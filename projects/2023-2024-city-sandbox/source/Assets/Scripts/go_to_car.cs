using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class go_to_car : MonoBehaviour
{
    [SerializeField] GameObject car_btn;
   
    Collider car;
    // Start is called before the first frame update
    void Start()
    {
        
    }

   public void VHODIIIIM()
    {
        car.GetComponentInChildren<Camera>(true).gameObject.SetActive(true);
        car.GetComponentInChildren<Canvas>(true).gameObject.SetActive(true);

        car_btn.transform.parent.gameObject.SetActive(false);
        transform.parent = car.transform;
        gameObject.SetActive(false);


    }


    public void VIHODIM()
    {
        car.GetComponentInChildren<Camera>(true).gameObject.SetActive(false);
        car.GetComponentInChildren<Canvas>(true).gameObject.SetActive(false);

        car_btn.transform.parent.gameObject.SetActive(true);
        transform.parent = null;
        gameObject.SetActive(true);


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "pl_car_1")
        { 
        car_btn.SetActive(true);
            car = other;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "pl_car_1")
        {
            car_btn.SetActive(false);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
