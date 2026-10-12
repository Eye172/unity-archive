using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class save : MonoBehaviour
{
    public string savename;
    // Start is called before the first frame update
    void Start()
    {
      
        if (PlayerPrefs.GetInt("d"+savename)==3)
        { 
            Destroy(gameObject);
        }
        transform.position = new Vector3(PlayerPrefs.GetFloat("x" + savename,transform.position.x), PlayerPrefs.GetFloat("y" + savename, transform.position.y), PlayerPrefs.GetFloat("z" + savename, transform.position.z));    
    }

    public void Des()
    {
        PlayerPrefs.SetInt("d" + savename, 3);

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        PlayerPrefs.SetFloat("x"+ savename, transform.position.x);
        PlayerPrefs.SetFloat("y"+savename, transform.position.y);
        PlayerPrefs.SetFloat("z" + savename, transform.position.z);
    }
}
