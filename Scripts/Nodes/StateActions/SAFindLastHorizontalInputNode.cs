// * 
// * 
// * This file was generated using NASB_Parser_to_xNode by megalon2d
// * https://github.com/megalon/NASB_Parser_to_xNode
// * 
// * 
using MovesetParser.BulkSerialize;
using MovesetParser.Misc;
using UnityEngine;
using UnityEditor;
using XNode;
using XNodeEditor;
using MovesetParser;
using MovesetParser.CheckThings;
using MovesetParser.FloatSources;
using MovesetParser.Jumps;
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
using static MovesetParser.StateActions.StateAction;

namespace NASB_Moveset_Editor.StateActions
{
	public class SAFindLastHorizontalInputNode : StateActionNode
	{
		[Input(connectionType = ConnectionType.Override)] public StateAction NodeInput;
		[Output(connectionType = ConnectionType.Override)] public Search Search;
		[Output(connectionType = ConnectionType.Override)] public Stick Stick;
		public int ResultInScratch;
		public int DurationFrames;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.SAFindLastHorizontalInput;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SAFindLastHorizontalInput data, MovesetGraph graph, string assetPath, UnityEngine.Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SAFindLastHorizontalInput));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			Search = data.Search;
			
			SearchNode node_Search = graph.AddNode<SearchNode>();
			GetPort("Search").Connect(node_Search.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_Search, assetPath);
			variableCount += node_Search.SetData(Search, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			Stick = data.Stick;
			
			StickNode node_Stick = graph.AddNode<StickNode>();
			GetPort("Stick").Connect(node_Stick.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_Stick, assetPath);
			variableCount += node_Stick.SetData(Stick, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			ResultInScratch = data.ResultInScratch;
			DurationFrames = data.DurationFrames;
			return variableCount;
		}
		
		public new SAFindLastHorizontalInput GetData()
		{
			SAFindLastHorizontalInput objToReturn = new SAFindLastHorizontalInput();
			objToReturn.TID = TypeId.SAFindLastHorizontalInput;
			if (GetPort("Search").ConnectionCount > 0)
			{
				SearchNode Search_Node = (SearchNode)GetPort("Search").GetConnection(0).node;
				objToReturn.Search = Search_Node.GetData();
			}
			if (GetPort("Stick").ConnectionCount > 0)
			{
				StickNode Stick_Node = (StickNode)GetPort("Stick").GetConnection(0).node;
				objToReturn.Stick = Stick_Node.GetData();
			}
			objToReturn.ResultInScratch = ResultInScratch;
			objToReturn.DurationFrames = DurationFrames;
			return objToReturn;
		}
	}
}

