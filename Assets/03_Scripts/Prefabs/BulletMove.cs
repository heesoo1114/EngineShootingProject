using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{

    public float bulletSpeed;
    
    Vector3 dir;
    
    // Start is called before the first frame update
    void Start()
    {
        GameObject target = GameObject.Find("Star");
        dir = target.transform.position - transform.position;
        transform.rotation = target.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position += dir * bulletSpeed * Time.deltaTime;
        dir.Normalize();


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 7)
        {
            Destroy(gameObject);
        }

        if(collision.CompareTag("Boss"))
        {
            Destroy(gameObject);
        }
    }
}
