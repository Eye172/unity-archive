using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Batoot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        GetComponent<Rigidbody>().AddForce(Vector3.up * 30, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
