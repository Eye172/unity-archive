using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraMove : MonoBehaviour
{
    public Transform target;
    public Vector3 offset = new Vector3(0f, 0f, -10f);
    public float smoothSpeed = 5f;

    private Vector3 initialOffset;

    void Start()
    {
        if (target != null)
        {
            // Загружаем сохранённые значения позиции камеры из PlayerPrefs
            float cameraPosX = PlayerPrefs.GetFloat("CameraPosX", transform.position.x);
            float cameraPosY = PlayerPrefs.GetFloat("CameraPosY", transform.position.y);
            float cameraPosZ = PlayerPrefs.GetFloat("CameraPosZ", transform.position.z);

            // Устанавливаем позицию камеры на загруженные значения
            transform.position = new Vector3(cameraPosX, cameraPosY, cameraPosZ);

            // Загружаем координаты игрока из PlayerPrefs
            float playerPosX = PlayerPrefs.GetFloat("PlayerPosX", target.position.x);
            float playerPosY = PlayerPrefs.GetFloat("PlayerPosY", target.position.y);
            float playerPosZ = PlayerPrefs.GetFloat("PlayerPosZ", target.position.z);

            // Устанавливаем позицию игрока на сохраненные значения
            target.position = new Vector3(playerPosX, playerPosY, playerPosZ);

            // Обновляем начальное смещение камеры
            initialOffset = transform.position - target.position;
        }
    }

    void LateUpdate()
    {
        if (target == null) return;

        // Обновляем позицию камеры
        Vector3 desiredPosition = target.position + initialOffset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        transform.position = smoothedPosition;

        // Сохраняем текущую позицию камеры в PlayerPrefs
        //transform.position = new Vector3(0, transform.position.y, -9);
        PlayerPrefs.SetFloat("CameraPosX", transform.position.x);
        PlayerPrefs.SetFloat("CameraPosY", transform.position.y);
        PlayerPrefs.SetFloat("CameraPosZ", transform.position.z);
    }
}
