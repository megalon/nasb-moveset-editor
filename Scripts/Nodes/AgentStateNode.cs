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
		[Output(connectionType = ConnectionType.Multiple)] public TimedAction[] Timeline;
		public string CustomCall;
		
		protected override void Init()
		{
			base.Init();
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
			
			foreach (TimedAction Timeline_item in data.Timeline)
			{
				TimedActionNode node_Timeline = graph.AddNode<TimedActionNode>();
				GetPort("Timeline").Connect(node_Timeline.GetPort("NodeInput"));
				AssetDatabase.AddObjectToAsset(node_Timeline, assetPath);
				variableCount += node_Timeline.SetData(Timeline_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				++variableCount;
			}
			
			CustomCall = data.CustomCall;
			return variableCount;
		}
		
		public AgentState GetData()
		{
			AgentState objToReturn = new AgentState();
			objToReturn.Timeline = new TimedAction[GetPort("Timeline").ConnectionCount];
			int i = 0;
			foreach(NodePort port in GetPort("Timeline").GetConnections())
			{
				TimedActionNode TimedAction_Node = (TimedActionNode)port.node;
				objToReturn.Timeline[i] = TimedAction_Node.GetData();
				++i;
			}
			objToReturn.CustomCall = CustomCall;
			return objToReturn;
		}
	}
}

