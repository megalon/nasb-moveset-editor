// * 
// * 
// * This file was generated using NASB_Parser_to_xNode by megalon2d
// * https://github.com/megalon/NASB_Parser_to_xNode
// * 
// * 
using MovesetParser.BulkSerialize;
using System;
using UnityEngine;
using UnityEditor;
using XNode;
using XNodeEditor;
using MovesetParser;
using MovesetParser.CheckThings;
using MovesetParser.FloatSources;
using MovesetParser.Jumps;
using MovesetParser.Misc;
using MovesetParser.StateActions;
using MovesetParser.ObjectSources;
using MovesetParser.Unity;
using NASB_Moveset_Editor.CheckThings;
using NASB_Moveset_Editor.FloatSources;
using NASB_Moveset_Editor.Jumps;
using NASB_Moveset_Editor.Misc;
using NASB_Moveset_Editor.StateActions;
using NASB_Moveset_Editor.ObjectSources;
using NASB_Moveset_Editor.Unity;

namespace NASB_Moveset_Editor
{
	public class AgentStateNode : BaseMovesetNode
	{
		[Input(connectionType = ConnectionType.Override)] public AgentState NodeInput;
		public TimedAction[] Timeline;
		public string CustomCall;
		
		protected override void Init()
		{
			base.Init();
			Timeline = new TimedAction[1];
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(AgentState data, MovesetGraph graph, string assetPath, UnityEngine.Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(AgentState));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			Timeline = data.Timeline;
			CustomCall = data.CustomCall;
			return variableCount;
		}
		
		public AgentState GetData()
		{
			AgentState objToReturn = new AgentState();
			objToReturn.Timeline = Timeline;
			objToReturn.CustomCall = CustomCall;
			return objToReturn;
		}
	}
}

