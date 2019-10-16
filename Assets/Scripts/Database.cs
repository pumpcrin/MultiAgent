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
    }

    void Start(){
        routineList = new List<RoutineEnum>();
        foreach(RoutineEnum value in Enum.GetValues(typeof(RoutineEnum))){
            routineList.Add(value);
        }
    }

    public RoutineEnum GetRoutine(Status status){
        int index = status.routineCount%routineList.Count;
        status.routineCount = index;

        return routineList[index];
    }

    //この関数の場合分けをなくしたい
    public Params GetParams(Routine routine){
        if(routine is Awake)    return param.awake;
        // else                    throw new InvalidOperationException();
        else{
            Debug.LogWarning("Database.GetParam: parameter is not defined.\nargument: "+routine.GetType().ToString());
            return null;
        }
    }
    // }
}

[Serializable]
public class Parameters{

    public float navFinishDistance = 0.5f;

    public AwakeParam awake;
}

[Serializable]
public abstract class Params{
    
    [SerializeField] Transform startPosition;

    public Vector3 StartPosition => startPosition.position;
}

[Serializable]
public class AwakeParam : Params{
    
}
