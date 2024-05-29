using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform[] spawnPoint;
    public GameObject enemyPrefab;

    public float countdownTime = 5f;
    private float currentTime;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = countdownTime;
    }

    // Update is called once per frame
    void Update()
    {
        if(currentTime > 0)
        {
            currentTime -= Time.deltaTime;
            if(currentTime <= 0)
            {
                EnemySpawn();
                currentTime = countdownTime;
            }
        }
        
    }
    void EnemySpawn()
    {
        int randSpawnPoint = Random.Range(0, spawnPoint.Length);
        Instantiate(enemyPrefab, spawnPoint[randSpawnPoint].position, transform.rotation);
    }
}
