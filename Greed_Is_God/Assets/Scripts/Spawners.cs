using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawners : MonoBehaviour
{
    public GameObject enemy;
    public GameObject [] spawnPoints;
    private GameObject chosenSpawnPoint;
    private int spawnCount;
    private float spawnDelay = 1f;
    private float spawnTimer = 0f;
    private RoomController roomControllerScript;

    // Start is called before the first frame update
    void Awake()
    {
        roomControllerScript = GameObject.FindObjectOfType<RoomController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(roomControllerScript.roomActive == true)
        {
            SpawnTimer();
        }      
    }

    public void Spawn()
    {
        if(spawnCount <= 10)
        {
            int spawnPointRounded;
            spawnPointRounded = Mathf.RoundToInt(Random.Range(0f, 3f));

            Instantiate(enemy, spawnPoints[spawnPointRounded].transform.position, Quaternion.identity);
            spawnCount++;
        }
    }

    public void SpawnTimer()
    {
        spawnTimer += Time.deltaTime;
        if(spawnTimer >= spawnDelay)
        {
            Spawn();
            spawnTimer = 0f;
        }
    }
}
