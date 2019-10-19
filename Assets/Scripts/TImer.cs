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
    Database database;

    public ReactiveProperty<DateTime> CurrentTime;

    void Start()
    {
        database = Database.database;
        beforeTime = Time.time;

        float worldStartTime = database.param.worldStartTime;
        int minute = (int)(worldStartTime%1*60);
        dateTime = new DateTime(1, 1, 1, (int)worldStartTime, minute, 0);
        CurrentTime = this.UpdateAsObservable().Select(_ => dateTime).ToReactiveProperty();

        
    }

    void Update()
    {
        if(Time.time - beforeTime >= 1){
            dateTime = dateTime.AddMinutes(1);
            beforeTime += 1;
        }
        
        var text = dateTime.ToString("MM月dd日  HH:mm");
        timeText.text = text;

        //デバッグ用
        if(Input.GetMouseButtonDown(0))
            dateTime = dateTime.AddMinutes(30);
    }
}
