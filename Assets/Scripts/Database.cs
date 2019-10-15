using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEditorInternal;

public class Database : MonoBehaviour
{
    public static Database database;

    [SerializeField]
    protected List<RoutineEnum> routineList;
    public Parameters param;
    

    void Awake(){
        database = this;
        param = new Parameters();
    }

    void Start(){
        routineList = new List<RoutineEnum>();
        foreach(RoutineEnum value in Enum.GetValues(typeof(RoutineEnum))){
            routineList.Add(value);
            Debug.Log(value);
        }
    }

    public RoutineEnum GetRoutine(Status status){
        int index = status.routineCount%routineList.Count;
        status.routineCount = index;

        return routineList[index];
    }
}

[Serializable]
public class Parameters{

    public float navFinishDistance = 0.5f;

    public AwakeParam awake;

    public Parameters(){
        awake = new AwakeParam();
    }
}

[Serializable]
public class AwakeParam{
    public Vector3 startPosition;
}
