using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    private Transform Player;
    public float speed;
    public float targetDistance;
    public float stopDistance;

    public float health = 1;

    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }
    void Update()
    {
        float distance = Vector2.Distance(transform.position, Player.position);
        if (distance > stopDistance && distance < targetDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, Player.position, speed * Time.deltaTime);
        }

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void damage()
    {
        health -= 1;
    }
}