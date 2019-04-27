using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    //An array of spawns and enemies are made, so that more spawns and enemies can be later implemented.
    public Transform[] spawnPoints;
    public GameObject[] enemies;
    int randomSpawnPoint, randomEnemy;
    public static bool spawnAllowed;
    void Start()
    {
        //Enemies are spawned at a rate declared below.
        spawnAllowed = true;
        InvokeRepeating("SpawnAnEnemy", 1f, 2f);
    }

    
    void SpawnAnEnemy()
    {
        if (spawnAllowed)
        {
            //Script randomly selects which and where enemies spawn.
            randomSpawnPoint = Random.Range(0, spawnPoints.Length);
            randomEnemy = Random.Range(0, enemies.Length);
            Instantiate(enemies[randomEnemy], spawnPoints[randomSpawnPoint].position,
                Quaternion.identity);
        }
    }
}
