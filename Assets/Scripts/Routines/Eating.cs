using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Eating : Routine
{
    public override RoutineEnum routineEnum => RoutineEnum.Lunch;

    Parameters parameters;
    

    public Eating(Status status): base(status){
        parameters = Database.database.parameters;
    }
    public override void Start(){
        var decreasedSatiety = status.MAX_SATIETY - status.Satiety;
        var eatAmount = Math.Min(status.FoodSaving, decreasedSatiety/parameters.satietyPerFood);
        Debug.LogWarning("eatAmount: "+eatAmount);
        var recentSatiety = (int)(eatAmount * parameters.satietyPerFood + status.Satiety);
        var recentEatTime = Timer.timer.CurrentTime.Value;

        status.FoodSaving -= Mathf.CeilToInt((float)eatAmount);
        status.SetRecentEatTime(recentEatTime, recentSatiety);
    }
    public override void Loop(){
        
    }
    public override void Finish(){}
}
