using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEditorInternal;

public class Database : MonoBehaviour
{
    public static Database database;

    public List<RoutineEnum> routineList;

    void Awake(){
        database = this;
    }

    void Start(){
        routineList = new List<RoutineEnum>();
    }

    public void GetRoutine(){

    }
}
