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
	public class SACameraPunchNode : StateActionNode
	{
		[Input(connectionType = ConnectionType.Override)] public StateAction NodeInput;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer X;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer Y;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer Z;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer T;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.SACameraPunch;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SACameraPunch data, MovesetGraph graph, string assetPath, UnityEngine.Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SACameraPunch));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			X = data.X;
			
			FloatSourceContainerNode node_X = graph.AddNode<FloatSourceContainerNode>();
			GetPort("X").Connect(node_X.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_X, assetPath);
			variableCount += node_X.SetData(X, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			Y = data.Y;
			
			FloatSourceContainerNode node_Y = graph.AddNode<FloatSourceContainerNode>();
			GetPort("Y").Connect(node_Y.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_Y, assetPath);
			variableCount += node_Y.SetData(Y, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			Z = data.Z;
			
			FloatSourceContainerNode node_Z = graph.AddNode<FloatSourceContainerNode>();
			GetPort("Z").Connect(node_Z.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_Z, assetPath);
			variableCount += node_Z.SetData(Z, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			T = data.T;
			
			FloatSourceContainerNode node_T = graph.AddNode<FloatSourceContainerNode>();
			GetPort("T").Connect(node_T.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_T, assetPath);
			variableCount += node_T.SetData(T, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			
			return variableCount;
		}
		
		public new SACameraPunch GetData()
		{
			SACameraPunch objToReturn = new SACameraPunch();
			objToReturn.TID = TypeId.SACameraPunch;
			if (GetPort("X").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("X").GetConnection(0).node;
				objToReturn.X = FloatSourceContainer_Node.GetData();
			}
			if (GetPort("Y").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("Y").GetConnection(0).node;
				objToReturn.Y = FloatSourceContainer_Node.GetData();
			}
			if (GetPort("Z").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("Z").GetConnection(0).node;
				objToReturn.Z = FloatSourceContainer_Node.GetData();
			}
			if (GetPort("T").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("T").GetConnection(0).node;
				objToReturn.T = FloatSourceContainer_Node.GetData();
			}
			return objToReturn;
		}
	}
}

