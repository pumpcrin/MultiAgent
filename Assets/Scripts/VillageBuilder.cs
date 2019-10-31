using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VillageBuilder : MonoBehaviour
{

    public GameObject house;
    public GameObject houseInstance_debug;
    public Material boundsCubeMaterial_debug;

    void Start()
    {
        var bounds = house.GetComponent<MeshFilter>().sharedMesh.bounds;

        var pos = houseInstance_debug.transform.position + bounds.center;
        var rot = houseInstance_debug.transform.rotation;
        var sca = bounds.extents * 2;

        var args = new object[]{(object)pos, (object)rot, (object)sca};

        DebugTools.Instance.MethodInvoke(typeof(ShowBounds), args);
    }

}
