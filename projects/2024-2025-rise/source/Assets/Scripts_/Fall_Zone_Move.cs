using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall_Zone_Move : MonoBehaviour
{
    [SerializeField] Transform pl;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(pl.position.x, -15f);
    }
}
