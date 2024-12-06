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
using static MovesetParser.Jumps.Jump;

namespace NASB_Moveset_Editor.Jumps
{
	public class ClampMomentumJumpNode : JumpNode
	{
		[Input(connectionType = ConnectionType.Override)] public Jump NodeInput;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.ClampMomentumId;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(ClampMomentumJump data, MovesetGraph graph, string assetPath, Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(ClampMomentumJump));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			return variableCount;
		}
		
		public new ClampMomentumJump GetData()
		{
			ClampMomentumJump objToReturn = new ClampMomentumJump();
			objToReturn.TID = TypeId.ClampMomentumId;
			objToReturn.Version = Version;
			return objToReturn;
		}
	}
}

