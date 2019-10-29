using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

// デフォルトステータスの受け皿として利用することもあるため、Serializableを使用する

public class Status
{
    public readonly int MAX_HP;
    public readonly int MAX_SATIETY;
    
    [NonSerialized] public int id;
    public int Hp;
    public int Satiety{
        get{
            var now = Timer.timer.CurrentTime.Value;
            var time = now - recentEatTime;
            var decreasedSatiety = time.TotalMinutes*statusParam.satietyDecreasePerMin;

            Debug.Log("recentSatiety: "+recentSatiety);

            return (int)(recentSatiety - decreasedSatiety);
        }
    }
    public int Money;

    public int FoodSaving;

    [NonSerialized] public RoutineEnum currentRoutineEnum;
    [NonSerialized] public int routineIndex;

    // public DateTime RecentEatTime => recentEatTime;
    
    StatusParam statusParam;
    DateTime recentEatTime;
    int recentSatiety;


    // シリアライズ用constructor

    public Status(){
        statusParam = Database.database.parameters.statusParam;

        MAX_HP = statusParam.DefaultHp;
        MAX_SATIETY = (int)statusParam.DefaultSatiety;
        Money = statusParam.DefaultMoney;
        FoodSaving = statusParam.DefaultFoodSaving;

        recentEatTime = Timer.timer.CurrentTime.Value;
        recentSatiety = MAX_SATIETY;
        Hp = MAX_HP;
    }

    public void SetRecentEatTime(DateTime _recentEatTime, int _recentSatiety){
        recentEatTime = _recentEatTime;
        recentSatiety = _recentSatiety;
        Debug.LogWarning("Set!");
    }
}
