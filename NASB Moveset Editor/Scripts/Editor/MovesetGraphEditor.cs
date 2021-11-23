using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XNodeEditor;

namespace NASB_Moveset_Editor
{
	[CustomNodeGraphEditor(typeof(MovesetGraph))]
	public class MovesetGraphEditor : NodeGraphEditor
	{
		/// <summary> 
		/// Overriding GetNodeMenuName lets you control if and how nodes are categorized.
		/// In this example we are sorting out all node types that are not in the XNode.Examples namespace.
		/// </summary>
		public override string GetNodeMenuName(System.Type type)
		{
			if (type.Namespace != null && type.Namespace.StartsWith("NASB_Moveset_Editor"))
			{
				return base.GetNodeMenuName(type).Replace("NASB_Moveset_Editor/", "");
			}
			else return null;
		}
	}
}