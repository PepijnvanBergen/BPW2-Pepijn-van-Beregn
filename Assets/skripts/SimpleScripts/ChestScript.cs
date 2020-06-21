using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestScript : MonoBehaviour
{
    private playerMovement PM;

    private void Awake()
    {
        PM = GameObject.FindObjectOfType<playerMovement>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            PM.armorCounter++;
            Destroy(gameObject);
        }
    }
}
