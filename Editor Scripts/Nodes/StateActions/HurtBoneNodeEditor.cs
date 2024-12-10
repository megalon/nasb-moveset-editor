using NASB_Moveset_Editor;
using NASB_Moveset_Editor.Misc;
using NASB_Moveset_Editor.StateActions;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;
using XNodeEditor;

namespace NASB_Moveset_Editor
{
    [CustomNodeEditor(typeof(HurtSetSetup_HurtBoneNode))]
    public class HurtBoneNodeEditor : BaseMovesetNodeEditor
    {
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

                if (iterator.type.Equals("string"))
                {
                    EditorGUILayout.LabelField(iterator.displayName);
                    iterator.stringValue = EditorGUILayout.TextField(iterator.stringValue);
                } else if (iterator.name.Equals("KnockbackArmor"))
                {
                    EditorGUILayout.LabelField(iterator.displayName);
                    iterator.intValue = EditorGUILayout.IntField(iterator.intValue);
                } else if (iterator.name.Equals("ForceZ0"))
                {
                    // ForceZ0 is ignored as of game update v21.5.0
                    // And NASB Parser for Unity v1.2.0
                }
                else
                {
                    NodeEditorGUILayout.PropertyField(iterator, true);
                }
            }

            serializedObject.ApplyModifiedProperties();
        }
    }
}