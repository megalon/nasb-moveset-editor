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
using static MovesetParser.CheckThings.CheckThing;

namespace NASB_Moveset_Editor.CheckThings
{
	public class CTCompareFloatNode : CheckThingNode
	{
		[Input(connectionType = ConnectionType.Override)] public CheckThing NodeInput;
		public CheckWay Way;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer A;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer B;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.CTCompareFloat;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(CTCompareFloat data, MovesetGraph graph, string assetPath, UnityEngine.Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(CTCompareFloat));
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
			
			return variableCount;
		}
		
		public new CTCompareFloat GetData()
		{
			CTCompareFloat objToReturn = new CTCompareFloat();
			objToReturn.TID = TypeId.CTCompareFloat;
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
			return objToReturn;
		}
	}
}

