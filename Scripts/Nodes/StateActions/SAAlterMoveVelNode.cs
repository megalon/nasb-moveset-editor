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
	public class SAAlterMoveVelNode : StateActionNode
	{
		[Input(connectionType = ConnectionType.Override)] public StateAction NodeInput;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer AlterX;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer AlterY;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer FalloffX;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer FalloffY;
		public bool Clear;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.SAAlterMoveVel;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SAAlterMoveVel data, MovesetGraph graph, string assetPath, UnityEngine.Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SAAlterMoveVel));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			AlterX = data.AlterX;
			
			FloatSourceContainerNode node_AlterX = graph.AddNode<FloatSourceContainerNode>();
			GetPort("AlterX").Connect(node_AlterX.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_AlterX, assetPath);
			variableCount += node_AlterX.SetData(AlterX, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			AlterY = data.AlterY;
			
			FloatSourceContainerNode node_AlterY = graph.AddNode<FloatSourceContainerNode>();
			GetPort("AlterY").Connect(node_AlterY.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_AlterY, assetPath);
			variableCount += node_AlterY.SetData(AlterY, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			FalloffX = data.FalloffX;
			
			FloatSourceContainerNode node_FalloffX = graph.AddNode<FloatSourceContainerNode>();
			GetPort("FalloffX").Connect(node_FalloffX.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_FalloffX, assetPath);
			variableCount += node_FalloffX.SetData(FalloffX, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			FalloffY = data.FalloffY;
			
			FloatSourceContainerNode node_FalloffY = graph.AddNode<FloatSourceContainerNode>();
			GetPort("FalloffY").Connect(node_FalloffY.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_FalloffY, assetPath);
			variableCount += node_FalloffY.SetData(FalloffY, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			Clear = data.Clear;
			return variableCount;
		}
		
		public new SAAlterMoveVel GetData()
		{
			SAAlterMoveVel objToReturn = new SAAlterMoveVel();
			objToReturn.TID = TypeId.SAAlterMoveVel;
			if (GetPort("AlterX").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("AlterX").GetConnection(0).node;
				objToReturn.AlterX = FloatSourceContainer_Node.GetData();
			}
			if (GetPort("AlterY").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("AlterY").GetConnection(0).node;
				objToReturn.AlterY = FloatSourceContainer_Node.GetData();
			}
			if (GetPort("FalloffX").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("FalloffX").GetConnection(0).node;
				objToReturn.FalloffX = FloatSourceContainer_Node.GetData();
			}
			if (GetPort("FalloffY").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("FalloffY").GetConnection(0).node;
				objToReturn.FalloffY = FloatSourceContainer_Node.GetData();
			}
			objToReturn.Clear = Clear;
			return objToReturn;
		}
	}
}

