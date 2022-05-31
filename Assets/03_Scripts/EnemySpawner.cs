using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public StageData StageData;
    public GameObject enemyFactory;
    public float spawnTime;
    
    

    private void Awake()
    {
        StartCoroutine("EnemySpawn");
    }

    IEnumerator EnemySpawn()
    {
        while (true)

        {
            float positionX = Random.Range(StageData.LimitMin.x, StageData.LimitMax.x);
            GameObject enemy = Instantiate(enemyFactory, new Vector3(positionX, StageData.LimitMax.y + 1.0f, 0.0f), Quaternion.identity);
            // enemy.transform.position = transform.position;
            yield return new WaitForSeconds(spawnTime);
        }

    }

    
}
