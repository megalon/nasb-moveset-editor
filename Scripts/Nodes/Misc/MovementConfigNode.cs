// * 
// * 
// * This file was generated using NASB_Parser_to_xNode by megalon2d
// * https://github.com/megalon/NASB_Parser_to_xNode
// * 
// * 
using MovesetParser.BulkSerialize;
using UnityEngine;
using UnityEditor;
using XNode;
using XNodeEditor;
using MovesetParser;
using MovesetParser.CheckThings;
using MovesetParser.FloatSources;
using MovesetParser.Jumps;
using MovesetParser.Misc;
using MovesetParser.StateActions;
using MovesetParser.ObjectSources;
using MovesetParser.Unity;
using NASB_Moveset_Editor.CheckThings;
using NASB_Moveset_Editor.FloatSources;
using NASB_Moveset_Editor.Jumps;
using NASB_Moveset_Editor.Misc;
using NASB_Moveset_Editor.StateActions;
using NASB_Moveset_Editor.ObjectSources;
using NASB_Moveset_Editor.Unity;
using static MovesetParser.Misc.MovementConfig;

namespace NASB_Moveset_Editor.Misc
{
	public class MovementConfigNode : BaseMovesetNode
	{
		[Input(connectionType = ConnectionType.Override)] public MovementConfig NodeInput;
		public bool GetParented;
		public bool LeaveEdges;
		public bool PassThrough;
		public bool FallThrough;
		public bool IgnoreMovingStage;
		public bool Bounce;
		public bool Stop;
		public bool LeaveParent;
		public float InheritParentVelocity;
		public StageLayer IgnoreStageLayer;
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
		
		public int SetData(MovementConfig data, MovesetGraph graph, string assetPath, UnityEngine.Vector2 nodeDepthXY)
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
			InheritParentVelocity = data.InheritParentVelocity;
			IgnoreStageLayer = data.IgnoreStageLayer;
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
			objToReturn.InheritParentVelocity = InheritParentVelocity;
			objToReturn.IgnoreStageLayer = IgnoreStageLayer;
			objToReturn.LeaveEdgeRestrict = LeaveEdgeRestrict;
			objToReturn.SimpleFreeMovement = SimpleFreeMovement;
			objToReturn.SimpleRadius = SimpleRadius;
			return objToReturn;
		}
	}
}

