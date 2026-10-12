using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grass3_Script : MonoBehaviour
{
    public int t3;
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
            StartCoroutine("Grass3Time");
        }
    }

    public IEnumerator Grass3Time()
    {
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        gameObject.GetComponent<CapsuleCollider2D>().enabled = false;
        PlayerPrefs.SetFloat("jumpForce", 4f);
        PlayerPrefs.Save();
        yield return new WaitForSeconds(t3);
        PlayerPrefs.SetFloat("jumpForce", 2f);
        PlayerPrefs.Save();
    }
}
