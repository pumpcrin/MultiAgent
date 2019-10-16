using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Routine
{
    protected Params param;
    protected Vector3 startPosition;

    public Routine(){
        param = Database.database.GetParams(this);
        if(param == null)   return;
        startPosition = param.StartPosition;
        Debug.Log(startPosition);
    }

    public abstract void Start();
    public abstract void Loop();
    public abstract void Finish();
    public Vector3 StartPosition => startPosition;
}

public enum RoutineEnum{
    Awake, Breakfast, Work, Lunch, Dinner, Bath, Sleep
}
