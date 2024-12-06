// * 
// * 
// * This file was generated using MovesetParser_to_xNode by megalon2d
// * https://github.com/megalon/MovesetParser_to_xNode
// * 
// * 
using MovesetParser.StateActions;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEditor;
using XNode;
using XNodeEditor;
using MovesetParser;
using MovesetParser.FloatSources;
using MovesetParser.Jumps;
using MovesetParser.CheckThings;
using MovesetParser.ObjectSources;
using NASB_Moveset_Editor.FloatSources;
using NASB_Moveset_Editor.Jumps;
using NASB_Moveset_Editor.CheckThings;
using NASB_Moveset_Editor.StateActions;
using NASB_Moveset_Editor.ObjectSources;
using static MovesetParser.CheckThings.LookForInput;

namespace NASB_Moveset_Editor.CheckThings
{
	public class LookForInputNode : CheckThingNode
	{
		[Input(connectionType = ConnectionType.Override)] public LookForInput NodeInput;
		public int MatchMinFrames;
		[Output(connectionType = ConnectionType.Override)] public InputValidator InputValidator;
		
		protected override void Init()
		{
			base.Init();
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(LookForInput data, MovesetGraph graph, string assetPath, Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(LookForInput));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			MatchMinFrames = data.MatchMinFrames;
			InputValidator = data.InputValidator;
			
			InputValidatorNode node_InputValidator = graph.AddNode<InputValidatorNode>();
			GetPort("InputValidator").Connect(node_InputValidator.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_InputValidator, assetPath);
			variableCount += node_InputValidator.SetData(InputValidator, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
			
			return variableCount;
		}
		
		public LookForInput GetData()
		{
			LookForInput objToReturn = new LookForInput();
			objToReturn.MatchMinFrames = MatchMinFrames;
			if (GetPort("InputValidator").ConnectionCount > 0)
			{
				InputValidatorNode InputValidator_Node = (InputValidatorNode)GetPort("InputValidator").GetConnection(0).node;
				objToReturn.InputValidator = InputValidator_Node.GetData();
			}
			return objToReturn;
		}
	}
}

