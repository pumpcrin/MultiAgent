using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UniRx;
using UniRx.Triggers;

public class Timer : MonoBehaviour
{
    public Text timeText;

    float beforeTime;

    DateTime dateTime;

    ReactiveProperty<DateTime> TimeObservable;

    void Start()
    {
        beforeTime = Time.time;

        dateTime = new DateTime(1, 1, 1, 6, 0, 0);
        TimeObservable = this.UpdateAsObservable().Select(_ => dateTime).ToReactiveProperty();
    }

    void Update()
    {
        if(Time.time - beforeTime >= 1){
            dateTime = dateTime.AddMinutes(1);
            beforeTime += 1;
        }
        
        var text = dateTime.ToString("MM月dd日  hh:mm");
        timeText.text = text;
    }
}
