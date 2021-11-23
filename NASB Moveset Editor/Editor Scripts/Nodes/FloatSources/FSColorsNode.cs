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
	public class FSColorsNode : FloatSourceNode
	{
		public string ColorId;
		public bool Permanent;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.ColorsId;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(FSColors data, MovesetGraph graph, string assetPath, Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(FSColors));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			ColorId = data.ColorId;
			Permanent = data.Permanent;
			return variableCount;
		}
		
		public new FSColors GetData()
		{
			FSColors objToReturn = new FSColors();
			objToReturn.TID = TypeId.ColorsId;
			objToReturn.Version = Version;
			objToReturn.ColorId = ColorId;
			objToReturn.Permanent = Permanent;
			return objToReturn;
		}
	}
}

