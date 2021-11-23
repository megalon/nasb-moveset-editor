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
	public class KnockbackJumpNode : JumpNode
	{
		[Output] public FloatSource XDir;
		[Output] public FloatSource YDir;
		[Output] public FloatSource LaunchDist;
		[Output] public FloatSource Frames;
		[Output] public FloatSource DiType;
		[Output] public FloatSource DiAngleIn;
		[Output] public FloatSource DiAngleOut;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.KnockbackId;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(KnockbackJump data, MovesetGraph graph, string assetPath, Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(KnockbackJump));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
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
			
			LaunchDist = data.LaunchDist;
			
			switch (LaunchDist.TID)
			{
				case FloatSource.TypeId.AgentId:
					FSAgentNode AgentId_node_LaunchDist = graph.AddNode<FSAgentNode>();
					GetPort("LaunchDist").Connect(AgentId_node_LaunchDist.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AgentId_node_LaunchDist, assetPath);
					variableCount += AgentId_node_LaunchDist.SetData((FSAgent)LaunchDist, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.BonesId:
					FSBonesNode BonesId_node_LaunchDist = graph.AddNode<FSBonesNode>();
					GetPort("LaunchDist").Connect(BonesId_node_LaunchDist.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BonesId_node_LaunchDist, assetPath);
					variableCount += BonesId_node_LaunchDist.SetData((FSBones)LaunchDist, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AttackId:
					FSAttackNode AttackId_node_LaunchDist = graph.AddNode<FSAttackNode>();
					GetPort("LaunchDist").Connect(AttackId_node_LaunchDist.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AttackId_node_LaunchDist, assetPath);
					variableCount += AttackId_node_LaunchDist.SetData((FSAttack)LaunchDist, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FrameId:
					FSFrameNode FrameId_node_LaunchDist = graph.AddNode<FSFrameNode>();
					GetPort("LaunchDist").Connect(FrameId_node_LaunchDist.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FrameId_node_LaunchDist, assetPath);
					variableCount += FrameId_node_LaunchDist.SetData((FSFrame)LaunchDist, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.InputId:
					FSInputNode InputId_node_LaunchDist = graph.AddNode<FSInputNode>();
					GetPort("LaunchDist").Connect(InputId_node_LaunchDist.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputId_node_LaunchDist, assetPath);
					variableCount += InputId_node_LaunchDist.SetData((FSInput)LaunchDist, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FuncId:
					FSFuncNode FuncId_node_LaunchDist = graph.AddNode<FSFuncNode>();
					GetPort("LaunchDist").Connect(FuncId_node_LaunchDist.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FuncId_node_LaunchDist, assetPath);
					variableCount += FuncId_node_LaunchDist.SetData((FSFunc)LaunchDist, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.MovementId:
					FSMovementNode MovementId_node_LaunchDist = graph.AddNode<FSMovementNode>();
					GetPort("LaunchDist").Connect(MovementId_node_LaunchDist.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(MovementId_node_LaunchDist, assetPath);
					variableCount += MovementId_node_LaunchDist.SetData((FSMovement)LaunchDist, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CombatId:
					FSCombatNode CombatId_node_LaunchDist = graph.AddNode<FSCombatNode>();
					GetPort("LaunchDist").Connect(CombatId_node_LaunchDist.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CombatId_node_LaunchDist, assetPath);
					variableCount += CombatId_node_LaunchDist.SetData((FSCombat)LaunchDist, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.GrabsId:
					FSGrabsNode GrabsId_node_LaunchDist = graph.AddNode<FSGrabsNode>();
					GetPort("LaunchDist").Connect(GrabsId_node_LaunchDist.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(GrabsId_node_LaunchDist, assetPath);
					variableCount += GrabsId_node_LaunchDist.SetData((FSGrabs)LaunchDist, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.DataId:
					FSDataNode DataId_node_LaunchDist = graph.AddNode<FSDataNode>();
					GetPort("LaunchDist").Connect(DataId_node_LaunchDist.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DataId_node_LaunchDist, assetPath);
					variableCount += DataId_node_LaunchDist.SetData((FSData)LaunchDist, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ScratchId:
					FSScratchNode ScratchId_node_LaunchDist = graph.AddNode<FSScratchNode>();
					GetPort("LaunchDist").Connect(ScratchId_node_LaunchDist.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ScratchId_node_LaunchDist, assetPath);
					variableCount += ScratchId_node_LaunchDist.SetData((FSScratch)LaunchDist, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AnimId:
					FSAnimNode AnimId_node_LaunchDist = graph.AddNode<FSAnimNode>();
					GetPort("LaunchDist").Connect(AnimId_node_LaunchDist.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AnimId_node_LaunchDist, assetPath);
					variableCount += AnimId_node_LaunchDist.SetData((FSAnim)LaunchDist, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SpeedId:
					FSSpeedNode SpeedId_node_LaunchDist = graph.AddNode<FSSpeedNode>();
					GetPort("LaunchDist").Connect(SpeedId_node_LaunchDist.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpeedId_node_LaunchDist, assetPath);
					variableCount += SpeedId_node_LaunchDist.SetData((FSSpeed)LaunchDist, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.PhysicsId:
					FSPhysicsNode PhysicsId_node_LaunchDist = graph.AddNode<FSPhysicsNode>();
					GetPort("LaunchDist").Connect(PhysicsId_node_LaunchDist.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(PhysicsId_node_LaunchDist, assetPath);
					variableCount += PhysicsId_node_LaunchDist.SetData((FSPhysics)LaunchDist, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CollisionId:
					FSCollisionNode CollisionId_node_LaunchDist = graph.AddNode<FSCollisionNode>();
					GetPort("LaunchDist").Connect(CollisionId_node_LaunchDist.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CollisionId_node_LaunchDist, assetPath);
					variableCount += CollisionId_node_LaunchDist.SetData((FSCollision)LaunchDist, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.TimerId:
					FSTimerNode TimerId_node_LaunchDist = graph.AddNode<FSTimerNode>();
					GetPort("LaunchDist").Connect(TimerId_node_LaunchDist.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(TimerId_node_LaunchDist, assetPath);
					variableCount += TimerId_node_LaunchDist.SetData((FSTimer)LaunchDist, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.LagId:
					FSLagNode LagId_node_LaunchDist = graph.AddNode<FSLagNode>();
					GetPort("LaunchDist").Connect(LagId_node_LaunchDist.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LagId_node_LaunchDist, assetPath);
					variableCount += LagId_node_LaunchDist.SetData((FSLag)LaunchDist, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.EffectsId:
					FSEffectsNode EffectsId_node_LaunchDist = graph.AddNode<FSEffectsNode>();
					GetPort("LaunchDist").Connect(EffectsId_node_LaunchDist.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EffectsId_node_LaunchDist, assetPath);
					variableCount += EffectsId_node_LaunchDist.SetData((FSEffects)LaunchDist, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ColorsId:
					FSColorsNode ColorsId_node_LaunchDist = graph.AddNode<FSColorsNode>();
					GetPort("LaunchDist").Connect(ColorsId_node_LaunchDist.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ColorsId_node_LaunchDist, assetPath);
					variableCount += ColorsId_node_LaunchDist.SetData((FSColors)LaunchDist, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.OnHitId:
					FSOnHitNode OnHitId_node_LaunchDist = graph.AddNode<FSOnHitNode>();
					GetPort("LaunchDist").Connect(OnHitId_node_LaunchDist.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnHitId_node_LaunchDist, assetPath);
					variableCount += OnHitId_node_LaunchDist.SetData((FSOnHit)LaunchDist, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RandomId:
					FSRandomNode RandomId_node_LaunchDist = graph.AddNode<FSRandomNode>();
					GetPort("LaunchDist").Connect(RandomId_node_LaunchDist.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RandomId_node_LaunchDist, assetPath);
					variableCount += RandomId_node_LaunchDist.SetData((FSRandom)LaunchDist, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CameraId:
					FSCameraInfoNode CameraId_node_LaunchDist = graph.AddNode<FSCameraInfoNode>();
					GetPort("LaunchDist").Connect(CameraId_node_LaunchDist.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CameraId_node_LaunchDist, assetPath);
					variableCount += CameraId_node_LaunchDist.SetData((FSCameraInfo)LaunchDist, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SportsId:
					FSSportsNode SportsId_node_LaunchDist = graph.AddNode<FSSportsNode>();
					GetPort("LaunchDist").Connect(SportsId_node_LaunchDist.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SportsId_node_LaunchDist, assetPath);
					variableCount += SportsId_node_LaunchDist.SetData((FSSports)LaunchDist, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.Vector2Mag:
					FSVector2MagNode Vector2Mag_node_LaunchDist = graph.AddNode<FSVector2MagNode>();
					GetPort("LaunchDist").Connect(Vector2Mag_node_LaunchDist.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(Vector2Mag_node_LaunchDist, assetPath);
					variableCount += Vector2Mag_node_LaunchDist.SetData((FSVector2Mag)LaunchDist, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CPUHelpId:
					FSCpuHelpNode CPUHelpId_node_LaunchDist = graph.AddNode<FSCpuHelpNode>();
					GetPort("LaunchDist").Connect(CPUHelpId_node_LaunchDist.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CPUHelpId_node_LaunchDist, assetPath);
					variableCount += CPUHelpId_node_LaunchDist.SetData((FSCpuHelp)LaunchDist, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ItemId:
					FSItemNode ItemId_node_LaunchDist = graph.AddNode<FSItemNode>();
					GetPort("LaunchDist").Connect(ItemId_node_LaunchDist.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ItemId_node_LaunchDist, assetPath);
					variableCount += ItemId_node_LaunchDist.SetData((FSItem)LaunchDist, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ModeId:
					FSModeNode ModeId_node_LaunchDist = graph.AddNode<FSModeNode>();
					GetPort("LaunchDist").Connect(ModeId_node_LaunchDist.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ModeId_node_LaunchDist, assetPath);
					variableCount += ModeId_node_LaunchDist.SetData((FSMode)LaunchDist, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.JumpsId:
					FSJumpsNode JumpsId_node_LaunchDist = graph.AddNode<FSJumpsNode>();
					GetPort("LaunchDist").Connect(JumpsId_node_LaunchDist.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(JumpsId_node_LaunchDist, assetPath);
					variableCount += JumpsId_node_LaunchDist.SetData((FSJumps)LaunchDist, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RootAnimId:
					FSRootAnimNode RootAnimId_node_LaunchDist = graph.AddNode<FSRootAnimNode>();
					GetPort("LaunchDist").Connect(RootAnimId_node_LaunchDist.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RootAnimId_node_LaunchDist, assetPath);
					variableCount += RootAnimId_node_LaunchDist.SetData((FSRootAnim)LaunchDist, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FloatId:
					FSValueNode FloatId_node_LaunchDist = graph.AddNode<FSValueNode>();
					GetPort("LaunchDist").Connect(FloatId_node_LaunchDist.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FloatId_node_LaunchDist, assetPath);
					variableCount += FloatId_node_LaunchDist.SetData((FSValue)LaunchDist, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
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
			
			DiType = data.DiType;
			
			switch (DiType.TID)
			{
				case FloatSource.TypeId.AgentId:
					FSAgentNode AgentId_node_DiType = graph.AddNode<FSAgentNode>();
					GetPort("DiType").Connect(AgentId_node_DiType.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AgentId_node_DiType, assetPath);
					variableCount += AgentId_node_DiType.SetData((FSAgent)DiType, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.BonesId:
					FSBonesNode BonesId_node_DiType = graph.AddNode<FSBonesNode>();
					GetPort("DiType").Connect(BonesId_node_DiType.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BonesId_node_DiType, assetPath);
					variableCount += BonesId_node_DiType.SetData((FSBones)DiType, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AttackId:
					FSAttackNode AttackId_node_DiType = graph.AddNode<FSAttackNode>();
					GetPort("DiType").Connect(AttackId_node_DiType.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AttackId_node_DiType, assetPath);
					variableCount += AttackId_node_DiType.SetData((FSAttack)DiType, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FrameId:
					FSFrameNode FrameId_node_DiType = graph.AddNode<FSFrameNode>();
					GetPort("DiType").Connect(FrameId_node_DiType.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FrameId_node_DiType, assetPath);
					variableCount += FrameId_node_DiType.SetData((FSFrame)DiType, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.InputId:
					FSInputNode InputId_node_DiType = graph.AddNode<FSInputNode>();
					GetPort("DiType").Connect(InputId_node_DiType.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputId_node_DiType, assetPath);
					variableCount += InputId_node_DiType.SetData((FSInput)DiType, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FuncId:
					FSFuncNode FuncId_node_DiType = graph.AddNode<FSFuncNode>();
					GetPort("DiType").Connect(FuncId_node_DiType.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FuncId_node_DiType, assetPath);
					variableCount += FuncId_node_DiType.SetData((FSFunc)DiType, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.MovementId:
					FSMovementNode MovementId_node_DiType = graph.AddNode<FSMovementNode>();
					GetPort("DiType").Connect(MovementId_node_DiType.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(MovementId_node_DiType, assetPath);
					variableCount += MovementId_node_DiType.SetData((FSMovement)DiType, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CombatId:
					FSCombatNode CombatId_node_DiType = graph.AddNode<FSCombatNode>();
					GetPort("DiType").Connect(CombatId_node_DiType.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CombatId_node_DiType, assetPath);
					variableCount += CombatId_node_DiType.SetData((FSCombat)DiType, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.GrabsId:
					FSGrabsNode GrabsId_node_DiType = graph.AddNode<FSGrabsNode>();
					GetPort("DiType").Connect(GrabsId_node_DiType.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(GrabsId_node_DiType, assetPath);
					variableCount += GrabsId_node_DiType.SetData((FSGrabs)DiType, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.DataId:
					FSDataNode DataId_node_DiType = graph.AddNode<FSDataNode>();
					GetPort("DiType").Connect(DataId_node_DiType.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DataId_node_DiType, assetPath);
					variableCount += DataId_node_DiType.SetData((FSData)DiType, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ScratchId:
					FSScratchNode ScratchId_node_DiType = graph.AddNode<FSScratchNode>();
					GetPort("DiType").Connect(ScratchId_node_DiType.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ScratchId_node_DiType, assetPath);
					variableCount += ScratchId_node_DiType.SetData((FSScratch)DiType, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AnimId:
					FSAnimNode AnimId_node_DiType = graph.AddNode<FSAnimNode>();
					GetPort("DiType").Connect(AnimId_node_DiType.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AnimId_node_DiType, assetPath);
					variableCount += AnimId_node_DiType.SetData((FSAnim)DiType, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SpeedId:
					FSSpeedNode SpeedId_node_DiType = graph.AddNode<FSSpeedNode>();
					GetPort("DiType").Connect(SpeedId_node_DiType.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpeedId_node_DiType, assetPath);
					variableCount += SpeedId_node_DiType.SetData((FSSpeed)DiType, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.PhysicsId:
					FSPhysicsNode PhysicsId_node_DiType = graph.AddNode<FSPhysicsNode>();
					GetPort("DiType").Connect(PhysicsId_node_DiType.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(PhysicsId_node_DiType, assetPath);
					variableCount += PhysicsId_node_DiType.SetData((FSPhysics)DiType, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CollisionId:
					FSCollisionNode CollisionId_node_DiType = graph.AddNode<FSCollisionNode>();
					GetPort("DiType").Connect(CollisionId_node_DiType.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CollisionId_node_DiType, assetPath);
					variableCount += CollisionId_node_DiType.SetData((FSCollision)DiType, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.TimerId:
					FSTimerNode TimerId_node_DiType = graph.AddNode<FSTimerNode>();
					GetPort("DiType").Connect(TimerId_node_DiType.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(TimerId_node_DiType, assetPath);
					variableCount += TimerId_node_DiType.SetData((FSTimer)DiType, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.LagId:
					FSLagNode LagId_node_DiType = graph.AddNode<FSLagNode>();
					GetPort("DiType").Connect(LagId_node_DiType.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LagId_node_DiType, assetPath);
					variableCount += LagId_node_DiType.SetData((FSLag)DiType, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.EffectsId:
					FSEffectsNode EffectsId_node_DiType = graph.AddNode<FSEffectsNode>();
					GetPort("DiType").Connect(EffectsId_node_DiType.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EffectsId_node_DiType, assetPath);
					variableCount += EffectsId_node_DiType.SetData((FSEffects)DiType, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ColorsId:
					FSColorsNode ColorsId_node_DiType = graph.AddNode<FSColorsNode>();
					GetPort("DiType").Connect(ColorsId_node_DiType.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ColorsId_node_DiType, assetPath);
					variableCount += ColorsId_node_DiType.SetData((FSColors)DiType, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.OnHitId:
					FSOnHitNode OnHitId_node_DiType = graph.AddNode<FSOnHitNode>();
					GetPort("DiType").Connect(OnHitId_node_DiType.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnHitId_node_DiType, assetPath);
					variableCount += OnHitId_node_DiType.SetData((FSOnHit)DiType, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RandomId:
					FSRandomNode RandomId_node_DiType = graph.AddNode<FSRandomNode>();
					GetPort("DiType").Connect(RandomId_node_DiType.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RandomId_node_DiType, assetPath);
					variableCount += RandomId_node_DiType.SetData((FSRandom)DiType, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CameraId:
					FSCameraInfoNode CameraId_node_DiType = graph.AddNode<FSCameraInfoNode>();
					GetPort("DiType").Connect(CameraId_node_DiType.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CameraId_node_DiType, assetPath);
					variableCount += CameraId_node_DiType.SetData((FSCameraInfo)DiType, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SportsId:
					FSSportsNode SportsId_node_DiType = graph.AddNode<FSSportsNode>();
					GetPort("DiType").Connect(SportsId_node_DiType.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SportsId_node_DiType, assetPath);
					variableCount += SportsId_node_DiType.SetData((FSSports)DiType, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.Vector2Mag:
					FSVector2MagNode Vector2Mag_node_DiType = graph.AddNode<FSVector2MagNode>();
					GetPort("DiType").Connect(Vector2Mag_node_DiType.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(Vector2Mag_node_DiType, assetPath);
					variableCount += Vector2Mag_node_DiType.SetData((FSVector2Mag)DiType, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CPUHelpId:
					FSCpuHelpNode CPUHelpId_node_DiType = graph.AddNode<FSCpuHelpNode>();
					GetPort("DiType").Connect(CPUHelpId_node_DiType.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CPUHelpId_node_DiType, assetPath);
					variableCount += CPUHelpId_node_DiType.SetData((FSCpuHelp)DiType, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ItemId:
					FSItemNode ItemId_node_DiType = graph.AddNode<FSItemNode>();
					GetPort("DiType").Connect(ItemId_node_DiType.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ItemId_node_DiType, assetPath);
					variableCount += ItemId_node_DiType.SetData((FSItem)DiType, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ModeId:
					FSModeNode ModeId_node_DiType = graph.AddNode<FSModeNode>();
					GetPort("DiType").Connect(ModeId_node_DiType.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ModeId_node_DiType, assetPath);
					variableCount += ModeId_node_DiType.SetData((FSMode)DiType, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.JumpsId:
					FSJumpsNode JumpsId_node_DiType = graph.AddNode<FSJumpsNode>();
					GetPort("DiType").Connect(JumpsId_node_DiType.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(JumpsId_node_DiType, assetPath);
					variableCount += JumpsId_node_DiType.SetData((FSJumps)DiType, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RootAnimId:
					FSRootAnimNode RootAnimId_node_DiType = graph.AddNode<FSRootAnimNode>();
					GetPort("DiType").Connect(RootAnimId_node_DiType.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RootAnimId_node_DiType, assetPath);
					variableCount += RootAnimId_node_DiType.SetData((FSRootAnim)DiType, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FloatId:
					FSValueNode FloatId_node_DiType = graph.AddNode<FSValueNode>();
					GetPort("DiType").Connect(FloatId_node_DiType.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FloatId_node_DiType, assetPath);
					variableCount += FloatId_node_DiType.SetData((FSValue)DiType, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
			}
			++variableCount;
			
			DiAngleIn = data.DiAngleIn;
			
			switch (DiAngleIn.TID)
			{
				case FloatSource.TypeId.AgentId:
					FSAgentNode AgentId_node_DiAngleIn = graph.AddNode<FSAgentNode>();
					GetPort("DiAngleIn").Connect(AgentId_node_DiAngleIn.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AgentId_node_DiAngleIn, assetPath);
					variableCount += AgentId_node_DiAngleIn.SetData((FSAgent)DiAngleIn, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.BonesId:
					FSBonesNode BonesId_node_DiAngleIn = graph.AddNode<FSBonesNode>();
					GetPort("DiAngleIn").Connect(BonesId_node_DiAngleIn.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BonesId_node_DiAngleIn, assetPath);
					variableCount += BonesId_node_DiAngleIn.SetData((FSBones)DiAngleIn, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AttackId:
					FSAttackNode AttackId_node_DiAngleIn = graph.AddNode<FSAttackNode>();
					GetPort("DiAngleIn").Connect(AttackId_node_DiAngleIn.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AttackId_node_DiAngleIn, assetPath);
					variableCount += AttackId_node_DiAngleIn.SetData((FSAttack)DiAngleIn, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FrameId:
					FSFrameNode FrameId_node_DiAngleIn = graph.AddNode<FSFrameNode>();
					GetPort("DiAngleIn").Connect(FrameId_node_DiAngleIn.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FrameId_node_DiAngleIn, assetPath);
					variableCount += FrameId_node_DiAngleIn.SetData((FSFrame)DiAngleIn, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.InputId:
					FSInputNode InputId_node_DiAngleIn = graph.AddNode<FSInputNode>();
					GetPort("DiAngleIn").Connect(InputId_node_DiAngleIn.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputId_node_DiAngleIn, assetPath);
					variableCount += InputId_node_DiAngleIn.SetData((FSInput)DiAngleIn, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FuncId:
					FSFuncNode FuncId_node_DiAngleIn = graph.AddNode<FSFuncNode>();
					GetPort("DiAngleIn").Connect(FuncId_node_DiAngleIn.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FuncId_node_DiAngleIn, assetPath);
					variableCount += FuncId_node_DiAngleIn.SetData((FSFunc)DiAngleIn, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.MovementId:
					FSMovementNode MovementId_node_DiAngleIn = graph.AddNode<FSMovementNode>();
					GetPort("DiAngleIn").Connect(MovementId_node_DiAngleIn.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(MovementId_node_DiAngleIn, assetPath);
					variableCount += MovementId_node_DiAngleIn.SetData((FSMovement)DiAngleIn, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CombatId:
					FSCombatNode CombatId_node_DiAngleIn = graph.AddNode<FSCombatNode>();
					GetPort("DiAngleIn").Connect(CombatId_node_DiAngleIn.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CombatId_node_DiAngleIn, assetPath);
					variableCount += CombatId_node_DiAngleIn.SetData((FSCombat)DiAngleIn, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.GrabsId:
					FSGrabsNode GrabsId_node_DiAngleIn = graph.AddNode<FSGrabsNode>();
					GetPort("DiAngleIn").Connect(GrabsId_node_DiAngleIn.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(GrabsId_node_DiAngleIn, assetPath);
					variableCount += GrabsId_node_DiAngleIn.SetData((FSGrabs)DiAngleIn, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.DataId:
					FSDataNode DataId_node_DiAngleIn = graph.AddNode<FSDataNode>();
					GetPort("DiAngleIn").Connect(DataId_node_DiAngleIn.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DataId_node_DiAngleIn, assetPath);
					variableCount += DataId_node_DiAngleIn.SetData((FSData)DiAngleIn, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ScratchId:
					FSScratchNode ScratchId_node_DiAngleIn = graph.AddNode<FSScratchNode>();
					GetPort("DiAngleIn").Connect(ScratchId_node_DiAngleIn.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ScratchId_node_DiAngleIn, assetPath);
					variableCount += ScratchId_node_DiAngleIn.SetData((FSScratch)DiAngleIn, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AnimId:
					FSAnimNode AnimId_node_DiAngleIn = graph.AddNode<FSAnimNode>();
					GetPort("DiAngleIn").Connect(AnimId_node_DiAngleIn.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AnimId_node_DiAngleIn, assetPath);
					variableCount += AnimId_node_DiAngleIn.SetData((FSAnim)DiAngleIn, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SpeedId:
					FSSpeedNode SpeedId_node_DiAngleIn = graph.AddNode<FSSpeedNode>();
					GetPort("DiAngleIn").Connect(SpeedId_node_DiAngleIn.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpeedId_node_DiAngleIn, assetPath);
					variableCount += SpeedId_node_DiAngleIn.SetData((FSSpeed)DiAngleIn, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.PhysicsId:
					FSPhysicsNode PhysicsId_node_DiAngleIn = graph.AddNode<FSPhysicsNode>();
					GetPort("DiAngleIn").Connect(PhysicsId_node_DiAngleIn.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(PhysicsId_node_DiAngleIn, assetPath);
					variableCount += PhysicsId_node_DiAngleIn.SetData((FSPhysics)DiAngleIn, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CollisionId:
					FSCollisionNode CollisionId_node_DiAngleIn = graph.AddNode<FSCollisionNode>();
					GetPort("DiAngleIn").Connect(CollisionId_node_DiAngleIn.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CollisionId_node_DiAngleIn, assetPath);
					variableCount += CollisionId_node_DiAngleIn.SetData((FSCollision)DiAngleIn, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.TimerId:
					FSTimerNode TimerId_node_DiAngleIn = graph.AddNode<FSTimerNode>();
					GetPort("DiAngleIn").Connect(TimerId_node_DiAngleIn.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(TimerId_node_DiAngleIn, assetPath);
					variableCount += TimerId_node_DiAngleIn.SetData((FSTimer)DiAngleIn, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.LagId:
					FSLagNode LagId_node_DiAngleIn = graph.AddNode<FSLagNode>();
					GetPort("DiAngleIn").Connect(LagId_node_DiAngleIn.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LagId_node_DiAngleIn, assetPath);
					variableCount += LagId_node_DiAngleIn.SetData((FSLag)DiAngleIn, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.EffectsId:
					FSEffectsNode EffectsId_node_DiAngleIn = graph.AddNode<FSEffectsNode>();
					GetPort("DiAngleIn").Connect(EffectsId_node_DiAngleIn.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EffectsId_node_DiAngleIn, assetPath);
					variableCount += EffectsId_node_DiAngleIn.SetData((FSEffects)DiAngleIn, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ColorsId:
					FSColorsNode ColorsId_node_DiAngleIn = graph.AddNode<FSColorsNode>();
					GetPort("DiAngleIn").Connect(ColorsId_node_DiAngleIn.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ColorsId_node_DiAngleIn, assetPath);
					variableCount += ColorsId_node_DiAngleIn.SetData((FSColors)DiAngleIn, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.OnHitId:
					FSOnHitNode OnHitId_node_DiAngleIn = graph.AddNode<FSOnHitNode>();
					GetPort("DiAngleIn").Connect(OnHitId_node_DiAngleIn.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnHitId_node_DiAngleIn, assetPath);
					variableCount += OnHitId_node_DiAngleIn.SetData((FSOnHit)DiAngleIn, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RandomId:
					FSRandomNode RandomId_node_DiAngleIn = graph.AddNode<FSRandomNode>();
					GetPort("DiAngleIn").Connect(RandomId_node_DiAngleIn.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RandomId_node_DiAngleIn, assetPath);
					variableCount += RandomId_node_DiAngleIn.SetData((FSRandom)DiAngleIn, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CameraId:
					FSCameraInfoNode CameraId_node_DiAngleIn = graph.AddNode<FSCameraInfoNode>();
					GetPort("DiAngleIn").Connect(CameraId_node_DiAngleIn.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CameraId_node_DiAngleIn, assetPath);
					variableCount += CameraId_node_DiAngleIn.SetData((FSCameraInfo)DiAngleIn, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SportsId:
					FSSportsNode SportsId_node_DiAngleIn = graph.AddNode<FSSportsNode>();
					GetPort("DiAngleIn").Connect(SportsId_node_DiAngleIn.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SportsId_node_DiAngleIn, assetPath);
					variableCount += SportsId_node_DiAngleIn.SetData((FSSports)DiAngleIn, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.Vector2Mag:
					FSVector2MagNode Vector2Mag_node_DiAngleIn = graph.AddNode<FSVector2MagNode>();
					GetPort("DiAngleIn").Connect(Vector2Mag_node_DiAngleIn.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(Vector2Mag_node_DiAngleIn, assetPath);
					variableCount += Vector2Mag_node_DiAngleIn.SetData((FSVector2Mag)DiAngleIn, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CPUHelpId:
					FSCpuHelpNode CPUHelpId_node_DiAngleIn = graph.AddNode<FSCpuHelpNode>();
					GetPort("DiAngleIn").Connect(CPUHelpId_node_DiAngleIn.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CPUHelpId_node_DiAngleIn, assetPath);
					variableCount += CPUHelpId_node_DiAngleIn.SetData((FSCpuHelp)DiAngleIn, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ItemId:
					FSItemNode ItemId_node_DiAngleIn = graph.AddNode<FSItemNode>();
					GetPort("DiAngleIn").Connect(ItemId_node_DiAngleIn.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ItemId_node_DiAngleIn, assetPath);
					variableCount += ItemId_node_DiAngleIn.SetData((FSItem)DiAngleIn, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ModeId:
					FSModeNode ModeId_node_DiAngleIn = graph.AddNode<FSModeNode>();
					GetPort("DiAngleIn").Connect(ModeId_node_DiAngleIn.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ModeId_node_DiAngleIn, assetPath);
					variableCount += ModeId_node_DiAngleIn.SetData((FSMode)DiAngleIn, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.JumpsId:
					FSJumpsNode JumpsId_node_DiAngleIn = graph.AddNode<FSJumpsNode>();
					GetPort("DiAngleIn").Connect(JumpsId_node_DiAngleIn.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(JumpsId_node_DiAngleIn, assetPath);
					variableCount += JumpsId_node_DiAngleIn.SetData((FSJumps)DiAngleIn, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RootAnimId:
					FSRootAnimNode RootAnimId_node_DiAngleIn = graph.AddNode<FSRootAnimNode>();
					GetPort("DiAngleIn").Connect(RootAnimId_node_DiAngleIn.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RootAnimId_node_DiAngleIn, assetPath);
					variableCount += RootAnimId_node_DiAngleIn.SetData((FSRootAnim)DiAngleIn, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FloatId:
					FSValueNode FloatId_node_DiAngleIn = graph.AddNode<FSValueNode>();
					GetPort("DiAngleIn").Connect(FloatId_node_DiAngleIn.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FloatId_node_DiAngleIn, assetPath);
					variableCount += FloatId_node_DiAngleIn.SetData((FSValue)DiAngleIn, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
			}
			++variableCount;
			
			DiAngleOut = data.DiAngleOut;
			
			switch (DiAngleOut.TID)
			{
				case FloatSource.TypeId.AgentId:
					FSAgentNode AgentId_node_DiAngleOut = graph.AddNode<FSAgentNode>();
					GetPort("DiAngleOut").Connect(AgentId_node_DiAngleOut.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AgentId_node_DiAngleOut, assetPath);
					variableCount += AgentId_node_DiAngleOut.SetData((FSAgent)DiAngleOut, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.BonesId:
					FSBonesNode BonesId_node_DiAngleOut = graph.AddNode<FSBonesNode>();
					GetPort("DiAngleOut").Connect(BonesId_node_DiAngleOut.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BonesId_node_DiAngleOut, assetPath);
					variableCount += BonesId_node_DiAngleOut.SetData((FSBones)DiAngleOut, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AttackId:
					FSAttackNode AttackId_node_DiAngleOut = graph.AddNode<FSAttackNode>();
					GetPort("DiAngleOut").Connect(AttackId_node_DiAngleOut.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AttackId_node_DiAngleOut, assetPath);
					variableCount += AttackId_node_DiAngleOut.SetData((FSAttack)DiAngleOut, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FrameId:
					FSFrameNode FrameId_node_DiAngleOut = graph.AddNode<FSFrameNode>();
					GetPort("DiAngleOut").Connect(FrameId_node_DiAngleOut.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FrameId_node_DiAngleOut, assetPath);
					variableCount += FrameId_node_DiAngleOut.SetData((FSFrame)DiAngleOut, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.InputId:
					FSInputNode InputId_node_DiAngleOut = graph.AddNode<FSInputNode>();
					GetPort("DiAngleOut").Connect(InputId_node_DiAngleOut.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputId_node_DiAngleOut, assetPath);
					variableCount += InputId_node_DiAngleOut.SetData((FSInput)DiAngleOut, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FuncId:
					FSFuncNode FuncId_node_DiAngleOut = graph.AddNode<FSFuncNode>();
					GetPort("DiAngleOut").Connect(FuncId_node_DiAngleOut.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FuncId_node_DiAngleOut, assetPath);
					variableCount += FuncId_node_DiAngleOut.SetData((FSFunc)DiAngleOut, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.MovementId:
					FSMovementNode MovementId_node_DiAngleOut = graph.AddNode<FSMovementNode>();
					GetPort("DiAngleOut").Connect(MovementId_node_DiAngleOut.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(MovementId_node_DiAngleOut, assetPath);
					variableCount += MovementId_node_DiAngleOut.SetData((FSMovement)DiAngleOut, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CombatId:
					FSCombatNode CombatId_node_DiAngleOut = graph.AddNode<FSCombatNode>();
					GetPort("DiAngleOut").Connect(CombatId_node_DiAngleOut.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CombatId_node_DiAngleOut, assetPath);
					variableCount += CombatId_node_DiAngleOut.SetData((FSCombat)DiAngleOut, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.GrabsId:
					FSGrabsNode GrabsId_node_DiAngleOut = graph.AddNode<FSGrabsNode>();
					GetPort("DiAngleOut").Connect(GrabsId_node_DiAngleOut.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(GrabsId_node_DiAngleOut, assetPath);
					variableCount += GrabsId_node_DiAngleOut.SetData((FSGrabs)DiAngleOut, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.DataId:
					FSDataNode DataId_node_DiAngleOut = graph.AddNode<FSDataNode>();
					GetPort("DiAngleOut").Connect(DataId_node_DiAngleOut.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DataId_node_DiAngleOut, assetPath);
					variableCount += DataId_node_DiAngleOut.SetData((FSData)DiAngleOut, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ScratchId:
					FSScratchNode ScratchId_node_DiAngleOut = graph.AddNode<FSScratchNode>();
					GetPort("DiAngleOut").Connect(ScratchId_node_DiAngleOut.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ScratchId_node_DiAngleOut, assetPath);
					variableCount += ScratchId_node_DiAngleOut.SetData((FSScratch)DiAngleOut, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AnimId:
					FSAnimNode AnimId_node_DiAngleOut = graph.AddNode<FSAnimNode>();
					GetPort("DiAngleOut").Connect(AnimId_node_DiAngleOut.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AnimId_node_DiAngleOut, assetPath);
					variableCount += AnimId_node_DiAngleOut.SetData((FSAnim)DiAngleOut, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SpeedId:
					FSSpeedNode SpeedId_node_DiAngleOut = graph.AddNode<FSSpeedNode>();
					GetPort("DiAngleOut").Connect(SpeedId_node_DiAngleOut.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpeedId_node_DiAngleOut, assetPath);
					variableCount += SpeedId_node_DiAngleOut.SetData((FSSpeed)DiAngleOut, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.PhysicsId:
					FSPhysicsNode PhysicsId_node_DiAngleOut = graph.AddNode<FSPhysicsNode>();
					GetPort("DiAngleOut").Connect(PhysicsId_node_DiAngleOut.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(PhysicsId_node_DiAngleOut, assetPath);
					variableCount += PhysicsId_node_DiAngleOut.SetData((FSPhysics)DiAngleOut, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CollisionId:
					FSCollisionNode CollisionId_node_DiAngleOut = graph.AddNode<FSCollisionNode>();
					GetPort("DiAngleOut").Connect(CollisionId_node_DiAngleOut.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CollisionId_node_DiAngleOut, assetPath);
					variableCount += CollisionId_node_DiAngleOut.SetData((FSCollision)DiAngleOut, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.TimerId:
					FSTimerNode TimerId_node_DiAngleOut = graph.AddNode<FSTimerNode>();
					GetPort("DiAngleOut").Connect(TimerId_node_DiAngleOut.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(TimerId_node_DiAngleOut, assetPath);
					variableCount += TimerId_node_DiAngleOut.SetData((FSTimer)DiAngleOut, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.LagId:
					FSLagNode LagId_node_DiAngleOut = graph.AddNode<FSLagNode>();
					GetPort("DiAngleOut").Connect(LagId_node_DiAngleOut.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LagId_node_DiAngleOut, assetPath);
					variableCount += LagId_node_DiAngleOut.SetData((FSLag)DiAngleOut, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.EffectsId:
					FSEffectsNode EffectsId_node_DiAngleOut = graph.AddNode<FSEffectsNode>();
					GetPort("DiAngleOut").Connect(EffectsId_node_DiAngleOut.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EffectsId_node_DiAngleOut, assetPath);
					variableCount += EffectsId_node_DiAngleOut.SetData((FSEffects)DiAngleOut, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ColorsId:
					FSColorsNode ColorsId_node_DiAngleOut = graph.AddNode<FSColorsNode>();
					GetPort("DiAngleOut").Connect(ColorsId_node_DiAngleOut.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ColorsId_node_DiAngleOut, assetPath);
					variableCount += ColorsId_node_DiAngleOut.SetData((FSColors)DiAngleOut, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.OnHitId:
					FSOnHitNode OnHitId_node_DiAngleOut = graph.AddNode<FSOnHitNode>();
					GetPort("DiAngleOut").Connect(OnHitId_node_DiAngleOut.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnHitId_node_DiAngleOut, assetPath);
					variableCount += OnHitId_node_DiAngleOut.SetData((FSOnHit)DiAngleOut, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RandomId:
					FSRandomNode RandomId_node_DiAngleOut = graph.AddNode<FSRandomNode>();
					GetPort("DiAngleOut").Connect(RandomId_node_DiAngleOut.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RandomId_node_DiAngleOut, assetPath);
					variableCount += RandomId_node_DiAngleOut.SetData((FSRandom)DiAngleOut, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CameraId:
					FSCameraInfoNode CameraId_node_DiAngleOut = graph.AddNode<FSCameraInfoNode>();
					GetPort("DiAngleOut").Connect(CameraId_node_DiAngleOut.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CameraId_node_DiAngleOut, assetPath);
					variableCount += CameraId_node_DiAngleOut.SetData((FSCameraInfo)DiAngleOut, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SportsId:
					FSSportsNode SportsId_node_DiAngleOut = graph.AddNode<FSSportsNode>();
					GetPort("DiAngleOut").Connect(SportsId_node_DiAngleOut.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SportsId_node_DiAngleOut, assetPath);
					variableCount += SportsId_node_DiAngleOut.SetData((FSSports)DiAngleOut, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.Vector2Mag:
					FSVector2MagNode Vector2Mag_node_DiAngleOut = graph.AddNode<FSVector2MagNode>();
					GetPort("DiAngleOut").Connect(Vector2Mag_node_DiAngleOut.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(Vector2Mag_node_DiAngleOut, assetPath);
					variableCount += Vector2Mag_node_DiAngleOut.SetData((FSVector2Mag)DiAngleOut, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CPUHelpId:
					FSCpuHelpNode CPUHelpId_node_DiAngleOut = graph.AddNode<FSCpuHelpNode>();
					GetPort("DiAngleOut").Connect(CPUHelpId_node_DiAngleOut.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CPUHelpId_node_DiAngleOut, assetPath);
					variableCount += CPUHelpId_node_DiAngleOut.SetData((FSCpuHelp)DiAngleOut, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ItemId:
					FSItemNode ItemId_node_DiAngleOut = graph.AddNode<FSItemNode>();
					GetPort("DiAngleOut").Connect(ItemId_node_DiAngleOut.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ItemId_node_DiAngleOut, assetPath);
					variableCount += ItemId_node_DiAngleOut.SetData((FSItem)DiAngleOut, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ModeId:
					FSModeNode ModeId_node_DiAngleOut = graph.AddNode<FSModeNode>();
					GetPort("DiAngleOut").Connect(ModeId_node_DiAngleOut.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ModeId_node_DiAngleOut, assetPath);
					variableCount += ModeId_node_DiAngleOut.SetData((FSMode)DiAngleOut, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.JumpsId:
					FSJumpsNode JumpsId_node_DiAngleOut = graph.AddNode<FSJumpsNode>();
					GetPort("DiAngleOut").Connect(JumpsId_node_DiAngleOut.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(JumpsId_node_DiAngleOut, assetPath);
					variableCount += JumpsId_node_DiAngleOut.SetData((FSJumps)DiAngleOut, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RootAnimId:
					FSRootAnimNode RootAnimId_node_DiAngleOut = graph.AddNode<FSRootAnimNode>();
					GetPort("DiAngleOut").Connect(RootAnimId_node_DiAngleOut.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RootAnimId_node_DiAngleOut, assetPath);
					variableCount += RootAnimId_node_DiAngleOut.SetData((FSRootAnim)DiAngleOut, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FloatId:
					FSValueNode FloatId_node_DiAngleOut = graph.AddNode<FSValueNode>();
					GetPort("DiAngleOut").Connect(FloatId_node_DiAngleOut.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FloatId_node_DiAngleOut, assetPath);
					variableCount += FloatId_node_DiAngleOut.SetData((FSValue)DiAngleOut, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
			}
			
			return variableCount;
		}
		
		public new KnockbackJump GetData()
		{
			KnockbackJump objToReturn = new KnockbackJump();
			objToReturn.TID = TypeId.KnockbackId;
			objToReturn.Version = Version;
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
			if (GetPort("LaunchDist").ConnectionCount > 0)
			{
				FloatSourceNode FloatSource_Node = (FloatSourceNode)GetPort("LaunchDist").GetConnection(0).node;
				switch (FloatSource_Node.TID)
				{
					case FloatSource.TypeId.AgentId:
						FSAgentNode AgentId_FloatSource_Node = (FSAgentNode)GetPort("LaunchDist").GetConnection(0).node;
						objToReturn.LaunchDist = AgentId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.BonesId:
						FSBonesNode BonesId_FloatSource_Node = (FSBonesNode)GetPort("LaunchDist").GetConnection(0).node;
						objToReturn.LaunchDist = BonesId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AttackId:
						FSAttackNode AttackId_FloatSource_Node = (FSAttackNode)GetPort("LaunchDist").GetConnection(0).node;
						objToReturn.LaunchDist = AttackId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FrameId:
						FSFrameNode FrameId_FloatSource_Node = (FSFrameNode)GetPort("LaunchDist").GetConnection(0).node;
						objToReturn.LaunchDist = FrameId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.InputId:
						FSInputNode InputId_FloatSource_Node = (FSInputNode)GetPort("LaunchDist").GetConnection(0).node;
						objToReturn.LaunchDist = InputId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FuncId:
						FSFuncNode FuncId_FloatSource_Node = (FSFuncNode)GetPort("LaunchDist").GetConnection(0).node;
						objToReturn.LaunchDist = FuncId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.MovementId:
						FSMovementNode MovementId_FloatSource_Node = (FSMovementNode)GetPort("LaunchDist").GetConnection(0).node;
						objToReturn.LaunchDist = MovementId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CombatId:
						FSCombatNode CombatId_FloatSource_Node = (FSCombatNode)GetPort("LaunchDist").GetConnection(0).node;
						objToReturn.LaunchDist = CombatId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.GrabsId:
						FSGrabsNode GrabsId_FloatSource_Node = (FSGrabsNode)GetPort("LaunchDist").GetConnection(0).node;
						objToReturn.LaunchDist = GrabsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.DataId:
						FSDataNode DataId_FloatSource_Node = (FSDataNode)GetPort("LaunchDist").GetConnection(0).node;
						objToReturn.LaunchDist = DataId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ScratchId:
						FSScratchNode ScratchId_FloatSource_Node = (FSScratchNode)GetPort("LaunchDist").GetConnection(0).node;
						objToReturn.LaunchDist = ScratchId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AnimId:
						FSAnimNode AnimId_FloatSource_Node = (FSAnimNode)GetPort("LaunchDist").GetConnection(0).node;
						objToReturn.LaunchDist = AnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SpeedId:
						FSSpeedNode SpeedId_FloatSource_Node = (FSSpeedNode)GetPort("LaunchDist").GetConnection(0).node;
						objToReturn.LaunchDist = SpeedId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.PhysicsId:
						FSPhysicsNode PhysicsId_FloatSource_Node = (FSPhysicsNode)GetPort("LaunchDist").GetConnection(0).node;
						objToReturn.LaunchDist = PhysicsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CollisionId:
						FSCollisionNode CollisionId_FloatSource_Node = (FSCollisionNode)GetPort("LaunchDist").GetConnection(0).node;
						objToReturn.LaunchDist = CollisionId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.TimerId:
						FSTimerNode TimerId_FloatSource_Node = (FSTimerNode)GetPort("LaunchDist").GetConnection(0).node;
						objToReturn.LaunchDist = TimerId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.LagId:
						FSLagNode LagId_FloatSource_Node = (FSLagNode)GetPort("LaunchDist").GetConnection(0).node;
						objToReturn.LaunchDist = LagId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.EffectsId:
						FSEffectsNode EffectsId_FloatSource_Node = (FSEffectsNode)GetPort("LaunchDist").GetConnection(0).node;
						objToReturn.LaunchDist = EffectsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ColorsId:
						FSColorsNode ColorsId_FloatSource_Node = (FSColorsNode)GetPort("LaunchDist").GetConnection(0).node;
						objToReturn.LaunchDist = ColorsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.OnHitId:
						FSOnHitNode OnHitId_FloatSource_Node = (FSOnHitNode)GetPort("LaunchDist").GetConnection(0).node;
						objToReturn.LaunchDist = OnHitId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RandomId:
						FSRandomNode RandomId_FloatSource_Node = (FSRandomNode)GetPort("LaunchDist").GetConnection(0).node;
						objToReturn.LaunchDist = RandomId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CameraId:
						FSCameraInfoNode CameraId_FloatSource_Node = (FSCameraInfoNode)GetPort("LaunchDist").GetConnection(0).node;
						objToReturn.LaunchDist = CameraId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SportsId:
						FSSportsNode SportsId_FloatSource_Node = (FSSportsNode)GetPort("LaunchDist").GetConnection(0).node;
						objToReturn.LaunchDist = SportsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.Vector2Mag:
						FSVector2MagNode Vector2Mag_FloatSource_Node = (FSVector2MagNode)GetPort("LaunchDist").GetConnection(0).node;
						objToReturn.LaunchDist = Vector2Mag_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CPUHelpId:
						FSCpuHelpNode CPUHelpId_FloatSource_Node = (FSCpuHelpNode)GetPort("LaunchDist").GetConnection(0).node;
						objToReturn.LaunchDist = CPUHelpId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ItemId:
						FSItemNode ItemId_FloatSource_Node = (FSItemNode)GetPort("LaunchDist").GetConnection(0).node;
						objToReturn.LaunchDist = ItemId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ModeId:
						FSModeNode ModeId_FloatSource_Node = (FSModeNode)GetPort("LaunchDist").GetConnection(0).node;
						objToReturn.LaunchDist = ModeId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.JumpsId:
						FSJumpsNode JumpsId_FloatSource_Node = (FSJumpsNode)GetPort("LaunchDist").GetConnection(0).node;
						objToReturn.LaunchDist = JumpsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RootAnimId:
						FSRootAnimNode RootAnimId_FloatSource_Node = (FSRootAnimNode)GetPort("LaunchDist").GetConnection(0).node;
						objToReturn.LaunchDist = RootAnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FloatId:
						FSValueNode FloatId_FloatSource_Node = (FSValueNode)GetPort("LaunchDist").GetConnection(0).node;
						objToReturn.LaunchDist = FloatId_FloatSource_Node.GetData();
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
			if (GetPort("DiType").ConnectionCount > 0)
			{
				FloatSourceNode FloatSource_Node = (FloatSourceNode)GetPort("DiType").GetConnection(0).node;
				switch (FloatSource_Node.TID)
				{
					case FloatSource.TypeId.AgentId:
						FSAgentNode AgentId_FloatSource_Node = (FSAgentNode)GetPort("DiType").GetConnection(0).node;
						objToReturn.DiType = AgentId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.BonesId:
						FSBonesNode BonesId_FloatSource_Node = (FSBonesNode)GetPort("DiType").GetConnection(0).node;
						objToReturn.DiType = BonesId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AttackId:
						FSAttackNode AttackId_FloatSource_Node = (FSAttackNode)GetPort("DiType").GetConnection(0).node;
						objToReturn.DiType = AttackId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FrameId:
						FSFrameNode FrameId_FloatSource_Node = (FSFrameNode)GetPort("DiType").GetConnection(0).node;
						objToReturn.DiType = FrameId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.InputId:
						FSInputNode InputId_FloatSource_Node = (FSInputNode)GetPort("DiType").GetConnection(0).node;
						objToReturn.DiType = InputId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FuncId:
						FSFuncNode FuncId_FloatSource_Node = (FSFuncNode)GetPort("DiType").GetConnection(0).node;
						objToReturn.DiType = FuncId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.MovementId:
						FSMovementNode MovementId_FloatSource_Node = (FSMovementNode)GetPort("DiType").GetConnection(0).node;
						objToReturn.DiType = MovementId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CombatId:
						FSCombatNode CombatId_FloatSource_Node = (FSCombatNode)GetPort("DiType").GetConnection(0).node;
						objToReturn.DiType = CombatId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.GrabsId:
						FSGrabsNode GrabsId_FloatSource_Node = (FSGrabsNode)GetPort("DiType").GetConnection(0).node;
						objToReturn.DiType = GrabsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.DataId:
						FSDataNode DataId_FloatSource_Node = (FSDataNode)GetPort("DiType").GetConnection(0).node;
						objToReturn.DiType = DataId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ScratchId:
						FSScratchNode ScratchId_FloatSource_Node = (FSScratchNode)GetPort("DiType").GetConnection(0).node;
						objToReturn.DiType = ScratchId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AnimId:
						FSAnimNode AnimId_FloatSource_Node = (FSAnimNode)GetPort("DiType").GetConnection(0).node;
						objToReturn.DiType = AnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SpeedId:
						FSSpeedNode SpeedId_FloatSource_Node = (FSSpeedNode)GetPort("DiType").GetConnection(0).node;
						objToReturn.DiType = SpeedId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.PhysicsId:
						FSPhysicsNode PhysicsId_FloatSource_Node = (FSPhysicsNode)GetPort("DiType").GetConnection(0).node;
						objToReturn.DiType = PhysicsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CollisionId:
						FSCollisionNode CollisionId_FloatSource_Node = (FSCollisionNode)GetPort("DiType").GetConnection(0).node;
						objToReturn.DiType = CollisionId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.TimerId:
						FSTimerNode TimerId_FloatSource_Node = (FSTimerNode)GetPort("DiType").GetConnection(0).node;
						objToReturn.DiType = TimerId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.LagId:
						FSLagNode LagId_FloatSource_Node = (FSLagNode)GetPort("DiType").GetConnection(0).node;
						objToReturn.DiType = LagId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.EffectsId:
						FSEffectsNode EffectsId_FloatSource_Node = (FSEffectsNode)GetPort("DiType").GetConnection(0).node;
						objToReturn.DiType = EffectsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ColorsId:
						FSColorsNode ColorsId_FloatSource_Node = (FSColorsNode)GetPort("DiType").GetConnection(0).node;
						objToReturn.DiType = ColorsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.OnHitId:
						FSOnHitNode OnHitId_FloatSource_Node = (FSOnHitNode)GetPort("DiType").GetConnection(0).node;
						objToReturn.DiType = OnHitId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RandomId:
						FSRandomNode RandomId_FloatSource_Node = (FSRandomNode)GetPort("DiType").GetConnection(0).node;
						objToReturn.DiType = RandomId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CameraId:
						FSCameraInfoNode CameraId_FloatSource_Node = (FSCameraInfoNode)GetPort("DiType").GetConnection(0).node;
						objToReturn.DiType = CameraId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SportsId:
						FSSportsNode SportsId_FloatSource_Node = (FSSportsNode)GetPort("DiType").GetConnection(0).node;
						objToReturn.DiType = SportsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.Vector2Mag:
						FSVector2MagNode Vector2Mag_FloatSource_Node = (FSVector2MagNode)GetPort("DiType").GetConnection(0).node;
						objToReturn.DiType = Vector2Mag_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CPUHelpId:
						FSCpuHelpNode CPUHelpId_FloatSource_Node = (FSCpuHelpNode)GetPort("DiType").GetConnection(0).node;
						objToReturn.DiType = CPUHelpId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ItemId:
						FSItemNode ItemId_FloatSource_Node = (FSItemNode)GetPort("DiType").GetConnection(0).node;
						objToReturn.DiType = ItemId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ModeId:
						FSModeNode ModeId_FloatSource_Node = (FSModeNode)GetPort("DiType").GetConnection(0).node;
						objToReturn.DiType = ModeId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.JumpsId:
						FSJumpsNode JumpsId_FloatSource_Node = (FSJumpsNode)GetPort("DiType").GetConnection(0).node;
						objToReturn.DiType = JumpsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RootAnimId:
						FSRootAnimNode RootAnimId_FloatSource_Node = (FSRootAnimNode)GetPort("DiType").GetConnection(0).node;
						objToReturn.DiType = RootAnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FloatId:
						FSValueNode FloatId_FloatSource_Node = (FSValueNode)GetPort("DiType").GetConnection(0).node;
						objToReturn.DiType = FloatId_FloatSource_Node.GetData();
					break;
				}
			}
			if (GetPort("DiAngleIn").ConnectionCount > 0)
			{
				FloatSourceNode FloatSource_Node = (FloatSourceNode)GetPort("DiAngleIn").GetConnection(0).node;
				switch (FloatSource_Node.TID)
				{
					case FloatSource.TypeId.AgentId:
						FSAgentNode AgentId_FloatSource_Node = (FSAgentNode)GetPort("DiAngleIn").GetConnection(0).node;
						objToReturn.DiAngleIn = AgentId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.BonesId:
						FSBonesNode BonesId_FloatSource_Node = (FSBonesNode)GetPort("DiAngleIn").GetConnection(0).node;
						objToReturn.DiAngleIn = BonesId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AttackId:
						FSAttackNode AttackId_FloatSource_Node = (FSAttackNode)GetPort("DiAngleIn").GetConnection(0).node;
						objToReturn.DiAngleIn = AttackId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FrameId:
						FSFrameNode FrameId_FloatSource_Node = (FSFrameNode)GetPort("DiAngleIn").GetConnection(0).node;
						objToReturn.DiAngleIn = FrameId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.InputId:
						FSInputNode InputId_FloatSource_Node = (FSInputNode)GetPort("DiAngleIn").GetConnection(0).node;
						objToReturn.DiAngleIn = InputId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FuncId:
						FSFuncNode FuncId_FloatSource_Node = (FSFuncNode)GetPort("DiAngleIn").GetConnection(0).node;
						objToReturn.DiAngleIn = FuncId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.MovementId:
						FSMovementNode MovementId_FloatSource_Node = (FSMovementNode)GetPort("DiAngleIn").GetConnection(0).node;
						objToReturn.DiAngleIn = MovementId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CombatId:
						FSCombatNode CombatId_FloatSource_Node = (FSCombatNode)GetPort("DiAngleIn").GetConnection(0).node;
						objToReturn.DiAngleIn = CombatId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.GrabsId:
						FSGrabsNode GrabsId_FloatSource_Node = (FSGrabsNode)GetPort("DiAngleIn").GetConnection(0).node;
						objToReturn.DiAngleIn = GrabsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.DataId:
						FSDataNode DataId_FloatSource_Node = (FSDataNode)GetPort("DiAngleIn").GetConnection(0).node;
						objToReturn.DiAngleIn = DataId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ScratchId:
						FSScratchNode ScratchId_FloatSource_Node = (FSScratchNode)GetPort("DiAngleIn").GetConnection(0).node;
						objToReturn.DiAngleIn = ScratchId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AnimId:
						FSAnimNode AnimId_FloatSource_Node = (FSAnimNode)GetPort("DiAngleIn").GetConnection(0).node;
						objToReturn.DiAngleIn = AnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SpeedId:
						FSSpeedNode SpeedId_FloatSource_Node = (FSSpeedNode)GetPort("DiAngleIn").GetConnection(0).node;
						objToReturn.DiAngleIn = SpeedId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.PhysicsId:
						FSPhysicsNode PhysicsId_FloatSource_Node = (FSPhysicsNode)GetPort("DiAngleIn").GetConnection(0).node;
						objToReturn.DiAngleIn = PhysicsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CollisionId:
						FSCollisionNode CollisionId_FloatSource_Node = (FSCollisionNode)GetPort("DiAngleIn").GetConnection(0).node;
						objToReturn.DiAngleIn = CollisionId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.TimerId:
						FSTimerNode TimerId_FloatSource_Node = (FSTimerNode)GetPort("DiAngleIn").GetConnection(0).node;
						objToReturn.DiAngleIn = TimerId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.LagId:
						FSLagNode LagId_FloatSource_Node = (FSLagNode)GetPort("DiAngleIn").GetConnection(0).node;
						objToReturn.DiAngleIn = LagId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.EffectsId:
						FSEffectsNode EffectsId_FloatSource_Node = (FSEffectsNode)GetPort("DiAngleIn").GetConnection(0).node;
						objToReturn.DiAngleIn = EffectsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ColorsId:
						FSColorsNode ColorsId_FloatSource_Node = (FSColorsNode)GetPort("DiAngleIn").GetConnection(0).node;
						objToReturn.DiAngleIn = ColorsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.OnHitId:
						FSOnHitNode OnHitId_FloatSource_Node = (FSOnHitNode)GetPort("DiAngleIn").GetConnection(0).node;
						objToReturn.DiAngleIn = OnHitId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RandomId:
						FSRandomNode RandomId_FloatSource_Node = (FSRandomNode)GetPort("DiAngleIn").GetConnection(0).node;
						objToReturn.DiAngleIn = RandomId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CameraId:
						FSCameraInfoNode CameraId_FloatSource_Node = (FSCameraInfoNode)GetPort("DiAngleIn").GetConnection(0).node;
						objToReturn.DiAngleIn = CameraId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SportsId:
						FSSportsNode SportsId_FloatSource_Node = (FSSportsNode)GetPort("DiAngleIn").GetConnection(0).node;
						objToReturn.DiAngleIn = SportsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.Vector2Mag:
						FSVector2MagNode Vector2Mag_FloatSource_Node = (FSVector2MagNode)GetPort("DiAngleIn").GetConnection(0).node;
						objToReturn.DiAngleIn = Vector2Mag_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CPUHelpId:
						FSCpuHelpNode CPUHelpId_FloatSource_Node = (FSCpuHelpNode)GetPort("DiAngleIn").GetConnection(0).node;
						objToReturn.DiAngleIn = CPUHelpId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ItemId:
						FSItemNode ItemId_FloatSource_Node = (FSItemNode)GetPort("DiAngleIn").GetConnection(0).node;
						objToReturn.DiAngleIn = ItemId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ModeId:
						FSModeNode ModeId_FloatSource_Node = (FSModeNode)GetPort("DiAngleIn").GetConnection(0).node;
						objToReturn.DiAngleIn = ModeId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.JumpsId:
						FSJumpsNode JumpsId_FloatSource_Node = (FSJumpsNode)GetPort("DiAngleIn").GetConnection(0).node;
						objToReturn.DiAngleIn = JumpsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RootAnimId:
						FSRootAnimNode RootAnimId_FloatSource_Node = (FSRootAnimNode)GetPort("DiAngleIn").GetConnection(0).node;
						objToReturn.DiAngleIn = RootAnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FloatId:
						FSValueNode FloatId_FloatSource_Node = (FSValueNode)GetPort("DiAngleIn").GetConnection(0).node;
						objToReturn.DiAngleIn = FloatId_FloatSource_Node.GetData();
					break;
				}
			}
			if (GetPort("DiAngleOut").ConnectionCount > 0)
			{
				FloatSourceNode FloatSource_Node = (FloatSourceNode)GetPort("DiAngleOut").GetConnection(0).node;
				switch (FloatSource_Node.TID)
				{
					case FloatSource.TypeId.AgentId:
						FSAgentNode AgentId_FloatSource_Node = (FSAgentNode)GetPort("DiAngleOut").GetConnection(0).node;
						objToReturn.DiAngleOut = AgentId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.BonesId:
						FSBonesNode BonesId_FloatSource_Node = (FSBonesNode)GetPort("DiAngleOut").GetConnection(0).node;
						objToReturn.DiAngleOut = BonesId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AttackId:
						FSAttackNode AttackId_FloatSource_Node = (FSAttackNode)GetPort("DiAngleOut").GetConnection(0).node;
						objToReturn.DiAngleOut = AttackId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FrameId:
						FSFrameNode FrameId_FloatSource_Node = (FSFrameNode)GetPort("DiAngleOut").GetConnection(0).node;
						objToReturn.DiAngleOut = FrameId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.InputId:
						FSInputNode InputId_FloatSource_Node = (FSInputNode)GetPort("DiAngleOut").GetConnection(0).node;
						objToReturn.DiAngleOut = InputId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FuncId:
						FSFuncNode FuncId_FloatSource_Node = (FSFuncNode)GetPort("DiAngleOut").GetConnection(0).node;
						objToReturn.DiAngleOut = FuncId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.MovementId:
						FSMovementNode MovementId_FloatSource_Node = (FSMovementNode)GetPort("DiAngleOut").GetConnection(0).node;
						objToReturn.DiAngleOut = MovementId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CombatId:
						FSCombatNode CombatId_FloatSource_Node = (FSCombatNode)GetPort("DiAngleOut").GetConnection(0).node;
						objToReturn.DiAngleOut = CombatId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.GrabsId:
						FSGrabsNode GrabsId_FloatSource_Node = (FSGrabsNode)GetPort("DiAngleOut").GetConnection(0).node;
						objToReturn.DiAngleOut = GrabsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.DataId:
						FSDataNode DataId_FloatSource_Node = (FSDataNode)GetPort("DiAngleOut").GetConnection(0).node;
						objToReturn.DiAngleOut = DataId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ScratchId:
						FSScratchNode ScratchId_FloatSource_Node = (FSScratchNode)GetPort("DiAngleOut").GetConnection(0).node;
						objToReturn.DiAngleOut = ScratchId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AnimId:
						FSAnimNode AnimId_FloatSource_Node = (FSAnimNode)GetPort("DiAngleOut").GetConnection(0).node;
						objToReturn.DiAngleOut = AnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SpeedId:
						FSSpeedNode SpeedId_FloatSource_Node = (FSSpeedNode)GetPort("DiAngleOut").GetConnection(0).node;
						objToReturn.DiAngleOut = SpeedId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.PhysicsId:
						FSPhysicsNode PhysicsId_FloatSource_Node = (FSPhysicsNode)GetPort("DiAngleOut").GetConnection(0).node;
						objToReturn.DiAngleOut = PhysicsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CollisionId:
						FSCollisionNode CollisionId_FloatSource_Node = (FSCollisionNode)GetPort("DiAngleOut").GetConnection(0).node;
						objToReturn.DiAngleOut = CollisionId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.TimerId:
						FSTimerNode TimerId_FloatSource_Node = (FSTimerNode)GetPort("DiAngleOut").GetConnection(0).node;
						objToReturn.DiAngleOut = TimerId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.LagId:
						FSLagNode LagId_FloatSource_Node = (FSLagNode)GetPort("DiAngleOut").GetConnection(0).node;
						objToReturn.DiAngleOut = LagId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.EffectsId:
						FSEffectsNode EffectsId_FloatSource_Node = (FSEffectsNode)GetPort("DiAngleOut").GetConnection(0).node;
						objToReturn.DiAngleOut = EffectsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ColorsId:
						FSColorsNode ColorsId_FloatSource_Node = (FSColorsNode)GetPort("DiAngleOut").GetConnection(0).node;
						objToReturn.DiAngleOut = ColorsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.OnHitId:
						FSOnHitNode OnHitId_FloatSource_Node = (FSOnHitNode)GetPort("DiAngleOut").GetConnection(0).node;
						objToReturn.DiAngleOut = OnHitId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RandomId:
						FSRandomNode RandomId_FloatSource_Node = (FSRandomNode)GetPort("DiAngleOut").GetConnection(0).node;
						objToReturn.DiAngleOut = RandomId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CameraId:
						FSCameraInfoNode CameraId_FloatSource_Node = (FSCameraInfoNode)GetPort("DiAngleOut").GetConnection(0).node;
						objToReturn.DiAngleOut = CameraId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SportsId:
						FSSportsNode SportsId_FloatSource_Node = (FSSportsNode)GetPort("DiAngleOut").GetConnection(0).node;
						objToReturn.DiAngleOut = SportsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.Vector2Mag:
						FSVector2MagNode Vector2Mag_FloatSource_Node = (FSVector2MagNode)GetPort("DiAngleOut").GetConnection(0).node;
						objToReturn.DiAngleOut = Vector2Mag_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CPUHelpId:
						FSCpuHelpNode CPUHelpId_FloatSource_Node = (FSCpuHelpNode)GetPort("DiAngleOut").GetConnection(0).node;
						objToReturn.DiAngleOut = CPUHelpId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ItemId:
						FSItemNode ItemId_FloatSource_Node = (FSItemNode)GetPort("DiAngleOut").GetConnection(0).node;
						objToReturn.DiAngleOut = ItemId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ModeId:
						FSModeNode ModeId_FloatSource_Node = (FSModeNode)GetPort("DiAngleOut").GetConnection(0).node;
						objToReturn.DiAngleOut = ModeId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.JumpsId:
						FSJumpsNode JumpsId_FloatSource_Node = (FSJumpsNode)GetPort("DiAngleOut").GetConnection(0).node;
						objToReturn.DiAngleOut = JumpsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RootAnimId:
						FSRootAnimNode RootAnimId_FloatSource_Node = (FSRootAnimNode)GetPort("DiAngleOut").GetConnection(0).node;
						objToReturn.DiAngleOut = RootAnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FloatId:
						FSValueNode FloatId_FloatSource_Node = (FSValueNode)GetPort("DiAngleOut").GetConnection(0).node;
						objToReturn.DiAngleOut = FloatId_FloatSource_Node.GetData();
					break;
				}
			}
			return objToReturn;
		}
	}
}

