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
        Debug.Log("bounds"+bounds);

        var boundsCube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        boundsCube.transform.localScale = bounds.extents * 2;
        boundsCube.transform.rotation = houseInstance_debug.transform.rotation;
        boundsCube.transform.position = houseInstance_debug.transform.position + bounds.center;
        boundsCube.GetComponent<Renderer>().material = boundsCubeMaterial_debug;
    }

    void Update()
    {
        
    }
}
