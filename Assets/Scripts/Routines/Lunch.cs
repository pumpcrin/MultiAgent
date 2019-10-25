using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lunch : Routine
{
    public override RoutineEnum routineEnum => RoutineEnum.Lunch;
    new LunchParam param;

    public Lunch(Status status): base(status){
        param = base.param as LunchParam;
    }
    public override void Start(){}
    public override void Loop(){}
    public override void Finish(){}
}
