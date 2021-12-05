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
	public class IdStateNode : Node
	{
		public string Id;
		public List<string> Tags;
		[Output(connectionType = ConnectionType.Override)] public AgentState State;
		
		protected override void Init()
		{
			base.Init();
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(IdState data, MovesetGraph graph, string assetPath, Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(IdState));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			Id = data.Id;
			Tags = data.Tags;
			State = data.State;
			
			AgentStateNode node_State = graph.AddNode<AgentStateNode>();
			GetPort("State").Connect(node_State.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_State, assetPath);
			variableCount += node_State.SetData(State, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
			
			return variableCount;
		}
		
		public IdState GetData()
		{
			IdState objToReturn = new IdState();
			objToReturn.Id = Id;
			objToReturn.Tags = Tags;
			if (GetPort("State").ConnectionCount > 0)
			{
				AgentStateNode AgentState_Node = (AgentStateNode)GetPort("State").GetConnection(0).node;
				objToReturn.State = AgentState_Node.GetData();
			}
			return objToReturn;
		}
	}
}

