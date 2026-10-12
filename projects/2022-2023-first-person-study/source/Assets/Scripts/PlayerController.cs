
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Text HpText;
    int health;

    [SerializeField] GameObject bullet;
    [SerializeField] GameObject rifleStart;

    public void ChangeHealth(int count)
{
    health = health + count;
    HpText.text = "♥ " + health.ToString();
    PlayerPrefs.SetInt("hp", health);
    
}
    // Start is called before the first frame update
    void Start()
    {      
        ChangeHealth(PlayerPrefs.GetInt("hp", 100));
    }





    void Update()
{
     
if (Input.GetMouseButtonDown(0))
{
       
    GameObject buf = Instantiate(bullet); 
    buf.GetComponent<Bullet>().setDirection(transform.forward);
    buf.transform.position = rifleStart.transform.position;
    buf.transform.rotation = transform.rotation;
}
if (health <=0 )
{
    PlayerPrefs.DeleteAll();
    SceneManager.LoadScene(0);
}
}
}