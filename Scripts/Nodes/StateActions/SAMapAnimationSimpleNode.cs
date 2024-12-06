// * 
// * 
// * This file was generated using MovesetParser_to_xNode by megalon2d
// * https://github.com/megalon/MovesetParser_to_xNode
// * 
// * 
using MovesetParser.FloatSources;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEditor;
using XNode;
using XNodeEditor;
using MovesetParser;
using MovesetParser.Jumps;
using MovesetParser.CheckThings;
using MovesetParser.StateActions;
using MovesetParser.ObjectSources;
using NASB_Moveset_Editor.FloatSources;
using NASB_Moveset_Editor.Jumps;
using NASB_Moveset_Editor.CheckThings;
using NASB_Moveset_Editor.StateActions;
using NASB_Moveset_Editor.ObjectSources;
using static MovesetParser.StateActions.StateAction;

namespace NASB_Moveset_Editor.StateActions
{
	public class SAMapAnimationSimpleNode : StateActionNode
	{
		[Input(connectionType = ConnectionType.Override)] public StateAction NodeInput;
		public string AnimId;
		public bool RootAnim;
		[Output(connectionType = ConnectionType.Multiple)] public List<SAMapAnimationSimple.MapPoint> Map;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.MapAnimSimpleId;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SAMapAnimationSimple data, MovesetGraph graph, string assetPath, Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SAMapAnimationSimple));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			AnimId = data.AnimId;
			RootAnim = data.RootAnim;
			Map = data.Map;
			
			foreach (SAMapAnimationSimple.MapPoint Map_item in Map)
			{
				SAMapAnimationSimple_MapPointNode node_Map = graph.AddNode<SAMapAnimationSimple_MapPointNode>();
				GetPort("Map").Connect(node_Map.GetPort("NodeInput"));
				AssetDatabase.AddObjectToAsset(node_Map, assetPath);
				variableCount += node_Map.SetData(Map_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				++variableCount;
			}
			return variableCount;
		}
		
		public new SAMapAnimationSimple GetData()
		{
			SAMapAnimationSimple objToReturn = new SAMapAnimationSimple();
			objToReturn.TID = TypeId.MapAnimSimpleId;
			objToReturn.Version = Version;
			objToReturn.AnimId = AnimId;
			objToReturn.RootAnim = RootAnim;
			foreach(NodePort port in GetPort("Map").GetConnections())
			{
				SAMapAnimationSimple_MapPointNode SAMapAnimationSimple_MapPoint_Node = (SAMapAnimationSimple_MapPointNode)port.node;
				objToReturn.Map.Add(SAMapAnimationSimple_MapPoint_Node.GetData());
			}
			return objToReturn;
		}
	}
}

