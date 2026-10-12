using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float stepDistance = 1f;    // длина одного шага
    public float stepDuration = 0.2f;  // время шага в секундах
    
    private bool isMoving = false;
    private Vector3 targetPosition;

    void Update()
    {
        if (!isMoving)
        {
            Vector3 inputDir = GetInputDirection();
            if (inputDir != Vector3.zero)
            {
                StartCoroutine(MoveStep(inputDir));
            }
        }
    }

    Vector3 GetInputDirection()
    {
        Vector3 dir = Vector3.zero;

        if (Input.GetKey(KeyCode.W)) dir += Vector3.right;
        if (Input.GetKey(KeyCode.S)) dir += Vector3.left;
        if (Input.GetKey(KeyCode.A)) dir += Vector3.forward;
        if (Input.GetKey(KeyCode.D)) dir += Vector3.back;

        return dir.normalized;
    }

    IEnumerator MoveStep(Vector3 direction)
    {
        isMoving = true;
        Vector3 startPos = transform.position;
        targetPosition = startPos + direction * stepDistance;

        float elapsed = 0f;

        while (elapsed < stepDuration)
        {
            elapsed += Time.deltaTime;
            transform.position = Vector3.Lerp(startPos, targetPosition, elapsed / stepDuration);
            yield return null;
        }

        transform.position = targetPosition;
        isMoving = false;
    }
}
