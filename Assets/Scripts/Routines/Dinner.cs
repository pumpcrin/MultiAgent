﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dinner : Eating
{
    public override RoutineEnum routineEnum => RoutineEnum.Dinner;
    new DinnerParam param;

    public Dinner(Status status): base(status){
        param = base.param as DinnerParam;
    }
    // public override void Start(){}
    // public override void Loop(){}
    // public override void Finish(){}
}
