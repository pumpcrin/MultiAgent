using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace DebugTool{
    public static class DebugLine
    {

        const string assetPath = "Assets/Prefabs/Debug/DebugLine.prefab";
        static bool isUsed = false;
        static GameObject line_prefab;
        static void SetUp(){
            line_prefab = AssetDatabase.LoadAssetAtPath<GameObject>(assetPath);
        }

        public static GameObject CreateLine(Vector3[] points){
            if(!isUsed){
                SetUp();
                isUsed = true;
            }

            var line = GameObject.Instantiate(line_prefab);
            var renderer = line.GetComponent<LineRenderer>();
            renderer.SetPositions(points);

            return line;
        }

        public static GameObject CreateLine(Vector3 startPos, Vector3 endPos){
            return CreateLine(new Vector3[]{startPos, endPos});
        }

    }
}
