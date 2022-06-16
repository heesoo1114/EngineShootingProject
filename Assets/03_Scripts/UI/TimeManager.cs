using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    [SerializeField]
    private Text TimeText;

    private float count;
    private bool time = false;

    private void Update()
    {
        
        if(time == false)
        {
            time = true;
            StartCoroutine(time_1());
        }
    }

    IEnumerator time_1()
    {

        yield return new WaitForSeconds(1f);
        count += 1f;
        TimeText.text = "Time : " + count;
        time = false;

    }



}

 

