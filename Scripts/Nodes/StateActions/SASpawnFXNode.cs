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
	public class SASpawnFXNode : StateActionNode
	{
		public bool Dynamic;
		public bool Track;
		public bool BoneDir;
		public string Id;
		public string Bone;
		public NASB_Parser.Vector3 LocalOffset;
		public NASB_Parser.Vector3 GlobalOffset;
		[Output(connectionType = ConnectionType.Override)] public FloatSource DirX;
		[Output(connectionType = ConnectionType.Override)] public FloatSource DirY;
		[Output(connectionType = ConnectionType.Override)] public FloatSource DirZ;
		[Output(connectionType = ConnectionType.Override)] public FloatSource DynamicX;
		[Output(connectionType = ConnectionType.Override)] public FloatSource DynamicY;
		[Output(connectionType = ConnectionType.Override)] public FloatSource DynamicZ;
		[Output(connectionType = ConnectionType.Override)] public FloatSource Scale;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.SpawnFXId;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SASpawnFX data, MovesetGraph graph, string assetPath, Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SASpawnFX));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			Dynamic = data.Dynamic;
			Track = data.Track;
			BoneDir = data.BoneDir;
			Id = data.Id;
			Bone = data.Bone;
			LocalOffset = data.LocalOffset;
			GlobalOffset = data.GlobalOffset;
			DirX = data.DirX;
			
			switch (DirX.TID)
			{
				case FloatSource.TypeId.AgentId:
					FSAgentNode AgentId_node_DirX = graph.AddNode<FSAgentNode>();
					GetPort("DirX").Connect(AgentId_node_DirX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AgentId_node_DirX, assetPath);
					variableCount += AgentId_node_DirX.SetData((FSAgent)DirX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.BonesId:
					FSBonesNode BonesId_node_DirX = graph.AddNode<FSBonesNode>();
					GetPort("DirX").Connect(BonesId_node_DirX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BonesId_node_DirX, assetPath);
					variableCount += BonesId_node_DirX.SetData((FSBones)DirX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AttackId:
					FSAttackNode AttackId_node_DirX = graph.AddNode<FSAttackNode>();
					GetPort("DirX").Connect(AttackId_node_DirX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AttackId_node_DirX, assetPath);
					variableCount += AttackId_node_DirX.SetData((FSAttack)DirX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FrameId:
					FSFrameNode FrameId_node_DirX = graph.AddNode<FSFrameNode>();
					GetPort("DirX").Connect(FrameId_node_DirX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FrameId_node_DirX, assetPath);
					variableCount += FrameId_node_DirX.SetData((FSFrame)DirX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.InputId:
					FSInputNode InputId_node_DirX = graph.AddNode<FSInputNode>();
					GetPort("DirX").Connect(InputId_node_DirX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputId_node_DirX, assetPath);
					variableCount += InputId_node_DirX.SetData((FSInput)DirX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FuncId:
					FSFuncNode FuncId_node_DirX = graph.AddNode<FSFuncNode>();
					GetPort("DirX").Connect(FuncId_node_DirX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FuncId_node_DirX, assetPath);
					variableCount += FuncId_node_DirX.SetData((FSFunc)DirX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.MovementId:
					FSMovementNode MovementId_node_DirX = graph.AddNode<FSMovementNode>();
					GetPort("DirX").Connect(MovementId_node_DirX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(MovementId_node_DirX, assetPath);
					variableCount += MovementId_node_DirX.SetData((FSMovement)DirX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CombatId:
					FSCombatNode CombatId_node_DirX = graph.AddNode<FSCombatNode>();
					GetPort("DirX").Connect(CombatId_node_DirX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CombatId_node_DirX, assetPath);
					variableCount += CombatId_node_DirX.SetData((FSCombat)DirX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.GrabsId:
					FSGrabsNode GrabsId_node_DirX = graph.AddNode<FSGrabsNode>();
					GetPort("DirX").Connect(GrabsId_node_DirX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(GrabsId_node_DirX, assetPath);
					variableCount += GrabsId_node_DirX.SetData((FSGrabs)DirX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.DataId:
					FSDataNode DataId_node_DirX = graph.AddNode<FSDataNode>();
					GetPort("DirX").Connect(DataId_node_DirX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DataId_node_DirX, assetPath);
					variableCount += DataId_node_DirX.SetData((FSData)DirX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ScratchId:
					FSScratchNode ScratchId_node_DirX = graph.AddNode<FSScratchNode>();
					GetPort("DirX").Connect(ScratchId_node_DirX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ScratchId_node_DirX, assetPath);
					variableCount += ScratchId_node_DirX.SetData((FSScratch)DirX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AnimId:
					FSAnimNode AnimId_node_DirX = graph.AddNode<FSAnimNode>();
					GetPort("DirX").Connect(AnimId_node_DirX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AnimId_node_DirX, assetPath);
					variableCount += AnimId_node_DirX.SetData((FSAnim)DirX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SpeedId:
					FSSpeedNode SpeedId_node_DirX = graph.AddNode<FSSpeedNode>();
					GetPort("DirX").Connect(SpeedId_node_DirX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpeedId_node_DirX, assetPath);
					variableCount += SpeedId_node_DirX.SetData((FSSpeed)DirX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.PhysicsId:
					FSPhysicsNode PhysicsId_node_DirX = graph.AddNode<FSPhysicsNode>();
					GetPort("DirX").Connect(PhysicsId_node_DirX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(PhysicsId_node_DirX, assetPath);
					variableCount += PhysicsId_node_DirX.SetData((FSPhysics)DirX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CollisionId:
					FSCollisionNode CollisionId_node_DirX = graph.AddNode<FSCollisionNode>();
					GetPort("DirX").Connect(CollisionId_node_DirX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CollisionId_node_DirX, assetPath);
					variableCount += CollisionId_node_DirX.SetData((FSCollision)DirX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.TimerId:
					FSTimerNode TimerId_node_DirX = graph.AddNode<FSTimerNode>();
					GetPort("DirX").Connect(TimerId_node_DirX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(TimerId_node_DirX, assetPath);
					variableCount += TimerId_node_DirX.SetData((FSTimer)DirX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.LagId:
					FSLagNode LagId_node_DirX = graph.AddNode<FSLagNode>();
					GetPort("DirX").Connect(LagId_node_DirX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LagId_node_DirX, assetPath);
					variableCount += LagId_node_DirX.SetData((FSLag)DirX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.EffectsId:
					FSEffectsNode EffectsId_node_DirX = graph.AddNode<FSEffectsNode>();
					GetPort("DirX").Connect(EffectsId_node_DirX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EffectsId_node_DirX, assetPath);
					variableCount += EffectsId_node_DirX.SetData((FSEffects)DirX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ColorsId:
					FSColorsNode ColorsId_node_DirX = graph.AddNode<FSColorsNode>();
					GetPort("DirX").Connect(ColorsId_node_DirX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ColorsId_node_DirX, assetPath);
					variableCount += ColorsId_node_DirX.SetData((FSColors)DirX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.OnHitId:
					FSOnHitNode OnHitId_node_DirX = graph.AddNode<FSOnHitNode>();
					GetPort("DirX").Connect(OnHitId_node_DirX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnHitId_node_DirX, assetPath);
					variableCount += OnHitId_node_DirX.SetData((FSOnHit)DirX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RandomId:
					FSRandomNode RandomId_node_DirX = graph.AddNode<FSRandomNode>();
					GetPort("DirX").Connect(RandomId_node_DirX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RandomId_node_DirX, assetPath);
					variableCount += RandomId_node_DirX.SetData((FSRandom)DirX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CameraId:
					FSCameraInfoNode CameraId_node_DirX = graph.AddNode<FSCameraInfoNode>();
					GetPort("DirX").Connect(CameraId_node_DirX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CameraId_node_DirX, assetPath);
					variableCount += CameraId_node_DirX.SetData((FSCameraInfo)DirX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SportsId:
					FSSportsNode SportsId_node_DirX = graph.AddNode<FSSportsNode>();
					GetPort("DirX").Connect(SportsId_node_DirX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SportsId_node_DirX, assetPath);
					variableCount += SportsId_node_DirX.SetData((FSSports)DirX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.Vector2Mag:
					FSVector2MagNode Vector2Mag_node_DirX = graph.AddNode<FSVector2MagNode>();
					GetPort("DirX").Connect(Vector2Mag_node_DirX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(Vector2Mag_node_DirX, assetPath);
					variableCount += Vector2Mag_node_DirX.SetData((FSVector2Mag)DirX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CPUHelpId:
					FSCpuHelpNode CPUHelpId_node_DirX = graph.AddNode<FSCpuHelpNode>();
					GetPort("DirX").Connect(CPUHelpId_node_DirX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CPUHelpId_node_DirX, assetPath);
					variableCount += CPUHelpId_node_DirX.SetData((FSCpuHelp)DirX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ItemId:
					FSItemNode ItemId_node_DirX = graph.AddNode<FSItemNode>();
					GetPort("DirX").Connect(ItemId_node_DirX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ItemId_node_DirX, assetPath);
					variableCount += ItemId_node_DirX.SetData((FSItem)DirX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ModeId:
					FSModeNode ModeId_node_DirX = graph.AddNode<FSModeNode>();
					GetPort("DirX").Connect(ModeId_node_DirX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ModeId_node_DirX, assetPath);
					variableCount += ModeId_node_DirX.SetData((FSMode)DirX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.JumpsId:
					FSJumpsNode JumpsId_node_DirX = graph.AddNode<FSJumpsNode>();
					GetPort("DirX").Connect(JumpsId_node_DirX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(JumpsId_node_DirX, assetPath);
					variableCount += JumpsId_node_DirX.SetData((FSJumps)DirX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RootAnimId:
					FSRootAnimNode RootAnimId_node_DirX = graph.AddNode<FSRootAnimNode>();
					GetPort("DirX").Connect(RootAnimId_node_DirX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RootAnimId_node_DirX, assetPath);
					variableCount += RootAnimId_node_DirX.SetData((FSRootAnim)DirX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FloatId:
					FSValueNode FloatId_node_DirX = graph.AddNode<FSValueNode>();
					GetPort("DirX").Connect(FloatId_node_DirX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FloatId_node_DirX, assetPath);
					variableCount += FloatId_node_DirX.SetData((FSValue)DirX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
			}
			++variableCount;
			
			DirY = data.DirY;
			
			switch (DirY.TID)
			{
				case FloatSource.TypeId.AgentId:
					FSAgentNode AgentId_node_DirY = graph.AddNode<FSAgentNode>();
					GetPort("DirY").Connect(AgentId_node_DirY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AgentId_node_DirY, assetPath);
					variableCount += AgentId_node_DirY.SetData((FSAgent)DirY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.BonesId:
					FSBonesNode BonesId_node_DirY = graph.AddNode<FSBonesNode>();
					GetPort("DirY").Connect(BonesId_node_DirY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BonesId_node_DirY, assetPath);
					variableCount += BonesId_node_DirY.SetData((FSBones)DirY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AttackId:
					FSAttackNode AttackId_node_DirY = graph.AddNode<FSAttackNode>();
					GetPort("DirY").Connect(AttackId_node_DirY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AttackId_node_DirY, assetPath);
					variableCount += AttackId_node_DirY.SetData((FSAttack)DirY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FrameId:
					FSFrameNode FrameId_node_DirY = graph.AddNode<FSFrameNode>();
					GetPort("DirY").Connect(FrameId_node_DirY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FrameId_node_DirY, assetPath);
					variableCount += FrameId_node_DirY.SetData((FSFrame)DirY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.InputId:
					FSInputNode InputId_node_DirY = graph.AddNode<FSInputNode>();
					GetPort("DirY").Connect(InputId_node_DirY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputId_node_DirY, assetPath);
					variableCount += InputId_node_DirY.SetData((FSInput)DirY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FuncId:
					FSFuncNode FuncId_node_DirY = graph.AddNode<FSFuncNode>();
					GetPort("DirY").Connect(FuncId_node_DirY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FuncId_node_DirY, assetPath);
					variableCount += FuncId_node_DirY.SetData((FSFunc)DirY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.MovementId:
					FSMovementNode MovementId_node_DirY = graph.AddNode<FSMovementNode>();
					GetPort("DirY").Connect(MovementId_node_DirY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(MovementId_node_DirY, assetPath);
					variableCount += MovementId_node_DirY.SetData((FSMovement)DirY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CombatId:
					FSCombatNode CombatId_node_DirY = graph.AddNode<FSCombatNode>();
					GetPort("DirY").Connect(CombatId_node_DirY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CombatId_node_DirY, assetPath);
					variableCount += CombatId_node_DirY.SetData((FSCombat)DirY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.GrabsId:
					FSGrabsNode GrabsId_node_DirY = graph.AddNode<FSGrabsNode>();
					GetPort("DirY").Connect(GrabsId_node_DirY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(GrabsId_node_DirY, assetPath);
					variableCount += GrabsId_node_DirY.SetData((FSGrabs)DirY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.DataId:
					FSDataNode DataId_node_DirY = graph.AddNode<FSDataNode>();
					GetPort("DirY").Connect(DataId_node_DirY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DataId_node_DirY, assetPath);
					variableCount += DataId_node_DirY.SetData((FSData)DirY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ScratchId:
					FSScratchNode ScratchId_node_DirY = graph.AddNode<FSScratchNode>();
					GetPort("DirY").Connect(ScratchId_node_DirY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ScratchId_node_DirY, assetPath);
					variableCount += ScratchId_node_DirY.SetData((FSScratch)DirY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AnimId:
					FSAnimNode AnimId_node_DirY = graph.AddNode<FSAnimNode>();
					GetPort("DirY").Connect(AnimId_node_DirY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AnimId_node_DirY, assetPath);
					variableCount += AnimId_node_DirY.SetData((FSAnim)DirY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SpeedId:
					FSSpeedNode SpeedId_node_DirY = graph.AddNode<FSSpeedNode>();
					GetPort("DirY").Connect(SpeedId_node_DirY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpeedId_node_DirY, assetPath);
					variableCount += SpeedId_node_DirY.SetData((FSSpeed)DirY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.PhysicsId:
					FSPhysicsNode PhysicsId_node_DirY = graph.AddNode<FSPhysicsNode>();
					GetPort("DirY").Connect(PhysicsId_node_DirY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(PhysicsId_node_DirY, assetPath);
					variableCount += PhysicsId_node_DirY.SetData((FSPhysics)DirY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CollisionId:
					FSCollisionNode CollisionId_node_DirY = graph.AddNode<FSCollisionNode>();
					GetPort("DirY").Connect(CollisionId_node_DirY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CollisionId_node_DirY, assetPath);
					variableCount += CollisionId_node_DirY.SetData((FSCollision)DirY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.TimerId:
					FSTimerNode TimerId_node_DirY = graph.AddNode<FSTimerNode>();
					GetPort("DirY").Connect(TimerId_node_DirY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(TimerId_node_DirY, assetPath);
					variableCount += TimerId_node_DirY.SetData((FSTimer)DirY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.LagId:
					FSLagNode LagId_node_DirY = graph.AddNode<FSLagNode>();
					GetPort("DirY").Connect(LagId_node_DirY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LagId_node_DirY, assetPath);
					variableCount += LagId_node_DirY.SetData((FSLag)DirY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.EffectsId:
					FSEffectsNode EffectsId_node_DirY = graph.AddNode<FSEffectsNode>();
					GetPort("DirY").Connect(EffectsId_node_DirY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EffectsId_node_DirY, assetPath);
					variableCount += EffectsId_node_DirY.SetData((FSEffects)DirY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ColorsId:
					FSColorsNode ColorsId_node_DirY = graph.AddNode<FSColorsNode>();
					GetPort("DirY").Connect(ColorsId_node_DirY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ColorsId_node_DirY, assetPath);
					variableCount += ColorsId_node_DirY.SetData((FSColors)DirY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.OnHitId:
					FSOnHitNode OnHitId_node_DirY = graph.AddNode<FSOnHitNode>();
					GetPort("DirY").Connect(OnHitId_node_DirY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnHitId_node_DirY, assetPath);
					variableCount += OnHitId_node_DirY.SetData((FSOnHit)DirY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RandomId:
					FSRandomNode RandomId_node_DirY = graph.AddNode<FSRandomNode>();
					GetPort("DirY").Connect(RandomId_node_DirY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RandomId_node_DirY, assetPath);
					variableCount += RandomId_node_DirY.SetData((FSRandom)DirY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CameraId:
					FSCameraInfoNode CameraId_node_DirY = graph.AddNode<FSCameraInfoNode>();
					GetPort("DirY").Connect(CameraId_node_DirY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CameraId_node_DirY, assetPath);
					variableCount += CameraId_node_DirY.SetData((FSCameraInfo)DirY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SportsId:
					FSSportsNode SportsId_node_DirY = graph.AddNode<FSSportsNode>();
					GetPort("DirY").Connect(SportsId_node_DirY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SportsId_node_DirY, assetPath);
					variableCount += SportsId_node_DirY.SetData((FSSports)DirY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.Vector2Mag:
					FSVector2MagNode Vector2Mag_node_DirY = graph.AddNode<FSVector2MagNode>();
					GetPort("DirY").Connect(Vector2Mag_node_DirY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(Vector2Mag_node_DirY, assetPath);
					variableCount += Vector2Mag_node_DirY.SetData((FSVector2Mag)DirY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CPUHelpId:
					FSCpuHelpNode CPUHelpId_node_DirY = graph.AddNode<FSCpuHelpNode>();
					GetPort("DirY").Connect(CPUHelpId_node_DirY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CPUHelpId_node_DirY, assetPath);
					variableCount += CPUHelpId_node_DirY.SetData((FSCpuHelp)DirY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ItemId:
					FSItemNode ItemId_node_DirY = graph.AddNode<FSItemNode>();
					GetPort("DirY").Connect(ItemId_node_DirY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ItemId_node_DirY, assetPath);
					variableCount += ItemId_node_DirY.SetData((FSItem)DirY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ModeId:
					FSModeNode ModeId_node_DirY = graph.AddNode<FSModeNode>();
					GetPort("DirY").Connect(ModeId_node_DirY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ModeId_node_DirY, assetPath);
					variableCount += ModeId_node_DirY.SetData((FSMode)DirY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.JumpsId:
					FSJumpsNode JumpsId_node_DirY = graph.AddNode<FSJumpsNode>();
					GetPort("DirY").Connect(JumpsId_node_DirY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(JumpsId_node_DirY, assetPath);
					variableCount += JumpsId_node_DirY.SetData((FSJumps)DirY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RootAnimId:
					FSRootAnimNode RootAnimId_node_DirY = graph.AddNode<FSRootAnimNode>();
					GetPort("DirY").Connect(RootAnimId_node_DirY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RootAnimId_node_DirY, assetPath);
					variableCount += RootAnimId_node_DirY.SetData((FSRootAnim)DirY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FloatId:
					FSValueNode FloatId_node_DirY = graph.AddNode<FSValueNode>();
					GetPort("DirY").Connect(FloatId_node_DirY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FloatId_node_DirY, assetPath);
					variableCount += FloatId_node_DirY.SetData((FSValue)DirY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
			}
			++variableCount;
			
			DirZ = data.DirZ;
			
			switch (DirZ.TID)
			{
				case FloatSource.TypeId.AgentId:
					FSAgentNode AgentId_node_DirZ = graph.AddNode<FSAgentNode>();
					GetPort("DirZ").Connect(AgentId_node_DirZ.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AgentId_node_DirZ, assetPath);
					variableCount += AgentId_node_DirZ.SetData((FSAgent)DirZ, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.BonesId:
					FSBonesNode BonesId_node_DirZ = graph.AddNode<FSBonesNode>();
					GetPort("DirZ").Connect(BonesId_node_DirZ.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BonesId_node_DirZ, assetPath);
					variableCount += BonesId_node_DirZ.SetData((FSBones)DirZ, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AttackId:
					FSAttackNode AttackId_node_DirZ = graph.AddNode<FSAttackNode>();
					GetPort("DirZ").Connect(AttackId_node_DirZ.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AttackId_node_DirZ, assetPath);
					variableCount += AttackId_node_DirZ.SetData((FSAttack)DirZ, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FrameId:
					FSFrameNode FrameId_node_DirZ = graph.AddNode<FSFrameNode>();
					GetPort("DirZ").Connect(FrameId_node_DirZ.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FrameId_node_DirZ, assetPath);
					variableCount += FrameId_node_DirZ.SetData((FSFrame)DirZ, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.InputId:
					FSInputNode InputId_node_DirZ = graph.AddNode<FSInputNode>();
					GetPort("DirZ").Connect(InputId_node_DirZ.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputId_node_DirZ, assetPath);
					variableCount += InputId_node_DirZ.SetData((FSInput)DirZ, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FuncId:
					FSFuncNode FuncId_node_DirZ = graph.AddNode<FSFuncNode>();
					GetPort("DirZ").Connect(FuncId_node_DirZ.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FuncId_node_DirZ, assetPath);
					variableCount += FuncId_node_DirZ.SetData((FSFunc)DirZ, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.MovementId:
					FSMovementNode MovementId_node_DirZ = graph.AddNode<FSMovementNode>();
					GetPort("DirZ").Connect(MovementId_node_DirZ.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(MovementId_node_DirZ, assetPath);
					variableCount += MovementId_node_DirZ.SetData((FSMovement)DirZ, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CombatId:
					FSCombatNode CombatId_node_DirZ = graph.AddNode<FSCombatNode>();
					GetPort("DirZ").Connect(CombatId_node_DirZ.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CombatId_node_DirZ, assetPath);
					variableCount += CombatId_node_DirZ.SetData((FSCombat)DirZ, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.GrabsId:
					FSGrabsNode GrabsId_node_DirZ = graph.AddNode<FSGrabsNode>();
					GetPort("DirZ").Connect(GrabsId_node_DirZ.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(GrabsId_node_DirZ, assetPath);
					variableCount += GrabsId_node_DirZ.SetData((FSGrabs)DirZ, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.DataId:
					FSDataNode DataId_node_DirZ = graph.AddNode<FSDataNode>();
					GetPort("DirZ").Connect(DataId_node_DirZ.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DataId_node_DirZ, assetPath);
					variableCount += DataId_node_DirZ.SetData((FSData)DirZ, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ScratchId:
					FSScratchNode ScratchId_node_DirZ = graph.AddNode<FSScratchNode>();
					GetPort("DirZ").Connect(ScratchId_node_DirZ.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ScratchId_node_DirZ, assetPath);
					variableCount += ScratchId_node_DirZ.SetData((FSScratch)DirZ, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AnimId:
					FSAnimNode AnimId_node_DirZ = graph.AddNode<FSAnimNode>();
					GetPort("DirZ").Connect(AnimId_node_DirZ.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AnimId_node_DirZ, assetPath);
					variableCount += AnimId_node_DirZ.SetData((FSAnim)DirZ, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SpeedId:
					FSSpeedNode SpeedId_node_DirZ = graph.AddNode<FSSpeedNode>();
					GetPort("DirZ").Connect(SpeedId_node_DirZ.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpeedId_node_DirZ, assetPath);
					variableCount += SpeedId_node_DirZ.SetData((FSSpeed)DirZ, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.PhysicsId:
					FSPhysicsNode PhysicsId_node_DirZ = graph.AddNode<FSPhysicsNode>();
					GetPort("DirZ").Connect(PhysicsId_node_DirZ.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(PhysicsId_node_DirZ, assetPath);
					variableCount += PhysicsId_node_DirZ.SetData((FSPhysics)DirZ, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CollisionId:
					FSCollisionNode CollisionId_node_DirZ = graph.AddNode<FSCollisionNode>();
					GetPort("DirZ").Connect(CollisionId_node_DirZ.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CollisionId_node_DirZ, assetPath);
					variableCount += CollisionId_node_DirZ.SetData((FSCollision)DirZ, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.TimerId:
					FSTimerNode TimerId_node_DirZ = graph.AddNode<FSTimerNode>();
					GetPort("DirZ").Connect(TimerId_node_DirZ.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(TimerId_node_DirZ, assetPath);
					variableCount += TimerId_node_DirZ.SetData((FSTimer)DirZ, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.LagId:
					FSLagNode LagId_node_DirZ = graph.AddNode<FSLagNode>();
					GetPort("DirZ").Connect(LagId_node_DirZ.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LagId_node_DirZ, assetPath);
					variableCount += LagId_node_DirZ.SetData((FSLag)DirZ, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.EffectsId:
					FSEffectsNode EffectsId_node_DirZ = graph.AddNode<FSEffectsNode>();
					GetPort("DirZ").Connect(EffectsId_node_DirZ.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EffectsId_node_DirZ, assetPath);
					variableCount += EffectsId_node_DirZ.SetData((FSEffects)DirZ, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ColorsId:
					FSColorsNode ColorsId_node_DirZ = graph.AddNode<FSColorsNode>();
					GetPort("DirZ").Connect(ColorsId_node_DirZ.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ColorsId_node_DirZ, assetPath);
					variableCount += ColorsId_node_DirZ.SetData((FSColors)DirZ, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.OnHitId:
					FSOnHitNode OnHitId_node_DirZ = graph.AddNode<FSOnHitNode>();
					GetPort("DirZ").Connect(OnHitId_node_DirZ.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnHitId_node_DirZ, assetPath);
					variableCount += OnHitId_node_DirZ.SetData((FSOnHit)DirZ, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RandomId:
					FSRandomNode RandomId_node_DirZ = graph.AddNode<FSRandomNode>();
					GetPort("DirZ").Connect(RandomId_node_DirZ.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RandomId_node_DirZ, assetPath);
					variableCount += RandomId_node_DirZ.SetData((FSRandom)DirZ, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CameraId:
					FSCameraInfoNode CameraId_node_DirZ = graph.AddNode<FSCameraInfoNode>();
					GetPort("DirZ").Connect(CameraId_node_DirZ.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CameraId_node_DirZ, assetPath);
					variableCount += CameraId_node_DirZ.SetData((FSCameraInfo)DirZ, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SportsId:
					FSSportsNode SportsId_node_DirZ = graph.AddNode<FSSportsNode>();
					GetPort("DirZ").Connect(SportsId_node_DirZ.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SportsId_node_DirZ, assetPath);
					variableCount += SportsId_node_DirZ.SetData((FSSports)DirZ, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.Vector2Mag:
					FSVector2MagNode Vector2Mag_node_DirZ = graph.AddNode<FSVector2MagNode>();
					GetPort("DirZ").Connect(Vector2Mag_node_DirZ.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(Vector2Mag_node_DirZ, assetPath);
					variableCount += Vector2Mag_node_DirZ.SetData((FSVector2Mag)DirZ, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CPUHelpId:
					FSCpuHelpNode CPUHelpId_node_DirZ = graph.AddNode<FSCpuHelpNode>();
					GetPort("DirZ").Connect(CPUHelpId_node_DirZ.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CPUHelpId_node_DirZ, assetPath);
					variableCount += CPUHelpId_node_DirZ.SetData((FSCpuHelp)DirZ, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ItemId:
					FSItemNode ItemId_node_DirZ = graph.AddNode<FSItemNode>();
					GetPort("DirZ").Connect(ItemId_node_DirZ.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ItemId_node_DirZ, assetPath);
					variableCount += ItemId_node_DirZ.SetData((FSItem)DirZ, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ModeId:
					FSModeNode ModeId_node_DirZ = graph.AddNode<FSModeNode>();
					GetPort("DirZ").Connect(ModeId_node_DirZ.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ModeId_node_DirZ, assetPath);
					variableCount += ModeId_node_DirZ.SetData((FSMode)DirZ, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.JumpsId:
					FSJumpsNode JumpsId_node_DirZ = graph.AddNode<FSJumpsNode>();
					GetPort("DirZ").Connect(JumpsId_node_DirZ.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(JumpsId_node_DirZ, assetPath);
					variableCount += JumpsId_node_DirZ.SetData((FSJumps)DirZ, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RootAnimId:
					FSRootAnimNode RootAnimId_node_DirZ = graph.AddNode<FSRootAnimNode>();
					GetPort("DirZ").Connect(RootAnimId_node_DirZ.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RootAnimId_node_DirZ, assetPath);
					variableCount += RootAnimId_node_DirZ.SetData((FSRootAnim)DirZ, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FloatId:
					FSValueNode FloatId_node_DirZ = graph.AddNode<FSValueNode>();
					GetPort("DirZ").Connect(FloatId_node_DirZ.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FloatId_node_DirZ, assetPath);
					variableCount += FloatId_node_DirZ.SetData((FSValue)DirZ, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
			}
			++variableCount;
			
			DynamicX = data.DynamicX;
			
			switch (DynamicX.TID)
			{
				case FloatSource.TypeId.AgentId:
					FSAgentNode AgentId_node_DynamicX = graph.AddNode<FSAgentNode>();
					GetPort("DynamicX").Connect(AgentId_node_DynamicX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AgentId_node_DynamicX, assetPath);
					variableCount += AgentId_node_DynamicX.SetData((FSAgent)DynamicX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.BonesId:
					FSBonesNode BonesId_node_DynamicX = graph.AddNode<FSBonesNode>();
					GetPort("DynamicX").Connect(BonesId_node_DynamicX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BonesId_node_DynamicX, assetPath);
					variableCount += BonesId_node_DynamicX.SetData((FSBones)DynamicX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AttackId:
					FSAttackNode AttackId_node_DynamicX = graph.AddNode<FSAttackNode>();
					GetPort("DynamicX").Connect(AttackId_node_DynamicX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AttackId_node_DynamicX, assetPath);
					variableCount += AttackId_node_DynamicX.SetData((FSAttack)DynamicX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FrameId:
					FSFrameNode FrameId_node_DynamicX = graph.AddNode<FSFrameNode>();
					GetPort("DynamicX").Connect(FrameId_node_DynamicX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FrameId_node_DynamicX, assetPath);
					variableCount += FrameId_node_DynamicX.SetData((FSFrame)DynamicX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.InputId:
					FSInputNode InputId_node_DynamicX = graph.AddNode<FSInputNode>();
					GetPort("DynamicX").Connect(InputId_node_DynamicX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputId_node_DynamicX, assetPath);
					variableCount += InputId_node_DynamicX.SetData((FSInput)DynamicX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FuncId:
					FSFuncNode FuncId_node_DynamicX = graph.AddNode<FSFuncNode>();
					GetPort("DynamicX").Connect(FuncId_node_DynamicX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FuncId_node_DynamicX, assetPath);
					variableCount += FuncId_node_DynamicX.SetData((FSFunc)DynamicX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.MovementId:
					FSMovementNode MovementId_node_DynamicX = graph.AddNode<FSMovementNode>();
					GetPort("DynamicX").Connect(MovementId_node_DynamicX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(MovementId_node_DynamicX, assetPath);
					variableCount += MovementId_node_DynamicX.SetData((FSMovement)DynamicX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CombatId:
					FSCombatNode CombatId_node_DynamicX = graph.AddNode<FSCombatNode>();
					GetPort("DynamicX").Connect(CombatId_node_DynamicX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CombatId_node_DynamicX, assetPath);
					variableCount += CombatId_node_DynamicX.SetData((FSCombat)DynamicX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.GrabsId:
					FSGrabsNode GrabsId_node_DynamicX = graph.AddNode<FSGrabsNode>();
					GetPort("DynamicX").Connect(GrabsId_node_DynamicX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(GrabsId_node_DynamicX, assetPath);
					variableCount += GrabsId_node_DynamicX.SetData((FSGrabs)DynamicX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.DataId:
					FSDataNode DataId_node_DynamicX = graph.AddNode<FSDataNode>();
					GetPort("DynamicX").Connect(DataId_node_DynamicX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DataId_node_DynamicX, assetPath);
					variableCount += DataId_node_DynamicX.SetData((FSData)DynamicX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ScratchId:
					FSScratchNode ScratchId_node_DynamicX = graph.AddNode<FSScratchNode>();
					GetPort("DynamicX").Connect(ScratchId_node_DynamicX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ScratchId_node_DynamicX, assetPath);
					variableCount += ScratchId_node_DynamicX.SetData((FSScratch)DynamicX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AnimId:
					FSAnimNode AnimId_node_DynamicX = graph.AddNode<FSAnimNode>();
					GetPort("DynamicX").Connect(AnimId_node_DynamicX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AnimId_node_DynamicX, assetPath);
					variableCount += AnimId_node_DynamicX.SetData((FSAnim)DynamicX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SpeedId:
					FSSpeedNode SpeedId_node_DynamicX = graph.AddNode<FSSpeedNode>();
					GetPort("DynamicX").Connect(SpeedId_node_DynamicX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpeedId_node_DynamicX, assetPath);
					variableCount += SpeedId_node_DynamicX.SetData((FSSpeed)DynamicX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.PhysicsId:
					FSPhysicsNode PhysicsId_node_DynamicX = graph.AddNode<FSPhysicsNode>();
					GetPort("DynamicX").Connect(PhysicsId_node_DynamicX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(PhysicsId_node_DynamicX, assetPath);
					variableCount += PhysicsId_node_DynamicX.SetData((FSPhysics)DynamicX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CollisionId:
					FSCollisionNode CollisionId_node_DynamicX = graph.AddNode<FSCollisionNode>();
					GetPort("DynamicX").Connect(CollisionId_node_DynamicX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CollisionId_node_DynamicX, assetPath);
					variableCount += CollisionId_node_DynamicX.SetData((FSCollision)DynamicX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.TimerId:
					FSTimerNode TimerId_node_DynamicX = graph.AddNode<FSTimerNode>();
					GetPort("DynamicX").Connect(TimerId_node_DynamicX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(TimerId_node_DynamicX, assetPath);
					variableCount += TimerId_node_DynamicX.SetData((FSTimer)DynamicX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.LagId:
					FSLagNode LagId_node_DynamicX = graph.AddNode<FSLagNode>();
					GetPort("DynamicX").Connect(LagId_node_DynamicX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LagId_node_DynamicX, assetPath);
					variableCount += LagId_node_DynamicX.SetData((FSLag)DynamicX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.EffectsId:
					FSEffectsNode EffectsId_node_DynamicX = graph.AddNode<FSEffectsNode>();
					GetPort("DynamicX").Connect(EffectsId_node_DynamicX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EffectsId_node_DynamicX, assetPath);
					variableCount += EffectsId_node_DynamicX.SetData((FSEffects)DynamicX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ColorsId:
					FSColorsNode ColorsId_node_DynamicX = graph.AddNode<FSColorsNode>();
					GetPort("DynamicX").Connect(ColorsId_node_DynamicX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ColorsId_node_DynamicX, assetPath);
					variableCount += ColorsId_node_DynamicX.SetData((FSColors)DynamicX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.OnHitId:
					FSOnHitNode OnHitId_node_DynamicX = graph.AddNode<FSOnHitNode>();
					GetPort("DynamicX").Connect(OnHitId_node_DynamicX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnHitId_node_DynamicX, assetPath);
					variableCount += OnHitId_node_DynamicX.SetData((FSOnHit)DynamicX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RandomId:
					FSRandomNode RandomId_node_DynamicX = graph.AddNode<FSRandomNode>();
					GetPort("DynamicX").Connect(RandomId_node_DynamicX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RandomId_node_DynamicX, assetPath);
					variableCount += RandomId_node_DynamicX.SetData((FSRandom)DynamicX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CameraId:
					FSCameraInfoNode CameraId_node_DynamicX = graph.AddNode<FSCameraInfoNode>();
					GetPort("DynamicX").Connect(CameraId_node_DynamicX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CameraId_node_DynamicX, assetPath);
					variableCount += CameraId_node_DynamicX.SetData((FSCameraInfo)DynamicX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SportsId:
					FSSportsNode SportsId_node_DynamicX = graph.AddNode<FSSportsNode>();
					GetPort("DynamicX").Connect(SportsId_node_DynamicX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SportsId_node_DynamicX, assetPath);
					variableCount += SportsId_node_DynamicX.SetData((FSSports)DynamicX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.Vector2Mag:
					FSVector2MagNode Vector2Mag_node_DynamicX = graph.AddNode<FSVector2MagNode>();
					GetPort("DynamicX").Connect(Vector2Mag_node_DynamicX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(Vector2Mag_node_DynamicX, assetPath);
					variableCount += Vector2Mag_node_DynamicX.SetData((FSVector2Mag)DynamicX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CPUHelpId:
					FSCpuHelpNode CPUHelpId_node_DynamicX = graph.AddNode<FSCpuHelpNode>();
					GetPort("DynamicX").Connect(CPUHelpId_node_DynamicX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CPUHelpId_node_DynamicX, assetPath);
					variableCount += CPUHelpId_node_DynamicX.SetData((FSCpuHelp)DynamicX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ItemId:
					FSItemNode ItemId_node_DynamicX = graph.AddNode<FSItemNode>();
					GetPort("DynamicX").Connect(ItemId_node_DynamicX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ItemId_node_DynamicX, assetPath);
					variableCount += ItemId_node_DynamicX.SetData((FSItem)DynamicX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ModeId:
					FSModeNode ModeId_node_DynamicX = graph.AddNode<FSModeNode>();
					GetPort("DynamicX").Connect(ModeId_node_DynamicX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ModeId_node_DynamicX, assetPath);
					variableCount += ModeId_node_DynamicX.SetData((FSMode)DynamicX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.JumpsId:
					FSJumpsNode JumpsId_node_DynamicX = graph.AddNode<FSJumpsNode>();
					GetPort("DynamicX").Connect(JumpsId_node_DynamicX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(JumpsId_node_DynamicX, assetPath);
					variableCount += JumpsId_node_DynamicX.SetData((FSJumps)DynamicX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RootAnimId:
					FSRootAnimNode RootAnimId_node_DynamicX = graph.AddNode<FSRootAnimNode>();
					GetPort("DynamicX").Connect(RootAnimId_node_DynamicX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RootAnimId_node_DynamicX, assetPath);
					variableCount += RootAnimId_node_DynamicX.SetData((FSRootAnim)DynamicX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FloatId:
					FSValueNode FloatId_node_DynamicX = graph.AddNode<FSValueNode>();
					GetPort("DynamicX").Connect(FloatId_node_DynamicX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FloatId_node_DynamicX, assetPath);
					variableCount += FloatId_node_DynamicX.SetData((FSValue)DynamicX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
			}
			++variableCount;
			
			DynamicY = data.DynamicY;
			
			switch (DynamicY.TID)
			{
				case FloatSource.TypeId.AgentId:
					FSAgentNode AgentId_node_DynamicY = graph.AddNode<FSAgentNode>();
					GetPort("DynamicY").Connect(AgentId_node_DynamicY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AgentId_node_DynamicY, assetPath);
					variableCount += AgentId_node_DynamicY.SetData((FSAgent)DynamicY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.BonesId:
					FSBonesNode BonesId_node_DynamicY = graph.AddNode<FSBonesNode>();
					GetPort("DynamicY").Connect(BonesId_node_DynamicY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BonesId_node_DynamicY, assetPath);
					variableCount += BonesId_node_DynamicY.SetData((FSBones)DynamicY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AttackId:
					FSAttackNode AttackId_node_DynamicY = graph.AddNode<FSAttackNode>();
					GetPort("DynamicY").Connect(AttackId_node_DynamicY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AttackId_node_DynamicY, assetPath);
					variableCount += AttackId_node_DynamicY.SetData((FSAttack)DynamicY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FrameId:
					FSFrameNode FrameId_node_DynamicY = graph.AddNode<FSFrameNode>();
					GetPort("DynamicY").Connect(FrameId_node_DynamicY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FrameId_node_DynamicY, assetPath);
					variableCount += FrameId_node_DynamicY.SetData((FSFrame)DynamicY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.InputId:
					FSInputNode InputId_node_DynamicY = graph.AddNode<FSInputNode>();
					GetPort("DynamicY").Connect(InputId_node_DynamicY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputId_node_DynamicY, assetPath);
					variableCount += InputId_node_DynamicY.SetData((FSInput)DynamicY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FuncId:
					FSFuncNode FuncId_node_DynamicY = graph.AddNode<FSFuncNode>();
					GetPort("DynamicY").Connect(FuncId_node_DynamicY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FuncId_node_DynamicY, assetPath);
					variableCount += FuncId_node_DynamicY.SetData((FSFunc)DynamicY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.MovementId:
					FSMovementNode MovementId_node_DynamicY = graph.AddNode<FSMovementNode>();
					GetPort("DynamicY").Connect(MovementId_node_DynamicY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(MovementId_node_DynamicY, assetPath);
					variableCount += MovementId_node_DynamicY.SetData((FSMovement)DynamicY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CombatId:
					FSCombatNode CombatId_node_DynamicY = graph.AddNode<FSCombatNode>();
					GetPort("DynamicY").Connect(CombatId_node_DynamicY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CombatId_node_DynamicY, assetPath);
					variableCount += CombatId_node_DynamicY.SetData((FSCombat)DynamicY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.GrabsId:
					FSGrabsNode GrabsId_node_DynamicY = graph.AddNode<FSGrabsNode>();
					GetPort("DynamicY").Connect(GrabsId_node_DynamicY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(GrabsId_node_DynamicY, assetPath);
					variableCount += GrabsId_node_DynamicY.SetData((FSGrabs)DynamicY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.DataId:
					FSDataNode DataId_node_DynamicY = graph.AddNode<FSDataNode>();
					GetPort("DynamicY").Connect(DataId_node_DynamicY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DataId_node_DynamicY, assetPath);
					variableCount += DataId_node_DynamicY.SetData((FSData)DynamicY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ScratchId:
					FSScratchNode ScratchId_node_DynamicY = graph.AddNode<FSScratchNode>();
					GetPort("DynamicY").Connect(ScratchId_node_DynamicY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ScratchId_node_DynamicY, assetPath);
					variableCount += ScratchId_node_DynamicY.SetData((FSScratch)DynamicY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AnimId:
					FSAnimNode AnimId_node_DynamicY = graph.AddNode<FSAnimNode>();
					GetPort("DynamicY").Connect(AnimId_node_DynamicY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AnimId_node_DynamicY, assetPath);
					variableCount += AnimId_node_DynamicY.SetData((FSAnim)DynamicY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SpeedId:
					FSSpeedNode SpeedId_node_DynamicY = graph.AddNode<FSSpeedNode>();
					GetPort("DynamicY").Connect(SpeedId_node_DynamicY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpeedId_node_DynamicY, assetPath);
					variableCount += SpeedId_node_DynamicY.SetData((FSSpeed)DynamicY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.PhysicsId:
					FSPhysicsNode PhysicsId_node_DynamicY = graph.AddNode<FSPhysicsNode>();
					GetPort("DynamicY").Connect(PhysicsId_node_DynamicY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(PhysicsId_node_DynamicY, assetPath);
					variableCount += PhysicsId_node_DynamicY.SetData((FSPhysics)DynamicY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CollisionId:
					FSCollisionNode CollisionId_node_DynamicY = graph.AddNode<FSCollisionNode>();
					GetPort("DynamicY").Connect(CollisionId_node_DynamicY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CollisionId_node_DynamicY, assetPath);
					variableCount += CollisionId_node_DynamicY.SetData((FSCollision)DynamicY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.TimerId:
					FSTimerNode TimerId_node_DynamicY = graph.AddNode<FSTimerNode>();
					GetPort("DynamicY").Connect(TimerId_node_DynamicY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(TimerId_node_DynamicY, assetPath);
					variableCount += TimerId_node_DynamicY.SetData((FSTimer)DynamicY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.LagId:
					FSLagNode LagId_node_DynamicY = graph.AddNode<FSLagNode>();
					GetPort("DynamicY").Connect(LagId_node_DynamicY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LagId_node_DynamicY, assetPath);
					variableCount += LagId_node_DynamicY.SetData((FSLag)DynamicY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.EffectsId:
					FSEffectsNode EffectsId_node_DynamicY = graph.AddNode<FSEffectsNode>();
					GetPort("DynamicY").Connect(EffectsId_node_DynamicY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EffectsId_node_DynamicY, assetPath);
					variableCount += EffectsId_node_DynamicY.SetData((FSEffects)DynamicY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ColorsId:
					FSColorsNode ColorsId_node_DynamicY = graph.AddNode<FSColorsNode>();
					GetPort("DynamicY").Connect(ColorsId_node_DynamicY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ColorsId_node_DynamicY, assetPath);
					variableCount += ColorsId_node_DynamicY.SetData((FSColors)DynamicY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.OnHitId:
					FSOnHitNode OnHitId_node_DynamicY = graph.AddNode<FSOnHitNode>();
					GetPort("DynamicY").Connect(OnHitId_node_DynamicY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnHitId_node_DynamicY, assetPath);
					variableCount += OnHitId_node_DynamicY.SetData((FSOnHit)DynamicY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RandomId:
					FSRandomNode RandomId_node_DynamicY = graph.AddNode<FSRandomNode>();
					GetPort("DynamicY").Connect(RandomId_node_DynamicY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RandomId_node_DynamicY, assetPath);
					variableCount += RandomId_node_DynamicY.SetData((FSRandom)DynamicY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CameraId:
					FSCameraInfoNode CameraId_node_DynamicY = graph.AddNode<FSCameraInfoNode>();
					GetPort("DynamicY").Connect(CameraId_node_DynamicY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CameraId_node_DynamicY, assetPath);
					variableCount += CameraId_node_DynamicY.SetData((FSCameraInfo)DynamicY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SportsId:
					FSSportsNode SportsId_node_DynamicY = graph.AddNode<FSSportsNode>();
					GetPort("DynamicY").Connect(SportsId_node_DynamicY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SportsId_node_DynamicY, assetPath);
					variableCount += SportsId_node_DynamicY.SetData((FSSports)DynamicY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.Vector2Mag:
					FSVector2MagNode Vector2Mag_node_DynamicY = graph.AddNode<FSVector2MagNode>();
					GetPort("DynamicY").Connect(Vector2Mag_node_DynamicY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(Vector2Mag_node_DynamicY, assetPath);
					variableCount += Vector2Mag_node_DynamicY.SetData((FSVector2Mag)DynamicY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CPUHelpId:
					FSCpuHelpNode CPUHelpId_node_DynamicY = graph.AddNode<FSCpuHelpNode>();
					GetPort("DynamicY").Connect(CPUHelpId_node_DynamicY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CPUHelpId_node_DynamicY, assetPath);
					variableCount += CPUHelpId_node_DynamicY.SetData((FSCpuHelp)DynamicY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ItemId:
					FSItemNode ItemId_node_DynamicY = graph.AddNode<FSItemNode>();
					GetPort("DynamicY").Connect(ItemId_node_DynamicY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ItemId_node_DynamicY, assetPath);
					variableCount += ItemId_node_DynamicY.SetData((FSItem)DynamicY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ModeId:
					FSModeNode ModeId_node_DynamicY = graph.AddNode<FSModeNode>();
					GetPort("DynamicY").Connect(ModeId_node_DynamicY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ModeId_node_DynamicY, assetPath);
					variableCount += ModeId_node_DynamicY.SetData((FSMode)DynamicY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.JumpsId:
					FSJumpsNode JumpsId_node_DynamicY = graph.AddNode<FSJumpsNode>();
					GetPort("DynamicY").Connect(JumpsId_node_DynamicY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(JumpsId_node_DynamicY, assetPath);
					variableCount += JumpsId_node_DynamicY.SetData((FSJumps)DynamicY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RootAnimId:
					FSRootAnimNode RootAnimId_node_DynamicY = graph.AddNode<FSRootAnimNode>();
					GetPort("DynamicY").Connect(RootAnimId_node_DynamicY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RootAnimId_node_DynamicY, assetPath);
					variableCount += RootAnimId_node_DynamicY.SetData((FSRootAnim)DynamicY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FloatId:
					FSValueNode FloatId_node_DynamicY = graph.AddNode<FSValueNode>();
					GetPort("DynamicY").Connect(FloatId_node_DynamicY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FloatId_node_DynamicY, assetPath);
					variableCount += FloatId_node_DynamicY.SetData((FSValue)DynamicY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
			}
			++variableCount;
			
			DynamicZ = data.DynamicZ;
			
			switch (DynamicZ.TID)
			{
				case FloatSource.TypeId.AgentId:
					FSAgentNode AgentId_node_DynamicZ = graph.AddNode<FSAgentNode>();
					GetPort("DynamicZ").Connect(AgentId_node_DynamicZ.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AgentId_node_DynamicZ, assetPath);
					variableCount += AgentId_node_DynamicZ.SetData((FSAgent)DynamicZ, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.BonesId:
					FSBonesNode BonesId_node_DynamicZ = graph.AddNode<FSBonesNode>();
					GetPort("DynamicZ").Connect(BonesId_node_DynamicZ.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BonesId_node_DynamicZ, assetPath);
					variableCount += BonesId_node_DynamicZ.SetData((FSBones)DynamicZ, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AttackId:
					FSAttackNode AttackId_node_DynamicZ = graph.AddNode<FSAttackNode>();
					GetPort("DynamicZ").Connect(AttackId_node_DynamicZ.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AttackId_node_DynamicZ, assetPath);
					variableCount += AttackId_node_DynamicZ.SetData((FSAttack)DynamicZ, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FrameId:
					FSFrameNode FrameId_node_DynamicZ = graph.AddNode<FSFrameNode>();
					GetPort("DynamicZ").Connect(FrameId_node_DynamicZ.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FrameId_node_DynamicZ, assetPath);
					variableCount += FrameId_node_DynamicZ.SetData((FSFrame)DynamicZ, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.InputId:
					FSInputNode InputId_node_DynamicZ = graph.AddNode<FSInputNode>();
					GetPort("DynamicZ").Connect(InputId_node_DynamicZ.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputId_node_DynamicZ, assetPath);
					variableCount += InputId_node_DynamicZ.SetData((FSInput)DynamicZ, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FuncId:
					FSFuncNode FuncId_node_DynamicZ = graph.AddNode<FSFuncNode>();
					GetPort("DynamicZ").Connect(FuncId_node_DynamicZ.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FuncId_node_DynamicZ, assetPath);
					variableCount += FuncId_node_DynamicZ.SetData((FSFunc)DynamicZ, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.MovementId:
					FSMovementNode MovementId_node_DynamicZ = graph.AddNode<FSMovementNode>();
					GetPort("DynamicZ").Connect(MovementId_node_DynamicZ.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(MovementId_node_DynamicZ, assetPath);
					variableCount += MovementId_node_DynamicZ.SetData((FSMovement)DynamicZ, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CombatId:
					FSCombatNode CombatId_node_DynamicZ = graph.AddNode<FSCombatNode>();
					GetPort("DynamicZ").Connect(CombatId_node_DynamicZ.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CombatId_node_DynamicZ, assetPath);
					variableCount += CombatId_node_DynamicZ.SetData((FSCombat)DynamicZ, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.GrabsId:
					FSGrabsNode GrabsId_node_DynamicZ = graph.AddNode<FSGrabsNode>();
					GetPort("DynamicZ").Connect(GrabsId_node_DynamicZ.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(GrabsId_node_DynamicZ, assetPath);
					variableCount += GrabsId_node_DynamicZ.SetData((FSGrabs)DynamicZ, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.DataId:
					FSDataNode DataId_node_DynamicZ = graph.AddNode<FSDataNode>();
					GetPort("DynamicZ").Connect(DataId_node_DynamicZ.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DataId_node_DynamicZ, assetPath);
					variableCount += DataId_node_DynamicZ.SetData((FSData)DynamicZ, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ScratchId:
					FSScratchNode ScratchId_node_DynamicZ = graph.AddNode<FSScratchNode>();
					GetPort("DynamicZ").Connect(ScratchId_node_DynamicZ.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ScratchId_node_DynamicZ, assetPath);
					variableCount += ScratchId_node_DynamicZ.SetData((FSScratch)DynamicZ, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AnimId:
					FSAnimNode AnimId_node_DynamicZ = graph.AddNode<FSAnimNode>();
					GetPort("DynamicZ").Connect(AnimId_node_DynamicZ.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AnimId_node_DynamicZ, assetPath);
					variableCount += AnimId_node_DynamicZ.SetData((FSAnim)DynamicZ, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SpeedId:
					FSSpeedNode SpeedId_node_DynamicZ = graph.AddNode<FSSpeedNode>();
					GetPort("DynamicZ").Connect(SpeedId_node_DynamicZ.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpeedId_node_DynamicZ, assetPath);
					variableCount += SpeedId_node_DynamicZ.SetData((FSSpeed)DynamicZ, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.PhysicsId:
					FSPhysicsNode PhysicsId_node_DynamicZ = graph.AddNode<FSPhysicsNode>();
					GetPort("DynamicZ").Connect(PhysicsId_node_DynamicZ.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(PhysicsId_node_DynamicZ, assetPath);
					variableCount += PhysicsId_node_DynamicZ.SetData((FSPhysics)DynamicZ, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CollisionId:
					FSCollisionNode CollisionId_node_DynamicZ = graph.AddNode<FSCollisionNode>();
					GetPort("DynamicZ").Connect(CollisionId_node_DynamicZ.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CollisionId_node_DynamicZ, assetPath);
					variableCount += CollisionId_node_DynamicZ.SetData((FSCollision)DynamicZ, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.TimerId:
					FSTimerNode TimerId_node_DynamicZ = graph.AddNode<FSTimerNode>();
					GetPort("DynamicZ").Connect(TimerId_node_DynamicZ.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(TimerId_node_DynamicZ, assetPath);
					variableCount += TimerId_node_DynamicZ.SetData((FSTimer)DynamicZ, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.LagId:
					FSLagNode LagId_node_DynamicZ = graph.AddNode<FSLagNode>();
					GetPort("DynamicZ").Connect(LagId_node_DynamicZ.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LagId_node_DynamicZ, assetPath);
					variableCount += LagId_node_DynamicZ.SetData((FSLag)DynamicZ, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.EffectsId:
					FSEffectsNode EffectsId_node_DynamicZ = graph.AddNode<FSEffectsNode>();
					GetPort("DynamicZ").Connect(EffectsId_node_DynamicZ.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EffectsId_node_DynamicZ, assetPath);
					variableCount += EffectsId_node_DynamicZ.SetData((FSEffects)DynamicZ, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ColorsId:
					FSColorsNode ColorsId_node_DynamicZ = graph.AddNode<FSColorsNode>();
					GetPort("DynamicZ").Connect(ColorsId_node_DynamicZ.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ColorsId_node_DynamicZ, assetPath);
					variableCount += ColorsId_node_DynamicZ.SetData((FSColors)DynamicZ, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.OnHitId:
					FSOnHitNode OnHitId_node_DynamicZ = graph.AddNode<FSOnHitNode>();
					GetPort("DynamicZ").Connect(OnHitId_node_DynamicZ.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnHitId_node_DynamicZ, assetPath);
					variableCount += OnHitId_node_DynamicZ.SetData((FSOnHit)DynamicZ, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RandomId:
					FSRandomNode RandomId_node_DynamicZ = graph.AddNode<FSRandomNode>();
					GetPort("DynamicZ").Connect(RandomId_node_DynamicZ.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RandomId_node_DynamicZ, assetPath);
					variableCount += RandomId_node_DynamicZ.SetData((FSRandom)DynamicZ, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CameraId:
					FSCameraInfoNode CameraId_node_DynamicZ = graph.AddNode<FSCameraInfoNode>();
					GetPort("DynamicZ").Connect(CameraId_node_DynamicZ.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CameraId_node_DynamicZ, assetPath);
					variableCount += CameraId_node_DynamicZ.SetData((FSCameraInfo)DynamicZ, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SportsId:
					FSSportsNode SportsId_node_DynamicZ = graph.AddNode<FSSportsNode>();
					GetPort("DynamicZ").Connect(SportsId_node_DynamicZ.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SportsId_node_DynamicZ, assetPath);
					variableCount += SportsId_node_DynamicZ.SetData((FSSports)DynamicZ, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.Vector2Mag:
					FSVector2MagNode Vector2Mag_node_DynamicZ = graph.AddNode<FSVector2MagNode>();
					GetPort("DynamicZ").Connect(Vector2Mag_node_DynamicZ.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(Vector2Mag_node_DynamicZ, assetPath);
					variableCount += Vector2Mag_node_DynamicZ.SetData((FSVector2Mag)DynamicZ, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CPUHelpId:
					FSCpuHelpNode CPUHelpId_node_DynamicZ = graph.AddNode<FSCpuHelpNode>();
					GetPort("DynamicZ").Connect(CPUHelpId_node_DynamicZ.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CPUHelpId_node_DynamicZ, assetPath);
					variableCount += CPUHelpId_node_DynamicZ.SetData((FSCpuHelp)DynamicZ, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ItemId:
					FSItemNode ItemId_node_DynamicZ = graph.AddNode<FSItemNode>();
					GetPort("DynamicZ").Connect(ItemId_node_DynamicZ.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ItemId_node_DynamicZ, assetPath);
					variableCount += ItemId_node_DynamicZ.SetData((FSItem)DynamicZ, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ModeId:
					FSModeNode ModeId_node_DynamicZ = graph.AddNode<FSModeNode>();
					GetPort("DynamicZ").Connect(ModeId_node_DynamicZ.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ModeId_node_DynamicZ, assetPath);
					variableCount += ModeId_node_DynamicZ.SetData((FSMode)DynamicZ, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.JumpsId:
					FSJumpsNode JumpsId_node_DynamicZ = graph.AddNode<FSJumpsNode>();
					GetPort("DynamicZ").Connect(JumpsId_node_DynamicZ.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(JumpsId_node_DynamicZ, assetPath);
					variableCount += JumpsId_node_DynamicZ.SetData((FSJumps)DynamicZ, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RootAnimId:
					FSRootAnimNode RootAnimId_node_DynamicZ = graph.AddNode<FSRootAnimNode>();
					GetPort("DynamicZ").Connect(RootAnimId_node_DynamicZ.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RootAnimId_node_DynamicZ, assetPath);
					variableCount += RootAnimId_node_DynamicZ.SetData((FSRootAnim)DynamicZ, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FloatId:
					FSValueNode FloatId_node_DynamicZ = graph.AddNode<FSValueNode>();
					GetPort("DynamicZ").Connect(FloatId_node_DynamicZ.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FloatId_node_DynamicZ, assetPath);
					variableCount += FloatId_node_DynamicZ.SetData((FSValue)DynamicZ, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
			}
			++variableCount;
			
			Scale = data.Scale;
			
			switch (Scale.TID)
			{
				case FloatSource.TypeId.AgentId:
					FSAgentNode AgentId_node_Scale = graph.AddNode<FSAgentNode>();
					GetPort("Scale").Connect(AgentId_node_Scale.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AgentId_node_Scale, assetPath);
					variableCount += AgentId_node_Scale.SetData((FSAgent)Scale, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.BonesId:
					FSBonesNode BonesId_node_Scale = graph.AddNode<FSBonesNode>();
					GetPort("Scale").Connect(BonesId_node_Scale.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BonesId_node_Scale, assetPath);
					variableCount += BonesId_node_Scale.SetData((FSBones)Scale, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AttackId:
					FSAttackNode AttackId_node_Scale = graph.AddNode<FSAttackNode>();
					GetPort("Scale").Connect(AttackId_node_Scale.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AttackId_node_Scale, assetPath);
					variableCount += AttackId_node_Scale.SetData((FSAttack)Scale, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FrameId:
					FSFrameNode FrameId_node_Scale = graph.AddNode<FSFrameNode>();
					GetPort("Scale").Connect(FrameId_node_Scale.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FrameId_node_Scale, assetPath);
					variableCount += FrameId_node_Scale.SetData((FSFrame)Scale, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.InputId:
					FSInputNode InputId_node_Scale = graph.AddNode<FSInputNode>();
					GetPort("Scale").Connect(InputId_node_Scale.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputId_node_Scale, assetPath);
					variableCount += InputId_node_Scale.SetData((FSInput)Scale, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FuncId:
					FSFuncNode FuncId_node_Scale = graph.AddNode<FSFuncNode>();
					GetPort("Scale").Connect(FuncId_node_Scale.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FuncId_node_Scale, assetPath);
					variableCount += FuncId_node_Scale.SetData((FSFunc)Scale, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.MovementId:
					FSMovementNode MovementId_node_Scale = graph.AddNode<FSMovementNode>();
					GetPort("Scale").Connect(MovementId_node_Scale.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(MovementId_node_Scale, assetPath);
					variableCount += MovementId_node_Scale.SetData((FSMovement)Scale, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CombatId:
					FSCombatNode CombatId_node_Scale = graph.AddNode<FSCombatNode>();
					GetPort("Scale").Connect(CombatId_node_Scale.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CombatId_node_Scale, assetPath);
					variableCount += CombatId_node_Scale.SetData((FSCombat)Scale, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.GrabsId:
					FSGrabsNode GrabsId_node_Scale = graph.AddNode<FSGrabsNode>();
					GetPort("Scale").Connect(GrabsId_node_Scale.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(GrabsId_node_Scale, assetPath);
					variableCount += GrabsId_node_Scale.SetData((FSGrabs)Scale, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.DataId:
					FSDataNode DataId_node_Scale = graph.AddNode<FSDataNode>();
					GetPort("Scale").Connect(DataId_node_Scale.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DataId_node_Scale, assetPath);
					variableCount += DataId_node_Scale.SetData((FSData)Scale, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ScratchId:
					FSScratchNode ScratchId_node_Scale = graph.AddNode<FSScratchNode>();
					GetPort("Scale").Connect(ScratchId_node_Scale.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ScratchId_node_Scale, assetPath);
					variableCount += ScratchId_node_Scale.SetData((FSScratch)Scale, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AnimId:
					FSAnimNode AnimId_node_Scale = graph.AddNode<FSAnimNode>();
					GetPort("Scale").Connect(AnimId_node_Scale.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AnimId_node_Scale, assetPath);
					variableCount += AnimId_node_Scale.SetData((FSAnim)Scale, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SpeedId:
					FSSpeedNode SpeedId_node_Scale = graph.AddNode<FSSpeedNode>();
					GetPort("Scale").Connect(SpeedId_node_Scale.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpeedId_node_Scale, assetPath);
					variableCount += SpeedId_node_Scale.SetData((FSSpeed)Scale, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.PhysicsId:
					FSPhysicsNode PhysicsId_node_Scale = graph.AddNode<FSPhysicsNode>();
					GetPort("Scale").Connect(PhysicsId_node_Scale.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(PhysicsId_node_Scale, assetPath);
					variableCount += PhysicsId_node_Scale.SetData((FSPhysics)Scale, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CollisionId:
					FSCollisionNode CollisionId_node_Scale = graph.AddNode<FSCollisionNode>();
					GetPort("Scale").Connect(CollisionId_node_Scale.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CollisionId_node_Scale, assetPath);
					variableCount += CollisionId_node_Scale.SetData((FSCollision)Scale, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.TimerId:
					FSTimerNode TimerId_node_Scale = graph.AddNode<FSTimerNode>();
					GetPort("Scale").Connect(TimerId_node_Scale.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(TimerId_node_Scale, assetPath);
					variableCount += TimerId_node_Scale.SetData((FSTimer)Scale, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.LagId:
					FSLagNode LagId_node_Scale = graph.AddNode<FSLagNode>();
					GetPort("Scale").Connect(LagId_node_Scale.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LagId_node_Scale, assetPath);
					variableCount += LagId_node_Scale.SetData((FSLag)Scale, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.EffectsId:
					FSEffectsNode EffectsId_node_Scale = graph.AddNode<FSEffectsNode>();
					GetPort("Scale").Connect(EffectsId_node_Scale.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EffectsId_node_Scale, assetPath);
					variableCount += EffectsId_node_Scale.SetData((FSEffects)Scale, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ColorsId:
					FSColorsNode ColorsId_node_Scale = graph.AddNode<FSColorsNode>();
					GetPort("Scale").Connect(ColorsId_node_Scale.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ColorsId_node_Scale, assetPath);
					variableCount += ColorsId_node_Scale.SetData((FSColors)Scale, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.OnHitId:
					FSOnHitNode OnHitId_node_Scale = graph.AddNode<FSOnHitNode>();
					GetPort("Scale").Connect(OnHitId_node_Scale.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnHitId_node_Scale, assetPath);
					variableCount += OnHitId_node_Scale.SetData((FSOnHit)Scale, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RandomId:
					FSRandomNode RandomId_node_Scale = graph.AddNode<FSRandomNode>();
					GetPort("Scale").Connect(RandomId_node_Scale.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RandomId_node_Scale, assetPath);
					variableCount += RandomId_node_Scale.SetData((FSRandom)Scale, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CameraId:
					FSCameraInfoNode CameraId_node_Scale = graph.AddNode<FSCameraInfoNode>();
					GetPort("Scale").Connect(CameraId_node_Scale.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CameraId_node_Scale, assetPath);
					variableCount += CameraId_node_Scale.SetData((FSCameraInfo)Scale, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SportsId:
					FSSportsNode SportsId_node_Scale = graph.AddNode<FSSportsNode>();
					GetPort("Scale").Connect(SportsId_node_Scale.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SportsId_node_Scale, assetPath);
					variableCount += SportsId_node_Scale.SetData((FSSports)Scale, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.Vector2Mag:
					FSVector2MagNode Vector2Mag_node_Scale = graph.AddNode<FSVector2MagNode>();
					GetPort("Scale").Connect(Vector2Mag_node_Scale.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(Vector2Mag_node_Scale, assetPath);
					variableCount += Vector2Mag_node_Scale.SetData((FSVector2Mag)Scale, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CPUHelpId:
					FSCpuHelpNode CPUHelpId_node_Scale = graph.AddNode<FSCpuHelpNode>();
					GetPort("Scale").Connect(CPUHelpId_node_Scale.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CPUHelpId_node_Scale, assetPath);
					variableCount += CPUHelpId_node_Scale.SetData((FSCpuHelp)Scale, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ItemId:
					FSItemNode ItemId_node_Scale = graph.AddNode<FSItemNode>();
					GetPort("Scale").Connect(ItemId_node_Scale.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ItemId_node_Scale, assetPath);
					variableCount += ItemId_node_Scale.SetData((FSItem)Scale, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ModeId:
					FSModeNode ModeId_node_Scale = graph.AddNode<FSModeNode>();
					GetPort("Scale").Connect(ModeId_node_Scale.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ModeId_node_Scale, assetPath);
					variableCount += ModeId_node_Scale.SetData((FSMode)Scale, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.JumpsId:
					FSJumpsNode JumpsId_node_Scale = graph.AddNode<FSJumpsNode>();
					GetPort("Scale").Connect(JumpsId_node_Scale.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(JumpsId_node_Scale, assetPath);
					variableCount += JumpsId_node_Scale.SetData((FSJumps)Scale, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RootAnimId:
					FSRootAnimNode RootAnimId_node_Scale = graph.AddNode<FSRootAnimNode>();
					GetPort("Scale").Connect(RootAnimId_node_Scale.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RootAnimId_node_Scale, assetPath);
					variableCount += RootAnimId_node_Scale.SetData((FSRootAnim)Scale, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FloatId:
					FSValueNode FloatId_node_Scale = graph.AddNode<FSValueNode>();
					GetPort("Scale").Connect(FloatId_node_Scale.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FloatId_node_Scale, assetPath);
					variableCount += FloatId_node_Scale.SetData((FSValue)Scale, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
			}
			
			return variableCount;
		}
		
		public new SASpawnFX GetData()
		{
			SASpawnFX objToReturn = new SASpawnFX();
			objToReturn.TID = TypeId.SpawnFXId;
			objToReturn.Version = Version;
			objToReturn.Dynamic = Dynamic;
			objToReturn.Track = Track;
			objToReturn.BoneDir = BoneDir;
			objToReturn.Id = Id;
			objToReturn.Bone = Bone;
			objToReturn.LocalOffset = LocalOffset;
			objToReturn.GlobalOffset = GlobalOffset;
			if (GetPort("DirX").ConnectionCount > 0)
			{
				FloatSourceNode FloatSource_Node = (FloatSourceNode)GetPort("DirX").GetConnection(0).node;
				switch (FloatSource_Node.TID)
				{
					case FloatSource.TypeId.AgentId:
						FSAgentNode AgentId_FloatSource_Node = (FSAgentNode)GetPort("DirX").GetConnection(0).node;
						objToReturn.DirX = AgentId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.BonesId:
						FSBonesNode BonesId_FloatSource_Node = (FSBonesNode)GetPort("DirX").GetConnection(0).node;
						objToReturn.DirX = BonesId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AttackId:
						FSAttackNode AttackId_FloatSource_Node = (FSAttackNode)GetPort("DirX").GetConnection(0).node;
						objToReturn.DirX = AttackId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FrameId:
						FSFrameNode FrameId_FloatSource_Node = (FSFrameNode)GetPort("DirX").GetConnection(0).node;
						objToReturn.DirX = FrameId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.InputId:
						FSInputNode InputId_FloatSource_Node = (FSInputNode)GetPort("DirX").GetConnection(0).node;
						objToReturn.DirX = InputId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FuncId:
						FSFuncNode FuncId_FloatSource_Node = (FSFuncNode)GetPort("DirX").GetConnection(0).node;
						objToReturn.DirX = FuncId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.MovementId:
						FSMovementNode MovementId_FloatSource_Node = (FSMovementNode)GetPort("DirX").GetConnection(0).node;
						objToReturn.DirX = MovementId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CombatId:
						FSCombatNode CombatId_FloatSource_Node = (FSCombatNode)GetPort("DirX").GetConnection(0).node;
						objToReturn.DirX = CombatId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.GrabsId:
						FSGrabsNode GrabsId_FloatSource_Node = (FSGrabsNode)GetPort("DirX").GetConnection(0).node;
						objToReturn.DirX = GrabsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.DataId:
						FSDataNode DataId_FloatSource_Node = (FSDataNode)GetPort("DirX").GetConnection(0).node;
						objToReturn.DirX = DataId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ScratchId:
						FSScratchNode ScratchId_FloatSource_Node = (FSScratchNode)GetPort("DirX").GetConnection(0).node;
						objToReturn.DirX = ScratchId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AnimId:
						FSAnimNode AnimId_FloatSource_Node = (FSAnimNode)GetPort("DirX").GetConnection(0).node;
						objToReturn.DirX = AnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SpeedId:
						FSSpeedNode SpeedId_FloatSource_Node = (FSSpeedNode)GetPort("DirX").GetConnection(0).node;
						objToReturn.DirX = SpeedId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.PhysicsId:
						FSPhysicsNode PhysicsId_FloatSource_Node = (FSPhysicsNode)GetPort("DirX").GetConnection(0).node;
						objToReturn.DirX = PhysicsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CollisionId:
						FSCollisionNode CollisionId_FloatSource_Node = (FSCollisionNode)GetPort("DirX").GetConnection(0).node;
						objToReturn.DirX = CollisionId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.TimerId:
						FSTimerNode TimerId_FloatSource_Node = (FSTimerNode)GetPort("DirX").GetConnection(0).node;
						objToReturn.DirX = TimerId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.LagId:
						FSLagNode LagId_FloatSource_Node = (FSLagNode)GetPort("DirX").GetConnection(0).node;
						objToReturn.DirX = LagId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.EffectsId:
						FSEffectsNode EffectsId_FloatSource_Node = (FSEffectsNode)GetPort("DirX").GetConnection(0).node;
						objToReturn.DirX = EffectsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ColorsId:
						FSColorsNode ColorsId_FloatSource_Node = (FSColorsNode)GetPort("DirX").GetConnection(0).node;
						objToReturn.DirX = ColorsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.OnHitId:
						FSOnHitNode OnHitId_FloatSource_Node = (FSOnHitNode)GetPort("DirX").GetConnection(0).node;
						objToReturn.DirX = OnHitId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RandomId:
						FSRandomNode RandomId_FloatSource_Node = (FSRandomNode)GetPort("DirX").GetConnection(0).node;
						objToReturn.DirX = RandomId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CameraId:
						FSCameraInfoNode CameraId_FloatSource_Node = (FSCameraInfoNode)GetPort("DirX").GetConnection(0).node;
						objToReturn.DirX = CameraId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SportsId:
						FSSportsNode SportsId_FloatSource_Node = (FSSportsNode)GetPort("DirX").GetConnection(0).node;
						objToReturn.DirX = SportsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.Vector2Mag:
						FSVector2MagNode Vector2Mag_FloatSource_Node = (FSVector2MagNode)GetPort("DirX").GetConnection(0).node;
						objToReturn.DirX = Vector2Mag_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CPUHelpId:
						FSCpuHelpNode CPUHelpId_FloatSource_Node = (FSCpuHelpNode)GetPort("DirX").GetConnection(0).node;
						objToReturn.DirX = CPUHelpId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ItemId:
						FSItemNode ItemId_FloatSource_Node = (FSItemNode)GetPort("DirX").GetConnection(0).node;
						objToReturn.DirX = ItemId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ModeId:
						FSModeNode ModeId_FloatSource_Node = (FSModeNode)GetPort("DirX").GetConnection(0).node;
						objToReturn.DirX = ModeId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.JumpsId:
						FSJumpsNode JumpsId_FloatSource_Node = (FSJumpsNode)GetPort("DirX").GetConnection(0).node;
						objToReturn.DirX = JumpsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RootAnimId:
						FSRootAnimNode RootAnimId_FloatSource_Node = (FSRootAnimNode)GetPort("DirX").GetConnection(0).node;
						objToReturn.DirX = RootAnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FloatId:
						FSValueNode FloatId_FloatSource_Node = (FSValueNode)GetPort("DirX").GetConnection(0).node;
						objToReturn.DirX = FloatId_FloatSource_Node.GetData();
					break;
				}
			}
			if (GetPort("DirY").ConnectionCount > 0)
			{
				FloatSourceNode FloatSource_Node = (FloatSourceNode)GetPort("DirY").GetConnection(0).node;
				switch (FloatSource_Node.TID)
				{
					case FloatSource.TypeId.AgentId:
						FSAgentNode AgentId_FloatSource_Node = (FSAgentNode)GetPort("DirY").GetConnection(0).node;
						objToReturn.DirY = AgentId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.BonesId:
						FSBonesNode BonesId_FloatSource_Node = (FSBonesNode)GetPort("DirY").GetConnection(0).node;
						objToReturn.DirY = BonesId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AttackId:
						FSAttackNode AttackId_FloatSource_Node = (FSAttackNode)GetPort("DirY").GetConnection(0).node;
						objToReturn.DirY = AttackId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FrameId:
						FSFrameNode FrameId_FloatSource_Node = (FSFrameNode)GetPort("DirY").GetConnection(0).node;
						objToReturn.DirY = FrameId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.InputId:
						FSInputNode InputId_FloatSource_Node = (FSInputNode)GetPort("DirY").GetConnection(0).node;
						objToReturn.DirY = InputId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FuncId:
						FSFuncNode FuncId_FloatSource_Node = (FSFuncNode)GetPort("DirY").GetConnection(0).node;
						objToReturn.DirY = FuncId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.MovementId:
						FSMovementNode MovementId_FloatSource_Node = (FSMovementNode)GetPort("DirY").GetConnection(0).node;
						objToReturn.DirY = MovementId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CombatId:
						FSCombatNode CombatId_FloatSource_Node = (FSCombatNode)GetPort("DirY").GetConnection(0).node;
						objToReturn.DirY = CombatId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.GrabsId:
						FSGrabsNode GrabsId_FloatSource_Node = (FSGrabsNode)GetPort("DirY").GetConnection(0).node;
						objToReturn.DirY = GrabsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.DataId:
						FSDataNode DataId_FloatSource_Node = (FSDataNode)GetPort("DirY").GetConnection(0).node;
						objToReturn.DirY = DataId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ScratchId:
						FSScratchNode ScratchId_FloatSource_Node = (FSScratchNode)GetPort("DirY").GetConnection(0).node;
						objToReturn.DirY = ScratchId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AnimId:
						FSAnimNode AnimId_FloatSource_Node = (FSAnimNode)GetPort("DirY").GetConnection(0).node;
						objToReturn.DirY = AnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SpeedId:
						FSSpeedNode SpeedId_FloatSource_Node = (FSSpeedNode)GetPort("DirY").GetConnection(0).node;
						objToReturn.DirY = SpeedId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.PhysicsId:
						FSPhysicsNode PhysicsId_FloatSource_Node = (FSPhysicsNode)GetPort("DirY").GetConnection(0).node;
						objToReturn.DirY = PhysicsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CollisionId:
						FSCollisionNode CollisionId_FloatSource_Node = (FSCollisionNode)GetPort("DirY").GetConnection(0).node;
						objToReturn.DirY = CollisionId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.TimerId:
						FSTimerNode TimerId_FloatSource_Node = (FSTimerNode)GetPort("DirY").GetConnection(0).node;
						objToReturn.DirY = TimerId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.LagId:
						FSLagNode LagId_FloatSource_Node = (FSLagNode)GetPort("DirY").GetConnection(0).node;
						objToReturn.DirY = LagId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.EffectsId:
						FSEffectsNode EffectsId_FloatSource_Node = (FSEffectsNode)GetPort("DirY").GetConnection(0).node;
						objToReturn.DirY = EffectsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ColorsId:
						FSColorsNode ColorsId_FloatSource_Node = (FSColorsNode)GetPort("DirY").GetConnection(0).node;
						objToReturn.DirY = ColorsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.OnHitId:
						FSOnHitNode OnHitId_FloatSource_Node = (FSOnHitNode)GetPort("DirY").GetConnection(0).node;
						objToReturn.DirY = OnHitId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RandomId:
						FSRandomNode RandomId_FloatSource_Node = (FSRandomNode)GetPort("DirY").GetConnection(0).node;
						objToReturn.DirY = RandomId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CameraId:
						FSCameraInfoNode CameraId_FloatSource_Node = (FSCameraInfoNode)GetPort("DirY").GetConnection(0).node;
						objToReturn.DirY = CameraId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SportsId:
						FSSportsNode SportsId_FloatSource_Node = (FSSportsNode)GetPort("DirY").GetConnection(0).node;
						objToReturn.DirY = SportsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.Vector2Mag:
						FSVector2MagNode Vector2Mag_FloatSource_Node = (FSVector2MagNode)GetPort("DirY").GetConnection(0).node;
						objToReturn.DirY = Vector2Mag_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CPUHelpId:
						FSCpuHelpNode CPUHelpId_FloatSource_Node = (FSCpuHelpNode)GetPort("DirY").GetConnection(0).node;
						objToReturn.DirY = CPUHelpId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ItemId:
						FSItemNode ItemId_FloatSource_Node = (FSItemNode)GetPort("DirY").GetConnection(0).node;
						objToReturn.DirY = ItemId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ModeId:
						FSModeNode ModeId_FloatSource_Node = (FSModeNode)GetPort("DirY").GetConnection(0).node;
						objToReturn.DirY = ModeId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.JumpsId:
						FSJumpsNode JumpsId_FloatSource_Node = (FSJumpsNode)GetPort("DirY").GetConnection(0).node;
						objToReturn.DirY = JumpsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RootAnimId:
						FSRootAnimNode RootAnimId_FloatSource_Node = (FSRootAnimNode)GetPort("DirY").GetConnection(0).node;
						objToReturn.DirY = RootAnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FloatId:
						FSValueNode FloatId_FloatSource_Node = (FSValueNode)GetPort("DirY").GetConnection(0).node;
						objToReturn.DirY = FloatId_FloatSource_Node.GetData();
					break;
				}
			}
			if (GetPort("DirZ").ConnectionCount > 0)
			{
				FloatSourceNode FloatSource_Node = (FloatSourceNode)GetPort("DirZ").GetConnection(0).node;
				switch (FloatSource_Node.TID)
				{
					case FloatSource.TypeId.AgentId:
						FSAgentNode AgentId_FloatSource_Node = (FSAgentNode)GetPort("DirZ").GetConnection(0).node;
						objToReturn.DirZ = AgentId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.BonesId:
						FSBonesNode BonesId_FloatSource_Node = (FSBonesNode)GetPort("DirZ").GetConnection(0).node;
						objToReturn.DirZ = BonesId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AttackId:
						FSAttackNode AttackId_FloatSource_Node = (FSAttackNode)GetPort("DirZ").GetConnection(0).node;
						objToReturn.DirZ = AttackId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FrameId:
						FSFrameNode FrameId_FloatSource_Node = (FSFrameNode)GetPort("DirZ").GetConnection(0).node;
						objToReturn.DirZ = FrameId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.InputId:
						FSInputNode InputId_FloatSource_Node = (FSInputNode)GetPort("DirZ").GetConnection(0).node;
						objToReturn.DirZ = InputId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FuncId:
						FSFuncNode FuncId_FloatSource_Node = (FSFuncNode)GetPort("DirZ").GetConnection(0).node;
						objToReturn.DirZ = FuncId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.MovementId:
						FSMovementNode MovementId_FloatSource_Node = (FSMovementNode)GetPort("DirZ").GetConnection(0).node;
						objToReturn.DirZ = MovementId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CombatId:
						FSCombatNode CombatId_FloatSource_Node = (FSCombatNode)GetPort("DirZ").GetConnection(0).node;
						objToReturn.DirZ = CombatId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.GrabsId:
						FSGrabsNode GrabsId_FloatSource_Node = (FSGrabsNode)GetPort("DirZ").GetConnection(0).node;
						objToReturn.DirZ = GrabsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.DataId:
						FSDataNode DataId_FloatSource_Node = (FSDataNode)GetPort("DirZ").GetConnection(0).node;
						objToReturn.DirZ = DataId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ScratchId:
						FSScratchNode ScratchId_FloatSource_Node = (FSScratchNode)GetPort("DirZ").GetConnection(0).node;
						objToReturn.DirZ = ScratchId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AnimId:
						FSAnimNode AnimId_FloatSource_Node = (FSAnimNode)GetPort("DirZ").GetConnection(0).node;
						objToReturn.DirZ = AnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SpeedId:
						FSSpeedNode SpeedId_FloatSource_Node = (FSSpeedNode)GetPort("DirZ").GetConnection(0).node;
						objToReturn.DirZ = SpeedId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.PhysicsId:
						FSPhysicsNode PhysicsId_FloatSource_Node = (FSPhysicsNode)GetPort("DirZ").GetConnection(0).node;
						objToReturn.DirZ = PhysicsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CollisionId:
						FSCollisionNode CollisionId_FloatSource_Node = (FSCollisionNode)GetPort("DirZ").GetConnection(0).node;
						objToReturn.DirZ = CollisionId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.TimerId:
						FSTimerNode TimerId_FloatSource_Node = (FSTimerNode)GetPort("DirZ").GetConnection(0).node;
						objToReturn.DirZ = TimerId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.LagId:
						FSLagNode LagId_FloatSource_Node = (FSLagNode)GetPort("DirZ").GetConnection(0).node;
						objToReturn.DirZ = LagId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.EffectsId:
						FSEffectsNode EffectsId_FloatSource_Node = (FSEffectsNode)GetPort("DirZ").GetConnection(0).node;
						objToReturn.DirZ = EffectsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ColorsId:
						FSColorsNode ColorsId_FloatSource_Node = (FSColorsNode)GetPort("DirZ").GetConnection(0).node;
						objToReturn.DirZ = ColorsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.OnHitId:
						FSOnHitNode OnHitId_FloatSource_Node = (FSOnHitNode)GetPort("DirZ").GetConnection(0).node;
						objToReturn.DirZ = OnHitId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RandomId:
						FSRandomNode RandomId_FloatSource_Node = (FSRandomNode)GetPort("DirZ").GetConnection(0).node;
						objToReturn.DirZ = RandomId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CameraId:
						FSCameraInfoNode CameraId_FloatSource_Node = (FSCameraInfoNode)GetPort("DirZ").GetConnection(0).node;
						objToReturn.DirZ = CameraId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SportsId:
						FSSportsNode SportsId_FloatSource_Node = (FSSportsNode)GetPort("DirZ").GetConnection(0).node;
						objToReturn.DirZ = SportsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.Vector2Mag:
						FSVector2MagNode Vector2Mag_FloatSource_Node = (FSVector2MagNode)GetPort("DirZ").GetConnection(0).node;
						objToReturn.DirZ = Vector2Mag_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CPUHelpId:
						FSCpuHelpNode CPUHelpId_FloatSource_Node = (FSCpuHelpNode)GetPort("DirZ").GetConnection(0).node;
						objToReturn.DirZ = CPUHelpId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ItemId:
						FSItemNode ItemId_FloatSource_Node = (FSItemNode)GetPort("DirZ").GetConnection(0).node;
						objToReturn.DirZ = ItemId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ModeId:
						FSModeNode ModeId_FloatSource_Node = (FSModeNode)GetPort("DirZ").GetConnection(0).node;
						objToReturn.DirZ = ModeId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.JumpsId:
						FSJumpsNode JumpsId_FloatSource_Node = (FSJumpsNode)GetPort("DirZ").GetConnection(0).node;
						objToReturn.DirZ = JumpsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RootAnimId:
						FSRootAnimNode RootAnimId_FloatSource_Node = (FSRootAnimNode)GetPort("DirZ").GetConnection(0).node;
						objToReturn.DirZ = RootAnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FloatId:
						FSValueNode FloatId_FloatSource_Node = (FSValueNode)GetPort("DirZ").GetConnection(0).node;
						objToReturn.DirZ = FloatId_FloatSource_Node.GetData();
					break;
				}
			}
			if (GetPort("DynamicX").ConnectionCount > 0)
			{
				FloatSourceNode FloatSource_Node = (FloatSourceNode)GetPort("DynamicX").GetConnection(0).node;
				switch (FloatSource_Node.TID)
				{
					case FloatSource.TypeId.AgentId:
						FSAgentNode AgentId_FloatSource_Node = (FSAgentNode)GetPort("DynamicX").GetConnection(0).node;
						objToReturn.DynamicX = AgentId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.BonesId:
						FSBonesNode BonesId_FloatSource_Node = (FSBonesNode)GetPort("DynamicX").GetConnection(0).node;
						objToReturn.DynamicX = BonesId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AttackId:
						FSAttackNode AttackId_FloatSource_Node = (FSAttackNode)GetPort("DynamicX").GetConnection(0).node;
						objToReturn.DynamicX = AttackId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FrameId:
						FSFrameNode FrameId_FloatSource_Node = (FSFrameNode)GetPort("DynamicX").GetConnection(0).node;
						objToReturn.DynamicX = FrameId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.InputId:
						FSInputNode InputId_FloatSource_Node = (FSInputNode)GetPort("DynamicX").GetConnection(0).node;
						objToReturn.DynamicX = InputId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FuncId:
						FSFuncNode FuncId_FloatSource_Node = (FSFuncNode)GetPort("DynamicX").GetConnection(0).node;
						objToReturn.DynamicX = FuncId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.MovementId:
						FSMovementNode MovementId_FloatSource_Node = (FSMovementNode)GetPort("DynamicX").GetConnection(0).node;
						objToReturn.DynamicX = MovementId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CombatId:
						FSCombatNode CombatId_FloatSource_Node = (FSCombatNode)GetPort("DynamicX").GetConnection(0).node;
						objToReturn.DynamicX = CombatId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.GrabsId:
						FSGrabsNode GrabsId_FloatSource_Node = (FSGrabsNode)GetPort("DynamicX").GetConnection(0).node;
						objToReturn.DynamicX = GrabsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.DataId:
						FSDataNode DataId_FloatSource_Node = (FSDataNode)GetPort("DynamicX").GetConnection(0).node;
						objToReturn.DynamicX = DataId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ScratchId:
						FSScratchNode ScratchId_FloatSource_Node = (FSScratchNode)GetPort("DynamicX").GetConnection(0).node;
						objToReturn.DynamicX = ScratchId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AnimId:
						FSAnimNode AnimId_FloatSource_Node = (FSAnimNode)GetPort("DynamicX").GetConnection(0).node;
						objToReturn.DynamicX = AnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SpeedId:
						FSSpeedNode SpeedId_FloatSource_Node = (FSSpeedNode)GetPort("DynamicX").GetConnection(0).node;
						objToReturn.DynamicX = SpeedId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.PhysicsId:
						FSPhysicsNode PhysicsId_FloatSource_Node = (FSPhysicsNode)GetPort("DynamicX").GetConnection(0).node;
						objToReturn.DynamicX = PhysicsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CollisionId:
						FSCollisionNode CollisionId_FloatSource_Node = (FSCollisionNode)GetPort("DynamicX").GetConnection(0).node;
						objToReturn.DynamicX = CollisionId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.TimerId:
						FSTimerNode TimerId_FloatSource_Node = (FSTimerNode)GetPort("DynamicX").GetConnection(0).node;
						objToReturn.DynamicX = TimerId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.LagId:
						FSLagNode LagId_FloatSource_Node = (FSLagNode)GetPort("DynamicX").GetConnection(0).node;
						objToReturn.DynamicX = LagId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.EffectsId:
						FSEffectsNode EffectsId_FloatSource_Node = (FSEffectsNode)GetPort("DynamicX").GetConnection(0).node;
						objToReturn.DynamicX = EffectsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ColorsId:
						FSColorsNode ColorsId_FloatSource_Node = (FSColorsNode)GetPort("DynamicX").GetConnection(0).node;
						objToReturn.DynamicX = ColorsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.OnHitId:
						FSOnHitNode OnHitId_FloatSource_Node = (FSOnHitNode)GetPort("DynamicX").GetConnection(0).node;
						objToReturn.DynamicX = OnHitId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RandomId:
						FSRandomNode RandomId_FloatSource_Node = (FSRandomNode)GetPort("DynamicX").GetConnection(0).node;
						objToReturn.DynamicX = RandomId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CameraId:
						FSCameraInfoNode CameraId_FloatSource_Node = (FSCameraInfoNode)GetPort("DynamicX").GetConnection(0).node;
						objToReturn.DynamicX = CameraId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SportsId:
						FSSportsNode SportsId_FloatSource_Node = (FSSportsNode)GetPort("DynamicX").GetConnection(0).node;
						objToReturn.DynamicX = SportsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.Vector2Mag:
						FSVector2MagNode Vector2Mag_FloatSource_Node = (FSVector2MagNode)GetPort("DynamicX").GetConnection(0).node;
						objToReturn.DynamicX = Vector2Mag_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CPUHelpId:
						FSCpuHelpNode CPUHelpId_FloatSource_Node = (FSCpuHelpNode)GetPort("DynamicX").GetConnection(0).node;
						objToReturn.DynamicX = CPUHelpId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ItemId:
						FSItemNode ItemId_FloatSource_Node = (FSItemNode)GetPort("DynamicX").GetConnection(0).node;
						objToReturn.DynamicX = ItemId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ModeId:
						FSModeNode ModeId_FloatSource_Node = (FSModeNode)GetPort("DynamicX").GetConnection(0).node;
						objToReturn.DynamicX = ModeId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.JumpsId:
						FSJumpsNode JumpsId_FloatSource_Node = (FSJumpsNode)GetPort("DynamicX").GetConnection(0).node;
						objToReturn.DynamicX = JumpsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RootAnimId:
						FSRootAnimNode RootAnimId_FloatSource_Node = (FSRootAnimNode)GetPort("DynamicX").GetConnection(0).node;
						objToReturn.DynamicX = RootAnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FloatId:
						FSValueNode FloatId_FloatSource_Node = (FSValueNode)GetPort("DynamicX").GetConnection(0).node;
						objToReturn.DynamicX = FloatId_FloatSource_Node.GetData();
					break;
				}
			}
			if (GetPort("DynamicY").ConnectionCount > 0)
			{
				FloatSourceNode FloatSource_Node = (FloatSourceNode)GetPort("DynamicY").GetConnection(0).node;
				switch (FloatSource_Node.TID)
				{
					case FloatSource.TypeId.AgentId:
						FSAgentNode AgentId_FloatSource_Node = (FSAgentNode)GetPort("DynamicY").GetConnection(0).node;
						objToReturn.DynamicY = AgentId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.BonesId:
						FSBonesNode BonesId_FloatSource_Node = (FSBonesNode)GetPort("DynamicY").GetConnection(0).node;
						objToReturn.DynamicY = BonesId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AttackId:
						FSAttackNode AttackId_FloatSource_Node = (FSAttackNode)GetPort("DynamicY").GetConnection(0).node;
						objToReturn.DynamicY = AttackId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FrameId:
						FSFrameNode FrameId_FloatSource_Node = (FSFrameNode)GetPort("DynamicY").GetConnection(0).node;
						objToReturn.DynamicY = FrameId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.InputId:
						FSInputNode InputId_FloatSource_Node = (FSInputNode)GetPort("DynamicY").GetConnection(0).node;
						objToReturn.DynamicY = InputId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FuncId:
						FSFuncNode FuncId_FloatSource_Node = (FSFuncNode)GetPort("DynamicY").GetConnection(0).node;
						objToReturn.DynamicY = FuncId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.MovementId:
						FSMovementNode MovementId_FloatSource_Node = (FSMovementNode)GetPort("DynamicY").GetConnection(0).node;
						objToReturn.DynamicY = MovementId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CombatId:
						FSCombatNode CombatId_FloatSource_Node = (FSCombatNode)GetPort("DynamicY").GetConnection(0).node;
						objToReturn.DynamicY = CombatId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.GrabsId:
						FSGrabsNode GrabsId_FloatSource_Node = (FSGrabsNode)GetPort("DynamicY").GetConnection(0).node;
						objToReturn.DynamicY = GrabsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.DataId:
						FSDataNode DataId_FloatSource_Node = (FSDataNode)GetPort("DynamicY").GetConnection(0).node;
						objToReturn.DynamicY = DataId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ScratchId:
						FSScratchNode ScratchId_FloatSource_Node = (FSScratchNode)GetPort("DynamicY").GetConnection(0).node;
						objToReturn.DynamicY = ScratchId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AnimId:
						FSAnimNode AnimId_FloatSource_Node = (FSAnimNode)GetPort("DynamicY").GetConnection(0).node;
						objToReturn.DynamicY = AnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SpeedId:
						FSSpeedNode SpeedId_FloatSource_Node = (FSSpeedNode)GetPort("DynamicY").GetConnection(0).node;
						objToReturn.DynamicY = SpeedId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.PhysicsId:
						FSPhysicsNode PhysicsId_FloatSource_Node = (FSPhysicsNode)GetPort("DynamicY").GetConnection(0).node;
						objToReturn.DynamicY = PhysicsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CollisionId:
						FSCollisionNode CollisionId_FloatSource_Node = (FSCollisionNode)GetPort("DynamicY").GetConnection(0).node;
						objToReturn.DynamicY = CollisionId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.TimerId:
						FSTimerNode TimerId_FloatSource_Node = (FSTimerNode)GetPort("DynamicY").GetConnection(0).node;
						objToReturn.DynamicY = TimerId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.LagId:
						FSLagNode LagId_FloatSource_Node = (FSLagNode)GetPort("DynamicY").GetConnection(0).node;
						objToReturn.DynamicY = LagId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.EffectsId:
						FSEffectsNode EffectsId_FloatSource_Node = (FSEffectsNode)GetPort("DynamicY").GetConnection(0).node;
						objToReturn.DynamicY = EffectsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ColorsId:
						FSColorsNode ColorsId_FloatSource_Node = (FSColorsNode)GetPort("DynamicY").GetConnection(0).node;
						objToReturn.DynamicY = ColorsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.OnHitId:
						FSOnHitNode OnHitId_FloatSource_Node = (FSOnHitNode)GetPort("DynamicY").GetConnection(0).node;
						objToReturn.DynamicY = OnHitId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RandomId:
						FSRandomNode RandomId_FloatSource_Node = (FSRandomNode)GetPort("DynamicY").GetConnection(0).node;
						objToReturn.DynamicY = RandomId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CameraId:
						FSCameraInfoNode CameraId_FloatSource_Node = (FSCameraInfoNode)GetPort("DynamicY").GetConnection(0).node;
						objToReturn.DynamicY = CameraId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SportsId:
						FSSportsNode SportsId_FloatSource_Node = (FSSportsNode)GetPort("DynamicY").GetConnection(0).node;
						objToReturn.DynamicY = SportsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.Vector2Mag:
						FSVector2MagNode Vector2Mag_FloatSource_Node = (FSVector2MagNode)GetPort("DynamicY").GetConnection(0).node;
						objToReturn.DynamicY = Vector2Mag_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CPUHelpId:
						FSCpuHelpNode CPUHelpId_FloatSource_Node = (FSCpuHelpNode)GetPort("DynamicY").GetConnection(0).node;
						objToReturn.DynamicY = CPUHelpId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ItemId:
						FSItemNode ItemId_FloatSource_Node = (FSItemNode)GetPort("DynamicY").GetConnection(0).node;
						objToReturn.DynamicY = ItemId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ModeId:
						FSModeNode ModeId_FloatSource_Node = (FSModeNode)GetPort("DynamicY").GetConnection(0).node;
						objToReturn.DynamicY = ModeId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.JumpsId:
						FSJumpsNode JumpsId_FloatSource_Node = (FSJumpsNode)GetPort("DynamicY").GetConnection(0).node;
						objToReturn.DynamicY = JumpsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RootAnimId:
						FSRootAnimNode RootAnimId_FloatSource_Node = (FSRootAnimNode)GetPort("DynamicY").GetConnection(0).node;
						objToReturn.DynamicY = RootAnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FloatId:
						FSValueNode FloatId_FloatSource_Node = (FSValueNode)GetPort("DynamicY").GetConnection(0).node;
						objToReturn.DynamicY = FloatId_FloatSource_Node.GetData();
					break;
				}
			}
			if (GetPort("DynamicZ").ConnectionCount > 0)
			{
				FloatSourceNode FloatSource_Node = (FloatSourceNode)GetPort("DynamicZ").GetConnection(0).node;
				switch (FloatSource_Node.TID)
				{
					case FloatSource.TypeId.AgentId:
						FSAgentNode AgentId_FloatSource_Node = (FSAgentNode)GetPort("DynamicZ").GetConnection(0).node;
						objToReturn.DynamicZ = AgentId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.BonesId:
						FSBonesNode BonesId_FloatSource_Node = (FSBonesNode)GetPort("DynamicZ").GetConnection(0).node;
						objToReturn.DynamicZ = BonesId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AttackId:
						FSAttackNode AttackId_FloatSource_Node = (FSAttackNode)GetPort("DynamicZ").GetConnection(0).node;
						objToReturn.DynamicZ = AttackId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FrameId:
						FSFrameNode FrameId_FloatSource_Node = (FSFrameNode)GetPort("DynamicZ").GetConnection(0).node;
						objToReturn.DynamicZ = FrameId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.InputId:
						FSInputNode InputId_FloatSource_Node = (FSInputNode)GetPort("DynamicZ").GetConnection(0).node;
						objToReturn.DynamicZ = InputId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FuncId:
						FSFuncNode FuncId_FloatSource_Node = (FSFuncNode)GetPort("DynamicZ").GetConnection(0).node;
						objToReturn.DynamicZ = FuncId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.MovementId:
						FSMovementNode MovementId_FloatSource_Node = (FSMovementNode)GetPort("DynamicZ").GetConnection(0).node;
						objToReturn.DynamicZ = MovementId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CombatId:
						FSCombatNode CombatId_FloatSource_Node = (FSCombatNode)GetPort("DynamicZ").GetConnection(0).node;
						objToReturn.DynamicZ = CombatId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.GrabsId:
						FSGrabsNode GrabsId_FloatSource_Node = (FSGrabsNode)GetPort("DynamicZ").GetConnection(0).node;
						objToReturn.DynamicZ = GrabsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.DataId:
						FSDataNode DataId_FloatSource_Node = (FSDataNode)GetPort("DynamicZ").GetConnection(0).node;
						objToReturn.DynamicZ = DataId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ScratchId:
						FSScratchNode ScratchId_FloatSource_Node = (FSScratchNode)GetPort("DynamicZ").GetConnection(0).node;
						objToReturn.DynamicZ = ScratchId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AnimId:
						FSAnimNode AnimId_FloatSource_Node = (FSAnimNode)GetPort("DynamicZ").GetConnection(0).node;
						objToReturn.DynamicZ = AnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SpeedId:
						FSSpeedNode SpeedId_FloatSource_Node = (FSSpeedNode)GetPort("DynamicZ").GetConnection(0).node;
						objToReturn.DynamicZ = SpeedId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.PhysicsId:
						FSPhysicsNode PhysicsId_FloatSource_Node = (FSPhysicsNode)GetPort("DynamicZ").GetConnection(0).node;
						objToReturn.DynamicZ = PhysicsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CollisionId:
						FSCollisionNode CollisionId_FloatSource_Node = (FSCollisionNode)GetPort("DynamicZ").GetConnection(0).node;
						objToReturn.DynamicZ = CollisionId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.TimerId:
						FSTimerNode TimerId_FloatSource_Node = (FSTimerNode)GetPort("DynamicZ").GetConnection(0).node;
						objToReturn.DynamicZ = TimerId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.LagId:
						FSLagNode LagId_FloatSource_Node = (FSLagNode)GetPort("DynamicZ").GetConnection(0).node;
						objToReturn.DynamicZ = LagId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.EffectsId:
						FSEffectsNode EffectsId_FloatSource_Node = (FSEffectsNode)GetPort("DynamicZ").GetConnection(0).node;
						objToReturn.DynamicZ = EffectsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ColorsId:
						FSColorsNode ColorsId_FloatSource_Node = (FSColorsNode)GetPort("DynamicZ").GetConnection(0).node;
						objToReturn.DynamicZ = ColorsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.OnHitId:
						FSOnHitNode OnHitId_FloatSource_Node = (FSOnHitNode)GetPort("DynamicZ").GetConnection(0).node;
						objToReturn.DynamicZ = OnHitId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RandomId:
						FSRandomNode RandomId_FloatSource_Node = (FSRandomNode)GetPort("DynamicZ").GetConnection(0).node;
						objToReturn.DynamicZ = RandomId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CameraId:
						FSCameraInfoNode CameraId_FloatSource_Node = (FSCameraInfoNode)GetPort("DynamicZ").GetConnection(0).node;
						objToReturn.DynamicZ = CameraId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SportsId:
						FSSportsNode SportsId_FloatSource_Node = (FSSportsNode)GetPort("DynamicZ").GetConnection(0).node;
						objToReturn.DynamicZ = SportsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.Vector2Mag:
						FSVector2MagNode Vector2Mag_FloatSource_Node = (FSVector2MagNode)GetPort("DynamicZ").GetConnection(0).node;
						objToReturn.DynamicZ = Vector2Mag_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CPUHelpId:
						FSCpuHelpNode CPUHelpId_FloatSource_Node = (FSCpuHelpNode)GetPort("DynamicZ").GetConnection(0).node;
						objToReturn.DynamicZ = CPUHelpId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ItemId:
						FSItemNode ItemId_FloatSource_Node = (FSItemNode)GetPort("DynamicZ").GetConnection(0).node;
						objToReturn.DynamicZ = ItemId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ModeId:
						FSModeNode ModeId_FloatSource_Node = (FSModeNode)GetPort("DynamicZ").GetConnection(0).node;
						objToReturn.DynamicZ = ModeId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.JumpsId:
						FSJumpsNode JumpsId_FloatSource_Node = (FSJumpsNode)GetPort("DynamicZ").GetConnection(0).node;
						objToReturn.DynamicZ = JumpsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RootAnimId:
						FSRootAnimNode RootAnimId_FloatSource_Node = (FSRootAnimNode)GetPort("DynamicZ").GetConnection(0).node;
						objToReturn.DynamicZ = RootAnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FloatId:
						FSValueNode FloatId_FloatSource_Node = (FSValueNode)GetPort("DynamicZ").GetConnection(0).node;
						objToReturn.DynamicZ = FloatId_FloatSource_Node.GetData();
					break;
				}
			}
			if (GetPort("Scale").ConnectionCount > 0)
			{
				FloatSourceNode FloatSource_Node = (FloatSourceNode)GetPort("Scale").GetConnection(0).node;
				switch (FloatSource_Node.TID)
				{
					case FloatSource.TypeId.AgentId:
						FSAgentNode AgentId_FloatSource_Node = (FSAgentNode)GetPort("Scale").GetConnection(0).node;
						objToReturn.Scale = AgentId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.BonesId:
						FSBonesNode BonesId_FloatSource_Node = (FSBonesNode)GetPort("Scale").GetConnection(0).node;
						objToReturn.Scale = BonesId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AttackId:
						FSAttackNode AttackId_FloatSource_Node = (FSAttackNode)GetPort("Scale").GetConnection(0).node;
						objToReturn.Scale = AttackId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FrameId:
						FSFrameNode FrameId_FloatSource_Node = (FSFrameNode)GetPort("Scale").GetConnection(0).node;
						objToReturn.Scale = FrameId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.InputId:
						FSInputNode InputId_FloatSource_Node = (FSInputNode)GetPort("Scale").GetConnection(0).node;
						objToReturn.Scale = InputId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FuncId:
						FSFuncNode FuncId_FloatSource_Node = (FSFuncNode)GetPort("Scale").GetConnection(0).node;
						objToReturn.Scale = FuncId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.MovementId:
						FSMovementNode MovementId_FloatSource_Node = (FSMovementNode)GetPort("Scale").GetConnection(0).node;
						objToReturn.Scale = MovementId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CombatId:
						FSCombatNode CombatId_FloatSource_Node = (FSCombatNode)GetPort("Scale").GetConnection(0).node;
						objToReturn.Scale = CombatId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.GrabsId:
						FSGrabsNode GrabsId_FloatSource_Node = (FSGrabsNode)GetPort("Scale").GetConnection(0).node;
						objToReturn.Scale = GrabsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.DataId:
						FSDataNode DataId_FloatSource_Node = (FSDataNode)GetPort("Scale").GetConnection(0).node;
						objToReturn.Scale = DataId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ScratchId:
						FSScratchNode ScratchId_FloatSource_Node = (FSScratchNode)GetPort("Scale").GetConnection(0).node;
						objToReturn.Scale = ScratchId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AnimId:
						FSAnimNode AnimId_FloatSource_Node = (FSAnimNode)GetPort("Scale").GetConnection(0).node;
						objToReturn.Scale = AnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SpeedId:
						FSSpeedNode SpeedId_FloatSource_Node = (FSSpeedNode)GetPort("Scale").GetConnection(0).node;
						objToReturn.Scale = SpeedId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.PhysicsId:
						FSPhysicsNode PhysicsId_FloatSource_Node = (FSPhysicsNode)GetPort("Scale").GetConnection(0).node;
						objToReturn.Scale = PhysicsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CollisionId:
						FSCollisionNode CollisionId_FloatSource_Node = (FSCollisionNode)GetPort("Scale").GetConnection(0).node;
						objToReturn.Scale = CollisionId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.TimerId:
						FSTimerNode TimerId_FloatSource_Node = (FSTimerNode)GetPort("Scale").GetConnection(0).node;
						objToReturn.Scale = TimerId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.LagId:
						FSLagNode LagId_FloatSource_Node = (FSLagNode)GetPort("Scale").GetConnection(0).node;
						objToReturn.Scale = LagId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.EffectsId:
						FSEffectsNode EffectsId_FloatSource_Node = (FSEffectsNode)GetPort("Scale").GetConnection(0).node;
						objToReturn.Scale = EffectsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ColorsId:
						FSColorsNode ColorsId_FloatSource_Node = (FSColorsNode)GetPort("Scale").GetConnection(0).node;
						objToReturn.Scale = ColorsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.OnHitId:
						FSOnHitNode OnHitId_FloatSource_Node = (FSOnHitNode)GetPort("Scale").GetConnection(0).node;
						objToReturn.Scale = OnHitId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RandomId:
						FSRandomNode RandomId_FloatSource_Node = (FSRandomNode)GetPort("Scale").GetConnection(0).node;
						objToReturn.Scale = RandomId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CameraId:
						FSCameraInfoNode CameraId_FloatSource_Node = (FSCameraInfoNode)GetPort("Scale").GetConnection(0).node;
						objToReturn.Scale = CameraId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SportsId:
						FSSportsNode SportsId_FloatSource_Node = (FSSportsNode)GetPort("Scale").GetConnection(0).node;
						objToReturn.Scale = SportsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.Vector2Mag:
						FSVector2MagNode Vector2Mag_FloatSource_Node = (FSVector2MagNode)GetPort("Scale").GetConnection(0).node;
						objToReturn.Scale = Vector2Mag_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CPUHelpId:
						FSCpuHelpNode CPUHelpId_FloatSource_Node = (FSCpuHelpNode)GetPort("Scale").GetConnection(0).node;
						objToReturn.Scale = CPUHelpId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ItemId:
						FSItemNode ItemId_FloatSource_Node = (FSItemNode)GetPort("Scale").GetConnection(0).node;
						objToReturn.Scale = ItemId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ModeId:
						FSModeNode ModeId_FloatSource_Node = (FSModeNode)GetPort("Scale").GetConnection(0).node;
						objToReturn.Scale = ModeId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.JumpsId:
						FSJumpsNode JumpsId_FloatSource_Node = (FSJumpsNode)GetPort("Scale").GetConnection(0).node;
						objToReturn.Scale = JumpsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RootAnimId:
						FSRootAnimNode RootAnimId_FloatSource_Node = (FSRootAnimNode)GetPort("Scale").GetConnection(0).node;
						objToReturn.Scale = RootAnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FloatId:
						FSValueNode FloatId_FloatSource_Node = (FSValueNode)GetPort("Scale").GetConnection(0).node;
						objToReturn.Scale = FloatId_FloatSource_Node.GetData();
					break;
				}
			}
			return objToReturn;
		}
	}
}

