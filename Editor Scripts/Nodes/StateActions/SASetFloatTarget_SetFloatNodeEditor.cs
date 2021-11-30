using NASB_Moveset_Editor.CheckThings;
using NASB_Moveset_Editor.StateActions;
using NASB_Parser.StateActions;
using System.Linq;
using UnityEditor;
using XNodeEditor;

namespace NASB_Moveset_Editor
{
    [CustomNodeEditor(typeof(SASetFloatTarget_SetFloatNode))]
    public class SASetFloatTarget_SetFloatNodeEditor : StateActionNodeEditor
    {
        string[] options = { "[=]   Set", "[+]   Add", "[*]   Multiply"};
        public override void OnBodyGUI()
        {
            serializedObject.Update();
            string[] excludes = { "m_Script", "graph", "position", "ports" };

            SerializedProperty iterator = serializedObject.GetIterator();

            // Node input
            NodeEditorGUILayout.PropertyField(iterator.serializedObject.FindProperty("NodeInput"), true);
            NodeEditorGUILayout.PropertyField(iterator.serializedObject.FindProperty("Target"), true);

            SerializedProperty waySelect = iterator.serializedObject.FindProperty("Way");
            waySelect.intValue = EditorGUILayout.Popup(waySelect.intValue, options);

            NodeEditorGUILayout.PropertyField(iterator.serializedObject.FindProperty("Source"), true);

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