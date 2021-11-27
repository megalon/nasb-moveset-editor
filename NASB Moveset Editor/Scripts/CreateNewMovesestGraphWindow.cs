using NASB_Parser;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.IO;
using System.Linq;

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
            textAssetName = "char_example";
            stateId = "idle";
        }

        private void OnGUI()
        {
            EditorGUILayout.BeginHorizontal();
            {
                GUILayout.FlexibleSpace();
                EditorGUILayout.BeginVertical(GUILayout.MaxWidth(400));
                {
                    EditorGUILayout.Space(10);
                    movesetType = (MovesetType)EditorGUILayout.EnumPopup("Moveset Type", movesetType);
                    EditorGUILayout.Space(10);
                    textAssetName = EditorGUILayout.TextField("TextAsset Name", textAssetName);
                    EditorGUILayout.Space(10);
                    stateId = EditorGUILayout.TextField("State ID", stateId);
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

            if (GraphHandlerWindow.graphNames.Contains(textAssetName))
            {
                GraphHandler.AddGraphToExistingFolder(data, textAssetName, Path.Combine(Utils.GetGraphsDirPath(), textAssetName));
            }
            else
            {
                GraphHandler.GenerateGraphs(data, textAssetName);
            }

            this.Close();
        }
    }
}
