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
	public class HoldJumpNode : JumpNode
	{
		[Input(connectionType = ConnectionType.Override)] public Jump NodeInput;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer Height;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer AutoHoldFrames;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer YVelocityMaxOnRelease;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.HoldJump;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(HoldJump data, MovesetGraph graph, string assetPath, UnityEngine.Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(HoldJump));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			Height = data.Height;
			
			FloatSourceContainerNode node_Height = graph.AddNode<FloatSourceContainerNode>();
			GetPort("Height").Connect(node_Height.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_Height, assetPath);
			variableCount += node_Height.SetData(Height, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			AutoHoldFrames = data.AutoHoldFrames;
			
			FloatSourceContainerNode node_AutoHoldFrames = graph.AddNode<FloatSourceContainerNode>();
			GetPort("AutoHoldFrames").Connect(node_AutoHoldFrames.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_AutoHoldFrames, assetPath);
			variableCount += node_AutoHoldFrames.SetData(AutoHoldFrames, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			YVelocityMaxOnRelease = data.YVelocityMaxOnRelease;
			
			FloatSourceContainerNode node_YVelocityMaxOnRelease = graph.AddNode<FloatSourceContainerNode>();
			GetPort("YVelocityMaxOnRelease").Connect(node_YVelocityMaxOnRelease.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_YVelocityMaxOnRelease, assetPath);
			variableCount += node_YVelocityMaxOnRelease.SetData(YVelocityMaxOnRelease, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			
			return variableCount;
		}
		
		public new HoldJump GetData()
		{
			HoldJump objToReturn = new HoldJump();
			objToReturn.TID = TypeId.HoldJump;
			if (GetPort("Height").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("Height").GetConnection(0).node;
				objToReturn.Height = FloatSourceContainer_Node.GetData();
			}
			if (GetPort("AutoHoldFrames").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("AutoHoldFrames").GetConnection(0).node;
				objToReturn.AutoHoldFrames = FloatSourceContainer_Node.GetData();
			}
			if (GetPort("YVelocityMaxOnRelease").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("YVelocityMaxOnRelease").GetConnection(0).node;
				objToReturn.YVelocityMaxOnRelease = FloatSourceContainer_Node.GetData();
			}
			return objToReturn;
		}
	}
}

