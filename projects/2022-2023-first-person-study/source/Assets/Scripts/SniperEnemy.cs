using UnityEngine;

public class SniperEnemy : Enemy
{
    [SerializeField] GameObject bullet;
    [SerializeField] GameObject rifleStart;

    float timer = 0;
    float cooldown = 5;
    float area = 300;
    #region---HomeWork_M4L3
    float moveTimer = 0;
    float moveCooldown = 5;
    #endregion
    enum Firing { Wait, Prepare, Shoot }
    Firing fire = Firing.Wait;
    public override void Move()
    {
        #region---HomeWork_M4L3
        if(fire == Firing.Wait)
        {
            GetComponent<CharacterController>().Move(transform.forward * Time.deltaTime * 3);
            moveTimer += Time.deltaTime;
            if (moveTimer >= moveCooldown)
            {
                transform.Rotate(new Vector3(0, 180, 0));
                moveTimer = 0;
            }
        }
        #endregion
    }
    public override void Attack()
    {
        switch (fire)
        {
            case Firing.Wait:
                if (Vector3.Distance(transform.position, player.transform.position) <= area)
                {
                    fire = Firing.Prepare;
                }
                break;
            case Firing.Prepare:
                timer += Time.deltaTime;
                transform.LookAt(player.transform);
                if (timer > cooldown)
                {
                    fire = Firing.Shoot;
                }
                break;
            case Firing.Shoot:
                timer = 0;
                GameObject buf = Instantiate(bullet);
                buf.transform.position = rifleStart.transform.position;
                buf.transform.rotation = transform.rotation;
                buf.GetComponent<Bullet>().setDirection(transform.forward);
                fire = Firing.Wait;
                break;
        }

    }
}