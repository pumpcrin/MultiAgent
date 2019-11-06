using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;
using System.Linq;

// public class ShowBounds : IDebugTool
// {
//     const string assetPath = "Assets/Materials/Debug/DebugTransparent.mat";

//     public bool isUsed = false;
//     Material boundsCubeMaterial;

//     public void SetUp(){
//         boundsCubeMaterial = AssetDatabase.LoadAssetAtPath<Material>(assetPath);
//         isUsed = true;
//     }

//     public void Method(object[] args){
//         CreateBoundsCube((Vector3)args[0], (Quaternion)args[1], (Vector3)args[2]);
//     }

//     public void CreateBoundsCube(Vector3 pos, Quaternion rot, Vector3 sca){
//         var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
//         cube.transform.position = pos;
//         cube.transform.rotation = rot;
//         cube.transform.localScale = sca;
//         cube.GetComponent<Renderer>().material = boundsCubeMaterial;
        
//         GameObject.Destroy(cube.GetComponent<BoxCollider>());

//     }
// }
namespace DebugTool{
    public static class ShowBounds
    {
        const string assetPath = "Assets/Materials/Debug/DebugTransparent.mat";

        static bool isUsed = false;
        static Material boundsCubeMaterial;

        static void SetUp(){
            boundsCubeMaterial = AssetDatabase.LoadAssetAtPath<Material>(assetPath);
        }

        // static void Method(object[] args){
        //     CreateBoundsCube((Vector3)args[0], (Quaternion)args[1], (Vector3)args[2]);
        // }

        public static void CreateBoundsCube(Vector3 pos, Quaternion rot, Vector3 sca){
            if(!isUsed){
                SetUp();
                isUsed = true;
            }

            var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.position = pos;
            cube.transform.rotation = rot;
            cube.transform.localScale = sca;
            cube.GetComponent<Renderer>().material = boundsCubeMaterial;
            
            GameObject.Destroy(cube.GetComponent<BoxCollider>());
        }
    }
}
