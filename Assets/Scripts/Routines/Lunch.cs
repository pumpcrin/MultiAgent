using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lunch : Routine
{
    new LunchParam param;

    public Lunch(): base(){
        param = base.param as LunchParam;
    }
    public override void Start(){}
    public override void Loop(){}
    public override void Finish(){}
}
