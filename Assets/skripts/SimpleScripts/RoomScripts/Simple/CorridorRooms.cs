using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorridorRooms : MonoBehaviour
{
    private GameManager GM;
    void Start()
    {
        GM = GameObject.FindObjectOfType<GameManager>();
        GM.corridorRooms++;
    }
}
