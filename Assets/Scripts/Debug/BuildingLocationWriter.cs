using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UniRx;
using System.Linq;

public class BuildingLocationWriter : MonoBehaviour
{
    
    public BuildingLocations locationStorage;
    Camera cam;
    List<Vector3> locationList;

    GameObject locationIndicator;       // セットした位置に表示されるゲームオブジェクト
    int maxIndex = -1;                   // 現在設定されている座標のうち、最後に設定された座標のindex

    void Start()
    {
        locationIndicator = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        cam = Camera.main;
        Debug.Log("main: "+Camera.main);
        locationList = new List<Vector3>();
    }

    void Update(){
        if(Input.GetMouseButtonDown(0)){
            Debug.Log("cam: "+cam);
            var ray = cam.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;
            if(!Physics.Raycast(ray, out hit))  return;

            if(locationList.Count - 1 > maxIndex)
                locationList.RemoveRange(maxIndex + 1, locationList.Count - 1);
            
            locationList.Add(hit.transform.position);
            maxIndex = locationList.Count - 1;
        }
        else if(Input.GetKeyDown("left ctrl") && Input.GetKeyDown("z")){
            if(maxIndex > -1)
                maxIndex--;
        }
        else if((Input.GetKeyDown("left ctrl") && Input.GetKeyDown("y")) || 
                (Input.GetKeyDown("left ctrl") && Input.GetKeyDown("z") && Input.GetKeyDown("left shift"))){
            if(locationList.Count - 1 > maxIndex){
                maxIndex++;
            }
        }

        if(maxIndex == -1)   return;

        Debug.Log("maxIndex: "+maxIndex);
        locationIndicator.transform.position = locationList[maxIndex];
    }

    void OnDestroy(){
        locationStorage.buildingLocations.AddRange(locationList);
    }
}
