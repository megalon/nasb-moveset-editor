// * 
// * 
// * This file was generated using NASB_Parser_to_xNode by megalon2d
// * https://github.com/megalon/NASB_Parser_to_xNode
// * 
// * 
using MovesetParser.BulkSerialize;
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
using static MovesetParser.FloatSources.FloatSource;

namespace NASB_Moveset_Editor.FloatSources
{
	public class FSFuncNode : FloatSourceNode
	{
		[Input(connectionType = ConnectionType.Override)] public FloatSource NodeInput;
		public MovesetParser.FloatSources.FSFunc.FuncWay Way;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer A;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer B;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer C;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.FSFunc;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(FSFunc data, MovesetGraph graph, string assetPath, UnityEngine.Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(FSFunc));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			Way = data.Way;
			A = data.A;
			
			FloatSourceContainerNode node_A = graph.AddNode<FloatSourceContainerNode>();
			GetPort("A").Connect(node_A.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_A, assetPath);
			variableCount += node_A.SetData(A, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			B = data.B;
			
			FloatSourceContainerNode node_B = graph.AddNode<FloatSourceContainerNode>();
			GetPort("B").Connect(node_B.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_B, assetPath);
			variableCount += node_B.SetData(B, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			C = data.C;
			
			FloatSourceContainerNode node_C = graph.AddNode<FloatSourceContainerNode>();
			GetPort("C").Connect(node_C.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_C, assetPath);
			variableCount += node_C.SetData(C, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			
			return variableCount;
		}
		
		public new FSFunc GetData()
		{
			FSFunc objToReturn = new FSFunc();
			objToReturn.TID = TypeId.FSFunc;
			objToReturn.Way = Way;
			if (GetPort("A").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("A").GetConnection(0).node;
				objToReturn.A = FloatSourceContainer_Node.GetData();
			}
			if (GetPort("B").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("B").GetConnection(0).node;
				objToReturn.B = FloatSourceContainer_Node.GetData();
			}
			if (GetPort("C").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("C").GetConnection(0).node;
				objToReturn.C = FloatSourceContainer_Node.GetData();
			}
			return objToReturn;
		}
	}
}

