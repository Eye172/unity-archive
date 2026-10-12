using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavigationAI : MonoBehaviour
{
    protected NavMeshAgent agent;//
    protected Animator anim;
    [SerializeField]
    List<Transform> points = new List<Transform>();
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        SetDestination();
    }
    virtual protected void Update()
    {
        if (agent.remainingDistance < 2.25f)
        {
            StartCoroutine("Idle");
        }
    }

    public void SetDestination()
    {
        Vector3 newTarget = points[Random.Range(0, points.Count)].position;
        agent.SetDestination(newTarget);
    }

    IEnumerator Idle()
    {
        agent.speed = 0;
        SetDestination();
        anim.SetBool("idle", true);
        yield return new WaitForSeconds(5);
        agent.speed = 3.5f;
        anim.SetBool("idle", false);

    }
}
 
