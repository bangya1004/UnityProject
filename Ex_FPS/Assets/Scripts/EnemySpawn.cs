using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField]
    private Transform spawnPoint;
    [SerializeField]
    private GameObject enemyPrefab;

    void Awake()
    {
        StartCoroutine("SpawnEnemy");
    }

    void Update()
    {

    }

    IEnumerator SpawnEnemy()
    {
        while (true)
        {
            Instantiate(enemyPrefab, transform.position, Quaternion.identity);
        }

        yield return new WaitForSeconds(3.0f);
    }
}
