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

        /// �ٸ� �Լ��� �ű��
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

        StartCoroutine("FireUmbrella"); // � �л�
        StartCoroutine("FireUmbrellaBig"); // � �л� �Ѿ� ū ����
        StartCoroutine("FireMain"); // ������ �л�
        StartCoroutine("FireMainBig"); // ������ �л� �Ѿ� ū ����
        StartCoroutine("FireRock"); //���� �ϼ� ������
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
