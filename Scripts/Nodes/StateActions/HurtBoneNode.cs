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
using static MovesetParser.StateActions.HurtBone;

namespace NASB_Moveset_Editor.StateActions
{
	public class HurtBoneNode : StateActionNode
	{
		[Input(connectionType = ConnectionType.Override)] public HurtBone NodeInput;
		public HurtType Type;
		public int Armor;
		public int KnockbackArmor;
		public bool IgnoreGrab;
		public string BoneA;
		public string BoneB;
		public float Radius;
		public MovesetParser.Vector3 LocalOffsetA;
		public MovesetParser.Vector3 WorldOffsetA;
		public MovesetParser.Vector3 LocalOffsetB;
		public MovesetParser.Vector3 WorldOffsetB;
		
		protected override void Init()
		{
			base.Init();
			Version = 1;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(HurtBone data, MovesetGraph graph, string assetPath, Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(HurtBone));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			Type = data.Type;
			Armor = data.Armor;
			KnockbackArmor = data.KnockbackArmor;
			IgnoreGrab = data.IgnoreGrab;
			BoneA = data.BoneA;
			BoneB = data.BoneB;
			Radius = data.Radius;
			LocalOffsetA = data.LocalOffsetA;
			WorldOffsetA = data.WorldOffsetA;
			LocalOffsetB = data.LocalOffsetB;
			WorldOffsetB = data.WorldOffsetB;
			return variableCount;
		}
		
		public HurtBone GetData()
		{
			HurtBone objToReturn = new HurtBone();
			objToReturn.Type = Type;
			objToReturn.Armor = Armor;
			objToReturn.KnockbackArmor = KnockbackArmor;
			objToReturn.IgnoreGrab = IgnoreGrab;
			objToReturn.BoneA = BoneA;
			objToReturn.BoneB = BoneB;
			objToReturn.Radius = Radius;
			objToReturn.LocalOffsetA = LocalOffsetA;
			objToReturn.WorldOffsetA = WorldOffsetA;
			objToReturn.LocalOffsetB = LocalOffsetB;
			objToReturn.WorldOffsetB = WorldOffsetB;
			return objToReturn;
		}
	}
}

