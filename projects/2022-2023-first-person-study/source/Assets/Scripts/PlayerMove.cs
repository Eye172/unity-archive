using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    float x = 430.4f;
    float y = 0.1f;
    float z = 451f;
    int crystals_count;
    //string sos = "172";
    //[SerializeField] string message;    
    [SerializeField] CharacterController controller;
    [SerializeField] float speed = 10;    
    [SerializeField] float jumpForce = 10;
    [SerializeField] float gravity = 1;
    [SerializeField] Text crystals_count_text;
    private Vector3 direction;

    void Start()
    {
        //print("OCULUS");
        print(x);
        print(y); 
        //transform.position = new Vector3(x, y, z);
        //print(message);
    }
    
    void OnTriggerEnter(Collider tcsks)
    {
        if (tcsks.tag == "Crystal1")
        {
            Destroy(tcsks.gameObject);
            crystals_count++;
            crystals_count_text.text = "Count: " + crystals_count;  
        }
        if (tcsks.tag == "Crystal_OMEGA")
        {
            GetComponent<AudioSource>().Play();
            Destroy(tcsks.gameObject);
            crystals_count+=2;
            crystals_count_text.text = "Count: " + crystals_count;  
        }
        if (tcsks.tag == "bullet_5")
        {
           FindObjectOfType<PlayerController>().ChangeHealth(-20);
        }
        if (tcsks.tag == "+hp_1")
        {
            FindObjectOfType<PlayerController>().ChangeHealth(100);
            Destroy(tcsks.gameObject);
        }
    }

    void Update()
    {
		float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");        
		
        if(moveHorizontal == 0 && moveVertical == 0)
        {
            GetComponent<Animator>().SetBool("walk", false);
        }
        else
        {
            GetComponent<Animator>().SetBool("walk", true);
        }
        if(Input.GetKey(KeyCode.LeftShift))
        {
            speed = 25;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = 100;
        }
        if (controller.isGrounded)
        {
			direction = new Vector3(moveHorizontal, 0, moveVertical);
			direction = transform.TransformDirection(direction) * speed;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                direction.y = jumpForce;
            }
        }        

        direction.y -= gravity * Time.deltaTime;
        controller.Move(direction * Time.deltaTime);
        if (crystals_count_text.text == "14")
        {
            crystals_count_text.text = "YOU WIN";
            SceneManager.LoadScene(1); 
        }
    }       
}