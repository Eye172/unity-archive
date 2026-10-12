using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallPlatforms : MonoBehaviour
{
    [SerializeField] Rigidbody[] rb;
    void Start()
    {
        rb[Random.Range(0, rb.Length)].isKinematic = false;
    }
}