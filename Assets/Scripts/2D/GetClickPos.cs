using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class GetClickPos : MonoBehaviour
{   
    Camera cam;
    List<Vector3> locationList;

    public GameObject resident;       // セットした位置に表示されるゲームオブジェクト

    public Vector2 startPos;

    public ReactiveProperty<Vector3> clickPositionAsObservable;

    void Start()
    {
        cam = Camera.main;
        Debug.Log("main: "+Camera.main);
        clickPositionAsObservable = new ReactiveProperty<Vector3>(Vector3.zero);

        clickPositionAsObservable.Subscribe(position => Debug.Log(position));
    }

    void Update(){
        if(Input.GetMouseButtonDown(0)){
            Debug.Log("cam: "+cam);
            var ray = cam.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;
            if(!Physics.Raycast(ray, out hit))  return;

            clickPositionAsObservable.Value = hit.transform.position;
        }
    }
}
