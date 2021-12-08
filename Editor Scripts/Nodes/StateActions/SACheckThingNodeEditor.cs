using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using XNodeEditor;
using NASB_Moveset_Editor.StateActions;

namespace NASB_Moveset_Editor
{
    [CustomNodeEditor(typeof(SACheckThingNode))]
    public class SACheckThingNodeEditor : StateActionNodeEditor
    {
        public override void OnBodyGUI()
        {
            serializedObject.Update();
            SerializedProperty iterator = serializedObject.GetIterator();

            // Node input
            NodeEditorGUILayout.PropertyField(iterator.serializedObject.FindProperty("NodeInput"), true);
            NodeEditorGUILayout.PropertyField(iterator.serializedObject.FindProperty("CheckThing"), true);
            NodeEditorGUILayout.PropertyField(iterator.serializedObject.FindProperty("Action"), true);
            SerializedProperty elseBool = iterator.serializedObject.FindProperty("Else");
            elseBool.boolValue = EditorGUILayout.ToggleLeft(elseBool.displayName, elseBool.boolValue);

            if (elseBool.boolValue)
            {
                NodeEditorGUILayout.PropertyField(iterator.serializedObject.FindProperty("ElseAction"), true);
            }

            // Iterate through dynamic ports and draw them in the order in which they are serialized
            foreach (XNode.NodePort dynamicPort in target.DynamicPorts)
            {
                if (NodeEditorGUILayout.IsDynamicPortListPort(dynamicPort)) continue;
                NodeEditorGUILayout.PortField(dynamicPort);
            }

            serializedObject.ApplyModifiedProperties();
        }
    }

}