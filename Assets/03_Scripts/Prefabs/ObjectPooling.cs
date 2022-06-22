using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooling : MonoBehaviour
{
    [SerializeField] private GameObject pool1;

    private void Start()
    {
        Instantiate(pool1, transform);
    }
}
