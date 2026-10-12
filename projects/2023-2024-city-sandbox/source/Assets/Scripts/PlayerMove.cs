using UnityEngine;

public class PlayerMove : MonoBehaviour
{ 
    [SerializeField] Joystick joystick;
    [SerializeField] float speed;
    [SerializeField] float jumpSpeed;
    [SerializeField] Animator anima;
    Rigidbody rb;
    Vector3 direction;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        float horizontal = joystick.Horizontal;
        float vertical = joystick.Vertical;
        
        anima.SetFloat("Blend", Mathf.Max(Mathf.Abs(horizontal), Mathf.Abs(vertical)));
        direction = transform.TransformDirection(horizontal, 0, vertical);
        
    }
    void FixedUpdate()
    {
        rb.MovePosition(transform.position + speed * direction * Time.deltaTime);  
    }
    public void jumping()
    {
        if(rb.velocity.y==0)
        rb.AddForce(new Vector3(0, jumpSpeed, 0), ForceMode.Impulse);
    }
}

