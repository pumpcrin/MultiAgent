using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

// デフォルトステータスの受け皿として利用することもあるため、Serializableを使用する

[Serializable]
public class Status
{
    public readonly int MAX_HP;
    public readonly int MAX_SATIETY;
    
    [NonSerialized] public int id;
    public int Hp;
    public int Satiety{
        get{
            return ;
        }
    
    }
    public int Money;

    public int FoodSaving;

    [NonSerialized] public RoutineEnum currentRoutineEnum;
    [NonSerialized] public int routineIndex;

    DateTime lastEatTime;

    public Status(Database database){
        var defaultStatus = database.parameters.VillagerDefaultStatus;
        MAX_HP = defaultStatus.Hp;
        MAX_SATIETY = (int)defaultStatus.Satiety;
        Money = defaultStatus.Money;

        lastEatTime = database.parameters.worldStartTime
        Hp = MAX_HP;
    }

    public Eat(DateTime now){
        var time = now - lastEatTime;
        
    }
    
}
