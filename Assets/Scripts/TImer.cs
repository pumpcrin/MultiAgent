using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{

    int day;
    int hour;
    int minute;
    float time;    

    float startTime;

    void Start()
    {
        startTime = Time.time;
        Debug.Log("Start time: "+startTime);
    }

    void Update()
    {
        time = Time.time - startTime;
        if(time > 60) minute++;

        if(Input.GetMouseButtonDown(0)) Debug.LogWarning("m/t: "+minute+"/"+time);
    }
}
