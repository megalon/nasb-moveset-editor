// * 
// * 
// * This file was generated using NASB_Parser_to_xNode by megalon2d
// * https://github.com/megalon/NASB_Parser_to_xNode
// * 
// * 
using NASB_Parser.CheckThings;
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
	public class SACheckThingNode : StateActionNode
	{
		[Output] public CheckThing CheckThing;
		[Output] public StateAction Action;
		public bool Else;
		[Output] public StateAction ElseAction;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.CheckId;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SACheckThing data, MovesetGraph graph, string assetPath, Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SACheckThing));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			CheckThing = data.CheckThing;
			
			switch (CheckThing.TID)
			{
				case CheckThing.TypeId.MultipleId:
					CTMultipleNode MultipleId_node_CheckThing = graph.AddNode<CTMultipleNode>();
					GetPort("CheckThing").Connect(MultipleId_node_CheckThing.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(MultipleId_node_CheckThing, assetPath);
					variableCount += MultipleId_node_CheckThing.SetData((CTMultiple)CheckThing, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case CheckThing.TypeId.CompareId:
					CTCompareFloatNode CompareId_node_CheckThing = graph.AddNode<CTCompareFloatNode>();
					GetPort("CheckThing").Connect(CompareId_node_CheckThing.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CompareId_node_CheckThing, assetPath);
					variableCount += CompareId_node_CheckThing.SetData((CTCompareFloat)CheckThing, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case CheckThing.TypeId.DoubleTapId:
					CTDoubleTapIdNode DoubleTapId_node_CheckThing = graph.AddNode<CTDoubleTapIdNode>();
					GetPort("CheckThing").Connect(DoubleTapId_node_CheckThing.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DoubleTapId_node_CheckThing, assetPath);
					variableCount += DoubleTapId_node_CheckThing.SetData((CTDoubleTapId)CheckThing, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case CheckThing.TypeId.InputId:
					CTInputNode InputId_node_CheckThing = graph.AddNode<CTInputNode>();
					GetPort("CheckThing").Connect(InputId_node_CheckThing.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputId_node_CheckThing, assetPath);
					variableCount += InputId_node_CheckThing.SetData((CTInput)CheckThing, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case CheckThing.TypeId.InputSeriesId:
					CTInputSeriesNode InputSeriesId_node_CheckThing = graph.AddNode<CTInputSeriesNode>();
					GetPort("CheckThing").Connect(InputSeriesId_node_CheckThing.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputSeriesId_node_CheckThing, assetPath);
					variableCount += InputSeriesId_node_CheckThing.SetData((CTInputSeries)CheckThing, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case CheckThing.TypeId.TechId:
					CTCheckTechNode TechId_node_CheckThing = graph.AddNode<CTCheckTechNode>();
					GetPort("CheckThing").Connect(TechId_node_CheckThing.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(TechId_node_CheckThing, assetPath);
					variableCount += TechId_node_CheckThing.SetData((CTCheckTech)CheckThing, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case CheckThing.TypeId.GrabId:
					CTGrabIdNode GrabId_node_CheckThing = graph.AddNode<CTGrabIdNode>();
					GetPort("CheckThing").Connect(GrabId_node_CheckThing.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(GrabId_node_CheckThing, assetPath);
					variableCount += GrabId_node_CheckThing.SetData((CTGrabId)CheckThing, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case CheckThing.TypeId.GrabAgentId:
					CTGrabbedAgentNode GrabAgentId_node_CheckThing = graph.AddNode<CTGrabbedAgentNode>();
					GetPort("CheckThing").Connect(GrabAgentId_node_CheckThing.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(GrabAgentId_node_CheckThing, assetPath);
					variableCount += GrabAgentId_node_CheckThing.SetData((CTGrabbedAgent)CheckThing, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case CheckThing.TypeId.SkinId:
					CTSkinNode SkinId_node_CheckThing = graph.AddNode<CTSkinNode>();
					GetPort("CheckThing").Connect(SkinId_node_CheckThing.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SkinId_node_CheckThing, assetPath);
					variableCount += SkinId_node_CheckThing.SetData((CTSkin)CheckThing, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case CheckThing.TypeId.MoveId:
					CTMoveNode MoveId_node_CheckThing = graph.AddNode<CTMoveNode>();
					GetPort("CheckThing").Connect(MoveId_node_CheckThing.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(MoveId_node_CheckThing, assetPath);
					variableCount += MoveId_node_CheckThing.SetData((CTMove)CheckThing, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case CheckThing.TypeId.BaseIdentifier:
					CheckThingNode BaseIdentifier_node_CheckThing = graph.AddNode<CheckThingNode>();
					GetPort("CheckThing").Connect(BaseIdentifier_node_CheckThing.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BaseIdentifier_node_CheckThing, assetPath);
					variableCount += BaseIdentifier_node_CheckThing.SetData((CheckThing)CheckThing, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
			}
			++variableCount;
			
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
				case StateAction.TypeId.BaseIdentifier:
					StateActionNode BaseIdentifier_node_Action = graph.AddNode<StateActionNode>();
					GetPort("Action").Connect(BaseIdentifier_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BaseIdentifier_node_Action, assetPath);
					variableCount += BaseIdentifier_node_Action.SetData((StateAction)Action, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
			}
			++variableCount;
			
			Else = data.Else;
			ElseAction = data.ElseAction;
			
			switch (ElseAction.TID)
			{
				case StateAction.TypeId.DebugId:
					SADebugMessageNode DebugId_node_ElseAction = graph.AddNode<SADebugMessageNode>();
					GetPort("ElseAction").Connect(DebugId_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DebugId_node_ElseAction, assetPath);
					variableCount += DebugId_node_ElseAction.SetData((SADebugMessage)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.PlayAnimId:
					SAPlayAnimNode PlayAnimId_node_ElseAction = graph.AddNode<SAPlayAnimNode>();
					GetPort("ElseAction").Connect(PlayAnimId_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(PlayAnimId_node_ElseAction, assetPath);
					variableCount += PlayAnimId_node_ElseAction.SetData((SAPlayAnim)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.RootAnimId:
					SAPlayRootAnimNode RootAnimId_node_ElseAction = graph.AddNode<SAPlayRootAnimNode>();
					GetPort("ElseAction").Connect(RootAnimId_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RootAnimId_node_ElseAction, assetPath);
					variableCount += RootAnimId_node_ElseAction.SetData((SAPlayRootAnim)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SnapAnimWeightsId:
					SASnapAnimWeightsNode SnapAnimWeightsId_node_ElseAction = graph.AddNode<SASnapAnimWeightsNode>();
					GetPort("ElseAction").Connect(SnapAnimWeightsId_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SnapAnimWeightsId_node_ElseAction, assetPath);
					variableCount += SnapAnimWeightsId_node_ElseAction.SetData((SASnapAnimWeights)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.StandardInputId:
					SAStandardInputNode StandardInputId_node_ElseAction = graph.AddNode<SAStandardInputNode>();
					GetPort("ElseAction").Connect(StandardInputId_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(StandardInputId_node_ElseAction, assetPath);
					variableCount += StandardInputId_node_ElseAction.SetData((SAStandardInput)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.InputId:
					SAInputActionNode InputId_node_ElseAction = graph.AddNode<SAInputActionNode>();
					GetPort("ElseAction").Connect(InputId_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputId_node_ElseAction, assetPath);
					variableCount += InputId_node_ElseAction.SetData((SAInputAction)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.DeactInputId:
					SADeactivateInputActionNode DeactInputId_node_ElseAction = graph.AddNode<SADeactivateInputActionNode>();
					GetPort("ElseAction").Connect(DeactInputId_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DeactInputId_node_ElseAction, assetPath);
					variableCount += DeactInputId_node_ElseAction.SetData((SADeactivateInputAction)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.InputEventFromFrameId:
					SAAddInputEventFromFrameNode InputEventFromFrameId_node_ElseAction = graph.AddNode<SAAddInputEventFromFrameNode>();
					GetPort("ElseAction").Connect(InputEventFromFrameId_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputEventFromFrameId_node_ElseAction, assetPath);
					variableCount += InputEventFromFrameId_node_ElseAction.SetData((SAAddInputEventFromFrame)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.CancelStateId:
					SACancelToStateNode CancelStateId_node_ElseAction = graph.AddNode<SACancelToStateNode>();
					GetPort("ElseAction").Connect(CancelStateId_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CancelStateId_node_ElseAction, assetPath);
					variableCount += CancelStateId_node_ElseAction.SetData((SACancelToState)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.CustomCallId:
					SACustomCallNode CustomCallId_node_ElseAction = graph.AddNode<SACustomCallNode>();
					GetPort("ElseAction").Connect(CustomCallId_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CustomCallId_node_ElseAction, assetPath);
					variableCount += CustomCallId_node_ElseAction.SetData((SACustomCall)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.TimerId:
					SATimedActionNode TimerId_node_ElseAction = graph.AddNode<SATimedActionNode>();
					GetPort("ElseAction").Connect(TimerId_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(TimerId_node_ElseAction, assetPath);
					variableCount += TimerId_node_ElseAction.SetData((SATimedAction)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.OrderId:
					SAOrderedSensitiveNode OrderId_node_ElseAction = graph.AddNode<SAOrderedSensitiveNode>();
					GetPort("ElseAction").Connect(OrderId_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OrderId_node_ElseAction, assetPath);
					variableCount += OrderId_node_ElseAction.SetData((SAOrderedSensitive)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.ProxyId:
					SAProxyMoveNode ProxyId_node_ElseAction = graph.AddNode<SAProxyMoveNode>();
					GetPort("ElseAction").Connect(ProxyId_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ProxyId_node_ElseAction, assetPath);
					variableCount += ProxyId_node_ElseAction.SetData((SAProxyMove)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.CheckId:
					SACheckThingNode CheckId_node_ElseAction = graph.AddNode<SACheckThingNode>();
					GetPort("ElseAction").Connect(CheckId_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CheckId_node_ElseAction, assetPath);
					variableCount += CheckId_node_ElseAction.SetData((SACheckThing)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.ActiveActionId:
					SAActiveActionNode ActiveActionId_node_ElseAction = graph.AddNode<SAActiveActionNode>();
					GetPort("ElseAction").Connect(ActiveActionId_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ActiveActionId_node_ElseAction, assetPath);
					variableCount += ActiveActionId_node_ElseAction.SetData((SAActiveAction)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.DeactivateActionId:
					SADeactivateActionNode DeactivateActionId_node_ElseAction = graph.AddNode<SADeactivateActionNode>();
					GetPort("ElseAction").Connect(DeactivateActionId_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DeactivateActionId_node_ElseAction, assetPath);
					variableCount += DeactivateActionId_node_ElseAction.SetData((SADeactivateAction)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SetFloatId:
					SASetFloatTargetNode SetFloatId_node_ElseAction = graph.AddNode<SASetFloatTargetNode>();
					GetPort("ElseAction").Connect(SetFloatId_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SetFloatId_node_ElseAction, assetPath);
					variableCount += SetFloatId_node_ElseAction.SetData((SASetFloatTarget)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.OnBounceId:
					SAOnBounceNode OnBounceId_node_ElseAction = graph.AddNode<SAOnBounceNode>();
					GetPort("ElseAction").Connect(OnBounceId_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnBounceId_node_ElseAction, assetPath);
					variableCount += OnBounceId_node_ElseAction.SetData((SAOnBounce)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.OnLeaveEdgeId:
					SAOnLeaveEdgeNode OnLeaveEdgeId_node_ElseAction = graph.AddNode<SAOnLeaveEdgeNode>();
					GetPort("ElseAction").Connect(OnLeaveEdgeId_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnLeaveEdgeId_node_ElseAction, assetPath);
					variableCount += OnLeaveEdgeId_node_ElseAction.SetData((SAOnLeaveEdge)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.OnStoppedAtEdgeId:
					SAOnStoppedAtLedgeNode OnStoppedAtEdgeId_node_ElseAction = graph.AddNode<SAOnStoppedAtLedgeNode>();
					GetPort("ElseAction").Connect(OnStoppedAtEdgeId_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnStoppedAtEdgeId_node_ElseAction, assetPath);
					variableCount += OnStoppedAtEdgeId_node_ElseAction.SetData((SAOnStoppedAtLedge)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.OnLandId:
					SAOnLandNode OnLandId_node_ElseAction = graph.AddNode<SAOnLandNode>();
					GetPort("ElseAction").Connect(OnLandId_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnLandId_node_ElseAction, assetPath);
					variableCount += OnLandId_node_ElseAction.SetData((SAOnLand)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.OnCancelId:
					SAOnCancelNode OnCancelId_node_ElseAction = graph.AddNode<SAOnCancelNode>();
					GetPort("ElseAction").Connect(OnCancelId_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnCancelId_node_ElseAction, assetPath);
					variableCount += OnCancelId_node_ElseAction.SetData((SAOnCancel)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.RefreshAtkId:
					SARefreshAttackNode RefreshAtkId_node_ElseAction = graph.AddNode<SARefreshAttackNode>();
					GetPort("ElseAction").Connect(RefreshAtkId_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RefreshAtkId_node_ElseAction, assetPath);
					variableCount += RefreshAtkId_node_ElseAction.SetData((SARefreshAttack)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.EndAtkId:
					SAEndAttackNode EndAtkId_node_ElseAction = graph.AddNode<SAEndAttackNode>();
					GetPort("ElseAction").Connect(EndAtkId_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EndAtkId_node_ElseAction, assetPath);
					variableCount += EndAtkId_node_ElseAction.SetData((SAEndAttack)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SetHitboxCountId:
					SASetHitboxCountNode SetHitboxCountId_node_ElseAction = graph.AddNode<SASetHitboxCountNode>();
					GetPort("ElseAction").Connect(SetHitboxCountId_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SetHitboxCountId_node_ElseAction, assetPath);
					variableCount += SetHitboxCountId_node_ElseAction.SetData((SASetHitboxCount)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.ConfigHitboxId:
					SAConfigHitboxNode ConfigHitboxId_node_ElseAction = graph.AddNode<SAConfigHitboxNode>();
					GetPort("ElseAction").Connect(ConfigHitboxId_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ConfigHitboxId_node_ElseAction, assetPath);
					variableCount += ConfigHitboxId_node_ElseAction.SetData((SAConfigHitbox)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SetAtkPropId:
					SASetAttackPropNode SetAtkPropId_node_ElseAction = graph.AddNode<SASetAttackPropNode>();
					GetPort("ElseAction").Connect(SetAtkPropId_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SetAtkPropId_node_ElseAction, assetPath);
					variableCount += SetAtkPropId_node_ElseAction.SetData((SASetAttackProp)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.ManipHitboxId:
					SAManipHitboxNode ManipHitboxId_node_ElseAction = graph.AddNode<SAManipHitboxNode>();
					GetPort("ElseAction").Connect(ManipHitboxId_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ManipHitboxId_node_ElseAction, assetPath);
					variableCount += ManipHitboxId_node_ElseAction.SetData((SAManipHitbox)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.UpdateHurtsetId:
					SAUpdateHurtboxesNode UpdateHurtsetId_node_ElseAction = graph.AddNode<SAUpdateHurtboxesNode>();
					GetPort("ElseAction").Connect(UpdateHurtsetId_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(UpdateHurtsetId_node_ElseAction, assetPath);
					variableCount += UpdateHurtsetId_node_ElseAction.SetData((SAUpdateHurtboxes)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SetupHurtsetId:
					SASetupHurtboxesNode SetupHurtsetId_node_ElseAction = graph.AddNode<SASetupHurtboxesNode>();
					GetPort("ElseAction").Connect(SetupHurtsetId_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SetupHurtsetId_node_ElseAction, assetPath);
					variableCount += SetupHurtsetId_node_ElseAction.SetData((SASetupHurtboxes)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.ManipHurtboxId:
					SAManipHurtboxNode ManipHurtboxId_node_ElseAction = graph.AddNode<SAManipHurtboxNode>();
					GetPort("ElseAction").Connect(ManipHurtboxId_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ManipHurtboxId_node_ElseAction, assetPath);
					variableCount += ManipHurtboxId_node_ElseAction.SetData((SAManipHurtbox)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.BoneStateId:
					SABoneStateNode BoneStateId_node_ElseAction = graph.AddNode<SABoneStateNode>();
					GetPort("ElseAction").Connect(BoneStateId_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BoneStateId_node_ElseAction, assetPath);
					variableCount += BoneStateId_node_ElseAction.SetData((SABoneState)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.BoneScaleId:
					SABoneScaleNode BoneScaleId_node_ElseAction = graph.AddNode<SABoneScaleNode>();
					GetPort("ElseAction").Connect(BoneScaleId_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BoneScaleId_node_ElseAction, assetPath);
					variableCount += BoneScaleId_node_ElseAction.SetData((SABoneScale)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SpawnAgentId:
					SASpawnAgentNode SpawnAgentId_node_ElseAction = graph.AddNode<SASpawnAgentNode>();
					GetPort("ElseAction").Connect(SpawnAgentId_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpawnAgentId_node_ElseAction, assetPath);
					variableCount += SpawnAgentId_node_ElseAction.SetData((SASpawnAgent)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.LocalFXId:
					SALocalFXNode LocalFXId_node_ElseAction = graph.AddNode<SALocalFXNode>();
					GetPort("ElseAction").Connect(LocalFXId_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LocalFXId_node_ElseAction, assetPath);
					variableCount += LocalFXId_node_ElseAction.SetData((SALocalFX)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SpawnFXId:
					SASpawnFXNode SpawnFXId_node_ElseAction = graph.AddNode<SASpawnFXNode>();
					GetPort("ElseAction").Connect(SpawnFXId_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpawnFXId_node_ElseAction, assetPath);
					variableCount += SpawnFXId_node_ElseAction.SetData((SASpawnFX)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.HitboxFXId:
					SASetHitboxFXNode HitboxFXId_node_ElseAction = graph.AddNode<SASetHitboxFXNode>();
					GetPort("ElseAction").Connect(HitboxFXId_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(HitboxFXId_node_ElseAction, assetPath);
					variableCount += HitboxFXId_node_ElseAction.SetData((SASetHitboxFX)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SFXId:
					SAPlaySFXNode SFXId_node_ElseAction = graph.AddNode<SAPlaySFXNode>();
					GetPort("ElseAction").Connect(SFXId_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SFXId_node_ElseAction, assetPath);
					variableCount += SFXId_node_ElseAction.SetData((SAPlaySFX)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.HitboxSFXId:
					SASetHitboxSFXNode HitboxSFXId_node_ElseAction = graph.AddNode<SASetHitboxSFXNode>();
					GetPort("ElseAction").Connect(HitboxSFXId_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(HitboxSFXId_node_ElseAction, assetPath);
					variableCount += HitboxSFXId_node_ElseAction.SetData((SASetHitboxSFX)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.ColorTintId:
					SAColorTintNode ColorTintId_node_ElseAction = graph.AddNode<SAColorTintNode>();
					GetPort("ElseAction").Connect(ColorTintId_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ColorTintId_node_ElseAction, assetPath);
					variableCount += ColorTintId_node_ElseAction.SetData((SAColorTint)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.FindFloorId:
					SAFindFloorNode FindFloorId_node_ElseAction = graph.AddNode<SAFindFloorNode>();
					GetPort("ElseAction").Connect(FindFloorId_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FindFloorId_node_ElseAction, assetPath);
					variableCount += FindFloorId_node_ElseAction.SetData((SAFindFloor)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.HurtGrabbedId:
					SAHurtGrabbedNode HurtGrabbedId_node_ElseAction = graph.AddNode<SAHurtGrabbedNode>();
					GetPort("ElseAction").Connect(HurtGrabbedId_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(HurtGrabbedId_node_ElseAction, assetPath);
					variableCount += HurtGrabbedId_node_ElseAction.SetData((SAHurtGrabbed)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.LaunchGrabbedId:
					SALaunchGrabbedNode LaunchGrabbedId_node_ElseAction = graph.AddNode<SALaunchGrabbedNode>();
					GetPort("ElseAction").Connect(LaunchGrabbedId_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LaunchGrabbedId_node_ElseAction, assetPath);
					variableCount += LaunchGrabbedId_node_ElseAction.SetData((SALaunchGrabbed)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.StateCancelGrabbedId:
					SAStateCancelGrabbedNode StateCancelGrabbedId_node_ElseAction = graph.AddNode<SAStateCancelGrabbedNode>();
					GetPort("ElseAction").Connect(StateCancelGrabbedId_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(StateCancelGrabbedId_node_ElseAction, assetPath);
					variableCount += StateCancelGrabbedId_node_ElseAction.SetData((SAStateCancelGrabbed)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.EndGrabId:
					SAEndGrabNode EndGrabId_node_ElseAction = graph.AddNode<SAEndGrabNode>();
					GetPort("ElseAction").Connect(EndGrabId_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EndGrabId_node_ElseAction, assetPath);
					variableCount += EndGrabId_node_ElseAction.SetData((SAEndGrab)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.GrabNotifyEscapeId:
					SAGrabNotifyEscapeNode GrabNotifyEscapeId_node_ElseAction = graph.AddNode<SAGrabNotifyEscapeNode>();
					GetPort("ElseAction").Connect(GrabNotifyEscapeId_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(GrabNotifyEscapeId_node_ElseAction, assetPath);
					variableCount += GrabNotifyEscapeId_node_ElseAction.SetData((SAGrabNotifyEscape)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.IgnoreGrabbedId:
					SAIgnoreGrabbedNode IgnoreGrabbedId_node_ElseAction = graph.AddNode<SAIgnoreGrabbedNode>();
					GetPort("ElseAction").Connect(IgnoreGrabbedId_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(IgnoreGrabbedId_node_ElseAction, assetPath);
					variableCount += IgnoreGrabbedId_node_ElseAction.SetData((SAIgnoreGrabbed)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.EventKOId:
					SAEventKONode EventKOId_node_ElseAction = graph.AddNode<SAEventKONode>();
					GetPort("ElseAction").Connect(EventKOId_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EventKOId_node_ElseAction, assetPath);
					variableCount += EventKOId_node_ElseAction.SetData((SAEventKO)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.EventKOGrabbedId:
					SAEventKOGrabbedNode EventKOGrabbedId_node_ElseAction = graph.AddNode<SAEventKOGrabbedNode>();
					GetPort("ElseAction").Connect(EventKOGrabbedId_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EventKOGrabbedId_node_ElseAction, assetPath);
					variableCount += EventKOGrabbedId_node_ElseAction.SetData((SAEventKOGrabbed)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.CameraShakeId:
					SACameraShakeNode CameraShakeId_node_ElseAction = graph.AddNode<SACameraShakeNode>();
					GetPort("ElseAction").Connect(CameraShakeId_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CameraShakeId_node_ElseAction, assetPath);
					variableCount += CameraShakeId_node_ElseAction.SetData((SACameraShake)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.ResetOnHitId:
					SAResetOnHitsNode ResetOnHitId_node_ElseAction = graph.AddNode<SAResetOnHitsNode>();
					GetPort("ElseAction").Connect(ResetOnHitId_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ResetOnHitId_node_ElseAction, assetPath);
					variableCount += ResetOnHitId_node_ElseAction.SetData((SAResetOnHits)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.OnHitId:
					SAOnHitNode OnHitId_node_ElseAction = graph.AddNode<SAOnHitNode>();
					GetPort("ElseAction").Connect(OnHitId_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnHitId_node_ElseAction, assetPath);
					variableCount += OnHitId_node_ElseAction.SetData((SAOnHit)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.FastForwardId:
					SAFastForwardStateNode FastForwardId_node_ElseAction = graph.AddNode<SAFastForwardStateNode>();
					GetPort("ElseAction").Connect(FastForwardId_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FastForwardId_node_ElseAction, assetPath);
					variableCount += FastForwardId_node_ElseAction.SetData((SAFastForwardState)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.TimingTweakId:
					SATimingTweakNode TimingTweakId_node_ElseAction = graph.AddNode<SATimingTweakNode>();
					GetPort("ElseAction").Connect(TimingTweakId_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(TimingTweakId_node_ElseAction, assetPath);
					variableCount += TimingTweakId_node_ElseAction.SetData((SATimingTweak)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.MapAnimId:
					SAMapAnimationNode MapAnimId_node_ElseAction = graph.AddNode<SAMapAnimationNode>();
					GetPort("ElseAction").Connect(MapAnimId_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(MapAnimId_node_ElseAction, assetPath);
					variableCount += MapAnimId_node_ElseAction.SetData((SAMapAnimation)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.AlterMoveDtId:
					SAAlterMoveDTNode AlterMoveDtId_node_ElseAction = graph.AddNode<SAAlterMoveDTNode>();
					GetPort("ElseAction").Connect(AlterMoveDtId_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AlterMoveDtId_node_ElseAction, assetPath);
					variableCount += AlterMoveDtId_node_ElseAction.SetData((SAAlterMoveDT)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.AlterMoveVelId:
					SAAlterMoveVelNode AlterMoveVelId_node_ElseAction = graph.AddNode<SAAlterMoveVelNode>();
					GetPort("ElseAction").Connect(AlterMoveVelId_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AlterMoveVelId_node_ElseAction, assetPath);
					variableCount += AlterMoveVelId_node_ElseAction.SetData((SAAlterMoveVel)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SetStagePartId:
					SASetStagePartNode SetStagePartId_node_ElseAction = graph.AddNode<SASetStagePartNode>();
					GetPort("ElseAction").Connect(SetStagePartId_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SetStagePartId_node_ElseAction, assetPath);
					variableCount += SetStagePartId_node_ElseAction.SetData((SASetStagePart)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SetStagePartsDefaultId:
					SASetStagePartsDefaultNode SetStagePartsDefaultId_node_ElseAction = graph.AddNode<SASetStagePartsDefaultNode>();
					GetPort("ElseAction").Connect(SetStagePartsDefaultId_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SetStagePartsDefaultId_node_ElseAction, assetPath);
					variableCount += SetStagePartsDefaultId_node_ElseAction.SetData((SASetStagePartsDefault)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.JumpId:
					SAJumpNode JumpId_node_ElseAction = graph.AddNode<SAJumpNode>();
					GetPort("ElseAction").Connect(JumpId_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(JumpId_node_ElseAction, assetPath);
					variableCount += JumpId_node_ElseAction.SetData((SAJump)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.StopJumpId:
					SAStopJumpNode StopJumpId_node_ElseAction = graph.AddNode<SAStopJumpNode>();
					GetPort("ElseAction").Connect(StopJumpId_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(StopJumpId_node_ElseAction, assetPath);
					variableCount += StopJumpId_node_ElseAction.SetData((SAStopJump)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.ManageAirJumpId:
					SAManageAirJumpNode ManageAirJumpId_node_ElseAction = graph.AddNode<SAManageAirJumpNode>();
					GetPort("ElseAction").Connect(ManageAirJumpId_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ManageAirJumpId_node_ElseAction, assetPath);
					variableCount += ManageAirJumpId_node_ElseAction.SetData((SAManageAirJump)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.LeaveGroundId:
					SALeaveGroundNode LeaveGroundId_node_ElseAction = graph.AddNode<SALeaveGroundNode>();
					GetPort("ElseAction").Connect(LeaveGroundId_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LeaveGroundId_node_ElseAction, assetPath);
					variableCount += LeaveGroundId_node_ElseAction.SetData((SALeaveGround)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.UnhogEdgeId:
					SAUnHogEdgeNode UnhogEdgeId_node_ElseAction = graph.AddNode<SAUnHogEdgeNode>();
					GetPort("ElseAction").Connect(UnhogEdgeId_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(UnhogEdgeId_node_ElseAction, assetPath);
					variableCount += UnhogEdgeId_node_ElseAction.SetData((SAUnHogEdge)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SFXTimelineId:
					SAPlaySFXTimelineNode SFXTimelineId_node_ElseAction = graph.AddNode<SAPlaySFXTimelineNode>();
					GetPort("ElseAction").Connect(SFXTimelineId_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SFXTimelineId_node_ElseAction, assetPath);
					variableCount += SFXTimelineId_node_ElseAction.SetData((SAPlaySFXTimeline)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.FindLastHorizontalInputId:
					SAFindLastHorizontalInputNode FindLastHorizontalInputId_node_ElseAction = graph.AddNode<SAFindLastHorizontalInputNode>();
					GetPort("ElseAction").Connect(FindLastHorizontalInputId_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FindLastHorizontalInputId_node_ElseAction, assetPath);
					variableCount += FindLastHorizontalInputId_node_ElseAction.SetData((SAFindLastHorizontalInput)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SetCommandGrab:
					SASetCommandGrabNode SetCommandGrab_node_ElseAction = graph.AddNode<SASetCommandGrabNode>();
					GetPort("ElseAction").Connect(SetCommandGrab_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SetCommandGrab_node_ElseAction, assetPath);
					variableCount += SetCommandGrab_node_ElseAction.SetData((SASetCommandGrab)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.CameraPunchId:
					SACameraPunchNode CameraPunchId_node_ElseAction = graph.AddNode<SACameraPunchNode>();
					GetPort("ElseAction").Connect(CameraPunchId_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CameraPunchId_node_ElseAction, assetPath);
					variableCount += CameraPunchId_node_ElseAction.SetData((SACameraPunch)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SpawnAgent2Id:
					SASpawnAgent2Node SpawnAgent2Id_node_ElseAction = graph.AddNode<SASpawnAgent2Node>();
					GetPort("ElseAction").Connect(SpawnAgent2Id_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpawnAgent2Id_node_ElseAction, assetPath);
					variableCount += SpawnAgent2Id_node_ElseAction.SetData((SASpawnAgent2)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.ManipDecorChainId:
					SAManipDecorChainNode ManipDecorChainId_node_ElseAction = graph.AddNode<SAManipDecorChainNode>();
					GetPort("ElseAction").Connect(ManipDecorChainId_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ManipDecorChainId_node_ElseAction, assetPath);
					variableCount += ManipDecorChainId_node_ElseAction.SetData((SAManipDecorChain)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.UpdateHitboxesId:
					SAUpdateHitboxesNode UpdateHitboxesId_node_ElseAction = graph.AddNode<SAUpdateHitboxesNode>();
					GetPort("ElseAction").Connect(UpdateHitboxesId_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(UpdateHitboxesId_node_ElseAction, assetPath);
					variableCount += UpdateHitboxesId_node_ElseAction.SetData((SAUpdateHitboxes)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SampleAnimId:
					SASampleAnimNode SampleAnimId_node_ElseAction = graph.AddNode<SASampleAnimNode>();
					GetPort("ElseAction").Connect(SampleAnimId_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SampleAnimId_node_ElseAction, assetPath);
					variableCount += SampleAnimId_node_ElseAction.SetData((SASampleAnim)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.ForceExtraInputId:
					SAForceExtraInputCheckNode ForceExtraInputId_node_ElseAction = graph.AddNode<SAForceExtraInputCheckNode>();
					GetPort("ElseAction").Connect(ForceExtraInputId_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ForceExtraInputId_node_ElseAction, assetPath);
					variableCount += ForceExtraInputId_node_ElseAction.SetData((SAForceExtraInputCheck)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.LaunchGrabbedCustomId:
					SALaunchGrabbedCustomNode LaunchGrabbedCustomId_node_ElseAction = graph.AddNode<SALaunchGrabbedCustomNode>();
					GetPort("ElseAction").Connect(LaunchGrabbedCustomId_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LaunchGrabbedCustomId_node_ElseAction, assetPath);
					variableCount += LaunchGrabbedCustomId_node_ElseAction.SetData((SALaunchGrabbedCustom)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.BaseIdentifier:
					StateActionNode BaseIdentifier_node_ElseAction = graph.AddNode<StateActionNode>();
					GetPort("ElseAction").Connect(BaseIdentifier_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BaseIdentifier_node_ElseAction, assetPath);
					variableCount += BaseIdentifier_node_ElseAction.SetData((StateAction)ElseAction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
			}
			
			return variableCount;
		}
		
		public new SACheckThing GetData()
		{
			SACheckThing objToReturn = new SACheckThing();
			objToReturn.TID = TypeId.CheckId;
			objToReturn.Version = Version;
			if (GetPort("CheckThing").ConnectionCount > 0)
			{
				CheckThingNode CheckThing_Node = (CheckThingNode)GetPort("CheckThing").GetConnection(0).node;
				switch (CheckThing_Node.TID)
				{
					case CheckThing.TypeId.MultipleId:
						CTMultipleNode MultipleId_CheckThing_Node = (CTMultipleNode)GetPort("CheckThing").GetConnection(0).node;
						objToReturn.CheckThing = MultipleId_CheckThing_Node.GetData();
					break;
					case CheckThing.TypeId.CompareId:
						CTCompareFloatNode CompareId_CheckThing_Node = (CTCompareFloatNode)GetPort("CheckThing").GetConnection(0).node;
						objToReturn.CheckThing = CompareId_CheckThing_Node.GetData();
					break;
					case CheckThing.TypeId.DoubleTapId:
						CTDoubleTapIdNode DoubleTapId_CheckThing_Node = (CTDoubleTapIdNode)GetPort("CheckThing").GetConnection(0).node;
						objToReturn.CheckThing = DoubleTapId_CheckThing_Node.GetData();
					break;
					case CheckThing.TypeId.InputId:
						CTInputNode InputId_CheckThing_Node = (CTInputNode)GetPort("CheckThing").GetConnection(0).node;
						objToReturn.CheckThing = InputId_CheckThing_Node.GetData();
					break;
					case CheckThing.TypeId.InputSeriesId:
						CTInputSeriesNode InputSeriesId_CheckThing_Node = (CTInputSeriesNode)GetPort("CheckThing").GetConnection(0).node;
						objToReturn.CheckThing = InputSeriesId_CheckThing_Node.GetData();
					break;
					case CheckThing.TypeId.TechId:
						CTCheckTechNode TechId_CheckThing_Node = (CTCheckTechNode)GetPort("CheckThing").GetConnection(0).node;
						objToReturn.CheckThing = TechId_CheckThing_Node.GetData();
					break;
					case CheckThing.TypeId.GrabId:
						CTGrabIdNode GrabId_CheckThing_Node = (CTGrabIdNode)GetPort("CheckThing").GetConnection(0).node;
						objToReturn.CheckThing = GrabId_CheckThing_Node.GetData();
					break;
					case CheckThing.TypeId.GrabAgentId:
						CTGrabbedAgentNode GrabAgentId_CheckThing_Node = (CTGrabbedAgentNode)GetPort("CheckThing").GetConnection(0).node;
						objToReturn.CheckThing = GrabAgentId_CheckThing_Node.GetData();
					break;
					case CheckThing.TypeId.SkinId:
						CTSkinNode SkinId_CheckThing_Node = (CTSkinNode)GetPort("CheckThing").GetConnection(0).node;
						objToReturn.CheckThing = SkinId_CheckThing_Node.GetData();
					break;
					case CheckThing.TypeId.MoveId:
						CTMoveNode MoveId_CheckThing_Node = (CTMoveNode)GetPort("CheckThing").GetConnection(0).node;
						objToReturn.CheckThing = MoveId_CheckThing_Node.GetData();
					break;
					case CheckThing.TypeId.BaseIdentifier:
						CheckThingNode BaseIdentifier_CheckThing_Node = (CheckThingNode)GetPort("CheckThing").GetConnection(0).node;
						objToReturn.CheckThing = BaseIdentifier_CheckThing_Node.GetData();
					break;
				}
			}
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
					case StateAction.TypeId.BaseIdentifier:
						StateActionNode BaseIdentifier_StateAction_Node = (StateActionNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = BaseIdentifier_StateAction_Node.GetData();
					break;
				}
			}
			objToReturn.Else = Else;
			if (GetPort("ElseAction").ConnectionCount > 0)
			{
				StateActionNode StateAction_Node = (StateActionNode)GetPort("ElseAction").GetConnection(0).node;
				switch (StateAction_Node.TID)
				{
					case StateAction.TypeId.DebugId:
						SADebugMessageNode DebugId_StateAction_Node = (SADebugMessageNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = DebugId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.PlayAnimId:
						SAPlayAnimNode PlayAnimId_StateAction_Node = (SAPlayAnimNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = PlayAnimId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.RootAnimId:
						SAPlayRootAnimNode RootAnimId_StateAction_Node = (SAPlayRootAnimNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = RootAnimId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SnapAnimWeightsId:
						SASnapAnimWeightsNode SnapAnimWeightsId_StateAction_Node = (SASnapAnimWeightsNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SnapAnimWeightsId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.StandardInputId:
						SAStandardInputNode StandardInputId_StateAction_Node = (SAStandardInputNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = StandardInputId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.InputId:
						SAInputActionNode InputId_StateAction_Node = (SAInputActionNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = InputId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.DeactInputId:
						SADeactivateInputActionNode DeactInputId_StateAction_Node = (SADeactivateInputActionNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = DeactInputId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.InputEventFromFrameId:
						SAAddInputEventFromFrameNode InputEventFromFrameId_StateAction_Node = (SAAddInputEventFromFrameNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = InputEventFromFrameId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.CancelStateId:
						SACancelToStateNode CancelStateId_StateAction_Node = (SACancelToStateNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = CancelStateId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.CustomCallId:
						SACustomCallNode CustomCallId_StateAction_Node = (SACustomCallNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = CustomCallId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.TimerId:
						SATimedActionNode TimerId_StateAction_Node = (SATimedActionNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = TimerId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.OrderId:
						SAOrderedSensitiveNode OrderId_StateAction_Node = (SAOrderedSensitiveNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = OrderId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.ProxyId:
						SAProxyMoveNode ProxyId_StateAction_Node = (SAProxyMoveNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = ProxyId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.CheckId:
						SACheckThingNode CheckId_StateAction_Node = (SACheckThingNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = CheckId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.ActiveActionId:
						SAActiveActionNode ActiveActionId_StateAction_Node = (SAActiveActionNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = ActiveActionId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.DeactivateActionId:
						SADeactivateActionNode DeactivateActionId_StateAction_Node = (SADeactivateActionNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = DeactivateActionId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SetFloatId:
						SASetFloatTargetNode SetFloatId_StateAction_Node = (SASetFloatTargetNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SetFloatId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.OnBounceId:
						SAOnBounceNode OnBounceId_StateAction_Node = (SAOnBounceNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = OnBounceId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.OnLeaveEdgeId:
						SAOnLeaveEdgeNode OnLeaveEdgeId_StateAction_Node = (SAOnLeaveEdgeNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = OnLeaveEdgeId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.OnStoppedAtEdgeId:
						SAOnStoppedAtLedgeNode OnStoppedAtEdgeId_StateAction_Node = (SAOnStoppedAtLedgeNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = OnStoppedAtEdgeId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.OnLandId:
						SAOnLandNode OnLandId_StateAction_Node = (SAOnLandNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = OnLandId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.OnCancelId:
						SAOnCancelNode OnCancelId_StateAction_Node = (SAOnCancelNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = OnCancelId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.RefreshAtkId:
						SARefreshAttackNode RefreshAtkId_StateAction_Node = (SARefreshAttackNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = RefreshAtkId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.EndAtkId:
						SAEndAttackNode EndAtkId_StateAction_Node = (SAEndAttackNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = EndAtkId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SetHitboxCountId:
						SASetHitboxCountNode SetHitboxCountId_StateAction_Node = (SASetHitboxCountNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SetHitboxCountId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.ConfigHitboxId:
						SAConfigHitboxNode ConfigHitboxId_StateAction_Node = (SAConfigHitboxNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = ConfigHitboxId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SetAtkPropId:
						SASetAttackPropNode SetAtkPropId_StateAction_Node = (SASetAttackPropNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SetAtkPropId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.ManipHitboxId:
						SAManipHitboxNode ManipHitboxId_StateAction_Node = (SAManipHitboxNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = ManipHitboxId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.UpdateHurtsetId:
						SAUpdateHurtboxesNode UpdateHurtsetId_StateAction_Node = (SAUpdateHurtboxesNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = UpdateHurtsetId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SetupHurtsetId:
						SASetupHurtboxesNode SetupHurtsetId_StateAction_Node = (SASetupHurtboxesNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SetupHurtsetId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.ManipHurtboxId:
						SAManipHurtboxNode ManipHurtboxId_StateAction_Node = (SAManipHurtboxNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = ManipHurtboxId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.BoneStateId:
						SABoneStateNode BoneStateId_StateAction_Node = (SABoneStateNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = BoneStateId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.BoneScaleId:
						SABoneScaleNode BoneScaleId_StateAction_Node = (SABoneScaleNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = BoneScaleId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SpawnAgentId:
						SASpawnAgentNode SpawnAgentId_StateAction_Node = (SASpawnAgentNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SpawnAgentId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.LocalFXId:
						SALocalFXNode LocalFXId_StateAction_Node = (SALocalFXNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = LocalFXId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SpawnFXId:
						SASpawnFXNode SpawnFXId_StateAction_Node = (SASpawnFXNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SpawnFXId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.HitboxFXId:
						SASetHitboxFXNode HitboxFXId_StateAction_Node = (SASetHitboxFXNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = HitboxFXId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SFXId:
						SAPlaySFXNode SFXId_StateAction_Node = (SAPlaySFXNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SFXId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.HitboxSFXId:
						SASetHitboxSFXNode HitboxSFXId_StateAction_Node = (SASetHitboxSFXNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = HitboxSFXId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.ColorTintId:
						SAColorTintNode ColorTintId_StateAction_Node = (SAColorTintNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = ColorTintId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.FindFloorId:
						SAFindFloorNode FindFloorId_StateAction_Node = (SAFindFloorNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = FindFloorId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.HurtGrabbedId:
						SAHurtGrabbedNode HurtGrabbedId_StateAction_Node = (SAHurtGrabbedNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = HurtGrabbedId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.LaunchGrabbedId:
						SALaunchGrabbedNode LaunchGrabbedId_StateAction_Node = (SALaunchGrabbedNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = LaunchGrabbedId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.StateCancelGrabbedId:
						SAStateCancelGrabbedNode StateCancelGrabbedId_StateAction_Node = (SAStateCancelGrabbedNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = StateCancelGrabbedId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.EndGrabId:
						SAEndGrabNode EndGrabId_StateAction_Node = (SAEndGrabNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = EndGrabId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.GrabNotifyEscapeId:
						SAGrabNotifyEscapeNode GrabNotifyEscapeId_StateAction_Node = (SAGrabNotifyEscapeNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = GrabNotifyEscapeId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.IgnoreGrabbedId:
						SAIgnoreGrabbedNode IgnoreGrabbedId_StateAction_Node = (SAIgnoreGrabbedNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = IgnoreGrabbedId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.EventKOId:
						SAEventKONode EventKOId_StateAction_Node = (SAEventKONode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = EventKOId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.EventKOGrabbedId:
						SAEventKOGrabbedNode EventKOGrabbedId_StateAction_Node = (SAEventKOGrabbedNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = EventKOGrabbedId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.CameraShakeId:
						SACameraShakeNode CameraShakeId_StateAction_Node = (SACameraShakeNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = CameraShakeId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.ResetOnHitId:
						SAResetOnHitsNode ResetOnHitId_StateAction_Node = (SAResetOnHitsNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = ResetOnHitId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.OnHitId:
						SAOnHitNode OnHitId_StateAction_Node = (SAOnHitNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = OnHitId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.FastForwardId:
						SAFastForwardStateNode FastForwardId_StateAction_Node = (SAFastForwardStateNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = FastForwardId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.TimingTweakId:
						SATimingTweakNode TimingTweakId_StateAction_Node = (SATimingTweakNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = TimingTweakId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.MapAnimId:
						SAMapAnimationNode MapAnimId_StateAction_Node = (SAMapAnimationNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = MapAnimId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.AlterMoveDtId:
						SAAlterMoveDTNode AlterMoveDtId_StateAction_Node = (SAAlterMoveDTNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = AlterMoveDtId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.AlterMoveVelId:
						SAAlterMoveVelNode AlterMoveVelId_StateAction_Node = (SAAlterMoveVelNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = AlterMoveVelId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SetStagePartId:
						SASetStagePartNode SetStagePartId_StateAction_Node = (SASetStagePartNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SetStagePartId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SetStagePartsDefaultId:
						SASetStagePartsDefaultNode SetStagePartsDefaultId_StateAction_Node = (SASetStagePartsDefaultNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SetStagePartsDefaultId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.JumpId:
						SAJumpNode JumpId_StateAction_Node = (SAJumpNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = JumpId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.StopJumpId:
						SAStopJumpNode StopJumpId_StateAction_Node = (SAStopJumpNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = StopJumpId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.ManageAirJumpId:
						SAManageAirJumpNode ManageAirJumpId_StateAction_Node = (SAManageAirJumpNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = ManageAirJumpId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.LeaveGroundId:
						SALeaveGroundNode LeaveGroundId_StateAction_Node = (SALeaveGroundNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = LeaveGroundId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.UnhogEdgeId:
						SAUnHogEdgeNode UnhogEdgeId_StateAction_Node = (SAUnHogEdgeNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = UnhogEdgeId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SFXTimelineId:
						SAPlaySFXTimelineNode SFXTimelineId_StateAction_Node = (SAPlaySFXTimelineNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SFXTimelineId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.FindLastHorizontalInputId:
						SAFindLastHorizontalInputNode FindLastHorizontalInputId_StateAction_Node = (SAFindLastHorizontalInputNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = FindLastHorizontalInputId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SetCommandGrab:
						SASetCommandGrabNode SetCommandGrab_StateAction_Node = (SASetCommandGrabNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SetCommandGrab_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.CameraPunchId:
						SACameraPunchNode CameraPunchId_StateAction_Node = (SACameraPunchNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = CameraPunchId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SpawnAgent2Id:
						SASpawnAgent2Node SpawnAgent2Id_StateAction_Node = (SASpawnAgent2Node)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SpawnAgent2Id_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.ManipDecorChainId:
						SAManipDecorChainNode ManipDecorChainId_StateAction_Node = (SAManipDecorChainNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = ManipDecorChainId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.UpdateHitboxesId:
						SAUpdateHitboxesNode UpdateHitboxesId_StateAction_Node = (SAUpdateHitboxesNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = UpdateHitboxesId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SampleAnimId:
						SASampleAnimNode SampleAnimId_StateAction_Node = (SASampleAnimNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SampleAnimId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.ForceExtraInputId:
						SAForceExtraInputCheckNode ForceExtraInputId_StateAction_Node = (SAForceExtraInputCheckNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = ForceExtraInputId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.LaunchGrabbedCustomId:
						SALaunchGrabbedCustomNode LaunchGrabbedCustomId_StateAction_Node = (SALaunchGrabbedCustomNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = LaunchGrabbedCustomId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.BaseIdentifier:
						StateActionNode BaseIdentifier_StateAction_Node = (StateActionNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = BaseIdentifier_StateAction_Node.GetData();
					break;
				}
			}
			return objToReturn;
		}
	}
}

