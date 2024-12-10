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
using static MovesetParser.ObjectSources.ObjectSource;

namespace NASB_Moveset_Editor.ObjectSources
{
	public class OSVector2Node : ObjectSourceNode
	{
		[Input(connectionType = ConnectionType.Override)] public ObjectSource NodeInput;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer X;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer Y;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.OSVector2;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(OSVector2 data, MovesetGraph graph, string assetPath, UnityEngine.Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(OSVector2));
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
			
			return variableCount;
		}
		
		public new OSVector2 GetData()
		{
			OSVector2 objToReturn = new OSVector2();
			objToReturn.TID = TypeId.OSVector2;
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
			return objToReturn;
		}
	}
}

