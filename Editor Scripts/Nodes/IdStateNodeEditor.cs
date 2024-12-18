using MovesetParser.StateActions;
using System.Linq;
using UnityEngine;
using UnityEditor;
using XNodeEditor;

namespace NASB_Moveset_Editor
{
    [CustomNodeEditor(typeof(IdStateNode))]
    public class IdStateNodeEditor : BaseMovesetNodeEditor
    {
        public override void OnBodyGUI()
        {
            serializedObject.Update();
            string[] excludes = { "m_Script", "graph", "position", "ports" };

            SerializedProperty iterator = serializedObject.GetIterator();

            var nameof = GUI.GetNameOfFocusedControl();

            bool enterChildren = true;
            while (iterator.NextVisible(enterChildren))
            {
                enterChildren = false;
                if (excludes.Contains(iterator.name)) continue;

                if (iterator.type.Equals("string"))
                {
                    EditorGUILayout.LabelField(iterator.displayName);
                    iterator.stringValue = EditorGUILayout.TextField(iterator.stringValue);
                }
                else
                {
                    NodeEditorGUILayout.PropertyField(iterator, true);
                }
            }

            // Iterate through dynamic ports and draw them in the order in which they are serialized
            foreach (XNode.NodePort dynamicPort in target.DynamicPorts)
            {
                if (NodeEditorGUILayout.IsDynamicPortListPort(dynamicPort)) continue;
                NodeEditorGUILayout.PortField(dynamicPort);
            }

            serializedObject.ApplyModifiedProperties();
        }
    }
}