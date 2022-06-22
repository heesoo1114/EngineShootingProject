using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour
{

    public GameObject rainbowPrefabs;
    

    private void Awake()
    {
        StartCoroutine("FireUmbrella"); // 곡선 분사
        StartCoroutine("FireMain"); // 여러개 분사
    }

    


    public int count = 10;
    int a;

    IEnumerator FireMain()
    {
        yield return new WaitForSeconds(2f);
        while (true)
        {
            a = 90 / 5;
            for (int i = a; i < 180; i += a)
            {
                Instantiate(rainbowPrefabs, transform.position, Quaternion.Euler(0, 0, 90 + i));
            }

            yield return new WaitForSeconds(5f);
        }
    }

    IEnumerator FireUmbrella()
    {
        while(true)
        {
            a = 90 / 5;
            for (int i = a; i < 180; i += a)
            {
                Instantiate(rainbowPrefabs, transform.position, Quaternion.Euler(0, 0, 90 + i));
                yield return new WaitForSeconds(0.1f);
            }

             yield return new WaitForSeconds(7f);
        }
    }



}
