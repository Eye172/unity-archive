using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrel_scr : MonoBehaviour
{
    [SerializeField] float radius = 10;
    [SerializeField] GameObject prefab;
    public void Boom()
    {
        Destroy(Instantiate(prefab, transform.position, Quaternion.identity), 1);
        PlayerController player = FindObjectOfType<PlayerController>();
        if (Vector3.Distance(transform.position, player.transform.position) < radius)
        {
            player.ChangeHealth(-80);
        }
        //
        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);
        
        for (int i = 0; i < colliders.Length; i++)
        {
            Rigidbody rb = colliders[i].attachedRigidbody;
            if (rb)
            {
                if (rb.tag == "enemy_ragdoll")
                {
                    rb.transform.root.GetComponent<Ragdoll>().Death_Fall(true);
                }
                rb.AddExplosionForce(10000, transform.position, radius);
            }
        }
        Destroy(gameObject);
    }

}
