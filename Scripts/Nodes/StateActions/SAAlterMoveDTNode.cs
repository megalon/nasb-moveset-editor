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
	public class SAAlterMoveDTNode : StateActionNode
	{
		[Input(connectionType = ConnectionType.Override)] public StateAction NodeInput;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer Alter;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer Falloff;
		public bool Clear;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.SAAlterMoveDT;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SAAlterMoveDT data, MovesetGraph graph, string assetPath, UnityEngine.Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SAAlterMoveDT));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			Alter = data.Alter;
			
			FloatSourceContainerNode node_Alter = graph.AddNode<FloatSourceContainerNode>();
			GetPort("Alter").Connect(node_Alter.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_Alter, assetPath);
			variableCount += node_Alter.SetData(Alter, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			Falloff = data.Falloff;
			
			FloatSourceContainerNode node_Falloff = graph.AddNode<FloatSourceContainerNode>();
			GetPort("Falloff").Connect(node_Falloff.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_Falloff, assetPath);
			variableCount += node_Falloff.SetData(Falloff, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			Clear = data.Clear;
			return variableCount;
		}
		
		public new SAAlterMoveDT GetData()
		{
			SAAlterMoveDT objToReturn = new SAAlterMoveDT();
			objToReturn.TID = TypeId.SAAlterMoveDT;
			if (GetPort("Alter").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("Alter").GetConnection(0).node;
				objToReturn.Alter = FloatSourceContainer_Node.GetData();
			}
			if (GetPort("Falloff").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("Falloff").GetConnection(0).node;
				objToReturn.Falloff = FloatSourceContainer_Node.GetData();
			}
			objToReturn.Clear = Clear;
			return objToReturn;
		}
	}
}

