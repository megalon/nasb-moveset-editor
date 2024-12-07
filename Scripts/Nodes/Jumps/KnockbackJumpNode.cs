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
using static MovesetParser.Jumps.Jump;

namespace NASB_Moveset_Editor.Jumps
{
	public class KnockbackJumpNode : JumpNode
	{
		[Input(connectionType = ConnectionType.Override)] public Jump NodeInput;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer XDir;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer YDir;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer LaunchDistance;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer Frames;
		public bool DoLaunch;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer BounceMinVelocity;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.KnockbackJump;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(KnockbackJump data, MovesetGraph graph, string assetPath, UnityEngine.Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(KnockbackJump));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			XDir = data.XDir;
			
			FloatSourceContainerNode node_XDir = graph.AddNode<FloatSourceContainerNode>();
			GetPort("XDir").Connect(node_XDir.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_XDir, assetPath);
			variableCount += node_XDir.SetData(XDir, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			YDir = data.YDir;
			
			FloatSourceContainerNode node_YDir = graph.AddNode<FloatSourceContainerNode>();
			GetPort("YDir").Connect(node_YDir.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_YDir, assetPath);
			variableCount += node_YDir.SetData(YDir, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			LaunchDistance = data.LaunchDistance;
			
			FloatSourceContainerNode node_LaunchDistance = graph.AddNode<FloatSourceContainerNode>();
			GetPort("LaunchDistance").Connect(node_LaunchDistance.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_LaunchDistance, assetPath);
			variableCount += node_LaunchDistance.SetData(LaunchDistance, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			Frames = data.Frames;
			
			FloatSourceContainerNode node_Frames = graph.AddNode<FloatSourceContainerNode>();
			GetPort("Frames").Connect(node_Frames.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_Frames, assetPath);
			variableCount += node_Frames.SetData(Frames, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			DoLaunch = data.DoLaunch;
			BounceMinVelocity = data.BounceMinVelocity;
			
			FloatSourceContainerNode node_BounceMinVelocity = graph.AddNode<FloatSourceContainerNode>();
			GetPort("BounceMinVelocity").Connect(node_BounceMinVelocity.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_BounceMinVelocity, assetPath);
			variableCount += node_BounceMinVelocity.SetData(BounceMinVelocity, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			
			return variableCount;
		}
		
		public new KnockbackJump GetData()
		{
			KnockbackJump objToReturn = new KnockbackJump();
			objToReturn.TID = TypeId.KnockbackJump;
			if (GetPort("XDir").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("XDir").GetConnection(0).node;
				objToReturn.XDir = FloatSourceContainer_Node.GetData();
			}
			if (GetPort("YDir").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("YDir").GetConnection(0).node;
				objToReturn.YDir = FloatSourceContainer_Node.GetData();
			}
			if (GetPort("LaunchDistance").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("LaunchDistance").GetConnection(0).node;
				objToReturn.LaunchDistance = FloatSourceContainer_Node.GetData();
			}
			if (GetPort("Frames").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("Frames").GetConnection(0).node;
				objToReturn.Frames = FloatSourceContainer_Node.GetData();
			}
			objToReturn.DoLaunch = DoLaunch;
			if (GetPort("BounceMinVelocity").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("BounceMinVelocity").GetConnection(0).node;
				objToReturn.BounceMinVelocity = FloatSourceContainer_Node.GetData();
			}
			return objToReturn;
		}
	}
}

