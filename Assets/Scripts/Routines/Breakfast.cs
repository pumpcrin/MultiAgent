﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakfast : Eating
{
    public override RoutineEnum routineEnum => RoutineEnum.Breakfast;
    new BreakfastParam param;

    public Breakfast(Status status): base(status){
        param = base.param as BreakfastParam;
    }
    // public override void Start(){}
    // public override void Loop(){}
    // public override void Finish(){}
}
