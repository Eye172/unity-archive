using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindForce : MonoBehaviour
{
    [SerializeField] Vector3 v3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.GetComponent<Rigidbody>() != null)
        {
            other.GetComponent<Rigidbody>().AddForce(v3, ForceMode.Impulse);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
