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
using System.Linq;
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
		[Range(2, 50)] public int listSize = 0;
		
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
			
			listSize = data.Actions.Length;
			
			foreach (StateAction Actions_item in data.Actions)
			{
				// Create dynamic ports based on number of actions
				string portName = "" + (DynamicPorts.Count() + 1);
				AddDynamicOutput(typeof(StateAction), ConnectionType.Override, TypeConstraint.None, portName);
				
				switch (Actions_item.TID)
				{
					case StateAction.TypeId.StateAction:
						StateActionNode StateAction_node_Actions = graph.AddNode<StateActionNode>();
						GetPort(portName).Connect(StateAction_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(StateAction_node_Actions, assetPath);
						variableCount += StateAction_node_Actions.SetData((StateAction)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SADebugMessage:
						SADebugMessageNode SADebugMessage_node_Actions = graph.AddNode<SADebugMessageNode>();
						GetPort(portName).Connect(SADebugMessage_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SADebugMessage_node_Actions, assetPath);
						variableCount += SADebugMessage_node_Actions.SetData((SADebugMessage)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAPlayAnim:
						SAPlayAnimNode SAPlayAnim_node_Actions = graph.AddNode<SAPlayAnimNode>();
						GetPort(portName).Connect(SAPlayAnim_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAPlayAnim_node_Actions, assetPath);
						variableCount += SAPlayAnim_node_Actions.SetData((SAPlayAnim)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAPlayRootAnim:
						SAPlayRootAnimNode SAPlayRootAnim_node_Actions = graph.AddNode<SAPlayRootAnimNode>();
						GetPort(portName).Connect(SAPlayRootAnim_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAPlayRootAnim_node_Actions, assetPath);
						variableCount += SAPlayRootAnim_node_Actions.SetData((SAPlayRootAnim)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SASnapAnimWeights:
						SASnapAnimWeightsNode SASnapAnimWeights_node_Actions = graph.AddNode<SASnapAnimWeightsNode>();
						GetPort(portName).Connect(SASnapAnimWeights_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SASnapAnimWeights_node_Actions, assetPath);
						variableCount += SASnapAnimWeights_node_Actions.SetData((SASnapAnimWeights)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAStandardInput:
						SAStandardInputNode SAStandardInput_node_Actions = graph.AddNode<SAStandardInputNode>();
						GetPort(portName).Connect(SAStandardInput_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAStandardInput_node_Actions, assetPath);
						variableCount += SAStandardInput_node_Actions.SetData((SAStandardInput)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAInputAction:
						SAInputActionNode SAInputAction_node_Actions = graph.AddNode<SAInputActionNode>();
						GetPort(portName).Connect(SAInputAction_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAInputAction_node_Actions, assetPath);
						variableCount += SAInputAction_node_Actions.SetData((SAInputAction)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SADeactivateInputAction:
						SADeactivateInputActionNode SADeactivateInputAction_node_Actions = graph.AddNode<SADeactivateInputActionNode>();
						GetPort(portName).Connect(SADeactivateInputAction_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SADeactivateInputAction_node_Actions, assetPath);
						variableCount += SADeactivateInputAction_node_Actions.SetData((SADeactivateInputAction)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAAddInputEventFromFrame:
						SAAddInputEventFromFrameNode SAAddInputEventFromFrame_node_Actions = graph.AddNode<SAAddInputEventFromFrameNode>();
						GetPort(portName).Connect(SAAddInputEventFromFrame_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAAddInputEventFromFrame_node_Actions, assetPath);
						variableCount += SAAddInputEventFromFrame_node_Actions.SetData((SAAddInputEventFromFrame)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SACancelToState:
						SACancelToStateNode SACancelToState_node_Actions = graph.AddNode<SACancelToStateNode>();
						GetPort(portName).Connect(SACancelToState_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SACancelToState_node_Actions, assetPath);
						variableCount += SACancelToState_node_Actions.SetData((SACancelToState)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SACustomCall:
						SACustomCallNode SACustomCall_node_Actions = graph.AddNode<SACustomCallNode>();
						GetPort(portName).Connect(SACustomCall_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SACustomCall_node_Actions, assetPath);
						variableCount += SACustomCall_node_Actions.SetData((SACustomCall)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SATimedAction:
						SATimedActionNode SATimedAction_node_Actions = graph.AddNode<SATimedActionNode>();
						GetPort(portName).Connect(SATimedAction_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SATimedAction_node_Actions, assetPath);
						variableCount += SATimedAction_node_Actions.SetData((SATimedAction)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAOrderSensitive:
						SAOrderSensitiveNode SAOrderSensitive_node_Actions = graph.AddNode<SAOrderSensitiveNode>();
						GetPort(portName).Connect(SAOrderSensitive_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAOrderSensitive_node_Actions, assetPath);
						variableCount += SAOrderSensitive_node_Actions.SetData((SAOrderSensitive)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAProxyMove:
						SAProxyMoveNode SAProxyMove_node_Actions = graph.AddNode<SAProxyMoveNode>();
						GetPort(portName).Connect(SAProxyMove_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAProxyMove_node_Actions, assetPath);
						variableCount += SAProxyMove_node_Actions.SetData((SAProxyMove)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SACheckThing:
						SACheckThingNode SACheckThing_node_Actions = graph.AddNode<SACheckThingNode>();
						GetPort(portName).Connect(SACheckThing_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SACheckThing_node_Actions, assetPath);
						variableCount += SACheckThing_node_Actions.SetData((SACheckThing)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAActiveAction:
						SAActiveActionNode SAActiveAction_node_Actions = graph.AddNode<SAActiveActionNode>();
						GetPort(portName).Connect(SAActiveAction_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAActiveAction_node_Actions, assetPath);
						variableCount += SAActiveAction_node_Actions.SetData((SAActiveAction)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SADeactivateAction:
						SADeactivateActionNode SADeactivateAction_node_Actions = graph.AddNode<SADeactivateActionNode>();
						GetPort(portName).Connect(SADeactivateAction_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SADeactivateAction_node_Actions, assetPath);
						variableCount += SADeactivateAction_node_Actions.SetData((SADeactivateAction)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SASetFloatTarget:
						SASetFloatTargetNode SASetFloatTarget_node_Actions = graph.AddNode<SASetFloatTargetNode>();
						GetPort(portName).Connect(SASetFloatTarget_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SASetFloatTarget_node_Actions, assetPath);
						variableCount += SASetFloatTarget_node_Actions.SetData((SASetFloatTarget)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAOnBounce:
						SAOnBounceNode SAOnBounce_node_Actions = graph.AddNode<SAOnBounceNode>();
						GetPort(portName).Connect(SAOnBounce_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAOnBounce_node_Actions, assetPath);
						variableCount += SAOnBounce_node_Actions.SetData((SAOnBounce)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAOnLeaveEdge:
						SAOnLeaveEdgeNode SAOnLeaveEdge_node_Actions = graph.AddNode<SAOnLeaveEdgeNode>();
						GetPort(portName).Connect(SAOnLeaveEdge_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAOnLeaveEdge_node_Actions, assetPath);
						variableCount += SAOnLeaveEdge_node_Actions.SetData((SAOnLeaveEdge)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAOnStoppedAtEdge:
						SAOnStoppedAtEdgeNode SAOnStoppedAtEdge_node_Actions = graph.AddNode<SAOnStoppedAtEdgeNode>();
						GetPort(portName).Connect(SAOnStoppedAtEdge_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAOnStoppedAtEdge_node_Actions, assetPath);
						variableCount += SAOnStoppedAtEdge_node_Actions.SetData((SAOnStoppedAtEdge)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAOnLand:
						SAOnLandNode SAOnLand_node_Actions = graph.AddNode<SAOnLandNode>();
						GetPort(portName).Connect(SAOnLand_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAOnLand_node_Actions, assetPath);
						variableCount += SAOnLand_node_Actions.SetData((SAOnLand)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAOnCancel:
						SAOnCancelNode SAOnCancel_node_Actions = graph.AddNode<SAOnCancelNode>();
						GetPort(portName).Connect(SAOnCancel_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAOnCancel_node_Actions, assetPath);
						variableCount += SAOnCancel_node_Actions.SetData((SAOnCancel)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SARefreshAttack:
						SARefreshAttackNode SARefreshAttack_node_Actions = graph.AddNode<SARefreshAttackNode>();
						GetPort(portName).Connect(SARefreshAttack_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SARefreshAttack_node_Actions, assetPath);
						variableCount += SARefreshAttack_node_Actions.SetData((SARefreshAttack)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAEndAttack:
						SAEndAttackNode SAEndAttack_node_Actions = graph.AddNode<SAEndAttackNode>();
						GetPort(portName).Connect(SAEndAttack_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAEndAttack_node_Actions, assetPath);
						variableCount += SAEndAttack_node_Actions.SetData((SAEndAttack)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SASetHitboxCount:
						SASetHitboxCountNode SASetHitboxCount_node_Actions = graph.AddNode<SASetHitboxCountNode>();
						GetPort(portName).Connect(SASetHitboxCount_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SASetHitboxCount_node_Actions, assetPath);
						variableCount += SASetHitboxCount_node_Actions.SetData((SASetHitboxCount)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAConfigHitbox:
						SAConfigHitboxNode SAConfigHitbox_node_Actions = graph.AddNode<SAConfigHitboxNode>();
						GetPort(portName).Connect(SAConfigHitbox_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAConfigHitbox_node_Actions, assetPath);
						variableCount += SAConfigHitbox_node_Actions.SetData((SAConfigHitbox)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SASetAtkProp:
						SASetAtkPropNode SASetAtkProp_node_Actions = graph.AddNode<SASetAtkPropNode>();
						GetPort(portName).Connect(SASetAtkProp_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SASetAtkProp_node_Actions, assetPath);
						variableCount += SASetAtkProp_node_Actions.SetData((SASetAtkProp)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAManipHitBox:
						SAManipHitBoxNode SAManipHitBox_node_Actions = graph.AddNode<SAManipHitBoxNode>();
						GetPort(portName).Connect(SAManipHitBox_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAManipHitBox_node_Actions, assetPath);
						variableCount += SAManipHitBox_node_Actions.SetData((SAManipHitBox)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAUpdateHurtboxes:
						SAUpdateHurtboxesNode SAUpdateHurtboxes_node_Actions = graph.AddNode<SAUpdateHurtboxesNode>();
						GetPort(portName).Connect(SAUpdateHurtboxes_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAUpdateHurtboxes_node_Actions, assetPath);
						variableCount += SAUpdateHurtboxes_node_Actions.SetData((SAUpdateHurtboxes)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SASetupHurtboxes:
						SASetupHurtboxesNode SASetupHurtboxes_node_Actions = graph.AddNode<SASetupHurtboxesNode>();
						GetPort(portName).Connect(SASetupHurtboxes_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SASetupHurtboxes_node_Actions, assetPath);
						variableCount += SASetupHurtboxes_node_Actions.SetData((SASetupHurtboxes)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAManipHurtBox:
						SAManipHurtBoxNode SAManipHurtBox_node_Actions = graph.AddNode<SAManipHurtBoxNode>();
						GetPort(portName).Connect(SAManipHurtBox_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAManipHurtBox_node_Actions, assetPath);
						variableCount += SAManipHurtBox_node_Actions.SetData((SAManipHurtBox)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SABoneState:
						SABoneStateNode SABoneState_node_Actions = graph.AddNode<SABoneStateNode>();
						GetPort(portName).Connect(SABoneState_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SABoneState_node_Actions, assetPath);
						variableCount += SABoneState_node_Actions.SetData((SABoneState)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SABoneScale:
						SABoneScaleNode SABoneScale_node_Actions = graph.AddNode<SABoneScaleNode>();
						GetPort(portName).Connect(SABoneScale_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SABoneScale_node_Actions, assetPath);
						variableCount += SABoneScale_node_Actions.SetData((SABoneScale)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SASpawnAgent:
						SASpawnAgentNode SASpawnAgent_node_Actions = graph.AddNode<SASpawnAgentNode>();
						GetPort(portName).Connect(SASpawnAgent_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SASpawnAgent_node_Actions, assetPath);
						variableCount += SASpawnAgent_node_Actions.SetData((SASpawnAgent)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SALocalFX:
						SALocalFXNode SALocalFX_node_Actions = graph.AddNode<SALocalFXNode>();
						GetPort(portName).Connect(SALocalFX_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SALocalFX_node_Actions, assetPath);
						variableCount += SALocalFX_node_Actions.SetData((SALocalFX)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SASpawnFX:
						SASpawnFXNode SASpawnFX_node_Actions = graph.AddNode<SASpawnFXNode>();
						GetPort(portName).Connect(SASpawnFX_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SASpawnFX_node_Actions, assetPath);
						variableCount += SASpawnFX_node_Actions.SetData((SASpawnFX)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SASetHitboxFX:
						SASetHitboxFXNode SASetHitboxFX_node_Actions = graph.AddNode<SASetHitboxFXNode>();
						GetPort(portName).Connect(SASetHitboxFX_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SASetHitboxFX_node_Actions, assetPath);
						variableCount += SASetHitboxFX_node_Actions.SetData((SASetHitboxFX)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAPlaySFX:
						SAPlaySFXNode SAPlaySFX_node_Actions = graph.AddNode<SAPlaySFXNode>();
						GetPort(portName).Connect(SAPlaySFX_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAPlaySFX_node_Actions, assetPath);
						variableCount += SAPlaySFX_node_Actions.SetData((SAPlaySFX)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SASetHitboxSFX:
						SASetHitboxSFXNode SASetHitboxSFX_node_Actions = graph.AddNode<SASetHitboxSFXNode>();
						GetPort(portName).Connect(SASetHitboxSFX_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SASetHitboxSFX_node_Actions, assetPath);
						variableCount += SASetHitboxSFX_node_Actions.SetData((SASetHitboxSFX)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAColorTint:
						SAColorTintNode SAColorTint_node_Actions = graph.AddNode<SAColorTintNode>();
						GetPort(portName).Connect(SAColorTint_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAColorTint_node_Actions, assetPath);
						variableCount += SAColorTint_node_Actions.SetData((SAColorTint)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAFindFloor:
						SAFindFloorNode SAFindFloor_node_Actions = graph.AddNode<SAFindFloorNode>();
						GetPort(portName).Connect(SAFindFloor_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAFindFloor_node_Actions, assetPath);
						variableCount += SAFindFloor_node_Actions.SetData((SAFindFloor)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAHurtGrabbed:
						SAHurtGrabbedNode SAHurtGrabbed_node_Actions = graph.AddNode<SAHurtGrabbedNode>();
						GetPort(portName).Connect(SAHurtGrabbed_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAHurtGrabbed_node_Actions, assetPath);
						variableCount += SAHurtGrabbed_node_Actions.SetData((SAHurtGrabbed)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SALaunchGrabbed:
						SALaunchGrabbedNode SALaunchGrabbed_node_Actions = graph.AddNode<SALaunchGrabbedNode>();
						GetPort(portName).Connect(SALaunchGrabbed_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SALaunchGrabbed_node_Actions, assetPath);
						variableCount += SALaunchGrabbed_node_Actions.SetData((SALaunchGrabbed)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAStateCancelGrabbed:
						SAStateCancelGrabbedNode SAStateCancelGrabbed_node_Actions = graph.AddNode<SAStateCancelGrabbedNode>();
						GetPort(portName).Connect(SAStateCancelGrabbed_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAStateCancelGrabbed_node_Actions, assetPath);
						variableCount += SAStateCancelGrabbed_node_Actions.SetData((SAStateCancelGrabbed)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAEndGrab:
						SAEndGrabNode SAEndGrab_node_Actions = graph.AddNode<SAEndGrabNode>();
						GetPort(portName).Connect(SAEndGrab_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAEndGrab_node_Actions, assetPath);
						variableCount += SAEndGrab_node_Actions.SetData((SAEndGrab)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAGrabNotifyEscape:
						SAGrabNotifyEscapeNode SAGrabNotifyEscape_node_Actions = graph.AddNode<SAGrabNotifyEscapeNode>();
						GetPort(portName).Connect(SAGrabNotifyEscape_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAGrabNotifyEscape_node_Actions, assetPath);
						variableCount += SAGrabNotifyEscape_node_Actions.SetData((SAGrabNotifyEscape)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAIgnoreGrabbed:
						SAIgnoreGrabbedNode SAIgnoreGrabbed_node_Actions = graph.AddNode<SAIgnoreGrabbedNode>();
						GetPort(portName).Connect(SAIgnoreGrabbed_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAIgnoreGrabbed_node_Actions, assetPath);
						variableCount += SAIgnoreGrabbed_node_Actions.SetData((SAIgnoreGrabbed)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAEventKO:
						SAEventKONode SAEventKO_node_Actions = graph.AddNode<SAEventKONode>();
						GetPort(portName).Connect(SAEventKO_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAEventKO_node_Actions, assetPath);
						variableCount += SAEventKO_node_Actions.SetData((SAEventKO)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAEventKOGrabbed:
						SAEventKOGrabbedNode SAEventKOGrabbed_node_Actions = graph.AddNode<SAEventKOGrabbedNode>();
						GetPort(portName).Connect(SAEventKOGrabbed_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAEventKOGrabbed_node_Actions, assetPath);
						variableCount += SAEventKOGrabbed_node_Actions.SetData((SAEventKOGrabbed)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SACameraShake:
						SACameraShakeNode SACameraShake_node_Actions = graph.AddNode<SACameraShakeNode>();
						GetPort(portName).Connect(SACameraShake_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SACameraShake_node_Actions, assetPath);
						variableCount += SACameraShake_node_Actions.SetData((SACameraShake)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAResetOnHits:
						SAResetOnHitsNode SAResetOnHits_node_Actions = graph.AddNode<SAResetOnHitsNode>();
						GetPort(portName).Connect(SAResetOnHits_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAResetOnHits_node_Actions, assetPath);
						variableCount += SAResetOnHits_node_Actions.SetData((SAResetOnHits)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAOnHit:
						SAOnHitNode SAOnHit_node_Actions = graph.AddNode<SAOnHitNode>();
						GetPort(portName).Connect(SAOnHit_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAOnHit_node_Actions, assetPath);
						variableCount += SAOnHit_node_Actions.SetData((SAOnHit)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAFastForwardState:
						SAFastForwardStateNode SAFastForwardState_node_Actions = graph.AddNode<SAFastForwardStateNode>();
						GetPort(portName).Connect(SAFastForwardState_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAFastForwardState_node_Actions, assetPath);
						variableCount += SAFastForwardState_node_Actions.SetData((SAFastForwardState)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SATimingTweak:
						SATimingTweakNode SATimingTweak_node_Actions = graph.AddNode<SATimingTweakNode>();
						GetPort(portName).Connect(SATimingTweak_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SATimingTweak_node_Actions, assetPath);
						variableCount += SATimingTweak_node_Actions.SetData((SATimingTweak)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAMapAnimation:
						SAMapAnimationNode SAMapAnimation_node_Actions = graph.AddNode<SAMapAnimationNode>();
						GetPort(portName).Connect(SAMapAnimation_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAMapAnimation_node_Actions, assetPath);
						variableCount += SAMapAnimation_node_Actions.SetData((SAMapAnimation)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAAlterMoveDT:
						SAAlterMoveDTNode SAAlterMoveDT_node_Actions = graph.AddNode<SAAlterMoveDTNode>();
						GetPort(portName).Connect(SAAlterMoveDT_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAAlterMoveDT_node_Actions, assetPath);
						variableCount += SAAlterMoveDT_node_Actions.SetData((SAAlterMoveDT)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAAlterMoveVel:
						SAAlterMoveVelNode SAAlterMoveVel_node_Actions = graph.AddNode<SAAlterMoveVelNode>();
						GetPort(portName).Connect(SAAlterMoveVel_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAAlterMoveVel_node_Actions, assetPath);
						variableCount += SAAlterMoveVel_node_Actions.SetData((SAAlterMoveVel)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SASetStagePart:
						SASetStagePartNode SASetStagePart_node_Actions = graph.AddNode<SASetStagePartNode>();
						GetPort(portName).Connect(SASetStagePart_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SASetStagePart_node_Actions, assetPath);
						variableCount += SASetStagePart_node_Actions.SetData((SASetStagePart)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SASetStagePartsDefault:
						SASetStagePartsDefaultNode SASetStagePartsDefault_node_Actions = graph.AddNode<SASetStagePartsDefaultNode>();
						GetPort(portName).Connect(SASetStagePartsDefault_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SASetStagePartsDefault_node_Actions, assetPath);
						variableCount += SASetStagePartsDefault_node_Actions.SetData((SASetStagePartsDefault)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAJump:
						SAJumpNode SAJump_node_Actions = graph.AddNode<SAJumpNode>();
						GetPort(portName).Connect(SAJump_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAJump_node_Actions, assetPath);
						variableCount += SAJump_node_Actions.SetData((SAJump)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAStopJump:
						SAStopJumpNode SAStopJump_node_Actions = graph.AddNode<SAStopJumpNode>();
						GetPort(portName).Connect(SAStopJump_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAStopJump_node_Actions, assetPath);
						variableCount += SAStopJump_node_Actions.SetData((SAStopJump)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAManageAirJump:
						SAManageAirJumpNode SAManageAirJump_node_Actions = graph.AddNode<SAManageAirJumpNode>();
						GetPort(portName).Connect(SAManageAirJump_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAManageAirJump_node_Actions, assetPath);
						variableCount += SAManageAirJump_node_Actions.SetData((SAManageAirJump)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SALeaveGround:
						SALeaveGroundNode SALeaveGround_node_Actions = graph.AddNode<SALeaveGroundNode>();
						GetPort(portName).Connect(SALeaveGround_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SALeaveGround_node_Actions, assetPath);
						variableCount += SALeaveGround_node_Actions.SetData((SALeaveGround)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAUnHogEdge:
						SAUnHogEdgeNode SAUnHogEdge_node_Actions = graph.AddNode<SAUnHogEdgeNode>();
						GetPort(portName).Connect(SAUnHogEdge_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAUnHogEdge_node_Actions, assetPath);
						variableCount += SAUnHogEdge_node_Actions.SetData((SAUnHogEdge)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAPlaySFXTimeline:
						SAPlaySFXTimelineNode SAPlaySFXTimeline_node_Actions = graph.AddNode<SAPlaySFXTimelineNode>();
						GetPort(portName).Connect(SAPlaySFXTimeline_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAPlaySFXTimeline_node_Actions, assetPath);
						variableCount += SAPlaySFXTimeline_node_Actions.SetData((SAPlaySFXTimeline)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAFindLastHorizontalInput:
						SAFindLastHorizontalInputNode SAFindLastHorizontalInput_node_Actions = graph.AddNode<SAFindLastHorizontalInputNode>();
						GetPort(portName).Connect(SAFindLastHorizontalInput_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAFindLastHorizontalInput_node_Actions, assetPath);
						variableCount += SAFindLastHorizontalInput_node_Actions.SetData((SAFindLastHorizontalInput)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SASetCommandGrab:
						SASetCommandGrabNode SASetCommandGrab_node_Actions = graph.AddNode<SASetCommandGrabNode>();
						GetPort(portName).Connect(SASetCommandGrab_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SASetCommandGrab_node_Actions, assetPath);
						variableCount += SASetCommandGrab_node_Actions.SetData((SASetCommandGrab)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SACameraPunch:
						SACameraPunchNode SACameraPunch_node_Actions = graph.AddNode<SACameraPunchNode>();
						GetPort(portName).Connect(SACameraPunch_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SACameraPunch_node_Actions, assetPath);
						variableCount += SACameraPunch_node_Actions.SetData((SACameraPunch)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SASpawnAgent2:
						SASpawnAgent2Node SASpawnAgent2_node_Actions = graph.AddNode<SASpawnAgent2Node>();
						GetPort(portName).Connect(SASpawnAgent2_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SASpawnAgent2_node_Actions, assetPath);
						variableCount += SASpawnAgent2_node_Actions.SetData((SASpawnAgent2)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAManipDecorChain:
						SAManipDecorChainNode SAManipDecorChain_node_Actions = graph.AddNode<SAManipDecorChainNode>();
						GetPort(portName).Connect(SAManipDecorChain_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAManipDecorChain_node_Actions, assetPath);
						variableCount += SAManipDecorChain_node_Actions.SetData((SAManipDecorChain)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAUpdateHitboxes:
						SAUpdateHitboxesNode SAUpdateHitboxes_node_Actions = graph.AddNode<SAUpdateHitboxesNode>();
						GetPort(portName).Connect(SAUpdateHitboxes_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAUpdateHitboxes_node_Actions, assetPath);
						variableCount += SAUpdateHitboxes_node_Actions.SetData((SAUpdateHitboxes)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SASampleAnim:
						SASampleAnimNode SASampleAnim_node_Actions = graph.AddNode<SASampleAnimNode>();
						GetPort(portName).Connect(SASampleAnim_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SASampleAnim_node_Actions, assetPath);
						variableCount += SASampleAnim_node_Actions.SetData((SASampleAnim)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAForceExtraInputCheck:
						SAForceExtraInputCheckNode SAForceExtraInputCheck_node_Actions = graph.AddNode<SAForceExtraInputCheckNode>();
						GetPort(portName).Connect(SAForceExtraInputCheck_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAForceExtraInputCheck_node_Actions, assetPath);
						variableCount += SAForceExtraInputCheck_node_Actions.SetData((SAForceExtraInputCheck)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SALaunchGrabbedCustom:
						SALaunchGrabbedCustomNode SALaunchGrabbedCustom_node_Actions = graph.AddNode<SALaunchGrabbedCustomNode>();
						GetPort(portName).Connect(SALaunchGrabbedCustom_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SALaunchGrabbedCustom_node_Actions, assetPath);
						variableCount += SALaunchGrabbedCustom_node_Actions.SetData((SALaunchGrabbedCustom)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAMapAnimationSimple:
						SAMapAnimationSimpleNode SAMapAnimationSimple_node_Actions = graph.AddNode<SAMapAnimationSimpleNode>();
						GetPort(portName).Connect(SAMapAnimationSimple_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAMapAnimationSimple_node_Actions, assetPath);
						variableCount += SAMapAnimationSimple_node_Actions.SetData((SAMapAnimationSimple)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAPersistLocalFX:
						SAPersistLocalFXNode SAPersistLocalFX_node_Actions = graph.AddNode<SAPersistLocalFXNode>();
						GetPort(portName).Connect(SAPersistLocalFX_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAPersistLocalFX_node_Actions, assetPath);
						variableCount += SAPersistLocalFX_node_Actions.SetData((SAPersistLocalFX)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAOnLeaveParent:
						SAOnLeaveParentNode SAOnLeaveParent_node_Actions = graph.AddNode<SAOnLeaveParentNode>();
						GetPort(portName).Connect(SAOnLeaveParent_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAOnLeaveParent_node_Actions, assetPath);
						variableCount += SAOnLeaveParent_node_Actions.SetData((SAOnLeaveParent)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAPlayVoiceLine:
						SAPlayVoiceLineNode SAPlayVoiceLine_node_Actions = graph.AddNode<SAPlayVoiceLineNode>();
						GetPort(portName).Connect(SAPlayVoiceLine_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAPlayVoiceLine_node_Actions, assetPath);
						variableCount += SAPlayVoiceLine_node_Actions.SetData((SAPlayVoiceLine)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAPlayCategoryVoiceLine:
						SAPlayCategoryVoiceLineNode SAPlayCategoryVoiceLine_node_Actions = graph.AddNode<SAPlayCategoryVoiceLineNode>();
						GetPort(portName).Connect(SAPlayCategoryVoiceLine_node_Actions.GetPort("NodeInput"));
						AssetDatabase.AddObjectToAsset(SAPlayCategoryVoiceLine_node_Actions, assetPath);
						variableCount += SAPlayCategoryVoiceLine_node_Actions.SetData((SAPlayCategoryVoiceLine)Actions_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
					break;
					case StateAction.TypeId.SAStopVoiceLines:
						SAStopVoiceLinesNode SAStopVoiceLines_node_Actions = graph.AddNode<SAStopVoiceLinesNode>();
						GetPort(portName).Connect(SAStopVoiceLines_node_Actions.GetPort("NodeInput"));
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
			foreach(NodePort port in DynamicOutputs)
			{
				if (port.ConnectionCount <= 0) continue;
				StateActionNode StateAction_Node = (StateActionNode)port.Connection.node;
				switch (StateAction_Node.TID)
				{
					case StateAction.TypeId.StateAction:
						StateActionNode StateAction_StateAction_Node = (StateActionNode)port.Connection.node;
						objToReturn.Actions[i] = StateAction_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SADebugMessage:
						SADebugMessageNode SADebugMessage_StateAction_Node = (SADebugMessageNode)port.Connection.node;
						objToReturn.Actions[i] = SADebugMessage_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAPlayAnim:
						SAPlayAnimNode SAPlayAnim_StateAction_Node = (SAPlayAnimNode)port.Connection.node;
						objToReturn.Actions[i] = SAPlayAnim_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAPlayRootAnim:
						SAPlayRootAnimNode SAPlayRootAnim_StateAction_Node = (SAPlayRootAnimNode)port.Connection.node;
						objToReturn.Actions[i] = SAPlayRootAnim_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASnapAnimWeights:
						SASnapAnimWeightsNode SASnapAnimWeights_StateAction_Node = (SASnapAnimWeightsNode)port.Connection.node;
						objToReturn.Actions[i] = SASnapAnimWeights_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAStandardInput:
						SAStandardInputNode SAStandardInput_StateAction_Node = (SAStandardInputNode)port.Connection.node;
						objToReturn.Actions[i] = SAStandardInput_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAInputAction:
						SAInputActionNode SAInputAction_StateAction_Node = (SAInputActionNode)port.Connection.node;
						objToReturn.Actions[i] = SAInputAction_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SADeactivateInputAction:
						SADeactivateInputActionNode SADeactivateInputAction_StateAction_Node = (SADeactivateInputActionNode)port.Connection.node;
						objToReturn.Actions[i] = SADeactivateInputAction_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAAddInputEventFromFrame:
						SAAddInputEventFromFrameNode SAAddInputEventFromFrame_StateAction_Node = (SAAddInputEventFromFrameNode)port.Connection.node;
						objToReturn.Actions[i] = SAAddInputEventFromFrame_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SACancelToState:
						SACancelToStateNode SACancelToState_StateAction_Node = (SACancelToStateNode)port.Connection.node;
						objToReturn.Actions[i] = SACancelToState_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SACustomCall:
						SACustomCallNode SACustomCall_StateAction_Node = (SACustomCallNode)port.Connection.node;
						objToReturn.Actions[i] = SACustomCall_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SATimedAction:
						SATimedActionNode SATimedAction_StateAction_Node = (SATimedActionNode)port.Connection.node;
						objToReturn.Actions[i] = SATimedAction_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAOrderSensitive:
						SAOrderSensitiveNode SAOrderSensitive_StateAction_Node = (SAOrderSensitiveNode)port.Connection.node;
						objToReturn.Actions[i] = SAOrderSensitive_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAProxyMove:
						SAProxyMoveNode SAProxyMove_StateAction_Node = (SAProxyMoveNode)port.Connection.node;
						objToReturn.Actions[i] = SAProxyMove_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SACheckThing:
						SACheckThingNode SACheckThing_StateAction_Node = (SACheckThingNode)port.Connection.node;
						objToReturn.Actions[i] = SACheckThing_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAActiveAction:
						SAActiveActionNode SAActiveAction_StateAction_Node = (SAActiveActionNode)port.Connection.node;
						objToReturn.Actions[i] = SAActiveAction_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SADeactivateAction:
						SADeactivateActionNode SADeactivateAction_StateAction_Node = (SADeactivateActionNode)port.Connection.node;
						objToReturn.Actions[i] = SADeactivateAction_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASetFloatTarget:
						SASetFloatTargetNode SASetFloatTarget_StateAction_Node = (SASetFloatTargetNode)port.Connection.node;
						objToReturn.Actions[i] = SASetFloatTarget_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAOnBounce:
						SAOnBounceNode SAOnBounce_StateAction_Node = (SAOnBounceNode)port.Connection.node;
						objToReturn.Actions[i] = SAOnBounce_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAOnLeaveEdge:
						SAOnLeaveEdgeNode SAOnLeaveEdge_StateAction_Node = (SAOnLeaveEdgeNode)port.Connection.node;
						objToReturn.Actions[i] = SAOnLeaveEdge_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAOnStoppedAtEdge:
						SAOnStoppedAtEdgeNode SAOnStoppedAtEdge_StateAction_Node = (SAOnStoppedAtEdgeNode)port.Connection.node;
						objToReturn.Actions[i] = SAOnStoppedAtEdge_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAOnLand:
						SAOnLandNode SAOnLand_StateAction_Node = (SAOnLandNode)port.Connection.node;
						objToReturn.Actions[i] = SAOnLand_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAOnCancel:
						SAOnCancelNode SAOnCancel_StateAction_Node = (SAOnCancelNode)port.Connection.node;
						objToReturn.Actions[i] = SAOnCancel_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SARefreshAttack:
						SARefreshAttackNode SARefreshAttack_StateAction_Node = (SARefreshAttackNode)port.Connection.node;
						objToReturn.Actions[i] = SARefreshAttack_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAEndAttack:
						SAEndAttackNode SAEndAttack_StateAction_Node = (SAEndAttackNode)port.Connection.node;
						objToReturn.Actions[i] = SAEndAttack_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASetHitboxCount:
						SASetHitboxCountNode SASetHitboxCount_StateAction_Node = (SASetHitboxCountNode)port.Connection.node;
						objToReturn.Actions[i] = SASetHitboxCount_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAConfigHitbox:
						SAConfigHitboxNode SAConfigHitbox_StateAction_Node = (SAConfigHitboxNode)port.Connection.node;
						objToReturn.Actions[i] = SAConfigHitbox_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASetAtkProp:
						SASetAtkPropNode SASetAtkProp_StateAction_Node = (SASetAtkPropNode)port.Connection.node;
						objToReturn.Actions[i] = SASetAtkProp_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAManipHitBox:
						SAManipHitBoxNode SAManipHitBox_StateAction_Node = (SAManipHitBoxNode)port.Connection.node;
						objToReturn.Actions[i] = SAManipHitBox_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAUpdateHurtboxes:
						SAUpdateHurtboxesNode SAUpdateHurtboxes_StateAction_Node = (SAUpdateHurtboxesNode)port.Connection.node;
						objToReturn.Actions[i] = SAUpdateHurtboxes_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASetupHurtboxes:
						SASetupHurtboxesNode SASetupHurtboxes_StateAction_Node = (SASetupHurtboxesNode)port.Connection.node;
						objToReturn.Actions[i] = SASetupHurtboxes_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAManipHurtBox:
						SAManipHurtBoxNode SAManipHurtBox_StateAction_Node = (SAManipHurtBoxNode)port.Connection.node;
						objToReturn.Actions[i] = SAManipHurtBox_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SABoneState:
						SABoneStateNode SABoneState_StateAction_Node = (SABoneStateNode)port.Connection.node;
						objToReturn.Actions[i] = SABoneState_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SABoneScale:
						SABoneScaleNode SABoneScale_StateAction_Node = (SABoneScaleNode)port.Connection.node;
						objToReturn.Actions[i] = SABoneScale_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASpawnAgent:
						SASpawnAgentNode SASpawnAgent_StateAction_Node = (SASpawnAgentNode)port.Connection.node;
						objToReturn.Actions[i] = SASpawnAgent_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SALocalFX:
						SALocalFXNode SALocalFX_StateAction_Node = (SALocalFXNode)port.Connection.node;
						objToReturn.Actions[i] = SALocalFX_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASpawnFX:
						SASpawnFXNode SASpawnFX_StateAction_Node = (SASpawnFXNode)port.Connection.node;
						objToReturn.Actions[i] = SASpawnFX_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASetHitboxFX:
						SASetHitboxFXNode SASetHitboxFX_StateAction_Node = (SASetHitboxFXNode)port.Connection.node;
						objToReturn.Actions[i] = SASetHitboxFX_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAPlaySFX:
						SAPlaySFXNode SAPlaySFX_StateAction_Node = (SAPlaySFXNode)port.Connection.node;
						objToReturn.Actions[i] = SAPlaySFX_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASetHitboxSFX:
						SASetHitboxSFXNode SASetHitboxSFX_StateAction_Node = (SASetHitboxSFXNode)port.Connection.node;
						objToReturn.Actions[i] = SASetHitboxSFX_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAColorTint:
						SAColorTintNode SAColorTint_StateAction_Node = (SAColorTintNode)port.Connection.node;
						objToReturn.Actions[i] = SAColorTint_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAFindFloor:
						SAFindFloorNode SAFindFloor_StateAction_Node = (SAFindFloorNode)port.Connection.node;
						objToReturn.Actions[i] = SAFindFloor_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAHurtGrabbed:
						SAHurtGrabbedNode SAHurtGrabbed_StateAction_Node = (SAHurtGrabbedNode)port.Connection.node;
						objToReturn.Actions[i] = SAHurtGrabbed_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SALaunchGrabbed:
						SALaunchGrabbedNode SALaunchGrabbed_StateAction_Node = (SALaunchGrabbedNode)port.Connection.node;
						objToReturn.Actions[i] = SALaunchGrabbed_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAStateCancelGrabbed:
						SAStateCancelGrabbedNode SAStateCancelGrabbed_StateAction_Node = (SAStateCancelGrabbedNode)port.Connection.node;
						objToReturn.Actions[i] = SAStateCancelGrabbed_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAEndGrab:
						SAEndGrabNode SAEndGrab_StateAction_Node = (SAEndGrabNode)port.Connection.node;
						objToReturn.Actions[i] = SAEndGrab_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAGrabNotifyEscape:
						SAGrabNotifyEscapeNode SAGrabNotifyEscape_StateAction_Node = (SAGrabNotifyEscapeNode)port.Connection.node;
						objToReturn.Actions[i] = SAGrabNotifyEscape_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAIgnoreGrabbed:
						SAIgnoreGrabbedNode SAIgnoreGrabbed_StateAction_Node = (SAIgnoreGrabbedNode)port.Connection.node;
						objToReturn.Actions[i] = SAIgnoreGrabbed_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAEventKO:
						SAEventKONode SAEventKO_StateAction_Node = (SAEventKONode)port.Connection.node;
						objToReturn.Actions[i] = SAEventKO_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAEventKOGrabbed:
						SAEventKOGrabbedNode SAEventKOGrabbed_StateAction_Node = (SAEventKOGrabbedNode)port.Connection.node;
						objToReturn.Actions[i] = SAEventKOGrabbed_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SACameraShake:
						SACameraShakeNode SACameraShake_StateAction_Node = (SACameraShakeNode)port.Connection.node;
						objToReturn.Actions[i] = SACameraShake_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAResetOnHits:
						SAResetOnHitsNode SAResetOnHits_StateAction_Node = (SAResetOnHitsNode)port.Connection.node;
						objToReturn.Actions[i] = SAResetOnHits_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAOnHit:
						SAOnHitNode SAOnHit_StateAction_Node = (SAOnHitNode)port.Connection.node;
						objToReturn.Actions[i] = SAOnHit_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAFastForwardState:
						SAFastForwardStateNode SAFastForwardState_StateAction_Node = (SAFastForwardStateNode)port.Connection.node;
						objToReturn.Actions[i] = SAFastForwardState_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SATimingTweak:
						SATimingTweakNode SATimingTweak_StateAction_Node = (SATimingTweakNode)port.Connection.node;
						objToReturn.Actions[i] = SATimingTweak_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAMapAnimation:
						SAMapAnimationNode SAMapAnimation_StateAction_Node = (SAMapAnimationNode)port.Connection.node;
						objToReturn.Actions[i] = SAMapAnimation_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAAlterMoveDT:
						SAAlterMoveDTNode SAAlterMoveDT_StateAction_Node = (SAAlterMoveDTNode)port.Connection.node;
						objToReturn.Actions[i] = SAAlterMoveDT_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAAlterMoveVel:
						SAAlterMoveVelNode SAAlterMoveVel_StateAction_Node = (SAAlterMoveVelNode)port.Connection.node;
						objToReturn.Actions[i] = SAAlterMoveVel_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASetStagePart:
						SASetStagePartNode SASetStagePart_StateAction_Node = (SASetStagePartNode)port.Connection.node;
						objToReturn.Actions[i] = SASetStagePart_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASetStagePartsDefault:
						SASetStagePartsDefaultNode SASetStagePartsDefault_StateAction_Node = (SASetStagePartsDefaultNode)port.Connection.node;
						objToReturn.Actions[i] = SASetStagePartsDefault_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAJump:
						SAJumpNode SAJump_StateAction_Node = (SAJumpNode)port.Connection.node;
						objToReturn.Actions[i] = SAJump_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAStopJump:
						SAStopJumpNode SAStopJump_StateAction_Node = (SAStopJumpNode)port.Connection.node;
						objToReturn.Actions[i] = SAStopJump_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAManageAirJump:
						SAManageAirJumpNode SAManageAirJump_StateAction_Node = (SAManageAirJumpNode)port.Connection.node;
						objToReturn.Actions[i] = SAManageAirJump_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SALeaveGround:
						SALeaveGroundNode SALeaveGround_StateAction_Node = (SALeaveGroundNode)port.Connection.node;
						objToReturn.Actions[i] = SALeaveGround_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAUnHogEdge:
						SAUnHogEdgeNode SAUnHogEdge_StateAction_Node = (SAUnHogEdgeNode)port.Connection.node;
						objToReturn.Actions[i] = SAUnHogEdge_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAPlaySFXTimeline:
						SAPlaySFXTimelineNode SAPlaySFXTimeline_StateAction_Node = (SAPlaySFXTimelineNode)port.Connection.node;
						objToReturn.Actions[i] = SAPlaySFXTimeline_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAFindLastHorizontalInput:
						SAFindLastHorizontalInputNode SAFindLastHorizontalInput_StateAction_Node = (SAFindLastHorizontalInputNode)port.Connection.node;
						objToReturn.Actions[i] = SAFindLastHorizontalInput_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASetCommandGrab:
						SASetCommandGrabNode SASetCommandGrab_StateAction_Node = (SASetCommandGrabNode)port.Connection.node;
						objToReturn.Actions[i] = SASetCommandGrab_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SACameraPunch:
						SACameraPunchNode SACameraPunch_StateAction_Node = (SACameraPunchNode)port.Connection.node;
						objToReturn.Actions[i] = SACameraPunch_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASpawnAgent2:
						SASpawnAgent2Node SASpawnAgent2_StateAction_Node = (SASpawnAgent2Node)port.Connection.node;
						objToReturn.Actions[i] = SASpawnAgent2_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAManipDecorChain:
						SAManipDecorChainNode SAManipDecorChain_StateAction_Node = (SAManipDecorChainNode)port.Connection.node;
						objToReturn.Actions[i] = SAManipDecorChain_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAUpdateHitboxes:
						SAUpdateHitboxesNode SAUpdateHitboxes_StateAction_Node = (SAUpdateHitboxesNode)port.Connection.node;
						objToReturn.Actions[i] = SAUpdateHitboxes_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASampleAnim:
						SASampleAnimNode SASampleAnim_StateAction_Node = (SASampleAnimNode)port.Connection.node;
						objToReturn.Actions[i] = SASampleAnim_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAForceExtraInputCheck:
						SAForceExtraInputCheckNode SAForceExtraInputCheck_StateAction_Node = (SAForceExtraInputCheckNode)port.Connection.node;
						objToReturn.Actions[i] = SAForceExtraInputCheck_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SALaunchGrabbedCustom:
						SALaunchGrabbedCustomNode SALaunchGrabbedCustom_StateAction_Node = (SALaunchGrabbedCustomNode)port.Connection.node;
						objToReturn.Actions[i] = SALaunchGrabbedCustom_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAMapAnimationSimple:
						SAMapAnimationSimpleNode SAMapAnimationSimple_StateAction_Node = (SAMapAnimationSimpleNode)port.Connection.node;
						objToReturn.Actions[i] = SAMapAnimationSimple_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAPersistLocalFX:
						SAPersistLocalFXNode SAPersistLocalFX_StateAction_Node = (SAPersistLocalFXNode)port.Connection.node;
						objToReturn.Actions[i] = SAPersistLocalFX_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAOnLeaveParent:
						SAOnLeaveParentNode SAOnLeaveParent_StateAction_Node = (SAOnLeaveParentNode)port.Connection.node;
						objToReturn.Actions[i] = SAOnLeaveParent_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAPlayVoiceLine:
						SAPlayVoiceLineNode SAPlayVoiceLine_StateAction_Node = (SAPlayVoiceLineNode)port.Connection.node;
						objToReturn.Actions[i] = SAPlayVoiceLine_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAPlayCategoryVoiceLine:
						SAPlayCategoryVoiceLineNode SAPlayCategoryVoiceLine_StateAction_Node = (SAPlayCategoryVoiceLineNode)port.Connection.node;
						objToReturn.Actions[i] = SAPlayCategoryVoiceLine_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAStopVoiceLines:
						SAStopVoiceLinesNode SAStopVoiceLines_StateAction_Node = (SAStopVoiceLinesNode)port.Connection.node;
						objToReturn.Actions[i] = SAStopVoiceLines_StateAction_Node.GetData();
					break;
				}
				++i;
			}
			return objToReturn;
		}
	}
}

