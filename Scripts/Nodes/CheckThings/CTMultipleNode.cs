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
	public class CTMultipleNode : CheckThingNode
	{
		public NASB_Parser.CheckThings.CTMultiple.CheckMatch Match;
		[Output(connectionType = ConnectionType.Multiple)] public List<CheckThing> Checklist;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.MultipleId;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(CTMultiple data, MovesetGraph graph, string assetPath, Vector2 nodeDepthXY)
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
					case CheckThing.TypeId.MultipleId:
						CTMultipleNode MultipleId_node_Checklist = graph.AddNode<CTMultipleNode>();
						GetPort("Checklist").Connect(MultipleId_node_Checklist.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(MultipleId_node_Checklist, assetPath);
						variableCount += MultipleId_node_Checklist.SetData((CTMultiple)Checklist_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case CheckThing.TypeId.CompareId:
						CTCompareFloatNode CompareId_node_Checklist = graph.AddNode<CTCompareFloatNode>();
						GetPort("Checklist").Connect(CompareId_node_Checklist.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(CompareId_node_Checklist, assetPath);
						variableCount += CompareId_node_Checklist.SetData((CTCompareFloat)Checklist_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case CheckThing.TypeId.DoubleTapId:
						CTDoubleTapIdNode DoubleTapId_node_Checklist = graph.AddNode<CTDoubleTapIdNode>();
						GetPort("Checklist").Connect(DoubleTapId_node_Checklist.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(DoubleTapId_node_Checklist, assetPath);
						variableCount += DoubleTapId_node_Checklist.SetData((CTDoubleTapId)Checklist_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case CheckThing.TypeId.InputId:
						CTInputNode InputId_node_Checklist = graph.AddNode<CTInputNode>();
						GetPort("Checklist").Connect(InputId_node_Checklist.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(InputId_node_Checklist, assetPath);
						variableCount += InputId_node_Checklist.SetData((CTInput)Checklist_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case CheckThing.TypeId.InputSeriesId:
						CTInputSeriesNode InputSeriesId_node_Checklist = graph.AddNode<CTInputSeriesNode>();
						GetPort("Checklist").Connect(InputSeriesId_node_Checklist.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(InputSeriesId_node_Checklist, assetPath);
						variableCount += InputSeriesId_node_Checklist.SetData((CTInputSeries)Checklist_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case CheckThing.TypeId.TechId:
						CTCheckTechNode TechId_node_Checklist = graph.AddNode<CTCheckTechNode>();
						GetPort("Checklist").Connect(TechId_node_Checklist.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(TechId_node_Checklist, assetPath);
						variableCount += TechId_node_Checklist.SetData((CTCheckTech)Checklist_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case CheckThing.TypeId.GrabId:
						CTGrabIdNode GrabId_node_Checklist = graph.AddNode<CTGrabIdNode>();
						GetPort("Checklist").Connect(GrabId_node_Checklist.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(GrabId_node_Checklist, assetPath);
						variableCount += GrabId_node_Checklist.SetData((CTGrabId)Checklist_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case CheckThing.TypeId.GrabAgentId:
						CTGrabbedAgentNode GrabAgentId_node_Checklist = graph.AddNode<CTGrabbedAgentNode>();
						GetPort("Checklist").Connect(GrabAgentId_node_Checklist.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(GrabAgentId_node_Checklist, assetPath);
						variableCount += GrabAgentId_node_Checklist.SetData((CTGrabbedAgent)Checklist_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case CheckThing.TypeId.SkinId:
						CTSkinNode SkinId_node_Checklist = graph.AddNode<CTSkinNode>();
						GetPort("Checklist").Connect(SkinId_node_Checklist.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SkinId_node_Checklist, assetPath);
						variableCount += SkinId_node_Checklist.SetData((CTSkin)Checklist_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case CheckThing.TypeId.MoveId:
						CTMoveNode MoveId_node_Checklist = graph.AddNode<CTMoveNode>();
						GetPort("Checklist").Connect(MoveId_node_Checklist.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(MoveId_node_Checklist, assetPath);
						variableCount += MoveId_node_Checklist.SetData((CTMove)Checklist_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
				}
				++variableCount;
			}
			
			return variableCount;
		}
		
		public new CTMultiple GetData()
		{
			CTMultiple objToReturn = new CTMultiple();
			objToReturn.TID = TypeId.MultipleId;
			objToReturn.Version = Version;
			objToReturn.Match = Match;
			foreach(NodePort port in GetPort("Checklist").GetConnections())
			{
				CheckThingNode CheckThing_Node = (CheckThingNode)port.node;
				switch (CheckThing_Node.TID)
				{
					case CheckThing.TypeId.MultipleId:
						CTMultipleNode MultipleId_CheckThing_Node = (CTMultipleNode)port.node;
						objToReturn.Checklist.Add(MultipleId_CheckThing_Node.GetData());
					break;
					case CheckThing.TypeId.CompareId:
						CTCompareFloatNode CompareId_CheckThing_Node = (CTCompareFloatNode)port.node;
						objToReturn.Checklist.Add(CompareId_CheckThing_Node.GetData());
					break;
					case CheckThing.TypeId.DoubleTapId:
						CTDoubleTapIdNode DoubleTapId_CheckThing_Node = (CTDoubleTapIdNode)port.node;
						objToReturn.Checklist.Add(DoubleTapId_CheckThing_Node.GetData());
					break;
					case CheckThing.TypeId.InputId:
						CTInputNode InputId_CheckThing_Node = (CTInputNode)port.node;
						objToReturn.Checklist.Add(InputId_CheckThing_Node.GetData());
					break;
					case CheckThing.TypeId.InputSeriesId:
						CTInputSeriesNode InputSeriesId_CheckThing_Node = (CTInputSeriesNode)port.node;
						objToReturn.Checklist.Add(InputSeriesId_CheckThing_Node.GetData());
					break;
					case CheckThing.TypeId.TechId:
						CTCheckTechNode TechId_CheckThing_Node = (CTCheckTechNode)port.node;
						objToReturn.Checklist.Add(TechId_CheckThing_Node.GetData());
					break;
					case CheckThing.TypeId.GrabId:
						CTGrabIdNode GrabId_CheckThing_Node = (CTGrabIdNode)port.node;
						objToReturn.Checklist.Add(GrabId_CheckThing_Node.GetData());
					break;
					case CheckThing.TypeId.GrabAgentId:
						CTGrabbedAgentNode GrabAgentId_CheckThing_Node = (CTGrabbedAgentNode)port.node;
						objToReturn.Checklist.Add(GrabAgentId_CheckThing_Node.GetData());
					break;
					case CheckThing.TypeId.SkinId:
						CTSkinNode SkinId_CheckThing_Node = (CTSkinNode)port.node;
						objToReturn.Checklist.Add(SkinId_CheckThing_Node.GetData());
					break;
					case CheckThing.TypeId.MoveId:
						CTMoveNode MoveId_CheckThing_Node = (CTMoveNode)port.node;
						objToReturn.Checklist.Add(MoveId_CheckThing_Node.GetData());
					break;
					case CheckThing.TypeId.BaseIdentifier:
						CheckThingNode BaseIdentifier_CheckThing_Node = (CheckThingNode)port.node;
						objToReturn.Checklist.Add(BaseIdentifier_CheckThing_Node.GetData());
					break;
				}
			}
			return objToReturn;
		}
	}
}

