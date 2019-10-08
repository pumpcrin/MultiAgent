using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum RoutineEnum{
    Awake, Breakfast, Work, Lunch, Dinner, Bath, Sleep
}

public abstract class Routine
{
    protected Vector3 startPosition;

    public abstract void Start();
    public abstract void Loop();
    public abstract void Finish();
}
