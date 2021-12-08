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
	public class SAAlterMoveVelNode : StateActionNode
	{
		[Input(connectionType = ConnectionType.Override)] public StateAction NodeInput;
		public bool ClearAMV;
		[Output(connectionType = ConnectionType.Override)] public FloatSource AlterX;
		[Output(connectionType = ConnectionType.Override)] public FloatSource AlterY;
		[Output(connectionType = ConnectionType.Override)] public FloatSource FalloffX;
		[Output(connectionType = ConnectionType.Override)] public FloatSource FalloffY;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.AlterMoveVelId;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SAAlterMoveVel data, MovesetGraph graph, string assetPath, Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SAAlterMoveVel));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			ClearAMV = data.ClearAMV;
			AlterX = data.AlterX;
			
			switch (AlterX.TID)
			{
				case FloatSource.TypeId.AgentId:
					FSAgentNode AgentId_node_AlterX = graph.AddNode<FSAgentNode>();
					GetPort("AlterX").Connect(AgentId_node_AlterX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AgentId_node_AlterX, assetPath);
					variableCount += AgentId_node_AlterX.SetData((FSAgent)AlterX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.BonesId:
					FSBonesNode BonesId_node_AlterX = graph.AddNode<FSBonesNode>();
					GetPort("AlterX").Connect(BonesId_node_AlterX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BonesId_node_AlterX, assetPath);
					variableCount += BonesId_node_AlterX.SetData((FSBones)AlterX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AttackId:
					FSAttackNode AttackId_node_AlterX = graph.AddNode<FSAttackNode>();
					GetPort("AlterX").Connect(AttackId_node_AlterX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AttackId_node_AlterX, assetPath);
					variableCount += AttackId_node_AlterX.SetData((FSAttack)AlterX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FrameId:
					FSFrameNode FrameId_node_AlterX = graph.AddNode<FSFrameNode>();
					GetPort("AlterX").Connect(FrameId_node_AlterX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FrameId_node_AlterX, assetPath);
					variableCount += FrameId_node_AlterX.SetData((FSFrame)AlterX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.InputId:
					FSInputNode InputId_node_AlterX = graph.AddNode<FSInputNode>();
					GetPort("AlterX").Connect(InputId_node_AlterX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputId_node_AlterX, assetPath);
					variableCount += InputId_node_AlterX.SetData((FSInput)AlterX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FuncId:
					FSFuncNode FuncId_node_AlterX = graph.AddNode<FSFuncNode>();
					GetPort("AlterX").Connect(FuncId_node_AlterX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FuncId_node_AlterX, assetPath);
					variableCount += FuncId_node_AlterX.SetData((FSFunc)AlterX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.MovementId:
					FSMovementNode MovementId_node_AlterX = graph.AddNode<FSMovementNode>();
					GetPort("AlterX").Connect(MovementId_node_AlterX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(MovementId_node_AlterX, assetPath);
					variableCount += MovementId_node_AlterX.SetData((FSMovement)AlterX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CombatId:
					FSCombatNode CombatId_node_AlterX = graph.AddNode<FSCombatNode>();
					GetPort("AlterX").Connect(CombatId_node_AlterX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CombatId_node_AlterX, assetPath);
					variableCount += CombatId_node_AlterX.SetData((FSCombat)AlterX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.GrabsId:
					FSGrabsNode GrabsId_node_AlterX = graph.AddNode<FSGrabsNode>();
					GetPort("AlterX").Connect(GrabsId_node_AlterX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(GrabsId_node_AlterX, assetPath);
					variableCount += GrabsId_node_AlterX.SetData((FSGrabs)AlterX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.DataId:
					FSDataNode DataId_node_AlterX = graph.AddNode<FSDataNode>();
					GetPort("AlterX").Connect(DataId_node_AlterX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DataId_node_AlterX, assetPath);
					variableCount += DataId_node_AlterX.SetData((FSData)AlterX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ScratchId:
					FSScratchNode ScratchId_node_AlterX = graph.AddNode<FSScratchNode>();
					GetPort("AlterX").Connect(ScratchId_node_AlterX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ScratchId_node_AlterX, assetPath);
					variableCount += ScratchId_node_AlterX.SetData((FSScratch)AlterX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AnimId:
					FSAnimNode AnimId_node_AlterX = graph.AddNode<FSAnimNode>();
					GetPort("AlterX").Connect(AnimId_node_AlterX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AnimId_node_AlterX, assetPath);
					variableCount += AnimId_node_AlterX.SetData((FSAnim)AlterX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SpeedId:
					FSSpeedNode SpeedId_node_AlterX = graph.AddNode<FSSpeedNode>();
					GetPort("AlterX").Connect(SpeedId_node_AlterX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpeedId_node_AlterX, assetPath);
					variableCount += SpeedId_node_AlterX.SetData((FSSpeed)AlterX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.PhysicsId:
					FSPhysicsNode PhysicsId_node_AlterX = graph.AddNode<FSPhysicsNode>();
					GetPort("AlterX").Connect(PhysicsId_node_AlterX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(PhysicsId_node_AlterX, assetPath);
					variableCount += PhysicsId_node_AlterX.SetData((FSPhysics)AlterX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CollisionId:
					FSCollisionNode CollisionId_node_AlterX = graph.AddNode<FSCollisionNode>();
					GetPort("AlterX").Connect(CollisionId_node_AlterX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CollisionId_node_AlterX, assetPath);
					variableCount += CollisionId_node_AlterX.SetData((FSCollision)AlterX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.TimerId:
					FSTimerNode TimerId_node_AlterX = graph.AddNode<FSTimerNode>();
					GetPort("AlterX").Connect(TimerId_node_AlterX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(TimerId_node_AlterX, assetPath);
					variableCount += TimerId_node_AlterX.SetData((FSTimer)AlterX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.LagId:
					FSLagNode LagId_node_AlterX = graph.AddNode<FSLagNode>();
					GetPort("AlterX").Connect(LagId_node_AlterX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LagId_node_AlterX, assetPath);
					variableCount += LagId_node_AlterX.SetData((FSLag)AlterX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.EffectsId:
					FSEffectsNode EffectsId_node_AlterX = graph.AddNode<FSEffectsNode>();
					GetPort("AlterX").Connect(EffectsId_node_AlterX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EffectsId_node_AlterX, assetPath);
					variableCount += EffectsId_node_AlterX.SetData((FSEffects)AlterX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ColorsId:
					FSColorsNode ColorsId_node_AlterX = graph.AddNode<FSColorsNode>();
					GetPort("AlterX").Connect(ColorsId_node_AlterX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ColorsId_node_AlterX, assetPath);
					variableCount += ColorsId_node_AlterX.SetData((FSColors)AlterX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.OnHitId:
					FSOnHitNode OnHitId_node_AlterX = graph.AddNode<FSOnHitNode>();
					GetPort("AlterX").Connect(OnHitId_node_AlterX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnHitId_node_AlterX, assetPath);
					variableCount += OnHitId_node_AlterX.SetData((FSOnHit)AlterX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RandomId:
					FSRandomNode RandomId_node_AlterX = graph.AddNode<FSRandomNode>();
					GetPort("AlterX").Connect(RandomId_node_AlterX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RandomId_node_AlterX, assetPath);
					variableCount += RandomId_node_AlterX.SetData((FSRandom)AlterX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CameraId:
					FSCameraInfoNode CameraId_node_AlterX = graph.AddNode<FSCameraInfoNode>();
					GetPort("AlterX").Connect(CameraId_node_AlterX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CameraId_node_AlterX, assetPath);
					variableCount += CameraId_node_AlterX.SetData((FSCameraInfo)AlterX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SportsId:
					FSSportsNode SportsId_node_AlterX = graph.AddNode<FSSportsNode>();
					GetPort("AlterX").Connect(SportsId_node_AlterX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SportsId_node_AlterX, assetPath);
					variableCount += SportsId_node_AlterX.SetData((FSSports)AlterX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.Vector2Mag:
					FSVector2MagNode Vector2Mag_node_AlterX = graph.AddNode<FSVector2MagNode>();
					GetPort("AlterX").Connect(Vector2Mag_node_AlterX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(Vector2Mag_node_AlterX, assetPath);
					variableCount += Vector2Mag_node_AlterX.SetData((FSVector2Mag)AlterX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CPUHelpId:
					FSCpuHelpNode CPUHelpId_node_AlterX = graph.AddNode<FSCpuHelpNode>();
					GetPort("AlterX").Connect(CPUHelpId_node_AlterX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CPUHelpId_node_AlterX, assetPath);
					variableCount += CPUHelpId_node_AlterX.SetData((FSCpuHelp)AlterX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ItemId:
					FSItemNode ItemId_node_AlterX = graph.AddNode<FSItemNode>();
					GetPort("AlterX").Connect(ItemId_node_AlterX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ItemId_node_AlterX, assetPath);
					variableCount += ItemId_node_AlterX.SetData((FSItem)AlterX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ModeId:
					FSModeNode ModeId_node_AlterX = graph.AddNode<FSModeNode>();
					GetPort("AlterX").Connect(ModeId_node_AlterX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ModeId_node_AlterX, assetPath);
					variableCount += ModeId_node_AlterX.SetData((FSMode)AlterX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.JumpsId:
					FSJumpsNode JumpsId_node_AlterX = graph.AddNode<FSJumpsNode>();
					GetPort("AlterX").Connect(JumpsId_node_AlterX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(JumpsId_node_AlterX, assetPath);
					variableCount += JumpsId_node_AlterX.SetData((FSJumps)AlterX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RootAnimId:
					FSRootAnimNode RootAnimId_node_AlterX = graph.AddNode<FSRootAnimNode>();
					GetPort("AlterX").Connect(RootAnimId_node_AlterX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RootAnimId_node_AlterX, assetPath);
					variableCount += RootAnimId_node_AlterX.SetData((FSRootAnim)AlterX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FloatId:
					FSValueNode FloatId_node_AlterX = graph.AddNode<FSValueNode>();
					GetPort("AlterX").Connect(FloatId_node_AlterX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FloatId_node_AlterX, assetPath);
					variableCount += FloatId_node_AlterX.SetData((FSValue)AlterX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
			}
			++variableCount;
			
			AlterY = data.AlterY;
			
			switch (AlterY.TID)
			{
				case FloatSource.TypeId.AgentId:
					FSAgentNode AgentId_node_AlterY = graph.AddNode<FSAgentNode>();
					GetPort("AlterY").Connect(AgentId_node_AlterY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AgentId_node_AlterY, assetPath);
					variableCount += AgentId_node_AlterY.SetData((FSAgent)AlterY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.BonesId:
					FSBonesNode BonesId_node_AlterY = graph.AddNode<FSBonesNode>();
					GetPort("AlterY").Connect(BonesId_node_AlterY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BonesId_node_AlterY, assetPath);
					variableCount += BonesId_node_AlterY.SetData((FSBones)AlterY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AttackId:
					FSAttackNode AttackId_node_AlterY = graph.AddNode<FSAttackNode>();
					GetPort("AlterY").Connect(AttackId_node_AlterY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AttackId_node_AlterY, assetPath);
					variableCount += AttackId_node_AlterY.SetData((FSAttack)AlterY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FrameId:
					FSFrameNode FrameId_node_AlterY = graph.AddNode<FSFrameNode>();
					GetPort("AlterY").Connect(FrameId_node_AlterY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FrameId_node_AlterY, assetPath);
					variableCount += FrameId_node_AlterY.SetData((FSFrame)AlterY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.InputId:
					FSInputNode InputId_node_AlterY = graph.AddNode<FSInputNode>();
					GetPort("AlterY").Connect(InputId_node_AlterY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputId_node_AlterY, assetPath);
					variableCount += InputId_node_AlterY.SetData((FSInput)AlterY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FuncId:
					FSFuncNode FuncId_node_AlterY = graph.AddNode<FSFuncNode>();
					GetPort("AlterY").Connect(FuncId_node_AlterY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FuncId_node_AlterY, assetPath);
					variableCount += FuncId_node_AlterY.SetData((FSFunc)AlterY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.MovementId:
					FSMovementNode MovementId_node_AlterY = graph.AddNode<FSMovementNode>();
					GetPort("AlterY").Connect(MovementId_node_AlterY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(MovementId_node_AlterY, assetPath);
					variableCount += MovementId_node_AlterY.SetData((FSMovement)AlterY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CombatId:
					FSCombatNode CombatId_node_AlterY = graph.AddNode<FSCombatNode>();
					GetPort("AlterY").Connect(CombatId_node_AlterY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CombatId_node_AlterY, assetPath);
					variableCount += CombatId_node_AlterY.SetData((FSCombat)AlterY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.GrabsId:
					FSGrabsNode GrabsId_node_AlterY = graph.AddNode<FSGrabsNode>();
					GetPort("AlterY").Connect(GrabsId_node_AlterY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(GrabsId_node_AlterY, assetPath);
					variableCount += GrabsId_node_AlterY.SetData((FSGrabs)AlterY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.DataId:
					FSDataNode DataId_node_AlterY = graph.AddNode<FSDataNode>();
					GetPort("AlterY").Connect(DataId_node_AlterY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DataId_node_AlterY, assetPath);
					variableCount += DataId_node_AlterY.SetData((FSData)AlterY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ScratchId:
					FSScratchNode ScratchId_node_AlterY = graph.AddNode<FSScratchNode>();
					GetPort("AlterY").Connect(ScratchId_node_AlterY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ScratchId_node_AlterY, assetPath);
					variableCount += ScratchId_node_AlterY.SetData((FSScratch)AlterY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AnimId:
					FSAnimNode AnimId_node_AlterY = graph.AddNode<FSAnimNode>();
					GetPort("AlterY").Connect(AnimId_node_AlterY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AnimId_node_AlterY, assetPath);
					variableCount += AnimId_node_AlterY.SetData((FSAnim)AlterY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SpeedId:
					FSSpeedNode SpeedId_node_AlterY = graph.AddNode<FSSpeedNode>();
					GetPort("AlterY").Connect(SpeedId_node_AlterY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpeedId_node_AlterY, assetPath);
					variableCount += SpeedId_node_AlterY.SetData((FSSpeed)AlterY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.PhysicsId:
					FSPhysicsNode PhysicsId_node_AlterY = graph.AddNode<FSPhysicsNode>();
					GetPort("AlterY").Connect(PhysicsId_node_AlterY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(PhysicsId_node_AlterY, assetPath);
					variableCount += PhysicsId_node_AlterY.SetData((FSPhysics)AlterY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CollisionId:
					FSCollisionNode CollisionId_node_AlterY = graph.AddNode<FSCollisionNode>();
					GetPort("AlterY").Connect(CollisionId_node_AlterY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CollisionId_node_AlterY, assetPath);
					variableCount += CollisionId_node_AlterY.SetData((FSCollision)AlterY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.TimerId:
					FSTimerNode TimerId_node_AlterY = graph.AddNode<FSTimerNode>();
					GetPort("AlterY").Connect(TimerId_node_AlterY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(TimerId_node_AlterY, assetPath);
					variableCount += TimerId_node_AlterY.SetData((FSTimer)AlterY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.LagId:
					FSLagNode LagId_node_AlterY = graph.AddNode<FSLagNode>();
					GetPort("AlterY").Connect(LagId_node_AlterY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LagId_node_AlterY, assetPath);
					variableCount += LagId_node_AlterY.SetData((FSLag)AlterY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.EffectsId:
					FSEffectsNode EffectsId_node_AlterY = graph.AddNode<FSEffectsNode>();
					GetPort("AlterY").Connect(EffectsId_node_AlterY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EffectsId_node_AlterY, assetPath);
					variableCount += EffectsId_node_AlterY.SetData((FSEffects)AlterY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ColorsId:
					FSColorsNode ColorsId_node_AlterY = graph.AddNode<FSColorsNode>();
					GetPort("AlterY").Connect(ColorsId_node_AlterY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ColorsId_node_AlterY, assetPath);
					variableCount += ColorsId_node_AlterY.SetData((FSColors)AlterY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.OnHitId:
					FSOnHitNode OnHitId_node_AlterY = graph.AddNode<FSOnHitNode>();
					GetPort("AlterY").Connect(OnHitId_node_AlterY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnHitId_node_AlterY, assetPath);
					variableCount += OnHitId_node_AlterY.SetData((FSOnHit)AlterY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RandomId:
					FSRandomNode RandomId_node_AlterY = graph.AddNode<FSRandomNode>();
					GetPort("AlterY").Connect(RandomId_node_AlterY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RandomId_node_AlterY, assetPath);
					variableCount += RandomId_node_AlterY.SetData((FSRandom)AlterY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CameraId:
					FSCameraInfoNode CameraId_node_AlterY = graph.AddNode<FSCameraInfoNode>();
					GetPort("AlterY").Connect(CameraId_node_AlterY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CameraId_node_AlterY, assetPath);
					variableCount += CameraId_node_AlterY.SetData((FSCameraInfo)AlterY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SportsId:
					FSSportsNode SportsId_node_AlterY = graph.AddNode<FSSportsNode>();
					GetPort("AlterY").Connect(SportsId_node_AlterY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SportsId_node_AlterY, assetPath);
					variableCount += SportsId_node_AlterY.SetData((FSSports)AlterY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.Vector2Mag:
					FSVector2MagNode Vector2Mag_node_AlterY = graph.AddNode<FSVector2MagNode>();
					GetPort("AlterY").Connect(Vector2Mag_node_AlterY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(Vector2Mag_node_AlterY, assetPath);
					variableCount += Vector2Mag_node_AlterY.SetData((FSVector2Mag)AlterY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CPUHelpId:
					FSCpuHelpNode CPUHelpId_node_AlterY = graph.AddNode<FSCpuHelpNode>();
					GetPort("AlterY").Connect(CPUHelpId_node_AlterY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CPUHelpId_node_AlterY, assetPath);
					variableCount += CPUHelpId_node_AlterY.SetData((FSCpuHelp)AlterY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ItemId:
					FSItemNode ItemId_node_AlterY = graph.AddNode<FSItemNode>();
					GetPort("AlterY").Connect(ItemId_node_AlterY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ItemId_node_AlterY, assetPath);
					variableCount += ItemId_node_AlterY.SetData((FSItem)AlterY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ModeId:
					FSModeNode ModeId_node_AlterY = graph.AddNode<FSModeNode>();
					GetPort("AlterY").Connect(ModeId_node_AlterY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ModeId_node_AlterY, assetPath);
					variableCount += ModeId_node_AlterY.SetData((FSMode)AlterY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.JumpsId:
					FSJumpsNode JumpsId_node_AlterY = graph.AddNode<FSJumpsNode>();
					GetPort("AlterY").Connect(JumpsId_node_AlterY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(JumpsId_node_AlterY, assetPath);
					variableCount += JumpsId_node_AlterY.SetData((FSJumps)AlterY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RootAnimId:
					FSRootAnimNode RootAnimId_node_AlterY = graph.AddNode<FSRootAnimNode>();
					GetPort("AlterY").Connect(RootAnimId_node_AlterY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RootAnimId_node_AlterY, assetPath);
					variableCount += RootAnimId_node_AlterY.SetData((FSRootAnim)AlterY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FloatId:
					FSValueNode FloatId_node_AlterY = graph.AddNode<FSValueNode>();
					GetPort("AlterY").Connect(FloatId_node_AlterY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FloatId_node_AlterY, assetPath);
					variableCount += FloatId_node_AlterY.SetData((FSValue)AlterY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
			}
			++variableCount;
			
			FalloffX = data.FalloffX;
			
			switch (FalloffX.TID)
			{
				case FloatSource.TypeId.AgentId:
					FSAgentNode AgentId_node_FalloffX = graph.AddNode<FSAgentNode>();
					GetPort("FalloffX").Connect(AgentId_node_FalloffX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AgentId_node_FalloffX, assetPath);
					variableCount += AgentId_node_FalloffX.SetData((FSAgent)FalloffX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.BonesId:
					FSBonesNode BonesId_node_FalloffX = graph.AddNode<FSBonesNode>();
					GetPort("FalloffX").Connect(BonesId_node_FalloffX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BonesId_node_FalloffX, assetPath);
					variableCount += BonesId_node_FalloffX.SetData((FSBones)FalloffX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AttackId:
					FSAttackNode AttackId_node_FalloffX = graph.AddNode<FSAttackNode>();
					GetPort("FalloffX").Connect(AttackId_node_FalloffX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AttackId_node_FalloffX, assetPath);
					variableCount += AttackId_node_FalloffX.SetData((FSAttack)FalloffX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FrameId:
					FSFrameNode FrameId_node_FalloffX = graph.AddNode<FSFrameNode>();
					GetPort("FalloffX").Connect(FrameId_node_FalloffX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FrameId_node_FalloffX, assetPath);
					variableCount += FrameId_node_FalloffX.SetData((FSFrame)FalloffX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.InputId:
					FSInputNode InputId_node_FalloffX = graph.AddNode<FSInputNode>();
					GetPort("FalloffX").Connect(InputId_node_FalloffX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputId_node_FalloffX, assetPath);
					variableCount += InputId_node_FalloffX.SetData((FSInput)FalloffX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FuncId:
					FSFuncNode FuncId_node_FalloffX = graph.AddNode<FSFuncNode>();
					GetPort("FalloffX").Connect(FuncId_node_FalloffX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FuncId_node_FalloffX, assetPath);
					variableCount += FuncId_node_FalloffX.SetData((FSFunc)FalloffX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.MovementId:
					FSMovementNode MovementId_node_FalloffX = graph.AddNode<FSMovementNode>();
					GetPort("FalloffX").Connect(MovementId_node_FalloffX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(MovementId_node_FalloffX, assetPath);
					variableCount += MovementId_node_FalloffX.SetData((FSMovement)FalloffX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CombatId:
					FSCombatNode CombatId_node_FalloffX = graph.AddNode<FSCombatNode>();
					GetPort("FalloffX").Connect(CombatId_node_FalloffX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CombatId_node_FalloffX, assetPath);
					variableCount += CombatId_node_FalloffX.SetData((FSCombat)FalloffX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.GrabsId:
					FSGrabsNode GrabsId_node_FalloffX = graph.AddNode<FSGrabsNode>();
					GetPort("FalloffX").Connect(GrabsId_node_FalloffX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(GrabsId_node_FalloffX, assetPath);
					variableCount += GrabsId_node_FalloffX.SetData((FSGrabs)FalloffX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.DataId:
					FSDataNode DataId_node_FalloffX = graph.AddNode<FSDataNode>();
					GetPort("FalloffX").Connect(DataId_node_FalloffX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DataId_node_FalloffX, assetPath);
					variableCount += DataId_node_FalloffX.SetData((FSData)FalloffX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ScratchId:
					FSScratchNode ScratchId_node_FalloffX = graph.AddNode<FSScratchNode>();
					GetPort("FalloffX").Connect(ScratchId_node_FalloffX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ScratchId_node_FalloffX, assetPath);
					variableCount += ScratchId_node_FalloffX.SetData((FSScratch)FalloffX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AnimId:
					FSAnimNode AnimId_node_FalloffX = graph.AddNode<FSAnimNode>();
					GetPort("FalloffX").Connect(AnimId_node_FalloffX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AnimId_node_FalloffX, assetPath);
					variableCount += AnimId_node_FalloffX.SetData((FSAnim)FalloffX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SpeedId:
					FSSpeedNode SpeedId_node_FalloffX = graph.AddNode<FSSpeedNode>();
					GetPort("FalloffX").Connect(SpeedId_node_FalloffX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpeedId_node_FalloffX, assetPath);
					variableCount += SpeedId_node_FalloffX.SetData((FSSpeed)FalloffX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.PhysicsId:
					FSPhysicsNode PhysicsId_node_FalloffX = graph.AddNode<FSPhysicsNode>();
					GetPort("FalloffX").Connect(PhysicsId_node_FalloffX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(PhysicsId_node_FalloffX, assetPath);
					variableCount += PhysicsId_node_FalloffX.SetData((FSPhysics)FalloffX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CollisionId:
					FSCollisionNode CollisionId_node_FalloffX = graph.AddNode<FSCollisionNode>();
					GetPort("FalloffX").Connect(CollisionId_node_FalloffX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CollisionId_node_FalloffX, assetPath);
					variableCount += CollisionId_node_FalloffX.SetData((FSCollision)FalloffX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.TimerId:
					FSTimerNode TimerId_node_FalloffX = graph.AddNode<FSTimerNode>();
					GetPort("FalloffX").Connect(TimerId_node_FalloffX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(TimerId_node_FalloffX, assetPath);
					variableCount += TimerId_node_FalloffX.SetData((FSTimer)FalloffX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.LagId:
					FSLagNode LagId_node_FalloffX = graph.AddNode<FSLagNode>();
					GetPort("FalloffX").Connect(LagId_node_FalloffX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LagId_node_FalloffX, assetPath);
					variableCount += LagId_node_FalloffX.SetData((FSLag)FalloffX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.EffectsId:
					FSEffectsNode EffectsId_node_FalloffX = graph.AddNode<FSEffectsNode>();
					GetPort("FalloffX").Connect(EffectsId_node_FalloffX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EffectsId_node_FalloffX, assetPath);
					variableCount += EffectsId_node_FalloffX.SetData((FSEffects)FalloffX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ColorsId:
					FSColorsNode ColorsId_node_FalloffX = graph.AddNode<FSColorsNode>();
					GetPort("FalloffX").Connect(ColorsId_node_FalloffX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ColorsId_node_FalloffX, assetPath);
					variableCount += ColorsId_node_FalloffX.SetData((FSColors)FalloffX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.OnHitId:
					FSOnHitNode OnHitId_node_FalloffX = graph.AddNode<FSOnHitNode>();
					GetPort("FalloffX").Connect(OnHitId_node_FalloffX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnHitId_node_FalloffX, assetPath);
					variableCount += OnHitId_node_FalloffX.SetData((FSOnHit)FalloffX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RandomId:
					FSRandomNode RandomId_node_FalloffX = graph.AddNode<FSRandomNode>();
					GetPort("FalloffX").Connect(RandomId_node_FalloffX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RandomId_node_FalloffX, assetPath);
					variableCount += RandomId_node_FalloffX.SetData((FSRandom)FalloffX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CameraId:
					FSCameraInfoNode CameraId_node_FalloffX = graph.AddNode<FSCameraInfoNode>();
					GetPort("FalloffX").Connect(CameraId_node_FalloffX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CameraId_node_FalloffX, assetPath);
					variableCount += CameraId_node_FalloffX.SetData((FSCameraInfo)FalloffX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SportsId:
					FSSportsNode SportsId_node_FalloffX = graph.AddNode<FSSportsNode>();
					GetPort("FalloffX").Connect(SportsId_node_FalloffX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SportsId_node_FalloffX, assetPath);
					variableCount += SportsId_node_FalloffX.SetData((FSSports)FalloffX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.Vector2Mag:
					FSVector2MagNode Vector2Mag_node_FalloffX = graph.AddNode<FSVector2MagNode>();
					GetPort("FalloffX").Connect(Vector2Mag_node_FalloffX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(Vector2Mag_node_FalloffX, assetPath);
					variableCount += Vector2Mag_node_FalloffX.SetData((FSVector2Mag)FalloffX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CPUHelpId:
					FSCpuHelpNode CPUHelpId_node_FalloffX = graph.AddNode<FSCpuHelpNode>();
					GetPort("FalloffX").Connect(CPUHelpId_node_FalloffX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CPUHelpId_node_FalloffX, assetPath);
					variableCount += CPUHelpId_node_FalloffX.SetData((FSCpuHelp)FalloffX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ItemId:
					FSItemNode ItemId_node_FalloffX = graph.AddNode<FSItemNode>();
					GetPort("FalloffX").Connect(ItemId_node_FalloffX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ItemId_node_FalloffX, assetPath);
					variableCount += ItemId_node_FalloffX.SetData((FSItem)FalloffX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ModeId:
					FSModeNode ModeId_node_FalloffX = graph.AddNode<FSModeNode>();
					GetPort("FalloffX").Connect(ModeId_node_FalloffX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ModeId_node_FalloffX, assetPath);
					variableCount += ModeId_node_FalloffX.SetData((FSMode)FalloffX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.JumpsId:
					FSJumpsNode JumpsId_node_FalloffX = graph.AddNode<FSJumpsNode>();
					GetPort("FalloffX").Connect(JumpsId_node_FalloffX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(JumpsId_node_FalloffX, assetPath);
					variableCount += JumpsId_node_FalloffX.SetData((FSJumps)FalloffX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RootAnimId:
					FSRootAnimNode RootAnimId_node_FalloffX = graph.AddNode<FSRootAnimNode>();
					GetPort("FalloffX").Connect(RootAnimId_node_FalloffX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RootAnimId_node_FalloffX, assetPath);
					variableCount += RootAnimId_node_FalloffX.SetData((FSRootAnim)FalloffX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FloatId:
					FSValueNode FloatId_node_FalloffX = graph.AddNode<FSValueNode>();
					GetPort("FalloffX").Connect(FloatId_node_FalloffX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FloatId_node_FalloffX, assetPath);
					variableCount += FloatId_node_FalloffX.SetData((FSValue)FalloffX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
			}
			++variableCount;
			
			FalloffY = data.FalloffY;
			
			switch (FalloffY.TID)
			{
				case FloatSource.TypeId.AgentId:
					FSAgentNode AgentId_node_FalloffY = graph.AddNode<FSAgentNode>();
					GetPort("FalloffY").Connect(AgentId_node_FalloffY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AgentId_node_FalloffY, assetPath);
					variableCount += AgentId_node_FalloffY.SetData((FSAgent)FalloffY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.BonesId:
					FSBonesNode BonesId_node_FalloffY = graph.AddNode<FSBonesNode>();
					GetPort("FalloffY").Connect(BonesId_node_FalloffY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BonesId_node_FalloffY, assetPath);
					variableCount += BonesId_node_FalloffY.SetData((FSBones)FalloffY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AttackId:
					FSAttackNode AttackId_node_FalloffY = graph.AddNode<FSAttackNode>();
					GetPort("FalloffY").Connect(AttackId_node_FalloffY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AttackId_node_FalloffY, assetPath);
					variableCount += AttackId_node_FalloffY.SetData((FSAttack)FalloffY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FrameId:
					FSFrameNode FrameId_node_FalloffY = graph.AddNode<FSFrameNode>();
					GetPort("FalloffY").Connect(FrameId_node_FalloffY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FrameId_node_FalloffY, assetPath);
					variableCount += FrameId_node_FalloffY.SetData((FSFrame)FalloffY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.InputId:
					FSInputNode InputId_node_FalloffY = graph.AddNode<FSInputNode>();
					GetPort("FalloffY").Connect(InputId_node_FalloffY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputId_node_FalloffY, assetPath);
					variableCount += InputId_node_FalloffY.SetData((FSInput)FalloffY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FuncId:
					FSFuncNode FuncId_node_FalloffY = graph.AddNode<FSFuncNode>();
					GetPort("FalloffY").Connect(FuncId_node_FalloffY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FuncId_node_FalloffY, assetPath);
					variableCount += FuncId_node_FalloffY.SetData((FSFunc)FalloffY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.MovementId:
					FSMovementNode MovementId_node_FalloffY = graph.AddNode<FSMovementNode>();
					GetPort("FalloffY").Connect(MovementId_node_FalloffY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(MovementId_node_FalloffY, assetPath);
					variableCount += MovementId_node_FalloffY.SetData((FSMovement)FalloffY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CombatId:
					FSCombatNode CombatId_node_FalloffY = graph.AddNode<FSCombatNode>();
					GetPort("FalloffY").Connect(CombatId_node_FalloffY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CombatId_node_FalloffY, assetPath);
					variableCount += CombatId_node_FalloffY.SetData((FSCombat)FalloffY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.GrabsId:
					FSGrabsNode GrabsId_node_FalloffY = graph.AddNode<FSGrabsNode>();
					GetPort("FalloffY").Connect(GrabsId_node_FalloffY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(GrabsId_node_FalloffY, assetPath);
					variableCount += GrabsId_node_FalloffY.SetData((FSGrabs)FalloffY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.DataId:
					FSDataNode DataId_node_FalloffY = graph.AddNode<FSDataNode>();
					GetPort("FalloffY").Connect(DataId_node_FalloffY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DataId_node_FalloffY, assetPath);
					variableCount += DataId_node_FalloffY.SetData((FSData)FalloffY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ScratchId:
					FSScratchNode ScratchId_node_FalloffY = graph.AddNode<FSScratchNode>();
					GetPort("FalloffY").Connect(ScratchId_node_FalloffY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ScratchId_node_FalloffY, assetPath);
					variableCount += ScratchId_node_FalloffY.SetData((FSScratch)FalloffY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AnimId:
					FSAnimNode AnimId_node_FalloffY = graph.AddNode<FSAnimNode>();
					GetPort("FalloffY").Connect(AnimId_node_FalloffY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AnimId_node_FalloffY, assetPath);
					variableCount += AnimId_node_FalloffY.SetData((FSAnim)FalloffY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SpeedId:
					FSSpeedNode SpeedId_node_FalloffY = graph.AddNode<FSSpeedNode>();
					GetPort("FalloffY").Connect(SpeedId_node_FalloffY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpeedId_node_FalloffY, assetPath);
					variableCount += SpeedId_node_FalloffY.SetData((FSSpeed)FalloffY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.PhysicsId:
					FSPhysicsNode PhysicsId_node_FalloffY = graph.AddNode<FSPhysicsNode>();
					GetPort("FalloffY").Connect(PhysicsId_node_FalloffY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(PhysicsId_node_FalloffY, assetPath);
					variableCount += PhysicsId_node_FalloffY.SetData((FSPhysics)FalloffY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CollisionId:
					FSCollisionNode CollisionId_node_FalloffY = graph.AddNode<FSCollisionNode>();
					GetPort("FalloffY").Connect(CollisionId_node_FalloffY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CollisionId_node_FalloffY, assetPath);
					variableCount += CollisionId_node_FalloffY.SetData((FSCollision)FalloffY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.TimerId:
					FSTimerNode TimerId_node_FalloffY = graph.AddNode<FSTimerNode>();
					GetPort("FalloffY").Connect(TimerId_node_FalloffY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(TimerId_node_FalloffY, assetPath);
					variableCount += TimerId_node_FalloffY.SetData((FSTimer)FalloffY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.LagId:
					FSLagNode LagId_node_FalloffY = graph.AddNode<FSLagNode>();
					GetPort("FalloffY").Connect(LagId_node_FalloffY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LagId_node_FalloffY, assetPath);
					variableCount += LagId_node_FalloffY.SetData((FSLag)FalloffY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.EffectsId:
					FSEffectsNode EffectsId_node_FalloffY = graph.AddNode<FSEffectsNode>();
					GetPort("FalloffY").Connect(EffectsId_node_FalloffY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EffectsId_node_FalloffY, assetPath);
					variableCount += EffectsId_node_FalloffY.SetData((FSEffects)FalloffY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ColorsId:
					FSColorsNode ColorsId_node_FalloffY = graph.AddNode<FSColorsNode>();
					GetPort("FalloffY").Connect(ColorsId_node_FalloffY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ColorsId_node_FalloffY, assetPath);
					variableCount += ColorsId_node_FalloffY.SetData((FSColors)FalloffY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.OnHitId:
					FSOnHitNode OnHitId_node_FalloffY = graph.AddNode<FSOnHitNode>();
					GetPort("FalloffY").Connect(OnHitId_node_FalloffY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnHitId_node_FalloffY, assetPath);
					variableCount += OnHitId_node_FalloffY.SetData((FSOnHit)FalloffY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RandomId:
					FSRandomNode RandomId_node_FalloffY = graph.AddNode<FSRandomNode>();
					GetPort("FalloffY").Connect(RandomId_node_FalloffY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RandomId_node_FalloffY, assetPath);
					variableCount += RandomId_node_FalloffY.SetData((FSRandom)FalloffY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CameraId:
					FSCameraInfoNode CameraId_node_FalloffY = graph.AddNode<FSCameraInfoNode>();
					GetPort("FalloffY").Connect(CameraId_node_FalloffY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CameraId_node_FalloffY, assetPath);
					variableCount += CameraId_node_FalloffY.SetData((FSCameraInfo)FalloffY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SportsId:
					FSSportsNode SportsId_node_FalloffY = graph.AddNode<FSSportsNode>();
					GetPort("FalloffY").Connect(SportsId_node_FalloffY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SportsId_node_FalloffY, assetPath);
					variableCount += SportsId_node_FalloffY.SetData((FSSports)FalloffY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.Vector2Mag:
					FSVector2MagNode Vector2Mag_node_FalloffY = graph.AddNode<FSVector2MagNode>();
					GetPort("FalloffY").Connect(Vector2Mag_node_FalloffY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(Vector2Mag_node_FalloffY, assetPath);
					variableCount += Vector2Mag_node_FalloffY.SetData((FSVector2Mag)FalloffY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CPUHelpId:
					FSCpuHelpNode CPUHelpId_node_FalloffY = graph.AddNode<FSCpuHelpNode>();
					GetPort("FalloffY").Connect(CPUHelpId_node_FalloffY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CPUHelpId_node_FalloffY, assetPath);
					variableCount += CPUHelpId_node_FalloffY.SetData((FSCpuHelp)FalloffY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ItemId:
					FSItemNode ItemId_node_FalloffY = graph.AddNode<FSItemNode>();
					GetPort("FalloffY").Connect(ItemId_node_FalloffY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ItemId_node_FalloffY, assetPath);
					variableCount += ItemId_node_FalloffY.SetData((FSItem)FalloffY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ModeId:
					FSModeNode ModeId_node_FalloffY = graph.AddNode<FSModeNode>();
					GetPort("FalloffY").Connect(ModeId_node_FalloffY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ModeId_node_FalloffY, assetPath);
					variableCount += ModeId_node_FalloffY.SetData((FSMode)FalloffY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.JumpsId:
					FSJumpsNode JumpsId_node_FalloffY = graph.AddNode<FSJumpsNode>();
					GetPort("FalloffY").Connect(JumpsId_node_FalloffY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(JumpsId_node_FalloffY, assetPath);
					variableCount += JumpsId_node_FalloffY.SetData((FSJumps)FalloffY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RootAnimId:
					FSRootAnimNode RootAnimId_node_FalloffY = graph.AddNode<FSRootAnimNode>();
					GetPort("FalloffY").Connect(RootAnimId_node_FalloffY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RootAnimId_node_FalloffY, assetPath);
					variableCount += RootAnimId_node_FalloffY.SetData((FSRootAnim)FalloffY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FloatId:
					FSValueNode FloatId_node_FalloffY = graph.AddNode<FSValueNode>();
					GetPort("FalloffY").Connect(FloatId_node_FalloffY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FloatId_node_FalloffY, assetPath);
					variableCount += FloatId_node_FalloffY.SetData((FSValue)FalloffY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
			}
			
			return variableCount;
		}
		
		public new SAAlterMoveVel GetData()
		{
			SAAlterMoveVel objToReturn = new SAAlterMoveVel();
			objToReturn.TID = TypeId.AlterMoveVelId;
			objToReturn.Version = Version;
			objToReturn.ClearAMV = ClearAMV;
			if (GetPort("AlterX").ConnectionCount > 0)
			{
				FloatSourceNode FloatSource_Node = (FloatSourceNode)GetPort("AlterX").GetConnection(0).node;
				switch (FloatSource_Node.TID)
				{
					case FloatSource.TypeId.AgentId:
						FSAgentNode AgentId_FloatSource_Node = (FSAgentNode)GetPort("AlterX").GetConnection(0).node;
						objToReturn.AlterX = AgentId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.BonesId:
						FSBonesNode BonesId_FloatSource_Node = (FSBonesNode)GetPort("AlterX").GetConnection(0).node;
						objToReturn.AlterX = BonesId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AttackId:
						FSAttackNode AttackId_FloatSource_Node = (FSAttackNode)GetPort("AlterX").GetConnection(0).node;
						objToReturn.AlterX = AttackId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FrameId:
						FSFrameNode FrameId_FloatSource_Node = (FSFrameNode)GetPort("AlterX").GetConnection(0).node;
						objToReturn.AlterX = FrameId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.InputId:
						FSInputNode InputId_FloatSource_Node = (FSInputNode)GetPort("AlterX").GetConnection(0).node;
						objToReturn.AlterX = InputId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FuncId:
						FSFuncNode FuncId_FloatSource_Node = (FSFuncNode)GetPort("AlterX").GetConnection(0).node;
						objToReturn.AlterX = FuncId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.MovementId:
						FSMovementNode MovementId_FloatSource_Node = (FSMovementNode)GetPort("AlterX").GetConnection(0).node;
						objToReturn.AlterX = MovementId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CombatId:
						FSCombatNode CombatId_FloatSource_Node = (FSCombatNode)GetPort("AlterX").GetConnection(0).node;
						objToReturn.AlterX = CombatId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.GrabsId:
						FSGrabsNode GrabsId_FloatSource_Node = (FSGrabsNode)GetPort("AlterX").GetConnection(0).node;
						objToReturn.AlterX = GrabsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.DataId:
						FSDataNode DataId_FloatSource_Node = (FSDataNode)GetPort("AlterX").GetConnection(0).node;
						objToReturn.AlterX = DataId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ScratchId:
						FSScratchNode ScratchId_FloatSource_Node = (FSScratchNode)GetPort("AlterX").GetConnection(0).node;
						objToReturn.AlterX = ScratchId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AnimId:
						FSAnimNode AnimId_FloatSource_Node = (FSAnimNode)GetPort("AlterX").GetConnection(0).node;
						objToReturn.AlterX = AnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SpeedId:
						FSSpeedNode SpeedId_FloatSource_Node = (FSSpeedNode)GetPort("AlterX").GetConnection(0).node;
						objToReturn.AlterX = SpeedId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.PhysicsId:
						FSPhysicsNode PhysicsId_FloatSource_Node = (FSPhysicsNode)GetPort("AlterX").GetConnection(0).node;
						objToReturn.AlterX = PhysicsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CollisionId:
						FSCollisionNode CollisionId_FloatSource_Node = (FSCollisionNode)GetPort("AlterX").GetConnection(0).node;
						objToReturn.AlterX = CollisionId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.TimerId:
						FSTimerNode TimerId_FloatSource_Node = (FSTimerNode)GetPort("AlterX").GetConnection(0).node;
						objToReturn.AlterX = TimerId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.LagId:
						FSLagNode LagId_FloatSource_Node = (FSLagNode)GetPort("AlterX").GetConnection(0).node;
						objToReturn.AlterX = LagId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.EffectsId:
						FSEffectsNode EffectsId_FloatSource_Node = (FSEffectsNode)GetPort("AlterX").GetConnection(0).node;
						objToReturn.AlterX = EffectsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ColorsId:
						FSColorsNode ColorsId_FloatSource_Node = (FSColorsNode)GetPort("AlterX").GetConnection(0).node;
						objToReturn.AlterX = ColorsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.OnHitId:
						FSOnHitNode OnHitId_FloatSource_Node = (FSOnHitNode)GetPort("AlterX").GetConnection(0).node;
						objToReturn.AlterX = OnHitId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RandomId:
						FSRandomNode RandomId_FloatSource_Node = (FSRandomNode)GetPort("AlterX").GetConnection(0).node;
						objToReturn.AlterX = RandomId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CameraId:
						FSCameraInfoNode CameraId_FloatSource_Node = (FSCameraInfoNode)GetPort("AlterX").GetConnection(0).node;
						objToReturn.AlterX = CameraId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SportsId:
						FSSportsNode SportsId_FloatSource_Node = (FSSportsNode)GetPort("AlterX").GetConnection(0).node;
						objToReturn.AlterX = SportsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.Vector2Mag:
						FSVector2MagNode Vector2Mag_FloatSource_Node = (FSVector2MagNode)GetPort("AlterX").GetConnection(0).node;
						objToReturn.AlterX = Vector2Mag_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CPUHelpId:
						FSCpuHelpNode CPUHelpId_FloatSource_Node = (FSCpuHelpNode)GetPort("AlterX").GetConnection(0).node;
						objToReturn.AlterX = CPUHelpId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ItemId:
						FSItemNode ItemId_FloatSource_Node = (FSItemNode)GetPort("AlterX").GetConnection(0).node;
						objToReturn.AlterX = ItemId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ModeId:
						FSModeNode ModeId_FloatSource_Node = (FSModeNode)GetPort("AlterX").GetConnection(0).node;
						objToReturn.AlterX = ModeId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.JumpsId:
						FSJumpsNode JumpsId_FloatSource_Node = (FSJumpsNode)GetPort("AlterX").GetConnection(0).node;
						objToReturn.AlterX = JumpsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RootAnimId:
						FSRootAnimNode RootAnimId_FloatSource_Node = (FSRootAnimNode)GetPort("AlterX").GetConnection(0).node;
						objToReturn.AlterX = RootAnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FloatId:
						FSValueNode FloatId_FloatSource_Node = (FSValueNode)GetPort("AlterX").GetConnection(0).node;
						objToReturn.AlterX = FloatId_FloatSource_Node.GetData();
					break;
				}
			}
			if (GetPort("AlterY").ConnectionCount > 0)
			{
				FloatSourceNode FloatSource_Node = (FloatSourceNode)GetPort("AlterY").GetConnection(0).node;
				switch (FloatSource_Node.TID)
				{
					case FloatSource.TypeId.AgentId:
						FSAgentNode AgentId_FloatSource_Node = (FSAgentNode)GetPort("AlterY").GetConnection(0).node;
						objToReturn.AlterY = AgentId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.BonesId:
						FSBonesNode BonesId_FloatSource_Node = (FSBonesNode)GetPort("AlterY").GetConnection(0).node;
						objToReturn.AlterY = BonesId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AttackId:
						FSAttackNode AttackId_FloatSource_Node = (FSAttackNode)GetPort("AlterY").GetConnection(0).node;
						objToReturn.AlterY = AttackId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FrameId:
						FSFrameNode FrameId_FloatSource_Node = (FSFrameNode)GetPort("AlterY").GetConnection(0).node;
						objToReturn.AlterY = FrameId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.InputId:
						FSInputNode InputId_FloatSource_Node = (FSInputNode)GetPort("AlterY").GetConnection(0).node;
						objToReturn.AlterY = InputId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FuncId:
						FSFuncNode FuncId_FloatSource_Node = (FSFuncNode)GetPort("AlterY").GetConnection(0).node;
						objToReturn.AlterY = FuncId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.MovementId:
						FSMovementNode MovementId_FloatSource_Node = (FSMovementNode)GetPort("AlterY").GetConnection(0).node;
						objToReturn.AlterY = MovementId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CombatId:
						FSCombatNode CombatId_FloatSource_Node = (FSCombatNode)GetPort("AlterY").GetConnection(0).node;
						objToReturn.AlterY = CombatId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.GrabsId:
						FSGrabsNode GrabsId_FloatSource_Node = (FSGrabsNode)GetPort("AlterY").GetConnection(0).node;
						objToReturn.AlterY = GrabsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.DataId:
						FSDataNode DataId_FloatSource_Node = (FSDataNode)GetPort("AlterY").GetConnection(0).node;
						objToReturn.AlterY = DataId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ScratchId:
						FSScratchNode ScratchId_FloatSource_Node = (FSScratchNode)GetPort("AlterY").GetConnection(0).node;
						objToReturn.AlterY = ScratchId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AnimId:
						FSAnimNode AnimId_FloatSource_Node = (FSAnimNode)GetPort("AlterY").GetConnection(0).node;
						objToReturn.AlterY = AnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SpeedId:
						FSSpeedNode SpeedId_FloatSource_Node = (FSSpeedNode)GetPort("AlterY").GetConnection(0).node;
						objToReturn.AlterY = SpeedId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.PhysicsId:
						FSPhysicsNode PhysicsId_FloatSource_Node = (FSPhysicsNode)GetPort("AlterY").GetConnection(0).node;
						objToReturn.AlterY = PhysicsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CollisionId:
						FSCollisionNode CollisionId_FloatSource_Node = (FSCollisionNode)GetPort("AlterY").GetConnection(0).node;
						objToReturn.AlterY = CollisionId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.TimerId:
						FSTimerNode TimerId_FloatSource_Node = (FSTimerNode)GetPort("AlterY").GetConnection(0).node;
						objToReturn.AlterY = TimerId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.LagId:
						FSLagNode LagId_FloatSource_Node = (FSLagNode)GetPort("AlterY").GetConnection(0).node;
						objToReturn.AlterY = LagId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.EffectsId:
						FSEffectsNode EffectsId_FloatSource_Node = (FSEffectsNode)GetPort("AlterY").GetConnection(0).node;
						objToReturn.AlterY = EffectsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ColorsId:
						FSColorsNode ColorsId_FloatSource_Node = (FSColorsNode)GetPort("AlterY").GetConnection(0).node;
						objToReturn.AlterY = ColorsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.OnHitId:
						FSOnHitNode OnHitId_FloatSource_Node = (FSOnHitNode)GetPort("AlterY").GetConnection(0).node;
						objToReturn.AlterY = OnHitId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RandomId:
						FSRandomNode RandomId_FloatSource_Node = (FSRandomNode)GetPort("AlterY").GetConnection(0).node;
						objToReturn.AlterY = RandomId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CameraId:
						FSCameraInfoNode CameraId_FloatSource_Node = (FSCameraInfoNode)GetPort("AlterY").GetConnection(0).node;
						objToReturn.AlterY = CameraId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SportsId:
						FSSportsNode SportsId_FloatSource_Node = (FSSportsNode)GetPort("AlterY").GetConnection(0).node;
						objToReturn.AlterY = SportsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.Vector2Mag:
						FSVector2MagNode Vector2Mag_FloatSource_Node = (FSVector2MagNode)GetPort("AlterY").GetConnection(0).node;
						objToReturn.AlterY = Vector2Mag_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CPUHelpId:
						FSCpuHelpNode CPUHelpId_FloatSource_Node = (FSCpuHelpNode)GetPort("AlterY").GetConnection(0).node;
						objToReturn.AlterY = CPUHelpId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ItemId:
						FSItemNode ItemId_FloatSource_Node = (FSItemNode)GetPort("AlterY").GetConnection(0).node;
						objToReturn.AlterY = ItemId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ModeId:
						FSModeNode ModeId_FloatSource_Node = (FSModeNode)GetPort("AlterY").GetConnection(0).node;
						objToReturn.AlterY = ModeId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.JumpsId:
						FSJumpsNode JumpsId_FloatSource_Node = (FSJumpsNode)GetPort("AlterY").GetConnection(0).node;
						objToReturn.AlterY = JumpsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RootAnimId:
						FSRootAnimNode RootAnimId_FloatSource_Node = (FSRootAnimNode)GetPort("AlterY").GetConnection(0).node;
						objToReturn.AlterY = RootAnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FloatId:
						FSValueNode FloatId_FloatSource_Node = (FSValueNode)GetPort("AlterY").GetConnection(0).node;
						objToReturn.AlterY = FloatId_FloatSource_Node.GetData();
					break;
				}
			}
			if (GetPort("FalloffX").ConnectionCount > 0)
			{
				FloatSourceNode FloatSource_Node = (FloatSourceNode)GetPort("FalloffX").GetConnection(0).node;
				switch (FloatSource_Node.TID)
				{
					case FloatSource.TypeId.AgentId:
						FSAgentNode AgentId_FloatSource_Node = (FSAgentNode)GetPort("FalloffX").GetConnection(0).node;
						objToReturn.FalloffX = AgentId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.BonesId:
						FSBonesNode BonesId_FloatSource_Node = (FSBonesNode)GetPort("FalloffX").GetConnection(0).node;
						objToReturn.FalloffX = BonesId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AttackId:
						FSAttackNode AttackId_FloatSource_Node = (FSAttackNode)GetPort("FalloffX").GetConnection(0).node;
						objToReturn.FalloffX = AttackId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FrameId:
						FSFrameNode FrameId_FloatSource_Node = (FSFrameNode)GetPort("FalloffX").GetConnection(0).node;
						objToReturn.FalloffX = FrameId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.InputId:
						FSInputNode InputId_FloatSource_Node = (FSInputNode)GetPort("FalloffX").GetConnection(0).node;
						objToReturn.FalloffX = InputId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FuncId:
						FSFuncNode FuncId_FloatSource_Node = (FSFuncNode)GetPort("FalloffX").GetConnection(0).node;
						objToReturn.FalloffX = FuncId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.MovementId:
						FSMovementNode MovementId_FloatSource_Node = (FSMovementNode)GetPort("FalloffX").GetConnection(0).node;
						objToReturn.FalloffX = MovementId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CombatId:
						FSCombatNode CombatId_FloatSource_Node = (FSCombatNode)GetPort("FalloffX").GetConnection(0).node;
						objToReturn.FalloffX = CombatId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.GrabsId:
						FSGrabsNode GrabsId_FloatSource_Node = (FSGrabsNode)GetPort("FalloffX").GetConnection(0).node;
						objToReturn.FalloffX = GrabsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.DataId:
						FSDataNode DataId_FloatSource_Node = (FSDataNode)GetPort("FalloffX").GetConnection(0).node;
						objToReturn.FalloffX = DataId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ScratchId:
						FSScratchNode ScratchId_FloatSource_Node = (FSScratchNode)GetPort("FalloffX").GetConnection(0).node;
						objToReturn.FalloffX = ScratchId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AnimId:
						FSAnimNode AnimId_FloatSource_Node = (FSAnimNode)GetPort("FalloffX").GetConnection(0).node;
						objToReturn.FalloffX = AnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SpeedId:
						FSSpeedNode SpeedId_FloatSource_Node = (FSSpeedNode)GetPort("FalloffX").GetConnection(0).node;
						objToReturn.FalloffX = SpeedId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.PhysicsId:
						FSPhysicsNode PhysicsId_FloatSource_Node = (FSPhysicsNode)GetPort("FalloffX").GetConnection(0).node;
						objToReturn.FalloffX = PhysicsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CollisionId:
						FSCollisionNode CollisionId_FloatSource_Node = (FSCollisionNode)GetPort("FalloffX").GetConnection(0).node;
						objToReturn.FalloffX = CollisionId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.TimerId:
						FSTimerNode TimerId_FloatSource_Node = (FSTimerNode)GetPort("FalloffX").GetConnection(0).node;
						objToReturn.FalloffX = TimerId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.LagId:
						FSLagNode LagId_FloatSource_Node = (FSLagNode)GetPort("FalloffX").GetConnection(0).node;
						objToReturn.FalloffX = LagId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.EffectsId:
						FSEffectsNode EffectsId_FloatSource_Node = (FSEffectsNode)GetPort("FalloffX").GetConnection(0).node;
						objToReturn.FalloffX = EffectsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ColorsId:
						FSColorsNode ColorsId_FloatSource_Node = (FSColorsNode)GetPort("FalloffX").GetConnection(0).node;
						objToReturn.FalloffX = ColorsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.OnHitId:
						FSOnHitNode OnHitId_FloatSource_Node = (FSOnHitNode)GetPort("FalloffX").GetConnection(0).node;
						objToReturn.FalloffX = OnHitId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RandomId:
						FSRandomNode RandomId_FloatSource_Node = (FSRandomNode)GetPort("FalloffX").GetConnection(0).node;
						objToReturn.FalloffX = RandomId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CameraId:
						FSCameraInfoNode CameraId_FloatSource_Node = (FSCameraInfoNode)GetPort("FalloffX").GetConnection(0).node;
						objToReturn.FalloffX = CameraId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SportsId:
						FSSportsNode SportsId_FloatSource_Node = (FSSportsNode)GetPort("FalloffX").GetConnection(0).node;
						objToReturn.FalloffX = SportsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.Vector2Mag:
						FSVector2MagNode Vector2Mag_FloatSource_Node = (FSVector2MagNode)GetPort("FalloffX").GetConnection(0).node;
						objToReturn.FalloffX = Vector2Mag_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CPUHelpId:
						FSCpuHelpNode CPUHelpId_FloatSource_Node = (FSCpuHelpNode)GetPort("FalloffX").GetConnection(0).node;
						objToReturn.FalloffX = CPUHelpId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ItemId:
						FSItemNode ItemId_FloatSource_Node = (FSItemNode)GetPort("FalloffX").GetConnection(0).node;
						objToReturn.FalloffX = ItemId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ModeId:
						FSModeNode ModeId_FloatSource_Node = (FSModeNode)GetPort("FalloffX").GetConnection(0).node;
						objToReturn.FalloffX = ModeId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.JumpsId:
						FSJumpsNode JumpsId_FloatSource_Node = (FSJumpsNode)GetPort("FalloffX").GetConnection(0).node;
						objToReturn.FalloffX = JumpsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RootAnimId:
						FSRootAnimNode RootAnimId_FloatSource_Node = (FSRootAnimNode)GetPort("FalloffX").GetConnection(0).node;
						objToReturn.FalloffX = RootAnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FloatId:
						FSValueNode FloatId_FloatSource_Node = (FSValueNode)GetPort("FalloffX").GetConnection(0).node;
						objToReturn.FalloffX = FloatId_FloatSource_Node.GetData();
					break;
				}
			}
			if (GetPort("FalloffY").ConnectionCount > 0)
			{
				FloatSourceNode FloatSource_Node = (FloatSourceNode)GetPort("FalloffY").GetConnection(0).node;
				switch (FloatSource_Node.TID)
				{
					case FloatSource.TypeId.AgentId:
						FSAgentNode AgentId_FloatSource_Node = (FSAgentNode)GetPort("FalloffY").GetConnection(0).node;
						objToReturn.FalloffY = AgentId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.BonesId:
						FSBonesNode BonesId_FloatSource_Node = (FSBonesNode)GetPort("FalloffY").GetConnection(0).node;
						objToReturn.FalloffY = BonesId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AttackId:
						FSAttackNode AttackId_FloatSource_Node = (FSAttackNode)GetPort("FalloffY").GetConnection(0).node;
						objToReturn.FalloffY = AttackId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FrameId:
						FSFrameNode FrameId_FloatSource_Node = (FSFrameNode)GetPort("FalloffY").GetConnection(0).node;
						objToReturn.FalloffY = FrameId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.InputId:
						FSInputNode InputId_FloatSource_Node = (FSInputNode)GetPort("FalloffY").GetConnection(0).node;
						objToReturn.FalloffY = InputId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FuncId:
						FSFuncNode FuncId_FloatSource_Node = (FSFuncNode)GetPort("FalloffY").GetConnection(0).node;
						objToReturn.FalloffY = FuncId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.MovementId:
						FSMovementNode MovementId_FloatSource_Node = (FSMovementNode)GetPort("FalloffY").GetConnection(0).node;
						objToReturn.FalloffY = MovementId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CombatId:
						FSCombatNode CombatId_FloatSource_Node = (FSCombatNode)GetPort("FalloffY").GetConnection(0).node;
						objToReturn.FalloffY = CombatId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.GrabsId:
						FSGrabsNode GrabsId_FloatSource_Node = (FSGrabsNode)GetPort("FalloffY").GetConnection(0).node;
						objToReturn.FalloffY = GrabsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.DataId:
						FSDataNode DataId_FloatSource_Node = (FSDataNode)GetPort("FalloffY").GetConnection(0).node;
						objToReturn.FalloffY = DataId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ScratchId:
						FSScratchNode ScratchId_FloatSource_Node = (FSScratchNode)GetPort("FalloffY").GetConnection(0).node;
						objToReturn.FalloffY = ScratchId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AnimId:
						FSAnimNode AnimId_FloatSource_Node = (FSAnimNode)GetPort("FalloffY").GetConnection(0).node;
						objToReturn.FalloffY = AnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SpeedId:
						FSSpeedNode SpeedId_FloatSource_Node = (FSSpeedNode)GetPort("FalloffY").GetConnection(0).node;
						objToReturn.FalloffY = SpeedId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.PhysicsId:
						FSPhysicsNode PhysicsId_FloatSource_Node = (FSPhysicsNode)GetPort("FalloffY").GetConnection(0).node;
						objToReturn.FalloffY = PhysicsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CollisionId:
						FSCollisionNode CollisionId_FloatSource_Node = (FSCollisionNode)GetPort("FalloffY").GetConnection(0).node;
						objToReturn.FalloffY = CollisionId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.TimerId:
						FSTimerNode TimerId_FloatSource_Node = (FSTimerNode)GetPort("FalloffY").GetConnection(0).node;
						objToReturn.FalloffY = TimerId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.LagId:
						FSLagNode LagId_FloatSource_Node = (FSLagNode)GetPort("FalloffY").GetConnection(0).node;
						objToReturn.FalloffY = LagId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.EffectsId:
						FSEffectsNode EffectsId_FloatSource_Node = (FSEffectsNode)GetPort("FalloffY").GetConnection(0).node;
						objToReturn.FalloffY = EffectsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ColorsId:
						FSColorsNode ColorsId_FloatSource_Node = (FSColorsNode)GetPort("FalloffY").GetConnection(0).node;
						objToReturn.FalloffY = ColorsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.OnHitId:
						FSOnHitNode OnHitId_FloatSource_Node = (FSOnHitNode)GetPort("FalloffY").GetConnection(0).node;
						objToReturn.FalloffY = OnHitId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RandomId:
						FSRandomNode RandomId_FloatSource_Node = (FSRandomNode)GetPort("FalloffY").GetConnection(0).node;
						objToReturn.FalloffY = RandomId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CameraId:
						FSCameraInfoNode CameraId_FloatSource_Node = (FSCameraInfoNode)GetPort("FalloffY").GetConnection(0).node;
						objToReturn.FalloffY = CameraId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SportsId:
						FSSportsNode SportsId_FloatSource_Node = (FSSportsNode)GetPort("FalloffY").GetConnection(0).node;
						objToReturn.FalloffY = SportsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.Vector2Mag:
						FSVector2MagNode Vector2Mag_FloatSource_Node = (FSVector2MagNode)GetPort("FalloffY").GetConnection(0).node;
						objToReturn.FalloffY = Vector2Mag_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CPUHelpId:
						FSCpuHelpNode CPUHelpId_FloatSource_Node = (FSCpuHelpNode)GetPort("FalloffY").GetConnection(0).node;
						objToReturn.FalloffY = CPUHelpId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ItemId:
						FSItemNode ItemId_FloatSource_Node = (FSItemNode)GetPort("FalloffY").GetConnection(0).node;
						objToReturn.FalloffY = ItemId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ModeId:
						FSModeNode ModeId_FloatSource_Node = (FSModeNode)GetPort("FalloffY").GetConnection(0).node;
						objToReturn.FalloffY = ModeId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.JumpsId:
						FSJumpsNode JumpsId_FloatSource_Node = (FSJumpsNode)GetPort("FalloffY").GetConnection(0).node;
						objToReturn.FalloffY = JumpsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RootAnimId:
						FSRootAnimNode RootAnimId_FloatSource_Node = (FSRootAnimNode)GetPort("FalloffY").GetConnection(0).node;
						objToReturn.FalloffY = RootAnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FloatId:
						FSValueNode FloatId_FloatSource_Node = (FSValueNode)GetPort("FalloffY").GetConnection(0).node;
						objToReturn.FalloffY = FloatId_FloatSource_Node.GetData();
					break;
				}
			}
			return objToReturn;
		}
	}
}

