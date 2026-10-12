using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove2 : MonoBehaviour
{
    [SerializeField] Transform pl;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position - Vector3.forward * 7 + Vector3.up * 0.04f, pl.position - Vector3.forward * 7  + Vector3.up * 0.02f, 0.01f);
    }
}
