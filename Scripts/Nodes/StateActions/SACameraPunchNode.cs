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
	public class SACameraPunchNode : StateActionNode
	{
		[Input(connectionType = ConnectionType.Override)] public StateAction NodeInput;
		[Output(connectionType = ConnectionType.Override)] public FloatSource X;
		[Output(connectionType = ConnectionType.Override)] public FloatSource Y;
		[Output(connectionType = ConnectionType.Override)] public FloatSource Z;
		[Output(connectionType = ConnectionType.Override)] public FloatSource T;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.CameraPunchId;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SACameraPunch data, MovesetGraph graph, string assetPath, Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SACameraPunch));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			X = data.X;
			
			switch (X.TID)
			{
				case FloatSource.TypeId.AgentId:
					FSAgentNode AgentId_node_X = graph.AddNode<FSAgentNode>();
					GetPort("X").Connect(AgentId_node_X.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AgentId_node_X, assetPath);
					variableCount += AgentId_node_X.SetData((FSAgent)X, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.BonesId:
					FSBonesNode BonesId_node_X = graph.AddNode<FSBonesNode>();
					GetPort("X").Connect(BonesId_node_X.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BonesId_node_X, assetPath);
					variableCount += BonesId_node_X.SetData((FSBones)X, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AttackId:
					FSAttackNode AttackId_node_X = graph.AddNode<FSAttackNode>();
					GetPort("X").Connect(AttackId_node_X.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AttackId_node_X, assetPath);
					variableCount += AttackId_node_X.SetData((FSAttack)X, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FrameId:
					FSFrameNode FrameId_node_X = graph.AddNode<FSFrameNode>();
					GetPort("X").Connect(FrameId_node_X.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FrameId_node_X, assetPath);
					variableCount += FrameId_node_X.SetData((FSFrame)X, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.InputId:
					FSInputNode InputId_node_X = graph.AddNode<FSInputNode>();
					GetPort("X").Connect(InputId_node_X.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputId_node_X, assetPath);
					variableCount += InputId_node_X.SetData((FSInput)X, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FuncId:
					FSFuncNode FuncId_node_X = graph.AddNode<FSFuncNode>();
					GetPort("X").Connect(FuncId_node_X.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FuncId_node_X, assetPath);
					variableCount += FuncId_node_X.SetData((FSFunc)X, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.MovementId:
					FSMovementNode MovementId_node_X = graph.AddNode<FSMovementNode>();
					GetPort("X").Connect(MovementId_node_X.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(MovementId_node_X, assetPath);
					variableCount += MovementId_node_X.SetData((FSMovement)X, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CombatId:
					FSCombatNode CombatId_node_X = graph.AddNode<FSCombatNode>();
					GetPort("X").Connect(CombatId_node_X.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CombatId_node_X, assetPath);
					variableCount += CombatId_node_X.SetData((FSCombat)X, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.GrabsId:
					FSGrabsNode GrabsId_node_X = graph.AddNode<FSGrabsNode>();
					GetPort("X").Connect(GrabsId_node_X.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(GrabsId_node_X, assetPath);
					variableCount += GrabsId_node_X.SetData((FSGrabs)X, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.DataId:
					FSDataNode DataId_node_X = graph.AddNode<FSDataNode>();
					GetPort("X").Connect(DataId_node_X.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DataId_node_X, assetPath);
					variableCount += DataId_node_X.SetData((FSData)X, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ScratchId:
					FSScratchNode ScratchId_node_X = graph.AddNode<FSScratchNode>();
					GetPort("X").Connect(ScratchId_node_X.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ScratchId_node_X, assetPath);
					variableCount += ScratchId_node_X.SetData((FSScratch)X, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AnimId:
					FSAnimNode AnimId_node_X = graph.AddNode<FSAnimNode>();
					GetPort("X").Connect(AnimId_node_X.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AnimId_node_X, assetPath);
					variableCount += AnimId_node_X.SetData((FSAnim)X, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SpeedId:
					FSSpeedNode SpeedId_node_X = graph.AddNode<FSSpeedNode>();
					GetPort("X").Connect(SpeedId_node_X.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpeedId_node_X, assetPath);
					variableCount += SpeedId_node_X.SetData((FSSpeed)X, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.PhysicsId:
					FSPhysicsNode PhysicsId_node_X = graph.AddNode<FSPhysicsNode>();
					GetPort("X").Connect(PhysicsId_node_X.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(PhysicsId_node_X, assetPath);
					variableCount += PhysicsId_node_X.SetData((FSPhysics)X, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CollisionId:
					FSCollisionNode CollisionId_node_X = graph.AddNode<FSCollisionNode>();
					GetPort("X").Connect(CollisionId_node_X.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CollisionId_node_X, assetPath);
					variableCount += CollisionId_node_X.SetData((FSCollision)X, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.TimerId:
					FSTimerNode TimerId_node_X = graph.AddNode<FSTimerNode>();
					GetPort("X").Connect(TimerId_node_X.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(TimerId_node_X, assetPath);
					variableCount += TimerId_node_X.SetData((FSTimer)X, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.LagId:
					FSLagNode LagId_node_X = graph.AddNode<FSLagNode>();
					GetPort("X").Connect(LagId_node_X.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LagId_node_X, assetPath);
					variableCount += LagId_node_X.SetData((FSLag)X, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.EffectsId:
					FSEffectsNode EffectsId_node_X = graph.AddNode<FSEffectsNode>();
					GetPort("X").Connect(EffectsId_node_X.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EffectsId_node_X, assetPath);
					variableCount += EffectsId_node_X.SetData((FSEffects)X, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ColorsId:
					FSColorsNode ColorsId_node_X = graph.AddNode<FSColorsNode>();
					GetPort("X").Connect(ColorsId_node_X.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ColorsId_node_X, assetPath);
					variableCount += ColorsId_node_X.SetData((FSColors)X, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.OnHitId:
					FSOnHitNode OnHitId_node_X = graph.AddNode<FSOnHitNode>();
					GetPort("X").Connect(OnHitId_node_X.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnHitId_node_X, assetPath);
					variableCount += OnHitId_node_X.SetData((FSOnHit)X, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RandomId:
					FSRandomNode RandomId_node_X = graph.AddNode<FSRandomNode>();
					GetPort("X").Connect(RandomId_node_X.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RandomId_node_X, assetPath);
					variableCount += RandomId_node_X.SetData((FSRandom)X, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CameraId:
					FSCameraInfoNode CameraId_node_X = graph.AddNode<FSCameraInfoNode>();
					GetPort("X").Connect(CameraId_node_X.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CameraId_node_X, assetPath);
					variableCount += CameraId_node_X.SetData((FSCameraInfo)X, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SportsId:
					FSSportsNode SportsId_node_X = graph.AddNode<FSSportsNode>();
					GetPort("X").Connect(SportsId_node_X.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SportsId_node_X, assetPath);
					variableCount += SportsId_node_X.SetData((FSSports)X, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.Vector2Mag:
					FSVector2MagNode Vector2Mag_node_X = graph.AddNode<FSVector2MagNode>();
					GetPort("X").Connect(Vector2Mag_node_X.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(Vector2Mag_node_X, assetPath);
					variableCount += Vector2Mag_node_X.SetData((FSVector2Mag)X, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CPUHelpId:
					FSCpuHelpNode CPUHelpId_node_X = graph.AddNode<FSCpuHelpNode>();
					GetPort("X").Connect(CPUHelpId_node_X.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CPUHelpId_node_X, assetPath);
					variableCount += CPUHelpId_node_X.SetData((FSCpuHelp)X, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ItemId:
					FSItemNode ItemId_node_X = graph.AddNode<FSItemNode>();
					GetPort("X").Connect(ItemId_node_X.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ItemId_node_X, assetPath);
					variableCount += ItemId_node_X.SetData((FSItem)X, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ModeId:
					FSModeNode ModeId_node_X = graph.AddNode<FSModeNode>();
					GetPort("X").Connect(ModeId_node_X.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ModeId_node_X, assetPath);
					variableCount += ModeId_node_X.SetData((FSMode)X, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.JumpsId:
					FSJumpsNode JumpsId_node_X = graph.AddNode<FSJumpsNode>();
					GetPort("X").Connect(JumpsId_node_X.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(JumpsId_node_X, assetPath);
					variableCount += JumpsId_node_X.SetData((FSJumps)X, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RootAnimId:
					FSRootAnimNode RootAnimId_node_X = graph.AddNode<FSRootAnimNode>();
					GetPort("X").Connect(RootAnimId_node_X.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RootAnimId_node_X, assetPath);
					variableCount += RootAnimId_node_X.SetData((FSRootAnim)X, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FloatId:
					FSValueNode FloatId_node_X = graph.AddNode<FSValueNode>();
					GetPort("X").Connect(FloatId_node_X.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FloatId_node_X, assetPath);
					variableCount += FloatId_node_X.SetData((FSValue)X, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
			}
			++variableCount;
			
			Y = data.Y;
			
			switch (Y.TID)
			{
				case FloatSource.TypeId.AgentId:
					FSAgentNode AgentId_node_Y = graph.AddNode<FSAgentNode>();
					GetPort("Y").Connect(AgentId_node_Y.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AgentId_node_Y, assetPath);
					variableCount += AgentId_node_Y.SetData((FSAgent)Y, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.BonesId:
					FSBonesNode BonesId_node_Y = graph.AddNode<FSBonesNode>();
					GetPort("Y").Connect(BonesId_node_Y.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BonesId_node_Y, assetPath);
					variableCount += BonesId_node_Y.SetData((FSBones)Y, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AttackId:
					FSAttackNode AttackId_node_Y = graph.AddNode<FSAttackNode>();
					GetPort("Y").Connect(AttackId_node_Y.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AttackId_node_Y, assetPath);
					variableCount += AttackId_node_Y.SetData((FSAttack)Y, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FrameId:
					FSFrameNode FrameId_node_Y = graph.AddNode<FSFrameNode>();
					GetPort("Y").Connect(FrameId_node_Y.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FrameId_node_Y, assetPath);
					variableCount += FrameId_node_Y.SetData((FSFrame)Y, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.InputId:
					FSInputNode InputId_node_Y = graph.AddNode<FSInputNode>();
					GetPort("Y").Connect(InputId_node_Y.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputId_node_Y, assetPath);
					variableCount += InputId_node_Y.SetData((FSInput)Y, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FuncId:
					FSFuncNode FuncId_node_Y = graph.AddNode<FSFuncNode>();
					GetPort("Y").Connect(FuncId_node_Y.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FuncId_node_Y, assetPath);
					variableCount += FuncId_node_Y.SetData((FSFunc)Y, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.MovementId:
					FSMovementNode MovementId_node_Y = graph.AddNode<FSMovementNode>();
					GetPort("Y").Connect(MovementId_node_Y.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(MovementId_node_Y, assetPath);
					variableCount += MovementId_node_Y.SetData((FSMovement)Y, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CombatId:
					FSCombatNode CombatId_node_Y = graph.AddNode<FSCombatNode>();
					GetPort("Y").Connect(CombatId_node_Y.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CombatId_node_Y, assetPath);
					variableCount += CombatId_node_Y.SetData((FSCombat)Y, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.GrabsId:
					FSGrabsNode GrabsId_node_Y = graph.AddNode<FSGrabsNode>();
					GetPort("Y").Connect(GrabsId_node_Y.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(GrabsId_node_Y, assetPath);
					variableCount += GrabsId_node_Y.SetData((FSGrabs)Y, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.DataId:
					FSDataNode DataId_node_Y = graph.AddNode<FSDataNode>();
					GetPort("Y").Connect(DataId_node_Y.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DataId_node_Y, assetPath);
					variableCount += DataId_node_Y.SetData((FSData)Y, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ScratchId:
					FSScratchNode ScratchId_node_Y = graph.AddNode<FSScratchNode>();
					GetPort("Y").Connect(ScratchId_node_Y.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ScratchId_node_Y, assetPath);
					variableCount += ScratchId_node_Y.SetData((FSScratch)Y, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AnimId:
					FSAnimNode AnimId_node_Y = graph.AddNode<FSAnimNode>();
					GetPort("Y").Connect(AnimId_node_Y.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AnimId_node_Y, assetPath);
					variableCount += AnimId_node_Y.SetData((FSAnim)Y, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SpeedId:
					FSSpeedNode SpeedId_node_Y = graph.AddNode<FSSpeedNode>();
					GetPort("Y").Connect(SpeedId_node_Y.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpeedId_node_Y, assetPath);
					variableCount += SpeedId_node_Y.SetData((FSSpeed)Y, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.PhysicsId:
					FSPhysicsNode PhysicsId_node_Y = graph.AddNode<FSPhysicsNode>();
					GetPort("Y").Connect(PhysicsId_node_Y.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(PhysicsId_node_Y, assetPath);
					variableCount += PhysicsId_node_Y.SetData((FSPhysics)Y, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CollisionId:
					FSCollisionNode CollisionId_node_Y = graph.AddNode<FSCollisionNode>();
					GetPort("Y").Connect(CollisionId_node_Y.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CollisionId_node_Y, assetPath);
					variableCount += CollisionId_node_Y.SetData((FSCollision)Y, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.TimerId:
					FSTimerNode TimerId_node_Y = graph.AddNode<FSTimerNode>();
					GetPort("Y").Connect(TimerId_node_Y.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(TimerId_node_Y, assetPath);
					variableCount += TimerId_node_Y.SetData((FSTimer)Y, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.LagId:
					FSLagNode LagId_node_Y = graph.AddNode<FSLagNode>();
					GetPort("Y").Connect(LagId_node_Y.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LagId_node_Y, assetPath);
					variableCount += LagId_node_Y.SetData((FSLag)Y, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.EffectsId:
					FSEffectsNode EffectsId_node_Y = graph.AddNode<FSEffectsNode>();
					GetPort("Y").Connect(EffectsId_node_Y.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EffectsId_node_Y, assetPath);
					variableCount += EffectsId_node_Y.SetData((FSEffects)Y, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ColorsId:
					FSColorsNode ColorsId_node_Y = graph.AddNode<FSColorsNode>();
					GetPort("Y").Connect(ColorsId_node_Y.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ColorsId_node_Y, assetPath);
					variableCount += ColorsId_node_Y.SetData((FSColors)Y, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.OnHitId:
					FSOnHitNode OnHitId_node_Y = graph.AddNode<FSOnHitNode>();
					GetPort("Y").Connect(OnHitId_node_Y.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnHitId_node_Y, assetPath);
					variableCount += OnHitId_node_Y.SetData((FSOnHit)Y, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RandomId:
					FSRandomNode RandomId_node_Y = graph.AddNode<FSRandomNode>();
					GetPort("Y").Connect(RandomId_node_Y.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RandomId_node_Y, assetPath);
					variableCount += RandomId_node_Y.SetData((FSRandom)Y, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CameraId:
					FSCameraInfoNode CameraId_node_Y = graph.AddNode<FSCameraInfoNode>();
					GetPort("Y").Connect(CameraId_node_Y.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CameraId_node_Y, assetPath);
					variableCount += CameraId_node_Y.SetData((FSCameraInfo)Y, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SportsId:
					FSSportsNode SportsId_node_Y = graph.AddNode<FSSportsNode>();
					GetPort("Y").Connect(SportsId_node_Y.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SportsId_node_Y, assetPath);
					variableCount += SportsId_node_Y.SetData((FSSports)Y, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.Vector2Mag:
					FSVector2MagNode Vector2Mag_node_Y = graph.AddNode<FSVector2MagNode>();
					GetPort("Y").Connect(Vector2Mag_node_Y.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(Vector2Mag_node_Y, assetPath);
					variableCount += Vector2Mag_node_Y.SetData((FSVector2Mag)Y, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CPUHelpId:
					FSCpuHelpNode CPUHelpId_node_Y = graph.AddNode<FSCpuHelpNode>();
					GetPort("Y").Connect(CPUHelpId_node_Y.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CPUHelpId_node_Y, assetPath);
					variableCount += CPUHelpId_node_Y.SetData((FSCpuHelp)Y, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ItemId:
					FSItemNode ItemId_node_Y = graph.AddNode<FSItemNode>();
					GetPort("Y").Connect(ItemId_node_Y.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ItemId_node_Y, assetPath);
					variableCount += ItemId_node_Y.SetData((FSItem)Y, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ModeId:
					FSModeNode ModeId_node_Y = graph.AddNode<FSModeNode>();
					GetPort("Y").Connect(ModeId_node_Y.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ModeId_node_Y, assetPath);
					variableCount += ModeId_node_Y.SetData((FSMode)Y, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.JumpsId:
					FSJumpsNode JumpsId_node_Y = graph.AddNode<FSJumpsNode>();
					GetPort("Y").Connect(JumpsId_node_Y.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(JumpsId_node_Y, assetPath);
					variableCount += JumpsId_node_Y.SetData((FSJumps)Y, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RootAnimId:
					FSRootAnimNode RootAnimId_node_Y = graph.AddNode<FSRootAnimNode>();
					GetPort("Y").Connect(RootAnimId_node_Y.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RootAnimId_node_Y, assetPath);
					variableCount += RootAnimId_node_Y.SetData((FSRootAnim)Y, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FloatId:
					FSValueNode FloatId_node_Y = graph.AddNode<FSValueNode>();
					GetPort("Y").Connect(FloatId_node_Y.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FloatId_node_Y, assetPath);
					variableCount += FloatId_node_Y.SetData((FSValue)Y, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
			}
			++variableCount;
			
			Z = data.Z;
			
			switch (Z.TID)
			{
				case FloatSource.TypeId.AgentId:
					FSAgentNode AgentId_node_Z = graph.AddNode<FSAgentNode>();
					GetPort("Z").Connect(AgentId_node_Z.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AgentId_node_Z, assetPath);
					variableCount += AgentId_node_Z.SetData((FSAgent)Z, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.BonesId:
					FSBonesNode BonesId_node_Z = graph.AddNode<FSBonesNode>();
					GetPort("Z").Connect(BonesId_node_Z.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BonesId_node_Z, assetPath);
					variableCount += BonesId_node_Z.SetData((FSBones)Z, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AttackId:
					FSAttackNode AttackId_node_Z = graph.AddNode<FSAttackNode>();
					GetPort("Z").Connect(AttackId_node_Z.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AttackId_node_Z, assetPath);
					variableCount += AttackId_node_Z.SetData((FSAttack)Z, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FrameId:
					FSFrameNode FrameId_node_Z = graph.AddNode<FSFrameNode>();
					GetPort("Z").Connect(FrameId_node_Z.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FrameId_node_Z, assetPath);
					variableCount += FrameId_node_Z.SetData((FSFrame)Z, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.InputId:
					FSInputNode InputId_node_Z = graph.AddNode<FSInputNode>();
					GetPort("Z").Connect(InputId_node_Z.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputId_node_Z, assetPath);
					variableCount += InputId_node_Z.SetData((FSInput)Z, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FuncId:
					FSFuncNode FuncId_node_Z = graph.AddNode<FSFuncNode>();
					GetPort("Z").Connect(FuncId_node_Z.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FuncId_node_Z, assetPath);
					variableCount += FuncId_node_Z.SetData((FSFunc)Z, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.MovementId:
					FSMovementNode MovementId_node_Z = graph.AddNode<FSMovementNode>();
					GetPort("Z").Connect(MovementId_node_Z.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(MovementId_node_Z, assetPath);
					variableCount += MovementId_node_Z.SetData((FSMovement)Z, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CombatId:
					FSCombatNode CombatId_node_Z = graph.AddNode<FSCombatNode>();
					GetPort("Z").Connect(CombatId_node_Z.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CombatId_node_Z, assetPath);
					variableCount += CombatId_node_Z.SetData((FSCombat)Z, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.GrabsId:
					FSGrabsNode GrabsId_node_Z = graph.AddNode<FSGrabsNode>();
					GetPort("Z").Connect(GrabsId_node_Z.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(GrabsId_node_Z, assetPath);
					variableCount += GrabsId_node_Z.SetData((FSGrabs)Z, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.DataId:
					FSDataNode DataId_node_Z = graph.AddNode<FSDataNode>();
					GetPort("Z").Connect(DataId_node_Z.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DataId_node_Z, assetPath);
					variableCount += DataId_node_Z.SetData((FSData)Z, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ScratchId:
					FSScratchNode ScratchId_node_Z = graph.AddNode<FSScratchNode>();
					GetPort("Z").Connect(ScratchId_node_Z.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ScratchId_node_Z, assetPath);
					variableCount += ScratchId_node_Z.SetData((FSScratch)Z, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AnimId:
					FSAnimNode AnimId_node_Z = graph.AddNode<FSAnimNode>();
					GetPort("Z").Connect(AnimId_node_Z.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AnimId_node_Z, assetPath);
					variableCount += AnimId_node_Z.SetData((FSAnim)Z, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SpeedId:
					FSSpeedNode SpeedId_node_Z = graph.AddNode<FSSpeedNode>();
					GetPort("Z").Connect(SpeedId_node_Z.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpeedId_node_Z, assetPath);
					variableCount += SpeedId_node_Z.SetData((FSSpeed)Z, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.PhysicsId:
					FSPhysicsNode PhysicsId_node_Z = graph.AddNode<FSPhysicsNode>();
					GetPort("Z").Connect(PhysicsId_node_Z.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(PhysicsId_node_Z, assetPath);
					variableCount += PhysicsId_node_Z.SetData((FSPhysics)Z, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CollisionId:
					FSCollisionNode CollisionId_node_Z = graph.AddNode<FSCollisionNode>();
					GetPort("Z").Connect(CollisionId_node_Z.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CollisionId_node_Z, assetPath);
					variableCount += CollisionId_node_Z.SetData((FSCollision)Z, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.TimerId:
					FSTimerNode TimerId_node_Z = graph.AddNode<FSTimerNode>();
					GetPort("Z").Connect(TimerId_node_Z.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(TimerId_node_Z, assetPath);
					variableCount += TimerId_node_Z.SetData((FSTimer)Z, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.LagId:
					FSLagNode LagId_node_Z = graph.AddNode<FSLagNode>();
					GetPort("Z").Connect(LagId_node_Z.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LagId_node_Z, assetPath);
					variableCount += LagId_node_Z.SetData((FSLag)Z, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.EffectsId:
					FSEffectsNode EffectsId_node_Z = graph.AddNode<FSEffectsNode>();
					GetPort("Z").Connect(EffectsId_node_Z.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EffectsId_node_Z, assetPath);
					variableCount += EffectsId_node_Z.SetData((FSEffects)Z, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ColorsId:
					FSColorsNode ColorsId_node_Z = graph.AddNode<FSColorsNode>();
					GetPort("Z").Connect(ColorsId_node_Z.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ColorsId_node_Z, assetPath);
					variableCount += ColorsId_node_Z.SetData((FSColors)Z, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.OnHitId:
					FSOnHitNode OnHitId_node_Z = graph.AddNode<FSOnHitNode>();
					GetPort("Z").Connect(OnHitId_node_Z.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnHitId_node_Z, assetPath);
					variableCount += OnHitId_node_Z.SetData((FSOnHit)Z, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RandomId:
					FSRandomNode RandomId_node_Z = graph.AddNode<FSRandomNode>();
					GetPort("Z").Connect(RandomId_node_Z.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RandomId_node_Z, assetPath);
					variableCount += RandomId_node_Z.SetData((FSRandom)Z, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CameraId:
					FSCameraInfoNode CameraId_node_Z = graph.AddNode<FSCameraInfoNode>();
					GetPort("Z").Connect(CameraId_node_Z.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CameraId_node_Z, assetPath);
					variableCount += CameraId_node_Z.SetData((FSCameraInfo)Z, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SportsId:
					FSSportsNode SportsId_node_Z = graph.AddNode<FSSportsNode>();
					GetPort("Z").Connect(SportsId_node_Z.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SportsId_node_Z, assetPath);
					variableCount += SportsId_node_Z.SetData((FSSports)Z, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.Vector2Mag:
					FSVector2MagNode Vector2Mag_node_Z = graph.AddNode<FSVector2MagNode>();
					GetPort("Z").Connect(Vector2Mag_node_Z.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(Vector2Mag_node_Z, assetPath);
					variableCount += Vector2Mag_node_Z.SetData((FSVector2Mag)Z, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CPUHelpId:
					FSCpuHelpNode CPUHelpId_node_Z = graph.AddNode<FSCpuHelpNode>();
					GetPort("Z").Connect(CPUHelpId_node_Z.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CPUHelpId_node_Z, assetPath);
					variableCount += CPUHelpId_node_Z.SetData((FSCpuHelp)Z, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ItemId:
					FSItemNode ItemId_node_Z = graph.AddNode<FSItemNode>();
					GetPort("Z").Connect(ItemId_node_Z.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ItemId_node_Z, assetPath);
					variableCount += ItemId_node_Z.SetData((FSItem)Z, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ModeId:
					FSModeNode ModeId_node_Z = graph.AddNode<FSModeNode>();
					GetPort("Z").Connect(ModeId_node_Z.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ModeId_node_Z, assetPath);
					variableCount += ModeId_node_Z.SetData((FSMode)Z, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.JumpsId:
					FSJumpsNode JumpsId_node_Z = graph.AddNode<FSJumpsNode>();
					GetPort("Z").Connect(JumpsId_node_Z.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(JumpsId_node_Z, assetPath);
					variableCount += JumpsId_node_Z.SetData((FSJumps)Z, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RootAnimId:
					FSRootAnimNode RootAnimId_node_Z = graph.AddNode<FSRootAnimNode>();
					GetPort("Z").Connect(RootAnimId_node_Z.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RootAnimId_node_Z, assetPath);
					variableCount += RootAnimId_node_Z.SetData((FSRootAnim)Z, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FloatId:
					FSValueNode FloatId_node_Z = graph.AddNode<FSValueNode>();
					GetPort("Z").Connect(FloatId_node_Z.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FloatId_node_Z, assetPath);
					variableCount += FloatId_node_Z.SetData((FSValue)Z, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
			}
			++variableCount;
			
			T = data.T;
			
			switch (T.TID)
			{
				case FloatSource.TypeId.AgentId:
					FSAgentNode AgentId_node_T = graph.AddNode<FSAgentNode>();
					GetPort("T").Connect(AgentId_node_T.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AgentId_node_T, assetPath);
					variableCount += AgentId_node_T.SetData((FSAgent)T, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.BonesId:
					FSBonesNode BonesId_node_T = graph.AddNode<FSBonesNode>();
					GetPort("T").Connect(BonesId_node_T.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BonesId_node_T, assetPath);
					variableCount += BonesId_node_T.SetData((FSBones)T, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AttackId:
					FSAttackNode AttackId_node_T = graph.AddNode<FSAttackNode>();
					GetPort("T").Connect(AttackId_node_T.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AttackId_node_T, assetPath);
					variableCount += AttackId_node_T.SetData((FSAttack)T, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FrameId:
					FSFrameNode FrameId_node_T = graph.AddNode<FSFrameNode>();
					GetPort("T").Connect(FrameId_node_T.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FrameId_node_T, assetPath);
					variableCount += FrameId_node_T.SetData((FSFrame)T, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.InputId:
					FSInputNode InputId_node_T = graph.AddNode<FSInputNode>();
					GetPort("T").Connect(InputId_node_T.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputId_node_T, assetPath);
					variableCount += InputId_node_T.SetData((FSInput)T, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FuncId:
					FSFuncNode FuncId_node_T = graph.AddNode<FSFuncNode>();
					GetPort("T").Connect(FuncId_node_T.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FuncId_node_T, assetPath);
					variableCount += FuncId_node_T.SetData((FSFunc)T, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.MovementId:
					FSMovementNode MovementId_node_T = graph.AddNode<FSMovementNode>();
					GetPort("T").Connect(MovementId_node_T.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(MovementId_node_T, assetPath);
					variableCount += MovementId_node_T.SetData((FSMovement)T, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CombatId:
					FSCombatNode CombatId_node_T = graph.AddNode<FSCombatNode>();
					GetPort("T").Connect(CombatId_node_T.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CombatId_node_T, assetPath);
					variableCount += CombatId_node_T.SetData((FSCombat)T, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.GrabsId:
					FSGrabsNode GrabsId_node_T = graph.AddNode<FSGrabsNode>();
					GetPort("T").Connect(GrabsId_node_T.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(GrabsId_node_T, assetPath);
					variableCount += GrabsId_node_T.SetData((FSGrabs)T, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.DataId:
					FSDataNode DataId_node_T = graph.AddNode<FSDataNode>();
					GetPort("T").Connect(DataId_node_T.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DataId_node_T, assetPath);
					variableCount += DataId_node_T.SetData((FSData)T, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ScratchId:
					FSScratchNode ScratchId_node_T = graph.AddNode<FSScratchNode>();
					GetPort("T").Connect(ScratchId_node_T.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ScratchId_node_T, assetPath);
					variableCount += ScratchId_node_T.SetData((FSScratch)T, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AnimId:
					FSAnimNode AnimId_node_T = graph.AddNode<FSAnimNode>();
					GetPort("T").Connect(AnimId_node_T.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AnimId_node_T, assetPath);
					variableCount += AnimId_node_T.SetData((FSAnim)T, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SpeedId:
					FSSpeedNode SpeedId_node_T = graph.AddNode<FSSpeedNode>();
					GetPort("T").Connect(SpeedId_node_T.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpeedId_node_T, assetPath);
					variableCount += SpeedId_node_T.SetData((FSSpeed)T, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.PhysicsId:
					FSPhysicsNode PhysicsId_node_T = graph.AddNode<FSPhysicsNode>();
					GetPort("T").Connect(PhysicsId_node_T.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(PhysicsId_node_T, assetPath);
					variableCount += PhysicsId_node_T.SetData((FSPhysics)T, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CollisionId:
					FSCollisionNode CollisionId_node_T = graph.AddNode<FSCollisionNode>();
					GetPort("T").Connect(CollisionId_node_T.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CollisionId_node_T, assetPath);
					variableCount += CollisionId_node_T.SetData((FSCollision)T, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.TimerId:
					FSTimerNode TimerId_node_T = graph.AddNode<FSTimerNode>();
					GetPort("T").Connect(TimerId_node_T.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(TimerId_node_T, assetPath);
					variableCount += TimerId_node_T.SetData((FSTimer)T, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.LagId:
					FSLagNode LagId_node_T = graph.AddNode<FSLagNode>();
					GetPort("T").Connect(LagId_node_T.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LagId_node_T, assetPath);
					variableCount += LagId_node_T.SetData((FSLag)T, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.EffectsId:
					FSEffectsNode EffectsId_node_T = graph.AddNode<FSEffectsNode>();
					GetPort("T").Connect(EffectsId_node_T.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EffectsId_node_T, assetPath);
					variableCount += EffectsId_node_T.SetData((FSEffects)T, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ColorsId:
					FSColorsNode ColorsId_node_T = graph.AddNode<FSColorsNode>();
					GetPort("T").Connect(ColorsId_node_T.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ColorsId_node_T, assetPath);
					variableCount += ColorsId_node_T.SetData((FSColors)T, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.OnHitId:
					FSOnHitNode OnHitId_node_T = graph.AddNode<FSOnHitNode>();
					GetPort("T").Connect(OnHitId_node_T.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnHitId_node_T, assetPath);
					variableCount += OnHitId_node_T.SetData((FSOnHit)T, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RandomId:
					FSRandomNode RandomId_node_T = graph.AddNode<FSRandomNode>();
					GetPort("T").Connect(RandomId_node_T.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RandomId_node_T, assetPath);
					variableCount += RandomId_node_T.SetData((FSRandom)T, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CameraId:
					FSCameraInfoNode CameraId_node_T = graph.AddNode<FSCameraInfoNode>();
					GetPort("T").Connect(CameraId_node_T.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CameraId_node_T, assetPath);
					variableCount += CameraId_node_T.SetData((FSCameraInfo)T, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SportsId:
					FSSportsNode SportsId_node_T = graph.AddNode<FSSportsNode>();
					GetPort("T").Connect(SportsId_node_T.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SportsId_node_T, assetPath);
					variableCount += SportsId_node_T.SetData((FSSports)T, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.Vector2Mag:
					FSVector2MagNode Vector2Mag_node_T = graph.AddNode<FSVector2MagNode>();
					GetPort("T").Connect(Vector2Mag_node_T.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(Vector2Mag_node_T, assetPath);
					variableCount += Vector2Mag_node_T.SetData((FSVector2Mag)T, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CPUHelpId:
					FSCpuHelpNode CPUHelpId_node_T = graph.AddNode<FSCpuHelpNode>();
					GetPort("T").Connect(CPUHelpId_node_T.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CPUHelpId_node_T, assetPath);
					variableCount += CPUHelpId_node_T.SetData((FSCpuHelp)T, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ItemId:
					FSItemNode ItemId_node_T = graph.AddNode<FSItemNode>();
					GetPort("T").Connect(ItemId_node_T.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ItemId_node_T, assetPath);
					variableCount += ItemId_node_T.SetData((FSItem)T, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ModeId:
					FSModeNode ModeId_node_T = graph.AddNode<FSModeNode>();
					GetPort("T").Connect(ModeId_node_T.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ModeId_node_T, assetPath);
					variableCount += ModeId_node_T.SetData((FSMode)T, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.JumpsId:
					FSJumpsNode JumpsId_node_T = graph.AddNode<FSJumpsNode>();
					GetPort("T").Connect(JumpsId_node_T.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(JumpsId_node_T, assetPath);
					variableCount += JumpsId_node_T.SetData((FSJumps)T, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RootAnimId:
					FSRootAnimNode RootAnimId_node_T = graph.AddNode<FSRootAnimNode>();
					GetPort("T").Connect(RootAnimId_node_T.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RootAnimId_node_T, assetPath);
					variableCount += RootAnimId_node_T.SetData((FSRootAnim)T, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FloatId:
					FSValueNode FloatId_node_T = graph.AddNode<FSValueNode>();
					GetPort("T").Connect(FloatId_node_T.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FloatId_node_T, assetPath);
					variableCount += FloatId_node_T.SetData((FSValue)T, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
			}
			
			return variableCount;
		}
		
		public new SACameraPunch GetData()
		{
			SACameraPunch objToReturn = new SACameraPunch();
			objToReturn.TID = TypeId.CameraPunchId;
			objToReturn.Version = Version;
			if (GetPort("X").ConnectionCount > 0)
			{
				FloatSourceNode FloatSource_Node = (FloatSourceNode)GetPort("X").GetConnection(0).node;
				switch (FloatSource_Node.TID)
				{
					case FloatSource.TypeId.AgentId:
						FSAgentNode AgentId_FloatSource_Node = (FSAgentNode)GetPort("X").GetConnection(0).node;
						objToReturn.X = AgentId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.BonesId:
						FSBonesNode BonesId_FloatSource_Node = (FSBonesNode)GetPort("X").GetConnection(0).node;
						objToReturn.X = BonesId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AttackId:
						FSAttackNode AttackId_FloatSource_Node = (FSAttackNode)GetPort("X").GetConnection(0).node;
						objToReturn.X = AttackId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FrameId:
						FSFrameNode FrameId_FloatSource_Node = (FSFrameNode)GetPort("X").GetConnection(0).node;
						objToReturn.X = FrameId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.InputId:
						FSInputNode InputId_FloatSource_Node = (FSInputNode)GetPort("X").GetConnection(0).node;
						objToReturn.X = InputId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FuncId:
						FSFuncNode FuncId_FloatSource_Node = (FSFuncNode)GetPort("X").GetConnection(0).node;
						objToReturn.X = FuncId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.MovementId:
						FSMovementNode MovementId_FloatSource_Node = (FSMovementNode)GetPort("X").GetConnection(0).node;
						objToReturn.X = MovementId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CombatId:
						FSCombatNode CombatId_FloatSource_Node = (FSCombatNode)GetPort("X").GetConnection(0).node;
						objToReturn.X = CombatId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.GrabsId:
						FSGrabsNode GrabsId_FloatSource_Node = (FSGrabsNode)GetPort("X").GetConnection(0).node;
						objToReturn.X = GrabsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.DataId:
						FSDataNode DataId_FloatSource_Node = (FSDataNode)GetPort("X").GetConnection(0).node;
						objToReturn.X = DataId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ScratchId:
						FSScratchNode ScratchId_FloatSource_Node = (FSScratchNode)GetPort("X").GetConnection(0).node;
						objToReturn.X = ScratchId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AnimId:
						FSAnimNode AnimId_FloatSource_Node = (FSAnimNode)GetPort("X").GetConnection(0).node;
						objToReturn.X = AnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SpeedId:
						FSSpeedNode SpeedId_FloatSource_Node = (FSSpeedNode)GetPort("X").GetConnection(0).node;
						objToReturn.X = SpeedId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.PhysicsId:
						FSPhysicsNode PhysicsId_FloatSource_Node = (FSPhysicsNode)GetPort("X").GetConnection(0).node;
						objToReturn.X = PhysicsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CollisionId:
						FSCollisionNode CollisionId_FloatSource_Node = (FSCollisionNode)GetPort("X").GetConnection(0).node;
						objToReturn.X = CollisionId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.TimerId:
						FSTimerNode TimerId_FloatSource_Node = (FSTimerNode)GetPort("X").GetConnection(0).node;
						objToReturn.X = TimerId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.LagId:
						FSLagNode LagId_FloatSource_Node = (FSLagNode)GetPort("X").GetConnection(0).node;
						objToReturn.X = LagId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.EffectsId:
						FSEffectsNode EffectsId_FloatSource_Node = (FSEffectsNode)GetPort("X").GetConnection(0).node;
						objToReturn.X = EffectsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ColorsId:
						FSColorsNode ColorsId_FloatSource_Node = (FSColorsNode)GetPort("X").GetConnection(0).node;
						objToReturn.X = ColorsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.OnHitId:
						FSOnHitNode OnHitId_FloatSource_Node = (FSOnHitNode)GetPort("X").GetConnection(0).node;
						objToReturn.X = OnHitId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RandomId:
						FSRandomNode RandomId_FloatSource_Node = (FSRandomNode)GetPort("X").GetConnection(0).node;
						objToReturn.X = RandomId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CameraId:
						FSCameraInfoNode CameraId_FloatSource_Node = (FSCameraInfoNode)GetPort("X").GetConnection(0).node;
						objToReturn.X = CameraId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SportsId:
						FSSportsNode SportsId_FloatSource_Node = (FSSportsNode)GetPort("X").GetConnection(0).node;
						objToReturn.X = SportsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.Vector2Mag:
						FSVector2MagNode Vector2Mag_FloatSource_Node = (FSVector2MagNode)GetPort("X").GetConnection(0).node;
						objToReturn.X = Vector2Mag_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CPUHelpId:
						FSCpuHelpNode CPUHelpId_FloatSource_Node = (FSCpuHelpNode)GetPort("X").GetConnection(0).node;
						objToReturn.X = CPUHelpId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ItemId:
						FSItemNode ItemId_FloatSource_Node = (FSItemNode)GetPort("X").GetConnection(0).node;
						objToReturn.X = ItemId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ModeId:
						FSModeNode ModeId_FloatSource_Node = (FSModeNode)GetPort("X").GetConnection(0).node;
						objToReturn.X = ModeId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.JumpsId:
						FSJumpsNode JumpsId_FloatSource_Node = (FSJumpsNode)GetPort("X").GetConnection(0).node;
						objToReturn.X = JumpsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RootAnimId:
						FSRootAnimNode RootAnimId_FloatSource_Node = (FSRootAnimNode)GetPort("X").GetConnection(0).node;
						objToReturn.X = RootAnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FloatId:
						FSValueNode FloatId_FloatSource_Node = (FSValueNode)GetPort("X").GetConnection(0).node;
						objToReturn.X = FloatId_FloatSource_Node.GetData();
					break;
				}
			}
			if (GetPort("Y").ConnectionCount > 0)
			{
				FloatSourceNode FloatSource_Node = (FloatSourceNode)GetPort("Y").GetConnection(0).node;
				switch (FloatSource_Node.TID)
				{
					case FloatSource.TypeId.AgentId:
						FSAgentNode AgentId_FloatSource_Node = (FSAgentNode)GetPort("Y").GetConnection(0).node;
						objToReturn.Y = AgentId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.BonesId:
						FSBonesNode BonesId_FloatSource_Node = (FSBonesNode)GetPort("Y").GetConnection(0).node;
						objToReturn.Y = BonesId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AttackId:
						FSAttackNode AttackId_FloatSource_Node = (FSAttackNode)GetPort("Y").GetConnection(0).node;
						objToReturn.Y = AttackId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FrameId:
						FSFrameNode FrameId_FloatSource_Node = (FSFrameNode)GetPort("Y").GetConnection(0).node;
						objToReturn.Y = FrameId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.InputId:
						FSInputNode InputId_FloatSource_Node = (FSInputNode)GetPort("Y").GetConnection(0).node;
						objToReturn.Y = InputId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FuncId:
						FSFuncNode FuncId_FloatSource_Node = (FSFuncNode)GetPort("Y").GetConnection(0).node;
						objToReturn.Y = FuncId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.MovementId:
						FSMovementNode MovementId_FloatSource_Node = (FSMovementNode)GetPort("Y").GetConnection(0).node;
						objToReturn.Y = MovementId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CombatId:
						FSCombatNode CombatId_FloatSource_Node = (FSCombatNode)GetPort("Y").GetConnection(0).node;
						objToReturn.Y = CombatId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.GrabsId:
						FSGrabsNode GrabsId_FloatSource_Node = (FSGrabsNode)GetPort("Y").GetConnection(0).node;
						objToReturn.Y = GrabsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.DataId:
						FSDataNode DataId_FloatSource_Node = (FSDataNode)GetPort("Y").GetConnection(0).node;
						objToReturn.Y = DataId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ScratchId:
						FSScratchNode ScratchId_FloatSource_Node = (FSScratchNode)GetPort("Y").GetConnection(0).node;
						objToReturn.Y = ScratchId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AnimId:
						FSAnimNode AnimId_FloatSource_Node = (FSAnimNode)GetPort("Y").GetConnection(0).node;
						objToReturn.Y = AnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SpeedId:
						FSSpeedNode SpeedId_FloatSource_Node = (FSSpeedNode)GetPort("Y").GetConnection(0).node;
						objToReturn.Y = SpeedId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.PhysicsId:
						FSPhysicsNode PhysicsId_FloatSource_Node = (FSPhysicsNode)GetPort("Y").GetConnection(0).node;
						objToReturn.Y = PhysicsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CollisionId:
						FSCollisionNode CollisionId_FloatSource_Node = (FSCollisionNode)GetPort("Y").GetConnection(0).node;
						objToReturn.Y = CollisionId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.TimerId:
						FSTimerNode TimerId_FloatSource_Node = (FSTimerNode)GetPort("Y").GetConnection(0).node;
						objToReturn.Y = TimerId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.LagId:
						FSLagNode LagId_FloatSource_Node = (FSLagNode)GetPort("Y").GetConnection(0).node;
						objToReturn.Y = LagId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.EffectsId:
						FSEffectsNode EffectsId_FloatSource_Node = (FSEffectsNode)GetPort("Y").GetConnection(0).node;
						objToReturn.Y = EffectsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ColorsId:
						FSColorsNode ColorsId_FloatSource_Node = (FSColorsNode)GetPort("Y").GetConnection(0).node;
						objToReturn.Y = ColorsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.OnHitId:
						FSOnHitNode OnHitId_FloatSource_Node = (FSOnHitNode)GetPort("Y").GetConnection(0).node;
						objToReturn.Y = OnHitId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RandomId:
						FSRandomNode RandomId_FloatSource_Node = (FSRandomNode)GetPort("Y").GetConnection(0).node;
						objToReturn.Y = RandomId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CameraId:
						FSCameraInfoNode CameraId_FloatSource_Node = (FSCameraInfoNode)GetPort("Y").GetConnection(0).node;
						objToReturn.Y = CameraId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SportsId:
						FSSportsNode SportsId_FloatSource_Node = (FSSportsNode)GetPort("Y").GetConnection(0).node;
						objToReturn.Y = SportsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.Vector2Mag:
						FSVector2MagNode Vector2Mag_FloatSource_Node = (FSVector2MagNode)GetPort("Y").GetConnection(0).node;
						objToReturn.Y = Vector2Mag_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CPUHelpId:
						FSCpuHelpNode CPUHelpId_FloatSource_Node = (FSCpuHelpNode)GetPort("Y").GetConnection(0).node;
						objToReturn.Y = CPUHelpId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ItemId:
						FSItemNode ItemId_FloatSource_Node = (FSItemNode)GetPort("Y").GetConnection(0).node;
						objToReturn.Y = ItemId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ModeId:
						FSModeNode ModeId_FloatSource_Node = (FSModeNode)GetPort("Y").GetConnection(0).node;
						objToReturn.Y = ModeId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.JumpsId:
						FSJumpsNode JumpsId_FloatSource_Node = (FSJumpsNode)GetPort("Y").GetConnection(0).node;
						objToReturn.Y = JumpsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RootAnimId:
						FSRootAnimNode RootAnimId_FloatSource_Node = (FSRootAnimNode)GetPort("Y").GetConnection(0).node;
						objToReturn.Y = RootAnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FloatId:
						FSValueNode FloatId_FloatSource_Node = (FSValueNode)GetPort("Y").GetConnection(0).node;
						objToReturn.Y = FloatId_FloatSource_Node.GetData();
					break;
				}
			}
			if (GetPort("Z").ConnectionCount > 0)
			{
				FloatSourceNode FloatSource_Node = (FloatSourceNode)GetPort("Z").GetConnection(0).node;
				switch (FloatSource_Node.TID)
				{
					case FloatSource.TypeId.AgentId:
						FSAgentNode AgentId_FloatSource_Node = (FSAgentNode)GetPort("Z").GetConnection(0).node;
						objToReturn.Z = AgentId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.BonesId:
						FSBonesNode BonesId_FloatSource_Node = (FSBonesNode)GetPort("Z").GetConnection(0).node;
						objToReturn.Z = BonesId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AttackId:
						FSAttackNode AttackId_FloatSource_Node = (FSAttackNode)GetPort("Z").GetConnection(0).node;
						objToReturn.Z = AttackId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FrameId:
						FSFrameNode FrameId_FloatSource_Node = (FSFrameNode)GetPort("Z").GetConnection(0).node;
						objToReturn.Z = FrameId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.InputId:
						FSInputNode InputId_FloatSource_Node = (FSInputNode)GetPort("Z").GetConnection(0).node;
						objToReturn.Z = InputId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FuncId:
						FSFuncNode FuncId_FloatSource_Node = (FSFuncNode)GetPort("Z").GetConnection(0).node;
						objToReturn.Z = FuncId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.MovementId:
						FSMovementNode MovementId_FloatSource_Node = (FSMovementNode)GetPort("Z").GetConnection(0).node;
						objToReturn.Z = MovementId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CombatId:
						FSCombatNode CombatId_FloatSource_Node = (FSCombatNode)GetPort("Z").GetConnection(0).node;
						objToReturn.Z = CombatId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.GrabsId:
						FSGrabsNode GrabsId_FloatSource_Node = (FSGrabsNode)GetPort("Z").GetConnection(0).node;
						objToReturn.Z = GrabsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.DataId:
						FSDataNode DataId_FloatSource_Node = (FSDataNode)GetPort("Z").GetConnection(0).node;
						objToReturn.Z = DataId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ScratchId:
						FSScratchNode ScratchId_FloatSource_Node = (FSScratchNode)GetPort("Z").GetConnection(0).node;
						objToReturn.Z = ScratchId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AnimId:
						FSAnimNode AnimId_FloatSource_Node = (FSAnimNode)GetPort("Z").GetConnection(0).node;
						objToReturn.Z = AnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SpeedId:
						FSSpeedNode SpeedId_FloatSource_Node = (FSSpeedNode)GetPort("Z").GetConnection(0).node;
						objToReturn.Z = SpeedId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.PhysicsId:
						FSPhysicsNode PhysicsId_FloatSource_Node = (FSPhysicsNode)GetPort("Z").GetConnection(0).node;
						objToReturn.Z = PhysicsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CollisionId:
						FSCollisionNode CollisionId_FloatSource_Node = (FSCollisionNode)GetPort("Z").GetConnection(0).node;
						objToReturn.Z = CollisionId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.TimerId:
						FSTimerNode TimerId_FloatSource_Node = (FSTimerNode)GetPort("Z").GetConnection(0).node;
						objToReturn.Z = TimerId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.LagId:
						FSLagNode LagId_FloatSource_Node = (FSLagNode)GetPort("Z").GetConnection(0).node;
						objToReturn.Z = LagId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.EffectsId:
						FSEffectsNode EffectsId_FloatSource_Node = (FSEffectsNode)GetPort("Z").GetConnection(0).node;
						objToReturn.Z = EffectsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ColorsId:
						FSColorsNode ColorsId_FloatSource_Node = (FSColorsNode)GetPort("Z").GetConnection(0).node;
						objToReturn.Z = ColorsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.OnHitId:
						FSOnHitNode OnHitId_FloatSource_Node = (FSOnHitNode)GetPort("Z").GetConnection(0).node;
						objToReturn.Z = OnHitId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RandomId:
						FSRandomNode RandomId_FloatSource_Node = (FSRandomNode)GetPort("Z").GetConnection(0).node;
						objToReturn.Z = RandomId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CameraId:
						FSCameraInfoNode CameraId_FloatSource_Node = (FSCameraInfoNode)GetPort("Z").GetConnection(0).node;
						objToReturn.Z = CameraId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SportsId:
						FSSportsNode SportsId_FloatSource_Node = (FSSportsNode)GetPort("Z").GetConnection(0).node;
						objToReturn.Z = SportsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.Vector2Mag:
						FSVector2MagNode Vector2Mag_FloatSource_Node = (FSVector2MagNode)GetPort("Z").GetConnection(0).node;
						objToReturn.Z = Vector2Mag_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CPUHelpId:
						FSCpuHelpNode CPUHelpId_FloatSource_Node = (FSCpuHelpNode)GetPort("Z").GetConnection(0).node;
						objToReturn.Z = CPUHelpId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ItemId:
						FSItemNode ItemId_FloatSource_Node = (FSItemNode)GetPort("Z").GetConnection(0).node;
						objToReturn.Z = ItemId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ModeId:
						FSModeNode ModeId_FloatSource_Node = (FSModeNode)GetPort("Z").GetConnection(0).node;
						objToReturn.Z = ModeId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.JumpsId:
						FSJumpsNode JumpsId_FloatSource_Node = (FSJumpsNode)GetPort("Z").GetConnection(0).node;
						objToReturn.Z = JumpsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RootAnimId:
						FSRootAnimNode RootAnimId_FloatSource_Node = (FSRootAnimNode)GetPort("Z").GetConnection(0).node;
						objToReturn.Z = RootAnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FloatId:
						FSValueNode FloatId_FloatSource_Node = (FSValueNode)GetPort("Z").GetConnection(0).node;
						objToReturn.Z = FloatId_FloatSource_Node.GetData();
					break;
				}
			}
			if (GetPort("T").ConnectionCount > 0)
			{
				FloatSourceNode FloatSource_Node = (FloatSourceNode)GetPort("T").GetConnection(0).node;
				switch (FloatSource_Node.TID)
				{
					case FloatSource.TypeId.AgentId:
						FSAgentNode AgentId_FloatSource_Node = (FSAgentNode)GetPort("T").GetConnection(0).node;
						objToReturn.T = AgentId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.BonesId:
						FSBonesNode BonesId_FloatSource_Node = (FSBonesNode)GetPort("T").GetConnection(0).node;
						objToReturn.T = BonesId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AttackId:
						FSAttackNode AttackId_FloatSource_Node = (FSAttackNode)GetPort("T").GetConnection(0).node;
						objToReturn.T = AttackId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FrameId:
						FSFrameNode FrameId_FloatSource_Node = (FSFrameNode)GetPort("T").GetConnection(0).node;
						objToReturn.T = FrameId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.InputId:
						FSInputNode InputId_FloatSource_Node = (FSInputNode)GetPort("T").GetConnection(0).node;
						objToReturn.T = InputId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FuncId:
						FSFuncNode FuncId_FloatSource_Node = (FSFuncNode)GetPort("T").GetConnection(0).node;
						objToReturn.T = FuncId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.MovementId:
						FSMovementNode MovementId_FloatSource_Node = (FSMovementNode)GetPort("T").GetConnection(0).node;
						objToReturn.T = MovementId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CombatId:
						FSCombatNode CombatId_FloatSource_Node = (FSCombatNode)GetPort("T").GetConnection(0).node;
						objToReturn.T = CombatId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.GrabsId:
						FSGrabsNode GrabsId_FloatSource_Node = (FSGrabsNode)GetPort("T").GetConnection(0).node;
						objToReturn.T = GrabsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.DataId:
						FSDataNode DataId_FloatSource_Node = (FSDataNode)GetPort("T").GetConnection(0).node;
						objToReturn.T = DataId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ScratchId:
						FSScratchNode ScratchId_FloatSource_Node = (FSScratchNode)GetPort("T").GetConnection(0).node;
						objToReturn.T = ScratchId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AnimId:
						FSAnimNode AnimId_FloatSource_Node = (FSAnimNode)GetPort("T").GetConnection(0).node;
						objToReturn.T = AnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SpeedId:
						FSSpeedNode SpeedId_FloatSource_Node = (FSSpeedNode)GetPort("T").GetConnection(0).node;
						objToReturn.T = SpeedId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.PhysicsId:
						FSPhysicsNode PhysicsId_FloatSource_Node = (FSPhysicsNode)GetPort("T").GetConnection(0).node;
						objToReturn.T = PhysicsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CollisionId:
						FSCollisionNode CollisionId_FloatSource_Node = (FSCollisionNode)GetPort("T").GetConnection(0).node;
						objToReturn.T = CollisionId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.TimerId:
						FSTimerNode TimerId_FloatSource_Node = (FSTimerNode)GetPort("T").GetConnection(0).node;
						objToReturn.T = TimerId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.LagId:
						FSLagNode LagId_FloatSource_Node = (FSLagNode)GetPort("T").GetConnection(0).node;
						objToReturn.T = LagId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.EffectsId:
						FSEffectsNode EffectsId_FloatSource_Node = (FSEffectsNode)GetPort("T").GetConnection(0).node;
						objToReturn.T = EffectsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ColorsId:
						FSColorsNode ColorsId_FloatSource_Node = (FSColorsNode)GetPort("T").GetConnection(0).node;
						objToReturn.T = ColorsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.OnHitId:
						FSOnHitNode OnHitId_FloatSource_Node = (FSOnHitNode)GetPort("T").GetConnection(0).node;
						objToReturn.T = OnHitId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RandomId:
						FSRandomNode RandomId_FloatSource_Node = (FSRandomNode)GetPort("T").GetConnection(0).node;
						objToReturn.T = RandomId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CameraId:
						FSCameraInfoNode CameraId_FloatSource_Node = (FSCameraInfoNode)GetPort("T").GetConnection(0).node;
						objToReturn.T = CameraId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SportsId:
						FSSportsNode SportsId_FloatSource_Node = (FSSportsNode)GetPort("T").GetConnection(0).node;
						objToReturn.T = SportsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.Vector2Mag:
						FSVector2MagNode Vector2Mag_FloatSource_Node = (FSVector2MagNode)GetPort("T").GetConnection(0).node;
						objToReturn.T = Vector2Mag_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CPUHelpId:
						FSCpuHelpNode CPUHelpId_FloatSource_Node = (FSCpuHelpNode)GetPort("T").GetConnection(0).node;
						objToReturn.T = CPUHelpId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ItemId:
						FSItemNode ItemId_FloatSource_Node = (FSItemNode)GetPort("T").GetConnection(0).node;
						objToReturn.T = ItemId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ModeId:
						FSModeNode ModeId_FloatSource_Node = (FSModeNode)GetPort("T").GetConnection(0).node;
						objToReturn.T = ModeId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.JumpsId:
						FSJumpsNode JumpsId_FloatSource_Node = (FSJumpsNode)GetPort("T").GetConnection(0).node;
						objToReturn.T = JumpsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RootAnimId:
						FSRootAnimNode RootAnimId_FloatSource_Node = (FSRootAnimNode)GetPort("T").GetConnection(0).node;
						objToReturn.T = RootAnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FloatId:
						FSValueNode FloatId_FloatSource_Node = (FSValueNode)GetPort("T").GetConnection(0).node;
						objToReturn.T = FloatId_FloatSource_Node.GetData();
					break;
				}
			}
			return objToReturn;
		}
	}
}

