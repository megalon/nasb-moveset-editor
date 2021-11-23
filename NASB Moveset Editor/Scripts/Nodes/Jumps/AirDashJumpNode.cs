// * 
// * 
// * This file was generated using NASB_Parser_to_xNode by megalon2d
// * https://github.com/megalon/NASB_Parser_to_xNode
// * 
// * 
using NASB_Parser.FloatSources;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEditor;
using XNode;
using XNodeEditor;
using NASB_Parser;
using NASB_Parser.Jumps;
using NASB_Parser.CheckThings;
using NASB_Parser.StateActions;
using NASB_Parser.ObjectSources;
using NASB_Moveset_Editor.FloatSources;
using NASB_Moveset_Editor.Jumps;
using NASB_Moveset_Editor.CheckThings;
using NASB_Moveset_Editor.StateActions;
using NASB_Moveset_Editor.ObjectSources;
using static NASB_Parser.Jumps.Jump;

namespace NASB_Moveset_Editor.Jumps
{
	public class AirDashJumpNode : JumpNode
	{
		public Ease EaseSpeed;
		[Output] public FloatSource XDir;
		[Output] public FloatSource YDir;
		[Output] public FloatSource SpeedStart;
		[Output] public FloatSource SpeedEnd;
		[Output] public FloatSource SpeedUpMult;
		[Output] public FloatSource SpeedDownMult;
		[Output] public FloatSource Frames;
		[Output] public FloatSource RedirectFrames;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.AirdashId;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(AirDashJump data, MovesetGraph graph, string assetPath, Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(AirDashJump));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			EaseSpeed = data.EaseSpeed;
			XDir = data.XDir;
			
			switch (XDir.TID)
			{
				case FloatSource.TypeId.AgentId:
					FSAgentNode AgentId_node_XDir = graph.AddNode<FSAgentNode>();
					GetPort("XDir").Connect(AgentId_node_XDir.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AgentId_node_XDir, assetPath);
					variableCount += AgentId_node_XDir.SetData((FSAgent)XDir, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.BonesId:
					FSBonesNode BonesId_node_XDir = graph.AddNode<FSBonesNode>();
					GetPort("XDir").Connect(BonesId_node_XDir.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BonesId_node_XDir, assetPath);
					variableCount += BonesId_node_XDir.SetData((FSBones)XDir, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AttackId:
					FSAttackNode AttackId_node_XDir = graph.AddNode<FSAttackNode>();
					GetPort("XDir").Connect(AttackId_node_XDir.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AttackId_node_XDir, assetPath);
					variableCount += AttackId_node_XDir.SetData((FSAttack)XDir, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FrameId:
					FSFrameNode FrameId_node_XDir = graph.AddNode<FSFrameNode>();
					GetPort("XDir").Connect(FrameId_node_XDir.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FrameId_node_XDir, assetPath);
					variableCount += FrameId_node_XDir.SetData((FSFrame)XDir, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.InputId:
					FSInputNode InputId_node_XDir = graph.AddNode<FSInputNode>();
					GetPort("XDir").Connect(InputId_node_XDir.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputId_node_XDir, assetPath);
					variableCount += InputId_node_XDir.SetData((FSInput)XDir, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FuncId:
					FSFuncNode FuncId_node_XDir = graph.AddNode<FSFuncNode>();
					GetPort("XDir").Connect(FuncId_node_XDir.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FuncId_node_XDir, assetPath);
					variableCount += FuncId_node_XDir.SetData((FSFunc)XDir, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.MovementId:
					FSMovementNode MovementId_node_XDir = graph.AddNode<FSMovementNode>();
					GetPort("XDir").Connect(MovementId_node_XDir.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(MovementId_node_XDir, assetPath);
					variableCount += MovementId_node_XDir.SetData((FSMovement)XDir, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CombatId:
					FSCombatNode CombatId_node_XDir = graph.AddNode<FSCombatNode>();
					GetPort("XDir").Connect(CombatId_node_XDir.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CombatId_node_XDir, assetPath);
					variableCount += CombatId_node_XDir.SetData((FSCombat)XDir, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.GrabsId:
					FSGrabsNode GrabsId_node_XDir = graph.AddNode<FSGrabsNode>();
					GetPort("XDir").Connect(GrabsId_node_XDir.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(GrabsId_node_XDir, assetPath);
					variableCount += GrabsId_node_XDir.SetData((FSGrabs)XDir, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.DataId:
					FSDataNode DataId_node_XDir = graph.AddNode<FSDataNode>();
					GetPort("XDir").Connect(DataId_node_XDir.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DataId_node_XDir, assetPath);
					variableCount += DataId_node_XDir.SetData((FSData)XDir, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ScratchId:
					FSScratchNode ScratchId_node_XDir = graph.AddNode<FSScratchNode>();
					GetPort("XDir").Connect(ScratchId_node_XDir.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ScratchId_node_XDir, assetPath);
					variableCount += ScratchId_node_XDir.SetData((FSScratch)XDir, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AnimId:
					FSAnimNode AnimId_node_XDir = graph.AddNode<FSAnimNode>();
					GetPort("XDir").Connect(AnimId_node_XDir.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AnimId_node_XDir, assetPath);
					variableCount += AnimId_node_XDir.SetData((FSAnim)XDir, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SpeedId:
					FSSpeedNode SpeedId_node_XDir = graph.AddNode<FSSpeedNode>();
					GetPort("XDir").Connect(SpeedId_node_XDir.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpeedId_node_XDir, assetPath);
					variableCount += SpeedId_node_XDir.SetData((FSSpeed)XDir, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.PhysicsId:
					FSPhysicsNode PhysicsId_node_XDir = graph.AddNode<FSPhysicsNode>();
					GetPort("XDir").Connect(PhysicsId_node_XDir.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(PhysicsId_node_XDir, assetPath);
					variableCount += PhysicsId_node_XDir.SetData((FSPhysics)XDir, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CollisionId:
					FSCollisionNode CollisionId_node_XDir = graph.AddNode<FSCollisionNode>();
					GetPort("XDir").Connect(CollisionId_node_XDir.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CollisionId_node_XDir, assetPath);
					variableCount += CollisionId_node_XDir.SetData((FSCollision)XDir, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.TimerId:
					FSTimerNode TimerId_node_XDir = graph.AddNode<FSTimerNode>();
					GetPort("XDir").Connect(TimerId_node_XDir.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(TimerId_node_XDir, assetPath);
					variableCount += TimerId_node_XDir.SetData((FSTimer)XDir, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.LagId:
					FSLagNode LagId_node_XDir = graph.AddNode<FSLagNode>();
					GetPort("XDir").Connect(LagId_node_XDir.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LagId_node_XDir, assetPath);
					variableCount += LagId_node_XDir.SetData((FSLag)XDir, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.EffectsId:
					FSEffectsNode EffectsId_node_XDir = graph.AddNode<FSEffectsNode>();
					GetPort("XDir").Connect(EffectsId_node_XDir.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EffectsId_node_XDir, assetPath);
					variableCount += EffectsId_node_XDir.SetData((FSEffects)XDir, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ColorsId:
					FSColorsNode ColorsId_node_XDir = graph.AddNode<FSColorsNode>();
					GetPort("XDir").Connect(ColorsId_node_XDir.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ColorsId_node_XDir, assetPath);
					variableCount += ColorsId_node_XDir.SetData((FSColors)XDir, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.OnHitId:
					FSOnHitNode OnHitId_node_XDir = graph.AddNode<FSOnHitNode>();
					GetPort("XDir").Connect(OnHitId_node_XDir.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnHitId_node_XDir, assetPath);
					variableCount += OnHitId_node_XDir.SetData((FSOnHit)XDir, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RandomId:
					FSRandomNode RandomId_node_XDir = graph.AddNode<FSRandomNode>();
					GetPort("XDir").Connect(RandomId_node_XDir.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RandomId_node_XDir, assetPath);
					variableCount += RandomId_node_XDir.SetData((FSRandom)XDir, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CameraId:
					FSCameraInfoNode CameraId_node_XDir = graph.AddNode<FSCameraInfoNode>();
					GetPort("XDir").Connect(CameraId_node_XDir.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CameraId_node_XDir, assetPath);
					variableCount += CameraId_node_XDir.SetData((FSCameraInfo)XDir, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SportsId:
					FSSportsNode SportsId_node_XDir = graph.AddNode<FSSportsNode>();
					GetPort("XDir").Connect(SportsId_node_XDir.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SportsId_node_XDir, assetPath);
					variableCount += SportsId_node_XDir.SetData((FSSports)XDir, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.Vector2Mag:
					FSVector2MagNode Vector2Mag_node_XDir = graph.AddNode<FSVector2MagNode>();
					GetPort("XDir").Connect(Vector2Mag_node_XDir.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(Vector2Mag_node_XDir, assetPath);
					variableCount += Vector2Mag_node_XDir.SetData((FSVector2Mag)XDir, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CPUHelpId:
					FSCpuHelpNode CPUHelpId_node_XDir = graph.AddNode<FSCpuHelpNode>();
					GetPort("XDir").Connect(CPUHelpId_node_XDir.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CPUHelpId_node_XDir, assetPath);
					variableCount += CPUHelpId_node_XDir.SetData((FSCpuHelp)XDir, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ItemId:
					FSItemNode ItemId_node_XDir = graph.AddNode<FSItemNode>();
					GetPort("XDir").Connect(ItemId_node_XDir.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ItemId_node_XDir, assetPath);
					variableCount += ItemId_node_XDir.SetData((FSItem)XDir, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ModeId:
					FSModeNode ModeId_node_XDir = graph.AddNode<FSModeNode>();
					GetPort("XDir").Connect(ModeId_node_XDir.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ModeId_node_XDir, assetPath);
					variableCount += ModeId_node_XDir.SetData((FSMode)XDir, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.JumpsId:
					FSJumpsNode JumpsId_node_XDir = graph.AddNode<FSJumpsNode>();
					GetPort("XDir").Connect(JumpsId_node_XDir.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(JumpsId_node_XDir, assetPath);
					variableCount += JumpsId_node_XDir.SetData((FSJumps)XDir, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RootAnimId:
					FSRootAnimNode RootAnimId_node_XDir = graph.AddNode<FSRootAnimNode>();
					GetPort("XDir").Connect(RootAnimId_node_XDir.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RootAnimId_node_XDir, assetPath);
					variableCount += RootAnimId_node_XDir.SetData((FSRootAnim)XDir, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FloatId:
					FSValueNode FloatId_node_XDir = graph.AddNode<FSValueNode>();
					GetPort("XDir").Connect(FloatId_node_XDir.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FloatId_node_XDir, assetPath);
					variableCount += FloatId_node_XDir.SetData((FSValue)XDir, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
			}
			++variableCount;
			
			YDir = data.YDir;
			
			switch (YDir.TID)
			{
				case FloatSource.TypeId.AgentId:
					FSAgentNode AgentId_node_YDir = graph.AddNode<FSAgentNode>();
					GetPort("YDir").Connect(AgentId_node_YDir.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AgentId_node_YDir, assetPath);
					variableCount += AgentId_node_YDir.SetData((FSAgent)YDir, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.BonesId:
					FSBonesNode BonesId_node_YDir = graph.AddNode<FSBonesNode>();
					GetPort("YDir").Connect(BonesId_node_YDir.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BonesId_node_YDir, assetPath);
					variableCount += BonesId_node_YDir.SetData((FSBones)YDir, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AttackId:
					FSAttackNode AttackId_node_YDir = graph.AddNode<FSAttackNode>();
					GetPort("YDir").Connect(AttackId_node_YDir.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AttackId_node_YDir, assetPath);
					variableCount += AttackId_node_YDir.SetData((FSAttack)YDir, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FrameId:
					FSFrameNode FrameId_node_YDir = graph.AddNode<FSFrameNode>();
					GetPort("YDir").Connect(FrameId_node_YDir.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FrameId_node_YDir, assetPath);
					variableCount += FrameId_node_YDir.SetData((FSFrame)YDir, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.InputId:
					FSInputNode InputId_node_YDir = graph.AddNode<FSInputNode>();
					GetPort("YDir").Connect(InputId_node_YDir.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputId_node_YDir, assetPath);
					variableCount += InputId_node_YDir.SetData((FSInput)YDir, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FuncId:
					FSFuncNode FuncId_node_YDir = graph.AddNode<FSFuncNode>();
					GetPort("YDir").Connect(FuncId_node_YDir.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FuncId_node_YDir, assetPath);
					variableCount += FuncId_node_YDir.SetData((FSFunc)YDir, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.MovementId:
					FSMovementNode MovementId_node_YDir = graph.AddNode<FSMovementNode>();
					GetPort("YDir").Connect(MovementId_node_YDir.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(MovementId_node_YDir, assetPath);
					variableCount += MovementId_node_YDir.SetData((FSMovement)YDir, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CombatId:
					FSCombatNode CombatId_node_YDir = graph.AddNode<FSCombatNode>();
					GetPort("YDir").Connect(CombatId_node_YDir.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CombatId_node_YDir, assetPath);
					variableCount += CombatId_node_YDir.SetData((FSCombat)YDir, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.GrabsId:
					FSGrabsNode GrabsId_node_YDir = graph.AddNode<FSGrabsNode>();
					GetPort("YDir").Connect(GrabsId_node_YDir.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(GrabsId_node_YDir, assetPath);
					variableCount += GrabsId_node_YDir.SetData((FSGrabs)YDir, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.DataId:
					FSDataNode DataId_node_YDir = graph.AddNode<FSDataNode>();
					GetPort("YDir").Connect(DataId_node_YDir.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DataId_node_YDir, assetPath);
					variableCount += DataId_node_YDir.SetData((FSData)YDir, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ScratchId:
					FSScratchNode ScratchId_node_YDir = graph.AddNode<FSScratchNode>();
					GetPort("YDir").Connect(ScratchId_node_YDir.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ScratchId_node_YDir, assetPath);
					variableCount += ScratchId_node_YDir.SetData((FSScratch)YDir, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AnimId:
					FSAnimNode AnimId_node_YDir = graph.AddNode<FSAnimNode>();
					GetPort("YDir").Connect(AnimId_node_YDir.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AnimId_node_YDir, assetPath);
					variableCount += AnimId_node_YDir.SetData((FSAnim)YDir, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SpeedId:
					FSSpeedNode SpeedId_node_YDir = graph.AddNode<FSSpeedNode>();
					GetPort("YDir").Connect(SpeedId_node_YDir.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpeedId_node_YDir, assetPath);
					variableCount += SpeedId_node_YDir.SetData((FSSpeed)YDir, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.PhysicsId:
					FSPhysicsNode PhysicsId_node_YDir = graph.AddNode<FSPhysicsNode>();
					GetPort("YDir").Connect(PhysicsId_node_YDir.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(PhysicsId_node_YDir, assetPath);
					variableCount += PhysicsId_node_YDir.SetData((FSPhysics)YDir, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CollisionId:
					FSCollisionNode CollisionId_node_YDir = graph.AddNode<FSCollisionNode>();
					GetPort("YDir").Connect(CollisionId_node_YDir.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CollisionId_node_YDir, assetPath);
					variableCount += CollisionId_node_YDir.SetData((FSCollision)YDir, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.TimerId:
					FSTimerNode TimerId_node_YDir = graph.AddNode<FSTimerNode>();
					GetPort("YDir").Connect(TimerId_node_YDir.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(TimerId_node_YDir, assetPath);
					variableCount += TimerId_node_YDir.SetData((FSTimer)YDir, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.LagId:
					FSLagNode LagId_node_YDir = graph.AddNode<FSLagNode>();
					GetPort("YDir").Connect(LagId_node_YDir.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LagId_node_YDir, assetPath);
					variableCount += LagId_node_YDir.SetData((FSLag)YDir, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.EffectsId:
					FSEffectsNode EffectsId_node_YDir = graph.AddNode<FSEffectsNode>();
					GetPort("YDir").Connect(EffectsId_node_YDir.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EffectsId_node_YDir, assetPath);
					variableCount += EffectsId_node_YDir.SetData((FSEffects)YDir, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ColorsId:
					FSColorsNode ColorsId_node_YDir = graph.AddNode<FSColorsNode>();
					GetPort("YDir").Connect(ColorsId_node_YDir.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ColorsId_node_YDir, assetPath);
					variableCount += ColorsId_node_YDir.SetData((FSColors)YDir, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.OnHitId:
					FSOnHitNode OnHitId_node_YDir = graph.AddNode<FSOnHitNode>();
					GetPort("YDir").Connect(OnHitId_node_YDir.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnHitId_node_YDir, assetPath);
					variableCount += OnHitId_node_YDir.SetData((FSOnHit)YDir, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RandomId:
					FSRandomNode RandomId_node_YDir = graph.AddNode<FSRandomNode>();
					GetPort("YDir").Connect(RandomId_node_YDir.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RandomId_node_YDir, assetPath);
					variableCount += RandomId_node_YDir.SetData((FSRandom)YDir, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CameraId:
					FSCameraInfoNode CameraId_node_YDir = graph.AddNode<FSCameraInfoNode>();
					GetPort("YDir").Connect(CameraId_node_YDir.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CameraId_node_YDir, assetPath);
					variableCount += CameraId_node_YDir.SetData((FSCameraInfo)YDir, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SportsId:
					FSSportsNode SportsId_node_YDir = graph.AddNode<FSSportsNode>();
					GetPort("YDir").Connect(SportsId_node_YDir.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SportsId_node_YDir, assetPath);
					variableCount += SportsId_node_YDir.SetData((FSSports)YDir, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.Vector2Mag:
					FSVector2MagNode Vector2Mag_node_YDir = graph.AddNode<FSVector2MagNode>();
					GetPort("YDir").Connect(Vector2Mag_node_YDir.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(Vector2Mag_node_YDir, assetPath);
					variableCount += Vector2Mag_node_YDir.SetData((FSVector2Mag)YDir, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CPUHelpId:
					FSCpuHelpNode CPUHelpId_node_YDir = graph.AddNode<FSCpuHelpNode>();
					GetPort("YDir").Connect(CPUHelpId_node_YDir.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CPUHelpId_node_YDir, assetPath);
					variableCount += CPUHelpId_node_YDir.SetData((FSCpuHelp)YDir, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ItemId:
					FSItemNode ItemId_node_YDir = graph.AddNode<FSItemNode>();
					GetPort("YDir").Connect(ItemId_node_YDir.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ItemId_node_YDir, assetPath);
					variableCount += ItemId_node_YDir.SetData((FSItem)YDir, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ModeId:
					FSModeNode ModeId_node_YDir = graph.AddNode<FSModeNode>();
					GetPort("YDir").Connect(ModeId_node_YDir.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ModeId_node_YDir, assetPath);
					variableCount += ModeId_node_YDir.SetData((FSMode)YDir, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.JumpsId:
					FSJumpsNode JumpsId_node_YDir = graph.AddNode<FSJumpsNode>();
					GetPort("YDir").Connect(JumpsId_node_YDir.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(JumpsId_node_YDir, assetPath);
					variableCount += JumpsId_node_YDir.SetData((FSJumps)YDir, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RootAnimId:
					FSRootAnimNode RootAnimId_node_YDir = graph.AddNode<FSRootAnimNode>();
					GetPort("YDir").Connect(RootAnimId_node_YDir.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RootAnimId_node_YDir, assetPath);
					variableCount += RootAnimId_node_YDir.SetData((FSRootAnim)YDir, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FloatId:
					FSValueNode FloatId_node_YDir = graph.AddNode<FSValueNode>();
					GetPort("YDir").Connect(FloatId_node_YDir.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FloatId_node_YDir, assetPath);
					variableCount += FloatId_node_YDir.SetData((FSValue)YDir, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
			}
			++variableCount;
			
			SpeedStart = data.SpeedStart;
			
			switch (SpeedStart.TID)
			{
				case FloatSource.TypeId.AgentId:
					FSAgentNode AgentId_node_SpeedStart = graph.AddNode<FSAgentNode>();
					GetPort("SpeedStart").Connect(AgentId_node_SpeedStart.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AgentId_node_SpeedStart, assetPath);
					variableCount += AgentId_node_SpeedStart.SetData((FSAgent)SpeedStart, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.BonesId:
					FSBonesNode BonesId_node_SpeedStart = graph.AddNode<FSBonesNode>();
					GetPort("SpeedStart").Connect(BonesId_node_SpeedStart.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BonesId_node_SpeedStart, assetPath);
					variableCount += BonesId_node_SpeedStart.SetData((FSBones)SpeedStart, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AttackId:
					FSAttackNode AttackId_node_SpeedStart = graph.AddNode<FSAttackNode>();
					GetPort("SpeedStart").Connect(AttackId_node_SpeedStart.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AttackId_node_SpeedStart, assetPath);
					variableCount += AttackId_node_SpeedStart.SetData((FSAttack)SpeedStart, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FrameId:
					FSFrameNode FrameId_node_SpeedStart = graph.AddNode<FSFrameNode>();
					GetPort("SpeedStart").Connect(FrameId_node_SpeedStart.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FrameId_node_SpeedStart, assetPath);
					variableCount += FrameId_node_SpeedStart.SetData((FSFrame)SpeedStart, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.InputId:
					FSInputNode InputId_node_SpeedStart = graph.AddNode<FSInputNode>();
					GetPort("SpeedStart").Connect(InputId_node_SpeedStart.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputId_node_SpeedStart, assetPath);
					variableCount += InputId_node_SpeedStart.SetData((FSInput)SpeedStart, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FuncId:
					FSFuncNode FuncId_node_SpeedStart = graph.AddNode<FSFuncNode>();
					GetPort("SpeedStart").Connect(FuncId_node_SpeedStart.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FuncId_node_SpeedStart, assetPath);
					variableCount += FuncId_node_SpeedStart.SetData((FSFunc)SpeedStart, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.MovementId:
					FSMovementNode MovementId_node_SpeedStart = graph.AddNode<FSMovementNode>();
					GetPort("SpeedStart").Connect(MovementId_node_SpeedStart.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(MovementId_node_SpeedStart, assetPath);
					variableCount += MovementId_node_SpeedStart.SetData((FSMovement)SpeedStart, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CombatId:
					FSCombatNode CombatId_node_SpeedStart = graph.AddNode<FSCombatNode>();
					GetPort("SpeedStart").Connect(CombatId_node_SpeedStart.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CombatId_node_SpeedStart, assetPath);
					variableCount += CombatId_node_SpeedStart.SetData((FSCombat)SpeedStart, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.GrabsId:
					FSGrabsNode GrabsId_node_SpeedStart = graph.AddNode<FSGrabsNode>();
					GetPort("SpeedStart").Connect(GrabsId_node_SpeedStart.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(GrabsId_node_SpeedStart, assetPath);
					variableCount += GrabsId_node_SpeedStart.SetData((FSGrabs)SpeedStart, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.DataId:
					FSDataNode DataId_node_SpeedStart = graph.AddNode<FSDataNode>();
					GetPort("SpeedStart").Connect(DataId_node_SpeedStart.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DataId_node_SpeedStart, assetPath);
					variableCount += DataId_node_SpeedStart.SetData((FSData)SpeedStart, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ScratchId:
					FSScratchNode ScratchId_node_SpeedStart = graph.AddNode<FSScratchNode>();
					GetPort("SpeedStart").Connect(ScratchId_node_SpeedStart.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ScratchId_node_SpeedStart, assetPath);
					variableCount += ScratchId_node_SpeedStart.SetData((FSScratch)SpeedStart, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AnimId:
					FSAnimNode AnimId_node_SpeedStart = graph.AddNode<FSAnimNode>();
					GetPort("SpeedStart").Connect(AnimId_node_SpeedStart.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AnimId_node_SpeedStart, assetPath);
					variableCount += AnimId_node_SpeedStart.SetData((FSAnim)SpeedStart, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SpeedId:
					FSSpeedNode SpeedId_node_SpeedStart = graph.AddNode<FSSpeedNode>();
					GetPort("SpeedStart").Connect(SpeedId_node_SpeedStart.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpeedId_node_SpeedStart, assetPath);
					variableCount += SpeedId_node_SpeedStart.SetData((FSSpeed)SpeedStart, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.PhysicsId:
					FSPhysicsNode PhysicsId_node_SpeedStart = graph.AddNode<FSPhysicsNode>();
					GetPort("SpeedStart").Connect(PhysicsId_node_SpeedStart.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(PhysicsId_node_SpeedStart, assetPath);
					variableCount += PhysicsId_node_SpeedStart.SetData((FSPhysics)SpeedStart, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CollisionId:
					FSCollisionNode CollisionId_node_SpeedStart = graph.AddNode<FSCollisionNode>();
					GetPort("SpeedStart").Connect(CollisionId_node_SpeedStart.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CollisionId_node_SpeedStart, assetPath);
					variableCount += CollisionId_node_SpeedStart.SetData((FSCollision)SpeedStart, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.TimerId:
					FSTimerNode TimerId_node_SpeedStart = graph.AddNode<FSTimerNode>();
					GetPort("SpeedStart").Connect(TimerId_node_SpeedStart.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(TimerId_node_SpeedStart, assetPath);
					variableCount += TimerId_node_SpeedStart.SetData((FSTimer)SpeedStart, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.LagId:
					FSLagNode LagId_node_SpeedStart = graph.AddNode<FSLagNode>();
					GetPort("SpeedStart").Connect(LagId_node_SpeedStart.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LagId_node_SpeedStart, assetPath);
					variableCount += LagId_node_SpeedStart.SetData((FSLag)SpeedStart, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.EffectsId:
					FSEffectsNode EffectsId_node_SpeedStart = graph.AddNode<FSEffectsNode>();
					GetPort("SpeedStart").Connect(EffectsId_node_SpeedStart.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EffectsId_node_SpeedStart, assetPath);
					variableCount += EffectsId_node_SpeedStart.SetData((FSEffects)SpeedStart, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ColorsId:
					FSColorsNode ColorsId_node_SpeedStart = graph.AddNode<FSColorsNode>();
					GetPort("SpeedStart").Connect(ColorsId_node_SpeedStart.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ColorsId_node_SpeedStart, assetPath);
					variableCount += ColorsId_node_SpeedStart.SetData((FSColors)SpeedStart, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.OnHitId:
					FSOnHitNode OnHitId_node_SpeedStart = graph.AddNode<FSOnHitNode>();
					GetPort("SpeedStart").Connect(OnHitId_node_SpeedStart.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnHitId_node_SpeedStart, assetPath);
					variableCount += OnHitId_node_SpeedStart.SetData((FSOnHit)SpeedStart, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RandomId:
					FSRandomNode RandomId_node_SpeedStart = graph.AddNode<FSRandomNode>();
					GetPort("SpeedStart").Connect(RandomId_node_SpeedStart.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RandomId_node_SpeedStart, assetPath);
					variableCount += RandomId_node_SpeedStart.SetData((FSRandom)SpeedStart, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CameraId:
					FSCameraInfoNode CameraId_node_SpeedStart = graph.AddNode<FSCameraInfoNode>();
					GetPort("SpeedStart").Connect(CameraId_node_SpeedStart.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CameraId_node_SpeedStart, assetPath);
					variableCount += CameraId_node_SpeedStart.SetData((FSCameraInfo)SpeedStart, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SportsId:
					FSSportsNode SportsId_node_SpeedStart = graph.AddNode<FSSportsNode>();
					GetPort("SpeedStart").Connect(SportsId_node_SpeedStart.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SportsId_node_SpeedStart, assetPath);
					variableCount += SportsId_node_SpeedStart.SetData((FSSports)SpeedStart, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.Vector2Mag:
					FSVector2MagNode Vector2Mag_node_SpeedStart = graph.AddNode<FSVector2MagNode>();
					GetPort("SpeedStart").Connect(Vector2Mag_node_SpeedStart.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(Vector2Mag_node_SpeedStart, assetPath);
					variableCount += Vector2Mag_node_SpeedStart.SetData((FSVector2Mag)SpeedStart, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CPUHelpId:
					FSCpuHelpNode CPUHelpId_node_SpeedStart = graph.AddNode<FSCpuHelpNode>();
					GetPort("SpeedStart").Connect(CPUHelpId_node_SpeedStart.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CPUHelpId_node_SpeedStart, assetPath);
					variableCount += CPUHelpId_node_SpeedStart.SetData((FSCpuHelp)SpeedStart, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ItemId:
					FSItemNode ItemId_node_SpeedStart = graph.AddNode<FSItemNode>();
					GetPort("SpeedStart").Connect(ItemId_node_SpeedStart.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ItemId_node_SpeedStart, assetPath);
					variableCount += ItemId_node_SpeedStart.SetData((FSItem)SpeedStart, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ModeId:
					FSModeNode ModeId_node_SpeedStart = graph.AddNode<FSModeNode>();
					GetPort("SpeedStart").Connect(ModeId_node_SpeedStart.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ModeId_node_SpeedStart, assetPath);
					variableCount += ModeId_node_SpeedStart.SetData((FSMode)SpeedStart, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.JumpsId:
					FSJumpsNode JumpsId_node_SpeedStart = graph.AddNode<FSJumpsNode>();
					GetPort("SpeedStart").Connect(JumpsId_node_SpeedStart.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(JumpsId_node_SpeedStart, assetPath);
					variableCount += JumpsId_node_SpeedStart.SetData((FSJumps)SpeedStart, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RootAnimId:
					FSRootAnimNode RootAnimId_node_SpeedStart = graph.AddNode<FSRootAnimNode>();
					GetPort("SpeedStart").Connect(RootAnimId_node_SpeedStart.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RootAnimId_node_SpeedStart, assetPath);
					variableCount += RootAnimId_node_SpeedStart.SetData((FSRootAnim)SpeedStart, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FloatId:
					FSValueNode FloatId_node_SpeedStart = graph.AddNode<FSValueNode>();
					GetPort("SpeedStart").Connect(FloatId_node_SpeedStart.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FloatId_node_SpeedStart, assetPath);
					variableCount += FloatId_node_SpeedStart.SetData((FSValue)SpeedStart, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
			}
			++variableCount;
			
			SpeedEnd = data.SpeedEnd;
			
			switch (SpeedEnd.TID)
			{
				case FloatSource.TypeId.AgentId:
					FSAgentNode AgentId_node_SpeedEnd = graph.AddNode<FSAgentNode>();
					GetPort("SpeedEnd").Connect(AgentId_node_SpeedEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AgentId_node_SpeedEnd, assetPath);
					variableCount += AgentId_node_SpeedEnd.SetData((FSAgent)SpeedEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.BonesId:
					FSBonesNode BonesId_node_SpeedEnd = graph.AddNode<FSBonesNode>();
					GetPort("SpeedEnd").Connect(BonesId_node_SpeedEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BonesId_node_SpeedEnd, assetPath);
					variableCount += BonesId_node_SpeedEnd.SetData((FSBones)SpeedEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AttackId:
					FSAttackNode AttackId_node_SpeedEnd = graph.AddNode<FSAttackNode>();
					GetPort("SpeedEnd").Connect(AttackId_node_SpeedEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AttackId_node_SpeedEnd, assetPath);
					variableCount += AttackId_node_SpeedEnd.SetData((FSAttack)SpeedEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FrameId:
					FSFrameNode FrameId_node_SpeedEnd = graph.AddNode<FSFrameNode>();
					GetPort("SpeedEnd").Connect(FrameId_node_SpeedEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FrameId_node_SpeedEnd, assetPath);
					variableCount += FrameId_node_SpeedEnd.SetData((FSFrame)SpeedEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.InputId:
					FSInputNode InputId_node_SpeedEnd = graph.AddNode<FSInputNode>();
					GetPort("SpeedEnd").Connect(InputId_node_SpeedEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputId_node_SpeedEnd, assetPath);
					variableCount += InputId_node_SpeedEnd.SetData((FSInput)SpeedEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FuncId:
					FSFuncNode FuncId_node_SpeedEnd = graph.AddNode<FSFuncNode>();
					GetPort("SpeedEnd").Connect(FuncId_node_SpeedEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FuncId_node_SpeedEnd, assetPath);
					variableCount += FuncId_node_SpeedEnd.SetData((FSFunc)SpeedEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.MovementId:
					FSMovementNode MovementId_node_SpeedEnd = graph.AddNode<FSMovementNode>();
					GetPort("SpeedEnd").Connect(MovementId_node_SpeedEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(MovementId_node_SpeedEnd, assetPath);
					variableCount += MovementId_node_SpeedEnd.SetData((FSMovement)SpeedEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CombatId:
					FSCombatNode CombatId_node_SpeedEnd = graph.AddNode<FSCombatNode>();
					GetPort("SpeedEnd").Connect(CombatId_node_SpeedEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CombatId_node_SpeedEnd, assetPath);
					variableCount += CombatId_node_SpeedEnd.SetData((FSCombat)SpeedEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.GrabsId:
					FSGrabsNode GrabsId_node_SpeedEnd = graph.AddNode<FSGrabsNode>();
					GetPort("SpeedEnd").Connect(GrabsId_node_SpeedEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(GrabsId_node_SpeedEnd, assetPath);
					variableCount += GrabsId_node_SpeedEnd.SetData((FSGrabs)SpeedEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.DataId:
					FSDataNode DataId_node_SpeedEnd = graph.AddNode<FSDataNode>();
					GetPort("SpeedEnd").Connect(DataId_node_SpeedEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DataId_node_SpeedEnd, assetPath);
					variableCount += DataId_node_SpeedEnd.SetData((FSData)SpeedEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ScratchId:
					FSScratchNode ScratchId_node_SpeedEnd = graph.AddNode<FSScratchNode>();
					GetPort("SpeedEnd").Connect(ScratchId_node_SpeedEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ScratchId_node_SpeedEnd, assetPath);
					variableCount += ScratchId_node_SpeedEnd.SetData((FSScratch)SpeedEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AnimId:
					FSAnimNode AnimId_node_SpeedEnd = graph.AddNode<FSAnimNode>();
					GetPort("SpeedEnd").Connect(AnimId_node_SpeedEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AnimId_node_SpeedEnd, assetPath);
					variableCount += AnimId_node_SpeedEnd.SetData((FSAnim)SpeedEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SpeedId:
					FSSpeedNode SpeedId_node_SpeedEnd = graph.AddNode<FSSpeedNode>();
					GetPort("SpeedEnd").Connect(SpeedId_node_SpeedEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpeedId_node_SpeedEnd, assetPath);
					variableCount += SpeedId_node_SpeedEnd.SetData((FSSpeed)SpeedEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.PhysicsId:
					FSPhysicsNode PhysicsId_node_SpeedEnd = graph.AddNode<FSPhysicsNode>();
					GetPort("SpeedEnd").Connect(PhysicsId_node_SpeedEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(PhysicsId_node_SpeedEnd, assetPath);
					variableCount += PhysicsId_node_SpeedEnd.SetData((FSPhysics)SpeedEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CollisionId:
					FSCollisionNode CollisionId_node_SpeedEnd = graph.AddNode<FSCollisionNode>();
					GetPort("SpeedEnd").Connect(CollisionId_node_SpeedEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CollisionId_node_SpeedEnd, assetPath);
					variableCount += CollisionId_node_SpeedEnd.SetData((FSCollision)SpeedEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.TimerId:
					FSTimerNode TimerId_node_SpeedEnd = graph.AddNode<FSTimerNode>();
					GetPort("SpeedEnd").Connect(TimerId_node_SpeedEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(TimerId_node_SpeedEnd, assetPath);
					variableCount += TimerId_node_SpeedEnd.SetData((FSTimer)SpeedEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.LagId:
					FSLagNode LagId_node_SpeedEnd = graph.AddNode<FSLagNode>();
					GetPort("SpeedEnd").Connect(LagId_node_SpeedEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LagId_node_SpeedEnd, assetPath);
					variableCount += LagId_node_SpeedEnd.SetData((FSLag)SpeedEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.EffectsId:
					FSEffectsNode EffectsId_node_SpeedEnd = graph.AddNode<FSEffectsNode>();
					GetPort("SpeedEnd").Connect(EffectsId_node_SpeedEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EffectsId_node_SpeedEnd, assetPath);
					variableCount += EffectsId_node_SpeedEnd.SetData((FSEffects)SpeedEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ColorsId:
					FSColorsNode ColorsId_node_SpeedEnd = graph.AddNode<FSColorsNode>();
					GetPort("SpeedEnd").Connect(ColorsId_node_SpeedEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ColorsId_node_SpeedEnd, assetPath);
					variableCount += ColorsId_node_SpeedEnd.SetData((FSColors)SpeedEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.OnHitId:
					FSOnHitNode OnHitId_node_SpeedEnd = graph.AddNode<FSOnHitNode>();
					GetPort("SpeedEnd").Connect(OnHitId_node_SpeedEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnHitId_node_SpeedEnd, assetPath);
					variableCount += OnHitId_node_SpeedEnd.SetData((FSOnHit)SpeedEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RandomId:
					FSRandomNode RandomId_node_SpeedEnd = graph.AddNode<FSRandomNode>();
					GetPort("SpeedEnd").Connect(RandomId_node_SpeedEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RandomId_node_SpeedEnd, assetPath);
					variableCount += RandomId_node_SpeedEnd.SetData((FSRandom)SpeedEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CameraId:
					FSCameraInfoNode CameraId_node_SpeedEnd = graph.AddNode<FSCameraInfoNode>();
					GetPort("SpeedEnd").Connect(CameraId_node_SpeedEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CameraId_node_SpeedEnd, assetPath);
					variableCount += CameraId_node_SpeedEnd.SetData((FSCameraInfo)SpeedEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SportsId:
					FSSportsNode SportsId_node_SpeedEnd = graph.AddNode<FSSportsNode>();
					GetPort("SpeedEnd").Connect(SportsId_node_SpeedEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SportsId_node_SpeedEnd, assetPath);
					variableCount += SportsId_node_SpeedEnd.SetData((FSSports)SpeedEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.Vector2Mag:
					FSVector2MagNode Vector2Mag_node_SpeedEnd = graph.AddNode<FSVector2MagNode>();
					GetPort("SpeedEnd").Connect(Vector2Mag_node_SpeedEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(Vector2Mag_node_SpeedEnd, assetPath);
					variableCount += Vector2Mag_node_SpeedEnd.SetData((FSVector2Mag)SpeedEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CPUHelpId:
					FSCpuHelpNode CPUHelpId_node_SpeedEnd = graph.AddNode<FSCpuHelpNode>();
					GetPort("SpeedEnd").Connect(CPUHelpId_node_SpeedEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CPUHelpId_node_SpeedEnd, assetPath);
					variableCount += CPUHelpId_node_SpeedEnd.SetData((FSCpuHelp)SpeedEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ItemId:
					FSItemNode ItemId_node_SpeedEnd = graph.AddNode<FSItemNode>();
					GetPort("SpeedEnd").Connect(ItemId_node_SpeedEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ItemId_node_SpeedEnd, assetPath);
					variableCount += ItemId_node_SpeedEnd.SetData((FSItem)SpeedEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ModeId:
					FSModeNode ModeId_node_SpeedEnd = graph.AddNode<FSModeNode>();
					GetPort("SpeedEnd").Connect(ModeId_node_SpeedEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ModeId_node_SpeedEnd, assetPath);
					variableCount += ModeId_node_SpeedEnd.SetData((FSMode)SpeedEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.JumpsId:
					FSJumpsNode JumpsId_node_SpeedEnd = graph.AddNode<FSJumpsNode>();
					GetPort("SpeedEnd").Connect(JumpsId_node_SpeedEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(JumpsId_node_SpeedEnd, assetPath);
					variableCount += JumpsId_node_SpeedEnd.SetData((FSJumps)SpeedEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RootAnimId:
					FSRootAnimNode RootAnimId_node_SpeedEnd = graph.AddNode<FSRootAnimNode>();
					GetPort("SpeedEnd").Connect(RootAnimId_node_SpeedEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RootAnimId_node_SpeedEnd, assetPath);
					variableCount += RootAnimId_node_SpeedEnd.SetData((FSRootAnim)SpeedEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FloatId:
					FSValueNode FloatId_node_SpeedEnd = graph.AddNode<FSValueNode>();
					GetPort("SpeedEnd").Connect(FloatId_node_SpeedEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FloatId_node_SpeedEnd, assetPath);
					variableCount += FloatId_node_SpeedEnd.SetData((FSValue)SpeedEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
			}
			++variableCount;
			
			SpeedUpMult = data.SpeedUpMult;
			
			switch (SpeedUpMult.TID)
			{
				case FloatSource.TypeId.AgentId:
					FSAgentNode AgentId_node_SpeedUpMult = graph.AddNode<FSAgentNode>();
					GetPort("SpeedUpMult").Connect(AgentId_node_SpeedUpMult.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AgentId_node_SpeedUpMult, assetPath);
					variableCount += AgentId_node_SpeedUpMult.SetData((FSAgent)SpeedUpMult, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.BonesId:
					FSBonesNode BonesId_node_SpeedUpMult = graph.AddNode<FSBonesNode>();
					GetPort("SpeedUpMult").Connect(BonesId_node_SpeedUpMult.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BonesId_node_SpeedUpMult, assetPath);
					variableCount += BonesId_node_SpeedUpMult.SetData((FSBones)SpeedUpMult, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AttackId:
					FSAttackNode AttackId_node_SpeedUpMult = graph.AddNode<FSAttackNode>();
					GetPort("SpeedUpMult").Connect(AttackId_node_SpeedUpMult.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AttackId_node_SpeedUpMult, assetPath);
					variableCount += AttackId_node_SpeedUpMult.SetData((FSAttack)SpeedUpMult, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FrameId:
					FSFrameNode FrameId_node_SpeedUpMult = graph.AddNode<FSFrameNode>();
					GetPort("SpeedUpMult").Connect(FrameId_node_SpeedUpMult.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FrameId_node_SpeedUpMult, assetPath);
					variableCount += FrameId_node_SpeedUpMult.SetData((FSFrame)SpeedUpMult, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.InputId:
					FSInputNode InputId_node_SpeedUpMult = graph.AddNode<FSInputNode>();
					GetPort("SpeedUpMult").Connect(InputId_node_SpeedUpMult.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputId_node_SpeedUpMult, assetPath);
					variableCount += InputId_node_SpeedUpMult.SetData((FSInput)SpeedUpMult, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FuncId:
					FSFuncNode FuncId_node_SpeedUpMult = graph.AddNode<FSFuncNode>();
					GetPort("SpeedUpMult").Connect(FuncId_node_SpeedUpMult.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FuncId_node_SpeedUpMult, assetPath);
					variableCount += FuncId_node_SpeedUpMult.SetData((FSFunc)SpeedUpMult, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.MovementId:
					FSMovementNode MovementId_node_SpeedUpMult = graph.AddNode<FSMovementNode>();
					GetPort("SpeedUpMult").Connect(MovementId_node_SpeedUpMult.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(MovementId_node_SpeedUpMult, assetPath);
					variableCount += MovementId_node_SpeedUpMult.SetData((FSMovement)SpeedUpMult, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CombatId:
					FSCombatNode CombatId_node_SpeedUpMult = graph.AddNode<FSCombatNode>();
					GetPort("SpeedUpMult").Connect(CombatId_node_SpeedUpMult.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CombatId_node_SpeedUpMult, assetPath);
					variableCount += CombatId_node_SpeedUpMult.SetData((FSCombat)SpeedUpMult, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.GrabsId:
					FSGrabsNode GrabsId_node_SpeedUpMult = graph.AddNode<FSGrabsNode>();
					GetPort("SpeedUpMult").Connect(GrabsId_node_SpeedUpMult.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(GrabsId_node_SpeedUpMult, assetPath);
					variableCount += GrabsId_node_SpeedUpMult.SetData((FSGrabs)SpeedUpMult, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.DataId:
					FSDataNode DataId_node_SpeedUpMult = graph.AddNode<FSDataNode>();
					GetPort("SpeedUpMult").Connect(DataId_node_SpeedUpMult.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DataId_node_SpeedUpMult, assetPath);
					variableCount += DataId_node_SpeedUpMult.SetData((FSData)SpeedUpMult, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ScratchId:
					FSScratchNode ScratchId_node_SpeedUpMult = graph.AddNode<FSScratchNode>();
					GetPort("SpeedUpMult").Connect(ScratchId_node_SpeedUpMult.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ScratchId_node_SpeedUpMult, assetPath);
					variableCount += ScratchId_node_SpeedUpMult.SetData((FSScratch)SpeedUpMult, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AnimId:
					FSAnimNode AnimId_node_SpeedUpMult = graph.AddNode<FSAnimNode>();
					GetPort("SpeedUpMult").Connect(AnimId_node_SpeedUpMult.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AnimId_node_SpeedUpMult, assetPath);
					variableCount += AnimId_node_SpeedUpMult.SetData((FSAnim)SpeedUpMult, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SpeedId:
					FSSpeedNode SpeedId_node_SpeedUpMult = graph.AddNode<FSSpeedNode>();
					GetPort("SpeedUpMult").Connect(SpeedId_node_SpeedUpMult.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpeedId_node_SpeedUpMult, assetPath);
					variableCount += SpeedId_node_SpeedUpMult.SetData((FSSpeed)SpeedUpMult, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.PhysicsId:
					FSPhysicsNode PhysicsId_node_SpeedUpMult = graph.AddNode<FSPhysicsNode>();
					GetPort("SpeedUpMult").Connect(PhysicsId_node_SpeedUpMult.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(PhysicsId_node_SpeedUpMult, assetPath);
					variableCount += PhysicsId_node_SpeedUpMult.SetData((FSPhysics)SpeedUpMult, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CollisionId:
					FSCollisionNode CollisionId_node_SpeedUpMult = graph.AddNode<FSCollisionNode>();
					GetPort("SpeedUpMult").Connect(CollisionId_node_SpeedUpMult.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CollisionId_node_SpeedUpMult, assetPath);
					variableCount += CollisionId_node_SpeedUpMult.SetData((FSCollision)SpeedUpMult, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.TimerId:
					FSTimerNode TimerId_node_SpeedUpMult = graph.AddNode<FSTimerNode>();
					GetPort("SpeedUpMult").Connect(TimerId_node_SpeedUpMult.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(TimerId_node_SpeedUpMult, assetPath);
					variableCount += TimerId_node_SpeedUpMult.SetData((FSTimer)SpeedUpMult, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.LagId:
					FSLagNode LagId_node_SpeedUpMult = graph.AddNode<FSLagNode>();
					GetPort("SpeedUpMult").Connect(LagId_node_SpeedUpMult.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LagId_node_SpeedUpMult, assetPath);
					variableCount += LagId_node_SpeedUpMult.SetData((FSLag)SpeedUpMult, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.EffectsId:
					FSEffectsNode EffectsId_node_SpeedUpMult = graph.AddNode<FSEffectsNode>();
					GetPort("SpeedUpMult").Connect(EffectsId_node_SpeedUpMult.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EffectsId_node_SpeedUpMult, assetPath);
					variableCount += EffectsId_node_SpeedUpMult.SetData((FSEffects)SpeedUpMult, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ColorsId:
					FSColorsNode ColorsId_node_SpeedUpMult = graph.AddNode<FSColorsNode>();
					GetPort("SpeedUpMult").Connect(ColorsId_node_SpeedUpMult.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ColorsId_node_SpeedUpMult, assetPath);
					variableCount += ColorsId_node_SpeedUpMult.SetData((FSColors)SpeedUpMult, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.OnHitId:
					FSOnHitNode OnHitId_node_SpeedUpMult = graph.AddNode<FSOnHitNode>();
					GetPort("SpeedUpMult").Connect(OnHitId_node_SpeedUpMult.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnHitId_node_SpeedUpMult, assetPath);
					variableCount += OnHitId_node_SpeedUpMult.SetData((FSOnHit)SpeedUpMult, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RandomId:
					FSRandomNode RandomId_node_SpeedUpMult = graph.AddNode<FSRandomNode>();
					GetPort("SpeedUpMult").Connect(RandomId_node_SpeedUpMult.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RandomId_node_SpeedUpMult, assetPath);
					variableCount += RandomId_node_SpeedUpMult.SetData((FSRandom)SpeedUpMult, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CameraId:
					FSCameraInfoNode CameraId_node_SpeedUpMult = graph.AddNode<FSCameraInfoNode>();
					GetPort("SpeedUpMult").Connect(CameraId_node_SpeedUpMult.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CameraId_node_SpeedUpMult, assetPath);
					variableCount += CameraId_node_SpeedUpMult.SetData((FSCameraInfo)SpeedUpMult, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SportsId:
					FSSportsNode SportsId_node_SpeedUpMult = graph.AddNode<FSSportsNode>();
					GetPort("SpeedUpMult").Connect(SportsId_node_SpeedUpMult.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SportsId_node_SpeedUpMult, assetPath);
					variableCount += SportsId_node_SpeedUpMult.SetData((FSSports)SpeedUpMult, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.Vector2Mag:
					FSVector2MagNode Vector2Mag_node_SpeedUpMult = graph.AddNode<FSVector2MagNode>();
					GetPort("SpeedUpMult").Connect(Vector2Mag_node_SpeedUpMult.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(Vector2Mag_node_SpeedUpMult, assetPath);
					variableCount += Vector2Mag_node_SpeedUpMult.SetData((FSVector2Mag)SpeedUpMult, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CPUHelpId:
					FSCpuHelpNode CPUHelpId_node_SpeedUpMult = graph.AddNode<FSCpuHelpNode>();
					GetPort("SpeedUpMult").Connect(CPUHelpId_node_SpeedUpMult.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CPUHelpId_node_SpeedUpMult, assetPath);
					variableCount += CPUHelpId_node_SpeedUpMult.SetData((FSCpuHelp)SpeedUpMult, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ItemId:
					FSItemNode ItemId_node_SpeedUpMult = graph.AddNode<FSItemNode>();
					GetPort("SpeedUpMult").Connect(ItemId_node_SpeedUpMult.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ItemId_node_SpeedUpMult, assetPath);
					variableCount += ItemId_node_SpeedUpMult.SetData((FSItem)SpeedUpMult, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ModeId:
					FSModeNode ModeId_node_SpeedUpMult = graph.AddNode<FSModeNode>();
					GetPort("SpeedUpMult").Connect(ModeId_node_SpeedUpMult.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ModeId_node_SpeedUpMult, assetPath);
					variableCount += ModeId_node_SpeedUpMult.SetData((FSMode)SpeedUpMult, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.JumpsId:
					FSJumpsNode JumpsId_node_SpeedUpMult = graph.AddNode<FSJumpsNode>();
					GetPort("SpeedUpMult").Connect(JumpsId_node_SpeedUpMult.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(JumpsId_node_SpeedUpMult, assetPath);
					variableCount += JumpsId_node_SpeedUpMult.SetData((FSJumps)SpeedUpMult, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RootAnimId:
					FSRootAnimNode RootAnimId_node_SpeedUpMult = graph.AddNode<FSRootAnimNode>();
					GetPort("SpeedUpMult").Connect(RootAnimId_node_SpeedUpMult.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RootAnimId_node_SpeedUpMult, assetPath);
					variableCount += RootAnimId_node_SpeedUpMult.SetData((FSRootAnim)SpeedUpMult, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FloatId:
					FSValueNode FloatId_node_SpeedUpMult = graph.AddNode<FSValueNode>();
					GetPort("SpeedUpMult").Connect(FloatId_node_SpeedUpMult.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FloatId_node_SpeedUpMult, assetPath);
					variableCount += FloatId_node_SpeedUpMult.SetData((FSValue)SpeedUpMult, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
			}
			++variableCount;
			
			SpeedDownMult = data.SpeedDownMult;
			
			switch (SpeedDownMult.TID)
			{
				case FloatSource.TypeId.AgentId:
					FSAgentNode AgentId_node_SpeedDownMult = graph.AddNode<FSAgentNode>();
					GetPort("SpeedDownMult").Connect(AgentId_node_SpeedDownMult.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AgentId_node_SpeedDownMult, assetPath);
					variableCount += AgentId_node_SpeedDownMult.SetData((FSAgent)SpeedDownMult, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.BonesId:
					FSBonesNode BonesId_node_SpeedDownMult = graph.AddNode<FSBonesNode>();
					GetPort("SpeedDownMult").Connect(BonesId_node_SpeedDownMult.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BonesId_node_SpeedDownMult, assetPath);
					variableCount += BonesId_node_SpeedDownMult.SetData((FSBones)SpeedDownMult, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AttackId:
					FSAttackNode AttackId_node_SpeedDownMult = graph.AddNode<FSAttackNode>();
					GetPort("SpeedDownMult").Connect(AttackId_node_SpeedDownMult.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AttackId_node_SpeedDownMult, assetPath);
					variableCount += AttackId_node_SpeedDownMult.SetData((FSAttack)SpeedDownMult, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FrameId:
					FSFrameNode FrameId_node_SpeedDownMult = graph.AddNode<FSFrameNode>();
					GetPort("SpeedDownMult").Connect(FrameId_node_SpeedDownMult.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FrameId_node_SpeedDownMult, assetPath);
					variableCount += FrameId_node_SpeedDownMult.SetData((FSFrame)SpeedDownMult, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.InputId:
					FSInputNode InputId_node_SpeedDownMult = graph.AddNode<FSInputNode>();
					GetPort("SpeedDownMult").Connect(InputId_node_SpeedDownMult.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputId_node_SpeedDownMult, assetPath);
					variableCount += InputId_node_SpeedDownMult.SetData((FSInput)SpeedDownMult, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FuncId:
					FSFuncNode FuncId_node_SpeedDownMult = graph.AddNode<FSFuncNode>();
					GetPort("SpeedDownMult").Connect(FuncId_node_SpeedDownMult.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FuncId_node_SpeedDownMult, assetPath);
					variableCount += FuncId_node_SpeedDownMult.SetData((FSFunc)SpeedDownMult, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.MovementId:
					FSMovementNode MovementId_node_SpeedDownMult = graph.AddNode<FSMovementNode>();
					GetPort("SpeedDownMult").Connect(MovementId_node_SpeedDownMult.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(MovementId_node_SpeedDownMult, assetPath);
					variableCount += MovementId_node_SpeedDownMult.SetData((FSMovement)SpeedDownMult, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CombatId:
					FSCombatNode CombatId_node_SpeedDownMult = graph.AddNode<FSCombatNode>();
					GetPort("SpeedDownMult").Connect(CombatId_node_SpeedDownMult.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CombatId_node_SpeedDownMult, assetPath);
					variableCount += CombatId_node_SpeedDownMult.SetData((FSCombat)SpeedDownMult, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.GrabsId:
					FSGrabsNode GrabsId_node_SpeedDownMult = graph.AddNode<FSGrabsNode>();
					GetPort("SpeedDownMult").Connect(GrabsId_node_SpeedDownMult.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(GrabsId_node_SpeedDownMult, assetPath);
					variableCount += GrabsId_node_SpeedDownMult.SetData((FSGrabs)SpeedDownMult, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.DataId:
					FSDataNode DataId_node_SpeedDownMult = graph.AddNode<FSDataNode>();
					GetPort("SpeedDownMult").Connect(DataId_node_SpeedDownMult.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DataId_node_SpeedDownMult, assetPath);
					variableCount += DataId_node_SpeedDownMult.SetData((FSData)SpeedDownMult, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ScratchId:
					FSScratchNode ScratchId_node_SpeedDownMult = graph.AddNode<FSScratchNode>();
					GetPort("SpeedDownMult").Connect(ScratchId_node_SpeedDownMult.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ScratchId_node_SpeedDownMult, assetPath);
					variableCount += ScratchId_node_SpeedDownMult.SetData((FSScratch)SpeedDownMult, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AnimId:
					FSAnimNode AnimId_node_SpeedDownMult = graph.AddNode<FSAnimNode>();
					GetPort("SpeedDownMult").Connect(AnimId_node_SpeedDownMult.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AnimId_node_SpeedDownMult, assetPath);
					variableCount += AnimId_node_SpeedDownMult.SetData((FSAnim)SpeedDownMult, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SpeedId:
					FSSpeedNode SpeedId_node_SpeedDownMult = graph.AddNode<FSSpeedNode>();
					GetPort("SpeedDownMult").Connect(SpeedId_node_SpeedDownMult.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpeedId_node_SpeedDownMult, assetPath);
					variableCount += SpeedId_node_SpeedDownMult.SetData((FSSpeed)SpeedDownMult, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.PhysicsId:
					FSPhysicsNode PhysicsId_node_SpeedDownMult = graph.AddNode<FSPhysicsNode>();
					GetPort("SpeedDownMult").Connect(PhysicsId_node_SpeedDownMult.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(PhysicsId_node_SpeedDownMult, assetPath);
					variableCount += PhysicsId_node_SpeedDownMult.SetData((FSPhysics)SpeedDownMult, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CollisionId:
					FSCollisionNode CollisionId_node_SpeedDownMult = graph.AddNode<FSCollisionNode>();
					GetPort("SpeedDownMult").Connect(CollisionId_node_SpeedDownMult.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CollisionId_node_SpeedDownMult, assetPath);
					variableCount += CollisionId_node_SpeedDownMult.SetData((FSCollision)SpeedDownMult, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.TimerId:
					FSTimerNode TimerId_node_SpeedDownMult = graph.AddNode<FSTimerNode>();
					GetPort("SpeedDownMult").Connect(TimerId_node_SpeedDownMult.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(TimerId_node_SpeedDownMult, assetPath);
					variableCount += TimerId_node_SpeedDownMult.SetData((FSTimer)SpeedDownMult, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.LagId:
					FSLagNode LagId_node_SpeedDownMult = graph.AddNode<FSLagNode>();
					GetPort("SpeedDownMult").Connect(LagId_node_SpeedDownMult.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LagId_node_SpeedDownMult, assetPath);
					variableCount += LagId_node_SpeedDownMult.SetData((FSLag)SpeedDownMult, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.EffectsId:
					FSEffectsNode EffectsId_node_SpeedDownMult = graph.AddNode<FSEffectsNode>();
					GetPort("SpeedDownMult").Connect(EffectsId_node_SpeedDownMult.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EffectsId_node_SpeedDownMult, assetPath);
					variableCount += EffectsId_node_SpeedDownMult.SetData((FSEffects)SpeedDownMult, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ColorsId:
					FSColorsNode ColorsId_node_SpeedDownMult = graph.AddNode<FSColorsNode>();
					GetPort("SpeedDownMult").Connect(ColorsId_node_SpeedDownMult.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ColorsId_node_SpeedDownMult, assetPath);
					variableCount += ColorsId_node_SpeedDownMult.SetData((FSColors)SpeedDownMult, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.OnHitId:
					FSOnHitNode OnHitId_node_SpeedDownMult = graph.AddNode<FSOnHitNode>();
					GetPort("SpeedDownMult").Connect(OnHitId_node_SpeedDownMult.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnHitId_node_SpeedDownMult, assetPath);
					variableCount += OnHitId_node_SpeedDownMult.SetData((FSOnHit)SpeedDownMult, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RandomId:
					FSRandomNode RandomId_node_SpeedDownMult = graph.AddNode<FSRandomNode>();
					GetPort("SpeedDownMult").Connect(RandomId_node_SpeedDownMult.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RandomId_node_SpeedDownMult, assetPath);
					variableCount += RandomId_node_SpeedDownMult.SetData((FSRandom)SpeedDownMult, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CameraId:
					FSCameraInfoNode CameraId_node_SpeedDownMult = graph.AddNode<FSCameraInfoNode>();
					GetPort("SpeedDownMult").Connect(CameraId_node_SpeedDownMult.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CameraId_node_SpeedDownMult, assetPath);
					variableCount += CameraId_node_SpeedDownMult.SetData((FSCameraInfo)SpeedDownMult, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SportsId:
					FSSportsNode SportsId_node_SpeedDownMult = graph.AddNode<FSSportsNode>();
					GetPort("SpeedDownMult").Connect(SportsId_node_SpeedDownMult.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SportsId_node_SpeedDownMult, assetPath);
					variableCount += SportsId_node_SpeedDownMult.SetData((FSSports)SpeedDownMult, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.Vector2Mag:
					FSVector2MagNode Vector2Mag_node_SpeedDownMult = graph.AddNode<FSVector2MagNode>();
					GetPort("SpeedDownMult").Connect(Vector2Mag_node_SpeedDownMult.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(Vector2Mag_node_SpeedDownMult, assetPath);
					variableCount += Vector2Mag_node_SpeedDownMult.SetData((FSVector2Mag)SpeedDownMult, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CPUHelpId:
					FSCpuHelpNode CPUHelpId_node_SpeedDownMult = graph.AddNode<FSCpuHelpNode>();
					GetPort("SpeedDownMult").Connect(CPUHelpId_node_SpeedDownMult.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CPUHelpId_node_SpeedDownMult, assetPath);
					variableCount += CPUHelpId_node_SpeedDownMult.SetData((FSCpuHelp)SpeedDownMult, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ItemId:
					FSItemNode ItemId_node_SpeedDownMult = graph.AddNode<FSItemNode>();
					GetPort("SpeedDownMult").Connect(ItemId_node_SpeedDownMult.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ItemId_node_SpeedDownMult, assetPath);
					variableCount += ItemId_node_SpeedDownMult.SetData((FSItem)SpeedDownMult, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ModeId:
					FSModeNode ModeId_node_SpeedDownMult = graph.AddNode<FSModeNode>();
					GetPort("SpeedDownMult").Connect(ModeId_node_SpeedDownMult.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ModeId_node_SpeedDownMult, assetPath);
					variableCount += ModeId_node_SpeedDownMult.SetData((FSMode)SpeedDownMult, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.JumpsId:
					FSJumpsNode JumpsId_node_SpeedDownMult = graph.AddNode<FSJumpsNode>();
					GetPort("SpeedDownMult").Connect(JumpsId_node_SpeedDownMult.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(JumpsId_node_SpeedDownMult, assetPath);
					variableCount += JumpsId_node_SpeedDownMult.SetData((FSJumps)SpeedDownMult, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RootAnimId:
					FSRootAnimNode RootAnimId_node_SpeedDownMult = graph.AddNode<FSRootAnimNode>();
					GetPort("SpeedDownMult").Connect(RootAnimId_node_SpeedDownMult.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RootAnimId_node_SpeedDownMult, assetPath);
					variableCount += RootAnimId_node_SpeedDownMult.SetData((FSRootAnim)SpeedDownMult, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FloatId:
					FSValueNode FloatId_node_SpeedDownMult = graph.AddNode<FSValueNode>();
					GetPort("SpeedDownMult").Connect(FloatId_node_SpeedDownMult.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FloatId_node_SpeedDownMult, assetPath);
					variableCount += FloatId_node_SpeedDownMult.SetData((FSValue)SpeedDownMult, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
			}
			++variableCount;
			
			Frames = data.Frames;
			
			switch (Frames.TID)
			{
				case FloatSource.TypeId.AgentId:
					FSAgentNode AgentId_node_Frames = graph.AddNode<FSAgentNode>();
					GetPort("Frames").Connect(AgentId_node_Frames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AgentId_node_Frames, assetPath);
					variableCount += AgentId_node_Frames.SetData((FSAgent)Frames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.BonesId:
					FSBonesNode BonesId_node_Frames = graph.AddNode<FSBonesNode>();
					GetPort("Frames").Connect(BonesId_node_Frames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BonesId_node_Frames, assetPath);
					variableCount += BonesId_node_Frames.SetData((FSBones)Frames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AttackId:
					FSAttackNode AttackId_node_Frames = graph.AddNode<FSAttackNode>();
					GetPort("Frames").Connect(AttackId_node_Frames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AttackId_node_Frames, assetPath);
					variableCount += AttackId_node_Frames.SetData((FSAttack)Frames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FrameId:
					FSFrameNode FrameId_node_Frames = graph.AddNode<FSFrameNode>();
					GetPort("Frames").Connect(FrameId_node_Frames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FrameId_node_Frames, assetPath);
					variableCount += FrameId_node_Frames.SetData((FSFrame)Frames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.InputId:
					FSInputNode InputId_node_Frames = graph.AddNode<FSInputNode>();
					GetPort("Frames").Connect(InputId_node_Frames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputId_node_Frames, assetPath);
					variableCount += InputId_node_Frames.SetData((FSInput)Frames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FuncId:
					FSFuncNode FuncId_node_Frames = graph.AddNode<FSFuncNode>();
					GetPort("Frames").Connect(FuncId_node_Frames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FuncId_node_Frames, assetPath);
					variableCount += FuncId_node_Frames.SetData((FSFunc)Frames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.MovementId:
					FSMovementNode MovementId_node_Frames = graph.AddNode<FSMovementNode>();
					GetPort("Frames").Connect(MovementId_node_Frames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(MovementId_node_Frames, assetPath);
					variableCount += MovementId_node_Frames.SetData((FSMovement)Frames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CombatId:
					FSCombatNode CombatId_node_Frames = graph.AddNode<FSCombatNode>();
					GetPort("Frames").Connect(CombatId_node_Frames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CombatId_node_Frames, assetPath);
					variableCount += CombatId_node_Frames.SetData((FSCombat)Frames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.GrabsId:
					FSGrabsNode GrabsId_node_Frames = graph.AddNode<FSGrabsNode>();
					GetPort("Frames").Connect(GrabsId_node_Frames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(GrabsId_node_Frames, assetPath);
					variableCount += GrabsId_node_Frames.SetData((FSGrabs)Frames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.DataId:
					FSDataNode DataId_node_Frames = graph.AddNode<FSDataNode>();
					GetPort("Frames").Connect(DataId_node_Frames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DataId_node_Frames, assetPath);
					variableCount += DataId_node_Frames.SetData((FSData)Frames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ScratchId:
					FSScratchNode ScratchId_node_Frames = graph.AddNode<FSScratchNode>();
					GetPort("Frames").Connect(ScratchId_node_Frames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ScratchId_node_Frames, assetPath);
					variableCount += ScratchId_node_Frames.SetData((FSScratch)Frames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AnimId:
					FSAnimNode AnimId_node_Frames = graph.AddNode<FSAnimNode>();
					GetPort("Frames").Connect(AnimId_node_Frames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AnimId_node_Frames, assetPath);
					variableCount += AnimId_node_Frames.SetData((FSAnim)Frames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SpeedId:
					FSSpeedNode SpeedId_node_Frames = graph.AddNode<FSSpeedNode>();
					GetPort("Frames").Connect(SpeedId_node_Frames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpeedId_node_Frames, assetPath);
					variableCount += SpeedId_node_Frames.SetData((FSSpeed)Frames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.PhysicsId:
					FSPhysicsNode PhysicsId_node_Frames = graph.AddNode<FSPhysicsNode>();
					GetPort("Frames").Connect(PhysicsId_node_Frames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(PhysicsId_node_Frames, assetPath);
					variableCount += PhysicsId_node_Frames.SetData((FSPhysics)Frames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CollisionId:
					FSCollisionNode CollisionId_node_Frames = graph.AddNode<FSCollisionNode>();
					GetPort("Frames").Connect(CollisionId_node_Frames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CollisionId_node_Frames, assetPath);
					variableCount += CollisionId_node_Frames.SetData((FSCollision)Frames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.TimerId:
					FSTimerNode TimerId_node_Frames = graph.AddNode<FSTimerNode>();
					GetPort("Frames").Connect(TimerId_node_Frames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(TimerId_node_Frames, assetPath);
					variableCount += TimerId_node_Frames.SetData((FSTimer)Frames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.LagId:
					FSLagNode LagId_node_Frames = graph.AddNode<FSLagNode>();
					GetPort("Frames").Connect(LagId_node_Frames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LagId_node_Frames, assetPath);
					variableCount += LagId_node_Frames.SetData((FSLag)Frames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.EffectsId:
					FSEffectsNode EffectsId_node_Frames = graph.AddNode<FSEffectsNode>();
					GetPort("Frames").Connect(EffectsId_node_Frames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EffectsId_node_Frames, assetPath);
					variableCount += EffectsId_node_Frames.SetData((FSEffects)Frames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ColorsId:
					FSColorsNode ColorsId_node_Frames = graph.AddNode<FSColorsNode>();
					GetPort("Frames").Connect(ColorsId_node_Frames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ColorsId_node_Frames, assetPath);
					variableCount += ColorsId_node_Frames.SetData((FSColors)Frames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.OnHitId:
					FSOnHitNode OnHitId_node_Frames = graph.AddNode<FSOnHitNode>();
					GetPort("Frames").Connect(OnHitId_node_Frames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnHitId_node_Frames, assetPath);
					variableCount += OnHitId_node_Frames.SetData((FSOnHit)Frames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RandomId:
					FSRandomNode RandomId_node_Frames = graph.AddNode<FSRandomNode>();
					GetPort("Frames").Connect(RandomId_node_Frames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RandomId_node_Frames, assetPath);
					variableCount += RandomId_node_Frames.SetData((FSRandom)Frames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CameraId:
					FSCameraInfoNode CameraId_node_Frames = graph.AddNode<FSCameraInfoNode>();
					GetPort("Frames").Connect(CameraId_node_Frames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CameraId_node_Frames, assetPath);
					variableCount += CameraId_node_Frames.SetData((FSCameraInfo)Frames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SportsId:
					FSSportsNode SportsId_node_Frames = graph.AddNode<FSSportsNode>();
					GetPort("Frames").Connect(SportsId_node_Frames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SportsId_node_Frames, assetPath);
					variableCount += SportsId_node_Frames.SetData((FSSports)Frames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.Vector2Mag:
					FSVector2MagNode Vector2Mag_node_Frames = graph.AddNode<FSVector2MagNode>();
					GetPort("Frames").Connect(Vector2Mag_node_Frames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(Vector2Mag_node_Frames, assetPath);
					variableCount += Vector2Mag_node_Frames.SetData((FSVector2Mag)Frames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CPUHelpId:
					FSCpuHelpNode CPUHelpId_node_Frames = graph.AddNode<FSCpuHelpNode>();
					GetPort("Frames").Connect(CPUHelpId_node_Frames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CPUHelpId_node_Frames, assetPath);
					variableCount += CPUHelpId_node_Frames.SetData((FSCpuHelp)Frames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ItemId:
					FSItemNode ItemId_node_Frames = graph.AddNode<FSItemNode>();
					GetPort("Frames").Connect(ItemId_node_Frames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ItemId_node_Frames, assetPath);
					variableCount += ItemId_node_Frames.SetData((FSItem)Frames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ModeId:
					FSModeNode ModeId_node_Frames = graph.AddNode<FSModeNode>();
					GetPort("Frames").Connect(ModeId_node_Frames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ModeId_node_Frames, assetPath);
					variableCount += ModeId_node_Frames.SetData((FSMode)Frames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.JumpsId:
					FSJumpsNode JumpsId_node_Frames = graph.AddNode<FSJumpsNode>();
					GetPort("Frames").Connect(JumpsId_node_Frames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(JumpsId_node_Frames, assetPath);
					variableCount += JumpsId_node_Frames.SetData((FSJumps)Frames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RootAnimId:
					FSRootAnimNode RootAnimId_node_Frames = graph.AddNode<FSRootAnimNode>();
					GetPort("Frames").Connect(RootAnimId_node_Frames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RootAnimId_node_Frames, assetPath);
					variableCount += RootAnimId_node_Frames.SetData((FSRootAnim)Frames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FloatId:
					FSValueNode FloatId_node_Frames = graph.AddNode<FSValueNode>();
					GetPort("Frames").Connect(FloatId_node_Frames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FloatId_node_Frames, assetPath);
					variableCount += FloatId_node_Frames.SetData((FSValue)Frames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
			}
			++variableCount;
			
			RedirectFrames = data.RedirectFrames;
			
			switch (RedirectFrames.TID)
			{
				case FloatSource.TypeId.AgentId:
					FSAgentNode AgentId_node_RedirectFrames = graph.AddNode<FSAgentNode>();
					GetPort("RedirectFrames").Connect(AgentId_node_RedirectFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AgentId_node_RedirectFrames, assetPath);
					variableCount += AgentId_node_RedirectFrames.SetData((FSAgent)RedirectFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.BonesId:
					FSBonesNode BonesId_node_RedirectFrames = graph.AddNode<FSBonesNode>();
					GetPort("RedirectFrames").Connect(BonesId_node_RedirectFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BonesId_node_RedirectFrames, assetPath);
					variableCount += BonesId_node_RedirectFrames.SetData((FSBones)RedirectFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AttackId:
					FSAttackNode AttackId_node_RedirectFrames = graph.AddNode<FSAttackNode>();
					GetPort("RedirectFrames").Connect(AttackId_node_RedirectFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AttackId_node_RedirectFrames, assetPath);
					variableCount += AttackId_node_RedirectFrames.SetData((FSAttack)RedirectFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FrameId:
					FSFrameNode FrameId_node_RedirectFrames = graph.AddNode<FSFrameNode>();
					GetPort("RedirectFrames").Connect(FrameId_node_RedirectFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FrameId_node_RedirectFrames, assetPath);
					variableCount += FrameId_node_RedirectFrames.SetData((FSFrame)RedirectFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.InputId:
					FSInputNode InputId_node_RedirectFrames = graph.AddNode<FSInputNode>();
					GetPort("RedirectFrames").Connect(InputId_node_RedirectFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputId_node_RedirectFrames, assetPath);
					variableCount += InputId_node_RedirectFrames.SetData((FSInput)RedirectFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FuncId:
					FSFuncNode FuncId_node_RedirectFrames = graph.AddNode<FSFuncNode>();
					GetPort("RedirectFrames").Connect(FuncId_node_RedirectFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FuncId_node_RedirectFrames, assetPath);
					variableCount += FuncId_node_RedirectFrames.SetData((FSFunc)RedirectFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.MovementId:
					FSMovementNode MovementId_node_RedirectFrames = graph.AddNode<FSMovementNode>();
					GetPort("RedirectFrames").Connect(MovementId_node_RedirectFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(MovementId_node_RedirectFrames, assetPath);
					variableCount += MovementId_node_RedirectFrames.SetData((FSMovement)RedirectFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CombatId:
					FSCombatNode CombatId_node_RedirectFrames = graph.AddNode<FSCombatNode>();
					GetPort("RedirectFrames").Connect(CombatId_node_RedirectFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CombatId_node_RedirectFrames, assetPath);
					variableCount += CombatId_node_RedirectFrames.SetData((FSCombat)RedirectFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.GrabsId:
					FSGrabsNode GrabsId_node_RedirectFrames = graph.AddNode<FSGrabsNode>();
					GetPort("RedirectFrames").Connect(GrabsId_node_RedirectFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(GrabsId_node_RedirectFrames, assetPath);
					variableCount += GrabsId_node_RedirectFrames.SetData((FSGrabs)RedirectFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.DataId:
					FSDataNode DataId_node_RedirectFrames = graph.AddNode<FSDataNode>();
					GetPort("RedirectFrames").Connect(DataId_node_RedirectFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DataId_node_RedirectFrames, assetPath);
					variableCount += DataId_node_RedirectFrames.SetData((FSData)RedirectFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ScratchId:
					FSScratchNode ScratchId_node_RedirectFrames = graph.AddNode<FSScratchNode>();
					GetPort("RedirectFrames").Connect(ScratchId_node_RedirectFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ScratchId_node_RedirectFrames, assetPath);
					variableCount += ScratchId_node_RedirectFrames.SetData((FSScratch)RedirectFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AnimId:
					FSAnimNode AnimId_node_RedirectFrames = graph.AddNode<FSAnimNode>();
					GetPort("RedirectFrames").Connect(AnimId_node_RedirectFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AnimId_node_RedirectFrames, assetPath);
					variableCount += AnimId_node_RedirectFrames.SetData((FSAnim)RedirectFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SpeedId:
					FSSpeedNode SpeedId_node_RedirectFrames = graph.AddNode<FSSpeedNode>();
					GetPort("RedirectFrames").Connect(SpeedId_node_RedirectFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpeedId_node_RedirectFrames, assetPath);
					variableCount += SpeedId_node_RedirectFrames.SetData((FSSpeed)RedirectFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.PhysicsId:
					FSPhysicsNode PhysicsId_node_RedirectFrames = graph.AddNode<FSPhysicsNode>();
					GetPort("RedirectFrames").Connect(PhysicsId_node_RedirectFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(PhysicsId_node_RedirectFrames, assetPath);
					variableCount += PhysicsId_node_RedirectFrames.SetData((FSPhysics)RedirectFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CollisionId:
					FSCollisionNode CollisionId_node_RedirectFrames = graph.AddNode<FSCollisionNode>();
					GetPort("RedirectFrames").Connect(CollisionId_node_RedirectFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CollisionId_node_RedirectFrames, assetPath);
					variableCount += CollisionId_node_RedirectFrames.SetData((FSCollision)RedirectFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.TimerId:
					FSTimerNode TimerId_node_RedirectFrames = graph.AddNode<FSTimerNode>();
					GetPort("RedirectFrames").Connect(TimerId_node_RedirectFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(TimerId_node_RedirectFrames, assetPath);
					variableCount += TimerId_node_RedirectFrames.SetData((FSTimer)RedirectFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.LagId:
					FSLagNode LagId_node_RedirectFrames = graph.AddNode<FSLagNode>();
					GetPort("RedirectFrames").Connect(LagId_node_RedirectFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LagId_node_RedirectFrames, assetPath);
					variableCount += LagId_node_RedirectFrames.SetData((FSLag)RedirectFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.EffectsId:
					FSEffectsNode EffectsId_node_RedirectFrames = graph.AddNode<FSEffectsNode>();
					GetPort("RedirectFrames").Connect(EffectsId_node_RedirectFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EffectsId_node_RedirectFrames, assetPath);
					variableCount += EffectsId_node_RedirectFrames.SetData((FSEffects)RedirectFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ColorsId:
					FSColorsNode ColorsId_node_RedirectFrames = graph.AddNode<FSColorsNode>();
					GetPort("RedirectFrames").Connect(ColorsId_node_RedirectFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ColorsId_node_RedirectFrames, assetPath);
					variableCount += ColorsId_node_RedirectFrames.SetData((FSColors)RedirectFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.OnHitId:
					FSOnHitNode OnHitId_node_RedirectFrames = graph.AddNode<FSOnHitNode>();
					GetPort("RedirectFrames").Connect(OnHitId_node_RedirectFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnHitId_node_RedirectFrames, assetPath);
					variableCount += OnHitId_node_RedirectFrames.SetData((FSOnHit)RedirectFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RandomId:
					FSRandomNode RandomId_node_RedirectFrames = graph.AddNode<FSRandomNode>();
					GetPort("RedirectFrames").Connect(RandomId_node_RedirectFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RandomId_node_RedirectFrames, assetPath);
					variableCount += RandomId_node_RedirectFrames.SetData((FSRandom)RedirectFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CameraId:
					FSCameraInfoNode CameraId_node_RedirectFrames = graph.AddNode<FSCameraInfoNode>();
					GetPort("RedirectFrames").Connect(CameraId_node_RedirectFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CameraId_node_RedirectFrames, assetPath);
					variableCount += CameraId_node_RedirectFrames.SetData((FSCameraInfo)RedirectFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SportsId:
					FSSportsNode SportsId_node_RedirectFrames = graph.AddNode<FSSportsNode>();
					GetPort("RedirectFrames").Connect(SportsId_node_RedirectFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SportsId_node_RedirectFrames, assetPath);
					variableCount += SportsId_node_RedirectFrames.SetData((FSSports)RedirectFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.Vector2Mag:
					FSVector2MagNode Vector2Mag_node_RedirectFrames = graph.AddNode<FSVector2MagNode>();
					GetPort("RedirectFrames").Connect(Vector2Mag_node_RedirectFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(Vector2Mag_node_RedirectFrames, assetPath);
					variableCount += Vector2Mag_node_RedirectFrames.SetData((FSVector2Mag)RedirectFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CPUHelpId:
					FSCpuHelpNode CPUHelpId_node_RedirectFrames = graph.AddNode<FSCpuHelpNode>();
					GetPort("RedirectFrames").Connect(CPUHelpId_node_RedirectFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CPUHelpId_node_RedirectFrames, assetPath);
					variableCount += CPUHelpId_node_RedirectFrames.SetData((FSCpuHelp)RedirectFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ItemId:
					FSItemNode ItemId_node_RedirectFrames = graph.AddNode<FSItemNode>();
					GetPort("RedirectFrames").Connect(ItemId_node_RedirectFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ItemId_node_RedirectFrames, assetPath);
					variableCount += ItemId_node_RedirectFrames.SetData((FSItem)RedirectFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ModeId:
					FSModeNode ModeId_node_RedirectFrames = graph.AddNode<FSModeNode>();
					GetPort("RedirectFrames").Connect(ModeId_node_RedirectFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ModeId_node_RedirectFrames, assetPath);
					variableCount += ModeId_node_RedirectFrames.SetData((FSMode)RedirectFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.JumpsId:
					FSJumpsNode JumpsId_node_RedirectFrames = graph.AddNode<FSJumpsNode>();
					GetPort("RedirectFrames").Connect(JumpsId_node_RedirectFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(JumpsId_node_RedirectFrames, assetPath);
					variableCount += JumpsId_node_RedirectFrames.SetData((FSJumps)RedirectFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RootAnimId:
					FSRootAnimNode RootAnimId_node_RedirectFrames = graph.AddNode<FSRootAnimNode>();
					GetPort("RedirectFrames").Connect(RootAnimId_node_RedirectFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RootAnimId_node_RedirectFrames, assetPath);
					variableCount += RootAnimId_node_RedirectFrames.SetData((FSRootAnim)RedirectFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FloatId:
					FSValueNode FloatId_node_RedirectFrames = graph.AddNode<FSValueNode>();
					GetPort("RedirectFrames").Connect(FloatId_node_RedirectFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FloatId_node_RedirectFrames, assetPath);
					variableCount += FloatId_node_RedirectFrames.SetData((FSValue)RedirectFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
			}
			
			return variableCount;
		}
		
		public new AirDashJump GetData()
		{
			AirDashJump objToReturn = new AirDashJump();
			objToReturn.TID = TypeId.AirdashId;
			objToReturn.Version = Version;
			objToReturn.EaseSpeed = EaseSpeed;
			if (GetPort("XDir").ConnectionCount > 0)
			{
				FloatSourceNode FloatSource_Node = (FloatSourceNode)GetPort("XDir").GetConnection(0).node;
				switch (FloatSource_Node.TID)
				{
					case FloatSource.TypeId.AgentId:
						FSAgentNode AgentId_FloatSource_Node = (FSAgentNode)GetPort("XDir").GetConnection(0).node;
						objToReturn.XDir = AgentId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.BonesId:
						FSBonesNode BonesId_FloatSource_Node = (FSBonesNode)GetPort("XDir").GetConnection(0).node;
						objToReturn.XDir = BonesId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AttackId:
						FSAttackNode AttackId_FloatSource_Node = (FSAttackNode)GetPort("XDir").GetConnection(0).node;
						objToReturn.XDir = AttackId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FrameId:
						FSFrameNode FrameId_FloatSource_Node = (FSFrameNode)GetPort("XDir").GetConnection(0).node;
						objToReturn.XDir = FrameId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.InputId:
						FSInputNode InputId_FloatSource_Node = (FSInputNode)GetPort("XDir").GetConnection(0).node;
						objToReturn.XDir = InputId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FuncId:
						FSFuncNode FuncId_FloatSource_Node = (FSFuncNode)GetPort("XDir").GetConnection(0).node;
						objToReturn.XDir = FuncId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.MovementId:
						FSMovementNode MovementId_FloatSource_Node = (FSMovementNode)GetPort("XDir").GetConnection(0).node;
						objToReturn.XDir = MovementId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CombatId:
						FSCombatNode CombatId_FloatSource_Node = (FSCombatNode)GetPort("XDir").GetConnection(0).node;
						objToReturn.XDir = CombatId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.GrabsId:
						FSGrabsNode GrabsId_FloatSource_Node = (FSGrabsNode)GetPort("XDir").GetConnection(0).node;
						objToReturn.XDir = GrabsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.DataId:
						FSDataNode DataId_FloatSource_Node = (FSDataNode)GetPort("XDir").GetConnection(0).node;
						objToReturn.XDir = DataId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ScratchId:
						FSScratchNode ScratchId_FloatSource_Node = (FSScratchNode)GetPort("XDir").GetConnection(0).node;
						objToReturn.XDir = ScratchId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AnimId:
						FSAnimNode AnimId_FloatSource_Node = (FSAnimNode)GetPort("XDir").GetConnection(0).node;
						objToReturn.XDir = AnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SpeedId:
						FSSpeedNode SpeedId_FloatSource_Node = (FSSpeedNode)GetPort("XDir").GetConnection(0).node;
						objToReturn.XDir = SpeedId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.PhysicsId:
						FSPhysicsNode PhysicsId_FloatSource_Node = (FSPhysicsNode)GetPort("XDir").GetConnection(0).node;
						objToReturn.XDir = PhysicsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CollisionId:
						FSCollisionNode CollisionId_FloatSource_Node = (FSCollisionNode)GetPort("XDir").GetConnection(0).node;
						objToReturn.XDir = CollisionId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.TimerId:
						FSTimerNode TimerId_FloatSource_Node = (FSTimerNode)GetPort("XDir").GetConnection(0).node;
						objToReturn.XDir = TimerId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.LagId:
						FSLagNode LagId_FloatSource_Node = (FSLagNode)GetPort("XDir").GetConnection(0).node;
						objToReturn.XDir = LagId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.EffectsId:
						FSEffectsNode EffectsId_FloatSource_Node = (FSEffectsNode)GetPort("XDir").GetConnection(0).node;
						objToReturn.XDir = EffectsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ColorsId:
						FSColorsNode ColorsId_FloatSource_Node = (FSColorsNode)GetPort("XDir").GetConnection(0).node;
						objToReturn.XDir = ColorsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.OnHitId:
						FSOnHitNode OnHitId_FloatSource_Node = (FSOnHitNode)GetPort("XDir").GetConnection(0).node;
						objToReturn.XDir = OnHitId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RandomId:
						FSRandomNode RandomId_FloatSource_Node = (FSRandomNode)GetPort("XDir").GetConnection(0).node;
						objToReturn.XDir = RandomId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CameraId:
						FSCameraInfoNode CameraId_FloatSource_Node = (FSCameraInfoNode)GetPort("XDir").GetConnection(0).node;
						objToReturn.XDir = CameraId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SportsId:
						FSSportsNode SportsId_FloatSource_Node = (FSSportsNode)GetPort("XDir").GetConnection(0).node;
						objToReturn.XDir = SportsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.Vector2Mag:
						FSVector2MagNode Vector2Mag_FloatSource_Node = (FSVector2MagNode)GetPort("XDir").GetConnection(0).node;
						objToReturn.XDir = Vector2Mag_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CPUHelpId:
						FSCpuHelpNode CPUHelpId_FloatSource_Node = (FSCpuHelpNode)GetPort("XDir").GetConnection(0).node;
						objToReturn.XDir = CPUHelpId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ItemId:
						FSItemNode ItemId_FloatSource_Node = (FSItemNode)GetPort("XDir").GetConnection(0).node;
						objToReturn.XDir = ItemId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ModeId:
						FSModeNode ModeId_FloatSource_Node = (FSModeNode)GetPort("XDir").GetConnection(0).node;
						objToReturn.XDir = ModeId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.JumpsId:
						FSJumpsNode JumpsId_FloatSource_Node = (FSJumpsNode)GetPort("XDir").GetConnection(0).node;
						objToReturn.XDir = JumpsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RootAnimId:
						FSRootAnimNode RootAnimId_FloatSource_Node = (FSRootAnimNode)GetPort("XDir").GetConnection(0).node;
						objToReturn.XDir = RootAnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FloatId:
						FSValueNode FloatId_FloatSource_Node = (FSValueNode)GetPort("XDir").GetConnection(0).node;
						objToReturn.XDir = FloatId_FloatSource_Node.GetData();
					break;
				}
			}
			if (GetPort("YDir").ConnectionCount > 0)
			{
				FloatSourceNode FloatSource_Node = (FloatSourceNode)GetPort("YDir").GetConnection(0).node;
				switch (FloatSource_Node.TID)
				{
					case FloatSource.TypeId.AgentId:
						FSAgentNode AgentId_FloatSource_Node = (FSAgentNode)GetPort("YDir").GetConnection(0).node;
						objToReturn.YDir = AgentId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.BonesId:
						FSBonesNode BonesId_FloatSource_Node = (FSBonesNode)GetPort("YDir").GetConnection(0).node;
						objToReturn.YDir = BonesId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AttackId:
						FSAttackNode AttackId_FloatSource_Node = (FSAttackNode)GetPort("YDir").GetConnection(0).node;
						objToReturn.YDir = AttackId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FrameId:
						FSFrameNode FrameId_FloatSource_Node = (FSFrameNode)GetPort("YDir").GetConnection(0).node;
						objToReturn.YDir = FrameId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.InputId:
						FSInputNode InputId_FloatSource_Node = (FSInputNode)GetPort("YDir").GetConnection(0).node;
						objToReturn.YDir = InputId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FuncId:
						FSFuncNode FuncId_FloatSource_Node = (FSFuncNode)GetPort("YDir").GetConnection(0).node;
						objToReturn.YDir = FuncId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.MovementId:
						FSMovementNode MovementId_FloatSource_Node = (FSMovementNode)GetPort("YDir").GetConnection(0).node;
						objToReturn.YDir = MovementId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CombatId:
						FSCombatNode CombatId_FloatSource_Node = (FSCombatNode)GetPort("YDir").GetConnection(0).node;
						objToReturn.YDir = CombatId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.GrabsId:
						FSGrabsNode GrabsId_FloatSource_Node = (FSGrabsNode)GetPort("YDir").GetConnection(0).node;
						objToReturn.YDir = GrabsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.DataId:
						FSDataNode DataId_FloatSource_Node = (FSDataNode)GetPort("YDir").GetConnection(0).node;
						objToReturn.YDir = DataId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ScratchId:
						FSScratchNode ScratchId_FloatSource_Node = (FSScratchNode)GetPort("YDir").GetConnection(0).node;
						objToReturn.YDir = ScratchId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AnimId:
						FSAnimNode AnimId_FloatSource_Node = (FSAnimNode)GetPort("YDir").GetConnection(0).node;
						objToReturn.YDir = AnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SpeedId:
						FSSpeedNode SpeedId_FloatSource_Node = (FSSpeedNode)GetPort("YDir").GetConnection(0).node;
						objToReturn.YDir = SpeedId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.PhysicsId:
						FSPhysicsNode PhysicsId_FloatSource_Node = (FSPhysicsNode)GetPort("YDir").GetConnection(0).node;
						objToReturn.YDir = PhysicsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CollisionId:
						FSCollisionNode CollisionId_FloatSource_Node = (FSCollisionNode)GetPort("YDir").GetConnection(0).node;
						objToReturn.YDir = CollisionId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.TimerId:
						FSTimerNode TimerId_FloatSource_Node = (FSTimerNode)GetPort("YDir").GetConnection(0).node;
						objToReturn.YDir = TimerId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.LagId:
						FSLagNode LagId_FloatSource_Node = (FSLagNode)GetPort("YDir").GetConnection(0).node;
						objToReturn.YDir = LagId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.EffectsId:
						FSEffectsNode EffectsId_FloatSource_Node = (FSEffectsNode)GetPort("YDir").GetConnection(0).node;
						objToReturn.YDir = EffectsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ColorsId:
						FSColorsNode ColorsId_FloatSource_Node = (FSColorsNode)GetPort("YDir").GetConnection(0).node;
						objToReturn.YDir = ColorsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.OnHitId:
						FSOnHitNode OnHitId_FloatSource_Node = (FSOnHitNode)GetPort("YDir").GetConnection(0).node;
						objToReturn.YDir = OnHitId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RandomId:
						FSRandomNode RandomId_FloatSource_Node = (FSRandomNode)GetPort("YDir").GetConnection(0).node;
						objToReturn.YDir = RandomId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CameraId:
						FSCameraInfoNode CameraId_FloatSource_Node = (FSCameraInfoNode)GetPort("YDir").GetConnection(0).node;
						objToReturn.YDir = CameraId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SportsId:
						FSSportsNode SportsId_FloatSource_Node = (FSSportsNode)GetPort("YDir").GetConnection(0).node;
						objToReturn.YDir = SportsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.Vector2Mag:
						FSVector2MagNode Vector2Mag_FloatSource_Node = (FSVector2MagNode)GetPort("YDir").GetConnection(0).node;
						objToReturn.YDir = Vector2Mag_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CPUHelpId:
						FSCpuHelpNode CPUHelpId_FloatSource_Node = (FSCpuHelpNode)GetPort("YDir").GetConnection(0).node;
						objToReturn.YDir = CPUHelpId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ItemId:
						FSItemNode ItemId_FloatSource_Node = (FSItemNode)GetPort("YDir").GetConnection(0).node;
						objToReturn.YDir = ItemId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ModeId:
						FSModeNode ModeId_FloatSource_Node = (FSModeNode)GetPort("YDir").GetConnection(0).node;
						objToReturn.YDir = ModeId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.JumpsId:
						FSJumpsNode JumpsId_FloatSource_Node = (FSJumpsNode)GetPort("YDir").GetConnection(0).node;
						objToReturn.YDir = JumpsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RootAnimId:
						FSRootAnimNode RootAnimId_FloatSource_Node = (FSRootAnimNode)GetPort("YDir").GetConnection(0).node;
						objToReturn.YDir = RootAnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FloatId:
						FSValueNode FloatId_FloatSource_Node = (FSValueNode)GetPort("YDir").GetConnection(0).node;
						objToReturn.YDir = FloatId_FloatSource_Node.GetData();
					break;
				}
			}
			if (GetPort("SpeedStart").ConnectionCount > 0)
			{
				FloatSourceNode FloatSource_Node = (FloatSourceNode)GetPort("SpeedStart").GetConnection(0).node;
				switch (FloatSource_Node.TID)
				{
					case FloatSource.TypeId.AgentId:
						FSAgentNode AgentId_FloatSource_Node = (FSAgentNode)GetPort("SpeedStart").GetConnection(0).node;
						objToReturn.SpeedStart = AgentId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.BonesId:
						FSBonesNode BonesId_FloatSource_Node = (FSBonesNode)GetPort("SpeedStart").GetConnection(0).node;
						objToReturn.SpeedStart = BonesId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AttackId:
						FSAttackNode AttackId_FloatSource_Node = (FSAttackNode)GetPort("SpeedStart").GetConnection(0).node;
						objToReturn.SpeedStart = AttackId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FrameId:
						FSFrameNode FrameId_FloatSource_Node = (FSFrameNode)GetPort("SpeedStart").GetConnection(0).node;
						objToReturn.SpeedStart = FrameId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.InputId:
						FSInputNode InputId_FloatSource_Node = (FSInputNode)GetPort("SpeedStart").GetConnection(0).node;
						objToReturn.SpeedStart = InputId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FuncId:
						FSFuncNode FuncId_FloatSource_Node = (FSFuncNode)GetPort("SpeedStart").GetConnection(0).node;
						objToReturn.SpeedStart = FuncId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.MovementId:
						FSMovementNode MovementId_FloatSource_Node = (FSMovementNode)GetPort("SpeedStart").GetConnection(0).node;
						objToReturn.SpeedStart = MovementId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CombatId:
						FSCombatNode CombatId_FloatSource_Node = (FSCombatNode)GetPort("SpeedStart").GetConnection(0).node;
						objToReturn.SpeedStart = CombatId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.GrabsId:
						FSGrabsNode GrabsId_FloatSource_Node = (FSGrabsNode)GetPort("SpeedStart").GetConnection(0).node;
						objToReturn.SpeedStart = GrabsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.DataId:
						FSDataNode DataId_FloatSource_Node = (FSDataNode)GetPort("SpeedStart").GetConnection(0).node;
						objToReturn.SpeedStart = DataId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ScratchId:
						FSScratchNode ScratchId_FloatSource_Node = (FSScratchNode)GetPort("SpeedStart").GetConnection(0).node;
						objToReturn.SpeedStart = ScratchId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AnimId:
						FSAnimNode AnimId_FloatSource_Node = (FSAnimNode)GetPort("SpeedStart").GetConnection(0).node;
						objToReturn.SpeedStart = AnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SpeedId:
						FSSpeedNode SpeedId_FloatSource_Node = (FSSpeedNode)GetPort("SpeedStart").GetConnection(0).node;
						objToReturn.SpeedStart = SpeedId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.PhysicsId:
						FSPhysicsNode PhysicsId_FloatSource_Node = (FSPhysicsNode)GetPort("SpeedStart").GetConnection(0).node;
						objToReturn.SpeedStart = PhysicsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CollisionId:
						FSCollisionNode CollisionId_FloatSource_Node = (FSCollisionNode)GetPort("SpeedStart").GetConnection(0).node;
						objToReturn.SpeedStart = CollisionId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.TimerId:
						FSTimerNode TimerId_FloatSource_Node = (FSTimerNode)GetPort("SpeedStart").GetConnection(0).node;
						objToReturn.SpeedStart = TimerId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.LagId:
						FSLagNode LagId_FloatSource_Node = (FSLagNode)GetPort("SpeedStart").GetConnection(0).node;
						objToReturn.SpeedStart = LagId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.EffectsId:
						FSEffectsNode EffectsId_FloatSource_Node = (FSEffectsNode)GetPort("SpeedStart").GetConnection(0).node;
						objToReturn.SpeedStart = EffectsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ColorsId:
						FSColorsNode ColorsId_FloatSource_Node = (FSColorsNode)GetPort("SpeedStart").GetConnection(0).node;
						objToReturn.SpeedStart = ColorsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.OnHitId:
						FSOnHitNode OnHitId_FloatSource_Node = (FSOnHitNode)GetPort("SpeedStart").GetConnection(0).node;
						objToReturn.SpeedStart = OnHitId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RandomId:
						FSRandomNode RandomId_FloatSource_Node = (FSRandomNode)GetPort("SpeedStart").GetConnection(0).node;
						objToReturn.SpeedStart = RandomId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CameraId:
						FSCameraInfoNode CameraId_FloatSource_Node = (FSCameraInfoNode)GetPort("SpeedStart").GetConnection(0).node;
						objToReturn.SpeedStart = CameraId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SportsId:
						FSSportsNode SportsId_FloatSource_Node = (FSSportsNode)GetPort("SpeedStart").GetConnection(0).node;
						objToReturn.SpeedStart = SportsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.Vector2Mag:
						FSVector2MagNode Vector2Mag_FloatSource_Node = (FSVector2MagNode)GetPort("SpeedStart").GetConnection(0).node;
						objToReturn.SpeedStart = Vector2Mag_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CPUHelpId:
						FSCpuHelpNode CPUHelpId_FloatSource_Node = (FSCpuHelpNode)GetPort("SpeedStart").GetConnection(0).node;
						objToReturn.SpeedStart = CPUHelpId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ItemId:
						FSItemNode ItemId_FloatSource_Node = (FSItemNode)GetPort("SpeedStart").GetConnection(0).node;
						objToReturn.SpeedStart = ItemId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ModeId:
						FSModeNode ModeId_FloatSource_Node = (FSModeNode)GetPort("SpeedStart").GetConnection(0).node;
						objToReturn.SpeedStart = ModeId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.JumpsId:
						FSJumpsNode JumpsId_FloatSource_Node = (FSJumpsNode)GetPort("SpeedStart").GetConnection(0).node;
						objToReturn.SpeedStart = JumpsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RootAnimId:
						FSRootAnimNode RootAnimId_FloatSource_Node = (FSRootAnimNode)GetPort("SpeedStart").GetConnection(0).node;
						objToReturn.SpeedStart = RootAnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FloatId:
						FSValueNode FloatId_FloatSource_Node = (FSValueNode)GetPort("SpeedStart").GetConnection(0).node;
						objToReturn.SpeedStart = FloatId_FloatSource_Node.GetData();
					break;
				}
			}
			if (GetPort("SpeedEnd").ConnectionCount > 0)
			{
				FloatSourceNode FloatSource_Node = (FloatSourceNode)GetPort("SpeedEnd").GetConnection(0).node;
				switch (FloatSource_Node.TID)
				{
					case FloatSource.TypeId.AgentId:
						FSAgentNode AgentId_FloatSource_Node = (FSAgentNode)GetPort("SpeedEnd").GetConnection(0).node;
						objToReturn.SpeedEnd = AgentId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.BonesId:
						FSBonesNode BonesId_FloatSource_Node = (FSBonesNode)GetPort("SpeedEnd").GetConnection(0).node;
						objToReturn.SpeedEnd = BonesId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AttackId:
						FSAttackNode AttackId_FloatSource_Node = (FSAttackNode)GetPort("SpeedEnd").GetConnection(0).node;
						objToReturn.SpeedEnd = AttackId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FrameId:
						FSFrameNode FrameId_FloatSource_Node = (FSFrameNode)GetPort("SpeedEnd").GetConnection(0).node;
						objToReturn.SpeedEnd = FrameId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.InputId:
						FSInputNode InputId_FloatSource_Node = (FSInputNode)GetPort("SpeedEnd").GetConnection(0).node;
						objToReturn.SpeedEnd = InputId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FuncId:
						FSFuncNode FuncId_FloatSource_Node = (FSFuncNode)GetPort("SpeedEnd").GetConnection(0).node;
						objToReturn.SpeedEnd = FuncId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.MovementId:
						FSMovementNode MovementId_FloatSource_Node = (FSMovementNode)GetPort("SpeedEnd").GetConnection(0).node;
						objToReturn.SpeedEnd = MovementId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CombatId:
						FSCombatNode CombatId_FloatSource_Node = (FSCombatNode)GetPort("SpeedEnd").GetConnection(0).node;
						objToReturn.SpeedEnd = CombatId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.GrabsId:
						FSGrabsNode GrabsId_FloatSource_Node = (FSGrabsNode)GetPort("SpeedEnd").GetConnection(0).node;
						objToReturn.SpeedEnd = GrabsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.DataId:
						FSDataNode DataId_FloatSource_Node = (FSDataNode)GetPort("SpeedEnd").GetConnection(0).node;
						objToReturn.SpeedEnd = DataId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ScratchId:
						FSScratchNode ScratchId_FloatSource_Node = (FSScratchNode)GetPort("SpeedEnd").GetConnection(0).node;
						objToReturn.SpeedEnd = ScratchId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AnimId:
						FSAnimNode AnimId_FloatSource_Node = (FSAnimNode)GetPort("SpeedEnd").GetConnection(0).node;
						objToReturn.SpeedEnd = AnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SpeedId:
						FSSpeedNode SpeedId_FloatSource_Node = (FSSpeedNode)GetPort("SpeedEnd").GetConnection(0).node;
						objToReturn.SpeedEnd = SpeedId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.PhysicsId:
						FSPhysicsNode PhysicsId_FloatSource_Node = (FSPhysicsNode)GetPort("SpeedEnd").GetConnection(0).node;
						objToReturn.SpeedEnd = PhysicsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CollisionId:
						FSCollisionNode CollisionId_FloatSource_Node = (FSCollisionNode)GetPort("SpeedEnd").GetConnection(0).node;
						objToReturn.SpeedEnd = CollisionId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.TimerId:
						FSTimerNode TimerId_FloatSource_Node = (FSTimerNode)GetPort("SpeedEnd").GetConnection(0).node;
						objToReturn.SpeedEnd = TimerId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.LagId:
						FSLagNode LagId_FloatSource_Node = (FSLagNode)GetPort("SpeedEnd").GetConnection(0).node;
						objToReturn.SpeedEnd = LagId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.EffectsId:
						FSEffectsNode EffectsId_FloatSource_Node = (FSEffectsNode)GetPort("SpeedEnd").GetConnection(0).node;
						objToReturn.SpeedEnd = EffectsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ColorsId:
						FSColorsNode ColorsId_FloatSource_Node = (FSColorsNode)GetPort("SpeedEnd").GetConnection(0).node;
						objToReturn.SpeedEnd = ColorsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.OnHitId:
						FSOnHitNode OnHitId_FloatSource_Node = (FSOnHitNode)GetPort("SpeedEnd").GetConnection(0).node;
						objToReturn.SpeedEnd = OnHitId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RandomId:
						FSRandomNode RandomId_FloatSource_Node = (FSRandomNode)GetPort("SpeedEnd").GetConnection(0).node;
						objToReturn.SpeedEnd = RandomId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CameraId:
						FSCameraInfoNode CameraId_FloatSource_Node = (FSCameraInfoNode)GetPort("SpeedEnd").GetConnection(0).node;
						objToReturn.SpeedEnd = CameraId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SportsId:
						FSSportsNode SportsId_FloatSource_Node = (FSSportsNode)GetPort("SpeedEnd").GetConnection(0).node;
						objToReturn.SpeedEnd = SportsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.Vector2Mag:
						FSVector2MagNode Vector2Mag_FloatSource_Node = (FSVector2MagNode)GetPort("SpeedEnd").GetConnection(0).node;
						objToReturn.SpeedEnd = Vector2Mag_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CPUHelpId:
						FSCpuHelpNode CPUHelpId_FloatSource_Node = (FSCpuHelpNode)GetPort("SpeedEnd").GetConnection(0).node;
						objToReturn.SpeedEnd = CPUHelpId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ItemId:
						FSItemNode ItemId_FloatSource_Node = (FSItemNode)GetPort("SpeedEnd").GetConnection(0).node;
						objToReturn.SpeedEnd = ItemId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ModeId:
						FSModeNode ModeId_FloatSource_Node = (FSModeNode)GetPort("SpeedEnd").GetConnection(0).node;
						objToReturn.SpeedEnd = ModeId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.JumpsId:
						FSJumpsNode JumpsId_FloatSource_Node = (FSJumpsNode)GetPort("SpeedEnd").GetConnection(0).node;
						objToReturn.SpeedEnd = JumpsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RootAnimId:
						FSRootAnimNode RootAnimId_FloatSource_Node = (FSRootAnimNode)GetPort("SpeedEnd").GetConnection(0).node;
						objToReturn.SpeedEnd = RootAnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FloatId:
						FSValueNode FloatId_FloatSource_Node = (FSValueNode)GetPort("SpeedEnd").GetConnection(0).node;
						objToReturn.SpeedEnd = FloatId_FloatSource_Node.GetData();
					break;
				}
			}
			if (GetPort("SpeedUpMult").ConnectionCount > 0)
			{
				FloatSourceNode FloatSource_Node = (FloatSourceNode)GetPort("SpeedUpMult").GetConnection(0).node;
				switch (FloatSource_Node.TID)
				{
					case FloatSource.TypeId.AgentId:
						FSAgentNode AgentId_FloatSource_Node = (FSAgentNode)GetPort("SpeedUpMult").GetConnection(0).node;
						objToReturn.SpeedUpMult = AgentId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.BonesId:
						FSBonesNode BonesId_FloatSource_Node = (FSBonesNode)GetPort("SpeedUpMult").GetConnection(0).node;
						objToReturn.SpeedUpMult = BonesId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AttackId:
						FSAttackNode AttackId_FloatSource_Node = (FSAttackNode)GetPort("SpeedUpMult").GetConnection(0).node;
						objToReturn.SpeedUpMult = AttackId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FrameId:
						FSFrameNode FrameId_FloatSource_Node = (FSFrameNode)GetPort("SpeedUpMult").GetConnection(0).node;
						objToReturn.SpeedUpMult = FrameId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.InputId:
						FSInputNode InputId_FloatSource_Node = (FSInputNode)GetPort("SpeedUpMult").GetConnection(0).node;
						objToReturn.SpeedUpMult = InputId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FuncId:
						FSFuncNode FuncId_FloatSource_Node = (FSFuncNode)GetPort("SpeedUpMult").GetConnection(0).node;
						objToReturn.SpeedUpMult = FuncId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.MovementId:
						FSMovementNode MovementId_FloatSource_Node = (FSMovementNode)GetPort("SpeedUpMult").GetConnection(0).node;
						objToReturn.SpeedUpMult = MovementId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CombatId:
						FSCombatNode CombatId_FloatSource_Node = (FSCombatNode)GetPort("SpeedUpMult").GetConnection(0).node;
						objToReturn.SpeedUpMult = CombatId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.GrabsId:
						FSGrabsNode GrabsId_FloatSource_Node = (FSGrabsNode)GetPort("SpeedUpMult").GetConnection(0).node;
						objToReturn.SpeedUpMult = GrabsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.DataId:
						FSDataNode DataId_FloatSource_Node = (FSDataNode)GetPort("SpeedUpMult").GetConnection(0).node;
						objToReturn.SpeedUpMult = DataId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ScratchId:
						FSScratchNode ScratchId_FloatSource_Node = (FSScratchNode)GetPort("SpeedUpMult").GetConnection(0).node;
						objToReturn.SpeedUpMult = ScratchId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AnimId:
						FSAnimNode AnimId_FloatSource_Node = (FSAnimNode)GetPort("SpeedUpMult").GetConnection(0).node;
						objToReturn.SpeedUpMult = AnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SpeedId:
						FSSpeedNode SpeedId_FloatSource_Node = (FSSpeedNode)GetPort("SpeedUpMult").GetConnection(0).node;
						objToReturn.SpeedUpMult = SpeedId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.PhysicsId:
						FSPhysicsNode PhysicsId_FloatSource_Node = (FSPhysicsNode)GetPort("SpeedUpMult").GetConnection(0).node;
						objToReturn.SpeedUpMult = PhysicsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CollisionId:
						FSCollisionNode CollisionId_FloatSource_Node = (FSCollisionNode)GetPort("SpeedUpMult").GetConnection(0).node;
						objToReturn.SpeedUpMult = CollisionId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.TimerId:
						FSTimerNode TimerId_FloatSource_Node = (FSTimerNode)GetPort("SpeedUpMult").GetConnection(0).node;
						objToReturn.SpeedUpMult = TimerId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.LagId:
						FSLagNode LagId_FloatSource_Node = (FSLagNode)GetPort("SpeedUpMult").GetConnection(0).node;
						objToReturn.SpeedUpMult = LagId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.EffectsId:
						FSEffectsNode EffectsId_FloatSource_Node = (FSEffectsNode)GetPort("SpeedUpMult").GetConnection(0).node;
						objToReturn.SpeedUpMult = EffectsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ColorsId:
						FSColorsNode ColorsId_FloatSource_Node = (FSColorsNode)GetPort("SpeedUpMult").GetConnection(0).node;
						objToReturn.SpeedUpMult = ColorsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.OnHitId:
						FSOnHitNode OnHitId_FloatSource_Node = (FSOnHitNode)GetPort("SpeedUpMult").GetConnection(0).node;
						objToReturn.SpeedUpMult = OnHitId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RandomId:
						FSRandomNode RandomId_FloatSource_Node = (FSRandomNode)GetPort("SpeedUpMult").GetConnection(0).node;
						objToReturn.SpeedUpMult = RandomId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CameraId:
						FSCameraInfoNode CameraId_FloatSource_Node = (FSCameraInfoNode)GetPort("SpeedUpMult").GetConnection(0).node;
						objToReturn.SpeedUpMult = CameraId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SportsId:
						FSSportsNode SportsId_FloatSource_Node = (FSSportsNode)GetPort("SpeedUpMult").GetConnection(0).node;
						objToReturn.SpeedUpMult = SportsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.Vector2Mag:
						FSVector2MagNode Vector2Mag_FloatSource_Node = (FSVector2MagNode)GetPort("SpeedUpMult").GetConnection(0).node;
						objToReturn.SpeedUpMult = Vector2Mag_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CPUHelpId:
						FSCpuHelpNode CPUHelpId_FloatSource_Node = (FSCpuHelpNode)GetPort("SpeedUpMult").GetConnection(0).node;
						objToReturn.SpeedUpMult = CPUHelpId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ItemId:
						FSItemNode ItemId_FloatSource_Node = (FSItemNode)GetPort("SpeedUpMult").GetConnection(0).node;
						objToReturn.SpeedUpMult = ItemId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ModeId:
						FSModeNode ModeId_FloatSource_Node = (FSModeNode)GetPort("SpeedUpMult").GetConnection(0).node;
						objToReturn.SpeedUpMult = ModeId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.JumpsId:
						FSJumpsNode JumpsId_FloatSource_Node = (FSJumpsNode)GetPort("SpeedUpMult").GetConnection(0).node;
						objToReturn.SpeedUpMult = JumpsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RootAnimId:
						FSRootAnimNode RootAnimId_FloatSource_Node = (FSRootAnimNode)GetPort("SpeedUpMult").GetConnection(0).node;
						objToReturn.SpeedUpMult = RootAnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FloatId:
						FSValueNode FloatId_FloatSource_Node = (FSValueNode)GetPort("SpeedUpMult").GetConnection(0).node;
						objToReturn.SpeedUpMult = FloatId_FloatSource_Node.GetData();
					break;
				}
			}
			if (GetPort("SpeedDownMult").ConnectionCount > 0)
			{
				FloatSourceNode FloatSource_Node = (FloatSourceNode)GetPort("SpeedDownMult").GetConnection(0).node;
				switch (FloatSource_Node.TID)
				{
					case FloatSource.TypeId.AgentId:
						FSAgentNode AgentId_FloatSource_Node = (FSAgentNode)GetPort("SpeedDownMult").GetConnection(0).node;
						objToReturn.SpeedDownMult = AgentId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.BonesId:
						FSBonesNode BonesId_FloatSource_Node = (FSBonesNode)GetPort("SpeedDownMult").GetConnection(0).node;
						objToReturn.SpeedDownMult = BonesId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AttackId:
						FSAttackNode AttackId_FloatSource_Node = (FSAttackNode)GetPort("SpeedDownMult").GetConnection(0).node;
						objToReturn.SpeedDownMult = AttackId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FrameId:
						FSFrameNode FrameId_FloatSource_Node = (FSFrameNode)GetPort("SpeedDownMult").GetConnection(0).node;
						objToReturn.SpeedDownMult = FrameId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.InputId:
						FSInputNode InputId_FloatSource_Node = (FSInputNode)GetPort("SpeedDownMult").GetConnection(0).node;
						objToReturn.SpeedDownMult = InputId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FuncId:
						FSFuncNode FuncId_FloatSource_Node = (FSFuncNode)GetPort("SpeedDownMult").GetConnection(0).node;
						objToReturn.SpeedDownMult = FuncId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.MovementId:
						FSMovementNode MovementId_FloatSource_Node = (FSMovementNode)GetPort("SpeedDownMult").GetConnection(0).node;
						objToReturn.SpeedDownMult = MovementId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CombatId:
						FSCombatNode CombatId_FloatSource_Node = (FSCombatNode)GetPort("SpeedDownMult").GetConnection(0).node;
						objToReturn.SpeedDownMult = CombatId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.GrabsId:
						FSGrabsNode GrabsId_FloatSource_Node = (FSGrabsNode)GetPort("SpeedDownMult").GetConnection(0).node;
						objToReturn.SpeedDownMult = GrabsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.DataId:
						FSDataNode DataId_FloatSource_Node = (FSDataNode)GetPort("SpeedDownMult").GetConnection(0).node;
						objToReturn.SpeedDownMult = DataId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ScratchId:
						FSScratchNode ScratchId_FloatSource_Node = (FSScratchNode)GetPort("SpeedDownMult").GetConnection(0).node;
						objToReturn.SpeedDownMult = ScratchId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AnimId:
						FSAnimNode AnimId_FloatSource_Node = (FSAnimNode)GetPort("SpeedDownMult").GetConnection(0).node;
						objToReturn.SpeedDownMult = AnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SpeedId:
						FSSpeedNode SpeedId_FloatSource_Node = (FSSpeedNode)GetPort("SpeedDownMult").GetConnection(0).node;
						objToReturn.SpeedDownMult = SpeedId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.PhysicsId:
						FSPhysicsNode PhysicsId_FloatSource_Node = (FSPhysicsNode)GetPort("SpeedDownMult").GetConnection(0).node;
						objToReturn.SpeedDownMult = PhysicsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CollisionId:
						FSCollisionNode CollisionId_FloatSource_Node = (FSCollisionNode)GetPort("SpeedDownMult").GetConnection(0).node;
						objToReturn.SpeedDownMult = CollisionId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.TimerId:
						FSTimerNode TimerId_FloatSource_Node = (FSTimerNode)GetPort("SpeedDownMult").GetConnection(0).node;
						objToReturn.SpeedDownMult = TimerId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.LagId:
						FSLagNode LagId_FloatSource_Node = (FSLagNode)GetPort("SpeedDownMult").GetConnection(0).node;
						objToReturn.SpeedDownMult = LagId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.EffectsId:
						FSEffectsNode EffectsId_FloatSource_Node = (FSEffectsNode)GetPort("SpeedDownMult").GetConnection(0).node;
						objToReturn.SpeedDownMult = EffectsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ColorsId:
						FSColorsNode ColorsId_FloatSource_Node = (FSColorsNode)GetPort("SpeedDownMult").GetConnection(0).node;
						objToReturn.SpeedDownMult = ColorsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.OnHitId:
						FSOnHitNode OnHitId_FloatSource_Node = (FSOnHitNode)GetPort("SpeedDownMult").GetConnection(0).node;
						objToReturn.SpeedDownMult = OnHitId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RandomId:
						FSRandomNode RandomId_FloatSource_Node = (FSRandomNode)GetPort("SpeedDownMult").GetConnection(0).node;
						objToReturn.SpeedDownMult = RandomId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CameraId:
						FSCameraInfoNode CameraId_FloatSource_Node = (FSCameraInfoNode)GetPort("SpeedDownMult").GetConnection(0).node;
						objToReturn.SpeedDownMult = CameraId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SportsId:
						FSSportsNode SportsId_FloatSource_Node = (FSSportsNode)GetPort("SpeedDownMult").GetConnection(0).node;
						objToReturn.SpeedDownMult = SportsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.Vector2Mag:
						FSVector2MagNode Vector2Mag_FloatSource_Node = (FSVector2MagNode)GetPort("SpeedDownMult").GetConnection(0).node;
						objToReturn.SpeedDownMult = Vector2Mag_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CPUHelpId:
						FSCpuHelpNode CPUHelpId_FloatSource_Node = (FSCpuHelpNode)GetPort("SpeedDownMult").GetConnection(0).node;
						objToReturn.SpeedDownMult = CPUHelpId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ItemId:
						FSItemNode ItemId_FloatSource_Node = (FSItemNode)GetPort("SpeedDownMult").GetConnection(0).node;
						objToReturn.SpeedDownMult = ItemId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ModeId:
						FSModeNode ModeId_FloatSource_Node = (FSModeNode)GetPort("SpeedDownMult").GetConnection(0).node;
						objToReturn.SpeedDownMult = ModeId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.JumpsId:
						FSJumpsNode JumpsId_FloatSource_Node = (FSJumpsNode)GetPort("SpeedDownMult").GetConnection(0).node;
						objToReturn.SpeedDownMult = JumpsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RootAnimId:
						FSRootAnimNode RootAnimId_FloatSource_Node = (FSRootAnimNode)GetPort("SpeedDownMult").GetConnection(0).node;
						objToReturn.SpeedDownMult = RootAnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FloatId:
						FSValueNode FloatId_FloatSource_Node = (FSValueNode)GetPort("SpeedDownMult").GetConnection(0).node;
						objToReturn.SpeedDownMult = FloatId_FloatSource_Node.GetData();
					break;
				}
			}
			if (GetPort("Frames").ConnectionCount > 0)
			{
				FloatSourceNode FloatSource_Node = (FloatSourceNode)GetPort("Frames").GetConnection(0).node;
				switch (FloatSource_Node.TID)
				{
					case FloatSource.TypeId.AgentId:
						FSAgentNode AgentId_FloatSource_Node = (FSAgentNode)GetPort("Frames").GetConnection(0).node;
						objToReturn.Frames = AgentId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.BonesId:
						FSBonesNode BonesId_FloatSource_Node = (FSBonesNode)GetPort("Frames").GetConnection(0).node;
						objToReturn.Frames = BonesId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AttackId:
						FSAttackNode AttackId_FloatSource_Node = (FSAttackNode)GetPort("Frames").GetConnection(0).node;
						objToReturn.Frames = AttackId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FrameId:
						FSFrameNode FrameId_FloatSource_Node = (FSFrameNode)GetPort("Frames").GetConnection(0).node;
						objToReturn.Frames = FrameId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.InputId:
						FSInputNode InputId_FloatSource_Node = (FSInputNode)GetPort("Frames").GetConnection(0).node;
						objToReturn.Frames = InputId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FuncId:
						FSFuncNode FuncId_FloatSource_Node = (FSFuncNode)GetPort("Frames").GetConnection(0).node;
						objToReturn.Frames = FuncId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.MovementId:
						FSMovementNode MovementId_FloatSource_Node = (FSMovementNode)GetPort("Frames").GetConnection(0).node;
						objToReturn.Frames = MovementId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CombatId:
						FSCombatNode CombatId_FloatSource_Node = (FSCombatNode)GetPort("Frames").GetConnection(0).node;
						objToReturn.Frames = CombatId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.GrabsId:
						FSGrabsNode GrabsId_FloatSource_Node = (FSGrabsNode)GetPort("Frames").GetConnection(0).node;
						objToReturn.Frames = GrabsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.DataId:
						FSDataNode DataId_FloatSource_Node = (FSDataNode)GetPort("Frames").GetConnection(0).node;
						objToReturn.Frames = DataId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ScratchId:
						FSScratchNode ScratchId_FloatSource_Node = (FSScratchNode)GetPort("Frames").GetConnection(0).node;
						objToReturn.Frames = ScratchId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AnimId:
						FSAnimNode AnimId_FloatSource_Node = (FSAnimNode)GetPort("Frames").GetConnection(0).node;
						objToReturn.Frames = AnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SpeedId:
						FSSpeedNode SpeedId_FloatSource_Node = (FSSpeedNode)GetPort("Frames").GetConnection(0).node;
						objToReturn.Frames = SpeedId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.PhysicsId:
						FSPhysicsNode PhysicsId_FloatSource_Node = (FSPhysicsNode)GetPort("Frames").GetConnection(0).node;
						objToReturn.Frames = PhysicsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CollisionId:
						FSCollisionNode CollisionId_FloatSource_Node = (FSCollisionNode)GetPort("Frames").GetConnection(0).node;
						objToReturn.Frames = CollisionId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.TimerId:
						FSTimerNode TimerId_FloatSource_Node = (FSTimerNode)GetPort("Frames").GetConnection(0).node;
						objToReturn.Frames = TimerId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.LagId:
						FSLagNode LagId_FloatSource_Node = (FSLagNode)GetPort("Frames").GetConnection(0).node;
						objToReturn.Frames = LagId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.EffectsId:
						FSEffectsNode EffectsId_FloatSource_Node = (FSEffectsNode)GetPort("Frames").GetConnection(0).node;
						objToReturn.Frames = EffectsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ColorsId:
						FSColorsNode ColorsId_FloatSource_Node = (FSColorsNode)GetPort("Frames").GetConnection(0).node;
						objToReturn.Frames = ColorsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.OnHitId:
						FSOnHitNode OnHitId_FloatSource_Node = (FSOnHitNode)GetPort("Frames").GetConnection(0).node;
						objToReturn.Frames = OnHitId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RandomId:
						FSRandomNode RandomId_FloatSource_Node = (FSRandomNode)GetPort("Frames").GetConnection(0).node;
						objToReturn.Frames = RandomId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CameraId:
						FSCameraInfoNode CameraId_FloatSource_Node = (FSCameraInfoNode)GetPort("Frames").GetConnection(0).node;
						objToReturn.Frames = CameraId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SportsId:
						FSSportsNode SportsId_FloatSource_Node = (FSSportsNode)GetPort("Frames").GetConnection(0).node;
						objToReturn.Frames = SportsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.Vector2Mag:
						FSVector2MagNode Vector2Mag_FloatSource_Node = (FSVector2MagNode)GetPort("Frames").GetConnection(0).node;
						objToReturn.Frames = Vector2Mag_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CPUHelpId:
						FSCpuHelpNode CPUHelpId_FloatSource_Node = (FSCpuHelpNode)GetPort("Frames").GetConnection(0).node;
						objToReturn.Frames = CPUHelpId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ItemId:
						FSItemNode ItemId_FloatSource_Node = (FSItemNode)GetPort("Frames").GetConnection(0).node;
						objToReturn.Frames = ItemId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ModeId:
						FSModeNode ModeId_FloatSource_Node = (FSModeNode)GetPort("Frames").GetConnection(0).node;
						objToReturn.Frames = ModeId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.JumpsId:
						FSJumpsNode JumpsId_FloatSource_Node = (FSJumpsNode)GetPort("Frames").GetConnection(0).node;
						objToReturn.Frames = JumpsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RootAnimId:
						FSRootAnimNode RootAnimId_FloatSource_Node = (FSRootAnimNode)GetPort("Frames").GetConnection(0).node;
						objToReturn.Frames = RootAnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FloatId:
						FSValueNode FloatId_FloatSource_Node = (FSValueNode)GetPort("Frames").GetConnection(0).node;
						objToReturn.Frames = FloatId_FloatSource_Node.GetData();
					break;
				}
			}
			if (GetPort("RedirectFrames").ConnectionCount > 0)
			{
				FloatSourceNode FloatSource_Node = (FloatSourceNode)GetPort("RedirectFrames").GetConnection(0).node;
				switch (FloatSource_Node.TID)
				{
					case FloatSource.TypeId.AgentId:
						FSAgentNode AgentId_FloatSource_Node = (FSAgentNode)GetPort("RedirectFrames").GetConnection(0).node;
						objToReturn.RedirectFrames = AgentId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.BonesId:
						FSBonesNode BonesId_FloatSource_Node = (FSBonesNode)GetPort("RedirectFrames").GetConnection(0).node;
						objToReturn.RedirectFrames = BonesId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AttackId:
						FSAttackNode AttackId_FloatSource_Node = (FSAttackNode)GetPort("RedirectFrames").GetConnection(0).node;
						objToReturn.RedirectFrames = AttackId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FrameId:
						FSFrameNode FrameId_FloatSource_Node = (FSFrameNode)GetPort("RedirectFrames").GetConnection(0).node;
						objToReturn.RedirectFrames = FrameId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.InputId:
						FSInputNode InputId_FloatSource_Node = (FSInputNode)GetPort("RedirectFrames").GetConnection(0).node;
						objToReturn.RedirectFrames = InputId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FuncId:
						FSFuncNode FuncId_FloatSource_Node = (FSFuncNode)GetPort("RedirectFrames").GetConnection(0).node;
						objToReturn.RedirectFrames = FuncId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.MovementId:
						FSMovementNode MovementId_FloatSource_Node = (FSMovementNode)GetPort("RedirectFrames").GetConnection(0).node;
						objToReturn.RedirectFrames = MovementId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CombatId:
						FSCombatNode CombatId_FloatSource_Node = (FSCombatNode)GetPort("RedirectFrames").GetConnection(0).node;
						objToReturn.RedirectFrames = CombatId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.GrabsId:
						FSGrabsNode GrabsId_FloatSource_Node = (FSGrabsNode)GetPort("RedirectFrames").GetConnection(0).node;
						objToReturn.RedirectFrames = GrabsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.DataId:
						FSDataNode DataId_FloatSource_Node = (FSDataNode)GetPort("RedirectFrames").GetConnection(0).node;
						objToReturn.RedirectFrames = DataId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ScratchId:
						FSScratchNode ScratchId_FloatSource_Node = (FSScratchNode)GetPort("RedirectFrames").GetConnection(0).node;
						objToReturn.RedirectFrames = ScratchId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AnimId:
						FSAnimNode AnimId_FloatSource_Node = (FSAnimNode)GetPort("RedirectFrames").GetConnection(0).node;
						objToReturn.RedirectFrames = AnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SpeedId:
						FSSpeedNode SpeedId_FloatSource_Node = (FSSpeedNode)GetPort("RedirectFrames").GetConnection(0).node;
						objToReturn.RedirectFrames = SpeedId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.PhysicsId:
						FSPhysicsNode PhysicsId_FloatSource_Node = (FSPhysicsNode)GetPort("RedirectFrames").GetConnection(0).node;
						objToReturn.RedirectFrames = PhysicsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CollisionId:
						FSCollisionNode CollisionId_FloatSource_Node = (FSCollisionNode)GetPort("RedirectFrames").GetConnection(0).node;
						objToReturn.RedirectFrames = CollisionId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.TimerId:
						FSTimerNode TimerId_FloatSource_Node = (FSTimerNode)GetPort("RedirectFrames").GetConnection(0).node;
						objToReturn.RedirectFrames = TimerId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.LagId:
						FSLagNode LagId_FloatSource_Node = (FSLagNode)GetPort("RedirectFrames").GetConnection(0).node;
						objToReturn.RedirectFrames = LagId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.EffectsId:
						FSEffectsNode EffectsId_FloatSource_Node = (FSEffectsNode)GetPort("RedirectFrames").GetConnection(0).node;
						objToReturn.RedirectFrames = EffectsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ColorsId:
						FSColorsNode ColorsId_FloatSource_Node = (FSColorsNode)GetPort("RedirectFrames").GetConnection(0).node;
						objToReturn.RedirectFrames = ColorsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.OnHitId:
						FSOnHitNode OnHitId_FloatSource_Node = (FSOnHitNode)GetPort("RedirectFrames").GetConnection(0).node;
						objToReturn.RedirectFrames = OnHitId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RandomId:
						FSRandomNode RandomId_FloatSource_Node = (FSRandomNode)GetPort("RedirectFrames").GetConnection(0).node;
						objToReturn.RedirectFrames = RandomId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CameraId:
						FSCameraInfoNode CameraId_FloatSource_Node = (FSCameraInfoNode)GetPort("RedirectFrames").GetConnection(0).node;
						objToReturn.RedirectFrames = CameraId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SportsId:
						FSSportsNode SportsId_FloatSource_Node = (FSSportsNode)GetPort("RedirectFrames").GetConnection(0).node;
						objToReturn.RedirectFrames = SportsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.Vector2Mag:
						FSVector2MagNode Vector2Mag_FloatSource_Node = (FSVector2MagNode)GetPort("RedirectFrames").GetConnection(0).node;
						objToReturn.RedirectFrames = Vector2Mag_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CPUHelpId:
						FSCpuHelpNode CPUHelpId_FloatSource_Node = (FSCpuHelpNode)GetPort("RedirectFrames").GetConnection(0).node;
						objToReturn.RedirectFrames = CPUHelpId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ItemId:
						FSItemNode ItemId_FloatSource_Node = (FSItemNode)GetPort("RedirectFrames").GetConnection(0).node;
						objToReturn.RedirectFrames = ItemId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ModeId:
						FSModeNode ModeId_FloatSource_Node = (FSModeNode)GetPort("RedirectFrames").GetConnection(0).node;
						objToReturn.RedirectFrames = ModeId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.JumpsId:
						FSJumpsNode JumpsId_FloatSource_Node = (FSJumpsNode)GetPort("RedirectFrames").GetConnection(0).node;
						objToReturn.RedirectFrames = JumpsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RootAnimId:
						FSRootAnimNode RootAnimId_FloatSource_Node = (FSRootAnimNode)GetPort("RedirectFrames").GetConnection(0).node;
						objToReturn.RedirectFrames = RootAnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FloatId:
						FSValueNode FloatId_FloatSource_Node = (FSValueNode)GetPort("RedirectFrames").GetConnection(0).node;
						objToReturn.RedirectFrames = FloatId_FloatSource_Node.GetData();
					break;
				}
			}
			return objToReturn;
		}
	}
}

