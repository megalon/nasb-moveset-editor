// * 
// * 
// * This file was generated using MovesetParser_to_xNode by megalon2d
// * https://github.com/megalon/MovesetParser_to_xNode
// * 
// * 
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEditor;
using XNode;
using XNodeEditor;
using MovesetParser;
using MovesetParser.FloatSources;
using MovesetParser.Jumps;
using MovesetParser.CheckThings;
using MovesetParser.StateActions;
using MovesetParser.ObjectSources;
using NASB_Moveset_Editor.FloatSources;
using NASB_Moveset_Editor.Jumps;
using NASB_Moveset_Editor.CheckThings;
using NASB_Moveset_Editor.StateActions;
using NASB_Moveset_Editor.ObjectSources;
using static MovesetParser.FloatSources.FloatSource;

namespace NASB_Moveset_Editor.FloatSources
{
	public class FSRandomNode : FloatSourceNode
	{
		[Input(connectionType = ConnectionType.Override)] public FloatSource NodeInput;
		public bool Ratio;
		[Output(connectionType = ConnectionType.Override)] public FloatSource A;
		[Output(connectionType = ConnectionType.Override)] public FloatSource B;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.RandomId;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(FSRandom data, MovesetGraph graph, string assetPath, Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(FSRandom));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			Ratio = data.Ratio;
			A = data.A;
			
			switch (A.TID)
			{
				case FloatSource.TypeId.AgentId:
					FSAgentNode AgentId_node_A = graph.AddNode<FSAgentNode>();
					GetPort("A").Connect(AgentId_node_A.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AgentId_node_A, assetPath);
					variableCount += AgentId_node_A.SetData((FSAgent)A, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.BonesId:
					FSBonesNode BonesId_node_A = graph.AddNode<FSBonesNode>();
					GetPort("A").Connect(BonesId_node_A.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BonesId_node_A, assetPath);
					variableCount += BonesId_node_A.SetData((FSBones)A, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AttackId:
					FSAttackNode AttackId_node_A = graph.AddNode<FSAttackNode>();
					GetPort("A").Connect(AttackId_node_A.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AttackId_node_A, assetPath);
					variableCount += AttackId_node_A.SetData((FSAttack)A, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FrameId:
					FSFrameNode FrameId_node_A = graph.AddNode<FSFrameNode>();
					GetPort("A").Connect(FrameId_node_A.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FrameId_node_A, assetPath);
					variableCount += FrameId_node_A.SetData((FSFrame)A, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.InputId:
					FSInputNode InputId_node_A = graph.AddNode<FSInputNode>();
					GetPort("A").Connect(InputId_node_A.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputId_node_A, assetPath);
					variableCount += InputId_node_A.SetData((FSInput)A, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FuncId:
					FSFuncNode FuncId_node_A = graph.AddNode<FSFuncNode>();
					GetPort("A").Connect(FuncId_node_A.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FuncId_node_A, assetPath);
					variableCount += FuncId_node_A.SetData((FSFunc)A, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.MovementId:
					FSMovementNode MovementId_node_A = graph.AddNode<FSMovementNode>();
					GetPort("A").Connect(MovementId_node_A.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(MovementId_node_A, assetPath);
					variableCount += MovementId_node_A.SetData((FSMovement)A, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CombatId:
					FSCombatNode CombatId_node_A = graph.AddNode<FSCombatNode>();
					GetPort("A").Connect(CombatId_node_A.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CombatId_node_A, assetPath);
					variableCount += CombatId_node_A.SetData((FSCombat)A, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.GrabsId:
					FSGrabsNode GrabsId_node_A = graph.AddNode<FSGrabsNode>();
					GetPort("A").Connect(GrabsId_node_A.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(GrabsId_node_A, assetPath);
					variableCount += GrabsId_node_A.SetData((FSGrabs)A, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.DataId:
					FSDataNode DataId_node_A = graph.AddNode<FSDataNode>();
					GetPort("A").Connect(DataId_node_A.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DataId_node_A, assetPath);
					variableCount += DataId_node_A.SetData((FSData)A, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ScratchId:
					FSScratchNode ScratchId_node_A = graph.AddNode<FSScratchNode>();
					GetPort("A").Connect(ScratchId_node_A.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ScratchId_node_A, assetPath);
					variableCount += ScratchId_node_A.SetData((FSScratch)A, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AnimId:
					FSAnimNode AnimId_node_A = graph.AddNode<FSAnimNode>();
					GetPort("A").Connect(AnimId_node_A.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AnimId_node_A, assetPath);
					variableCount += AnimId_node_A.SetData((FSAnim)A, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SpeedId:
					FSSpeedNode SpeedId_node_A = graph.AddNode<FSSpeedNode>();
					GetPort("A").Connect(SpeedId_node_A.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpeedId_node_A, assetPath);
					variableCount += SpeedId_node_A.SetData((FSSpeed)A, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.PhysicsId:
					FSPhysicsNode PhysicsId_node_A = graph.AddNode<FSPhysicsNode>();
					GetPort("A").Connect(PhysicsId_node_A.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(PhysicsId_node_A, assetPath);
					variableCount += PhysicsId_node_A.SetData((FSPhysics)A, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CollisionId:
					FSCollisionNode CollisionId_node_A = graph.AddNode<FSCollisionNode>();
					GetPort("A").Connect(CollisionId_node_A.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CollisionId_node_A, assetPath);
					variableCount += CollisionId_node_A.SetData((FSCollision)A, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.TimerId:
					FSTimerNode TimerId_node_A = graph.AddNode<FSTimerNode>();
					GetPort("A").Connect(TimerId_node_A.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(TimerId_node_A, assetPath);
					variableCount += TimerId_node_A.SetData((FSTimer)A, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.LagId:
					FSLagNode LagId_node_A = graph.AddNode<FSLagNode>();
					GetPort("A").Connect(LagId_node_A.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LagId_node_A, assetPath);
					variableCount += LagId_node_A.SetData((FSLag)A, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.EffectsId:
					FSEffectsNode EffectsId_node_A = graph.AddNode<FSEffectsNode>();
					GetPort("A").Connect(EffectsId_node_A.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EffectsId_node_A, assetPath);
					variableCount += EffectsId_node_A.SetData((FSEffects)A, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ColorsId:
					FSColorsNode ColorsId_node_A = graph.AddNode<FSColorsNode>();
					GetPort("A").Connect(ColorsId_node_A.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ColorsId_node_A, assetPath);
					variableCount += ColorsId_node_A.SetData((FSColors)A, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.OnHitId:
					FSOnHitNode OnHitId_node_A = graph.AddNode<FSOnHitNode>();
					GetPort("A").Connect(OnHitId_node_A.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnHitId_node_A, assetPath);
					variableCount += OnHitId_node_A.SetData((FSOnHit)A, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RandomId:
					FSRandomNode RandomId_node_A = graph.AddNode<FSRandomNode>();
					GetPort("A").Connect(RandomId_node_A.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RandomId_node_A, assetPath);
					variableCount += RandomId_node_A.SetData((FSRandom)A, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CameraId:
					FSCameraInfoNode CameraId_node_A = graph.AddNode<FSCameraInfoNode>();
					GetPort("A").Connect(CameraId_node_A.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CameraId_node_A, assetPath);
					variableCount += CameraId_node_A.SetData((FSCameraInfo)A, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SportsId:
					FSSportsNode SportsId_node_A = graph.AddNode<FSSportsNode>();
					GetPort("A").Connect(SportsId_node_A.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SportsId_node_A, assetPath);
					variableCount += SportsId_node_A.SetData((FSSports)A, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.Vector2Mag:
					FSVector2MagNode Vector2Mag_node_A = graph.AddNode<FSVector2MagNode>();
					GetPort("A").Connect(Vector2Mag_node_A.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(Vector2Mag_node_A, assetPath);
					variableCount += Vector2Mag_node_A.SetData((FSVector2Mag)A, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CPUHelpId:
					FSCpuHelpNode CPUHelpId_node_A = graph.AddNode<FSCpuHelpNode>();
					GetPort("A").Connect(CPUHelpId_node_A.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CPUHelpId_node_A, assetPath);
					variableCount += CPUHelpId_node_A.SetData((FSCpuHelp)A, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ItemId:
					FSItemNode ItemId_node_A = graph.AddNode<FSItemNode>();
					GetPort("A").Connect(ItemId_node_A.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ItemId_node_A, assetPath);
					variableCount += ItemId_node_A.SetData((FSItem)A, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ModeId:
					FSModeNode ModeId_node_A = graph.AddNode<FSModeNode>();
					GetPort("A").Connect(ModeId_node_A.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ModeId_node_A, assetPath);
					variableCount += ModeId_node_A.SetData((FSMode)A, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.JumpsId:
					FSJumpsNode JumpsId_node_A = graph.AddNode<FSJumpsNode>();
					GetPort("A").Connect(JumpsId_node_A.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(JumpsId_node_A, assetPath);
					variableCount += JumpsId_node_A.SetData((FSJumps)A, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RootAnimId:
					FSRootAnimNode RootAnimId_node_A = graph.AddNode<FSRootAnimNode>();
					GetPort("A").Connect(RootAnimId_node_A.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RootAnimId_node_A, assetPath);
					variableCount += RootAnimId_node_A.SetData((FSRootAnim)A, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FloatId:
					FSValueNode FloatId_node_A = graph.AddNode<FSValueNode>();
					GetPort("A").Connect(FloatId_node_A.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FloatId_node_A, assetPath);
					variableCount += FloatId_node_A.SetData((FSValue)A, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
			}
			++variableCount;
			
			B = data.B;
			
			switch (B.TID)
			{
				case FloatSource.TypeId.AgentId:
					FSAgentNode AgentId_node_B = graph.AddNode<FSAgentNode>();
					GetPort("B").Connect(AgentId_node_B.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AgentId_node_B, assetPath);
					variableCount += AgentId_node_B.SetData((FSAgent)B, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.BonesId:
					FSBonesNode BonesId_node_B = graph.AddNode<FSBonesNode>();
					GetPort("B").Connect(BonesId_node_B.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BonesId_node_B, assetPath);
					variableCount += BonesId_node_B.SetData((FSBones)B, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AttackId:
					FSAttackNode AttackId_node_B = graph.AddNode<FSAttackNode>();
					GetPort("B").Connect(AttackId_node_B.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AttackId_node_B, assetPath);
					variableCount += AttackId_node_B.SetData((FSAttack)B, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FrameId:
					FSFrameNode FrameId_node_B = graph.AddNode<FSFrameNode>();
					GetPort("B").Connect(FrameId_node_B.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FrameId_node_B, assetPath);
					variableCount += FrameId_node_B.SetData((FSFrame)B, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.InputId:
					FSInputNode InputId_node_B = graph.AddNode<FSInputNode>();
					GetPort("B").Connect(InputId_node_B.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputId_node_B, assetPath);
					variableCount += InputId_node_B.SetData((FSInput)B, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FuncId:
					FSFuncNode FuncId_node_B = graph.AddNode<FSFuncNode>();
					GetPort("B").Connect(FuncId_node_B.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FuncId_node_B, assetPath);
					variableCount += FuncId_node_B.SetData((FSFunc)B, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.MovementId:
					FSMovementNode MovementId_node_B = graph.AddNode<FSMovementNode>();
					GetPort("B").Connect(MovementId_node_B.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(MovementId_node_B, assetPath);
					variableCount += MovementId_node_B.SetData((FSMovement)B, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CombatId:
					FSCombatNode CombatId_node_B = graph.AddNode<FSCombatNode>();
					GetPort("B").Connect(CombatId_node_B.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CombatId_node_B, assetPath);
					variableCount += CombatId_node_B.SetData((FSCombat)B, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.GrabsId:
					FSGrabsNode GrabsId_node_B = graph.AddNode<FSGrabsNode>();
					GetPort("B").Connect(GrabsId_node_B.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(GrabsId_node_B, assetPath);
					variableCount += GrabsId_node_B.SetData((FSGrabs)B, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.DataId:
					FSDataNode DataId_node_B = graph.AddNode<FSDataNode>();
					GetPort("B").Connect(DataId_node_B.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DataId_node_B, assetPath);
					variableCount += DataId_node_B.SetData((FSData)B, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ScratchId:
					FSScratchNode ScratchId_node_B = graph.AddNode<FSScratchNode>();
					GetPort("B").Connect(ScratchId_node_B.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ScratchId_node_B, assetPath);
					variableCount += ScratchId_node_B.SetData((FSScratch)B, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AnimId:
					FSAnimNode AnimId_node_B = graph.AddNode<FSAnimNode>();
					GetPort("B").Connect(AnimId_node_B.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AnimId_node_B, assetPath);
					variableCount += AnimId_node_B.SetData((FSAnim)B, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SpeedId:
					FSSpeedNode SpeedId_node_B = graph.AddNode<FSSpeedNode>();
					GetPort("B").Connect(SpeedId_node_B.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpeedId_node_B, assetPath);
					variableCount += SpeedId_node_B.SetData((FSSpeed)B, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.PhysicsId:
					FSPhysicsNode PhysicsId_node_B = graph.AddNode<FSPhysicsNode>();
					GetPort("B").Connect(PhysicsId_node_B.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(PhysicsId_node_B, assetPath);
					variableCount += PhysicsId_node_B.SetData((FSPhysics)B, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CollisionId:
					FSCollisionNode CollisionId_node_B = graph.AddNode<FSCollisionNode>();
					GetPort("B").Connect(CollisionId_node_B.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CollisionId_node_B, assetPath);
					variableCount += CollisionId_node_B.SetData((FSCollision)B, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.TimerId:
					FSTimerNode TimerId_node_B = graph.AddNode<FSTimerNode>();
					GetPort("B").Connect(TimerId_node_B.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(TimerId_node_B, assetPath);
					variableCount += TimerId_node_B.SetData((FSTimer)B, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.LagId:
					FSLagNode LagId_node_B = graph.AddNode<FSLagNode>();
					GetPort("B").Connect(LagId_node_B.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LagId_node_B, assetPath);
					variableCount += LagId_node_B.SetData((FSLag)B, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.EffectsId:
					FSEffectsNode EffectsId_node_B = graph.AddNode<FSEffectsNode>();
					GetPort("B").Connect(EffectsId_node_B.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EffectsId_node_B, assetPath);
					variableCount += EffectsId_node_B.SetData((FSEffects)B, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ColorsId:
					FSColorsNode ColorsId_node_B = graph.AddNode<FSColorsNode>();
					GetPort("B").Connect(ColorsId_node_B.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ColorsId_node_B, assetPath);
					variableCount += ColorsId_node_B.SetData((FSColors)B, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.OnHitId:
					FSOnHitNode OnHitId_node_B = graph.AddNode<FSOnHitNode>();
					GetPort("B").Connect(OnHitId_node_B.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnHitId_node_B, assetPath);
					variableCount += OnHitId_node_B.SetData((FSOnHit)B, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RandomId:
					FSRandomNode RandomId_node_B = graph.AddNode<FSRandomNode>();
					GetPort("B").Connect(RandomId_node_B.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RandomId_node_B, assetPath);
					variableCount += RandomId_node_B.SetData((FSRandom)B, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CameraId:
					FSCameraInfoNode CameraId_node_B = graph.AddNode<FSCameraInfoNode>();
					GetPort("B").Connect(CameraId_node_B.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CameraId_node_B, assetPath);
					variableCount += CameraId_node_B.SetData((FSCameraInfo)B, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SportsId:
					FSSportsNode SportsId_node_B = graph.AddNode<FSSportsNode>();
					GetPort("B").Connect(SportsId_node_B.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SportsId_node_B, assetPath);
					variableCount += SportsId_node_B.SetData((FSSports)B, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.Vector2Mag:
					FSVector2MagNode Vector2Mag_node_B = graph.AddNode<FSVector2MagNode>();
					GetPort("B").Connect(Vector2Mag_node_B.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(Vector2Mag_node_B, assetPath);
					variableCount += Vector2Mag_node_B.SetData((FSVector2Mag)B, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CPUHelpId:
					FSCpuHelpNode CPUHelpId_node_B = graph.AddNode<FSCpuHelpNode>();
					GetPort("B").Connect(CPUHelpId_node_B.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CPUHelpId_node_B, assetPath);
					variableCount += CPUHelpId_node_B.SetData((FSCpuHelp)B, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ItemId:
					FSItemNode ItemId_node_B = graph.AddNode<FSItemNode>();
					GetPort("B").Connect(ItemId_node_B.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ItemId_node_B, assetPath);
					variableCount += ItemId_node_B.SetData((FSItem)B, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ModeId:
					FSModeNode ModeId_node_B = graph.AddNode<FSModeNode>();
					GetPort("B").Connect(ModeId_node_B.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ModeId_node_B, assetPath);
					variableCount += ModeId_node_B.SetData((FSMode)B, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.JumpsId:
					FSJumpsNode JumpsId_node_B = graph.AddNode<FSJumpsNode>();
					GetPort("B").Connect(JumpsId_node_B.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(JumpsId_node_B, assetPath);
					variableCount += JumpsId_node_B.SetData((FSJumps)B, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RootAnimId:
					FSRootAnimNode RootAnimId_node_B = graph.AddNode<FSRootAnimNode>();
					GetPort("B").Connect(RootAnimId_node_B.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RootAnimId_node_B, assetPath);
					variableCount += RootAnimId_node_B.SetData((FSRootAnim)B, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FloatId:
					FSValueNode FloatId_node_B = graph.AddNode<FSValueNode>();
					GetPort("B").Connect(FloatId_node_B.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FloatId_node_B, assetPath);
					variableCount += FloatId_node_B.SetData((FSValue)B, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
			}
			
			return variableCount;
		}
		
		public new FSRandom GetData()
		{
			FSRandom objToReturn = new FSRandom();
			objToReturn.TID = TypeId.RandomId;
			objToReturn.Version = Version;
			objToReturn.Ratio = Ratio;
			if (GetPort("A").ConnectionCount > 0)
			{
				FloatSourceNode FloatSource_Node = (FloatSourceNode)GetPort("A").GetConnection(0).node;
				switch (FloatSource_Node.TID)
				{
					case FloatSource.TypeId.AgentId:
						FSAgentNode AgentId_FloatSource_Node = (FSAgentNode)GetPort("A").GetConnection(0).node;
						objToReturn.A = AgentId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.BonesId:
						FSBonesNode BonesId_FloatSource_Node = (FSBonesNode)GetPort("A").GetConnection(0).node;
						objToReturn.A = BonesId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AttackId:
						FSAttackNode AttackId_FloatSource_Node = (FSAttackNode)GetPort("A").GetConnection(0).node;
						objToReturn.A = AttackId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FrameId:
						FSFrameNode FrameId_FloatSource_Node = (FSFrameNode)GetPort("A").GetConnection(0).node;
						objToReturn.A = FrameId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.InputId:
						FSInputNode InputId_FloatSource_Node = (FSInputNode)GetPort("A").GetConnection(0).node;
						objToReturn.A = InputId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FuncId:
						FSFuncNode FuncId_FloatSource_Node = (FSFuncNode)GetPort("A").GetConnection(0).node;
						objToReturn.A = FuncId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.MovementId:
						FSMovementNode MovementId_FloatSource_Node = (FSMovementNode)GetPort("A").GetConnection(0).node;
						objToReturn.A = MovementId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CombatId:
						FSCombatNode CombatId_FloatSource_Node = (FSCombatNode)GetPort("A").GetConnection(0).node;
						objToReturn.A = CombatId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.GrabsId:
						FSGrabsNode GrabsId_FloatSource_Node = (FSGrabsNode)GetPort("A").GetConnection(0).node;
						objToReturn.A = GrabsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.DataId:
						FSDataNode DataId_FloatSource_Node = (FSDataNode)GetPort("A").GetConnection(0).node;
						objToReturn.A = DataId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ScratchId:
						FSScratchNode ScratchId_FloatSource_Node = (FSScratchNode)GetPort("A").GetConnection(0).node;
						objToReturn.A = ScratchId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AnimId:
						FSAnimNode AnimId_FloatSource_Node = (FSAnimNode)GetPort("A").GetConnection(0).node;
						objToReturn.A = AnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SpeedId:
						FSSpeedNode SpeedId_FloatSource_Node = (FSSpeedNode)GetPort("A").GetConnection(0).node;
						objToReturn.A = SpeedId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.PhysicsId:
						FSPhysicsNode PhysicsId_FloatSource_Node = (FSPhysicsNode)GetPort("A").GetConnection(0).node;
						objToReturn.A = PhysicsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CollisionId:
						FSCollisionNode CollisionId_FloatSource_Node = (FSCollisionNode)GetPort("A").GetConnection(0).node;
						objToReturn.A = CollisionId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.TimerId:
						FSTimerNode TimerId_FloatSource_Node = (FSTimerNode)GetPort("A").GetConnection(0).node;
						objToReturn.A = TimerId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.LagId:
						FSLagNode LagId_FloatSource_Node = (FSLagNode)GetPort("A").GetConnection(0).node;
						objToReturn.A = LagId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.EffectsId:
						FSEffectsNode EffectsId_FloatSource_Node = (FSEffectsNode)GetPort("A").GetConnection(0).node;
						objToReturn.A = EffectsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ColorsId:
						FSColorsNode ColorsId_FloatSource_Node = (FSColorsNode)GetPort("A").GetConnection(0).node;
						objToReturn.A = ColorsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.OnHitId:
						FSOnHitNode OnHitId_FloatSource_Node = (FSOnHitNode)GetPort("A").GetConnection(0).node;
						objToReturn.A = OnHitId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RandomId:
						FSRandomNode RandomId_FloatSource_Node = (FSRandomNode)GetPort("A").GetConnection(0).node;
						objToReturn.A = RandomId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CameraId:
						FSCameraInfoNode CameraId_FloatSource_Node = (FSCameraInfoNode)GetPort("A").GetConnection(0).node;
						objToReturn.A = CameraId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SportsId:
						FSSportsNode SportsId_FloatSource_Node = (FSSportsNode)GetPort("A").GetConnection(0).node;
						objToReturn.A = SportsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.Vector2Mag:
						FSVector2MagNode Vector2Mag_FloatSource_Node = (FSVector2MagNode)GetPort("A").GetConnection(0).node;
						objToReturn.A = Vector2Mag_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CPUHelpId:
						FSCpuHelpNode CPUHelpId_FloatSource_Node = (FSCpuHelpNode)GetPort("A").GetConnection(0).node;
						objToReturn.A = CPUHelpId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ItemId:
						FSItemNode ItemId_FloatSource_Node = (FSItemNode)GetPort("A").GetConnection(0).node;
						objToReturn.A = ItemId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ModeId:
						FSModeNode ModeId_FloatSource_Node = (FSModeNode)GetPort("A").GetConnection(0).node;
						objToReturn.A = ModeId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.JumpsId:
						FSJumpsNode JumpsId_FloatSource_Node = (FSJumpsNode)GetPort("A").GetConnection(0).node;
						objToReturn.A = JumpsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RootAnimId:
						FSRootAnimNode RootAnimId_FloatSource_Node = (FSRootAnimNode)GetPort("A").GetConnection(0).node;
						objToReturn.A = RootAnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FloatId:
						FSValueNode FloatId_FloatSource_Node = (FSValueNode)GetPort("A").GetConnection(0).node;
						objToReturn.A = FloatId_FloatSource_Node.GetData();
					break;
				}
			}
			if (GetPort("B").ConnectionCount > 0)
			{
				FloatSourceNode FloatSource_Node = (FloatSourceNode)GetPort("B").GetConnection(0).node;
				switch (FloatSource_Node.TID)
				{
					case FloatSource.TypeId.AgentId:
						FSAgentNode AgentId_FloatSource_Node = (FSAgentNode)GetPort("B").GetConnection(0).node;
						objToReturn.B = AgentId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.BonesId:
						FSBonesNode BonesId_FloatSource_Node = (FSBonesNode)GetPort("B").GetConnection(0).node;
						objToReturn.B = BonesId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AttackId:
						FSAttackNode AttackId_FloatSource_Node = (FSAttackNode)GetPort("B").GetConnection(0).node;
						objToReturn.B = AttackId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FrameId:
						FSFrameNode FrameId_FloatSource_Node = (FSFrameNode)GetPort("B").GetConnection(0).node;
						objToReturn.B = FrameId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.InputId:
						FSInputNode InputId_FloatSource_Node = (FSInputNode)GetPort("B").GetConnection(0).node;
						objToReturn.B = InputId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FuncId:
						FSFuncNode FuncId_FloatSource_Node = (FSFuncNode)GetPort("B").GetConnection(0).node;
						objToReturn.B = FuncId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.MovementId:
						FSMovementNode MovementId_FloatSource_Node = (FSMovementNode)GetPort("B").GetConnection(0).node;
						objToReturn.B = MovementId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CombatId:
						FSCombatNode CombatId_FloatSource_Node = (FSCombatNode)GetPort("B").GetConnection(0).node;
						objToReturn.B = CombatId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.GrabsId:
						FSGrabsNode GrabsId_FloatSource_Node = (FSGrabsNode)GetPort("B").GetConnection(0).node;
						objToReturn.B = GrabsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.DataId:
						FSDataNode DataId_FloatSource_Node = (FSDataNode)GetPort("B").GetConnection(0).node;
						objToReturn.B = DataId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ScratchId:
						FSScratchNode ScratchId_FloatSource_Node = (FSScratchNode)GetPort("B").GetConnection(0).node;
						objToReturn.B = ScratchId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AnimId:
						FSAnimNode AnimId_FloatSource_Node = (FSAnimNode)GetPort("B").GetConnection(0).node;
						objToReturn.B = AnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SpeedId:
						FSSpeedNode SpeedId_FloatSource_Node = (FSSpeedNode)GetPort("B").GetConnection(0).node;
						objToReturn.B = SpeedId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.PhysicsId:
						FSPhysicsNode PhysicsId_FloatSource_Node = (FSPhysicsNode)GetPort("B").GetConnection(0).node;
						objToReturn.B = PhysicsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CollisionId:
						FSCollisionNode CollisionId_FloatSource_Node = (FSCollisionNode)GetPort("B").GetConnection(0).node;
						objToReturn.B = CollisionId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.TimerId:
						FSTimerNode TimerId_FloatSource_Node = (FSTimerNode)GetPort("B").GetConnection(0).node;
						objToReturn.B = TimerId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.LagId:
						FSLagNode LagId_FloatSource_Node = (FSLagNode)GetPort("B").GetConnection(0).node;
						objToReturn.B = LagId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.EffectsId:
						FSEffectsNode EffectsId_FloatSource_Node = (FSEffectsNode)GetPort("B").GetConnection(0).node;
						objToReturn.B = EffectsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ColorsId:
						FSColorsNode ColorsId_FloatSource_Node = (FSColorsNode)GetPort("B").GetConnection(0).node;
						objToReturn.B = ColorsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.OnHitId:
						FSOnHitNode OnHitId_FloatSource_Node = (FSOnHitNode)GetPort("B").GetConnection(0).node;
						objToReturn.B = OnHitId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RandomId:
						FSRandomNode RandomId_FloatSource_Node = (FSRandomNode)GetPort("B").GetConnection(0).node;
						objToReturn.B = RandomId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CameraId:
						FSCameraInfoNode CameraId_FloatSource_Node = (FSCameraInfoNode)GetPort("B").GetConnection(0).node;
						objToReturn.B = CameraId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SportsId:
						FSSportsNode SportsId_FloatSource_Node = (FSSportsNode)GetPort("B").GetConnection(0).node;
						objToReturn.B = SportsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.Vector2Mag:
						FSVector2MagNode Vector2Mag_FloatSource_Node = (FSVector2MagNode)GetPort("B").GetConnection(0).node;
						objToReturn.B = Vector2Mag_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CPUHelpId:
						FSCpuHelpNode CPUHelpId_FloatSource_Node = (FSCpuHelpNode)GetPort("B").GetConnection(0).node;
						objToReturn.B = CPUHelpId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ItemId:
						FSItemNode ItemId_FloatSource_Node = (FSItemNode)GetPort("B").GetConnection(0).node;
						objToReturn.B = ItemId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ModeId:
						FSModeNode ModeId_FloatSource_Node = (FSModeNode)GetPort("B").GetConnection(0).node;
						objToReturn.B = ModeId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.JumpsId:
						FSJumpsNode JumpsId_FloatSource_Node = (FSJumpsNode)GetPort("B").GetConnection(0).node;
						objToReturn.B = JumpsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RootAnimId:
						FSRootAnimNode RootAnimId_FloatSource_Node = (FSRootAnimNode)GetPort("B").GetConnection(0).node;
						objToReturn.B = RootAnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FloatId:
						FSValueNode FloatId_FloatSource_Node = (FSValueNode)GetPort("B").GetConnection(0).node;
						objToReturn.B = FloatId_FloatSource_Node.GetData();
					break;
				}
			}
			return objToReturn;
		}
	}
}

