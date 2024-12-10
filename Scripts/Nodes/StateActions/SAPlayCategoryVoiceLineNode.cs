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
using static MovesetParser.StateActions.StateAction;

namespace NASB_Moveset_Editor.StateActions
{
	public class SAPlayCategoryVoiceLineNode : StateActionNode
	{
		[Input(connectionType = ConnectionType.Override)] public StateAction NodeInput;
		public string CategoryId;
		public bool CheckAvailableLines;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.SAPlayCategoryVoiceLine;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SAPlayCategoryVoiceLine data, MovesetGraph graph, string assetPath, UnityEngine.Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SAPlayCategoryVoiceLine));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			CategoryId = data.CategoryId;
			CheckAvailableLines = data.CheckAvailableLines;
			return variableCount;
		}
		
		public new SAPlayCategoryVoiceLine GetData()
		{
			SAPlayCategoryVoiceLine objToReturn = new SAPlayCategoryVoiceLine();
			objToReturn.TID = TypeId.SAPlayCategoryVoiceLine;
			objToReturn.CategoryId = CategoryId;
			objToReturn.CheckAvailableLines = CheckAvailableLines;
			return objToReturn;
		}
	}
}

