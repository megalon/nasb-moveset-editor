using UnityEngine;
using UnityEditor;
using NASB_Parser;
using System.IO;
using System;
using System.Collections.Generic;

namespace NASB_Moveset_Editor
{
    public class GraphHandler
    {
        public static void LoadTextAsset()
        {
            string filePath = EditorUtility.OpenFilePanel("Select Text Asset", "", "txt");

            if (filePath == null || filePath.Equals(string.Empty))
            {
                return;
            }

            BulkSerializeReader ser;
            using (var fsread = File.OpenRead(filePath))
                ser = new BulkSerializeReader(fsread);
            var data = new SerialMoveset(ser);

            var textAssetName = Path.GetFileNameWithoutExtension(filePath);

            GenerateGraphs(data, textAssetName);

            string assetFolderPath = Path.Combine(Utils.GetGraphsDirPath(), textAssetName);

            EditorUtility.DisplayDialog("NASB Moveset Editor", $"Imported {textAssetName}!\n\nYou can find the moveset state graphs in\n\"{assetFolderPath}\"", "OK");
        }

        public static void SaveTextAsset(string graphDir, string graphName)
        {
            if (graphDir == null || graphDir.Equals(string.Empty)) return;

            string outputFilePath = EditorUtility.SaveFilePanel("Select Save Location", "", $"{graphName}_new", "txt");

            if (outputFilePath == null || outputFilePath.Equals(string.Empty))
            {
                return;
            }

            SerialMoveset serialMoveset = new SerialMoveset();


            string[] graphPaths = Directory.GetFiles(graphDir);
            foreach (string graphPath in graphPaths)
            {
                try
                {
                    // Skip anything that isn't an asset file
                    if (!graphPath.EndsWith(".asset")) continue;

                    Debug.Log($"Reading graph...\n{graphPath}");

                    MovesetGraph graph = (MovesetGraph)AssetDatabase.LoadMainAssetAtPath(graphPath);
                    IdStateNode idStateNode = (IdStateNode)graph.nodes.Find(x => x.GetType() == typeof(IdStateNode));

                    serialMoveset.States.Add(idStateNode.GetData());
                }
                catch (Exception e)
                {
                    var idStateName = Path.GetFileNameWithoutExtension(graphPath);

                    Debug.LogError($"Error reading graph: {idStateName}\n{graphPath}");
                    Debug.LogError(e.Message);

                    EditorUtility.DisplayDialog("NASB Moveset Editor", $"Export failed!\n\nError with IdState: {idStateName}\n\nSee error message in console window for more info.", "Close");
                    return;
                }
            }

            Debug.Log($"Built SerialMoveset for {graphName}!");

            try
            {
                var writer = new BulkSerializeWriter();
                serialMoveset.Write(writer);
                using var fs = File.OpenWrite(outputFilePath);
                using var sr = new StreamWriter(fs);

                Debug.Log($"Writing file...\n{outputFilePath}!");
                writer.Serialize(sr);
                Debug.Log($"Finished writing file!\n{outputFilePath}!");
            }
            catch (Exception e)
            {
                Debug.LogError($"Error writing file!\n{outputFilePath}");
                Debug.LogError(e.Message);

                EditorUtility.DisplayDialog("NASB Moveset Editor", "Failed to write file!\n\nSee error message in console window for more info.", "Close");
                return;
            }

            EditorUtility.DisplayDialog("NASB Moveset Editor", $"Export complete!\n\nSaved to \"{outputFilePath}\"", "OK");
        }

        public static List<MovesetGraph> GenerateGraphs(SerialMoveset data, string itemName)
        {
            string graphsFolderPath = Utils.GetGraphsDirPath();
            if (!Directory.Exists(graphsFolderPath))
                Directory.CreateDirectory(graphsFolderPath);

            string updatedItemName = itemName;
            string folderPath = Path.Combine(graphsFolderPath, itemName);

            int duplicateIndex = 0;

            while (Directory.Exists(folderPath))
            {
                ++duplicateIndex;
                updatedItemName = itemName + "_" + duplicateIndex;
                folderPath = Path.Combine(graphsFolderPath, updatedItemName);
            }

            AssetDatabase.CreateFolder(graphsFolderPath, updatedItemName);

            return CreateGraphsForAllStates(data, updatedItemName, folderPath);
        }

        public static List<MovesetGraph> CreateGraphsForAllStates(SerialMoveset data, string updatedItemName, string assetFolderPath)
        {
            List<MovesetGraph> movesetGraphs = new List<MovesetGraph>();
            // Split the moveset apart by state
            int i = 0;
            foreach (IdState state in data.States)
            {
                ++i;
                movesetGraphs.Add(CreateOneStateGraph(state, updatedItemName, assetFolderPath, data, i));
            }

            EditorUtility.ClearProgressBar();
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
            return movesetGraphs;
        }

        private static MovesetGraph CreateOneStateGraph(IdState state, string textassetName, string assetFolderPath, SerialMoveset data, int i)
        {
            // Check if graph already exists
            string filePath = Path.Combine(Utils.GetGraphsDirPath(), textassetName, $"{state.Id}.asset");
            if (File.Exists(filePath))
            {
                string logMessage = $"The graph \"{state.Id}\" already exists for \"{textassetName}\"!";
                EditorUtility.DisplayDialog("NASB Moveset Editor", logMessage, "OK");
                Debug.LogWarning(logMessage);
                return null;
            }

            if (data != null)
                EditorUtility.DisplayProgressBar($"Importing {textassetName}...", $"Loading {state.Id}", i / data.States.Count);
            else
                EditorUtility.DisplayProgressBar($"Importing {textassetName}...", $"Loading {state.Id}", 0);

            ScriptableObject graph = ScriptableObject.CreateInstance("MovesetGraph");
            AssetDatabase.CreateAsset(graph, $"{assetFolderPath}/{state.Id}.asset");

            LoadMovesetIntoGraph(state, (MovesetGraph)graph, $"{assetFolderPath}/{state.Id}.asset");

            return (MovesetGraph)graph;
        }

        private static void LoadMovesetIntoGraph(IdState data, MovesetGraph graph, string assetPath)
        {
            IdStateNode idStateNode = graph.AddNode<IdStateNode>();
            AssetDatabase.AddObjectToAsset(idStateNode, assetPath);
            idStateNode.SetData(data, graph, assetPath, Vector2.zero);
        }
    }
}