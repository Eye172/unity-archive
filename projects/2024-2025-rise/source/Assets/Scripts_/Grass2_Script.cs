using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grass2_Script : MonoBehaviour
{
    public PhysicsMaterial2D phys;
    public int t2;
    // Start is called before the first frame update
    void Start()
    {
        phys.friction = 0.4f;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine("Grass2Time");
        }
    }

    public IEnumerator Grass2Time()
    {
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        gameObject.GetComponent<CapsuleCollider2D>().enabled = false;
        phys.friction = 100f;
        yield return new WaitForSeconds(t2);
        phys.friction = 0.4f;
    }
}
