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
    public class FSFuncText
    {
        public Dictionary<string, GUIContent> ContainerContents;

        public FSFuncText(string AText, string BText, string CText)
        {
            ContainerContents = new Dictionary<string, GUIContent>();
            ContainerContents.Add("ContainerA", new GUIContent(AText));
            ContainerContents.Add("ContainerB", new GUIContent(BText));
            ContainerContents.Add("ContainerC", new GUIContent(CText));
        }
    }

    [CustomNodeEditor(typeof(FSFuncNode))]
    public class FSFuncNodeEditor : NodeEditor
    {
        private Dictionary<NASB_Parser.FloatSources.FSFunc.FuncWay, FSFuncText> funcTextDict = new Dictionary<NASB_Parser.FloatSources.FSFunc.FuncWay, FSFuncText>();
        private NASB_Parser.FloatSources.FSFunc.FuncWay currentFunc;

        public override void OnCreate()
        {
            base.OnCreate();
            funcTextDict.Add(NASB_Parser.FloatSources.FSFunc.FuncWay.Abs, new FSFuncText("Input", "", ""));
            funcTextDict.Add(NASB_Parser.FloatSources.FSFunc.FuncWay.Add, new FSFuncText("A", "B", ""));
            funcTextDict.Add(NASB_Parser.FloatSources.FSFunc.FuncWay.Sub, new FSFuncText("A", "B", ""));
            funcTextDict.Add(NASB_Parser.FloatSources.FSFunc.FuncWay.Div, new FSFuncText("A", "B", ""));
            funcTextDict.Add(NASB_Parser.FloatSources.FSFunc.FuncWay.Mult, new FSFuncText("A", "B", ""));
            funcTextDict.Add(NASB_Parser.FloatSources.FSFunc.FuncWay.Sin, new FSFuncText("Input Deg", "", ""));
            funcTextDict.Add(NASB_Parser.FloatSources.FSFunc.FuncWay.Cos, new FSFuncText("Input Deg", "", ""));
            funcTextDict.Add(NASB_Parser.FloatSources.FSFunc.FuncWay.Mod, new FSFuncText("A", "B", ""));
            funcTextDict.Add(NASB_Parser.FloatSources.FSFunc.FuncWay.Clamp, new FSFuncText("Input", "Min", "Max"));
            funcTextDict.Add(NASB_Parser.FloatSources.FSFunc.FuncWay.Floor, new FSFuncText("Input", "", ""));
            funcTextDict.Add(NASB_Parser.FloatSources.FSFunc.FuncWay.Ceil, new FSFuncText("Input", "", ""));
            funcTextDict.Add(NASB_Parser.FloatSources.FSFunc.FuncWay.MoveTo, new FSFuncText("Current", "Target", "Max Delta"));
            funcTextDict.Add(NASB_Parser.FloatSources.FSFunc.FuncWay.MoveToAng, new FSFuncText("Current", "Target", "Max Delta"));
            funcTextDict.Add(NASB_Parser.FloatSources.FSFunc.FuncWay.MoveToF, new FSFuncText("Current", "Target", "Max Delta"));
            funcTextDict.Add(NASB_Parser.FloatSources.FSFunc.FuncWay.MoveToAngF, new FSFuncText("Current", "Target", "Max Delta"));
            funcTextDict.Add(NASB_Parser.FloatSources.FSFunc.FuncWay.Sign, new FSFuncText("Input", "", ""));
            funcTextDict.Add(NASB_Parser.FloatSources.FSFunc.FuncWay.Lerp, new FSFuncText("A", "B", "T"));
            funcTextDict.Add(NASB_Parser.FloatSources.FSFunc.FuncWay.InvLerp, new FSFuncText("A", "B", "T"));
            funcTextDict.Add(NASB_Parser.FloatSources.FSFunc.FuncWay.Repeat, new FSFuncText("Input", "Length", ""));
            funcTextDict.Add(NASB_Parser.FloatSources.FSFunc.FuncWay.Pow, new FSFuncText("Input", "Power", ""));
            funcTextDict.Add(NASB_Parser.FloatSources.FSFunc.FuncWay.Sqrt, new FSFuncText("Input", "", ""));
            funcTextDict.Add(NASB_Parser.FloatSources.FSFunc.FuncWay.Log, new FSFuncText("Input", "", ""));
            funcTextDict.Add(NASB_Parser.FloatSources.FSFunc.FuncWay.Log10, new FSFuncText("Input", "", ""));
            funcTextDict.Add(NASB_Parser.FloatSources.FSFunc.FuncWay.Atan, new FSFuncText("Input", "", ""));
            funcTextDict.Add(NASB_Parser.FloatSources.FSFunc.FuncWay.Atan2, new FSFuncText("Y", "X", ""));
            funcTextDict.Add(NASB_Parser.FloatSources.FSFunc.FuncWay.RoundToInt, new FSFuncText("Input", "", ""));
            funcTextDict.Add(NASB_Parser.FloatSources.FSFunc.FuncWay.Max, new FSFuncText("A", "B", ""));
            funcTextDict.Add(NASB_Parser.FloatSources.FSFunc.FuncWay.Min, new FSFuncText("A", "B", ""));
            funcTextDict.Add(NASB_Parser.FloatSources.FSFunc.FuncWay.Pi, new FSFuncText("", "", ""));
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
                } else if (iterator.type.Equals("FloatSource") && funcTextDict.ContainsKey(currentFunc))
                {
                        NodeEditorGUILayout.PropertyField(iterator, funcTextDict[currentFunc].ContainerContents[iterator.name], true);
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