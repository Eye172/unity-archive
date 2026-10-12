using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class race_scr : MonoBehaviour
{
    [SerializeField] GameObject[] cheqpoints;
    int i;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "cheq")
        {
            cheqpoints[i].SetActive(false);
            i++;
            cheqpoints[i].SetActive(true);

        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
