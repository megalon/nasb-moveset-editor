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

namespace NASB_Moveset_Editor
{
	public class SerialMovesetNode : BaseMovesetNode
	{
		[Input(connectionType = ConnectionType.Override)] public SerialMoveset NodeInput;
		[Output(connectionType = ConnectionType.Multiple)] public List<IdState> States;
		
		protected override void Init()
		{
			base.Init();
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SerialMoveset data, MovesetGraph graph, string assetPath, Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SerialMoveset));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			States = data.States;
			
			foreach (IdState States_item in data.States)
			{
				IdStateNode node_States = graph.AddNode<IdStateNode>();
				GetPort("States").Connect(node_States.GetPort("NodeInput"));
				AssetDatabase.AddObjectToAsset(node_States, assetPath);
				variableCount += node_States.SetData(States_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				++variableCount;
			}
			
			return variableCount;
		}
		
		public SerialMoveset GetData()
		{
			SerialMoveset objToReturn = new SerialMoveset();
			foreach(NodePort port in GetPort("States").GetConnections())
			{
				IdStateNode IdState_Node = (IdStateNode)port.node;
				objToReturn.States.Add(IdState_Node.GetData());
			}
			return objToReturn;
		}
	}
}

