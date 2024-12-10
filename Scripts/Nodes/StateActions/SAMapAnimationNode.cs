// * 
// * 
// * This file was generated using NASB_Parser_to_xNode by megalon2d
// * https://github.com/megalon/NASB_Parser_to_xNode
// * 
// * 
using MovesetParser.BulkSerialize;
using MovesetParser.FloatSources;
using UnityEngine;
using UnityEditor;
using XNode;
using XNodeEditor;
using MovesetParser;
using MovesetParser.CheckThings;
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
using static MovesetParser.StateActions.StateAction;

namespace NASB_Moveset_Editor.StateActions
{
	public class SAMapAnimationNode : StateActionNode
	{
		[Input(connectionType = ConnectionType.Override)] public StateAction NodeInput;
		[Output(connectionType = ConnectionType.Multiple)] public SAMapAnimation.MapPoint[] MapPoints;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.SAMapAnimation;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SAMapAnimation data, MovesetGraph graph, string assetPath, UnityEngine.Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SAMapAnimation));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			MapPoints = data.MapPoints;
			
			foreach (SAMapAnimation.MapPoint MapPoints_item in MapPoints)
			{
				SAMapAnimation_MapPointNode node_MapPoints = graph.AddNode<SAMapAnimation_MapPointNode>();
				GetPort("MapPoints").Connect(node_MapPoints.GetPort("NodeInput"));
				AssetDatabase.AddObjectToAsset(node_MapPoints, assetPath);
				variableCount += node_MapPoints.SetData(MapPoints_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				++variableCount;
			}
			return variableCount;
		}
		
		public new SAMapAnimation GetData()
		{
			SAMapAnimation objToReturn = new SAMapAnimation();
			objToReturn.TID = TypeId.SAMapAnimation;
			objToReturn.MapPoints = new SAMapAnimation.MapPoint[GetPort("MapPoints").ConnectionCount];
			int i = 0;
			foreach(NodePort port in GetPort("MapPoints").GetConnections())
			{
				SAMapAnimation_MapPointNode SAMapAnimation_MapPoint_Node = (SAMapAnimation_MapPointNode)port.node;
				objToReturn.MapPoints[i] = SAMapAnimation_MapPoint_Node.GetData();
				++i;
			}
			return objToReturn;
		}
	}
}

