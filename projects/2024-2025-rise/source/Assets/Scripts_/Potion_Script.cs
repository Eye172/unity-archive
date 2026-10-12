using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion_Script : MonoBehaviour
{
    public PhysicsMaterial2D phys;
    public int t5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine("PotionTime");
        }
    }
    public IEnumerator PotionTime()
    {
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        gameObject.GetComponent<CapsuleCollider2D>().enabled = false;
        phys.friction = 100f;
        phys.bounciness = 1;
        PlayerPrefs.SetFloat("m1", 10f);
        PlayerPrefs.Save();
        PlayerPrefs.SetFloat("jumpForce", 4f);
        PlayerPrefs.Save();
        yield return new WaitForSeconds(t5);
        phys.friction = 0.4f;
        phys.bounciness = 0.6f;
        PlayerPrefs.SetFloat("m1", 0.4f);
        PlayerPrefs.Save();
        PlayerPrefs.SetFloat("jumpForce", 2f);
        PlayerPrefs.Save();
    }
}

