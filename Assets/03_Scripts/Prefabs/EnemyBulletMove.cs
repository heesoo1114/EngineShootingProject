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

}
