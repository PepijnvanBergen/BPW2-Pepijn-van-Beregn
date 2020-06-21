using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicRoomScript : MonoBehaviour
{
    private GameManager GM;
    public GameObject enemy;
    public GameObject chest;

    private void Awake()
    {
        GM = GameObject.FindObjectOfType<GameManager>();
    }
    void Start()
    {
        GM.basicRooms++;
        int rand = Random.Range(0, 3);

        if(rand == 2)
        {
            Instantiate(enemy, transform.position, Quaternion.identity);
        }
    }
}
