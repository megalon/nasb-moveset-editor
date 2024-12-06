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
	public class SACancelToStateNode : StateActionNode
	{
		[Input(connectionType = ConnectionType.Override)] public StateAction NodeInput;
		public string ToState;
		public bool Soft;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.CancelStateId;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SACancelToState data, MovesetGraph graph, string assetPath, Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SACancelToState));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			ToState = data.ToState;
			Soft = data.Soft;
			return variableCount;
		}
		
		public new SACancelToState GetData()
		{
			SACancelToState objToReturn = new SACancelToState();
			objToReturn.TID = TypeId.CancelStateId;
			objToReturn.Version = Version;
			objToReturn.ToState = ToState;
			objToReturn.Soft = Soft;
			return objToReturn;
		}
	}
}

