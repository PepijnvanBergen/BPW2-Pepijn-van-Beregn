using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    private enemy enemy;
    private Boss boss;

    private void Start()
    {
        enemy = GameObject.FindObjectOfType<enemy>();
        boss = GameObject.FindObjectOfType<Boss>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("triggered");
            enemy.damage();
        }
        if(collision.gameObject.tag == "Boss")
        {
            Debug.Log("boss hit");
            boss.Damage();
        }
        Destroy(gameObject);
    }
}
