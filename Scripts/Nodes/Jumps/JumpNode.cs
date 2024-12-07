// * 
// * 
// * This file was generated using NASB_Parser_to_xNode by megalon2d
// * https://github.com/megalon/NASB_Parser_to_xNode
// * 
// * 
using MovesetParser.BulkSerialize;
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
using static MovesetParser.Jumps.Jump;

namespace NASB_Moveset_Editor.Jumps
{
	public class JumpNode : BaseMovesetNode
	{
		[HideInInspector] public MovesetParser.Jumps.Jump.TypeId TID;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.Jump;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(Jump data, MovesetGraph graph, string assetPath, UnityEngine.Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(Jump));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			TID = data.TID;
			return variableCount;
		}
		
		public Jump GetData()
		{
			Jump objToReturn = new Jump();
			objToReturn.TID = TypeId.Jump;
			objToReturn.TID = TID;
			return objToReturn;
		}
	}
}

