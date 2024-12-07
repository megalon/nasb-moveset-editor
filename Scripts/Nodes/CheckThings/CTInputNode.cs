// * 
// * 
// * This file was generated using NASB_Parser_to_xNode by megalon2d
// * https://github.com/megalon/NASB_Parser_to_xNode
// * 
// * 
using MovesetParser.BulkSerialize;
using MovesetParser.Misc;
using UnityEngine;
using UnityEditor;
using XNode;
using XNodeEditor;
using MovesetParser;
using MovesetParser.CheckThings;
using MovesetParser.FloatSources;
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
using static MovesetParser.CheckThings.CheckThing;

namespace NASB_Moveset_Editor.CheckThings
{
	public class CTInputNode : CheckThingNode
	{
		[Input(connectionType = ConnectionType.Override)] public CheckThing NodeInput;
		[Output(connectionType = ConnectionType.Override)] public InputValidator InputValidator;
		public int Frames;
		public GIEV BlockedBy;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.CTInput;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(CTInput data, MovesetGraph graph, string assetPath, UnityEngine.Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(CTInput));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			InputValidator = data.InputValidator;
			
			InputValidatorNode node_InputValidator = graph.AddNode<InputValidatorNode>();
			GetPort("InputValidator").Connect(node_InputValidator.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_InputValidator, assetPath);
			variableCount += node_InputValidator.SetData(InputValidator, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			Frames = data.Frames;
			BlockedBy = data.BlockedBy;
			return variableCount;
		}
		
		public new CTInput GetData()
		{
			CTInput objToReturn = new CTInput();
			objToReturn.TID = TypeId.CTInput;
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

