using NASB_Moveset_Editor.CheckThings;
using NASB_Moveset_Editor.StateActions;
using NASB_Parser.StateActions;
using System.Linq;
using UnityEditor;
using UnityEngine;
using XNodeEditor;

namespace NASB_Moveset_Editor
{
    [CustomNodeEditor(typeof(InputTriggerNode))]
    public class InputTriggerNodeEditor : StateActionNodeEditor
    {
        GIEV giev_BlockedByEvent;
        GIEV giev_AddEventOnTrigger;

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

                if (iterator.type.Equals("Enum") && iterator.name.Equals("BlockedByEvent"))
                {
                    // Initialize the item on first load
                    if (!initialized)
                    {
                        giev_BlockedByEvent = (GIEV)iterator.intValue;
                        initialized = true;
                    }
                    EditorGUILayout.LabelField(iterator.displayName);
                    giev_BlockedByEvent = (GIEV)EditorGUILayout.EnumFlagsField(giev_BlockedByEvent);
                    iterator.intValue = (int)giev_BlockedByEvent;
                }
                else if (iterator.type.Equals("Enum") && iterator.name.Equals("AddEventOnTrigger"))
                {
                    // Initialize the item on first load
                    if (!initialized)
                    {
                        giev_AddEventOnTrigger = (GIEV)iterator.intValue;
                        initialized = true;
                    }
                    EditorGUILayout.LabelField(iterator.displayName);
                    giev_AddEventOnTrigger = (GIEV)EditorGUILayout.EnumFlagsField(giev_AddEventOnTrigger);
                    iterator.intValue = (int)giev_AddEventOnTrigger;
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