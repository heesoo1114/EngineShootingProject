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
        transform.localRotation = Quaternion.Euler(0,0, angle);
        if(Input.GetKey(KeyCode.N))
        {
            angle += 2.5f;
        }
        else if(Input.GetKey(KeyCode.M))
        {
            angle -= 2.5f;
        }

        transform.position = Target.position;
    }
}
