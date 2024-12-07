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
	public class OSFloatNode : ObjectSourceNode
	{
		[Input(connectionType = ConnectionType.Override)] public ObjectSource NodeInput;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer Float;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.OSFloat;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(OSFloat data, MovesetGraph graph, string assetPath, UnityEngine.Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(OSFloat));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			Float = data.Float;
			
			FloatSourceContainerNode node_Float = graph.AddNode<FloatSourceContainerNode>();
			GetPort("Float").Connect(node_Float.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_Float, assetPath);
			variableCount += node_Float.SetData(Float, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			
			return variableCount;
		}
		
		public new OSFloat GetData()
		{
			OSFloat objToReturn = new OSFloat();
			objToReturn.TID = TypeId.OSFloat;
			if (GetPort("Float").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("Float").GetConnection(0).node;
				objToReturn.Float = FloatSourceContainer_Node.GetData();
			}
			return objToReturn;
		}
	}
}

