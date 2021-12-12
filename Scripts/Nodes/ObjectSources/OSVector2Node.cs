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
using static NASB_Parser.ObjectSources.ObjectSource;

namespace NASB_Moveset_Editor.ObjectSources
{
	public class OSVector2Node : ObjectSourceNode
	{
		[Input(connectionType = ConnectionType.Override)] public ObjectSource NodeInput;
		[Output(connectionType = ConnectionType.Override)] public FloatSource X;
		[Output(connectionType = ConnectionType.Override)] public FloatSource Y;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.Vector2Id;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(OSVector2 data, MovesetGraph graph, string assetPath, Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(OSVector2));
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
			
			return variableCount;
		}
		
		public new OSVector2 GetData()
		{
			OSVector2 objToReturn = new OSVector2();
			objToReturn.TID = TypeId.Vector2Id;
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
			return objToReturn;
		}
	}
}

