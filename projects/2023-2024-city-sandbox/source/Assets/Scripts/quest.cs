using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quest : MonoBehaviour
{
    public int skolko_noozhno;
    public string tag;
    // Start is called before the first frame update
    public void GetQuest()
    {
        if (FindObjectOfType<spisok_zadaniy>().tag == tag)
        {
            if (FindObjectOfType<spisok_zadaniy>().skolko_sobral >= skolko_noozhno)
            {
                FindObjectOfType<PlayerController>().ChangeMoney(1000);
            }
        }
        else
        {
            FindObjectOfType<spisok_zadaniy>().tag = tag;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
