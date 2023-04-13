using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPool : MonoBehaviour
{

    public int enemyPoolSize = 5;
    public GameObject enemyPrefab;
    public GameObject spikeenemyPrefab;
    public GameObject coinsPrefab;
    public float spawnRate = 4f;
    public float spawnXPosition = 10f;
    private int currentEnemy = 0;
    private float spawnYPosition = -1.2f;
    private GameObject[] sawEnemies;
    private GameObject[] spikeEnemies;
    private GameObject[] coins;
    private Vector2 objectPoolPosition = new Vector2(-15f, -25f);
    private float timeSinceLastSpawned;

    void Start()
    {
        sawEnemies = new GameObject[enemyPoolSize];
        spikeEnemies = new GameObject[enemyPoolSize];
        coins = new GameObject[enemyPoolSize];
        for (int i=0; i < enemyPoolSize; i++)
        {
            sawEnemies[i] = (GameObject)Instantiate(enemyPrefab, objectPoolPosition, Quaternion.identity);
            spikeEnemies[i] = (GameObject)Instantiate(spikeenemyPrefab, objectPoolPosition, Quaternion.identity);
            coins[i] = (GameObject)Instantiate(coinsPrefab, objectPoolPosition, Quaternion.identity);
        }
    }

    void Update()
    {
        timeSinceLastSpawned += Time.deltaTime;

        if (GameControlScript.instance.gameOver == false && timeSinceLastSpawned >= spawnRate)
        {
            timeSinceLastSpawned = 0;
            int spawnNumber = Random.Range(1, 4);
            //float spawnYPosition = Random.Range(enemyMin, enemyMax);
            if (spawnNumber == 1)
            {
                spawnYPosition = -1.2f;
            }
            else if (spawnNumber == 2)
            {
                spawnYPosition = 2.7f;
            }
            else if (spawnNumber == 3)
            {
                spawnYPosition = 7.0f;
            }

            int enemyType = Random.Range(1, 4);
            if(enemyType == 1)
            {
                sawEnemies[currentEnemy].transform.position = new Vector2(spawnXPosition, spawnYPosition);
                GameControlScript.instance.Scored(1);
            }
            else if (enemyType == 2)
            {
                spikeEnemies[currentEnemy].transform.position = new Vector2(spawnXPosition, spawnYPosition);
                GameControlScript.instance.Scored(1);
            }
            else if (enemyType == 3)
            {
                coins[currentEnemy].transform.position = new Vector2(spawnXPosition, spawnYPosition);
            }


            currentEnemy++;
            if (currentEnemy >= enemyPoolSize)
            {
                currentEnemy = 0;
            }
        }
    }
}
