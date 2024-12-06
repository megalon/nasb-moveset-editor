using MovesetParser;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.IO;
using System.Linq;
using XNodeEditor;

namespace NASB_Moveset_Editor
{
    enum MovesetType {
        Character,
        Projectile
    }

    public class CreateNewMovesestGraphWindow : EditorWindow
    {
        string textAssetName;
        string stateId;
        MovesetType movesetType;

        private void OnEnable()
        {
            textAssetName = EditorPrefs.GetString(Consts.KEY_NEW_GRAPH_TEXTASSET_NAME, "char_example");
            stateId = EditorPrefs.GetString(Consts.KEY_NEW_GRAPH_STATE, "idle");
        }

        private void OnGUI()
        {
            EditorGUILayout.BeginHorizontal();
            {
                GUILayout.FlexibleSpace();
                EditorGUILayout.BeginVertical(GUILayout.MaxWidth(400));
                {
                    EditorGUILayout.Space(10);
                    EditorGUILayout.HelpBox("Import the \"characterBase\" TextAsset from NASB to view all the built-in states that characters can override!", MessageType.Info);
                    // EditorGUILayout.Space(10);
                    // movesetType = (MovesetType)EditorGUILayout.EnumPopup("Moveset Type", movesetType);
                    EditorGUILayout.Space(10);

                    // I think this is the wrong way of going about this, but it works
                    string newTextAssetName = EditorGUILayout.TextField("TextAsset Name", textAssetName).Trim();
                    if (!textAssetName.Equals(newTextAssetName))
                    {
                        EditorPrefs.SetString(Consts.KEY_NEW_GRAPH_TEXTASSET_NAME, newTextAssetName);
                    }
                    textAssetName = newTextAssetName;

                    EditorGUILayout.Space(10);

                    string newStateId = EditorGUILayout.TextField("State ID", stateId).Trim();
                    if (!stateId.Equals(newStateId))
                    {
                        EditorPrefs.SetString(Consts.KEY_NEW_GRAPH_STATE, newStateId);
                    }
                    stateId = newStateId;
                    
                    EditorGUILayout.Space(10);
                    if (GUILayout.Button("Create Moveset Graph", GUILayout.MinHeight(35))) CreateGraph();
                    EditorGUILayout.Space(10);
                }
                EditorGUILayout.EndVertical();
                GUILayout.FlexibleSpace();
            }
            EditorGUILayout.EndHorizontal();
        }

        private void CreateGraph()
        {
            SerialMoveset data = new SerialMoveset();

            IdState idState = new IdState();
            idState.Id = stateId;

            data.States.Add(idState);

            List<MovesetGraph> graphs = new List<MovesetGraph>();

            if (GraphHandlerWindow.graphNames.Contains(textAssetName))
            {
                // If other graphs already exist for this TextAsset, add the graph there
                graphs = GraphHandler.CreateGraphsForAllStates(data, textAssetName, Path.Combine(Utils.GetGraphsDirPath(), textAssetName));
            }
            else
            {
                // If this is the only graph for this TextAsset
                graphs = GraphHandler.GenerateGraphs(data, textAssetName);
            }

            NodeEditorWindow.Open(graphs[0]);
            NodeEditorWindow.current.SelectNode(graphs[0].nodes[0], false);
            NodeEditorWindow.current.panOffset = new Vector2(-100, -100);

            this.Close();
        }
    }
}
