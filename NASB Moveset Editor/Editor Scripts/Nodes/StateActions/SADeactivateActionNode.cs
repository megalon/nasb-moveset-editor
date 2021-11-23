// * 
// * 
// * This file was generated using NASB_Parser_to_xNode by megalon2d
// * https://github.com/megalon/NASB_Parser_to_xNode
// * 
// * 
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEditor;
using XNode;
using XNodeEditor;
using NASB_Parser;
using NASB_Parser.FloatSources;
using NASB_Parser.Jumps;
using NASB_Parser.CheckThings;
using NASB_Parser.StateActions;
using NASB_Parser.ObjectSources;
using NASB_Moveset_Editor.FloatSources;
using NASB_Moveset_Editor.Jumps;
using NASB_Moveset_Editor.CheckThings;
using NASB_Moveset_Editor.StateActions;
using NASB_Moveset_Editor.ObjectSources;
using static NASB_Parser.StateActions.StateAction;

namespace NASB_Moveset_Editor.StateActions
{
	public class SADeactivateActionNode : StateActionNode
	{
		public int Index;
		public string Id;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.DeactivateActionId;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SADeactivateAction data, MovesetGraph graph, string assetPath, Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SADeactivateAction));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			Index = data.Index;
			Id = data.Id;
			return variableCount;
		}
		
		public new SADeactivateAction GetData()
		{
			SADeactivateAction objToReturn = new SADeactivateAction();
			objToReturn.TID = TypeId.DeactivateActionId;
			objToReturn.Version = Version;
			objToReturn.Index = Index;
			objToReturn.Id = Id;
			return objToReturn;
		}
	}
}

