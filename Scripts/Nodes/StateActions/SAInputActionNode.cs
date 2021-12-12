// * 
// * 
// * This file was generated using NASB_Parser_to_xNode by megalon2d
// * https://github.com/megalon/NASB_Parser_to_xNode
// * 
// * 
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEditor;
using XNode;
using XNodeEditor;
using NASB_Parser;
using NASB_Parser.FloatSources;
using NASB_Parser.Jumps;
using NASB_Parser.CheckThings;
using NASB_Parser.StateActions;
using NASB_Parser.ObjectSources;
using NASB_Moveset_Editor.FloatSources;
using NASB_Moveset_Editor.Jumps;
using NASB_Moveset_Editor.CheckThings;
using NASB_Moveset_Editor.StateActions;
using NASB_Moveset_Editor.ObjectSources;
using static NASB_Parser.StateActions.StateAction;

namespace NASB_Moveset_Editor.StateActions
{
	public class SAInputActionNode : StateActionNode
	{
		[Input(connectionType = ConnectionType.Override)] public StateAction NodeInput;
		public float Frames;
		public string Id;
		[Output(connectionType = ConnectionType.Override)] public InputTrigger Trigger;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.InputId;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SAInputAction data, MovesetGraph graph, string assetPath, Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SAInputAction));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			Frames = data.Frames;
			Id = data.Id;
			Trigger = data.Trigger;
			
			InputTriggerNode node_Trigger = graph.AddNode<InputTriggerNode>();
			GetPort("Trigger").Connect(node_Trigger.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_Trigger, assetPath);
			variableCount += node_Trigger.SetData(Trigger, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
			
			return variableCount;
		}
		
		public new SAInputAction GetData()
		{
			SAInputAction objToReturn = new SAInputAction();
			objToReturn.TID = TypeId.InputId;
			objToReturn.Version = Version;
			objToReturn.Frames = Frames;
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

