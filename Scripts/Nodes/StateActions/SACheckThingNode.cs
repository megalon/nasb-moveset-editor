// * 
// * 
// * This file was generated using NASB_Parser_to_xNode by megalon2d
// * https://github.com/megalon/NASB_Parser_to_xNode
// * 
// * 
using MovesetParser.BulkSerialize;
using MovesetParser.CheckThings;
using UnityEngine;
using UnityEditor;
using XNode;
using XNodeEditor;
using MovesetParser;
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
using static MovesetParser.StateActions.StateAction;

namespace NASB_Moveset_Editor.StateActions
{
	public class SACheckThingNode : StateActionNode
	{
		[Input(connectionType = ConnectionType.Override)] public StateAction NodeInput;
		[Output(connectionType = ConnectionType.Override)] public CheckThing CheckThing;
		[Output(connectionType = ConnectionType.Override)] public StateAction Action;
		public bool Else;
		[Output(connectionType = ConnectionType.Override)] public StateAction ElseAction;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.SACheckThing;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SACheckThing data, MovesetGraph graph, string assetPath, UnityEngine.Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SACheckThing));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			CheckThing = data.CheckThing;
			
			switch (CheckThing.TID)
			{
				case CheckThing.TypeId.CheckThing:
					CheckThingNode CheckThing_node_CheckThing = graph.AddNode<CheckThingNode>();
					GetPort("CheckThing").Connect(CheckThing_node_CheckThing.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CheckThing_node_CheckThing, assetPath);
					variableCount += CheckThing_node_CheckThing.SetData((CheckThing)CheckThing, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case CheckThing.TypeId.CTMultiple:
					CTMultipleNode CTMultiple_node_CheckThing = graph.AddNode<CTMultipleNode>();
					GetPort("CheckThing").Connect(CTMultiple_node_CheckThing.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CTMultiple_node_CheckThing, assetPath);
					variableCount += CTMultiple_node_CheckThing.SetData((CTMultiple)CheckThing, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case CheckThing.TypeId.CTCompareFloat:
					CTCompareFloatNode CTCompareFloat_node_CheckThing = graph.AddNode<CTCompareFloatNode>();
					GetPort("CheckThing").Connect(CTCompareFloat_node_CheckThing.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CTCompareFloat_node_CheckThing, assetPath);
					variableCount += CTCompareFloat_node_CheckThing.SetData((CTCompareFloat)CheckThing, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case CheckThing.TypeId.CTDoubleTap:
					CTDoubleTapNode CTDoubleTap_node_CheckThing = graph.AddNode<CTDoubleTapNode>();
					GetPort("CheckThing").Connect(CTDoubleTap_node_CheckThing.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CTDoubleTap_node_CheckThing, assetPath);
					variableCount += CTDoubleTap_node_CheckThing.SetData((CTDoubleTap)CheckThing, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case CheckThing.TypeId.CTInput:
					CTInputNode CTInput_node_CheckThing = graph.AddNode<CTInputNode>();
					GetPort("CheckThing").Connect(CTInput_node_CheckThing.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CTInput_node_CheckThing, assetPath);
					variableCount += CTInput_node_CheckThing.SetData((CTInput)CheckThing, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case CheckThing.TypeId.CTInputSeries:
					CTInputSeriesNode CTInputSeries_node_CheckThing = graph.AddNode<CTInputSeriesNode>();
					GetPort("CheckThing").Connect(CTInputSeries_node_CheckThing.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CTInputSeries_node_CheckThing, assetPath);
					variableCount += CTInputSeries_node_CheckThing.SetData((CTInputSeries)CheckThing, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case CheckThing.TypeId.CTCheckTech:
					CTCheckTechNode CTCheckTech_node_CheckThing = graph.AddNode<CTCheckTechNode>();
					GetPort("CheckThing").Connect(CTCheckTech_node_CheckThing.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CTCheckTech_node_CheckThing, assetPath);
					variableCount += CTCheckTech_node_CheckThing.SetData((CTCheckTech)CheckThing, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case CheckThing.TypeId.CTGrab:
					CTGrabNode CTGrab_node_CheckThing = graph.AddNode<CTGrabNode>();
					GetPort("CheckThing").Connect(CTGrab_node_CheckThing.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CTGrab_node_CheckThing, assetPath);
					variableCount += CTGrab_node_CheckThing.SetData((CTGrab)CheckThing, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case CheckThing.TypeId.CTGrabbedAgent:
					CTGrabbedAgentNode CTGrabbedAgent_node_CheckThing = graph.AddNode<CTGrabbedAgentNode>();
					GetPort("CheckThing").Connect(CTGrabbedAgent_node_CheckThing.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CTGrabbedAgent_node_CheckThing, assetPath);
					variableCount += CTGrabbedAgent_node_CheckThing.SetData((CTGrabbedAgent)CheckThing, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case CheckThing.TypeId.CTSkin:
					CTSkinNode CTSkin_node_CheckThing = graph.AddNode<CTSkinNode>();
					GetPort("CheckThing").Connect(CTSkin_node_CheckThing.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CTSkin_node_CheckThing, assetPath);
					variableCount += CTSkin_node_CheckThing.SetData((CTSkin)CheckThing, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case CheckThing.TypeId.CTMove:
					CTMoveNode CTMove_node_CheckThing = graph.AddNode<CTMoveNode>();
					GetPort("CheckThing").Connect(CTMove_node_CheckThing.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CTMove_node_CheckThing, assetPath);
					variableCount += CTMove_node_CheckThing.SetData((CTMove)CheckThing, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
			}
			++variableCount;
			
			Action = data.Action;
			
			switch (Action.TID)
			{
				case StateAction.TypeId.StateAction:
					StateActionNode StateAction_node_Action = graph.AddNode<StateActionNode>();
					GetPort("Action").Connect(StateAction_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(StateAction_node_Action, assetPath);
					variableCount += StateAction_node_Action.SetData((StateAction)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SADebugMessage:
					SADebugMessageNode SADebugMessage_node_Action = graph.AddNode<SADebugMessageNode>();
					GetPort("Action").Connect(SADebugMessage_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SADebugMessage_node_Action, assetPath);
					variableCount += SADebugMessage_node_Action.SetData((SADebugMessage)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAPlayAnim:
					SAPlayAnimNode SAPlayAnim_node_Action = graph.AddNode<SAPlayAnimNode>();
					GetPort("Action").Connect(SAPlayAnim_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAPlayAnim_node_Action, assetPath);
					variableCount += SAPlayAnim_node_Action.SetData((SAPlayAnim)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAPlayRootAnim:
					SAPlayRootAnimNode SAPlayRootAnim_node_Action = graph.AddNode<SAPlayRootAnimNode>();
					GetPort("Action").Connect(SAPlayRootAnim_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAPlayRootAnim_node_Action, assetPath);
					variableCount += SAPlayRootAnim_node_Action.SetData((SAPlayRootAnim)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SASnapAnimWeights:
					SASnapAnimWeightsNode SASnapAnimWeights_node_Action = graph.AddNode<SASnapAnimWeightsNode>();
					GetPort("Action").Connect(SASnapAnimWeights_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SASnapAnimWeights_node_Action, assetPath);
					variableCount += SASnapAnimWeights_node_Action.SetData((SASnapAnimWeights)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAStandardInput:
					SAStandardInputNode SAStandardInput_node_Action = graph.AddNode<SAStandardInputNode>();
					GetPort("Action").Connect(SAStandardInput_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAStandardInput_node_Action, assetPath);
					variableCount += SAStandardInput_node_Action.SetData((SAStandardInput)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAInputAction:
					SAInputActionNode SAInputAction_node_Action = graph.AddNode<SAInputActionNode>();
					GetPort("Action").Connect(SAInputAction_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAInputAction_node_Action, assetPath);
					variableCount += SAInputAction_node_Action.SetData((SAInputAction)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SADeactivateInputAction:
					SADeactivateInputActionNode SADeactivateInputAction_node_Action = graph.AddNode<SADeactivateInputActionNode>();
					GetPort("Action").Connect(SADeactivateInputAction_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SADeactivateInputAction_node_Action, assetPath);
					variableCount += SADeactivateInputAction_node_Action.SetData((SADeactivateInputAction)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAAddInputEventFromFrame:
					SAAddInputEventFromFrameNode SAAddInputEventFromFrame_node_Action = graph.AddNode<SAAddInputEventFromFrameNode>();
					GetPort("Action").Connect(SAAddInputEventFromFrame_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAAddInputEventFromFrame_node_Action, assetPath);
					variableCount += SAAddInputEventFromFrame_node_Action.SetData((SAAddInputEventFromFrame)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SACancelToState:
					SACancelToStateNode SACancelToState_node_Action = graph.AddNode<SACancelToStateNode>();
					GetPort("Action").Connect(SACancelToState_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SACancelToState_node_Action, assetPath);
					variableCount += SACancelToState_node_Action.SetData((SACancelToState)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SACustomCall:
					SACustomCallNode SACustomCall_node_Action = graph.AddNode<SACustomCallNode>();
					GetPort("Action").Connect(SACustomCall_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SACustomCall_node_Action, assetPath);
					variableCount += SACustomCall_node_Action.SetData((SACustomCall)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SATimedAction:
					SATimedActionNode SATimedAction_node_Action = graph.AddNode<SATimedActionNode>();
					GetPort("Action").Connect(SATimedAction_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SATimedAction_node_Action, assetPath);
					variableCount += SATimedAction_node_Action.SetData((SATimedAction)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAOrderSensitive:
					SAOrderSensitiveNode SAOrderSensitive_node_Action = graph.AddNode<SAOrderSensitiveNode>();
					GetPort("Action").Connect(SAOrderSensitive_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAOrderSensitive_node_Action, assetPath);
					variableCount += SAOrderSensitive_node_Action.SetData((SAOrderSensitive)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAProxyMove:
					SAProxyMoveNode SAProxyMove_node_Action = graph.AddNode<SAProxyMoveNode>();
					GetPort("Action").Connect(SAProxyMove_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAProxyMove_node_Action, assetPath);
					variableCount += SAProxyMove_node_Action.SetData((SAProxyMove)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SACheckThing:
					SACheckThingNode SACheckThing_node_Action = graph.AddNode<SACheckThingNode>();
					GetPort("Action").Connect(SACheckThing_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SACheckThing_node_Action, assetPath);
					variableCount += SACheckThing_node_Action.SetData((SACheckThing)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAActiveAction:
					SAActiveActionNode SAActiveAction_node_Action = graph.AddNode<SAActiveActionNode>();
					GetPort("Action").Connect(SAActiveAction_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAActiveAction_node_Action, assetPath);
					variableCount += SAActiveAction_node_Action.SetData((SAActiveAction)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SADeactivateAction:
					SADeactivateActionNode SADeactivateAction_node_Action = graph.AddNode<SADeactivateActionNode>();
					GetPort("Action").Connect(SADeactivateAction_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SADeactivateAction_node_Action, assetPath);
					variableCount += SADeactivateAction_node_Action.SetData((SADeactivateAction)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SASetFloatTarget:
					SASetFloatTargetNode SASetFloatTarget_node_Action = graph.AddNode<SASetFloatTargetNode>();
					GetPort("Action").Connect(SASetFloatTarget_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SASetFloatTarget_node_Action, assetPath);
					variableCount += SASetFloatTarget_node_Action.SetData((SASetFloatTarget)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAOnBounce:
					SAOnBounceNode SAOnBounce_node_Action = graph.AddNode<SAOnBounceNode>();
					GetPort("Action").Connect(SAOnBounce_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAOnBounce_node_Action, assetPath);
					variableCount += SAOnBounce_node_Action.SetData((SAOnBounce)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAOnLeaveEdge:
					SAOnLeaveEdgeNode SAOnLeaveEdge_node_Action = graph.AddNode<SAOnLeaveEdgeNode>();
					GetPort("Action").Connect(SAOnLeaveEdge_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAOnLeaveEdge_node_Action, assetPath);
					variableCount += SAOnLeaveEdge_node_Action.SetData((SAOnLeaveEdge)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAOnStoppedAtEdge:
					SAOnStoppedAtEdgeNode SAOnStoppedAtEdge_node_Action = graph.AddNode<SAOnStoppedAtEdgeNode>();
					GetPort("Action").Connect(SAOnStoppedAtEdge_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAOnStoppedAtEdge_node_Action, assetPath);
					variableCount += SAOnStoppedAtEdge_node_Action.SetData((SAOnStoppedAtEdge)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAOnLand:
					SAOnLandNode SAOnLand_node_Action = graph.AddNode<SAOnLandNode>();
					GetPort("Action").Connect(SAOnLand_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAOnLand_node_Action, assetPath);
					variableCount += SAOnLand_node_Action.SetData((SAOnLand)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAOnCancel:
					SAOnCancelNode SAOnCancel_node_Action = graph.AddNode<SAOnCancelNode>();
					GetPort("Action").Connect(SAOnCancel_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAOnCancel_node_Action, assetPath);
					variableCount += SAOnCancel_node_Action.SetData((SAOnCancel)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SARefreshAttack:
					SARefreshAttackNode SARefreshAttack_node_Action = graph.AddNode<SARefreshAttackNode>();
					GetPort("Action").Connect(SARefreshAttack_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SARefreshAttack_node_Action, assetPath);
					variableCount += SARefreshAttack_node_Action.SetData((SARefreshAttack)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAEndAttack:
					SAEndAttackNode SAEndAttack_node_Action = graph.AddNode<SAEndAttackNode>();
					GetPort("Action").Connect(SAEndAttack_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAEndAttack_node_Action, assetPath);
					variableCount += SAEndAttack_node_Action.SetData((SAEndAttack)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SASetHitboxCount:
					SASetHitboxCountNode SASetHitboxCount_node_Action = graph.AddNode<SASetHitboxCountNode>();
					GetPort("Action").Connect(SASetHitboxCount_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SASetHitboxCount_node_Action, assetPath);
					variableCount += SASetHitboxCount_node_Action.SetData((SASetHitboxCount)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAConfigHitbox:
					SAConfigHitboxNode SAConfigHitbox_node_Action = graph.AddNode<SAConfigHitboxNode>();
					GetPort("Action").Connect(SAConfigHitbox_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAConfigHitbox_node_Action, assetPath);
					variableCount += SAConfigHitbox_node_Action.SetData((SAConfigHitbox)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SASetAtkProp:
					SASetAtkPropNode SASetAtkProp_node_Action = graph.AddNode<SASetAtkPropNode>();
					GetPort("Action").Connect(SASetAtkProp_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SASetAtkProp_node_Action, assetPath);
					variableCount += SASetAtkProp_node_Action.SetData((SASetAtkProp)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAManipHitBox:
					SAManipHitBoxNode SAManipHitBox_node_Action = graph.AddNode<SAManipHitBoxNode>();
					GetPort("Action").Connect(SAManipHitBox_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAManipHitBox_node_Action, assetPath);
					variableCount += SAManipHitBox_node_Action.SetData((SAManipHitBox)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAUpdateHurtboxes:
					SAUpdateHurtboxesNode SAUpdateHurtboxes_node_Action = graph.AddNode<SAUpdateHurtboxesNode>();
					GetPort("Action").Connect(SAUpdateHurtboxes_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAUpdateHurtboxes_node_Action, assetPath);
					variableCount += SAUpdateHurtboxes_node_Action.SetData((SAUpdateHurtboxes)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SASetupHurtboxes:
					SASetupHurtboxesNode SASetupHurtboxes_node_Action = graph.AddNode<SASetupHurtboxesNode>();
					GetPort("Action").Connect(SASetupHurtboxes_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SASetupHurtboxes_node_Action, assetPath);
					variableCount += SASetupHurtboxes_node_Action.SetData((SASetupHurtboxes)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAManipHurtBox:
					SAManipHurtBoxNode SAManipHurtBox_node_Action = graph.AddNode<SAManipHurtBoxNode>();
					GetPort("Action").Connect(SAManipHurtBox_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAManipHurtBox_node_Action, assetPath);
					variableCount += SAManipHurtBox_node_Action.SetData((SAManipHurtBox)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SABoneState:
					SABoneStateNode SABoneState_node_Action = graph.AddNode<SABoneStateNode>();
					GetPort("Action").Connect(SABoneState_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SABoneState_node_Action, assetPath);
					variableCount += SABoneState_node_Action.SetData((SABoneState)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SABoneScale:
					SABoneScaleNode SABoneScale_node_Action = graph.AddNode<SABoneScaleNode>();
					GetPort("Action").Connect(SABoneScale_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SABoneScale_node_Action, assetPath);
					variableCount += SABoneScale_node_Action.SetData((SABoneScale)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SASpawnAgent:
					SASpawnAgentNode SASpawnAgent_node_Action = graph.AddNode<SASpawnAgentNode>();
					GetPort("Action").Connect(SASpawnAgent_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SASpawnAgent_node_Action, assetPath);
					variableCount += SASpawnAgent_node_Action.SetData((SASpawnAgent)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SALocalFX:
					SALocalFXNode SALocalFX_node_Action = graph.AddNode<SALocalFXNode>();
					GetPort("Action").Connect(SALocalFX_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SALocalFX_node_Action, assetPath);
					variableCount += SALocalFX_node_Action.SetData((SALocalFX)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SASpawnFX:
					SASpawnFXNode SASpawnFX_node_Action = graph.AddNode<SASpawnFXNode>();
					GetPort("Action").Connect(SASpawnFX_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SASpawnFX_node_Action, assetPath);
					variableCount += SASpawnFX_node_Action.SetData((SASpawnFX)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SASetHitboxFX:
					SASetHitboxFXNode SASetHitboxFX_node_Action = graph.AddNode<SASetHitboxFXNode>();
					GetPort("Action").Connect(SASetHitboxFX_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SASetHitboxFX_node_Action, assetPath);
					variableCount += SASetHitboxFX_node_Action.SetData((SASetHitboxFX)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAPlaySFX:
					SAPlaySFXNode SAPlaySFX_node_Action = graph.AddNode<SAPlaySFXNode>();
					GetPort("Action").Connect(SAPlaySFX_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAPlaySFX_node_Action, assetPath);
					variableCount += SAPlaySFX_node_Action.SetData((SAPlaySFX)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SASetHitboxSFX:
					SASetHitboxSFXNode SASetHitboxSFX_node_Action = graph.AddNode<SASetHitboxSFXNode>();
					GetPort("Action").Connect(SASetHitboxSFX_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SASetHitboxSFX_node_Action, assetPath);
					variableCount += SASetHitboxSFX_node_Action.SetData((SASetHitboxSFX)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAColorTint:
					SAColorTintNode SAColorTint_node_Action = graph.AddNode<SAColorTintNode>();
					GetPort("Action").Connect(SAColorTint_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAColorTint_node_Action, assetPath);
					variableCount += SAColorTint_node_Action.SetData((SAColorTint)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAFindFloor:
					SAFindFloorNode SAFindFloor_node_Action = graph.AddNode<SAFindFloorNode>();
					GetPort("Action").Connect(SAFindFloor_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAFindFloor_node_Action, assetPath);
					variableCount += SAFindFloor_node_Action.SetData((SAFindFloor)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAHurtGrabbed:
					SAHurtGrabbedNode SAHurtGrabbed_node_Action = graph.AddNode<SAHurtGrabbedNode>();
					GetPort("Action").Connect(SAHurtGrabbed_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAHurtGrabbed_node_Action, assetPath);
					variableCount += SAHurtGrabbed_node_Action.SetData((SAHurtGrabbed)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SALaunchGrabbed:
					SALaunchGrabbedNode SALaunchGrabbed_node_Action = graph.AddNode<SALaunchGrabbedNode>();
					GetPort("Action").Connect(SALaunchGrabbed_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SALaunchGrabbed_node_Action, assetPath);
					variableCount += SALaunchGrabbed_node_Action.SetData((SALaunchGrabbed)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAStateCancelGrabbed:
					SAStateCancelGrabbedNode SAStateCancelGrabbed_node_Action = graph.AddNode<SAStateCancelGrabbedNode>();
					GetPort("Action").Connect(SAStateCancelGrabbed_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAStateCancelGrabbed_node_Action, assetPath);
					variableCount += SAStateCancelGrabbed_node_Action.SetData((SAStateCancelGrabbed)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAEndGrab:
					SAEndGrabNode SAEndGrab_node_Action = graph.AddNode<SAEndGrabNode>();
					GetPort("Action").Connect(SAEndGrab_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAEndGrab_node_Action, assetPath);
					variableCount += SAEndGrab_node_Action.SetData((SAEndGrab)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAGrabNotifyEscape:
					SAGrabNotifyEscapeNode SAGrabNotifyEscape_node_Action = graph.AddNode<SAGrabNotifyEscapeNode>();
					GetPort("Action").Connect(SAGrabNotifyEscape_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAGrabNotifyEscape_node_Action, assetPath);
					variableCount += SAGrabNotifyEscape_node_Action.SetData((SAGrabNotifyEscape)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAIgnoreGrabbed:
					SAIgnoreGrabbedNode SAIgnoreGrabbed_node_Action = graph.AddNode<SAIgnoreGrabbedNode>();
					GetPort("Action").Connect(SAIgnoreGrabbed_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAIgnoreGrabbed_node_Action, assetPath);
					variableCount += SAIgnoreGrabbed_node_Action.SetData((SAIgnoreGrabbed)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAEventKO:
					SAEventKONode SAEventKO_node_Action = graph.AddNode<SAEventKONode>();
					GetPort("Action").Connect(SAEventKO_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAEventKO_node_Action, assetPath);
					variableCount += SAEventKO_node_Action.SetData((SAEventKO)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAEventKOGrabbed:
					SAEventKOGrabbedNode SAEventKOGrabbed_node_Action = graph.AddNode<SAEventKOGrabbedNode>();
					GetPort("Action").Connect(SAEventKOGrabbed_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAEventKOGrabbed_node_Action, assetPath);
					variableCount += SAEventKOGrabbed_node_Action.SetData((SAEventKOGrabbed)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SACameraShake:
					SACameraShakeNode SACameraShake_node_Action = graph.AddNode<SACameraShakeNode>();
					GetPort("Action").Connect(SACameraShake_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SACameraShake_node_Action, assetPath);
					variableCount += SACameraShake_node_Action.SetData((SACameraShake)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAResetOnHits:
					SAResetOnHitsNode SAResetOnHits_node_Action = graph.AddNode<SAResetOnHitsNode>();
					GetPort("Action").Connect(SAResetOnHits_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAResetOnHits_node_Action, assetPath);
					variableCount += SAResetOnHits_node_Action.SetData((SAResetOnHits)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAOnHit:
					SAOnHitNode SAOnHit_node_Action = graph.AddNode<SAOnHitNode>();
					GetPort("Action").Connect(SAOnHit_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAOnHit_node_Action, assetPath);
					variableCount += SAOnHit_node_Action.SetData((SAOnHit)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAFastForwardState:
					SAFastForwardStateNode SAFastForwardState_node_Action = graph.AddNode<SAFastForwardStateNode>();
					GetPort("Action").Connect(SAFastForwardState_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAFastForwardState_node_Action, assetPath);
					variableCount += SAFastForwardState_node_Action.SetData((SAFastForwardState)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SATimingTweak:
					SATimingTweakNode SATimingTweak_node_Action = graph.AddNode<SATimingTweakNode>();
					GetPort("Action").Connect(SATimingTweak_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SATimingTweak_node_Action, assetPath);
					variableCount += SATimingTweak_node_Action.SetData((SATimingTweak)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAMapAnimation:
					SAMapAnimationNode SAMapAnimation_node_Action = graph.AddNode<SAMapAnimationNode>();
					GetPort("Action").Connect(SAMapAnimation_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAMapAnimation_node_Action, assetPath);
					variableCount += SAMapAnimation_node_Action.SetData((SAMapAnimation)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAAlterMoveDT:
					SAAlterMoveDTNode SAAlterMoveDT_node_Action = graph.AddNode<SAAlterMoveDTNode>();
					GetPort("Action").Connect(SAAlterMoveDT_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAAlterMoveDT_node_Action, assetPath);
					variableCount += SAAlterMoveDT_node_Action.SetData((SAAlterMoveDT)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAAlterMoveVel:
					SAAlterMoveVelNode SAAlterMoveVel_node_Action = graph.AddNode<SAAlterMoveVelNode>();
					GetPort("Action").Connect(SAAlterMoveVel_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAAlterMoveVel_node_Action, assetPath);
					variableCount += SAAlterMoveVel_node_Action.SetData((SAAlterMoveVel)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SASetStagePart:
					SASetStagePartNode SASetStagePart_node_Action = graph.AddNode<SASetStagePartNode>();
					GetPort("Action").Connect(SASetStagePart_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SASetStagePart_node_Action, assetPath);
					variableCount += SASetStagePart_node_Action.SetData((SASetStagePart)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SASetStagePartsDefault:
					SASetStagePartsDefaultNode SASetStagePartsDefault_node_Action = graph.AddNode<SASetStagePartsDefaultNode>();
					GetPort("Action").Connect(SASetStagePartsDefault_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SASetStagePartsDefault_node_Action, assetPath);
					variableCount += SASetStagePartsDefault_node_Action.SetData((SASetStagePartsDefault)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAJump:
					SAJumpNode SAJump_node_Action = graph.AddNode<SAJumpNode>();
					GetPort("Action").Connect(SAJump_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAJump_node_Action, assetPath);
					variableCount += SAJump_node_Action.SetData((SAJump)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAStopJump:
					SAStopJumpNode SAStopJump_node_Action = graph.AddNode<SAStopJumpNode>();
					GetPort("Action").Connect(SAStopJump_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAStopJump_node_Action, assetPath);
					variableCount += SAStopJump_node_Action.SetData((SAStopJump)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAManageAirJump:
					SAManageAirJumpNode SAManageAirJump_node_Action = graph.AddNode<SAManageAirJumpNode>();
					GetPort("Action").Connect(SAManageAirJump_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAManageAirJump_node_Action, assetPath);
					variableCount += SAManageAirJump_node_Action.SetData((SAManageAirJump)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SALeaveGround:
					SALeaveGroundNode SALeaveGround_node_Action = graph.AddNode<SALeaveGroundNode>();
					GetPort("Action").Connect(SALeaveGround_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SALeaveGround_node_Action, assetPath);
					variableCount += SALeaveGround_node_Action.SetData((SALeaveGround)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAUnHogEdge:
					SAUnHogEdgeNode SAUnHogEdge_node_Action = graph.AddNode<SAUnHogEdgeNode>();
					GetPort("Action").Connect(SAUnHogEdge_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAUnHogEdge_node_Action, assetPath);
					variableCount += SAUnHogEdge_node_Action.SetData((SAUnHogEdge)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAPlaySFXTimeline:
					SAPlaySFXTimelineNode SAPlaySFXTimeline_node_Action = graph.AddNode<SAPlaySFXTimelineNode>();
					GetPort("Action").Connect(SAPlaySFXTimeline_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAPlaySFXTimeline_node_Action, assetPath);
					variableCount += SAPlaySFXTimeline_node_Action.SetData((SAPlaySFXTimeline)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAFindLastHorizontalInput:
					SAFindLastHorizontalInputNode SAFindLastHorizontalInput_node_Action = graph.AddNode<SAFindLastHorizontalInputNode>();
					GetPort("Action").Connect(SAFindLastHorizontalInput_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAFindLastHorizontalInput_node_Action, assetPath);
					variableCount += SAFindLastHorizontalInput_node_Action.SetData((SAFindLastHorizontalInput)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SASetCommandGrab:
					SASetCommandGrabNode SASetCommandGrab_node_Action = graph.AddNode<SASetCommandGrabNode>();
					GetPort("Action").Connect(SASetCommandGrab_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SASetCommandGrab_node_Action, assetPath);
					variableCount += SASetCommandGrab_node_Action.SetData((SASetCommandGrab)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SACameraPunch:
					SACameraPunchNode SACameraPunch_node_Action = graph.AddNode<SACameraPunchNode>();
					GetPort("Action").Connect(SACameraPunch_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SACameraPunch_node_Action, assetPath);
					variableCount += SACameraPunch_node_Action.SetData((SACameraPunch)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SASpawnAgent2:
					SASpawnAgent2Node SASpawnAgent2_node_Action = graph.AddNode<SASpawnAgent2Node>();
					GetPort("Action").Connect(SASpawnAgent2_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SASpawnAgent2_node_Action, assetPath);
					variableCount += SASpawnAgent2_node_Action.SetData((SASpawnAgent2)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAManipDecorChain:
					SAManipDecorChainNode SAManipDecorChain_node_Action = graph.AddNode<SAManipDecorChainNode>();
					GetPort("Action").Connect(SAManipDecorChain_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAManipDecorChain_node_Action, assetPath);
					variableCount += SAManipDecorChain_node_Action.SetData((SAManipDecorChain)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAUpdateHitboxes:
					SAUpdateHitboxesNode SAUpdateHitboxes_node_Action = graph.AddNode<SAUpdateHitboxesNode>();
					GetPort("Action").Connect(SAUpdateHitboxes_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAUpdateHitboxes_node_Action, assetPath);
					variableCount += SAUpdateHitboxes_node_Action.SetData((SAUpdateHitboxes)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SASampleAnim:
					SASampleAnimNode SASampleAnim_node_Action = graph.AddNode<SASampleAnimNode>();
					GetPort("Action").Connect(SASampleAnim_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SASampleAnim_node_Action, assetPath);
					variableCount += SASampleAnim_node_Action.SetData((SASampleAnim)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAForceExtraInputCheck:
					SAForceExtraInputCheckNode SAForceExtraInputCheck_node_Action = graph.AddNode<SAForceExtraInputCheckNode>();
					GetPort("Action").Connect(SAForceExtraInputCheck_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAForceExtraInputCheck_node_Action, assetPath);
					variableCount += SAForceExtraInputCheck_node_Action.SetData((SAForceExtraInputCheck)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SALaunchGrabbedCustom:
					SALaunchGrabbedCustomNode SALaunchGrabbedCustom_node_Action = graph.AddNode<SALaunchGrabbedCustomNode>();
					GetPort("Action").Connect(SALaunchGrabbedCustom_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SALaunchGrabbedCustom_node_Action, assetPath);
					variableCount += SALaunchGrabbedCustom_node_Action.SetData((SALaunchGrabbedCustom)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAMapAnimationSimple:
					SAMapAnimationSimpleNode SAMapAnimationSimple_node_Action = graph.AddNode<SAMapAnimationSimpleNode>();
					GetPort("Action").Connect(SAMapAnimationSimple_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAMapAnimationSimple_node_Action, assetPath);
					variableCount += SAMapAnimationSimple_node_Action.SetData((SAMapAnimationSimple)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAPersistLocalFX:
					SAPersistLocalFXNode SAPersistLocalFX_node_Action = graph.AddNode<SAPersistLocalFXNode>();
					GetPort("Action").Connect(SAPersistLocalFX_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAPersistLocalFX_node_Action, assetPath);
					variableCount += SAPersistLocalFX_node_Action.SetData((SAPersistLocalFX)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAOnLeaveParent:
					SAOnLeaveParentNode SAOnLeaveParent_node_Action = graph.AddNode<SAOnLeaveParentNode>();
					GetPort("Action").Connect(SAOnLeaveParent_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAOnLeaveParent_node_Action, assetPath);
					variableCount += SAOnLeaveParent_node_Action.SetData((SAOnLeaveParent)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAPlayVoiceLine:
					SAPlayVoiceLineNode SAPlayVoiceLine_node_Action = graph.AddNode<SAPlayVoiceLineNode>();
					GetPort("Action").Connect(SAPlayVoiceLine_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAPlayVoiceLine_node_Action, assetPath);
					variableCount += SAPlayVoiceLine_node_Action.SetData((SAPlayVoiceLine)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAPlayCategoryVoiceLine:
					SAPlayCategoryVoiceLineNode SAPlayCategoryVoiceLine_node_Action = graph.AddNode<SAPlayCategoryVoiceLineNode>();
					GetPort("Action").Connect(SAPlayCategoryVoiceLine_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAPlayCategoryVoiceLine_node_Action, assetPath);
					variableCount += SAPlayCategoryVoiceLine_node_Action.SetData((SAPlayCategoryVoiceLine)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAStopVoiceLines:
					SAStopVoiceLinesNode SAStopVoiceLines_node_Action = graph.AddNode<SAStopVoiceLinesNode>();
					GetPort("Action").Connect(SAStopVoiceLines_node_Action.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAStopVoiceLines_node_Action, assetPath);
					variableCount += SAStopVoiceLines_node_Action.SetData((SAStopVoiceLines)Action, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
			}
			++variableCount;
			
			Else = data.Else;
			ElseAction = data.ElseAction;
			
			switch (ElseAction.TID)
			{
				case StateAction.TypeId.StateAction:
					StateActionNode StateAction_node_ElseAction = graph.AddNode<StateActionNode>();
					GetPort("ElseAction").Connect(StateAction_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(StateAction_node_ElseAction, assetPath);
					variableCount += StateAction_node_ElseAction.SetData((StateAction)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SADebugMessage:
					SADebugMessageNode SADebugMessage_node_ElseAction = graph.AddNode<SADebugMessageNode>();
					GetPort("ElseAction").Connect(SADebugMessage_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SADebugMessage_node_ElseAction, assetPath);
					variableCount += SADebugMessage_node_ElseAction.SetData((SADebugMessage)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAPlayAnim:
					SAPlayAnimNode SAPlayAnim_node_ElseAction = graph.AddNode<SAPlayAnimNode>();
					GetPort("ElseAction").Connect(SAPlayAnim_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAPlayAnim_node_ElseAction, assetPath);
					variableCount += SAPlayAnim_node_ElseAction.SetData((SAPlayAnim)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAPlayRootAnim:
					SAPlayRootAnimNode SAPlayRootAnim_node_ElseAction = graph.AddNode<SAPlayRootAnimNode>();
					GetPort("ElseAction").Connect(SAPlayRootAnim_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAPlayRootAnim_node_ElseAction, assetPath);
					variableCount += SAPlayRootAnim_node_ElseAction.SetData((SAPlayRootAnim)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SASnapAnimWeights:
					SASnapAnimWeightsNode SASnapAnimWeights_node_ElseAction = graph.AddNode<SASnapAnimWeightsNode>();
					GetPort("ElseAction").Connect(SASnapAnimWeights_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SASnapAnimWeights_node_ElseAction, assetPath);
					variableCount += SASnapAnimWeights_node_ElseAction.SetData((SASnapAnimWeights)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAStandardInput:
					SAStandardInputNode SAStandardInput_node_ElseAction = graph.AddNode<SAStandardInputNode>();
					GetPort("ElseAction").Connect(SAStandardInput_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAStandardInput_node_ElseAction, assetPath);
					variableCount += SAStandardInput_node_ElseAction.SetData((SAStandardInput)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAInputAction:
					SAInputActionNode SAInputAction_node_ElseAction = graph.AddNode<SAInputActionNode>();
					GetPort("ElseAction").Connect(SAInputAction_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAInputAction_node_ElseAction, assetPath);
					variableCount += SAInputAction_node_ElseAction.SetData((SAInputAction)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SADeactivateInputAction:
					SADeactivateInputActionNode SADeactivateInputAction_node_ElseAction = graph.AddNode<SADeactivateInputActionNode>();
					GetPort("ElseAction").Connect(SADeactivateInputAction_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SADeactivateInputAction_node_ElseAction, assetPath);
					variableCount += SADeactivateInputAction_node_ElseAction.SetData((SADeactivateInputAction)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAAddInputEventFromFrame:
					SAAddInputEventFromFrameNode SAAddInputEventFromFrame_node_ElseAction = graph.AddNode<SAAddInputEventFromFrameNode>();
					GetPort("ElseAction").Connect(SAAddInputEventFromFrame_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAAddInputEventFromFrame_node_ElseAction, assetPath);
					variableCount += SAAddInputEventFromFrame_node_ElseAction.SetData((SAAddInputEventFromFrame)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SACancelToState:
					SACancelToStateNode SACancelToState_node_ElseAction = graph.AddNode<SACancelToStateNode>();
					GetPort("ElseAction").Connect(SACancelToState_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SACancelToState_node_ElseAction, assetPath);
					variableCount += SACancelToState_node_ElseAction.SetData((SACancelToState)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SACustomCall:
					SACustomCallNode SACustomCall_node_ElseAction = graph.AddNode<SACustomCallNode>();
					GetPort("ElseAction").Connect(SACustomCall_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SACustomCall_node_ElseAction, assetPath);
					variableCount += SACustomCall_node_ElseAction.SetData((SACustomCall)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SATimedAction:
					SATimedActionNode SATimedAction_node_ElseAction = graph.AddNode<SATimedActionNode>();
					GetPort("ElseAction").Connect(SATimedAction_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SATimedAction_node_ElseAction, assetPath);
					variableCount += SATimedAction_node_ElseAction.SetData((SATimedAction)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAOrderSensitive:
					SAOrderSensitiveNode SAOrderSensitive_node_ElseAction = graph.AddNode<SAOrderSensitiveNode>();
					GetPort("ElseAction").Connect(SAOrderSensitive_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAOrderSensitive_node_ElseAction, assetPath);
					variableCount += SAOrderSensitive_node_ElseAction.SetData((SAOrderSensitive)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAProxyMove:
					SAProxyMoveNode SAProxyMove_node_ElseAction = graph.AddNode<SAProxyMoveNode>();
					GetPort("ElseAction").Connect(SAProxyMove_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAProxyMove_node_ElseAction, assetPath);
					variableCount += SAProxyMove_node_ElseAction.SetData((SAProxyMove)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SACheckThing:
					SACheckThingNode SACheckThing_node_ElseAction = graph.AddNode<SACheckThingNode>();
					GetPort("ElseAction").Connect(SACheckThing_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SACheckThing_node_ElseAction, assetPath);
					variableCount += SACheckThing_node_ElseAction.SetData((SACheckThing)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAActiveAction:
					SAActiveActionNode SAActiveAction_node_ElseAction = graph.AddNode<SAActiveActionNode>();
					GetPort("ElseAction").Connect(SAActiveAction_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAActiveAction_node_ElseAction, assetPath);
					variableCount += SAActiveAction_node_ElseAction.SetData((SAActiveAction)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SADeactivateAction:
					SADeactivateActionNode SADeactivateAction_node_ElseAction = graph.AddNode<SADeactivateActionNode>();
					GetPort("ElseAction").Connect(SADeactivateAction_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SADeactivateAction_node_ElseAction, assetPath);
					variableCount += SADeactivateAction_node_ElseAction.SetData((SADeactivateAction)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SASetFloatTarget:
					SASetFloatTargetNode SASetFloatTarget_node_ElseAction = graph.AddNode<SASetFloatTargetNode>();
					GetPort("ElseAction").Connect(SASetFloatTarget_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SASetFloatTarget_node_ElseAction, assetPath);
					variableCount += SASetFloatTarget_node_ElseAction.SetData((SASetFloatTarget)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAOnBounce:
					SAOnBounceNode SAOnBounce_node_ElseAction = graph.AddNode<SAOnBounceNode>();
					GetPort("ElseAction").Connect(SAOnBounce_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAOnBounce_node_ElseAction, assetPath);
					variableCount += SAOnBounce_node_ElseAction.SetData((SAOnBounce)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAOnLeaveEdge:
					SAOnLeaveEdgeNode SAOnLeaveEdge_node_ElseAction = graph.AddNode<SAOnLeaveEdgeNode>();
					GetPort("ElseAction").Connect(SAOnLeaveEdge_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAOnLeaveEdge_node_ElseAction, assetPath);
					variableCount += SAOnLeaveEdge_node_ElseAction.SetData((SAOnLeaveEdge)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAOnStoppedAtEdge:
					SAOnStoppedAtEdgeNode SAOnStoppedAtEdge_node_ElseAction = graph.AddNode<SAOnStoppedAtEdgeNode>();
					GetPort("ElseAction").Connect(SAOnStoppedAtEdge_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAOnStoppedAtEdge_node_ElseAction, assetPath);
					variableCount += SAOnStoppedAtEdge_node_ElseAction.SetData((SAOnStoppedAtEdge)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAOnLand:
					SAOnLandNode SAOnLand_node_ElseAction = graph.AddNode<SAOnLandNode>();
					GetPort("ElseAction").Connect(SAOnLand_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAOnLand_node_ElseAction, assetPath);
					variableCount += SAOnLand_node_ElseAction.SetData((SAOnLand)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAOnCancel:
					SAOnCancelNode SAOnCancel_node_ElseAction = graph.AddNode<SAOnCancelNode>();
					GetPort("ElseAction").Connect(SAOnCancel_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAOnCancel_node_ElseAction, assetPath);
					variableCount += SAOnCancel_node_ElseAction.SetData((SAOnCancel)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SARefreshAttack:
					SARefreshAttackNode SARefreshAttack_node_ElseAction = graph.AddNode<SARefreshAttackNode>();
					GetPort("ElseAction").Connect(SARefreshAttack_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SARefreshAttack_node_ElseAction, assetPath);
					variableCount += SARefreshAttack_node_ElseAction.SetData((SARefreshAttack)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAEndAttack:
					SAEndAttackNode SAEndAttack_node_ElseAction = graph.AddNode<SAEndAttackNode>();
					GetPort("ElseAction").Connect(SAEndAttack_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAEndAttack_node_ElseAction, assetPath);
					variableCount += SAEndAttack_node_ElseAction.SetData((SAEndAttack)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SASetHitboxCount:
					SASetHitboxCountNode SASetHitboxCount_node_ElseAction = graph.AddNode<SASetHitboxCountNode>();
					GetPort("ElseAction").Connect(SASetHitboxCount_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SASetHitboxCount_node_ElseAction, assetPath);
					variableCount += SASetHitboxCount_node_ElseAction.SetData((SASetHitboxCount)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAConfigHitbox:
					SAConfigHitboxNode SAConfigHitbox_node_ElseAction = graph.AddNode<SAConfigHitboxNode>();
					GetPort("ElseAction").Connect(SAConfigHitbox_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAConfigHitbox_node_ElseAction, assetPath);
					variableCount += SAConfigHitbox_node_ElseAction.SetData((SAConfigHitbox)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SASetAtkProp:
					SASetAtkPropNode SASetAtkProp_node_ElseAction = graph.AddNode<SASetAtkPropNode>();
					GetPort("ElseAction").Connect(SASetAtkProp_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SASetAtkProp_node_ElseAction, assetPath);
					variableCount += SASetAtkProp_node_ElseAction.SetData((SASetAtkProp)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAManipHitBox:
					SAManipHitBoxNode SAManipHitBox_node_ElseAction = graph.AddNode<SAManipHitBoxNode>();
					GetPort("ElseAction").Connect(SAManipHitBox_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAManipHitBox_node_ElseAction, assetPath);
					variableCount += SAManipHitBox_node_ElseAction.SetData((SAManipHitBox)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAUpdateHurtboxes:
					SAUpdateHurtboxesNode SAUpdateHurtboxes_node_ElseAction = graph.AddNode<SAUpdateHurtboxesNode>();
					GetPort("ElseAction").Connect(SAUpdateHurtboxes_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAUpdateHurtboxes_node_ElseAction, assetPath);
					variableCount += SAUpdateHurtboxes_node_ElseAction.SetData((SAUpdateHurtboxes)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SASetupHurtboxes:
					SASetupHurtboxesNode SASetupHurtboxes_node_ElseAction = graph.AddNode<SASetupHurtboxesNode>();
					GetPort("ElseAction").Connect(SASetupHurtboxes_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SASetupHurtboxes_node_ElseAction, assetPath);
					variableCount += SASetupHurtboxes_node_ElseAction.SetData((SASetupHurtboxes)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAManipHurtBox:
					SAManipHurtBoxNode SAManipHurtBox_node_ElseAction = graph.AddNode<SAManipHurtBoxNode>();
					GetPort("ElseAction").Connect(SAManipHurtBox_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAManipHurtBox_node_ElseAction, assetPath);
					variableCount += SAManipHurtBox_node_ElseAction.SetData((SAManipHurtBox)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SABoneState:
					SABoneStateNode SABoneState_node_ElseAction = graph.AddNode<SABoneStateNode>();
					GetPort("ElseAction").Connect(SABoneState_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SABoneState_node_ElseAction, assetPath);
					variableCount += SABoneState_node_ElseAction.SetData((SABoneState)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SABoneScale:
					SABoneScaleNode SABoneScale_node_ElseAction = graph.AddNode<SABoneScaleNode>();
					GetPort("ElseAction").Connect(SABoneScale_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SABoneScale_node_ElseAction, assetPath);
					variableCount += SABoneScale_node_ElseAction.SetData((SABoneScale)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SASpawnAgent:
					SASpawnAgentNode SASpawnAgent_node_ElseAction = graph.AddNode<SASpawnAgentNode>();
					GetPort("ElseAction").Connect(SASpawnAgent_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SASpawnAgent_node_ElseAction, assetPath);
					variableCount += SASpawnAgent_node_ElseAction.SetData((SASpawnAgent)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SALocalFX:
					SALocalFXNode SALocalFX_node_ElseAction = graph.AddNode<SALocalFXNode>();
					GetPort("ElseAction").Connect(SALocalFX_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SALocalFX_node_ElseAction, assetPath);
					variableCount += SALocalFX_node_ElseAction.SetData((SALocalFX)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SASpawnFX:
					SASpawnFXNode SASpawnFX_node_ElseAction = graph.AddNode<SASpawnFXNode>();
					GetPort("ElseAction").Connect(SASpawnFX_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SASpawnFX_node_ElseAction, assetPath);
					variableCount += SASpawnFX_node_ElseAction.SetData((SASpawnFX)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SASetHitboxFX:
					SASetHitboxFXNode SASetHitboxFX_node_ElseAction = graph.AddNode<SASetHitboxFXNode>();
					GetPort("ElseAction").Connect(SASetHitboxFX_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SASetHitboxFX_node_ElseAction, assetPath);
					variableCount += SASetHitboxFX_node_ElseAction.SetData((SASetHitboxFX)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAPlaySFX:
					SAPlaySFXNode SAPlaySFX_node_ElseAction = graph.AddNode<SAPlaySFXNode>();
					GetPort("ElseAction").Connect(SAPlaySFX_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAPlaySFX_node_ElseAction, assetPath);
					variableCount += SAPlaySFX_node_ElseAction.SetData((SAPlaySFX)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SASetHitboxSFX:
					SASetHitboxSFXNode SASetHitboxSFX_node_ElseAction = graph.AddNode<SASetHitboxSFXNode>();
					GetPort("ElseAction").Connect(SASetHitboxSFX_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SASetHitboxSFX_node_ElseAction, assetPath);
					variableCount += SASetHitboxSFX_node_ElseAction.SetData((SASetHitboxSFX)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAColorTint:
					SAColorTintNode SAColorTint_node_ElseAction = graph.AddNode<SAColorTintNode>();
					GetPort("ElseAction").Connect(SAColorTint_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAColorTint_node_ElseAction, assetPath);
					variableCount += SAColorTint_node_ElseAction.SetData((SAColorTint)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAFindFloor:
					SAFindFloorNode SAFindFloor_node_ElseAction = graph.AddNode<SAFindFloorNode>();
					GetPort("ElseAction").Connect(SAFindFloor_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAFindFloor_node_ElseAction, assetPath);
					variableCount += SAFindFloor_node_ElseAction.SetData((SAFindFloor)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAHurtGrabbed:
					SAHurtGrabbedNode SAHurtGrabbed_node_ElseAction = graph.AddNode<SAHurtGrabbedNode>();
					GetPort("ElseAction").Connect(SAHurtGrabbed_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAHurtGrabbed_node_ElseAction, assetPath);
					variableCount += SAHurtGrabbed_node_ElseAction.SetData((SAHurtGrabbed)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SALaunchGrabbed:
					SALaunchGrabbedNode SALaunchGrabbed_node_ElseAction = graph.AddNode<SALaunchGrabbedNode>();
					GetPort("ElseAction").Connect(SALaunchGrabbed_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SALaunchGrabbed_node_ElseAction, assetPath);
					variableCount += SALaunchGrabbed_node_ElseAction.SetData((SALaunchGrabbed)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAStateCancelGrabbed:
					SAStateCancelGrabbedNode SAStateCancelGrabbed_node_ElseAction = graph.AddNode<SAStateCancelGrabbedNode>();
					GetPort("ElseAction").Connect(SAStateCancelGrabbed_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAStateCancelGrabbed_node_ElseAction, assetPath);
					variableCount += SAStateCancelGrabbed_node_ElseAction.SetData((SAStateCancelGrabbed)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAEndGrab:
					SAEndGrabNode SAEndGrab_node_ElseAction = graph.AddNode<SAEndGrabNode>();
					GetPort("ElseAction").Connect(SAEndGrab_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAEndGrab_node_ElseAction, assetPath);
					variableCount += SAEndGrab_node_ElseAction.SetData((SAEndGrab)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAGrabNotifyEscape:
					SAGrabNotifyEscapeNode SAGrabNotifyEscape_node_ElseAction = graph.AddNode<SAGrabNotifyEscapeNode>();
					GetPort("ElseAction").Connect(SAGrabNotifyEscape_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAGrabNotifyEscape_node_ElseAction, assetPath);
					variableCount += SAGrabNotifyEscape_node_ElseAction.SetData((SAGrabNotifyEscape)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAIgnoreGrabbed:
					SAIgnoreGrabbedNode SAIgnoreGrabbed_node_ElseAction = graph.AddNode<SAIgnoreGrabbedNode>();
					GetPort("ElseAction").Connect(SAIgnoreGrabbed_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAIgnoreGrabbed_node_ElseAction, assetPath);
					variableCount += SAIgnoreGrabbed_node_ElseAction.SetData((SAIgnoreGrabbed)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAEventKO:
					SAEventKONode SAEventKO_node_ElseAction = graph.AddNode<SAEventKONode>();
					GetPort("ElseAction").Connect(SAEventKO_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAEventKO_node_ElseAction, assetPath);
					variableCount += SAEventKO_node_ElseAction.SetData((SAEventKO)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAEventKOGrabbed:
					SAEventKOGrabbedNode SAEventKOGrabbed_node_ElseAction = graph.AddNode<SAEventKOGrabbedNode>();
					GetPort("ElseAction").Connect(SAEventKOGrabbed_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAEventKOGrabbed_node_ElseAction, assetPath);
					variableCount += SAEventKOGrabbed_node_ElseAction.SetData((SAEventKOGrabbed)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SACameraShake:
					SACameraShakeNode SACameraShake_node_ElseAction = graph.AddNode<SACameraShakeNode>();
					GetPort("ElseAction").Connect(SACameraShake_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SACameraShake_node_ElseAction, assetPath);
					variableCount += SACameraShake_node_ElseAction.SetData((SACameraShake)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAResetOnHits:
					SAResetOnHitsNode SAResetOnHits_node_ElseAction = graph.AddNode<SAResetOnHitsNode>();
					GetPort("ElseAction").Connect(SAResetOnHits_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAResetOnHits_node_ElseAction, assetPath);
					variableCount += SAResetOnHits_node_ElseAction.SetData((SAResetOnHits)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAOnHit:
					SAOnHitNode SAOnHit_node_ElseAction = graph.AddNode<SAOnHitNode>();
					GetPort("ElseAction").Connect(SAOnHit_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAOnHit_node_ElseAction, assetPath);
					variableCount += SAOnHit_node_ElseAction.SetData((SAOnHit)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAFastForwardState:
					SAFastForwardStateNode SAFastForwardState_node_ElseAction = graph.AddNode<SAFastForwardStateNode>();
					GetPort("ElseAction").Connect(SAFastForwardState_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAFastForwardState_node_ElseAction, assetPath);
					variableCount += SAFastForwardState_node_ElseAction.SetData((SAFastForwardState)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SATimingTweak:
					SATimingTweakNode SATimingTweak_node_ElseAction = graph.AddNode<SATimingTweakNode>();
					GetPort("ElseAction").Connect(SATimingTweak_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SATimingTweak_node_ElseAction, assetPath);
					variableCount += SATimingTweak_node_ElseAction.SetData((SATimingTweak)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAMapAnimation:
					SAMapAnimationNode SAMapAnimation_node_ElseAction = graph.AddNode<SAMapAnimationNode>();
					GetPort("ElseAction").Connect(SAMapAnimation_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAMapAnimation_node_ElseAction, assetPath);
					variableCount += SAMapAnimation_node_ElseAction.SetData((SAMapAnimation)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAAlterMoveDT:
					SAAlterMoveDTNode SAAlterMoveDT_node_ElseAction = graph.AddNode<SAAlterMoveDTNode>();
					GetPort("ElseAction").Connect(SAAlterMoveDT_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAAlterMoveDT_node_ElseAction, assetPath);
					variableCount += SAAlterMoveDT_node_ElseAction.SetData((SAAlterMoveDT)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAAlterMoveVel:
					SAAlterMoveVelNode SAAlterMoveVel_node_ElseAction = graph.AddNode<SAAlterMoveVelNode>();
					GetPort("ElseAction").Connect(SAAlterMoveVel_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAAlterMoveVel_node_ElseAction, assetPath);
					variableCount += SAAlterMoveVel_node_ElseAction.SetData((SAAlterMoveVel)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SASetStagePart:
					SASetStagePartNode SASetStagePart_node_ElseAction = graph.AddNode<SASetStagePartNode>();
					GetPort("ElseAction").Connect(SASetStagePart_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SASetStagePart_node_ElseAction, assetPath);
					variableCount += SASetStagePart_node_ElseAction.SetData((SASetStagePart)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SASetStagePartsDefault:
					SASetStagePartsDefaultNode SASetStagePartsDefault_node_ElseAction = graph.AddNode<SASetStagePartsDefaultNode>();
					GetPort("ElseAction").Connect(SASetStagePartsDefault_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SASetStagePartsDefault_node_ElseAction, assetPath);
					variableCount += SASetStagePartsDefault_node_ElseAction.SetData((SASetStagePartsDefault)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAJump:
					SAJumpNode SAJump_node_ElseAction = graph.AddNode<SAJumpNode>();
					GetPort("ElseAction").Connect(SAJump_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAJump_node_ElseAction, assetPath);
					variableCount += SAJump_node_ElseAction.SetData((SAJump)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAStopJump:
					SAStopJumpNode SAStopJump_node_ElseAction = graph.AddNode<SAStopJumpNode>();
					GetPort("ElseAction").Connect(SAStopJump_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAStopJump_node_ElseAction, assetPath);
					variableCount += SAStopJump_node_ElseAction.SetData((SAStopJump)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAManageAirJump:
					SAManageAirJumpNode SAManageAirJump_node_ElseAction = graph.AddNode<SAManageAirJumpNode>();
					GetPort("ElseAction").Connect(SAManageAirJump_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAManageAirJump_node_ElseAction, assetPath);
					variableCount += SAManageAirJump_node_ElseAction.SetData((SAManageAirJump)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SALeaveGround:
					SALeaveGroundNode SALeaveGround_node_ElseAction = graph.AddNode<SALeaveGroundNode>();
					GetPort("ElseAction").Connect(SALeaveGround_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SALeaveGround_node_ElseAction, assetPath);
					variableCount += SALeaveGround_node_ElseAction.SetData((SALeaveGround)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAUnHogEdge:
					SAUnHogEdgeNode SAUnHogEdge_node_ElseAction = graph.AddNode<SAUnHogEdgeNode>();
					GetPort("ElseAction").Connect(SAUnHogEdge_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAUnHogEdge_node_ElseAction, assetPath);
					variableCount += SAUnHogEdge_node_ElseAction.SetData((SAUnHogEdge)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAPlaySFXTimeline:
					SAPlaySFXTimelineNode SAPlaySFXTimeline_node_ElseAction = graph.AddNode<SAPlaySFXTimelineNode>();
					GetPort("ElseAction").Connect(SAPlaySFXTimeline_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAPlaySFXTimeline_node_ElseAction, assetPath);
					variableCount += SAPlaySFXTimeline_node_ElseAction.SetData((SAPlaySFXTimeline)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAFindLastHorizontalInput:
					SAFindLastHorizontalInputNode SAFindLastHorizontalInput_node_ElseAction = graph.AddNode<SAFindLastHorizontalInputNode>();
					GetPort("ElseAction").Connect(SAFindLastHorizontalInput_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAFindLastHorizontalInput_node_ElseAction, assetPath);
					variableCount += SAFindLastHorizontalInput_node_ElseAction.SetData((SAFindLastHorizontalInput)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SASetCommandGrab:
					SASetCommandGrabNode SASetCommandGrab_node_ElseAction = graph.AddNode<SASetCommandGrabNode>();
					GetPort("ElseAction").Connect(SASetCommandGrab_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SASetCommandGrab_node_ElseAction, assetPath);
					variableCount += SASetCommandGrab_node_ElseAction.SetData((SASetCommandGrab)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SACameraPunch:
					SACameraPunchNode SACameraPunch_node_ElseAction = graph.AddNode<SACameraPunchNode>();
					GetPort("ElseAction").Connect(SACameraPunch_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SACameraPunch_node_ElseAction, assetPath);
					variableCount += SACameraPunch_node_ElseAction.SetData((SACameraPunch)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SASpawnAgent2:
					SASpawnAgent2Node SASpawnAgent2_node_ElseAction = graph.AddNode<SASpawnAgent2Node>();
					GetPort("ElseAction").Connect(SASpawnAgent2_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SASpawnAgent2_node_ElseAction, assetPath);
					variableCount += SASpawnAgent2_node_ElseAction.SetData((SASpawnAgent2)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAManipDecorChain:
					SAManipDecorChainNode SAManipDecorChain_node_ElseAction = graph.AddNode<SAManipDecorChainNode>();
					GetPort("ElseAction").Connect(SAManipDecorChain_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAManipDecorChain_node_ElseAction, assetPath);
					variableCount += SAManipDecorChain_node_ElseAction.SetData((SAManipDecorChain)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAUpdateHitboxes:
					SAUpdateHitboxesNode SAUpdateHitboxes_node_ElseAction = graph.AddNode<SAUpdateHitboxesNode>();
					GetPort("ElseAction").Connect(SAUpdateHitboxes_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAUpdateHitboxes_node_ElseAction, assetPath);
					variableCount += SAUpdateHitboxes_node_ElseAction.SetData((SAUpdateHitboxes)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SASampleAnim:
					SASampleAnimNode SASampleAnim_node_ElseAction = graph.AddNode<SASampleAnimNode>();
					GetPort("ElseAction").Connect(SASampleAnim_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SASampleAnim_node_ElseAction, assetPath);
					variableCount += SASampleAnim_node_ElseAction.SetData((SASampleAnim)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAForceExtraInputCheck:
					SAForceExtraInputCheckNode SAForceExtraInputCheck_node_ElseAction = graph.AddNode<SAForceExtraInputCheckNode>();
					GetPort("ElseAction").Connect(SAForceExtraInputCheck_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAForceExtraInputCheck_node_ElseAction, assetPath);
					variableCount += SAForceExtraInputCheck_node_ElseAction.SetData((SAForceExtraInputCheck)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SALaunchGrabbedCustom:
					SALaunchGrabbedCustomNode SALaunchGrabbedCustom_node_ElseAction = graph.AddNode<SALaunchGrabbedCustomNode>();
					GetPort("ElseAction").Connect(SALaunchGrabbedCustom_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SALaunchGrabbedCustom_node_ElseAction, assetPath);
					variableCount += SALaunchGrabbedCustom_node_ElseAction.SetData((SALaunchGrabbedCustom)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAMapAnimationSimple:
					SAMapAnimationSimpleNode SAMapAnimationSimple_node_ElseAction = graph.AddNode<SAMapAnimationSimpleNode>();
					GetPort("ElseAction").Connect(SAMapAnimationSimple_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAMapAnimationSimple_node_ElseAction, assetPath);
					variableCount += SAMapAnimationSimple_node_ElseAction.SetData((SAMapAnimationSimple)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAPersistLocalFX:
					SAPersistLocalFXNode SAPersistLocalFX_node_ElseAction = graph.AddNode<SAPersistLocalFXNode>();
					GetPort("ElseAction").Connect(SAPersistLocalFX_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAPersistLocalFX_node_ElseAction, assetPath);
					variableCount += SAPersistLocalFX_node_ElseAction.SetData((SAPersistLocalFX)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAOnLeaveParent:
					SAOnLeaveParentNode SAOnLeaveParent_node_ElseAction = graph.AddNode<SAOnLeaveParentNode>();
					GetPort("ElseAction").Connect(SAOnLeaveParent_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAOnLeaveParent_node_ElseAction, assetPath);
					variableCount += SAOnLeaveParent_node_ElseAction.SetData((SAOnLeaveParent)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAPlayVoiceLine:
					SAPlayVoiceLineNode SAPlayVoiceLine_node_ElseAction = graph.AddNode<SAPlayVoiceLineNode>();
					GetPort("ElseAction").Connect(SAPlayVoiceLine_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAPlayVoiceLine_node_ElseAction, assetPath);
					variableCount += SAPlayVoiceLine_node_ElseAction.SetData((SAPlayVoiceLine)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAPlayCategoryVoiceLine:
					SAPlayCategoryVoiceLineNode SAPlayCategoryVoiceLine_node_ElseAction = graph.AddNode<SAPlayCategoryVoiceLineNode>();
					GetPort("ElseAction").Connect(SAPlayCategoryVoiceLine_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAPlayCategoryVoiceLine_node_ElseAction, assetPath);
					variableCount += SAPlayCategoryVoiceLine_node_ElseAction.SetData((SAPlayCategoryVoiceLine)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAStopVoiceLines:
					SAStopVoiceLinesNode SAStopVoiceLines_node_ElseAction = graph.AddNode<SAStopVoiceLinesNode>();
					GetPort("ElseAction").Connect(SAStopVoiceLines_node_ElseAction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAStopVoiceLines_node_ElseAction, assetPath);
					variableCount += SAStopVoiceLines_node_ElseAction.SetData((SAStopVoiceLines)ElseAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
			}
			
			return variableCount;
		}
		
		public new SACheckThing GetData()
		{
			SACheckThing objToReturn = new SACheckThing();
			objToReturn.TID = TypeId.SACheckThing;
			if (GetPort("CheckThing").ConnectionCount > 0)
			{
				CheckThingNode CheckThing_Node = (CheckThingNode)GetPort("CheckThing").GetConnection(0).node;
				switch (CheckThing_Node.TID)
				{
					case CheckThing.TypeId.CheckThing:
						CheckThingNode CheckThing_CheckThing_Node = (CheckThingNode)GetPort("CheckThing").GetConnection(0).node;
						objToReturn.CheckThing = CheckThing_CheckThing_Node.GetData();
					break;
					case CheckThing.TypeId.CTMultiple:
						CTMultipleNode CTMultiple_CheckThing_Node = (CTMultipleNode)GetPort("CheckThing").GetConnection(0).node;
						objToReturn.CheckThing = CTMultiple_CheckThing_Node.GetData();
					break;
					case CheckThing.TypeId.CTCompareFloat:
						CTCompareFloatNode CTCompareFloat_CheckThing_Node = (CTCompareFloatNode)GetPort("CheckThing").GetConnection(0).node;
						objToReturn.CheckThing = CTCompareFloat_CheckThing_Node.GetData();
					break;
					case CheckThing.TypeId.CTDoubleTap:
						CTDoubleTapNode CTDoubleTap_CheckThing_Node = (CTDoubleTapNode)GetPort("CheckThing").GetConnection(0).node;
						objToReturn.CheckThing = CTDoubleTap_CheckThing_Node.GetData();
					break;
					case CheckThing.TypeId.CTInput:
						CTInputNode CTInput_CheckThing_Node = (CTInputNode)GetPort("CheckThing").GetConnection(0).node;
						objToReturn.CheckThing = CTInput_CheckThing_Node.GetData();
					break;
					case CheckThing.TypeId.CTInputSeries:
						CTInputSeriesNode CTInputSeries_CheckThing_Node = (CTInputSeriesNode)GetPort("CheckThing").GetConnection(0).node;
						objToReturn.CheckThing = CTInputSeries_CheckThing_Node.GetData();
					break;
					case CheckThing.TypeId.CTCheckTech:
						CTCheckTechNode CTCheckTech_CheckThing_Node = (CTCheckTechNode)GetPort("CheckThing").GetConnection(0).node;
						objToReturn.CheckThing = CTCheckTech_CheckThing_Node.GetData();
					break;
					case CheckThing.TypeId.CTGrab:
						CTGrabNode CTGrab_CheckThing_Node = (CTGrabNode)GetPort("CheckThing").GetConnection(0).node;
						objToReturn.CheckThing = CTGrab_CheckThing_Node.GetData();
					break;
					case CheckThing.TypeId.CTGrabbedAgent:
						CTGrabbedAgentNode CTGrabbedAgent_CheckThing_Node = (CTGrabbedAgentNode)GetPort("CheckThing").GetConnection(0).node;
						objToReturn.CheckThing = CTGrabbedAgent_CheckThing_Node.GetData();
					break;
					case CheckThing.TypeId.CTSkin:
						CTSkinNode CTSkin_CheckThing_Node = (CTSkinNode)GetPort("CheckThing").GetConnection(0).node;
						objToReturn.CheckThing = CTSkin_CheckThing_Node.GetData();
					break;
					case CheckThing.TypeId.CTMove:
						CTMoveNode CTMove_CheckThing_Node = (CTMoveNode)GetPort("CheckThing").GetConnection(0).node;
						objToReturn.CheckThing = CTMove_CheckThing_Node.GetData();
					break;
				}
			}
			if (GetPort("Action").ConnectionCount > 0)
			{
				StateActionNode StateAction_Node = (StateActionNode)GetPort("Action").GetConnection(0).node;
				switch (StateAction_Node.TID)
				{
					case StateAction.TypeId.StateAction:
						StateActionNode StateAction_StateAction_Node = (StateActionNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = StateAction_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SADebugMessage:
						SADebugMessageNode SADebugMessage_StateAction_Node = (SADebugMessageNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SADebugMessage_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAPlayAnim:
						SAPlayAnimNode SAPlayAnim_StateAction_Node = (SAPlayAnimNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SAPlayAnim_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAPlayRootAnim:
						SAPlayRootAnimNode SAPlayRootAnim_StateAction_Node = (SAPlayRootAnimNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SAPlayRootAnim_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASnapAnimWeights:
						SASnapAnimWeightsNode SASnapAnimWeights_StateAction_Node = (SASnapAnimWeightsNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SASnapAnimWeights_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAStandardInput:
						SAStandardInputNode SAStandardInput_StateAction_Node = (SAStandardInputNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SAStandardInput_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAInputAction:
						SAInputActionNode SAInputAction_StateAction_Node = (SAInputActionNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SAInputAction_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SADeactivateInputAction:
						SADeactivateInputActionNode SADeactivateInputAction_StateAction_Node = (SADeactivateInputActionNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SADeactivateInputAction_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAAddInputEventFromFrame:
						SAAddInputEventFromFrameNode SAAddInputEventFromFrame_StateAction_Node = (SAAddInputEventFromFrameNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SAAddInputEventFromFrame_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SACancelToState:
						SACancelToStateNode SACancelToState_StateAction_Node = (SACancelToStateNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SACancelToState_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SACustomCall:
						SACustomCallNode SACustomCall_StateAction_Node = (SACustomCallNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SACustomCall_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SATimedAction:
						SATimedActionNode SATimedAction_StateAction_Node = (SATimedActionNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SATimedAction_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAOrderSensitive:
						SAOrderSensitiveNode SAOrderSensitive_StateAction_Node = (SAOrderSensitiveNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SAOrderSensitive_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAProxyMove:
						SAProxyMoveNode SAProxyMove_StateAction_Node = (SAProxyMoveNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SAProxyMove_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SACheckThing:
						SACheckThingNode SACheckThing_StateAction_Node = (SACheckThingNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SACheckThing_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAActiveAction:
						SAActiveActionNode SAActiveAction_StateAction_Node = (SAActiveActionNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SAActiveAction_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SADeactivateAction:
						SADeactivateActionNode SADeactivateAction_StateAction_Node = (SADeactivateActionNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SADeactivateAction_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASetFloatTarget:
						SASetFloatTargetNode SASetFloatTarget_StateAction_Node = (SASetFloatTargetNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SASetFloatTarget_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAOnBounce:
						SAOnBounceNode SAOnBounce_StateAction_Node = (SAOnBounceNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SAOnBounce_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAOnLeaveEdge:
						SAOnLeaveEdgeNode SAOnLeaveEdge_StateAction_Node = (SAOnLeaveEdgeNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SAOnLeaveEdge_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAOnStoppedAtEdge:
						SAOnStoppedAtEdgeNode SAOnStoppedAtEdge_StateAction_Node = (SAOnStoppedAtEdgeNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SAOnStoppedAtEdge_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAOnLand:
						SAOnLandNode SAOnLand_StateAction_Node = (SAOnLandNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SAOnLand_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAOnCancel:
						SAOnCancelNode SAOnCancel_StateAction_Node = (SAOnCancelNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SAOnCancel_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SARefreshAttack:
						SARefreshAttackNode SARefreshAttack_StateAction_Node = (SARefreshAttackNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SARefreshAttack_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAEndAttack:
						SAEndAttackNode SAEndAttack_StateAction_Node = (SAEndAttackNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SAEndAttack_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASetHitboxCount:
						SASetHitboxCountNode SASetHitboxCount_StateAction_Node = (SASetHitboxCountNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SASetHitboxCount_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAConfigHitbox:
						SAConfigHitboxNode SAConfigHitbox_StateAction_Node = (SAConfigHitboxNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SAConfigHitbox_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASetAtkProp:
						SASetAtkPropNode SASetAtkProp_StateAction_Node = (SASetAtkPropNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SASetAtkProp_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAManipHitBox:
						SAManipHitBoxNode SAManipHitBox_StateAction_Node = (SAManipHitBoxNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SAManipHitBox_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAUpdateHurtboxes:
						SAUpdateHurtboxesNode SAUpdateHurtboxes_StateAction_Node = (SAUpdateHurtboxesNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SAUpdateHurtboxes_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASetupHurtboxes:
						SASetupHurtboxesNode SASetupHurtboxes_StateAction_Node = (SASetupHurtboxesNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SASetupHurtboxes_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAManipHurtBox:
						SAManipHurtBoxNode SAManipHurtBox_StateAction_Node = (SAManipHurtBoxNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SAManipHurtBox_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SABoneState:
						SABoneStateNode SABoneState_StateAction_Node = (SABoneStateNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SABoneState_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SABoneScale:
						SABoneScaleNode SABoneScale_StateAction_Node = (SABoneScaleNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SABoneScale_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASpawnAgent:
						SASpawnAgentNode SASpawnAgent_StateAction_Node = (SASpawnAgentNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SASpawnAgent_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SALocalFX:
						SALocalFXNode SALocalFX_StateAction_Node = (SALocalFXNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SALocalFX_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASpawnFX:
						SASpawnFXNode SASpawnFX_StateAction_Node = (SASpawnFXNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SASpawnFX_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASetHitboxFX:
						SASetHitboxFXNode SASetHitboxFX_StateAction_Node = (SASetHitboxFXNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SASetHitboxFX_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAPlaySFX:
						SAPlaySFXNode SAPlaySFX_StateAction_Node = (SAPlaySFXNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SAPlaySFX_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASetHitboxSFX:
						SASetHitboxSFXNode SASetHitboxSFX_StateAction_Node = (SASetHitboxSFXNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SASetHitboxSFX_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAColorTint:
						SAColorTintNode SAColorTint_StateAction_Node = (SAColorTintNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SAColorTint_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAFindFloor:
						SAFindFloorNode SAFindFloor_StateAction_Node = (SAFindFloorNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SAFindFloor_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAHurtGrabbed:
						SAHurtGrabbedNode SAHurtGrabbed_StateAction_Node = (SAHurtGrabbedNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SAHurtGrabbed_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SALaunchGrabbed:
						SALaunchGrabbedNode SALaunchGrabbed_StateAction_Node = (SALaunchGrabbedNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SALaunchGrabbed_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAStateCancelGrabbed:
						SAStateCancelGrabbedNode SAStateCancelGrabbed_StateAction_Node = (SAStateCancelGrabbedNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SAStateCancelGrabbed_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAEndGrab:
						SAEndGrabNode SAEndGrab_StateAction_Node = (SAEndGrabNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SAEndGrab_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAGrabNotifyEscape:
						SAGrabNotifyEscapeNode SAGrabNotifyEscape_StateAction_Node = (SAGrabNotifyEscapeNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SAGrabNotifyEscape_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAIgnoreGrabbed:
						SAIgnoreGrabbedNode SAIgnoreGrabbed_StateAction_Node = (SAIgnoreGrabbedNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SAIgnoreGrabbed_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAEventKO:
						SAEventKONode SAEventKO_StateAction_Node = (SAEventKONode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SAEventKO_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAEventKOGrabbed:
						SAEventKOGrabbedNode SAEventKOGrabbed_StateAction_Node = (SAEventKOGrabbedNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SAEventKOGrabbed_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SACameraShake:
						SACameraShakeNode SACameraShake_StateAction_Node = (SACameraShakeNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SACameraShake_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAResetOnHits:
						SAResetOnHitsNode SAResetOnHits_StateAction_Node = (SAResetOnHitsNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SAResetOnHits_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAOnHit:
						SAOnHitNode SAOnHit_StateAction_Node = (SAOnHitNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SAOnHit_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAFastForwardState:
						SAFastForwardStateNode SAFastForwardState_StateAction_Node = (SAFastForwardStateNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SAFastForwardState_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SATimingTweak:
						SATimingTweakNode SATimingTweak_StateAction_Node = (SATimingTweakNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SATimingTweak_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAMapAnimation:
						SAMapAnimationNode SAMapAnimation_StateAction_Node = (SAMapAnimationNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SAMapAnimation_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAAlterMoveDT:
						SAAlterMoveDTNode SAAlterMoveDT_StateAction_Node = (SAAlterMoveDTNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SAAlterMoveDT_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAAlterMoveVel:
						SAAlterMoveVelNode SAAlterMoveVel_StateAction_Node = (SAAlterMoveVelNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SAAlterMoveVel_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASetStagePart:
						SASetStagePartNode SASetStagePart_StateAction_Node = (SASetStagePartNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SASetStagePart_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASetStagePartsDefault:
						SASetStagePartsDefaultNode SASetStagePartsDefault_StateAction_Node = (SASetStagePartsDefaultNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SASetStagePartsDefault_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAJump:
						SAJumpNode SAJump_StateAction_Node = (SAJumpNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SAJump_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAStopJump:
						SAStopJumpNode SAStopJump_StateAction_Node = (SAStopJumpNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SAStopJump_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAManageAirJump:
						SAManageAirJumpNode SAManageAirJump_StateAction_Node = (SAManageAirJumpNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SAManageAirJump_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SALeaveGround:
						SALeaveGroundNode SALeaveGround_StateAction_Node = (SALeaveGroundNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SALeaveGround_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAUnHogEdge:
						SAUnHogEdgeNode SAUnHogEdge_StateAction_Node = (SAUnHogEdgeNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SAUnHogEdge_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAPlaySFXTimeline:
						SAPlaySFXTimelineNode SAPlaySFXTimeline_StateAction_Node = (SAPlaySFXTimelineNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SAPlaySFXTimeline_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAFindLastHorizontalInput:
						SAFindLastHorizontalInputNode SAFindLastHorizontalInput_StateAction_Node = (SAFindLastHorizontalInputNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SAFindLastHorizontalInput_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASetCommandGrab:
						SASetCommandGrabNode SASetCommandGrab_StateAction_Node = (SASetCommandGrabNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SASetCommandGrab_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SACameraPunch:
						SACameraPunchNode SACameraPunch_StateAction_Node = (SACameraPunchNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SACameraPunch_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASpawnAgent2:
						SASpawnAgent2Node SASpawnAgent2_StateAction_Node = (SASpawnAgent2Node)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SASpawnAgent2_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAManipDecorChain:
						SAManipDecorChainNode SAManipDecorChain_StateAction_Node = (SAManipDecorChainNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SAManipDecorChain_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAUpdateHitboxes:
						SAUpdateHitboxesNode SAUpdateHitboxes_StateAction_Node = (SAUpdateHitboxesNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SAUpdateHitboxes_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASampleAnim:
						SASampleAnimNode SASampleAnim_StateAction_Node = (SASampleAnimNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SASampleAnim_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAForceExtraInputCheck:
						SAForceExtraInputCheckNode SAForceExtraInputCheck_StateAction_Node = (SAForceExtraInputCheckNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SAForceExtraInputCheck_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SALaunchGrabbedCustom:
						SALaunchGrabbedCustomNode SALaunchGrabbedCustom_StateAction_Node = (SALaunchGrabbedCustomNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SALaunchGrabbedCustom_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAMapAnimationSimple:
						SAMapAnimationSimpleNode SAMapAnimationSimple_StateAction_Node = (SAMapAnimationSimpleNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SAMapAnimationSimple_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAPersistLocalFX:
						SAPersistLocalFXNode SAPersistLocalFX_StateAction_Node = (SAPersistLocalFXNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SAPersistLocalFX_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAOnLeaveParent:
						SAOnLeaveParentNode SAOnLeaveParent_StateAction_Node = (SAOnLeaveParentNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SAOnLeaveParent_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAPlayVoiceLine:
						SAPlayVoiceLineNode SAPlayVoiceLine_StateAction_Node = (SAPlayVoiceLineNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SAPlayVoiceLine_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAPlayCategoryVoiceLine:
						SAPlayCategoryVoiceLineNode SAPlayCategoryVoiceLine_StateAction_Node = (SAPlayCategoryVoiceLineNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SAPlayCategoryVoiceLine_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAStopVoiceLines:
						SAStopVoiceLinesNode SAStopVoiceLines_StateAction_Node = (SAStopVoiceLinesNode)GetPort("Action").GetConnection(0).node;
						objToReturn.Action = SAStopVoiceLines_StateAction_Node.GetData();
					break;
				}
			}
			objToReturn.Else = Else;
			if (GetPort("ElseAction").ConnectionCount > 0)
			{
				StateActionNode StateAction_Node = (StateActionNode)GetPort("ElseAction").GetConnection(0).node;
				switch (StateAction_Node.TID)
				{
					case StateAction.TypeId.StateAction:
						StateActionNode StateAction_StateAction_Node = (StateActionNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = StateAction_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SADebugMessage:
						SADebugMessageNode SADebugMessage_StateAction_Node = (SADebugMessageNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SADebugMessage_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAPlayAnim:
						SAPlayAnimNode SAPlayAnim_StateAction_Node = (SAPlayAnimNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SAPlayAnim_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAPlayRootAnim:
						SAPlayRootAnimNode SAPlayRootAnim_StateAction_Node = (SAPlayRootAnimNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SAPlayRootAnim_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASnapAnimWeights:
						SASnapAnimWeightsNode SASnapAnimWeights_StateAction_Node = (SASnapAnimWeightsNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SASnapAnimWeights_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAStandardInput:
						SAStandardInputNode SAStandardInput_StateAction_Node = (SAStandardInputNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SAStandardInput_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAInputAction:
						SAInputActionNode SAInputAction_StateAction_Node = (SAInputActionNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SAInputAction_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SADeactivateInputAction:
						SADeactivateInputActionNode SADeactivateInputAction_StateAction_Node = (SADeactivateInputActionNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SADeactivateInputAction_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAAddInputEventFromFrame:
						SAAddInputEventFromFrameNode SAAddInputEventFromFrame_StateAction_Node = (SAAddInputEventFromFrameNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SAAddInputEventFromFrame_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SACancelToState:
						SACancelToStateNode SACancelToState_StateAction_Node = (SACancelToStateNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SACancelToState_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SACustomCall:
						SACustomCallNode SACustomCall_StateAction_Node = (SACustomCallNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SACustomCall_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SATimedAction:
						SATimedActionNode SATimedAction_StateAction_Node = (SATimedActionNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SATimedAction_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAOrderSensitive:
						SAOrderSensitiveNode SAOrderSensitive_StateAction_Node = (SAOrderSensitiveNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SAOrderSensitive_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAProxyMove:
						SAProxyMoveNode SAProxyMove_StateAction_Node = (SAProxyMoveNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SAProxyMove_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SACheckThing:
						SACheckThingNode SACheckThing_StateAction_Node = (SACheckThingNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SACheckThing_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAActiveAction:
						SAActiveActionNode SAActiveAction_StateAction_Node = (SAActiveActionNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SAActiveAction_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SADeactivateAction:
						SADeactivateActionNode SADeactivateAction_StateAction_Node = (SADeactivateActionNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SADeactivateAction_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASetFloatTarget:
						SASetFloatTargetNode SASetFloatTarget_StateAction_Node = (SASetFloatTargetNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SASetFloatTarget_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAOnBounce:
						SAOnBounceNode SAOnBounce_StateAction_Node = (SAOnBounceNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SAOnBounce_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAOnLeaveEdge:
						SAOnLeaveEdgeNode SAOnLeaveEdge_StateAction_Node = (SAOnLeaveEdgeNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SAOnLeaveEdge_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAOnStoppedAtEdge:
						SAOnStoppedAtEdgeNode SAOnStoppedAtEdge_StateAction_Node = (SAOnStoppedAtEdgeNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SAOnStoppedAtEdge_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAOnLand:
						SAOnLandNode SAOnLand_StateAction_Node = (SAOnLandNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SAOnLand_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAOnCancel:
						SAOnCancelNode SAOnCancel_StateAction_Node = (SAOnCancelNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SAOnCancel_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SARefreshAttack:
						SARefreshAttackNode SARefreshAttack_StateAction_Node = (SARefreshAttackNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SARefreshAttack_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAEndAttack:
						SAEndAttackNode SAEndAttack_StateAction_Node = (SAEndAttackNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SAEndAttack_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASetHitboxCount:
						SASetHitboxCountNode SASetHitboxCount_StateAction_Node = (SASetHitboxCountNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SASetHitboxCount_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAConfigHitbox:
						SAConfigHitboxNode SAConfigHitbox_StateAction_Node = (SAConfigHitboxNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SAConfigHitbox_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASetAtkProp:
						SASetAtkPropNode SASetAtkProp_StateAction_Node = (SASetAtkPropNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SASetAtkProp_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAManipHitBox:
						SAManipHitBoxNode SAManipHitBox_StateAction_Node = (SAManipHitBoxNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SAManipHitBox_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAUpdateHurtboxes:
						SAUpdateHurtboxesNode SAUpdateHurtboxes_StateAction_Node = (SAUpdateHurtboxesNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SAUpdateHurtboxes_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASetupHurtboxes:
						SASetupHurtboxesNode SASetupHurtboxes_StateAction_Node = (SASetupHurtboxesNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SASetupHurtboxes_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAManipHurtBox:
						SAManipHurtBoxNode SAManipHurtBox_StateAction_Node = (SAManipHurtBoxNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SAManipHurtBox_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SABoneState:
						SABoneStateNode SABoneState_StateAction_Node = (SABoneStateNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SABoneState_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SABoneScale:
						SABoneScaleNode SABoneScale_StateAction_Node = (SABoneScaleNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SABoneScale_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASpawnAgent:
						SASpawnAgentNode SASpawnAgent_StateAction_Node = (SASpawnAgentNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SASpawnAgent_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SALocalFX:
						SALocalFXNode SALocalFX_StateAction_Node = (SALocalFXNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SALocalFX_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASpawnFX:
						SASpawnFXNode SASpawnFX_StateAction_Node = (SASpawnFXNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SASpawnFX_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASetHitboxFX:
						SASetHitboxFXNode SASetHitboxFX_StateAction_Node = (SASetHitboxFXNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SASetHitboxFX_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAPlaySFX:
						SAPlaySFXNode SAPlaySFX_StateAction_Node = (SAPlaySFXNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SAPlaySFX_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASetHitboxSFX:
						SASetHitboxSFXNode SASetHitboxSFX_StateAction_Node = (SASetHitboxSFXNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SASetHitboxSFX_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAColorTint:
						SAColorTintNode SAColorTint_StateAction_Node = (SAColorTintNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SAColorTint_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAFindFloor:
						SAFindFloorNode SAFindFloor_StateAction_Node = (SAFindFloorNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SAFindFloor_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAHurtGrabbed:
						SAHurtGrabbedNode SAHurtGrabbed_StateAction_Node = (SAHurtGrabbedNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SAHurtGrabbed_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SALaunchGrabbed:
						SALaunchGrabbedNode SALaunchGrabbed_StateAction_Node = (SALaunchGrabbedNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SALaunchGrabbed_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAStateCancelGrabbed:
						SAStateCancelGrabbedNode SAStateCancelGrabbed_StateAction_Node = (SAStateCancelGrabbedNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SAStateCancelGrabbed_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAEndGrab:
						SAEndGrabNode SAEndGrab_StateAction_Node = (SAEndGrabNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SAEndGrab_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAGrabNotifyEscape:
						SAGrabNotifyEscapeNode SAGrabNotifyEscape_StateAction_Node = (SAGrabNotifyEscapeNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SAGrabNotifyEscape_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAIgnoreGrabbed:
						SAIgnoreGrabbedNode SAIgnoreGrabbed_StateAction_Node = (SAIgnoreGrabbedNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SAIgnoreGrabbed_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAEventKO:
						SAEventKONode SAEventKO_StateAction_Node = (SAEventKONode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SAEventKO_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAEventKOGrabbed:
						SAEventKOGrabbedNode SAEventKOGrabbed_StateAction_Node = (SAEventKOGrabbedNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SAEventKOGrabbed_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SACameraShake:
						SACameraShakeNode SACameraShake_StateAction_Node = (SACameraShakeNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SACameraShake_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAResetOnHits:
						SAResetOnHitsNode SAResetOnHits_StateAction_Node = (SAResetOnHitsNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SAResetOnHits_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAOnHit:
						SAOnHitNode SAOnHit_StateAction_Node = (SAOnHitNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SAOnHit_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAFastForwardState:
						SAFastForwardStateNode SAFastForwardState_StateAction_Node = (SAFastForwardStateNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SAFastForwardState_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SATimingTweak:
						SATimingTweakNode SATimingTweak_StateAction_Node = (SATimingTweakNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SATimingTweak_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAMapAnimation:
						SAMapAnimationNode SAMapAnimation_StateAction_Node = (SAMapAnimationNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SAMapAnimation_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAAlterMoveDT:
						SAAlterMoveDTNode SAAlterMoveDT_StateAction_Node = (SAAlterMoveDTNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SAAlterMoveDT_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAAlterMoveVel:
						SAAlterMoveVelNode SAAlterMoveVel_StateAction_Node = (SAAlterMoveVelNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SAAlterMoveVel_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASetStagePart:
						SASetStagePartNode SASetStagePart_StateAction_Node = (SASetStagePartNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SASetStagePart_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASetStagePartsDefault:
						SASetStagePartsDefaultNode SASetStagePartsDefault_StateAction_Node = (SASetStagePartsDefaultNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SASetStagePartsDefault_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAJump:
						SAJumpNode SAJump_StateAction_Node = (SAJumpNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SAJump_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAStopJump:
						SAStopJumpNode SAStopJump_StateAction_Node = (SAStopJumpNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SAStopJump_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAManageAirJump:
						SAManageAirJumpNode SAManageAirJump_StateAction_Node = (SAManageAirJumpNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SAManageAirJump_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SALeaveGround:
						SALeaveGroundNode SALeaveGround_StateAction_Node = (SALeaveGroundNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SALeaveGround_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAUnHogEdge:
						SAUnHogEdgeNode SAUnHogEdge_StateAction_Node = (SAUnHogEdgeNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SAUnHogEdge_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAPlaySFXTimeline:
						SAPlaySFXTimelineNode SAPlaySFXTimeline_StateAction_Node = (SAPlaySFXTimelineNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SAPlaySFXTimeline_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAFindLastHorizontalInput:
						SAFindLastHorizontalInputNode SAFindLastHorizontalInput_StateAction_Node = (SAFindLastHorizontalInputNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SAFindLastHorizontalInput_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASetCommandGrab:
						SASetCommandGrabNode SASetCommandGrab_StateAction_Node = (SASetCommandGrabNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SASetCommandGrab_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SACameraPunch:
						SACameraPunchNode SACameraPunch_StateAction_Node = (SACameraPunchNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SACameraPunch_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASpawnAgent2:
						SASpawnAgent2Node SASpawnAgent2_StateAction_Node = (SASpawnAgent2Node)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SASpawnAgent2_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAManipDecorChain:
						SAManipDecorChainNode SAManipDecorChain_StateAction_Node = (SAManipDecorChainNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SAManipDecorChain_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAUpdateHitboxes:
						SAUpdateHitboxesNode SAUpdateHitboxes_StateAction_Node = (SAUpdateHitboxesNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SAUpdateHitboxes_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASampleAnim:
						SASampleAnimNode SASampleAnim_StateAction_Node = (SASampleAnimNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SASampleAnim_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAForceExtraInputCheck:
						SAForceExtraInputCheckNode SAForceExtraInputCheck_StateAction_Node = (SAForceExtraInputCheckNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SAForceExtraInputCheck_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SALaunchGrabbedCustom:
						SALaunchGrabbedCustomNode SALaunchGrabbedCustom_StateAction_Node = (SALaunchGrabbedCustomNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SALaunchGrabbedCustom_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAMapAnimationSimple:
						SAMapAnimationSimpleNode SAMapAnimationSimple_StateAction_Node = (SAMapAnimationSimpleNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SAMapAnimationSimple_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAPersistLocalFX:
						SAPersistLocalFXNode SAPersistLocalFX_StateAction_Node = (SAPersistLocalFXNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SAPersistLocalFX_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAOnLeaveParent:
						SAOnLeaveParentNode SAOnLeaveParent_StateAction_Node = (SAOnLeaveParentNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SAOnLeaveParent_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAPlayVoiceLine:
						SAPlayVoiceLineNode SAPlayVoiceLine_StateAction_Node = (SAPlayVoiceLineNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SAPlayVoiceLine_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAPlayCategoryVoiceLine:
						SAPlayCategoryVoiceLineNode SAPlayCategoryVoiceLine_StateAction_Node = (SAPlayCategoryVoiceLineNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SAPlayCategoryVoiceLine_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAStopVoiceLines:
						SAStopVoiceLinesNode SAStopVoiceLines_StateAction_Node = (SAStopVoiceLinesNode)GetPort("ElseAction").GetConnection(0).node;
						objToReturn.ElseAction = SAStopVoiceLines_StateAction_Node.GetData();
					break;
				}
			}
			return objToReturn;
		}
	}
}

