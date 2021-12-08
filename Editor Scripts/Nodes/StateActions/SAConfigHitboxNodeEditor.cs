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
            SerializedProperty forceZ0Bool = iterator.serializedObject.FindProperty("ForceZ0");
            forceZ0Bool.boolValue = EditorGUILayout.ToggleLeft(forceZ0Bool.displayName, forceZ0Bool.boolValue);
            NodeEditorGUILayout.PropertyField(iterator.serializedObject.FindProperty("Radius"), true);
            NodeEditorGUILayout.PropertyField(iterator.serializedObject.FindProperty("LocalOffset"), true);
            NodeEditorGUILayout.PropertyField(iterator.serializedObject.FindProperty("WorldOffset"), true);

            DisplayStringProp(iterator.serializedObject.FindProperty("Prop"));
            DisplayStringProp(iterator.serializedObject.FindProperty("Bone"));
            DisplayStringProp(iterator.serializedObject.FindProperty("FxId"));
            DisplayStringProp(iterator.serializedObject.FindProperty("SfxId"));

            SerializedProperty secondTrackBool = iterator.serializedObject.FindProperty("SecondTrack");
            secondTrackBool.boolValue = EditorGUILayout.ToggleLeft(secondTrackBool.displayName, secondTrackBool.boolValue);

            if (secondTrackBool.boolValue)
            {
                DisplayStringProp(iterator.serializedObject.FindProperty("Bone2"));

                NodeEditorGUILayout.PropertyField(iterator.serializedObject.FindProperty("LocalOffset2"), true);
                NodeEditorGUILayout.PropertyField(iterator.serializedObject.FindProperty("WorldOffset2"), true);
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