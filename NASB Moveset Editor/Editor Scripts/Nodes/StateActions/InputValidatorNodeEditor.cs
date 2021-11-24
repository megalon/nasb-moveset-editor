using NASB_Moveset_Editor.StateActions;
using NASB_Parser.StateActions;
using System.Linq;
using UnityEditor;
using XNodeEditor;

namespace NASB_Moveset_Editor
{

    /// <summary> 
    /// NodeEditor functions similarly to the Editor class, only it is xNode specific.
    /// Custom node editors should have the CustomNodeEditor attribute that defines which node type it is an editor for.
    /// </summary>
    [CustomNodeEditor(typeof(InputValidatorNode))]
    public class InputValidatorNodeEditor : NodeEditor
    {
        InputValidator.CtrlSeg ctrlSeg;


        bool initialized = false;
        /// <summary> Called whenever the xNode editor window is updated </summary>
        public override void OnBodyGUI()
        {
            // Unity specifically requires this to save/update any serial object.
            // serializedObject.Update(); must go at the start of an inspector gui, and
            // serializedObject.ApplyModifiedProperties(); goes at the end.
            serializedObject.Update();
            string[] excludes = { "m_Script", "graph", "position", "ports" };

            // Iterate through serialized properties and draw them like the Inspector (But with ports)
            SerializedProperty iterator = serializedObject.GetIterator();
            bool enterChildren = true;

            while (iterator.NextVisible(enterChildren))
            {
                enterChildren = false;
                if (excludes.Contains(iterator.name)) continue;

                if (iterator.type.Equals("Enum")) {
                    if (iterator.name.Equals("Segment"))
                    {
                        // Initialize the item on first load
                        if (!initialized)
                        {
                            ctrlSeg = (InputValidator.CtrlSeg)iterator.intValue;
                            initialized = true;
                        }
                        EditorGUILayout.LabelField(iterator.displayName);
                        ctrlSeg = (InputValidator.CtrlSeg)EditorGUILayout.EnumFlagsField(ctrlSeg);
                        iterator.intValue = (int)ctrlSeg;
                    } else if (iterator.name.Equals("SegCompare") || iterator.name.Equals("MultiCompare"))
                    {
                        NodeEditorGUILayout.PropertyField(iterator, true);
                    } else
                    {
                        EditorGUILayout.LabelField(iterator.displayName);
                        iterator.intValue = EditorGUILayout.Popup(iterator.intValue, iterator.enumDisplayNames);
                    }
                }
                else if (iterator.type.Equals("bool"))
                {
                    iterator.boolValue = EditorGUILayout.ToggleLeft(iterator.displayName, iterator.boolValue);
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