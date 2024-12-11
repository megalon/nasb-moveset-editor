using System.Linq;
using UnityEngine;
using UnityEditor;
using XNodeEditor;
using NASB_Moveset_Editor.FloatSources;
using static MovesetParser.FloatSources.FSMovement;

namespace NASB_Moveset_Editor
{
    [CustomNodeEditor(typeof(FSJumpsNode))]
    public class FSJumpsNodeEditor : FloatSourceNodeEditor
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

                if (iterator.name.Equals("Value"))
                {
                    continue;
                }

                if (iterator.type.Equals("string"))
                {
                    EditorGUILayout.LabelField(iterator.displayName);
                    iterator.stringValue = EditorGUILayout.TextField(iterator.stringValue);
                }
                else if (iterator.type.Equals("bool"))
                {
                    iterator.boolValue = EditorGUILayout.ToggleLeft(iterator.displayName, iterator.boolValue);
                }
                else if (iterator.type.Equals("Enum"))
                {
                    EditorGUILayout.LabelField(iterator.displayName);

                    // Since this enum skips from 18 to 27
                    if (iterator.intValue > 18)
                    {
                        iterator.intValue = iterator.intValue - 9;
                    }

                    iterator.intValue = EditorGUILayout.Popup(iterator.intValue, iterator.enumDisplayNames);

                    // If we don't do this the wrong value gets saved
                    if (iterator.intValue > 18)
                    {
                        iterator.intValue = iterator.intValue + 9;
                    }
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