using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UniRx;

public class Resident : MonoBehaviour
{
    public Vector2 startPos;

    Vector2 destinationPos;

    Map2DManager singleton;

    void Start()
    {
        singleton = Map2DManager.Singleton;

        transform.position = singleton.GetPosition(startPos);

        singleton.GetComponent<MouseEventHandler>().clickPositionAsObservable.Subscribe(position => {
            var pos = singleton.GetPos(position);
            transform.position = singleton.GetPosition(pos);
        });
    }

    void Update()
    {
        
    }
}
