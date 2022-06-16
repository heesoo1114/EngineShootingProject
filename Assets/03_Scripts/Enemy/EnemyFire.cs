using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour
{

    public GameObject bulletPrefabs;
    

    private void Awake()
    {
        StartCoroutine("Fire");
        
    }

    IEnumerator Fire()
    {
        while(true)
        {
            Instantiate(bulletPrefabs, transform.position, Quaternion.identity);
            
            yield return new WaitForSeconds(3f);
        }
    }



}
