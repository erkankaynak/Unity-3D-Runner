using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ObstacleSpawnerScript : MonoBehaviour
{
    public GameObject[] obstacles;
    private float lastSpawnPosition;

    void Start()
    {
        lastSpawnPosition = 0f;
        
        InvokeRepeating("SpawnObstacle", 0f, 2f);
    }
    public void SpawnObstacle()
    {
        for (int i = 0; i < 5; i++)
        {
            var rnd = Random.Range(0, obstacles.Length - 1);
            var obstacle = obstacles[rnd];

            Instantiate(obstacle, new Vector3(0f, 1f, lastSpawnPosition + 30f), Quaternion.identity);
            lastSpawnPosition += 30f;
        }
    }

}
