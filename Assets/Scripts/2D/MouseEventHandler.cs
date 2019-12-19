using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class MouseEventHandler : MonoBehaviour
{   
    Camera cam;
    List<Vector3> locationList;

    public Vector2 startPos;

    public ReactiveProperty<Vector3> clickPositionAsObservable;

    public ReactiveProperty<Vector3> ClickPositionAsObservable => clickPositionAsObservable;

    void Start()
    {
        cam = Camera.main;
        Debug.Log("main: "+Camera.main);
        clickPositionAsObservable = new ReactiveProperty<Vector3>();
        clickPositionAsObservable.Value = Vector3.zero;

        clickPositionAsObservable.Subscribe(position => Debug.LogWarning(position));
    }

    void Update(){
        if(Input.GetMouseButtonDown(0)){
            var ray = cam.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;
            if(!Physics.Raycast(ray, out hit))  return;

            Debug.Log("hitPosition: "+hit.transform.position);

            clickPositionAsObservable.Value = hit.transform.position;
        }

        Debug.Log("position: "+clickPositionAsObservable.Value);
    }
}
