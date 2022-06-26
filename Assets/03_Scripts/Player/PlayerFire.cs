using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{

    KeyCode fire = KeyCode.Space;
    public float fireTime;
    [SerializeField] GameObject bulletFactory;

    private void Awake()
    {
        StartCoroutine("Fire");
    }

    IEnumerator Fire()
    {
        while(true)
        {
            GameObject bullet = Instantiate(bulletFactory);
            bullet.transform.position = transform.position;
            yield return new WaitForSeconds(fireTime);
        }
        
        
    }
}
