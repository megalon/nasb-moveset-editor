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
	public class FSMovementNode : FloatSourceNode
	{
		public NASB_Parser.FloatSources.FSMovement.Attributes Attribute;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.MovementId;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(FSMovement data, MovesetGraph graph, string assetPath, Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(FSMovement));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			Attribute = data.Attribute;
			return variableCount;
		}
		
		public new FSMovement GetData()
		{
			FSMovement objToReturn = new FSMovement();
			objToReturn.TID = TypeId.MovementId;
			objToReturn.Version = Version;
			objToReturn.Attribute = Attribute;
			return objToReturn;
		}
	}
}

