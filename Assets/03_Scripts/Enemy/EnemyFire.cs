using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour
{

    public GameObject rainbowPrefabs;
    public GameObject rockPrefabs;
    public GameObject bigBowPrefabs;

    BossHp _bossHp;
    

    private void Awake()
    {
        _bossHp = GetComponent<BossHp>();

        /// 다른 함수로 옮기기
       /* if(_bossHp.hp >= 40)
        {
            Debug.Log("111");
            StartCoroutine("FireMain");
        }
        else if(_bossHp.hp == 30) 
        {
            Debug.Log("222");
            // StartCoroutine("FireUmbrella"); 
        }
        else if(_bossHp.hp == 20)
        {
            Debug.Log("333");
            StopAllCoroutines();
            StartCoroutine("FireRock");
        }
        else if(_bossHp.hp == 10)
        {
            Debug.Log("444");
            StartCoroutine("FireUmbrella"); 
            StartCoroutine("FireMain"); 
            StartCoroutine("FireRock");
        }*/

        StartCoroutine("FireUmbrella"); // 곡선 분사
        StartCoroutine("FireUmbrellaBig"); // 곡선 분사 총알 큰 버전
        StartCoroutine("FireMain"); // 여러개 분사
        StartCoroutine("FireMainBig"); // 여러개 분사 총알 큰 버전
        StartCoroutine("FireRock"); //랜덤 암석 떨구기
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

    IEnumerator FireMainBig()
    {
        yield return new WaitForSeconds(4f);

        while (true)
        {
            a = 90 / 5;
            for (int i = a; i < 180; i += a)
            {
                Instantiate(bigBowPrefabs, transform.position, Quaternion.Euler(0, 0, 90 + i));
            }

            yield return new WaitForSeconds(13f);
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

    IEnumerator FireUmbrellaBig()
    {
        while (true)
        {
            a = 90 / 5;
            for (int i = a; i < 180; i += a)
            {
                Instantiate(bigBowPrefabs, transform.position, Quaternion.Euler(0, 0, 90 + i));
                yield return new WaitForSeconds(0.2f);
            }

            yield return new WaitForSeconds(15f);
        }
    }

    IEnumerator FireRock()
    {
        while(true)
        {
            Instantiate(rockPrefabs, transform.position, Quaternion.Euler(0, 0, -180));
            yield return new WaitForSeconds(5f);
        }

        
    }





}
