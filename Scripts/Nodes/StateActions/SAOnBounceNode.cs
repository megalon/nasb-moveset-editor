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
using static MovesetParser.StateActions.StateAction;

namespace NASB_Moveset_Editor.StateActions
{
	public class SAOnBounceNode : StateActionNode
	{
		[Input(connectionType = ConnectionType.Override)] public StateAction NodeInput;
		[Output(connectionType = ConnectionType.Override)] public StateAction Action;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.SAOnBounce;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SAOnBounce data, MovesetGraph graph, string assetPath, UnityEngine.Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SAOnBounce));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
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
			
			return variableCount;
		}
		
		public new SAOnBounce GetData()
		{
			SAOnBounce objToReturn = new SAOnBounce();
			objToReturn.TID = TypeId.SAOnBounce;
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
			return objToReturn;
		}
	}
}

