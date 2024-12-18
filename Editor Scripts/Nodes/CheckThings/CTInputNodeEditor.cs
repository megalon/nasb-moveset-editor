using NASB_Moveset_Editor.CheckThings;
using MovesetParser.StateActions;
using System.Linq;
using UnityEditor;
using XNodeEditor;
using MovesetParser.Misc;

namespace NASB_Moveset_Editor
{
    [CustomNodeEditor(typeof(CTInputNode))]
    public class CTInputNodeEditor : CheckThingNodeEditor
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

                if (iterator.type.Equals("Enum") && iterator.name.Equals("BlockedBy"))
                {
                    // Initialize the item on first load
                    if (!initialized)
                    {
                        giev = (GIEV)iterator.intValue;
                        initialized = true;
                    }

                    EditorGUILayout.LabelField(iterator.displayName);
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