using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyOrgAI : MonoBehaviour
{
    public enum EnemyState { Idle, Patrol, Chasing }

    public EnemyState currentState = EnemyState.Idle;

    public Transform[] patrolPoints;
    private int currentPatrolIndex = 0;

    public float patrolSpeed = 3f;
    public float chaseSpeed = 4.5f;

    public float stoppingDistance = 2f;
    public float chaseTimeout = 4f;

    private Transform player;
    private bool playerInRange = false;

    public Animator animator;

    private Rigidbody rb;

    private Coroutine chaseTimeoutCoroutine;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        if (currentState == EnemyState.Patrol && patrolPoints.Length == 0)
        {
            Debug.LogWarning("Patrol state set but no patrol points assigned!");
            currentState = EnemyState.Idle;
        }
    }

    void Update()
    {
        switch (currentState)
        {
            case EnemyState.Idle:
                IdleBehavior();
                break;
            case EnemyState.Patrol:
                PatrolBehavior();
                break;
            case EnemyState.Chasing:
                ChaseBehavior();
                break;
        }
    }

    void IdleBehavior()
    {
        animator.SetBool("isMoving", false);
        if (playerInRange)
        {
            StartChase();
        }
    }
    void PatrolBehavior()
    {
        if (patrolPoints.Length == 0) return;

        Transform targetPoint = patrolPoints[currentPatrolIndex];
        MoveTowards(targetPoint.position, patrolSpeed);

        if (Vector3.Distance(transform.position, targetPoint.position) < 0.5f)
        {
            currentPatrolIndex = (currentPatrolIndex + 1) % patrolPoints.Length;
        }

        if (playerInRange)
        {
            StartChase();
        }
    }
    void ChaseBehavior()
    {
        if (player == null) return;

        float dist = Vector3.Distance(transform.position, player.position);

        if (dist > stoppingDistance)
        {
            MoveTowards(player.position, chaseSpeed);
        }
        else
        {
            animator.SetBool("isMoving", false);
        }
    }

    void MoveTowards(Vector3 target, float speed)
    {
        Vector3 direction = (target - transform.position).normalized;
        direction.y = 0;  // Игнорируем движение по оси Y, чтобы враг двигался только по X и Z.

        Vector3 move = direction * speed * Time.deltaTime;
        rb.MovePosition(transform.position + move);

        if (move != Vector3.zero)
        {
            // Поворачиваем врага в нужную сторону в зависимости от движения по оси X.
            if (move.x > 0)
            {
                transform.localScale = new Vector3(1, 1, 1);
            }
            else if (move.x < 0)
            {
                transform.localScale = new Vector3(-1, 1, 1);
            }

            animator.SetBool("isMoving", true);
        }
    }


    void StartChase()
    {
        currentState = EnemyState.Chasing;
        if (chaseTimeoutCoroutine != null)
        {
            StopCoroutine(chaseTimeoutCoroutine);
        }
    }

    void StopChase()
    {
        if (currentState == EnemyState.Chasing)
        {
            currentState = patrolPoints.Length > 0 ? EnemyState.Patrol : EnemyState.Idle;
            animator.SetBool("isMoving", true);
        }
    }

    public void PlayerEntered(Transform playerTransform)
    {
        player = playerTransform;
        playerInRange = true;
        StartChase();
    }

    public void PlayerExited()
    {
        playerInRange = false;
        if (chaseTimeoutCoroutine != null)
        {
            StopCoroutine(chaseTimeoutCoroutine);
        }
        chaseTimeoutCoroutine = StartCoroutine(ChaseTimeoutRoutine());
    }

    private IEnumerator ChaseTimeoutRoutine()
    {
        yield return new WaitForSeconds(chaseTimeout);
        if (!playerInRange)
        {
            StopChase();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerEntered(other.transform);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerExited();
        }
    }
}
