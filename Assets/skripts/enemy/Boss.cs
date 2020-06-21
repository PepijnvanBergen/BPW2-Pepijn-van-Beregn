using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public float speed;
    public float enragedSpeed;
    public float targetDistance;
    public float attackDistance;

    public int damage;
    public float health = 10;

    private Transform player;
    public Transform bulletPoint;
    public GameObject BossBullet;
    public bool isAttacking = false;
    public bool isEnraged = false;

    private float timeBetweenShots = 2;

    private SliderScript SC;
    private playerMovement PM;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        SC = GameObject.FindObjectOfType<SliderScript>();
        PM = GameObject.FindObjectOfType<playerMovement>();
        Instantiate(BossBullet, bulletPoint.position, Quaternion.identity);
    }

    public void Damage()
    {
        health--;
        SC.UpdateBossHealth(health);
    }

    public void Flipping()
    {
        float Xpos = transform.position.x;
        float playerXpos = player.transform.position.x;

        float player2boss = Xpos - playerXpos;

        if (player2boss > 0 && !isEnraged)
        {
            transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
        }
        else if (player2boss < 0 && !isEnraged)
        {
            transform.localScale = new Vector3(-0.3f, 0.3f, 0.3f);
        }
        if (player2boss > 0 && isEnraged)
        {
            transform.localScale = new Vector3(0.35f, 0.35f, 0.35f);
        }
        else if (player2boss < 0 && isEnraged)
        {
            transform.localScale = new Vector3(-0.35f, 0.35f, 0.35f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector2.Distance(transform.position, player.position);
        if (distance > attackDistance && distance < targetDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }
        if (distance < attackDistance && isEnraged == false)
        {
            isAttacking = true;
        }
        else if (distance > attackDistance && isEnraged == false)
        {
            isAttacking = false;
        }
        if (health <= 10f)
        {
            isEnraged = true;
        }
        if (health <= 0)
        {
            Destroy(gameObject);
        }
        if (!isEnraged)
        {
            attackDistance = 10;
        }
        if (isEnraged)
        {
            speed = enragedSpeed;
            transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
            attackDistance = 3;
        }
        timeBetweenShots -= Time.deltaTime;

        if (timeBetweenShots <= 0 && isEnraged)
        {
            Instantiate(BossBullet, bulletPoint.position, Quaternion.identity);
            timeBetweenShots = 1f;
        } else if(timeBetweenShots <= 0)
        {
            Instantiate(BossBullet, bulletPoint.position, Quaternion.identity);
            timeBetweenShots = 2f;
        }
        Flipping();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            PM.damage(5);
        }
    }
}
