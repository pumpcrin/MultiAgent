using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Awake : Routine
{
    public override RoutineEnum routineEnum => RoutineEnum.Awake;
    new AwakeParam param;

    public Awake(): base(){
        param = base.param as AwakeParam;
    }

    public override void Start(){}
    public override void Loop(){}
    public override void Finish(){}
}
