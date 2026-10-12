using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables_ : MonoBehaviour
{
    public int pl_gems;
    public int pl_skin_N2;
    public int pl_skin_N3;
    public int pl_skin_N4;
    public int pl_skin_N5;
    public int pl_skin_N6;
    public int pl_skin_N7;
    public int pl_skin_N8;
    public int pl_skin_N9;
    public int pl_skin_N10;
    public int pl_skin_N11;
    public int pl_skin_N12;
    public int pl_skin_N13;
    public int pl_skin_N14;
    public int pl_skin_N15;
    public int pl_trail_N1;
    public int pl_trail_N2;
    public int pl_trail_N3;
    public int pl_trail_N4;
    public int pl_trail_N5;
    public int pl_trail_N6;
    public int pl_trail_N7;
    public int pl_trail_N8;
    public int pl_trail_N9;
    public int lv1;
    public int lv2;
    public int lv3;
    public int lv4;
    public int lv5;
    public int lv6;
    public int lv7;
    public int lv8;
    public int lv9;
    public int lv10;
    public int lv11;
    public int lv12;
    public int lv13;
    public int lv14;
    public int lv15;
    public int lv16;
    public int lv17;
    public int lv18;
    public int lv19;
    public int lv20;
    public int lv21;
    public int lv22;
    public int lv23;
    public int lv24;
    public int sk1;
    public int sk2;
    public int sk3;
    public int sk4;
    public int sk5;
    public int sk6;
    public int sk7;
    public int sk8;
    public int sk9;
    public int sk10;
    public int sk11;
    public int sk12;
    public int sk13;
    public int sk14;
    public int sk15;
    public int tr1;
    public int tr2;
    public int tr3;
    public int tr4;
    public int tr5;
    public int tr6;
    public int tr7;
    public int tr8;
    public int tr9;
    public int IsIt2;

    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetInt("First") == 0)
        {
            PlayerPrefs.SetInt("First", 1);
            PlayerPrefs.SetInt("pl_gems", pl_gems);
            PlayerPrefs.SetInt("pl_skin_N2", pl_skin_N2);
            PlayerPrefs.SetInt("pl_skin_N3", pl_skin_N3);
            PlayerPrefs.SetInt("pl_skin_N4", pl_skin_N4);
            PlayerPrefs.SetInt("pl_skin_N5", pl_skin_N5);
            PlayerPrefs.SetInt("pl_skin_N6", pl_skin_N6);
            PlayerPrefs.SetInt("pl_skin_N7", pl_skin_N7);
            PlayerPrefs.SetInt("pl_skin_N8", pl_skin_N8);
            PlayerPrefs.SetInt("pl_skin_N9", pl_skin_N9);
            PlayerPrefs.SetInt("pl_skin_N10", pl_skin_N10);
            PlayerPrefs.SetInt("pl_skin_N11", pl_skin_N11);
            PlayerPrefs.SetInt("pl_skin_N12", pl_skin_N12);
            PlayerPrefs.SetInt("pl_skin_N13", pl_skin_N13);
            PlayerPrefs.SetInt("pl_skin_N14", pl_skin_N14);
            PlayerPrefs.SetInt("pl_skin_N15", pl_skin_N15);
            PlayerPrefs.SetInt("pl_trail_N2", pl_trail_N2);
            PlayerPrefs.SetInt("pl_trail_N3", pl_trail_N3);
            PlayerPrefs.SetInt("pl_trail_N4", pl_trail_N4);
            PlayerPrefs.SetInt("pl_trail_N5", pl_trail_N5);
            PlayerPrefs.SetInt("pl_trail_N6", pl_trail_N6);
            PlayerPrefs.SetInt("pl_trail_N7", pl_trail_N7);
            PlayerPrefs.SetInt("pl_trail_N8", pl_trail_N8);
            PlayerPrefs.SetInt("pl_trail_N9", pl_trail_N9);
            PlayerPrefs.SetInt("sk1", sk1);
            PlayerPrefs.SetInt("sk2", sk2);
            PlayerPrefs.SetInt("sk3", sk3);
            PlayerPrefs.SetInt("sk4", sk4);
            PlayerPrefs.SetInt("sk5", sk5);
            PlayerPrefs.SetInt("sk6", sk6);
            PlayerPrefs.SetInt("sk7", sk7);
            PlayerPrefs.SetInt("sk8", sk8);
            PlayerPrefs.SetInt("sk9", sk9);
            PlayerPrefs.SetInt("sk10", sk10);
            PlayerPrefs.SetInt("sk11", sk11);
            PlayerPrefs.SetInt("sk12", sk12);
            PlayerPrefs.SetInt("sk13", sk13);
            PlayerPrefs.SetInt("sk14", sk14);
            PlayerPrefs.SetInt("sk15", sk15);
            PlayerPrefs.SetInt("tr1", tr1);
            PlayerPrefs.SetInt("tr2", tr2);
            PlayerPrefs.SetInt("tr3", tr3);
            PlayerPrefs.SetInt("tr4", tr4);
            PlayerPrefs.SetInt("tr5", tr5);
            PlayerPrefs.SetInt("tr6", tr6);
            PlayerPrefs.SetInt("tr7", tr7);
            PlayerPrefs.SetInt("tr8", tr8);
            PlayerPrefs.SetInt("tr9", tr9);
            PlayerPrefs.SetInt("lv1", lv1);
            PlayerPrefs.SetInt("lv2", lv2);
            PlayerPrefs.SetInt("lv3", lv3);
            PlayerPrefs.SetInt("lv4", lv4);
            PlayerPrefs.SetInt("lv5", lv5);
            PlayerPrefs.SetInt("lv6", lv6);
            PlayerPrefs.SetInt("lv7", lv7);
            PlayerPrefs.SetInt("lv8", lv8);
            PlayerPrefs.SetInt("lv9", lv9);
            PlayerPrefs.SetInt("lv10", lv10);
            PlayerPrefs.SetInt("lv11", lv11);
            PlayerPrefs.SetInt("lv12", lv12);
            PlayerPrefs.SetInt("lv13", lv13);
            PlayerPrefs.SetInt("lv14", lv14);
            PlayerPrefs.SetInt("lv15", lv15);
            PlayerPrefs.SetInt("lv16", lv16);
            PlayerPrefs.SetInt("lv17", lv17);
            PlayerPrefs.SetInt("lv18", lv18);
            PlayerPrefs.SetInt("lv19", lv19);
            PlayerPrefs.SetInt("lv20", lv20);
            PlayerPrefs.SetInt("lv21", lv21);
            PlayerPrefs.SetInt("lv22", lv22);
            PlayerPrefs.SetInt("lv23", lv23);
            PlayerPrefs.SetInt("lv24", lv24);
            PlayerPrefs.SetInt("IsIt2", IsIt2);
            PlayerPrefs.Save();
        }

    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
