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
	public class FSVector2MagNode : FloatSourceNode
	{
		[Input(connectionType = ConnectionType.Override)] public FloatSource NodeInput;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer X;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer Y;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.FSVector2Mag;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(FSVector2Mag data, MovesetGraph graph, string assetPath, UnityEngine.Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(FSVector2Mag));
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
		
		public new FSVector2Mag GetData()
		{
			FSVector2Mag objToReturn = new FSVector2Mag();
			objToReturn.TID = TypeId.FSVector2Mag;
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

