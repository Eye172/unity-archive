using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerRotate : MonoBehaviour
{
    public Transform opponent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FaceOpponent();
    }
    
    void FaceOpponent()
    {
        if (opponent == null) return;

        Vector3 lookDir = opponent.position - transform.position;
        lookDir.y = 0f;

        if (lookDir.sqrMagnitude > 0.001f)
        {
            Quaternion targetRot = Quaternion.LookRotation(lookDir);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRot, Time.deltaTime * 10f);
        }
    }
}
