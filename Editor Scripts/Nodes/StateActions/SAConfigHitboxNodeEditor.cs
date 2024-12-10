using NASB_Moveset_Editor.StateActions;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using XNodeEditor;
using static XNodeEditor.NodeEditor;

namespace NASB_Moveset_Editor
{
    [CustomNodeEditor(typeof(SAConfigHitboxNode))]
    public class SAConfigHitboxNodeEditor : StateActionNodeEditor
    {
        public override void OnBodyGUI()
        {
            serializedObject.Update();
            SerializedProperty iterator = serializedObject.GetIterator();

            // Node input
            NodeEditorGUILayout.PropertyField(iterator.serializedObject.FindProperty("NodeInput"), true);
            NodeEditorGUILayout.PropertyField(iterator.serializedObject.FindProperty("Hitbox"), true);

            DisplayStringProp(iterator.serializedObject.FindProperty("Prop"));
            DisplayStringProp(iterator.serializedObject.FindProperty("Bone"));

            NodeEditorGUILayout.PropertyField(iterator.serializedObject.FindProperty("Radius"), true);
            NodeEditorGUILayout.PropertyField(iterator.serializedObject.FindProperty("LocalOffsetX"), true);
            NodeEditorGUILayout.PropertyField(iterator.serializedObject.FindProperty("LocalOffsetY"), true);
            NodeEditorGUILayout.PropertyField(iterator.serializedObject.FindProperty("LocalOffsetZ"), true);
            NodeEditorGUILayout.PropertyField(iterator.serializedObject.FindProperty("WorldOffsetX"), true);
            NodeEditorGUILayout.PropertyField(iterator.serializedObject.FindProperty("WorldOffsetY"), true);
            NodeEditorGUILayout.PropertyField(iterator.serializedObject.FindProperty("WorldOffsetZ"), true);

            DisplayStringProp(iterator.serializedObject.FindProperty("FxId"));
            DisplayStringProp(iterator.serializedObject.FindProperty("SfxId"));

            SerializedProperty inactiveBool = iterator.serializedObject.FindProperty("Inactive");
            inactiveBool.boolValue = EditorGUILayout.ToggleLeft(inactiveBool.displayName, inactiveBool.boolValue);

            SerializedProperty secondTrackBool = iterator.serializedObject.FindProperty("SecondTrack");
            secondTrackBool.boolValue = EditorGUILayout.ToggleLeft(secondTrackBool.displayName, secondTrackBool.boolValue);

            if (secondTrackBool.boolValue)
            {
                DisplayStringProp(iterator.serializedObject.FindProperty("Bone2nd"));

                NodeEditorGUILayout.PropertyField(iterator.serializedObject.FindProperty("LocalOffset2ndX"), true);
                NodeEditorGUILayout.PropertyField(iterator.serializedObject.FindProperty("LocalOffset2ndY"), true);
                NodeEditorGUILayout.PropertyField(iterator.serializedObject.FindProperty("LocalOffset2ndZ"), true);
                NodeEditorGUILayout.PropertyField(iterator.serializedObject.FindProperty("WorldOffset2ndX"), true);
                NodeEditorGUILayout.PropertyField(iterator.serializedObject.FindProperty("WorldOffset2ndY"), true);
                NodeEditorGUILayout.PropertyField(iterator.serializedObject.FindProperty("WorldOffset2ndZ"), true);
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