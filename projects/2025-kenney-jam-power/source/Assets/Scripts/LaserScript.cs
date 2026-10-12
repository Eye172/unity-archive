using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserScript : MonoBehaviour
{
    public int damage = 1;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Skip"))
        {

        }
        else
        {
            if (other.CompareTag("EnemyOrg"))
            {
                EnemyOrg enemy = other.GetComponent<EnemyOrg>();
                if (enemy != null)
                {
                    enemy.TakeDamage(damage);
                }
            }
            else if (other.CompareTag("EnemyMech"))
            {
                //EnemyMech enemyMech = other.GetComponent<EnemyMech>();
                //if (enemyMech != null)
                //{
                    //enemyMech.AbsorbEnergy(damage);
                //}
            }
            Destroy(gameObject);
        }
    }
}

