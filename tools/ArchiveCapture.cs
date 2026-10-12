using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.IO;
using System.Collections;
// Restoration-only capture helper. Not part of the historical game source.
public class ArchiveCapture : MonoBehaviour {
  string folder; bool recording; int frame; float until; float next;
  [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
  static void Boot(){ var go=new GameObject("Archive capture helper (2026)"); DontDestroyOnLoad(go); go.AddComponent<ArchiveCapture>(); }
  IEnumerator Start(){
    folder=Environment.GetEnvironmentVariable("ARCHIVE_CAPTURE");
    if(string.IsNullOrEmpty(folder)) folder=Path.Combine(Application.dataPath,"../captures");
    Directory.CreateDirectory(folder); Application.targetFrameRate=60;
    yield return new WaitForSeconds(3);
    string scene=Environment.GetEnvironmentVariable("ARCHIVE_SCENE");
    if(!string.IsNullOrEmpty(scene)) { SceneManager.LoadScene(scene); yield return new WaitForSeconds(3); }
    ScreenCapture.CaptureScreenshot(Path.Combine(folder,"startup.png"));
    File.WriteAllText(Path.Combine(folder,"capture-info.txt"),"Actual Unity runtime capture\nUTC: "+DateTime.UtcNow.ToString("o")+"\nScene: "+SceneManager.GetActiveScene().path+"\nResolution: "+Screen.width+"x"+Screen.height+"\n");
    if(Environment.GetEnvironmentVariable("ARCHIVE_RECORD")=="1"){recording=true;until=Time.unscaledTime+25;}
  }
  void Update(){
    if(Input.GetKeyDown(KeyCode.F8)) ScreenCapture.CaptureScreenshot(Path.Combine(folder,"shot-"+DateTime.Now.ToString("HHmmssfff")+".png"));
    if(Input.GetKeyDown(KeyCode.F9)){ recording=!recording; until=Time.unscaledTime+25; next=0; }
    if(recording && Time.unscaledTime<until && Time.unscaledTime>=next){ next=Time.unscaledTime+0.1f; string name="frame-"+(frame++).ToString("D5")+".png"; ScreenCapture.CaptureScreenshot(Path.Combine(folder,name)); File.AppendAllText(Path.Combine(folder,"frames.csv"),name+","+Time.unscaledTime.ToString("R",System.Globalization.CultureInfo.InvariantCulture)+"\n"); }
    if(Time.unscaledTime>=until) recording=false;
  }
}
