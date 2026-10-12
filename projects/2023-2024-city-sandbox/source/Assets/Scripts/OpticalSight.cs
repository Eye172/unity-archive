using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OpticalSight : MonoBehaviour
{
    [SerializeField] Camera cameraMain;
    [SerializeField] Camera opticalCamera;
    [SerializeField] Slider slider;
    [SerializeField] GameObject optic;
    [SerializeField] float mouse;
    PlayerLook playerLook;

    float mouseMax = 0.5f;   
    float maxFOV = 60;     
    
    bool isOptic;
    void Start()
    {
        mouse = mouseMax;
        isOptic = false;
        playerLook = GetComponent<PlayerLook>();
    }
    void Update()
    {
        if (isOptic)
        {
            mouse = slider.value / maxFOV * mouseMax;
            opticalCamera.fieldOfView = Mathf.Lerp(opticalCamera.fieldOfView, slider.value, 10 * Time.deltaTime);            
            playerLook.ChangeMouseSensivity(mouse); 
            cameraMain.enabled = false;
            opticalCamera.enabled = true;
            optic.SetActive(true);
        }
        else
        {
            slider.value = maxFOV;
            mouse = mouseMax;
            playerLook.ChangeMouseSensivity(mouse); 
            cameraMain.enabled = true;
            opticalCamera.enabled = false;
            optic.SetActive(false);
        }
    }

    public void OpticOnOff()
    {
        if (!isOptic)
        {
            isOptic = true;
        }
        else isOptic = false;
    }
    
}