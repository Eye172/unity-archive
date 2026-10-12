using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    [SerializeField] GameObject Audio1;    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D qwe)
    {
        if(qwe.tag == "Player")
        {
            Audio1.SetActive(true);
        }
    }
}
