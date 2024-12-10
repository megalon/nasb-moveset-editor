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
	public class HeightJumpNode : JumpNode
	{
		[Input(connectionType = ConnectionType.Override)] public Jump NodeInput;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer Height;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.HeightJump;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(HeightJump data, MovesetGraph graph, string assetPath, UnityEngine.Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(HeightJump));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			Height = data.Height;
			
			FloatSourceContainerNode node_Height = graph.AddNode<FloatSourceContainerNode>();
			GetPort("Height").Connect(node_Height.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_Height, assetPath);
			variableCount += node_Height.SetData(Height, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			
			return variableCount;
		}
		
		public new HeightJump GetData()
		{
			HeightJump objToReturn = new HeightJump();
			objToReturn.TID = TypeId.HeightJump;
			if (GetPort("Height").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("Height").GetConnection(0).node;
				objToReturn.Height = FloatSourceContainer_Node.GetData();
			}
			return objToReturn;
		}
	}
}

