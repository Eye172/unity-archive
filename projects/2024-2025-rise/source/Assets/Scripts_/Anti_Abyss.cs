using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anti_Abyss : MonoBehaviour
{
    [SerializeField] Transform pl;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(pl.position.y < -1)
        {
            transform.position = new Vector2(0.5f, 1.5f);
            rb.velocity = new Vector2(0f, 0f);
        }
    }
}
