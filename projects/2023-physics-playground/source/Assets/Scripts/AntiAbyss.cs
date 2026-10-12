using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntiAbyss : MonoBehaviour
{
    Vector3 start_position;
    // Start is called before the first frame update
    void Start()
    {
        start_position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -50)
        {
            transform.position = start_position;
        }
        if(transform.position.z >= 160 )
        {
            start_position.z = 167;
        }
    }
}
