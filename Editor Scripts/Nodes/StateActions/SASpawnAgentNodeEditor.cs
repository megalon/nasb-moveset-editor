using NASB_Moveset_Editor.StateActions;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using XNodeEditor;

namespace NASB_Moveset_Editor
{
    [CustomNodeEditor(typeof(SASpawnAgentNode))]
    public class SASpawnAgentNodeEditor : StateActionNodeEditor
    {

        public override void OnBodyGUI()
        {
            serializedObject.Update();
            SerializedProperty iterator = serializedObject.GetIterator();

            // Node input
            NodeEditorGUILayout.PropertyField(iterator.serializedObject.FindProperty("NodeInput"), true);

            DisplayStringProp(iterator.serializedObject.FindProperty("Bank"));
            DisplayStringProp(iterator.serializedObject.FindProperty("Id"));
            DisplayStringProp(iterator.serializedObject.FindProperty("Bone"));

            NodeEditorGUILayout.PropertyField(iterator.serializedObject.FindProperty("LocalOffsetX"), true);
            NodeEditorGUILayout.PropertyField(iterator.serializedObject.FindProperty("LocalOffsetY"), true);
            NodeEditorGUILayout.PropertyField(iterator.serializedObject.FindProperty("LocalOffsetZ"), true);
            NodeEditorGUILayout.PropertyField(iterator.serializedObject.FindProperty("WorldOffsetX"), true);
            NodeEditorGUILayout.PropertyField(iterator.serializedObject.FindProperty("WorldOffsetY"), true);
            NodeEditorGUILayout.PropertyField(iterator.serializedObject.FindProperty("WorldOffsetZ"), true);

            SerializedProperty spawnMovementBool = iterator.serializedObject.FindProperty("CustomSpawnMovement");
            spawnMovementBool.boolValue = EditorGUILayout.ToggleLeft(spawnMovementBool.displayName, spawnMovementBool.boolValue);

            if (spawnMovementBool.boolValue)
            {
                NodeEditorGUILayout.PropertyField(iterator.serializedObject.FindProperty("CustomSpawnMovements"), true);
            }

            NodeEditorGUILayout.PropertyField(iterator.serializedObject.FindProperty("GuaMessageObject"), true);
            NodeEditorGUILayout.PropertyField(iterator.serializedObject.FindProperty("ResultOrderAdded"), true);


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