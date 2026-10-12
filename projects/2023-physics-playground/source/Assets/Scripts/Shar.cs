using UnityEngine;

public class Shar : MonoBehaviour
{	
    [SerializeField] float limit = 75f;
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
		    float angle = limit * Mathf.Sin(Time.time);        
		    transform.localRotation = Quaternion.Euler(0, 0, angle);
	}
}