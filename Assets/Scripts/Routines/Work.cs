using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Work : Routine
{
    new WorkParam param;

    public Work(): base(){
        param = base.param as WorkParam;
    }

    public override void Start(){}
    public override void Finish(){}
    public override void Loop(){}
}
