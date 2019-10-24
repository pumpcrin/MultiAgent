using System.Collections;
using System.Collections.Generic;
using System;
using System.Linq;
using UnityEngine;
using UnityEngine.Serialization;

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
    public float satietyDecreasePerMin;
    public float satietyPerFood;

    // public List<Params> paramList = new List<Params>(Enum.GetNames(typeof(RoutineEnum)).Count());
    public Status VillagerDefaultStatus;    //いずれランダムにするため、変数の意味はそのうち変更する予定
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
public abstract class EatingParam : Params{
    public override RoutineEnum paramEnum{get;}
}


[Serializable]
public class AwakeParam : Params{
    public override RoutineEnum paramEnum => RoutineEnum.Awake;
}
[Serializable]
public class BreakfastParam : EatingParam{
    public override RoutineEnum paramEnum => RoutineEnum.Breakfast;
}
[Serializable]
public class WorkParam : Params{
    public override RoutineEnum paramEnum => RoutineEnum.Work;
}
[Serializable]
public class LunchParam : EatingParam{
    public override RoutineEnum paramEnum => RoutineEnum.Lunch;
}
[Serializable]
public class DinnerParam : EatingParam{
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