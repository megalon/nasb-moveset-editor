// * 
// * 
// * This file was generated using MovesetParser_to_xNode by megalon2d
// * https://github.com/megalon/MovesetParser_to_xNode
// * 
// * 
using MovesetParser.FloatSources;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEditor;
using XNode;
using XNodeEditor;
using MovesetParser;
using MovesetParser.Jumps;
using MovesetParser.CheckThings;
using MovesetParser.StateActions;
using MovesetParser.ObjectSources;
using NASB_Moveset_Editor.FloatSources;
using NASB_Moveset_Editor.Jumps;
using NASB_Moveset_Editor.CheckThings;
using NASB_Moveset_Editor.StateActions;
using NASB_Moveset_Editor.ObjectSources;
using static MovesetParser.StateActions.StateAction;

namespace NASB_Moveset_Editor.StateActions
{
	public class SATimedActionNode : StateActionNode
	{
		[Input(connectionType = ConnectionType.Override)] public StateAction NodeInput;
		[Output(connectionType = ConnectionType.Override)] public FloatSource Source;
		public bool Repeat;
		[Output(connectionType = ConnectionType.Override)] public StateAction Action;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.TimerId;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SATimedAction data, MovesetGraph graph, string assetPath, Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SATimedAction));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			Source = data.Source;
			
			switch (Source.TID)
			{
				case FloatSource.TypeId.AgentId:
					FSAgentNode AgentId_node_Source = graph.AddNode<FSAgentNode>();
					GetPort("Source").Connect(AgentId_node_Source.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AgentId_node_Source, assetPath);
					variableCount += AgentId_node_Source.SetData((FSAgent)Source, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.BonesId:
					FSBonesNode BonesId_node_Source = graph.AddNode<FSBonesNode>();
					GetPort("Source").Connect(BonesId_node_Source.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BonesId_node_Source, assetPath);
					variableCount += BonesId_node_Source.SetData((FSBones)Source, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AttackId:
					FSAttackNode AttackId_node_Source = graph.AddNode<FSAttackNode>();
					GetPort("Source").Connect(AttackId_node_Source.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AttackId_node_Source, assetPath);
					variableCount += AttackId_node_Source.SetData((FSAttack)Source, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FrameId:
					FSFrameNode FrameId_node_Source = graph.AddNode<FSFrameNode>();
					GetPort("Source").Connect(FrameId_node_Source.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FrameId_node_Source, assetPath);
					variableCount += FrameId_node_Source.SetData((FSFrame)Source, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.InputId:
					FSInputNode InputId_node_Source = graph.AddNode<FSInputNode>();
					GetPort("Source").Connect(InputId_node_Source.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputId_node_Source, assetPath);
					variableCount += InputId_node_Source.SetData((FSInput)Source, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FuncId:
					FSFuncNode FuncId_node_Source = graph.AddNode<FSFuncNode>();
					GetPort("Source").Connect(FuncId_node_Source.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FuncId_node_Source, assetPath);
					variableCount += FuncId_node_Source.SetData((FSFunc)Source, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.MovementId:
					FSMovementNode MovementId_node_Source = graph.AddNode<FSMovementNode>();
					GetPort("Source").Connect(MovementId_node_Source.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(MovementId_node_Source, assetPath);
					variableCount += MovementId_node_Source.SetData((FSMovement)Source, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CombatId:
					FSCombatNode CombatId_node_Source = graph.AddNode<FSCombatNode>();
					GetPort("Source").Connect(CombatId_node_Source.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CombatId_node_Source, assetPath);
					variableCount += CombatId_node_Source.SetData((FSCombat)Source, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.GrabsId:
					FSGrabsNode GrabsId_node_Source = graph.AddNode<FSGrabsNode>();
					GetPort("Source").Connect(GrabsId_node_Source.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(GrabsId_node_Source, assetPath);
					variableCount += GrabsId_node_Source.SetData((FSGrabs)Source, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.DataId:
					FSDataNode DataId_node_Source = graph.AddNode<FSDataNode>();
					GetPort("Source").Connect(DataId_node_Source.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DataId_node_Source, assetPath);
					variableCount += DataId_node_Source.SetData((FSData)Source, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ScratchId:
					FSScratchNode ScratchId_node_Source = graph.AddNode<FSScratchNode>();
					GetPort("Source").Connect(ScratchId_node_Source.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ScratchId_node_Source, assetPath);
					variableCount += ScratchId_node_Source.SetData((FSScratch)Source, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AnimId:
					FSAnimNode AnimId_node_Source = graph.AddNode<FSAnimNode>();
					GetPort("Source").Connect(AnimId_node_Source.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AnimId_node_Source, assetPath);
					variableCount += AnimId_node_Source.SetData((FSAnim)Source, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SpeedId:
					FSSpeedNode SpeedId_node_Source = graph.AddNode<FSSpeedNode>();
					GetPort("Source").Connect(SpeedId_node_Source.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpeedId_node_Source, assetPath);
					variableCount += SpeedId_node_Source.SetData((FSSpeed)Source, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.PhysicsId:
					FSPhysicsNode PhysicsId_node_Source = graph.AddNode<FSPhysicsNode>();
					GetPort("Source").Connect(PhysicsId_node_Source.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(PhysicsId_node_Source, assetPath);
					variableCount += PhysicsId_node_Source.SetData((FSPhysics)Source, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CollisionId:
					FSCollisionNode CollisionId_node_Source = graph.AddNode<FSCollisionNode>();
					GetPort("Source").Connect(CollisionId_node_Source.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CollisionId_node_Source, assetPath);
					variableCount += CollisionId_node_Source.SetData((FSCollision)Source, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.TimerId:
					FSTimerNode TimerId_node_Source = graph.AddNode<FSTimerNode>();
					GetPort("Source").Connect(TimerId_node_Source.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(TimerId_node_Source, assetPath);
					variableCount += TimerId_node_Source.SetData((FSTimer)Source, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.LagId:
					FSLagNode LagId_node_Source = graph.AddNode<FSLagNode>();
					GetPort("Source").Connect(LagId_node_Source.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LagId_node_Source, assetPath);
					variableCount += LagId_node_Source.SetData((FSLag)Source, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.EffectsId:
					FSEffectsNode EffectsId_node_Source = graph.AddNode<FSEffectsNode>();
					GetPort("Source").Connect(EffectsId_node_Source.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EffectsId_node_Source, assetPath);
					variableCount += EffectsId_node_Source.SetData((FSEffects)Source, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ColorsId:
					FSColorsNode ColorsId_node_Source = graph.AddNode<FSColorsNode>();
					GetPort("Source").Connect(ColorsId_node_Source.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ColorsId_node_Source, assetPath);
					variableCount += ColorsId_node_Source.SetData((FSColors)Source, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.OnHitId:
					FSOnHitNode OnHitId_node_Source = graph.AddNode<FSOnHitNode>();
					GetPort("Source").Connect(OnHitId_node_Source.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnHitId_node_Source, assetPath);
					variableCount += OnHitId_node_Source.SetData((FSOnHit)Source, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RandomId:
					FSRandomNode RandomId_node_Source = graph.AddNode<FSRandomNode>();
					GetPort("Source").Connect(RandomId_node_Source.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RandomId_node_Source, assetPath);
					variableCount += RandomId_node_Source.SetData((FSRandom)Source, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CameraId:
					FSCameraInfoNode CameraId_node_Source = graph.AddNode<FSCameraInfoNode>();
					GetPort("Source").Connect(CameraId_node_Source.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CameraId_node_Source, assetPath);
					variableCount += CameraId_node_Source.SetData((FSCameraInfo)Source, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SportsId:
					FSSportsNode SportsId_node_Source = graph.AddNode<FSSportsNode>();
					GetPort("Source").Connect(SportsId_node_Source.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SportsId_node_Source, assetPath);
					variableCount += SportsId_node_Source.SetData((FSSports)Source, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.Vector2Mag:
					FSVector2MagNode Vector2Mag_node_Source = graph.AddNode<FSVector2MagNode>();
					GetPort("Source").Connect(Vector2Mag_node_Source.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(Vector2Mag_node_Source, assetPath);
					variableCount += Vector2Mag_node_Source.SetData((FSVector2Mag)Source, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CPUHelpId:
					FSCpuHelpNode CPUHelpId_node_Source = graph.AddNode<FSCpuHelpNode>();
					GetPort("Source").Connect(CPUHelpId_node_Source.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CPUHelpId_node_Source, assetPath);
					variableCount += CPUHelpId_node_Source.SetData((FSCpuHelp)Source, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ItemId:
					FSItemNode ItemId_node_Source = graph.AddNode<FSItemNode>();
					GetPort("Source").Connect(ItemId_node_Source.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ItemId_node_Source, assetPath);
					variableCount += ItemId_node_Source.SetData((FSItem)Source, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ModeId:
					FSModeNode ModeId_node_Source = graph.AddNode<FSModeNode>();
					GetPort("Source").Connect(ModeId_node_Source.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ModeId_node_Source, assetPath);
					variableCount += ModeId_node_Source.SetData((FSMode)Source, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.JumpsId:
					FSJumpsNode JumpsId_node_Source = graph.AddNode<FSJumpsNode>();
					GetPort("Source").Connect(JumpsId_node_Source.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(JumpsId_node_Source, assetPath);
					variableCount += JumpsId_node_Source.SetData((FSJumps)Source, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RootAnimId:
					FSRootAnimNode RootAnimId_node_Source = graph.AddNode<FSRootAnimNode>();
					GetPort("Source").Connect(RootAnimId_node_Source.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RootAnimId_node_Source, assetPath);
					variableCount += RootAnimId_node_Source.SetData((FSRootAnim)Source, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FloatId:
					FSValueNode FloatId_node_Source = graph.AddNode<FSValueNode>();
					GetPort("Source").Connect(FloatId_node_Source.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FloatId_node_Source, assetPath);
					variableCount += FloatId_node_Source.SetData((FSValue)Source, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
			}
			++variableCount;
			
			Repeat = data.Repeat;
			Action = data.Action;
			
			switch (Action.TID)
			{
				case StateAction.TypeId.DebugId:
					SADebugMessageNode DebugId_node_Action = graph.AddNode<SADebugMessageNode>();
					GetPort("Action").Connect(DebugId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DebugId_node_Action, assetPath);
					variableCount += DebugId_node_Action.SetData((SADebugMessage)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.PlayAnimId:
					SAPlayAnimNode PlayAnimId_node_Action = graph.AddNode<SAPlayAnimNode>();
					GetPort("Action").Connect(PlayAnimId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(PlayAnimId_node_Action, assetPath);
					variableCount += PlayAnimId_node_Action.SetData((SAPlayAnim)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.RootAnimId:
					SAPlayRootAnimNode RootAnimId_node_Action = graph.AddNode<SAPlayRootAnimNode>();
					GetPort("Action").Connect(RootAnimId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RootAnimId_node_Action, assetPath);
					variableCount += RootAnimId_node_Action.SetData((SAPlayRootAnim)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SnapAnimWeightsId:
					SASnapAnimWeightsNode SnapAnimWeightsId_node_Action = graph.AddNode<SASnapAnimWeightsNode>();
					GetPort("Action").Connect(SnapAnimWeightsId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SnapAnimWeightsId_node_Action, assetPath);
					variableCount += SnapAnimWeightsId_node_Action.SetData((SASnapAnimWeights)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.StandardInputId:
					SAStandardInputNode StandardInputId_node_Action = graph.AddNode<SAStandardInputNode>();
					GetPort("Action").Connect(StandardInputId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(StandardInputId_node_Action, assetPath);
					variableCount += StandardInputId_node_Action.SetData((SAStandardInput)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.InputId:
					SAInputActionNode InputId_node_Action = graph.AddNode<SAInputActionNode>();
					GetPort("Action").Connect(InputId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputId_node_Action, assetPath);
					variableCount += InputId_node_Action.SetData((SAInputAction)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.DeactInputId:
					SADeactivateInputActionNode DeactInputId_node_Action = graph.AddNode<SADeactivateInputActionNode>();
					GetPort("Action").Connect(DeactInputId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DeactInputId_node_Action, assetPath);
					variableCount += DeactInputId_node_Action.SetData((SADeactivateInputAction)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.InputEventFromFrameId:
					SAAddInputEventFromFrameNode InputEventFromFrameId_node_Action = graph.AddNode<SAAddInputEventFromFrameNode>();
					GetPort("Action").Connect(InputEventFromFrameId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputEventFromFrameId_node_Action, assetPath);
					variableCount += InputEventFromFrameId_node_Action.SetData((SAAddInputEventFromFrame)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.CancelStateId:
					SACancelToStateNode CancelStateId_node_Action = graph.AddNode<SACancelToStateNode>();
					GetPort("Action").Connect(CancelStateId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CancelStateId_node_Action, assetPath);
					variableCount += CancelStateId_node_Action.SetData((SACancelToState)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.CustomCallId:
					SACustomCallNode CustomCallId_node_Action = graph.AddNode<SACustomCallNode>();
					GetPort("Action").Connect(CustomCallId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CustomCallId_node_Action, assetPath);
					variableCount += CustomCallId_node_Action.SetData((SACustomCall)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.TimerId:
					SATimedActionNode TimerId_node_Action = graph.AddNode<SATimedActionNode>();
					GetPort("Action").Connect(TimerId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(TimerId_node_Action, assetPath);
					variableCount += TimerId_node_Action.SetData((SATimedAction)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.OrderId:
					SAOrderedSensitiveNode OrderId_node_Action = graph.AddNode<SAOrderedSensitiveNode>();
					GetPort("Action").Connect(OrderId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OrderId_node_Action, assetPath);
					variableCount += OrderId_node_Action.SetData((SAOrderedSensitive)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.ProxyId:
					SAProxyMoveNode ProxyId_node_Action = graph.AddNode<SAProxyMoveNode>();
					GetPort("Action").Connect(ProxyId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ProxyId_node_Action, assetPath);
					variableCount += ProxyId_node_Action.SetData((SAProxyMove)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.CheckId:
					SACheckThingNode CheckId_node_Action = graph.AddNode<SACheckThingNode>();
					GetPort("Action").Connect(CheckId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CheckId_node_Action, assetPath);
					variableCount += CheckId_node_Action.SetData((SACheckThing)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.ActiveActionId:
					SAActiveActionNode ActiveActionId_node_Action = graph.AddNode<SAActiveActionNode>();
					GetPort("Action").Connect(ActiveActionId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ActiveActionId_node_Action, assetPath);
					variableCount += ActiveActionId_node_Action.SetData((SAActiveAction)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.DeactivateActionId:
					SADeactivateActionNode DeactivateActionId_node_Action = graph.AddNode<SADeactivateActionNode>();
					GetPort("Action").Connect(DeactivateActionId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DeactivateActionId_node_Action, assetPath);
					variableCount += DeactivateActionId_node_Action.SetData((SADeactivateAction)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SetFloatId:
					SASetFloatTargetNode SetFloatId_node_Action = graph.AddNode<SASetFloatTargetNode>();
					GetPort("Action").Connect(SetFloatId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SetFloatId_node_Action, assetPath);
					variableCount += SetFloatId_node_Action.SetData((SASetFloatTarget)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.OnBounceId:
					SAOnBounceNode OnBounceId_node_Action = graph.AddNode<SAOnBounceNode>();
					GetPort("Action").Connect(OnBounceId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnBounceId_node_Action, assetPath);
					variableCount += OnBounceId_node_Action.SetData((SAOnBounce)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.OnLeaveEdgeId:
					SAOnLeaveEdgeNode OnLeaveEdgeId_node_Action = graph.AddNode<SAOnLeaveEdgeNode>();
					GetPort("Action").Connect(OnLeaveEdgeId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnLeaveEdgeId_node_Action, assetPath);
					variableCount += OnLeaveEdgeId_node_Action.SetData((SAOnLeaveEdge)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.OnStoppedAtEdgeId:
					SAOnStoppedAtLedgeNode OnStoppedAtEdgeId_node_Action = graph.AddNode<SAOnStoppedAtLedgeNode>();
					GetPort("Action").Connect(OnStoppedAtEdgeId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnStoppedAtEdgeId_node_Action, assetPath);
					variableCount += OnStoppedAtEdgeId_node_Action.SetData((SAOnStoppedAtLedge)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.OnLandId:
					SAOnLandNode OnLandId_node_Action = graph.AddNode<SAOnLandNode>();
					GetPort("Action").Connect(OnLandId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnLandId_node_Action, assetPath);
					variableCount += OnLandId_node_Action.SetData((SAOnLand)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.OnCancelId:
					SAOnCancelNode OnCancelId_node_Action = graph.AddNode<SAOnCancelNode>();
					GetPort("Action").Connect(OnCancelId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnCancelId_node_Action, assetPath);
					variableCount += OnCancelId_node_Action.SetData((SAOnCancel)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.RefreshAtkId:
					SARefreshAttackNode RefreshAtkId_node_Action = graph.AddNode<SARefreshAttackNode>();
					GetPort("Action").Connect(RefreshAtkId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RefreshAtkId_node_Action, assetPath);
					variableCount += RefreshAtkId_node_Action.SetData((SARefreshAttack)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.EndAtkId:
					SAEndAttackNode EndAtkId_node_Action = graph.AddNode<SAEndAttackNode>();
					GetPort("Action").Connect(EndAtkId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EndAtkId_node_Action, assetPath);
					variableCount += EndAtkId_node_Action.SetData((SAEndAttack)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SetHitboxCountId:
					SASetHitboxCountNode SetHitboxCountId_node_Action = graph.AddNode<SASetHitboxCountNode>();
					GetPort("Action").Connect(SetHitboxCountId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SetHitboxCountId_node_Action, assetPath);
					variableCount += SetHitboxCountId_node_Action.SetData((SASetHitboxCount)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.ConfigHitboxId:
					SAConfigHitboxNode ConfigHitboxId_node_Action = graph.AddNode<SAConfigHitboxNode>();
					GetPort("Action").Connect(ConfigHitboxId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ConfigHitboxId_node_Action, assetPath);
					variableCount += ConfigHitboxId_node_Action.SetData((SAConfigHitbox)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SetAtkPropId:
					SASetAttackPropNode SetAtkPropId_node_Action = graph.AddNode<SASetAttackPropNode>();
					GetPort("Action").Connect(SetAtkPropId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SetAtkPropId_node_Action, assetPath);
					variableCount += SetAtkPropId_node_Action.SetData((SASetAttackProp)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.ManipHitboxId:
					SAManipHitboxNode ManipHitboxId_node_Action = graph.AddNode<SAManipHitboxNode>();
					GetPort("Action").Connect(ManipHitboxId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ManipHitboxId_node_Action, assetPath);
					variableCount += ManipHitboxId_node_Action.SetData((SAManipHitbox)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.UpdateHurtsetId:
					SAUpdateHurtboxesNode UpdateHurtsetId_node_Action = graph.AddNode<SAUpdateHurtboxesNode>();
					GetPort("Action").Connect(UpdateHurtsetId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(UpdateHurtsetId_node_Action, assetPath);
					variableCount += UpdateHurtsetId_node_Action.SetData((SAUpdateHurtboxes)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SetupHurtsetId:
					SASetupHurtboxesNode SetupHurtsetId_node_Action = graph.AddNode<SASetupHurtboxesNode>();
					GetPort("Action").Connect(SetupHurtsetId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SetupHurtsetId_node_Action, assetPath);
					variableCount += SetupHurtsetId_node_Action.SetData((SASetupHurtboxes)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.ManipHurtboxId:
					SAManipHurtboxNode ManipHurtboxId_node_Action = graph.AddNode<SAManipHurtboxNode>();
					GetPort("Action").Connect(ManipHurtboxId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ManipHurtboxId_node_Action, assetPath);
					variableCount += ManipHurtboxId_node_Action.SetData((SAManipHurtbox)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.BoneStateId:
					SABoneStateNode BoneStateId_node_Action = graph.AddNode<SABoneStateNode>();
					GetPort("Action").Connect(BoneStateId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BoneStateId_node_Action, assetPath);
					variableCount += BoneStateId_node_Action.SetData((SABoneState)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.BoneScaleId:
					SABoneScaleNode BoneScaleId_node_Action = graph.AddNode<SABoneScaleNode>();
					GetPort("Action").Connect(BoneScaleId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BoneScaleId_node_Action, assetPath);
					variableCount += BoneScaleId_node_Action.SetData((SABoneScale)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SpawnAgentId:
					SASpawnAgentNode SpawnAgentId_node_Action = graph.AddNode<SASpawnAgentNode>();
					GetPort("Action").Connect(SpawnAgentId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpawnAgentId_node_Action, assetPath);
					variableCount += SpawnAgentId_node_Action.SetData((SASpawnAgent)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.LocalFXId:
					SALocalFXNode LocalFXId_node_Action = graph.AddNode<SALocalFXNode>();
					GetPort("Action").Connect(LocalFXId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LocalFXId_node_Action, assetPath);
					variableCount += LocalFXId_node_Action.SetData((SALocalFX)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SpawnFXId:
					SASpawnFXNode SpawnFXId_node_Action = graph.AddNode<SASpawnFXNode>();
					GetPort("Action").Connect(SpawnFXId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpawnFXId_node_Action, assetPath);
					variableCount += SpawnFXId_node_Action.SetData((SASpawnFX)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.HitboxFXId:
					SASetHitboxFXNode HitboxFXId_node_Action = graph.AddNode<SASetHitboxFXNode>();
					GetPort("Action").Connect(HitboxFXId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(HitboxFXId_node_Action, assetPath);
					variableCount += HitboxFXId_node_Action.SetData((SASetHitboxFX)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SFXId:
					SAPlaySFXNode SFXId_node_Action = graph.AddNode<SAPlaySFXNode>();
					GetPort("Action").Connect(SFXId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SFXId_node_Action, assetPath);
					variableCount += SFXId_node_Action.SetData((SAPlaySFX)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.HitboxSFXId:
					SASetHitboxSFXNode HitboxSFXId_node_Action = graph.AddNode<SASetHitboxSFXNode>();
					GetPort("Action").Connect(HitboxSFXId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(HitboxSFXId_node_Action, assetPath);
					variableCount += HitboxSFXId_node_Action.SetData((SASetHitboxSFX)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.ColorTintId:
					SAColorTintNode ColorTintId_node_Action = graph.AddNode<SAColorTintNode>();
					GetPort("Action").Connect(ColorTintId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ColorTintId_node_Action, assetPath);
					variableCount += ColorTintId_node_Action.SetData((SAColorTint)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.FindFloorId:
					SAFindFloorNode FindFloorId_node_Action = graph.AddNode<SAFindFloorNode>();
					GetPort("Action").Connect(FindFloorId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FindFloorId_node_Action, assetPath);
					variableCount += FindFloorId_node_Action.SetData((SAFindFloor)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.HurtGrabbedId:
					SAHurtGrabbedNode HurtGrabbedId_node_Action = graph.AddNode<SAHurtGrabbedNode>();
					GetPort("Action").Connect(HurtGrabbedId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(HurtGrabbedId_node_Action, assetPath);
					variableCount += HurtGrabbedId_node_Action.SetData((SAHurtGrabbed)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.LaunchGrabbedId:
					SALaunchGrabbedNode LaunchGrabbedId_node_Action = graph.AddNode<SALaunchGrabbedNode>();
					GetPort("Action").Connect(LaunchGrabbedId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LaunchGrabbedId_node_Action, assetPath);
					variableCount += LaunchGrabbedId_node_Action.SetData((SALaunchGrabbed)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.StateCancelGrabbedId:
					SAStateCancelGrabbedNode StateCancelGrabbedId_node_Action = graph.AddNode<SAStateCancelGrabbedNode>();
					GetPort("Action").Connect(StateCancelGrabbedId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(StateCancelGrabbedId_node_Action, assetPath);
					variableCount += StateCancelGrabbedId_node_Action.SetData((SAStateCancelGrabbed)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.EndGrabId:
					SAEndGrabNode EndGrabId_node_Action = graph.AddNode<SAEndGrabNode>();
					GetPort("Action").Connect(EndGrabId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EndGrabId_node_Action, assetPath);
					variableCount += EndGrabId_node_Action.SetData((SAEndGrab)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.GrabNotifyEscapeId:
					SAGrabNotifyEscapeNode GrabNotifyEscapeId_node_Action = graph.AddNode<SAGrabNotifyEscapeNode>();
					GetPort("Action").Connect(GrabNotifyEscapeId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(GrabNotifyEscapeId_node_Action, assetPath);
					variableCount += GrabNotifyEscapeId_node_Action.SetData((SAGrabNotifyEscape)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.IgnoreGrabbedId:
					SAIgnoreGrabbedNode IgnoreGrabbedId_node_Action = graph.AddNode<SAIgnoreGrabbedNode>();
					GetPort("Action").Connect(IgnoreGrabbedId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(IgnoreGrabbedId_node_Action, assetPath);
					variableCount += IgnoreGrabbedId_node_Action.SetData((SAIgnoreGrabbed)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.EventKOId:
					SAEventKONode EventKOId_node_Action = graph.AddNode<SAEventKONode>();
					GetPort("Action").Connect(EventKOId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EventKOId_node_Action, assetPath);
					variableCount += EventKOId_node_Action.SetData((SAEventKO)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.EventKOGrabbedId:
					SAEventKOGrabbedNode EventKOGrabbedId_node_Action = graph.AddNode<SAEventKOGrabbedNode>();
					GetPort("Action").Connect(EventKOGrabbedId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EventKOGrabbedId_node_Action, assetPath);
					variableCount += EventKOGrabbedId_node_Action.SetData((SAEventKOGrabbed)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.CameraShakeId:
					SACameraShakeNode CameraShakeId_node_Action = graph.AddNode<SACameraShakeNode>();
					GetPort("Action").Connect(CameraShakeId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CameraShakeId_node_Action, assetPath);
					variableCount += CameraShakeId_node_Action.SetData((SACameraShake)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.ResetOnHitId:
					SAResetOnHitsNode ResetOnHitId_node_Action = graph.AddNode<SAResetOnHitsNode>();
					GetPort("Action").Connect(ResetOnHitId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ResetOnHitId_node_Action, assetPath);
					variableCount += ResetOnHitId_node_Action.SetData((SAResetOnHits)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.OnHitId:
					SAOnHitNode OnHitId_node_Action = graph.AddNode<SAOnHitNode>();
					GetPort("Action").Connect(OnHitId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnHitId_node_Action, assetPath);
					variableCount += OnHitId_node_Action.SetData((SAOnHit)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.FastForwardId:
					SAFastForwardStateNode FastForwardId_node_Action = graph.AddNode<SAFastForwardStateNode>();
					GetPort("Action").Connect(FastForwardId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FastForwardId_node_Action, assetPath);
					variableCount += FastForwardId_node_Action.SetData((SAFastForwardState)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.TimingTweakId:
					SATimingTweakNode TimingTweakId_node_Action = graph.AddNode<SATimingTweakNode>();
					GetPort("Action").Connect(TimingTweakId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(TimingTweakId_node_Action, assetPath);
					variableCount += TimingTweakId_node_Action.SetData((SATimingTweak)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.MapAnimId:
					SAMapAnimationNode MapAnimId_node_Action = graph.AddNode<SAMapAnimationNode>();
					GetPort("Action").Connect(MapAnimId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(MapAnimId_node_Action, assetPath);
					variableCount += MapAnimId_node_Action.SetData((SAMapAnimation)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.AlterMoveDtId:
					SAAlterMoveDTNode AlterMoveDtId_node_Action = graph.AddNode<SAAlterMoveDTNode>();
					GetPort("Action").Connect(AlterMoveDtId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AlterMoveDtId_node_Action, assetPath);
					variableCount += AlterMoveDtId_node_Action.SetData((SAAlterMoveDT)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.AlterMoveVelId:
					SAAlterMoveVelNode AlterMoveVelId_node_Action = graph.AddNode<SAAlterMoveVelNode>();
					GetPort("Action").Connect(AlterMoveVelId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AlterMoveVelId_node_Action, assetPath);
					variableCount += AlterMoveVelId_node_Action.SetData((SAAlterMoveVel)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SetStagePartId:
					SASetStagePartNode SetStagePartId_node_Action = graph.AddNode<SASetStagePartNode>();
					GetPort("Action").Connect(SetStagePartId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SetStagePartId_node_Action, assetPath);
					variableCount += SetStagePartId_node_Action.SetData((SASetStagePart)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SetStagePartsDefaultId:
					SASetStagePartsDefaultNode SetStagePartsDefaultId_node_Action = graph.AddNode<SASetStagePartsDefaultNode>();
					GetPort("Action").Connect(SetStagePartsDefaultId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SetStagePartsDefaultId_node_Action, assetPath);
					variableCount += SetStagePartsDefaultId_node_Action.SetData((SASetStagePartsDefault)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.JumpId:
					SAJumpNode JumpId_node_Action = graph.AddNode<SAJumpNode>();
					GetPort("Action").Connect(JumpId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(JumpId_node_Action, assetPath);
					variableCount += JumpId_node_Action.SetData((SAJump)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.StopJumpId:
					SAStopJumpNode StopJumpId_node_Action = graph.AddNode<SAStopJumpNode>();
					GetPort("Action").Connect(StopJumpId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(StopJumpId_node_Action, assetPath);
					variableCount += StopJumpId_node_Action.SetData((SAStopJump)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.ManageAirJumpId:
					SAManageAirJumpNode ManageAirJumpId_node_Action = graph.AddNode<SAManageAirJumpNode>();
					GetPort("Action").Connect(ManageAirJumpId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ManageAirJumpId_node_Action, assetPath);
					variableCount += ManageAirJumpId_node_Action.SetData((SAManageAirJump)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.LeaveGroundId:
					SALeaveGroundNode LeaveGroundId_node_Action = graph.AddNode<SALeaveGroundNode>();
					GetPort("Action").Connect(LeaveGroundId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LeaveGroundId_node_Action, assetPath);
					variableCount += LeaveGroundId_node_Action.SetData((SALeaveGround)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.UnhogEdgeId:
					SAUnHogEdgeNode UnhogEdgeId_node_Action = graph.AddNode<SAUnHogEdgeNode>();
					GetPort("Action").Connect(UnhogEdgeId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(UnhogEdgeId_node_Action, assetPath);
					variableCount += UnhogEdgeId_node_Action.SetData((SAUnHogEdge)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SFXTimelineId:
					SAPlaySFXTimelineNode SFXTimelineId_node_Action = graph.AddNode<SAPlaySFXTimelineNode>();
					GetPort("Action").Connect(SFXTimelineId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SFXTimelineId_node_Action, assetPath);
					variableCount += SFXTimelineId_node_Action.SetData((SAPlaySFXTimeline)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.FindLastHorizontalInputId:
					SAFindLastHorizontalInputNode FindLastHorizontalInputId_node_Action = graph.AddNode<SAFindLastHorizontalInputNode>();
					GetPort("Action").Connect(FindLastHorizontalInputId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FindLastHorizontalInputId_node_Action, assetPath);
					variableCount += FindLastHorizontalInputId_node_Action.SetData((SAFindLastHorizontalInput)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SetCommandGrab:
					SASetCommandGrabNode SetCommandGrab_node_Action = graph.AddNode<SASetCommandGrabNode>();
					GetPort("Action").Connect(SetCommandGrab_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SetCommandGrab_node_Action, assetPath);
					variableCount += SetCommandGrab_node_Action.SetData((SASetCommandGrab)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.CameraPunchId:
					SACameraPunchNode CameraPunchId_node_Action = graph.AddNode<SACameraPunchNode>();
					GetPort("Action").Connect(CameraPunchId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CameraPunchId_node_Action, assetPath);
					variableCount += CameraPunchId_node_Action.SetData((SACameraPunch)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SpawnAgent2Id:
					SASpawnAgent2Node SpawnAgent2Id_node_Action = graph.AddNode<SASpawnAgent2Node>();
					GetPort("Action").Connect(SpawnAgent2Id_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpawnAgent2Id_node_Action, assetPath);
					variableCount += SpawnAgent2Id_node_Action.SetData((SASpawnAgent2)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.ManipDecorChainId:
					SAManipDecorChainNode ManipDecorChainId_node_Action = graph.AddNode<SAManipDecorChainNode>();
					GetPort("Action").Connect(ManipDecorChainId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ManipDecorChainId_node_Action, assetPath);
					variableCount += ManipDecorChainId_node_Action.SetData((SAManipDecorChain)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.UpdateHitboxesId:
					SAUpdateHitboxesNode UpdateHitboxesId_node_Action = graph.AddNode<SAUpdateHitboxesNode>();
					GetPort("Action").Connect(UpdateHitboxesId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(UpdateHitboxesId_node_Action, assetPath);
					variableCount += UpdateHitboxesId_node_Action.SetData((SAUpdateHitboxes)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SampleAnimId:
					SASampleAnimNode SampleAnimId_node_Action = graph.AddNode<SASampleAnimNode>();
					GetPort("Action").Connect(SampleAnimId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SampleAnimId_node_Action, assetPath);
					variableCount += SampleAnimId_node_Action.SetData((SASampleAnim)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.ForceExtraInputId:
					SAForceExtraInputCheckNode ForceExtraInputId_node_Action = graph.AddNode<SAForceExtraInputCheckNode>();
					GetPort("Action").Connect(ForceExtraInputId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ForceExtraInputId_node_Action, assetPath);
					variableCount += ForceExtraInputId_node_Action.SetData((SAForceExtraInputCheck)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.LaunchGrabbedCustomId:
					SALaunchGrabbedCustomNode LaunchGrabbedCustomId_node_Action = graph.AddNode<SALaunchGrabbedCustomNode>();
					GetPort("Action").Connect(LaunchGrabbedCustomId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LaunchGrabbedCustomId_node_Action, assetPath);
					variableCount += LaunchGrabbedCustomId_node_Action.SetData((SALaunchGrabbedCustom)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.MapAnimSimpleId:
					SAMapAnimationSimpleNode MapAnimSimpleId_node_Action = graph.AddNode<SAMapAnimationSimpleNode>();
					GetPort("Action").Connect(MapAnimSimpleId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(MapAnimSimpleId_node_Action, assetPath);
					variableCount += MapAnimSimpleId_node_Action.SetData((SAMapAnimationSimple)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.OnLeaveParentId:
					SAOnLeaveParentNode OnLeaveParentId_node_Action = graph.AddNode<SAOnLeaveParentNode>();
					GetPort("Action").Connect(OnLeaveParentId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnLeaveParentId_node_Action, assetPath);
					variableCount += OnLeaveParentId_node_Action.SetData((SAOnLeaveParent)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.PersistLocalFXId:
					SAPersistLocalFXNode PersistLocalFXId_node_Action = graph.AddNode<SAPersistLocalFXNode>();
					GetPort("Action").Connect(PersistLocalFXId_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(PersistLocalFXId_node_Action, assetPath);
					variableCount += PersistLocalFXId_node_Action.SetData((SAPersistLocalFX)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
			}
			
			return variableCount;
		}
		
		public new SATimedAction GetData()
		{
			SATimedAction objToReturn = new SATimedAction();
			objToReturn.TID = TypeId.TimerId;
			objToReturn.Version = Version;
			if (GetPort("Source").ConnectionCount > 0)
			{
				FloatSourceNode FloatSource_Node = (FloatSourceNode)GetPort("Source").GetConnection(0).node;
				switch (FloatSource_Node.TID)
				{
					case FloatSource.TypeId.AgentId:
						FSAgentNode AgentId_FloatSource_Node = (FSAgentNode)GetPort("Source").GetConnection(0).node;
						objToReturn.Source = AgentId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.BonesId:
						FSBonesNode BonesId_FloatSource_Node = (FSBonesNode)GetPort("Source").GetConnection(0).node;
						objToReturn.Source = BonesId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AttackId:
						FSAttackNode AttackId_FloatSource_Node = (FSAttackNode)GetPort("Source").GetConnection(0).node;
						objToReturn.Source = AttackId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FrameId:
						FSFrameNode FrameId_FloatSource_Node = (FSFrameNode)GetPort("Source").GetConnection(0).node;
						objToReturn.Source = FrameId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.InputId:
						FSInputNode InputId_FloatSource_Node = (FSInputNode)GetPort("Source").GetConnection(0).node;
						objToReturn.Source = InputId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FuncId:
						FSFuncNode FuncId_FloatSource_Node = (FSFuncNode)GetPort("Source").GetConnection(0).node;
						objToReturn.Source = FuncId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.MovementId:
						FSMovementNode MovementId_FloatSource_Node = (FSMovementNode)GetPort("Source").GetConnection(0).node;
						objToReturn.Source = MovementId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CombatId:
						FSCombatNode CombatId_FloatSource_Node = (FSCombatNode)GetPort("Source").GetConnection(0).node;
						objToReturn.Source = CombatId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.GrabsId:
						FSGrabsNode GrabsId_FloatSource_Node = (FSGrabsNode)GetPort("Source").GetConnection(0).node;
						objToReturn.Source = GrabsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.DataId:
						FSDataNode DataId_FloatSource_Node = (FSDataNode)GetPort("Source").GetConnection(0).node;
						objToReturn.Source = DataId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ScratchId:
						FSScratchNode ScratchId_FloatSource_Node = (FSScratchNode)GetPort("Source").GetConnection(0).node;
						objToReturn.Source = ScratchId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AnimId:
						FSAnimNode AnimId_FloatSource_Node = (FSAnimNode)GetPort("Source").GetConnection(0).node;
						objToReturn.Source = AnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SpeedId:
						FSSpeedNode SpeedId_FloatSource_Node = (FSSpeedNode)GetPort("Source").GetConnection(0).node;
						objToReturn.Source = SpeedId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.PhysicsId:
						FSPhysicsNode PhysicsId_FloatSource_Node = (FSPhysicsNode)GetPort("Source").GetConnection(0).node;
						objToReturn.Source = PhysicsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CollisionId:
						FSCollisionNode CollisionId_FloatSource_Node = (FSCollisionNode)GetPort("Source").GetConnection(0).node;
						objToReturn.Source = CollisionId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.TimerId:
						FSTimerNode TimerId_FloatSource_Node = (FSTimerNode)GetPort("Source").GetConnection(0).node;
						objToReturn.Source = TimerId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.LagId:
						FSLagNode LagId_FloatSource_Node = (FSLagNode)GetPort("Source").GetConnection(0).node;
						objToReturn.Source = LagId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.EffectsId:
						FSEffectsNode EffectsId_FloatSource_Node = (FSEffectsNode)GetPort("Source").GetConnection(0).node;
						objToReturn.Source = EffectsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ColorsId:
						FSColorsNode ColorsId_FloatSource_Node = (FSColorsNode)GetPort("Source").GetConnection(0).node;
						objToReturn.Source = ColorsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.OnHitId:
						FSOnHitNode OnHitId_FloatSource_Node = (FSOnHitNode)GetPort("Source").GetConnection(0).node;
						objToReturn.Source = OnHitId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RandomId:
						FSRandomNode RandomId_FloatSource_Node = (FSRandomNode)GetPort("Source").GetConnection(0).node;
						objToReturn.Source = RandomId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CameraId:
						FSCameraInfoNode CameraId_FloatSource_Node = (FSCameraInfoNode)GetPort("Source").GetConnection(0).node;
						objToReturn.Source = CameraId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SportsId:
						FSSportsNode SportsId_FloatSource_Node = (FSSportsNode)GetPort("Source").GetConnection(0).node;
						objToReturn.Source = SportsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.Vector2Mag:
						FSVector2MagNode Vector2Mag_FloatSource_Node = (FSVector2MagNode)GetPort("Source").GetConnection(0).node;
						objToReturn.Source = Vector2Mag_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CPUHelpId:
						FSCpuHelpNode CPUHelpId_FloatSource_Node = (FSCpuHelpNode)GetPort("Source").GetConnection(0).node;
						objToReturn.Source = CPUHelpId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ItemId:
						FSItemNode ItemId_FloatSource_Node = (FSItemNode)GetPort("Source").GetConnection(0).node;
						objToReturn.Source = ItemId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ModeId:
						FSModeNode ModeId_FloatSource_Node = (FSModeNode)GetPort("Source").GetConnection(0).node;
						objToReturn.Source = ModeId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.JumpsId:
						FSJumpsNode JumpsId_FloatSource_Node = (FSJumpsNode)GetPort("Source").GetConnection(0).node;
						objToReturn.Source = JumpsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RootAnimId:
						FSRootAnimNode RootAnimId_FloatSource_Node = (FSRootAnimNode)GetPort("Source").GetConnection(0).node;
						objToReturn.Source = RootAnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FloatId:
						FSValueNode FloatId_FloatSource_Node = (FSValueNode)GetPort("Source").GetConnection(0).node;
						objToReturn.Source = FloatId_FloatSource_Node.GetData();
					break;
				}
			}
			objToReturn.Repeat = Repeat;
			if (GetPort("Action").ConnectionCount > 0)
			{
				StateActionNode StateAction_Node = (StateActionNode)GetPort("Action").GetConnection(0).node;
				switch (StateAction_Node.TID)
				{
					case StateAction.TypeId.DebugId:
						SADebugMessageNode DebugId_StateAction_Node = (SADebugMessageNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = DebugId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.PlayAnimId:
						SAPlayAnimNode PlayAnimId_StateAction_Node = (SAPlayAnimNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = PlayAnimId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.RootAnimId:
						SAPlayRootAnimNode RootAnimId_StateAction_Node = (SAPlayRootAnimNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = RootAnimId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SnapAnimWeightsId:
						SASnapAnimWeightsNode SnapAnimWeightsId_StateAction_Node = (SASnapAnimWeightsNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SnapAnimWeightsId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.StandardInputId:
						SAStandardInputNode StandardInputId_StateAction_Node = (SAStandardInputNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = StandardInputId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.InputId:
						SAInputActionNode InputId_StateAction_Node = (SAInputActionNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = InputId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.DeactInputId:
						SADeactivateInputActionNode DeactInputId_StateAction_Node = (SADeactivateInputActionNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = DeactInputId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.InputEventFromFrameId:
						SAAddInputEventFromFrameNode InputEventFromFrameId_StateAction_Node = (SAAddInputEventFromFrameNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = InputEventFromFrameId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.CancelStateId:
						SACancelToStateNode CancelStateId_StateAction_Node = (SACancelToStateNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = CancelStateId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.CustomCallId:
						SACustomCallNode CustomCallId_StateAction_Node = (SACustomCallNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = CustomCallId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.TimerId:
						SATimedActionNode TimerId_StateAction_Node = (SATimedActionNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = TimerId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.OrderId:
						SAOrderedSensitiveNode OrderId_StateAction_Node = (SAOrderedSensitiveNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = OrderId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.ProxyId:
						SAProxyMoveNode ProxyId_StateAction_Node = (SAProxyMoveNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = ProxyId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.CheckId:
						SACheckThingNode CheckId_StateAction_Node = (SACheckThingNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = CheckId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.ActiveActionId:
						SAActiveActionNode ActiveActionId_StateAction_Node = (SAActiveActionNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = ActiveActionId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.DeactivateActionId:
						SADeactivateActionNode DeactivateActionId_StateAction_Node = (SADeactivateActionNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = DeactivateActionId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SetFloatId:
						SASetFloatTargetNode SetFloatId_StateAction_Node = (SASetFloatTargetNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SetFloatId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.OnBounceId:
						SAOnBounceNode OnBounceId_StateAction_Node = (SAOnBounceNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = OnBounceId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.OnLeaveEdgeId:
						SAOnLeaveEdgeNode OnLeaveEdgeId_StateAction_Node = (SAOnLeaveEdgeNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = OnLeaveEdgeId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.OnStoppedAtEdgeId:
						SAOnStoppedAtLedgeNode OnStoppedAtEdgeId_StateAction_Node = (SAOnStoppedAtLedgeNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = OnStoppedAtEdgeId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.OnLandId:
						SAOnLandNode OnLandId_StateAction_Node = (SAOnLandNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = OnLandId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.OnCancelId:
						SAOnCancelNode OnCancelId_StateAction_Node = (SAOnCancelNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = OnCancelId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.RefreshAtkId:
						SARefreshAttackNode RefreshAtkId_StateAction_Node = (SARefreshAttackNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = RefreshAtkId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.EndAtkId:
						SAEndAttackNode EndAtkId_StateAction_Node = (SAEndAttackNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = EndAtkId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SetHitboxCountId:
						SASetHitboxCountNode SetHitboxCountId_StateAction_Node = (SASetHitboxCountNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SetHitboxCountId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.ConfigHitboxId:
						SAConfigHitboxNode ConfigHitboxId_StateAction_Node = (SAConfigHitboxNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = ConfigHitboxId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SetAtkPropId:
						SASetAttackPropNode SetAtkPropId_StateAction_Node = (SASetAttackPropNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SetAtkPropId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.ManipHitboxId:
						SAManipHitboxNode ManipHitboxId_StateAction_Node = (SAManipHitboxNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = ManipHitboxId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.UpdateHurtsetId:
						SAUpdateHurtboxesNode UpdateHurtsetId_StateAction_Node = (SAUpdateHurtboxesNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = UpdateHurtsetId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SetupHurtsetId:
						SASetupHurtboxesNode SetupHurtsetId_StateAction_Node = (SASetupHurtboxesNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SetupHurtsetId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.ManipHurtboxId:
						SAManipHurtboxNode ManipHurtboxId_StateAction_Node = (SAManipHurtboxNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = ManipHurtboxId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.BoneStateId:
						SABoneStateNode BoneStateId_StateAction_Node = (SABoneStateNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = BoneStateId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.BoneScaleId:
						SABoneScaleNode BoneScaleId_StateAction_Node = (SABoneScaleNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = BoneScaleId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SpawnAgentId:
						SASpawnAgentNode SpawnAgentId_StateAction_Node = (SASpawnAgentNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SpawnAgentId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.LocalFXId:
						SALocalFXNode LocalFXId_StateAction_Node = (SALocalFXNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = LocalFXId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SpawnFXId:
						SASpawnFXNode SpawnFXId_StateAction_Node = (SASpawnFXNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SpawnFXId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.HitboxFXId:
						SASetHitboxFXNode HitboxFXId_StateAction_Node = (SASetHitboxFXNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = HitboxFXId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SFXId:
						SAPlaySFXNode SFXId_StateAction_Node = (SAPlaySFXNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SFXId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.HitboxSFXId:
						SASetHitboxSFXNode HitboxSFXId_StateAction_Node = (SASetHitboxSFXNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = HitboxSFXId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.ColorTintId:
						SAColorTintNode ColorTintId_StateAction_Node = (SAColorTintNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = ColorTintId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.FindFloorId:
						SAFindFloorNode FindFloorId_StateAction_Node = (SAFindFloorNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = FindFloorId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.HurtGrabbedId:
						SAHurtGrabbedNode HurtGrabbedId_StateAction_Node = (SAHurtGrabbedNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = HurtGrabbedId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.LaunchGrabbedId:
						SALaunchGrabbedNode LaunchGrabbedId_StateAction_Node = (SALaunchGrabbedNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = LaunchGrabbedId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.StateCancelGrabbedId:
						SAStateCancelGrabbedNode StateCancelGrabbedId_StateAction_Node = (SAStateCancelGrabbedNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = StateCancelGrabbedId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.EndGrabId:
						SAEndGrabNode EndGrabId_StateAction_Node = (SAEndGrabNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = EndGrabId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.GrabNotifyEscapeId:
						SAGrabNotifyEscapeNode GrabNotifyEscapeId_StateAction_Node = (SAGrabNotifyEscapeNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = GrabNotifyEscapeId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.IgnoreGrabbedId:
						SAIgnoreGrabbedNode IgnoreGrabbedId_StateAction_Node = (SAIgnoreGrabbedNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = IgnoreGrabbedId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.EventKOId:
						SAEventKONode EventKOId_StateAction_Node = (SAEventKONode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = EventKOId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.EventKOGrabbedId:
						SAEventKOGrabbedNode EventKOGrabbedId_StateAction_Node = (SAEventKOGrabbedNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = EventKOGrabbedId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.CameraShakeId:
						SACameraShakeNode CameraShakeId_StateAction_Node = (SACameraShakeNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = CameraShakeId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.ResetOnHitId:
						SAResetOnHitsNode ResetOnHitId_StateAction_Node = (SAResetOnHitsNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = ResetOnHitId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.OnHitId:
						SAOnHitNode OnHitId_StateAction_Node = (SAOnHitNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = OnHitId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.FastForwardId:
						SAFastForwardStateNode FastForwardId_StateAction_Node = (SAFastForwardStateNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = FastForwardId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.TimingTweakId:
						SATimingTweakNode TimingTweakId_StateAction_Node = (SATimingTweakNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = TimingTweakId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.MapAnimId:
						SAMapAnimationNode MapAnimId_StateAction_Node = (SAMapAnimationNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = MapAnimId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.AlterMoveDtId:
						SAAlterMoveDTNode AlterMoveDtId_StateAction_Node = (SAAlterMoveDTNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = AlterMoveDtId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.AlterMoveVelId:
						SAAlterMoveVelNode AlterMoveVelId_StateAction_Node = (SAAlterMoveVelNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = AlterMoveVelId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SetStagePartId:
						SASetStagePartNode SetStagePartId_StateAction_Node = (SASetStagePartNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SetStagePartId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SetStagePartsDefaultId:
						SASetStagePartsDefaultNode SetStagePartsDefaultId_StateAction_Node = (SASetStagePartsDefaultNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SetStagePartsDefaultId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.JumpId:
						SAJumpNode JumpId_StateAction_Node = (SAJumpNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = JumpId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.StopJumpId:
						SAStopJumpNode StopJumpId_StateAction_Node = (SAStopJumpNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = StopJumpId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.ManageAirJumpId:
						SAManageAirJumpNode ManageAirJumpId_StateAction_Node = (SAManageAirJumpNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = ManageAirJumpId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.LeaveGroundId:
						SALeaveGroundNode LeaveGroundId_StateAction_Node = (SALeaveGroundNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = LeaveGroundId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.UnhogEdgeId:
						SAUnHogEdgeNode UnhogEdgeId_StateAction_Node = (SAUnHogEdgeNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = UnhogEdgeId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SFXTimelineId:
						SAPlaySFXTimelineNode SFXTimelineId_StateAction_Node = (SAPlaySFXTimelineNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SFXTimelineId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.FindLastHorizontalInputId:
						SAFindLastHorizontalInputNode FindLastHorizontalInputId_StateAction_Node = (SAFindLastHorizontalInputNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = FindLastHorizontalInputId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SetCommandGrab:
						SASetCommandGrabNode SetCommandGrab_StateAction_Node = (SASetCommandGrabNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SetCommandGrab_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.CameraPunchId:
						SACameraPunchNode CameraPunchId_StateAction_Node = (SACameraPunchNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = CameraPunchId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SpawnAgent2Id:
						SASpawnAgent2Node SpawnAgent2Id_StateAction_Node = (SASpawnAgent2Node)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SpawnAgent2Id_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.ManipDecorChainId:
						SAManipDecorChainNode ManipDecorChainId_StateAction_Node = (SAManipDecorChainNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = ManipDecorChainId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.UpdateHitboxesId:
						SAUpdateHitboxesNode UpdateHitboxesId_StateAction_Node = (SAUpdateHitboxesNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = UpdateHitboxesId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SampleAnimId:
						SASampleAnimNode SampleAnimId_StateAction_Node = (SASampleAnimNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SampleAnimId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.ForceExtraInputId:
						SAForceExtraInputCheckNode ForceExtraInputId_StateAction_Node = (SAForceExtraInputCheckNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = ForceExtraInputId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.LaunchGrabbedCustomId:
						SALaunchGrabbedCustomNode LaunchGrabbedCustomId_StateAction_Node = (SALaunchGrabbedCustomNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = LaunchGrabbedCustomId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.MapAnimSimpleId:
						SAMapAnimationSimpleNode MapAnimSimpleId_StateAction_Node = (SAMapAnimationSimpleNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = MapAnimSimpleId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.OnLeaveParentId:
						SAOnLeaveParentNode OnLeaveParentId_StateAction_Node = (SAOnLeaveParentNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = OnLeaveParentId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.PersistLocalFXId:
						SAPersistLocalFXNode PersistLocalFXId_StateAction_Node = (SAPersistLocalFXNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = PersistLocalFXId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.BaseIdentifier:
						StateActionNode BaseIdentifier_StateAction_Node = (StateActionNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = BaseIdentifier_StateAction_Node.GetData();
					break;
				}
			}
			return objToReturn;
		}
	}
}

