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

namespace NASB_Moveset_Editor.Misc
{
	public class InputValidatorNode : BaseMovesetNode
	{
		[Input(connectionType = ConnectionType.Override)] public InputValidator NodeInput;
		[Output(connectionType = ConnectionType.Override)] public InputType InputType;
		public bool RawX;
		
		protected override void Init()
		{
			base.Init();
			// InputValidator should default to Inside, since zero is unused
			SegCompare = CtrlSegCompare.Inside;
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
			
			InputTypeNode node_InputType = graph.AddNode<InputTypeNode>();
			GetPort("InputType").Connect(node_InputType.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_InputType, assetPath);
			variableCount += node_InputType.SetData(InputType, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			RawX = data.RawX;
			return variableCount;
		}
		
		public InputValidator GetData()
		{
			InputValidator objToReturn = new InputValidator();
			if (GetPort("InputType").ConnectionCount > 0)
			{
				InputTypeNode InputType_Node = (InputTypeNode)GetPort("InputType").GetConnection(0).node;
				objToReturn.InputType = InputType_Node.GetData();
			}
			objToReturn.RawX = RawX;
			return objToReturn;
		}
	}
}

