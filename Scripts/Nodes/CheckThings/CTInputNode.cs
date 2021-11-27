// * 
// * 
// * This file was generated using NASB_Parser_to_xNode by megalon2d
// * https://github.com/megalon/NASB_Parser_to_xNode
// * 
// * 
using NASB_Parser.StateActions;
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
using NASB_Parser.ObjectSources;
using NASB_Moveset_Editor.FloatSources;
using NASB_Moveset_Editor.Jumps;
using NASB_Moveset_Editor.CheckThings;
using NASB_Moveset_Editor.StateActions;
using NASB_Moveset_Editor.ObjectSources;
using static NASB_Parser.CheckThings.CheckThing;

namespace NASB_Moveset_Editor.CheckThings
{
	public class CTInputNode : CheckThingNode
	{
		[Output] public InputValidator InputValidator;
		public int Frames;
		public GIEV BlockedBy;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.InputId;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(CTInput data, MovesetGraph graph, string assetPath, Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(CTInput));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			InputValidator = data.InputValidator;
			
			InputValidatorNode node_InputValidator = graph.AddNode<InputValidatorNode>();
			GetPort("InputValidator").Connect(node_InputValidator.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_InputValidator, assetPath);
			variableCount += node_InputValidator.SetData(InputValidator, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
			++variableCount;
			
			Frames = data.Frames;
			BlockedBy = data.BlockedBy;
			return variableCount;
		}
		
		public new CTInput GetData()
		{
			CTInput objToReturn = new CTInput();
			objToReturn.TID = TypeId.InputId;
			objToReturn.Version = Version;
			if (GetPort("InputValidator").ConnectionCount > 0)
			{
				InputValidatorNode InputValidator_Node = (InputValidatorNode)GetPort("InputValidator").GetConnection(0).node;
				objToReturn.InputValidator = InputValidator_Node.GetData();
			}
			objToReturn.Frames = Frames;
			objToReturn.BlockedBy = BlockedBy;
			return objToReturn;
		}
	}
}

