using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowRock : MonoBehaviour
{
    GameObject target;
    Vector2 dir;
    public float downSpeed = 5f;

    private void Start()
    {
        target = GameObject.Find("Player");
        dir = transform.position - target.transform.position;
    }

    private void Update()
    {

        
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
