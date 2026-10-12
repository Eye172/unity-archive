using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergySystem : MonoBehaviour
{
    public float maxEnergy = 100f;
    public float currentEnergy;

    public float passiveDrain;
    public float flashlightDrain;
    public Slider energySlider;
    public Light flashlight;

    private bool isFlashlightOn = false;

    void Start()
    {
        currentEnergy = PlayerPrefs.HasKey("PlayerEnergy") ? PlayerPrefs.GetFloat("PlayerEnergy") : maxEnergy;

        if (energySlider != null)
        {
            energySlider.maxValue = maxEnergy;
            energySlider.value = currentEnergy;
        }

        if (flashlight != null)
            flashlight.enabled = false;
    }

    void Update()
    {
        HandleFlashlightToggle();

        float totalDrain = passiveDrain + (isFlashlightOn ? flashlightDrain : 0f);
        DrainEnergy(totalDrain * Time.deltaTime);

        UpdateUI();

        HandleEnergyEmpty();
        HandleEnergyReset();
    }


    void HandleFlashlightToggle()
    {
        if (Input.GetKeyDown(KeyCode.F) && currentEnergy > 0)
        {
            isFlashlightOn = !isFlashlightOn;
            if (flashlight != null)
                flashlight.enabled = isFlashlightOn;
        }
    }

    public void DrainEnergy(float amount)
    {
        currentEnergy -= amount;
        currentEnergy = Mathf.Clamp(currentEnergy, 0f, maxEnergy);
        PlayerPrefs.SetFloat("PlayerEnergy", currentEnergy);
    }


    public bool HasEnergy()
    {
        return currentEnergy > 0f;
    }

    void UpdateUI()
    {
        if (energySlider != null)
            energySlider.value = currentEnergy;
    }

    void HandleEnergyEmpty()
    {
        if (currentEnergy <= 0f && flashlight != null)
        {
            flashlight.enabled = false;
            isFlashlightOn = false;
        }
    }

    void HandleEnergyReset()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            currentEnergy = maxEnergy;
            PlayerPrefs.SetFloat("PlayerEnergy", currentEnergy);
            PlayerPrefs.Save();

            if (energySlider != null)
                energySlider.value = currentEnergy;

            if (flashlight != null)
                flashlight.enabled = false;

            isFlashlightOn = false;
        }
    }
}
