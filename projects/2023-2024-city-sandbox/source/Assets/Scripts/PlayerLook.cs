using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    float mouseSense = 1; // Чувствительность мыши

    [SerializeField] GameObject palka;
    public GameObject enemy; 

    // Update is called once per frame
    void Update()
    {
        //Cursor.lockState = CursorLockMode.Locked; // Скрываем курсор

        foreach (var touch in Input.touches)
        {
            if (touch.position.x >= Screen.width / 2)
            {
                float rotateX = touch.deltaPosition.x * mouseSense;
                float rotateY = touch.deltaPosition.y * mouseSense;
                Vector3 rotPlayer = transform.rotation.eulerAngles;
                Vector3 rotPalka = palka.transform.rotation.eulerAngles;
               

                rotPalka.x -= rotateY;
                rotPlayer.z = 0;
                rotPlayer.y += rotateX;
                rotPalka.y += rotateX;
                transform.rotation = Quaternion.Euler(rotPlayer);
                palka.transform.rotation = Quaternion.Euler(rotPalka);
            }
        }
    }
    public void ChangeMouseSensivity(float count)
    {
        mouseSense = count;
    }
}
