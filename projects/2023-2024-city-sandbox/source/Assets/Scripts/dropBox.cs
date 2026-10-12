using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropBox : MonoBehaviour
{
    Animator anim;
    Rigidbody rb;
    [SerializeField] float airResistance; // ������������� �������
    [SerializeField] float deploymentHeight; //������ ��������� ��������
    bool deployed; // �������� �� �������
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit; //������, � ������� ����� ���
        Ray ray = new Ray(transform.position, Vector3.down);

        Debug.DrawRay(transform.position, -transform.up * deploymentHeight, Color.red);
        if (!deployed)
        {
            if (Physics.Raycast(ray, out hit, deploymentHeight))
            {
                if (hit.transform.tag != "water")
                {
                    deployed = true; // ���������, ��� ������� ��������
                    rb.drag = airResistance; // ������ �������� ������������� �������
                    anim.SetTrigger("open"); // �������� �������� ��������� ��������

                }
            }
        
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        anim.SetTrigger("close");
        rb.drag = 0;
    }
}
