using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrokenDoors : MonoBehaviour
{
    [SerializeField] Rigidbody[] rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponentsInChildren<Rigidbody>();

        foreach (Rigidbody j in rb)
        { 
            j.isKinematic = true;
        }

        rb[Random.Range(0, rb.Length)].isKinematic = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
