using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grass1_Script : MonoBehaviour
{
    public PhysicsMaterial2D phys;
    public int t1;
    // Start is called before the first frame update
    void Start()
    {
        phys.bounciness = 0.6f;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine("Grass1Time");
        }
    }

    public IEnumerator Grass1Time()
    {
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        gameObject.GetComponent<CapsuleCollider2D>().enabled = false;
        phys.bounciness = 1;
        PlayerPrefs.SetFloat("m1", 10f);
        PlayerPrefs.Save();
        yield return new WaitForSeconds(t1);
        phys.bounciness = 0.6f;
        PlayerPrefs.SetFloat("m1", 0.4f);
        PlayerPrefs.Save();
    }
}
