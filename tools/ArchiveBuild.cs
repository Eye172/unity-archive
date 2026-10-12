using System;
using System.Linq;
using System.IO;
using UnityEditor;
using UnityEditor.Build.Reporting;
using UnityEditor.SceneManagement;
using UnityEngine;
[InitializeOnLoad]
public class ArchiveBuild {
  static ArchiveBuild(){ EditorApplication.update += Poll; }
  static void Poll(){
    if(EditorApplication.isCompiling || EditorApplication.isUpdating) return;
    string request=Path.GetFullPath("archive-build-request.txt");
    if(!File.Exists(request)) return;
    string destination=File.ReadAllText(request).Trim(); File.Move(request,request+".consumed");
    Environment.SetEnvironmentVariable("ARCHIVE_OUTPUT",destination); Run();
  }
  public static void Run() {
    string root = Environment.GetEnvironmentVariable("ARCHIVE_OUTPUT");
    Directory.CreateDirectory(root);
    var scenes = EditorBuildSettings.scenes.Where(s=>s.enabled && File.Exists(s.path)).Select(s=>s.path).ToArray();
    if(scenes.Length==0) scenes=AssetDatabase.FindAssets("t:Scene",new[]{"Assets/Scenes"}).Select(AssetDatabase.GUIDToAssetPath).ToArray();
    File.WriteAllLines(Path.Combine(root,"scenes.txt"),scenes);
    File.WriteAllLines(Path.Combine(root,"dependencies.txt"),AssetDatabase.GetDependencies(scenes,true).OrderBy(x=>x));
    PlayerSettings.companyName="Eye172ArchivePreview";
    PlayerSettings.defaultScreenWidth=1280; PlayerSettings.defaultScreenHeight=720;
    PlayerSettings.fullScreenMode=FullScreenMode.Windowed;
    PlayerSettings.runInBackground=true;
    PlayerSettings.SetScriptingBackend(BuildTargetGroup.Standalone,ScriptingImplementation.Mono2x);
    EditorUserBuildSettings.SetBuildLocation(BuildTarget.StandaloneWindows64,Path.Combine(root,"Preview.exe"));
    var r=BuildPipeline.BuildPlayer(new BuildPlayerOptions{scenes=scenes,locationPathName=Path.Combine(root,"Preview.exe"),target=BuildTarget.StandaloneWindows64,options=BuildOptions.None});
    File.WriteAllText(Path.Combine(root,"build-result.json"),"{\"result\":\""+r.summary.result+"\",\"errors\":"+r.summary.totalErrors+",\"warnings\":"+r.summary.totalWarnings+"}");
    EditorApplication.Exit(r.summary.result==BuildResult.Succeeded?0:1);
  }
}
