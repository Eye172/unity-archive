using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Enemy1 : MonoBehaviour
{
    [SerializeField] int EnViewDistance = 20000000;
    [SerializeField] int EnAttackRange = 3;
    [SerializeField] int EnSpeed = 5;
    [SerializeField] int EnDamage = 20;
    [SerializeField] int EnHealth = 100;
    [SerializeField] GameObject EnTarget;
    Animator anima;
    Rigidbody2D rb;
    bool sideTF;
    bool kill;
    // Start is called before the first frame update
    void Start()
    {
        anima = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D cldr)
    {
        if (cldr.tag == "Player")
        {
            kill = true;
        }
    }
    void Update()
    {
        
        if(EnHealth <= 0)
        {
            anima.SetBool("death", true);
        }
        if(kill)
        {
            anima.SetBool("walk", true);
            transform.position = Vector3.MoveTowards(transform.position, EnTarget.transform.position, EnSpeed * Time.deltaTime * 0.2f);
        }
        if (Vector3.Distance(transform.position, EnTarget.transform.position) <= EnAttackRange)
        {
            EnAttack();
        }
        if (rb.velocity.x < 0)
        {
             transform.rotation = Quaternion.Euler (new Vector3 (0, 0, 0));

        }
        else if (rb.velocity.x > 0)
        {
             transform.rotation = Quaternion.Euler (new Vector3 (0, 180f, 0));
        }
    }
    public void EnDeath()
    {
        Destroy(gameObject);
        EnTarget.GetComponent<PlayerMove1>().ChangeSouls(100);
    }
    public void EnAttack()
    {
        anima.SetTrigger("attack");
    }
    public void Damage(int count)
    {
        EnHealth = EnHealth - count;
    }
}
