using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    private List<GameObject> spawnedEnemies;
    //[SerializeField] private int numOfEnemies;
    public GameObject emenyPrefab;
    public List<Transform> spawnPoints = new List<Transform>();
    public PlayerMovement player;
    public int spawnTime;
    public int maxEnemyCount;
    private int enemyCount = 0;


    private void Awake()
    {
        spawnedEnemies = new List<GameObject>();
    }

    void Start()
    {
        StartCoroutine(SpawnCoroutine(spawnTime));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator SpawnCoroutine(int timeForSpawn)
    {
        System.Random randomIndex = new System.Random();
        while(true)
        {
            int index = randomIndex.Next(0, spawnPoints.Count);
            Vector3 spawnPosition = spawnPoints[index].position;

            GameObject instantiatedEnemy = Instantiate(emenyPrefab, spawnPosition, Quaternion.identity);
        
            spawnedEnemies.Add(instantiatedEnemy);
            enemyCount++;

            if(enemyCount >= maxEnemyCount)
            {
                yield break; //zaustavlja se korutina
            }

            yield return new WaitForSecondsRealtime(timeForSpawn);
        }
    }
}
