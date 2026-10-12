using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bread_Script : MonoBehaviour
{
    public int t4;
    public GameObject pl_;
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
            StartCoroutine("Almighty");
        }

    }

    public IEnumerator Almighty()
    {
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        gameObject.GetComponent<CapsuleCollider2D>().enabled = false;
        pl_.GetComponent<Rigidbody2D>().mass = 0.5f;
        PlayerPrefs.SetFloat("m1", 100000000000000000000000f);
        PlayerPrefs.Save();
        yield return new WaitForSeconds(t4);
        PlayerPrefs.SetFloat("m1", 0.4f);
        PlayerPrefs.Save();
        pl_.GetComponent<Rigidbody2D>().mass = 1f;

    }
}
