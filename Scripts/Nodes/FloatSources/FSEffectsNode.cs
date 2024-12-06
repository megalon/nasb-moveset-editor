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
using static MovesetParser.FloatSources.FloatSource;

namespace NASB_Moveset_Editor.FloatSources
{
	public class FSEffectsNode : FloatSourceNode
	{
		[Input(connectionType = ConnectionType.Override)] public FloatSource NodeInput;
		public string LocalFxId;
		public MovesetParser.FloatSources.FSEffects.ManipAspect Masp;
		
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

