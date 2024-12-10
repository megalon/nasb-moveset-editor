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
	public class SAMapAnimationSimpleNode : StateActionNode
	{
		[Input(connectionType = ConnectionType.Override)] public StateAction NodeInput;
		public string AnimId;
		public bool RootAnim;
		[Output(connectionType = ConnectionType.Multiple)] public SAMapAnimationSimple.MapPoint[] MapPoints;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.SAMapAnimationSimple;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SAMapAnimationSimple data, MovesetGraph graph, string assetPath, UnityEngine.Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SAMapAnimationSimple));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			AnimId = data.AnimId;
			RootAnim = data.RootAnim;
			MapPoints = data.MapPoints;
			
			foreach (SAMapAnimationSimple.MapPoint MapPoints_item in MapPoints)
			{
				SAMapAnimationSimple_MapPointNode node_MapPoints = graph.AddNode<SAMapAnimationSimple_MapPointNode>();
				GetPort("MapPoints").Connect(node_MapPoints.GetPort("NodeInput"));
				AssetDatabase.AddObjectToAsset(node_MapPoints, assetPath);
				variableCount += node_MapPoints.SetData(MapPoints_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				++variableCount;
			}
			return variableCount;
		}
		
		public new SAMapAnimationSimple GetData()
		{
			SAMapAnimationSimple objToReturn = new SAMapAnimationSimple();
			objToReturn.TID = TypeId.SAMapAnimationSimple;
			objToReturn.AnimId = AnimId;
			objToReturn.RootAnim = RootAnim;
			objToReturn.MapPoints = new SAMapAnimationSimple.MapPoint[GetPort("MapPoints").ConnectionCount];
			int i = 0;
			foreach(NodePort port in GetPort("MapPoints").GetConnections())
			{
				SAMapAnimationSimple_MapPointNode SAMapAnimationSimple_MapPoint_Node = (SAMapAnimationSimple_MapPointNode)port.node;
				objToReturn.MapPoints[i] = SAMapAnimationSimple_MapPoint_Node.GetData();
				++i;
			}
			return objToReturn;
		}
	}
}

