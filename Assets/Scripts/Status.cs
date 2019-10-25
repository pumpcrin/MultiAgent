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
    public int Satiety;
    public int Money;

    public int FoodSaving;

    [NonSerialized] public RoutineEnum currentRoutineEnum;
    [NonSerialized] public int routineIndex;

    // シリアライズ用constructor
    public Status(){}

    public Status(Database database){
        param = database.parameters;
        var defaultStatus = param.VillagerDefaultStatus;
        MAX_HP = defaultStatus.Hp;
        MAX_SATIETY = (int)defaultStatus.Satiety;
        Money = defaultStatus.Money;
        FoodSaving = defaultStatus.FoodSaving;

        lastEatTime = Timer.timer.CurrentTime.Value;
        Hp = MAX_HP;
    }

    public void Eat(){
        var eatAmount = Math.Min(FoodSaving, Satiety/param.satietyPerFood);
        lastSatiety = (int)(eatAmount * param.satietyPerFood + Satiety);

        FoodSaving -= Mathf.CeilToInt((float)eatAmount);
    }
    
}
