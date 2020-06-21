using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CornerRoomScript : MonoBehaviour
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
        GM.cornerRooms++;
    }

    public void Update()
    {
        if(GM.cornerRooms == 2)
        {

        }
        else if(GM.cornerRooms == 3)
        {

        }
        else if (GM.cornerRooms >= 4)
        {

        }
    }
}