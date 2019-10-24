using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eating : Routine
{
    public override RoutineEnum routineEnum => RoutineEnum.Lunch;
    new EatingParam param;

    public Eating(Status status): base(status){
        param = base.param as EatingParam;
    }
    public override void Start(){}
    public override void Loop(){}
    public override void Finish(){}
}
