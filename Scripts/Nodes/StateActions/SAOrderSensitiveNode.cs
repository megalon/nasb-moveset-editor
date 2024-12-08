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
	public class SAOrderSensitiveNode : StateActionNode
	{
		[Input(connectionType = ConnectionType.Override)] public StateAction NodeInput;
		[Output(connectionType = ConnectionType.Multiple)] public StateAction[] Actions;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.SAOrderSensitive;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SAOrderSensitive data, MovesetGraph graph, string assetPath, UnityEngine.Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SAOrderSensitive));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			Actions = data.Actions;
			
			foreach (StateAction Actions_item in data.Actions)
			{
				switch (Actions_item.TID)
				{
					case StateAction.TypeId.StateAction:
						StateActionNode StateAction_node_Actions = graph.AddNode<StateActionNode>();
						GetPort("Actions").Connect(StateAction_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(StateAction_node_Actions, assetPath);
						variableCount += StateAction_node_Actions.SetData((StateAction)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SADebugMessage:
						SADebugMessageNode SADebugMessage_node_Actions = graph.AddNode<SADebugMessageNode>();
						GetPort("Actions").Connect(SADebugMessage_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SADebugMessage_node_Actions, assetPath);
						variableCount += SADebugMessage_node_Actions.SetData((SADebugMessage)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAPlayAnim:
						SAPlayAnimNode SAPlayAnim_node_Actions = graph.AddNode<SAPlayAnimNode>();
						GetPort("Actions").Connect(SAPlayAnim_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAPlayAnim_node_Actions, assetPath);
						variableCount += SAPlayAnim_node_Actions.SetData((SAPlayAnim)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAPlayRootAnim:
						SAPlayRootAnimNode SAPlayRootAnim_node_Actions = graph.AddNode<SAPlayRootAnimNode>();
						GetPort("Actions").Connect(SAPlayRootAnim_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAPlayRootAnim_node_Actions, assetPath);
						variableCount += SAPlayRootAnim_node_Actions.SetData((SAPlayRootAnim)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SASnapAnimWeights:
						SASnapAnimWeightsNode SASnapAnimWeights_node_Actions = graph.AddNode<SASnapAnimWeightsNode>();
						GetPort("Actions").Connect(SASnapAnimWeights_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SASnapAnimWeights_node_Actions, assetPath);
						variableCount += SASnapAnimWeights_node_Actions.SetData((SASnapAnimWeights)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAStandardInput:
						SAStandardInputNode SAStandardInput_node_Actions = graph.AddNode<SAStandardInputNode>();
						GetPort("Actions").Connect(SAStandardInput_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAStandardInput_node_Actions, assetPath);
						variableCount += SAStandardInput_node_Actions.SetData((SAStandardInput)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAInputAction:
						SAInputActionNode SAInputAction_node_Actions = graph.AddNode<SAInputActionNode>();
						GetPort("Actions").Connect(SAInputAction_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAInputAction_node_Actions, assetPath);
						variableCount += SAInputAction_node_Actions.SetData((SAInputAction)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SADeactivateInputAction:
						SADeactivateInputActionNode SADeactivateInputAction_node_Actions = graph.AddNode<SADeactivateInputActionNode>();
						GetPort("Actions").Connect(SADeactivateInputAction_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SADeactivateInputAction_node_Actions, assetPath);
						variableCount += SADeactivateInputAction_node_Actions.SetData((SADeactivateInputAction)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAAddInputEventFromFrame:
						SAAddInputEventFromFrameNode SAAddInputEventFromFrame_node_Actions = graph.AddNode<SAAddInputEventFromFrameNode>();
						GetPort("Actions").Connect(SAAddInputEventFromFrame_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAAddInputEventFromFrame_node_Actions, assetPath);
						variableCount += SAAddInputEventFromFrame_node_Actions.SetData((SAAddInputEventFromFrame)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SACancelToState:
						SACancelToStateNode SACancelToState_node_Actions = graph.AddNode<SACancelToStateNode>();
						GetPort("Actions").Connect(SACancelToState_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SACancelToState_node_Actions, assetPath);
						variableCount += SACancelToState_node_Actions.SetData((SACancelToState)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SACustomCall:
						SACustomCallNode SACustomCall_node_Actions = graph.AddNode<SACustomCallNode>();
						GetPort("Actions").Connect(SACustomCall_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SACustomCall_node_Actions, assetPath);
						variableCount += SACustomCall_node_Actions.SetData((SACustomCall)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SATimedAction:
						SATimedActionNode SATimedAction_node_Actions = graph.AddNode<SATimedActionNode>();
						GetPort("Actions").Connect(SATimedAction_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SATimedAction_node_Actions, assetPath);
						variableCount += SATimedAction_node_Actions.SetData((SATimedAction)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAOrderSensitive:
						SAOrderSensitiveNode SAOrderSensitive_node_Actions = graph.AddNode<SAOrderSensitiveNode>();
						GetPort("Actions").Connect(SAOrderSensitive_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAOrderSensitive_node_Actions, assetPath);
						variableCount += SAOrderSensitive_node_Actions.SetData((SAOrderSensitive)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAProxyMove:
						SAProxyMoveNode SAProxyMove_node_Actions = graph.AddNode<SAProxyMoveNode>();
						GetPort("Actions").Connect(SAProxyMove_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAProxyMove_node_Actions, assetPath);
						variableCount += SAProxyMove_node_Actions.SetData((SAProxyMove)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SACheckThing:
						SACheckThingNode SACheckThing_node_Actions = graph.AddNode<SACheckThingNode>();
						GetPort("Actions").Connect(SACheckThing_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SACheckThing_node_Actions, assetPath);
						variableCount += SACheckThing_node_Actions.SetData((SACheckThing)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAActiveAction:
						SAActiveActionNode SAActiveAction_node_Actions = graph.AddNode<SAActiveActionNode>();
						GetPort("Actions").Connect(SAActiveAction_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAActiveAction_node_Actions, assetPath);
						variableCount += SAActiveAction_node_Actions.SetData((SAActiveAction)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SADeactivateAction:
						SADeactivateActionNode SADeactivateAction_node_Actions = graph.AddNode<SADeactivateActionNode>();
						GetPort("Actions").Connect(SADeactivateAction_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SADeactivateAction_node_Actions, assetPath);
						variableCount += SADeactivateAction_node_Actions.SetData((SADeactivateAction)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SASetFloatTarget:
						SASetFloatTargetNode SASetFloatTarget_node_Actions = graph.AddNode<SASetFloatTargetNode>();
						GetPort("Actions").Connect(SASetFloatTarget_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SASetFloatTarget_node_Actions, assetPath);
						variableCount += SASetFloatTarget_node_Actions.SetData((SASetFloatTarget)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAOnBounce:
						SAOnBounceNode SAOnBounce_node_Actions = graph.AddNode<SAOnBounceNode>();
						GetPort("Actions").Connect(SAOnBounce_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAOnBounce_node_Actions, assetPath);
						variableCount += SAOnBounce_node_Actions.SetData((SAOnBounce)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAOnLeaveEdge:
						SAOnLeaveEdgeNode SAOnLeaveEdge_node_Actions = graph.AddNode<SAOnLeaveEdgeNode>();
						GetPort("Actions").Connect(SAOnLeaveEdge_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAOnLeaveEdge_node_Actions, assetPath);
						variableCount += SAOnLeaveEdge_node_Actions.SetData((SAOnLeaveEdge)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAOnStoppedAtEdge:
						SAOnStoppedAtEdgeNode SAOnStoppedAtEdge_node_Actions = graph.AddNode<SAOnStoppedAtEdgeNode>();
						GetPort("Actions").Connect(SAOnStoppedAtEdge_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAOnStoppedAtEdge_node_Actions, assetPath);
						variableCount += SAOnStoppedAtEdge_node_Actions.SetData((SAOnStoppedAtEdge)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAOnLand:
						SAOnLandNode SAOnLand_node_Actions = graph.AddNode<SAOnLandNode>();
						GetPort("Actions").Connect(SAOnLand_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAOnLand_node_Actions, assetPath);
						variableCount += SAOnLand_node_Actions.SetData((SAOnLand)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAOnCancel:
						SAOnCancelNode SAOnCancel_node_Actions = graph.AddNode<SAOnCancelNode>();
						GetPort("Actions").Connect(SAOnCancel_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAOnCancel_node_Actions, assetPath);
						variableCount += SAOnCancel_node_Actions.SetData((SAOnCancel)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SARefreshAttack:
						SARefreshAttackNode SARefreshAttack_node_Actions = graph.AddNode<SARefreshAttackNode>();
						GetPort("Actions").Connect(SARefreshAttack_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SARefreshAttack_node_Actions, assetPath);
						variableCount += SARefreshAttack_node_Actions.SetData((SARefreshAttack)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAEndAttack:
						SAEndAttackNode SAEndAttack_node_Actions = graph.AddNode<SAEndAttackNode>();
						GetPort("Actions").Connect(SAEndAttack_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAEndAttack_node_Actions, assetPath);
						variableCount += SAEndAttack_node_Actions.SetData((SAEndAttack)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SASetHitboxCount:
						SASetHitboxCountNode SASetHitboxCount_node_Actions = graph.AddNode<SASetHitboxCountNode>();
						GetPort("Actions").Connect(SASetHitboxCount_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SASetHitboxCount_node_Actions, assetPath);
						variableCount += SASetHitboxCount_node_Actions.SetData((SASetHitboxCount)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAConfigHitbox:
						SAConfigHitboxNode SAConfigHitbox_node_Actions = graph.AddNode<SAConfigHitboxNode>();
						GetPort("Actions").Connect(SAConfigHitbox_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAConfigHitbox_node_Actions, assetPath);
						variableCount += SAConfigHitbox_node_Actions.SetData((SAConfigHitbox)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SASetAtkProp:
						SASetAtkPropNode SASetAtkProp_node_Actions = graph.AddNode<SASetAtkPropNode>();
						GetPort("Actions").Connect(SASetAtkProp_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SASetAtkProp_node_Actions, assetPath);
						variableCount += SASetAtkProp_node_Actions.SetData((SASetAtkProp)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAManipHitBox:
						SAManipHitBoxNode SAManipHitBox_node_Actions = graph.AddNode<SAManipHitBoxNode>();
						GetPort("Actions").Connect(SAManipHitBox_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAManipHitBox_node_Actions, assetPath);
						variableCount += SAManipHitBox_node_Actions.SetData((SAManipHitBox)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAUpdateHurtboxes:
						SAUpdateHurtboxesNode SAUpdateHurtboxes_node_Actions = graph.AddNode<SAUpdateHurtboxesNode>();
						GetPort("Actions").Connect(SAUpdateHurtboxes_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAUpdateHurtboxes_node_Actions, assetPath);
						variableCount += SAUpdateHurtboxes_node_Actions.SetData((SAUpdateHurtboxes)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SASetupHurtboxes:
						SASetupHurtboxesNode SASetupHurtboxes_node_Actions = graph.AddNode<SASetupHurtboxesNode>();
						GetPort("Actions").Connect(SASetupHurtboxes_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SASetupHurtboxes_node_Actions, assetPath);
						variableCount += SASetupHurtboxes_node_Actions.SetData((SASetupHurtboxes)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAManipHurtBox:
						SAManipHurtBoxNode SAManipHurtBox_node_Actions = graph.AddNode<SAManipHurtBoxNode>();
						GetPort("Actions").Connect(SAManipHurtBox_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAManipHurtBox_node_Actions, assetPath);
						variableCount += SAManipHurtBox_node_Actions.SetData((SAManipHurtBox)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SABoneState:
						SABoneStateNode SABoneState_node_Actions = graph.AddNode<SABoneStateNode>();
						GetPort("Actions").Connect(SABoneState_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SABoneState_node_Actions, assetPath);
						variableCount += SABoneState_node_Actions.SetData((SABoneState)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SABoneScale:
						SABoneScaleNode SABoneScale_node_Actions = graph.AddNode<SABoneScaleNode>();
						GetPort("Actions").Connect(SABoneScale_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SABoneScale_node_Actions, assetPath);
						variableCount += SABoneScale_node_Actions.SetData((SABoneScale)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SASpawnAgent:
						SASpawnAgentNode SASpawnAgent_node_Actions = graph.AddNode<SASpawnAgentNode>();
						GetPort("Actions").Connect(SASpawnAgent_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SASpawnAgent_node_Actions, assetPath);
						variableCount += SASpawnAgent_node_Actions.SetData((SASpawnAgent)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SALocalFX:
						SALocalFXNode SALocalFX_node_Actions = graph.AddNode<SALocalFXNode>();
						GetPort("Actions").Connect(SALocalFX_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SALocalFX_node_Actions, assetPath);
						variableCount += SALocalFX_node_Actions.SetData((SALocalFX)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SASpawnFX:
						SASpawnFXNode SASpawnFX_node_Actions = graph.AddNode<SASpawnFXNode>();
						GetPort("Actions").Connect(SASpawnFX_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SASpawnFX_node_Actions, assetPath);
						variableCount += SASpawnFX_node_Actions.SetData((SASpawnFX)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SASetHitboxFX:
						SASetHitboxFXNode SASetHitboxFX_node_Actions = graph.AddNode<SASetHitboxFXNode>();
						GetPort("Actions").Connect(SASetHitboxFX_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SASetHitboxFX_node_Actions, assetPath);
						variableCount += SASetHitboxFX_node_Actions.SetData((SASetHitboxFX)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAPlaySFX:
						SAPlaySFXNode SAPlaySFX_node_Actions = graph.AddNode<SAPlaySFXNode>();
						GetPort("Actions").Connect(SAPlaySFX_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAPlaySFX_node_Actions, assetPath);
						variableCount += SAPlaySFX_node_Actions.SetData((SAPlaySFX)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SASetHitboxSFX:
						SASetHitboxSFXNode SASetHitboxSFX_node_Actions = graph.AddNode<SASetHitboxSFXNode>();
						GetPort("Actions").Connect(SASetHitboxSFX_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SASetHitboxSFX_node_Actions, assetPath);
						variableCount += SASetHitboxSFX_node_Actions.SetData((SASetHitboxSFX)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAColorTint:
						SAColorTintNode SAColorTint_node_Actions = graph.AddNode<SAColorTintNode>();
						GetPort("Actions").Connect(SAColorTint_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAColorTint_node_Actions, assetPath);
						variableCount += SAColorTint_node_Actions.SetData((SAColorTint)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAFindFloor:
						SAFindFloorNode SAFindFloor_node_Actions = graph.AddNode<SAFindFloorNode>();
						GetPort("Actions").Connect(SAFindFloor_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAFindFloor_node_Actions, assetPath);
						variableCount += SAFindFloor_node_Actions.SetData((SAFindFloor)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAHurtGrabbed:
						SAHurtGrabbedNode SAHurtGrabbed_node_Actions = graph.AddNode<SAHurtGrabbedNode>();
						GetPort("Actions").Connect(SAHurtGrabbed_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAHurtGrabbed_node_Actions, assetPath);
						variableCount += SAHurtGrabbed_node_Actions.SetData((SAHurtGrabbed)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SALaunchGrabbed:
						SALaunchGrabbedNode SALaunchGrabbed_node_Actions = graph.AddNode<SALaunchGrabbedNode>();
						GetPort("Actions").Connect(SALaunchGrabbed_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SALaunchGrabbed_node_Actions, assetPath);
						variableCount += SALaunchGrabbed_node_Actions.SetData((SALaunchGrabbed)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAStateCancelGrabbed:
						SAStateCancelGrabbedNode SAStateCancelGrabbed_node_Actions = graph.AddNode<SAStateCancelGrabbedNode>();
						GetPort("Actions").Connect(SAStateCancelGrabbed_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAStateCancelGrabbed_node_Actions, assetPath);
						variableCount += SAStateCancelGrabbed_node_Actions.SetData((SAStateCancelGrabbed)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAEndGrab:
						SAEndGrabNode SAEndGrab_node_Actions = graph.AddNode<SAEndGrabNode>();
						GetPort("Actions").Connect(SAEndGrab_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAEndGrab_node_Actions, assetPath);
						variableCount += SAEndGrab_node_Actions.SetData((SAEndGrab)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAGrabNotifyEscape:
						SAGrabNotifyEscapeNode SAGrabNotifyEscape_node_Actions = graph.AddNode<SAGrabNotifyEscapeNode>();
						GetPort("Actions").Connect(SAGrabNotifyEscape_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAGrabNotifyEscape_node_Actions, assetPath);
						variableCount += SAGrabNotifyEscape_node_Actions.SetData((SAGrabNotifyEscape)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAIgnoreGrabbed:
						SAIgnoreGrabbedNode SAIgnoreGrabbed_node_Actions = graph.AddNode<SAIgnoreGrabbedNode>();
						GetPort("Actions").Connect(SAIgnoreGrabbed_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAIgnoreGrabbed_node_Actions, assetPath);
						variableCount += SAIgnoreGrabbed_node_Actions.SetData((SAIgnoreGrabbed)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAEventKO:
						SAEventKONode SAEventKO_node_Actions = graph.AddNode<SAEventKONode>();
						GetPort("Actions").Connect(SAEventKO_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAEventKO_node_Actions, assetPath);
						variableCount += SAEventKO_node_Actions.SetData((SAEventKO)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAEventKOGrabbed:
						SAEventKOGrabbedNode SAEventKOGrabbed_node_Actions = graph.AddNode<SAEventKOGrabbedNode>();
						GetPort("Actions").Connect(SAEventKOGrabbed_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAEventKOGrabbed_node_Actions, assetPath);
						variableCount += SAEventKOGrabbed_node_Actions.SetData((SAEventKOGrabbed)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SACameraShake:
						SACameraShakeNode SACameraShake_node_Actions = graph.AddNode<SACameraShakeNode>();
						GetPort("Actions").Connect(SACameraShake_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SACameraShake_node_Actions, assetPath);
						variableCount += SACameraShake_node_Actions.SetData((SACameraShake)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAResetOnHits:
						SAResetOnHitsNode SAResetOnHits_node_Actions = graph.AddNode<SAResetOnHitsNode>();
						GetPort("Actions").Connect(SAResetOnHits_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAResetOnHits_node_Actions, assetPath);
						variableCount += SAResetOnHits_node_Actions.SetData((SAResetOnHits)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAOnHit:
						SAOnHitNode SAOnHit_node_Actions = graph.AddNode<SAOnHitNode>();
						GetPort("Actions").Connect(SAOnHit_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAOnHit_node_Actions, assetPath);
						variableCount += SAOnHit_node_Actions.SetData((SAOnHit)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAFastForwardState:
						SAFastForwardStateNode SAFastForwardState_node_Actions = graph.AddNode<SAFastForwardStateNode>();
						GetPort("Actions").Connect(SAFastForwardState_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAFastForwardState_node_Actions, assetPath);
						variableCount += SAFastForwardState_node_Actions.SetData((SAFastForwardState)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SATimingTweak:
						SATimingTweakNode SATimingTweak_node_Actions = graph.AddNode<SATimingTweakNode>();
						GetPort("Actions").Connect(SATimingTweak_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SATimingTweak_node_Actions, assetPath);
						variableCount += SATimingTweak_node_Actions.SetData((SATimingTweak)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAMapAnimation:
						SAMapAnimationNode SAMapAnimation_node_Actions = graph.AddNode<SAMapAnimationNode>();
						GetPort("Actions").Connect(SAMapAnimation_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAMapAnimation_node_Actions, assetPath);
						variableCount += SAMapAnimation_node_Actions.SetData((SAMapAnimation)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAAlterMoveDT:
						SAAlterMoveDTNode SAAlterMoveDT_node_Actions = graph.AddNode<SAAlterMoveDTNode>();
						GetPort("Actions").Connect(SAAlterMoveDT_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAAlterMoveDT_node_Actions, assetPath);
						variableCount += SAAlterMoveDT_node_Actions.SetData((SAAlterMoveDT)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAAlterMoveVel:
						SAAlterMoveVelNode SAAlterMoveVel_node_Actions = graph.AddNode<SAAlterMoveVelNode>();
						GetPort("Actions").Connect(SAAlterMoveVel_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAAlterMoveVel_node_Actions, assetPath);
						variableCount += SAAlterMoveVel_node_Actions.SetData((SAAlterMoveVel)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SASetStagePart:
						SASetStagePartNode SASetStagePart_node_Actions = graph.AddNode<SASetStagePartNode>();
						GetPort("Actions").Connect(SASetStagePart_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SASetStagePart_node_Actions, assetPath);
						variableCount += SASetStagePart_node_Actions.SetData((SASetStagePart)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SASetStagePartsDefault:
						SASetStagePartsDefaultNode SASetStagePartsDefault_node_Actions = graph.AddNode<SASetStagePartsDefaultNode>();
						GetPort("Actions").Connect(SASetStagePartsDefault_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SASetStagePartsDefault_node_Actions, assetPath);
						variableCount += SASetStagePartsDefault_node_Actions.SetData((SASetStagePartsDefault)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAJump:
						SAJumpNode SAJump_node_Actions = graph.AddNode<SAJumpNode>();
						GetPort("Actions").Connect(SAJump_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAJump_node_Actions, assetPath);
						variableCount += SAJump_node_Actions.SetData((SAJump)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAStopJump:
						SAStopJumpNode SAStopJump_node_Actions = graph.AddNode<SAStopJumpNode>();
						GetPort("Actions").Connect(SAStopJump_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAStopJump_node_Actions, assetPath);
						variableCount += SAStopJump_node_Actions.SetData((SAStopJump)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAManageAirJump:
						SAManageAirJumpNode SAManageAirJump_node_Actions = graph.AddNode<SAManageAirJumpNode>();
						GetPort("Actions").Connect(SAManageAirJump_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAManageAirJump_node_Actions, assetPath);
						variableCount += SAManageAirJump_node_Actions.SetData((SAManageAirJump)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SALeaveGround:
						SALeaveGroundNode SALeaveGround_node_Actions = graph.AddNode<SALeaveGroundNode>();
						GetPort("Actions").Connect(SALeaveGround_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SALeaveGround_node_Actions, assetPath);
						variableCount += SALeaveGround_node_Actions.SetData((SALeaveGround)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAUnHogEdge:
						SAUnHogEdgeNode SAUnHogEdge_node_Actions = graph.AddNode<SAUnHogEdgeNode>();
						GetPort("Actions").Connect(SAUnHogEdge_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAUnHogEdge_node_Actions, assetPath);
						variableCount += SAUnHogEdge_node_Actions.SetData((SAUnHogEdge)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAPlaySFXTimeline:
						SAPlaySFXTimelineNode SAPlaySFXTimeline_node_Actions = graph.AddNode<SAPlaySFXTimelineNode>();
						GetPort("Actions").Connect(SAPlaySFXTimeline_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAPlaySFXTimeline_node_Actions, assetPath);
						variableCount += SAPlaySFXTimeline_node_Actions.SetData((SAPlaySFXTimeline)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAFindLastHorizontalInput:
						SAFindLastHorizontalInputNode SAFindLastHorizontalInput_node_Actions = graph.AddNode<SAFindLastHorizontalInputNode>();
						GetPort("Actions").Connect(SAFindLastHorizontalInput_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAFindLastHorizontalInput_node_Actions, assetPath);
						variableCount += SAFindLastHorizontalInput_node_Actions.SetData((SAFindLastHorizontalInput)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SASetCommandGrab:
						SASetCommandGrabNode SASetCommandGrab_node_Actions = graph.AddNode<SASetCommandGrabNode>();
						GetPort("Actions").Connect(SASetCommandGrab_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SASetCommandGrab_node_Actions, assetPath);
						variableCount += SASetCommandGrab_node_Actions.SetData((SASetCommandGrab)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SACameraPunch:
						SACameraPunchNode SACameraPunch_node_Actions = graph.AddNode<SACameraPunchNode>();
						GetPort("Actions").Connect(SACameraPunch_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SACameraPunch_node_Actions, assetPath);
						variableCount += SACameraPunch_node_Actions.SetData((SACameraPunch)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SASpawnAgent2:
						SASpawnAgent2Node SASpawnAgent2_node_Actions = graph.AddNode<SASpawnAgent2Node>();
						GetPort("Actions").Connect(SASpawnAgent2_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SASpawnAgent2_node_Actions, assetPath);
						variableCount += SASpawnAgent2_node_Actions.SetData((SASpawnAgent2)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAManipDecorChain:
						SAManipDecorChainNode SAManipDecorChain_node_Actions = graph.AddNode<SAManipDecorChainNode>();
						GetPort("Actions").Connect(SAManipDecorChain_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAManipDecorChain_node_Actions, assetPath);
						variableCount += SAManipDecorChain_node_Actions.SetData((SAManipDecorChain)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAUpdateHitboxes:
						SAUpdateHitboxesNode SAUpdateHitboxes_node_Actions = graph.AddNode<SAUpdateHitboxesNode>();
						GetPort("Actions").Connect(SAUpdateHitboxes_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAUpdateHitboxes_node_Actions, assetPath);
						variableCount += SAUpdateHitboxes_node_Actions.SetData((SAUpdateHitboxes)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SASampleAnim:
						SASampleAnimNode SASampleAnim_node_Actions = graph.AddNode<SASampleAnimNode>();
						GetPort("Actions").Connect(SASampleAnim_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SASampleAnim_node_Actions, assetPath);
						variableCount += SASampleAnim_node_Actions.SetData((SASampleAnim)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAForceExtraInputCheck:
						SAForceExtraInputCheckNode SAForceExtraInputCheck_node_Actions = graph.AddNode<SAForceExtraInputCheckNode>();
						GetPort("Actions").Connect(SAForceExtraInputCheck_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAForceExtraInputCheck_node_Actions, assetPath);
						variableCount += SAForceExtraInputCheck_node_Actions.SetData((SAForceExtraInputCheck)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SALaunchGrabbedCustom:
						SALaunchGrabbedCustomNode SALaunchGrabbedCustom_node_Actions = graph.AddNode<SALaunchGrabbedCustomNode>();
						GetPort("Actions").Connect(SALaunchGrabbedCustom_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SALaunchGrabbedCustom_node_Actions, assetPath);
						variableCount += SALaunchGrabbedCustom_node_Actions.SetData((SALaunchGrabbedCustom)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAMapAnimationSimple:
						SAMapAnimationSimpleNode SAMapAnimationSimple_node_Actions = graph.AddNode<SAMapAnimationSimpleNode>();
						GetPort("Actions").Connect(SAMapAnimationSimple_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAMapAnimationSimple_node_Actions, assetPath);
						variableCount += SAMapAnimationSimple_node_Actions.SetData((SAMapAnimationSimple)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAPersistLocalFX:
						SAPersistLocalFXNode SAPersistLocalFX_node_Actions = graph.AddNode<SAPersistLocalFXNode>();
						GetPort("Actions").Connect(SAPersistLocalFX_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAPersistLocalFX_node_Actions, assetPath);
						variableCount += SAPersistLocalFX_node_Actions.SetData((SAPersistLocalFX)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAOnLeaveParent:
						SAOnLeaveParentNode SAOnLeaveParent_node_Actions = graph.AddNode<SAOnLeaveParentNode>();
						GetPort("Actions").Connect(SAOnLeaveParent_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAOnLeaveParent_node_Actions, assetPath);
						variableCount += SAOnLeaveParent_node_Actions.SetData((SAOnLeaveParent)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAPlayVoiceLine:
						SAPlayVoiceLineNode SAPlayVoiceLine_node_Actions = graph.AddNode<SAPlayVoiceLineNode>();
						GetPort("Actions").Connect(SAPlayVoiceLine_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAPlayVoiceLine_node_Actions, assetPath);
						variableCount += SAPlayVoiceLine_node_Actions.SetData((SAPlayVoiceLine)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAPlayCategoryVoiceLine:
						SAPlayCategoryVoiceLineNode SAPlayCategoryVoiceLine_node_Actions = graph.AddNode<SAPlayCategoryVoiceLineNode>();
						GetPort("Actions").Connect(SAPlayCategoryVoiceLine_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAPlayCategoryVoiceLine_node_Actions, assetPath);
						variableCount += SAPlayCategoryVoiceLine_node_Actions.SetData((SAPlayCategoryVoiceLine)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAStopVoiceLines:
						SAStopVoiceLinesNode SAStopVoiceLines_node_Actions = graph.AddNode<SAStopVoiceLinesNode>();
						GetPort("Actions").Connect(SAStopVoiceLines_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAStopVoiceLines_node_Actions, assetPath);
						variableCount += SAStopVoiceLines_node_Actions.SetData((SAStopVoiceLines)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
				}
				++variableCount;
			}
			
			return variableCount;
		}
		
		public new SAOrderSensitive GetData()
		{
			SAOrderSensitive objToReturn = new SAOrderSensitive();
			objToReturn.TID = TypeId.SAOrderSensitive;
			objToReturn.Actions = new StateAction[GetPort("Actions").ConnectionCount];
			int i = 0;
			foreach(NodePort port in GetPort("Actions").GetConnections())
			{
				StateActionNode StateAction_Node = (StateActionNode)port.node;
				switch (StateAction_Node.TID)
				{
					case StateAction.TypeId.StateAction:
						StateActionNode StateAction_StateAction_Node = (StateActionNode)port.node;
						objToReturn.Actions[i] = StateAction_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SADebugMessage:
						SADebugMessageNode SADebugMessage_StateAction_Node = (SADebugMessageNode)port.node;
						objToReturn.Actions[i] = SADebugMessage_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAPlayAnim:
						SAPlayAnimNode SAPlayAnim_StateAction_Node = (SAPlayAnimNode)port.node;
						objToReturn.Actions[i] = SAPlayAnim_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAPlayRootAnim:
						SAPlayRootAnimNode SAPlayRootAnim_StateAction_Node = (SAPlayRootAnimNode)port.node;
						objToReturn.Actions[i] = SAPlayRootAnim_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASnapAnimWeights:
						SASnapAnimWeightsNode SASnapAnimWeights_StateAction_Node = (SASnapAnimWeightsNode)port.node;
						objToReturn.Actions[i] = SASnapAnimWeights_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAStandardInput:
						SAStandardInputNode SAStandardInput_StateAction_Node = (SAStandardInputNode)port.node;
						objToReturn.Actions[i] = SAStandardInput_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAInputAction:
						SAInputActionNode SAInputAction_StateAction_Node = (SAInputActionNode)port.node;
						objToReturn.Actions[i] = SAInputAction_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SADeactivateInputAction:
						SADeactivateInputActionNode SADeactivateInputAction_StateAction_Node = (SADeactivateInputActionNode)port.node;
						objToReturn.Actions[i] = SADeactivateInputAction_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAAddInputEventFromFrame:
						SAAddInputEventFromFrameNode SAAddInputEventFromFrame_StateAction_Node = (SAAddInputEventFromFrameNode)port.node;
						objToReturn.Actions[i] = SAAddInputEventFromFrame_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SACancelToState:
						SACancelToStateNode SACancelToState_StateAction_Node = (SACancelToStateNode)port.node;
						objToReturn.Actions[i] = SACancelToState_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SACustomCall:
						SACustomCallNode SACustomCall_StateAction_Node = (SACustomCallNode)port.node;
						objToReturn.Actions[i] = SACustomCall_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SATimedAction:
						SATimedActionNode SATimedAction_StateAction_Node = (SATimedActionNode)port.node;
						objToReturn.Actions[i] = SATimedAction_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAOrderSensitive:
						SAOrderSensitiveNode SAOrderSensitive_StateAction_Node = (SAOrderSensitiveNode)port.node;
						objToReturn.Actions[i] = SAOrderSensitive_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAProxyMove:
						SAProxyMoveNode SAProxyMove_StateAction_Node = (SAProxyMoveNode)port.node;
						objToReturn.Actions[i] = SAProxyMove_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SACheckThing:
						SACheckThingNode SACheckThing_StateAction_Node = (SACheckThingNode)port.node;
						objToReturn.Actions[i] = SACheckThing_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAActiveAction:
						SAActiveActionNode SAActiveAction_StateAction_Node = (SAActiveActionNode)port.node;
						objToReturn.Actions[i] = SAActiveAction_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SADeactivateAction:
						SADeactivateActionNode SADeactivateAction_StateAction_Node = (SADeactivateActionNode)port.node;
						objToReturn.Actions[i] = SADeactivateAction_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASetFloatTarget:
						SASetFloatTargetNode SASetFloatTarget_StateAction_Node = (SASetFloatTargetNode)port.node;
						objToReturn.Actions[i] = SASetFloatTarget_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAOnBounce:
						SAOnBounceNode SAOnBounce_StateAction_Node = (SAOnBounceNode)port.node;
						objToReturn.Actions[i] = SAOnBounce_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAOnLeaveEdge:
						SAOnLeaveEdgeNode SAOnLeaveEdge_StateAction_Node = (SAOnLeaveEdgeNode)port.node;
						objToReturn.Actions[i] = SAOnLeaveEdge_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAOnStoppedAtEdge:
						SAOnStoppedAtEdgeNode SAOnStoppedAtEdge_StateAction_Node = (SAOnStoppedAtEdgeNode)port.node;
						objToReturn.Actions[i] = SAOnStoppedAtEdge_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAOnLand:
						SAOnLandNode SAOnLand_StateAction_Node = (SAOnLandNode)port.node;
						objToReturn.Actions[i] = SAOnLand_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAOnCancel:
						SAOnCancelNode SAOnCancel_StateAction_Node = (SAOnCancelNode)port.node;
						objToReturn.Actions[i] = SAOnCancel_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SARefreshAttack:
						SARefreshAttackNode SARefreshAttack_StateAction_Node = (SARefreshAttackNode)port.node;
						objToReturn.Actions[i] = SARefreshAttack_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAEndAttack:
						SAEndAttackNode SAEndAttack_StateAction_Node = (SAEndAttackNode)port.node;
						objToReturn.Actions[i] = SAEndAttack_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASetHitboxCount:
						SASetHitboxCountNode SASetHitboxCount_StateAction_Node = (SASetHitboxCountNode)port.node;
						objToReturn.Actions[i] = SASetHitboxCount_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAConfigHitbox:
						SAConfigHitboxNode SAConfigHitbox_StateAction_Node = (SAConfigHitboxNode)port.node;
						objToReturn.Actions[i] = SAConfigHitbox_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASetAtkProp:
						SASetAtkPropNode SASetAtkProp_StateAction_Node = (SASetAtkPropNode)port.node;
						objToReturn.Actions[i] = SASetAtkProp_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAManipHitBox:
						SAManipHitBoxNode SAManipHitBox_StateAction_Node = (SAManipHitBoxNode)port.node;
						objToReturn.Actions[i] = SAManipHitBox_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAUpdateHurtboxes:
						SAUpdateHurtboxesNode SAUpdateHurtboxes_StateAction_Node = (SAUpdateHurtboxesNode)port.node;
						objToReturn.Actions[i] = SAUpdateHurtboxes_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASetupHurtboxes:
						SASetupHurtboxesNode SASetupHurtboxes_StateAction_Node = (SASetupHurtboxesNode)port.node;
						objToReturn.Actions[i] = SASetupHurtboxes_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAManipHurtBox:
						SAManipHurtBoxNode SAManipHurtBox_StateAction_Node = (SAManipHurtBoxNode)port.node;
						objToReturn.Actions[i] = SAManipHurtBox_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SABoneState:
						SABoneStateNode SABoneState_StateAction_Node = (SABoneStateNode)port.node;
						objToReturn.Actions[i] = SABoneState_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SABoneScale:
						SABoneScaleNode SABoneScale_StateAction_Node = (SABoneScaleNode)port.node;
						objToReturn.Actions[i] = SABoneScale_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASpawnAgent:
						SASpawnAgentNode SASpawnAgent_StateAction_Node = (SASpawnAgentNode)port.node;
						objToReturn.Actions[i] = SASpawnAgent_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SALocalFX:
						SALocalFXNode SALocalFX_StateAction_Node = (SALocalFXNode)port.node;
						objToReturn.Actions[i] = SALocalFX_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASpawnFX:
						SASpawnFXNode SASpawnFX_StateAction_Node = (SASpawnFXNode)port.node;
						objToReturn.Actions[i] = SASpawnFX_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASetHitboxFX:
						SASetHitboxFXNode SASetHitboxFX_StateAction_Node = (SASetHitboxFXNode)port.node;
						objToReturn.Actions[i] = SASetHitboxFX_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAPlaySFX:
						SAPlaySFXNode SAPlaySFX_StateAction_Node = (SAPlaySFXNode)port.node;
						objToReturn.Actions[i] = SAPlaySFX_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASetHitboxSFX:
						SASetHitboxSFXNode SASetHitboxSFX_StateAction_Node = (SASetHitboxSFXNode)port.node;
						objToReturn.Actions[i] = SASetHitboxSFX_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAColorTint:
						SAColorTintNode SAColorTint_StateAction_Node = (SAColorTintNode)port.node;
						objToReturn.Actions[i] = SAColorTint_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAFindFloor:
						SAFindFloorNode SAFindFloor_StateAction_Node = (SAFindFloorNode)port.node;
						objToReturn.Actions[i] = SAFindFloor_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAHurtGrabbed:
						SAHurtGrabbedNode SAHurtGrabbed_StateAction_Node = (SAHurtGrabbedNode)port.node;
						objToReturn.Actions[i] = SAHurtGrabbed_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SALaunchGrabbed:
						SALaunchGrabbedNode SALaunchGrabbed_StateAction_Node = (SALaunchGrabbedNode)port.node;
						objToReturn.Actions[i] = SALaunchGrabbed_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAStateCancelGrabbed:
						SAStateCancelGrabbedNode SAStateCancelGrabbed_StateAction_Node = (SAStateCancelGrabbedNode)port.node;
						objToReturn.Actions[i] = SAStateCancelGrabbed_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAEndGrab:
						SAEndGrabNode SAEndGrab_StateAction_Node = (SAEndGrabNode)port.node;
						objToReturn.Actions[i] = SAEndGrab_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAGrabNotifyEscape:
						SAGrabNotifyEscapeNode SAGrabNotifyEscape_StateAction_Node = (SAGrabNotifyEscapeNode)port.node;
						objToReturn.Actions[i] = SAGrabNotifyEscape_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAIgnoreGrabbed:
						SAIgnoreGrabbedNode SAIgnoreGrabbed_StateAction_Node = (SAIgnoreGrabbedNode)port.node;
						objToReturn.Actions[i] = SAIgnoreGrabbed_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAEventKO:
						SAEventKONode SAEventKO_StateAction_Node = (SAEventKONode)port.node;
						objToReturn.Actions[i] = SAEventKO_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAEventKOGrabbed:
						SAEventKOGrabbedNode SAEventKOGrabbed_StateAction_Node = (SAEventKOGrabbedNode)port.node;
						objToReturn.Actions[i] = SAEventKOGrabbed_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SACameraShake:
						SACameraShakeNode SACameraShake_StateAction_Node = (SACameraShakeNode)port.node;
						objToReturn.Actions[i] = SACameraShake_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAResetOnHits:
						SAResetOnHitsNode SAResetOnHits_StateAction_Node = (SAResetOnHitsNode)port.node;
						objToReturn.Actions[i] = SAResetOnHits_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAOnHit:
						SAOnHitNode SAOnHit_StateAction_Node = (SAOnHitNode)port.node;
						objToReturn.Actions[i] = SAOnHit_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAFastForwardState:
						SAFastForwardStateNode SAFastForwardState_StateAction_Node = (SAFastForwardStateNode)port.node;
						objToReturn.Actions[i] = SAFastForwardState_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SATimingTweak:
						SATimingTweakNode SATimingTweak_StateAction_Node = (SATimingTweakNode)port.node;
						objToReturn.Actions[i] = SATimingTweak_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAMapAnimation:
						SAMapAnimationNode SAMapAnimation_StateAction_Node = (SAMapAnimationNode)port.node;
						objToReturn.Actions[i] = SAMapAnimation_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAAlterMoveDT:
						SAAlterMoveDTNode SAAlterMoveDT_StateAction_Node = (SAAlterMoveDTNode)port.node;
						objToReturn.Actions[i] = SAAlterMoveDT_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAAlterMoveVel:
						SAAlterMoveVelNode SAAlterMoveVel_StateAction_Node = (SAAlterMoveVelNode)port.node;
						objToReturn.Actions[i] = SAAlterMoveVel_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASetStagePart:
						SASetStagePartNode SASetStagePart_StateAction_Node = (SASetStagePartNode)port.node;
						objToReturn.Actions[i] = SASetStagePart_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASetStagePartsDefault:
						SASetStagePartsDefaultNode SASetStagePartsDefault_StateAction_Node = (SASetStagePartsDefaultNode)port.node;
						objToReturn.Actions[i] = SASetStagePartsDefault_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAJump:
						SAJumpNode SAJump_StateAction_Node = (SAJumpNode)port.node;
						objToReturn.Actions[i] = SAJump_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAStopJump:
						SAStopJumpNode SAStopJump_StateAction_Node = (SAStopJumpNode)port.node;
						objToReturn.Actions[i] = SAStopJump_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAManageAirJump:
						SAManageAirJumpNode SAManageAirJump_StateAction_Node = (SAManageAirJumpNode)port.node;
						objToReturn.Actions[i] = SAManageAirJump_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SALeaveGround:
						SALeaveGroundNode SALeaveGround_StateAction_Node = (SALeaveGroundNode)port.node;
						objToReturn.Actions[i] = SALeaveGround_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAUnHogEdge:
						SAUnHogEdgeNode SAUnHogEdge_StateAction_Node = (SAUnHogEdgeNode)port.node;
						objToReturn.Actions[i] = SAUnHogEdge_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAPlaySFXTimeline:
						SAPlaySFXTimelineNode SAPlaySFXTimeline_StateAction_Node = (SAPlaySFXTimelineNode)port.node;
						objToReturn.Actions[i] = SAPlaySFXTimeline_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAFindLastHorizontalInput:
						SAFindLastHorizontalInputNode SAFindLastHorizontalInput_StateAction_Node = (SAFindLastHorizontalInputNode)port.node;
						objToReturn.Actions[i] = SAFindLastHorizontalInput_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASetCommandGrab:
						SASetCommandGrabNode SASetCommandGrab_StateAction_Node = (SASetCommandGrabNode)port.node;
						objToReturn.Actions[i] = SASetCommandGrab_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SACameraPunch:
						SACameraPunchNode SACameraPunch_StateAction_Node = (SACameraPunchNode)port.node;
						objToReturn.Actions[i] = SACameraPunch_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASpawnAgent2:
						SASpawnAgent2Node SASpawnAgent2_StateAction_Node = (SASpawnAgent2Node)port.node;
						objToReturn.Actions[i] = SASpawnAgent2_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAManipDecorChain:
						SAManipDecorChainNode SAManipDecorChain_StateAction_Node = (SAManipDecorChainNode)port.node;
						objToReturn.Actions[i] = SAManipDecorChain_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAUpdateHitboxes:
						SAUpdateHitboxesNode SAUpdateHitboxes_StateAction_Node = (SAUpdateHitboxesNode)port.node;
						objToReturn.Actions[i] = SAUpdateHitboxes_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASampleAnim:
						SASampleAnimNode SASampleAnim_StateAction_Node = (SASampleAnimNode)port.node;
						objToReturn.Actions[i] = SASampleAnim_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAForceExtraInputCheck:
						SAForceExtraInputCheckNode SAForceExtraInputCheck_StateAction_Node = (SAForceExtraInputCheckNode)port.node;
						objToReturn.Actions[i] = SAForceExtraInputCheck_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SALaunchGrabbedCustom:
						SALaunchGrabbedCustomNode SALaunchGrabbedCustom_StateAction_Node = (SALaunchGrabbedCustomNode)port.node;
						objToReturn.Actions[i] = SALaunchGrabbedCustom_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAMapAnimationSimple:
						SAMapAnimationSimpleNode SAMapAnimationSimple_StateAction_Node = (SAMapAnimationSimpleNode)port.node;
						objToReturn.Actions[i] = SAMapAnimationSimple_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAPersistLocalFX:
						SAPersistLocalFXNode SAPersistLocalFX_StateAction_Node = (SAPersistLocalFXNode)port.node;
						objToReturn.Actions[i] = SAPersistLocalFX_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAOnLeaveParent:
						SAOnLeaveParentNode SAOnLeaveParent_StateAction_Node = (SAOnLeaveParentNode)port.node;
						objToReturn.Actions[i] = SAOnLeaveParent_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAPlayVoiceLine:
						SAPlayVoiceLineNode SAPlayVoiceLine_StateAction_Node = (SAPlayVoiceLineNode)port.node;
						objToReturn.Actions[i] = SAPlayVoiceLine_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAPlayCategoryVoiceLine:
						SAPlayCategoryVoiceLineNode SAPlayCategoryVoiceLine_StateAction_Node = (SAPlayCategoryVoiceLineNode)port.node;
						objToReturn.Actions[i] = SAPlayCategoryVoiceLine_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAStopVoiceLines:
						SAStopVoiceLinesNode SAStopVoiceLines_StateAction_Node = (SAStopVoiceLinesNode)port.node;
						objToReturn.Actions[i] = SAStopVoiceLines_StateAction_Node.GetData();
					break;
				}
				++i;
			}
			return objToReturn;
		}
	}
}

