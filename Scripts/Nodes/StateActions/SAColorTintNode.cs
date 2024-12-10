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
	public class SAColorTintNode : StateActionNode
	{
		[Input(connectionType = ConnectionType.Override)] public StateAction NodeInput;
		public string Id;
		public bool Activate;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer RunForTime;
		public bool Permanent;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.SAColorTint;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SAColorTint data, MovesetGraph graph, string assetPath, UnityEngine.Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SAColorTint));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			Id = data.Id;
			Activate = data.Activate;
			RunForTime = data.RunForTime;
			
			FloatSourceContainerNode node_RunForTime = graph.AddNode<FloatSourceContainerNode>();
			GetPort("RunForTime").Connect(node_RunForTime.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_RunForTime, assetPath);
			variableCount += node_RunForTime.SetData(RunForTime, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			Permanent = data.Permanent;
			return variableCount;
		}
		
		public new SAColorTint GetData()
		{
			SAColorTint objToReturn = new SAColorTint();
			objToReturn.TID = TypeId.SAColorTint;
			objToReturn.Id = Id;
			objToReturn.Activate = Activate;
			if (GetPort("RunForTime").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("RunForTime").GetConnection(0).node;
				objToReturn.RunForTime = FloatSourceContainer_Node.GetData();
			}
			objToReturn.Permanent = Permanent;
			return objToReturn;
		}
	}
}

