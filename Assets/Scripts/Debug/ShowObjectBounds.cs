using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DebugTool{
    public static class ShowObjectBounds
    {
        static bool isUsed = false;

        static void SetUp(){
            isUsed = true;
        }

        public static void Create(GameObject obj){
            if(!isUsed) SetUp();

            var bounds = obj.GetComponent<MeshFilter>().sharedMesh.bounds;

            Debug.Log("road: "+bounds.center);

            var pos = obj.transform.position + bounds.center;
            var rot = obj.transform.rotation;
            var sca = bounds.extents * 2;
            sca = Vector3.Scale(sca, obj.transform.lossyScale);
            // var args = new object[]{pos, rot, sca};
            // DebugTools.Instance.MethodInvoke(typeof(ShowBounds), args);
            ShowBounds.CreateBoundsCube(pos, rot, sca);
        }
    }
}
