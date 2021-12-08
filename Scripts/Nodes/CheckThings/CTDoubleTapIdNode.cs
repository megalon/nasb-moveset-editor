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
	public class CTDoubleTapIdNode : CheckThingNode
	{
		[Input(connectionType = ConnectionType.Override)] public CheckThing NodeInput;
		public NASB_Parser.CheckThings.CTDoubleTapId.SimpleControlDir TapDir;
		public int Window;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.DoubleTapId;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(CTDoubleTapId data, MovesetGraph graph, string assetPath, Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(CTDoubleTapId));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			TapDir = data.TapDir;
			Window = data.Window;
			return variableCount;
		}
		
		public new CTDoubleTapId GetData()
		{
			CTDoubleTapId objToReturn = new CTDoubleTapId();
			objToReturn.TID = TypeId.DoubleTapId;
			objToReturn.Version = Version;
			objToReturn.TapDir = TapDir;
			objToReturn.Window = Window;
			return objToReturn;
		}
	}
}

