using MovesetParser.StateActions;
using System.Linq;
using UnityEngine;
using UnityEditor;
using XNodeEditor;

namespace NASB_Moveset_Editor
{
    [CustomNodeEditor(typeof(BaseMovesetNode))]
    public class BaseMovesetNodeEditor : NodeEditor
    {
        public override void OnHeaderGUI()
        {
            if (target.name.Contains("_"))
            {
                string updatedName = target.name.Substring(target.name.IndexOf("_") + 1);
                GUILayout.Label(updatedName, NodeEditorResources.styles.nodeHeader, GUILayout.Height(30));
            } else
            {
                base.OnHeaderGUI();
            }
        }

        public override void OnBodyGUI()
        {
            serializedObject.Update();
            string[] excludes = { "m_Script", "graph", "position", "ports" };

            SerializedProperty iterator = serializedObject.GetIterator();

            bool enterChildren = true;
            while (iterator.NextVisible(enterChildren))
            {
                enterChildren = false;
                if (excludes.Contains(iterator.name)) continue;

                if (iterator.type.Equals("string")) {
                    DisplayStringProp(iterator);
                } else if (iterator.type.Equals("bool")) {
                    iterator.boolValue = EditorGUILayout.ToggleLeft(iterator.displayName, iterator.boolValue);
                } else if (iterator.type.Equals("Enum") && iterator.displayName.Length > Consts.MaxDisplayNameLength)
                {
                    EditorGUILayout.LabelField(iterator.displayName);
                    iterator.intValue = EditorGUILayout.Popup(iterator.intValue, iterator.enumDisplayNames);
                }
                else if (iterator.type.Equals("float") && iterator.displayName.Length > Consts.MaxDisplayNameLength)
                {
                    EditorGUILayout.LabelField(iterator.displayName);
                    iterator.floatValue = EditorGUILayout.FloatField(iterator.floatValue);
                }
                else if (iterator.type.Equals("int") && iterator.displayName.Length > Consts.MaxDisplayNameLength)
                {
                    EditorGUILayout.LabelField(iterator.displayName);
                    iterator.intValue = EditorGUILayout.IntField(iterator.intValue);
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

        protected void DisplayStringProp(SerializedProperty property)
        {
            EditorGUILayout.LabelField(property.displayName);
            property.stringValue = EditorGUILayout.TextField(property.stringValue);
        }
    }
}