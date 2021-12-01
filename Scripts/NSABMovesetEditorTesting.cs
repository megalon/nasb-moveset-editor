using System.IO;
using UnityEditor;
using UnityEngine;
using XNodeEditor;
using XNode;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NASB_Moveset_Editor
{
    public class NSABMovesetEditorTesting : EditorWindow
    {
        private static int xSpacing = 240;
        private static int ySpacing = 140;
        private static int numPerRow = 6;
        private static int fileCount = 0;

        [MenuItem("NASB/NASB Moveset Editor Tests", priority = 4)]
        private static void OpenWindow()
        {
            NSABMovesetEditorTesting window = GetWindow<NSABMovesetEditorTesting>();
            window.titleContent = new GUIContent("TESTING NASB Moveset Editor");
        }

        private void OnGUI()
        {
            EditorGUILayout.BeginHorizontal();
            {
                GUILayout.FlexibleSpace();
                EditorGUILayout.BeginVertical(GUILayout.MaxWidth(400));
                {
                    EditorGUILayout.Space(10);
                    EditorGUILayout.HelpBox("Test scripts for the NASB Moveset Editor", MessageType.Warning);
                    EditorGUILayout.Space(10);
                    if (GUILayout.Button("Generate AllNodes Graph", GUILayout.MinHeight(35)))
                    {
                        GenerateAllNodes();
                    }
                    EditorGUILayout.Space(10);
                    if (GUILayout.Button("Print All States From characterBase", GUILayout.MinHeight(35)))
                    {
                        try
                        {
                            string[] stateGraphPaths = Directory.GetFiles(Path.Combine(Utils.GetGraphsDirPath(), "characterBase"));
                            string longstring = "";
                            foreach (string path in stateGraphPaths)
                            {
                                if (path.Contains(".meta")) continue;
                                longstring += Path.GetFileNameWithoutExtension(path) + ",";
                            }
                            Logger.LogInfo(longstring);
                        } catch (Exception e)
                        {
                            Logger.LogError("Could not find characterBase. Have you imported the characterBase asset?");
                            Logger.LogError(e.Message);
                        }
                    }
                    EditorGUILayout.Space(10);
                    if (GUILayout.Button("Organize Graph", GUILayout.MinHeight(35)))
                    {
                        GraphHandler.CheckOrganizeGraph();
                    }
                    EditorGUILayout.Space(10);
                }
                EditorGUILayout.EndVertical();
                GUILayout.FlexibleSpace();
            }
            EditorGUILayout.EndHorizontal();
        }

        private void GenerateAllNodes()
        {
            string graphsFolderPath = Utils.GetGraphsDirPath();
            if (!Directory.Exists(graphsFolderPath))
                Directory.CreateDirectory(graphsFolderPath);

            string nodesDirPath = Utils.GetNodesDirPath();
            string[] directories = Directory.GetDirectories(nodesDirPath);
            string[] looseFiles = Directory.GetFiles(nodesDirPath);

            fileCount = 0;

            ScriptableObject graph = null;
            graph = (ScriptableObject)AssetDatabase.LoadMainAssetAtPath($"{graphsFolderPath}/AllNodes.asset");

            if (graph == null)
            {
                graph = ScriptableObject.CreateInstance("MovesetGraph");
                AssetDatabase.CreateAsset(graph, $"{graphsFolderPath}/AllNodes.asset");
            } else
            {
                Logger.LogInfo("Clearing graph...");
                ((MovesetGraph)graph).Clear();
            }

            foreach (string filePath in looseFiles)
            {
                AddNodeToGraph((MovesetGraph)graph, filePath);
            }
            AddSpacingRow();

            foreach (string dir in directories)
            {
                string[] files = Directory.GetFiles(dir);
                foreach (string filePath in files)
                {
                    AddNodeToGraph((MovesetGraph)graph, filePath);
                }
                AddSpacingRow();
            }
        }

        private void AddNodeToGraph(MovesetGraph graph, string filePath)
        {
            var extension = Path.GetExtension(filePath);
            if (!extension.Equals(".cs")) return;

            var filename = filePath.Substring(filePath.IndexOf("NASB Moveset Editor\\Scripts\\Nodes"));
            filename = filename.Substring("NASB Moveset Editor\\Scripts\\Nodes".Length + 1).Replace("\\", ".");
            filename = filename.Substring(0, filename.LastIndexOf("."));
            var t = System.Type.GetType("NASB_Moveset_Editor." + filename);

            // Skip null types
            if (t == null)
            {
                return;
            }

            Node node = ((MovesetGraph)graph).AddNode(t);

            Vector2 pos = new Vector2((fileCount % numPerRow) * xSpacing, Mathf.Floor(fileCount / numPerRow) * ySpacing);

            node.position = pos;
            if (filename.IndexOf(".") > 0) {
                node.name = filename.Substring(filename.LastIndexOf(".") + 1);
            } else
            {
                node.name = filename;
            }

            // Trim off "Node" at the end
            node.name = node.name.Substring(0, node.name.Length - 4);

            ++fileCount;
        }

        private void AddSpacingRow()
        {
            fileCount = (int)(Mathf.Floor(fileCount / numPerRow) + 2) * numPerRow;
        }
    }

}