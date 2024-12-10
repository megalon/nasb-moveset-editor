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
	public class SAMapAnimation_MapPointNode : StateActionNode
	{
		[Input(connectionType = ConnectionType.Override)] public SAMapAnimation.MapPoint NodeInput;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer AtFrame;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer Frames;
		public string AnimId;
		public bool RootAnim;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer StartAnimFrame;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer EndAnimFrame;
		
		protected override void Init()
		{
			base.Init();
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SAMapAnimation.MapPoint data, MovesetGraph graph, string assetPath, UnityEngine.Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SAMapAnimation.MapPoint));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			AtFrame = data.AtFrame;
			
			FloatSourceContainerNode node_AtFrame = graph.AddNode<FloatSourceContainerNode>();
			GetPort("AtFrame").Connect(node_AtFrame.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_AtFrame, assetPath);
			variableCount += node_AtFrame.SetData(AtFrame, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			Frames = data.Frames;
			
			FloatSourceContainerNode node_Frames = graph.AddNode<FloatSourceContainerNode>();
			GetPort("Frames").Connect(node_Frames.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_Frames, assetPath);
			variableCount += node_Frames.SetData(Frames, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			AnimId = data.AnimId;
			RootAnim = data.RootAnim;
			StartAnimFrame = data.StartAnimFrame;
			
			FloatSourceContainerNode node_StartAnimFrame = graph.AddNode<FloatSourceContainerNode>();
			GetPort("StartAnimFrame").Connect(node_StartAnimFrame.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_StartAnimFrame, assetPath);
			variableCount += node_StartAnimFrame.SetData(StartAnimFrame, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			EndAnimFrame = data.EndAnimFrame;
			
			FloatSourceContainerNode node_EndAnimFrame = graph.AddNode<FloatSourceContainerNode>();
			GetPort("EndAnimFrame").Connect(node_EndAnimFrame.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_EndAnimFrame, assetPath);
			variableCount += node_EndAnimFrame.SetData(EndAnimFrame, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			
			return variableCount;
		}
		
		public SAMapAnimation.MapPoint GetData()
		{
			SAMapAnimation.MapPoint objToReturn = new SAMapAnimation.MapPoint();
			if (GetPort("AtFrame").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("AtFrame").GetConnection(0).node;
				objToReturn.AtFrame = FloatSourceContainer_Node.GetData();
			}
			if (GetPort("Frames").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("Frames").GetConnection(0).node;
				objToReturn.Frames = FloatSourceContainer_Node.GetData();
			}
			objToReturn.AnimId = AnimId;
			objToReturn.RootAnim = RootAnim;
			if (GetPort("StartAnimFrame").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("StartAnimFrame").GetConnection(0).node;
				objToReturn.StartAnimFrame = FloatSourceContainer_Node.GetData();
			}
			if (GetPort("EndAnimFrame").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("EndAnimFrame").GetConnection(0).node;
				objToReturn.EndAnimFrame = FloatSourceContainer_Node.GetData();
			}
			return objToReturn;
		}
	}
}

