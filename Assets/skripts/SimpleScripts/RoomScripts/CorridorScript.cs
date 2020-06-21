using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorridorScript : MonoBehaviour
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
        GM.corridorRooms++;
    }

    public void Update()
    {
        if (GM.corridorRooms == 2)
        {

        }
        else if (GM.corridorRooms == 3)
        {

        }
        else if (GM.corridorRooms >= 4)
        {

        }
    }
}
