using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ragdoll : MonoBehaviour
{
    Rigidbody[] childrenRb;
    Animator anim;
    public GameObject enemy;

    // Start is called before the first frame update

    // Update is called once per frame
    public void Death_Fall(bool gravity)
    {
        foreach( var i in childrenRb)
        {
            i.isKinematic = false;
            i.useGravity = gravity;
        }
        anim.enabled = false; 

    }
   
    void Start()
    {        
        anim = GetComponent<Animator>();
        childrenRb = GetComponentsInChildren<Rigidbody>();
        foreach (Rigidbody rb in childrenRb)
        {
            rb.isKinematic = true;
            rb.tag = "enemy_ragdoll";
        }
    }
    public void OffTelekinesis()
    {       
        foreach (Rigidbody rb in childrenRb)
        {            
            rb.useGravity = true;
        }
    }
}
