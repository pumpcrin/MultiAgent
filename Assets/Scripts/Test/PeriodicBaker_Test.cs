using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System;
using System.Linq;
using UniRx.Triggers;
using UniRx;

public class PeriodicBaker_Test : MonoBehaviour
{
    void Start()
    {
        var surface = GetComponent<NavMeshSurface>();
        Observable.Interval(TimeSpan.FromSeconds(1)).Subscribe(_ => surface.BuildNavMesh()).AddTo(this);
    }

}
