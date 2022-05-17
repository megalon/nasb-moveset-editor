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
using static NASB_Parser.CheckThings.CheckThing;

namespace NASB_Moveset_Editor.CheckThings
{
	public class CTMoveNode : CheckThingNode
	{
		[Input(connectionType = ConnectionType.Override)] public CheckThing NodeInput;
		public string MovesetId;
		public bool Previous;
		public bool Not;
		public List<string> Extras;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.MoveId;
			Version = 1;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(CTMove data, MovesetGraph graph, string assetPath, Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(CTMove));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			MovesetId = data.MovesetId;
			Previous = data.Previous;
			Not = data.Not;
			Extras = data.Extras;
			return variableCount;
		}
		
		public new CTMove GetData()
		{
			CTMove objToReturn = new CTMove();
			objToReturn.TID = TypeId.MoveId;
			objToReturn.Version = Version;
			objToReturn.MovesetId = MovesetId;
			objToReturn.Previous = Previous;
			objToReturn.Not = Not;
			objToReturn.Extras = Extras;
			return objToReturn;
		}
	}
}

