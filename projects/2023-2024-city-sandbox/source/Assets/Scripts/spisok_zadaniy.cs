using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spisok_zadaniy : MonoBehaviour
{
    public int skolko_sobral;
    public string tag;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.tag == tag)
        {
            skolko_sobral++;
            Destroy(collision.gameObject);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
