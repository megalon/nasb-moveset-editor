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
using static NASB_Parser.StateActions.HurtBone;

namespace NASB_Moveset_Editor.StateActions
{
	public class HurtBoneNode : BaseMovesetNode
	{
		public HurtType Type;
		public int Armor;
		public int KnockbackArmor;
		public bool ForceZ0;
		public string BoneA;
		public string BoneB;
		public float Radius;
		public NASB_Parser.Vector3 LocalOffsetA;
		public NASB_Parser.Vector3 WorldOffsetA;
		public NASB_Parser.Vector3 LocalOffsetB;
		public NASB_Parser.Vector3 WorldOffsetB;
		
		protected override void Init()
		{
			base.Init();
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
			ForceZ0 = data.ForceZ0;
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
			objToReturn.ForceZ0 = ForceZ0;
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

