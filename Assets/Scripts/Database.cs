using System.Collections;
using System.Collections.Generic;
using System;
using System.Linq;
using UnityEngine;
using UnityEditorInternal;

public class Database : MonoBehaviour
{
    public static Database database;

    public Parameters param;

    //EditorによってReorderableListで表示するので、デフォルトでは表示しない (関連: EditorTest.cs)
    [HideInInspector][SerializeField] protected List<RoutineEnum> routineList;
    [HideInInspector][SerializeField][Range(0, 24)] protected List<float> routineStartHours;

    public List<TimeSpan> RoutineStartTime => routineStartHours.Select(hour => TimeSpan.FromHours(hour)).ToList();

    void Awake(){
        database = this;
    }

    void Start(){
        routineStartHours.Sort();
    }

    public RoutineEnum GetRoutine(Status status){
        int index = status.routineIndex%routineList.Count;
        status.routineIndex = index;

        return routineList[index];
    }

    //この関数の場合分けをなくしたい
    public Params GetParams(Routine routine){
        if(routine is Awake)            return param.awake;
        if(routine is Breakfast)        return param.breakfast;
        if(routine is Work)             return param.work;
        if(routine is Lunch)            return param.lunch;
        if(routine is Dinner)           return param.dinner;
        if(routine is Bath)             return param.bath;
        if(routine is Sleep)            return param.sleep;
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
    [Range(0, 24)]
    public float worldStartTime = 6;

    public AwakeParam       awake;
    public BreakfastParam   breakfast;
    public WorkParam        work;
    public LunchParam       lunch;
    public DinnerParam      dinner;
    public BathParam        bath;
    public SleepParam       sleep;
}

[Serializable]
public abstract class Params{
    
    [SerializeField] Transform startPosition;
    // [SerializeField] [Range(0, 24)] float startHour;

    public Vector3 StartPosition => startPosition.position;
    // public TimeSpan startTime => TimeSpan.FromHours(startHour);
}

[Serializable]
public class AwakeParam : Params{
    
}
[Serializable]
public class BreakfastParam : Params{
    
}
[Serializable]
public class WorkParam : Params{
    
}
[Serializable]
public class LunchParam : Params{
    
}
[Serializable]
public class DinnerParam : Params{
    
}
[Serializable]
public class BathParam : Params{
    
}
[Serializable]
public class SleepParam : Params{
    
}
