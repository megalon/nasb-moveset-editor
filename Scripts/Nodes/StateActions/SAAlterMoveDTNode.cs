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
using static NASB_Parser.StateActions.StateAction;

namespace NASB_Moveset_Editor.StateActions
{
	public class SAAlterMoveDTNode : StateActionNode
	{
		[Input(connectionType = ConnectionType.Override)] public StateAction NodeInput;
		public bool ClearAMDT;
		[Output(connectionType = ConnectionType.Override)] public FloatSource After;
		[Output(connectionType = ConnectionType.Override)] public FloatSource Falloff;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.AlterMoveDtId;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SAAlterMoveDT data, MovesetGraph graph, string assetPath, Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SAAlterMoveDT));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			ClearAMDT = data.ClearAMDT;
			After = data.After;
			
			switch (After.TID)
			{
				case FloatSource.TypeId.AgentId:
					FSAgentNode AgentId_node_After = graph.AddNode<FSAgentNode>();
					GetPort("After").Connect(AgentId_node_After.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AgentId_node_After, assetPath);
					variableCount += AgentId_node_After.SetData((FSAgent)After, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.BonesId:
					FSBonesNode BonesId_node_After = graph.AddNode<FSBonesNode>();
					GetPort("After").Connect(BonesId_node_After.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BonesId_node_After, assetPath);
					variableCount += BonesId_node_After.SetData((FSBones)After, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AttackId:
					FSAttackNode AttackId_node_After = graph.AddNode<FSAttackNode>();
					GetPort("After").Connect(AttackId_node_After.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AttackId_node_After, assetPath);
					variableCount += AttackId_node_After.SetData((FSAttack)After, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FrameId:
					FSFrameNode FrameId_node_After = graph.AddNode<FSFrameNode>();
					GetPort("After").Connect(FrameId_node_After.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FrameId_node_After, assetPath);
					variableCount += FrameId_node_After.SetData((FSFrame)After, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.InputId:
					FSInputNode InputId_node_After = graph.AddNode<FSInputNode>();
					GetPort("After").Connect(InputId_node_After.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputId_node_After, assetPath);
					variableCount += InputId_node_After.SetData((FSInput)After, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FuncId:
					FSFuncNode FuncId_node_After = graph.AddNode<FSFuncNode>();
					GetPort("After").Connect(FuncId_node_After.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FuncId_node_After, assetPath);
					variableCount += FuncId_node_After.SetData((FSFunc)After, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.MovementId:
					FSMovementNode MovementId_node_After = graph.AddNode<FSMovementNode>();
					GetPort("After").Connect(MovementId_node_After.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(MovementId_node_After, assetPath);
					variableCount += MovementId_node_After.SetData((FSMovement)After, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CombatId:
					FSCombatNode CombatId_node_After = graph.AddNode<FSCombatNode>();
					GetPort("After").Connect(CombatId_node_After.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CombatId_node_After, assetPath);
					variableCount += CombatId_node_After.SetData((FSCombat)After, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.GrabsId:
					FSGrabsNode GrabsId_node_After = graph.AddNode<FSGrabsNode>();
					GetPort("After").Connect(GrabsId_node_After.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(GrabsId_node_After, assetPath);
					variableCount += GrabsId_node_After.SetData((FSGrabs)After, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.DataId:
					FSDataNode DataId_node_After = graph.AddNode<FSDataNode>();
					GetPort("After").Connect(DataId_node_After.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DataId_node_After, assetPath);
					variableCount += DataId_node_After.SetData((FSData)After, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ScratchId:
					FSScratchNode ScratchId_node_After = graph.AddNode<FSScratchNode>();
					GetPort("After").Connect(ScratchId_node_After.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ScratchId_node_After, assetPath);
					variableCount += ScratchId_node_After.SetData((FSScratch)After, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AnimId:
					FSAnimNode AnimId_node_After = graph.AddNode<FSAnimNode>();
					GetPort("After").Connect(AnimId_node_After.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AnimId_node_After, assetPath);
					variableCount += AnimId_node_After.SetData((FSAnim)After, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SpeedId:
					FSSpeedNode SpeedId_node_After = graph.AddNode<FSSpeedNode>();
					GetPort("After").Connect(SpeedId_node_After.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpeedId_node_After, assetPath);
					variableCount += SpeedId_node_After.SetData((FSSpeed)After, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.PhysicsId:
					FSPhysicsNode PhysicsId_node_After = graph.AddNode<FSPhysicsNode>();
					GetPort("After").Connect(PhysicsId_node_After.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(PhysicsId_node_After, assetPath);
					variableCount += PhysicsId_node_After.SetData((FSPhysics)After, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CollisionId:
					FSCollisionNode CollisionId_node_After = graph.AddNode<FSCollisionNode>();
					GetPort("After").Connect(CollisionId_node_After.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CollisionId_node_After, assetPath);
					variableCount += CollisionId_node_After.SetData((FSCollision)After, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.TimerId:
					FSTimerNode TimerId_node_After = graph.AddNode<FSTimerNode>();
					GetPort("After").Connect(TimerId_node_After.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(TimerId_node_After, assetPath);
					variableCount += TimerId_node_After.SetData((FSTimer)After, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.LagId:
					FSLagNode LagId_node_After = graph.AddNode<FSLagNode>();
					GetPort("After").Connect(LagId_node_After.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LagId_node_After, assetPath);
					variableCount += LagId_node_After.SetData((FSLag)After, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.EffectsId:
					FSEffectsNode EffectsId_node_After = graph.AddNode<FSEffectsNode>();
					GetPort("After").Connect(EffectsId_node_After.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EffectsId_node_After, assetPath);
					variableCount += EffectsId_node_After.SetData((FSEffects)After, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ColorsId:
					FSColorsNode ColorsId_node_After = graph.AddNode<FSColorsNode>();
					GetPort("After").Connect(ColorsId_node_After.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ColorsId_node_After, assetPath);
					variableCount += ColorsId_node_After.SetData((FSColors)After, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.OnHitId:
					FSOnHitNode OnHitId_node_After = graph.AddNode<FSOnHitNode>();
					GetPort("After").Connect(OnHitId_node_After.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnHitId_node_After, assetPath);
					variableCount += OnHitId_node_After.SetData((FSOnHit)After, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RandomId:
					FSRandomNode RandomId_node_After = graph.AddNode<FSRandomNode>();
					GetPort("After").Connect(RandomId_node_After.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RandomId_node_After, assetPath);
					variableCount += RandomId_node_After.SetData((FSRandom)After, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CameraId:
					FSCameraInfoNode CameraId_node_After = graph.AddNode<FSCameraInfoNode>();
					GetPort("After").Connect(CameraId_node_After.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CameraId_node_After, assetPath);
					variableCount += CameraId_node_After.SetData((FSCameraInfo)After, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SportsId:
					FSSportsNode SportsId_node_After = graph.AddNode<FSSportsNode>();
					GetPort("After").Connect(SportsId_node_After.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SportsId_node_After, assetPath);
					variableCount += SportsId_node_After.SetData((FSSports)After, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.Vector2Mag:
					FSVector2MagNode Vector2Mag_node_After = graph.AddNode<FSVector2MagNode>();
					GetPort("After").Connect(Vector2Mag_node_After.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(Vector2Mag_node_After, assetPath);
					variableCount += Vector2Mag_node_After.SetData((FSVector2Mag)After, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CPUHelpId:
					FSCpuHelpNode CPUHelpId_node_After = graph.AddNode<FSCpuHelpNode>();
					GetPort("After").Connect(CPUHelpId_node_After.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CPUHelpId_node_After, assetPath);
					variableCount += CPUHelpId_node_After.SetData((FSCpuHelp)After, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ItemId:
					FSItemNode ItemId_node_After = graph.AddNode<FSItemNode>();
					GetPort("After").Connect(ItemId_node_After.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ItemId_node_After, assetPath);
					variableCount += ItemId_node_After.SetData((FSItem)After, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ModeId:
					FSModeNode ModeId_node_After = graph.AddNode<FSModeNode>();
					GetPort("After").Connect(ModeId_node_After.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ModeId_node_After, assetPath);
					variableCount += ModeId_node_After.SetData((FSMode)After, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.JumpsId:
					FSJumpsNode JumpsId_node_After = graph.AddNode<FSJumpsNode>();
					GetPort("After").Connect(JumpsId_node_After.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(JumpsId_node_After, assetPath);
					variableCount += JumpsId_node_After.SetData((FSJumps)After, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RootAnimId:
					FSRootAnimNode RootAnimId_node_After = graph.AddNode<FSRootAnimNode>();
					GetPort("After").Connect(RootAnimId_node_After.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RootAnimId_node_After, assetPath);
					variableCount += RootAnimId_node_After.SetData((FSRootAnim)After, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FloatId:
					FSValueNode FloatId_node_After = graph.AddNode<FSValueNode>();
					GetPort("After").Connect(FloatId_node_After.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FloatId_node_After, assetPath);
					variableCount += FloatId_node_After.SetData((FSValue)After, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
			}
			++variableCount;
			
			Falloff = data.Falloff;
			
			switch (Falloff.TID)
			{
				case FloatSource.TypeId.AgentId:
					FSAgentNode AgentId_node_Falloff = graph.AddNode<FSAgentNode>();
					GetPort("Falloff").Connect(AgentId_node_Falloff.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AgentId_node_Falloff, assetPath);
					variableCount += AgentId_node_Falloff.SetData((FSAgent)Falloff, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.BonesId:
					FSBonesNode BonesId_node_Falloff = graph.AddNode<FSBonesNode>();
					GetPort("Falloff").Connect(BonesId_node_Falloff.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BonesId_node_Falloff, assetPath);
					variableCount += BonesId_node_Falloff.SetData((FSBones)Falloff, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AttackId:
					FSAttackNode AttackId_node_Falloff = graph.AddNode<FSAttackNode>();
					GetPort("Falloff").Connect(AttackId_node_Falloff.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AttackId_node_Falloff, assetPath);
					variableCount += AttackId_node_Falloff.SetData((FSAttack)Falloff, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FrameId:
					FSFrameNode FrameId_node_Falloff = graph.AddNode<FSFrameNode>();
					GetPort("Falloff").Connect(FrameId_node_Falloff.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FrameId_node_Falloff, assetPath);
					variableCount += FrameId_node_Falloff.SetData((FSFrame)Falloff, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.InputId:
					FSInputNode InputId_node_Falloff = graph.AddNode<FSInputNode>();
					GetPort("Falloff").Connect(InputId_node_Falloff.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputId_node_Falloff, assetPath);
					variableCount += InputId_node_Falloff.SetData((FSInput)Falloff, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FuncId:
					FSFuncNode FuncId_node_Falloff = graph.AddNode<FSFuncNode>();
					GetPort("Falloff").Connect(FuncId_node_Falloff.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FuncId_node_Falloff, assetPath);
					variableCount += FuncId_node_Falloff.SetData((FSFunc)Falloff, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.MovementId:
					FSMovementNode MovementId_node_Falloff = graph.AddNode<FSMovementNode>();
					GetPort("Falloff").Connect(MovementId_node_Falloff.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(MovementId_node_Falloff, assetPath);
					variableCount += MovementId_node_Falloff.SetData((FSMovement)Falloff, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CombatId:
					FSCombatNode CombatId_node_Falloff = graph.AddNode<FSCombatNode>();
					GetPort("Falloff").Connect(CombatId_node_Falloff.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CombatId_node_Falloff, assetPath);
					variableCount += CombatId_node_Falloff.SetData((FSCombat)Falloff, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.GrabsId:
					FSGrabsNode GrabsId_node_Falloff = graph.AddNode<FSGrabsNode>();
					GetPort("Falloff").Connect(GrabsId_node_Falloff.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(GrabsId_node_Falloff, assetPath);
					variableCount += GrabsId_node_Falloff.SetData((FSGrabs)Falloff, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.DataId:
					FSDataNode DataId_node_Falloff = graph.AddNode<FSDataNode>();
					GetPort("Falloff").Connect(DataId_node_Falloff.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DataId_node_Falloff, assetPath);
					variableCount += DataId_node_Falloff.SetData((FSData)Falloff, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ScratchId:
					FSScratchNode ScratchId_node_Falloff = graph.AddNode<FSScratchNode>();
					GetPort("Falloff").Connect(ScratchId_node_Falloff.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ScratchId_node_Falloff, assetPath);
					variableCount += ScratchId_node_Falloff.SetData((FSScratch)Falloff, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AnimId:
					FSAnimNode AnimId_node_Falloff = graph.AddNode<FSAnimNode>();
					GetPort("Falloff").Connect(AnimId_node_Falloff.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AnimId_node_Falloff, assetPath);
					variableCount += AnimId_node_Falloff.SetData((FSAnim)Falloff, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SpeedId:
					FSSpeedNode SpeedId_node_Falloff = graph.AddNode<FSSpeedNode>();
					GetPort("Falloff").Connect(SpeedId_node_Falloff.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpeedId_node_Falloff, assetPath);
					variableCount += SpeedId_node_Falloff.SetData((FSSpeed)Falloff, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.PhysicsId:
					FSPhysicsNode PhysicsId_node_Falloff = graph.AddNode<FSPhysicsNode>();
					GetPort("Falloff").Connect(PhysicsId_node_Falloff.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(PhysicsId_node_Falloff, assetPath);
					variableCount += PhysicsId_node_Falloff.SetData((FSPhysics)Falloff, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CollisionId:
					FSCollisionNode CollisionId_node_Falloff = graph.AddNode<FSCollisionNode>();
					GetPort("Falloff").Connect(CollisionId_node_Falloff.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CollisionId_node_Falloff, assetPath);
					variableCount += CollisionId_node_Falloff.SetData((FSCollision)Falloff, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.TimerId:
					FSTimerNode TimerId_node_Falloff = graph.AddNode<FSTimerNode>();
					GetPort("Falloff").Connect(TimerId_node_Falloff.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(TimerId_node_Falloff, assetPath);
					variableCount += TimerId_node_Falloff.SetData((FSTimer)Falloff, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.LagId:
					FSLagNode LagId_node_Falloff = graph.AddNode<FSLagNode>();
					GetPort("Falloff").Connect(LagId_node_Falloff.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LagId_node_Falloff, assetPath);
					variableCount += LagId_node_Falloff.SetData((FSLag)Falloff, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.EffectsId:
					FSEffectsNode EffectsId_node_Falloff = graph.AddNode<FSEffectsNode>();
					GetPort("Falloff").Connect(EffectsId_node_Falloff.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EffectsId_node_Falloff, assetPath);
					variableCount += EffectsId_node_Falloff.SetData((FSEffects)Falloff, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ColorsId:
					FSColorsNode ColorsId_node_Falloff = graph.AddNode<FSColorsNode>();
					GetPort("Falloff").Connect(ColorsId_node_Falloff.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ColorsId_node_Falloff, assetPath);
					variableCount += ColorsId_node_Falloff.SetData((FSColors)Falloff, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.OnHitId:
					FSOnHitNode OnHitId_node_Falloff = graph.AddNode<FSOnHitNode>();
					GetPort("Falloff").Connect(OnHitId_node_Falloff.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnHitId_node_Falloff, assetPath);
					variableCount += OnHitId_node_Falloff.SetData((FSOnHit)Falloff, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RandomId:
					FSRandomNode RandomId_node_Falloff = graph.AddNode<FSRandomNode>();
					GetPort("Falloff").Connect(RandomId_node_Falloff.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RandomId_node_Falloff, assetPath);
					variableCount += RandomId_node_Falloff.SetData((FSRandom)Falloff, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CameraId:
					FSCameraInfoNode CameraId_node_Falloff = graph.AddNode<FSCameraInfoNode>();
					GetPort("Falloff").Connect(CameraId_node_Falloff.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CameraId_node_Falloff, assetPath);
					variableCount += CameraId_node_Falloff.SetData((FSCameraInfo)Falloff, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SportsId:
					FSSportsNode SportsId_node_Falloff = graph.AddNode<FSSportsNode>();
					GetPort("Falloff").Connect(SportsId_node_Falloff.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SportsId_node_Falloff, assetPath);
					variableCount += SportsId_node_Falloff.SetData((FSSports)Falloff, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.Vector2Mag:
					FSVector2MagNode Vector2Mag_node_Falloff = graph.AddNode<FSVector2MagNode>();
					GetPort("Falloff").Connect(Vector2Mag_node_Falloff.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(Vector2Mag_node_Falloff, assetPath);
					variableCount += Vector2Mag_node_Falloff.SetData((FSVector2Mag)Falloff, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CPUHelpId:
					FSCpuHelpNode CPUHelpId_node_Falloff = graph.AddNode<FSCpuHelpNode>();
					GetPort("Falloff").Connect(CPUHelpId_node_Falloff.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CPUHelpId_node_Falloff, assetPath);
					variableCount += CPUHelpId_node_Falloff.SetData((FSCpuHelp)Falloff, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ItemId:
					FSItemNode ItemId_node_Falloff = graph.AddNode<FSItemNode>();
					GetPort("Falloff").Connect(ItemId_node_Falloff.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ItemId_node_Falloff, assetPath);
					variableCount += ItemId_node_Falloff.SetData((FSItem)Falloff, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ModeId:
					FSModeNode ModeId_node_Falloff = graph.AddNode<FSModeNode>();
					GetPort("Falloff").Connect(ModeId_node_Falloff.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ModeId_node_Falloff, assetPath);
					variableCount += ModeId_node_Falloff.SetData((FSMode)Falloff, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.JumpsId:
					FSJumpsNode JumpsId_node_Falloff = graph.AddNode<FSJumpsNode>();
					GetPort("Falloff").Connect(JumpsId_node_Falloff.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(JumpsId_node_Falloff, assetPath);
					variableCount += JumpsId_node_Falloff.SetData((FSJumps)Falloff, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RootAnimId:
					FSRootAnimNode RootAnimId_node_Falloff = graph.AddNode<FSRootAnimNode>();
					GetPort("Falloff").Connect(RootAnimId_node_Falloff.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RootAnimId_node_Falloff, assetPath);
					variableCount += RootAnimId_node_Falloff.SetData((FSRootAnim)Falloff, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FloatId:
					FSValueNode FloatId_node_Falloff = graph.AddNode<FSValueNode>();
					GetPort("Falloff").Connect(FloatId_node_Falloff.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FloatId_node_Falloff, assetPath);
					variableCount += FloatId_node_Falloff.SetData((FSValue)Falloff, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
			}
			
			return variableCount;
		}
		
		public new SAAlterMoveDT GetData()
		{
			SAAlterMoveDT objToReturn = new SAAlterMoveDT();
			objToReturn.TID = TypeId.AlterMoveDtId;
			objToReturn.Version = Version;
			objToReturn.ClearAMDT = ClearAMDT;
			if (GetPort("After").ConnectionCount > 0)
			{
				FloatSourceNode FloatSource_Node = (FloatSourceNode)GetPort("After").GetConnection(0).node;
				switch (FloatSource_Node.TID)
				{
					case FloatSource.TypeId.AgentId:
						FSAgentNode AgentId_FloatSource_Node = (FSAgentNode)GetPort("After").GetConnection(0).node;
						objToReturn.After = AgentId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.BonesId:
						FSBonesNode BonesId_FloatSource_Node = (FSBonesNode)GetPort("After").GetConnection(0).node;
						objToReturn.After = BonesId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AttackId:
						FSAttackNode AttackId_FloatSource_Node = (FSAttackNode)GetPort("After").GetConnection(0).node;
						objToReturn.After = AttackId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FrameId:
						FSFrameNode FrameId_FloatSource_Node = (FSFrameNode)GetPort("After").GetConnection(0).node;
						objToReturn.After = FrameId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.InputId:
						FSInputNode InputId_FloatSource_Node = (FSInputNode)GetPort("After").GetConnection(0).node;
						objToReturn.After = InputId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FuncId:
						FSFuncNode FuncId_FloatSource_Node = (FSFuncNode)GetPort("After").GetConnection(0).node;
						objToReturn.After = FuncId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.MovementId:
						FSMovementNode MovementId_FloatSource_Node = (FSMovementNode)GetPort("After").GetConnection(0).node;
						objToReturn.After = MovementId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CombatId:
						FSCombatNode CombatId_FloatSource_Node = (FSCombatNode)GetPort("After").GetConnection(0).node;
						objToReturn.After = CombatId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.GrabsId:
						FSGrabsNode GrabsId_FloatSource_Node = (FSGrabsNode)GetPort("After").GetConnection(0).node;
						objToReturn.After = GrabsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.DataId:
						FSDataNode DataId_FloatSource_Node = (FSDataNode)GetPort("After").GetConnection(0).node;
						objToReturn.After = DataId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ScratchId:
						FSScratchNode ScratchId_FloatSource_Node = (FSScratchNode)GetPort("After").GetConnection(0).node;
						objToReturn.After = ScratchId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AnimId:
						FSAnimNode AnimId_FloatSource_Node = (FSAnimNode)GetPort("After").GetConnection(0).node;
						objToReturn.After = AnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SpeedId:
						FSSpeedNode SpeedId_FloatSource_Node = (FSSpeedNode)GetPort("After").GetConnection(0).node;
						objToReturn.After = SpeedId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.PhysicsId:
						FSPhysicsNode PhysicsId_FloatSource_Node = (FSPhysicsNode)GetPort("After").GetConnection(0).node;
						objToReturn.After = PhysicsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CollisionId:
						FSCollisionNode CollisionId_FloatSource_Node = (FSCollisionNode)GetPort("After").GetConnection(0).node;
						objToReturn.After = CollisionId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.TimerId:
						FSTimerNode TimerId_FloatSource_Node = (FSTimerNode)GetPort("After").GetConnection(0).node;
						objToReturn.After = TimerId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.LagId:
						FSLagNode LagId_FloatSource_Node = (FSLagNode)GetPort("After").GetConnection(0).node;
						objToReturn.After = LagId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.EffectsId:
						FSEffectsNode EffectsId_FloatSource_Node = (FSEffectsNode)GetPort("After").GetConnection(0).node;
						objToReturn.After = EffectsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ColorsId:
						FSColorsNode ColorsId_FloatSource_Node = (FSColorsNode)GetPort("After").GetConnection(0).node;
						objToReturn.After = ColorsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.OnHitId:
						FSOnHitNode OnHitId_FloatSource_Node = (FSOnHitNode)GetPort("After").GetConnection(0).node;
						objToReturn.After = OnHitId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RandomId:
						FSRandomNode RandomId_FloatSource_Node = (FSRandomNode)GetPort("After").GetConnection(0).node;
						objToReturn.After = RandomId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CameraId:
						FSCameraInfoNode CameraId_FloatSource_Node = (FSCameraInfoNode)GetPort("After").GetConnection(0).node;
						objToReturn.After = CameraId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SportsId:
						FSSportsNode SportsId_FloatSource_Node = (FSSportsNode)GetPort("After").GetConnection(0).node;
						objToReturn.After = SportsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.Vector2Mag:
						FSVector2MagNode Vector2Mag_FloatSource_Node = (FSVector2MagNode)GetPort("After").GetConnection(0).node;
						objToReturn.After = Vector2Mag_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CPUHelpId:
						FSCpuHelpNode CPUHelpId_FloatSource_Node = (FSCpuHelpNode)GetPort("After").GetConnection(0).node;
						objToReturn.After = CPUHelpId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ItemId:
						FSItemNode ItemId_FloatSource_Node = (FSItemNode)GetPort("After").GetConnection(0).node;
						objToReturn.After = ItemId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ModeId:
						FSModeNode ModeId_FloatSource_Node = (FSModeNode)GetPort("After").GetConnection(0).node;
						objToReturn.After = ModeId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.JumpsId:
						FSJumpsNode JumpsId_FloatSource_Node = (FSJumpsNode)GetPort("After").GetConnection(0).node;
						objToReturn.After = JumpsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RootAnimId:
						FSRootAnimNode RootAnimId_FloatSource_Node = (FSRootAnimNode)GetPort("After").GetConnection(0).node;
						objToReturn.After = RootAnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FloatId:
						FSValueNode FloatId_FloatSource_Node = (FSValueNode)GetPort("After").GetConnection(0).node;
						objToReturn.After = FloatId_FloatSource_Node.GetData();
					break;
				}
			}
			if (GetPort("Falloff").ConnectionCount > 0)
			{
				FloatSourceNode FloatSource_Node = (FloatSourceNode)GetPort("Falloff").GetConnection(0).node;
				switch (FloatSource_Node.TID)
				{
					case FloatSource.TypeId.AgentId:
						FSAgentNode AgentId_FloatSource_Node = (FSAgentNode)GetPort("Falloff").GetConnection(0).node;
						objToReturn.Falloff = AgentId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.BonesId:
						FSBonesNode BonesId_FloatSource_Node = (FSBonesNode)GetPort("Falloff").GetConnection(0).node;
						objToReturn.Falloff = BonesId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AttackId:
						FSAttackNode AttackId_FloatSource_Node = (FSAttackNode)GetPort("Falloff").GetConnection(0).node;
						objToReturn.Falloff = AttackId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FrameId:
						FSFrameNode FrameId_FloatSource_Node = (FSFrameNode)GetPort("Falloff").GetConnection(0).node;
						objToReturn.Falloff = FrameId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.InputId:
						FSInputNode InputId_FloatSource_Node = (FSInputNode)GetPort("Falloff").GetConnection(0).node;
						objToReturn.Falloff = InputId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FuncId:
						FSFuncNode FuncId_FloatSource_Node = (FSFuncNode)GetPort("Falloff").GetConnection(0).node;
						objToReturn.Falloff = FuncId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.MovementId:
						FSMovementNode MovementId_FloatSource_Node = (FSMovementNode)GetPort("Falloff").GetConnection(0).node;
						objToReturn.Falloff = MovementId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CombatId:
						FSCombatNode CombatId_FloatSource_Node = (FSCombatNode)GetPort("Falloff").GetConnection(0).node;
						objToReturn.Falloff = CombatId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.GrabsId:
						FSGrabsNode GrabsId_FloatSource_Node = (FSGrabsNode)GetPort("Falloff").GetConnection(0).node;
						objToReturn.Falloff = GrabsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.DataId:
						FSDataNode DataId_FloatSource_Node = (FSDataNode)GetPort("Falloff").GetConnection(0).node;
						objToReturn.Falloff = DataId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ScratchId:
						FSScratchNode ScratchId_FloatSource_Node = (FSScratchNode)GetPort("Falloff").GetConnection(0).node;
						objToReturn.Falloff = ScratchId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AnimId:
						FSAnimNode AnimId_FloatSource_Node = (FSAnimNode)GetPort("Falloff").GetConnection(0).node;
						objToReturn.Falloff = AnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SpeedId:
						FSSpeedNode SpeedId_FloatSource_Node = (FSSpeedNode)GetPort("Falloff").GetConnection(0).node;
						objToReturn.Falloff = SpeedId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.PhysicsId:
						FSPhysicsNode PhysicsId_FloatSource_Node = (FSPhysicsNode)GetPort("Falloff").GetConnection(0).node;
						objToReturn.Falloff = PhysicsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CollisionId:
						FSCollisionNode CollisionId_FloatSource_Node = (FSCollisionNode)GetPort("Falloff").GetConnection(0).node;
						objToReturn.Falloff = CollisionId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.TimerId:
						FSTimerNode TimerId_FloatSource_Node = (FSTimerNode)GetPort("Falloff").GetConnection(0).node;
						objToReturn.Falloff = TimerId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.LagId:
						FSLagNode LagId_FloatSource_Node = (FSLagNode)GetPort("Falloff").GetConnection(0).node;
						objToReturn.Falloff = LagId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.EffectsId:
						FSEffectsNode EffectsId_FloatSource_Node = (FSEffectsNode)GetPort("Falloff").GetConnection(0).node;
						objToReturn.Falloff = EffectsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ColorsId:
						FSColorsNode ColorsId_FloatSource_Node = (FSColorsNode)GetPort("Falloff").GetConnection(0).node;
						objToReturn.Falloff = ColorsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.OnHitId:
						FSOnHitNode OnHitId_FloatSource_Node = (FSOnHitNode)GetPort("Falloff").GetConnection(0).node;
						objToReturn.Falloff = OnHitId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RandomId:
						FSRandomNode RandomId_FloatSource_Node = (FSRandomNode)GetPort("Falloff").GetConnection(0).node;
						objToReturn.Falloff = RandomId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CameraId:
						FSCameraInfoNode CameraId_FloatSource_Node = (FSCameraInfoNode)GetPort("Falloff").GetConnection(0).node;
						objToReturn.Falloff = CameraId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SportsId:
						FSSportsNode SportsId_FloatSource_Node = (FSSportsNode)GetPort("Falloff").GetConnection(0).node;
						objToReturn.Falloff = SportsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.Vector2Mag:
						FSVector2MagNode Vector2Mag_FloatSource_Node = (FSVector2MagNode)GetPort("Falloff").GetConnection(0).node;
						objToReturn.Falloff = Vector2Mag_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CPUHelpId:
						FSCpuHelpNode CPUHelpId_FloatSource_Node = (FSCpuHelpNode)GetPort("Falloff").GetConnection(0).node;
						objToReturn.Falloff = CPUHelpId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ItemId:
						FSItemNode ItemId_FloatSource_Node = (FSItemNode)GetPort("Falloff").GetConnection(0).node;
						objToReturn.Falloff = ItemId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ModeId:
						FSModeNode ModeId_FloatSource_Node = (FSModeNode)GetPort("Falloff").GetConnection(0).node;
						objToReturn.Falloff = ModeId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.JumpsId:
						FSJumpsNode JumpsId_FloatSource_Node = (FSJumpsNode)GetPort("Falloff").GetConnection(0).node;
						objToReturn.Falloff = JumpsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RootAnimId:
						FSRootAnimNode RootAnimId_FloatSource_Node = (FSRootAnimNode)GetPort("Falloff").GetConnection(0).node;
						objToReturn.Falloff = RootAnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FloatId:
						FSValueNode FloatId_FloatSource_Node = (FSValueNode)GetPort("Falloff").GetConnection(0).node;
						objToReturn.Falloff = FloatId_FloatSource_Node.GetData();
					break;
				}
			}
			return objToReturn;
		}
	}
}

