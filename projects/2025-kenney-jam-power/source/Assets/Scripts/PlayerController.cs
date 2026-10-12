using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float walkSpeed = 3f;
    public float runSpeed = 6f;
    public float laserSpeed = 20f;

    public float energyWalkDrain;
    public float energyRunDrain;
    public float energyShotDrain;

    

    public float lowEnergyThreshold = 3f;

    public Transform spriteTransform;

    private CharacterController controller;
    public Animator animator;
    
    private EnergySystem energySystem;

    public GameObject laserPrefab;
    public Transform firePoint;

    private Vector3 moveDirection;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        energySystem = GetComponent<EnergySystem>();

        if (PlayerPrefs.HasKey("PlayerPosX"))
        {
            transform.position = new Vector3(
                PlayerPrefs.GetFloat("PlayerPosX"),
                PlayerPrefs.GetFloat("PlayerPosY"),
                PlayerPrefs.GetFloat("PlayerPosZ")
            );
        }
    }

    void Update()
    {
        if (!energySystem.HasEnergy())
        {
            return;
        }

        HandleShooting();

        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 input = new Vector3(horizontal, 0f, vertical).normalized;

        bool isRunning = Input.GetKey(KeyCode.LeftShift);
        float speed = isRunning ? runSpeed : walkSpeed;

        if (energySystem.currentEnergy < lowEnergyThreshold)
        {
            isRunning = false;
            speed = walkSpeed;
        }

        moveDirection = input * speed;

        if (input.magnitude >= 0.1f)
        {
            if (animator != null)
            {
                animator.SetBool("isMoving", true);
            }

            controller.Move(moveDirection * Time.deltaTime);

            if (isRunning)
            {
                energySystem.DrainEnergy(energyRunDrain * Time.deltaTime);
            }
            else
            {
                energySystem.DrainEnergy(energyWalkDrain * Time.deltaTime);

            }
        }
        else
        {
            animator.SetBool("isMoving", false);
        }


        if (horizontal != 0)
        {
            Vector3 scale = transform.localScale;
            scale.x = Mathf.Sign(horizontal) * Mathf.Abs(scale.x);
            transform.localScale = scale;
            //Vector3 scale = spriteTransform.localScale;
            //scale.x = Mathf.Sign(horizontal) * Mathf.Abs(scale.x);
            //spriteTransform.localScale = scale;
        }
        //transform.position = new Vector3(0, transform.position.y, 0);
        PlayerPrefs.SetFloat("PlayerPosX", transform.position.x);
        PlayerPrefs.SetFloat("PlayerPosY", transform.position.y);
        PlayerPrefs.SetFloat("PlayerPosZ", transform.position.z);
    }

    void HandleShooting()
    {
        if (Input.GetMouseButtonDown(0) && energySystem.currentEnergy >= energyShotDrain)
        {
            energySystem.DrainEnergy(energyShotDrain);

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Plane xzPlane = new Plane(Vector3.up, firePoint.position);

            if (xzPlane.Raycast(ray, out float enter))
            {
                Vector3 targetPoint = ray.GetPoint(enter);
                
                Vector3 direction = targetPoint - firePoint.position;
                direction.y = 0f;
                direction = direction.normalized;

                GameObject laser = Instantiate(laserPrefab, firePoint.position, Quaternion.LookRotation(direction));
                Rigidbody rb = laser.GetComponent<Rigidbody>();
                rb.velocity = direction * laserSpeed;
            }
        }
    }
}
