using System.Collections;
using System.Collections.Generic;
using System;
using System.Linq;
using UnityEngine;
using UnityEditorInternal;

// Routine追加手順
// RoutineEnum, Routineを継承したclass, Paramsを継承したクラスを定義
// ParametersにParamsを継承したクラスの変数を定義し、その変数をparamListに追加
// Paramsを継承したクラスにstatic変数として対応したRoutineEnumを追加する
// おそらくこれだけ

public class Database : MonoBehaviour
{
    public static Database database;

    public Parameters parameters;

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
    // public Params GetParams(Routine routine){
    //     if(routine is Awake)            return param.awake;
    //     if(routine is Breakfast)        return param.breakfast;
    //     if(routine is Work)             return param.work;
    //     if(routine is Lunch)            return param.lunch;
    //     if(routine is Dinner)           return param.dinner;
    //     if(routine is Bath)             return param.bath;
    //     if(routine is Sleep)            return param.sleep;
    //     else{
    //         Debug.LogWarning("Database.GetParam: parameter is not defined.\nargument: "+routine.GetType().ToString());
    //         return null;
    //     }
    // }

    public Params GetParams(RoutineEnum routineEnum){
        var param = parameters.paramList.Where(p => p.paramEnum == routineEnum).First();
        if(param == null){
            Debug.LogWarning("Database.GetParam: parameter is not defined.\nargument: "+routineEnum);
        }
        return param;
    }
    // }
}

[Serializable]
public class Parameters{

    public float navFinishDistance = 0.5f;
    [Range(0, 24)]
    public float worldStartTime = 6;

    // public List<Params> paramList = new List<Params>(Enum.GetNames(typeof(RoutineEnum)).Count());
    public List<Params> paramList => new List<Params>(){awake, breakfast, work, lunch, dinner, bath, sleep};

    [SerializeField] AwakeParam       awake;
    [SerializeField] BreakfastParam   breakfast;
    [SerializeField] WorkParam        work;
    [SerializeField] LunchParam       lunch;
    [SerializeField] DinnerParam      dinner;
    [SerializeField] BathParam        bath;
    [SerializeField] SleepParam       sleep;

    // public Parameters(){
    //     var enums = Enum.GetNames(typeof(RoutineEnum));
    //     paramList = new List<Params>(enums.Count());
    //     foreach(var enu in enums){
    //         paramList.
    //     }
    // }
}

[Serializable]
public abstract class Params{
    public abstract RoutineEnum paramEnum{get;}
    [SerializeField] Transform startPosition;

    public Vector3 StartPosition => startPosition.position;
}
[Serializable]
public class AwakeParam : Params{
    public override RoutineEnum paramEnum => RoutineEnum.Awake;
}
[Serializable]
public class BreakfastParam : Params{
    public override RoutineEnum paramEnum => RoutineEnum.Breakfast;
}
[Serializable]
public class WorkParam : Params{
    public override RoutineEnum paramEnum => RoutineEnum.Work;
}
[Serializable]
public class LunchParam : Params{
    public override RoutineEnum paramEnum => RoutineEnum.Lunch;
}
[Serializable]
public class DinnerParam : Params{
    public override RoutineEnum paramEnum => RoutineEnum.Dinner;
}
[Serializable]
public class BathParam : Params{
    public override RoutineEnum paramEnum => RoutineEnum.Bath;
}
[Serializable]
public class SleepParam : Params{
    public override RoutineEnum paramEnum => RoutineEnum.Sleep;
}