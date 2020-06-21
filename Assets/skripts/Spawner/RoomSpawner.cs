using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSpawner : MonoBehaviour
{

	public int openingDirection;
	// 1 --> need bottom door
	// 2 --> need top door
	// 3 --> need left door
	// 4 --> need right door


	private RoomTemplates templates;
	private GameManager GM;
	private int rand;
	public bool spawned = false;
	public bool collided = false;

	public float waitTime = 1.1f;

	void Start()
	{
		GM = GameObject.FindObjectOfType<GameManager>();
		templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>();
		Invoke("Spawn", 0.5f);
		Destroy(gameObject, waitTime);
	}

	void Spawn()
	{
		if (spawned == false)
		{
			if (openingDirection == 1)
			{
				// Need to spawn a room with a BOTTOM door.
				rand = Random.Range(0, templates.bottomDoorRooms.Count);
				Instantiate(templates.bottomDoorRooms[rand], transform.position, Quaternion.identity);
			}
			else if (openingDirection == 2)
			{
				// Need to spawn a room with a TOP door.
				rand = Random.Range(0, templates.topDoorRooms.Count);
				Instantiate(templates.topDoorRooms[rand], transform.position, Quaternion.identity);
			}
			else if (openingDirection == 3)
			{
				// Need to spawn a room with a LEFT door.
				rand = Random.Range(0, templates.leftDoorRooms.Count);
				Instantiate(templates.leftDoorRooms[rand], transform.position, Quaternion.identity);
			}
			else if (openingDirection == 4)
			{
				// Need to spawn a room with a RIGHT door.
				rand = Random.Range(0, templates.rightDoorRooms.Count);
				Instantiate(templates.rightDoorRooms[rand], transform.position, Quaternion.identity);
			}
			spawned = true;
		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		collided = true;
		if (other.CompareTag("SpawnPoint"))
		{

			if (other.GetComponent<RoomSpawner>().spawned == false && spawned == false)
			{
				Instantiate(templates.closedRooms[rand], transform.position, Quaternion.identity);
				Destroy(gameObject);
			}
			spawned = true;
		}
	}
}