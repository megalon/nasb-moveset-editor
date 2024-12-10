using NASB_Moveset_Editor.StateActions;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using XNodeEditor;

namespace NASB_Moveset_Editor
{
    [CustomNodeEditor(typeof(SASpawnAgent2Node))]
    public class SASpawnAgent2NodeEditor : StateActionNodeEditor
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

            DisplayStringProp(iterator.serializedObject.FindProperty("SpawnedAgentDataId"));

            NodeEditorGUILayout.PropertyField(iterator.serializedObject.FindProperty("SpawnedAgentDataSetValue"), true);
            NodeEditorGUILayout.PropertyField(iterator.serializedObject.FindProperty("ResultOrderAdded"), true);

            // Contextual set options
            SerializedProperty setPlayerIndex = iterator.serializedObject.FindProperty("SetPlayerIndex");
            SerializedProperty setAttackTeam = iterator.serializedObject.FindProperty("SetAttackTeam");
            SerializedProperty setDefendTeam = iterator.serializedObject.FindProperty("SetDefendTeam");
            SerializedProperty setProjectileLevel = iterator.serializedObject.FindProperty("SetProjectileLevel");
            SerializedProperty setDirection = iterator.serializedObject.FindProperty("SetDirection");
            SerializedProperty setRedirect = iterator.serializedObject.FindProperty("SetRedirect");

            setPlayerIndex.boolValue = EditorGUILayout.ToggleLeft(setPlayerIndex.displayName, setPlayerIndex.boolValue);
            setAttackTeam.boolValue = EditorGUILayout.ToggleLeft(setAttackTeam.displayName, setAttackTeam.boolValue);
            setDefendTeam.boolValue = EditorGUILayout.ToggleLeft(setDefendTeam.displayName, setDefendTeam.boolValue);
            setProjectileLevel.boolValue = EditorGUILayout.ToggleLeft(setProjectileLevel.displayName, setProjectileLevel.boolValue);
            setDirection.boolValue = EditorGUILayout.ToggleLeft(setDirection.displayName, setDirection.boolValue);
            setRedirect.boolValue = EditorGUILayout.ToggleLeft(setRedirect.displayName, setRedirect.boolValue);

            if (setPlayerIndex.boolValue) NodeEditorGUILayout.PropertyField(iterator.serializedObject.FindProperty("PlayerIndex"), true);
            if (setAttackTeam.boolValue) NodeEditorGUILayout.PropertyField(iterator.serializedObject.FindProperty("AttackTeam"), true);
            if (setDefendTeam.boolValue) NodeEditorGUILayout.PropertyField(iterator.serializedObject.FindProperty("DefendTeam"), true);
            if (setProjectileLevel.boolValue) NodeEditorGUILayout.PropertyField(iterator.serializedObject.FindProperty("ProjectileLevel"), true);
            if (setDirection.boolValue) NodeEditorGUILayout.PropertyField(iterator.serializedObject.FindProperty("Direction"), true);
            if (setRedirect.boolValue)
            {
                NodeEditorGUILayout.PropertyField(iterator.serializedObject.FindProperty("RedirectX"), true);
                NodeEditorGUILayout.PropertyField(iterator.serializedObject.FindProperty("RedirectY"), true);
            }

            SerializedProperty exactSpawn = iterator.serializedObject.FindProperty("ExactSpawn");
            exactSpawn.boolValue = EditorGUILayout.ToggleLeft(exactSpawn.displayName, exactSpawn.boolValue);

            NodeEditorGUILayout.PropertyField(iterator.serializedObject.FindProperty("AddedSpawnedDatas"), true);

            serializedObject.ApplyModifiedProperties();
        }
    }
}
