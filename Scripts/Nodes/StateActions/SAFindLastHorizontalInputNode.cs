// * 
// * 
// * This file was generated using NASB_Parser_to_xNode by megalon2d
// * https://github.com/megalon/NASB_Parser_to_xNode
// * 
// * 
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
using NASB_Parser.StateActions;
using NASB_Parser.ObjectSources;
using NASB_Moveset_Editor.FloatSources;
using NASB_Moveset_Editor.Jumps;
using NASB_Moveset_Editor.CheckThings;
using NASB_Moveset_Editor.StateActions;
using NASB_Moveset_Editor.ObjectSources;
using static NASB_Parser.StateActions.StateAction;

namespace NASB_Moveset_Editor.StateActions
{
	public class SAFindLastHorizontalInputNode : StateActionNode
	{
		[Input(connectionType = ConnectionType.Override)] public StateAction NodeInput;
		public NASB_Parser.StateActions.SAFindLastHorizontalInput.SearchType Search;
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

