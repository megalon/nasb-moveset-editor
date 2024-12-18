﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using MovesetParser;
using System.IO;
using System.Threading.Tasks;
using XNode;
using XNodeEditor;

namespace NASB_Moveset_Editor
{
    public class GraphHandlerWindow : EditorWindow
    {
        public string[] graphDirectories = { "None" };
        public static string[] graphNames = { "None" };
        private int previousSelectionIndex = 0;
        public int selectionIndex = 0;
        public string selectedAssetName;
        private Vector2 scrollPosition = Vector2.zero;

        private Color controlColor;

        public void OnProjectChange()
        {
            SetupGraphNames();
        }

        [MenuItem("NASB/Moveset Editor", priority = 4)]
        private static void OpenWindow()
        {
            GraphHandlerWindow window = GetWindow<GraphHandlerWindow>();
            window.titleContent = new GUIContent(Consts.PROJECT_NAME);
            window.minSize = new Vector2(280, 0);
        }

        private void OnEnable()
        {
            SetupGraphNames();
            selectedAssetName = EditorPrefs.GetString(Consts.KEY_SELECTED_ASSET_NAME, "");

            if (!selectedAssetName.Equals(string.Empty))
            {
                for (int i = 0; i < graphNames.Length; ++i)
                {
                    if (graphNames[i].Equals(selectedAssetName)) selectionIndex = i;
                }
            }
            else
            {
                Logger.LogInfo($"{Consts.KEY_SELECTED_ASSET_NAME} was empty! Selecting first item in list.");
            }

            controlColor = new Color(0.3f, 0.3f, 0.3f);
        }

        private void OnGUI()
        {
            GUIStyle rightAlignedGUIStyle = new GUIStyle(GUI.skin.label);
            rightAlignedGUIStyle.alignment = TextAnchor.LowerRight;
            EditorGUILayout.BeginHorizontal();
            {
                GUILayout.FlexibleSpace();
                EditorGUILayout.BeginVertical(GUILayout.MaxWidth(400));
                {
                    EditorGUILayout.HelpBox("This is in Alpha! Things may break! You may lose all of your work!", MessageType.Warning);
                }
                EditorGUILayout.EndVertical();
                GUILayout.FlexibleSpace();
            }
            EditorGUILayout.EndHorizontal();

            scrollPosition = EditorGUILayout.BeginScrollView(scrollPosition);
            EditorGUILayout.BeginHorizontal();
            {
                GUILayout.FlexibleSpace();
                EditorGUILayout.BeginVertical(GUILayout.MaxWidth(400));
                {
                    EditorGUILayout.Space(10);
                    if (GUILayout.Button("Import TextAsset", GUILayout.MinHeight(35))) GraphHandler.LoadTextAsset();
                    EditorGUILayout.Space(5);
                    if (GUILayout.Button("Create New Moveset Graph", GUILayout.MinHeight(35)))
                    {
                        CreateNewMovesestGraphWindow window = GetWindow<CreateNewMovesestGraphWindow>();
                        window.titleContent = new GUIContent("New Moveset Graph");
                    }
                    EditorGUILayout.Space(25);

                    if (graphDirectories.Length > 0)
                    {
                        previousSelectionIndex = selectionIndex;
                        selectionIndex = EditorGUILayout.Popup("Moveset to export", selectionIndex, graphNames);
                        if (selectionIndex != previousSelectionIndex)
                        {
                            // Selection changed, update prefs
                            if (graphNames.Length > selectionIndex)
                                EditorPrefs.SetString(Consts.KEY_SELECTED_ASSET_NAME, graphNames[selectionIndex]);
                        }

                        EditorGUILayout.Space();
                        if (GUILayout.Button("Export TextAsset", GUILayout.MinHeight(50))) GraphHandler.SaveTextAsset(graphDirectories[selectionIndex], graphNames[selectionIndex]);
                    }
                    EditorGUILayout.Space(10);
                    EditorGUI.DrawRect(EditorGUILayout.GetControlRect(false, 2), controlColor);
                    EditorGUILayout.Space(4);
                    if (GUILayout.Button("View project on GitHub!")) Application.OpenURL("https://github.com/megalon/nasb-moveset-editor");
                    if (GUILayout.Button("Report issues!")) Application.OpenURL("https://github.com/megalon/nasb-moveset-editor/issues");
                    EditorGUILayout.Space(4);
                    EditorGUILayout.BeginHorizontal();
                    {
                        EditorGUILayout.LabelField("Created by megalon", GUILayout.MinWidth(0));
                        EditorGUILayout.LabelField($"Version {Consts.VERSION}", rightAlignedGUIStyle, GUILayout.MinWidth(0));
                    }
                    EditorGUILayout.EndHorizontal();
                    EditorGUILayout.LabelField("NASB Moveset Parser created by Steven");
                    EditorGUILayout.LabelField("xNode created by Siccity");
                    EditorGUILayout.Space(10);
                }
                EditorGUILayout.EndVertical();
                GUILayout.FlexibleSpace();
            }
            EditorGUILayout.EndHorizontal();
            EditorGUILayout.EndScrollView();
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
}