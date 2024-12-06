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
	public class SAMapAnimationNode : StateActionNode
	{
		[Input(connectionType = ConnectionType.Override)] public StateAction NodeInput;
		[Output(connectionType = ConnectionType.Multiple)] public List<SAMapAnimation.MapPoint> Map;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.MapAnimId;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SAMapAnimation data, MovesetGraph graph, string assetPath, Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SAMapAnimation));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			Map = data.Map;
			
			foreach (SAMapAnimation.MapPoint Map_item in Map)
			{
				SAMapAnimation_MapPointNode node_Map = graph.AddNode<SAMapAnimation_MapPointNode>();
				GetPort("Map").Connect(node_Map.GetPort("NodeInput"));
				AssetDatabase.AddObjectToAsset(node_Map, assetPath);
				variableCount += node_Map.SetData(Map_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				++variableCount;
			}
			return variableCount;
		}
		
		public new SAMapAnimation GetData()
		{
			SAMapAnimation objToReturn = new SAMapAnimation();
			objToReturn.TID = TypeId.MapAnimId;
			objToReturn.Version = Version;
			foreach(NodePort port in GetPort("Map").GetConnections())
			{
				SAMapAnimation_MapPointNode SAMapAnimation_MapPoint_Node = (SAMapAnimation_MapPointNode)port.node;
				objToReturn.Map.Add(SAMapAnimation_MapPoint_Node.GetData());
			}
			return objToReturn;
		}
	}
}

