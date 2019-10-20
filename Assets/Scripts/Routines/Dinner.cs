using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dinner : Routine
{
    public override RoutineEnum routineEnum => RoutineEnum.Dinner;
    new DinnerParam param;

    public Dinner(): base(){
        param = base.param as DinnerParam;
    }
    public override void Start(){}
    public override void Loop(){}
    public override void Finish(){}
}
