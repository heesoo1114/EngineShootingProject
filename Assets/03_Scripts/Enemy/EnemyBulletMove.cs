using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletMove : MonoBehaviour
{
    public float speed =3f;
    private void FixedUpdate()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Ground"))
        {
            Destroy(gameObject);
        }

        if(collision.CompareTag("Player"))
        {
            Destroy(gameObject);
        }

        if(collision.CompareTag("D_Zone"))
        {
            Destroy(gameObject);    
        }
    }

}
