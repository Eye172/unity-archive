using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem_Script_ : Variables_
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            PlayerPrefs.SetInt("pl_gems", PlayerPrefs.GetInt("pl_gems") + 1);
            PlayerPrefs.Save();
            Destroy(gameObject);
        }
    }
}
