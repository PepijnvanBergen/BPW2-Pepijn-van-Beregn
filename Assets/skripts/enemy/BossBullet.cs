using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBullet : MonoBehaviour
{
    private Transform Player;
    public Rigidbody2D rb;
    private playerMovement PM;
    public float speed;
    public int damage;

    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        PM = GameObject.FindObjectOfType<playerMovement>();
    }
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, Player.position, speed * Time.deltaTime);
        Vector3 direction = Player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            PM.damage(damage);
            Destroy(gameObject);
        }else if(collision.gameObject.tag == "Wall" || collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "Bullet")
        {
            Destroy(gameObject);
        }
    }
}
