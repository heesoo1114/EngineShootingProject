using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public StageData StageData;
    public GameObject enemyFactory;
    public GameObject bossPrefabs;
    public float spawnTime;
    public int maxCount;
    

    private void Awake()
    {
        StartCoroutine("EnemySpawn");
    }

    IEnumerator EnemySpawn()
    {

        int enemyCount = 0;

        while (true)

        {
            float positionX = Random.Range(StageData.LimitMin.x, StageData.LimitMax.x);
            GameObject enemy = Instantiate(enemyFactory, new Vector3(positionX, StageData.LimitMax.y + 1.0f, 0.0f), Quaternion.identity);
            // enemy.transform.position = transform.position;

            enemyCount++;
            if(enemyCount >= maxCount)
            {
                
                StopCoroutine("EnemySpawn");
                StartCoroutine("BossSpawn");
                break;

            }

            yield return new WaitForSeconds(spawnTime);
        }

    }

    private IEnumerator BossSpawn()
    {
        
        Instantiate(bossPrefabs, new Vector3(0.32f, 11.63f, 0), Quaternion.identity);
        yield return null;
    }

    
}
