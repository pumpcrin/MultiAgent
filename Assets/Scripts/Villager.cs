using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UniRx;
using System.Linq;
using System;

public enum WorkState{
    Move, Work, Finish
}

[RequireComponent (typeof(VillagerNavigation))]
public class Villager : MonoBehaviour
{

    Database database;
    Status status;
    VillagerNavigation moveScript;
    Dictionary<RoutineEnum, Routine> routines;
    Routine currentRoutine;

    WorkState workState;

    void Start()
    {
        database = Database.database;
        status = new Status();
        moveScript = GetComponent<VillagerNavigation>();

        var timer = database.GetComponent<Timer>();
        timer.CurrentTime
            .Where(dateTime => {
                if(currentRoutine == null)  Debug.Log("Error is \"where1\"");
                if(dateTime == null)  Debug.Log("Error is \"where2\"");
                return currentRoutine.startTime < dateTime.TimeOfDay;
            })
            .Subscribe(dateTime => ChangeRoutine());

        workState = WorkState.Move;
        CreateRoutines();

        
        ChangeRoutine();
    }

    void Update()
    {
      switch(workState){
        case WorkState.Work:    currentRoutine.Loop();     break;
        //case WorkState.Finish:  //モーションの間待つ   break;
        case WorkState.Finish:  currentRoutine.Finish();   break;  //今の間だけ（仮）
      }
    }

    void ToLoop(){
        currentRoutine.Start();
        Debug.Log("start: "+status.currentRoutineEnum);
    }

    void CreateRoutines(){
        routines = new Dictionary<RoutineEnum, Routine>();
        foreach(RoutineEnum enu in Enum.GetValues(typeof(RoutineEnum))){
            var type = Type.GetType(enu.ToString());
            var instance = Activator.CreateInstance(type) as Routine;
            routines.Add(enu, instance);
        }
    }

    //タイマーから呼ばれる（割り込み）
    public void FinishRoutine(){
        currentRoutine.Finish();
        workState = WorkState.Finish;
        Debug.Log("finish: "+GetType().ToString());
    }

    //終了モーションなどがある場合はそれが終わり次第これを呼ぶ
    public void ChangeRoutine(){

        status.routineCount++;
        status.currentRoutineEnum = database.GetRoutine(status);

        currentRoutine = routines[status.currentRoutineEnum];
        moveScript.SetTarget(currentRoutine.StartPosition, ToLoop);
    }
}
