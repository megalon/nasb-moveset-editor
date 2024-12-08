// * 
// * 
// * This file was generated using NASB_Parser_to_xNode by megalon2d
// * https://github.com/megalon/NASB_Parser_to_xNode
// * 
// * 
using MovesetParser.BulkSerialize;
using System.Diagnostics;
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
	public class MovesetNode : BaseMovesetNode
	{
		[Input(connectionType = ConnectionType.Override)] public Moveset NodeInput;
		[Output(connectionType = ConnectionType.Multiple)] public IdState[] States;
		
		protected override void Init()
		{
			base.Init();
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(Moveset data, MovesetGraph graph, string assetPath, UnityEngine.Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(Moveset));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			States = data.States;
			
			foreach (IdState States_item in data.States)
			{
				IdStateNode node_States = graph.AddNode<IdStateNode>();
				GetPort("States").Connect(node_States.GetPort("NodeInput"));
				AssetDatabase.AddObjectToAsset(node_States, assetPath);
				variableCount += node_States.SetData(States_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				++variableCount;
			}
			
			return variableCount;
		}
		
		public Moveset GetData()
		{
			Moveset objToReturn = new Moveset();
			objToReturn.States = new IdState[GetPort("States").ConnectionCount];
			int i = 0;
			foreach(NodePort port in GetPort("States").GetConnections())
			{
				IdStateNode IdState_Node = (IdStateNode)port.node;
				objToReturn.States[i] = IdState_Node.GetData();
				++i;
			}
			return objToReturn;
		}
	}
}

