using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword_Script : MonoBehaviour
{
    public int t6;
    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.SetInt("IsIt1", 0);
        //PlayerPrefs.Save();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
    //        StartCoroutine("SwordTime");
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            gameObject.GetComponent<CapsuleCollider2D>().enabled = false;
            PlayerPrefs.SetInt("IsIt1", 1);
            PlayerPrefs.Save();
        }
    }

    //public IEnumerator SwordTime()
    //{
    //    gameObject.GetComponent<SpriteRenderer>().enabled = false;
    //    gameObject.GetComponent<CapsuleCollider2D>().enabled = false;
    //    PlayerPrefs.SetInt("IsIt1", 1);
    //    PlayerPrefs.Save();
    //    yield return new WaitForSeconds(t6);
    //    PlayerPrefs.SetInt("IsIt1", 0);
    //    PlayerPrefs.Save();
    //}

}
