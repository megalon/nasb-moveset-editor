// * 
// * 
// * This file was generated using NASB_Parser_to_xNode by megalon2d
// * https://github.com/megalon/NASB_Parser_to_xNode
// * 
// * 
using MovesetParser.BulkSerialize;
using MovesetParser.FloatSources;
using MovesetParser.Misc;
using UnityEngine;
using UnityEditor;
using XNode;
using XNodeEditor;
using MovesetParser;
using MovesetParser.CheckThings;
using MovesetParser.Jumps;
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
	public class SATimingTweakNode : StateActionNode
	{
		[Input(connectionType = ConnectionType.Override)] public StateAction NodeInput;
		public string AnimId;
		public string RootAnimId;
		[Output(connectionType = ConnectionType.Override)] public AnimConfig AnimConfig;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer AnimFrames;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer StateFrames;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer FramesToA;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer FramesToBe;
		[Output(connectionType = ConnectionType.Override)] public StateAction ActionA;
		[Output(connectionType = ConnectionType.Override)] public StateAction ActionB;
		[Output(connectionType = ConnectionType.Override)] public StateAction ActionEnd;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.SATimingTweak;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SATimingTweak data, MovesetGraph graph, string assetPath, UnityEngine.Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SATimingTweak));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			AnimId = data.AnimId;
			RootAnimId = data.RootAnimId;
			AnimConfig = data.AnimConfig;
			
			AnimConfigNode node_AnimConfig = graph.AddNode<AnimConfigNode>();
			GetPort("AnimConfig").Connect(node_AnimConfig.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_AnimConfig, assetPath);
			variableCount += node_AnimConfig.SetData(AnimConfig, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			AnimFrames = data.AnimFrames;
			
			FloatSourceContainerNode node_AnimFrames = graph.AddNode<FloatSourceContainerNode>();
			GetPort("AnimFrames").Connect(node_AnimFrames.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_AnimFrames, assetPath);
			variableCount += node_AnimFrames.SetData(AnimFrames, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			StateFrames = data.StateFrames;
			
			FloatSourceContainerNode node_StateFrames = graph.AddNode<FloatSourceContainerNode>();
			GetPort("StateFrames").Connect(node_StateFrames.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_StateFrames, assetPath);
			variableCount += node_StateFrames.SetData(StateFrames, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			FramesToA = data.FramesToA;
			
			FloatSourceContainerNode node_FramesToA = graph.AddNode<FloatSourceContainerNode>();
			GetPort("FramesToA").Connect(node_FramesToA.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_FramesToA, assetPath);
			variableCount += node_FramesToA.SetData(FramesToA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			FramesToBe = data.FramesToBe;
			
			FloatSourceContainerNode node_FramesToBe = graph.AddNode<FloatSourceContainerNode>();
			GetPort("FramesToBe").Connect(node_FramesToBe.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_FramesToBe, assetPath);
			variableCount += node_FramesToBe.SetData(FramesToBe, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			ActionA = data.ActionA;
			
			switch (ActionA.TID)
			{
				case StateAction.TypeId.StateAction:
					StateActionNode StateAction_node_ActionA = graph.AddNode<StateActionNode>();
					GetPort("ActionA").Connect(StateAction_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(StateAction_node_ActionA, assetPath);
					variableCount += StateAction_node_ActionA.SetData((StateAction)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SADebugMessage:
					SADebugMessageNode SADebugMessage_node_ActionA = graph.AddNode<SADebugMessageNode>();
					GetPort("ActionA").Connect(SADebugMessage_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SADebugMessage_node_ActionA, assetPath);
					variableCount += SADebugMessage_node_ActionA.SetData((SADebugMessage)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAPlayAnim:
					SAPlayAnimNode SAPlayAnim_node_ActionA = graph.AddNode<SAPlayAnimNode>();
					GetPort("ActionA").Connect(SAPlayAnim_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAPlayAnim_node_ActionA, assetPath);
					variableCount += SAPlayAnim_node_ActionA.SetData((SAPlayAnim)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAPlayRootAnim:
					SAPlayRootAnimNode SAPlayRootAnim_node_ActionA = graph.AddNode<SAPlayRootAnimNode>();
					GetPort("ActionA").Connect(SAPlayRootAnim_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAPlayRootAnim_node_ActionA, assetPath);
					variableCount += SAPlayRootAnim_node_ActionA.SetData((SAPlayRootAnim)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SASnapAnimWeights:
					SASnapAnimWeightsNode SASnapAnimWeights_node_ActionA = graph.AddNode<SASnapAnimWeightsNode>();
					GetPort("ActionA").Connect(SASnapAnimWeights_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SASnapAnimWeights_node_ActionA, assetPath);
					variableCount += SASnapAnimWeights_node_ActionA.SetData((SASnapAnimWeights)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAStandardInput:
					SAStandardInputNode SAStandardInput_node_ActionA = graph.AddNode<SAStandardInputNode>();
					GetPort("ActionA").Connect(SAStandardInput_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAStandardInput_node_ActionA, assetPath);
					variableCount += SAStandardInput_node_ActionA.SetData((SAStandardInput)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAInputAction:
					SAInputActionNode SAInputAction_node_ActionA = graph.AddNode<SAInputActionNode>();
					GetPort("ActionA").Connect(SAInputAction_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAInputAction_node_ActionA, assetPath);
					variableCount += SAInputAction_node_ActionA.SetData((SAInputAction)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SADeactivateInputAction:
					SADeactivateInputActionNode SADeactivateInputAction_node_ActionA = graph.AddNode<SADeactivateInputActionNode>();
					GetPort("ActionA").Connect(SADeactivateInputAction_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SADeactivateInputAction_node_ActionA, assetPath);
					variableCount += SADeactivateInputAction_node_ActionA.SetData((SADeactivateInputAction)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAAddInputEventFromFrame:
					SAAddInputEventFromFrameNode SAAddInputEventFromFrame_node_ActionA = graph.AddNode<SAAddInputEventFromFrameNode>();
					GetPort("ActionA").Connect(SAAddInputEventFromFrame_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAAddInputEventFromFrame_node_ActionA, assetPath);
					variableCount += SAAddInputEventFromFrame_node_ActionA.SetData((SAAddInputEventFromFrame)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SACancelToState:
					SACancelToStateNode SACancelToState_node_ActionA = graph.AddNode<SACancelToStateNode>();
					GetPort("ActionA").Connect(SACancelToState_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SACancelToState_node_ActionA, assetPath);
					variableCount += SACancelToState_node_ActionA.SetData((SACancelToState)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SACustomCall:
					SACustomCallNode SACustomCall_node_ActionA = graph.AddNode<SACustomCallNode>();
					GetPort("ActionA").Connect(SACustomCall_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SACustomCall_node_ActionA, assetPath);
					variableCount += SACustomCall_node_ActionA.SetData((SACustomCall)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SATimedAction:
					SATimedActionNode SATimedAction_node_ActionA = graph.AddNode<SATimedActionNode>();
					GetPort("ActionA").Connect(SATimedAction_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SATimedAction_node_ActionA, assetPath);
					variableCount += SATimedAction_node_ActionA.SetData((SATimedAction)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAOrderSensitive:
					SAOrderSensitiveNode SAOrderSensitive_node_ActionA = graph.AddNode<SAOrderSensitiveNode>();
					GetPort("ActionA").Connect(SAOrderSensitive_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAOrderSensitive_node_ActionA, assetPath);
					variableCount += SAOrderSensitive_node_ActionA.SetData((SAOrderSensitive)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAProxyMove:
					SAProxyMoveNode SAProxyMove_node_ActionA = graph.AddNode<SAProxyMoveNode>();
					GetPort("ActionA").Connect(SAProxyMove_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAProxyMove_node_ActionA, assetPath);
					variableCount += SAProxyMove_node_ActionA.SetData((SAProxyMove)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SACheckThing:
					SACheckThingNode SACheckThing_node_ActionA = graph.AddNode<SACheckThingNode>();
					GetPort("ActionA").Connect(SACheckThing_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SACheckThing_node_ActionA, assetPath);
					variableCount += SACheckThing_node_ActionA.SetData((SACheckThing)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAActiveAction:
					SAActiveActionNode SAActiveAction_node_ActionA = graph.AddNode<SAActiveActionNode>();
					GetPort("ActionA").Connect(SAActiveAction_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAActiveAction_node_ActionA, assetPath);
					variableCount += SAActiveAction_node_ActionA.SetData((SAActiveAction)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SADeactivateAction:
					SADeactivateActionNode SADeactivateAction_node_ActionA = graph.AddNode<SADeactivateActionNode>();
					GetPort("ActionA").Connect(SADeactivateAction_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SADeactivateAction_node_ActionA, assetPath);
					variableCount += SADeactivateAction_node_ActionA.SetData((SADeactivateAction)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SASetFloatTarget:
					SASetFloatTargetNode SASetFloatTarget_node_ActionA = graph.AddNode<SASetFloatTargetNode>();
					GetPort("ActionA").Connect(SASetFloatTarget_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SASetFloatTarget_node_ActionA, assetPath);
					variableCount += SASetFloatTarget_node_ActionA.SetData((SASetFloatTarget)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAOnBounce:
					SAOnBounceNode SAOnBounce_node_ActionA = graph.AddNode<SAOnBounceNode>();
					GetPort("ActionA").Connect(SAOnBounce_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAOnBounce_node_ActionA, assetPath);
					variableCount += SAOnBounce_node_ActionA.SetData((SAOnBounce)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAOnLeaveEdge:
					SAOnLeaveEdgeNode SAOnLeaveEdge_node_ActionA = graph.AddNode<SAOnLeaveEdgeNode>();
					GetPort("ActionA").Connect(SAOnLeaveEdge_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAOnLeaveEdge_node_ActionA, assetPath);
					variableCount += SAOnLeaveEdge_node_ActionA.SetData((SAOnLeaveEdge)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAOnStoppedAtEdge:
					SAOnStoppedAtEdgeNode SAOnStoppedAtEdge_node_ActionA = graph.AddNode<SAOnStoppedAtEdgeNode>();
					GetPort("ActionA").Connect(SAOnStoppedAtEdge_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAOnStoppedAtEdge_node_ActionA, assetPath);
					variableCount += SAOnStoppedAtEdge_node_ActionA.SetData((SAOnStoppedAtEdge)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAOnLand:
					SAOnLandNode SAOnLand_node_ActionA = graph.AddNode<SAOnLandNode>();
					GetPort("ActionA").Connect(SAOnLand_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAOnLand_node_ActionA, assetPath);
					variableCount += SAOnLand_node_ActionA.SetData((SAOnLand)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAOnCancel:
					SAOnCancelNode SAOnCancel_node_ActionA = graph.AddNode<SAOnCancelNode>();
					GetPort("ActionA").Connect(SAOnCancel_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAOnCancel_node_ActionA, assetPath);
					variableCount += SAOnCancel_node_ActionA.SetData((SAOnCancel)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SARefreshAttack:
					SARefreshAttackNode SARefreshAttack_node_ActionA = graph.AddNode<SARefreshAttackNode>();
					GetPort("ActionA").Connect(SARefreshAttack_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SARefreshAttack_node_ActionA, assetPath);
					variableCount += SARefreshAttack_node_ActionA.SetData((SARefreshAttack)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAEndAttack:
					SAEndAttackNode SAEndAttack_node_ActionA = graph.AddNode<SAEndAttackNode>();
					GetPort("ActionA").Connect(SAEndAttack_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAEndAttack_node_ActionA, assetPath);
					variableCount += SAEndAttack_node_ActionA.SetData((SAEndAttack)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SASetHitboxCount:
					SASetHitboxCountNode SASetHitboxCount_node_ActionA = graph.AddNode<SASetHitboxCountNode>();
					GetPort("ActionA").Connect(SASetHitboxCount_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SASetHitboxCount_node_ActionA, assetPath);
					variableCount += SASetHitboxCount_node_ActionA.SetData((SASetHitboxCount)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAConfigHitbox:
					SAConfigHitboxNode SAConfigHitbox_node_ActionA = graph.AddNode<SAConfigHitboxNode>();
					GetPort("ActionA").Connect(SAConfigHitbox_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAConfigHitbox_node_ActionA, assetPath);
					variableCount += SAConfigHitbox_node_ActionA.SetData((SAConfigHitbox)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SASetAtkProp:
					SASetAtkPropNode SASetAtkProp_node_ActionA = graph.AddNode<SASetAtkPropNode>();
					GetPort("ActionA").Connect(SASetAtkProp_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SASetAtkProp_node_ActionA, assetPath);
					variableCount += SASetAtkProp_node_ActionA.SetData((SASetAtkProp)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAManipHitBox:
					SAManipHitBoxNode SAManipHitBox_node_ActionA = graph.AddNode<SAManipHitBoxNode>();
					GetPort("ActionA").Connect(SAManipHitBox_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAManipHitBox_node_ActionA, assetPath);
					variableCount += SAManipHitBox_node_ActionA.SetData((SAManipHitBox)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAUpdateHurtboxes:
					SAUpdateHurtboxesNode SAUpdateHurtboxes_node_ActionA = graph.AddNode<SAUpdateHurtboxesNode>();
					GetPort("ActionA").Connect(SAUpdateHurtboxes_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAUpdateHurtboxes_node_ActionA, assetPath);
					variableCount += SAUpdateHurtboxes_node_ActionA.SetData((SAUpdateHurtboxes)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SASetupHurtboxes:
					SASetupHurtboxesNode SASetupHurtboxes_node_ActionA = graph.AddNode<SASetupHurtboxesNode>();
					GetPort("ActionA").Connect(SASetupHurtboxes_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SASetupHurtboxes_node_ActionA, assetPath);
					variableCount += SASetupHurtboxes_node_ActionA.SetData((SASetupHurtboxes)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAManipHurtBox:
					SAManipHurtBoxNode SAManipHurtBox_node_ActionA = graph.AddNode<SAManipHurtBoxNode>();
					GetPort("ActionA").Connect(SAManipHurtBox_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAManipHurtBox_node_ActionA, assetPath);
					variableCount += SAManipHurtBox_node_ActionA.SetData((SAManipHurtBox)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SABoneState:
					SABoneStateNode SABoneState_node_ActionA = graph.AddNode<SABoneStateNode>();
					GetPort("ActionA").Connect(SABoneState_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SABoneState_node_ActionA, assetPath);
					variableCount += SABoneState_node_ActionA.SetData((SABoneState)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SABoneScale:
					SABoneScaleNode SABoneScale_node_ActionA = graph.AddNode<SABoneScaleNode>();
					GetPort("ActionA").Connect(SABoneScale_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SABoneScale_node_ActionA, assetPath);
					variableCount += SABoneScale_node_ActionA.SetData((SABoneScale)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SASpawnAgent:
					SASpawnAgentNode SASpawnAgent_node_ActionA = graph.AddNode<SASpawnAgentNode>();
					GetPort("ActionA").Connect(SASpawnAgent_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SASpawnAgent_node_ActionA, assetPath);
					variableCount += SASpawnAgent_node_ActionA.SetData((SASpawnAgent)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SALocalFX:
					SALocalFXNode SALocalFX_node_ActionA = graph.AddNode<SALocalFXNode>();
					GetPort("ActionA").Connect(SALocalFX_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SALocalFX_node_ActionA, assetPath);
					variableCount += SALocalFX_node_ActionA.SetData((SALocalFX)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SASpawnFX:
					SASpawnFXNode SASpawnFX_node_ActionA = graph.AddNode<SASpawnFXNode>();
					GetPort("ActionA").Connect(SASpawnFX_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SASpawnFX_node_ActionA, assetPath);
					variableCount += SASpawnFX_node_ActionA.SetData((SASpawnFX)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SASetHitboxFX:
					SASetHitboxFXNode SASetHitboxFX_node_ActionA = graph.AddNode<SASetHitboxFXNode>();
					GetPort("ActionA").Connect(SASetHitboxFX_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SASetHitboxFX_node_ActionA, assetPath);
					variableCount += SASetHitboxFX_node_ActionA.SetData((SASetHitboxFX)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAPlaySFX:
					SAPlaySFXNode SAPlaySFX_node_ActionA = graph.AddNode<SAPlaySFXNode>();
					GetPort("ActionA").Connect(SAPlaySFX_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAPlaySFX_node_ActionA, assetPath);
					variableCount += SAPlaySFX_node_ActionA.SetData((SAPlaySFX)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SASetHitboxSFX:
					SASetHitboxSFXNode SASetHitboxSFX_node_ActionA = graph.AddNode<SASetHitboxSFXNode>();
					GetPort("ActionA").Connect(SASetHitboxSFX_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SASetHitboxSFX_node_ActionA, assetPath);
					variableCount += SASetHitboxSFX_node_ActionA.SetData((SASetHitboxSFX)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAColorTint:
					SAColorTintNode SAColorTint_node_ActionA = graph.AddNode<SAColorTintNode>();
					GetPort("ActionA").Connect(SAColorTint_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAColorTint_node_ActionA, assetPath);
					variableCount += SAColorTint_node_ActionA.SetData((SAColorTint)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAFindFloor:
					SAFindFloorNode SAFindFloor_node_ActionA = graph.AddNode<SAFindFloorNode>();
					GetPort("ActionA").Connect(SAFindFloor_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAFindFloor_node_ActionA, assetPath);
					variableCount += SAFindFloor_node_ActionA.SetData((SAFindFloor)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAHurtGrabbed:
					SAHurtGrabbedNode SAHurtGrabbed_node_ActionA = graph.AddNode<SAHurtGrabbedNode>();
					GetPort("ActionA").Connect(SAHurtGrabbed_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAHurtGrabbed_node_ActionA, assetPath);
					variableCount += SAHurtGrabbed_node_ActionA.SetData((SAHurtGrabbed)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SALaunchGrabbed:
					SALaunchGrabbedNode SALaunchGrabbed_node_ActionA = graph.AddNode<SALaunchGrabbedNode>();
					GetPort("ActionA").Connect(SALaunchGrabbed_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SALaunchGrabbed_node_ActionA, assetPath);
					variableCount += SALaunchGrabbed_node_ActionA.SetData((SALaunchGrabbed)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAStateCancelGrabbed:
					SAStateCancelGrabbedNode SAStateCancelGrabbed_node_ActionA = graph.AddNode<SAStateCancelGrabbedNode>();
					GetPort("ActionA").Connect(SAStateCancelGrabbed_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAStateCancelGrabbed_node_ActionA, assetPath);
					variableCount += SAStateCancelGrabbed_node_ActionA.SetData((SAStateCancelGrabbed)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAEndGrab:
					SAEndGrabNode SAEndGrab_node_ActionA = graph.AddNode<SAEndGrabNode>();
					GetPort("ActionA").Connect(SAEndGrab_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAEndGrab_node_ActionA, assetPath);
					variableCount += SAEndGrab_node_ActionA.SetData((SAEndGrab)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAGrabNotifyEscape:
					SAGrabNotifyEscapeNode SAGrabNotifyEscape_node_ActionA = graph.AddNode<SAGrabNotifyEscapeNode>();
					GetPort("ActionA").Connect(SAGrabNotifyEscape_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAGrabNotifyEscape_node_ActionA, assetPath);
					variableCount += SAGrabNotifyEscape_node_ActionA.SetData((SAGrabNotifyEscape)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAIgnoreGrabbed:
					SAIgnoreGrabbedNode SAIgnoreGrabbed_node_ActionA = graph.AddNode<SAIgnoreGrabbedNode>();
					GetPort("ActionA").Connect(SAIgnoreGrabbed_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAIgnoreGrabbed_node_ActionA, assetPath);
					variableCount += SAIgnoreGrabbed_node_ActionA.SetData((SAIgnoreGrabbed)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAEventKO:
					SAEventKONode SAEventKO_node_ActionA = graph.AddNode<SAEventKONode>();
					GetPort("ActionA").Connect(SAEventKO_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAEventKO_node_ActionA, assetPath);
					variableCount += SAEventKO_node_ActionA.SetData((SAEventKO)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAEventKOGrabbed:
					SAEventKOGrabbedNode SAEventKOGrabbed_node_ActionA = graph.AddNode<SAEventKOGrabbedNode>();
					GetPort("ActionA").Connect(SAEventKOGrabbed_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAEventKOGrabbed_node_ActionA, assetPath);
					variableCount += SAEventKOGrabbed_node_ActionA.SetData((SAEventKOGrabbed)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SACameraShake:
					SACameraShakeNode SACameraShake_node_ActionA = graph.AddNode<SACameraShakeNode>();
					GetPort("ActionA").Connect(SACameraShake_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SACameraShake_node_ActionA, assetPath);
					variableCount += SACameraShake_node_ActionA.SetData((SACameraShake)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAResetOnHits:
					SAResetOnHitsNode SAResetOnHits_node_ActionA = graph.AddNode<SAResetOnHitsNode>();
					GetPort("ActionA").Connect(SAResetOnHits_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAResetOnHits_node_ActionA, assetPath);
					variableCount += SAResetOnHits_node_ActionA.SetData((SAResetOnHits)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAOnHit:
					SAOnHitNode SAOnHit_node_ActionA = graph.AddNode<SAOnHitNode>();
					GetPort("ActionA").Connect(SAOnHit_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAOnHit_node_ActionA, assetPath);
					variableCount += SAOnHit_node_ActionA.SetData((SAOnHit)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAFastForwardState:
					SAFastForwardStateNode SAFastForwardState_node_ActionA = graph.AddNode<SAFastForwardStateNode>();
					GetPort("ActionA").Connect(SAFastForwardState_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAFastForwardState_node_ActionA, assetPath);
					variableCount += SAFastForwardState_node_ActionA.SetData((SAFastForwardState)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SATimingTweak:
					SATimingTweakNode SATimingTweak_node_ActionA = graph.AddNode<SATimingTweakNode>();
					GetPort("ActionA").Connect(SATimingTweak_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SATimingTweak_node_ActionA, assetPath);
					variableCount += SATimingTweak_node_ActionA.SetData((SATimingTweak)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAMapAnimation:
					SAMapAnimationNode SAMapAnimation_node_ActionA = graph.AddNode<SAMapAnimationNode>();
					GetPort("ActionA").Connect(SAMapAnimation_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAMapAnimation_node_ActionA, assetPath);
					variableCount += SAMapAnimation_node_ActionA.SetData((SAMapAnimation)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAAlterMoveDT:
					SAAlterMoveDTNode SAAlterMoveDT_node_ActionA = graph.AddNode<SAAlterMoveDTNode>();
					GetPort("ActionA").Connect(SAAlterMoveDT_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAAlterMoveDT_node_ActionA, assetPath);
					variableCount += SAAlterMoveDT_node_ActionA.SetData((SAAlterMoveDT)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAAlterMoveVel:
					SAAlterMoveVelNode SAAlterMoveVel_node_ActionA = graph.AddNode<SAAlterMoveVelNode>();
					GetPort("ActionA").Connect(SAAlterMoveVel_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAAlterMoveVel_node_ActionA, assetPath);
					variableCount += SAAlterMoveVel_node_ActionA.SetData((SAAlterMoveVel)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SASetStagePart:
					SASetStagePartNode SASetStagePart_node_ActionA = graph.AddNode<SASetStagePartNode>();
					GetPort("ActionA").Connect(SASetStagePart_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SASetStagePart_node_ActionA, assetPath);
					variableCount += SASetStagePart_node_ActionA.SetData((SASetStagePart)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SASetStagePartsDefault:
					SASetStagePartsDefaultNode SASetStagePartsDefault_node_ActionA = graph.AddNode<SASetStagePartsDefaultNode>();
					GetPort("ActionA").Connect(SASetStagePartsDefault_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SASetStagePartsDefault_node_ActionA, assetPath);
					variableCount += SASetStagePartsDefault_node_ActionA.SetData((SASetStagePartsDefault)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAJump:
					SAJumpNode SAJump_node_ActionA = graph.AddNode<SAJumpNode>();
					GetPort("ActionA").Connect(SAJump_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAJump_node_ActionA, assetPath);
					variableCount += SAJump_node_ActionA.SetData((SAJump)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAStopJump:
					SAStopJumpNode SAStopJump_node_ActionA = graph.AddNode<SAStopJumpNode>();
					GetPort("ActionA").Connect(SAStopJump_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAStopJump_node_ActionA, assetPath);
					variableCount += SAStopJump_node_ActionA.SetData((SAStopJump)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAManageAirJump:
					SAManageAirJumpNode SAManageAirJump_node_ActionA = graph.AddNode<SAManageAirJumpNode>();
					GetPort("ActionA").Connect(SAManageAirJump_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAManageAirJump_node_ActionA, assetPath);
					variableCount += SAManageAirJump_node_ActionA.SetData((SAManageAirJump)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SALeaveGround:
					SALeaveGroundNode SALeaveGround_node_ActionA = graph.AddNode<SALeaveGroundNode>();
					GetPort("ActionA").Connect(SALeaveGround_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SALeaveGround_node_ActionA, assetPath);
					variableCount += SALeaveGround_node_ActionA.SetData((SALeaveGround)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAUnHogEdge:
					SAUnHogEdgeNode SAUnHogEdge_node_ActionA = graph.AddNode<SAUnHogEdgeNode>();
					GetPort("ActionA").Connect(SAUnHogEdge_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAUnHogEdge_node_ActionA, assetPath);
					variableCount += SAUnHogEdge_node_ActionA.SetData((SAUnHogEdge)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAPlaySFXTimeline:
					SAPlaySFXTimelineNode SAPlaySFXTimeline_node_ActionA = graph.AddNode<SAPlaySFXTimelineNode>();
					GetPort("ActionA").Connect(SAPlaySFXTimeline_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAPlaySFXTimeline_node_ActionA, assetPath);
					variableCount += SAPlaySFXTimeline_node_ActionA.SetData((SAPlaySFXTimeline)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAFindLastHorizontalInput:
					SAFindLastHorizontalInputNode SAFindLastHorizontalInput_node_ActionA = graph.AddNode<SAFindLastHorizontalInputNode>();
					GetPort("ActionA").Connect(SAFindLastHorizontalInput_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAFindLastHorizontalInput_node_ActionA, assetPath);
					variableCount += SAFindLastHorizontalInput_node_ActionA.SetData((SAFindLastHorizontalInput)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SASetCommandGrab:
					SASetCommandGrabNode SASetCommandGrab_node_ActionA = graph.AddNode<SASetCommandGrabNode>();
					GetPort("ActionA").Connect(SASetCommandGrab_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SASetCommandGrab_node_ActionA, assetPath);
					variableCount += SASetCommandGrab_node_ActionA.SetData((SASetCommandGrab)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SACameraPunch:
					SACameraPunchNode SACameraPunch_node_ActionA = graph.AddNode<SACameraPunchNode>();
					GetPort("ActionA").Connect(SACameraPunch_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SACameraPunch_node_ActionA, assetPath);
					variableCount += SACameraPunch_node_ActionA.SetData((SACameraPunch)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SASpawnAgent2:
					SASpawnAgent2Node SASpawnAgent2_node_ActionA = graph.AddNode<SASpawnAgent2Node>();
					GetPort("ActionA").Connect(SASpawnAgent2_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SASpawnAgent2_node_ActionA, assetPath);
					variableCount += SASpawnAgent2_node_ActionA.SetData((SASpawnAgent2)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAManipDecorChain:
					SAManipDecorChainNode SAManipDecorChain_node_ActionA = graph.AddNode<SAManipDecorChainNode>();
					GetPort("ActionA").Connect(SAManipDecorChain_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAManipDecorChain_node_ActionA, assetPath);
					variableCount += SAManipDecorChain_node_ActionA.SetData((SAManipDecorChain)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAUpdateHitboxes:
					SAUpdateHitboxesNode SAUpdateHitboxes_node_ActionA = graph.AddNode<SAUpdateHitboxesNode>();
					GetPort("ActionA").Connect(SAUpdateHitboxes_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAUpdateHitboxes_node_ActionA, assetPath);
					variableCount += SAUpdateHitboxes_node_ActionA.SetData((SAUpdateHitboxes)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SASampleAnim:
					SASampleAnimNode SASampleAnim_node_ActionA = graph.AddNode<SASampleAnimNode>();
					GetPort("ActionA").Connect(SASampleAnim_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SASampleAnim_node_ActionA, assetPath);
					variableCount += SASampleAnim_node_ActionA.SetData((SASampleAnim)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAForceExtraInputCheck:
					SAForceExtraInputCheckNode SAForceExtraInputCheck_node_ActionA = graph.AddNode<SAForceExtraInputCheckNode>();
					GetPort("ActionA").Connect(SAForceExtraInputCheck_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAForceExtraInputCheck_node_ActionA, assetPath);
					variableCount += SAForceExtraInputCheck_node_ActionA.SetData((SAForceExtraInputCheck)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SALaunchGrabbedCustom:
					SALaunchGrabbedCustomNode SALaunchGrabbedCustom_node_ActionA = graph.AddNode<SALaunchGrabbedCustomNode>();
					GetPort("ActionA").Connect(SALaunchGrabbedCustom_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SALaunchGrabbedCustom_node_ActionA, assetPath);
					variableCount += SALaunchGrabbedCustom_node_ActionA.SetData((SALaunchGrabbedCustom)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAMapAnimationSimple:
					SAMapAnimationSimpleNode SAMapAnimationSimple_node_ActionA = graph.AddNode<SAMapAnimationSimpleNode>();
					GetPort("ActionA").Connect(SAMapAnimationSimple_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAMapAnimationSimple_node_ActionA, assetPath);
					variableCount += SAMapAnimationSimple_node_ActionA.SetData((SAMapAnimationSimple)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAPersistLocalFX:
					SAPersistLocalFXNode SAPersistLocalFX_node_ActionA = graph.AddNode<SAPersistLocalFXNode>();
					GetPort("ActionA").Connect(SAPersistLocalFX_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAPersistLocalFX_node_ActionA, assetPath);
					variableCount += SAPersistLocalFX_node_ActionA.SetData((SAPersistLocalFX)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAOnLeaveParent:
					SAOnLeaveParentNode SAOnLeaveParent_node_ActionA = graph.AddNode<SAOnLeaveParentNode>();
					GetPort("ActionA").Connect(SAOnLeaveParent_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAOnLeaveParent_node_ActionA, assetPath);
					variableCount += SAOnLeaveParent_node_ActionA.SetData((SAOnLeaveParent)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAPlayVoiceLine:
					SAPlayVoiceLineNode SAPlayVoiceLine_node_ActionA = graph.AddNode<SAPlayVoiceLineNode>();
					GetPort("ActionA").Connect(SAPlayVoiceLine_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAPlayVoiceLine_node_ActionA, assetPath);
					variableCount += SAPlayVoiceLine_node_ActionA.SetData((SAPlayVoiceLine)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAPlayCategoryVoiceLine:
					SAPlayCategoryVoiceLineNode SAPlayCategoryVoiceLine_node_ActionA = graph.AddNode<SAPlayCategoryVoiceLineNode>();
					GetPort("ActionA").Connect(SAPlayCategoryVoiceLine_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAPlayCategoryVoiceLine_node_ActionA, assetPath);
					variableCount += SAPlayCategoryVoiceLine_node_ActionA.SetData((SAPlayCategoryVoiceLine)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAStopVoiceLines:
					SAStopVoiceLinesNode SAStopVoiceLines_node_ActionA = graph.AddNode<SAStopVoiceLinesNode>();
					GetPort("ActionA").Connect(SAStopVoiceLines_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAStopVoiceLines_node_ActionA, assetPath);
					variableCount += SAStopVoiceLines_node_ActionA.SetData((SAStopVoiceLines)ActionA, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
			}
			++variableCount;
			
			ActionB = data.ActionB;
			
			switch (ActionB.TID)
			{
				case StateAction.TypeId.StateAction:
					StateActionNode StateAction_node_ActionB = graph.AddNode<StateActionNode>();
					GetPort("ActionB").Connect(StateAction_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(StateAction_node_ActionB, assetPath);
					variableCount += StateAction_node_ActionB.SetData((StateAction)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SADebugMessage:
					SADebugMessageNode SADebugMessage_node_ActionB = graph.AddNode<SADebugMessageNode>();
					GetPort("ActionB").Connect(SADebugMessage_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SADebugMessage_node_ActionB, assetPath);
					variableCount += SADebugMessage_node_ActionB.SetData((SADebugMessage)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAPlayAnim:
					SAPlayAnimNode SAPlayAnim_node_ActionB = graph.AddNode<SAPlayAnimNode>();
					GetPort("ActionB").Connect(SAPlayAnim_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAPlayAnim_node_ActionB, assetPath);
					variableCount += SAPlayAnim_node_ActionB.SetData((SAPlayAnim)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAPlayRootAnim:
					SAPlayRootAnimNode SAPlayRootAnim_node_ActionB = graph.AddNode<SAPlayRootAnimNode>();
					GetPort("ActionB").Connect(SAPlayRootAnim_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAPlayRootAnim_node_ActionB, assetPath);
					variableCount += SAPlayRootAnim_node_ActionB.SetData((SAPlayRootAnim)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SASnapAnimWeights:
					SASnapAnimWeightsNode SASnapAnimWeights_node_ActionB = graph.AddNode<SASnapAnimWeightsNode>();
					GetPort("ActionB").Connect(SASnapAnimWeights_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SASnapAnimWeights_node_ActionB, assetPath);
					variableCount += SASnapAnimWeights_node_ActionB.SetData((SASnapAnimWeights)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAStandardInput:
					SAStandardInputNode SAStandardInput_node_ActionB = graph.AddNode<SAStandardInputNode>();
					GetPort("ActionB").Connect(SAStandardInput_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAStandardInput_node_ActionB, assetPath);
					variableCount += SAStandardInput_node_ActionB.SetData((SAStandardInput)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAInputAction:
					SAInputActionNode SAInputAction_node_ActionB = graph.AddNode<SAInputActionNode>();
					GetPort("ActionB").Connect(SAInputAction_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAInputAction_node_ActionB, assetPath);
					variableCount += SAInputAction_node_ActionB.SetData((SAInputAction)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SADeactivateInputAction:
					SADeactivateInputActionNode SADeactivateInputAction_node_ActionB = graph.AddNode<SADeactivateInputActionNode>();
					GetPort("ActionB").Connect(SADeactivateInputAction_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SADeactivateInputAction_node_ActionB, assetPath);
					variableCount += SADeactivateInputAction_node_ActionB.SetData((SADeactivateInputAction)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAAddInputEventFromFrame:
					SAAddInputEventFromFrameNode SAAddInputEventFromFrame_node_ActionB = graph.AddNode<SAAddInputEventFromFrameNode>();
					GetPort("ActionB").Connect(SAAddInputEventFromFrame_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAAddInputEventFromFrame_node_ActionB, assetPath);
					variableCount += SAAddInputEventFromFrame_node_ActionB.SetData((SAAddInputEventFromFrame)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SACancelToState:
					SACancelToStateNode SACancelToState_node_ActionB = graph.AddNode<SACancelToStateNode>();
					GetPort("ActionB").Connect(SACancelToState_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SACancelToState_node_ActionB, assetPath);
					variableCount += SACancelToState_node_ActionB.SetData((SACancelToState)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SACustomCall:
					SACustomCallNode SACustomCall_node_ActionB = graph.AddNode<SACustomCallNode>();
					GetPort("ActionB").Connect(SACustomCall_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SACustomCall_node_ActionB, assetPath);
					variableCount += SACustomCall_node_ActionB.SetData((SACustomCall)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SATimedAction:
					SATimedActionNode SATimedAction_node_ActionB = graph.AddNode<SATimedActionNode>();
					GetPort("ActionB").Connect(SATimedAction_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SATimedAction_node_ActionB, assetPath);
					variableCount += SATimedAction_node_ActionB.SetData((SATimedAction)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAOrderSensitive:
					SAOrderSensitiveNode SAOrderSensitive_node_ActionB = graph.AddNode<SAOrderSensitiveNode>();
					GetPort("ActionB").Connect(SAOrderSensitive_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAOrderSensitive_node_ActionB, assetPath);
					variableCount += SAOrderSensitive_node_ActionB.SetData((SAOrderSensitive)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAProxyMove:
					SAProxyMoveNode SAProxyMove_node_ActionB = graph.AddNode<SAProxyMoveNode>();
					GetPort("ActionB").Connect(SAProxyMove_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAProxyMove_node_ActionB, assetPath);
					variableCount += SAProxyMove_node_ActionB.SetData((SAProxyMove)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SACheckThing:
					SACheckThingNode SACheckThing_node_ActionB = graph.AddNode<SACheckThingNode>();
					GetPort("ActionB").Connect(SACheckThing_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SACheckThing_node_ActionB, assetPath);
					variableCount += SACheckThing_node_ActionB.SetData((SACheckThing)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAActiveAction:
					SAActiveActionNode SAActiveAction_node_ActionB = graph.AddNode<SAActiveActionNode>();
					GetPort("ActionB").Connect(SAActiveAction_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAActiveAction_node_ActionB, assetPath);
					variableCount += SAActiveAction_node_ActionB.SetData((SAActiveAction)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SADeactivateAction:
					SADeactivateActionNode SADeactivateAction_node_ActionB = graph.AddNode<SADeactivateActionNode>();
					GetPort("ActionB").Connect(SADeactivateAction_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SADeactivateAction_node_ActionB, assetPath);
					variableCount += SADeactivateAction_node_ActionB.SetData((SADeactivateAction)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SASetFloatTarget:
					SASetFloatTargetNode SASetFloatTarget_node_ActionB = graph.AddNode<SASetFloatTargetNode>();
					GetPort("ActionB").Connect(SASetFloatTarget_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SASetFloatTarget_node_ActionB, assetPath);
					variableCount += SASetFloatTarget_node_ActionB.SetData((SASetFloatTarget)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAOnBounce:
					SAOnBounceNode SAOnBounce_node_ActionB = graph.AddNode<SAOnBounceNode>();
					GetPort("ActionB").Connect(SAOnBounce_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAOnBounce_node_ActionB, assetPath);
					variableCount += SAOnBounce_node_ActionB.SetData((SAOnBounce)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAOnLeaveEdge:
					SAOnLeaveEdgeNode SAOnLeaveEdge_node_ActionB = graph.AddNode<SAOnLeaveEdgeNode>();
					GetPort("ActionB").Connect(SAOnLeaveEdge_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAOnLeaveEdge_node_ActionB, assetPath);
					variableCount += SAOnLeaveEdge_node_ActionB.SetData((SAOnLeaveEdge)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAOnStoppedAtEdge:
					SAOnStoppedAtEdgeNode SAOnStoppedAtEdge_node_ActionB = graph.AddNode<SAOnStoppedAtEdgeNode>();
					GetPort("ActionB").Connect(SAOnStoppedAtEdge_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAOnStoppedAtEdge_node_ActionB, assetPath);
					variableCount += SAOnStoppedAtEdge_node_ActionB.SetData((SAOnStoppedAtEdge)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAOnLand:
					SAOnLandNode SAOnLand_node_ActionB = graph.AddNode<SAOnLandNode>();
					GetPort("ActionB").Connect(SAOnLand_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAOnLand_node_ActionB, assetPath);
					variableCount += SAOnLand_node_ActionB.SetData((SAOnLand)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAOnCancel:
					SAOnCancelNode SAOnCancel_node_ActionB = graph.AddNode<SAOnCancelNode>();
					GetPort("ActionB").Connect(SAOnCancel_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAOnCancel_node_ActionB, assetPath);
					variableCount += SAOnCancel_node_ActionB.SetData((SAOnCancel)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SARefreshAttack:
					SARefreshAttackNode SARefreshAttack_node_ActionB = graph.AddNode<SARefreshAttackNode>();
					GetPort("ActionB").Connect(SARefreshAttack_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SARefreshAttack_node_ActionB, assetPath);
					variableCount += SARefreshAttack_node_ActionB.SetData((SARefreshAttack)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAEndAttack:
					SAEndAttackNode SAEndAttack_node_ActionB = graph.AddNode<SAEndAttackNode>();
					GetPort("ActionB").Connect(SAEndAttack_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAEndAttack_node_ActionB, assetPath);
					variableCount += SAEndAttack_node_ActionB.SetData((SAEndAttack)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SASetHitboxCount:
					SASetHitboxCountNode SASetHitboxCount_node_ActionB = graph.AddNode<SASetHitboxCountNode>();
					GetPort("ActionB").Connect(SASetHitboxCount_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SASetHitboxCount_node_ActionB, assetPath);
					variableCount += SASetHitboxCount_node_ActionB.SetData((SASetHitboxCount)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAConfigHitbox:
					SAConfigHitboxNode SAConfigHitbox_node_ActionB = graph.AddNode<SAConfigHitboxNode>();
					GetPort("ActionB").Connect(SAConfigHitbox_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAConfigHitbox_node_ActionB, assetPath);
					variableCount += SAConfigHitbox_node_ActionB.SetData((SAConfigHitbox)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SASetAtkProp:
					SASetAtkPropNode SASetAtkProp_node_ActionB = graph.AddNode<SASetAtkPropNode>();
					GetPort("ActionB").Connect(SASetAtkProp_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SASetAtkProp_node_ActionB, assetPath);
					variableCount += SASetAtkProp_node_ActionB.SetData((SASetAtkProp)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAManipHitBox:
					SAManipHitBoxNode SAManipHitBox_node_ActionB = graph.AddNode<SAManipHitBoxNode>();
					GetPort("ActionB").Connect(SAManipHitBox_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAManipHitBox_node_ActionB, assetPath);
					variableCount += SAManipHitBox_node_ActionB.SetData((SAManipHitBox)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAUpdateHurtboxes:
					SAUpdateHurtboxesNode SAUpdateHurtboxes_node_ActionB = graph.AddNode<SAUpdateHurtboxesNode>();
					GetPort("ActionB").Connect(SAUpdateHurtboxes_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAUpdateHurtboxes_node_ActionB, assetPath);
					variableCount += SAUpdateHurtboxes_node_ActionB.SetData((SAUpdateHurtboxes)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SASetupHurtboxes:
					SASetupHurtboxesNode SASetupHurtboxes_node_ActionB = graph.AddNode<SASetupHurtboxesNode>();
					GetPort("ActionB").Connect(SASetupHurtboxes_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SASetupHurtboxes_node_ActionB, assetPath);
					variableCount += SASetupHurtboxes_node_ActionB.SetData((SASetupHurtboxes)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAManipHurtBox:
					SAManipHurtBoxNode SAManipHurtBox_node_ActionB = graph.AddNode<SAManipHurtBoxNode>();
					GetPort("ActionB").Connect(SAManipHurtBox_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAManipHurtBox_node_ActionB, assetPath);
					variableCount += SAManipHurtBox_node_ActionB.SetData((SAManipHurtBox)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SABoneState:
					SABoneStateNode SABoneState_node_ActionB = graph.AddNode<SABoneStateNode>();
					GetPort("ActionB").Connect(SABoneState_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SABoneState_node_ActionB, assetPath);
					variableCount += SABoneState_node_ActionB.SetData((SABoneState)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SABoneScale:
					SABoneScaleNode SABoneScale_node_ActionB = graph.AddNode<SABoneScaleNode>();
					GetPort("ActionB").Connect(SABoneScale_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SABoneScale_node_ActionB, assetPath);
					variableCount += SABoneScale_node_ActionB.SetData((SABoneScale)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SASpawnAgent:
					SASpawnAgentNode SASpawnAgent_node_ActionB = graph.AddNode<SASpawnAgentNode>();
					GetPort("ActionB").Connect(SASpawnAgent_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SASpawnAgent_node_ActionB, assetPath);
					variableCount += SASpawnAgent_node_ActionB.SetData((SASpawnAgent)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SALocalFX:
					SALocalFXNode SALocalFX_node_ActionB = graph.AddNode<SALocalFXNode>();
					GetPort("ActionB").Connect(SALocalFX_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SALocalFX_node_ActionB, assetPath);
					variableCount += SALocalFX_node_ActionB.SetData((SALocalFX)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SASpawnFX:
					SASpawnFXNode SASpawnFX_node_ActionB = graph.AddNode<SASpawnFXNode>();
					GetPort("ActionB").Connect(SASpawnFX_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SASpawnFX_node_ActionB, assetPath);
					variableCount += SASpawnFX_node_ActionB.SetData((SASpawnFX)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SASetHitboxFX:
					SASetHitboxFXNode SASetHitboxFX_node_ActionB = graph.AddNode<SASetHitboxFXNode>();
					GetPort("ActionB").Connect(SASetHitboxFX_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SASetHitboxFX_node_ActionB, assetPath);
					variableCount += SASetHitboxFX_node_ActionB.SetData((SASetHitboxFX)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAPlaySFX:
					SAPlaySFXNode SAPlaySFX_node_ActionB = graph.AddNode<SAPlaySFXNode>();
					GetPort("ActionB").Connect(SAPlaySFX_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAPlaySFX_node_ActionB, assetPath);
					variableCount += SAPlaySFX_node_ActionB.SetData((SAPlaySFX)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SASetHitboxSFX:
					SASetHitboxSFXNode SASetHitboxSFX_node_ActionB = graph.AddNode<SASetHitboxSFXNode>();
					GetPort("ActionB").Connect(SASetHitboxSFX_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SASetHitboxSFX_node_ActionB, assetPath);
					variableCount += SASetHitboxSFX_node_ActionB.SetData((SASetHitboxSFX)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAColorTint:
					SAColorTintNode SAColorTint_node_ActionB = graph.AddNode<SAColorTintNode>();
					GetPort("ActionB").Connect(SAColorTint_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAColorTint_node_ActionB, assetPath);
					variableCount += SAColorTint_node_ActionB.SetData((SAColorTint)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAFindFloor:
					SAFindFloorNode SAFindFloor_node_ActionB = graph.AddNode<SAFindFloorNode>();
					GetPort("ActionB").Connect(SAFindFloor_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAFindFloor_node_ActionB, assetPath);
					variableCount += SAFindFloor_node_ActionB.SetData((SAFindFloor)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAHurtGrabbed:
					SAHurtGrabbedNode SAHurtGrabbed_node_ActionB = graph.AddNode<SAHurtGrabbedNode>();
					GetPort("ActionB").Connect(SAHurtGrabbed_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAHurtGrabbed_node_ActionB, assetPath);
					variableCount += SAHurtGrabbed_node_ActionB.SetData((SAHurtGrabbed)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SALaunchGrabbed:
					SALaunchGrabbedNode SALaunchGrabbed_node_ActionB = graph.AddNode<SALaunchGrabbedNode>();
					GetPort("ActionB").Connect(SALaunchGrabbed_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SALaunchGrabbed_node_ActionB, assetPath);
					variableCount += SALaunchGrabbed_node_ActionB.SetData((SALaunchGrabbed)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAStateCancelGrabbed:
					SAStateCancelGrabbedNode SAStateCancelGrabbed_node_ActionB = graph.AddNode<SAStateCancelGrabbedNode>();
					GetPort("ActionB").Connect(SAStateCancelGrabbed_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAStateCancelGrabbed_node_ActionB, assetPath);
					variableCount += SAStateCancelGrabbed_node_ActionB.SetData((SAStateCancelGrabbed)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAEndGrab:
					SAEndGrabNode SAEndGrab_node_ActionB = graph.AddNode<SAEndGrabNode>();
					GetPort("ActionB").Connect(SAEndGrab_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAEndGrab_node_ActionB, assetPath);
					variableCount += SAEndGrab_node_ActionB.SetData((SAEndGrab)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAGrabNotifyEscape:
					SAGrabNotifyEscapeNode SAGrabNotifyEscape_node_ActionB = graph.AddNode<SAGrabNotifyEscapeNode>();
					GetPort("ActionB").Connect(SAGrabNotifyEscape_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAGrabNotifyEscape_node_ActionB, assetPath);
					variableCount += SAGrabNotifyEscape_node_ActionB.SetData((SAGrabNotifyEscape)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAIgnoreGrabbed:
					SAIgnoreGrabbedNode SAIgnoreGrabbed_node_ActionB = graph.AddNode<SAIgnoreGrabbedNode>();
					GetPort("ActionB").Connect(SAIgnoreGrabbed_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAIgnoreGrabbed_node_ActionB, assetPath);
					variableCount += SAIgnoreGrabbed_node_ActionB.SetData((SAIgnoreGrabbed)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAEventKO:
					SAEventKONode SAEventKO_node_ActionB = graph.AddNode<SAEventKONode>();
					GetPort("ActionB").Connect(SAEventKO_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAEventKO_node_ActionB, assetPath);
					variableCount += SAEventKO_node_ActionB.SetData((SAEventKO)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAEventKOGrabbed:
					SAEventKOGrabbedNode SAEventKOGrabbed_node_ActionB = graph.AddNode<SAEventKOGrabbedNode>();
					GetPort("ActionB").Connect(SAEventKOGrabbed_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAEventKOGrabbed_node_ActionB, assetPath);
					variableCount += SAEventKOGrabbed_node_ActionB.SetData((SAEventKOGrabbed)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SACameraShake:
					SACameraShakeNode SACameraShake_node_ActionB = graph.AddNode<SACameraShakeNode>();
					GetPort("ActionB").Connect(SACameraShake_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SACameraShake_node_ActionB, assetPath);
					variableCount += SACameraShake_node_ActionB.SetData((SACameraShake)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAResetOnHits:
					SAResetOnHitsNode SAResetOnHits_node_ActionB = graph.AddNode<SAResetOnHitsNode>();
					GetPort("ActionB").Connect(SAResetOnHits_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAResetOnHits_node_ActionB, assetPath);
					variableCount += SAResetOnHits_node_ActionB.SetData((SAResetOnHits)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAOnHit:
					SAOnHitNode SAOnHit_node_ActionB = graph.AddNode<SAOnHitNode>();
					GetPort("ActionB").Connect(SAOnHit_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAOnHit_node_ActionB, assetPath);
					variableCount += SAOnHit_node_ActionB.SetData((SAOnHit)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAFastForwardState:
					SAFastForwardStateNode SAFastForwardState_node_ActionB = graph.AddNode<SAFastForwardStateNode>();
					GetPort("ActionB").Connect(SAFastForwardState_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAFastForwardState_node_ActionB, assetPath);
					variableCount += SAFastForwardState_node_ActionB.SetData((SAFastForwardState)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SATimingTweak:
					SATimingTweakNode SATimingTweak_node_ActionB = graph.AddNode<SATimingTweakNode>();
					GetPort("ActionB").Connect(SATimingTweak_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SATimingTweak_node_ActionB, assetPath);
					variableCount += SATimingTweak_node_ActionB.SetData((SATimingTweak)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAMapAnimation:
					SAMapAnimationNode SAMapAnimation_node_ActionB = graph.AddNode<SAMapAnimationNode>();
					GetPort("ActionB").Connect(SAMapAnimation_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAMapAnimation_node_ActionB, assetPath);
					variableCount += SAMapAnimation_node_ActionB.SetData((SAMapAnimation)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAAlterMoveDT:
					SAAlterMoveDTNode SAAlterMoveDT_node_ActionB = graph.AddNode<SAAlterMoveDTNode>();
					GetPort("ActionB").Connect(SAAlterMoveDT_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAAlterMoveDT_node_ActionB, assetPath);
					variableCount += SAAlterMoveDT_node_ActionB.SetData((SAAlterMoveDT)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAAlterMoveVel:
					SAAlterMoveVelNode SAAlterMoveVel_node_ActionB = graph.AddNode<SAAlterMoveVelNode>();
					GetPort("ActionB").Connect(SAAlterMoveVel_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAAlterMoveVel_node_ActionB, assetPath);
					variableCount += SAAlterMoveVel_node_ActionB.SetData((SAAlterMoveVel)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SASetStagePart:
					SASetStagePartNode SASetStagePart_node_ActionB = graph.AddNode<SASetStagePartNode>();
					GetPort("ActionB").Connect(SASetStagePart_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SASetStagePart_node_ActionB, assetPath);
					variableCount += SASetStagePart_node_ActionB.SetData((SASetStagePart)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SASetStagePartsDefault:
					SASetStagePartsDefaultNode SASetStagePartsDefault_node_ActionB = graph.AddNode<SASetStagePartsDefaultNode>();
					GetPort("ActionB").Connect(SASetStagePartsDefault_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SASetStagePartsDefault_node_ActionB, assetPath);
					variableCount += SASetStagePartsDefault_node_ActionB.SetData((SASetStagePartsDefault)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAJump:
					SAJumpNode SAJump_node_ActionB = graph.AddNode<SAJumpNode>();
					GetPort("ActionB").Connect(SAJump_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAJump_node_ActionB, assetPath);
					variableCount += SAJump_node_ActionB.SetData((SAJump)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAStopJump:
					SAStopJumpNode SAStopJump_node_ActionB = graph.AddNode<SAStopJumpNode>();
					GetPort("ActionB").Connect(SAStopJump_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAStopJump_node_ActionB, assetPath);
					variableCount += SAStopJump_node_ActionB.SetData((SAStopJump)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAManageAirJump:
					SAManageAirJumpNode SAManageAirJump_node_ActionB = graph.AddNode<SAManageAirJumpNode>();
					GetPort("ActionB").Connect(SAManageAirJump_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAManageAirJump_node_ActionB, assetPath);
					variableCount += SAManageAirJump_node_ActionB.SetData((SAManageAirJump)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SALeaveGround:
					SALeaveGroundNode SALeaveGround_node_ActionB = graph.AddNode<SALeaveGroundNode>();
					GetPort("ActionB").Connect(SALeaveGround_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SALeaveGround_node_ActionB, assetPath);
					variableCount += SALeaveGround_node_ActionB.SetData((SALeaveGround)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAUnHogEdge:
					SAUnHogEdgeNode SAUnHogEdge_node_ActionB = graph.AddNode<SAUnHogEdgeNode>();
					GetPort("ActionB").Connect(SAUnHogEdge_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAUnHogEdge_node_ActionB, assetPath);
					variableCount += SAUnHogEdge_node_ActionB.SetData((SAUnHogEdge)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAPlaySFXTimeline:
					SAPlaySFXTimelineNode SAPlaySFXTimeline_node_ActionB = graph.AddNode<SAPlaySFXTimelineNode>();
					GetPort("ActionB").Connect(SAPlaySFXTimeline_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAPlaySFXTimeline_node_ActionB, assetPath);
					variableCount += SAPlaySFXTimeline_node_ActionB.SetData((SAPlaySFXTimeline)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAFindLastHorizontalInput:
					SAFindLastHorizontalInputNode SAFindLastHorizontalInput_node_ActionB = graph.AddNode<SAFindLastHorizontalInputNode>();
					GetPort("ActionB").Connect(SAFindLastHorizontalInput_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAFindLastHorizontalInput_node_ActionB, assetPath);
					variableCount += SAFindLastHorizontalInput_node_ActionB.SetData((SAFindLastHorizontalInput)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SASetCommandGrab:
					SASetCommandGrabNode SASetCommandGrab_node_ActionB = graph.AddNode<SASetCommandGrabNode>();
					GetPort("ActionB").Connect(SASetCommandGrab_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SASetCommandGrab_node_ActionB, assetPath);
					variableCount += SASetCommandGrab_node_ActionB.SetData((SASetCommandGrab)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SACameraPunch:
					SACameraPunchNode SACameraPunch_node_ActionB = graph.AddNode<SACameraPunchNode>();
					GetPort("ActionB").Connect(SACameraPunch_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SACameraPunch_node_ActionB, assetPath);
					variableCount += SACameraPunch_node_ActionB.SetData((SACameraPunch)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SASpawnAgent2:
					SASpawnAgent2Node SASpawnAgent2_node_ActionB = graph.AddNode<SASpawnAgent2Node>();
					GetPort("ActionB").Connect(SASpawnAgent2_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SASpawnAgent2_node_ActionB, assetPath);
					variableCount += SASpawnAgent2_node_ActionB.SetData((SASpawnAgent2)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAManipDecorChain:
					SAManipDecorChainNode SAManipDecorChain_node_ActionB = graph.AddNode<SAManipDecorChainNode>();
					GetPort("ActionB").Connect(SAManipDecorChain_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAManipDecorChain_node_ActionB, assetPath);
					variableCount += SAManipDecorChain_node_ActionB.SetData((SAManipDecorChain)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAUpdateHitboxes:
					SAUpdateHitboxesNode SAUpdateHitboxes_node_ActionB = graph.AddNode<SAUpdateHitboxesNode>();
					GetPort("ActionB").Connect(SAUpdateHitboxes_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAUpdateHitboxes_node_ActionB, assetPath);
					variableCount += SAUpdateHitboxes_node_ActionB.SetData((SAUpdateHitboxes)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SASampleAnim:
					SASampleAnimNode SASampleAnim_node_ActionB = graph.AddNode<SASampleAnimNode>();
					GetPort("ActionB").Connect(SASampleAnim_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SASampleAnim_node_ActionB, assetPath);
					variableCount += SASampleAnim_node_ActionB.SetData((SASampleAnim)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAForceExtraInputCheck:
					SAForceExtraInputCheckNode SAForceExtraInputCheck_node_ActionB = graph.AddNode<SAForceExtraInputCheckNode>();
					GetPort("ActionB").Connect(SAForceExtraInputCheck_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAForceExtraInputCheck_node_ActionB, assetPath);
					variableCount += SAForceExtraInputCheck_node_ActionB.SetData((SAForceExtraInputCheck)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SALaunchGrabbedCustom:
					SALaunchGrabbedCustomNode SALaunchGrabbedCustom_node_ActionB = graph.AddNode<SALaunchGrabbedCustomNode>();
					GetPort("ActionB").Connect(SALaunchGrabbedCustom_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SALaunchGrabbedCustom_node_ActionB, assetPath);
					variableCount += SALaunchGrabbedCustom_node_ActionB.SetData((SALaunchGrabbedCustom)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAMapAnimationSimple:
					SAMapAnimationSimpleNode SAMapAnimationSimple_node_ActionB = graph.AddNode<SAMapAnimationSimpleNode>();
					GetPort("ActionB").Connect(SAMapAnimationSimple_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAMapAnimationSimple_node_ActionB, assetPath);
					variableCount += SAMapAnimationSimple_node_ActionB.SetData((SAMapAnimationSimple)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAPersistLocalFX:
					SAPersistLocalFXNode SAPersistLocalFX_node_ActionB = graph.AddNode<SAPersistLocalFXNode>();
					GetPort("ActionB").Connect(SAPersistLocalFX_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAPersistLocalFX_node_ActionB, assetPath);
					variableCount += SAPersistLocalFX_node_ActionB.SetData((SAPersistLocalFX)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAOnLeaveParent:
					SAOnLeaveParentNode SAOnLeaveParent_node_ActionB = graph.AddNode<SAOnLeaveParentNode>();
					GetPort("ActionB").Connect(SAOnLeaveParent_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAOnLeaveParent_node_ActionB, assetPath);
					variableCount += SAOnLeaveParent_node_ActionB.SetData((SAOnLeaveParent)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAPlayVoiceLine:
					SAPlayVoiceLineNode SAPlayVoiceLine_node_ActionB = graph.AddNode<SAPlayVoiceLineNode>();
					GetPort("ActionB").Connect(SAPlayVoiceLine_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAPlayVoiceLine_node_ActionB, assetPath);
					variableCount += SAPlayVoiceLine_node_ActionB.SetData((SAPlayVoiceLine)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAPlayCategoryVoiceLine:
					SAPlayCategoryVoiceLineNode SAPlayCategoryVoiceLine_node_ActionB = graph.AddNode<SAPlayCategoryVoiceLineNode>();
					GetPort("ActionB").Connect(SAPlayCategoryVoiceLine_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAPlayCategoryVoiceLine_node_ActionB, assetPath);
					variableCount += SAPlayCategoryVoiceLine_node_ActionB.SetData((SAPlayCategoryVoiceLine)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAStopVoiceLines:
					SAStopVoiceLinesNode SAStopVoiceLines_node_ActionB = graph.AddNode<SAStopVoiceLinesNode>();
					GetPort("ActionB").Connect(SAStopVoiceLines_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAStopVoiceLines_node_ActionB, assetPath);
					variableCount += SAStopVoiceLines_node_ActionB.SetData((SAStopVoiceLines)ActionB, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
			}
			++variableCount;
			
			ActionEnd = data.ActionEnd;
			
			switch (ActionEnd.TID)
			{
				case StateAction.TypeId.StateAction:
					StateActionNode StateAction_node_ActionEnd = graph.AddNode<StateActionNode>();
					GetPort("ActionEnd").Connect(StateAction_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(StateAction_node_ActionEnd, assetPath);
					variableCount += StateAction_node_ActionEnd.SetData((StateAction)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SADebugMessage:
					SADebugMessageNode SADebugMessage_node_ActionEnd = graph.AddNode<SADebugMessageNode>();
					GetPort("ActionEnd").Connect(SADebugMessage_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SADebugMessage_node_ActionEnd, assetPath);
					variableCount += SADebugMessage_node_ActionEnd.SetData((SADebugMessage)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAPlayAnim:
					SAPlayAnimNode SAPlayAnim_node_ActionEnd = graph.AddNode<SAPlayAnimNode>();
					GetPort("ActionEnd").Connect(SAPlayAnim_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAPlayAnim_node_ActionEnd, assetPath);
					variableCount += SAPlayAnim_node_ActionEnd.SetData((SAPlayAnim)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAPlayRootAnim:
					SAPlayRootAnimNode SAPlayRootAnim_node_ActionEnd = graph.AddNode<SAPlayRootAnimNode>();
					GetPort("ActionEnd").Connect(SAPlayRootAnim_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAPlayRootAnim_node_ActionEnd, assetPath);
					variableCount += SAPlayRootAnim_node_ActionEnd.SetData((SAPlayRootAnim)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SASnapAnimWeights:
					SASnapAnimWeightsNode SASnapAnimWeights_node_ActionEnd = graph.AddNode<SASnapAnimWeightsNode>();
					GetPort("ActionEnd").Connect(SASnapAnimWeights_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SASnapAnimWeights_node_ActionEnd, assetPath);
					variableCount += SASnapAnimWeights_node_ActionEnd.SetData((SASnapAnimWeights)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAStandardInput:
					SAStandardInputNode SAStandardInput_node_ActionEnd = graph.AddNode<SAStandardInputNode>();
					GetPort("ActionEnd").Connect(SAStandardInput_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAStandardInput_node_ActionEnd, assetPath);
					variableCount += SAStandardInput_node_ActionEnd.SetData((SAStandardInput)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAInputAction:
					SAInputActionNode SAInputAction_node_ActionEnd = graph.AddNode<SAInputActionNode>();
					GetPort("ActionEnd").Connect(SAInputAction_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAInputAction_node_ActionEnd, assetPath);
					variableCount += SAInputAction_node_ActionEnd.SetData((SAInputAction)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SADeactivateInputAction:
					SADeactivateInputActionNode SADeactivateInputAction_node_ActionEnd = graph.AddNode<SADeactivateInputActionNode>();
					GetPort("ActionEnd").Connect(SADeactivateInputAction_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SADeactivateInputAction_node_ActionEnd, assetPath);
					variableCount += SADeactivateInputAction_node_ActionEnd.SetData((SADeactivateInputAction)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAAddInputEventFromFrame:
					SAAddInputEventFromFrameNode SAAddInputEventFromFrame_node_ActionEnd = graph.AddNode<SAAddInputEventFromFrameNode>();
					GetPort("ActionEnd").Connect(SAAddInputEventFromFrame_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAAddInputEventFromFrame_node_ActionEnd, assetPath);
					variableCount += SAAddInputEventFromFrame_node_ActionEnd.SetData((SAAddInputEventFromFrame)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SACancelToState:
					SACancelToStateNode SACancelToState_node_ActionEnd = graph.AddNode<SACancelToStateNode>();
					GetPort("ActionEnd").Connect(SACancelToState_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SACancelToState_node_ActionEnd, assetPath);
					variableCount += SACancelToState_node_ActionEnd.SetData((SACancelToState)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SACustomCall:
					SACustomCallNode SACustomCall_node_ActionEnd = graph.AddNode<SACustomCallNode>();
					GetPort("ActionEnd").Connect(SACustomCall_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SACustomCall_node_ActionEnd, assetPath);
					variableCount += SACustomCall_node_ActionEnd.SetData((SACustomCall)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SATimedAction:
					SATimedActionNode SATimedAction_node_ActionEnd = graph.AddNode<SATimedActionNode>();
					GetPort("ActionEnd").Connect(SATimedAction_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SATimedAction_node_ActionEnd, assetPath);
					variableCount += SATimedAction_node_ActionEnd.SetData((SATimedAction)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAOrderSensitive:
					SAOrderSensitiveNode SAOrderSensitive_node_ActionEnd = graph.AddNode<SAOrderSensitiveNode>();
					GetPort("ActionEnd").Connect(SAOrderSensitive_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAOrderSensitive_node_ActionEnd, assetPath);
					variableCount += SAOrderSensitive_node_ActionEnd.SetData((SAOrderSensitive)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAProxyMove:
					SAProxyMoveNode SAProxyMove_node_ActionEnd = graph.AddNode<SAProxyMoveNode>();
					GetPort("ActionEnd").Connect(SAProxyMove_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAProxyMove_node_ActionEnd, assetPath);
					variableCount += SAProxyMove_node_ActionEnd.SetData((SAProxyMove)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SACheckThing:
					SACheckThingNode SACheckThing_node_ActionEnd = graph.AddNode<SACheckThingNode>();
					GetPort("ActionEnd").Connect(SACheckThing_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SACheckThing_node_ActionEnd, assetPath);
					variableCount += SACheckThing_node_ActionEnd.SetData((SACheckThing)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAActiveAction:
					SAActiveActionNode SAActiveAction_node_ActionEnd = graph.AddNode<SAActiveActionNode>();
					GetPort("ActionEnd").Connect(SAActiveAction_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAActiveAction_node_ActionEnd, assetPath);
					variableCount += SAActiveAction_node_ActionEnd.SetData((SAActiveAction)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SADeactivateAction:
					SADeactivateActionNode SADeactivateAction_node_ActionEnd = graph.AddNode<SADeactivateActionNode>();
					GetPort("ActionEnd").Connect(SADeactivateAction_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SADeactivateAction_node_ActionEnd, assetPath);
					variableCount += SADeactivateAction_node_ActionEnd.SetData((SADeactivateAction)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SASetFloatTarget:
					SASetFloatTargetNode SASetFloatTarget_node_ActionEnd = graph.AddNode<SASetFloatTargetNode>();
					GetPort("ActionEnd").Connect(SASetFloatTarget_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SASetFloatTarget_node_ActionEnd, assetPath);
					variableCount += SASetFloatTarget_node_ActionEnd.SetData((SASetFloatTarget)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAOnBounce:
					SAOnBounceNode SAOnBounce_node_ActionEnd = graph.AddNode<SAOnBounceNode>();
					GetPort("ActionEnd").Connect(SAOnBounce_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAOnBounce_node_ActionEnd, assetPath);
					variableCount += SAOnBounce_node_ActionEnd.SetData((SAOnBounce)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAOnLeaveEdge:
					SAOnLeaveEdgeNode SAOnLeaveEdge_node_ActionEnd = graph.AddNode<SAOnLeaveEdgeNode>();
					GetPort("ActionEnd").Connect(SAOnLeaveEdge_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAOnLeaveEdge_node_ActionEnd, assetPath);
					variableCount += SAOnLeaveEdge_node_ActionEnd.SetData((SAOnLeaveEdge)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAOnStoppedAtEdge:
					SAOnStoppedAtEdgeNode SAOnStoppedAtEdge_node_ActionEnd = graph.AddNode<SAOnStoppedAtEdgeNode>();
					GetPort("ActionEnd").Connect(SAOnStoppedAtEdge_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAOnStoppedAtEdge_node_ActionEnd, assetPath);
					variableCount += SAOnStoppedAtEdge_node_ActionEnd.SetData((SAOnStoppedAtEdge)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAOnLand:
					SAOnLandNode SAOnLand_node_ActionEnd = graph.AddNode<SAOnLandNode>();
					GetPort("ActionEnd").Connect(SAOnLand_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAOnLand_node_ActionEnd, assetPath);
					variableCount += SAOnLand_node_ActionEnd.SetData((SAOnLand)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAOnCancel:
					SAOnCancelNode SAOnCancel_node_ActionEnd = graph.AddNode<SAOnCancelNode>();
					GetPort("ActionEnd").Connect(SAOnCancel_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAOnCancel_node_ActionEnd, assetPath);
					variableCount += SAOnCancel_node_ActionEnd.SetData((SAOnCancel)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SARefreshAttack:
					SARefreshAttackNode SARefreshAttack_node_ActionEnd = graph.AddNode<SARefreshAttackNode>();
					GetPort("ActionEnd").Connect(SARefreshAttack_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SARefreshAttack_node_ActionEnd, assetPath);
					variableCount += SARefreshAttack_node_ActionEnd.SetData((SARefreshAttack)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAEndAttack:
					SAEndAttackNode SAEndAttack_node_ActionEnd = graph.AddNode<SAEndAttackNode>();
					GetPort("ActionEnd").Connect(SAEndAttack_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAEndAttack_node_ActionEnd, assetPath);
					variableCount += SAEndAttack_node_ActionEnd.SetData((SAEndAttack)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SASetHitboxCount:
					SASetHitboxCountNode SASetHitboxCount_node_ActionEnd = graph.AddNode<SASetHitboxCountNode>();
					GetPort("ActionEnd").Connect(SASetHitboxCount_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SASetHitboxCount_node_ActionEnd, assetPath);
					variableCount += SASetHitboxCount_node_ActionEnd.SetData((SASetHitboxCount)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAConfigHitbox:
					SAConfigHitboxNode SAConfigHitbox_node_ActionEnd = graph.AddNode<SAConfigHitboxNode>();
					GetPort("ActionEnd").Connect(SAConfigHitbox_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAConfigHitbox_node_ActionEnd, assetPath);
					variableCount += SAConfigHitbox_node_ActionEnd.SetData((SAConfigHitbox)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SASetAtkProp:
					SASetAtkPropNode SASetAtkProp_node_ActionEnd = graph.AddNode<SASetAtkPropNode>();
					GetPort("ActionEnd").Connect(SASetAtkProp_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SASetAtkProp_node_ActionEnd, assetPath);
					variableCount += SASetAtkProp_node_ActionEnd.SetData((SASetAtkProp)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAManipHitBox:
					SAManipHitBoxNode SAManipHitBox_node_ActionEnd = graph.AddNode<SAManipHitBoxNode>();
					GetPort("ActionEnd").Connect(SAManipHitBox_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAManipHitBox_node_ActionEnd, assetPath);
					variableCount += SAManipHitBox_node_ActionEnd.SetData((SAManipHitBox)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAUpdateHurtboxes:
					SAUpdateHurtboxesNode SAUpdateHurtboxes_node_ActionEnd = graph.AddNode<SAUpdateHurtboxesNode>();
					GetPort("ActionEnd").Connect(SAUpdateHurtboxes_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAUpdateHurtboxes_node_ActionEnd, assetPath);
					variableCount += SAUpdateHurtboxes_node_ActionEnd.SetData((SAUpdateHurtboxes)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SASetupHurtboxes:
					SASetupHurtboxesNode SASetupHurtboxes_node_ActionEnd = graph.AddNode<SASetupHurtboxesNode>();
					GetPort("ActionEnd").Connect(SASetupHurtboxes_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SASetupHurtboxes_node_ActionEnd, assetPath);
					variableCount += SASetupHurtboxes_node_ActionEnd.SetData((SASetupHurtboxes)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAManipHurtBox:
					SAManipHurtBoxNode SAManipHurtBox_node_ActionEnd = graph.AddNode<SAManipHurtBoxNode>();
					GetPort("ActionEnd").Connect(SAManipHurtBox_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAManipHurtBox_node_ActionEnd, assetPath);
					variableCount += SAManipHurtBox_node_ActionEnd.SetData((SAManipHurtBox)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SABoneState:
					SABoneStateNode SABoneState_node_ActionEnd = graph.AddNode<SABoneStateNode>();
					GetPort("ActionEnd").Connect(SABoneState_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SABoneState_node_ActionEnd, assetPath);
					variableCount += SABoneState_node_ActionEnd.SetData((SABoneState)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SABoneScale:
					SABoneScaleNode SABoneScale_node_ActionEnd = graph.AddNode<SABoneScaleNode>();
					GetPort("ActionEnd").Connect(SABoneScale_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SABoneScale_node_ActionEnd, assetPath);
					variableCount += SABoneScale_node_ActionEnd.SetData((SABoneScale)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SASpawnAgent:
					SASpawnAgentNode SASpawnAgent_node_ActionEnd = graph.AddNode<SASpawnAgentNode>();
					GetPort("ActionEnd").Connect(SASpawnAgent_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SASpawnAgent_node_ActionEnd, assetPath);
					variableCount += SASpawnAgent_node_ActionEnd.SetData((SASpawnAgent)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SALocalFX:
					SALocalFXNode SALocalFX_node_ActionEnd = graph.AddNode<SALocalFXNode>();
					GetPort("ActionEnd").Connect(SALocalFX_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SALocalFX_node_ActionEnd, assetPath);
					variableCount += SALocalFX_node_ActionEnd.SetData((SALocalFX)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SASpawnFX:
					SASpawnFXNode SASpawnFX_node_ActionEnd = graph.AddNode<SASpawnFXNode>();
					GetPort("ActionEnd").Connect(SASpawnFX_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SASpawnFX_node_ActionEnd, assetPath);
					variableCount += SASpawnFX_node_ActionEnd.SetData((SASpawnFX)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SASetHitboxFX:
					SASetHitboxFXNode SASetHitboxFX_node_ActionEnd = graph.AddNode<SASetHitboxFXNode>();
					GetPort("ActionEnd").Connect(SASetHitboxFX_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SASetHitboxFX_node_ActionEnd, assetPath);
					variableCount += SASetHitboxFX_node_ActionEnd.SetData((SASetHitboxFX)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAPlaySFX:
					SAPlaySFXNode SAPlaySFX_node_ActionEnd = graph.AddNode<SAPlaySFXNode>();
					GetPort("ActionEnd").Connect(SAPlaySFX_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAPlaySFX_node_ActionEnd, assetPath);
					variableCount += SAPlaySFX_node_ActionEnd.SetData((SAPlaySFX)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SASetHitboxSFX:
					SASetHitboxSFXNode SASetHitboxSFX_node_ActionEnd = graph.AddNode<SASetHitboxSFXNode>();
					GetPort("ActionEnd").Connect(SASetHitboxSFX_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SASetHitboxSFX_node_ActionEnd, assetPath);
					variableCount += SASetHitboxSFX_node_ActionEnd.SetData((SASetHitboxSFX)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAColorTint:
					SAColorTintNode SAColorTint_node_ActionEnd = graph.AddNode<SAColorTintNode>();
					GetPort("ActionEnd").Connect(SAColorTint_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAColorTint_node_ActionEnd, assetPath);
					variableCount += SAColorTint_node_ActionEnd.SetData((SAColorTint)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAFindFloor:
					SAFindFloorNode SAFindFloor_node_ActionEnd = graph.AddNode<SAFindFloorNode>();
					GetPort("ActionEnd").Connect(SAFindFloor_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAFindFloor_node_ActionEnd, assetPath);
					variableCount += SAFindFloor_node_ActionEnd.SetData((SAFindFloor)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAHurtGrabbed:
					SAHurtGrabbedNode SAHurtGrabbed_node_ActionEnd = graph.AddNode<SAHurtGrabbedNode>();
					GetPort("ActionEnd").Connect(SAHurtGrabbed_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAHurtGrabbed_node_ActionEnd, assetPath);
					variableCount += SAHurtGrabbed_node_ActionEnd.SetData((SAHurtGrabbed)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SALaunchGrabbed:
					SALaunchGrabbedNode SALaunchGrabbed_node_ActionEnd = graph.AddNode<SALaunchGrabbedNode>();
					GetPort("ActionEnd").Connect(SALaunchGrabbed_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SALaunchGrabbed_node_ActionEnd, assetPath);
					variableCount += SALaunchGrabbed_node_ActionEnd.SetData((SALaunchGrabbed)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAStateCancelGrabbed:
					SAStateCancelGrabbedNode SAStateCancelGrabbed_node_ActionEnd = graph.AddNode<SAStateCancelGrabbedNode>();
					GetPort("ActionEnd").Connect(SAStateCancelGrabbed_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAStateCancelGrabbed_node_ActionEnd, assetPath);
					variableCount += SAStateCancelGrabbed_node_ActionEnd.SetData((SAStateCancelGrabbed)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAEndGrab:
					SAEndGrabNode SAEndGrab_node_ActionEnd = graph.AddNode<SAEndGrabNode>();
					GetPort("ActionEnd").Connect(SAEndGrab_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAEndGrab_node_ActionEnd, assetPath);
					variableCount += SAEndGrab_node_ActionEnd.SetData((SAEndGrab)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAGrabNotifyEscape:
					SAGrabNotifyEscapeNode SAGrabNotifyEscape_node_ActionEnd = graph.AddNode<SAGrabNotifyEscapeNode>();
					GetPort("ActionEnd").Connect(SAGrabNotifyEscape_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAGrabNotifyEscape_node_ActionEnd, assetPath);
					variableCount += SAGrabNotifyEscape_node_ActionEnd.SetData((SAGrabNotifyEscape)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAIgnoreGrabbed:
					SAIgnoreGrabbedNode SAIgnoreGrabbed_node_ActionEnd = graph.AddNode<SAIgnoreGrabbedNode>();
					GetPort("ActionEnd").Connect(SAIgnoreGrabbed_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAIgnoreGrabbed_node_ActionEnd, assetPath);
					variableCount += SAIgnoreGrabbed_node_ActionEnd.SetData((SAIgnoreGrabbed)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAEventKO:
					SAEventKONode SAEventKO_node_ActionEnd = graph.AddNode<SAEventKONode>();
					GetPort("ActionEnd").Connect(SAEventKO_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAEventKO_node_ActionEnd, assetPath);
					variableCount += SAEventKO_node_ActionEnd.SetData((SAEventKO)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAEventKOGrabbed:
					SAEventKOGrabbedNode SAEventKOGrabbed_node_ActionEnd = graph.AddNode<SAEventKOGrabbedNode>();
					GetPort("ActionEnd").Connect(SAEventKOGrabbed_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAEventKOGrabbed_node_ActionEnd, assetPath);
					variableCount += SAEventKOGrabbed_node_ActionEnd.SetData((SAEventKOGrabbed)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SACameraShake:
					SACameraShakeNode SACameraShake_node_ActionEnd = graph.AddNode<SACameraShakeNode>();
					GetPort("ActionEnd").Connect(SACameraShake_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SACameraShake_node_ActionEnd, assetPath);
					variableCount += SACameraShake_node_ActionEnd.SetData((SACameraShake)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAResetOnHits:
					SAResetOnHitsNode SAResetOnHits_node_ActionEnd = graph.AddNode<SAResetOnHitsNode>();
					GetPort("ActionEnd").Connect(SAResetOnHits_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAResetOnHits_node_ActionEnd, assetPath);
					variableCount += SAResetOnHits_node_ActionEnd.SetData((SAResetOnHits)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAOnHit:
					SAOnHitNode SAOnHit_node_ActionEnd = graph.AddNode<SAOnHitNode>();
					GetPort("ActionEnd").Connect(SAOnHit_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAOnHit_node_ActionEnd, assetPath);
					variableCount += SAOnHit_node_ActionEnd.SetData((SAOnHit)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAFastForwardState:
					SAFastForwardStateNode SAFastForwardState_node_ActionEnd = graph.AddNode<SAFastForwardStateNode>();
					GetPort("ActionEnd").Connect(SAFastForwardState_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAFastForwardState_node_ActionEnd, assetPath);
					variableCount += SAFastForwardState_node_ActionEnd.SetData((SAFastForwardState)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SATimingTweak:
					SATimingTweakNode SATimingTweak_node_ActionEnd = graph.AddNode<SATimingTweakNode>();
					GetPort("ActionEnd").Connect(SATimingTweak_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SATimingTweak_node_ActionEnd, assetPath);
					variableCount += SATimingTweak_node_ActionEnd.SetData((SATimingTweak)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAMapAnimation:
					SAMapAnimationNode SAMapAnimation_node_ActionEnd = graph.AddNode<SAMapAnimationNode>();
					GetPort("ActionEnd").Connect(SAMapAnimation_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAMapAnimation_node_ActionEnd, assetPath);
					variableCount += SAMapAnimation_node_ActionEnd.SetData((SAMapAnimation)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAAlterMoveDT:
					SAAlterMoveDTNode SAAlterMoveDT_node_ActionEnd = graph.AddNode<SAAlterMoveDTNode>();
					GetPort("ActionEnd").Connect(SAAlterMoveDT_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAAlterMoveDT_node_ActionEnd, assetPath);
					variableCount += SAAlterMoveDT_node_ActionEnd.SetData((SAAlterMoveDT)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAAlterMoveVel:
					SAAlterMoveVelNode SAAlterMoveVel_node_ActionEnd = graph.AddNode<SAAlterMoveVelNode>();
					GetPort("ActionEnd").Connect(SAAlterMoveVel_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAAlterMoveVel_node_ActionEnd, assetPath);
					variableCount += SAAlterMoveVel_node_ActionEnd.SetData((SAAlterMoveVel)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SASetStagePart:
					SASetStagePartNode SASetStagePart_node_ActionEnd = graph.AddNode<SASetStagePartNode>();
					GetPort("ActionEnd").Connect(SASetStagePart_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SASetStagePart_node_ActionEnd, assetPath);
					variableCount += SASetStagePart_node_ActionEnd.SetData((SASetStagePart)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SASetStagePartsDefault:
					SASetStagePartsDefaultNode SASetStagePartsDefault_node_ActionEnd = graph.AddNode<SASetStagePartsDefaultNode>();
					GetPort("ActionEnd").Connect(SASetStagePartsDefault_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SASetStagePartsDefault_node_ActionEnd, assetPath);
					variableCount += SASetStagePartsDefault_node_ActionEnd.SetData((SASetStagePartsDefault)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAJump:
					SAJumpNode SAJump_node_ActionEnd = graph.AddNode<SAJumpNode>();
					GetPort("ActionEnd").Connect(SAJump_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAJump_node_ActionEnd, assetPath);
					variableCount += SAJump_node_ActionEnd.SetData((SAJump)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAStopJump:
					SAStopJumpNode SAStopJump_node_ActionEnd = graph.AddNode<SAStopJumpNode>();
					GetPort("ActionEnd").Connect(SAStopJump_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAStopJump_node_ActionEnd, assetPath);
					variableCount += SAStopJump_node_ActionEnd.SetData((SAStopJump)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAManageAirJump:
					SAManageAirJumpNode SAManageAirJump_node_ActionEnd = graph.AddNode<SAManageAirJumpNode>();
					GetPort("ActionEnd").Connect(SAManageAirJump_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAManageAirJump_node_ActionEnd, assetPath);
					variableCount += SAManageAirJump_node_ActionEnd.SetData((SAManageAirJump)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SALeaveGround:
					SALeaveGroundNode SALeaveGround_node_ActionEnd = graph.AddNode<SALeaveGroundNode>();
					GetPort("ActionEnd").Connect(SALeaveGround_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SALeaveGround_node_ActionEnd, assetPath);
					variableCount += SALeaveGround_node_ActionEnd.SetData((SALeaveGround)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAUnHogEdge:
					SAUnHogEdgeNode SAUnHogEdge_node_ActionEnd = graph.AddNode<SAUnHogEdgeNode>();
					GetPort("ActionEnd").Connect(SAUnHogEdge_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAUnHogEdge_node_ActionEnd, assetPath);
					variableCount += SAUnHogEdge_node_ActionEnd.SetData((SAUnHogEdge)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAPlaySFXTimeline:
					SAPlaySFXTimelineNode SAPlaySFXTimeline_node_ActionEnd = graph.AddNode<SAPlaySFXTimelineNode>();
					GetPort("ActionEnd").Connect(SAPlaySFXTimeline_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAPlaySFXTimeline_node_ActionEnd, assetPath);
					variableCount += SAPlaySFXTimeline_node_ActionEnd.SetData((SAPlaySFXTimeline)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAFindLastHorizontalInput:
					SAFindLastHorizontalInputNode SAFindLastHorizontalInput_node_ActionEnd = graph.AddNode<SAFindLastHorizontalInputNode>();
					GetPort("ActionEnd").Connect(SAFindLastHorizontalInput_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAFindLastHorizontalInput_node_ActionEnd, assetPath);
					variableCount += SAFindLastHorizontalInput_node_ActionEnd.SetData((SAFindLastHorizontalInput)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SASetCommandGrab:
					SASetCommandGrabNode SASetCommandGrab_node_ActionEnd = graph.AddNode<SASetCommandGrabNode>();
					GetPort("ActionEnd").Connect(SASetCommandGrab_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SASetCommandGrab_node_ActionEnd, assetPath);
					variableCount += SASetCommandGrab_node_ActionEnd.SetData((SASetCommandGrab)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SACameraPunch:
					SACameraPunchNode SACameraPunch_node_ActionEnd = graph.AddNode<SACameraPunchNode>();
					GetPort("ActionEnd").Connect(SACameraPunch_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SACameraPunch_node_ActionEnd, assetPath);
					variableCount += SACameraPunch_node_ActionEnd.SetData((SACameraPunch)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SASpawnAgent2:
					SASpawnAgent2Node SASpawnAgent2_node_ActionEnd = graph.AddNode<SASpawnAgent2Node>();
					GetPort("ActionEnd").Connect(SASpawnAgent2_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SASpawnAgent2_node_ActionEnd, assetPath);
					variableCount += SASpawnAgent2_node_ActionEnd.SetData((SASpawnAgent2)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAManipDecorChain:
					SAManipDecorChainNode SAManipDecorChain_node_ActionEnd = graph.AddNode<SAManipDecorChainNode>();
					GetPort("ActionEnd").Connect(SAManipDecorChain_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAManipDecorChain_node_ActionEnd, assetPath);
					variableCount += SAManipDecorChain_node_ActionEnd.SetData((SAManipDecorChain)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAUpdateHitboxes:
					SAUpdateHitboxesNode SAUpdateHitboxes_node_ActionEnd = graph.AddNode<SAUpdateHitboxesNode>();
					GetPort("ActionEnd").Connect(SAUpdateHitboxes_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAUpdateHitboxes_node_ActionEnd, assetPath);
					variableCount += SAUpdateHitboxes_node_ActionEnd.SetData((SAUpdateHitboxes)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SASampleAnim:
					SASampleAnimNode SASampleAnim_node_ActionEnd = graph.AddNode<SASampleAnimNode>();
					GetPort("ActionEnd").Connect(SASampleAnim_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SASampleAnim_node_ActionEnd, assetPath);
					variableCount += SASampleAnim_node_ActionEnd.SetData((SASampleAnim)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAForceExtraInputCheck:
					SAForceExtraInputCheckNode SAForceExtraInputCheck_node_ActionEnd = graph.AddNode<SAForceExtraInputCheckNode>();
					GetPort("ActionEnd").Connect(SAForceExtraInputCheck_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAForceExtraInputCheck_node_ActionEnd, assetPath);
					variableCount += SAForceExtraInputCheck_node_ActionEnd.SetData((SAForceExtraInputCheck)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SALaunchGrabbedCustom:
					SALaunchGrabbedCustomNode SALaunchGrabbedCustom_node_ActionEnd = graph.AddNode<SALaunchGrabbedCustomNode>();
					GetPort("ActionEnd").Connect(SALaunchGrabbedCustom_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SALaunchGrabbedCustom_node_ActionEnd, assetPath);
					variableCount += SALaunchGrabbedCustom_node_ActionEnd.SetData((SALaunchGrabbedCustom)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAMapAnimationSimple:
					SAMapAnimationSimpleNode SAMapAnimationSimple_node_ActionEnd = graph.AddNode<SAMapAnimationSimpleNode>();
					GetPort("ActionEnd").Connect(SAMapAnimationSimple_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAMapAnimationSimple_node_ActionEnd, assetPath);
					variableCount += SAMapAnimationSimple_node_ActionEnd.SetData((SAMapAnimationSimple)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAPersistLocalFX:
					SAPersistLocalFXNode SAPersistLocalFX_node_ActionEnd = graph.AddNode<SAPersistLocalFXNode>();
					GetPort("ActionEnd").Connect(SAPersistLocalFX_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAPersistLocalFX_node_ActionEnd, assetPath);
					variableCount += SAPersistLocalFX_node_ActionEnd.SetData((SAPersistLocalFX)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAOnLeaveParent:
					SAOnLeaveParentNode SAOnLeaveParent_node_ActionEnd = graph.AddNode<SAOnLeaveParentNode>();
					GetPort("ActionEnd").Connect(SAOnLeaveParent_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAOnLeaveParent_node_ActionEnd, assetPath);
					variableCount += SAOnLeaveParent_node_ActionEnd.SetData((SAOnLeaveParent)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAPlayVoiceLine:
					SAPlayVoiceLineNode SAPlayVoiceLine_node_ActionEnd = graph.AddNode<SAPlayVoiceLineNode>();
					GetPort("ActionEnd").Connect(SAPlayVoiceLine_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAPlayVoiceLine_node_ActionEnd, assetPath);
					variableCount += SAPlayVoiceLine_node_ActionEnd.SetData((SAPlayVoiceLine)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAPlayCategoryVoiceLine:
					SAPlayCategoryVoiceLineNode SAPlayCategoryVoiceLine_node_ActionEnd = graph.AddNode<SAPlayCategoryVoiceLineNode>();
					GetPort("ActionEnd").Connect(SAPlayCategoryVoiceLine_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAPlayCategoryVoiceLine_node_ActionEnd, assetPath);
					variableCount += SAPlayCategoryVoiceLine_node_ActionEnd.SetData((SAPlayCategoryVoiceLine)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SAStopVoiceLines:
					SAStopVoiceLinesNode SAStopVoiceLines_node_ActionEnd = graph.AddNode<SAStopVoiceLinesNode>();
					GetPort("ActionEnd").Connect(SAStopVoiceLines_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SAStopVoiceLines_node_ActionEnd, assetPath);
					variableCount += SAStopVoiceLines_node_ActionEnd.SetData((SAStopVoiceLines)ActionEnd, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
			}
			
			return variableCount;
		}
		
		public new SATimingTweak GetData()
		{
			SATimingTweak objToReturn = new SATimingTweak();
			objToReturn.TID = TypeId.SATimingTweak;
			objToReturn.AnimId = AnimId;
			objToReturn.RootAnimId = RootAnimId;
			if (GetPort("AnimConfig").ConnectionCount > 0)
			{
				AnimConfigNode AnimConfig_Node = (AnimConfigNode)GetPort("AnimConfig").GetConnection(0).node;
				objToReturn.AnimConfig = AnimConfig_Node.GetData();
			}
			if (GetPort("AnimFrames").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("AnimFrames").GetConnection(0).node;
				objToReturn.AnimFrames = FloatSourceContainer_Node.GetData();
			}
			if (GetPort("StateFrames").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("StateFrames").GetConnection(0).node;
				objToReturn.StateFrames = FloatSourceContainer_Node.GetData();
			}
			if (GetPort("FramesToA").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("FramesToA").GetConnection(0).node;
				objToReturn.FramesToA = FloatSourceContainer_Node.GetData();
			}
			if (GetPort("FramesToBe").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("FramesToBe").GetConnection(0).node;
				objToReturn.FramesToBe = FloatSourceContainer_Node.GetData();
			}
			if (GetPort("ActionA").ConnectionCount > 0)
			{
				StateActionNode StateAction_Node = (StateActionNode)GetPort("ActionA").GetConnection(0).node;
				switch (StateAction_Node.TID)
				{
					case StateAction.TypeId.StateAction:
						StateActionNode StateAction_StateAction_Node = (StateActionNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = StateAction_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SADebugMessage:
						SADebugMessageNode SADebugMessage_StateAction_Node = (SADebugMessageNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SADebugMessage_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAPlayAnim:
						SAPlayAnimNode SAPlayAnim_StateAction_Node = (SAPlayAnimNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SAPlayAnim_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAPlayRootAnim:
						SAPlayRootAnimNode SAPlayRootAnim_StateAction_Node = (SAPlayRootAnimNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SAPlayRootAnim_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASnapAnimWeights:
						SASnapAnimWeightsNode SASnapAnimWeights_StateAction_Node = (SASnapAnimWeightsNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SASnapAnimWeights_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAStandardInput:
						SAStandardInputNode SAStandardInput_StateAction_Node = (SAStandardInputNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SAStandardInput_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAInputAction:
						SAInputActionNode SAInputAction_StateAction_Node = (SAInputActionNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SAInputAction_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SADeactivateInputAction:
						SADeactivateInputActionNode SADeactivateInputAction_StateAction_Node = (SADeactivateInputActionNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SADeactivateInputAction_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAAddInputEventFromFrame:
						SAAddInputEventFromFrameNode SAAddInputEventFromFrame_StateAction_Node = (SAAddInputEventFromFrameNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SAAddInputEventFromFrame_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SACancelToState:
						SACancelToStateNode SACancelToState_StateAction_Node = (SACancelToStateNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SACancelToState_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SACustomCall:
						SACustomCallNode SACustomCall_StateAction_Node = (SACustomCallNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SACustomCall_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SATimedAction:
						SATimedActionNode SATimedAction_StateAction_Node = (SATimedActionNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SATimedAction_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAOrderSensitive:
						SAOrderSensitiveNode SAOrderSensitive_StateAction_Node = (SAOrderSensitiveNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SAOrderSensitive_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAProxyMove:
						SAProxyMoveNode SAProxyMove_StateAction_Node = (SAProxyMoveNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SAProxyMove_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SACheckThing:
						SACheckThingNode SACheckThing_StateAction_Node = (SACheckThingNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SACheckThing_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAActiveAction:
						SAActiveActionNode SAActiveAction_StateAction_Node = (SAActiveActionNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SAActiveAction_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SADeactivateAction:
						SADeactivateActionNode SADeactivateAction_StateAction_Node = (SADeactivateActionNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SADeactivateAction_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASetFloatTarget:
						SASetFloatTargetNode SASetFloatTarget_StateAction_Node = (SASetFloatTargetNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SASetFloatTarget_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAOnBounce:
						SAOnBounceNode SAOnBounce_StateAction_Node = (SAOnBounceNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SAOnBounce_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAOnLeaveEdge:
						SAOnLeaveEdgeNode SAOnLeaveEdge_StateAction_Node = (SAOnLeaveEdgeNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SAOnLeaveEdge_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAOnStoppedAtEdge:
						SAOnStoppedAtEdgeNode SAOnStoppedAtEdge_StateAction_Node = (SAOnStoppedAtEdgeNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SAOnStoppedAtEdge_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAOnLand:
						SAOnLandNode SAOnLand_StateAction_Node = (SAOnLandNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SAOnLand_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAOnCancel:
						SAOnCancelNode SAOnCancel_StateAction_Node = (SAOnCancelNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SAOnCancel_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SARefreshAttack:
						SARefreshAttackNode SARefreshAttack_StateAction_Node = (SARefreshAttackNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SARefreshAttack_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAEndAttack:
						SAEndAttackNode SAEndAttack_StateAction_Node = (SAEndAttackNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SAEndAttack_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASetHitboxCount:
						SASetHitboxCountNode SASetHitboxCount_StateAction_Node = (SASetHitboxCountNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SASetHitboxCount_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAConfigHitbox:
						SAConfigHitboxNode SAConfigHitbox_StateAction_Node = (SAConfigHitboxNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SAConfigHitbox_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASetAtkProp:
						SASetAtkPropNode SASetAtkProp_StateAction_Node = (SASetAtkPropNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SASetAtkProp_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAManipHitBox:
						SAManipHitBoxNode SAManipHitBox_StateAction_Node = (SAManipHitBoxNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SAManipHitBox_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAUpdateHurtboxes:
						SAUpdateHurtboxesNode SAUpdateHurtboxes_StateAction_Node = (SAUpdateHurtboxesNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SAUpdateHurtboxes_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASetupHurtboxes:
						SASetupHurtboxesNode SASetupHurtboxes_StateAction_Node = (SASetupHurtboxesNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SASetupHurtboxes_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAManipHurtBox:
						SAManipHurtBoxNode SAManipHurtBox_StateAction_Node = (SAManipHurtBoxNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SAManipHurtBox_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SABoneState:
						SABoneStateNode SABoneState_StateAction_Node = (SABoneStateNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SABoneState_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SABoneScale:
						SABoneScaleNode SABoneScale_StateAction_Node = (SABoneScaleNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SABoneScale_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASpawnAgent:
						SASpawnAgentNode SASpawnAgent_StateAction_Node = (SASpawnAgentNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SASpawnAgent_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SALocalFX:
						SALocalFXNode SALocalFX_StateAction_Node = (SALocalFXNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SALocalFX_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASpawnFX:
						SASpawnFXNode SASpawnFX_StateAction_Node = (SASpawnFXNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SASpawnFX_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASetHitboxFX:
						SASetHitboxFXNode SASetHitboxFX_StateAction_Node = (SASetHitboxFXNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SASetHitboxFX_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAPlaySFX:
						SAPlaySFXNode SAPlaySFX_StateAction_Node = (SAPlaySFXNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SAPlaySFX_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASetHitboxSFX:
						SASetHitboxSFXNode SASetHitboxSFX_StateAction_Node = (SASetHitboxSFXNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SASetHitboxSFX_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAColorTint:
						SAColorTintNode SAColorTint_StateAction_Node = (SAColorTintNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SAColorTint_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAFindFloor:
						SAFindFloorNode SAFindFloor_StateAction_Node = (SAFindFloorNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SAFindFloor_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAHurtGrabbed:
						SAHurtGrabbedNode SAHurtGrabbed_StateAction_Node = (SAHurtGrabbedNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SAHurtGrabbed_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SALaunchGrabbed:
						SALaunchGrabbedNode SALaunchGrabbed_StateAction_Node = (SALaunchGrabbedNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SALaunchGrabbed_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAStateCancelGrabbed:
						SAStateCancelGrabbedNode SAStateCancelGrabbed_StateAction_Node = (SAStateCancelGrabbedNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SAStateCancelGrabbed_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAEndGrab:
						SAEndGrabNode SAEndGrab_StateAction_Node = (SAEndGrabNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SAEndGrab_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAGrabNotifyEscape:
						SAGrabNotifyEscapeNode SAGrabNotifyEscape_StateAction_Node = (SAGrabNotifyEscapeNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SAGrabNotifyEscape_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAIgnoreGrabbed:
						SAIgnoreGrabbedNode SAIgnoreGrabbed_StateAction_Node = (SAIgnoreGrabbedNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SAIgnoreGrabbed_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAEventKO:
						SAEventKONode SAEventKO_StateAction_Node = (SAEventKONode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SAEventKO_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAEventKOGrabbed:
						SAEventKOGrabbedNode SAEventKOGrabbed_StateAction_Node = (SAEventKOGrabbedNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SAEventKOGrabbed_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SACameraShake:
						SACameraShakeNode SACameraShake_StateAction_Node = (SACameraShakeNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SACameraShake_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAResetOnHits:
						SAResetOnHitsNode SAResetOnHits_StateAction_Node = (SAResetOnHitsNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SAResetOnHits_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAOnHit:
						SAOnHitNode SAOnHit_StateAction_Node = (SAOnHitNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SAOnHit_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAFastForwardState:
						SAFastForwardStateNode SAFastForwardState_StateAction_Node = (SAFastForwardStateNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SAFastForwardState_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SATimingTweak:
						SATimingTweakNode SATimingTweak_StateAction_Node = (SATimingTweakNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SATimingTweak_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAMapAnimation:
						SAMapAnimationNode SAMapAnimation_StateAction_Node = (SAMapAnimationNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SAMapAnimation_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAAlterMoveDT:
						SAAlterMoveDTNode SAAlterMoveDT_StateAction_Node = (SAAlterMoveDTNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SAAlterMoveDT_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAAlterMoveVel:
						SAAlterMoveVelNode SAAlterMoveVel_StateAction_Node = (SAAlterMoveVelNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SAAlterMoveVel_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASetStagePart:
						SASetStagePartNode SASetStagePart_StateAction_Node = (SASetStagePartNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SASetStagePart_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASetStagePartsDefault:
						SASetStagePartsDefaultNode SASetStagePartsDefault_StateAction_Node = (SASetStagePartsDefaultNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SASetStagePartsDefault_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAJump:
						SAJumpNode SAJump_StateAction_Node = (SAJumpNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SAJump_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAStopJump:
						SAStopJumpNode SAStopJump_StateAction_Node = (SAStopJumpNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SAStopJump_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAManageAirJump:
						SAManageAirJumpNode SAManageAirJump_StateAction_Node = (SAManageAirJumpNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SAManageAirJump_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SALeaveGround:
						SALeaveGroundNode SALeaveGround_StateAction_Node = (SALeaveGroundNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SALeaveGround_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAUnHogEdge:
						SAUnHogEdgeNode SAUnHogEdge_StateAction_Node = (SAUnHogEdgeNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SAUnHogEdge_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAPlaySFXTimeline:
						SAPlaySFXTimelineNode SAPlaySFXTimeline_StateAction_Node = (SAPlaySFXTimelineNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SAPlaySFXTimeline_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAFindLastHorizontalInput:
						SAFindLastHorizontalInputNode SAFindLastHorizontalInput_StateAction_Node = (SAFindLastHorizontalInputNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SAFindLastHorizontalInput_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASetCommandGrab:
						SASetCommandGrabNode SASetCommandGrab_StateAction_Node = (SASetCommandGrabNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SASetCommandGrab_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SACameraPunch:
						SACameraPunchNode SACameraPunch_StateAction_Node = (SACameraPunchNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SACameraPunch_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASpawnAgent2:
						SASpawnAgent2Node SASpawnAgent2_StateAction_Node = (SASpawnAgent2Node)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SASpawnAgent2_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAManipDecorChain:
						SAManipDecorChainNode SAManipDecorChain_StateAction_Node = (SAManipDecorChainNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SAManipDecorChain_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAUpdateHitboxes:
						SAUpdateHitboxesNode SAUpdateHitboxes_StateAction_Node = (SAUpdateHitboxesNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SAUpdateHitboxes_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASampleAnim:
						SASampleAnimNode SASampleAnim_StateAction_Node = (SASampleAnimNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SASampleAnim_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAForceExtraInputCheck:
						SAForceExtraInputCheckNode SAForceExtraInputCheck_StateAction_Node = (SAForceExtraInputCheckNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SAForceExtraInputCheck_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SALaunchGrabbedCustom:
						SALaunchGrabbedCustomNode SALaunchGrabbedCustom_StateAction_Node = (SALaunchGrabbedCustomNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SALaunchGrabbedCustom_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAMapAnimationSimple:
						SAMapAnimationSimpleNode SAMapAnimationSimple_StateAction_Node = (SAMapAnimationSimpleNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SAMapAnimationSimple_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAPersistLocalFX:
						SAPersistLocalFXNode SAPersistLocalFX_StateAction_Node = (SAPersistLocalFXNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SAPersistLocalFX_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAOnLeaveParent:
						SAOnLeaveParentNode SAOnLeaveParent_StateAction_Node = (SAOnLeaveParentNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SAOnLeaveParent_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAPlayVoiceLine:
						SAPlayVoiceLineNode SAPlayVoiceLine_StateAction_Node = (SAPlayVoiceLineNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SAPlayVoiceLine_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAPlayCategoryVoiceLine:
						SAPlayCategoryVoiceLineNode SAPlayCategoryVoiceLine_StateAction_Node = (SAPlayCategoryVoiceLineNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SAPlayCategoryVoiceLine_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAStopVoiceLines:
						SAStopVoiceLinesNode SAStopVoiceLines_StateAction_Node = (SAStopVoiceLinesNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SAStopVoiceLines_StateAction_Node.GetData();
					break;
				}
			}
			if (GetPort("ActionB").ConnectionCount > 0)
			{
				StateActionNode StateAction_Node = (StateActionNode)GetPort("ActionB").GetConnection(0).node;
				switch (StateAction_Node.TID)
				{
					case StateAction.TypeId.StateAction:
						StateActionNode StateAction_StateAction_Node = (StateActionNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = StateAction_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SADebugMessage:
						SADebugMessageNode SADebugMessage_StateAction_Node = (SADebugMessageNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SADebugMessage_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAPlayAnim:
						SAPlayAnimNode SAPlayAnim_StateAction_Node = (SAPlayAnimNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SAPlayAnim_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAPlayRootAnim:
						SAPlayRootAnimNode SAPlayRootAnim_StateAction_Node = (SAPlayRootAnimNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SAPlayRootAnim_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASnapAnimWeights:
						SASnapAnimWeightsNode SASnapAnimWeights_StateAction_Node = (SASnapAnimWeightsNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SASnapAnimWeights_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAStandardInput:
						SAStandardInputNode SAStandardInput_StateAction_Node = (SAStandardInputNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SAStandardInput_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAInputAction:
						SAInputActionNode SAInputAction_StateAction_Node = (SAInputActionNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SAInputAction_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SADeactivateInputAction:
						SADeactivateInputActionNode SADeactivateInputAction_StateAction_Node = (SADeactivateInputActionNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SADeactivateInputAction_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAAddInputEventFromFrame:
						SAAddInputEventFromFrameNode SAAddInputEventFromFrame_StateAction_Node = (SAAddInputEventFromFrameNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SAAddInputEventFromFrame_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SACancelToState:
						SACancelToStateNode SACancelToState_StateAction_Node = (SACancelToStateNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SACancelToState_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SACustomCall:
						SACustomCallNode SACustomCall_StateAction_Node = (SACustomCallNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SACustomCall_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SATimedAction:
						SATimedActionNode SATimedAction_StateAction_Node = (SATimedActionNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SATimedAction_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAOrderSensitive:
						SAOrderSensitiveNode SAOrderSensitive_StateAction_Node = (SAOrderSensitiveNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SAOrderSensitive_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAProxyMove:
						SAProxyMoveNode SAProxyMove_StateAction_Node = (SAProxyMoveNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SAProxyMove_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SACheckThing:
						SACheckThingNode SACheckThing_StateAction_Node = (SACheckThingNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SACheckThing_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAActiveAction:
						SAActiveActionNode SAActiveAction_StateAction_Node = (SAActiveActionNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SAActiveAction_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SADeactivateAction:
						SADeactivateActionNode SADeactivateAction_StateAction_Node = (SADeactivateActionNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SADeactivateAction_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASetFloatTarget:
						SASetFloatTargetNode SASetFloatTarget_StateAction_Node = (SASetFloatTargetNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SASetFloatTarget_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAOnBounce:
						SAOnBounceNode SAOnBounce_StateAction_Node = (SAOnBounceNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SAOnBounce_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAOnLeaveEdge:
						SAOnLeaveEdgeNode SAOnLeaveEdge_StateAction_Node = (SAOnLeaveEdgeNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SAOnLeaveEdge_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAOnStoppedAtEdge:
						SAOnStoppedAtEdgeNode SAOnStoppedAtEdge_StateAction_Node = (SAOnStoppedAtEdgeNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SAOnStoppedAtEdge_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAOnLand:
						SAOnLandNode SAOnLand_StateAction_Node = (SAOnLandNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SAOnLand_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAOnCancel:
						SAOnCancelNode SAOnCancel_StateAction_Node = (SAOnCancelNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SAOnCancel_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SARefreshAttack:
						SARefreshAttackNode SARefreshAttack_StateAction_Node = (SARefreshAttackNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SARefreshAttack_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAEndAttack:
						SAEndAttackNode SAEndAttack_StateAction_Node = (SAEndAttackNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SAEndAttack_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASetHitboxCount:
						SASetHitboxCountNode SASetHitboxCount_StateAction_Node = (SASetHitboxCountNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SASetHitboxCount_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAConfigHitbox:
						SAConfigHitboxNode SAConfigHitbox_StateAction_Node = (SAConfigHitboxNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SAConfigHitbox_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASetAtkProp:
						SASetAtkPropNode SASetAtkProp_StateAction_Node = (SASetAtkPropNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SASetAtkProp_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAManipHitBox:
						SAManipHitBoxNode SAManipHitBox_StateAction_Node = (SAManipHitBoxNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SAManipHitBox_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAUpdateHurtboxes:
						SAUpdateHurtboxesNode SAUpdateHurtboxes_StateAction_Node = (SAUpdateHurtboxesNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SAUpdateHurtboxes_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASetupHurtboxes:
						SASetupHurtboxesNode SASetupHurtboxes_StateAction_Node = (SASetupHurtboxesNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SASetupHurtboxes_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAManipHurtBox:
						SAManipHurtBoxNode SAManipHurtBox_StateAction_Node = (SAManipHurtBoxNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SAManipHurtBox_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SABoneState:
						SABoneStateNode SABoneState_StateAction_Node = (SABoneStateNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SABoneState_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SABoneScale:
						SABoneScaleNode SABoneScale_StateAction_Node = (SABoneScaleNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SABoneScale_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASpawnAgent:
						SASpawnAgentNode SASpawnAgent_StateAction_Node = (SASpawnAgentNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SASpawnAgent_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SALocalFX:
						SALocalFXNode SALocalFX_StateAction_Node = (SALocalFXNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SALocalFX_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASpawnFX:
						SASpawnFXNode SASpawnFX_StateAction_Node = (SASpawnFXNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SASpawnFX_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASetHitboxFX:
						SASetHitboxFXNode SASetHitboxFX_StateAction_Node = (SASetHitboxFXNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SASetHitboxFX_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAPlaySFX:
						SAPlaySFXNode SAPlaySFX_StateAction_Node = (SAPlaySFXNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SAPlaySFX_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASetHitboxSFX:
						SASetHitboxSFXNode SASetHitboxSFX_StateAction_Node = (SASetHitboxSFXNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SASetHitboxSFX_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAColorTint:
						SAColorTintNode SAColorTint_StateAction_Node = (SAColorTintNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SAColorTint_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAFindFloor:
						SAFindFloorNode SAFindFloor_StateAction_Node = (SAFindFloorNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SAFindFloor_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAHurtGrabbed:
						SAHurtGrabbedNode SAHurtGrabbed_StateAction_Node = (SAHurtGrabbedNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SAHurtGrabbed_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SALaunchGrabbed:
						SALaunchGrabbedNode SALaunchGrabbed_StateAction_Node = (SALaunchGrabbedNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SALaunchGrabbed_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAStateCancelGrabbed:
						SAStateCancelGrabbedNode SAStateCancelGrabbed_StateAction_Node = (SAStateCancelGrabbedNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SAStateCancelGrabbed_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAEndGrab:
						SAEndGrabNode SAEndGrab_StateAction_Node = (SAEndGrabNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SAEndGrab_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAGrabNotifyEscape:
						SAGrabNotifyEscapeNode SAGrabNotifyEscape_StateAction_Node = (SAGrabNotifyEscapeNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SAGrabNotifyEscape_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAIgnoreGrabbed:
						SAIgnoreGrabbedNode SAIgnoreGrabbed_StateAction_Node = (SAIgnoreGrabbedNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SAIgnoreGrabbed_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAEventKO:
						SAEventKONode SAEventKO_StateAction_Node = (SAEventKONode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SAEventKO_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAEventKOGrabbed:
						SAEventKOGrabbedNode SAEventKOGrabbed_StateAction_Node = (SAEventKOGrabbedNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SAEventKOGrabbed_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SACameraShake:
						SACameraShakeNode SACameraShake_StateAction_Node = (SACameraShakeNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SACameraShake_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAResetOnHits:
						SAResetOnHitsNode SAResetOnHits_StateAction_Node = (SAResetOnHitsNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SAResetOnHits_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAOnHit:
						SAOnHitNode SAOnHit_StateAction_Node = (SAOnHitNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SAOnHit_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAFastForwardState:
						SAFastForwardStateNode SAFastForwardState_StateAction_Node = (SAFastForwardStateNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SAFastForwardState_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SATimingTweak:
						SATimingTweakNode SATimingTweak_StateAction_Node = (SATimingTweakNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SATimingTweak_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAMapAnimation:
						SAMapAnimationNode SAMapAnimation_StateAction_Node = (SAMapAnimationNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SAMapAnimation_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAAlterMoveDT:
						SAAlterMoveDTNode SAAlterMoveDT_StateAction_Node = (SAAlterMoveDTNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SAAlterMoveDT_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAAlterMoveVel:
						SAAlterMoveVelNode SAAlterMoveVel_StateAction_Node = (SAAlterMoveVelNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SAAlterMoveVel_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASetStagePart:
						SASetStagePartNode SASetStagePart_StateAction_Node = (SASetStagePartNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SASetStagePart_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASetStagePartsDefault:
						SASetStagePartsDefaultNode SASetStagePartsDefault_StateAction_Node = (SASetStagePartsDefaultNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SASetStagePartsDefault_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAJump:
						SAJumpNode SAJump_StateAction_Node = (SAJumpNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SAJump_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAStopJump:
						SAStopJumpNode SAStopJump_StateAction_Node = (SAStopJumpNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SAStopJump_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAManageAirJump:
						SAManageAirJumpNode SAManageAirJump_StateAction_Node = (SAManageAirJumpNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SAManageAirJump_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SALeaveGround:
						SALeaveGroundNode SALeaveGround_StateAction_Node = (SALeaveGroundNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SALeaveGround_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAUnHogEdge:
						SAUnHogEdgeNode SAUnHogEdge_StateAction_Node = (SAUnHogEdgeNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SAUnHogEdge_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAPlaySFXTimeline:
						SAPlaySFXTimelineNode SAPlaySFXTimeline_StateAction_Node = (SAPlaySFXTimelineNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SAPlaySFXTimeline_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAFindLastHorizontalInput:
						SAFindLastHorizontalInputNode SAFindLastHorizontalInput_StateAction_Node = (SAFindLastHorizontalInputNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SAFindLastHorizontalInput_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASetCommandGrab:
						SASetCommandGrabNode SASetCommandGrab_StateAction_Node = (SASetCommandGrabNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SASetCommandGrab_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SACameraPunch:
						SACameraPunchNode SACameraPunch_StateAction_Node = (SACameraPunchNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SACameraPunch_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASpawnAgent2:
						SASpawnAgent2Node SASpawnAgent2_StateAction_Node = (SASpawnAgent2Node)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SASpawnAgent2_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAManipDecorChain:
						SAManipDecorChainNode SAManipDecorChain_StateAction_Node = (SAManipDecorChainNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SAManipDecorChain_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAUpdateHitboxes:
						SAUpdateHitboxesNode SAUpdateHitboxes_StateAction_Node = (SAUpdateHitboxesNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SAUpdateHitboxes_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASampleAnim:
						SASampleAnimNode SASampleAnim_StateAction_Node = (SASampleAnimNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SASampleAnim_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAForceExtraInputCheck:
						SAForceExtraInputCheckNode SAForceExtraInputCheck_StateAction_Node = (SAForceExtraInputCheckNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SAForceExtraInputCheck_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SALaunchGrabbedCustom:
						SALaunchGrabbedCustomNode SALaunchGrabbedCustom_StateAction_Node = (SALaunchGrabbedCustomNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SALaunchGrabbedCustom_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAMapAnimationSimple:
						SAMapAnimationSimpleNode SAMapAnimationSimple_StateAction_Node = (SAMapAnimationSimpleNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SAMapAnimationSimple_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAPersistLocalFX:
						SAPersistLocalFXNode SAPersistLocalFX_StateAction_Node = (SAPersistLocalFXNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SAPersistLocalFX_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAOnLeaveParent:
						SAOnLeaveParentNode SAOnLeaveParent_StateAction_Node = (SAOnLeaveParentNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SAOnLeaveParent_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAPlayVoiceLine:
						SAPlayVoiceLineNode SAPlayVoiceLine_StateAction_Node = (SAPlayVoiceLineNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SAPlayVoiceLine_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAPlayCategoryVoiceLine:
						SAPlayCategoryVoiceLineNode SAPlayCategoryVoiceLine_StateAction_Node = (SAPlayCategoryVoiceLineNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SAPlayCategoryVoiceLine_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAStopVoiceLines:
						SAStopVoiceLinesNode SAStopVoiceLines_StateAction_Node = (SAStopVoiceLinesNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SAStopVoiceLines_StateAction_Node.GetData();
					break;
				}
			}
			if (GetPort("ActionEnd").ConnectionCount > 0)
			{
				StateActionNode StateAction_Node = (StateActionNode)GetPort("ActionEnd").GetConnection(0).node;
				switch (StateAction_Node.TID)
				{
					case StateAction.TypeId.StateAction:
						StateActionNode StateAction_StateAction_Node = (StateActionNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = StateAction_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SADebugMessage:
						SADebugMessageNode SADebugMessage_StateAction_Node = (SADebugMessageNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SADebugMessage_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAPlayAnim:
						SAPlayAnimNode SAPlayAnim_StateAction_Node = (SAPlayAnimNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SAPlayAnim_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAPlayRootAnim:
						SAPlayRootAnimNode SAPlayRootAnim_StateAction_Node = (SAPlayRootAnimNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SAPlayRootAnim_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASnapAnimWeights:
						SASnapAnimWeightsNode SASnapAnimWeights_StateAction_Node = (SASnapAnimWeightsNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SASnapAnimWeights_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAStandardInput:
						SAStandardInputNode SAStandardInput_StateAction_Node = (SAStandardInputNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SAStandardInput_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAInputAction:
						SAInputActionNode SAInputAction_StateAction_Node = (SAInputActionNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SAInputAction_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SADeactivateInputAction:
						SADeactivateInputActionNode SADeactivateInputAction_StateAction_Node = (SADeactivateInputActionNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SADeactivateInputAction_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAAddInputEventFromFrame:
						SAAddInputEventFromFrameNode SAAddInputEventFromFrame_StateAction_Node = (SAAddInputEventFromFrameNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SAAddInputEventFromFrame_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SACancelToState:
						SACancelToStateNode SACancelToState_StateAction_Node = (SACancelToStateNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SACancelToState_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SACustomCall:
						SACustomCallNode SACustomCall_StateAction_Node = (SACustomCallNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SACustomCall_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SATimedAction:
						SATimedActionNode SATimedAction_StateAction_Node = (SATimedActionNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SATimedAction_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAOrderSensitive:
						SAOrderSensitiveNode SAOrderSensitive_StateAction_Node = (SAOrderSensitiveNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SAOrderSensitive_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAProxyMove:
						SAProxyMoveNode SAProxyMove_StateAction_Node = (SAProxyMoveNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SAProxyMove_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SACheckThing:
						SACheckThingNode SACheckThing_StateAction_Node = (SACheckThingNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SACheckThing_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAActiveAction:
						SAActiveActionNode SAActiveAction_StateAction_Node = (SAActiveActionNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SAActiveAction_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SADeactivateAction:
						SADeactivateActionNode SADeactivateAction_StateAction_Node = (SADeactivateActionNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SADeactivateAction_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASetFloatTarget:
						SASetFloatTargetNode SASetFloatTarget_StateAction_Node = (SASetFloatTargetNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SASetFloatTarget_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAOnBounce:
						SAOnBounceNode SAOnBounce_StateAction_Node = (SAOnBounceNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SAOnBounce_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAOnLeaveEdge:
						SAOnLeaveEdgeNode SAOnLeaveEdge_StateAction_Node = (SAOnLeaveEdgeNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SAOnLeaveEdge_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAOnStoppedAtEdge:
						SAOnStoppedAtEdgeNode SAOnStoppedAtEdge_StateAction_Node = (SAOnStoppedAtEdgeNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SAOnStoppedAtEdge_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAOnLand:
						SAOnLandNode SAOnLand_StateAction_Node = (SAOnLandNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SAOnLand_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAOnCancel:
						SAOnCancelNode SAOnCancel_StateAction_Node = (SAOnCancelNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SAOnCancel_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SARefreshAttack:
						SARefreshAttackNode SARefreshAttack_StateAction_Node = (SARefreshAttackNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SARefreshAttack_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAEndAttack:
						SAEndAttackNode SAEndAttack_StateAction_Node = (SAEndAttackNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SAEndAttack_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASetHitboxCount:
						SASetHitboxCountNode SASetHitboxCount_StateAction_Node = (SASetHitboxCountNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SASetHitboxCount_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAConfigHitbox:
						SAConfigHitboxNode SAConfigHitbox_StateAction_Node = (SAConfigHitboxNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SAConfigHitbox_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASetAtkProp:
						SASetAtkPropNode SASetAtkProp_StateAction_Node = (SASetAtkPropNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SASetAtkProp_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAManipHitBox:
						SAManipHitBoxNode SAManipHitBox_StateAction_Node = (SAManipHitBoxNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SAManipHitBox_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAUpdateHurtboxes:
						SAUpdateHurtboxesNode SAUpdateHurtboxes_StateAction_Node = (SAUpdateHurtboxesNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SAUpdateHurtboxes_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASetupHurtboxes:
						SASetupHurtboxesNode SASetupHurtboxes_StateAction_Node = (SASetupHurtboxesNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SASetupHurtboxes_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAManipHurtBox:
						SAManipHurtBoxNode SAManipHurtBox_StateAction_Node = (SAManipHurtBoxNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SAManipHurtBox_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SABoneState:
						SABoneStateNode SABoneState_StateAction_Node = (SABoneStateNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SABoneState_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SABoneScale:
						SABoneScaleNode SABoneScale_StateAction_Node = (SABoneScaleNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SABoneScale_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASpawnAgent:
						SASpawnAgentNode SASpawnAgent_StateAction_Node = (SASpawnAgentNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SASpawnAgent_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SALocalFX:
						SALocalFXNode SALocalFX_StateAction_Node = (SALocalFXNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SALocalFX_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASpawnFX:
						SASpawnFXNode SASpawnFX_StateAction_Node = (SASpawnFXNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SASpawnFX_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASetHitboxFX:
						SASetHitboxFXNode SASetHitboxFX_StateAction_Node = (SASetHitboxFXNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SASetHitboxFX_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAPlaySFX:
						SAPlaySFXNode SAPlaySFX_StateAction_Node = (SAPlaySFXNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SAPlaySFX_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASetHitboxSFX:
						SASetHitboxSFXNode SASetHitboxSFX_StateAction_Node = (SASetHitboxSFXNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SASetHitboxSFX_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAColorTint:
						SAColorTintNode SAColorTint_StateAction_Node = (SAColorTintNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SAColorTint_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAFindFloor:
						SAFindFloorNode SAFindFloor_StateAction_Node = (SAFindFloorNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SAFindFloor_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAHurtGrabbed:
						SAHurtGrabbedNode SAHurtGrabbed_StateAction_Node = (SAHurtGrabbedNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SAHurtGrabbed_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SALaunchGrabbed:
						SALaunchGrabbedNode SALaunchGrabbed_StateAction_Node = (SALaunchGrabbedNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SALaunchGrabbed_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAStateCancelGrabbed:
						SAStateCancelGrabbedNode SAStateCancelGrabbed_StateAction_Node = (SAStateCancelGrabbedNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SAStateCancelGrabbed_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAEndGrab:
						SAEndGrabNode SAEndGrab_StateAction_Node = (SAEndGrabNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SAEndGrab_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAGrabNotifyEscape:
						SAGrabNotifyEscapeNode SAGrabNotifyEscape_StateAction_Node = (SAGrabNotifyEscapeNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SAGrabNotifyEscape_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAIgnoreGrabbed:
						SAIgnoreGrabbedNode SAIgnoreGrabbed_StateAction_Node = (SAIgnoreGrabbedNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SAIgnoreGrabbed_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAEventKO:
						SAEventKONode SAEventKO_StateAction_Node = (SAEventKONode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SAEventKO_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAEventKOGrabbed:
						SAEventKOGrabbedNode SAEventKOGrabbed_StateAction_Node = (SAEventKOGrabbedNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SAEventKOGrabbed_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SACameraShake:
						SACameraShakeNode SACameraShake_StateAction_Node = (SACameraShakeNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SACameraShake_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAResetOnHits:
						SAResetOnHitsNode SAResetOnHits_StateAction_Node = (SAResetOnHitsNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SAResetOnHits_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAOnHit:
						SAOnHitNode SAOnHit_StateAction_Node = (SAOnHitNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SAOnHit_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAFastForwardState:
						SAFastForwardStateNode SAFastForwardState_StateAction_Node = (SAFastForwardStateNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SAFastForwardState_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SATimingTweak:
						SATimingTweakNode SATimingTweak_StateAction_Node = (SATimingTweakNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SATimingTweak_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAMapAnimation:
						SAMapAnimationNode SAMapAnimation_StateAction_Node = (SAMapAnimationNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SAMapAnimation_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAAlterMoveDT:
						SAAlterMoveDTNode SAAlterMoveDT_StateAction_Node = (SAAlterMoveDTNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SAAlterMoveDT_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAAlterMoveVel:
						SAAlterMoveVelNode SAAlterMoveVel_StateAction_Node = (SAAlterMoveVelNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SAAlterMoveVel_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASetStagePart:
						SASetStagePartNode SASetStagePart_StateAction_Node = (SASetStagePartNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SASetStagePart_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASetStagePartsDefault:
						SASetStagePartsDefaultNode SASetStagePartsDefault_StateAction_Node = (SASetStagePartsDefaultNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SASetStagePartsDefault_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAJump:
						SAJumpNode SAJump_StateAction_Node = (SAJumpNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SAJump_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAStopJump:
						SAStopJumpNode SAStopJump_StateAction_Node = (SAStopJumpNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SAStopJump_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAManageAirJump:
						SAManageAirJumpNode SAManageAirJump_StateAction_Node = (SAManageAirJumpNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SAManageAirJump_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SALeaveGround:
						SALeaveGroundNode SALeaveGround_StateAction_Node = (SALeaveGroundNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SALeaveGround_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAUnHogEdge:
						SAUnHogEdgeNode SAUnHogEdge_StateAction_Node = (SAUnHogEdgeNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SAUnHogEdge_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAPlaySFXTimeline:
						SAPlaySFXTimelineNode SAPlaySFXTimeline_StateAction_Node = (SAPlaySFXTimelineNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SAPlaySFXTimeline_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAFindLastHorizontalInput:
						SAFindLastHorizontalInputNode SAFindLastHorizontalInput_StateAction_Node = (SAFindLastHorizontalInputNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SAFindLastHorizontalInput_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASetCommandGrab:
						SASetCommandGrabNode SASetCommandGrab_StateAction_Node = (SASetCommandGrabNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SASetCommandGrab_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SACameraPunch:
						SACameraPunchNode SACameraPunch_StateAction_Node = (SACameraPunchNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SACameraPunch_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASpawnAgent2:
						SASpawnAgent2Node SASpawnAgent2_StateAction_Node = (SASpawnAgent2Node)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SASpawnAgent2_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAManipDecorChain:
						SAManipDecorChainNode SAManipDecorChain_StateAction_Node = (SAManipDecorChainNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SAManipDecorChain_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAUpdateHitboxes:
						SAUpdateHitboxesNode SAUpdateHitboxes_StateAction_Node = (SAUpdateHitboxesNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SAUpdateHitboxes_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SASampleAnim:
						SASampleAnimNode SASampleAnim_StateAction_Node = (SASampleAnimNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SASampleAnim_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAForceExtraInputCheck:
						SAForceExtraInputCheckNode SAForceExtraInputCheck_StateAction_Node = (SAForceExtraInputCheckNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SAForceExtraInputCheck_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SALaunchGrabbedCustom:
						SALaunchGrabbedCustomNode SALaunchGrabbedCustom_StateAction_Node = (SALaunchGrabbedCustomNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SALaunchGrabbedCustom_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAMapAnimationSimple:
						SAMapAnimationSimpleNode SAMapAnimationSimple_StateAction_Node = (SAMapAnimationSimpleNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SAMapAnimationSimple_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAPersistLocalFX:
						SAPersistLocalFXNode SAPersistLocalFX_StateAction_Node = (SAPersistLocalFXNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SAPersistLocalFX_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAOnLeaveParent:
						SAOnLeaveParentNode SAOnLeaveParent_StateAction_Node = (SAOnLeaveParentNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SAOnLeaveParent_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAPlayVoiceLine:
						SAPlayVoiceLineNode SAPlayVoiceLine_StateAction_Node = (SAPlayVoiceLineNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SAPlayVoiceLine_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAPlayCategoryVoiceLine:
						SAPlayCategoryVoiceLineNode SAPlayCategoryVoiceLine_StateAction_Node = (SAPlayCategoryVoiceLineNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SAPlayCategoryVoiceLine_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SAStopVoiceLines:
						SAStopVoiceLinesNode SAStopVoiceLines_StateAction_Node = (SAStopVoiceLinesNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SAStopVoiceLines_StateAction_Node.GetData();
					break;
				}
			}
			return objToReturn;
		}
	}
}

