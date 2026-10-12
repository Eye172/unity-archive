using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_Object : MonoBehaviour
{
    [SerializeField] GameObject barrier1;
    [SerializeField] GameObject barrier2;
    [SerializeField] float speed = 12f;
    bool dir_1;
    bool dir_2;
    
    // Start is called before the first frame update
    void Start()
    {
        dir_2 = true;
        dir_1 = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(transform.position == barrier1.transform.position)
        {
            dir_1 = false;
            dir_2 = true;
        }
        if(transform.position == barrier2.transform.position)
        {
            dir_1 = true;
            dir_2 = false;
        }
        if(dir_1)
        {
            transform.position = Vector2.MoveTowards(transform.position, barrier1.transform.position, speed * Time.deltaTime);
        }
        if(dir_2)
        {
            transform.position = Vector2.MoveTowards(transform.position, barrier2.transform.position, speed * Time.deltaTime);
        }
        
    }
}
