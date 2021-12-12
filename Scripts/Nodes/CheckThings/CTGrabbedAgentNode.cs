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
	public class CTGrabbedAgentNode : CheckThingNode
	{
		[Input(connectionType = ConnectionType.Override)] public CheckThing NodeInput;
		public List<string> MatchTags;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.GrabAgentId;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(CTGrabbedAgent data, MovesetGraph graph, string assetPath, Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(CTGrabbedAgent));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			MatchTags = data.MatchTags;
			return variableCount;
		}
		
		public new CTGrabbedAgent GetData()
		{
			CTGrabbedAgent objToReturn = new CTGrabbedAgent();
			objToReturn.TID = TypeId.GrabAgentId;
			objToReturn.Version = Version;
			objToReturn.MatchTags = MatchTags;
			return objToReturn;
		}
	}
}

