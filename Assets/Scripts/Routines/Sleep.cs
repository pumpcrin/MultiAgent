﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sleep : Routine
{
    public override RoutineEnum routineEnum => RoutineEnum.Sleep;
    new SleepParam param;

    public Sleep(): base(){
        param = base.param as SleepParam;
    }

    public override void Start(){}
    public override void Loop(){}
    public override void Finish(){}
}
