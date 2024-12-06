using UnityEngine;
using UnityEditor;
using MovesetParser;
using System.IO;
using System;
using System.Collections.Generic;
using XNode;
using XNodeEditor;
using NASB_Moveset_Editor.StateActions;

namespace NASB_Moveset_Editor
{
    public class GraphHandler
    {
        public static void LoadTextAsset()
        {
            string filePath = EditorUtility.OpenFilePanel("Select Text Asset", EditorPrefs.GetString(Consts.KEY_IMPORT_PATH, ""), "txt");

            if (filePath == null || filePath.Equals(string.Empty)) return;

            EditorPrefs.SetString(Consts.KEY_IMPORT_PATH, Path.GetDirectoryName(filePath));

            BulkSerializeReader ser;
            using (var fsread = File.OpenRead(filePath))
                ser = new BulkSerializeReader(fsread);
            var data = new SerialMoveset(ser);

            var textAssetName = Path.GetFileNameWithoutExtension(filePath);

            GenerateGraphs(data, textAssetName);

            string assetFolderPath = Path.Combine(Utils.GetGraphsDirPath(), textAssetName);

            EditorUtility.DisplayDialog(Consts.PROJECT_NAME, $"Imported {textAssetName}!\n\nYou can find the moveset state graphs in\n\"{assetFolderPath}\"", "OK");
        }

        public static void SaveTextAsset(string graphDir, string graphName)
        {
            if (graphDir == null || graphDir.Equals(string.Empty)) return;

            string outputFilePath = EditorUtility.SaveFilePanel("Select Save Location", EditorPrefs.GetString(Consts.KEY_EXPORT_PATH, ""), $"{graphName}_new", "txt");

            if (outputFilePath == null || outputFilePath.Equals(string.Empty)) return;

            EditorPrefs.SetString(Consts.KEY_EXPORT_PATH, Path.GetDirectoryName(outputFilePath));

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

                    IdState tempIdState = idStateNode.GetData();

                    // Sort timeline by start frame
                    tempIdState.State.Timeline.Sort((x, y) => x.AtFrame.CompareTo(y.AtFrame));

                    serialMoveset.States.Add(tempIdState);
                }
                catch (Exception e)
                {
                    var idStateName = Path.GetFileNameWithoutExtension(graphPath);

                    Logger.LogError($"Error reading graph: {idStateName}\n{graphPath}");
                    Logger.LogError(e.Message);

                    EditorUtility.DisplayDialog(Consts.PROJECT_NAME, $"Export failed!\n\nError with IdState: {idStateName}\n\nSee error message in console window for more info.", "Close");
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

                EditorUtility.DisplayDialog(Consts.PROJECT_NAME, "Failed to write file!\n\nSee error message in console window for more info.", "Close");
                return;
            }

            EditorUtility.DisplayDialog(Consts.PROJECT_NAME, $"Export complete!\n\nSaved to \"{outputFilePath}\"", "OK");
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
                EditorUtility.DisplayDialog(Consts.PROJECT_NAME, logMessage, "OK");
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
                XNodeEditor.NodeEditorWindow.DrawAllNodesOnce();
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
            TraverseThroughOutputsHeight(idStateNode, Vector2.zero);
            Logger.LogInfo($"Organized graph!");
        }

        private static Vector2 TraverseThroughOutputsHeight(Node node, Vector2 nodePos)
        {
            node.position.x = nodePos.x;
            node.position.y = nodePos.y;

            Vector2 nodeSize = NodeEditorWindow.current.nodeSizes[node];

            // Special variables used for SAConfigHitboxNode
            Node previousConnectedNode = null;
            float savedYPos = 0;

            float heightOffset = 0;
            float widthOffset = 0;
            int portCount = 0;
            foreach (NodePort port in node.Outputs)
            {
                foreach (NodePort connectedPort in port.GetConnections())
                {
                    Vector2 branchDepth = Vector2.zero;

                    if(connectedPort.node.GetType().Equals(typeof(SAConfigHitboxNode)) && previousConnectedNode != null)
                    {
                        if (previousConnectedNode.GetType().Equals(typeof(SAConfigHitboxNode)))
                        {
                            Vector2 offset = nodePos + new Vector2(Consts.NodeXOffset * portCount, savedYPos);
                            TraverseThroughOutputsHeight(connectedPort.node, offset);
                        } else
                        {
                            savedYPos = heightOffset;
                            Vector2 offset = nodePos + new Vector2(Consts.NodeXOffset * portCount, heightOffset);
                            branchDepth = TraverseThroughOutputsHeight(connectedPort.node, offset);
                        }
                    } else
                    {
                        branchDepth = TraverseThroughOutputsHeight(connectedPort.node, nodePos + new Vector2(Consts.NodeXOffset, heightOffset));
                    }

                    previousConnectedNode = connectedPort.node;
                    heightOffset += branchDepth.y;
                    widthOffset = branchDepth.x;
                    if (widthOffset > nodePos.x + Consts.NodeXOffset) 
                        heightOffset += Consts.NodeClusterYSpacing;
                }
                ++portCount;
            }

            return new Vector2 (widthOffset + nodePos.x, heightOffset > nodeSize.y ? heightOffset : nodeSize.y);
        }
    }
}