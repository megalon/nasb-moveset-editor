using NASB_Moveset_Editor.CheckThings;
using NASB_Moveset_Editor.StateActions;
using NASB_Parser.StateActions;
using System.Linq;
using UnityEditor;
using UnityEngine;
using XNodeEditor;
using static XNode.Node;

namespace NASB_Moveset_Editor {

    [CustomNodeEditor(typeof(SAOrderedSensitiveNode))]
    public class SAOrderedSensitiveNodeEditor : NodeEditor
    {
        private const int maxOutputs = 50;

        public override void OnCreate()
        {
            base.OnCreate();
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

                NodeEditorGUILayout.PropertyField(iterator, true);
            }

            if (GUILayout.Button("Update"))
            {
                UpdateNumberOfOutputs(target, serializedObject.FindProperty("listSize").intValue);
            }

            // Iterate through dynamic ports and draw them in the order in which they are serialized
            foreach (XNode.NodePort dynamicPort in target.DynamicPorts)
            {
                if (NodeEditorGUILayout.IsDynamicPortListPort(dynamicPort)) continue;
                NodeEditorGUILayout.PortField(dynamicPort);
            }

            serializedObject.ApplyModifiedProperties();
        }

        private static void UpdateNumberOfOutputs(XNode.Node target, int numOutputs)
        {
            while (numOutputs < target.Outputs.Count() && target.Outputs.Count() > 2)
            {
                target.RemoveDynamicPort("" + (target.Outputs.Count()));
            }

            while (numOutputs > target.Outputs.Count() && target.Outputs.Count() < maxOutputs)
            {
                target.AddDynamicOutput(typeof(StateAction), ConnectionType.Override, TypeConstraint.None, "" + (target.Outputs.Count() + 1));
            }
        }
    }
}
