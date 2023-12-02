using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemys : MonoBehaviour
{
    
    public GameObject EnemyPrefab;
    public Transform SpawnerLeft;
    public Transform SpawnerRight;
    
    // Start is called before the first frame update
    void Start()
    {
        Invoke("CreateEnemy", 2);
    }
   

    void CreateEnemy()
    {
        float randomX = Random.Range(SpawnerLeft.position.x, SpawnerRight.position.x);
        Vector3 spawnPosition = new Vector3(randomX, SpawnerLeft.position.y, SpawnerLeft.position.z);

        
        Instantiate(EnemyPrefab, spawnPosition, transform.rotation);
        Invoke("CreateEnemy", 2);
    }
    
}
