using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public abstract class Routine
{
    public abstract RoutineEnum routineEnum{get;}
    protected Params param;
    protected Vector3 startPosition;

    public Routine(){
        param = Database.database.GetParams(routineEnum);
        if(param == null)   return;
        startPosition = param.StartPosition;
    }

    public abstract void Start();
    public abstract void Loop();
    public abstract void Finish();
    public Vector3 StartPosition => startPosition;
}

public enum RoutineEnum{
    Awake, Breakfast, Work, Lunch, Dinner, Bath, Sleep
}
