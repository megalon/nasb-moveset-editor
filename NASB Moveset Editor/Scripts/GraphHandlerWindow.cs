using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using NASB_Parser;
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

        public void OnProjectChange()
        {
            SetupGraphNames();
        }

        [MenuItem("NASB/NASB Moveset Editor", priority = 4)]
        private static void OpenWindow()
        {
            GraphHandlerWindow window = GetWindow<GraphHandlerWindow>();
            window.titleContent = new GUIContent(Consts.PROJECT_NAME + " " + Consts.VERSION);
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
                Debug.Log($"{Consts.KEY_SELECTED_ASSET_NAME} was empty! Selecting first item in list.");
            }
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
                    if (GUILayout.Button("Create New Moveset Graph", GUILayout.MinHeight(35)))
                    {
                        CreateNewMovesestGraphWindow window = GetWindow<CreateNewMovesestGraphWindow>();
                        window.titleContent = new GUIContent("New Moveset Graph");
                    }
                    EditorGUILayout.Space(10);
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
                        EditorGUILayout.Space(10);
                    }
                    EditorGUILayout.LabelField("Created by @megalon2d!");
                    EditorGUILayout.LabelField("NASB_Parser library originally created by sc2ad!");
                    EditorGUILayout.LabelField("xNode created by Siccity!");
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
}