using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestSpawner : MonoBehaviour
{
    public GameObject chest;
    int rand;

    private void Start()
    {
        rand = Random.Range(0, 3);

        if(rand == 1)
        {
            Instantiate(chest, transform.position, Quaternion.identity);
        }
    }
}
