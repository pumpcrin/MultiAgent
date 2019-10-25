using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eating : Routine
{
    public override RoutineEnum routineEnum => RoutineEnum.Lunch;
    new EatingParam param;

    DateTime lastEatTime;
    

    public Eating(Status status): base(status){
        param = base.param as EatingParam;
    }
    public override void Start(){
        var now = Timer.timer.CurrentTime.Value;
        var time = now - lastEatTime;
        Debug.LogWarning("param"+param);
        var decreasedSatiety = time.TotalMinutes*param.satietyDecreasePerMin;

        return (int)(lastSatiety - decreasedSatiety);
    }
    public override void Loop(){
        
    }
    public override void Finish(){}
}
