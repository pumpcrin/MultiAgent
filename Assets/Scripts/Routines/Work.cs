using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Work : Routine
{
    public override RoutineEnum routineEnum => RoutineEnum.Work;
    new WorkParam param;

    public Work(Status status): base(status){
        param = base.param as WorkParam;
    }

    public override void Start(){}
    public override void Finish(){}
    public override void Loop(){}
}
