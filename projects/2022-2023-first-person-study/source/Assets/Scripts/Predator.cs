using UnityEngine;

public class Predator : Enemy
{
    [SerializeField] GameObject bullet;
    [SerializeField] GameObject rifleStart;

    float timer = 0;
    float cooldown = 1;

    float area = 25;
    public override void Move()
    {
        if (Vector3.Distance(transform.position, player.transform.position) < 25) //100 - если дистания меньше
        {
            transform.LookAt(player.transform);
            GetComponent<CharacterController>().Move(transform.forward * Time.deltaTime * 2);
        }
        if (Vector3.Distance(transform.position, player.transform.position) > 25)
        {
            transform.LookAt(player.transform);

            timer += Time.deltaTime;
            if (timer > cooldown)
            {
                timer = 0;
                GameObject buf = Instantiate(bullet);
                buf.transform.position = rifleStart.transform.position;
                buf.transform.rotation = transform.rotation;
                buf.GetComponent<Bullet>().setDirection(transform.forward);
            }
        }
    }
    public override void Attack()
    {
        if (Vector3.Distance(transform.position, player.transform.position) < 3) //3 - 
        {
            player.GetComponent<PlayerController>().ChangeHealth(-1);
        }
    }
}