using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx.Triggers;
using System;

public abstract class Routine
{
    public abstract RoutineEnum routineEnum{get;}
    protected Params param;
    protected Vector3 startPosition;
    protected Status status;

    public Routine(Status _status){
        param = Database.database.GetParams(routineEnum);
        if(param == null)   return;
        startPosition = param.StartPosition;

        status = _status;
    }

    public abstract void Start();
    public abstract void Loop();
    public abstract void Finish();
    public Vector3 StartPosition => startPosition;
}

public enum RoutineEnum{
    Awake, Breakfast, Work, Lunch, Dinner, Bath, Sleep
}
