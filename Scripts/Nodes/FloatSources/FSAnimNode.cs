// * 
// * 
// * This file was generated using MovesetParser_to_xNode by megalon2d
// * https://github.com/megalon/MovesetParser_to_xNode
// * 
// * 
using MovesetParser.FloatSources;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEditor;
using XNode;
using XNodeEditor;
using MovesetParser;
using MovesetParser.Jumps;
using MovesetParser.CheckThings;
using MovesetParser.StateActions;
using MovesetParser.ObjectSources;
using NASB_Moveset_Editor.FloatSources;
using NASB_Moveset_Editor.Jumps;
using NASB_Moveset_Editor.CheckThings;
using NASB_Moveset_Editor.StateActions;
using NASB_Moveset_Editor.ObjectSources;
using static MovesetParser.FloatSources.FloatSource;

namespace NASB_Moveset_Editor.FloatSources
{
	public class FSAnimNode : FloatSourceNode
	{
		[Input(connectionType = ConnectionType.Override)] public FloatSource NodeInput;
		public string Anim;
		public MovesetParser.FloatSources.FSAnim.AnimAttr Attribute;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.AnimId;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(FSAnim data, MovesetGraph graph, string assetPath, Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(FSAnim));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			Anim = data.Anim;
			Attribute = data.Attribute;
			return variableCount;
		}
		
		public new FSAnim GetData()
		{
			FSAnim objToReturn = new FSAnim();
			objToReturn.TID = TypeId.AnimId;
			objToReturn.Version = Version;
			objToReturn.Anim = Anim;
			objToReturn.Attribute = Attribute;
			return objToReturn;
		}
	}
}

