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

namespace NASB_Moveset_Editor
{
	public class AgentStateNode : BaseMovesetNode
	{
		public string CustomCall;
		[Output] public List<TimedAction> Timeline;
		
		protected override void Init()
		{
			base.Init();
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(AgentState data, MovesetGraph graph, string assetPath, Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(AgentState));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			CustomCall = data.CustomCall;
			Timeline = data.Timeline;
			
			foreach (TimedAction Timeline_item in data.Timeline)
			{
				TimedActionNode node_Timeline = graph.AddNode<TimedActionNode>();
				GetPort("Timeline").Connect(node_Timeline.GetPort("NodeInput"));
				AssetDatabase.AddObjectToAsset(node_Timeline, assetPath);
				variableCount += node_Timeline.SetData(Timeline_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				++variableCount;
			}
			
			return variableCount;
		}
		
		public AgentState GetData()
		{
			AgentState objToReturn = new AgentState();
			objToReturn.CustomCall = CustomCall;
			foreach(NodePort port in GetPort("Timeline").GetConnections())
			{
				TimedActionNode TimedAction_Node = (TimedActionNode)port.node;
				objToReturn.Timeline.Add(TimedAction_Node.GetData());
			}
			return objToReturn;
		}
	}
}

