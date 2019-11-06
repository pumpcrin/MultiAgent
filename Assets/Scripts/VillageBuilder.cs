using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DebugTool;

public class VillageBuilder : MonoBehaviour
{
    public GameObject house_prefab;
    public GameObject road_prefab;
    public GameObject houseInstance_debug;
    public Material boundsCubeMaterial_debug;

    Parameters param;

    void Start()
    {
        param = Database.database.parameters;
        Create();

        var bounds = house_prefab.GetComponent<MeshFilter>().sharedMesh.bounds;

        var pos = houseInstance_debug.transform.position + bounds.center;
        var rot = houseInstance_debug.transform.rotation;
        var sca = bounds.extents * 2;

        // var args = new object[]{(object)pos, (object)rot, (object)sca};
        // DebugTools.Instance.MethodInvoke(typeof(ShowBounds), args);

        ShowBounds.CreateBoundsCube(pos, rot, sca);
    }

    void Create(){
        var houseBounds = house_prefab.GetComponent<MeshFilter>().sharedMesh.bounds;
        var roadBounds = road_prefab.GetComponent<MeshFilter>().sharedMesh.bounds;


        float roadDepth = roadBounds.extents.x;
        float roadWidth = roadBounds.extents.z;

        float farmDepth = houseBounds.extents.z * 2;
        float farmWidth = param.farmlandMinArea / farmDepth;

        int times = 5;

        float margin = houseBounds.extents.x * 2 + roadWidth + farmWidth;


        for(int i = 0; i < times; i++){
            var pos = new Vector3(i*margin, 0, 0);
            var house = Instantiate(house_prefab, pos, Quaternion.identity);

            var farmPos = new Vector3(houseBounds.extents.x + farmWidth/2, 0, 0)+pos;
            var farmSca = new Vector3(farmWidth, 1, farmDepth);

            // var args = new object[]{farmPos, Quaternion.identity, farmSca};
            // DebugTools.Instance.MethodInvoke(typeof(ShowBounds), args);
            ShowBounds.CreateBoundsCube(farmPos, Quaternion.identity, farmSca);

            var roadPos = new Vector3(houseBounds.extents.x + farmWidth + roadWidth/2, 0, 0) + pos;
            var roadRot = Quaternion.Euler(new Vector3(0, 90, 0));
            var road = Instantiate(road_prefab, roadPos, roadRot);

            // DebugTool.ShowObjectBounds.Create(road);
            ShowObjectBounds.Create(road);
            // var scale = Vector3.Scale(roadBounds.extents * 2, road_prefab.transform.lossyScale);
            // args = new object[]{roadPos, roadRot, scale};
            // DebugTools.Instance.MethodInvoke(typeof(ShowBounds), args);
        }
    }

}
