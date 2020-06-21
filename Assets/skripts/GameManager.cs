using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    static GameManager instance;
    public GameObject player;

    public int dungeonLength;

    public int cornerRooms;
    public int endRooms;
    public int UDRooms;
    public int LRRooms;


    public int basicRooms;
    public int endrooms;
    public int corridorRooms;

    private void Update()
    {
        if(player == null)
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
