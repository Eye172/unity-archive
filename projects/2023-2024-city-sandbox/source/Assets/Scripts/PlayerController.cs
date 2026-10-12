using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Text HpText;
    [SerializeField] GameObject bullet;
    [SerializeField] GameObject bullet_hole;
    [SerializeField] GameObject rifleStart;
    [SerializeField] Text ammo_text;
    [SerializeField] Button rchg_btn;
    [SerializeField] AudioSource audio;
    [SerializeField] AudioClip musica2;
    [SerializeField] Text MoneyText;
    int ammo=12, max_ammo=12;
    float t=3;
    bool shooting;
    float shootTime;
    public int Money;
    
    
    private int health;
    public void ChangeHealth(int count)
    {
        health = health + count;
        HpText.text = health.ToString();
    }

    void Start()
    {
        ChangeHealth(100);
    }
    
    public void fire()
    {
        if (ammo > 0)
        {
            audio.PlayOneShot(musica2);
            // GameObject buffer = Instantiate(bullet);
            // buffer.GetComponent<Bullet>().SetDirection(- rifleStart.transform.forward);
            // buffer.transform.position = rifleStart.transform.position;
            // buffer.transform.rotation = rifleStart.transform.rotation;

            RaycastHit hit;

            if (Physics.Raycast(rifleStart.transform.position,-rifleStart.transform.forward, out hit, 400))
            {
                if (hit.transform.tag == "enemy_ragdoll")
                {
                    hit.transform.root.GetComponent<Ragdoll>().Death_Fall(true);
                }
                Destroy(Instantiate(bullet, hit.point, transform.rotation), 1);
                Destroy(Instantiate(bullet_hole, hit.point, transform.rotation), 20);
                if (hit.transform.GetComponent<Rigidbody>()!=null)
                {
                    hit.transform.GetComponent<Rigidbody>().AddForce(-hit.normal * 50, ForceMode.Impulse);
                }
                if (hit.transform.tag == "bar")
                {
                    hit.transform.GetComponent<barrel_scr>().Boom();
                }
            }

            
            

            ammo-=1;
            ammo_text.text = ammo.ToString() + "/" + max_ammo.ToString();
            
        }
    }

    public void start_shoot()
    {
        shooting = true;
    }

    public void stop_shoot()
    {
        shooting = false;
    }

    public void reload()
    {
        rchg_btn.interactable = false;
        rchg_btn.GetComponent<Image>().fillAmount = 0;
        StartCoroutine(reloading(t));
    }

    IEnumerator reloading(float t)
    {
        yield return new WaitForSeconds(t);
        rchg_btn.interactable = true;
        ammo = max_ammo;
        ammo_text.text = ammo + "/" + max_ammo;
    }



    void Update()
    {
        shootTime += Time.deltaTime;
        if (shooting && shootTime > 0.2f)
        {
            shootTime = 0;
            fire();
        }
        if (rchg_btn.GetComponent<Image>().fillAmount < 1)
        {
            rchg_btn.GetComponent<Image>().fillAmount+=Time.deltaTime/ t;


        }
    }
    
    
    public void ChangeMoney(int count)
    {
        Money = Money + count;
        MoneyText.text = "Gold_Coins: " + Money;
    }
}