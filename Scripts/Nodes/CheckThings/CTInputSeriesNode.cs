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
using static NASB_Parser.CheckThings.CheckThing;

namespace NASB_Moveset_Editor.CheckThings
{
	public class CTInputSeriesNode : CheckThingNode
	{
		public int CheckFrames;
		[Output] public List<LookForInput> InputSeries;
		[Output] public List<LookForInput> StopLooking;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.InputSeriesId;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(CTInputSeries data, MovesetGraph graph, string assetPath, Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(CTInputSeries));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			CheckFrames = data.CheckFrames;
			InputSeries = data.InputSeries;
			
			foreach (LookForInput InputSeries_item in data.InputSeries)
			{
				LookForInputNode node_InputSeries = graph.AddNode<LookForInputNode>();
				GetPort("InputSeries").Connect(node_InputSeries.GetPort("NodeInput"));
				AssetDatabase.AddObjectToAsset(node_InputSeries, assetPath);
				variableCount += node_InputSeries.SetData(InputSeries_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				++variableCount;
			}
			
			StopLooking = data.StopLooking;
			
			foreach (LookForInput StopLooking_item in data.StopLooking)
			{
				LookForInputNode node_StopLooking = graph.AddNode<LookForInputNode>();
				GetPort("StopLooking").Connect(node_StopLooking.GetPort("NodeInput"));
				AssetDatabase.AddObjectToAsset(node_StopLooking, assetPath);
				variableCount += node_StopLooking.SetData(StopLooking_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				++variableCount;
			}
			
			return variableCount;
		}
		
		public new CTInputSeries GetData()
		{
			CTInputSeries objToReturn = new CTInputSeries();
			objToReturn.TID = TypeId.InputSeriesId;
			objToReturn.Version = Version;
			objToReturn.CheckFrames = CheckFrames;
			foreach(NodePort port in GetPort("InputSeries").GetConnections())
			{
				LookForInputNode LookForInput_Node = (LookForInputNode)port.node;
				objToReturn.InputSeries.Add(LookForInput_Node.GetData());
			}
			foreach(NodePort port in GetPort("StopLooking").GetConnections())
			{
				LookForInputNode LookForInput_Node = (LookForInputNode)port.node;
				objToReturn.StopLooking.Add(LookForInput_Node.GetData());
			}
			return objToReturn;
		}
	}
}

