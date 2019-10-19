using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakfast : Routine
{
    new BreakfastParam param;

    public Breakfast(): base(){
        param = base.param as BreakfastParam;
    }
    public override void Start(){}
    public override void Loop(){}
    public override void Finish(){}
}
