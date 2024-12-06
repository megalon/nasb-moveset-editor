// * 
// * 
// * This file was generated using MovesetParser_to_xNode by megalon2d
// * https://github.com/megalon/MovesetParser_to_xNode
// * 
// * 
using MovesetParser.StateActions;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEditor;
using XNode;
using XNodeEditor;
using MovesetParser;
using MovesetParser.FloatSources;
using MovesetParser.Jumps;
using MovesetParser.CheckThings;
using MovesetParser.ObjectSources;
using NASB_Moveset_Editor.FloatSources;
using NASB_Moveset_Editor.Jumps;
using NASB_Moveset_Editor.CheckThings;
using NASB_Moveset_Editor.StateActions;
using NASB_Moveset_Editor.ObjectSources;
using static MovesetParser.StateActions.StateAction;

namespace NASB_Moveset_Editor.StateActions
{
	public class StateActionNode : BaseMovesetNode
	{
		[HideInInspector] public MovesetParser.StateActions.StateAction.TypeId TID;
		[HideInInspector] public int Version;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.BaseIdentifier;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(StateAction data, MovesetGraph graph, string assetPath, Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(StateAction));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			TID = data.TID;
			Version = data.Version;
			return variableCount;
		}
		
		public StateAction GetData()
		{
			StateAction objToReturn = new StateAction();
			objToReturn.TID = TypeId.BaseIdentifier;
			objToReturn.Version = Version;
			objToReturn.TID = TID;
			objToReturn.Version = Version;
			return objToReturn;
		}
	}
}

