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
	public class SATimingTweakNode : StateActionNode
	{
		public string AnimId;
		public string RootAnimId;
		[Output(connectionType = ConnectionType.Override)] public AnimConfig AnimCfg;
		[Output(connectionType = ConnectionType.Override)] public FloatSource AnimFrames;
		[Output(connectionType = ConnectionType.Override)] public FloatSource StateFrames;
		[Output(connectionType = ConnectionType.Override)] public FloatSource FramesToA;
		[Output(connectionType = ConnectionType.Override)] public FloatSource FramesToB;
		[Output(connectionType = ConnectionType.Override)] public StateAction ActionA;
		[Output(connectionType = ConnectionType.Override)] public StateAction ActionB;
		[Output(connectionType = ConnectionType.Override)] public StateAction ActionEnd;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.TimingTweakId;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SATimingTweak data, MovesetGraph graph, string assetPath, Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SATimingTweak));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			AnimId = data.AnimId;
			RootAnimId = data.RootAnimId;
			AnimCfg = data.AnimCfg;
			
			AnimConfigNode node_AnimCfg = graph.AddNode<AnimConfigNode>();
			GetPort("AnimCfg").Connect(node_AnimCfg.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_AnimCfg, assetPath);
			variableCount += node_AnimCfg.SetData(AnimCfg, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
			++variableCount;
			
			AnimFrames = data.AnimFrames;
			
			switch (AnimFrames.TID)
			{
				case FloatSource.TypeId.AgentId:
					FSAgentNode AgentId_node_AnimFrames = graph.AddNode<FSAgentNode>();
					GetPort("AnimFrames").Connect(AgentId_node_AnimFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AgentId_node_AnimFrames, assetPath);
					variableCount += AgentId_node_AnimFrames.SetData((FSAgent)AnimFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.BonesId:
					FSBonesNode BonesId_node_AnimFrames = graph.AddNode<FSBonesNode>();
					GetPort("AnimFrames").Connect(BonesId_node_AnimFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BonesId_node_AnimFrames, assetPath);
					variableCount += BonesId_node_AnimFrames.SetData((FSBones)AnimFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AttackId:
					FSAttackNode AttackId_node_AnimFrames = graph.AddNode<FSAttackNode>();
					GetPort("AnimFrames").Connect(AttackId_node_AnimFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AttackId_node_AnimFrames, assetPath);
					variableCount += AttackId_node_AnimFrames.SetData((FSAttack)AnimFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FrameId:
					FSFrameNode FrameId_node_AnimFrames = graph.AddNode<FSFrameNode>();
					GetPort("AnimFrames").Connect(FrameId_node_AnimFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FrameId_node_AnimFrames, assetPath);
					variableCount += FrameId_node_AnimFrames.SetData((FSFrame)AnimFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.InputId:
					FSInputNode InputId_node_AnimFrames = graph.AddNode<FSInputNode>();
					GetPort("AnimFrames").Connect(InputId_node_AnimFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputId_node_AnimFrames, assetPath);
					variableCount += InputId_node_AnimFrames.SetData((FSInput)AnimFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FuncId:
					FSFuncNode FuncId_node_AnimFrames = graph.AddNode<FSFuncNode>();
					GetPort("AnimFrames").Connect(FuncId_node_AnimFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FuncId_node_AnimFrames, assetPath);
					variableCount += FuncId_node_AnimFrames.SetData((FSFunc)AnimFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.MovementId:
					FSMovementNode MovementId_node_AnimFrames = graph.AddNode<FSMovementNode>();
					GetPort("AnimFrames").Connect(MovementId_node_AnimFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(MovementId_node_AnimFrames, assetPath);
					variableCount += MovementId_node_AnimFrames.SetData((FSMovement)AnimFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CombatId:
					FSCombatNode CombatId_node_AnimFrames = graph.AddNode<FSCombatNode>();
					GetPort("AnimFrames").Connect(CombatId_node_AnimFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CombatId_node_AnimFrames, assetPath);
					variableCount += CombatId_node_AnimFrames.SetData((FSCombat)AnimFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.GrabsId:
					FSGrabsNode GrabsId_node_AnimFrames = graph.AddNode<FSGrabsNode>();
					GetPort("AnimFrames").Connect(GrabsId_node_AnimFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(GrabsId_node_AnimFrames, assetPath);
					variableCount += GrabsId_node_AnimFrames.SetData((FSGrabs)AnimFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.DataId:
					FSDataNode DataId_node_AnimFrames = graph.AddNode<FSDataNode>();
					GetPort("AnimFrames").Connect(DataId_node_AnimFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DataId_node_AnimFrames, assetPath);
					variableCount += DataId_node_AnimFrames.SetData((FSData)AnimFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ScratchId:
					FSScratchNode ScratchId_node_AnimFrames = graph.AddNode<FSScratchNode>();
					GetPort("AnimFrames").Connect(ScratchId_node_AnimFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ScratchId_node_AnimFrames, assetPath);
					variableCount += ScratchId_node_AnimFrames.SetData((FSScratch)AnimFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AnimId:
					FSAnimNode AnimId_node_AnimFrames = graph.AddNode<FSAnimNode>();
					GetPort("AnimFrames").Connect(AnimId_node_AnimFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AnimId_node_AnimFrames, assetPath);
					variableCount += AnimId_node_AnimFrames.SetData((FSAnim)AnimFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SpeedId:
					FSSpeedNode SpeedId_node_AnimFrames = graph.AddNode<FSSpeedNode>();
					GetPort("AnimFrames").Connect(SpeedId_node_AnimFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpeedId_node_AnimFrames, assetPath);
					variableCount += SpeedId_node_AnimFrames.SetData((FSSpeed)AnimFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.PhysicsId:
					FSPhysicsNode PhysicsId_node_AnimFrames = graph.AddNode<FSPhysicsNode>();
					GetPort("AnimFrames").Connect(PhysicsId_node_AnimFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(PhysicsId_node_AnimFrames, assetPath);
					variableCount += PhysicsId_node_AnimFrames.SetData((FSPhysics)AnimFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CollisionId:
					FSCollisionNode CollisionId_node_AnimFrames = graph.AddNode<FSCollisionNode>();
					GetPort("AnimFrames").Connect(CollisionId_node_AnimFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CollisionId_node_AnimFrames, assetPath);
					variableCount += CollisionId_node_AnimFrames.SetData((FSCollision)AnimFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.TimerId:
					FSTimerNode TimerId_node_AnimFrames = graph.AddNode<FSTimerNode>();
					GetPort("AnimFrames").Connect(TimerId_node_AnimFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(TimerId_node_AnimFrames, assetPath);
					variableCount += TimerId_node_AnimFrames.SetData((FSTimer)AnimFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.LagId:
					FSLagNode LagId_node_AnimFrames = graph.AddNode<FSLagNode>();
					GetPort("AnimFrames").Connect(LagId_node_AnimFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LagId_node_AnimFrames, assetPath);
					variableCount += LagId_node_AnimFrames.SetData((FSLag)AnimFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.EffectsId:
					FSEffectsNode EffectsId_node_AnimFrames = graph.AddNode<FSEffectsNode>();
					GetPort("AnimFrames").Connect(EffectsId_node_AnimFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EffectsId_node_AnimFrames, assetPath);
					variableCount += EffectsId_node_AnimFrames.SetData((FSEffects)AnimFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ColorsId:
					FSColorsNode ColorsId_node_AnimFrames = graph.AddNode<FSColorsNode>();
					GetPort("AnimFrames").Connect(ColorsId_node_AnimFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ColorsId_node_AnimFrames, assetPath);
					variableCount += ColorsId_node_AnimFrames.SetData((FSColors)AnimFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.OnHitId:
					FSOnHitNode OnHitId_node_AnimFrames = graph.AddNode<FSOnHitNode>();
					GetPort("AnimFrames").Connect(OnHitId_node_AnimFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnHitId_node_AnimFrames, assetPath);
					variableCount += OnHitId_node_AnimFrames.SetData((FSOnHit)AnimFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RandomId:
					FSRandomNode RandomId_node_AnimFrames = graph.AddNode<FSRandomNode>();
					GetPort("AnimFrames").Connect(RandomId_node_AnimFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RandomId_node_AnimFrames, assetPath);
					variableCount += RandomId_node_AnimFrames.SetData((FSRandom)AnimFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CameraId:
					FSCameraInfoNode CameraId_node_AnimFrames = graph.AddNode<FSCameraInfoNode>();
					GetPort("AnimFrames").Connect(CameraId_node_AnimFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CameraId_node_AnimFrames, assetPath);
					variableCount += CameraId_node_AnimFrames.SetData((FSCameraInfo)AnimFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SportsId:
					FSSportsNode SportsId_node_AnimFrames = graph.AddNode<FSSportsNode>();
					GetPort("AnimFrames").Connect(SportsId_node_AnimFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SportsId_node_AnimFrames, assetPath);
					variableCount += SportsId_node_AnimFrames.SetData((FSSports)AnimFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.Vector2Mag:
					FSVector2MagNode Vector2Mag_node_AnimFrames = graph.AddNode<FSVector2MagNode>();
					GetPort("AnimFrames").Connect(Vector2Mag_node_AnimFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(Vector2Mag_node_AnimFrames, assetPath);
					variableCount += Vector2Mag_node_AnimFrames.SetData((FSVector2Mag)AnimFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CPUHelpId:
					FSCpuHelpNode CPUHelpId_node_AnimFrames = graph.AddNode<FSCpuHelpNode>();
					GetPort("AnimFrames").Connect(CPUHelpId_node_AnimFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CPUHelpId_node_AnimFrames, assetPath);
					variableCount += CPUHelpId_node_AnimFrames.SetData((FSCpuHelp)AnimFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ItemId:
					FSItemNode ItemId_node_AnimFrames = graph.AddNode<FSItemNode>();
					GetPort("AnimFrames").Connect(ItemId_node_AnimFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ItemId_node_AnimFrames, assetPath);
					variableCount += ItemId_node_AnimFrames.SetData((FSItem)AnimFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ModeId:
					FSModeNode ModeId_node_AnimFrames = graph.AddNode<FSModeNode>();
					GetPort("AnimFrames").Connect(ModeId_node_AnimFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ModeId_node_AnimFrames, assetPath);
					variableCount += ModeId_node_AnimFrames.SetData((FSMode)AnimFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.JumpsId:
					FSJumpsNode JumpsId_node_AnimFrames = graph.AddNode<FSJumpsNode>();
					GetPort("AnimFrames").Connect(JumpsId_node_AnimFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(JumpsId_node_AnimFrames, assetPath);
					variableCount += JumpsId_node_AnimFrames.SetData((FSJumps)AnimFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RootAnimId:
					FSRootAnimNode RootAnimId_node_AnimFrames = graph.AddNode<FSRootAnimNode>();
					GetPort("AnimFrames").Connect(RootAnimId_node_AnimFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RootAnimId_node_AnimFrames, assetPath);
					variableCount += RootAnimId_node_AnimFrames.SetData((FSRootAnim)AnimFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FloatId:
					FSValueNode FloatId_node_AnimFrames = graph.AddNode<FSValueNode>();
					GetPort("AnimFrames").Connect(FloatId_node_AnimFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FloatId_node_AnimFrames, assetPath);
					variableCount += FloatId_node_AnimFrames.SetData((FSValue)AnimFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
			}
			++variableCount;
			
			StateFrames = data.StateFrames;
			
			switch (StateFrames.TID)
			{
				case FloatSource.TypeId.AgentId:
					FSAgentNode AgentId_node_StateFrames = graph.AddNode<FSAgentNode>();
					GetPort("StateFrames").Connect(AgentId_node_StateFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AgentId_node_StateFrames, assetPath);
					variableCount += AgentId_node_StateFrames.SetData((FSAgent)StateFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.BonesId:
					FSBonesNode BonesId_node_StateFrames = graph.AddNode<FSBonesNode>();
					GetPort("StateFrames").Connect(BonesId_node_StateFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BonesId_node_StateFrames, assetPath);
					variableCount += BonesId_node_StateFrames.SetData((FSBones)StateFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AttackId:
					FSAttackNode AttackId_node_StateFrames = graph.AddNode<FSAttackNode>();
					GetPort("StateFrames").Connect(AttackId_node_StateFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AttackId_node_StateFrames, assetPath);
					variableCount += AttackId_node_StateFrames.SetData((FSAttack)StateFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FrameId:
					FSFrameNode FrameId_node_StateFrames = graph.AddNode<FSFrameNode>();
					GetPort("StateFrames").Connect(FrameId_node_StateFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FrameId_node_StateFrames, assetPath);
					variableCount += FrameId_node_StateFrames.SetData((FSFrame)StateFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.InputId:
					FSInputNode InputId_node_StateFrames = graph.AddNode<FSInputNode>();
					GetPort("StateFrames").Connect(InputId_node_StateFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputId_node_StateFrames, assetPath);
					variableCount += InputId_node_StateFrames.SetData((FSInput)StateFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FuncId:
					FSFuncNode FuncId_node_StateFrames = graph.AddNode<FSFuncNode>();
					GetPort("StateFrames").Connect(FuncId_node_StateFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FuncId_node_StateFrames, assetPath);
					variableCount += FuncId_node_StateFrames.SetData((FSFunc)StateFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.MovementId:
					FSMovementNode MovementId_node_StateFrames = graph.AddNode<FSMovementNode>();
					GetPort("StateFrames").Connect(MovementId_node_StateFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(MovementId_node_StateFrames, assetPath);
					variableCount += MovementId_node_StateFrames.SetData((FSMovement)StateFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CombatId:
					FSCombatNode CombatId_node_StateFrames = graph.AddNode<FSCombatNode>();
					GetPort("StateFrames").Connect(CombatId_node_StateFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CombatId_node_StateFrames, assetPath);
					variableCount += CombatId_node_StateFrames.SetData((FSCombat)StateFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.GrabsId:
					FSGrabsNode GrabsId_node_StateFrames = graph.AddNode<FSGrabsNode>();
					GetPort("StateFrames").Connect(GrabsId_node_StateFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(GrabsId_node_StateFrames, assetPath);
					variableCount += GrabsId_node_StateFrames.SetData((FSGrabs)StateFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.DataId:
					FSDataNode DataId_node_StateFrames = graph.AddNode<FSDataNode>();
					GetPort("StateFrames").Connect(DataId_node_StateFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DataId_node_StateFrames, assetPath);
					variableCount += DataId_node_StateFrames.SetData((FSData)StateFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ScratchId:
					FSScratchNode ScratchId_node_StateFrames = graph.AddNode<FSScratchNode>();
					GetPort("StateFrames").Connect(ScratchId_node_StateFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ScratchId_node_StateFrames, assetPath);
					variableCount += ScratchId_node_StateFrames.SetData((FSScratch)StateFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AnimId:
					FSAnimNode AnimId_node_StateFrames = graph.AddNode<FSAnimNode>();
					GetPort("StateFrames").Connect(AnimId_node_StateFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AnimId_node_StateFrames, assetPath);
					variableCount += AnimId_node_StateFrames.SetData((FSAnim)StateFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SpeedId:
					FSSpeedNode SpeedId_node_StateFrames = graph.AddNode<FSSpeedNode>();
					GetPort("StateFrames").Connect(SpeedId_node_StateFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpeedId_node_StateFrames, assetPath);
					variableCount += SpeedId_node_StateFrames.SetData((FSSpeed)StateFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.PhysicsId:
					FSPhysicsNode PhysicsId_node_StateFrames = graph.AddNode<FSPhysicsNode>();
					GetPort("StateFrames").Connect(PhysicsId_node_StateFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(PhysicsId_node_StateFrames, assetPath);
					variableCount += PhysicsId_node_StateFrames.SetData((FSPhysics)StateFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CollisionId:
					FSCollisionNode CollisionId_node_StateFrames = graph.AddNode<FSCollisionNode>();
					GetPort("StateFrames").Connect(CollisionId_node_StateFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CollisionId_node_StateFrames, assetPath);
					variableCount += CollisionId_node_StateFrames.SetData((FSCollision)StateFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.TimerId:
					FSTimerNode TimerId_node_StateFrames = graph.AddNode<FSTimerNode>();
					GetPort("StateFrames").Connect(TimerId_node_StateFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(TimerId_node_StateFrames, assetPath);
					variableCount += TimerId_node_StateFrames.SetData((FSTimer)StateFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.LagId:
					FSLagNode LagId_node_StateFrames = graph.AddNode<FSLagNode>();
					GetPort("StateFrames").Connect(LagId_node_StateFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LagId_node_StateFrames, assetPath);
					variableCount += LagId_node_StateFrames.SetData((FSLag)StateFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.EffectsId:
					FSEffectsNode EffectsId_node_StateFrames = graph.AddNode<FSEffectsNode>();
					GetPort("StateFrames").Connect(EffectsId_node_StateFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EffectsId_node_StateFrames, assetPath);
					variableCount += EffectsId_node_StateFrames.SetData((FSEffects)StateFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ColorsId:
					FSColorsNode ColorsId_node_StateFrames = graph.AddNode<FSColorsNode>();
					GetPort("StateFrames").Connect(ColorsId_node_StateFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ColorsId_node_StateFrames, assetPath);
					variableCount += ColorsId_node_StateFrames.SetData((FSColors)StateFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.OnHitId:
					FSOnHitNode OnHitId_node_StateFrames = graph.AddNode<FSOnHitNode>();
					GetPort("StateFrames").Connect(OnHitId_node_StateFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnHitId_node_StateFrames, assetPath);
					variableCount += OnHitId_node_StateFrames.SetData((FSOnHit)StateFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RandomId:
					FSRandomNode RandomId_node_StateFrames = graph.AddNode<FSRandomNode>();
					GetPort("StateFrames").Connect(RandomId_node_StateFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RandomId_node_StateFrames, assetPath);
					variableCount += RandomId_node_StateFrames.SetData((FSRandom)StateFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CameraId:
					FSCameraInfoNode CameraId_node_StateFrames = graph.AddNode<FSCameraInfoNode>();
					GetPort("StateFrames").Connect(CameraId_node_StateFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CameraId_node_StateFrames, assetPath);
					variableCount += CameraId_node_StateFrames.SetData((FSCameraInfo)StateFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SportsId:
					FSSportsNode SportsId_node_StateFrames = graph.AddNode<FSSportsNode>();
					GetPort("StateFrames").Connect(SportsId_node_StateFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SportsId_node_StateFrames, assetPath);
					variableCount += SportsId_node_StateFrames.SetData((FSSports)StateFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.Vector2Mag:
					FSVector2MagNode Vector2Mag_node_StateFrames = graph.AddNode<FSVector2MagNode>();
					GetPort("StateFrames").Connect(Vector2Mag_node_StateFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(Vector2Mag_node_StateFrames, assetPath);
					variableCount += Vector2Mag_node_StateFrames.SetData((FSVector2Mag)StateFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CPUHelpId:
					FSCpuHelpNode CPUHelpId_node_StateFrames = graph.AddNode<FSCpuHelpNode>();
					GetPort("StateFrames").Connect(CPUHelpId_node_StateFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CPUHelpId_node_StateFrames, assetPath);
					variableCount += CPUHelpId_node_StateFrames.SetData((FSCpuHelp)StateFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ItemId:
					FSItemNode ItemId_node_StateFrames = graph.AddNode<FSItemNode>();
					GetPort("StateFrames").Connect(ItemId_node_StateFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ItemId_node_StateFrames, assetPath);
					variableCount += ItemId_node_StateFrames.SetData((FSItem)StateFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ModeId:
					FSModeNode ModeId_node_StateFrames = graph.AddNode<FSModeNode>();
					GetPort("StateFrames").Connect(ModeId_node_StateFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ModeId_node_StateFrames, assetPath);
					variableCount += ModeId_node_StateFrames.SetData((FSMode)StateFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.JumpsId:
					FSJumpsNode JumpsId_node_StateFrames = graph.AddNode<FSJumpsNode>();
					GetPort("StateFrames").Connect(JumpsId_node_StateFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(JumpsId_node_StateFrames, assetPath);
					variableCount += JumpsId_node_StateFrames.SetData((FSJumps)StateFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RootAnimId:
					FSRootAnimNode RootAnimId_node_StateFrames = graph.AddNode<FSRootAnimNode>();
					GetPort("StateFrames").Connect(RootAnimId_node_StateFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RootAnimId_node_StateFrames, assetPath);
					variableCount += RootAnimId_node_StateFrames.SetData((FSRootAnim)StateFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FloatId:
					FSValueNode FloatId_node_StateFrames = graph.AddNode<FSValueNode>();
					GetPort("StateFrames").Connect(FloatId_node_StateFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FloatId_node_StateFrames, assetPath);
					variableCount += FloatId_node_StateFrames.SetData((FSValue)StateFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
			}
			++variableCount;
			
			FramesToA = data.FramesToA;
			
			switch (FramesToA.TID)
			{
				case FloatSource.TypeId.AgentId:
					FSAgentNode AgentId_node_FramesToA = graph.AddNode<FSAgentNode>();
					GetPort("FramesToA").Connect(AgentId_node_FramesToA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AgentId_node_FramesToA, assetPath);
					variableCount += AgentId_node_FramesToA.SetData((FSAgent)FramesToA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.BonesId:
					FSBonesNode BonesId_node_FramesToA = graph.AddNode<FSBonesNode>();
					GetPort("FramesToA").Connect(BonesId_node_FramesToA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BonesId_node_FramesToA, assetPath);
					variableCount += BonesId_node_FramesToA.SetData((FSBones)FramesToA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AttackId:
					FSAttackNode AttackId_node_FramesToA = graph.AddNode<FSAttackNode>();
					GetPort("FramesToA").Connect(AttackId_node_FramesToA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AttackId_node_FramesToA, assetPath);
					variableCount += AttackId_node_FramesToA.SetData((FSAttack)FramesToA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FrameId:
					FSFrameNode FrameId_node_FramesToA = graph.AddNode<FSFrameNode>();
					GetPort("FramesToA").Connect(FrameId_node_FramesToA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FrameId_node_FramesToA, assetPath);
					variableCount += FrameId_node_FramesToA.SetData((FSFrame)FramesToA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.InputId:
					FSInputNode InputId_node_FramesToA = graph.AddNode<FSInputNode>();
					GetPort("FramesToA").Connect(InputId_node_FramesToA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputId_node_FramesToA, assetPath);
					variableCount += InputId_node_FramesToA.SetData((FSInput)FramesToA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FuncId:
					FSFuncNode FuncId_node_FramesToA = graph.AddNode<FSFuncNode>();
					GetPort("FramesToA").Connect(FuncId_node_FramesToA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FuncId_node_FramesToA, assetPath);
					variableCount += FuncId_node_FramesToA.SetData((FSFunc)FramesToA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.MovementId:
					FSMovementNode MovementId_node_FramesToA = graph.AddNode<FSMovementNode>();
					GetPort("FramesToA").Connect(MovementId_node_FramesToA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(MovementId_node_FramesToA, assetPath);
					variableCount += MovementId_node_FramesToA.SetData((FSMovement)FramesToA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CombatId:
					FSCombatNode CombatId_node_FramesToA = graph.AddNode<FSCombatNode>();
					GetPort("FramesToA").Connect(CombatId_node_FramesToA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CombatId_node_FramesToA, assetPath);
					variableCount += CombatId_node_FramesToA.SetData((FSCombat)FramesToA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.GrabsId:
					FSGrabsNode GrabsId_node_FramesToA = graph.AddNode<FSGrabsNode>();
					GetPort("FramesToA").Connect(GrabsId_node_FramesToA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(GrabsId_node_FramesToA, assetPath);
					variableCount += GrabsId_node_FramesToA.SetData((FSGrabs)FramesToA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.DataId:
					FSDataNode DataId_node_FramesToA = graph.AddNode<FSDataNode>();
					GetPort("FramesToA").Connect(DataId_node_FramesToA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DataId_node_FramesToA, assetPath);
					variableCount += DataId_node_FramesToA.SetData((FSData)FramesToA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ScratchId:
					FSScratchNode ScratchId_node_FramesToA = graph.AddNode<FSScratchNode>();
					GetPort("FramesToA").Connect(ScratchId_node_FramesToA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ScratchId_node_FramesToA, assetPath);
					variableCount += ScratchId_node_FramesToA.SetData((FSScratch)FramesToA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AnimId:
					FSAnimNode AnimId_node_FramesToA = graph.AddNode<FSAnimNode>();
					GetPort("FramesToA").Connect(AnimId_node_FramesToA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AnimId_node_FramesToA, assetPath);
					variableCount += AnimId_node_FramesToA.SetData((FSAnim)FramesToA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SpeedId:
					FSSpeedNode SpeedId_node_FramesToA = graph.AddNode<FSSpeedNode>();
					GetPort("FramesToA").Connect(SpeedId_node_FramesToA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpeedId_node_FramesToA, assetPath);
					variableCount += SpeedId_node_FramesToA.SetData((FSSpeed)FramesToA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.PhysicsId:
					FSPhysicsNode PhysicsId_node_FramesToA = graph.AddNode<FSPhysicsNode>();
					GetPort("FramesToA").Connect(PhysicsId_node_FramesToA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(PhysicsId_node_FramesToA, assetPath);
					variableCount += PhysicsId_node_FramesToA.SetData((FSPhysics)FramesToA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CollisionId:
					FSCollisionNode CollisionId_node_FramesToA = graph.AddNode<FSCollisionNode>();
					GetPort("FramesToA").Connect(CollisionId_node_FramesToA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CollisionId_node_FramesToA, assetPath);
					variableCount += CollisionId_node_FramesToA.SetData((FSCollision)FramesToA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.TimerId:
					FSTimerNode TimerId_node_FramesToA = graph.AddNode<FSTimerNode>();
					GetPort("FramesToA").Connect(TimerId_node_FramesToA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(TimerId_node_FramesToA, assetPath);
					variableCount += TimerId_node_FramesToA.SetData((FSTimer)FramesToA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.LagId:
					FSLagNode LagId_node_FramesToA = graph.AddNode<FSLagNode>();
					GetPort("FramesToA").Connect(LagId_node_FramesToA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LagId_node_FramesToA, assetPath);
					variableCount += LagId_node_FramesToA.SetData((FSLag)FramesToA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.EffectsId:
					FSEffectsNode EffectsId_node_FramesToA = graph.AddNode<FSEffectsNode>();
					GetPort("FramesToA").Connect(EffectsId_node_FramesToA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EffectsId_node_FramesToA, assetPath);
					variableCount += EffectsId_node_FramesToA.SetData((FSEffects)FramesToA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ColorsId:
					FSColorsNode ColorsId_node_FramesToA = graph.AddNode<FSColorsNode>();
					GetPort("FramesToA").Connect(ColorsId_node_FramesToA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ColorsId_node_FramesToA, assetPath);
					variableCount += ColorsId_node_FramesToA.SetData((FSColors)FramesToA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.OnHitId:
					FSOnHitNode OnHitId_node_FramesToA = graph.AddNode<FSOnHitNode>();
					GetPort("FramesToA").Connect(OnHitId_node_FramesToA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnHitId_node_FramesToA, assetPath);
					variableCount += OnHitId_node_FramesToA.SetData((FSOnHit)FramesToA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RandomId:
					FSRandomNode RandomId_node_FramesToA = graph.AddNode<FSRandomNode>();
					GetPort("FramesToA").Connect(RandomId_node_FramesToA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RandomId_node_FramesToA, assetPath);
					variableCount += RandomId_node_FramesToA.SetData((FSRandom)FramesToA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CameraId:
					FSCameraInfoNode CameraId_node_FramesToA = graph.AddNode<FSCameraInfoNode>();
					GetPort("FramesToA").Connect(CameraId_node_FramesToA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CameraId_node_FramesToA, assetPath);
					variableCount += CameraId_node_FramesToA.SetData((FSCameraInfo)FramesToA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SportsId:
					FSSportsNode SportsId_node_FramesToA = graph.AddNode<FSSportsNode>();
					GetPort("FramesToA").Connect(SportsId_node_FramesToA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SportsId_node_FramesToA, assetPath);
					variableCount += SportsId_node_FramesToA.SetData((FSSports)FramesToA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.Vector2Mag:
					FSVector2MagNode Vector2Mag_node_FramesToA = graph.AddNode<FSVector2MagNode>();
					GetPort("FramesToA").Connect(Vector2Mag_node_FramesToA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(Vector2Mag_node_FramesToA, assetPath);
					variableCount += Vector2Mag_node_FramesToA.SetData((FSVector2Mag)FramesToA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CPUHelpId:
					FSCpuHelpNode CPUHelpId_node_FramesToA = graph.AddNode<FSCpuHelpNode>();
					GetPort("FramesToA").Connect(CPUHelpId_node_FramesToA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CPUHelpId_node_FramesToA, assetPath);
					variableCount += CPUHelpId_node_FramesToA.SetData((FSCpuHelp)FramesToA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ItemId:
					FSItemNode ItemId_node_FramesToA = graph.AddNode<FSItemNode>();
					GetPort("FramesToA").Connect(ItemId_node_FramesToA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ItemId_node_FramesToA, assetPath);
					variableCount += ItemId_node_FramesToA.SetData((FSItem)FramesToA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ModeId:
					FSModeNode ModeId_node_FramesToA = graph.AddNode<FSModeNode>();
					GetPort("FramesToA").Connect(ModeId_node_FramesToA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ModeId_node_FramesToA, assetPath);
					variableCount += ModeId_node_FramesToA.SetData((FSMode)FramesToA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.JumpsId:
					FSJumpsNode JumpsId_node_FramesToA = graph.AddNode<FSJumpsNode>();
					GetPort("FramesToA").Connect(JumpsId_node_FramesToA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(JumpsId_node_FramesToA, assetPath);
					variableCount += JumpsId_node_FramesToA.SetData((FSJumps)FramesToA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RootAnimId:
					FSRootAnimNode RootAnimId_node_FramesToA = graph.AddNode<FSRootAnimNode>();
					GetPort("FramesToA").Connect(RootAnimId_node_FramesToA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RootAnimId_node_FramesToA, assetPath);
					variableCount += RootAnimId_node_FramesToA.SetData((FSRootAnim)FramesToA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FloatId:
					FSValueNode FloatId_node_FramesToA = graph.AddNode<FSValueNode>();
					GetPort("FramesToA").Connect(FloatId_node_FramesToA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FloatId_node_FramesToA, assetPath);
					variableCount += FloatId_node_FramesToA.SetData((FSValue)FramesToA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
			}
			++variableCount;
			
			FramesToB = data.FramesToB;
			
			switch (FramesToB.TID)
			{
				case FloatSource.TypeId.AgentId:
					FSAgentNode AgentId_node_FramesToB = graph.AddNode<FSAgentNode>();
					GetPort("FramesToB").Connect(AgentId_node_FramesToB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AgentId_node_FramesToB, assetPath);
					variableCount += AgentId_node_FramesToB.SetData((FSAgent)FramesToB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.BonesId:
					FSBonesNode BonesId_node_FramesToB = graph.AddNode<FSBonesNode>();
					GetPort("FramesToB").Connect(BonesId_node_FramesToB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BonesId_node_FramesToB, assetPath);
					variableCount += BonesId_node_FramesToB.SetData((FSBones)FramesToB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AttackId:
					FSAttackNode AttackId_node_FramesToB = graph.AddNode<FSAttackNode>();
					GetPort("FramesToB").Connect(AttackId_node_FramesToB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AttackId_node_FramesToB, assetPath);
					variableCount += AttackId_node_FramesToB.SetData((FSAttack)FramesToB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FrameId:
					FSFrameNode FrameId_node_FramesToB = graph.AddNode<FSFrameNode>();
					GetPort("FramesToB").Connect(FrameId_node_FramesToB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FrameId_node_FramesToB, assetPath);
					variableCount += FrameId_node_FramesToB.SetData((FSFrame)FramesToB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.InputId:
					FSInputNode InputId_node_FramesToB = graph.AddNode<FSInputNode>();
					GetPort("FramesToB").Connect(InputId_node_FramesToB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputId_node_FramesToB, assetPath);
					variableCount += InputId_node_FramesToB.SetData((FSInput)FramesToB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FuncId:
					FSFuncNode FuncId_node_FramesToB = graph.AddNode<FSFuncNode>();
					GetPort("FramesToB").Connect(FuncId_node_FramesToB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FuncId_node_FramesToB, assetPath);
					variableCount += FuncId_node_FramesToB.SetData((FSFunc)FramesToB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.MovementId:
					FSMovementNode MovementId_node_FramesToB = graph.AddNode<FSMovementNode>();
					GetPort("FramesToB").Connect(MovementId_node_FramesToB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(MovementId_node_FramesToB, assetPath);
					variableCount += MovementId_node_FramesToB.SetData((FSMovement)FramesToB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CombatId:
					FSCombatNode CombatId_node_FramesToB = graph.AddNode<FSCombatNode>();
					GetPort("FramesToB").Connect(CombatId_node_FramesToB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CombatId_node_FramesToB, assetPath);
					variableCount += CombatId_node_FramesToB.SetData((FSCombat)FramesToB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.GrabsId:
					FSGrabsNode GrabsId_node_FramesToB = graph.AddNode<FSGrabsNode>();
					GetPort("FramesToB").Connect(GrabsId_node_FramesToB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(GrabsId_node_FramesToB, assetPath);
					variableCount += GrabsId_node_FramesToB.SetData((FSGrabs)FramesToB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.DataId:
					FSDataNode DataId_node_FramesToB = graph.AddNode<FSDataNode>();
					GetPort("FramesToB").Connect(DataId_node_FramesToB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DataId_node_FramesToB, assetPath);
					variableCount += DataId_node_FramesToB.SetData((FSData)FramesToB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ScratchId:
					FSScratchNode ScratchId_node_FramesToB = graph.AddNode<FSScratchNode>();
					GetPort("FramesToB").Connect(ScratchId_node_FramesToB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ScratchId_node_FramesToB, assetPath);
					variableCount += ScratchId_node_FramesToB.SetData((FSScratch)FramesToB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AnimId:
					FSAnimNode AnimId_node_FramesToB = graph.AddNode<FSAnimNode>();
					GetPort("FramesToB").Connect(AnimId_node_FramesToB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AnimId_node_FramesToB, assetPath);
					variableCount += AnimId_node_FramesToB.SetData((FSAnim)FramesToB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SpeedId:
					FSSpeedNode SpeedId_node_FramesToB = graph.AddNode<FSSpeedNode>();
					GetPort("FramesToB").Connect(SpeedId_node_FramesToB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpeedId_node_FramesToB, assetPath);
					variableCount += SpeedId_node_FramesToB.SetData((FSSpeed)FramesToB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.PhysicsId:
					FSPhysicsNode PhysicsId_node_FramesToB = graph.AddNode<FSPhysicsNode>();
					GetPort("FramesToB").Connect(PhysicsId_node_FramesToB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(PhysicsId_node_FramesToB, assetPath);
					variableCount += PhysicsId_node_FramesToB.SetData((FSPhysics)FramesToB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CollisionId:
					FSCollisionNode CollisionId_node_FramesToB = graph.AddNode<FSCollisionNode>();
					GetPort("FramesToB").Connect(CollisionId_node_FramesToB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CollisionId_node_FramesToB, assetPath);
					variableCount += CollisionId_node_FramesToB.SetData((FSCollision)FramesToB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.TimerId:
					FSTimerNode TimerId_node_FramesToB = graph.AddNode<FSTimerNode>();
					GetPort("FramesToB").Connect(TimerId_node_FramesToB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(TimerId_node_FramesToB, assetPath);
					variableCount += TimerId_node_FramesToB.SetData((FSTimer)FramesToB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.LagId:
					FSLagNode LagId_node_FramesToB = graph.AddNode<FSLagNode>();
					GetPort("FramesToB").Connect(LagId_node_FramesToB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LagId_node_FramesToB, assetPath);
					variableCount += LagId_node_FramesToB.SetData((FSLag)FramesToB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.EffectsId:
					FSEffectsNode EffectsId_node_FramesToB = graph.AddNode<FSEffectsNode>();
					GetPort("FramesToB").Connect(EffectsId_node_FramesToB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EffectsId_node_FramesToB, assetPath);
					variableCount += EffectsId_node_FramesToB.SetData((FSEffects)FramesToB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ColorsId:
					FSColorsNode ColorsId_node_FramesToB = graph.AddNode<FSColorsNode>();
					GetPort("FramesToB").Connect(ColorsId_node_FramesToB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ColorsId_node_FramesToB, assetPath);
					variableCount += ColorsId_node_FramesToB.SetData((FSColors)FramesToB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.OnHitId:
					FSOnHitNode OnHitId_node_FramesToB = graph.AddNode<FSOnHitNode>();
					GetPort("FramesToB").Connect(OnHitId_node_FramesToB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnHitId_node_FramesToB, assetPath);
					variableCount += OnHitId_node_FramesToB.SetData((FSOnHit)FramesToB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RandomId:
					FSRandomNode RandomId_node_FramesToB = graph.AddNode<FSRandomNode>();
					GetPort("FramesToB").Connect(RandomId_node_FramesToB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RandomId_node_FramesToB, assetPath);
					variableCount += RandomId_node_FramesToB.SetData((FSRandom)FramesToB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CameraId:
					FSCameraInfoNode CameraId_node_FramesToB = graph.AddNode<FSCameraInfoNode>();
					GetPort("FramesToB").Connect(CameraId_node_FramesToB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CameraId_node_FramesToB, assetPath);
					variableCount += CameraId_node_FramesToB.SetData((FSCameraInfo)FramesToB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SportsId:
					FSSportsNode SportsId_node_FramesToB = graph.AddNode<FSSportsNode>();
					GetPort("FramesToB").Connect(SportsId_node_FramesToB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SportsId_node_FramesToB, assetPath);
					variableCount += SportsId_node_FramesToB.SetData((FSSports)FramesToB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.Vector2Mag:
					FSVector2MagNode Vector2Mag_node_FramesToB = graph.AddNode<FSVector2MagNode>();
					GetPort("FramesToB").Connect(Vector2Mag_node_FramesToB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(Vector2Mag_node_FramesToB, assetPath);
					variableCount += Vector2Mag_node_FramesToB.SetData((FSVector2Mag)FramesToB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CPUHelpId:
					FSCpuHelpNode CPUHelpId_node_FramesToB = graph.AddNode<FSCpuHelpNode>();
					GetPort("FramesToB").Connect(CPUHelpId_node_FramesToB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CPUHelpId_node_FramesToB, assetPath);
					variableCount += CPUHelpId_node_FramesToB.SetData((FSCpuHelp)FramesToB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ItemId:
					FSItemNode ItemId_node_FramesToB = graph.AddNode<FSItemNode>();
					GetPort("FramesToB").Connect(ItemId_node_FramesToB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ItemId_node_FramesToB, assetPath);
					variableCount += ItemId_node_FramesToB.SetData((FSItem)FramesToB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ModeId:
					FSModeNode ModeId_node_FramesToB = graph.AddNode<FSModeNode>();
					GetPort("FramesToB").Connect(ModeId_node_FramesToB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ModeId_node_FramesToB, assetPath);
					variableCount += ModeId_node_FramesToB.SetData((FSMode)FramesToB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.JumpsId:
					FSJumpsNode JumpsId_node_FramesToB = graph.AddNode<FSJumpsNode>();
					GetPort("FramesToB").Connect(JumpsId_node_FramesToB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(JumpsId_node_FramesToB, assetPath);
					variableCount += JumpsId_node_FramesToB.SetData((FSJumps)FramesToB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RootAnimId:
					FSRootAnimNode RootAnimId_node_FramesToB = graph.AddNode<FSRootAnimNode>();
					GetPort("FramesToB").Connect(RootAnimId_node_FramesToB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RootAnimId_node_FramesToB, assetPath);
					variableCount += RootAnimId_node_FramesToB.SetData((FSRootAnim)FramesToB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FloatId:
					FSValueNode FloatId_node_FramesToB = graph.AddNode<FSValueNode>();
					GetPort("FramesToB").Connect(FloatId_node_FramesToB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FloatId_node_FramesToB, assetPath);
					variableCount += FloatId_node_FramesToB.SetData((FSValue)FramesToB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
			}
			++variableCount;
			
			ActionA = data.ActionA;
			
			switch (ActionA.TID)
			{
				case StateAction.TypeId.DebugId:
					SADebugMessageNode DebugId_node_ActionA = graph.AddNode<SADebugMessageNode>();
					GetPort("ActionA").Connect(DebugId_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DebugId_node_ActionA, assetPath);
					variableCount += DebugId_node_ActionA.SetData((SADebugMessage)ActionA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.PlayAnimId:
					SAPlayAnimNode PlayAnimId_node_ActionA = graph.AddNode<SAPlayAnimNode>();
					GetPort("ActionA").Connect(PlayAnimId_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(PlayAnimId_node_ActionA, assetPath);
					variableCount += PlayAnimId_node_ActionA.SetData((SAPlayAnim)ActionA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.RootAnimId:
					SAPlayRootAnimNode RootAnimId_node_ActionA = graph.AddNode<SAPlayRootAnimNode>();
					GetPort("ActionA").Connect(RootAnimId_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RootAnimId_node_ActionA, assetPath);
					variableCount += RootAnimId_node_ActionA.SetData((SAPlayRootAnim)ActionA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SnapAnimWeightsId:
					SASnapAnimWeightsNode SnapAnimWeightsId_node_ActionA = graph.AddNode<SASnapAnimWeightsNode>();
					GetPort("ActionA").Connect(SnapAnimWeightsId_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SnapAnimWeightsId_node_ActionA, assetPath);
					variableCount += SnapAnimWeightsId_node_ActionA.SetData((SASnapAnimWeights)ActionA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.StandardInputId:
					SAStandardInputNode StandardInputId_node_ActionA = graph.AddNode<SAStandardInputNode>();
					GetPort("ActionA").Connect(StandardInputId_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(StandardInputId_node_ActionA, assetPath);
					variableCount += StandardInputId_node_ActionA.SetData((SAStandardInput)ActionA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.InputId:
					SAInputActionNode InputId_node_ActionA = graph.AddNode<SAInputActionNode>();
					GetPort("ActionA").Connect(InputId_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputId_node_ActionA, assetPath);
					variableCount += InputId_node_ActionA.SetData((SAInputAction)ActionA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.DeactInputId:
					SADeactivateInputActionNode DeactInputId_node_ActionA = graph.AddNode<SADeactivateInputActionNode>();
					GetPort("ActionA").Connect(DeactInputId_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DeactInputId_node_ActionA, assetPath);
					variableCount += DeactInputId_node_ActionA.SetData((SADeactivateInputAction)ActionA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.InputEventFromFrameId:
					SAAddInputEventFromFrameNode InputEventFromFrameId_node_ActionA = graph.AddNode<SAAddInputEventFromFrameNode>();
					GetPort("ActionA").Connect(InputEventFromFrameId_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputEventFromFrameId_node_ActionA, assetPath);
					variableCount += InputEventFromFrameId_node_ActionA.SetData((SAAddInputEventFromFrame)ActionA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.CancelStateId:
					SACancelToStateNode CancelStateId_node_ActionA = graph.AddNode<SACancelToStateNode>();
					GetPort("ActionA").Connect(CancelStateId_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CancelStateId_node_ActionA, assetPath);
					variableCount += CancelStateId_node_ActionA.SetData((SACancelToState)ActionA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.CustomCallId:
					SACustomCallNode CustomCallId_node_ActionA = graph.AddNode<SACustomCallNode>();
					GetPort("ActionA").Connect(CustomCallId_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CustomCallId_node_ActionA, assetPath);
					variableCount += CustomCallId_node_ActionA.SetData((SACustomCall)ActionA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.TimerId:
					SATimedActionNode TimerId_node_ActionA = graph.AddNode<SATimedActionNode>();
					GetPort("ActionA").Connect(TimerId_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(TimerId_node_ActionA, assetPath);
					variableCount += TimerId_node_ActionA.SetData((SATimedAction)ActionA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.OrderId:
					SAOrderedSensitiveNode OrderId_node_ActionA = graph.AddNode<SAOrderedSensitiveNode>();
					GetPort("ActionA").Connect(OrderId_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OrderId_node_ActionA, assetPath);
					variableCount += OrderId_node_ActionA.SetData((SAOrderedSensitive)ActionA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.ProxyId:
					SAProxyMoveNode ProxyId_node_ActionA = graph.AddNode<SAProxyMoveNode>();
					GetPort("ActionA").Connect(ProxyId_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ProxyId_node_ActionA, assetPath);
					variableCount += ProxyId_node_ActionA.SetData((SAProxyMove)ActionA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.CheckId:
					SACheckThingNode CheckId_node_ActionA = graph.AddNode<SACheckThingNode>();
					GetPort("ActionA").Connect(CheckId_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CheckId_node_ActionA, assetPath);
					variableCount += CheckId_node_ActionA.SetData((SACheckThing)ActionA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.ActiveActionId:
					SAActiveActionNode ActiveActionId_node_ActionA = graph.AddNode<SAActiveActionNode>();
					GetPort("ActionA").Connect(ActiveActionId_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ActiveActionId_node_ActionA, assetPath);
					variableCount += ActiveActionId_node_ActionA.SetData((SAActiveAction)ActionA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.DeactivateActionId:
					SADeactivateActionNode DeactivateActionId_node_ActionA = graph.AddNode<SADeactivateActionNode>();
					GetPort("ActionA").Connect(DeactivateActionId_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DeactivateActionId_node_ActionA, assetPath);
					variableCount += DeactivateActionId_node_ActionA.SetData((SADeactivateAction)ActionA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SetFloatId:
					SASetFloatTargetNode SetFloatId_node_ActionA = graph.AddNode<SASetFloatTargetNode>();
					GetPort("ActionA").Connect(SetFloatId_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SetFloatId_node_ActionA, assetPath);
					variableCount += SetFloatId_node_ActionA.SetData((SASetFloatTarget)ActionA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.OnBounceId:
					SAOnBounceNode OnBounceId_node_ActionA = graph.AddNode<SAOnBounceNode>();
					GetPort("ActionA").Connect(OnBounceId_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnBounceId_node_ActionA, assetPath);
					variableCount += OnBounceId_node_ActionA.SetData((SAOnBounce)ActionA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.OnLeaveEdgeId:
					SAOnLeaveEdgeNode OnLeaveEdgeId_node_ActionA = graph.AddNode<SAOnLeaveEdgeNode>();
					GetPort("ActionA").Connect(OnLeaveEdgeId_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnLeaveEdgeId_node_ActionA, assetPath);
					variableCount += OnLeaveEdgeId_node_ActionA.SetData((SAOnLeaveEdge)ActionA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.OnStoppedAtEdgeId:
					SAOnStoppedAtLedgeNode OnStoppedAtEdgeId_node_ActionA = graph.AddNode<SAOnStoppedAtLedgeNode>();
					GetPort("ActionA").Connect(OnStoppedAtEdgeId_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnStoppedAtEdgeId_node_ActionA, assetPath);
					variableCount += OnStoppedAtEdgeId_node_ActionA.SetData((SAOnStoppedAtLedge)ActionA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.OnLandId:
					SAOnLandNode OnLandId_node_ActionA = graph.AddNode<SAOnLandNode>();
					GetPort("ActionA").Connect(OnLandId_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnLandId_node_ActionA, assetPath);
					variableCount += OnLandId_node_ActionA.SetData((SAOnLand)ActionA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.OnCancelId:
					SAOnCancelNode OnCancelId_node_ActionA = graph.AddNode<SAOnCancelNode>();
					GetPort("ActionA").Connect(OnCancelId_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnCancelId_node_ActionA, assetPath);
					variableCount += OnCancelId_node_ActionA.SetData((SAOnCancel)ActionA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.RefreshAtkId:
					SARefreshAttackNode RefreshAtkId_node_ActionA = graph.AddNode<SARefreshAttackNode>();
					GetPort("ActionA").Connect(RefreshAtkId_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RefreshAtkId_node_ActionA, assetPath);
					variableCount += RefreshAtkId_node_ActionA.SetData((SARefreshAttack)ActionA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.EndAtkId:
					SAEndAttackNode EndAtkId_node_ActionA = graph.AddNode<SAEndAttackNode>();
					GetPort("ActionA").Connect(EndAtkId_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EndAtkId_node_ActionA, assetPath);
					variableCount += EndAtkId_node_ActionA.SetData((SAEndAttack)ActionA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SetHitboxCountId:
					SASetHitboxCountNode SetHitboxCountId_node_ActionA = graph.AddNode<SASetHitboxCountNode>();
					GetPort("ActionA").Connect(SetHitboxCountId_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SetHitboxCountId_node_ActionA, assetPath);
					variableCount += SetHitboxCountId_node_ActionA.SetData((SASetHitboxCount)ActionA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.ConfigHitboxId:
					SAConfigHitboxNode ConfigHitboxId_node_ActionA = graph.AddNode<SAConfigHitboxNode>();
					GetPort("ActionA").Connect(ConfigHitboxId_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ConfigHitboxId_node_ActionA, assetPath);
					variableCount += ConfigHitboxId_node_ActionA.SetData((SAConfigHitbox)ActionA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SetAtkPropId:
					SASetAttackPropNode SetAtkPropId_node_ActionA = graph.AddNode<SASetAttackPropNode>();
					GetPort("ActionA").Connect(SetAtkPropId_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SetAtkPropId_node_ActionA, assetPath);
					variableCount += SetAtkPropId_node_ActionA.SetData((SASetAttackProp)ActionA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.ManipHitboxId:
					SAManipHitboxNode ManipHitboxId_node_ActionA = graph.AddNode<SAManipHitboxNode>();
					GetPort("ActionA").Connect(ManipHitboxId_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ManipHitboxId_node_ActionA, assetPath);
					variableCount += ManipHitboxId_node_ActionA.SetData((SAManipHitbox)ActionA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.UpdateHurtsetId:
					SAUpdateHurtboxesNode UpdateHurtsetId_node_ActionA = graph.AddNode<SAUpdateHurtboxesNode>();
					GetPort("ActionA").Connect(UpdateHurtsetId_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(UpdateHurtsetId_node_ActionA, assetPath);
					variableCount += UpdateHurtsetId_node_ActionA.SetData((SAUpdateHurtboxes)ActionA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SetupHurtsetId:
					SASetupHurtboxesNode SetupHurtsetId_node_ActionA = graph.AddNode<SASetupHurtboxesNode>();
					GetPort("ActionA").Connect(SetupHurtsetId_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SetupHurtsetId_node_ActionA, assetPath);
					variableCount += SetupHurtsetId_node_ActionA.SetData((SASetupHurtboxes)ActionA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.ManipHurtboxId:
					SAManipHurtboxNode ManipHurtboxId_node_ActionA = graph.AddNode<SAManipHurtboxNode>();
					GetPort("ActionA").Connect(ManipHurtboxId_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ManipHurtboxId_node_ActionA, assetPath);
					variableCount += ManipHurtboxId_node_ActionA.SetData((SAManipHurtbox)ActionA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.BoneStateId:
					SABoneStateNode BoneStateId_node_ActionA = graph.AddNode<SABoneStateNode>();
					GetPort("ActionA").Connect(BoneStateId_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BoneStateId_node_ActionA, assetPath);
					variableCount += BoneStateId_node_ActionA.SetData((SABoneState)ActionA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.BoneScaleId:
					SABoneScaleNode BoneScaleId_node_ActionA = graph.AddNode<SABoneScaleNode>();
					GetPort("ActionA").Connect(BoneScaleId_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BoneScaleId_node_ActionA, assetPath);
					variableCount += BoneScaleId_node_ActionA.SetData((SABoneScale)ActionA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SpawnAgentId:
					SASpawnAgentNode SpawnAgentId_node_ActionA = graph.AddNode<SASpawnAgentNode>();
					GetPort("ActionA").Connect(SpawnAgentId_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpawnAgentId_node_ActionA, assetPath);
					variableCount += SpawnAgentId_node_ActionA.SetData((SASpawnAgent)ActionA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.LocalFXId:
					SALocalFXNode LocalFXId_node_ActionA = graph.AddNode<SALocalFXNode>();
					GetPort("ActionA").Connect(LocalFXId_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LocalFXId_node_ActionA, assetPath);
					variableCount += LocalFXId_node_ActionA.SetData((SALocalFX)ActionA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SpawnFXId:
					SASpawnFXNode SpawnFXId_node_ActionA = graph.AddNode<SASpawnFXNode>();
					GetPort("ActionA").Connect(SpawnFXId_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpawnFXId_node_ActionA, assetPath);
					variableCount += SpawnFXId_node_ActionA.SetData((SASpawnFX)ActionA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.HitboxFXId:
					SASetHitboxFXNode HitboxFXId_node_ActionA = graph.AddNode<SASetHitboxFXNode>();
					GetPort("ActionA").Connect(HitboxFXId_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(HitboxFXId_node_ActionA, assetPath);
					variableCount += HitboxFXId_node_ActionA.SetData((SASetHitboxFX)ActionA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SFXId:
					SAPlaySFXNode SFXId_node_ActionA = graph.AddNode<SAPlaySFXNode>();
					GetPort("ActionA").Connect(SFXId_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SFXId_node_ActionA, assetPath);
					variableCount += SFXId_node_ActionA.SetData((SAPlaySFX)ActionA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.HitboxSFXId:
					SASetHitboxSFXNode HitboxSFXId_node_ActionA = graph.AddNode<SASetHitboxSFXNode>();
					GetPort("ActionA").Connect(HitboxSFXId_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(HitboxSFXId_node_ActionA, assetPath);
					variableCount += HitboxSFXId_node_ActionA.SetData((SASetHitboxSFX)ActionA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.ColorTintId:
					SAColorTintNode ColorTintId_node_ActionA = graph.AddNode<SAColorTintNode>();
					GetPort("ActionA").Connect(ColorTintId_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ColorTintId_node_ActionA, assetPath);
					variableCount += ColorTintId_node_ActionA.SetData((SAColorTint)ActionA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.FindFloorId:
					SAFindFloorNode FindFloorId_node_ActionA = graph.AddNode<SAFindFloorNode>();
					GetPort("ActionA").Connect(FindFloorId_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FindFloorId_node_ActionA, assetPath);
					variableCount += FindFloorId_node_ActionA.SetData((SAFindFloor)ActionA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.HurtGrabbedId:
					SAHurtGrabbedNode HurtGrabbedId_node_ActionA = graph.AddNode<SAHurtGrabbedNode>();
					GetPort("ActionA").Connect(HurtGrabbedId_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(HurtGrabbedId_node_ActionA, assetPath);
					variableCount += HurtGrabbedId_node_ActionA.SetData((SAHurtGrabbed)ActionA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.LaunchGrabbedId:
					SALaunchGrabbedNode LaunchGrabbedId_node_ActionA = graph.AddNode<SALaunchGrabbedNode>();
					GetPort("ActionA").Connect(LaunchGrabbedId_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LaunchGrabbedId_node_ActionA, assetPath);
					variableCount += LaunchGrabbedId_node_ActionA.SetData((SALaunchGrabbed)ActionA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.StateCancelGrabbedId:
					SAStateCancelGrabbedNode StateCancelGrabbedId_node_ActionA = graph.AddNode<SAStateCancelGrabbedNode>();
					GetPort("ActionA").Connect(StateCancelGrabbedId_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(StateCancelGrabbedId_node_ActionA, assetPath);
					variableCount += StateCancelGrabbedId_node_ActionA.SetData((SAStateCancelGrabbed)ActionA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.EndGrabId:
					SAEndGrabNode EndGrabId_node_ActionA = graph.AddNode<SAEndGrabNode>();
					GetPort("ActionA").Connect(EndGrabId_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EndGrabId_node_ActionA, assetPath);
					variableCount += EndGrabId_node_ActionA.SetData((SAEndGrab)ActionA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.GrabNotifyEscapeId:
					SAGrabNotifyEscapeNode GrabNotifyEscapeId_node_ActionA = graph.AddNode<SAGrabNotifyEscapeNode>();
					GetPort("ActionA").Connect(GrabNotifyEscapeId_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(GrabNotifyEscapeId_node_ActionA, assetPath);
					variableCount += GrabNotifyEscapeId_node_ActionA.SetData((SAGrabNotifyEscape)ActionA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.IgnoreGrabbedId:
					SAIgnoreGrabbedNode IgnoreGrabbedId_node_ActionA = graph.AddNode<SAIgnoreGrabbedNode>();
					GetPort("ActionA").Connect(IgnoreGrabbedId_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(IgnoreGrabbedId_node_ActionA, assetPath);
					variableCount += IgnoreGrabbedId_node_ActionA.SetData((SAIgnoreGrabbed)ActionA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.EventKOId:
					SAEventKONode EventKOId_node_ActionA = graph.AddNode<SAEventKONode>();
					GetPort("ActionA").Connect(EventKOId_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EventKOId_node_ActionA, assetPath);
					variableCount += EventKOId_node_ActionA.SetData((SAEventKO)ActionA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.EventKOGrabbedId:
					SAEventKOGrabbedNode EventKOGrabbedId_node_ActionA = graph.AddNode<SAEventKOGrabbedNode>();
					GetPort("ActionA").Connect(EventKOGrabbedId_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EventKOGrabbedId_node_ActionA, assetPath);
					variableCount += EventKOGrabbedId_node_ActionA.SetData((SAEventKOGrabbed)ActionA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.CameraShakeId:
					SACameraShakeNode CameraShakeId_node_ActionA = graph.AddNode<SACameraShakeNode>();
					GetPort("ActionA").Connect(CameraShakeId_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CameraShakeId_node_ActionA, assetPath);
					variableCount += CameraShakeId_node_ActionA.SetData((SACameraShake)ActionA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.ResetOnHitId:
					SAResetOnHitsNode ResetOnHitId_node_ActionA = graph.AddNode<SAResetOnHitsNode>();
					GetPort("ActionA").Connect(ResetOnHitId_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ResetOnHitId_node_ActionA, assetPath);
					variableCount += ResetOnHitId_node_ActionA.SetData((SAResetOnHits)ActionA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.OnHitId:
					SAOnHitNode OnHitId_node_ActionA = graph.AddNode<SAOnHitNode>();
					GetPort("ActionA").Connect(OnHitId_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnHitId_node_ActionA, assetPath);
					variableCount += OnHitId_node_ActionA.SetData((SAOnHit)ActionA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.FastForwardId:
					SAFastForwardStateNode FastForwardId_node_ActionA = graph.AddNode<SAFastForwardStateNode>();
					GetPort("ActionA").Connect(FastForwardId_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FastForwardId_node_ActionA, assetPath);
					variableCount += FastForwardId_node_ActionA.SetData((SAFastForwardState)ActionA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.TimingTweakId:
					SATimingTweakNode TimingTweakId_node_ActionA = graph.AddNode<SATimingTweakNode>();
					GetPort("ActionA").Connect(TimingTweakId_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(TimingTweakId_node_ActionA, assetPath);
					variableCount += TimingTweakId_node_ActionA.SetData((SATimingTweak)ActionA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.MapAnimId:
					SAMapAnimationNode MapAnimId_node_ActionA = graph.AddNode<SAMapAnimationNode>();
					GetPort("ActionA").Connect(MapAnimId_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(MapAnimId_node_ActionA, assetPath);
					variableCount += MapAnimId_node_ActionA.SetData((SAMapAnimation)ActionA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.AlterMoveDtId:
					SAAlterMoveDTNode AlterMoveDtId_node_ActionA = graph.AddNode<SAAlterMoveDTNode>();
					GetPort("ActionA").Connect(AlterMoveDtId_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AlterMoveDtId_node_ActionA, assetPath);
					variableCount += AlterMoveDtId_node_ActionA.SetData((SAAlterMoveDT)ActionA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.AlterMoveVelId:
					SAAlterMoveVelNode AlterMoveVelId_node_ActionA = graph.AddNode<SAAlterMoveVelNode>();
					GetPort("ActionA").Connect(AlterMoveVelId_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AlterMoveVelId_node_ActionA, assetPath);
					variableCount += AlterMoveVelId_node_ActionA.SetData((SAAlterMoveVel)ActionA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SetStagePartId:
					SASetStagePartNode SetStagePartId_node_ActionA = graph.AddNode<SASetStagePartNode>();
					GetPort("ActionA").Connect(SetStagePartId_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SetStagePartId_node_ActionA, assetPath);
					variableCount += SetStagePartId_node_ActionA.SetData((SASetStagePart)ActionA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SetStagePartsDefaultId:
					SASetStagePartsDefaultNode SetStagePartsDefaultId_node_ActionA = graph.AddNode<SASetStagePartsDefaultNode>();
					GetPort("ActionA").Connect(SetStagePartsDefaultId_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SetStagePartsDefaultId_node_ActionA, assetPath);
					variableCount += SetStagePartsDefaultId_node_ActionA.SetData((SASetStagePartsDefault)ActionA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.JumpId:
					SAJumpNode JumpId_node_ActionA = graph.AddNode<SAJumpNode>();
					GetPort("ActionA").Connect(JumpId_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(JumpId_node_ActionA, assetPath);
					variableCount += JumpId_node_ActionA.SetData((SAJump)ActionA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.StopJumpId:
					SAStopJumpNode StopJumpId_node_ActionA = graph.AddNode<SAStopJumpNode>();
					GetPort("ActionA").Connect(StopJumpId_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(StopJumpId_node_ActionA, assetPath);
					variableCount += StopJumpId_node_ActionA.SetData((SAStopJump)ActionA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.ManageAirJumpId:
					SAManageAirJumpNode ManageAirJumpId_node_ActionA = graph.AddNode<SAManageAirJumpNode>();
					GetPort("ActionA").Connect(ManageAirJumpId_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ManageAirJumpId_node_ActionA, assetPath);
					variableCount += ManageAirJumpId_node_ActionA.SetData((SAManageAirJump)ActionA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.LeaveGroundId:
					SALeaveGroundNode LeaveGroundId_node_ActionA = graph.AddNode<SALeaveGroundNode>();
					GetPort("ActionA").Connect(LeaveGroundId_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LeaveGroundId_node_ActionA, assetPath);
					variableCount += LeaveGroundId_node_ActionA.SetData((SALeaveGround)ActionA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.UnhogEdgeId:
					SAUnHogEdgeNode UnhogEdgeId_node_ActionA = graph.AddNode<SAUnHogEdgeNode>();
					GetPort("ActionA").Connect(UnhogEdgeId_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(UnhogEdgeId_node_ActionA, assetPath);
					variableCount += UnhogEdgeId_node_ActionA.SetData((SAUnHogEdge)ActionA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SFXTimelineId:
					SAPlaySFXTimelineNode SFXTimelineId_node_ActionA = graph.AddNode<SAPlaySFXTimelineNode>();
					GetPort("ActionA").Connect(SFXTimelineId_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SFXTimelineId_node_ActionA, assetPath);
					variableCount += SFXTimelineId_node_ActionA.SetData((SAPlaySFXTimeline)ActionA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.FindLastHorizontalInputId:
					SAFindLastHorizontalInputNode FindLastHorizontalInputId_node_ActionA = graph.AddNode<SAFindLastHorizontalInputNode>();
					GetPort("ActionA").Connect(FindLastHorizontalInputId_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FindLastHorizontalInputId_node_ActionA, assetPath);
					variableCount += FindLastHorizontalInputId_node_ActionA.SetData((SAFindLastHorizontalInput)ActionA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SetCommandGrab:
					SASetCommandGrabNode SetCommandGrab_node_ActionA = graph.AddNode<SASetCommandGrabNode>();
					GetPort("ActionA").Connect(SetCommandGrab_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SetCommandGrab_node_ActionA, assetPath);
					variableCount += SetCommandGrab_node_ActionA.SetData((SASetCommandGrab)ActionA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.CameraPunchId:
					SACameraPunchNode CameraPunchId_node_ActionA = graph.AddNode<SACameraPunchNode>();
					GetPort("ActionA").Connect(CameraPunchId_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CameraPunchId_node_ActionA, assetPath);
					variableCount += CameraPunchId_node_ActionA.SetData((SACameraPunch)ActionA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SpawnAgent2Id:
					SASpawnAgent2Node SpawnAgent2Id_node_ActionA = graph.AddNode<SASpawnAgent2Node>();
					GetPort("ActionA").Connect(SpawnAgent2Id_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpawnAgent2Id_node_ActionA, assetPath);
					variableCount += SpawnAgent2Id_node_ActionA.SetData((SASpawnAgent2)ActionA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.ManipDecorChainId:
					SAManipDecorChainNode ManipDecorChainId_node_ActionA = graph.AddNode<SAManipDecorChainNode>();
					GetPort("ActionA").Connect(ManipDecorChainId_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ManipDecorChainId_node_ActionA, assetPath);
					variableCount += ManipDecorChainId_node_ActionA.SetData((SAManipDecorChain)ActionA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.UpdateHitboxesId:
					SAUpdateHitboxesNode UpdateHitboxesId_node_ActionA = graph.AddNode<SAUpdateHitboxesNode>();
					GetPort("ActionA").Connect(UpdateHitboxesId_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(UpdateHitboxesId_node_ActionA, assetPath);
					variableCount += UpdateHitboxesId_node_ActionA.SetData((SAUpdateHitboxes)ActionA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SampleAnimId:
					SASampleAnimNode SampleAnimId_node_ActionA = graph.AddNode<SASampleAnimNode>();
					GetPort("ActionA").Connect(SampleAnimId_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SampleAnimId_node_ActionA, assetPath);
					variableCount += SampleAnimId_node_ActionA.SetData((SASampleAnim)ActionA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.ForceExtraInputId:
					SAForceExtraInputCheckNode ForceExtraInputId_node_ActionA = graph.AddNode<SAForceExtraInputCheckNode>();
					GetPort("ActionA").Connect(ForceExtraInputId_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ForceExtraInputId_node_ActionA, assetPath);
					variableCount += ForceExtraInputId_node_ActionA.SetData((SAForceExtraInputCheck)ActionA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.LaunchGrabbedCustomId:
					SALaunchGrabbedCustomNode LaunchGrabbedCustomId_node_ActionA = graph.AddNode<SALaunchGrabbedCustomNode>();
					GetPort("ActionA").Connect(LaunchGrabbedCustomId_node_ActionA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LaunchGrabbedCustomId_node_ActionA, assetPath);
					variableCount += LaunchGrabbedCustomId_node_ActionA.SetData((SALaunchGrabbedCustom)ActionA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
			}
			++variableCount;
			
			ActionB = data.ActionB;
			
			switch (ActionB.TID)
			{
				case StateAction.TypeId.DebugId:
					SADebugMessageNode DebugId_node_ActionB = graph.AddNode<SADebugMessageNode>();
					GetPort("ActionB").Connect(DebugId_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DebugId_node_ActionB, assetPath);
					variableCount += DebugId_node_ActionB.SetData((SADebugMessage)ActionB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.PlayAnimId:
					SAPlayAnimNode PlayAnimId_node_ActionB = graph.AddNode<SAPlayAnimNode>();
					GetPort("ActionB").Connect(PlayAnimId_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(PlayAnimId_node_ActionB, assetPath);
					variableCount += PlayAnimId_node_ActionB.SetData((SAPlayAnim)ActionB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.RootAnimId:
					SAPlayRootAnimNode RootAnimId_node_ActionB = graph.AddNode<SAPlayRootAnimNode>();
					GetPort("ActionB").Connect(RootAnimId_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RootAnimId_node_ActionB, assetPath);
					variableCount += RootAnimId_node_ActionB.SetData((SAPlayRootAnim)ActionB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SnapAnimWeightsId:
					SASnapAnimWeightsNode SnapAnimWeightsId_node_ActionB = graph.AddNode<SASnapAnimWeightsNode>();
					GetPort("ActionB").Connect(SnapAnimWeightsId_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SnapAnimWeightsId_node_ActionB, assetPath);
					variableCount += SnapAnimWeightsId_node_ActionB.SetData((SASnapAnimWeights)ActionB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.StandardInputId:
					SAStandardInputNode StandardInputId_node_ActionB = graph.AddNode<SAStandardInputNode>();
					GetPort("ActionB").Connect(StandardInputId_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(StandardInputId_node_ActionB, assetPath);
					variableCount += StandardInputId_node_ActionB.SetData((SAStandardInput)ActionB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.InputId:
					SAInputActionNode InputId_node_ActionB = graph.AddNode<SAInputActionNode>();
					GetPort("ActionB").Connect(InputId_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputId_node_ActionB, assetPath);
					variableCount += InputId_node_ActionB.SetData((SAInputAction)ActionB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.DeactInputId:
					SADeactivateInputActionNode DeactInputId_node_ActionB = graph.AddNode<SADeactivateInputActionNode>();
					GetPort("ActionB").Connect(DeactInputId_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DeactInputId_node_ActionB, assetPath);
					variableCount += DeactInputId_node_ActionB.SetData((SADeactivateInputAction)ActionB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.InputEventFromFrameId:
					SAAddInputEventFromFrameNode InputEventFromFrameId_node_ActionB = graph.AddNode<SAAddInputEventFromFrameNode>();
					GetPort("ActionB").Connect(InputEventFromFrameId_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputEventFromFrameId_node_ActionB, assetPath);
					variableCount += InputEventFromFrameId_node_ActionB.SetData((SAAddInputEventFromFrame)ActionB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.CancelStateId:
					SACancelToStateNode CancelStateId_node_ActionB = graph.AddNode<SACancelToStateNode>();
					GetPort("ActionB").Connect(CancelStateId_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CancelStateId_node_ActionB, assetPath);
					variableCount += CancelStateId_node_ActionB.SetData((SACancelToState)ActionB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.CustomCallId:
					SACustomCallNode CustomCallId_node_ActionB = graph.AddNode<SACustomCallNode>();
					GetPort("ActionB").Connect(CustomCallId_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CustomCallId_node_ActionB, assetPath);
					variableCount += CustomCallId_node_ActionB.SetData((SACustomCall)ActionB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.TimerId:
					SATimedActionNode TimerId_node_ActionB = graph.AddNode<SATimedActionNode>();
					GetPort("ActionB").Connect(TimerId_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(TimerId_node_ActionB, assetPath);
					variableCount += TimerId_node_ActionB.SetData((SATimedAction)ActionB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.OrderId:
					SAOrderedSensitiveNode OrderId_node_ActionB = graph.AddNode<SAOrderedSensitiveNode>();
					GetPort("ActionB").Connect(OrderId_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OrderId_node_ActionB, assetPath);
					variableCount += OrderId_node_ActionB.SetData((SAOrderedSensitive)ActionB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.ProxyId:
					SAProxyMoveNode ProxyId_node_ActionB = graph.AddNode<SAProxyMoveNode>();
					GetPort("ActionB").Connect(ProxyId_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ProxyId_node_ActionB, assetPath);
					variableCount += ProxyId_node_ActionB.SetData((SAProxyMove)ActionB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.CheckId:
					SACheckThingNode CheckId_node_ActionB = graph.AddNode<SACheckThingNode>();
					GetPort("ActionB").Connect(CheckId_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CheckId_node_ActionB, assetPath);
					variableCount += CheckId_node_ActionB.SetData((SACheckThing)ActionB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.ActiveActionId:
					SAActiveActionNode ActiveActionId_node_ActionB = graph.AddNode<SAActiveActionNode>();
					GetPort("ActionB").Connect(ActiveActionId_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ActiveActionId_node_ActionB, assetPath);
					variableCount += ActiveActionId_node_ActionB.SetData((SAActiveAction)ActionB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.DeactivateActionId:
					SADeactivateActionNode DeactivateActionId_node_ActionB = graph.AddNode<SADeactivateActionNode>();
					GetPort("ActionB").Connect(DeactivateActionId_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DeactivateActionId_node_ActionB, assetPath);
					variableCount += DeactivateActionId_node_ActionB.SetData((SADeactivateAction)ActionB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SetFloatId:
					SASetFloatTargetNode SetFloatId_node_ActionB = graph.AddNode<SASetFloatTargetNode>();
					GetPort("ActionB").Connect(SetFloatId_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SetFloatId_node_ActionB, assetPath);
					variableCount += SetFloatId_node_ActionB.SetData((SASetFloatTarget)ActionB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.OnBounceId:
					SAOnBounceNode OnBounceId_node_ActionB = graph.AddNode<SAOnBounceNode>();
					GetPort("ActionB").Connect(OnBounceId_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnBounceId_node_ActionB, assetPath);
					variableCount += OnBounceId_node_ActionB.SetData((SAOnBounce)ActionB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.OnLeaveEdgeId:
					SAOnLeaveEdgeNode OnLeaveEdgeId_node_ActionB = graph.AddNode<SAOnLeaveEdgeNode>();
					GetPort("ActionB").Connect(OnLeaveEdgeId_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnLeaveEdgeId_node_ActionB, assetPath);
					variableCount += OnLeaveEdgeId_node_ActionB.SetData((SAOnLeaveEdge)ActionB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.OnStoppedAtEdgeId:
					SAOnStoppedAtLedgeNode OnStoppedAtEdgeId_node_ActionB = graph.AddNode<SAOnStoppedAtLedgeNode>();
					GetPort("ActionB").Connect(OnStoppedAtEdgeId_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnStoppedAtEdgeId_node_ActionB, assetPath);
					variableCount += OnStoppedAtEdgeId_node_ActionB.SetData((SAOnStoppedAtLedge)ActionB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.OnLandId:
					SAOnLandNode OnLandId_node_ActionB = graph.AddNode<SAOnLandNode>();
					GetPort("ActionB").Connect(OnLandId_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnLandId_node_ActionB, assetPath);
					variableCount += OnLandId_node_ActionB.SetData((SAOnLand)ActionB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.OnCancelId:
					SAOnCancelNode OnCancelId_node_ActionB = graph.AddNode<SAOnCancelNode>();
					GetPort("ActionB").Connect(OnCancelId_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnCancelId_node_ActionB, assetPath);
					variableCount += OnCancelId_node_ActionB.SetData((SAOnCancel)ActionB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.RefreshAtkId:
					SARefreshAttackNode RefreshAtkId_node_ActionB = graph.AddNode<SARefreshAttackNode>();
					GetPort("ActionB").Connect(RefreshAtkId_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RefreshAtkId_node_ActionB, assetPath);
					variableCount += RefreshAtkId_node_ActionB.SetData((SARefreshAttack)ActionB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.EndAtkId:
					SAEndAttackNode EndAtkId_node_ActionB = graph.AddNode<SAEndAttackNode>();
					GetPort("ActionB").Connect(EndAtkId_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EndAtkId_node_ActionB, assetPath);
					variableCount += EndAtkId_node_ActionB.SetData((SAEndAttack)ActionB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SetHitboxCountId:
					SASetHitboxCountNode SetHitboxCountId_node_ActionB = graph.AddNode<SASetHitboxCountNode>();
					GetPort("ActionB").Connect(SetHitboxCountId_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SetHitboxCountId_node_ActionB, assetPath);
					variableCount += SetHitboxCountId_node_ActionB.SetData((SASetHitboxCount)ActionB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.ConfigHitboxId:
					SAConfigHitboxNode ConfigHitboxId_node_ActionB = graph.AddNode<SAConfigHitboxNode>();
					GetPort("ActionB").Connect(ConfigHitboxId_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ConfigHitboxId_node_ActionB, assetPath);
					variableCount += ConfigHitboxId_node_ActionB.SetData((SAConfigHitbox)ActionB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SetAtkPropId:
					SASetAttackPropNode SetAtkPropId_node_ActionB = graph.AddNode<SASetAttackPropNode>();
					GetPort("ActionB").Connect(SetAtkPropId_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SetAtkPropId_node_ActionB, assetPath);
					variableCount += SetAtkPropId_node_ActionB.SetData((SASetAttackProp)ActionB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.ManipHitboxId:
					SAManipHitboxNode ManipHitboxId_node_ActionB = graph.AddNode<SAManipHitboxNode>();
					GetPort("ActionB").Connect(ManipHitboxId_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ManipHitboxId_node_ActionB, assetPath);
					variableCount += ManipHitboxId_node_ActionB.SetData((SAManipHitbox)ActionB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.UpdateHurtsetId:
					SAUpdateHurtboxesNode UpdateHurtsetId_node_ActionB = graph.AddNode<SAUpdateHurtboxesNode>();
					GetPort("ActionB").Connect(UpdateHurtsetId_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(UpdateHurtsetId_node_ActionB, assetPath);
					variableCount += UpdateHurtsetId_node_ActionB.SetData((SAUpdateHurtboxes)ActionB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SetupHurtsetId:
					SASetupHurtboxesNode SetupHurtsetId_node_ActionB = graph.AddNode<SASetupHurtboxesNode>();
					GetPort("ActionB").Connect(SetupHurtsetId_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SetupHurtsetId_node_ActionB, assetPath);
					variableCount += SetupHurtsetId_node_ActionB.SetData((SASetupHurtboxes)ActionB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.ManipHurtboxId:
					SAManipHurtboxNode ManipHurtboxId_node_ActionB = graph.AddNode<SAManipHurtboxNode>();
					GetPort("ActionB").Connect(ManipHurtboxId_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ManipHurtboxId_node_ActionB, assetPath);
					variableCount += ManipHurtboxId_node_ActionB.SetData((SAManipHurtbox)ActionB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.BoneStateId:
					SABoneStateNode BoneStateId_node_ActionB = graph.AddNode<SABoneStateNode>();
					GetPort("ActionB").Connect(BoneStateId_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BoneStateId_node_ActionB, assetPath);
					variableCount += BoneStateId_node_ActionB.SetData((SABoneState)ActionB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.BoneScaleId:
					SABoneScaleNode BoneScaleId_node_ActionB = graph.AddNode<SABoneScaleNode>();
					GetPort("ActionB").Connect(BoneScaleId_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BoneScaleId_node_ActionB, assetPath);
					variableCount += BoneScaleId_node_ActionB.SetData((SABoneScale)ActionB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SpawnAgentId:
					SASpawnAgentNode SpawnAgentId_node_ActionB = graph.AddNode<SASpawnAgentNode>();
					GetPort("ActionB").Connect(SpawnAgentId_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpawnAgentId_node_ActionB, assetPath);
					variableCount += SpawnAgentId_node_ActionB.SetData((SASpawnAgent)ActionB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.LocalFXId:
					SALocalFXNode LocalFXId_node_ActionB = graph.AddNode<SALocalFXNode>();
					GetPort("ActionB").Connect(LocalFXId_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LocalFXId_node_ActionB, assetPath);
					variableCount += LocalFXId_node_ActionB.SetData((SALocalFX)ActionB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SpawnFXId:
					SASpawnFXNode SpawnFXId_node_ActionB = graph.AddNode<SASpawnFXNode>();
					GetPort("ActionB").Connect(SpawnFXId_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpawnFXId_node_ActionB, assetPath);
					variableCount += SpawnFXId_node_ActionB.SetData((SASpawnFX)ActionB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.HitboxFXId:
					SASetHitboxFXNode HitboxFXId_node_ActionB = graph.AddNode<SASetHitboxFXNode>();
					GetPort("ActionB").Connect(HitboxFXId_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(HitboxFXId_node_ActionB, assetPath);
					variableCount += HitboxFXId_node_ActionB.SetData((SASetHitboxFX)ActionB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SFXId:
					SAPlaySFXNode SFXId_node_ActionB = graph.AddNode<SAPlaySFXNode>();
					GetPort("ActionB").Connect(SFXId_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SFXId_node_ActionB, assetPath);
					variableCount += SFXId_node_ActionB.SetData((SAPlaySFX)ActionB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.HitboxSFXId:
					SASetHitboxSFXNode HitboxSFXId_node_ActionB = graph.AddNode<SASetHitboxSFXNode>();
					GetPort("ActionB").Connect(HitboxSFXId_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(HitboxSFXId_node_ActionB, assetPath);
					variableCount += HitboxSFXId_node_ActionB.SetData((SASetHitboxSFX)ActionB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.ColorTintId:
					SAColorTintNode ColorTintId_node_ActionB = graph.AddNode<SAColorTintNode>();
					GetPort("ActionB").Connect(ColorTintId_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ColorTintId_node_ActionB, assetPath);
					variableCount += ColorTintId_node_ActionB.SetData((SAColorTint)ActionB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.FindFloorId:
					SAFindFloorNode FindFloorId_node_ActionB = graph.AddNode<SAFindFloorNode>();
					GetPort("ActionB").Connect(FindFloorId_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FindFloorId_node_ActionB, assetPath);
					variableCount += FindFloorId_node_ActionB.SetData((SAFindFloor)ActionB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.HurtGrabbedId:
					SAHurtGrabbedNode HurtGrabbedId_node_ActionB = graph.AddNode<SAHurtGrabbedNode>();
					GetPort("ActionB").Connect(HurtGrabbedId_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(HurtGrabbedId_node_ActionB, assetPath);
					variableCount += HurtGrabbedId_node_ActionB.SetData((SAHurtGrabbed)ActionB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.LaunchGrabbedId:
					SALaunchGrabbedNode LaunchGrabbedId_node_ActionB = graph.AddNode<SALaunchGrabbedNode>();
					GetPort("ActionB").Connect(LaunchGrabbedId_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LaunchGrabbedId_node_ActionB, assetPath);
					variableCount += LaunchGrabbedId_node_ActionB.SetData((SALaunchGrabbed)ActionB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.StateCancelGrabbedId:
					SAStateCancelGrabbedNode StateCancelGrabbedId_node_ActionB = graph.AddNode<SAStateCancelGrabbedNode>();
					GetPort("ActionB").Connect(StateCancelGrabbedId_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(StateCancelGrabbedId_node_ActionB, assetPath);
					variableCount += StateCancelGrabbedId_node_ActionB.SetData((SAStateCancelGrabbed)ActionB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.EndGrabId:
					SAEndGrabNode EndGrabId_node_ActionB = graph.AddNode<SAEndGrabNode>();
					GetPort("ActionB").Connect(EndGrabId_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EndGrabId_node_ActionB, assetPath);
					variableCount += EndGrabId_node_ActionB.SetData((SAEndGrab)ActionB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.GrabNotifyEscapeId:
					SAGrabNotifyEscapeNode GrabNotifyEscapeId_node_ActionB = graph.AddNode<SAGrabNotifyEscapeNode>();
					GetPort("ActionB").Connect(GrabNotifyEscapeId_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(GrabNotifyEscapeId_node_ActionB, assetPath);
					variableCount += GrabNotifyEscapeId_node_ActionB.SetData((SAGrabNotifyEscape)ActionB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.IgnoreGrabbedId:
					SAIgnoreGrabbedNode IgnoreGrabbedId_node_ActionB = graph.AddNode<SAIgnoreGrabbedNode>();
					GetPort("ActionB").Connect(IgnoreGrabbedId_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(IgnoreGrabbedId_node_ActionB, assetPath);
					variableCount += IgnoreGrabbedId_node_ActionB.SetData((SAIgnoreGrabbed)ActionB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.EventKOId:
					SAEventKONode EventKOId_node_ActionB = graph.AddNode<SAEventKONode>();
					GetPort("ActionB").Connect(EventKOId_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EventKOId_node_ActionB, assetPath);
					variableCount += EventKOId_node_ActionB.SetData((SAEventKO)ActionB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.EventKOGrabbedId:
					SAEventKOGrabbedNode EventKOGrabbedId_node_ActionB = graph.AddNode<SAEventKOGrabbedNode>();
					GetPort("ActionB").Connect(EventKOGrabbedId_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EventKOGrabbedId_node_ActionB, assetPath);
					variableCount += EventKOGrabbedId_node_ActionB.SetData((SAEventKOGrabbed)ActionB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.CameraShakeId:
					SACameraShakeNode CameraShakeId_node_ActionB = graph.AddNode<SACameraShakeNode>();
					GetPort("ActionB").Connect(CameraShakeId_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CameraShakeId_node_ActionB, assetPath);
					variableCount += CameraShakeId_node_ActionB.SetData((SACameraShake)ActionB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.ResetOnHitId:
					SAResetOnHitsNode ResetOnHitId_node_ActionB = graph.AddNode<SAResetOnHitsNode>();
					GetPort("ActionB").Connect(ResetOnHitId_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ResetOnHitId_node_ActionB, assetPath);
					variableCount += ResetOnHitId_node_ActionB.SetData((SAResetOnHits)ActionB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.OnHitId:
					SAOnHitNode OnHitId_node_ActionB = graph.AddNode<SAOnHitNode>();
					GetPort("ActionB").Connect(OnHitId_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnHitId_node_ActionB, assetPath);
					variableCount += OnHitId_node_ActionB.SetData((SAOnHit)ActionB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.FastForwardId:
					SAFastForwardStateNode FastForwardId_node_ActionB = graph.AddNode<SAFastForwardStateNode>();
					GetPort("ActionB").Connect(FastForwardId_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FastForwardId_node_ActionB, assetPath);
					variableCount += FastForwardId_node_ActionB.SetData((SAFastForwardState)ActionB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.TimingTweakId:
					SATimingTweakNode TimingTweakId_node_ActionB = graph.AddNode<SATimingTweakNode>();
					GetPort("ActionB").Connect(TimingTweakId_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(TimingTweakId_node_ActionB, assetPath);
					variableCount += TimingTweakId_node_ActionB.SetData((SATimingTweak)ActionB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.MapAnimId:
					SAMapAnimationNode MapAnimId_node_ActionB = graph.AddNode<SAMapAnimationNode>();
					GetPort("ActionB").Connect(MapAnimId_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(MapAnimId_node_ActionB, assetPath);
					variableCount += MapAnimId_node_ActionB.SetData((SAMapAnimation)ActionB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.AlterMoveDtId:
					SAAlterMoveDTNode AlterMoveDtId_node_ActionB = graph.AddNode<SAAlterMoveDTNode>();
					GetPort("ActionB").Connect(AlterMoveDtId_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AlterMoveDtId_node_ActionB, assetPath);
					variableCount += AlterMoveDtId_node_ActionB.SetData((SAAlterMoveDT)ActionB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.AlterMoveVelId:
					SAAlterMoveVelNode AlterMoveVelId_node_ActionB = graph.AddNode<SAAlterMoveVelNode>();
					GetPort("ActionB").Connect(AlterMoveVelId_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AlterMoveVelId_node_ActionB, assetPath);
					variableCount += AlterMoveVelId_node_ActionB.SetData((SAAlterMoveVel)ActionB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SetStagePartId:
					SASetStagePartNode SetStagePartId_node_ActionB = graph.AddNode<SASetStagePartNode>();
					GetPort("ActionB").Connect(SetStagePartId_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SetStagePartId_node_ActionB, assetPath);
					variableCount += SetStagePartId_node_ActionB.SetData((SASetStagePart)ActionB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SetStagePartsDefaultId:
					SASetStagePartsDefaultNode SetStagePartsDefaultId_node_ActionB = graph.AddNode<SASetStagePartsDefaultNode>();
					GetPort("ActionB").Connect(SetStagePartsDefaultId_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SetStagePartsDefaultId_node_ActionB, assetPath);
					variableCount += SetStagePartsDefaultId_node_ActionB.SetData((SASetStagePartsDefault)ActionB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.JumpId:
					SAJumpNode JumpId_node_ActionB = graph.AddNode<SAJumpNode>();
					GetPort("ActionB").Connect(JumpId_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(JumpId_node_ActionB, assetPath);
					variableCount += JumpId_node_ActionB.SetData((SAJump)ActionB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.StopJumpId:
					SAStopJumpNode StopJumpId_node_ActionB = graph.AddNode<SAStopJumpNode>();
					GetPort("ActionB").Connect(StopJumpId_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(StopJumpId_node_ActionB, assetPath);
					variableCount += StopJumpId_node_ActionB.SetData((SAStopJump)ActionB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.ManageAirJumpId:
					SAManageAirJumpNode ManageAirJumpId_node_ActionB = graph.AddNode<SAManageAirJumpNode>();
					GetPort("ActionB").Connect(ManageAirJumpId_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ManageAirJumpId_node_ActionB, assetPath);
					variableCount += ManageAirJumpId_node_ActionB.SetData((SAManageAirJump)ActionB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.LeaveGroundId:
					SALeaveGroundNode LeaveGroundId_node_ActionB = graph.AddNode<SALeaveGroundNode>();
					GetPort("ActionB").Connect(LeaveGroundId_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LeaveGroundId_node_ActionB, assetPath);
					variableCount += LeaveGroundId_node_ActionB.SetData((SALeaveGround)ActionB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.UnhogEdgeId:
					SAUnHogEdgeNode UnhogEdgeId_node_ActionB = graph.AddNode<SAUnHogEdgeNode>();
					GetPort("ActionB").Connect(UnhogEdgeId_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(UnhogEdgeId_node_ActionB, assetPath);
					variableCount += UnhogEdgeId_node_ActionB.SetData((SAUnHogEdge)ActionB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SFXTimelineId:
					SAPlaySFXTimelineNode SFXTimelineId_node_ActionB = graph.AddNode<SAPlaySFXTimelineNode>();
					GetPort("ActionB").Connect(SFXTimelineId_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SFXTimelineId_node_ActionB, assetPath);
					variableCount += SFXTimelineId_node_ActionB.SetData((SAPlaySFXTimeline)ActionB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.FindLastHorizontalInputId:
					SAFindLastHorizontalInputNode FindLastHorizontalInputId_node_ActionB = graph.AddNode<SAFindLastHorizontalInputNode>();
					GetPort("ActionB").Connect(FindLastHorizontalInputId_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FindLastHorizontalInputId_node_ActionB, assetPath);
					variableCount += FindLastHorizontalInputId_node_ActionB.SetData((SAFindLastHorizontalInput)ActionB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SetCommandGrab:
					SASetCommandGrabNode SetCommandGrab_node_ActionB = graph.AddNode<SASetCommandGrabNode>();
					GetPort("ActionB").Connect(SetCommandGrab_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SetCommandGrab_node_ActionB, assetPath);
					variableCount += SetCommandGrab_node_ActionB.SetData((SASetCommandGrab)ActionB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.CameraPunchId:
					SACameraPunchNode CameraPunchId_node_ActionB = graph.AddNode<SACameraPunchNode>();
					GetPort("ActionB").Connect(CameraPunchId_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CameraPunchId_node_ActionB, assetPath);
					variableCount += CameraPunchId_node_ActionB.SetData((SACameraPunch)ActionB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SpawnAgent2Id:
					SASpawnAgent2Node SpawnAgent2Id_node_ActionB = graph.AddNode<SASpawnAgent2Node>();
					GetPort("ActionB").Connect(SpawnAgent2Id_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpawnAgent2Id_node_ActionB, assetPath);
					variableCount += SpawnAgent2Id_node_ActionB.SetData((SASpawnAgent2)ActionB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.ManipDecorChainId:
					SAManipDecorChainNode ManipDecorChainId_node_ActionB = graph.AddNode<SAManipDecorChainNode>();
					GetPort("ActionB").Connect(ManipDecorChainId_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ManipDecorChainId_node_ActionB, assetPath);
					variableCount += ManipDecorChainId_node_ActionB.SetData((SAManipDecorChain)ActionB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.UpdateHitboxesId:
					SAUpdateHitboxesNode UpdateHitboxesId_node_ActionB = graph.AddNode<SAUpdateHitboxesNode>();
					GetPort("ActionB").Connect(UpdateHitboxesId_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(UpdateHitboxesId_node_ActionB, assetPath);
					variableCount += UpdateHitboxesId_node_ActionB.SetData((SAUpdateHitboxes)ActionB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SampleAnimId:
					SASampleAnimNode SampleAnimId_node_ActionB = graph.AddNode<SASampleAnimNode>();
					GetPort("ActionB").Connect(SampleAnimId_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SampleAnimId_node_ActionB, assetPath);
					variableCount += SampleAnimId_node_ActionB.SetData((SASampleAnim)ActionB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.ForceExtraInputId:
					SAForceExtraInputCheckNode ForceExtraInputId_node_ActionB = graph.AddNode<SAForceExtraInputCheckNode>();
					GetPort("ActionB").Connect(ForceExtraInputId_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ForceExtraInputId_node_ActionB, assetPath);
					variableCount += ForceExtraInputId_node_ActionB.SetData((SAForceExtraInputCheck)ActionB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.LaunchGrabbedCustomId:
					SALaunchGrabbedCustomNode LaunchGrabbedCustomId_node_ActionB = graph.AddNode<SALaunchGrabbedCustomNode>();
					GetPort("ActionB").Connect(LaunchGrabbedCustomId_node_ActionB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LaunchGrabbedCustomId_node_ActionB, assetPath);
					variableCount += LaunchGrabbedCustomId_node_ActionB.SetData((SALaunchGrabbedCustom)ActionB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
			}
			++variableCount;
			
			ActionEnd = data.ActionEnd;
			
			switch (ActionEnd.TID)
			{
				case StateAction.TypeId.DebugId:
					SADebugMessageNode DebugId_node_ActionEnd = graph.AddNode<SADebugMessageNode>();
					GetPort("ActionEnd").Connect(DebugId_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DebugId_node_ActionEnd, assetPath);
					variableCount += DebugId_node_ActionEnd.SetData((SADebugMessage)ActionEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.PlayAnimId:
					SAPlayAnimNode PlayAnimId_node_ActionEnd = graph.AddNode<SAPlayAnimNode>();
					GetPort("ActionEnd").Connect(PlayAnimId_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(PlayAnimId_node_ActionEnd, assetPath);
					variableCount += PlayAnimId_node_ActionEnd.SetData((SAPlayAnim)ActionEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.RootAnimId:
					SAPlayRootAnimNode RootAnimId_node_ActionEnd = graph.AddNode<SAPlayRootAnimNode>();
					GetPort("ActionEnd").Connect(RootAnimId_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RootAnimId_node_ActionEnd, assetPath);
					variableCount += RootAnimId_node_ActionEnd.SetData((SAPlayRootAnim)ActionEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SnapAnimWeightsId:
					SASnapAnimWeightsNode SnapAnimWeightsId_node_ActionEnd = graph.AddNode<SASnapAnimWeightsNode>();
					GetPort("ActionEnd").Connect(SnapAnimWeightsId_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SnapAnimWeightsId_node_ActionEnd, assetPath);
					variableCount += SnapAnimWeightsId_node_ActionEnd.SetData((SASnapAnimWeights)ActionEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.StandardInputId:
					SAStandardInputNode StandardInputId_node_ActionEnd = graph.AddNode<SAStandardInputNode>();
					GetPort("ActionEnd").Connect(StandardInputId_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(StandardInputId_node_ActionEnd, assetPath);
					variableCount += StandardInputId_node_ActionEnd.SetData((SAStandardInput)ActionEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.InputId:
					SAInputActionNode InputId_node_ActionEnd = graph.AddNode<SAInputActionNode>();
					GetPort("ActionEnd").Connect(InputId_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputId_node_ActionEnd, assetPath);
					variableCount += InputId_node_ActionEnd.SetData((SAInputAction)ActionEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.DeactInputId:
					SADeactivateInputActionNode DeactInputId_node_ActionEnd = graph.AddNode<SADeactivateInputActionNode>();
					GetPort("ActionEnd").Connect(DeactInputId_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DeactInputId_node_ActionEnd, assetPath);
					variableCount += DeactInputId_node_ActionEnd.SetData((SADeactivateInputAction)ActionEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.InputEventFromFrameId:
					SAAddInputEventFromFrameNode InputEventFromFrameId_node_ActionEnd = graph.AddNode<SAAddInputEventFromFrameNode>();
					GetPort("ActionEnd").Connect(InputEventFromFrameId_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputEventFromFrameId_node_ActionEnd, assetPath);
					variableCount += InputEventFromFrameId_node_ActionEnd.SetData((SAAddInputEventFromFrame)ActionEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.CancelStateId:
					SACancelToStateNode CancelStateId_node_ActionEnd = graph.AddNode<SACancelToStateNode>();
					GetPort("ActionEnd").Connect(CancelStateId_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CancelStateId_node_ActionEnd, assetPath);
					variableCount += CancelStateId_node_ActionEnd.SetData((SACancelToState)ActionEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.CustomCallId:
					SACustomCallNode CustomCallId_node_ActionEnd = graph.AddNode<SACustomCallNode>();
					GetPort("ActionEnd").Connect(CustomCallId_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CustomCallId_node_ActionEnd, assetPath);
					variableCount += CustomCallId_node_ActionEnd.SetData((SACustomCall)ActionEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.TimerId:
					SATimedActionNode TimerId_node_ActionEnd = graph.AddNode<SATimedActionNode>();
					GetPort("ActionEnd").Connect(TimerId_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(TimerId_node_ActionEnd, assetPath);
					variableCount += TimerId_node_ActionEnd.SetData((SATimedAction)ActionEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.OrderId:
					SAOrderedSensitiveNode OrderId_node_ActionEnd = graph.AddNode<SAOrderedSensitiveNode>();
					GetPort("ActionEnd").Connect(OrderId_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OrderId_node_ActionEnd, assetPath);
					variableCount += OrderId_node_ActionEnd.SetData((SAOrderedSensitive)ActionEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.ProxyId:
					SAProxyMoveNode ProxyId_node_ActionEnd = graph.AddNode<SAProxyMoveNode>();
					GetPort("ActionEnd").Connect(ProxyId_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ProxyId_node_ActionEnd, assetPath);
					variableCount += ProxyId_node_ActionEnd.SetData((SAProxyMove)ActionEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.CheckId:
					SACheckThingNode CheckId_node_ActionEnd = graph.AddNode<SACheckThingNode>();
					GetPort("ActionEnd").Connect(CheckId_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CheckId_node_ActionEnd, assetPath);
					variableCount += CheckId_node_ActionEnd.SetData((SACheckThing)ActionEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.ActiveActionId:
					SAActiveActionNode ActiveActionId_node_ActionEnd = graph.AddNode<SAActiveActionNode>();
					GetPort("ActionEnd").Connect(ActiveActionId_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ActiveActionId_node_ActionEnd, assetPath);
					variableCount += ActiveActionId_node_ActionEnd.SetData((SAActiveAction)ActionEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.DeactivateActionId:
					SADeactivateActionNode DeactivateActionId_node_ActionEnd = graph.AddNode<SADeactivateActionNode>();
					GetPort("ActionEnd").Connect(DeactivateActionId_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DeactivateActionId_node_ActionEnd, assetPath);
					variableCount += DeactivateActionId_node_ActionEnd.SetData((SADeactivateAction)ActionEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SetFloatId:
					SASetFloatTargetNode SetFloatId_node_ActionEnd = graph.AddNode<SASetFloatTargetNode>();
					GetPort("ActionEnd").Connect(SetFloatId_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SetFloatId_node_ActionEnd, assetPath);
					variableCount += SetFloatId_node_ActionEnd.SetData((SASetFloatTarget)ActionEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.OnBounceId:
					SAOnBounceNode OnBounceId_node_ActionEnd = graph.AddNode<SAOnBounceNode>();
					GetPort("ActionEnd").Connect(OnBounceId_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnBounceId_node_ActionEnd, assetPath);
					variableCount += OnBounceId_node_ActionEnd.SetData((SAOnBounce)ActionEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.OnLeaveEdgeId:
					SAOnLeaveEdgeNode OnLeaveEdgeId_node_ActionEnd = graph.AddNode<SAOnLeaveEdgeNode>();
					GetPort("ActionEnd").Connect(OnLeaveEdgeId_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnLeaveEdgeId_node_ActionEnd, assetPath);
					variableCount += OnLeaveEdgeId_node_ActionEnd.SetData((SAOnLeaveEdge)ActionEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.OnStoppedAtEdgeId:
					SAOnStoppedAtLedgeNode OnStoppedAtEdgeId_node_ActionEnd = graph.AddNode<SAOnStoppedAtLedgeNode>();
					GetPort("ActionEnd").Connect(OnStoppedAtEdgeId_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnStoppedAtEdgeId_node_ActionEnd, assetPath);
					variableCount += OnStoppedAtEdgeId_node_ActionEnd.SetData((SAOnStoppedAtLedge)ActionEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.OnLandId:
					SAOnLandNode OnLandId_node_ActionEnd = graph.AddNode<SAOnLandNode>();
					GetPort("ActionEnd").Connect(OnLandId_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnLandId_node_ActionEnd, assetPath);
					variableCount += OnLandId_node_ActionEnd.SetData((SAOnLand)ActionEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.OnCancelId:
					SAOnCancelNode OnCancelId_node_ActionEnd = graph.AddNode<SAOnCancelNode>();
					GetPort("ActionEnd").Connect(OnCancelId_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnCancelId_node_ActionEnd, assetPath);
					variableCount += OnCancelId_node_ActionEnd.SetData((SAOnCancel)ActionEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.RefreshAtkId:
					SARefreshAttackNode RefreshAtkId_node_ActionEnd = graph.AddNode<SARefreshAttackNode>();
					GetPort("ActionEnd").Connect(RefreshAtkId_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RefreshAtkId_node_ActionEnd, assetPath);
					variableCount += RefreshAtkId_node_ActionEnd.SetData((SARefreshAttack)ActionEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.EndAtkId:
					SAEndAttackNode EndAtkId_node_ActionEnd = graph.AddNode<SAEndAttackNode>();
					GetPort("ActionEnd").Connect(EndAtkId_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EndAtkId_node_ActionEnd, assetPath);
					variableCount += EndAtkId_node_ActionEnd.SetData((SAEndAttack)ActionEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SetHitboxCountId:
					SASetHitboxCountNode SetHitboxCountId_node_ActionEnd = graph.AddNode<SASetHitboxCountNode>();
					GetPort("ActionEnd").Connect(SetHitboxCountId_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SetHitboxCountId_node_ActionEnd, assetPath);
					variableCount += SetHitboxCountId_node_ActionEnd.SetData((SASetHitboxCount)ActionEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.ConfigHitboxId:
					SAConfigHitboxNode ConfigHitboxId_node_ActionEnd = graph.AddNode<SAConfigHitboxNode>();
					GetPort("ActionEnd").Connect(ConfigHitboxId_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ConfigHitboxId_node_ActionEnd, assetPath);
					variableCount += ConfigHitboxId_node_ActionEnd.SetData((SAConfigHitbox)ActionEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SetAtkPropId:
					SASetAttackPropNode SetAtkPropId_node_ActionEnd = graph.AddNode<SASetAttackPropNode>();
					GetPort("ActionEnd").Connect(SetAtkPropId_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SetAtkPropId_node_ActionEnd, assetPath);
					variableCount += SetAtkPropId_node_ActionEnd.SetData((SASetAttackProp)ActionEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.ManipHitboxId:
					SAManipHitboxNode ManipHitboxId_node_ActionEnd = graph.AddNode<SAManipHitboxNode>();
					GetPort("ActionEnd").Connect(ManipHitboxId_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ManipHitboxId_node_ActionEnd, assetPath);
					variableCount += ManipHitboxId_node_ActionEnd.SetData((SAManipHitbox)ActionEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.UpdateHurtsetId:
					SAUpdateHurtboxesNode UpdateHurtsetId_node_ActionEnd = graph.AddNode<SAUpdateHurtboxesNode>();
					GetPort("ActionEnd").Connect(UpdateHurtsetId_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(UpdateHurtsetId_node_ActionEnd, assetPath);
					variableCount += UpdateHurtsetId_node_ActionEnd.SetData((SAUpdateHurtboxes)ActionEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SetupHurtsetId:
					SASetupHurtboxesNode SetupHurtsetId_node_ActionEnd = graph.AddNode<SASetupHurtboxesNode>();
					GetPort("ActionEnd").Connect(SetupHurtsetId_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SetupHurtsetId_node_ActionEnd, assetPath);
					variableCount += SetupHurtsetId_node_ActionEnd.SetData((SASetupHurtboxes)ActionEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.ManipHurtboxId:
					SAManipHurtboxNode ManipHurtboxId_node_ActionEnd = graph.AddNode<SAManipHurtboxNode>();
					GetPort("ActionEnd").Connect(ManipHurtboxId_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ManipHurtboxId_node_ActionEnd, assetPath);
					variableCount += ManipHurtboxId_node_ActionEnd.SetData((SAManipHurtbox)ActionEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.BoneStateId:
					SABoneStateNode BoneStateId_node_ActionEnd = graph.AddNode<SABoneStateNode>();
					GetPort("ActionEnd").Connect(BoneStateId_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BoneStateId_node_ActionEnd, assetPath);
					variableCount += BoneStateId_node_ActionEnd.SetData((SABoneState)ActionEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.BoneScaleId:
					SABoneScaleNode BoneScaleId_node_ActionEnd = graph.AddNode<SABoneScaleNode>();
					GetPort("ActionEnd").Connect(BoneScaleId_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BoneScaleId_node_ActionEnd, assetPath);
					variableCount += BoneScaleId_node_ActionEnd.SetData((SABoneScale)ActionEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SpawnAgentId:
					SASpawnAgentNode SpawnAgentId_node_ActionEnd = graph.AddNode<SASpawnAgentNode>();
					GetPort("ActionEnd").Connect(SpawnAgentId_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpawnAgentId_node_ActionEnd, assetPath);
					variableCount += SpawnAgentId_node_ActionEnd.SetData((SASpawnAgent)ActionEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.LocalFXId:
					SALocalFXNode LocalFXId_node_ActionEnd = graph.AddNode<SALocalFXNode>();
					GetPort("ActionEnd").Connect(LocalFXId_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LocalFXId_node_ActionEnd, assetPath);
					variableCount += LocalFXId_node_ActionEnd.SetData((SALocalFX)ActionEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SpawnFXId:
					SASpawnFXNode SpawnFXId_node_ActionEnd = graph.AddNode<SASpawnFXNode>();
					GetPort("ActionEnd").Connect(SpawnFXId_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpawnFXId_node_ActionEnd, assetPath);
					variableCount += SpawnFXId_node_ActionEnd.SetData((SASpawnFX)ActionEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.HitboxFXId:
					SASetHitboxFXNode HitboxFXId_node_ActionEnd = graph.AddNode<SASetHitboxFXNode>();
					GetPort("ActionEnd").Connect(HitboxFXId_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(HitboxFXId_node_ActionEnd, assetPath);
					variableCount += HitboxFXId_node_ActionEnd.SetData((SASetHitboxFX)ActionEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SFXId:
					SAPlaySFXNode SFXId_node_ActionEnd = graph.AddNode<SAPlaySFXNode>();
					GetPort("ActionEnd").Connect(SFXId_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SFXId_node_ActionEnd, assetPath);
					variableCount += SFXId_node_ActionEnd.SetData((SAPlaySFX)ActionEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.HitboxSFXId:
					SASetHitboxSFXNode HitboxSFXId_node_ActionEnd = graph.AddNode<SASetHitboxSFXNode>();
					GetPort("ActionEnd").Connect(HitboxSFXId_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(HitboxSFXId_node_ActionEnd, assetPath);
					variableCount += HitboxSFXId_node_ActionEnd.SetData((SASetHitboxSFX)ActionEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.ColorTintId:
					SAColorTintNode ColorTintId_node_ActionEnd = graph.AddNode<SAColorTintNode>();
					GetPort("ActionEnd").Connect(ColorTintId_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ColorTintId_node_ActionEnd, assetPath);
					variableCount += ColorTintId_node_ActionEnd.SetData((SAColorTint)ActionEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.FindFloorId:
					SAFindFloorNode FindFloorId_node_ActionEnd = graph.AddNode<SAFindFloorNode>();
					GetPort("ActionEnd").Connect(FindFloorId_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FindFloorId_node_ActionEnd, assetPath);
					variableCount += FindFloorId_node_ActionEnd.SetData((SAFindFloor)ActionEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.HurtGrabbedId:
					SAHurtGrabbedNode HurtGrabbedId_node_ActionEnd = graph.AddNode<SAHurtGrabbedNode>();
					GetPort("ActionEnd").Connect(HurtGrabbedId_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(HurtGrabbedId_node_ActionEnd, assetPath);
					variableCount += HurtGrabbedId_node_ActionEnd.SetData((SAHurtGrabbed)ActionEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.LaunchGrabbedId:
					SALaunchGrabbedNode LaunchGrabbedId_node_ActionEnd = graph.AddNode<SALaunchGrabbedNode>();
					GetPort("ActionEnd").Connect(LaunchGrabbedId_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LaunchGrabbedId_node_ActionEnd, assetPath);
					variableCount += LaunchGrabbedId_node_ActionEnd.SetData((SALaunchGrabbed)ActionEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.StateCancelGrabbedId:
					SAStateCancelGrabbedNode StateCancelGrabbedId_node_ActionEnd = graph.AddNode<SAStateCancelGrabbedNode>();
					GetPort("ActionEnd").Connect(StateCancelGrabbedId_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(StateCancelGrabbedId_node_ActionEnd, assetPath);
					variableCount += StateCancelGrabbedId_node_ActionEnd.SetData((SAStateCancelGrabbed)ActionEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.EndGrabId:
					SAEndGrabNode EndGrabId_node_ActionEnd = graph.AddNode<SAEndGrabNode>();
					GetPort("ActionEnd").Connect(EndGrabId_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EndGrabId_node_ActionEnd, assetPath);
					variableCount += EndGrabId_node_ActionEnd.SetData((SAEndGrab)ActionEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.GrabNotifyEscapeId:
					SAGrabNotifyEscapeNode GrabNotifyEscapeId_node_ActionEnd = graph.AddNode<SAGrabNotifyEscapeNode>();
					GetPort("ActionEnd").Connect(GrabNotifyEscapeId_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(GrabNotifyEscapeId_node_ActionEnd, assetPath);
					variableCount += GrabNotifyEscapeId_node_ActionEnd.SetData((SAGrabNotifyEscape)ActionEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.IgnoreGrabbedId:
					SAIgnoreGrabbedNode IgnoreGrabbedId_node_ActionEnd = graph.AddNode<SAIgnoreGrabbedNode>();
					GetPort("ActionEnd").Connect(IgnoreGrabbedId_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(IgnoreGrabbedId_node_ActionEnd, assetPath);
					variableCount += IgnoreGrabbedId_node_ActionEnd.SetData((SAIgnoreGrabbed)ActionEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.EventKOId:
					SAEventKONode EventKOId_node_ActionEnd = graph.AddNode<SAEventKONode>();
					GetPort("ActionEnd").Connect(EventKOId_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EventKOId_node_ActionEnd, assetPath);
					variableCount += EventKOId_node_ActionEnd.SetData((SAEventKO)ActionEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.EventKOGrabbedId:
					SAEventKOGrabbedNode EventKOGrabbedId_node_ActionEnd = graph.AddNode<SAEventKOGrabbedNode>();
					GetPort("ActionEnd").Connect(EventKOGrabbedId_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EventKOGrabbedId_node_ActionEnd, assetPath);
					variableCount += EventKOGrabbedId_node_ActionEnd.SetData((SAEventKOGrabbed)ActionEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.CameraShakeId:
					SACameraShakeNode CameraShakeId_node_ActionEnd = graph.AddNode<SACameraShakeNode>();
					GetPort("ActionEnd").Connect(CameraShakeId_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CameraShakeId_node_ActionEnd, assetPath);
					variableCount += CameraShakeId_node_ActionEnd.SetData((SACameraShake)ActionEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.ResetOnHitId:
					SAResetOnHitsNode ResetOnHitId_node_ActionEnd = graph.AddNode<SAResetOnHitsNode>();
					GetPort("ActionEnd").Connect(ResetOnHitId_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ResetOnHitId_node_ActionEnd, assetPath);
					variableCount += ResetOnHitId_node_ActionEnd.SetData((SAResetOnHits)ActionEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.OnHitId:
					SAOnHitNode OnHitId_node_ActionEnd = graph.AddNode<SAOnHitNode>();
					GetPort("ActionEnd").Connect(OnHitId_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnHitId_node_ActionEnd, assetPath);
					variableCount += OnHitId_node_ActionEnd.SetData((SAOnHit)ActionEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.FastForwardId:
					SAFastForwardStateNode FastForwardId_node_ActionEnd = graph.AddNode<SAFastForwardStateNode>();
					GetPort("ActionEnd").Connect(FastForwardId_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FastForwardId_node_ActionEnd, assetPath);
					variableCount += FastForwardId_node_ActionEnd.SetData((SAFastForwardState)ActionEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.TimingTweakId:
					SATimingTweakNode TimingTweakId_node_ActionEnd = graph.AddNode<SATimingTweakNode>();
					GetPort("ActionEnd").Connect(TimingTweakId_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(TimingTweakId_node_ActionEnd, assetPath);
					variableCount += TimingTweakId_node_ActionEnd.SetData((SATimingTweak)ActionEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.MapAnimId:
					SAMapAnimationNode MapAnimId_node_ActionEnd = graph.AddNode<SAMapAnimationNode>();
					GetPort("ActionEnd").Connect(MapAnimId_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(MapAnimId_node_ActionEnd, assetPath);
					variableCount += MapAnimId_node_ActionEnd.SetData((SAMapAnimation)ActionEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.AlterMoveDtId:
					SAAlterMoveDTNode AlterMoveDtId_node_ActionEnd = graph.AddNode<SAAlterMoveDTNode>();
					GetPort("ActionEnd").Connect(AlterMoveDtId_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AlterMoveDtId_node_ActionEnd, assetPath);
					variableCount += AlterMoveDtId_node_ActionEnd.SetData((SAAlterMoveDT)ActionEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.AlterMoveVelId:
					SAAlterMoveVelNode AlterMoveVelId_node_ActionEnd = graph.AddNode<SAAlterMoveVelNode>();
					GetPort("ActionEnd").Connect(AlterMoveVelId_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AlterMoveVelId_node_ActionEnd, assetPath);
					variableCount += AlterMoveVelId_node_ActionEnd.SetData((SAAlterMoveVel)ActionEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SetStagePartId:
					SASetStagePartNode SetStagePartId_node_ActionEnd = graph.AddNode<SASetStagePartNode>();
					GetPort("ActionEnd").Connect(SetStagePartId_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SetStagePartId_node_ActionEnd, assetPath);
					variableCount += SetStagePartId_node_ActionEnd.SetData((SASetStagePart)ActionEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SetStagePartsDefaultId:
					SASetStagePartsDefaultNode SetStagePartsDefaultId_node_ActionEnd = graph.AddNode<SASetStagePartsDefaultNode>();
					GetPort("ActionEnd").Connect(SetStagePartsDefaultId_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SetStagePartsDefaultId_node_ActionEnd, assetPath);
					variableCount += SetStagePartsDefaultId_node_ActionEnd.SetData((SASetStagePartsDefault)ActionEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.JumpId:
					SAJumpNode JumpId_node_ActionEnd = graph.AddNode<SAJumpNode>();
					GetPort("ActionEnd").Connect(JumpId_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(JumpId_node_ActionEnd, assetPath);
					variableCount += JumpId_node_ActionEnd.SetData((SAJump)ActionEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.StopJumpId:
					SAStopJumpNode StopJumpId_node_ActionEnd = graph.AddNode<SAStopJumpNode>();
					GetPort("ActionEnd").Connect(StopJumpId_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(StopJumpId_node_ActionEnd, assetPath);
					variableCount += StopJumpId_node_ActionEnd.SetData((SAStopJump)ActionEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.ManageAirJumpId:
					SAManageAirJumpNode ManageAirJumpId_node_ActionEnd = graph.AddNode<SAManageAirJumpNode>();
					GetPort("ActionEnd").Connect(ManageAirJumpId_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ManageAirJumpId_node_ActionEnd, assetPath);
					variableCount += ManageAirJumpId_node_ActionEnd.SetData((SAManageAirJump)ActionEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.LeaveGroundId:
					SALeaveGroundNode LeaveGroundId_node_ActionEnd = graph.AddNode<SALeaveGroundNode>();
					GetPort("ActionEnd").Connect(LeaveGroundId_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LeaveGroundId_node_ActionEnd, assetPath);
					variableCount += LeaveGroundId_node_ActionEnd.SetData((SALeaveGround)ActionEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.UnhogEdgeId:
					SAUnHogEdgeNode UnhogEdgeId_node_ActionEnd = graph.AddNode<SAUnHogEdgeNode>();
					GetPort("ActionEnd").Connect(UnhogEdgeId_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(UnhogEdgeId_node_ActionEnd, assetPath);
					variableCount += UnhogEdgeId_node_ActionEnd.SetData((SAUnHogEdge)ActionEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SFXTimelineId:
					SAPlaySFXTimelineNode SFXTimelineId_node_ActionEnd = graph.AddNode<SAPlaySFXTimelineNode>();
					GetPort("ActionEnd").Connect(SFXTimelineId_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SFXTimelineId_node_ActionEnd, assetPath);
					variableCount += SFXTimelineId_node_ActionEnd.SetData((SAPlaySFXTimeline)ActionEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.FindLastHorizontalInputId:
					SAFindLastHorizontalInputNode FindLastHorizontalInputId_node_ActionEnd = graph.AddNode<SAFindLastHorizontalInputNode>();
					GetPort("ActionEnd").Connect(FindLastHorizontalInputId_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FindLastHorizontalInputId_node_ActionEnd, assetPath);
					variableCount += FindLastHorizontalInputId_node_ActionEnd.SetData((SAFindLastHorizontalInput)ActionEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SetCommandGrab:
					SASetCommandGrabNode SetCommandGrab_node_ActionEnd = graph.AddNode<SASetCommandGrabNode>();
					GetPort("ActionEnd").Connect(SetCommandGrab_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SetCommandGrab_node_ActionEnd, assetPath);
					variableCount += SetCommandGrab_node_ActionEnd.SetData((SASetCommandGrab)ActionEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.CameraPunchId:
					SACameraPunchNode CameraPunchId_node_ActionEnd = graph.AddNode<SACameraPunchNode>();
					GetPort("ActionEnd").Connect(CameraPunchId_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CameraPunchId_node_ActionEnd, assetPath);
					variableCount += CameraPunchId_node_ActionEnd.SetData((SACameraPunch)ActionEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SpawnAgent2Id:
					SASpawnAgent2Node SpawnAgent2Id_node_ActionEnd = graph.AddNode<SASpawnAgent2Node>();
					GetPort("ActionEnd").Connect(SpawnAgent2Id_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpawnAgent2Id_node_ActionEnd, assetPath);
					variableCount += SpawnAgent2Id_node_ActionEnd.SetData((SASpawnAgent2)ActionEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.ManipDecorChainId:
					SAManipDecorChainNode ManipDecorChainId_node_ActionEnd = graph.AddNode<SAManipDecorChainNode>();
					GetPort("ActionEnd").Connect(ManipDecorChainId_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ManipDecorChainId_node_ActionEnd, assetPath);
					variableCount += ManipDecorChainId_node_ActionEnd.SetData((SAManipDecorChain)ActionEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.UpdateHitboxesId:
					SAUpdateHitboxesNode UpdateHitboxesId_node_ActionEnd = graph.AddNode<SAUpdateHitboxesNode>();
					GetPort("ActionEnd").Connect(UpdateHitboxesId_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(UpdateHitboxesId_node_ActionEnd, assetPath);
					variableCount += UpdateHitboxesId_node_ActionEnd.SetData((SAUpdateHitboxes)ActionEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.SampleAnimId:
					SASampleAnimNode SampleAnimId_node_ActionEnd = graph.AddNode<SASampleAnimNode>();
					GetPort("ActionEnd").Connect(SampleAnimId_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SampleAnimId_node_ActionEnd, assetPath);
					variableCount += SampleAnimId_node_ActionEnd.SetData((SASampleAnim)ActionEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.ForceExtraInputId:
					SAForceExtraInputCheckNode ForceExtraInputId_node_ActionEnd = graph.AddNode<SAForceExtraInputCheckNode>();
					GetPort("ActionEnd").Connect(ForceExtraInputId_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ForceExtraInputId_node_ActionEnd, assetPath);
					variableCount += ForceExtraInputId_node_ActionEnd.SetData((SAForceExtraInputCheck)ActionEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case StateAction.TypeId.LaunchGrabbedCustomId:
					SALaunchGrabbedCustomNode LaunchGrabbedCustomId_node_ActionEnd = graph.AddNode<SALaunchGrabbedCustomNode>();
					GetPort("ActionEnd").Connect(LaunchGrabbedCustomId_node_ActionEnd.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LaunchGrabbedCustomId_node_ActionEnd, assetPath);
					variableCount += LaunchGrabbedCustomId_node_ActionEnd.SetData((SALaunchGrabbedCustom)ActionEnd, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
			}
			
			return variableCount;
		}
		
		public new SATimingTweak GetData()
		{
			SATimingTweak objToReturn = new SATimingTweak();
			objToReturn.TID = TypeId.TimingTweakId;
			objToReturn.Version = Version;
			objToReturn.AnimId = AnimId;
			objToReturn.RootAnimId = RootAnimId;
			if (GetPort("AnimCfg").ConnectionCount > 0)
			{
				AnimConfigNode AnimConfig_Node = (AnimConfigNode)GetPort("AnimCfg").GetConnection(0).node;
				objToReturn.AnimCfg = AnimConfig_Node.GetData();
			}
			if (GetPort("AnimFrames").ConnectionCount > 0)
			{
				FloatSourceNode FloatSource_Node = (FloatSourceNode)GetPort("AnimFrames").GetConnection(0).node;
				switch (FloatSource_Node.TID)
				{
					case FloatSource.TypeId.AgentId:
						FSAgentNode AgentId_FloatSource_Node = (FSAgentNode)GetPort("AnimFrames").GetConnection(0).node;
						objToReturn.AnimFrames = AgentId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.BonesId:
						FSBonesNode BonesId_FloatSource_Node = (FSBonesNode)GetPort("AnimFrames").GetConnection(0).node;
						objToReturn.AnimFrames = BonesId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AttackId:
						FSAttackNode AttackId_FloatSource_Node = (FSAttackNode)GetPort("AnimFrames").GetConnection(0).node;
						objToReturn.AnimFrames = AttackId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FrameId:
						FSFrameNode FrameId_FloatSource_Node = (FSFrameNode)GetPort("AnimFrames").GetConnection(0).node;
						objToReturn.AnimFrames = FrameId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.InputId:
						FSInputNode InputId_FloatSource_Node = (FSInputNode)GetPort("AnimFrames").GetConnection(0).node;
						objToReturn.AnimFrames = InputId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FuncId:
						FSFuncNode FuncId_FloatSource_Node = (FSFuncNode)GetPort("AnimFrames").GetConnection(0).node;
						objToReturn.AnimFrames = FuncId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.MovementId:
						FSMovementNode MovementId_FloatSource_Node = (FSMovementNode)GetPort("AnimFrames").GetConnection(0).node;
						objToReturn.AnimFrames = MovementId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CombatId:
						FSCombatNode CombatId_FloatSource_Node = (FSCombatNode)GetPort("AnimFrames").GetConnection(0).node;
						objToReturn.AnimFrames = CombatId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.GrabsId:
						FSGrabsNode GrabsId_FloatSource_Node = (FSGrabsNode)GetPort("AnimFrames").GetConnection(0).node;
						objToReturn.AnimFrames = GrabsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.DataId:
						FSDataNode DataId_FloatSource_Node = (FSDataNode)GetPort("AnimFrames").GetConnection(0).node;
						objToReturn.AnimFrames = DataId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ScratchId:
						FSScratchNode ScratchId_FloatSource_Node = (FSScratchNode)GetPort("AnimFrames").GetConnection(0).node;
						objToReturn.AnimFrames = ScratchId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AnimId:
						FSAnimNode AnimId_FloatSource_Node = (FSAnimNode)GetPort("AnimFrames").GetConnection(0).node;
						objToReturn.AnimFrames = AnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SpeedId:
						FSSpeedNode SpeedId_FloatSource_Node = (FSSpeedNode)GetPort("AnimFrames").GetConnection(0).node;
						objToReturn.AnimFrames = SpeedId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.PhysicsId:
						FSPhysicsNode PhysicsId_FloatSource_Node = (FSPhysicsNode)GetPort("AnimFrames").GetConnection(0).node;
						objToReturn.AnimFrames = PhysicsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CollisionId:
						FSCollisionNode CollisionId_FloatSource_Node = (FSCollisionNode)GetPort("AnimFrames").GetConnection(0).node;
						objToReturn.AnimFrames = CollisionId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.TimerId:
						FSTimerNode TimerId_FloatSource_Node = (FSTimerNode)GetPort("AnimFrames").GetConnection(0).node;
						objToReturn.AnimFrames = TimerId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.LagId:
						FSLagNode LagId_FloatSource_Node = (FSLagNode)GetPort("AnimFrames").GetConnection(0).node;
						objToReturn.AnimFrames = LagId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.EffectsId:
						FSEffectsNode EffectsId_FloatSource_Node = (FSEffectsNode)GetPort("AnimFrames").GetConnection(0).node;
						objToReturn.AnimFrames = EffectsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ColorsId:
						FSColorsNode ColorsId_FloatSource_Node = (FSColorsNode)GetPort("AnimFrames").GetConnection(0).node;
						objToReturn.AnimFrames = ColorsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.OnHitId:
						FSOnHitNode OnHitId_FloatSource_Node = (FSOnHitNode)GetPort("AnimFrames").GetConnection(0).node;
						objToReturn.AnimFrames = OnHitId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RandomId:
						FSRandomNode RandomId_FloatSource_Node = (FSRandomNode)GetPort("AnimFrames").GetConnection(0).node;
						objToReturn.AnimFrames = RandomId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CameraId:
						FSCameraInfoNode CameraId_FloatSource_Node = (FSCameraInfoNode)GetPort("AnimFrames").GetConnection(0).node;
						objToReturn.AnimFrames = CameraId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SportsId:
						FSSportsNode SportsId_FloatSource_Node = (FSSportsNode)GetPort("AnimFrames").GetConnection(0).node;
						objToReturn.AnimFrames = SportsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.Vector2Mag:
						FSVector2MagNode Vector2Mag_FloatSource_Node = (FSVector2MagNode)GetPort("AnimFrames").GetConnection(0).node;
						objToReturn.AnimFrames = Vector2Mag_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CPUHelpId:
						FSCpuHelpNode CPUHelpId_FloatSource_Node = (FSCpuHelpNode)GetPort("AnimFrames").GetConnection(0).node;
						objToReturn.AnimFrames = CPUHelpId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ItemId:
						FSItemNode ItemId_FloatSource_Node = (FSItemNode)GetPort("AnimFrames").GetConnection(0).node;
						objToReturn.AnimFrames = ItemId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ModeId:
						FSModeNode ModeId_FloatSource_Node = (FSModeNode)GetPort("AnimFrames").GetConnection(0).node;
						objToReturn.AnimFrames = ModeId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.JumpsId:
						FSJumpsNode JumpsId_FloatSource_Node = (FSJumpsNode)GetPort("AnimFrames").GetConnection(0).node;
						objToReturn.AnimFrames = JumpsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RootAnimId:
						FSRootAnimNode RootAnimId_FloatSource_Node = (FSRootAnimNode)GetPort("AnimFrames").GetConnection(0).node;
						objToReturn.AnimFrames = RootAnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FloatId:
						FSValueNode FloatId_FloatSource_Node = (FSValueNode)GetPort("AnimFrames").GetConnection(0).node;
						objToReturn.AnimFrames = FloatId_FloatSource_Node.GetData();
					break;
				}
			}
			if (GetPort("StateFrames").ConnectionCount > 0)
			{
				FloatSourceNode FloatSource_Node = (FloatSourceNode)GetPort("StateFrames").GetConnection(0).node;
				switch (FloatSource_Node.TID)
				{
					case FloatSource.TypeId.AgentId:
						FSAgentNode AgentId_FloatSource_Node = (FSAgentNode)GetPort("StateFrames").GetConnection(0).node;
						objToReturn.StateFrames = AgentId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.BonesId:
						FSBonesNode BonesId_FloatSource_Node = (FSBonesNode)GetPort("StateFrames").GetConnection(0).node;
						objToReturn.StateFrames = BonesId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AttackId:
						FSAttackNode AttackId_FloatSource_Node = (FSAttackNode)GetPort("StateFrames").GetConnection(0).node;
						objToReturn.StateFrames = AttackId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FrameId:
						FSFrameNode FrameId_FloatSource_Node = (FSFrameNode)GetPort("StateFrames").GetConnection(0).node;
						objToReturn.StateFrames = FrameId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.InputId:
						FSInputNode InputId_FloatSource_Node = (FSInputNode)GetPort("StateFrames").GetConnection(0).node;
						objToReturn.StateFrames = InputId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FuncId:
						FSFuncNode FuncId_FloatSource_Node = (FSFuncNode)GetPort("StateFrames").GetConnection(0).node;
						objToReturn.StateFrames = FuncId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.MovementId:
						FSMovementNode MovementId_FloatSource_Node = (FSMovementNode)GetPort("StateFrames").GetConnection(0).node;
						objToReturn.StateFrames = MovementId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CombatId:
						FSCombatNode CombatId_FloatSource_Node = (FSCombatNode)GetPort("StateFrames").GetConnection(0).node;
						objToReturn.StateFrames = CombatId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.GrabsId:
						FSGrabsNode GrabsId_FloatSource_Node = (FSGrabsNode)GetPort("StateFrames").GetConnection(0).node;
						objToReturn.StateFrames = GrabsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.DataId:
						FSDataNode DataId_FloatSource_Node = (FSDataNode)GetPort("StateFrames").GetConnection(0).node;
						objToReturn.StateFrames = DataId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ScratchId:
						FSScratchNode ScratchId_FloatSource_Node = (FSScratchNode)GetPort("StateFrames").GetConnection(0).node;
						objToReturn.StateFrames = ScratchId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AnimId:
						FSAnimNode AnimId_FloatSource_Node = (FSAnimNode)GetPort("StateFrames").GetConnection(0).node;
						objToReturn.StateFrames = AnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SpeedId:
						FSSpeedNode SpeedId_FloatSource_Node = (FSSpeedNode)GetPort("StateFrames").GetConnection(0).node;
						objToReturn.StateFrames = SpeedId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.PhysicsId:
						FSPhysicsNode PhysicsId_FloatSource_Node = (FSPhysicsNode)GetPort("StateFrames").GetConnection(0).node;
						objToReturn.StateFrames = PhysicsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CollisionId:
						FSCollisionNode CollisionId_FloatSource_Node = (FSCollisionNode)GetPort("StateFrames").GetConnection(0).node;
						objToReturn.StateFrames = CollisionId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.TimerId:
						FSTimerNode TimerId_FloatSource_Node = (FSTimerNode)GetPort("StateFrames").GetConnection(0).node;
						objToReturn.StateFrames = TimerId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.LagId:
						FSLagNode LagId_FloatSource_Node = (FSLagNode)GetPort("StateFrames").GetConnection(0).node;
						objToReturn.StateFrames = LagId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.EffectsId:
						FSEffectsNode EffectsId_FloatSource_Node = (FSEffectsNode)GetPort("StateFrames").GetConnection(0).node;
						objToReturn.StateFrames = EffectsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ColorsId:
						FSColorsNode ColorsId_FloatSource_Node = (FSColorsNode)GetPort("StateFrames").GetConnection(0).node;
						objToReturn.StateFrames = ColorsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.OnHitId:
						FSOnHitNode OnHitId_FloatSource_Node = (FSOnHitNode)GetPort("StateFrames").GetConnection(0).node;
						objToReturn.StateFrames = OnHitId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RandomId:
						FSRandomNode RandomId_FloatSource_Node = (FSRandomNode)GetPort("StateFrames").GetConnection(0).node;
						objToReturn.StateFrames = RandomId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CameraId:
						FSCameraInfoNode CameraId_FloatSource_Node = (FSCameraInfoNode)GetPort("StateFrames").GetConnection(0).node;
						objToReturn.StateFrames = CameraId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SportsId:
						FSSportsNode SportsId_FloatSource_Node = (FSSportsNode)GetPort("StateFrames").GetConnection(0).node;
						objToReturn.StateFrames = SportsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.Vector2Mag:
						FSVector2MagNode Vector2Mag_FloatSource_Node = (FSVector2MagNode)GetPort("StateFrames").GetConnection(0).node;
						objToReturn.StateFrames = Vector2Mag_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CPUHelpId:
						FSCpuHelpNode CPUHelpId_FloatSource_Node = (FSCpuHelpNode)GetPort("StateFrames").GetConnection(0).node;
						objToReturn.StateFrames = CPUHelpId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ItemId:
						FSItemNode ItemId_FloatSource_Node = (FSItemNode)GetPort("StateFrames").GetConnection(0).node;
						objToReturn.StateFrames = ItemId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ModeId:
						FSModeNode ModeId_FloatSource_Node = (FSModeNode)GetPort("StateFrames").GetConnection(0).node;
						objToReturn.StateFrames = ModeId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.JumpsId:
						FSJumpsNode JumpsId_FloatSource_Node = (FSJumpsNode)GetPort("StateFrames").GetConnection(0).node;
						objToReturn.StateFrames = JumpsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RootAnimId:
						FSRootAnimNode RootAnimId_FloatSource_Node = (FSRootAnimNode)GetPort("StateFrames").GetConnection(0).node;
						objToReturn.StateFrames = RootAnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FloatId:
						FSValueNode FloatId_FloatSource_Node = (FSValueNode)GetPort("StateFrames").GetConnection(0).node;
						objToReturn.StateFrames = FloatId_FloatSource_Node.GetData();
					break;
				}
			}
			if (GetPort("FramesToA").ConnectionCount > 0)
			{
				FloatSourceNode FloatSource_Node = (FloatSourceNode)GetPort("FramesToA").GetConnection(0).node;
				switch (FloatSource_Node.TID)
				{
					case FloatSource.TypeId.AgentId:
						FSAgentNode AgentId_FloatSource_Node = (FSAgentNode)GetPort("FramesToA").GetConnection(0).node;
						objToReturn.FramesToA = AgentId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.BonesId:
						FSBonesNode BonesId_FloatSource_Node = (FSBonesNode)GetPort("FramesToA").GetConnection(0).node;
						objToReturn.FramesToA = BonesId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AttackId:
						FSAttackNode AttackId_FloatSource_Node = (FSAttackNode)GetPort("FramesToA").GetConnection(0).node;
						objToReturn.FramesToA = AttackId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FrameId:
						FSFrameNode FrameId_FloatSource_Node = (FSFrameNode)GetPort("FramesToA").GetConnection(0).node;
						objToReturn.FramesToA = FrameId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.InputId:
						FSInputNode InputId_FloatSource_Node = (FSInputNode)GetPort("FramesToA").GetConnection(0).node;
						objToReturn.FramesToA = InputId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FuncId:
						FSFuncNode FuncId_FloatSource_Node = (FSFuncNode)GetPort("FramesToA").GetConnection(0).node;
						objToReturn.FramesToA = FuncId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.MovementId:
						FSMovementNode MovementId_FloatSource_Node = (FSMovementNode)GetPort("FramesToA").GetConnection(0).node;
						objToReturn.FramesToA = MovementId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CombatId:
						FSCombatNode CombatId_FloatSource_Node = (FSCombatNode)GetPort("FramesToA").GetConnection(0).node;
						objToReturn.FramesToA = CombatId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.GrabsId:
						FSGrabsNode GrabsId_FloatSource_Node = (FSGrabsNode)GetPort("FramesToA").GetConnection(0).node;
						objToReturn.FramesToA = GrabsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.DataId:
						FSDataNode DataId_FloatSource_Node = (FSDataNode)GetPort("FramesToA").GetConnection(0).node;
						objToReturn.FramesToA = DataId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ScratchId:
						FSScratchNode ScratchId_FloatSource_Node = (FSScratchNode)GetPort("FramesToA").GetConnection(0).node;
						objToReturn.FramesToA = ScratchId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AnimId:
						FSAnimNode AnimId_FloatSource_Node = (FSAnimNode)GetPort("FramesToA").GetConnection(0).node;
						objToReturn.FramesToA = AnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SpeedId:
						FSSpeedNode SpeedId_FloatSource_Node = (FSSpeedNode)GetPort("FramesToA").GetConnection(0).node;
						objToReturn.FramesToA = SpeedId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.PhysicsId:
						FSPhysicsNode PhysicsId_FloatSource_Node = (FSPhysicsNode)GetPort("FramesToA").GetConnection(0).node;
						objToReturn.FramesToA = PhysicsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CollisionId:
						FSCollisionNode CollisionId_FloatSource_Node = (FSCollisionNode)GetPort("FramesToA").GetConnection(0).node;
						objToReturn.FramesToA = CollisionId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.TimerId:
						FSTimerNode TimerId_FloatSource_Node = (FSTimerNode)GetPort("FramesToA").GetConnection(0).node;
						objToReturn.FramesToA = TimerId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.LagId:
						FSLagNode LagId_FloatSource_Node = (FSLagNode)GetPort("FramesToA").GetConnection(0).node;
						objToReturn.FramesToA = LagId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.EffectsId:
						FSEffectsNode EffectsId_FloatSource_Node = (FSEffectsNode)GetPort("FramesToA").GetConnection(0).node;
						objToReturn.FramesToA = EffectsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ColorsId:
						FSColorsNode ColorsId_FloatSource_Node = (FSColorsNode)GetPort("FramesToA").GetConnection(0).node;
						objToReturn.FramesToA = ColorsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.OnHitId:
						FSOnHitNode OnHitId_FloatSource_Node = (FSOnHitNode)GetPort("FramesToA").GetConnection(0).node;
						objToReturn.FramesToA = OnHitId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RandomId:
						FSRandomNode RandomId_FloatSource_Node = (FSRandomNode)GetPort("FramesToA").GetConnection(0).node;
						objToReturn.FramesToA = RandomId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CameraId:
						FSCameraInfoNode CameraId_FloatSource_Node = (FSCameraInfoNode)GetPort("FramesToA").GetConnection(0).node;
						objToReturn.FramesToA = CameraId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SportsId:
						FSSportsNode SportsId_FloatSource_Node = (FSSportsNode)GetPort("FramesToA").GetConnection(0).node;
						objToReturn.FramesToA = SportsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.Vector2Mag:
						FSVector2MagNode Vector2Mag_FloatSource_Node = (FSVector2MagNode)GetPort("FramesToA").GetConnection(0).node;
						objToReturn.FramesToA = Vector2Mag_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CPUHelpId:
						FSCpuHelpNode CPUHelpId_FloatSource_Node = (FSCpuHelpNode)GetPort("FramesToA").GetConnection(0).node;
						objToReturn.FramesToA = CPUHelpId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ItemId:
						FSItemNode ItemId_FloatSource_Node = (FSItemNode)GetPort("FramesToA").GetConnection(0).node;
						objToReturn.FramesToA = ItemId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ModeId:
						FSModeNode ModeId_FloatSource_Node = (FSModeNode)GetPort("FramesToA").GetConnection(0).node;
						objToReturn.FramesToA = ModeId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.JumpsId:
						FSJumpsNode JumpsId_FloatSource_Node = (FSJumpsNode)GetPort("FramesToA").GetConnection(0).node;
						objToReturn.FramesToA = JumpsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RootAnimId:
						FSRootAnimNode RootAnimId_FloatSource_Node = (FSRootAnimNode)GetPort("FramesToA").GetConnection(0).node;
						objToReturn.FramesToA = RootAnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FloatId:
						FSValueNode FloatId_FloatSource_Node = (FSValueNode)GetPort("FramesToA").GetConnection(0).node;
						objToReturn.FramesToA = FloatId_FloatSource_Node.GetData();
					break;
				}
			}
			if (GetPort("FramesToB").ConnectionCount > 0)
			{
				FloatSourceNode FloatSource_Node = (FloatSourceNode)GetPort("FramesToB").GetConnection(0).node;
				switch (FloatSource_Node.TID)
				{
					case FloatSource.TypeId.AgentId:
						FSAgentNode AgentId_FloatSource_Node = (FSAgentNode)GetPort("FramesToB").GetConnection(0).node;
						objToReturn.FramesToB = AgentId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.BonesId:
						FSBonesNode BonesId_FloatSource_Node = (FSBonesNode)GetPort("FramesToB").GetConnection(0).node;
						objToReturn.FramesToB = BonesId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AttackId:
						FSAttackNode AttackId_FloatSource_Node = (FSAttackNode)GetPort("FramesToB").GetConnection(0).node;
						objToReturn.FramesToB = AttackId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FrameId:
						FSFrameNode FrameId_FloatSource_Node = (FSFrameNode)GetPort("FramesToB").GetConnection(0).node;
						objToReturn.FramesToB = FrameId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.InputId:
						FSInputNode InputId_FloatSource_Node = (FSInputNode)GetPort("FramesToB").GetConnection(0).node;
						objToReturn.FramesToB = InputId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FuncId:
						FSFuncNode FuncId_FloatSource_Node = (FSFuncNode)GetPort("FramesToB").GetConnection(0).node;
						objToReturn.FramesToB = FuncId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.MovementId:
						FSMovementNode MovementId_FloatSource_Node = (FSMovementNode)GetPort("FramesToB").GetConnection(0).node;
						objToReturn.FramesToB = MovementId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CombatId:
						FSCombatNode CombatId_FloatSource_Node = (FSCombatNode)GetPort("FramesToB").GetConnection(0).node;
						objToReturn.FramesToB = CombatId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.GrabsId:
						FSGrabsNode GrabsId_FloatSource_Node = (FSGrabsNode)GetPort("FramesToB").GetConnection(0).node;
						objToReturn.FramesToB = GrabsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.DataId:
						FSDataNode DataId_FloatSource_Node = (FSDataNode)GetPort("FramesToB").GetConnection(0).node;
						objToReturn.FramesToB = DataId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ScratchId:
						FSScratchNode ScratchId_FloatSource_Node = (FSScratchNode)GetPort("FramesToB").GetConnection(0).node;
						objToReturn.FramesToB = ScratchId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AnimId:
						FSAnimNode AnimId_FloatSource_Node = (FSAnimNode)GetPort("FramesToB").GetConnection(0).node;
						objToReturn.FramesToB = AnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SpeedId:
						FSSpeedNode SpeedId_FloatSource_Node = (FSSpeedNode)GetPort("FramesToB").GetConnection(0).node;
						objToReturn.FramesToB = SpeedId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.PhysicsId:
						FSPhysicsNode PhysicsId_FloatSource_Node = (FSPhysicsNode)GetPort("FramesToB").GetConnection(0).node;
						objToReturn.FramesToB = PhysicsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CollisionId:
						FSCollisionNode CollisionId_FloatSource_Node = (FSCollisionNode)GetPort("FramesToB").GetConnection(0).node;
						objToReturn.FramesToB = CollisionId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.TimerId:
						FSTimerNode TimerId_FloatSource_Node = (FSTimerNode)GetPort("FramesToB").GetConnection(0).node;
						objToReturn.FramesToB = TimerId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.LagId:
						FSLagNode LagId_FloatSource_Node = (FSLagNode)GetPort("FramesToB").GetConnection(0).node;
						objToReturn.FramesToB = LagId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.EffectsId:
						FSEffectsNode EffectsId_FloatSource_Node = (FSEffectsNode)GetPort("FramesToB").GetConnection(0).node;
						objToReturn.FramesToB = EffectsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ColorsId:
						FSColorsNode ColorsId_FloatSource_Node = (FSColorsNode)GetPort("FramesToB").GetConnection(0).node;
						objToReturn.FramesToB = ColorsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.OnHitId:
						FSOnHitNode OnHitId_FloatSource_Node = (FSOnHitNode)GetPort("FramesToB").GetConnection(0).node;
						objToReturn.FramesToB = OnHitId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RandomId:
						FSRandomNode RandomId_FloatSource_Node = (FSRandomNode)GetPort("FramesToB").GetConnection(0).node;
						objToReturn.FramesToB = RandomId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CameraId:
						FSCameraInfoNode CameraId_FloatSource_Node = (FSCameraInfoNode)GetPort("FramesToB").GetConnection(0).node;
						objToReturn.FramesToB = CameraId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SportsId:
						FSSportsNode SportsId_FloatSource_Node = (FSSportsNode)GetPort("FramesToB").GetConnection(0).node;
						objToReturn.FramesToB = SportsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.Vector2Mag:
						FSVector2MagNode Vector2Mag_FloatSource_Node = (FSVector2MagNode)GetPort("FramesToB").GetConnection(0).node;
						objToReturn.FramesToB = Vector2Mag_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CPUHelpId:
						FSCpuHelpNode CPUHelpId_FloatSource_Node = (FSCpuHelpNode)GetPort("FramesToB").GetConnection(0).node;
						objToReturn.FramesToB = CPUHelpId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ItemId:
						FSItemNode ItemId_FloatSource_Node = (FSItemNode)GetPort("FramesToB").GetConnection(0).node;
						objToReturn.FramesToB = ItemId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ModeId:
						FSModeNode ModeId_FloatSource_Node = (FSModeNode)GetPort("FramesToB").GetConnection(0).node;
						objToReturn.FramesToB = ModeId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.JumpsId:
						FSJumpsNode JumpsId_FloatSource_Node = (FSJumpsNode)GetPort("FramesToB").GetConnection(0).node;
						objToReturn.FramesToB = JumpsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RootAnimId:
						FSRootAnimNode RootAnimId_FloatSource_Node = (FSRootAnimNode)GetPort("FramesToB").GetConnection(0).node;
						objToReturn.FramesToB = RootAnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FloatId:
						FSValueNode FloatId_FloatSource_Node = (FSValueNode)GetPort("FramesToB").GetConnection(0).node;
						objToReturn.FramesToB = FloatId_FloatSource_Node.GetData();
					break;
				}
			}
			if (GetPort("ActionA").ConnectionCount > 0)
			{
				StateActionNode StateAction_Node = (StateActionNode)GetPort("ActionA").GetConnection(0).node;
				switch (StateAction_Node.TID)
				{
					case StateAction.TypeId.DebugId:
						SADebugMessageNode DebugId_StateAction_Node = (SADebugMessageNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = DebugId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.PlayAnimId:
						SAPlayAnimNode PlayAnimId_StateAction_Node = (SAPlayAnimNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = PlayAnimId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.RootAnimId:
						SAPlayRootAnimNode RootAnimId_StateAction_Node = (SAPlayRootAnimNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = RootAnimId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SnapAnimWeightsId:
						SASnapAnimWeightsNode SnapAnimWeightsId_StateAction_Node = (SASnapAnimWeightsNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SnapAnimWeightsId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.StandardInputId:
						SAStandardInputNode StandardInputId_StateAction_Node = (SAStandardInputNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = StandardInputId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.InputId:
						SAInputActionNode InputId_StateAction_Node = (SAInputActionNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = InputId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.DeactInputId:
						SADeactivateInputActionNode DeactInputId_StateAction_Node = (SADeactivateInputActionNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = DeactInputId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.InputEventFromFrameId:
						SAAddInputEventFromFrameNode InputEventFromFrameId_StateAction_Node = (SAAddInputEventFromFrameNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = InputEventFromFrameId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.CancelStateId:
						SACancelToStateNode CancelStateId_StateAction_Node = (SACancelToStateNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = CancelStateId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.CustomCallId:
						SACustomCallNode CustomCallId_StateAction_Node = (SACustomCallNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = CustomCallId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.TimerId:
						SATimedActionNode TimerId_StateAction_Node = (SATimedActionNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = TimerId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.OrderId:
						SAOrderedSensitiveNode OrderId_StateAction_Node = (SAOrderedSensitiveNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = OrderId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.ProxyId:
						SAProxyMoveNode ProxyId_StateAction_Node = (SAProxyMoveNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = ProxyId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.CheckId:
						SACheckThingNode CheckId_StateAction_Node = (SACheckThingNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = CheckId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.ActiveActionId:
						SAActiveActionNode ActiveActionId_StateAction_Node = (SAActiveActionNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = ActiveActionId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.DeactivateActionId:
						SADeactivateActionNode DeactivateActionId_StateAction_Node = (SADeactivateActionNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = DeactivateActionId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SetFloatId:
						SASetFloatTargetNode SetFloatId_StateAction_Node = (SASetFloatTargetNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SetFloatId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.OnBounceId:
						SAOnBounceNode OnBounceId_StateAction_Node = (SAOnBounceNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = OnBounceId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.OnLeaveEdgeId:
						SAOnLeaveEdgeNode OnLeaveEdgeId_StateAction_Node = (SAOnLeaveEdgeNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = OnLeaveEdgeId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.OnStoppedAtEdgeId:
						SAOnStoppedAtLedgeNode OnStoppedAtEdgeId_StateAction_Node = (SAOnStoppedAtLedgeNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = OnStoppedAtEdgeId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.OnLandId:
						SAOnLandNode OnLandId_StateAction_Node = (SAOnLandNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = OnLandId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.OnCancelId:
						SAOnCancelNode OnCancelId_StateAction_Node = (SAOnCancelNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = OnCancelId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.RefreshAtkId:
						SARefreshAttackNode RefreshAtkId_StateAction_Node = (SARefreshAttackNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = RefreshAtkId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.EndAtkId:
						SAEndAttackNode EndAtkId_StateAction_Node = (SAEndAttackNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = EndAtkId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SetHitboxCountId:
						SASetHitboxCountNode SetHitboxCountId_StateAction_Node = (SASetHitboxCountNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SetHitboxCountId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.ConfigHitboxId:
						SAConfigHitboxNode ConfigHitboxId_StateAction_Node = (SAConfigHitboxNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = ConfigHitboxId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SetAtkPropId:
						SASetAttackPropNode SetAtkPropId_StateAction_Node = (SASetAttackPropNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SetAtkPropId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.ManipHitboxId:
						SAManipHitboxNode ManipHitboxId_StateAction_Node = (SAManipHitboxNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = ManipHitboxId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.UpdateHurtsetId:
						SAUpdateHurtboxesNode UpdateHurtsetId_StateAction_Node = (SAUpdateHurtboxesNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = UpdateHurtsetId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SetupHurtsetId:
						SASetupHurtboxesNode SetupHurtsetId_StateAction_Node = (SASetupHurtboxesNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SetupHurtsetId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.ManipHurtboxId:
						SAManipHurtboxNode ManipHurtboxId_StateAction_Node = (SAManipHurtboxNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = ManipHurtboxId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.BoneStateId:
						SABoneStateNode BoneStateId_StateAction_Node = (SABoneStateNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = BoneStateId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.BoneScaleId:
						SABoneScaleNode BoneScaleId_StateAction_Node = (SABoneScaleNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = BoneScaleId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SpawnAgentId:
						SASpawnAgentNode SpawnAgentId_StateAction_Node = (SASpawnAgentNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SpawnAgentId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.LocalFXId:
						SALocalFXNode LocalFXId_StateAction_Node = (SALocalFXNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = LocalFXId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SpawnFXId:
						SASpawnFXNode SpawnFXId_StateAction_Node = (SASpawnFXNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SpawnFXId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.HitboxFXId:
						SASetHitboxFXNode HitboxFXId_StateAction_Node = (SASetHitboxFXNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = HitboxFXId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SFXId:
						SAPlaySFXNode SFXId_StateAction_Node = (SAPlaySFXNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SFXId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.HitboxSFXId:
						SASetHitboxSFXNode HitboxSFXId_StateAction_Node = (SASetHitboxSFXNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = HitboxSFXId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.ColorTintId:
						SAColorTintNode ColorTintId_StateAction_Node = (SAColorTintNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = ColorTintId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.FindFloorId:
						SAFindFloorNode FindFloorId_StateAction_Node = (SAFindFloorNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = FindFloorId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.HurtGrabbedId:
						SAHurtGrabbedNode HurtGrabbedId_StateAction_Node = (SAHurtGrabbedNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = HurtGrabbedId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.LaunchGrabbedId:
						SALaunchGrabbedNode LaunchGrabbedId_StateAction_Node = (SALaunchGrabbedNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = LaunchGrabbedId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.StateCancelGrabbedId:
						SAStateCancelGrabbedNode StateCancelGrabbedId_StateAction_Node = (SAStateCancelGrabbedNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = StateCancelGrabbedId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.EndGrabId:
						SAEndGrabNode EndGrabId_StateAction_Node = (SAEndGrabNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = EndGrabId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.GrabNotifyEscapeId:
						SAGrabNotifyEscapeNode GrabNotifyEscapeId_StateAction_Node = (SAGrabNotifyEscapeNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = GrabNotifyEscapeId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.IgnoreGrabbedId:
						SAIgnoreGrabbedNode IgnoreGrabbedId_StateAction_Node = (SAIgnoreGrabbedNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = IgnoreGrabbedId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.EventKOId:
						SAEventKONode EventKOId_StateAction_Node = (SAEventKONode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = EventKOId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.EventKOGrabbedId:
						SAEventKOGrabbedNode EventKOGrabbedId_StateAction_Node = (SAEventKOGrabbedNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = EventKOGrabbedId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.CameraShakeId:
						SACameraShakeNode CameraShakeId_StateAction_Node = (SACameraShakeNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = CameraShakeId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.ResetOnHitId:
						SAResetOnHitsNode ResetOnHitId_StateAction_Node = (SAResetOnHitsNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = ResetOnHitId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.OnHitId:
						SAOnHitNode OnHitId_StateAction_Node = (SAOnHitNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = OnHitId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.FastForwardId:
						SAFastForwardStateNode FastForwardId_StateAction_Node = (SAFastForwardStateNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = FastForwardId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.TimingTweakId:
						SATimingTweakNode TimingTweakId_StateAction_Node = (SATimingTweakNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = TimingTweakId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.MapAnimId:
						SAMapAnimationNode MapAnimId_StateAction_Node = (SAMapAnimationNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = MapAnimId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.AlterMoveDtId:
						SAAlterMoveDTNode AlterMoveDtId_StateAction_Node = (SAAlterMoveDTNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = AlterMoveDtId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.AlterMoveVelId:
						SAAlterMoveVelNode AlterMoveVelId_StateAction_Node = (SAAlterMoveVelNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = AlterMoveVelId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SetStagePartId:
						SASetStagePartNode SetStagePartId_StateAction_Node = (SASetStagePartNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SetStagePartId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SetStagePartsDefaultId:
						SASetStagePartsDefaultNode SetStagePartsDefaultId_StateAction_Node = (SASetStagePartsDefaultNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SetStagePartsDefaultId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.JumpId:
						SAJumpNode JumpId_StateAction_Node = (SAJumpNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = JumpId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.StopJumpId:
						SAStopJumpNode StopJumpId_StateAction_Node = (SAStopJumpNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = StopJumpId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.ManageAirJumpId:
						SAManageAirJumpNode ManageAirJumpId_StateAction_Node = (SAManageAirJumpNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = ManageAirJumpId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.LeaveGroundId:
						SALeaveGroundNode LeaveGroundId_StateAction_Node = (SALeaveGroundNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = LeaveGroundId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.UnhogEdgeId:
						SAUnHogEdgeNode UnhogEdgeId_StateAction_Node = (SAUnHogEdgeNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = UnhogEdgeId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SFXTimelineId:
						SAPlaySFXTimelineNode SFXTimelineId_StateAction_Node = (SAPlaySFXTimelineNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SFXTimelineId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.FindLastHorizontalInputId:
						SAFindLastHorizontalInputNode FindLastHorizontalInputId_StateAction_Node = (SAFindLastHorizontalInputNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = FindLastHorizontalInputId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SetCommandGrab:
						SASetCommandGrabNode SetCommandGrab_StateAction_Node = (SASetCommandGrabNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SetCommandGrab_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.CameraPunchId:
						SACameraPunchNode CameraPunchId_StateAction_Node = (SACameraPunchNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = CameraPunchId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SpawnAgent2Id:
						SASpawnAgent2Node SpawnAgent2Id_StateAction_Node = (SASpawnAgent2Node)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SpawnAgent2Id_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.ManipDecorChainId:
						SAManipDecorChainNode ManipDecorChainId_StateAction_Node = (SAManipDecorChainNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = ManipDecorChainId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.UpdateHitboxesId:
						SAUpdateHitboxesNode UpdateHitboxesId_StateAction_Node = (SAUpdateHitboxesNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = UpdateHitboxesId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SampleAnimId:
						SASampleAnimNode SampleAnimId_StateAction_Node = (SASampleAnimNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = SampleAnimId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.ForceExtraInputId:
						SAForceExtraInputCheckNode ForceExtraInputId_StateAction_Node = (SAForceExtraInputCheckNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = ForceExtraInputId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.LaunchGrabbedCustomId:
						SALaunchGrabbedCustomNode LaunchGrabbedCustomId_StateAction_Node = (SALaunchGrabbedCustomNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = LaunchGrabbedCustomId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.BaseIdentifier:
						StateActionNode BaseIdentifier_StateAction_Node = (StateActionNode)GetPort("ActionA").GetConnection(0).node;
						objToReturn.ActionA = BaseIdentifier_StateAction_Node.GetData();
					break;
				}
			}
			if (GetPort("ActionB").ConnectionCount > 0)
			{
				StateActionNode StateAction_Node = (StateActionNode)GetPort("ActionB").GetConnection(0).node;
				switch (StateAction_Node.TID)
				{
					case StateAction.TypeId.DebugId:
						SADebugMessageNode DebugId_StateAction_Node = (SADebugMessageNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = DebugId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.PlayAnimId:
						SAPlayAnimNode PlayAnimId_StateAction_Node = (SAPlayAnimNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = PlayAnimId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.RootAnimId:
						SAPlayRootAnimNode RootAnimId_StateAction_Node = (SAPlayRootAnimNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = RootAnimId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SnapAnimWeightsId:
						SASnapAnimWeightsNode SnapAnimWeightsId_StateAction_Node = (SASnapAnimWeightsNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SnapAnimWeightsId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.StandardInputId:
						SAStandardInputNode StandardInputId_StateAction_Node = (SAStandardInputNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = StandardInputId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.InputId:
						SAInputActionNode InputId_StateAction_Node = (SAInputActionNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = InputId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.DeactInputId:
						SADeactivateInputActionNode DeactInputId_StateAction_Node = (SADeactivateInputActionNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = DeactInputId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.InputEventFromFrameId:
						SAAddInputEventFromFrameNode InputEventFromFrameId_StateAction_Node = (SAAddInputEventFromFrameNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = InputEventFromFrameId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.CancelStateId:
						SACancelToStateNode CancelStateId_StateAction_Node = (SACancelToStateNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = CancelStateId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.CustomCallId:
						SACustomCallNode CustomCallId_StateAction_Node = (SACustomCallNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = CustomCallId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.TimerId:
						SATimedActionNode TimerId_StateAction_Node = (SATimedActionNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = TimerId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.OrderId:
						SAOrderedSensitiveNode OrderId_StateAction_Node = (SAOrderedSensitiveNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = OrderId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.ProxyId:
						SAProxyMoveNode ProxyId_StateAction_Node = (SAProxyMoveNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = ProxyId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.CheckId:
						SACheckThingNode CheckId_StateAction_Node = (SACheckThingNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = CheckId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.ActiveActionId:
						SAActiveActionNode ActiveActionId_StateAction_Node = (SAActiveActionNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = ActiveActionId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.DeactivateActionId:
						SADeactivateActionNode DeactivateActionId_StateAction_Node = (SADeactivateActionNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = DeactivateActionId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SetFloatId:
						SASetFloatTargetNode SetFloatId_StateAction_Node = (SASetFloatTargetNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SetFloatId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.OnBounceId:
						SAOnBounceNode OnBounceId_StateAction_Node = (SAOnBounceNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = OnBounceId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.OnLeaveEdgeId:
						SAOnLeaveEdgeNode OnLeaveEdgeId_StateAction_Node = (SAOnLeaveEdgeNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = OnLeaveEdgeId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.OnStoppedAtEdgeId:
						SAOnStoppedAtLedgeNode OnStoppedAtEdgeId_StateAction_Node = (SAOnStoppedAtLedgeNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = OnStoppedAtEdgeId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.OnLandId:
						SAOnLandNode OnLandId_StateAction_Node = (SAOnLandNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = OnLandId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.OnCancelId:
						SAOnCancelNode OnCancelId_StateAction_Node = (SAOnCancelNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = OnCancelId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.RefreshAtkId:
						SARefreshAttackNode RefreshAtkId_StateAction_Node = (SARefreshAttackNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = RefreshAtkId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.EndAtkId:
						SAEndAttackNode EndAtkId_StateAction_Node = (SAEndAttackNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = EndAtkId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SetHitboxCountId:
						SASetHitboxCountNode SetHitboxCountId_StateAction_Node = (SASetHitboxCountNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SetHitboxCountId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.ConfigHitboxId:
						SAConfigHitboxNode ConfigHitboxId_StateAction_Node = (SAConfigHitboxNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = ConfigHitboxId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SetAtkPropId:
						SASetAttackPropNode SetAtkPropId_StateAction_Node = (SASetAttackPropNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SetAtkPropId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.ManipHitboxId:
						SAManipHitboxNode ManipHitboxId_StateAction_Node = (SAManipHitboxNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = ManipHitboxId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.UpdateHurtsetId:
						SAUpdateHurtboxesNode UpdateHurtsetId_StateAction_Node = (SAUpdateHurtboxesNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = UpdateHurtsetId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SetupHurtsetId:
						SASetupHurtboxesNode SetupHurtsetId_StateAction_Node = (SASetupHurtboxesNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SetupHurtsetId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.ManipHurtboxId:
						SAManipHurtboxNode ManipHurtboxId_StateAction_Node = (SAManipHurtboxNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = ManipHurtboxId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.BoneStateId:
						SABoneStateNode BoneStateId_StateAction_Node = (SABoneStateNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = BoneStateId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.BoneScaleId:
						SABoneScaleNode BoneScaleId_StateAction_Node = (SABoneScaleNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = BoneScaleId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SpawnAgentId:
						SASpawnAgentNode SpawnAgentId_StateAction_Node = (SASpawnAgentNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SpawnAgentId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.LocalFXId:
						SALocalFXNode LocalFXId_StateAction_Node = (SALocalFXNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = LocalFXId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SpawnFXId:
						SASpawnFXNode SpawnFXId_StateAction_Node = (SASpawnFXNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SpawnFXId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.HitboxFXId:
						SASetHitboxFXNode HitboxFXId_StateAction_Node = (SASetHitboxFXNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = HitboxFXId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SFXId:
						SAPlaySFXNode SFXId_StateAction_Node = (SAPlaySFXNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SFXId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.HitboxSFXId:
						SASetHitboxSFXNode HitboxSFXId_StateAction_Node = (SASetHitboxSFXNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = HitboxSFXId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.ColorTintId:
						SAColorTintNode ColorTintId_StateAction_Node = (SAColorTintNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = ColorTintId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.FindFloorId:
						SAFindFloorNode FindFloorId_StateAction_Node = (SAFindFloorNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = FindFloorId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.HurtGrabbedId:
						SAHurtGrabbedNode HurtGrabbedId_StateAction_Node = (SAHurtGrabbedNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = HurtGrabbedId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.LaunchGrabbedId:
						SALaunchGrabbedNode LaunchGrabbedId_StateAction_Node = (SALaunchGrabbedNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = LaunchGrabbedId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.StateCancelGrabbedId:
						SAStateCancelGrabbedNode StateCancelGrabbedId_StateAction_Node = (SAStateCancelGrabbedNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = StateCancelGrabbedId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.EndGrabId:
						SAEndGrabNode EndGrabId_StateAction_Node = (SAEndGrabNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = EndGrabId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.GrabNotifyEscapeId:
						SAGrabNotifyEscapeNode GrabNotifyEscapeId_StateAction_Node = (SAGrabNotifyEscapeNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = GrabNotifyEscapeId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.IgnoreGrabbedId:
						SAIgnoreGrabbedNode IgnoreGrabbedId_StateAction_Node = (SAIgnoreGrabbedNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = IgnoreGrabbedId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.EventKOId:
						SAEventKONode EventKOId_StateAction_Node = (SAEventKONode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = EventKOId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.EventKOGrabbedId:
						SAEventKOGrabbedNode EventKOGrabbedId_StateAction_Node = (SAEventKOGrabbedNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = EventKOGrabbedId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.CameraShakeId:
						SACameraShakeNode CameraShakeId_StateAction_Node = (SACameraShakeNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = CameraShakeId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.ResetOnHitId:
						SAResetOnHitsNode ResetOnHitId_StateAction_Node = (SAResetOnHitsNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = ResetOnHitId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.OnHitId:
						SAOnHitNode OnHitId_StateAction_Node = (SAOnHitNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = OnHitId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.FastForwardId:
						SAFastForwardStateNode FastForwardId_StateAction_Node = (SAFastForwardStateNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = FastForwardId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.TimingTweakId:
						SATimingTweakNode TimingTweakId_StateAction_Node = (SATimingTweakNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = TimingTweakId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.MapAnimId:
						SAMapAnimationNode MapAnimId_StateAction_Node = (SAMapAnimationNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = MapAnimId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.AlterMoveDtId:
						SAAlterMoveDTNode AlterMoveDtId_StateAction_Node = (SAAlterMoveDTNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = AlterMoveDtId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.AlterMoveVelId:
						SAAlterMoveVelNode AlterMoveVelId_StateAction_Node = (SAAlterMoveVelNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = AlterMoveVelId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SetStagePartId:
						SASetStagePartNode SetStagePartId_StateAction_Node = (SASetStagePartNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SetStagePartId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SetStagePartsDefaultId:
						SASetStagePartsDefaultNode SetStagePartsDefaultId_StateAction_Node = (SASetStagePartsDefaultNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SetStagePartsDefaultId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.JumpId:
						SAJumpNode JumpId_StateAction_Node = (SAJumpNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = JumpId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.StopJumpId:
						SAStopJumpNode StopJumpId_StateAction_Node = (SAStopJumpNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = StopJumpId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.ManageAirJumpId:
						SAManageAirJumpNode ManageAirJumpId_StateAction_Node = (SAManageAirJumpNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = ManageAirJumpId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.LeaveGroundId:
						SALeaveGroundNode LeaveGroundId_StateAction_Node = (SALeaveGroundNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = LeaveGroundId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.UnhogEdgeId:
						SAUnHogEdgeNode UnhogEdgeId_StateAction_Node = (SAUnHogEdgeNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = UnhogEdgeId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SFXTimelineId:
						SAPlaySFXTimelineNode SFXTimelineId_StateAction_Node = (SAPlaySFXTimelineNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SFXTimelineId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.FindLastHorizontalInputId:
						SAFindLastHorizontalInputNode FindLastHorizontalInputId_StateAction_Node = (SAFindLastHorizontalInputNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = FindLastHorizontalInputId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SetCommandGrab:
						SASetCommandGrabNode SetCommandGrab_StateAction_Node = (SASetCommandGrabNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SetCommandGrab_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.CameraPunchId:
						SACameraPunchNode CameraPunchId_StateAction_Node = (SACameraPunchNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = CameraPunchId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SpawnAgent2Id:
						SASpawnAgent2Node SpawnAgent2Id_StateAction_Node = (SASpawnAgent2Node)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SpawnAgent2Id_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.ManipDecorChainId:
						SAManipDecorChainNode ManipDecorChainId_StateAction_Node = (SAManipDecorChainNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = ManipDecorChainId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.UpdateHitboxesId:
						SAUpdateHitboxesNode UpdateHitboxesId_StateAction_Node = (SAUpdateHitboxesNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = UpdateHitboxesId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SampleAnimId:
						SASampleAnimNode SampleAnimId_StateAction_Node = (SASampleAnimNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = SampleAnimId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.ForceExtraInputId:
						SAForceExtraInputCheckNode ForceExtraInputId_StateAction_Node = (SAForceExtraInputCheckNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = ForceExtraInputId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.LaunchGrabbedCustomId:
						SALaunchGrabbedCustomNode LaunchGrabbedCustomId_StateAction_Node = (SALaunchGrabbedCustomNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = LaunchGrabbedCustomId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.BaseIdentifier:
						StateActionNode BaseIdentifier_StateAction_Node = (StateActionNode)GetPort("ActionB").GetConnection(0).node;
						objToReturn.ActionB = BaseIdentifier_StateAction_Node.GetData();
					break;
				}
			}
			if (GetPort("ActionEnd").ConnectionCount > 0)
			{
				StateActionNode StateAction_Node = (StateActionNode)GetPort("ActionEnd").GetConnection(0).node;
				switch (StateAction_Node.TID)
				{
					case StateAction.TypeId.DebugId:
						SADebugMessageNode DebugId_StateAction_Node = (SADebugMessageNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = DebugId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.PlayAnimId:
						SAPlayAnimNode PlayAnimId_StateAction_Node = (SAPlayAnimNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = PlayAnimId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.RootAnimId:
						SAPlayRootAnimNode RootAnimId_StateAction_Node = (SAPlayRootAnimNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = RootAnimId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SnapAnimWeightsId:
						SASnapAnimWeightsNode SnapAnimWeightsId_StateAction_Node = (SASnapAnimWeightsNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SnapAnimWeightsId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.StandardInputId:
						SAStandardInputNode StandardInputId_StateAction_Node = (SAStandardInputNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = StandardInputId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.InputId:
						SAInputActionNode InputId_StateAction_Node = (SAInputActionNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = InputId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.DeactInputId:
						SADeactivateInputActionNode DeactInputId_StateAction_Node = (SADeactivateInputActionNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = DeactInputId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.InputEventFromFrameId:
						SAAddInputEventFromFrameNode InputEventFromFrameId_StateAction_Node = (SAAddInputEventFromFrameNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = InputEventFromFrameId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.CancelStateId:
						SACancelToStateNode CancelStateId_StateAction_Node = (SACancelToStateNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = CancelStateId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.CustomCallId:
						SACustomCallNode CustomCallId_StateAction_Node = (SACustomCallNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = CustomCallId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.TimerId:
						SATimedActionNode TimerId_StateAction_Node = (SATimedActionNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = TimerId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.OrderId:
						SAOrderedSensitiveNode OrderId_StateAction_Node = (SAOrderedSensitiveNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = OrderId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.ProxyId:
						SAProxyMoveNode ProxyId_StateAction_Node = (SAProxyMoveNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = ProxyId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.CheckId:
						SACheckThingNode CheckId_StateAction_Node = (SACheckThingNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = CheckId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.ActiveActionId:
						SAActiveActionNode ActiveActionId_StateAction_Node = (SAActiveActionNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = ActiveActionId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.DeactivateActionId:
						SADeactivateActionNode DeactivateActionId_StateAction_Node = (SADeactivateActionNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = DeactivateActionId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SetFloatId:
						SASetFloatTargetNode SetFloatId_StateAction_Node = (SASetFloatTargetNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SetFloatId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.OnBounceId:
						SAOnBounceNode OnBounceId_StateAction_Node = (SAOnBounceNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = OnBounceId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.OnLeaveEdgeId:
						SAOnLeaveEdgeNode OnLeaveEdgeId_StateAction_Node = (SAOnLeaveEdgeNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = OnLeaveEdgeId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.OnStoppedAtEdgeId:
						SAOnStoppedAtLedgeNode OnStoppedAtEdgeId_StateAction_Node = (SAOnStoppedAtLedgeNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = OnStoppedAtEdgeId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.OnLandId:
						SAOnLandNode OnLandId_StateAction_Node = (SAOnLandNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = OnLandId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.OnCancelId:
						SAOnCancelNode OnCancelId_StateAction_Node = (SAOnCancelNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = OnCancelId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.RefreshAtkId:
						SARefreshAttackNode RefreshAtkId_StateAction_Node = (SARefreshAttackNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = RefreshAtkId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.EndAtkId:
						SAEndAttackNode EndAtkId_StateAction_Node = (SAEndAttackNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = EndAtkId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SetHitboxCountId:
						SASetHitboxCountNode SetHitboxCountId_StateAction_Node = (SASetHitboxCountNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SetHitboxCountId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.ConfigHitboxId:
						SAConfigHitboxNode ConfigHitboxId_StateAction_Node = (SAConfigHitboxNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = ConfigHitboxId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SetAtkPropId:
						SASetAttackPropNode SetAtkPropId_StateAction_Node = (SASetAttackPropNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SetAtkPropId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.ManipHitboxId:
						SAManipHitboxNode ManipHitboxId_StateAction_Node = (SAManipHitboxNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = ManipHitboxId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.UpdateHurtsetId:
						SAUpdateHurtboxesNode UpdateHurtsetId_StateAction_Node = (SAUpdateHurtboxesNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = UpdateHurtsetId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SetupHurtsetId:
						SASetupHurtboxesNode SetupHurtsetId_StateAction_Node = (SASetupHurtboxesNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SetupHurtsetId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.ManipHurtboxId:
						SAManipHurtboxNode ManipHurtboxId_StateAction_Node = (SAManipHurtboxNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = ManipHurtboxId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.BoneStateId:
						SABoneStateNode BoneStateId_StateAction_Node = (SABoneStateNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = BoneStateId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.BoneScaleId:
						SABoneScaleNode BoneScaleId_StateAction_Node = (SABoneScaleNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = BoneScaleId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SpawnAgentId:
						SASpawnAgentNode SpawnAgentId_StateAction_Node = (SASpawnAgentNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SpawnAgentId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.LocalFXId:
						SALocalFXNode LocalFXId_StateAction_Node = (SALocalFXNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = LocalFXId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SpawnFXId:
						SASpawnFXNode SpawnFXId_StateAction_Node = (SASpawnFXNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SpawnFXId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.HitboxFXId:
						SASetHitboxFXNode HitboxFXId_StateAction_Node = (SASetHitboxFXNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = HitboxFXId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SFXId:
						SAPlaySFXNode SFXId_StateAction_Node = (SAPlaySFXNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SFXId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.HitboxSFXId:
						SASetHitboxSFXNode HitboxSFXId_StateAction_Node = (SASetHitboxSFXNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = HitboxSFXId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.ColorTintId:
						SAColorTintNode ColorTintId_StateAction_Node = (SAColorTintNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = ColorTintId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.FindFloorId:
						SAFindFloorNode FindFloorId_StateAction_Node = (SAFindFloorNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = FindFloorId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.HurtGrabbedId:
						SAHurtGrabbedNode HurtGrabbedId_StateAction_Node = (SAHurtGrabbedNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = HurtGrabbedId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.LaunchGrabbedId:
						SALaunchGrabbedNode LaunchGrabbedId_StateAction_Node = (SALaunchGrabbedNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = LaunchGrabbedId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.StateCancelGrabbedId:
						SAStateCancelGrabbedNode StateCancelGrabbedId_StateAction_Node = (SAStateCancelGrabbedNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = StateCancelGrabbedId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.EndGrabId:
						SAEndGrabNode EndGrabId_StateAction_Node = (SAEndGrabNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = EndGrabId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.GrabNotifyEscapeId:
						SAGrabNotifyEscapeNode GrabNotifyEscapeId_StateAction_Node = (SAGrabNotifyEscapeNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = GrabNotifyEscapeId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.IgnoreGrabbedId:
						SAIgnoreGrabbedNode IgnoreGrabbedId_StateAction_Node = (SAIgnoreGrabbedNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = IgnoreGrabbedId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.EventKOId:
						SAEventKONode EventKOId_StateAction_Node = (SAEventKONode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = EventKOId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.EventKOGrabbedId:
						SAEventKOGrabbedNode EventKOGrabbedId_StateAction_Node = (SAEventKOGrabbedNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = EventKOGrabbedId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.CameraShakeId:
						SACameraShakeNode CameraShakeId_StateAction_Node = (SACameraShakeNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = CameraShakeId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.ResetOnHitId:
						SAResetOnHitsNode ResetOnHitId_StateAction_Node = (SAResetOnHitsNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = ResetOnHitId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.OnHitId:
						SAOnHitNode OnHitId_StateAction_Node = (SAOnHitNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = OnHitId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.FastForwardId:
						SAFastForwardStateNode FastForwardId_StateAction_Node = (SAFastForwardStateNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = FastForwardId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.TimingTweakId:
						SATimingTweakNode TimingTweakId_StateAction_Node = (SATimingTweakNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = TimingTweakId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.MapAnimId:
						SAMapAnimationNode MapAnimId_StateAction_Node = (SAMapAnimationNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = MapAnimId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.AlterMoveDtId:
						SAAlterMoveDTNode AlterMoveDtId_StateAction_Node = (SAAlterMoveDTNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = AlterMoveDtId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.AlterMoveVelId:
						SAAlterMoveVelNode AlterMoveVelId_StateAction_Node = (SAAlterMoveVelNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = AlterMoveVelId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SetStagePartId:
						SASetStagePartNode SetStagePartId_StateAction_Node = (SASetStagePartNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SetStagePartId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SetStagePartsDefaultId:
						SASetStagePartsDefaultNode SetStagePartsDefaultId_StateAction_Node = (SASetStagePartsDefaultNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SetStagePartsDefaultId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.JumpId:
						SAJumpNode JumpId_StateAction_Node = (SAJumpNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = JumpId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.StopJumpId:
						SAStopJumpNode StopJumpId_StateAction_Node = (SAStopJumpNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = StopJumpId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.ManageAirJumpId:
						SAManageAirJumpNode ManageAirJumpId_StateAction_Node = (SAManageAirJumpNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = ManageAirJumpId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.LeaveGroundId:
						SALeaveGroundNode LeaveGroundId_StateAction_Node = (SALeaveGroundNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = LeaveGroundId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.UnhogEdgeId:
						SAUnHogEdgeNode UnhogEdgeId_StateAction_Node = (SAUnHogEdgeNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = UnhogEdgeId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SFXTimelineId:
						SAPlaySFXTimelineNode SFXTimelineId_StateAction_Node = (SAPlaySFXTimelineNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SFXTimelineId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.FindLastHorizontalInputId:
						SAFindLastHorizontalInputNode FindLastHorizontalInputId_StateAction_Node = (SAFindLastHorizontalInputNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = FindLastHorizontalInputId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SetCommandGrab:
						SASetCommandGrabNode SetCommandGrab_StateAction_Node = (SASetCommandGrabNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SetCommandGrab_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.CameraPunchId:
						SACameraPunchNode CameraPunchId_StateAction_Node = (SACameraPunchNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = CameraPunchId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SpawnAgent2Id:
						SASpawnAgent2Node SpawnAgent2Id_StateAction_Node = (SASpawnAgent2Node)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SpawnAgent2Id_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.ManipDecorChainId:
						SAManipDecorChainNode ManipDecorChainId_StateAction_Node = (SAManipDecorChainNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = ManipDecorChainId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.UpdateHitboxesId:
						SAUpdateHitboxesNode UpdateHitboxesId_StateAction_Node = (SAUpdateHitboxesNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = UpdateHitboxesId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.SampleAnimId:
						SASampleAnimNode SampleAnimId_StateAction_Node = (SASampleAnimNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = SampleAnimId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.ForceExtraInputId:
						SAForceExtraInputCheckNode ForceExtraInputId_StateAction_Node = (SAForceExtraInputCheckNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = ForceExtraInputId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.LaunchGrabbedCustomId:
						SALaunchGrabbedCustomNode LaunchGrabbedCustomId_StateAction_Node = (SALaunchGrabbedCustomNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = LaunchGrabbedCustomId_StateAction_Node.GetData();
					break;
					case StateAction.TypeId.BaseIdentifier:
						StateActionNode BaseIdentifier_StateAction_Node = (StateActionNode)GetPort("ActionEnd").GetConnection(0).node;
						objToReturn.ActionEnd = BaseIdentifier_StateAction_Node.GetData();
					break;
				}
			}
			return objToReturn;
		}
	}
}

