using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NASB_Parser;
using XNodeEditor;
using NASB_Moveset_Editor.FloatSources;
using UnityEditor;
using System.Linq;

namespace NASB_Moveset_Editor
{

    [CustomNodeEditor(typeof(FSFuncNode))]
    public class FSFuncNodeEditor : NodeEditor
    {
        private NASB_Parser.FloatSources.FSFunc.FuncWay currentFunc;

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

                if (iterator.type.Equals("Enum"))
                {
                    iterator.intValue = EditorGUILayout.Popup(iterator.intValue, iterator.enumDisplayNames);
                    currentFunc = (NASB_Parser.FloatSources.FSFunc.FuncWay)iterator.intValue;

                    if (!Utils.funcTextDict[currentFunc].ContainerContents["Formula"].tooltip.Equals(string.Empty))
                    {
                        EditorGUILayout.HelpBox(Utils.funcTextDict[currentFunc].ContainerContents["Formula"]);
                    }
                } else if (iterator.type.Equals("FloatSource") && Utils.funcTextDict.ContainsKey(currentFunc))
                {
                    NodeEditorGUILayout.PropertyField(iterator, Utils.funcTextDict[currentFunc].ContainerContents[iterator.name], true);
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