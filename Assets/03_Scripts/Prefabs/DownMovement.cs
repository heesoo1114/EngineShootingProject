using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownMovement : MonoBehaviour
{
    public float downSpeed = 5f;
    Vector2 dir;

    private void Update()
    {
        
        dir = Vector2.up;
        transform.Translate(dir.normalized * downSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground"))
        {
            Destroy(gameObject);
        }

        if (collision.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }

}
