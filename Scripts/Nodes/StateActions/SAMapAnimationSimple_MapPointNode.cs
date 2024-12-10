// * 
// * 
// * This file was generated using NASB_Parser_to_xNode by megalon2d
// * https://github.com/megalon/NASB_Parser_to_xNode
// * 
// * 
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

namespace NASB_Moveset_Editor.StateActions
{
	public class SAMapAnimationSimple_MapPointNode : StateActionNode
	{
		[Input(connectionType = ConnectionType.Override)] public SAMapAnimationSimple.MapPoint NodeInput;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer OffsetFrame;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer AnimFrame;
		
		protected override void Init()
		{
			base.Init();
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SAMapAnimationSimple.MapPoint data, MovesetGraph graph, string assetPath, UnityEngine.Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SAMapAnimationSimple.MapPoint));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			OffsetFrame = data.OffsetFrame;
			
			FloatSourceContainerNode node_OffsetFrame = graph.AddNode<FloatSourceContainerNode>();
			GetPort("OffsetFrame").Connect(node_OffsetFrame.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_OffsetFrame, assetPath);
			variableCount += node_OffsetFrame.SetData(OffsetFrame, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			AnimFrame = data.AnimFrame;
			
			FloatSourceContainerNode node_AnimFrame = graph.AddNode<FloatSourceContainerNode>();
			GetPort("AnimFrame").Connect(node_AnimFrame.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_AnimFrame, assetPath);
			variableCount += node_AnimFrame.SetData(AnimFrame, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			
			return variableCount;
		}
		
		public SAMapAnimationSimple.MapPoint GetData()
		{
			SAMapAnimationSimple.MapPoint objToReturn = new SAMapAnimationSimple.MapPoint();
			if (GetPort("OffsetFrame").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("OffsetFrame").GetConnection(0).node;
				objToReturn.OffsetFrame = FloatSourceContainer_Node.GetData();
			}
			if (GetPort("AnimFrame").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("AnimFrame").GetConnection(0).node;
				objToReturn.AnimFrame = FloatSourceContainer_Node.GetData();
			}
			return objToReturn;
		}
	}
}

