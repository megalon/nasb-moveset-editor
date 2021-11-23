using NASB_Moveset_Editor.CheckThings;
using NASB_Parser.StateActions;
using System.Linq;
using UnityEditor;
using XNodeEditor;

namespace NASB_Moveset_Editor
{
    [CustomNodeEditor(typeof(CTCompareFloatNode))]
    public class CTCompareFloatNodeEditor : NodeEditor
    {
        string[] options = { "[==]   Equals", "[!=]   Not equals", "[<]   Less than", "[>]   Greater than", "[<=]   Less than or equal", "[>=]   Greater than or equal" };
        public override void OnBodyGUI()
        {
            serializedObject.Update();
            string[] excludes = { "m_Script", "graph", "position", "ports" };

            SerializedProperty iterator = serializedObject.GetIterator();

            // Node input
            NodeEditorGUILayout.PropertyField(iterator.serializedObject.FindProperty("NodeInput"), true);
            NodeEditorGUILayout.PropertyField(iterator.serializedObject.FindProperty("A"), true);
            
            SerializedProperty waySelect = iterator.serializedObject.FindProperty("Way");
            waySelect.intValue = EditorGUILayout.Popup(waySelect.intValue, options);

            NodeEditorGUILayout.PropertyField(iterator.serializedObject.FindProperty("B"), true);

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