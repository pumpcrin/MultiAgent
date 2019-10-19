using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditorInternal;

[CustomEditor(typeof(Database))]
public class EditorTest : Editor
{
    List<ReorderableList> reorderables;
    List<SerializedProperty> properties;

    public void OnEnable(){
        reorderables = new List<ReorderableList>();
        properties = new List<SerializedProperty>();

        var propertyNames = new List<string>{"routineList", "routineStartHours"};

        foreach(var propertyName in propertyNames){
            var property = serializedObject.FindProperty(propertyName);
            properties.Add(property);

            var reorderable = new ReorderableList(
            serializedObject,
            property
            );

            reorderables.Add(reorderable);
        }
    }

    public override void OnInspectorGUI(){

        DrawDefaultInspector();

        EditorGUILayout.Space();

        serializedObject.Update ();

        int timeListCount = properties[1].arraySize;
        while(properties[0].arraySize > timeListCount){
            properties[1].InsertArrayElementAtIndex(timeListCount - 1);
            timeListCount++;
        }

        var titles = new List<string>{"Routine Order", "Routine Start Hours"};

        for(int i = 0; i < reorderables.Count; i++){
            reorderables[i].drawHeaderCallback = ( rect => EditorGUI.LabelField(rect, titles[i]));
            reorderables[i].drawElementCallback = (rect, index, isActive, isFocused) =>
            {
                var elementProperty = properties[i].GetArrayElementAtIndex(index);
                rect.height = EditorGUIUtility.singleLineHeight;
                EditorGUI.PropertyField(rect, elementProperty, new GUIContent("routine" + index));
            };

            // リスト・配列の変更可能なリストの表示
            reorderables[i].DoLayoutList();
        }

        serializedObject.ApplyModifiedProperties();
    }
}
