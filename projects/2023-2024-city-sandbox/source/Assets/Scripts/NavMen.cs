using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMen : MonoBehaviour
{

    [SerializeField] Transform[] points;
    // Start is called before the first frame update
    void Start()
    {
        SetDest();
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<NavMeshAgent>().remainingDistance < 2.25f)
        {
            SetDest();
        }
    }

    public void SetDest()
    {

        GetComponent<NavMeshAgent>().SetDestination(points[Random.Range(0,points.Length)].position);
    }
    
}
