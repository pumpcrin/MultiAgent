using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UniRx;
using UniRx.Triggers;

public class Timer : MonoBehaviour
{
    public static Timer timer = null;
    public Text timeText;

    float beforeTime;

    Database database;

    public ReactiveProperty<DateTime> CurrentTime;

    void Awake(){
        if(timer == null)   timer = this;
    }

    void Start()
    {
        database = Database.database;
        beforeTime = Time.time;

        float worldStartTime = database.parameters.worldStartTime;
        int minute = (int)(worldStartTime%1*60);
        // CurrentTime = this.UpdateAsObservable().Select(_ => CurrentTime.Value).ToReactiveProperty();
        CurrentTime = new ReactiveProperty<DateTime>();
        CurrentTime.Value = new DateTime(1, 1, 1, (int)worldStartTime, minute, 0);
        
    }

    void Update()
    {
        if(Time.time - beforeTime >= 1){
            CurrentTime.Value = CurrentTime.Value.AddMinutes(1);
            beforeTime += 1;
        }
        
        var text = CurrentTime.Value.ToString("MM月dd日  HH:mm");
        timeText.text = text;

        //デバッグ用
        if(Input.GetMouseButtonDown(0))
            CurrentTime.Value = CurrentTime.Value.AddMinutes(30);
    }
}
