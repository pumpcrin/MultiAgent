using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Awake : Routine
{
    AwakeParam param;

    public Awake(){
        param = Database.database.param.awake;
        startPosition = param.startPosition;
    }

    public override void Start(){}
    public override void Loop(){}
    public override void Finish(){}
}
