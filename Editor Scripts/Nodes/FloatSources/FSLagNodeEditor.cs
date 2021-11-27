using System.Linq;
using UnityEngine;
using UnityEditor;
using XNodeEditor;
using NASB_Moveset_Editor.FloatSources;

namespace NASB_Moveset_Editor
{
    [CustomNodeEditor(typeof(FSLagNode))]
    public class FSLagNodeEditor : NodeEditor
    {
        public override void OnBodyGUI()
        {
            base.OnBodyGUI();
        }
    }
}