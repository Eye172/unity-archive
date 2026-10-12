using UnityEngine;

public class Bullet : MonoBehaviour
{
    float speed = 10;
    Vector3 direction;

    public void setDirection(Vector3 dir)
    {
        direction = dir;
    }

    void FixedUpdate()
    {
        transform.position += direction * speed * Time.deltaTime;
        speed += 1f;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "enemy_N1")
        {
            other.GetComponent<Animator>().SetBool("death",true);
            other.GetComponent<Enemy>().OnDeath();


        }
        if (other.tag == "Player")
        {
            FindObjectOfType<PlayerController>().ChangeHealth(-20);
            Destroy(gameObject);
        }
        Destroy(gameObject);
    }
}