using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditorInternal;

[CustomEditor(typeof(Database))]
public class EditorTest : Editor
{
    ReorderableList list;
    List<string> testList = new List<string>(){"0", "1", "2"};

    public void OnEnable(){
        list = new ReorderableList(
        serializedObject,
        serializedObject.FindProperty("routineList")
        );
    }

    public override void OnInspectorGUI(){
        DrawDefaultInspector();

        serializedObject.Update ();

        // リスト・配列の変更可能なリストの表示
        list.DoLayoutList();

        serializedObject.ApplyModifiedProperties();
    }
}
