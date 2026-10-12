using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSword : MonoBehaviour
{   // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D tcsks)
    {
        if (tcsks.tag == "Enemy")
        {
            tcsks.GetComponent<Enemy1>().Damage(30);
        }
        if (tcsks.tag == "Wall")
        {
            Destroy(tcsks.gameObject);
        }
    }
}
