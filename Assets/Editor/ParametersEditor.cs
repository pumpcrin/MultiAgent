using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Parameters))]
public class ParametersEditor : Editor
{
    bool _isOpen = true;

    public void OnInspectorGUI(){
        DrawDefaultInspector();
        serializedObject.Update();

        //折りたたみUIを表示、現在開いているかを取得
        bool isOpen = EditorGUILayout.Foldout(_isOpen, "折りたたみ");

        //折りたたみの状態が変わったらログ表示
        if(_isOpen != isOpen){
            _isOpen = isOpen;
        }

        //開いている時はGUI追加
        if(isOpen){
            EditorGUI.indentLevel++;
            EditorGUILayout.PropertyField(serializedObject.FindProperty("DefaultHp"),           new GUIContent("Hp"));
            EditorGUILayout.PropertyField(serializedObject.FindProperty("DefaultSatiety"),      new GUIContent("Satiety"));
            EditorGUILayout.PropertyField(serializedObject.FindProperty("DefaultMoney"),        new GUIContent("Money"));
            EditorGUILayout.PropertyField(serializedObject.FindProperty("DefaultFoodSaving"),   new GUIContent("FoodSaving"));
            EditorGUI.indentLevel--;
        } 
    }
}
