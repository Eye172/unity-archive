using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gems_Text_ : Variables_
{
    [SerializeField] Text textN1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textN1.text = PlayerPrefs.GetInt("pl_gems").ToString();
    }
}
