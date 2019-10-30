using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;
using System.Linq;

public class DebugTools : MonoBehaviour{
    public static DebugTools Instance;

    List<DebugToolElement> toolInstances;

    void Start(){
        if(Instance == null)
            Instance = this;
        
        toolInstances = new List<DebugToolElement>();
        toolInstances.Add(new DebugToolElement(new ShowBounds()));
    }

    public void MethodInvoke(Type type){
        var toolElem = toolInstances.Where(elem => elem.GetType() == type).First();
        
    }
}

public class DebugToolElement{
    public DebugToolElement(IDebugTool _instance){
        instance = _instance;
    }

    public bool isUsed = false;
    public IDebugTool instance;
}

public interface IDebugTool{
    void SetUp();
    void Method(object[] arguments);
}

public class ShowBounds : IDebugTool
{
    const string assetPath = "Assets/Materials/Debug/BoundsCube.mat";

    public bool isUsed = false;
    Material boundsCubeMaterial;

    public void SetUp(){
        boundsCubeMaterial = AssetDatabase.LoadAssetAtPath<Material>(assetPath);
        isUsed = true;
    }

    public void Method(object[] arguments){
        CreateBoundsCube((Vector3)arguments[0], (Quaternion)arguments[1], (Vector3)arguments[2]);
    }

    public void CreateBoundsCube(Vector3 pos, Quaternion rot, Vector3 sca){
        var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.GetComponent<Renderer>().material = boundsCubeMaterial;
        cube.transform.localScale = sca;
        cube.transform.rotation = rot;
        cube.transform.position = pos;

    }
}
