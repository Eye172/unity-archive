using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove1 : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float jumpForce;
    [SerializeField] float rollForce;
    [SerializeField] Slider PlayerHpLine;
    [SerializeField] Slider PlayerStLine;
    [SerializeField] Text SoulsText;
    [SerializeField] GameObject Body;
    [SerializeField] Image HpPotionImg;
    [SerializeField] Sprite Img4;
    [SerializeField] Sprite Img3;
    [SerializeField] Sprite Img2;
    [SerializeField] Sprite Img1;
    [SerializeField] Sprite Img0;
    [SerializeField] GameObject DeathScreen;    
    [SerializeField] GameObject DeathButton;
    [SerializeField] GameObject DeathAudio; 
    float pr;
    float health;
    float maxhealth = 100;
    float stamina;
    float maxstamina = 100;
    int souls;
    int HpPotionCount;
    int MaxHpPotionCount = 5;
    bool ifRoll;
    public bool rightf;
    float stPause;

    Rigidbody2D rb;
    Vector3 direction;
    Animator anim;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        ChangeHealth(maxhealth);
        ChangeStamina(maxstamina);
        ChangeSouls(0);
        HpPotionCount = MaxHpPotionCount;
    }
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        direction = transform.TransformDirection(horizontal, 0, 0);
        if (health <= 0)
        {
            anim.SetBool("die", true);
        }
        if (horizontal > 0 && rightf == false)
        {
            flip_l();
            rightf = true;
        }
        else if (horizontal < 0 && rightf == true)
        {
            flip_r();
            rightf = false;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            jump();
        }
        if (Input.GetMouseButtonDown(0))
        {
            attack();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            roll();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            if(HpPotionCount != 0)
            {
                anim.SetTrigger("drink");
                ChangeHealth(50);
                HpPotionCount = HpPotionCount - 1;
                changeimg1();
            }
            
        }
        if (horizontal != 0) 
        {
          anim.SetBool("walk", true);
        }
        else
        {
          anim.SetBool("walk", false);
        }
        if (stPause > 0)
        {
            stPause -= Time.deltaTime;
        }
        else
        {
            stamina += Time.deltaTime * 10;
            if(stamina > maxstamina)
            {
                stamina = maxstamina;
            }
            PlayerStLine.value = stamina;
        }

    }
    void FixedUpdate()
    {
        transform.Translate(new Vector3(direction.x, 0,0)*Time.deltaTime);
    }
    public void jump()
    {
        if (rb.velocity.y==0 && stamina >= 10)
        {
            ChangeStamina(-10);
            rb.AddForce(new Vector3 (0,jumpForce,0), ForceMode2D.Impulse);
        }
    }
    public void attack()
    {
        if(stamina >= 20)
        {
            ChangeStamina(-20);
            anim.SetTrigger("attack_1");
        }
    }
        public void roll()
    {
        if(rb.velocity.y==0 && stamina >= 15)
        {
            anim.SetTrigger("roll");
            ChangeStamina(-15);
            ifRoll = true;
            if(rightf)
            {
                rb.AddForce(new Vector3 (rollForce,0,0), ForceMode2D.Impulse);
            }
            else
            {
                rb.AddForce(new Vector3 (rollForce * -1,0,0), ForceMode2D.Impulse);
            }
        }
    }
    public void endroll()
    {
        ifRoll = false;
    }
    public void ChangeHealth(float count)
    {
        if (ifRoll)
        {
            //Nothing
        }
        else
        {
            health = health + count;
            PlayerHpLine.value = health;
            PlayerPrefs.SetFloat("hp", health);
        }
        
    }
    public void ChangeStamina(float count)
    {
        stPause = 0.5f;
        stamina = stamina + count;
        PlayerStLine.value = stamina;
    }
    public void ChangeSouls(int count)
    {
        souls = souls + count;
        SoulsText.text = souls.ToString();
        PlayerPrefs.SetInt("souls", souls);
    }
    public void flip_r()
    {
        transform.rotation = Quaternion.Euler (new Vector3 (0, 0, 0));
    }
     public void flip_l()
    {
        transform.rotation = Quaternion.Euler (new Vector3 (0, 180f, 0));
    }
    public void changeimg1()
    {
        if(HpPotionCount == 4)
        {
            HpPotionImg.sprite = Img4;
        }
        else if(HpPotionCount == 3)
        {
            HpPotionImg.sprite = Img3;
        }
        else if(HpPotionCount == 2)
        {
            HpPotionImg.sprite = Img2;
        }
        else if(HpPotionCount == 1)
        {
            HpPotionImg.sprite = Img1;
        }
        else if(HpPotionCount == 0)
        {
            HpPotionImg.sprite = Img0;
        }
    }
    public void death()
    {
        DeathScreen.SetActive(true);
        DeathButton.SetActive(true);
        DeathAudio.SetActive(true);
    }
}
// Воспросы :

// Нужно сделать :
// Музыка
// Финальный противник