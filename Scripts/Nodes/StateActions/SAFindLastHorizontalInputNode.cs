// * 
// * 
// * This file was generated using MovesetParser_to_xNode by megalon2d
// * https://github.com/megalon/MovesetParser_to_xNode
// * 
// * 
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
using MovesetParser.StateActions;
using MovesetParser.ObjectSources;
using NASB_Moveset_Editor.FloatSources;
using NASB_Moveset_Editor.Jumps;
using NASB_Moveset_Editor.CheckThings;
using NASB_Moveset_Editor.StateActions;
using NASB_Moveset_Editor.ObjectSources;
using static MovesetParser.StateActions.StateAction;

namespace NASB_Moveset_Editor.StateActions
{
	public class SAFindLastHorizontalInputNode : StateActionNode
	{
		[Input(connectionType = ConnectionType.Override)] public StateAction NodeInput;
		public MovesetParser.StateActions.SAFindLastHorizontalInput.SearchType Search;
		public int ResultInScratch;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.FindLastHorizontalInputId;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SAFindLastHorizontalInput data, MovesetGraph graph, string assetPath, Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SAFindLastHorizontalInput));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			Search = data.Search;
			ResultInScratch = data.ResultInScratch;
			return variableCount;
		}
		
		public new SAFindLastHorizontalInput GetData()
		{
			SAFindLastHorizontalInput objToReturn = new SAFindLastHorizontalInput();
			objToReturn.TID = TypeId.FindLastHorizontalInputId;
			objToReturn.Version = Version;
			objToReturn.Search = Search;
			objToReturn.ResultInScratch = ResultInScratch;
			return objToReturn;
		}
	}
}

