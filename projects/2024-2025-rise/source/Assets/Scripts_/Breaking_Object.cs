using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breaking_Object : MonoBehaviour
{
    public int time;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine("StartToBreak");
        }
    }

    private IEnumerator StartToBreak()
    {
        animator.SetTrigger("break");
        yield return new WaitForSeconds(8);
        gameObject.SetActive(false);
        
    }
}
