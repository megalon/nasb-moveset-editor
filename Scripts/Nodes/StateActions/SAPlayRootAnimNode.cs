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
using static NASB_Parser.StateActions.StateAction;

namespace NASB_Moveset_Editor.StateActions
{
	public class SAPlayRootAnimNode : StateActionNode
	{
		[Input(connectionType = ConnectionType.Override)] public StateAction NodeInput;
		public string Anim;
		public float Rate;
		public bool SetRateOnly;
		public float Frame;
		public bool SetFrame;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.RootAnimId;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SAPlayRootAnim data, MovesetGraph graph, string assetPath, Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SAPlayRootAnim));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			Anim = data.Anim;
			Rate = data.Rate;
			SetRateOnly = data.SetRateOnly;
			Frame = data.Frame;
			SetFrame = data.SetFrame;
			return variableCount;
		}
		
		public new SAPlayRootAnim GetData()
		{
			SAPlayRootAnim objToReturn = new SAPlayRootAnim();
			objToReturn.TID = TypeId.RootAnimId;
			objToReturn.Version = Version;
			objToReturn.Anim = Anim;
			objToReturn.Rate = Rate;
			objToReturn.SetRateOnly = SetRateOnly;
			objToReturn.Frame = Frame;
			objToReturn.SetFrame = SetFrame;
			return objToReturn;
		}
	}
}

