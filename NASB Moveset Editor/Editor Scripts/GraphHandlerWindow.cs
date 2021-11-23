using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using NASB_Parser;
using System.IO;
using System.Threading.Tasks;
using XNode;
using NASB_Moveset_Editor;
using XNodeEditor;

public class GraphHandlerWindow : EditorWindow
{
    public string[] graphDirectories = { "None" };
    public string[] graphNames = { "None" };
    public int selection = 0;

    public void Awake()
    {
        SetupGraphNames();
    }

    public void OnProjectChange()
    {
        SetupGraphNames();
    }

    [MenuItem("Window/NASB Moveset Editor")]
    private static void OpenWindow()
    {
        GraphHandlerWindow window = GetWindow<GraphHandlerWindow>();
        window.titleContent = new GUIContent("NASB Moveset Editor v0.1");
    }

    private void OnGUI()
    {
        EditorGUILayout.BeginHorizontal();
        {
            GUILayout.FlexibleSpace();
            EditorGUILayout.BeginVertical(GUILayout.MaxWidth(400));
            {
                EditorGUILayout.Space(10);
                EditorGUILayout.HelpBox("This is in Alpha! Things may break! You may lose all of your work!", MessageType.Warning);
                EditorGUILayout.Space(10);
                if (GUILayout.Button("Import TextAsset", GUILayout.MinHeight(35))) GraphHandler.LoadTextAsset();
                EditorGUILayout.Space(10);
                if (graphDirectories.Length > 0)
                {
                    selection = EditorGUILayout.Popup("Asset to export", selection, graphNames);
                    EditorGUILayout.Space();
                    if (GUILayout.Button("Export TextAsset", GUILayout.MinHeight(50))) GraphHandler.SaveTextAsset(graphDirectories[selection], graphNames[selection]);
                    EditorGUILayout.Space(10);
                }
                EditorGUILayout.LabelField("Created by @megalon2d!");
                EditorGUILayout.LabelField("NASB_Parser library originally created by sc2ad!");
            }
            EditorGUILayout.EndVertical();
            GUILayout.FlexibleSpace();
        }
        EditorGUILayout.EndHorizontal();
    }

    private void SetupGraphNames()
    {
        if (!Directory.Exists(Utils.GetGraphsDirPath()))
        {
            Directory.CreateDirectory(Utils.GetGraphsDirPath());
        }

        graphDirectories = Directory.GetDirectories(Utils.GetGraphsDirPath());
        graphNames = new string[graphDirectories.Length];
        for (int i = 0; i < graphDirectories.Length; ++i)
        {
            graphNames[i] = Path.GetFileName(graphDirectories[i]);
        }
    }
}
