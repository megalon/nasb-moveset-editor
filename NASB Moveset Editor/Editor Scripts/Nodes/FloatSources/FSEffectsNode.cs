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
using static NASB_Parser.FloatSources.FloatSource;

namespace NASB_Moveset_Editor.FloatSources
{
	public class FSEffectsNode : FloatSourceNode
	{
		public string LocalFxId;
		public NASB_Parser.FloatSources.FSEffects.ManipAspect Masp;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.EffectsId;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(FSEffects data, MovesetGraph graph, string assetPath, Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(FSEffects));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			LocalFxId = data.LocalFxId;
			Masp = data.Masp;
			return variableCount;
		}
		
		public new FSEffects GetData()
		{
			FSEffects objToReturn = new FSEffects();
			objToReturn.TID = TypeId.EffectsId;
			objToReturn.Version = Version;
			objToReturn.LocalFxId = LocalFxId;
			objToReturn.Masp = Masp;
			return objToReturn;
		}
	}
}

