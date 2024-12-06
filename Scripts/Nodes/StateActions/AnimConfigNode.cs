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
using static MovesetParser.StateActions.AnimConfig;

namespace NASB_Moveset_Editor.StateActions
{
	public class AnimConfigNode : StateActionNode
	{
		[Input(connectionType = ConnectionType.Override)] public AnimConfig NodeInput;
		public float Rate;
		public float Weight;
		public MovesetParser.StateActions.AnimConfig.WrapMode Wrap;
		public bool ClingToFrames;
		
		protected override void Init()
		{
			base.Init();
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(AnimConfig data, MovesetGraph graph, string assetPath, Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(AnimConfig));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			Rate = data.Rate;
			Weight = data.Weight;
			Wrap = data.Wrap;
			ClingToFrames = data.ClingToFrames;
			return variableCount;
		}
		
		public AnimConfig GetData()
		{
			AnimConfig objToReturn = new AnimConfig();
			objToReturn.Rate = Rate;
			objToReturn.Weight = Weight;
			objToReturn.Wrap = Wrap;
			objToReturn.ClingToFrames = ClingToFrames;
			return objToReturn;
		}
	}
}

