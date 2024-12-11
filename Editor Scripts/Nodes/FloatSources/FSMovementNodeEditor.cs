using System.Linq;
using UnityEngine;
using UnityEditor;
using XNodeEditor;
using NASB_Moveset_Editor.FloatSources;
using static MovesetParser.FloatSources.FSMovement;

namespace NASB_Moveset_Editor
{
    [CustomNodeEditor(typeof(FSMovementNode))]
    public class FSMovementNodeEditor : FloatSourceNodeEditor
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
                    
                    // Since this enum skips from 71 to 83 we need to set it 72
                    // so that it displays correctly in the editor
                    if (iterator.intValue == 83)
                    {
                        iterator.intValue = 72;
                    }

                    iterator.intValue = EditorGUILayout.Popup(iterator.intValue, iterator.enumDisplayNames);

                    // If we don't do this the wrong value gets saved
                    if (iterator.intValue == 72)
                    {
                        iterator.intValue = 83;
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