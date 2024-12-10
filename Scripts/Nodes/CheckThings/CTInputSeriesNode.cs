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
using static MovesetParser.CheckThings.CheckThing;

namespace NASB_Moveset_Editor.CheckThings
{
	public class CTInputSeriesNode : CheckThingNode
	{
		[Input(connectionType = ConnectionType.Override)] public CheckThing NodeInput;
		public int CheckFrames;
		[Output(connectionType = ConnectionType.Multiple)] public CTInputSeries.LookForInput[] InputSeries;
		[Output(connectionType = ConnectionType.Multiple)] public CTInputSeries.LookForInput[] StopLooking;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.CTInputSeries;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(CTInputSeries data, MovesetGraph graph, string assetPath, UnityEngine.Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(CTInputSeries));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			CheckFrames = data.CheckFrames;
			InputSeries = data.InputSeries;
			
			foreach (CTInputSeries.LookForInput InputSeries_item in InputSeries)
			{
				CTInputSeries_LookForInputNode node_InputSeries = graph.AddNode<CTInputSeries_LookForInputNode>();
				GetPort("InputSeries").Connect(node_InputSeries.GetPort("NodeInput"));
				AssetDatabase.AddObjectToAsset(node_InputSeries, assetPath);
				variableCount += node_InputSeries.SetData(InputSeries_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				++variableCount;
			}
			StopLooking = data.StopLooking;
			
			foreach (CTInputSeries.LookForInput StopLooking_item in StopLooking)
			{
				CTInputSeries_LookForInputNode node_StopLooking = graph.AddNode<CTInputSeries_LookForInputNode>();
				GetPort("StopLooking").Connect(node_StopLooking.GetPort("NodeInput"));
				AssetDatabase.AddObjectToAsset(node_StopLooking, assetPath);
				variableCount += node_StopLooking.SetData(StopLooking_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				++variableCount;
			}
			return variableCount;
		}
		
		public new CTInputSeries GetData()
		{
			CTInputSeries objToReturn = new CTInputSeries();
			objToReturn.TID = TypeId.CTInputSeries;
			objToReturn.CheckFrames = CheckFrames;
			objToReturn.InputSeries = new CTInputSeries.LookForInput[GetPort("InputSeries").ConnectionCount];
			int i = 0;
			foreach(NodePort port in GetPort("InputSeries").GetConnections())
			{
				CTInputSeries_LookForInputNode CTInputSeries_LookForInput_Node = (CTInputSeries_LookForInputNode)port.node;
				objToReturn.InputSeries[i] = CTInputSeries_LookForInput_Node.GetData();
				++i;
			}
			objToReturn.StopLooking = new CTInputSeries.LookForInput[GetPort("StopLooking").ConnectionCount];
			i = 0;
			foreach(NodePort port in GetPort("StopLooking").GetConnections())
			{
				CTInputSeries_LookForInputNode CTInputSeries_LookForInput_Node = (CTInputSeries_LookForInputNode)port.node;
				objToReturn.StopLooking[i] = CTInputSeries_LookForInput_Node.GetData();
				++i;
			}
			return objToReturn;
		}
	}
}

