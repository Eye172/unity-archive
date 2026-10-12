using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float speed = 10;
    private Vector3 direction;

    public void SetDirection(Vector3 dir)
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
        if (other.tag == "Enemy")
        {
            Destroy(other.gameObject);
        }
        if (other.tag == "enemy_ragdoll")
        {
            other.transform.root.GetComponent<Ragdoll>().Death_Fall(true);
            other.GetComponent<Rigidbody>().AddForce(direction*100, ForceMode.Impulse);
        }
        if (other.tag == "Player")
        {
            other.GetComponent<PlayerController>().ChangeHealth(-20);
        }
        if (other.tag == "bar")
        {
            other.GetComponent<barrel_scr>().Boom();
        }
        Destroy(gameObject);
    }
}