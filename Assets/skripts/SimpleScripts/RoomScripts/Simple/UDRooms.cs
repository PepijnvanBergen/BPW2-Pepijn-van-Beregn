using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UDRooms : MonoBehaviour
{
    private GameManager GM;
    void Start()
    {
        GM = GameObject.FindObjectOfType<GameManager>();
        GM.UDRooms++;
    }
}
