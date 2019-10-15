using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System;

[RequireComponent (typeof(VillagerNavigation))]
public class Villager : MonoBehaviour
{

    Database database;
    Status status;
    VillagerNavigation moveScript;
    Dictionary<RoutineEnum, Routine> routines;
    Routine currentRoutine;

    bool isMoving;

    void Start()
    {
        database = Database.database;
        status = new Status();
        moveScript = GetComponent<VillagerNavigation>();
        isMoving = false;
        CreateRoutines();
        ChangeRoutine();
    }

    void Update()
    {
      if(!isMoving)
        Work(currentRoutine);
    }

    void ToWork(){
        
    }

    void Work(Routine routine){

    }

    void CreateRoutines(){
        routines = new Dictionary<RoutineEnum, Routine>();
        foreach(RoutineEnum enu in Enum.GetValues(typeof(RoutineEnum))){
            var type = Type.GetType(enu.ToString());
            var instance = Activator.CreateInstance(type) as Routine;
            routines.Add(enu, instance);
        }
    }

    public void ChangeRoutine(){

        status.routineCount++;
        status.currentRoutineEnum = database.GetRoutine(status);

        currentRoutine = routines[status.currentRoutineEnum];
        moveScript.SetTarget(currentRoutine.StartPosition, ToWork);
    }
}
