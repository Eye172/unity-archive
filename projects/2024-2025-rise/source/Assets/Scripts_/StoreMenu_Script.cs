using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreMenu_Script : MonoBehaviour
{
    public SpriteRenderer sprend;
    public GameObject csk;
    public GameObject ctr;
    public GameObject p2;
    public GameObject p3;
    public GameObject p4;
    public GameObject p5;
    public GameObject p6;
    public GameObject p7;
    public GameObject p8;
    public GameObject p9;
    public GameObject p10;
    public GameObject p11;
    public GameObject p12;
    public GameObject p13;
    public GameObject p14;
    public GameObject p15;
    public GameObject r2;
    public GameObject r3;
    public GameObject r4;
    public GameObject r5;
    public GameObject r6;
    public GameObject r7;
    public GameObject r8;
    public GameObject r9;

    int n;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NewSkin()
    {
        if(PlayerPrefs.GetInt("pl_gems") >= 50)
        {
            p2.SetActive(false);
            p3.SetActive(false);
            p4.SetActive(false);
            p5.SetActive(false);
            p6.SetActive(false);
            p7.SetActive(false);
            p8.SetActive(false);
            p9.SetActive(false);
            p10.SetActive(false);
            p11.SetActive(false);
            p12.SetActive(false);
            p13.SetActive(false);
            p14.SetActive(false);
            p15.SetActive(false);
            PlayerPrefs.SetInt("pl_gems", PlayerPrefs.GetInt("pl_gems") - 50);
            n = Random.Range(2,16);
            if(n == 2)
            {
                PlayerPrefs.SetInt("pl_skin_N2", 1);
                p2.SetActive(true);
            }
            if(n == 3)
            {
                PlayerPrefs.SetInt("pl_skin_N3", 1);
                p3.SetActive(true);
            }
            if(n == 4)
            {
                PlayerPrefs.SetInt("pl_skin_N4", 1);
                p4.SetActive(true);
            }
            if(n == 5)
            {
                PlayerPrefs.SetInt("pl_skin_N5", 1);
                p5.SetActive(true);
            }
            if(n == 6)
            {
                PlayerPrefs.SetInt("pl_skin_N6", 1);
                p6.SetActive(true);
            }
            if(n == 7)
            {
                PlayerPrefs.SetInt("pl_skin_N7", 1);
                p7.SetActive(true);
            }
            if(n == 8)
            {
                PlayerPrefs.SetInt("pl_skin_N8", 1);
                p8.SetActive(true);
            }
            if(n == 9)
            {
                PlayerPrefs.SetInt("pl_skin_N9", 1);
                p9.SetActive(true);
            }
            if(n == 10)
            {
                PlayerPrefs.SetInt("pl_skin_N10", 1);
                p10.SetActive(true);
            }
            if(n == 11)
            {
                PlayerPrefs.SetInt("pl_skin_N11", 1);
                p11.SetActive(true);
            }
            if(n == 12)
            {
                PlayerPrefs.SetInt("pl_skin_N2", 1);
                p12.SetActive(true);
            }
            if(n == 13)
            {
                PlayerPrefs.SetInt("pl_skin_N13", 1);
                p13.SetActive(true);
            }
            if(n == 14)
            {
                PlayerPrefs.SetInt("pl_skin_N14", 1);
                p14.SetActive(true);
            }
            if(n == 15)
            {
                PlayerPrefs.SetInt("pl_skin_N15", 1);
                p15.SetActive(true);
            }
            csk.SetActive(true);
        }
        
    }
    public void Ok()
    {
        csk.SetActive(false);
        ctr.SetActive(false);
    }

    public void NewTrail()
    {
        if(PlayerPrefs.GetInt("pl_gems") >= 100)
        {
            r2.SetActive(false);
            r3.SetActive(false);
            r4.SetActive(false);
            r5.SetActive(false);
            r6.SetActive(false);
            r7.SetActive(false);
            r8.SetActive(false);
            r9.SetActive(false);
            PlayerPrefs.SetInt("pl_gems", PlayerPrefs.GetInt("pl_gems") - 100);
            n = Random.Range(2,10);
            if(n == 2)
            {
                PlayerPrefs.SetInt("pl_trail_N2", 1);
                r2.SetActive(true);
            }
            if(n == 3)
            {
                PlayerPrefs.SetInt("pl_trail_N3", 1);
                r3.SetActive(true);
            }
            if(n == 4)
            {
                PlayerPrefs.SetInt("pl_trail_N4", 1);
                r4.SetActive(true);
            }
            if(n == 5)
            {
                PlayerPrefs.SetInt("pl_trail_N5", 1);
                r5.SetActive(true);
            }
            if(n == 6)
            {
                PlayerPrefs.SetInt("pl_trail_N6", 1);
                r6.SetActive(true);
            }
            if(n == 7)
            {
                PlayerPrefs.SetInt("pl_trail_N7", 1);
                r7.SetActive(true);
            }
            if(n == 8)
            {
                PlayerPrefs.SetInt("pl_trail_N8", 1);
                r8.SetActive(true);
            }
            if(n == 9)
            {
                PlayerPrefs.SetInt("pl_trail_N9", 1);
                r9.SetActive(true);
            }
            ctr.SetActive(true);
        }
        
    }
    public void BuySword()
    {
        if(PlayerPrefs.GetInt("IsIt2") == 0) 
        {
            PlayerPrefs.SetInt("pl_gems", PlayerPrefs.GetInt("pl_gems") - 30);
            PlayerPrefs.SetInt("IsIt2", 1);
        }
    }
    public void GreatAd()
    {
        PlayerPrefs.SetInt("pl_gems", PlayerPrefs.GetInt("pl_gems") + 100);
    }
    
}
