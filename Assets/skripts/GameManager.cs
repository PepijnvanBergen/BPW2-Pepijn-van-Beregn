using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //We maken er een singleton van omdat dit onze game manager is.
    //Deze heeft al onze data van alle scenes.
    static GameManager instance;

    public int dungeonLength;

    public int cornerRooms;
    public int endRooms;
    public int UDRooms;
    public int LRRooms;


    public int basicRooms;
    public int endrooms;
    public int corridorRooms;

    //public static GameManager GetInstance()
    //{
    //    return instance;
    //}
    //private void Awake()
    //{
    //    instance = this;
    //}

    //private void Start()
    //{
    //    if (instance != null)
    //    {
    //        Destroy(gameObject);
    //        return;
    //    }

    //    instance = this;
    //    GameObject.DontDestroyOnLoad(gameObject);
    //}

    //Hier hebben we de functies die ervoor zorgen dat het goud
    //en de landjes bijgewerkt worden voor een score.
    //public void AddGold1(int gold)
    //{
    //    gold1 += gold;
    //}
    //Hier hebben we de functies die ervoor zorgen dat de variables
    //goud en landjes beschikbaar zijn voor alle scripts.

    //public int GetGold1()
    //{
    //    return gold1;
    //}
}
