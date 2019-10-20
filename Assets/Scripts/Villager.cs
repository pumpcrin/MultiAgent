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

        //タイマーセット
        var timer = database.GetComponent<Timer>();
        timer.CurrentTime
            .Where(IsChangeTime)
            .Subscribe(dateTime => {FinishRoutine(); ChangeRoutine();});

        workState = WorkState.Move;
        CreateRoutines();
        SetFirstRoutine(timer);
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(1)) Debug.Log("currentRoutine: "+status.currentRoutineEnum);

        switch(workState){
            case WorkState.Work:    currentRoutine.Loop();     break;
            //case WorkState.Finish:  //モーションの間待つ    break;
            case WorkState.Finish:  currentRoutine.Finish();   break;  //今の間だけ（仮）
        }
    }

    void ToLoop(){
        currentRoutine.Start();
        workState = WorkState.Work;
        // Debug.Log("start: "+status.currentRoutineEnum);
    }

    Boolean IsChangeTime(DateTime dateTime){
        int routineCount = database.RoutineStartTime.Count();
        int nextIndex = (status.routineIndex+1);
        //その日のルーティーンが全て終わっているなら、次の日まで状態遷移しない
        if(nextIndex >= routineCount){
            if(dateTime.TimeOfDay > database.RoutineStartTime[status.routineIndex]) return false;
            else    nextIndex %= routineCount;
        }
        
        return (database.RoutineStartTime[nextIndex] <= dateTime.TimeOfDay);
    }

    void CreateRoutines(){
        routines = new Dictionary<RoutineEnum, Routine>();
        foreach(RoutineEnum enu in Enum.GetValues(typeof(RoutineEnum))){
            var type = Type.GetType(enu.ToString());
            var instance = Activator.CreateInstance(type) as Routine;
            routines.Add(enu, instance);
        }
    }

    void SetFirstRoutine(Timer timer){
        DateTime now = timer.CurrentTime.Value;
        // DateTime now = new DateTime(1, 1, 1, 6, 0, 0);
        int finishRoutineCount = database.RoutineStartTime.TakeWhile(startTime => now.TimeOfDay > startTime)
                                            .Count();
        int routineCount = database.RoutineStartTime.Count();
        status.routineIndex = (finishRoutineCount+routineCount-1)%routineCount - 1;    //最初のルーティーンのindexをセット（ChangeRoutineで1足すことを考慮する）
        
        ChangeRoutine();
    }

    //タイマーから呼ばれる（割り込み）
    void FinishRoutine(){
        currentRoutine.Finish();
        workState = WorkState.Finish;
        // Debug.Log("finish: "+status.currentRoutineEnum);
    }

    //終了モーションなどがある場合はそれが終わり次第これを呼ぶ
    public void ChangeRoutine(){

        status.routineIndex++;
        status.currentRoutineEnum = database.GetRoutine(status);

        currentRoutine = routines[status.currentRoutineEnum];
        moveScript.SetTarget(currentRoutine.StartPosition, ToLoop);
    }
}
