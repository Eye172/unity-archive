using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class go_to_race_scr : MonoBehaviour
{

    [SerializeField] GameObject canvas_s_knopkami;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "pl_car_1")
        {
            canvas_s_knopkami.SetActive(true);
        }    

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "pl_car_1")
        {
            canvas_s_knopkami.SetActive(false);
        }

    }

    public void DA()
    {

        SceneManager.LoadScene(2);
    
    }

    public void NET()
    {


        canvas_s_knopkami.SetActive(false);
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
