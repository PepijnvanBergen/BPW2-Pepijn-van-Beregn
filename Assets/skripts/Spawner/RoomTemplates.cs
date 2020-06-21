using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTemplates : MonoBehaviour
{
    public List<GameObject> bottomDoorRooms;
    public List<GameObject> topDoorRooms;
    public List<GameObject> rightDoorRooms;
    public List<GameObject> leftDoorRooms;

    public List<GameObject> rooms;

    public GameObject[] closedRooms;


    private GameManager GM;

    public float waitTime;
    public int totalRooms;
    public int roomsUntilCorners;

    //private bool spawnedBoss = false;
    private bool spawnCorners = false;
    private bool spawnEnd = false;

    public GameObject roomD;
    public GameObject roomL;
    public GameObject corridorLR;
    public GameObject corridorUD;
    public GameObject roomLD;
    public GameObject roomLR;
    public GameObject roomLU;
    public GameObject roomR;
    public GameObject roomRU;
    public GameObject roomRD;
    public GameObject roomStart;
    public GameObject roomU;
    public GameObject roomUD;

    public GameObject boss;

    private void Awake()
    {
        rooms = new List<GameObject>();
        GM = GameObject.FindObjectOfType<GameManager>();

        bottomDoorRooms = new List<GameObject>();
        topDoorRooms = new List<GameObject>();
        rightDoorRooms = new List<GameObject>();
        leftDoorRooms = new List<GameObject>();

        bottomDoorRooms.Add(roomUD);
        bottomDoorRooms.Add(corridorUD);

        topDoorRooms.Add(roomUD);
        topDoorRooms.Add(corridorUD);

        rightDoorRooms.Add(roomLR);
        rightDoorRooms.Add(corridorLR);

        leftDoorRooms.Add(roomLR);
        leftDoorRooms.Add(corridorLR);
    }
    private void Start()
    {
        Instantiate(roomStart);
    }
    private void AddingCorners()
    {
        //Adding some end rooms to to make it more interesting;
        bottomDoorRooms.Add(roomLD);
        bottomDoorRooms.Add(roomRD);
        bottomDoorRooms.Add(roomLD);
        bottomDoorRooms.Add(roomRD);
        bottomDoorRooms.Add(roomD);

        topDoorRooms.Add(roomRU);
        topDoorRooms.Add(roomLU);
        topDoorRooms.Add(roomRU);
        topDoorRooms.Add(roomLU);
        topDoorRooms.Add(roomU);

        leftDoorRooms.Add(roomLU);
        leftDoorRooms.Add(roomLD);
        leftDoorRooms.Add(roomLU);
        leftDoorRooms.Add(roomLD);
        leftDoorRooms.Add(roomL);

        rightDoorRooms.Add(roomRD);
        rightDoorRooms.Add(roomRU);
        rightDoorRooms.Add(roomRD);
        rightDoorRooms.Add(roomRU);
        rightDoorRooms.Add(roomR);
    }

    private void EndRoomU()
    {
        topDoorRooms.Clear();
        topDoorRooms.Add(roomU);
    }
    private void EndRoomD()
    {
        bottomDoorRooms.Clear();
        bottomDoorRooms.Add(roomD);
    }
    private void EndRoomL()
    {
        leftDoorRooms.Clear();
        leftDoorRooms.Add(roomL);
    }
    private void EndRoomR()
    {
        rightDoorRooms.Clear();
        rightDoorRooms.Add(roomR);

    }
    private void Update()
    {
        if(GM.LRRooms > roomsUntilCorners && spawnCorners == false)
        {
            AddingCorners();
            spawnCorners = true;
        }
        if (rooms.Count > totalRooms && spawnEnd == false)
        {
            EndRoomU();
            spawnEnd = true;
        }
        if (rooms.Count +3 > totalRooms && spawnEnd == false)
        {
            EndRoomU();
            spawnEnd = true;
        }
        if (rooms.Count +5 > totalRooms && spawnEnd == false)
        {
            EndRoomU();
            spawnEnd = true;
        }
        if (rooms.Count +6 > totalRooms && spawnEnd == false)
        {
            EndRoomU();
            spawnEnd = true;
        }

        //if (waitTime <= 0 && spawnedBoss == false)
        //{
        //    for (int i = 0; i < rooms.Count; i++)
        //    {
        //        if (i == rooms.Count - 1)
        //        {
        //            Instantiate(boss, rooms[i].transform.position, Quaternion.identity);
        //            spawnedBoss = true;
        //        }
        //    }
        //}
        //else
        //{
        //    waitTime -= Time.deltaTime;
        //}
    }
}
