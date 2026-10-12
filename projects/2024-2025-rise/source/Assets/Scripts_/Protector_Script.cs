using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Protector_Script : MonoBehaviour
{
    Animator anim;
    public Rigidbody2D rb;
    public Transform pl;
    public BoxCollider2D box1;
    public int t7;
    private float x;
    private float y;
    private bool qwe;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        qwe = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(rb.velocity.magnitude < 0.4f && qwe )
        {
            PlayerPrefs.SetFloat("x1", pl.transform.position.x);
            PlayerPrefs.SetFloat("y1", pl.transform.position.y);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "stopvoid")
        {
            qwe = false;
            if(PlayerPrefs.GetInt("IsIt1") == 1)
            {
                box1.enabled = true;
                rb.velocity = Vector3.zero;
                StartCoroutine("Hit"); 
                
            }
        }
    }
    public IEnumerator Hit()
    {

        anim.SetTrigger("hit");
        yield return new WaitForSeconds(t7);
        pl.position = new Vector2(PlayerPrefs.GetFloat("x1"),PlayerPrefs.GetFloat("y1"));
        box1.enabled = false;
        qwe = true;

    }
}
