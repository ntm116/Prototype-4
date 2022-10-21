using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject powerupPrefab;
    public int waveNumver = 1;

    private float spawnRange = 9f;

    public int enemyCount;
    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemyWave(waveNumver);
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = FindObjectsOfType<EnemyBehaviour>().Length;

        if (enemyCount < 1)
        {
            SpawnEnemyWave(waveNumver);
            SpawnPowerup();
            waveNumver++;
        }
    }

    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
    }

    void SpawnPowerup()
    {
        Instantiate(powerupPrefab, GenerateSpawnPosition(0), powerupPrefab.transform.rotation);
    }

    void SpawnEnemyWave(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            SpawnEnemy();
        }
        
    }

    Vector3 GenerateSpawnPosition(int posY = 6) { 
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);

        return new(spawnPosX, posY, spawnPosZ);
    }
}
