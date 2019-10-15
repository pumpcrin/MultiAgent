using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System;

public class VillagerNavigation : MonoBehaviour
{

    Database database;
    NavMeshAgent nav;
    Action finishMethod;

    void Start()
    {
        database = Database.database;
        nav = GetComponent<NavMeshAgent>();
        nav.isStopped  = false;
    }

    void Update()
    {
        var destination = Vector3.Scale(nav.destination, new Vector3(1, 0, 1));
        var current = Vector3.Scale(transform.position, new Vector3(1, 0, 1));

        if(Vector3.Distance(current, destination) < database.param.navFinishDistance){
            nav.isStopped = true;
            finishMethod();
        }

    }

    public void SetTarget(Vector3 target, Action _finishMethod){
        nav.destination = target;
        finishMethod = _finishMethod;
    }

}
