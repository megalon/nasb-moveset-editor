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
	public class SAOrderedSensitiveNode : StateActionNode
	{
		[Output] public List<StateAction> Actions;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.OrderId;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SAOrderedSensitive data, MovesetGraph graph, string assetPath, Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SAOrderedSensitive));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			Actions = data.Actions;
			
			foreach (StateAction Actions_item in Actions)
			{
				switch (Actions_item.TID)
				{
					case StateAction.TypeId.DebugId:
						SADebugMessageNode DebugId_node_Actions = graph.AddNode<SADebugMessageNode>();
						GetPort("Actions").Connect(DebugId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(DebugId_node_Actions, assetPath);
						variableCount += DebugId_node_Actions.SetData((SADebugMessage)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.PlayAnimId:
						SAPlayAnimNode PlayAnimId_node_Actions = graph.AddNode<SAPlayAnimNode>();
						GetPort("Actions").Connect(PlayAnimId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(PlayAnimId_node_Actions, assetPath);
						variableCount += PlayAnimId_node_Actions.SetData((SAPlayAnim)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.RootAnimId:
						SAPlayRootAnimNode RootAnimId_node_Actions = graph.AddNode<SAPlayRootAnimNode>();
						GetPort("Actions").Connect(RootAnimId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(RootAnimId_node_Actions, assetPath);
						variableCount += RootAnimId_node_Actions.SetData((SAPlayRootAnim)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SnapAnimWeightsId:
						SASnapAnimWeightsNode SnapAnimWeightsId_node_Actions = graph.AddNode<SASnapAnimWeightsNode>();
						GetPort("Actions").Connect(SnapAnimWeightsId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SnapAnimWeightsId_node_Actions, assetPath);
						variableCount += SnapAnimWeightsId_node_Actions.SetData((SASnapAnimWeights)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.StandardInputId:
						SAStandardInputNode StandardInputId_node_Actions = graph.AddNode<SAStandardInputNode>();
						GetPort("Actions").Connect(StandardInputId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(StandardInputId_node_Actions, assetPath);
						variableCount += StandardInputId_node_Actions.SetData((SAStandardInput)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.InputId:
						SAInputActionNode InputId_node_Actions = graph.AddNode<SAInputActionNode>();
						GetPort("Actions").Connect(InputId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(InputId_node_Actions, assetPath);
						variableCount += InputId_node_Actions.SetData((SAInputAction)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.DeactInputId:
						SADeactivateInputActionNode DeactInputId_node_Actions = graph.AddNode<SADeactivateInputActionNode>();
						GetPort("Actions").Connect(DeactInputId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(DeactInputId_node_Actions, assetPath);
						variableCount += DeactInputId_node_Actions.SetData((SADeactivateInputAction)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.InputEventFromFrameId:
						SAAddInputEventFromFrameNode InputEventFromFrameId_node_Actions = graph.AddNode<SAAddInputEventFromFrameNode>();
						GetPort("Actions").Connect(InputEventFromFrameId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(InputEventFromFrameId_node_Actions, assetPath);
						variableCount += InputEventFromFrameId_node_Actions.SetData((SAAddInputEventFromFrame)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.CancelStateId:
						SACancelToStateNode CancelStateId_node_Actions = graph.AddNode<SACancelToStateNode>();
						GetPort("Actions").Connect(CancelStateId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(CancelStateId_node_Actions, assetPath);
						variableCount += CancelStateId_node_Actions.SetData((SACancelToState)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.CustomCallId:
						SACustomCallNode CustomCallId_node_Actions = graph.AddNode<SACustomCallNode>();
						GetPort("Actions").Connect(CustomCallId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(CustomCallId_node_Actions, assetPath);
						variableCount += CustomCallId_node_Actions.SetData((SACustomCall)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.TimerId:
						SATimedActionNode TimerId_node_Actions = graph.AddNode<SATimedActionNode>();
						GetPort("Actions").Connect(TimerId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(TimerId_node_Actions, assetPath);
						variableCount += TimerId_node_Actions.SetData((SATimedAction)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.OrderId:
						SAOrderedSensitiveNode OrderId_node_Actions = graph.AddNode<SAOrderedSensitiveNode>();
						GetPort("Actions").Connect(OrderId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(OrderId_node_Actions, assetPath);
						variableCount += OrderId_node_Actions.SetData((SAOrderedSensitive)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.ProxyId:
						SAProxyMoveNode ProxyId_node_Actions = graph.AddNode<SAProxyMoveNode>();
						GetPort("Actions").Connect(ProxyId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(ProxyId_node_Actions, assetPath);
						variableCount += ProxyId_node_Actions.SetData((SAProxyMove)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.CheckId:
						SACheckThingNode CheckId_node_Actions = graph.AddNode<SACheckThingNode>();
						GetPort("Actions").Connect(CheckId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(CheckId_node_Actions, assetPath);
						variableCount += CheckId_node_Actions.SetData((SACheckThing)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.ActiveActionId:
						SAActiveActionNode ActiveActionId_node_Actions = graph.AddNode<SAActiveActionNode>();
						GetPort("Actions").Connect(ActiveActionId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(ActiveActionId_node_Actions, assetPath);
						variableCount += ActiveActionId_node_Actions.SetData((SAActiveAction)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.DeactivateActionId:
						SADeactivateActionNode DeactivateActionId_node_Actions = graph.AddNode<SADeactivateActionNode>();
						GetPort("Actions").Connect(DeactivateActionId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(DeactivateActionId_node_Actions, assetPath);
						variableCount += DeactivateActionId_node_Actions.SetData((SADeactivateAction)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SetFloatId:
						SASetFloatTargetNode SetFloatId_node_Actions = graph.AddNode<SASetFloatTargetNode>();
						GetPort("Actions").Connect(SetFloatId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SetFloatId_node_Actions, assetPath);
						variableCount += SetFloatId_node_Actions.SetData((SASetFloatTarget)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.OnBounceId:
						SAOnBounceNode OnBounceId_node_Actions = graph.AddNode<SAOnBounceNode>();
						GetPort("Actions").Connect(OnBounceId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(OnBounceId_node_Actions, assetPath);
						variableCount += OnBounceId_node_Actions.SetData((SAOnBounce)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.OnLeaveEdgeId:
						SAOnLeaveEdgeNode OnLeaveEdgeId_node_Actions = graph.AddNode<SAOnLeaveEdgeNode>();
						GetPort("Actions").Connect(OnLeaveEdgeId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(OnLeaveEdgeId_node_Actions, assetPath);
						variableCount += OnLeaveEdgeId_node_Actions.SetData((SAOnLeaveEdge)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.OnStoppedAtEdgeId:
						SAOnStoppedAtLedgeNode OnStoppedAtEdgeId_node_Actions = graph.AddNode<SAOnStoppedAtLedgeNode>();
						GetPort("Actions").Connect(OnStoppedAtEdgeId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(OnStoppedAtEdgeId_node_Actions, assetPath);
						variableCount += OnStoppedAtEdgeId_node_Actions.SetData((SAOnStoppedAtLedge)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.OnLandId:
						SAOnLandNode OnLandId_node_Actions = graph.AddNode<SAOnLandNode>();
						GetPort("Actions").Connect(OnLandId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(OnLandId_node_Actions, assetPath);
						variableCount += OnLandId_node_Actions.SetData((SAOnLand)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.OnCancelId:
						SAOnCancelNode OnCancelId_node_Actions = graph.AddNode<SAOnCancelNode>();
						GetPort("Actions").Connect(OnCancelId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(OnCancelId_node_Actions, assetPath);
						variableCount += OnCancelId_node_Actions.SetData((SAOnCancel)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.RefreshAtkId:
						SARefreshAttackNode RefreshAtkId_node_Actions = graph.AddNode<SARefreshAttackNode>();
						GetPort("Actions").Connect(RefreshAtkId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(RefreshAtkId_node_Actions, assetPath);
						variableCount += RefreshAtkId_node_Actions.SetData((SARefreshAttack)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.EndAtkId:
						SAEndAttackNode EndAtkId_node_Actions = graph.AddNode<SAEndAttackNode>();
						GetPort("Actions").Connect(EndAtkId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(EndAtkId_node_Actions, assetPath);
						variableCount += EndAtkId_node_Actions.SetData((SAEndAttack)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SetHitboxCountId:
						SASetHitboxCountNode SetHitboxCountId_node_Actions = graph.AddNode<SASetHitboxCountNode>();
						GetPort("Actions").Connect(SetHitboxCountId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SetHitboxCountId_node_Actions, assetPath);
						variableCount += SetHitboxCountId_node_Actions.SetData((SASetHitboxCount)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.ConfigHitboxId:
						SAConfigHitboxNode ConfigHitboxId_node_Actions = graph.AddNode<SAConfigHitboxNode>();
						GetPort("Actions").Connect(ConfigHitboxId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(ConfigHitboxId_node_Actions, assetPath);
						variableCount += ConfigHitboxId_node_Actions.SetData((SAConfigHitbox)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SetAtkPropId:
						SASetAttackPropNode SetAtkPropId_node_Actions = graph.AddNode<SASetAttackPropNode>();
						GetPort("Actions").Connect(SetAtkPropId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SetAtkPropId_node_Actions, assetPath);
						variableCount += SetAtkPropId_node_Actions.SetData((SASetAttackProp)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.ManipHitboxId:
						SAManipHitboxNode ManipHitboxId_node_Actions = graph.AddNode<SAManipHitboxNode>();
						GetPort("Actions").Connect(ManipHitboxId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(ManipHitboxId_node_Actions, assetPath);
						variableCount += ManipHitboxId_node_Actions.SetData((SAManipHitbox)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.UpdateHurtsetId:
						SAUpdateHurtboxesNode UpdateHurtsetId_node_Actions = graph.AddNode<SAUpdateHurtboxesNode>();
						GetPort("Actions").Connect(UpdateHurtsetId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(UpdateHurtsetId_node_Actions, assetPath);
						variableCount += UpdateHurtsetId_node_Actions.SetData((SAUpdateHurtboxes)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SetupHurtsetId:
						SASetupHurtboxesNode SetupHurtsetId_node_Actions = graph.AddNode<SASetupHurtboxesNode>();
						GetPort("Actions").Connect(SetupHurtsetId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SetupHurtsetId_node_Actions, assetPath);
						variableCount += SetupHurtsetId_node_Actions.SetData((SASetupHurtboxes)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.ManipHurtboxId:
						SAManipHurtboxNode ManipHurtboxId_node_Actions = graph.AddNode<SAManipHurtboxNode>();
						GetPort("Actions").Connect(ManipHurtboxId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(ManipHurtboxId_node_Actions, assetPath);
						variableCount += ManipHurtboxId_node_Actions.SetData((SAManipHurtbox)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.BoneStateId:
						SABoneStateNode BoneStateId_node_Actions = graph.AddNode<SABoneStateNode>();
						GetPort("Actions").Connect(BoneStateId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(BoneStateId_node_Actions, assetPath);
						variableCount += BoneStateId_node_Actions.SetData((SABoneState)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.BoneScaleId:
						SABoneScaleNode BoneScaleId_node_Actions = graph.AddNode<SABoneScaleNode>();
						GetPort("Actions").Connect(BoneScaleId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(BoneScaleId_node_Actions, assetPath);
						variableCount += BoneScaleId_node_Actions.SetData((SABoneScale)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SpawnAgentId:
						SASpawnAgentNode SpawnAgentId_node_Actions = graph.AddNode<SASpawnAgentNode>();
						GetPort("Actions").Connect(SpawnAgentId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SpawnAgentId_node_Actions, assetPath);
						variableCount += SpawnAgentId_node_Actions.SetData((SASpawnAgent)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.LocalFXId:
						SALocalFXNode LocalFXId_node_Actions = graph.AddNode<SALocalFXNode>();
						GetPort("Actions").Connect(LocalFXId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(LocalFXId_node_Actions, assetPath);
						variableCount += LocalFXId_node_Actions.SetData((SALocalFX)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SpawnFXId:
						SASpawnFXNode SpawnFXId_node_Actions = graph.AddNode<SASpawnFXNode>();
						GetPort("Actions").Connect(SpawnFXId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SpawnFXId_node_Actions, assetPath);
						variableCount += SpawnFXId_node_Actions.SetData((SASpawnFX)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.HitboxFXId:
						SASetHitboxFXNode HitboxFXId_node_Actions = graph.AddNode<SASetHitboxFXNode>();
						GetPort("Actions").Connect(HitboxFXId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(HitboxFXId_node_Actions, assetPath);
						variableCount += HitboxFXId_node_Actions.SetData((SASetHitboxFX)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SFXId:
						SAPlaySFXNode SFXId_node_Actions = graph.AddNode<SAPlaySFXNode>();
						GetPort("Actions").Connect(SFXId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SFXId_node_Actions, assetPath);
						variableCount += SFXId_node_Actions.SetData((SAPlaySFX)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.HitboxSFXId:
						SASetHitboxSFXNode HitboxSFXId_node_Actions = graph.AddNode<SASetHitboxSFXNode>();
						GetPort("Actions").Connect(HitboxSFXId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(HitboxSFXId_node_Actions, assetPath);
						variableCount += HitboxSFXId_node_Actions.SetData((SASetHitboxSFX)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.ColorTintId:
						SAColorTintNode ColorTintId_node_Actions = graph.AddNode<SAColorTintNode>();
						GetPort("Actions").Connect(ColorTintId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(ColorTintId_node_Actions, assetPath);
						variableCount += ColorTintId_node_Actions.SetData((SAColorTint)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.FindFloorId:
						SAFindFloorNode FindFloorId_node_Actions = graph.AddNode<SAFindFloorNode>();
						GetPort("Actions").Connect(FindFloorId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(FindFloorId_node_Actions, assetPath);
						variableCount += FindFloorId_node_Actions.SetData((SAFindFloor)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.HurtGrabbedId:
						SAHurtGrabbedNode HurtGrabbedId_node_Actions = graph.AddNode<SAHurtGrabbedNode>();
						GetPort("Actions").Connect(HurtGrabbedId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(HurtGrabbedId_node_Actions, assetPath);
						variableCount += HurtGrabbedId_node_Actions.SetData((SAHurtGrabbed)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.LaunchGrabbedId:
						SALaunchGrabbedNode LaunchGrabbedId_node_Actions = graph.AddNode<SALaunchGrabbedNode>();
						GetPort("Actions").Connect(LaunchGrabbedId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(LaunchGrabbedId_node_Actions, assetPath);
						variableCount += LaunchGrabbedId_node_Actions.SetData((SALaunchGrabbed)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.StateCancelGrabbedId:
						SAStateCancelGrabbedNode StateCancelGrabbedId_node_Actions = graph.AddNode<SAStateCancelGrabbedNode>();
						GetPort("Actions").Connect(StateCancelGrabbedId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(StateCancelGrabbedId_node_Actions, assetPath);
						variableCount += StateCancelGrabbedId_node_Actions.SetData((SAStateCancelGrabbed)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.EndGrabId:
						SAEndGrabNode EndGrabId_node_Actions = graph.AddNode<SAEndGrabNode>();
						GetPort("Actions").Connect(EndGrabId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(EndGrabId_node_Actions, assetPath);
						variableCount += EndGrabId_node_Actions.SetData((SAEndGrab)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.GrabNotifyEscapeId:
						SAGrabNotifyEscapeNode GrabNotifyEscapeId_node_Actions = graph.AddNode<SAGrabNotifyEscapeNode>();
						GetPort("Actions").Connect(GrabNotifyEscapeId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(GrabNotifyEscapeId_node_Actions, assetPath);
						variableCount += GrabNotifyEscapeId_node_Actions.SetData((SAGrabNotifyEscape)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.IgnoreGrabbedId:
						SAIgnoreGrabbedNode IgnoreGrabbedId_node_Actions = graph.AddNode<SAIgnoreGrabbedNode>();
						GetPort("Actions").Connect(IgnoreGrabbedId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(IgnoreGrabbedId_node_Actions, assetPath);
						variableCount += IgnoreGrabbedId_node_Actions.SetData((SAIgnoreGrabbed)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.EventKOId:
						SAEventKONode EventKOId_node_Actions = graph.AddNode<SAEventKONode>();
						GetPort("Actions").Connect(EventKOId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(EventKOId_node_Actions, assetPath);
						variableCount += EventKOId_node_Actions.SetData((SAEventKO)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.EventKOGrabbedId:
						SAEventKOGrabbedNode EventKOGrabbedId_node_Actions = graph.AddNode<SAEventKOGrabbedNode>();
						GetPort("Actions").Connect(EventKOGrabbedId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(EventKOGrabbedId_node_Actions, assetPath);
						variableCount += EventKOGrabbedId_node_Actions.SetData((SAEventKOGrabbed)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.CameraShakeId:
						SACameraShakeNode CameraShakeId_node_Actions = graph.AddNode<SACameraShakeNode>();
						GetPort("Actions").Connect(CameraShakeId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(CameraShakeId_node_Actions, assetPath);
						variableCount += CameraShakeId_node_Actions.SetData((SACameraShake)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.ResetOnHitId:
						SAResetOnHitsNode ResetOnHitId_node_Actions = graph.AddNode<SAResetOnHitsNode>();
						GetPort("Actions").Connect(ResetOnHitId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(ResetOnHitId_node_Actions, assetPath);
						variableCount += ResetOnHitId_node_Actions.SetData((SAResetOnHits)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.OnHitId:
						SAOnHitNode OnHitId_node_Actions = graph.AddNode<SAOnHitNode>();
						GetPort("Actions").Connect(OnHitId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(OnHitId_node_Actions, assetPath);
						variableCount += OnHitId_node_Actions.SetData((SAOnHit)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.FastForwardId:
						SAFastForwardStateNode FastForwardId_node_Actions = graph.AddNode<SAFastForwardStateNode>();
						GetPort("Actions").Connect(FastForwardId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(FastForwardId_node_Actions, assetPath);
						variableCount += FastForwardId_node_Actions.SetData((SAFastForwardState)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.TimingTweakId:
						SATimingTweakNode TimingTweakId_node_Actions = graph.AddNode<SATimingTweakNode>();
						GetPort("Actions").Connect(TimingTweakId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(TimingTweakId_node_Actions, assetPath);
						variableCount += TimingTweakId_node_Actions.SetData((SATimingTweak)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.MapAnimId:
						SAMapAnimationNode MapAnimId_node_Actions = graph.AddNode<SAMapAnimationNode>();
						GetPort("Actions").Connect(MapAnimId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(MapAnimId_node_Actions, assetPath);
						variableCount += MapAnimId_node_Actions.SetData((SAMapAnimation)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.AlterMoveDtId:
						SAAlterMoveDTNode AlterMoveDtId_node_Actions = graph.AddNode<SAAlterMoveDTNode>();
						GetPort("Actions").Connect(AlterMoveDtId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(AlterMoveDtId_node_Actions, assetPath);
						variableCount += AlterMoveDtId_node_Actions.SetData((SAAlterMoveDT)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.AlterMoveVelId:
						SAAlterMoveVelNode AlterMoveVelId_node_Actions = graph.AddNode<SAAlterMoveVelNode>();
						GetPort("Actions").Connect(AlterMoveVelId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(AlterMoveVelId_node_Actions, assetPath);
						variableCount += AlterMoveVelId_node_Actions.SetData((SAAlterMoveVel)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SetStagePartId:
						SASetStagePartNode SetStagePartId_node_Actions = graph.AddNode<SASetStagePartNode>();
						GetPort("Actions").Connect(SetStagePartId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SetStagePartId_node_Actions, assetPath);
						variableCount += SetStagePartId_node_Actions.SetData((SASetStagePart)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SetStagePartsDefaultId:
						SASetStagePartsDefaultNode SetStagePartsDefaultId_node_Actions = graph.AddNode<SASetStagePartsDefaultNode>();
						GetPort("Actions").Connect(SetStagePartsDefaultId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SetStagePartsDefaultId_node_Actions, assetPath);
						variableCount += SetStagePartsDefaultId_node_Actions.SetData((SASetStagePartsDefault)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.JumpId:
						SAJumpNode JumpId_node_Actions = graph.AddNode<SAJumpNode>();
						GetPort("Actions").Connect(JumpId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(JumpId_node_Actions, assetPath);
						variableCount += JumpId_node_Actions.SetData((SAJump)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.StopJumpId:
						SAStopJumpNode StopJumpId_node_Actions = graph.AddNode<SAStopJumpNode>();
						GetPort("Actions").Connect(StopJumpId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(StopJumpId_node_Actions, assetPath);
						variableCount += StopJumpId_node_Actions.SetData((SAStopJump)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.ManageAirJumpId:
						SAManageAirJumpNode ManageAirJumpId_node_Actions = graph.AddNode<SAManageAirJumpNode>();
						GetPort("Actions").Connect(ManageAirJumpId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(ManageAirJumpId_node_Actions, assetPath);
						variableCount += ManageAirJumpId_node_Actions.SetData((SAManageAirJump)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.LeaveGroundId:
						SALeaveGroundNode LeaveGroundId_node_Actions = graph.AddNode<SALeaveGroundNode>();
						GetPort("Actions").Connect(LeaveGroundId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(LeaveGroundId_node_Actions, assetPath);
						variableCount += LeaveGroundId_node_Actions.SetData((SALeaveGround)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.UnhogEdgeId:
						SAUnHogEdgeNode UnhogEdgeId_node_Actions = graph.AddNode<SAUnHogEdgeNode>();
						GetPort("Actions").Connect(UnhogEdgeId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(UnhogEdgeId_node_Actions, assetPath);
						variableCount += UnhogEdgeId_node_Actions.SetData((SAUnHogEdge)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SFXTimelineId:
						SAPlaySFXTimelineNode SFXTimelineId_node_Actions = graph.AddNode<SAPlaySFXTimelineNode>();
						GetPort("Actions").Connect(SFXTimelineId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SFXTimelineId_node_Actions, assetPath);
						variableCount += SFXTimelineId_node_Actions.SetData((SAPlaySFXTimeline)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.FindLastHorizontalInputId:
						SAFindLastHorizontalInputNode FindLastHorizontalInputId_node_Actions = graph.AddNode<SAFindLastHorizontalInputNode>();
						GetPort("Actions").Connect(FindLastHorizontalInputId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(FindLastHorizontalInputId_node_Actions, assetPath);
						variableCount += FindLastHorizontalInputId_node_Actions.SetData((SAFindLastHorizontalInput)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SetCommandGrab:
						SASetCommandGrabNode SetCommandGrab_node_Actions = graph.AddNode<SASetCommandGrabNode>();
						GetPort("Actions").Connect(SetCommandGrab_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SetCommandGrab_node_Actions, assetPath);
						variableCount += SetCommandGrab_node_Actions.SetData((SASetCommandGrab)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.CameraPunchId:
						SACameraPunchNode CameraPunchId_node_Actions = graph.AddNode<SACameraPunchNode>();
						GetPort("Actions").Connect(CameraPunchId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(CameraPunchId_node_Actions, assetPath);
						variableCount += CameraPunchId_node_Actions.SetData((SACameraPunch)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SpawnAgent2Id:
						SASpawnAgent2Node SpawnAgent2Id_node_Actions = graph.AddNode<SASpawnAgent2Node>();
						GetPort("Actions").Connect(SpawnAgent2Id_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SpawnAgent2Id_node_Actions, assetPath);
						variableCount += SpawnAgent2Id_node_Actions.SetData((SASpawnAgent2)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.ManipDecorChainId:
						SAManipDecorChainNode ManipDecorChainId_node_Actions = graph.AddNode<SAManipDecorChainNode>();
						GetPort("Actions").Connect(ManipDecorChainId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(ManipDecorChainId_node_Actions, assetPath);
						variableCount += ManipDecorChainId_node_Actions.SetData((SAManipDecorChain)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.UpdateHitboxesId:
						SAUpdateHitboxesNode UpdateHitboxesId_node_Actions = graph.AddNode<SAUpdateHitboxesNode>();
						GetPort("Actions").Connect(UpdateHitboxesId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(UpdateHitboxesId_node_Actions, assetPath);
						variableCount += UpdateHitboxesId_node_Actions.SetData((SAUpdateHitboxes)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SampleAnimId:
						SASampleAnimNode SampleAnimId_node_Actions = graph.AddNode<SASampleAnimNode>();
						GetPort("Actions").Connect(SampleAnimId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SampleAnimId_node_Actions, assetPath);
						variableCount += SampleAnimId_node_Actions.SetData((SASampleAnim)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.ForceExtraInputId:
						SAForceExtraInputCheckNode ForceExtraInputId_node_Actions = graph.AddNode<SAForceExtraInputCheckNode>();
						GetPort("Actions").Connect(ForceExtraInputId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(ForceExtraInputId_node_Actions, assetPath);
						variableCount += ForceExtraInputId_node_Actions.SetData((SAForceExtraInputCheck)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.LaunchGrabbedCustomId:
						SALaunchGrabbedCustomNode LaunchGrabbedCustomId_node_Actions = graph.AddNode<SALaunchGrabbedCustomNode>();
						GetPort("Actions").Connect(LaunchGrabbedCustomId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(LaunchGrabbedCustomId_node_Actions, assetPath);
						variableCount += LaunchGrabbedCustomId_node_Actions.SetData((SALaunchGrabbedCustom)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.BaseIdentifier:
						StateActionNode BaseIdentifier_node_Actions = graph.AddNode<StateActionNode>();
						GetPort("Actions").Connect(BaseIdentifier_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(BaseIdentifier_node_Actions, assetPath);
						variableCount += BaseIdentifier_node_Actions.SetData((StateAction)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
				}
				++variableCount;
			}
			
			return variableCount;
		}
		
		public new SAOrderedSensitive GetData()
		{
			SAOrderedSensitive objToReturn = new SAOrderedSensitive();
			objToReturn.TID = TypeId.OrderId;
			objToReturn.Version = Version;
			foreach(NodePort port in GetPort("Actions").GetConnections())
			{
				StateActionNode StateAction_Node = (StateActionNode)port.node;
				switch (StateAction_Node.TID)
				{
					case StateAction.TypeId.DebugId:
						SADebugMessageNode DebugId_StateAction_Node = (SADebugMessageNode)port.node;
						objToReturn.Actions.Add(DebugId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.PlayAnimId:
						SAPlayAnimNode PlayAnimId_StateAction_Node = (SAPlayAnimNode)port.node;
						objToReturn.Actions.Add(PlayAnimId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.RootAnimId:
						SAPlayRootAnimNode RootAnimId_StateAction_Node = (SAPlayRootAnimNode)port.node;
						objToReturn.Actions.Add(RootAnimId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.SnapAnimWeightsId:
						SASnapAnimWeightsNode SnapAnimWeightsId_StateAction_Node = (SASnapAnimWeightsNode)port.node;
						objToReturn.Actions.Add(SnapAnimWeightsId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.StandardInputId:
						SAStandardInputNode StandardInputId_StateAction_Node = (SAStandardInputNode)port.node;
						objToReturn.Actions.Add(StandardInputId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.InputId:
						SAInputActionNode InputId_StateAction_Node = (SAInputActionNode)port.node;
						objToReturn.Actions.Add(InputId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.DeactInputId:
						SADeactivateInputActionNode DeactInputId_StateAction_Node = (SADeactivateInputActionNode)port.node;
						objToReturn.Actions.Add(DeactInputId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.InputEventFromFrameId:
						SAAddInputEventFromFrameNode InputEventFromFrameId_StateAction_Node = (SAAddInputEventFromFrameNode)port.node;
						objToReturn.Actions.Add(InputEventFromFrameId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.CancelStateId:
						SACancelToStateNode CancelStateId_StateAction_Node = (SACancelToStateNode)port.node;
						objToReturn.Actions.Add(CancelStateId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.CustomCallId:
						SACustomCallNode CustomCallId_StateAction_Node = (SACustomCallNode)port.node;
						objToReturn.Actions.Add(CustomCallId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.TimerId:
						SATimedActionNode TimerId_StateAction_Node = (SATimedActionNode)port.node;
						objToReturn.Actions.Add(TimerId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.OrderId:
						SAOrderedSensitiveNode OrderId_StateAction_Node = (SAOrderedSensitiveNode)port.node;
						objToReturn.Actions.Add(OrderId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.ProxyId:
						SAProxyMoveNode ProxyId_StateAction_Node = (SAProxyMoveNode)port.node;
						objToReturn.Actions.Add(ProxyId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.CheckId:
						SACheckThingNode CheckId_StateAction_Node = (SACheckThingNode)port.node;
						objToReturn.Actions.Add(CheckId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.ActiveActionId:
						SAActiveActionNode ActiveActionId_StateAction_Node = (SAActiveActionNode)port.node;
						objToReturn.Actions.Add(ActiveActionId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.DeactivateActionId:
						SADeactivateActionNode DeactivateActionId_StateAction_Node = (SADeactivateActionNode)port.node;
						objToReturn.Actions.Add(DeactivateActionId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.SetFloatId:
						SASetFloatTargetNode SetFloatId_StateAction_Node = (SASetFloatTargetNode)port.node;
						objToReturn.Actions.Add(SetFloatId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.OnBounceId:
						SAOnBounceNode OnBounceId_StateAction_Node = (SAOnBounceNode)port.node;
						objToReturn.Actions.Add(OnBounceId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.OnLeaveEdgeId:
						SAOnLeaveEdgeNode OnLeaveEdgeId_StateAction_Node = (SAOnLeaveEdgeNode)port.node;
						objToReturn.Actions.Add(OnLeaveEdgeId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.OnStoppedAtEdgeId:
						SAOnStoppedAtLedgeNode OnStoppedAtEdgeId_StateAction_Node = (SAOnStoppedAtLedgeNode)port.node;
						objToReturn.Actions.Add(OnStoppedAtEdgeId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.OnLandId:
						SAOnLandNode OnLandId_StateAction_Node = (SAOnLandNode)port.node;
						objToReturn.Actions.Add(OnLandId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.OnCancelId:
						SAOnCancelNode OnCancelId_StateAction_Node = (SAOnCancelNode)port.node;
						objToReturn.Actions.Add(OnCancelId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.RefreshAtkId:
						SARefreshAttackNode RefreshAtkId_StateAction_Node = (SARefreshAttackNode)port.node;
						objToReturn.Actions.Add(RefreshAtkId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.EndAtkId:
						SAEndAttackNode EndAtkId_StateAction_Node = (SAEndAttackNode)port.node;
						objToReturn.Actions.Add(EndAtkId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.SetHitboxCountId:
						SASetHitboxCountNode SetHitboxCountId_StateAction_Node = (SASetHitboxCountNode)port.node;
						objToReturn.Actions.Add(SetHitboxCountId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.ConfigHitboxId:
						SAConfigHitboxNode ConfigHitboxId_StateAction_Node = (SAConfigHitboxNode)port.node;
						objToReturn.Actions.Add(ConfigHitboxId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.SetAtkPropId:
						SASetAttackPropNode SetAtkPropId_StateAction_Node = (SASetAttackPropNode)port.node;
						objToReturn.Actions.Add(SetAtkPropId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.ManipHitboxId:
						SAManipHitboxNode ManipHitboxId_StateAction_Node = (SAManipHitboxNode)port.node;
						objToReturn.Actions.Add(ManipHitboxId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.UpdateHurtsetId:
						SAUpdateHurtboxesNode UpdateHurtsetId_StateAction_Node = (SAUpdateHurtboxesNode)port.node;
						objToReturn.Actions.Add(UpdateHurtsetId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.SetupHurtsetId:
						SASetupHurtboxesNode SetupHurtsetId_StateAction_Node = (SASetupHurtboxesNode)port.node;
						objToReturn.Actions.Add(SetupHurtsetId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.ManipHurtboxId:
						SAManipHurtboxNode ManipHurtboxId_StateAction_Node = (SAManipHurtboxNode)port.node;
						objToReturn.Actions.Add(ManipHurtboxId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.BoneStateId:
						SABoneStateNode BoneStateId_StateAction_Node = (SABoneStateNode)port.node;
						objToReturn.Actions.Add(BoneStateId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.BoneScaleId:
						SABoneScaleNode BoneScaleId_StateAction_Node = (SABoneScaleNode)port.node;
						objToReturn.Actions.Add(BoneScaleId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.SpawnAgentId:
						SASpawnAgentNode SpawnAgentId_StateAction_Node = (SASpawnAgentNode)port.node;
						objToReturn.Actions.Add(SpawnAgentId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.LocalFXId:
						SALocalFXNode LocalFXId_StateAction_Node = (SALocalFXNode)port.node;
						objToReturn.Actions.Add(LocalFXId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.SpawnFXId:
						SASpawnFXNode SpawnFXId_StateAction_Node = (SASpawnFXNode)port.node;
						objToReturn.Actions.Add(SpawnFXId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.HitboxFXId:
						SASetHitboxFXNode HitboxFXId_StateAction_Node = (SASetHitboxFXNode)port.node;
						objToReturn.Actions.Add(HitboxFXId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.SFXId:
						SAPlaySFXNode SFXId_StateAction_Node = (SAPlaySFXNode)port.node;
						objToReturn.Actions.Add(SFXId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.HitboxSFXId:
						SASetHitboxSFXNode HitboxSFXId_StateAction_Node = (SASetHitboxSFXNode)port.node;
						objToReturn.Actions.Add(HitboxSFXId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.ColorTintId:
						SAColorTintNode ColorTintId_StateAction_Node = (SAColorTintNode)port.node;
						objToReturn.Actions.Add(ColorTintId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.FindFloorId:
						SAFindFloorNode FindFloorId_StateAction_Node = (SAFindFloorNode)port.node;
						objToReturn.Actions.Add(FindFloorId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.HurtGrabbedId:
						SAHurtGrabbedNode HurtGrabbedId_StateAction_Node = (SAHurtGrabbedNode)port.node;
						objToReturn.Actions.Add(HurtGrabbedId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.LaunchGrabbedId:
						SALaunchGrabbedNode LaunchGrabbedId_StateAction_Node = (SALaunchGrabbedNode)port.node;
						objToReturn.Actions.Add(LaunchGrabbedId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.StateCancelGrabbedId:
						SAStateCancelGrabbedNode StateCancelGrabbedId_StateAction_Node = (SAStateCancelGrabbedNode)port.node;
						objToReturn.Actions.Add(StateCancelGrabbedId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.EndGrabId:
						SAEndGrabNode EndGrabId_StateAction_Node = (SAEndGrabNode)port.node;
						objToReturn.Actions.Add(EndGrabId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.GrabNotifyEscapeId:
						SAGrabNotifyEscapeNode GrabNotifyEscapeId_StateAction_Node = (SAGrabNotifyEscapeNode)port.node;
						objToReturn.Actions.Add(GrabNotifyEscapeId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.IgnoreGrabbedId:
						SAIgnoreGrabbedNode IgnoreGrabbedId_StateAction_Node = (SAIgnoreGrabbedNode)port.node;
						objToReturn.Actions.Add(IgnoreGrabbedId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.EventKOId:
						SAEventKONode EventKOId_StateAction_Node = (SAEventKONode)port.node;
						objToReturn.Actions.Add(EventKOId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.EventKOGrabbedId:
						SAEventKOGrabbedNode EventKOGrabbedId_StateAction_Node = (SAEventKOGrabbedNode)port.node;
						objToReturn.Actions.Add(EventKOGrabbedId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.CameraShakeId:
						SACameraShakeNode CameraShakeId_StateAction_Node = (SACameraShakeNode)port.node;
						objToReturn.Actions.Add(CameraShakeId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.ResetOnHitId:
						SAResetOnHitsNode ResetOnHitId_StateAction_Node = (SAResetOnHitsNode)port.node;
						objToReturn.Actions.Add(ResetOnHitId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.OnHitId:
						SAOnHitNode OnHitId_StateAction_Node = (SAOnHitNode)port.node;
						objToReturn.Actions.Add(OnHitId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.FastForwardId:
						SAFastForwardStateNode FastForwardId_StateAction_Node = (SAFastForwardStateNode)port.node;
						objToReturn.Actions.Add(FastForwardId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.TimingTweakId:
						SATimingTweakNode TimingTweakId_StateAction_Node = (SATimingTweakNode)port.node;
						objToReturn.Actions.Add(TimingTweakId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.MapAnimId:
						SAMapAnimationNode MapAnimId_StateAction_Node = (SAMapAnimationNode)port.node;
						objToReturn.Actions.Add(MapAnimId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.AlterMoveDtId:
						SAAlterMoveDTNode AlterMoveDtId_StateAction_Node = (SAAlterMoveDTNode)port.node;
						objToReturn.Actions.Add(AlterMoveDtId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.AlterMoveVelId:
						SAAlterMoveVelNode AlterMoveVelId_StateAction_Node = (SAAlterMoveVelNode)port.node;
						objToReturn.Actions.Add(AlterMoveVelId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.SetStagePartId:
						SASetStagePartNode SetStagePartId_StateAction_Node = (SASetStagePartNode)port.node;
						objToReturn.Actions.Add(SetStagePartId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.SetStagePartsDefaultId:
						SASetStagePartsDefaultNode SetStagePartsDefaultId_StateAction_Node = (SASetStagePartsDefaultNode)port.node;
						objToReturn.Actions.Add(SetStagePartsDefaultId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.JumpId:
						SAJumpNode JumpId_StateAction_Node = (SAJumpNode)port.node;
						objToReturn.Actions.Add(JumpId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.StopJumpId:
						SAStopJumpNode StopJumpId_StateAction_Node = (SAStopJumpNode)port.node;
						objToReturn.Actions.Add(StopJumpId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.ManageAirJumpId:
						SAManageAirJumpNode ManageAirJumpId_StateAction_Node = (SAManageAirJumpNode)port.node;
						objToReturn.Actions.Add(ManageAirJumpId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.LeaveGroundId:
						SALeaveGroundNode LeaveGroundId_StateAction_Node = (SALeaveGroundNode)port.node;
						objToReturn.Actions.Add(LeaveGroundId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.UnhogEdgeId:
						SAUnHogEdgeNode UnhogEdgeId_StateAction_Node = (SAUnHogEdgeNode)port.node;
						objToReturn.Actions.Add(UnhogEdgeId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.SFXTimelineId:
						SAPlaySFXTimelineNode SFXTimelineId_StateAction_Node = (SAPlaySFXTimelineNode)port.node;
						objToReturn.Actions.Add(SFXTimelineId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.FindLastHorizontalInputId:
						SAFindLastHorizontalInputNode FindLastHorizontalInputId_StateAction_Node = (SAFindLastHorizontalInputNode)port.node;
						objToReturn.Actions.Add(FindLastHorizontalInputId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.SetCommandGrab:
						SASetCommandGrabNode SetCommandGrab_StateAction_Node = (SASetCommandGrabNode)port.node;
						objToReturn.Actions.Add(SetCommandGrab_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.CameraPunchId:
						SACameraPunchNode CameraPunchId_StateAction_Node = (SACameraPunchNode)port.node;
						objToReturn.Actions.Add(CameraPunchId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.SpawnAgent2Id:
						SASpawnAgent2Node SpawnAgent2Id_StateAction_Node = (SASpawnAgent2Node)port.node;
						objToReturn.Actions.Add(SpawnAgent2Id_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.ManipDecorChainId:
						SAManipDecorChainNode ManipDecorChainId_StateAction_Node = (SAManipDecorChainNode)port.node;
						objToReturn.Actions.Add(ManipDecorChainId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.UpdateHitboxesId:
						SAUpdateHitboxesNode UpdateHitboxesId_StateAction_Node = (SAUpdateHitboxesNode)port.node;
						objToReturn.Actions.Add(UpdateHitboxesId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.SampleAnimId:
						SASampleAnimNode SampleAnimId_StateAction_Node = (SASampleAnimNode)port.node;
						objToReturn.Actions.Add(SampleAnimId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.ForceExtraInputId:
						SAForceExtraInputCheckNode ForceExtraInputId_StateAction_Node = (SAForceExtraInputCheckNode)port.node;
						objToReturn.Actions.Add(ForceExtraInputId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.LaunchGrabbedCustomId:
						SALaunchGrabbedCustomNode LaunchGrabbedCustomId_StateAction_Node = (SALaunchGrabbedCustomNode)port.node;
						objToReturn.Actions.Add(LaunchGrabbedCustomId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.BaseIdentifier:
						StateActionNode BaseIdentifier_StateAction_Node = (StateActionNode)port.node;
						objToReturn.Actions.Add(BaseIdentifier_StateAction_Node.GetData());
					break;
				}
			}
			return objToReturn;
		}
	}
}

