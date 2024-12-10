// * 
// * 
// * This file was generated using NASB_Parser_to_xNode by megalon2d
// * https://github.com/megalon/NASB_Parser_to_xNode
// * 
// * 
using UnityEngine;
using UnityEditor;
using XNode;
using XNodeEditor;
using MovesetParser;
using MovesetParser.CheckThings;
using MovesetParser.FloatSources;
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

namespace NASB_Moveset_Editor.CheckThings
{
	public class CTInputSeries_LookForInputNode : CheckThingNode
	{
		[Input(connectionType = ConnectionType.Override)] public CTInputSeries.LookForInput NodeInput;
		public int matchMinFrames;
		[Output(connectionType = ConnectionType.Override)] public InputValidator iv;
		
		protected override void Init()
		{
			base.Init();
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(CTInputSeries.LookForInput data, MovesetGraph graph, string assetPath, UnityEngine.Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(CTInputSeries.LookForInput));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			matchMinFrames = data.matchMinFrames;
			iv = data.iv;
			
			InputValidatorNode node_iv = graph.AddNode<InputValidatorNode>();
			GetPort("iv").Connect(node_iv.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_iv, assetPath);
			variableCount += node_iv.SetData(iv, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			
			return variableCount;
		}
		
		public CTInputSeries.LookForInput GetData()
		{
			CTInputSeries.LookForInput objToReturn = new CTInputSeries.LookForInput();
			objToReturn.matchMinFrames = matchMinFrames;
			if (GetPort("iv").ConnectionCount > 0)
			{
				InputValidatorNode InputValidator_Node = (InputValidatorNode)GetPort("iv").GetConnection(0).node;
				objToReturn.iv = InputValidator_Node.GetData();
			}
			return objToReturn;
		}
	}
}

