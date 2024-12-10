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
using static MovesetParser.Misc.InputValidator;
using NUnit.Framework.Constraints;

namespace NASB_Moveset_Editor.Misc
{
	public class InputValidatorNode : BaseMovesetNode
	{
		[Input(connectionType = ConnectionType.Override)] public InputValidator NodeInput;
		public InputType InputType;
		public bool RawX;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer FloatValue;
		public CtrlSeg Segment;
		public FloatCompare FloatCompare;
		public ButtonCompare ButtonCompare;
		public CtrlSegCompare SegmentCompare;
		public MultiCompare MultiCompare;
		[Output(connectionType = ConnectionType.Multiple)] public InputValidator[] Validators;
		
		protected override void Init()
		{
			base.Init();
			ButtonCompare = ButtonCompare.Down;
			SegmentCompare = CtrlSegCompare.Inside;
			MultiCompare = MultiCompare.Any;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(InputValidator data, MovesetGraph graph, string assetPath, UnityEngine.Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(InputValidator));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			InputType = data.InputType;
			RawX = data.RawX;
			FloatValue = data.FloatValue;
			
			FloatSourceContainerNode node_FloatValue = graph.AddNode<FloatSourceContainerNode>();
			GetPort("FloatValue").Connect(node_FloatValue.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_FloatValue, assetPath);
			variableCount += node_FloatValue.SetData(FloatValue, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			Segment = data.Segment;
			FloatCompare = data.FloatCompare;
			ButtonCompare = data.ButtonCompare;
			SegmentCompare = data.SegmentCompare;
			MultiCompare = data.MultiCompare;
			Validators = data.Validators;

			if (Validators == null) return variableCount;
			
			foreach (InputValidator Validators_item in data.Validators)
			{
				InputValidatorNode node_Validators = graph.AddNode<InputValidatorNode>();
				GetPort("Validators").Connect(node_Validators.GetPort("NodeInput"));
				AssetDatabase.AddObjectToAsset(node_Validators, assetPath);
				variableCount += node_Validators.SetData(Validators_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				++variableCount;
			}
			
			return variableCount;
		}
		
		public InputValidator GetData()
		{
			InputValidator objToReturn = new InputValidator();
			objToReturn.InputType = InputType;
			objToReturn.RawX = RawX;
			if (GetPort("FloatValue").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("FloatValue").GetConnection(0).node;
				objToReturn.FloatValue = FloatSourceContainer_Node.GetData();
			}
			objToReturn.Segment = Segment;
			objToReturn.FloatCompare = FloatCompare;
			objToReturn.ButtonCompare = ButtonCompare;
			objToReturn.SegmentCompare = SegmentCompare;
			objToReturn.MultiCompare = MultiCompare;
			objToReturn.Validators = new InputValidator[GetPort("Validators").ConnectionCount];
			int i = 0;
			foreach(NodePort port in GetPort("Validators").GetConnections())
			{
				InputValidatorNode InputValidator_Node = (InputValidatorNode)port.node;
				objToReturn.Validators[i] = InputValidator_Node.GetData();
				++i;
			}
			return objToReturn;
		}
	}
}

