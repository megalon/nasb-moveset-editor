// * 
// * 
// * This file was generated using MovesetParser_to_xNode by megalon2d
// * https://github.com/megalon/MovesetParser_to_xNode
// * 
// * 
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
using MovesetParser.StateActions;
using MovesetParser.ObjectSources;
using NASB_Moveset_Editor.FloatSources;
using NASB_Moveset_Editor.Jumps;
using NASB_Moveset_Editor.CheckThings;
using NASB_Moveset_Editor.StateActions;
using NASB_Moveset_Editor.ObjectSources;
using static MovesetParser.StateActions.StateAction;

namespace NASB_Moveset_Editor.StateActions
{
	public class SAStopJumpNode : StateActionNode
	{
		[Input(connectionType = ConnectionType.Override)] public StateAction NodeInput;
		public bool StopAll;
		public string JumpId;
		public List<string> JumpIds;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.StopJumpId;
			Version = 1;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SAStopJump data, MovesetGraph graph, string assetPath, Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SAStopJump));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			StopAll = data.StopAll;
			JumpId = data.JumpId;
			JumpIds = data.JumpIds;
			return variableCount;
		}
		
		public new SAStopJump GetData()
		{
			SAStopJump objToReturn = new SAStopJump();
			objToReturn.TID = TypeId.StopJumpId;
			objToReturn.Version = Version;
			objToReturn.StopAll = StopAll;
			objToReturn.JumpId = JumpId;
			objToReturn.JumpIds = JumpIds;
			return objToReturn;
		}
	}
}

