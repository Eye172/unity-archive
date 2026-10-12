using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockerMenuScript : MonoBehaviour
{
    public GameObject g2;
    public GameObject g3;
    public GameObject g4;
    public GameObject g5;
    public GameObject g6;
    public GameObject g7;
    public GameObject g8;
    public GameObject g9;
    public GameObject g10;
    public GameObject g11;
    public GameObject g12;
    public GameObject g13;
    public GameObject g14;
    public GameObject g15;
    public GameObject k2;
    public GameObject k3;
    public GameObject k4;
    public GameObject k5;
    public GameObject k6;
    public GameObject k7;
    public GameObject k8;
    public GameObject k9;
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerPrefs.GetInt("pl_skin_N2") == 1)
        {
            g2.SetActive(false);
        }
        if(PlayerPrefs.GetInt("pl_skin_N3") == 1)
        {
            g3.SetActive(false);
        }
        if(PlayerPrefs.GetInt("pl_skin_N4") == 1)
        {
            g4.SetActive(false);
        }
        if(PlayerPrefs.GetInt("pl_skin_N5") == 1)
        {
            g5.SetActive(false);
        }
        if(PlayerPrefs.GetInt("pl_skin_N6") == 1)
        {
            g6.SetActive(false);
        }
        if(PlayerPrefs.GetInt("pl_skin_N7") == 1)
        {
            g7.SetActive(false);
        }
        if(PlayerPrefs.GetInt("pl_skin_N8") == 1)
        {
            g8.SetActive(false);
        }
        if(PlayerPrefs.GetInt("pl_skin_N9") == 1)
        {
            g9.SetActive(false);
        }
        if(PlayerPrefs.GetInt("pl_skin_N10") == 1)
        {
            g10.SetActive(false);
        }
        if(PlayerPrefs.GetInt("pl_skin_N11") == 1)
        {
            g11.SetActive(false);
        }
        if(PlayerPrefs.GetInt("pl_skin_N12") == 1)
        {
            g12.SetActive(false);
        }
        if(PlayerPrefs.GetInt("pl_skin_N13") == 1)
        {
            g13.SetActive(false);
        }
        if(PlayerPrefs.GetInt("pl_skin_N14") == 1)
        {
            g14.SetActive(false);
        }
        if(PlayerPrefs.GetInt("pl_skin_N15") == 1)
        {
            g15.SetActive(false);
        }
        if(PlayerPrefs.GetInt("pl_trail_N2") == 1)
        {
            k2.SetActive(false);
        }
        if(PlayerPrefs.GetInt("pl_trail_N3") == 1)
        {
            k3.SetActive(false);
        }
        if(PlayerPrefs.GetInt("pl_trail_N4") == 1)
        {
            k4.SetActive(false);
        }
        if(PlayerPrefs.GetInt("pl_trail_N5") == 1)
        {
            k5.SetActive(false);
        }
        if(PlayerPrefs.GetInt("pl_trail_N6") == 1)
        {
            k6.SetActive(false);
        }
        if(PlayerPrefs.GetInt("pl_trail_N7") == 1)
        {
            k7.SetActive(false);
        }
        if(PlayerPrefs.GetInt("pl_trail_N8") == 1)
        {
            k8.SetActive(false);
        }
        if(PlayerPrefs.GetInt("pl_trail_N9") == 1)
        {
            k9.SetActive(false);
        }


        
    }
    public void Skin1()
    {
        PlayerPrefs.SetInt("sk1", 1);
        PlayerPrefs.SetInt("sk2", 0);
        PlayerPrefs.SetInt("sk3", 0);
        PlayerPrefs.SetInt("sk4", 0);
        PlayerPrefs.SetInt("sk5", 0);
        PlayerPrefs.SetInt("sk6", 0);
        PlayerPrefs.SetInt("sk7", 0);
        PlayerPrefs.SetInt("sk8", 0);
        PlayerPrefs.SetInt("sk9", 0);
        PlayerPrefs.SetInt("sk10", 0);
        PlayerPrefs.SetInt("sk11", 0);
        PlayerPrefs.SetInt("sk12", 0);
        PlayerPrefs.SetInt("sk13", 0);
        PlayerPrefs.SetInt("sk14", 0);
        PlayerPrefs.SetInt("sk15", 0);
    }
    public void Skin2()
    {
        if(PlayerPrefs.GetInt("pl_skin_N2") == 1)
        {
            PlayerPrefs.SetInt("sk1", 0);
            PlayerPrefs.SetInt("sk2", 1);
            PlayerPrefs.SetInt("sk3", 0);
            PlayerPrefs.SetInt("sk4", 0);
            PlayerPrefs.SetInt("sk5", 0);
            PlayerPrefs.SetInt("sk6", 0);
            PlayerPrefs.SetInt("sk7", 0);
            PlayerPrefs.SetInt("sk8", 0);
            PlayerPrefs.SetInt("sk9", 0);
            PlayerPrefs.SetInt("sk10", 0);
            PlayerPrefs.SetInt("sk11", 0);
            PlayerPrefs.SetInt("sk12", 0);
            PlayerPrefs.SetInt("sk13", 0);
            PlayerPrefs.SetInt("sk14", 0);
            PlayerPrefs.SetInt("sk15", 0);
        }
    }
    public void Skin3()
    {
        if(PlayerPrefs.GetInt("pl_skin_N3") == 1)
        {
            PlayerPrefs.SetInt("sk1", 0);
            PlayerPrefs.SetInt("sk2", 0);
            PlayerPrefs.SetInt("sk3", 1);
            PlayerPrefs.SetInt("sk4", 0);
            PlayerPrefs.SetInt("sk5", 0);
            PlayerPrefs.SetInt("sk6", 0);
            PlayerPrefs.SetInt("sk7", 0);
            PlayerPrefs.SetInt("sk8", 0);
            PlayerPrefs.SetInt("sk9", 0);
            PlayerPrefs.SetInt("sk10", 0);
            PlayerPrefs.SetInt("sk11", 0);
            PlayerPrefs.SetInt("sk12", 0);
            PlayerPrefs.SetInt("sk13", 0);
            PlayerPrefs.SetInt("sk14", 0);
            PlayerPrefs.SetInt("sk15", 0);
        }
    }
    public void Skin4()
    {
        if(PlayerPrefs.GetInt("pl_skin_N4") == 1)
        {
            PlayerPrefs.SetInt("sk1", 0);
            PlayerPrefs.SetInt("sk2", 0);
            PlayerPrefs.SetInt("sk3", 0);
            PlayerPrefs.SetInt("sk4", 1);
            PlayerPrefs.SetInt("sk5", 0);
            PlayerPrefs.SetInt("sk6", 0);
            PlayerPrefs.SetInt("sk7", 0);
            PlayerPrefs.SetInt("sk8", 0);
            PlayerPrefs.SetInt("sk9", 0);
            PlayerPrefs.SetInt("sk10", 0);
            PlayerPrefs.SetInt("sk11", 0);
            PlayerPrefs.SetInt("sk12", 0);
            PlayerPrefs.SetInt("sk13", 0);
            PlayerPrefs.SetInt("sk14", 0);
            PlayerPrefs.SetInt("sk15", 0);
        }
    }
    public void Skin5()
    {
        if(PlayerPrefs.GetInt("pl_skin_N5") == 1)
        {
            PlayerPrefs.SetInt("sk1", 0);
            PlayerPrefs.SetInt("sk2", 0);
            PlayerPrefs.SetInt("sk3", 0);
            PlayerPrefs.SetInt("sk4", 0);
            PlayerPrefs.SetInt("sk5", 1);
            PlayerPrefs.SetInt("sk6", 0);
            PlayerPrefs.SetInt("sk7", 0);
            PlayerPrefs.SetInt("sk8", 0);
            PlayerPrefs.SetInt("sk9", 0);
            PlayerPrefs.SetInt("sk10", 0);
            PlayerPrefs.SetInt("sk11", 0);
            PlayerPrefs.SetInt("sk12", 0);
            PlayerPrefs.SetInt("sk13", 0);
            PlayerPrefs.SetInt("sk14", 0);
            PlayerPrefs.SetInt("sk15", 0);
        }
    }
    public void Skin6()
    {
        if(PlayerPrefs.GetInt("pl_skin_N6") == 1)
        {
            PlayerPrefs.SetInt("sk1", 0);
            PlayerPrefs.SetInt("sk2", 0);
            PlayerPrefs.SetInt("sk3", 0);
            PlayerPrefs.SetInt("sk4", 0);
            PlayerPrefs.SetInt("sk5", 0);
            PlayerPrefs.SetInt("sk6", 1);
            PlayerPrefs.SetInt("sk7", 0);
            PlayerPrefs.SetInt("sk8", 0);
            PlayerPrefs.SetInt("sk9", 0);
            PlayerPrefs.SetInt("sk10", 0);
            PlayerPrefs.SetInt("sk11", 0);
            PlayerPrefs.SetInt("sk12", 0);
            PlayerPrefs.SetInt("sk13", 0);
            PlayerPrefs.SetInt("sk14", 0);
            PlayerPrefs.SetInt("sk15", 0);
        }
    }
    public void Skin7()
    {
        if(PlayerPrefs.GetInt("pl_skin_N7") == 1)
        {
            PlayerPrefs.SetInt("sk1", 0);
            PlayerPrefs.SetInt("sk2", 0);
            PlayerPrefs.SetInt("sk3", 0);
            PlayerPrefs.SetInt("sk4", 0);
            PlayerPrefs.SetInt("sk5", 0);
            PlayerPrefs.SetInt("sk6", 0);
            PlayerPrefs.SetInt("sk7", 1);
            PlayerPrefs.SetInt("sk8", 0);
            PlayerPrefs.SetInt("sk9", 0);
            PlayerPrefs.SetInt("sk10", 0);
            PlayerPrefs.SetInt("sk11", 0);
            PlayerPrefs.SetInt("sk12", 0);
            PlayerPrefs.SetInt("sk13", 0);
            PlayerPrefs.SetInt("sk14", 0);
            PlayerPrefs.SetInt("sk15", 0);
        }
    }
    public void Skin8()
    {
        if(PlayerPrefs.GetInt("pl_skin_N8") == 1)
        {
            PlayerPrefs.SetInt("sk1", 0);
            PlayerPrefs.SetInt("sk2", 0);
            PlayerPrefs.SetInt("sk3", 0);
            PlayerPrefs.SetInt("sk4", 0);
            PlayerPrefs.SetInt("sk5", 0);
            PlayerPrefs.SetInt("sk6", 0);
            PlayerPrefs.SetInt("sk7", 0);
            PlayerPrefs.SetInt("sk8", 1);
            PlayerPrefs.SetInt("sk9", 0);
            PlayerPrefs.SetInt("sk10", 0);
            PlayerPrefs.SetInt("sk11", 0);
            PlayerPrefs.SetInt("sk12", 0);
            PlayerPrefs.SetInt("sk13", 0);
            PlayerPrefs.SetInt("sk14", 0);
            PlayerPrefs.SetInt("sk15", 0);
        }
    }
    public void Skin9()
    {
        if(PlayerPrefs.GetInt("pl_skin_N9") == 1)
        {
            PlayerPrefs.SetInt("sk1", 0);
            PlayerPrefs.SetInt("sk2", 0);
            PlayerPrefs.SetInt("sk3", 0);
            PlayerPrefs.SetInt("sk4", 0);
            PlayerPrefs.SetInt("sk5", 0);
            PlayerPrefs.SetInt("sk6", 0);
            PlayerPrefs.SetInt("sk7", 0);
            PlayerPrefs.SetInt("sk8", 0);
            PlayerPrefs.SetInt("sk9", 1);
            PlayerPrefs.SetInt("sk10", 0);
            PlayerPrefs.SetInt("sk11", 0);
            PlayerPrefs.SetInt("sk12", 0);
            PlayerPrefs.SetInt("sk13", 0);
            PlayerPrefs.SetInt("sk14", 0);
            PlayerPrefs.SetInt("sk15", 0);
        }
    }
    public void Skin10()
    {
        if(PlayerPrefs.GetInt("pl_skin_N10") == 1)
        {
            PlayerPrefs.SetInt("sk1", 0);
            PlayerPrefs.SetInt("sk2", 0);
            PlayerPrefs.SetInt("sk3", 0);
            PlayerPrefs.SetInt("sk4", 0);
            PlayerPrefs.SetInt("sk5", 0);
            PlayerPrefs.SetInt("sk6", 0);
            PlayerPrefs.SetInt("sk7", 0);
            PlayerPrefs.SetInt("sk8", 0);
            PlayerPrefs.SetInt("sk9", 0);
            PlayerPrefs.SetInt("sk10", 1);
            PlayerPrefs.SetInt("sk11", 0);
            PlayerPrefs.SetInt("sk12", 0);
            PlayerPrefs.SetInt("sk13", 0);
            PlayerPrefs.SetInt("sk14", 0);
            PlayerPrefs.SetInt("sk15", 0);
        }
    }
    public void Skin11()
    {
        if(PlayerPrefs.GetInt("pl_skin_N11") == 1)
        {
            PlayerPrefs.SetInt("sk1", 0);
            PlayerPrefs.SetInt("sk2", 0);
            PlayerPrefs.SetInt("sk3", 0);
            PlayerPrefs.SetInt("sk4", 0);
            PlayerPrefs.SetInt("sk5", 0);
            PlayerPrefs.SetInt("sk6", 0);
            PlayerPrefs.SetInt("sk7", 0);
            PlayerPrefs.SetInt("sk8", 0);
            PlayerPrefs.SetInt("sk9", 0);
            PlayerPrefs.SetInt("sk10", 0);
            PlayerPrefs.SetInt("sk11", 1);
            PlayerPrefs.SetInt("sk12", 0);
            PlayerPrefs.SetInt("sk13", 0);
            PlayerPrefs.SetInt("sk14", 0);
            PlayerPrefs.SetInt("sk15", 0);
        }
    }
    public void Skin12()
    {
        if(PlayerPrefs.GetInt("pl_skin_N12") == 1)
        {
            PlayerPrefs.SetInt("sk1", 0);
            PlayerPrefs.SetInt("sk2", 0);
            PlayerPrefs.SetInt("sk3", 0);
            PlayerPrefs.SetInt("sk4", 0);
            PlayerPrefs.SetInt("sk5", 0);
            PlayerPrefs.SetInt("sk6", 0);
            PlayerPrefs.SetInt("sk7", 0);
            PlayerPrefs.SetInt("sk8", 0);
            PlayerPrefs.SetInt("sk9", 0);
            PlayerPrefs.SetInt("sk10", 0);
            PlayerPrefs.SetInt("sk11", 0);
            PlayerPrefs.SetInt("sk12", 1);
            PlayerPrefs.SetInt("sk13", 0);
            PlayerPrefs.SetInt("sk14", 0);
            PlayerPrefs.SetInt("sk15", 0);
        }
    }
    public void Skin13()
    {
        if(PlayerPrefs.GetInt("pl_skin_N13") == 1)
        {
            PlayerPrefs.SetInt("sk1", 0);
            PlayerPrefs.SetInt("sk2", 0);
            PlayerPrefs.SetInt("sk3", 0);
            PlayerPrefs.SetInt("sk4", 0);
            PlayerPrefs.SetInt("sk5", 0);
            PlayerPrefs.SetInt("sk6", 0);
            PlayerPrefs.SetInt("sk7", 0);
            PlayerPrefs.SetInt("sk8", 0);
            PlayerPrefs.SetInt("sk9", 0);
            PlayerPrefs.SetInt("sk10", 0);
            PlayerPrefs.SetInt("sk11", 0);
            PlayerPrefs.SetInt("sk12", 0);
            PlayerPrefs.SetInt("sk13", 1);
            PlayerPrefs.SetInt("sk14", 0);
            PlayerPrefs.SetInt("sk15", 0);
        }
    }
    public void Skin14()
    {
        if(PlayerPrefs.GetInt("pl_skin_N14") == 1)
        {
            PlayerPrefs.SetInt("sk1", 0);
            PlayerPrefs.SetInt("sk2", 0);
            PlayerPrefs.SetInt("sk3", 0);
            PlayerPrefs.SetInt("sk4", 0);
            PlayerPrefs.SetInt("sk5", 0);
            PlayerPrefs.SetInt("sk6", 0);
            PlayerPrefs.SetInt("sk7", 0);
            PlayerPrefs.SetInt("sk8", 0);
            PlayerPrefs.SetInt("sk9", 0);
            PlayerPrefs.SetInt("sk10", 0);
            PlayerPrefs.SetInt("sk11", 0);
            PlayerPrefs.SetInt("sk12", 0);
            PlayerPrefs.SetInt("sk13", 0);
            PlayerPrefs.SetInt("sk14", 1);
            PlayerPrefs.SetInt("sk15", 0);
        }
    }
    public void Skin15()
    {
        if(PlayerPrefs.GetInt("pl_skin_N15") == 1)
        {
            PlayerPrefs.SetInt("sk1", 0);
            PlayerPrefs.SetInt("sk2", 0);
            PlayerPrefs.SetInt("sk3", 0);
            PlayerPrefs.SetInt("sk4", 0);
            PlayerPrefs.SetInt("sk5", 0);
            PlayerPrefs.SetInt("sk6", 0);
            PlayerPrefs.SetInt("sk7", 0);
            PlayerPrefs.SetInt("sk8", 0);
            PlayerPrefs.SetInt("sk9", 0);
            PlayerPrefs.SetInt("sk10", 0);
            PlayerPrefs.SetInt("sk11", 0);
            PlayerPrefs.SetInt("sk12", 0);
            PlayerPrefs.SetInt("sk13", 0);
            PlayerPrefs.SetInt("sk14", 0);
            PlayerPrefs.SetInt("sk15", 1);
        }
    }
    public void Trail1()
    {
            PlayerPrefs.SetInt("tr1", 1);
            PlayerPrefs.SetInt("tr2", 0);
            PlayerPrefs.SetInt("tr3", 0);
            PlayerPrefs.SetInt("tr4", 0);
            PlayerPrefs.SetInt("tr5", 0);
            PlayerPrefs.SetInt("tr6", 0);
            PlayerPrefs.SetInt("tr7", 0);
            PlayerPrefs.SetInt("tr8", 0);
            PlayerPrefs.SetInt("tr9", 0);
    }
    public void Trail2()
    {
        if(PlayerPrefs.GetInt("pl_trail_N2") == 1)
        {
            PlayerPrefs.SetInt("tr1", 0);
            PlayerPrefs.SetInt("tr2", 1);
            PlayerPrefs.SetInt("tr3", 0);
            PlayerPrefs.SetInt("tr4", 0);
            PlayerPrefs.SetInt("tr5", 0);
            PlayerPrefs.SetInt("tr6", 0);
            PlayerPrefs.SetInt("tr7", 0);
            PlayerPrefs.SetInt("tr8", 0);
            PlayerPrefs.SetInt("tr9", 0);
        }
    }
    public void Trail3()
    {
        if(PlayerPrefs.GetInt("pl_trail_N3") == 1)
        {
            PlayerPrefs.SetInt("tr1", 0);
            PlayerPrefs.SetInt("tr2", 0);
            PlayerPrefs.SetInt("tr3", 1);
            PlayerPrefs.SetInt("tr4", 0);
            PlayerPrefs.SetInt("tr5", 0);
            PlayerPrefs.SetInt("tr6", 0);
            PlayerPrefs.SetInt("tr7", 0);
            PlayerPrefs.SetInt("tr8", 0);
            PlayerPrefs.SetInt("tr9", 0);
        }
    }
    public void Trail4()
    {
        if(PlayerPrefs.GetInt("pl_trail_N4") == 1)
        {
            PlayerPrefs.SetInt("tr1", 0);
            PlayerPrefs.SetInt("tr2", 0);
            PlayerPrefs.SetInt("tr3", 0);
            PlayerPrefs.SetInt("tr4", 1);
            PlayerPrefs.SetInt("tr5", 0);
            PlayerPrefs.SetInt("tr6", 0);
            PlayerPrefs.SetInt("tr7", 0);
            PlayerPrefs.SetInt("tr8", 0);
            PlayerPrefs.SetInt("tr9", 0);
        }
    }
    public void Trail5()
    {
        if(PlayerPrefs.GetInt("pl_trail_N5") == 1)
        {
            PlayerPrefs.SetInt("tr1", 0);
            PlayerPrefs.SetInt("tr2", 0);
            PlayerPrefs.SetInt("tr3", 0);
            PlayerPrefs.SetInt("tr4", 0);
            PlayerPrefs.SetInt("tr5", 1);
            PlayerPrefs.SetInt("tr6", 0);
            PlayerPrefs.SetInt("tr7", 0);
            PlayerPrefs.SetInt("tr8", 0);
            PlayerPrefs.SetInt("tr9", 0);
        }
    }
    public void Trail6()
    {
        if(PlayerPrefs.GetInt("pl_trail_N6") == 1)
        {
            PlayerPrefs.SetInt("tr1", 0);
            PlayerPrefs.SetInt("tr2", 0);
            PlayerPrefs.SetInt("tr3", 0);
            PlayerPrefs.SetInt("tr4", 0);
            PlayerPrefs.SetInt("tr5", 0);
            PlayerPrefs.SetInt("tr6", 1);
            PlayerPrefs.SetInt("tr7", 0);
            PlayerPrefs.SetInt("tr8", 0);
            PlayerPrefs.SetInt("tr9", 0);
        }
    }
    public void Trail7()
    {
        if(PlayerPrefs.GetInt("pl_trail_N7") == 1)
        {
            PlayerPrefs.SetInt("tr1", 0);
            PlayerPrefs.SetInt("tr2", 0);
            PlayerPrefs.SetInt("tr3", 0);
            PlayerPrefs.SetInt("tr4", 0);
            PlayerPrefs.SetInt("tr5", 0);
            PlayerPrefs.SetInt("tr6", 0);
            PlayerPrefs.SetInt("tr7", 1);
            PlayerPrefs.SetInt("tr8", 0);
            PlayerPrefs.SetInt("tr9", 0);
        }
    }
    public void Trail8()
    {
        if(PlayerPrefs.GetInt("pl_trail_N8") == 1)
        {
            PlayerPrefs.SetInt("tr1", 0);
            PlayerPrefs.SetInt("tr2", 0);
            PlayerPrefs.SetInt("tr3", 0);
            PlayerPrefs.SetInt("tr4", 0);
            PlayerPrefs.SetInt("tr5", 0);
            PlayerPrefs.SetInt("tr6", 0);
            PlayerPrefs.SetInt("tr7", 0);
            PlayerPrefs.SetInt("tr8", 1);
            PlayerPrefs.SetInt("tr9", 0);
        }
    }
    public void Trail9()
    {
        if(PlayerPrefs.GetInt("pl_trail_N9") == 1)
        {
            PlayerPrefs.SetInt("tr1", 0);
            PlayerPrefs.SetInt("tr2", 0);
            PlayerPrefs.SetInt("tr3", 0);
            PlayerPrefs.SetInt("tr4", 0);
            PlayerPrefs.SetInt("tr5", 0);
            PlayerPrefs.SetInt("tr6", 0);
            PlayerPrefs.SetInt("tr7", 0);
            PlayerPrefs.SetInt("tr8", 0);
            PlayerPrefs.SetInt("tr9", 1);
        }
    }
    
}
