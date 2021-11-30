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
using static NASB_Parser.StateActions.MovementConfig;

namespace NASB_Moveset_Editor.StateActions
{
	public class MovementConfigNode : StateActionNode
	{
		public bool GetParented;
		public bool LeaveEdges;
		public bool PassThrough;
		public bool FallThrough;
		public bool IgnoreMovingStage;
		public bool Bounce;
		public bool Stop;
		public bool LeaveParent;
		public NASB_Parser.StateActions.MovementConfig.StageLayer IgnoreStageLayer;
		public float InheritParentVel;
		public float LeaveEdgeRestrict;
		public bool SimpleFreeMovement;
		public float SimpleRadius;
		
		protected override void Init()
		{
			base.Init();
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(MovementConfig data, MovesetGraph graph, string assetPath, Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(MovementConfig));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			GetParented = data.GetParented;
			LeaveEdges = data.LeaveEdges;
			PassThrough = data.PassThrough;
			FallThrough = data.FallThrough;
			IgnoreMovingStage = data.IgnoreMovingStage;
			Bounce = data.Bounce;
			Stop = data.Stop;
			LeaveParent = data.LeaveParent;
			IgnoreStageLayer = data.IgnoreStageLayer;
			InheritParentVel = data.InheritParentVel;
			LeaveEdgeRestrict = data.LeaveEdgeRestrict;
			SimpleFreeMovement = data.SimpleFreeMovement;
			SimpleRadius = data.SimpleRadius;
			return variableCount;
		}
		
		public MovementConfig GetData()
		{
			MovementConfig objToReturn = new MovementConfig();
			objToReturn.GetParented = GetParented;
			objToReturn.LeaveEdges = LeaveEdges;
			objToReturn.PassThrough = PassThrough;
			objToReturn.FallThrough = FallThrough;
			objToReturn.IgnoreMovingStage = IgnoreMovingStage;
			objToReturn.Bounce = Bounce;
			objToReturn.Stop = Stop;
			objToReturn.LeaveParent = LeaveParent;
			objToReturn.IgnoreStageLayer = IgnoreStageLayer;
			objToReturn.InheritParentVel = InheritParentVel;
			objToReturn.LeaveEdgeRestrict = LeaveEdgeRestrict;
			objToReturn.SimpleFreeMovement = SimpleFreeMovement;
			objToReturn.SimpleRadius = SimpleRadius;
			return objToReturn;
		}
	}
}

