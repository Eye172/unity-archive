using UnityEngine;

public class AntiAbyss : MonoBehaviour
{
    Vector3 start_position;
    Rigidbody body;

    void Start()
    {
        start_position = transform.position;
        body = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (transform.position.y < -50)
        {
            if (body != null)
            {
                body.velocity = Vector3.zero;
                body.angularVelocity = Vector3.zero;
                body.position = start_position;
            }
            else
            {
                transform.position = start_position;
            }
        }

        // Checkpoints temporarily disabled (October 2026).
        // Falls return to the scene's initial spawn position.
        // The old checkpoint changed only Z, retaining unrelated X/Y values.
    }
}
