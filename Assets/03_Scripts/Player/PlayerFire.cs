using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{

    KeyCode fire = KeyCode.Space;
    public float fireTime;
    [SerializeField] GameObject bulletFactory;

    
    // Start is called before the first frame update
    void Start()
    {
        /*GameObject target = GameObject.Find("Star");
        transform.position = target.transform.position;*/
    }

    private void Awake()
    {
        StartCoroutine("Fire");
    }

    // Update is called once per frame
    void Update()
    {
        
        /*if(Input.GetKeyDown(fire))
        {
            StartCoroutine("Fire");
        }
        else if(Input.GetKeyUp(fire))
        {
            StopCoroutine("Fire");
        }*/

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
