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
    }

    public void Update()
    {
        if (GM.basicRooms == 2)
        {

        }
        else if (GM.basicRooms == 3)
        {

        }
        else if (GM.basicRooms >= 4)
        {

        }
    }
}
