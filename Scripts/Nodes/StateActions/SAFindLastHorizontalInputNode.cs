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
using static MovesetParser.StateActions.StateAction;

namespace NASB_Moveset_Editor.StateActions
{
	public class SAFindLastHorizontalInputNode : StateActionNode
	{
		[Input(connectionType = ConnectionType.Override)] public StateAction NodeInput;
		public Search Search;
		public Stick Stick;
		public int ResultInScratch;
		public int DurationFrames;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.SAFindLastHorizontalInput;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SAFindLastHorizontalInput data, MovesetGraph graph, string assetPath, UnityEngine.Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SAFindLastHorizontalInput));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			Search = data.Search;
			Stick = data.Stick;
			ResultInScratch = data.ResultInScratch;
			DurationFrames = data.DurationFrames;
			return variableCount;
		}
		
		public new SAFindLastHorizontalInput GetData()
		{
			SAFindLastHorizontalInput objToReturn = new SAFindLastHorizontalInput();
			objToReturn.TID = TypeId.SAFindLastHorizontalInput;
			objToReturn.Search = Search;
			objToReturn.Stick = Stick;
			objToReturn.ResultInScratch = ResultInScratch;
			objToReturn.DurationFrames = DurationFrames;
			return objToReturn;
		}
	}
}

