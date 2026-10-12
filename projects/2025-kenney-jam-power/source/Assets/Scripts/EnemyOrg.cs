using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyOrg : MonoBehaviour
{
    public int maxHealth = 3;
    private int currentHealth;

    public float damageToPlayer = 30f;
    private bool isDead = false;

    public Animator animator;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        if (isDead) return;

        currentHealth -= damage;

        if (animator != null)
        {
            animator.SetTrigger("Hurt");
        }

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        isDead = true;

        if (animator != null)
        {
            animator.SetTrigger("Die");
        }

        Destroy(gameObject, 2f);
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            EnergySystem energy = other.GetComponent<EnergySystem>();
            if (energy != null)
            {
                energy.DrainEnergy(damageToPlayer);
            }
        }
    }
}
