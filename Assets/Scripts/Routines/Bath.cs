using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bath : Routine
{
    new BathParam param;

    public Bath(): base(){
        param = base.param as BathParam;
    }

    public override void Loop(){}
    public override void Start(){}
    public override void Finish(){}
}
