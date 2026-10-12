using UnityEngine;

public class PlayerMoveFall : MonoBehaviour
{
    [SerializeField] float speed= 5;
    [SerializeField] float jumpSpeed= 5;
    [SerializeField] bool slide;
    [SerializeField] bool sandio;
    Rigidbody rb;
    Vector3 direction;
    bool isGrounded;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        direction = transform.TransformDirection(x, 0, z);
        if (direction.magnitude > 0)
        {
            GetComponent<Animator>().SetBool("run", true);
        }
        else GetComponent<Animator>().SetBool("run", false);


        if (isGrounded)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(new Vector3(0, jumpSpeed, 0), ForceMode.Impulse);
            }
        }
        if(slide)
        {
            rb.AddForce(direction * 0.03f, ForceMode.VelocityChange);
        }
        if(sandio)
        {
            rb.AddForce(direction * -0.02f, ForceMode.VelocityChange);
        }
    }
    private void FixedUpdate()
    {
        rb.MovePosition(transform.position + direction * speed * Time.fixedDeltaTime);
    }

   

    private void OnCollisionStay(Collision other)
    {
        if (other != null)
        {
            isGrounded = true;
        }
		if (other.gameObject.CompareTag("ice"))
        {
         	slide = true;
        }
        else slide = false;
        if (other.gameObject.CompareTag("sand"))
        {
         	sandio = true;
        }
        else sandio = false;
    }
    private void OnCollisionExit(Collision other)
    {
        isGrounded = false;
    }
}