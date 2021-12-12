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
	public class SAConfigHitboxNode : StateActionNode
	{
		[Input(connectionType = ConnectionType.Override)] public StateAction NodeInput;
		public int Hitbox;
		public bool ForceZ0;
		public float Radius;
		public NASB_Parser.Vector3 LocalOffset;
		public NASB_Parser.Vector3 WorldOffset;
		public string Prop;
		public string Bone;
		public string FxId;
		public string SfxId;
		public bool SecondTrack;
		public string Bone2;
		public NASB_Parser.Vector3 LocalOffset2;
		public NASB_Parser.Vector3 WorldOffset2;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.ConfigHitboxId;
			Version = 1;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SAConfigHitbox data, MovesetGraph graph, string assetPath, Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SAConfigHitbox));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			Hitbox = data.Hitbox;
			ForceZ0 = data.ForceZ0;
			Radius = data.Radius;
			LocalOffset = data.LocalOffset;
			WorldOffset = data.WorldOffset;
			Prop = data.Prop;
			Bone = data.Bone;
			FxId = data.FxId;
			SfxId = data.SfxId;
			SecondTrack = data.SecondTrack;
			Bone2 = data.Bone2;
			LocalOffset2 = data.LocalOffset2;
			WorldOffset2 = data.WorldOffset2;
			return variableCount;
		}
		
		public new SAConfigHitbox GetData()
		{
			SAConfigHitbox objToReturn = new SAConfigHitbox();
			objToReturn.TID = TypeId.ConfigHitboxId;
			objToReturn.Version = Version;
			objToReturn.Hitbox = Hitbox;
			objToReturn.ForceZ0 = ForceZ0;
			objToReturn.Radius = Radius;
			objToReturn.LocalOffset = LocalOffset;
			objToReturn.WorldOffset = WorldOffset;
			objToReturn.Prop = Prop;
			objToReturn.Bone = Bone;
			objToReturn.FxId = FxId;
			objToReturn.SfxId = SfxId;
			objToReturn.SecondTrack = SecondTrack;
			objToReturn.Bone2 = Bone2;
			objToReturn.LocalOffset2 = LocalOffset2;
			objToReturn.WorldOffset2 = WorldOffset2;
			return objToReturn;
		}
	}
}

