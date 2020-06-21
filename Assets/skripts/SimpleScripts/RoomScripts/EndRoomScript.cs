using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndRoomScript : MonoBehaviour
{
    public GameObject enemy;
    public GameObject chest;
    public GameObject boss;

    private GameManager GM;

    bool spawned = false;
    bool bossSpawned = false;

    private void Awake()
    {
        GM = GameObject.FindObjectOfType<GameManager>();
    }
    void Start()
    {
        GM.endRooms++;
    }

    public void Update()
    {
        if (GM.endRooms <4 && spawned == false)
        {
            Instantiate(chest, transform.position, Quaternion.identity);
            Instantiate(enemy, transform.position, Quaternion.identity);
            spawned = true;
            if(GameObject.Find("EpischeBoss(Clone)") == null)
            {
                Debug.Log("bos");
                if(bossSpawned == false)
                {
                    Instantiate(boss, transform.position, Quaternion.identity);
                    bossSpawned = true;
                }
            }
        }
        else if (GM.endRooms == 4 && spawned == false)
        {
            Instantiate(chest, transform.position, Quaternion.identity);
            Instantiate(enemy, transform.position, Quaternion.identity);
            spawned = true;
            Instantiate(enemy, transform.position, Quaternion.identity);
        }
    }
}
