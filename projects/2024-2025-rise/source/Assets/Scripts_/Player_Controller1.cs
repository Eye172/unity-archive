using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller1 : MonoBehaviour
{
    public LineRenderer line;
    public Rigidbody2D rb;
    public float limit;
    public float jumpForce;
    private Camera plCamera;
    private bool tf;
    int kx;
    int ky;
    Vector3 TouchPos
    {
        get
        {
            if(Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);
                Vector3 pos = plCamera.ScreenToWorldPoint(touch.position);
                pos.z = 0f;
                return pos;
            }
            else
            {
                return Vector3.zero;
            }
        }
    }
    // Start is called before the first frame update
    private void Start()
    {
        plCamera = Camera.main;
        line.positionCount = 2;
        line.SetPosition(0, Vector2.zero);
        line.SetPosition(1, Vector2.zero);
        line.enabled = false;
        tf = false;
        PlayerPrefs.SetFloat("m1", 0.4f);
        PlayerPrefs.Save();
        PlayerPrefs.SetFloat("limit", 14f);
        PlayerPrefs.SetFloat("jumpForce", 2f);
        PlayerPrefs.Save();
    }

    // Update is called once per frame
    private void Update()
    {
        if(Input.touchCount > 0 && !tf)
        {
            dragStart();
        }

        if(Input.touchCount > 0 && tf)
        {
            drag();
        }

        if(Input.touchCount == 0 && tf)
        {
            dragEnd();
        }
        
    }



    void dragStart()
    {
        if(rb.velocity.magnitude < PlayerPrefs.GetFloat("m1"))
        {
            line.enabled = true;
            tf = true;
            line.SetPosition(0, TouchPos);
        }
        

    }
    void drag()
    {
        Vector3 startPos = line.GetPosition(0);
        Vector3 currentPos = TouchPos;

        Vector3 distance = currentPos - startPos;

        if(distance.magnitude <= PlayerPrefs.GetFloat("limit"))
        {
            line.SetPosition(1, currentPos);
        }
        else
        {
            Vector3 limitVec = startPos + (distance.normalized * PlayerPrefs.GetFloat("limit"));
            line.SetPosition(1, limitVec);
        }

        
    }
    void dragEnd()
    { 
        tf = false;
        line.enabled = false;

        Vector3 startPos = line.GetPosition(0);
        Vector3 endPos = line.GetPosition(1);
        
        Vector3 distance = endPos - startPos;
        Vector3 forceVec = distance * PlayerPrefs.GetFloat("jumpForce");
        
        rb.AddForce(new Vector2(-forceVec.x, -forceVec.y), ForceMode2D.Impulse);
        

        
    }

}
