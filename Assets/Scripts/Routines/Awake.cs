using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Awake : Routine
{
    new AwakeParam param;

    public Awake(): base(){
        param = base.param as AwakeParam;
    }

    public override void Start(){}
    public override void Loop(){}
    public override void Finish(){}
}
