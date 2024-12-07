// * 
// * 
// * This file was generated using NASB_Parser_to_xNode by megalon2d
// * https://github.com/megalon/NASB_Parser_to_xNode
// * 
// * 
using MovesetParser.BulkSerialize;
using MovesetParser.FloatSources;
using MovesetParser.Misc;
using UnityEngine;
using UnityEditor;
using XNode;
using XNodeEditor;
using MovesetParser;
using MovesetParser.CheckThings;
using MovesetParser.Jumps;
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
	public class SAInputActionNode : StateActionNode
	{
		[Input(connectionType = ConnectionType.Override)] public StateAction NodeInput;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer Frames;
		public string Id;
		[Output(connectionType = ConnectionType.Override)] public InputTrigger Trigger;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.SAInputAction;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SAInputAction data, MovesetGraph graph, string assetPath, UnityEngine.Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SAInputAction));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			Frames = data.Frames;
			
			FloatSourceContainerNode node_Frames = graph.AddNode<FloatSourceContainerNode>();
			GetPort("Frames").Connect(node_Frames.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_Frames, assetPath);
			variableCount += node_Frames.SetData(Frames, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			Id = data.Id;
			Trigger = data.Trigger;
			
			InputTriggerNode node_Trigger = graph.AddNode<InputTriggerNode>();
			GetPort("Trigger").Connect(node_Trigger.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_Trigger, assetPath);
			variableCount += node_Trigger.SetData(Trigger, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			
			return variableCount;
		}
		
		public new SAInputAction GetData()
		{
			SAInputAction objToReturn = new SAInputAction();
			objToReturn.TID = TypeId.SAInputAction;
			if (GetPort("Frames").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("Frames").GetConnection(0).node;
				objToReturn.Frames = FloatSourceContainer_Node.GetData();
			}
			objToReturn.Id = Id;
			if (GetPort("Trigger").ConnectionCount > 0)
			{
				InputTriggerNode InputTrigger_Node = (InputTriggerNode)GetPort("Trigger").GetConnection(0).node;
				objToReturn.Trigger = InputTrigger_Node.GetData();
			}
			return objToReturn;
		}
	}
}

