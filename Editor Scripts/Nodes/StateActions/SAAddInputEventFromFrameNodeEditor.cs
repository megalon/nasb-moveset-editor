using NASB_Moveset_Editor.CheckThings;
using NASB_Moveset_Editor.StateActions;
using MovesetParser.StateActions;
using System.Linq;
using UnityEditor;
using UnityEngine;
using XNodeEditor;
using MovesetParser.Misc;

namespace NASB_Moveset_Editor
{
    [CustomNodeEditor(typeof(SAAddInputEventFromFrameNode))]
    public class SAAddInputEventFromFrameNodeEditor : StateActionNodeEditor
    {
        GIEV giev;

        bool initialized = false;
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

                if (iterator.type.Equals("Enum") && iterator.name.Equals("AddEvent"))
                {
                    // Initialize the item on first load
                    if (!initialized)
                    {
                        giev = (GIEV)iterator.intValue;
                        initialized = true;
                    }
                    giev = (GIEV)EditorGUILayout.EnumFlagsField(giev);
                    iterator.intValue = (int)giev;
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