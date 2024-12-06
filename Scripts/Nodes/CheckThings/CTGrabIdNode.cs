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
using static MovesetParser.CheckThings.CheckThing;

namespace NASB_Moveset_Editor.CheckThings
{
	public class CTGrabIdNode : CheckThingNode
	{
		[Input(connectionType = ConnectionType.Override)] public CheckThing NodeInput;
		public MovesetParser.CheckThings.CTGrabId.CheckTypes CheckType;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.GrabId;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(CTGrabId data, MovesetGraph graph, string assetPath, Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(CTGrabId));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			CheckType = data.CheckType;
			return variableCount;
		}
		
		public new CTGrabId GetData()
		{
			CTGrabId objToReturn = new CTGrabId();
			objToReturn.TID = TypeId.GrabId;
			objToReturn.Version = Version;
			objToReturn.CheckType = CheckType;
			return objToReturn;
		}
	}
}

