using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    private float cameraSpeed = 3f;
    public GameObject player;
    void Start()
    {

    }

    void Update()
    {
        Vector2 dir = player.transform.position - this.transform.position;
        dir += new Vector2(0, 5f);
        Vector2 moveVector = new Vector2(dir.x * cameraSpeed * Time.deltaTime, dir.y * cameraSpeed * Time.deltaTime);
        this.transform.Translate(moveVector);
    }
}