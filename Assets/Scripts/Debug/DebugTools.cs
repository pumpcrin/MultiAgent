using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

// public class DebugTools : MonoBehaviour{
//     public static DebugTools Instance;

//     List<DebugToolElement> toolInstances;

//     void Start(){
//         if(Instance == null)
//             Instance = this;
        
//         toolInstances = new List<DebugToolElement>();
//         toolInstances.Add(new DebugToolElement(new ShowBounds()));
//     }

//     public void MethodInvoke(Type type, object[] args){
//         DebugToolElement toolElem;

//         // Debug.Log("type: "+type.ToString()+"\telem: "+toolin)

//         try{
//             toolElem = toolInstances.Where(elem => elem.instance.GetType() == type).First();
//         }catch(InvalidOperationException e){
//             Debug.LogError("type: "+type.ToString()+" はDebugToolとして登録されていません");
//             return;
//         }
        
//         if(!toolElem.isUsed){
//             toolElem.instance.SetUp();
//             toolElem.isUsed = true;
//         }

//         toolElem.instance.Method(args);
//     }
// }


public class DebugToolElement{
    public DebugToolElement(IDebugTool _instance){
        instance = _instance;
    }

    public bool isUsed = false;
    public IDebugTool instance;
}

public interface IDebugTool{
    void SetUp();
    void Method(object[] args);
}
