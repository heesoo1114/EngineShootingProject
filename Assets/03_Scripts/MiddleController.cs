using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddleController : MonoBehaviour
{

    public Transform Target;
    public float angle;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKey(KeyCode.N))
        {
            transform.Rotate(0,0, -angle);
        }
        else if(Input.GetKey(KeyCode.M))
        {
            transform.Rotate(0,0, +angle);
        }

        transform.position = Target.position;

    }
}
