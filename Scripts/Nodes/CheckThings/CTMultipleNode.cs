// * 
// * 
// * This file was generated using NASB_Parser_to_xNode by megalon2d
// * https://github.com/megalon/NASB_Parser_to_xNode
// * 
// * 
using MovesetParser.BulkSerialize;
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
using static MovesetParser.CheckThings.CheckThing;

namespace NASB_Moveset_Editor.CheckThings
{
	public class CTMultipleNode : CheckThingNode
	{
		[Input(connectionType = ConnectionType.Override)] public CheckThing NodeInput;
		public MovesetParser.CheckThings.CTMultiple.CheckMatch Match;
		[Output(connectionType = ConnectionType.Multiple)] public CheckThing[] Checklist;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.CTMultiple;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(CTMultiple data, MovesetGraph graph, string assetPath, UnityEngine.Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(CTMultiple));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			Match = data.Match;
			Checklist = data.Checklist;
			
			foreach (CheckThing Checklist_item in data.Checklist)
			{
				switch (Checklist_item.TID)
				{
					case CheckThing.TypeId.CheckThing:
						CheckThingNode CheckThing_node_Checklist = graph.AddNode<CheckThingNode>();
						GetPort("Checklist").Connect(CheckThing_node_Checklist.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(CheckThing_node_Checklist, assetPath);
						variableCount += CheckThing_node_Checklist.SetData((CheckThing)Checklist_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case CheckThing.TypeId.CTMultiple:
						CTMultipleNode CTMultiple_node_Checklist = graph.AddNode<CTMultipleNode>();
						GetPort("Checklist").Connect(CTMultiple_node_Checklist.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(CTMultiple_node_Checklist, assetPath);
						variableCount += CTMultiple_node_Checklist.SetData((CTMultiple)Checklist_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case CheckThing.TypeId.CTCompareFloat:
						CTCompareFloatNode CTCompareFloat_node_Checklist = graph.AddNode<CTCompareFloatNode>();
						GetPort("Checklist").Connect(CTCompareFloat_node_Checklist.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(CTCompareFloat_node_Checklist, assetPath);
						variableCount += CTCompareFloat_node_Checklist.SetData((CTCompareFloat)Checklist_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case CheckThing.TypeId.CTDoubleTap:
						CTDoubleTapNode CTDoubleTap_node_Checklist = graph.AddNode<CTDoubleTapNode>();
						GetPort("Checklist").Connect(CTDoubleTap_node_Checklist.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(CTDoubleTap_node_Checklist, assetPath);
						variableCount += CTDoubleTap_node_Checklist.SetData((CTDoubleTap)Checklist_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case CheckThing.TypeId.CTInput:
						CTInputNode CTInput_node_Checklist = graph.AddNode<CTInputNode>();
						GetPort("Checklist").Connect(CTInput_node_Checklist.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(CTInput_node_Checklist, assetPath);
						variableCount += CTInput_node_Checklist.SetData((CTInput)Checklist_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case CheckThing.TypeId.CTInputSeries:
						CTInputSeriesNode CTInputSeries_node_Checklist = graph.AddNode<CTInputSeriesNode>();
						GetPort("Checklist").Connect(CTInputSeries_node_Checklist.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(CTInputSeries_node_Checklist, assetPath);
						variableCount += CTInputSeries_node_Checklist.SetData((CTInputSeries)Checklist_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case CheckThing.TypeId.CTCheckTech:
						CTCheckTechNode CTCheckTech_node_Checklist = graph.AddNode<CTCheckTechNode>();
						GetPort("Checklist").Connect(CTCheckTech_node_Checklist.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(CTCheckTech_node_Checklist, assetPath);
						variableCount += CTCheckTech_node_Checklist.SetData((CTCheckTech)Checklist_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case CheckThing.TypeId.CTGrab:
						CTGrabNode CTGrab_node_Checklist = graph.AddNode<CTGrabNode>();
						GetPort("Checklist").Connect(CTGrab_node_Checklist.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(CTGrab_node_Checklist, assetPath);
						variableCount += CTGrab_node_Checklist.SetData((CTGrab)Checklist_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case CheckThing.TypeId.CTGrabbedAgent:
						CTGrabbedAgentNode CTGrabbedAgent_node_Checklist = graph.AddNode<CTGrabbedAgentNode>();
						GetPort("Checklist").Connect(CTGrabbedAgent_node_Checklist.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(CTGrabbedAgent_node_Checklist, assetPath);
						variableCount += CTGrabbedAgent_node_Checklist.SetData((CTGrabbedAgent)Checklist_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case CheckThing.TypeId.CTSkin:
						CTSkinNode CTSkin_node_Checklist = graph.AddNode<CTSkinNode>();
						GetPort("Checklist").Connect(CTSkin_node_Checklist.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(CTSkin_node_Checklist, assetPath);
						variableCount += CTSkin_node_Checklist.SetData((CTSkin)Checklist_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case CheckThing.TypeId.CTMove:
						CTMoveNode CTMove_node_Checklist = graph.AddNode<CTMoveNode>();
						GetPort("Checklist").Connect(CTMove_node_Checklist.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(CTMove_node_Checklist, assetPath);
						variableCount += CTMove_node_Checklist.SetData((CTMove)Checklist_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
				}
				++variableCount;
			}
			
			return variableCount;
		}
		
		public new CTMultiple GetData()
		{
			CTMultiple objToReturn = new CTMultiple();
			objToReturn.TID = TypeId.CTMultiple;
			objToReturn.Match = Match;
			objToReturn.Checklist = new CheckThing[GetPort("Checklist").ConnectionCount];
			int i = 0;
			foreach(NodePort port in GetPort("Checklist").GetConnections())
			{
				CheckThingNode CheckThing_Node = (CheckThingNode)port.node;
				switch (CheckThing_Node.TID)
				{
					case CheckThing.TypeId.CheckThing:
						CheckThingNode CheckThing_CheckThing_Node = (CheckThingNode)port.node;
						objToReturn.Checklist[i] = CheckThing_CheckThing_Node.GetData();
					break;
					case CheckThing.TypeId.CTMultiple:
						CTMultipleNode CTMultiple_CheckThing_Node = (CTMultipleNode)port.node;
						objToReturn.Checklist[i] = CTMultiple_CheckThing_Node.GetData();
					break;
					case CheckThing.TypeId.CTCompareFloat:
						CTCompareFloatNode CTCompareFloat_CheckThing_Node = (CTCompareFloatNode)port.node;
						objToReturn.Checklist[i] = CTCompareFloat_CheckThing_Node.GetData();
					break;
					case CheckThing.TypeId.CTDoubleTap:
						CTDoubleTapNode CTDoubleTap_CheckThing_Node = (CTDoubleTapNode)port.node;
						objToReturn.Checklist[i] = CTDoubleTap_CheckThing_Node.GetData();
					break;
					case CheckThing.TypeId.CTInput:
						CTInputNode CTInput_CheckThing_Node = (CTInputNode)port.node;
						objToReturn.Checklist[i] = CTInput_CheckThing_Node.GetData();
					break;
					case CheckThing.TypeId.CTInputSeries:
						CTInputSeriesNode CTInputSeries_CheckThing_Node = (CTInputSeriesNode)port.node;
						objToReturn.Checklist[i] = CTInputSeries_CheckThing_Node.GetData();
					break;
					case CheckThing.TypeId.CTCheckTech:
						CTCheckTechNode CTCheckTech_CheckThing_Node = (CTCheckTechNode)port.node;
						objToReturn.Checklist[i] = CTCheckTech_CheckThing_Node.GetData();
					break;
					case CheckThing.TypeId.CTGrab:
						CTGrabNode CTGrab_CheckThing_Node = (CTGrabNode)port.node;
						objToReturn.Checklist[i] = CTGrab_CheckThing_Node.GetData();
					break;
					case CheckThing.TypeId.CTGrabbedAgent:
						CTGrabbedAgentNode CTGrabbedAgent_CheckThing_Node = (CTGrabbedAgentNode)port.node;
						objToReturn.Checklist[i] = CTGrabbedAgent_CheckThing_Node.GetData();
					break;
					case CheckThing.TypeId.CTSkin:
						CTSkinNode CTSkin_CheckThing_Node = (CTSkinNode)port.node;
						objToReturn.Checklist[i] = CTSkin_CheckThing_Node.GetData();
					break;
					case CheckThing.TypeId.CTMove:
						CTMoveNode CTMove_CheckThing_Node = (CTMoveNode)port.node;
						objToReturn.Checklist[i] = CTMove_CheckThing_Node.GetData();
					break;
				}
				++i;
			}
			return objToReturn;
		}
	}
}

