using UnityEngine;
using UnityEditor;
using NASB_Parser;
using System.IO;
using System;
using System.Collections.Generic;
using XNode;

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

                    Logger.LogInfo($"Reading graph...\n{graphPath}");

                    MovesetGraph graph = (MovesetGraph)AssetDatabase.LoadMainAssetAtPath(graphPath);
                    IdStateNode idStateNode = (IdStateNode)graph.nodes.Find(x => x.GetType() == typeof(IdStateNode));

                    serialMoveset.States.Add(idStateNode.GetData());
                }
                catch (Exception e)
                {
                    var idStateName = Path.GetFileNameWithoutExtension(graphPath);

                    Logger.LogError($"Error reading graph: {idStateName}\n{graphPath}");
                    Logger.LogError(e.Message);

                    EditorUtility.DisplayDialog("NASB Moveset Editor", $"Export failed!\n\nError with IdState: {idStateName}\n\nSee error message in console window for more info.", "Close");
                    return;
                }
            }

            Logger.LogInfo($"Built SerialMoveset for {graphName}!");

            try
            {
                var writer = new BulkSerializeWriter();
                serialMoveset.Write(writer);
                using var fs = File.OpenWrite(outputFilePath);
                using var sr = new StreamWriter(fs);

                Logger.LogInfo($"Writing file...\n{outputFilePath}!");
                writer.Serialize(sr);
                Logger.LogInfo($"Finished writing file!\n{outputFilePath}!");
            }
            catch (Exception e)
            {
                Logger.LogError($"Error writing file!\n{outputFilePath}");
                Logger.LogError(e.Message);

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

            // Refresh to make sure we see the graphs folder on first load
            AssetDatabase.Refresh();

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
                Logger.LogWarning(logMessage);
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

        public static void CheckOrganizeGraph()
        {
            if (EditorUtility.DisplayDialog("Organize Graph", "Are you sure you want to organize the entire graph?", "Yes", "No"))
            {
                OrganizeGraph();
            }
        }

        private static void OrganizeGraph()
        {
            // Get all the nodes from the current graph
            List<Node> nodes = XNodeEditor.NodeEditorWindow.current.graph.nodes;

            // Find idstate node
            IdStateNode idStateNode = null;
            foreach (Node node in nodes)
            {
                if (node.GetType().Equals(typeof(IdStateNode)))
                {
                    idStateNode = (IdStateNode)node;
                }
            }

            if (idStateNode == null)
            {
                Logger.LogError("Could not find IdStateNode in graph!");
                return;
            }

            Undo.RecordObjects(nodes.ToArray(), "Organize Graph");

            // Travel through outputs and position nodes
            TraverseThroughOutputs(idStateNode, Vector2.zero);
            Logger.LogInfo($"Organized graph!");
        }

        private static int TraverseThroughOutputs(Node node, Vector2 nodeDepthXY)
        {
            // Move this node
            node.position.x = nodeDepthXY.x * Consts.NodeXOffset;
            node.position.y = nodeDepthXY.y * Consts.NodeYOffset;
            int outputPortCount = 0;
            foreach (NodePort port in node.Outputs)
            {
                foreach (NodePort connectedPort in port.GetConnections())
                {
                    outputPortCount += TraverseThroughOutputs(connectedPort.node, nodeDepthXY + new Vector2(1, outputPortCount));
                }
                ++outputPortCount;
            }

            return outputPortCount > 0 ? outputPortCount - 1 : outputPortCount;
        }
    }
}