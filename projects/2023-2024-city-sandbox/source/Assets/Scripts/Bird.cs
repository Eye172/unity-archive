using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
  
    Rigidbody rb;
    [SerializeField] float airResistance; // сопротивление воздуху
    [SerializeField] float deploymentHeight; //высота раскрытия парашюта
    bool deployed; // сработал ли парашют
    // Start is called before the first frame update
    void Start()
    {
     
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit; //объект, в который попал луч
        Ray ray = new Ray(transform.position, Vector3.down);
        rb.AddForce(Vector3.forward * 0.0001f, ForceMode.Impulse);
        Debug.DrawRay(transform.position, -transform.up * deploymentHeight, Color.red);
        if (!deployed)
        {
            if (Physics.Raycast(ray, out hit, deploymentHeight))
            {
                if (hit.transform.tag != "water")
                {

                    rb.AddForce(Vector3.up*4f, ForceMode.Impulse);
                   

                }
            }
        
        }
    }
}