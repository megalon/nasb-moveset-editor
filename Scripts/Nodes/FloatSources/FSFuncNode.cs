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
using static NASB_Parser.FloatSources.FloatSource;

namespace NASB_Moveset_Editor.FloatSources
{
	public class FSFuncNode : FloatSourceNode
	{
		public NASB_Parser.FloatSources.FSFunc.FuncWay Way;
		[Output(connectionType = ConnectionType.Override)] public FloatSource ContainerA;
		[Output(connectionType = ConnectionType.Override)] public FloatSource ContainerB;
		[Output(connectionType = ConnectionType.Override)] public FloatSource ContainerC;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.FuncId;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(FSFunc data, MovesetGraph graph, string assetPath, Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(FSFunc));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			Way = data.Way;
			ContainerA = data.ContainerA;
			
			switch (ContainerA.TID)
			{
				case FloatSource.TypeId.AgentId:
					FSAgentNode AgentId_node_ContainerA = graph.AddNode<FSAgentNode>();
					GetPort("ContainerA").Connect(AgentId_node_ContainerA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AgentId_node_ContainerA, assetPath);
					variableCount += AgentId_node_ContainerA.SetData((FSAgent)ContainerA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.BonesId:
					FSBonesNode BonesId_node_ContainerA = graph.AddNode<FSBonesNode>();
					GetPort("ContainerA").Connect(BonesId_node_ContainerA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BonesId_node_ContainerA, assetPath);
					variableCount += BonesId_node_ContainerA.SetData((FSBones)ContainerA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AttackId:
					FSAttackNode AttackId_node_ContainerA = graph.AddNode<FSAttackNode>();
					GetPort("ContainerA").Connect(AttackId_node_ContainerA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AttackId_node_ContainerA, assetPath);
					variableCount += AttackId_node_ContainerA.SetData((FSAttack)ContainerA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FrameId:
					FSFrameNode FrameId_node_ContainerA = graph.AddNode<FSFrameNode>();
					GetPort("ContainerA").Connect(FrameId_node_ContainerA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FrameId_node_ContainerA, assetPath);
					variableCount += FrameId_node_ContainerA.SetData((FSFrame)ContainerA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.InputId:
					FSInputNode InputId_node_ContainerA = graph.AddNode<FSInputNode>();
					GetPort("ContainerA").Connect(InputId_node_ContainerA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputId_node_ContainerA, assetPath);
					variableCount += InputId_node_ContainerA.SetData((FSInput)ContainerA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FuncId:
					FSFuncNode FuncId_node_ContainerA = graph.AddNode<FSFuncNode>();
					GetPort("ContainerA").Connect(FuncId_node_ContainerA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FuncId_node_ContainerA, assetPath);
					variableCount += FuncId_node_ContainerA.SetData((FSFunc)ContainerA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.MovementId:
					FSMovementNode MovementId_node_ContainerA = graph.AddNode<FSMovementNode>();
					GetPort("ContainerA").Connect(MovementId_node_ContainerA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(MovementId_node_ContainerA, assetPath);
					variableCount += MovementId_node_ContainerA.SetData((FSMovement)ContainerA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CombatId:
					FSCombatNode CombatId_node_ContainerA = graph.AddNode<FSCombatNode>();
					GetPort("ContainerA").Connect(CombatId_node_ContainerA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CombatId_node_ContainerA, assetPath);
					variableCount += CombatId_node_ContainerA.SetData((FSCombat)ContainerA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.GrabsId:
					FSGrabsNode GrabsId_node_ContainerA = graph.AddNode<FSGrabsNode>();
					GetPort("ContainerA").Connect(GrabsId_node_ContainerA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(GrabsId_node_ContainerA, assetPath);
					variableCount += GrabsId_node_ContainerA.SetData((FSGrabs)ContainerA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.DataId:
					FSDataNode DataId_node_ContainerA = graph.AddNode<FSDataNode>();
					GetPort("ContainerA").Connect(DataId_node_ContainerA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DataId_node_ContainerA, assetPath);
					variableCount += DataId_node_ContainerA.SetData((FSData)ContainerA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ScratchId:
					FSScratchNode ScratchId_node_ContainerA = graph.AddNode<FSScratchNode>();
					GetPort("ContainerA").Connect(ScratchId_node_ContainerA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ScratchId_node_ContainerA, assetPath);
					variableCount += ScratchId_node_ContainerA.SetData((FSScratch)ContainerA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AnimId:
					FSAnimNode AnimId_node_ContainerA = graph.AddNode<FSAnimNode>();
					GetPort("ContainerA").Connect(AnimId_node_ContainerA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AnimId_node_ContainerA, assetPath);
					variableCount += AnimId_node_ContainerA.SetData((FSAnim)ContainerA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SpeedId:
					FSSpeedNode SpeedId_node_ContainerA = graph.AddNode<FSSpeedNode>();
					GetPort("ContainerA").Connect(SpeedId_node_ContainerA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpeedId_node_ContainerA, assetPath);
					variableCount += SpeedId_node_ContainerA.SetData((FSSpeed)ContainerA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.PhysicsId:
					FSPhysicsNode PhysicsId_node_ContainerA = graph.AddNode<FSPhysicsNode>();
					GetPort("ContainerA").Connect(PhysicsId_node_ContainerA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(PhysicsId_node_ContainerA, assetPath);
					variableCount += PhysicsId_node_ContainerA.SetData((FSPhysics)ContainerA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CollisionId:
					FSCollisionNode CollisionId_node_ContainerA = graph.AddNode<FSCollisionNode>();
					GetPort("ContainerA").Connect(CollisionId_node_ContainerA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CollisionId_node_ContainerA, assetPath);
					variableCount += CollisionId_node_ContainerA.SetData((FSCollision)ContainerA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.TimerId:
					FSTimerNode TimerId_node_ContainerA = graph.AddNode<FSTimerNode>();
					GetPort("ContainerA").Connect(TimerId_node_ContainerA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(TimerId_node_ContainerA, assetPath);
					variableCount += TimerId_node_ContainerA.SetData((FSTimer)ContainerA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.LagId:
					FSLagNode LagId_node_ContainerA = graph.AddNode<FSLagNode>();
					GetPort("ContainerA").Connect(LagId_node_ContainerA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LagId_node_ContainerA, assetPath);
					variableCount += LagId_node_ContainerA.SetData((FSLag)ContainerA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.EffectsId:
					FSEffectsNode EffectsId_node_ContainerA = graph.AddNode<FSEffectsNode>();
					GetPort("ContainerA").Connect(EffectsId_node_ContainerA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EffectsId_node_ContainerA, assetPath);
					variableCount += EffectsId_node_ContainerA.SetData((FSEffects)ContainerA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ColorsId:
					FSColorsNode ColorsId_node_ContainerA = graph.AddNode<FSColorsNode>();
					GetPort("ContainerA").Connect(ColorsId_node_ContainerA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ColorsId_node_ContainerA, assetPath);
					variableCount += ColorsId_node_ContainerA.SetData((FSColors)ContainerA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.OnHitId:
					FSOnHitNode OnHitId_node_ContainerA = graph.AddNode<FSOnHitNode>();
					GetPort("ContainerA").Connect(OnHitId_node_ContainerA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnHitId_node_ContainerA, assetPath);
					variableCount += OnHitId_node_ContainerA.SetData((FSOnHit)ContainerA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RandomId:
					FSRandomNode RandomId_node_ContainerA = graph.AddNode<FSRandomNode>();
					GetPort("ContainerA").Connect(RandomId_node_ContainerA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RandomId_node_ContainerA, assetPath);
					variableCount += RandomId_node_ContainerA.SetData((FSRandom)ContainerA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CameraId:
					FSCameraInfoNode CameraId_node_ContainerA = graph.AddNode<FSCameraInfoNode>();
					GetPort("ContainerA").Connect(CameraId_node_ContainerA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CameraId_node_ContainerA, assetPath);
					variableCount += CameraId_node_ContainerA.SetData((FSCameraInfo)ContainerA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SportsId:
					FSSportsNode SportsId_node_ContainerA = graph.AddNode<FSSportsNode>();
					GetPort("ContainerA").Connect(SportsId_node_ContainerA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SportsId_node_ContainerA, assetPath);
					variableCount += SportsId_node_ContainerA.SetData((FSSports)ContainerA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.Vector2Mag:
					FSVector2MagNode Vector2Mag_node_ContainerA = graph.AddNode<FSVector2MagNode>();
					GetPort("ContainerA").Connect(Vector2Mag_node_ContainerA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(Vector2Mag_node_ContainerA, assetPath);
					variableCount += Vector2Mag_node_ContainerA.SetData((FSVector2Mag)ContainerA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CPUHelpId:
					FSCpuHelpNode CPUHelpId_node_ContainerA = graph.AddNode<FSCpuHelpNode>();
					GetPort("ContainerA").Connect(CPUHelpId_node_ContainerA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CPUHelpId_node_ContainerA, assetPath);
					variableCount += CPUHelpId_node_ContainerA.SetData((FSCpuHelp)ContainerA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ItemId:
					FSItemNode ItemId_node_ContainerA = graph.AddNode<FSItemNode>();
					GetPort("ContainerA").Connect(ItemId_node_ContainerA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ItemId_node_ContainerA, assetPath);
					variableCount += ItemId_node_ContainerA.SetData((FSItem)ContainerA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ModeId:
					FSModeNode ModeId_node_ContainerA = graph.AddNode<FSModeNode>();
					GetPort("ContainerA").Connect(ModeId_node_ContainerA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ModeId_node_ContainerA, assetPath);
					variableCount += ModeId_node_ContainerA.SetData((FSMode)ContainerA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.JumpsId:
					FSJumpsNode JumpsId_node_ContainerA = graph.AddNode<FSJumpsNode>();
					GetPort("ContainerA").Connect(JumpsId_node_ContainerA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(JumpsId_node_ContainerA, assetPath);
					variableCount += JumpsId_node_ContainerA.SetData((FSJumps)ContainerA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RootAnimId:
					FSRootAnimNode RootAnimId_node_ContainerA = graph.AddNode<FSRootAnimNode>();
					GetPort("ContainerA").Connect(RootAnimId_node_ContainerA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RootAnimId_node_ContainerA, assetPath);
					variableCount += RootAnimId_node_ContainerA.SetData((FSRootAnim)ContainerA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FloatId:
					FSValueNode FloatId_node_ContainerA = graph.AddNode<FSValueNode>();
					GetPort("ContainerA").Connect(FloatId_node_ContainerA.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FloatId_node_ContainerA, assetPath);
					variableCount += FloatId_node_ContainerA.SetData((FSValue)ContainerA, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
			}
			++variableCount;
			
			ContainerB = data.ContainerB;
			
			switch (ContainerB.TID)
			{
				case FloatSource.TypeId.AgentId:
					FSAgentNode AgentId_node_ContainerB = graph.AddNode<FSAgentNode>();
					GetPort("ContainerB").Connect(AgentId_node_ContainerB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AgentId_node_ContainerB, assetPath);
					variableCount += AgentId_node_ContainerB.SetData((FSAgent)ContainerB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.BonesId:
					FSBonesNode BonesId_node_ContainerB = graph.AddNode<FSBonesNode>();
					GetPort("ContainerB").Connect(BonesId_node_ContainerB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BonesId_node_ContainerB, assetPath);
					variableCount += BonesId_node_ContainerB.SetData((FSBones)ContainerB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AttackId:
					FSAttackNode AttackId_node_ContainerB = graph.AddNode<FSAttackNode>();
					GetPort("ContainerB").Connect(AttackId_node_ContainerB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AttackId_node_ContainerB, assetPath);
					variableCount += AttackId_node_ContainerB.SetData((FSAttack)ContainerB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FrameId:
					FSFrameNode FrameId_node_ContainerB = graph.AddNode<FSFrameNode>();
					GetPort("ContainerB").Connect(FrameId_node_ContainerB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FrameId_node_ContainerB, assetPath);
					variableCount += FrameId_node_ContainerB.SetData((FSFrame)ContainerB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.InputId:
					FSInputNode InputId_node_ContainerB = graph.AddNode<FSInputNode>();
					GetPort("ContainerB").Connect(InputId_node_ContainerB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputId_node_ContainerB, assetPath);
					variableCount += InputId_node_ContainerB.SetData((FSInput)ContainerB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FuncId:
					FSFuncNode FuncId_node_ContainerB = graph.AddNode<FSFuncNode>();
					GetPort("ContainerB").Connect(FuncId_node_ContainerB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FuncId_node_ContainerB, assetPath);
					variableCount += FuncId_node_ContainerB.SetData((FSFunc)ContainerB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.MovementId:
					FSMovementNode MovementId_node_ContainerB = graph.AddNode<FSMovementNode>();
					GetPort("ContainerB").Connect(MovementId_node_ContainerB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(MovementId_node_ContainerB, assetPath);
					variableCount += MovementId_node_ContainerB.SetData((FSMovement)ContainerB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CombatId:
					FSCombatNode CombatId_node_ContainerB = graph.AddNode<FSCombatNode>();
					GetPort("ContainerB").Connect(CombatId_node_ContainerB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CombatId_node_ContainerB, assetPath);
					variableCount += CombatId_node_ContainerB.SetData((FSCombat)ContainerB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.GrabsId:
					FSGrabsNode GrabsId_node_ContainerB = graph.AddNode<FSGrabsNode>();
					GetPort("ContainerB").Connect(GrabsId_node_ContainerB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(GrabsId_node_ContainerB, assetPath);
					variableCount += GrabsId_node_ContainerB.SetData((FSGrabs)ContainerB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.DataId:
					FSDataNode DataId_node_ContainerB = graph.AddNode<FSDataNode>();
					GetPort("ContainerB").Connect(DataId_node_ContainerB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DataId_node_ContainerB, assetPath);
					variableCount += DataId_node_ContainerB.SetData((FSData)ContainerB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ScratchId:
					FSScratchNode ScratchId_node_ContainerB = graph.AddNode<FSScratchNode>();
					GetPort("ContainerB").Connect(ScratchId_node_ContainerB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ScratchId_node_ContainerB, assetPath);
					variableCount += ScratchId_node_ContainerB.SetData((FSScratch)ContainerB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AnimId:
					FSAnimNode AnimId_node_ContainerB = graph.AddNode<FSAnimNode>();
					GetPort("ContainerB").Connect(AnimId_node_ContainerB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AnimId_node_ContainerB, assetPath);
					variableCount += AnimId_node_ContainerB.SetData((FSAnim)ContainerB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SpeedId:
					FSSpeedNode SpeedId_node_ContainerB = graph.AddNode<FSSpeedNode>();
					GetPort("ContainerB").Connect(SpeedId_node_ContainerB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpeedId_node_ContainerB, assetPath);
					variableCount += SpeedId_node_ContainerB.SetData((FSSpeed)ContainerB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.PhysicsId:
					FSPhysicsNode PhysicsId_node_ContainerB = graph.AddNode<FSPhysicsNode>();
					GetPort("ContainerB").Connect(PhysicsId_node_ContainerB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(PhysicsId_node_ContainerB, assetPath);
					variableCount += PhysicsId_node_ContainerB.SetData((FSPhysics)ContainerB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CollisionId:
					FSCollisionNode CollisionId_node_ContainerB = graph.AddNode<FSCollisionNode>();
					GetPort("ContainerB").Connect(CollisionId_node_ContainerB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CollisionId_node_ContainerB, assetPath);
					variableCount += CollisionId_node_ContainerB.SetData((FSCollision)ContainerB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.TimerId:
					FSTimerNode TimerId_node_ContainerB = graph.AddNode<FSTimerNode>();
					GetPort("ContainerB").Connect(TimerId_node_ContainerB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(TimerId_node_ContainerB, assetPath);
					variableCount += TimerId_node_ContainerB.SetData((FSTimer)ContainerB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.LagId:
					FSLagNode LagId_node_ContainerB = graph.AddNode<FSLagNode>();
					GetPort("ContainerB").Connect(LagId_node_ContainerB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LagId_node_ContainerB, assetPath);
					variableCount += LagId_node_ContainerB.SetData((FSLag)ContainerB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.EffectsId:
					FSEffectsNode EffectsId_node_ContainerB = graph.AddNode<FSEffectsNode>();
					GetPort("ContainerB").Connect(EffectsId_node_ContainerB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EffectsId_node_ContainerB, assetPath);
					variableCount += EffectsId_node_ContainerB.SetData((FSEffects)ContainerB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ColorsId:
					FSColorsNode ColorsId_node_ContainerB = graph.AddNode<FSColorsNode>();
					GetPort("ContainerB").Connect(ColorsId_node_ContainerB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ColorsId_node_ContainerB, assetPath);
					variableCount += ColorsId_node_ContainerB.SetData((FSColors)ContainerB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.OnHitId:
					FSOnHitNode OnHitId_node_ContainerB = graph.AddNode<FSOnHitNode>();
					GetPort("ContainerB").Connect(OnHitId_node_ContainerB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnHitId_node_ContainerB, assetPath);
					variableCount += OnHitId_node_ContainerB.SetData((FSOnHit)ContainerB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RandomId:
					FSRandomNode RandomId_node_ContainerB = graph.AddNode<FSRandomNode>();
					GetPort("ContainerB").Connect(RandomId_node_ContainerB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RandomId_node_ContainerB, assetPath);
					variableCount += RandomId_node_ContainerB.SetData((FSRandom)ContainerB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CameraId:
					FSCameraInfoNode CameraId_node_ContainerB = graph.AddNode<FSCameraInfoNode>();
					GetPort("ContainerB").Connect(CameraId_node_ContainerB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CameraId_node_ContainerB, assetPath);
					variableCount += CameraId_node_ContainerB.SetData((FSCameraInfo)ContainerB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SportsId:
					FSSportsNode SportsId_node_ContainerB = graph.AddNode<FSSportsNode>();
					GetPort("ContainerB").Connect(SportsId_node_ContainerB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SportsId_node_ContainerB, assetPath);
					variableCount += SportsId_node_ContainerB.SetData((FSSports)ContainerB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.Vector2Mag:
					FSVector2MagNode Vector2Mag_node_ContainerB = graph.AddNode<FSVector2MagNode>();
					GetPort("ContainerB").Connect(Vector2Mag_node_ContainerB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(Vector2Mag_node_ContainerB, assetPath);
					variableCount += Vector2Mag_node_ContainerB.SetData((FSVector2Mag)ContainerB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CPUHelpId:
					FSCpuHelpNode CPUHelpId_node_ContainerB = graph.AddNode<FSCpuHelpNode>();
					GetPort("ContainerB").Connect(CPUHelpId_node_ContainerB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CPUHelpId_node_ContainerB, assetPath);
					variableCount += CPUHelpId_node_ContainerB.SetData((FSCpuHelp)ContainerB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ItemId:
					FSItemNode ItemId_node_ContainerB = graph.AddNode<FSItemNode>();
					GetPort("ContainerB").Connect(ItemId_node_ContainerB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ItemId_node_ContainerB, assetPath);
					variableCount += ItemId_node_ContainerB.SetData((FSItem)ContainerB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ModeId:
					FSModeNode ModeId_node_ContainerB = graph.AddNode<FSModeNode>();
					GetPort("ContainerB").Connect(ModeId_node_ContainerB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ModeId_node_ContainerB, assetPath);
					variableCount += ModeId_node_ContainerB.SetData((FSMode)ContainerB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.JumpsId:
					FSJumpsNode JumpsId_node_ContainerB = graph.AddNode<FSJumpsNode>();
					GetPort("ContainerB").Connect(JumpsId_node_ContainerB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(JumpsId_node_ContainerB, assetPath);
					variableCount += JumpsId_node_ContainerB.SetData((FSJumps)ContainerB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RootAnimId:
					FSRootAnimNode RootAnimId_node_ContainerB = graph.AddNode<FSRootAnimNode>();
					GetPort("ContainerB").Connect(RootAnimId_node_ContainerB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RootAnimId_node_ContainerB, assetPath);
					variableCount += RootAnimId_node_ContainerB.SetData((FSRootAnim)ContainerB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FloatId:
					FSValueNode FloatId_node_ContainerB = graph.AddNode<FSValueNode>();
					GetPort("ContainerB").Connect(FloatId_node_ContainerB.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FloatId_node_ContainerB, assetPath);
					variableCount += FloatId_node_ContainerB.SetData((FSValue)ContainerB, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
			}
			++variableCount;
			
			ContainerC = data.ContainerC;
			
			switch (ContainerC.TID)
			{
				case FloatSource.TypeId.AgentId:
					FSAgentNode AgentId_node_ContainerC = graph.AddNode<FSAgentNode>();
					GetPort("ContainerC").Connect(AgentId_node_ContainerC.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AgentId_node_ContainerC, assetPath);
					variableCount += AgentId_node_ContainerC.SetData((FSAgent)ContainerC, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.BonesId:
					FSBonesNode BonesId_node_ContainerC = graph.AddNode<FSBonesNode>();
					GetPort("ContainerC").Connect(BonesId_node_ContainerC.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BonesId_node_ContainerC, assetPath);
					variableCount += BonesId_node_ContainerC.SetData((FSBones)ContainerC, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AttackId:
					FSAttackNode AttackId_node_ContainerC = graph.AddNode<FSAttackNode>();
					GetPort("ContainerC").Connect(AttackId_node_ContainerC.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AttackId_node_ContainerC, assetPath);
					variableCount += AttackId_node_ContainerC.SetData((FSAttack)ContainerC, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FrameId:
					FSFrameNode FrameId_node_ContainerC = graph.AddNode<FSFrameNode>();
					GetPort("ContainerC").Connect(FrameId_node_ContainerC.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FrameId_node_ContainerC, assetPath);
					variableCount += FrameId_node_ContainerC.SetData((FSFrame)ContainerC, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.InputId:
					FSInputNode InputId_node_ContainerC = graph.AddNode<FSInputNode>();
					GetPort("ContainerC").Connect(InputId_node_ContainerC.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputId_node_ContainerC, assetPath);
					variableCount += InputId_node_ContainerC.SetData((FSInput)ContainerC, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FuncId:
					FSFuncNode FuncId_node_ContainerC = graph.AddNode<FSFuncNode>();
					GetPort("ContainerC").Connect(FuncId_node_ContainerC.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FuncId_node_ContainerC, assetPath);
					variableCount += FuncId_node_ContainerC.SetData((FSFunc)ContainerC, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.MovementId:
					FSMovementNode MovementId_node_ContainerC = graph.AddNode<FSMovementNode>();
					GetPort("ContainerC").Connect(MovementId_node_ContainerC.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(MovementId_node_ContainerC, assetPath);
					variableCount += MovementId_node_ContainerC.SetData((FSMovement)ContainerC, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CombatId:
					FSCombatNode CombatId_node_ContainerC = graph.AddNode<FSCombatNode>();
					GetPort("ContainerC").Connect(CombatId_node_ContainerC.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CombatId_node_ContainerC, assetPath);
					variableCount += CombatId_node_ContainerC.SetData((FSCombat)ContainerC, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.GrabsId:
					FSGrabsNode GrabsId_node_ContainerC = graph.AddNode<FSGrabsNode>();
					GetPort("ContainerC").Connect(GrabsId_node_ContainerC.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(GrabsId_node_ContainerC, assetPath);
					variableCount += GrabsId_node_ContainerC.SetData((FSGrabs)ContainerC, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.DataId:
					FSDataNode DataId_node_ContainerC = graph.AddNode<FSDataNode>();
					GetPort("ContainerC").Connect(DataId_node_ContainerC.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DataId_node_ContainerC, assetPath);
					variableCount += DataId_node_ContainerC.SetData((FSData)ContainerC, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ScratchId:
					FSScratchNode ScratchId_node_ContainerC = graph.AddNode<FSScratchNode>();
					GetPort("ContainerC").Connect(ScratchId_node_ContainerC.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ScratchId_node_ContainerC, assetPath);
					variableCount += ScratchId_node_ContainerC.SetData((FSScratch)ContainerC, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AnimId:
					FSAnimNode AnimId_node_ContainerC = graph.AddNode<FSAnimNode>();
					GetPort("ContainerC").Connect(AnimId_node_ContainerC.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AnimId_node_ContainerC, assetPath);
					variableCount += AnimId_node_ContainerC.SetData((FSAnim)ContainerC, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SpeedId:
					FSSpeedNode SpeedId_node_ContainerC = graph.AddNode<FSSpeedNode>();
					GetPort("ContainerC").Connect(SpeedId_node_ContainerC.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpeedId_node_ContainerC, assetPath);
					variableCount += SpeedId_node_ContainerC.SetData((FSSpeed)ContainerC, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.PhysicsId:
					FSPhysicsNode PhysicsId_node_ContainerC = graph.AddNode<FSPhysicsNode>();
					GetPort("ContainerC").Connect(PhysicsId_node_ContainerC.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(PhysicsId_node_ContainerC, assetPath);
					variableCount += PhysicsId_node_ContainerC.SetData((FSPhysics)ContainerC, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CollisionId:
					FSCollisionNode CollisionId_node_ContainerC = graph.AddNode<FSCollisionNode>();
					GetPort("ContainerC").Connect(CollisionId_node_ContainerC.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CollisionId_node_ContainerC, assetPath);
					variableCount += CollisionId_node_ContainerC.SetData((FSCollision)ContainerC, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.TimerId:
					FSTimerNode TimerId_node_ContainerC = graph.AddNode<FSTimerNode>();
					GetPort("ContainerC").Connect(TimerId_node_ContainerC.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(TimerId_node_ContainerC, assetPath);
					variableCount += TimerId_node_ContainerC.SetData((FSTimer)ContainerC, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.LagId:
					FSLagNode LagId_node_ContainerC = graph.AddNode<FSLagNode>();
					GetPort("ContainerC").Connect(LagId_node_ContainerC.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LagId_node_ContainerC, assetPath);
					variableCount += LagId_node_ContainerC.SetData((FSLag)ContainerC, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.EffectsId:
					FSEffectsNode EffectsId_node_ContainerC = graph.AddNode<FSEffectsNode>();
					GetPort("ContainerC").Connect(EffectsId_node_ContainerC.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EffectsId_node_ContainerC, assetPath);
					variableCount += EffectsId_node_ContainerC.SetData((FSEffects)ContainerC, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ColorsId:
					FSColorsNode ColorsId_node_ContainerC = graph.AddNode<FSColorsNode>();
					GetPort("ContainerC").Connect(ColorsId_node_ContainerC.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ColorsId_node_ContainerC, assetPath);
					variableCount += ColorsId_node_ContainerC.SetData((FSColors)ContainerC, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.OnHitId:
					FSOnHitNode OnHitId_node_ContainerC = graph.AddNode<FSOnHitNode>();
					GetPort("ContainerC").Connect(OnHitId_node_ContainerC.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnHitId_node_ContainerC, assetPath);
					variableCount += OnHitId_node_ContainerC.SetData((FSOnHit)ContainerC, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RandomId:
					FSRandomNode RandomId_node_ContainerC = graph.AddNode<FSRandomNode>();
					GetPort("ContainerC").Connect(RandomId_node_ContainerC.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RandomId_node_ContainerC, assetPath);
					variableCount += RandomId_node_ContainerC.SetData((FSRandom)ContainerC, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CameraId:
					FSCameraInfoNode CameraId_node_ContainerC = graph.AddNode<FSCameraInfoNode>();
					GetPort("ContainerC").Connect(CameraId_node_ContainerC.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CameraId_node_ContainerC, assetPath);
					variableCount += CameraId_node_ContainerC.SetData((FSCameraInfo)ContainerC, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SportsId:
					FSSportsNode SportsId_node_ContainerC = graph.AddNode<FSSportsNode>();
					GetPort("ContainerC").Connect(SportsId_node_ContainerC.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SportsId_node_ContainerC, assetPath);
					variableCount += SportsId_node_ContainerC.SetData((FSSports)ContainerC, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.Vector2Mag:
					FSVector2MagNode Vector2Mag_node_ContainerC = graph.AddNode<FSVector2MagNode>();
					GetPort("ContainerC").Connect(Vector2Mag_node_ContainerC.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(Vector2Mag_node_ContainerC, assetPath);
					variableCount += Vector2Mag_node_ContainerC.SetData((FSVector2Mag)ContainerC, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CPUHelpId:
					FSCpuHelpNode CPUHelpId_node_ContainerC = graph.AddNode<FSCpuHelpNode>();
					GetPort("ContainerC").Connect(CPUHelpId_node_ContainerC.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CPUHelpId_node_ContainerC, assetPath);
					variableCount += CPUHelpId_node_ContainerC.SetData((FSCpuHelp)ContainerC, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ItemId:
					FSItemNode ItemId_node_ContainerC = graph.AddNode<FSItemNode>();
					GetPort("ContainerC").Connect(ItemId_node_ContainerC.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ItemId_node_ContainerC, assetPath);
					variableCount += ItemId_node_ContainerC.SetData((FSItem)ContainerC, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ModeId:
					FSModeNode ModeId_node_ContainerC = graph.AddNode<FSModeNode>();
					GetPort("ContainerC").Connect(ModeId_node_ContainerC.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ModeId_node_ContainerC, assetPath);
					variableCount += ModeId_node_ContainerC.SetData((FSMode)ContainerC, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.JumpsId:
					FSJumpsNode JumpsId_node_ContainerC = graph.AddNode<FSJumpsNode>();
					GetPort("ContainerC").Connect(JumpsId_node_ContainerC.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(JumpsId_node_ContainerC, assetPath);
					variableCount += JumpsId_node_ContainerC.SetData((FSJumps)ContainerC, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RootAnimId:
					FSRootAnimNode RootAnimId_node_ContainerC = graph.AddNode<FSRootAnimNode>();
					GetPort("ContainerC").Connect(RootAnimId_node_ContainerC.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RootAnimId_node_ContainerC, assetPath);
					variableCount += RootAnimId_node_ContainerC.SetData((FSRootAnim)ContainerC, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FloatId:
					FSValueNode FloatId_node_ContainerC = graph.AddNode<FSValueNode>();
					GetPort("ContainerC").Connect(FloatId_node_ContainerC.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FloatId_node_ContainerC, assetPath);
					variableCount += FloatId_node_ContainerC.SetData((FSValue)ContainerC, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
			}
			
			return variableCount;
		}
		
		public new FSFunc GetData()
		{
			FSFunc objToReturn = new FSFunc();
			objToReturn.TID = TypeId.FuncId;
			objToReturn.Version = Version;
			objToReturn.Way = Way;
			if (GetPort("ContainerA").ConnectionCount > 0)
			{
				FloatSourceNode FloatSource_Node = (FloatSourceNode)GetPort("ContainerA").GetConnection(0).node;
				switch (FloatSource_Node.TID)
				{
					case FloatSource.TypeId.AgentId:
						FSAgentNode AgentId_FloatSource_Node = (FSAgentNode)GetPort("ContainerA").GetConnection(0).node;
						objToReturn.ContainerA = AgentId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.BonesId:
						FSBonesNode BonesId_FloatSource_Node = (FSBonesNode)GetPort("ContainerA").GetConnection(0).node;
						objToReturn.ContainerA = BonesId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AttackId:
						FSAttackNode AttackId_FloatSource_Node = (FSAttackNode)GetPort("ContainerA").GetConnection(0).node;
						objToReturn.ContainerA = AttackId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FrameId:
						FSFrameNode FrameId_FloatSource_Node = (FSFrameNode)GetPort("ContainerA").GetConnection(0).node;
						objToReturn.ContainerA = FrameId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.InputId:
						FSInputNode InputId_FloatSource_Node = (FSInputNode)GetPort("ContainerA").GetConnection(0).node;
						objToReturn.ContainerA = InputId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FuncId:
						FSFuncNode FuncId_FloatSource_Node = (FSFuncNode)GetPort("ContainerA").GetConnection(0).node;
						objToReturn.ContainerA = FuncId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.MovementId:
						FSMovementNode MovementId_FloatSource_Node = (FSMovementNode)GetPort("ContainerA").GetConnection(0).node;
						objToReturn.ContainerA = MovementId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CombatId:
						FSCombatNode CombatId_FloatSource_Node = (FSCombatNode)GetPort("ContainerA").GetConnection(0).node;
						objToReturn.ContainerA = CombatId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.GrabsId:
						FSGrabsNode GrabsId_FloatSource_Node = (FSGrabsNode)GetPort("ContainerA").GetConnection(0).node;
						objToReturn.ContainerA = GrabsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.DataId:
						FSDataNode DataId_FloatSource_Node = (FSDataNode)GetPort("ContainerA").GetConnection(0).node;
						objToReturn.ContainerA = DataId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ScratchId:
						FSScratchNode ScratchId_FloatSource_Node = (FSScratchNode)GetPort("ContainerA").GetConnection(0).node;
						objToReturn.ContainerA = ScratchId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AnimId:
						FSAnimNode AnimId_FloatSource_Node = (FSAnimNode)GetPort("ContainerA").GetConnection(0).node;
						objToReturn.ContainerA = AnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SpeedId:
						FSSpeedNode SpeedId_FloatSource_Node = (FSSpeedNode)GetPort("ContainerA").GetConnection(0).node;
						objToReturn.ContainerA = SpeedId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.PhysicsId:
						FSPhysicsNode PhysicsId_FloatSource_Node = (FSPhysicsNode)GetPort("ContainerA").GetConnection(0).node;
						objToReturn.ContainerA = PhysicsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CollisionId:
						FSCollisionNode CollisionId_FloatSource_Node = (FSCollisionNode)GetPort("ContainerA").GetConnection(0).node;
						objToReturn.ContainerA = CollisionId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.TimerId:
						FSTimerNode TimerId_FloatSource_Node = (FSTimerNode)GetPort("ContainerA").GetConnection(0).node;
						objToReturn.ContainerA = TimerId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.LagId:
						FSLagNode LagId_FloatSource_Node = (FSLagNode)GetPort("ContainerA").GetConnection(0).node;
						objToReturn.ContainerA = LagId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.EffectsId:
						FSEffectsNode EffectsId_FloatSource_Node = (FSEffectsNode)GetPort("ContainerA").GetConnection(0).node;
						objToReturn.ContainerA = EffectsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ColorsId:
						FSColorsNode ColorsId_FloatSource_Node = (FSColorsNode)GetPort("ContainerA").GetConnection(0).node;
						objToReturn.ContainerA = ColorsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.OnHitId:
						FSOnHitNode OnHitId_FloatSource_Node = (FSOnHitNode)GetPort("ContainerA").GetConnection(0).node;
						objToReturn.ContainerA = OnHitId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RandomId:
						FSRandomNode RandomId_FloatSource_Node = (FSRandomNode)GetPort("ContainerA").GetConnection(0).node;
						objToReturn.ContainerA = RandomId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CameraId:
						FSCameraInfoNode CameraId_FloatSource_Node = (FSCameraInfoNode)GetPort("ContainerA").GetConnection(0).node;
						objToReturn.ContainerA = CameraId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SportsId:
						FSSportsNode SportsId_FloatSource_Node = (FSSportsNode)GetPort("ContainerA").GetConnection(0).node;
						objToReturn.ContainerA = SportsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.Vector2Mag:
						FSVector2MagNode Vector2Mag_FloatSource_Node = (FSVector2MagNode)GetPort("ContainerA").GetConnection(0).node;
						objToReturn.ContainerA = Vector2Mag_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CPUHelpId:
						FSCpuHelpNode CPUHelpId_FloatSource_Node = (FSCpuHelpNode)GetPort("ContainerA").GetConnection(0).node;
						objToReturn.ContainerA = CPUHelpId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ItemId:
						FSItemNode ItemId_FloatSource_Node = (FSItemNode)GetPort("ContainerA").GetConnection(0).node;
						objToReturn.ContainerA = ItemId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ModeId:
						FSModeNode ModeId_FloatSource_Node = (FSModeNode)GetPort("ContainerA").GetConnection(0).node;
						objToReturn.ContainerA = ModeId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.JumpsId:
						FSJumpsNode JumpsId_FloatSource_Node = (FSJumpsNode)GetPort("ContainerA").GetConnection(0).node;
						objToReturn.ContainerA = JumpsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RootAnimId:
						FSRootAnimNode RootAnimId_FloatSource_Node = (FSRootAnimNode)GetPort("ContainerA").GetConnection(0).node;
						objToReturn.ContainerA = RootAnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FloatId:
						FSValueNode FloatId_FloatSource_Node = (FSValueNode)GetPort("ContainerA").GetConnection(0).node;
						objToReturn.ContainerA = FloatId_FloatSource_Node.GetData();
					break;
				}
			}
			if (GetPort("ContainerB").ConnectionCount > 0)
			{
				FloatSourceNode FloatSource_Node = (FloatSourceNode)GetPort("ContainerB").GetConnection(0).node;
				switch (FloatSource_Node.TID)
				{
					case FloatSource.TypeId.AgentId:
						FSAgentNode AgentId_FloatSource_Node = (FSAgentNode)GetPort("ContainerB").GetConnection(0).node;
						objToReturn.ContainerB = AgentId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.BonesId:
						FSBonesNode BonesId_FloatSource_Node = (FSBonesNode)GetPort("ContainerB").GetConnection(0).node;
						objToReturn.ContainerB = BonesId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AttackId:
						FSAttackNode AttackId_FloatSource_Node = (FSAttackNode)GetPort("ContainerB").GetConnection(0).node;
						objToReturn.ContainerB = AttackId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FrameId:
						FSFrameNode FrameId_FloatSource_Node = (FSFrameNode)GetPort("ContainerB").GetConnection(0).node;
						objToReturn.ContainerB = FrameId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.InputId:
						FSInputNode InputId_FloatSource_Node = (FSInputNode)GetPort("ContainerB").GetConnection(0).node;
						objToReturn.ContainerB = InputId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FuncId:
						FSFuncNode FuncId_FloatSource_Node = (FSFuncNode)GetPort("ContainerB").GetConnection(0).node;
						objToReturn.ContainerB = FuncId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.MovementId:
						FSMovementNode MovementId_FloatSource_Node = (FSMovementNode)GetPort("ContainerB").GetConnection(0).node;
						objToReturn.ContainerB = MovementId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CombatId:
						FSCombatNode CombatId_FloatSource_Node = (FSCombatNode)GetPort("ContainerB").GetConnection(0).node;
						objToReturn.ContainerB = CombatId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.GrabsId:
						FSGrabsNode GrabsId_FloatSource_Node = (FSGrabsNode)GetPort("ContainerB").GetConnection(0).node;
						objToReturn.ContainerB = GrabsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.DataId:
						FSDataNode DataId_FloatSource_Node = (FSDataNode)GetPort("ContainerB").GetConnection(0).node;
						objToReturn.ContainerB = DataId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ScratchId:
						FSScratchNode ScratchId_FloatSource_Node = (FSScratchNode)GetPort("ContainerB").GetConnection(0).node;
						objToReturn.ContainerB = ScratchId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AnimId:
						FSAnimNode AnimId_FloatSource_Node = (FSAnimNode)GetPort("ContainerB").GetConnection(0).node;
						objToReturn.ContainerB = AnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SpeedId:
						FSSpeedNode SpeedId_FloatSource_Node = (FSSpeedNode)GetPort("ContainerB").GetConnection(0).node;
						objToReturn.ContainerB = SpeedId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.PhysicsId:
						FSPhysicsNode PhysicsId_FloatSource_Node = (FSPhysicsNode)GetPort("ContainerB").GetConnection(0).node;
						objToReturn.ContainerB = PhysicsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CollisionId:
						FSCollisionNode CollisionId_FloatSource_Node = (FSCollisionNode)GetPort("ContainerB").GetConnection(0).node;
						objToReturn.ContainerB = CollisionId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.TimerId:
						FSTimerNode TimerId_FloatSource_Node = (FSTimerNode)GetPort("ContainerB").GetConnection(0).node;
						objToReturn.ContainerB = TimerId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.LagId:
						FSLagNode LagId_FloatSource_Node = (FSLagNode)GetPort("ContainerB").GetConnection(0).node;
						objToReturn.ContainerB = LagId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.EffectsId:
						FSEffectsNode EffectsId_FloatSource_Node = (FSEffectsNode)GetPort("ContainerB").GetConnection(0).node;
						objToReturn.ContainerB = EffectsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ColorsId:
						FSColorsNode ColorsId_FloatSource_Node = (FSColorsNode)GetPort("ContainerB").GetConnection(0).node;
						objToReturn.ContainerB = ColorsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.OnHitId:
						FSOnHitNode OnHitId_FloatSource_Node = (FSOnHitNode)GetPort("ContainerB").GetConnection(0).node;
						objToReturn.ContainerB = OnHitId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RandomId:
						FSRandomNode RandomId_FloatSource_Node = (FSRandomNode)GetPort("ContainerB").GetConnection(0).node;
						objToReturn.ContainerB = RandomId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CameraId:
						FSCameraInfoNode CameraId_FloatSource_Node = (FSCameraInfoNode)GetPort("ContainerB").GetConnection(0).node;
						objToReturn.ContainerB = CameraId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SportsId:
						FSSportsNode SportsId_FloatSource_Node = (FSSportsNode)GetPort("ContainerB").GetConnection(0).node;
						objToReturn.ContainerB = SportsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.Vector2Mag:
						FSVector2MagNode Vector2Mag_FloatSource_Node = (FSVector2MagNode)GetPort("ContainerB").GetConnection(0).node;
						objToReturn.ContainerB = Vector2Mag_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CPUHelpId:
						FSCpuHelpNode CPUHelpId_FloatSource_Node = (FSCpuHelpNode)GetPort("ContainerB").GetConnection(0).node;
						objToReturn.ContainerB = CPUHelpId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ItemId:
						FSItemNode ItemId_FloatSource_Node = (FSItemNode)GetPort("ContainerB").GetConnection(0).node;
						objToReturn.ContainerB = ItemId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ModeId:
						FSModeNode ModeId_FloatSource_Node = (FSModeNode)GetPort("ContainerB").GetConnection(0).node;
						objToReturn.ContainerB = ModeId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.JumpsId:
						FSJumpsNode JumpsId_FloatSource_Node = (FSJumpsNode)GetPort("ContainerB").GetConnection(0).node;
						objToReturn.ContainerB = JumpsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RootAnimId:
						FSRootAnimNode RootAnimId_FloatSource_Node = (FSRootAnimNode)GetPort("ContainerB").GetConnection(0).node;
						objToReturn.ContainerB = RootAnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FloatId:
						FSValueNode FloatId_FloatSource_Node = (FSValueNode)GetPort("ContainerB").GetConnection(0).node;
						objToReturn.ContainerB = FloatId_FloatSource_Node.GetData();
					break;
				}
			}
			if (GetPort("ContainerC").ConnectionCount > 0)
			{
				FloatSourceNode FloatSource_Node = (FloatSourceNode)GetPort("ContainerC").GetConnection(0).node;
				switch (FloatSource_Node.TID)
				{
					case FloatSource.TypeId.AgentId:
						FSAgentNode AgentId_FloatSource_Node = (FSAgentNode)GetPort("ContainerC").GetConnection(0).node;
						objToReturn.ContainerC = AgentId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.BonesId:
						FSBonesNode BonesId_FloatSource_Node = (FSBonesNode)GetPort("ContainerC").GetConnection(0).node;
						objToReturn.ContainerC = BonesId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AttackId:
						FSAttackNode AttackId_FloatSource_Node = (FSAttackNode)GetPort("ContainerC").GetConnection(0).node;
						objToReturn.ContainerC = AttackId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FrameId:
						FSFrameNode FrameId_FloatSource_Node = (FSFrameNode)GetPort("ContainerC").GetConnection(0).node;
						objToReturn.ContainerC = FrameId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.InputId:
						FSInputNode InputId_FloatSource_Node = (FSInputNode)GetPort("ContainerC").GetConnection(0).node;
						objToReturn.ContainerC = InputId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FuncId:
						FSFuncNode FuncId_FloatSource_Node = (FSFuncNode)GetPort("ContainerC").GetConnection(0).node;
						objToReturn.ContainerC = FuncId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.MovementId:
						FSMovementNode MovementId_FloatSource_Node = (FSMovementNode)GetPort("ContainerC").GetConnection(0).node;
						objToReturn.ContainerC = MovementId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CombatId:
						FSCombatNode CombatId_FloatSource_Node = (FSCombatNode)GetPort("ContainerC").GetConnection(0).node;
						objToReturn.ContainerC = CombatId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.GrabsId:
						FSGrabsNode GrabsId_FloatSource_Node = (FSGrabsNode)GetPort("ContainerC").GetConnection(0).node;
						objToReturn.ContainerC = GrabsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.DataId:
						FSDataNode DataId_FloatSource_Node = (FSDataNode)GetPort("ContainerC").GetConnection(0).node;
						objToReturn.ContainerC = DataId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ScratchId:
						FSScratchNode ScratchId_FloatSource_Node = (FSScratchNode)GetPort("ContainerC").GetConnection(0).node;
						objToReturn.ContainerC = ScratchId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AnimId:
						FSAnimNode AnimId_FloatSource_Node = (FSAnimNode)GetPort("ContainerC").GetConnection(0).node;
						objToReturn.ContainerC = AnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SpeedId:
						FSSpeedNode SpeedId_FloatSource_Node = (FSSpeedNode)GetPort("ContainerC").GetConnection(0).node;
						objToReturn.ContainerC = SpeedId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.PhysicsId:
						FSPhysicsNode PhysicsId_FloatSource_Node = (FSPhysicsNode)GetPort("ContainerC").GetConnection(0).node;
						objToReturn.ContainerC = PhysicsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CollisionId:
						FSCollisionNode CollisionId_FloatSource_Node = (FSCollisionNode)GetPort("ContainerC").GetConnection(0).node;
						objToReturn.ContainerC = CollisionId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.TimerId:
						FSTimerNode TimerId_FloatSource_Node = (FSTimerNode)GetPort("ContainerC").GetConnection(0).node;
						objToReturn.ContainerC = TimerId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.LagId:
						FSLagNode LagId_FloatSource_Node = (FSLagNode)GetPort("ContainerC").GetConnection(0).node;
						objToReturn.ContainerC = LagId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.EffectsId:
						FSEffectsNode EffectsId_FloatSource_Node = (FSEffectsNode)GetPort("ContainerC").GetConnection(0).node;
						objToReturn.ContainerC = EffectsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ColorsId:
						FSColorsNode ColorsId_FloatSource_Node = (FSColorsNode)GetPort("ContainerC").GetConnection(0).node;
						objToReturn.ContainerC = ColorsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.OnHitId:
						FSOnHitNode OnHitId_FloatSource_Node = (FSOnHitNode)GetPort("ContainerC").GetConnection(0).node;
						objToReturn.ContainerC = OnHitId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RandomId:
						FSRandomNode RandomId_FloatSource_Node = (FSRandomNode)GetPort("ContainerC").GetConnection(0).node;
						objToReturn.ContainerC = RandomId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CameraId:
						FSCameraInfoNode CameraId_FloatSource_Node = (FSCameraInfoNode)GetPort("ContainerC").GetConnection(0).node;
						objToReturn.ContainerC = CameraId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SportsId:
						FSSportsNode SportsId_FloatSource_Node = (FSSportsNode)GetPort("ContainerC").GetConnection(0).node;
						objToReturn.ContainerC = SportsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.Vector2Mag:
						FSVector2MagNode Vector2Mag_FloatSource_Node = (FSVector2MagNode)GetPort("ContainerC").GetConnection(0).node;
						objToReturn.ContainerC = Vector2Mag_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CPUHelpId:
						FSCpuHelpNode CPUHelpId_FloatSource_Node = (FSCpuHelpNode)GetPort("ContainerC").GetConnection(0).node;
						objToReturn.ContainerC = CPUHelpId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ItemId:
						FSItemNode ItemId_FloatSource_Node = (FSItemNode)GetPort("ContainerC").GetConnection(0).node;
						objToReturn.ContainerC = ItemId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ModeId:
						FSModeNode ModeId_FloatSource_Node = (FSModeNode)GetPort("ContainerC").GetConnection(0).node;
						objToReturn.ContainerC = ModeId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.JumpsId:
						FSJumpsNode JumpsId_FloatSource_Node = (FSJumpsNode)GetPort("ContainerC").GetConnection(0).node;
						objToReturn.ContainerC = JumpsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RootAnimId:
						FSRootAnimNode RootAnimId_FloatSource_Node = (FSRootAnimNode)GetPort("ContainerC").GetConnection(0).node;
						objToReturn.ContainerC = RootAnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FloatId:
						FSValueNode FloatId_FloatSource_Node = (FSValueNode)GetPort("ContainerC").GetConnection(0).node;
						objToReturn.ContainerC = FloatId_FloatSource_Node.GetData();
					break;
				}
			}
			return objToReturn;
		}
	}
}

