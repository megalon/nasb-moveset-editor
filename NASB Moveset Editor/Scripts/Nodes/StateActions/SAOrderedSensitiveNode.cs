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
using System.Linq;
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
		public int listSize = 0;
		
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
			
			listSize = data.Actions.Count;
			
			foreach (StateAction Actions_item in data.Actions)
			{
				// Create dynamic ports based on number of actions
				string portName = "" + DynamicPorts.Count();
				AddDynamicOutput(typeof(StateAction), ConnectionType.Override, TypeConstraint.None, portName);
				
				switch (Actions_item.TID)
				{
					case StateAction.TypeId.DebugId:
						SADebugMessageNode DebugId_node_Actions = graph.AddNode<SADebugMessageNode>();
						GetPort(portName).Connect(DebugId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(DebugId_node_Actions, assetPath);
						variableCount += DebugId_node_Actions.SetData((SADebugMessage)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.PlayAnimId:
						SAPlayAnimNode PlayAnimId_node_Actions = graph.AddNode<SAPlayAnimNode>();
						GetPort(portName).Connect(PlayAnimId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(PlayAnimId_node_Actions, assetPath);
						variableCount += PlayAnimId_node_Actions.SetData((SAPlayAnim)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.RootAnimId:
						SAPlayRootAnimNode RootAnimId_node_Actions = graph.AddNode<SAPlayRootAnimNode>();
						GetPort(portName).Connect(RootAnimId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(RootAnimId_node_Actions, assetPath);
						variableCount += RootAnimId_node_Actions.SetData((SAPlayRootAnim)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SnapAnimWeightsId:
						SASnapAnimWeightsNode SnapAnimWeightsId_node_Actions = graph.AddNode<SASnapAnimWeightsNode>();
						GetPort(portName).Connect(SnapAnimWeightsId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SnapAnimWeightsId_node_Actions, assetPath);
						variableCount += SnapAnimWeightsId_node_Actions.SetData((SASnapAnimWeights)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.StandardInputId:
						SAStandardInputNode StandardInputId_node_Actions = graph.AddNode<SAStandardInputNode>();
						GetPort(portName).Connect(StandardInputId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(StandardInputId_node_Actions, assetPath);
						variableCount += StandardInputId_node_Actions.SetData((SAStandardInput)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.InputId:
						SAInputActionNode InputId_node_Actions = graph.AddNode<SAInputActionNode>();
						GetPort(portName).Connect(InputId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(InputId_node_Actions, assetPath);
						variableCount += InputId_node_Actions.SetData((SAInputAction)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.DeactInputId:
						SADeactivateInputActionNode DeactInputId_node_Actions = graph.AddNode<SADeactivateInputActionNode>();
						GetPort(portName).Connect(DeactInputId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(DeactInputId_node_Actions, assetPath);
						variableCount += DeactInputId_node_Actions.SetData((SADeactivateInputAction)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.InputEventFromFrameId:
						SAAddInputEventFromFrameNode InputEventFromFrameId_node_Actions = graph.AddNode<SAAddInputEventFromFrameNode>();
						GetPort(portName).Connect(InputEventFromFrameId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(InputEventFromFrameId_node_Actions, assetPath);
						variableCount += InputEventFromFrameId_node_Actions.SetData((SAAddInputEventFromFrame)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.CancelStateId:
						SACancelToStateNode CancelStateId_node_Actions = graph.AddNode<SACancelToStateNode>();
						GetPort(portName).Connect(CancelStateId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(CancelStateId_node_Actions, assetPath);
						variableCount += CancelStateId_node_Actions.SetData((SACancelToState)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.CustomCallId:
						SACustomCallNode CustomCallId_node_Actions = graph.AddNode<SACustomCallNode>();
						GetPort(portName).Connect(CustomCallId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(CustomCallId_node_Actions, assetPath);
						variableCount += CustomCallId_node_Actions.SetData((SACustomCall)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.TimerId:
						SATimedActionNode TimerId_node_Actions = graph.AddNode<SATimedActionNode>();
						GetPort(portName).Connect(TimerId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(TimerId_node_Actions, assetPath);
						variableCount += TimerId_node_Actions.SetData((SATimedAction)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.OrderId:
						SAOrderedSensitiveNode OrderId_node_Actions = graph.AddNode<SAOrderedSensitiveNode>();
						GetPort(portName).Connect(OrderId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(OrderId_node_Actions, assetPath);
						variableCount += OrderId_node_Actions.SetData((SAOrderedSensitive)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.ProxyId:
						SAProxyMoveNode ProxyId_node_Actions = graph.AddNode<SAProxyMoveNode>();
						GetPort(portName).Connect(ProxyId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(ProxyId_node_Actions, assetPath);
						variableCount += ProxyId_node_Actions.SetData((SAProxyMove)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.CheckId:
						SACheckThingNode CheckId_node_Actions = graph.AddNode<SACheckThingNode>();
						GetPort(portName).Connect(CheckId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(CheckId_node_Actions, assetPath);
						variableCount += CheckId_node_Actions.SetData((SACheckThing)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.ActiveActionId:
						SAActiveActionNode ActiveActionId_node_Actions = graph.AddNode<SAActiveActionNode>();
						GetPort(portName).Connect(ActiveActionId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(ActiveActionId_node_Actions, assetPath);
						variableCount += ActiveActionId_node_Actions.SetData((SAActiveAction)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.DeactivateActionId:
						SADeactivateActionNode DeactivateActionId_node_Actions = graph.AddNode<SADeactivateActionNode>();
						GetPort(portName).Connect(DeactivateActionId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(DeactivateActionId_node_Actions, assetPath);
						variableCount += DeactivateActionId_node_Actions.SetData((SADeactivateAction)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SetFloatId:
						SASetFloatTargetNode SetFloatId_node_Actions = graph.AddNode<SASetFloatTargetNode>();
						GetPort(portName).Connect(SetFloatId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SetFloatId_node_Actions, assetPath);
						variableCount += SetFloatId_node_Actions.SetData((SASetFloatTarget)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.OnBounceId:
						SAOnBounceNode OnBounceId_node_Actions = graph.AddNode<SAOnBounceNode>();
						GetPort(portName).Connect(OnBounceId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(OnBounceId_node_Actions, assetPath);
						variableCount += OnBounceId_node_Actions.SetData((SAOnBounce)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.OnLeaveEdgeId:
						SAOnLeaveEdgeNode OnLeaveEdgeId_node_Actions = graph.AddNode<SAOnLeaveEdgeNode>();
						GetPort(portName).Connect(OnLeaveEdgeId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(OnLeaveEdgeId_node_Actions, assetPath);
						variableCount += OnLeaveEdgeId_node_Actions.SetData((SAOnLeaveEdge)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.OnStoppedAtEdgeId:
						SAOnStoppedAtLedgeNode OnStoppedAtEdgeId_node_Actions = graph.AddNode<SAOnStoppedAtLedgeNode>();
						GetPort(portName).Connect(OnStoppedAtEdgeId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(OnStoppedAtEdgeId_node_Actions, assetPath);
						variableCount += OnStoppedAtEdgeId_node_Actions.SetData((SAOnStoppedAtLedge)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.OnLandId:
						SAOnLandNode OnLandId_node_Actions = graph.AddNode<SAOnLandNode>();
						GetPort(portName).Connect(OnLandId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(OnLandId_node_Actions, assetPath);
						variableCount += OnLandId_node_Actions.SetData((SAOnLand)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.OnCancelId:
						SAOnCancelNode OnCancelId_node_Actions = graph.AddNode<SAOnCancelNode>();
						GetPort(portName).Connect(OnCancelId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(OnCancelId_node_Actions, assetPath);
						variableCount += OnCancelId_node_Actions.SetData((SAOnCancel)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.RefreshAtkId:
						SARefreshAttackNode RefreshAtkId_node_Actions = graph.AddNode<SARefreshAttackNode>();
						GetPort(portName).Connect(RefreshAtkId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(RefreshAtkId_node_Actions, assetPath);
						variableCount += RefreshAtkId_node_Actions.SetData((SARefreshAttack)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.EndAtkId:
						SAEndAttackNode EndAtkId_node_Actions = graph.AddNode<SAEndAttackNode>();
						GetPort(portName).Connect(EndAtkId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(EndAtkId_node_Actions, assetPath);
						variableCount += EndAtkId_node_Actions.SetData((SAEndAttack)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SetHitboxCountId:
						SASetHitboxCountNode SetHitboxCountId_node_Actions = graph.AddNode<SASetHitboxCountNode>();
						GetPort(portName).Connect(SetHitboxCountId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SetHitboxCountId_node_Actions, assetPath);
						variableCount += SetHitboxCountId_node_Actions.SetData((SASetHitboxCount)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.ConfigHitboxId:
						SAConfigHitboxNode ConfigHitboxId_node_Actions = graph.AddNode<SAConfigHitboxNode>();
						GetPort(portName).Connect(ConfigHitboxId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(ConfigHitboxId_node_Actions, assetPath);
						variableCount += ConfigHitboxId_node_Actions.SetData((SAConfigHitbox)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SetAtkPropId:
						SASetAttackPropNode SetAtkPropId_node_Actions = graph.AddNode<SASetAttackPropNode>();
						GetPort(portName).Connect(SetAtkPropId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SetAtkPropId_node_Actions, assetPath);
						variableCount += SetAtkPropId_node_Actions.SetData((SASetAttackProp)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.ManipHitboxId:
						SAManipHitboxNode ManipHitboxId_node_Actions = graph.AddNode<SAManipHitboxNode>();
						GetPort(portName).Connect(ManipHitboxId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(ManipHitboxId_node_Actions, assetPath);
						variableCount += ManipHitboxId_node_Actions.SetData((SAManipHitbox)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.UpdateHurtsetId:
						SAUpdateHurtboxesNode UpdateHurtsetId_node_Actions = graph.AddNode<SAUpdateHurtboxesNode>();
						GetPort(portName).Connect(UpdateHurtsetId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(UpdateHurtsetId_node_Actions, assetPath);
						variableCount += UpdateHurtsetId_node_Actions.SetData((SAUpdateHurtboxes)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SetupHurtsetId:
						SASetupHurtboxesNode SetupHurtsetId_node_Actions = graph.AddNode<SASetupHurtboxesNode>();
						GetPort(portName).Connect(SetupHurtsetId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SetupHurtsetId_node_Actions, assetPath);
						variableCount += SetupHurtsetId_node_Actions.SetData((SASetupHurtboxes)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.ManipHurtboxId:
						SAManipHurtboxNode ManipHurtboxId_node_Actions = graph.AddNode<SAManipHurtboxNode>();
						GetPort(portName).Connect(ManipHurtboxId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(ManipHurtboxId_node_Actions, assetPath);
						variableCount += ManipHurtboxId_node_Actions.SetData((SAManipHurtbox)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.BoneStateId:
						SABoneStateNode BoneStateId_node_Actions = graph.AddNode<SABoneStateNode>();
						GetPort(portName).Connect(BoneStateId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(BoneStateId_node_Actions, assetPath);
						variableCount += BoneStateId_node_Actions.SetData((SABoneState)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.BoneScaleId:
						SABoneScaleNode BoneScaleId_node_Actions = graph.AddNode<SABoneScaleNode>();
						GetPort(portName).Connect(BoneScaleId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(BoneScaleId_node_Actions, assetPath);
						variableCount += BoneScaleId_node_Actions.SetData((SABoneScale)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SpawnAgentId:
						SASpawnAgentNode SpawnAgentId_node_Actions = graph.AddNode<SASpawnAgentNode>();
						GetPort(portName).Connect(SpawnAgentId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SpawnAgentId_node_Actions, assetPath);
						variableCount += SpawnAgentId_node_Actions.SetData((SASpawnAgent)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.LocalFXId:
						SALocalFXNode LocalFXId_node_Actions = graph.AddNode<SALocalFXNode>();
						GetPort(portName).Connect(LocalFXId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(LocalFXId_node_Actions, assetPath);
						variableCount += LocalFXId_node_Actions.SetData((SALocalFX)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SpawnFXId:
						SASpawnFXNode SpawnFXId_node_Actions = graph.AddNode<SASpawnFXNode>();
						GetPort(portName).Connect(SpawnFXId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SpawnFXId_node_Actions, assetPath);
						variableCount += SpawnFXId_node_Actions.SetData((SASpawnFX)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.HitboxFXId:
						SASetHitboxFXNode HitboxFXId_node_Actions = graph.AddNode<SASetHitboxFXNode>();
						GetPort(portName).Connect(HitboxFXId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(HitboxFXId_node_Actions, assetPath);
						variableCount += HitboxFXId_node_Actions.SetData((SASetHitboxFX)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SFXId:
						SAPlaySFXNode SFXId_node_Actions = graph.AddNode<SAPlaySFXNode>();
						GetPort(portName).Connect(SFXId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SFXId_node_Actions, assetPath);
						variableCount += SFXId_node_Actions.SetData((SAPlaySFX)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.HitboxSFXId:
						SASetHitboxSFXNode HitboxSFXId_node_Actions = graph.AddNode<SASetHitboxSFXNode>();
						GetPort(portName).Connect(HitboxSFXId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(HitboxSFXId_node_Actions, assetPath);
						variableCount += HitboxSFXId_node_Actions.SetData((SASetHitboxSFX)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.ColorTintId:
						SAColorTintNode ColorTintId_node_Actions = graph.AddNode<SAColorTintNode>();
						GetPort(portName).Connect(ColorTintId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(ColorTintId_node_Actions, assetPath);
						variableCount += ColorTintId_node_Actions.SetData((SAColorTint)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.FindFloorId:
						SAFindFloorNode FindFloorId_node_Actions = graph.AddNode<SAFindFloorNode>();
						GetPort(portName).Connect(FindFloorId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(FindFloorId_node_Actions, assetPath);
						variableCount += FindFloorId_node_Actions.SetData((SAFindFloor)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.HurtGrabbedId:
						SAHurtGrabbedNode HurtGrabbedId_node_Actions = graph.AddNode<SAHurtGrabbedNode>();
						GetPort(portName).Connect(HurtGrabbedId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(HurtGrabbedId_node_Actions, assetPath);
						variableCount += HurtGrabbedId_node_Actions.SetData((SAHurtGrabbed)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.LaunchGrabbedId:
						SALaunchGrabbedNode LaunchGrabbedId_node_Actions = graph.AddNode<SALaunchGrabbedNode>();
						GetPort(portName).Connect(LaunchGrabbedId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(LaunchGrabbedId_node_Actions, assetPath);
						variableCount += LaunchGrabbedId_node_Actions.SetData((SALaunchGrabbed)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.StateCancelGrabbedId:
						SAStateCancelGrabbedNode StateCancelGrabbedId_node_Actions = graph.AddNode<SAStateCancelGrabbedNode>();
						GetPort(portName).Connect(StateCancelGrabbedId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(StateCancelGrabbedId_node_Actions, assetPath);
						variableCount += StateCancelGrabbedId_node_Actions.SetData((SAStateCancelGrabbed)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.EndGrabId:
						SAEndGrabNode EndGrabId_node_Actions = graph.AddNode<SAEndGrabNode>();
						GetPort(portName).Connect(EndGrabId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(EndGrabId_node_Actions, assetPath);
						variableCount += EndGrabId_node_Actions.SetData((SAEndGrab)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.GrabNotifyEscapeId:
						SAGrabNotifyEscapeNode GrabNotifyEscapeId_node_Actions = graph.AddNode<SAGrabNotifyEscapeNode>();
						GetPort(portName).Connect(GrabNotifyEscapeId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(GrabNotifyEscapeId_node_Actions, assetPath);
						variableCount += GrabNotifyEscapeId_node_Actions.SetData((SAGrabNotifyEscape)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.IgnoreGrabbedId:
						SAIgnoreGrabbedNode IgnoreGrabbedId_node_Actions = graph.AddNode<SAIgnoreGrabbedNode>();
						GetPort(portName).Connect(IgnoreGrabbedId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(IgnoreGrabbedId_node_Actions, assetPath);
						variableCount += IgnoreGrabbedId_node_Actions.SetData((SAIgnoreGrabbed)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.EventKOId:
						SAEventKONode EventKOId_node_Actions = graph.AddNode<SAEventKONode>();
						GetPort(portName).Connect(EventKOId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(EventKOId_node_Actions, assetPath);
						variableCount += EventKOId_node_Actions.SetData((SAEventKO)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.EventKOGrabbedId:
						SAEventKOGrabbedNode EventKOGrabbedId_node_Actions = graph.AddNode<SAEventKOGrabbedNode>();
						GetPort(portName).Connect(EventKOGrabbedId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(EventKOGrabbedId_node_Actions, assetPath);
						variableCount += EventKOGrabbedId_node_Actions.SetData((SAEventKOGrabbed)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.CameraShakeId:
						SACameraShakeNode CameraShakeId_node_Actions = graph.AddNode<SACameraShakeNode>();
						GetPort(portName).Connect(CameraShakeId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(CameraShakeId_node_Actions, assetPath);
						variableCount += CameraShakeId_node_Actions.SetData((SACameraShake)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.ResetOnHitId:
						SAResetOnHitsNode ResetOnHitId_node_Actions = graph.AddNode<SAResetOnHitsNode>();
						GetPort(portName).Connect(ResetOnHitId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(ResetOnHitId_node_Actions, assetPath);
						variableCount += ResetOnHitId_node_Actions.SetData((SAResetOnHits)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.OnHitId:
						SAOnHitNode OnHitId_node_Actions = graph.AddNode<SAOnHitNode>();
						GetPort(portName).Connect(OnHitId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(OnHitId_node_Actions, assetPath);
						variableCount += OnHitId_node_Actions.SetData((SAOnHit)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.FastForwardId:
						SAFastForwardStateNode FastForwardId_node_Actions = graph.AddNode<SAFastForwardStateNode>();
						GetPort(portName).Connect(FastForwardId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(FastForwardId_node_Actions, assetPath);
						variableCount += FastForwardId_node_Actions.SetData((SAFastForwardState)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.TimingTweakId:
						SATimingTweakNode TimingTweakId_node_Actions = graph.AddNode<SATimingTweakNode>();
						GetPort(portName).Connect(TimingTweakId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(TimingTweakId_node_Actions, assetPath);
						variableCount += TimingTweakId_node_Actions.SetData((SATimingTweak)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.MapAnimId:
						SAMapAnimationNode MapAnimId_node_Actions = graph.AddNode<SAMapAnimationNode>();
						GetPort(portName).Connect(MapAnimId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(MapAnimId_node_Actions, assetPath);
						variableCount += MapAnimId_node_Actions.SetData((SAMapAnimation)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.AlterMoveDtId:
						SAAlterMoveDTNode AlterMoveDtId_node_Actions = graph.AddNode<SAAlterMoveDTNode>();
						GetPort(portName).Connect(AlterMoveDtId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(AlterMoveDtId_node_Actions, assetPath);
						variableCount += AlterMoveDtId_node_Actions.SetData((SAAlterMoveDT)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.AlterMoveVelId:
						SAAlterMoveVelNode AlterMoveVelId_node_Actions = graph.AddNode<SAAlterMoveVelNode>();
						GetPort(portName).Connect(AlterMoveVelId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(AlterMoveVelId_node_Actions, assetPath);
						variableCount += AlterMoveVelId_node_Actions.SetData((SAAlterMoveVel)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SetStagePartId:
						SASetStagePartNode SetStagePartId_node_Actions = graph.AddNode<SASetStagePartNode>();
						GetPort(portName).Connect(SetStagePartId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SetStagePartId_node_Actions, assetPath);
						variableCount += SetStagePartId_node_Actions.SetData((SASetStagePart)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SetStagePartsDefaultId:
						SASetStagePartsDefaultNode SetStagePartsDefaultId_node_Actions = graph.AddNode<SASetStagePartsDefaultNode>();
						GetPort(portName).Connect(SetStagePartsDefaultId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SetStagePartsDefaultId_node_Actions, assetPath);
						variableCount += SetStagePartsDefaultId_node_Actions.SetData((SASetStagePartsDefault)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.JumpId:
						SAJumpNode JumpId_node_Actions = graph.AddNode<SAJumpNode>();
						GetPort(portName).Connect(JumpId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(JumpId_node_Actions, assetPath);
						variableCount += JumpId_node_Actions.SetData((SAJump)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.StopJumpId:
						SAStopJumpNode StopJumpId_node_Actions = graph.AddNode<SAStopJumpNode>();
						GetPort(portName).Connect(StopJumpId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(StopJumpId_node_Actions, assetPath);
						variableCount += StopJumpId_node_Actions.SetData((SAStopJump)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.ManageAirJumpId:
						SAManageAirJumpNode ManageAirJumpId_node_Actions = graph.AddNode<SAManageAirJumpNode>();
						GetPort(portName).Connect(ManageAirJumpId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(ManageAirJumpId_node_Actions, assetPath);
						variableCount += ManageAirJumpId_node_Actions.SetData((SAManageAirJump)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.LeaveGroundId:
						SALeaveGroundNode LeaveGroundId_node_Actions = graph.AddNode<SALeaveGroundNode>();
						GetPort(portName).Connect(LeaveGroundId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(LeaveGroundId_node_Actions, assetPath);
						variableCount += LeaveGroundId_node_Actions.SetData((SALeaveGround)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.UnhogEdgeId:
						SAUnHogEdgeNode UnhogEdgeId_node_Actions = graph.AddNode<SAUnHogEdgeNode>();
						GetPort(portName).Connect(UnhogEdgeId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(UnhogEdgeId_node_Actions, assetPath);
						variableCount += UnhogEdgeId_node_Actions.SetData((SAUnHogEdge)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SFXTimelineId:
						SAPlaySFXTimelineNode SFXTimelineId_node_Actions = graph.AddNode<SAPlaySFXTimelineNode>();
						GetPort(portName).Connect(SFXTimelineId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SFXTimelineId_node_Actions, assetPath);
						variableCount += SFXTimelineId_node_Actions.SetData((SAPlaySFXTimeline)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.FindLastHorizontalInputId:
						SAFindLastHorizontalInputNode FindLastHorizontalInputId_node_Actions = graph.AddNode<SAFindLastHorizontalInputNode>();
						GetPort(portName).Connect(FindLastHorizontalInputId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(FindLastHorizontalInputId_node_Actions, assetPath);
						variableCount += FindLastHorizontalInputId_node_Actions.SetData((SAFindLastHorizontalInput)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SetCommandGrab:
						SASetCommandGrabNode SetCommandGrab_node_Actions = graph.AddNode<SASetCommandGrabNode>();
						GetPort(portName).Connect(SetCommandGrab_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SetCommandGrab_node_Actions, assetPath);
						variableCount += SetCommandGrab_node_Actions.SetData((SASetCommandGrab)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.CameraPunchId:
						SACameraPunchNode CameraPunchId_node_Actions = graph.AddNode<SACameraPunchNode>();
						GetPort(portName).Connect(CameraPunchId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(CameraPunchId_node_Actions, assetPath);
						variableCount += CameraPunchId_node_Actions.SetData((SACameraPunch)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SpawnAgent2Id:
						SASpawnAgent2Node SpawnAgent2Id_node_Actions = graph.AddNode<SASpawnAgent2Node>();
						GetPort(portName).Connect(SpawnAgent2Id_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SpawnAgent2Id_node_Actions, assetPath);
						variableCount += SpawnAgent2Id_node_Actions.SetData((SASpawnAgent2)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.ManipDecorChainId:
						SAManipDecorChainNode ManipDecorChainId_node_Actions = graph.AddNode<SAManipDecorChainNode>();
						GetPort(portName).Connect(ManipDecorChainId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(ManipDecorChainId_node_Actions, assetPath);
						variableCount += ManipDecorChainId_node_Actions.SetData((SAManipDecorChain)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.UpdateHitboxesId:
						SAUpdateHitboxesNode UpdateHitboxesId_node_Actions = graph.AddNode<SAUpdateHitboxesNode>();
						GetPort(portName).Connect(UpdateHitboxesId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(UpdateHitboxesId_node_Actions, assetPath);
						variableCount += UpdateHitboxesId_node_Actions.SetData((SAUpdateHitboxes)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SampleAnimId:
						SASampleAnimNode SampleAnimId_node_Actions = graph.AddNode<SASampleAnimNode>();
						GetPort(portName).Connect(SampleAnimId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SampleAnimId_node_Actions, assetPath);
						variableCount += SampleAnimId_node_Actions.SetData((SASampleAnim)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.ForceExtraInputId:
						SAForceExtraInputCheckNode ForceExtraInputId_node_Actions = graph.AddNode<SAForceExtraInputCheckNode>();
						GetPort(portName).Connect(ForceExtraInputId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(ForceExtraInputId_node_Actions, assetPath);
						variableCount += ForceExtraInputId_node_Actions.SetData((SAForceExtraInputCheck)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.LaunchGrabbedCustomId:
						SALaunchGrabbedCustomNode LaunchGrabbedCustomId_node_Actions = graph.AddNode<SALaunchGrabbedCustomNode>();
						GetPort(portName).Connect(LaunchGrabbedCustomId_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(LaunchGrabbedCustomId_node_Actions, assetPath);
						variableCount += LaunchGrabbedCustomId_node_Actions.SetData((SALaunchGrabbedCustom)Actions_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
					break;
					case StateAction.TypeId.BaseIdentifier:
						StateActionNode BaseIdentifier_node_Actions = graph.AddNode<StateActionNode>();
						GetPort(portName).Connect(BaseIdentifier_node_Actions.GetPort("NodeInput"));
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
			foreach(NodePort port in DynamicOutputs)
			{
				if (port.ConnectionCount <= 0) continue;
				StateActionNode StateAction_Node = (StateActionNode)port.Connection.node;
				switch (StateAction_Node.TID)
				{
					case StateAction.TypeId.DebugId:
						SADebugMessageNode DebugId_StateAction_Node = (SADebugMessageNode)port.Connection.node;
						objToReturn.Actions.Add(DebugId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.PlayAnimId:
						SAPlayAnimNode PlayAnimId_StateAction_Node = (SAPlayAnimNode)port.Connection.node;
						objToReturn.Actions.Add(PlayAnimId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.RootAnimId:
						SAPlayRootAnimNode RootAnimId_StateAction_Node = (SAPlayRootAnimNode)port.Connection.node;
						objToReturn.Actions.Add(RootAnimId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.SnapAnimWeightsId:
						SASnapAnimWeightsNode SnapAnimWeightsId_StateAction_Node = (SASnapAnimWeightsNode)port.Connection.node;
						objToReturn.Actions.Add(SnapAnimWeightsId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.StandardInputId:
						SAStandardInputNode StandardInputId_StateAction_Node = (SAStandardInputNode)port.Connection.node;
						objToReturn.Actions.Add(StandardInputId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.InputId:
						SAInputActionNode InputId_StateAction_Node = (SAInputActionNode)port.Connection.node;
						objToReturn.Actions.Add(InputId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.DeactInputId:
						SADeactivateInputActionNode DeactInputId_StateAction_Node = (SADeactivateInputActionNode)port.Connection.node;
						objToReturn.Actions.Add(DeactInputId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.InputEventFromFrameId:
						SAAddInputEventFromFrameNode InputEventFromFrameId_StateAction_Node = (SAAddInputEventFromFrameNode)port.Connection.node;
						objToReturn.Actions.Add(InputEventFromFrameId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.CancelStateId:
						SACancelToStateNode CancelStateId_StateAction_Node = (SACancelToStateNode)port.Connection.node;
						objToReturn.Actions.Add(CancelStateId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.CustomCallId:
						SACustomCallNode CustomCallId_StateAction_Node = (SACustomCallNode)port.Connection.node;
						objToReturn.Actions.Add(CustomCallId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.TimerId:
						SATimedActionNode TimerId_StateAction_Node = (SATimedActionNode)port.Connection.node;
						objToReturn.Actions.Add(TimerId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.OrderId:
						SAOrderedSensitiveNode OrderId_StateAction_Node = (SAOrderedSensitiveNode)port.Connection.node;
						objToReturn.Actions.Add(OrderId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.ProxyId:
						SAProxyMoveNode ProxyId_StateAction_Node = (SAProxyMoveNode)port.Connection.node;
						objToReturn.Actions.Add(ProxyId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.CheckId:
						SACheckThingNode CheckId_StateAction_Node = (SACheckThingNode)port.Connection.node;
						objToReturn.Actions.Add(CheckId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.ActiveActionId:
						SAActiveActionNode ActiveActionId_StateAction_Node = (SAActiveActionNode)port.Connection.node;
						objToReturn.Actions.Add(ActiveActionId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.DeactivateActionId:
						SADeactivateActionNode DeactivateActionId_StateAction_Node = (SADeactivateActionNode)port.Connection.node;
						objToReturn.Actions.Add(DeactivateActionId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.SetFloatId:
						SASetFloatTargetNode SetFloatId_StateAction_Node = (SASetFloatTargetNode)port.Connection.node;
						objToReturn.Actions.Add(SetFloatId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.OnBounceId:
						SAOnBounceNode OnBounceId_StateAction_Node = (SAOnBounceNode)port.Connection.node;
						objToReturn.Actions.Add(OnBounceId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.OnLeaveEdgeId:
						SAOnLeaveEdgeNode OnLeaveEdgeId_StateAction_Node = (SAOnLeaveEdgeNode)port.Connection.node;
						objToReturn.Actions.Add(OnLeaveEdgeId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.OnStoppedAtEdgeId:
						SAOnStoppedAtLedgeNode OnStoppedAtEdgeId_StateAction_Node = (SAOnStoppedAtLedgeNode)port.Connection.node;
						objToReturn.Actions.Add(OnStoppedAtEdgeId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.OnLandId:
						SAOnLandNode OnLandId_StateAction_Node = (SAOnLandNode)port.Connection.node;
						objToReturn.Actions.Add(OnLandId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.OnCancelId:
						SAOnCancelNode OnCancelId_StateAction_Node = (SAOnCancelNode)port.Connection.node;
						objToReturn.Actions.Add(OnCancelId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.RefreshAtkId:
						SARefreshAttackNode RefreshAtkId_StateAction_Node = (SARefreshAttackNode)port.Connection.node;
						objToReturn.Actions.Add(RefreshAtkId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.EndAtkId:
						SAEndAttackNode EndAtkId_StateAction_Node = (SAEndAttackNode)port.Connection.node;
						objToReturn.Actions.Add(EndAtkId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.SetHitboxCountId:
						SASetHitboxCountNode SetHitboxCountId_StateAction_Node = (SASetHitboxCountNode)port.Connection.node;
						objToReturn.Actions.Add(SetHitboxCountId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.ConfigHitboxId:
						SAConfigHitboxNode ConfigHitboxId_StateAction_Node = (SAConfigHitboxNode)port.Connection.node;
						objToReturn.Actions.Add(ConfigHitboxId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.SetAtkPropId:
						SASetAttackPropNode SetAtkPropId_StateAction_Node = (SASetAttackPropNode)port.Connection.node;
						objToReturn.Actions.Add(SetAtkPropId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.ManipHitboxId:
						SAManipHitboxNode ManipHitboxId_StateAction_Node = (SAManipHitboxNode)port.Connection.node;
						objToReturn.Actions.Add(ManipHitboxId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.UpdateHurtsetId:
						SAUpdateHurtboxesNode UpdateHurtsetId_StateAction_Node = (SAUpdateHurtboxesNode)port.Connection.node;
						objToReturn.Actions.Add(UpdateHurtsetId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.SetupHurtsetId:
						SASetupHurtboxesNode SetupHurtsetId_StateAction_Node = (SASetupHurtboxesNode)port.Connection.node;
						objToReturn.Actions.Add(SetupHurtsetId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.ManipHurtboxId:
						SAManipHurtboxNode ManipHurtboxId_StateAction_Node = (SAManipHurtboxNode)port.Connection.node;
						objToReturn.Actions.Add(ManipHurtboxId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.BoneStateId:
						SABoneStateNode BoneStateId_StateAction_Node = (SABoneStateNode)port.Connection.node;
						objToReturn.Actions.Add(BoneStateId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.BoneScaleId:
						SABoneScaleNode BoneScaleId_StateAction_Node = (SABoneScaleNode)port.Connection.node;
						objToReturn.Actions.Add(BoneScaleId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.SpawnAgentId:
						SASpawnAgentNode SpawnAgentId_StateAction_Node = (SASpawnAgentNode)port.Connection.node;
						objToReturn.Actions.Add(SpawnAgentId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.LocalFXId:
						SALocalFXNode LocalFXId_StateAction_Node = (SALocalFXNode)port.Connection.node;
						objToReturn.Actions.Add(LocalFXId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.SpawnFXId:
						SASpawnFXNode SpawnFXId_StateAction_Node = (SASpawnFXNode)port.Connection.node;
						objToReturn.Actions.Add(SpawnFXId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.HitboxFXId:
						SASetHitboxFXNode HitboxFXId_StateAction_Node = (SASetHitboxFXNode)port.Connection.node;
						objToReturn.Actions.Add(HitboxFXId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.SFXId:
						SAPlaySFXNode SFXId_StateAction_Node = (SAPlaySFXNode)port.Connection.node;
						objToReturn.Actions.Add(SFXId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.HitboxSFXId:
						SASetHitboxSFXNode HitboxSFXId_StateAction_Node = (SASetHitboxSFXNode)port.Connection.node;
						objToReturn.Actions.Add(HitboxSFXId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.ColorTintId:
						SAColorTintNode ColorTintId_StateAction_Node = (SAColorTintNode)port.Connection.node;
						objToReturn.Actions.Add(ColorTintId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.FindFloorId:
						SAFindFloorNode FindFloorId_StateAction_Node = (SAFindFloorNode)port.Connection.node;
						objToReturn.Actions.Add(FindFloorId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.HurtGrabbedId:
						SAHurtGrabbedNode HurtGrabbedId_StateAction_Node = (SAHurtGrabbedNode)port.Connection.node;
						objToReturn.Actions.Add(HurtGrabbedId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.LaunchGrabbedId:
						SALaunchGrabbedNode LaunchGrabbedId_StateAction_Node = (SALaunchGrabbedNode)port.Connection.node;
						objToReturn.Actions.Add(LaunchGrabbedId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.StateCancelGrabbedId:
						SAStateCancelGrabbedNode StateCancelGrabbedId_StateAction_Node = (SAStateCancelGrabbedNode)port.Connection.node;
						objToReturn.Actions.Add(StateCancelGrabbedId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.EndGrabId:
						SAEndGrabNode EndGrabId_StateAction_Node = (SAEndGrabNode)port.Connection.node;
						objToReturn.Actions.Add(EndGrabId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.GrabNotifyEscapeId:
						SAGrabNotifyEscapeNode GrabNotifyEscapeId_StateAction_Node = (SAGrabNotifyEscapeNode)port.Connection.node;
						objToReturn.Actions.Add(GrabNotifyEscapeId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.IgnoreGrabbedId:
						SAIgnoreGrabbedNode IgnoreGrabbedId_StateAction_Node = (SAIgnoreGrabbedNode)port.Connection.node;
						objToReturn.Actions.Add(IgnoreGrabbedId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.EventKOId:
						SAEventKONode EventKOId_StateAction_Node = (SAEventKONode)port.Connection.node;
						objToReturn.Actions.Add(EventKOId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.EventKOGrabbedId:
						SAEventKOGrabbedNode EventKOGrabbedId_StateAction_Node = (SAEventKOGrabbedNode)port.Connection.node;
						objToReturn.Actions.Add(EventKOGrabbedId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.CameraShakeId:
						SACameraShakeNode CameraShakeId_StateAction_Node = (SACameraShakeNode)port.Connection.node;
						objToReturn.Actions.Add(CameraShakeId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.ResetOnHitId:
						SAResetOnHitsNode ResetOnHitId_StateAction_Node = (SAResetOnHitsNode)port.Connection.node;
						objToReturn.Actions.Add(ResetOnHitId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.OnHitId:
						SAOnHitNode OnHitId_StateAction_Node = (SAOnHitNode)port.Connection.node;
						objToReturn.Actions.Add(OnHitId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.FastForwardId:
						SAFastForwardStateNode FastForwardId_StateAction_Node = (SAFastForwardStateNode)port.Connection.node;
						objToReturn.Actions.Add(FastForwardId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.TimingTweakId:
						SATimingTweakNode TimingTweakId_StateAction_Node = (SATimingTweakNode)port.Connection.node;
						objToReturn.Actions.Add(TimingTweakId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.MapAnimId:
						SAMapAnimationNode MapAnimId_StateAction_Node = (SAMapAnimationNode)port.Connection.node;
						objToReturn.Actions.Add(MapAnimId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.AlterMoveDtId:
						SAAlterMoveDTNode AlterMoveDtId_StateAction_Node = (SAAlterMoveDTNode)port.Connection.node;
						objToReturn.Actions.Add(AlterMoveDtId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.AlterMoveVelId:
						SAAlterMoveVelNode AlterMoveVelId_StateAction_Node = (SAAlterMoveVelNode)port.Connection.node;
						objToReturn.Actions.Add(AlterMoveVelId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.SetStagePartId:
						SASetStagePartNode SetStagePartId_StateAction_Node = (SASetStagePartNode)port.Connection.node;
						objToReturn.Actions.Add(SetStagePartId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.SetStagePartsDefaultId:
						SASetStagePartsDefaultNode SetStagePartsDefaultId_StateAction_Node = (SASetStagePartsDefaultNode)port.Connection.node;
						objToReturn.Actions.Add(SetStagePartsDefaultId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.JumpId:
						SAJumpNode JumpId_StateAction_Node = (SAJumpNode)port.Connection.node;
						objToReturn.Actions.Add(JumpId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.StopJumpId:
						SAStopJumpNode StopJumpId_StateAction_Node = (SAStopJumpNode)port.Connection.node;
						objToReturn.Actions.Add(StopJumpId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.ManageAirJumpId:
						SAManageAirJumpNode ManageAirJumpId_StateAction_Node = (SAManageAirJumpNode)port.Connection.node;
						objToReturn.Actions.Add(ManageAirJumpId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.LeaveGroundId:
						SALeaveGroundNode LeaveGroundId_StateAction_Node = (SALeaveGroundNode)port.Connection.node;
						objToReturn.Actions.Add(LeaveGroundId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.UnhogEdgeId:
						SAUnHogEdgeNode UnhogEdgeId_StateAction_Node = (SAUnHogEdgeNode)port.Connection.node;
						objToReturn.Actions.Add(UnhogEdgeId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.SFXTimelineId:
						SAPlaySFXTimelineNode SFXTimelineId_StateAction_Node = (SAPlaySFXTimelineNode)port.Connection.node;
						objToReturn.Actions.Add(SFXTimelineId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.FindLastHorizontalInputId:
						SAFindLastHorizontalInputNode FindLastHorizontalInputId_StateAction_Node = (SAFindLastHorizontalInputNode)port.Connection.node;
						objToReturn.Actions.Add(FindLastHorizontalInputId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.SetCommandGrab:
						SASetCommandGrabNode SetCommandGrab_StateAction_Node = (SASetCommandGrabNode)port.Connection.node;
						objToReturn.Actions.Add(SetCommandGrab_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.CameraPunchId:
						SACameraPunchNode CameraPunchId_StateAction_Node = (SACameraPunchNode)port.Connection.node;
						objToReturn.Actions.Add(CameraPunchId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.SpawnAgent2Id:
						SASpawnAgent2Node SpawnAgent2Id_StateAction_Node = (SASpawnAgent2Node)port.Connection.node;
						objToReturn.Actions.Add(SpawnAgent2Id_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.ManipDecorChainId:
						SAManipDecorChainNode ManipDecorChainId_StateAction_Node = (SAManipDecorChainNode)port.Connection.node;
						objToReturn.Actions.Add(ManipDecorChainId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.UpdateHitboxesId:
						SAUpdateHitboxesNode UpdateHitboxesId_StateAction_Node = (SAUpdateHitboxesNode)port.Connection.node;
						objToReturn.Actions.Add(UpdateHitboxesId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.SampleAnimId:
						SASampleAnimNode SampleAnimId_StateAction_Node = (SASampleAnimNode)port.Connection.node;
						objToReturn.Actions.Add(SampleAnimId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.ForceExtraInputId:
						SAForceExtraInputCheckNode ForceExtraInputId_StateAction_Node = (SAForceExtraInputCheckNode)port.Connection.node;
						objToReturn.Actions.Add(ForceExtraInputId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.LaunchGrabbedCustomId:
						SALaunchGrabbedCustomNode LaunchGrabbedCustomId_StateAction_Node = (SALaunchGrabbedCustomNode)port.Connection.node;
						objToReturn.Actions.Add(LaunchGrabbedCustomId_StateAction_Node.GetData());
					break;
					case StateAction.TypeId.BaseIdentifier:
						StateActionNode BaseIdentifier_StateAction_Node = (StateActionNode)port.Connection.node;
						objToReturn.Actions.Add(BaseIdentifier_StateAction_Node.GetData());
					break;
				}
			}
			return objToReturn;
		}
	}
}

