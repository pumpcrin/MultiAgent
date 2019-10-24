﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bath : Routine
{
    public override RoutineEnum routineEnum => RoutineEnum.Bath;
    new BathParam param;

    public Bath(Status status): base(status){
        param = base.param as BathParam;
    }

    public override void Loop(){}
    public override void Start(){}
    public override void Finish(){}
}
