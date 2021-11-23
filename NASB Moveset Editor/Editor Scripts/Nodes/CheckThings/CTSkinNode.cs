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
	public class CTSkinNode : CheckThingNode
	{
		public string MatchSkin;
		public bool MatchColor;
		public int MatchAgainstColor;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.SkinId;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(CTSkin data, MovesetGraph graph, string assetPath, Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(CTSkin));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			MatchSkin = data.MatchSkin;
			MatchColor = data.MatchColor;
			MatchAgainstColor = data.MatchAgainstColor;
			return variableCount;
		}
		
		public new CTSkin GetData()
		{
			CTSkin objToReturn = new CTSkin();
			objToReturn.TID = TypeId.SkinId;
			objToReturn.Version = Version;
			objToReturn.MatchSkin = MatchSkin;
			objToReturn.MatchColor = MatchColor;
			objToReturn.MatchAgainstColor = MatchAgainstColor;
			return objToReturn;
		}
	}
}

