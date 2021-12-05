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
	public class SASpawnAgent2Node : StateActionNode
	{
		public string Bank;
		public string Id;
		public string Bone;
		public NASB_Parser.Vector3 LocalOffset;
		public NASB_Parser.Vector3 WorldOffset;
		public bool CustomSpawnMovement;
		[Output(connectionType = ConnectionType.Multiple)] public List<SpawnMovement> Movements;
		public string SpawnedAgentDataId;
		[Output(connectionType = ConnectionType.Override)] public FloatSource SpawnedAgentDataSetValue;
		[Output(connectionType = ConnectionType.Override)] public FloatSource ResultOrderAdded;
		public bool SetPlayerIndex;
		public bool SetAttackTeam;
		public bool SetDefendTeam;
		public bool SetProjectileLevel;
		public bool SetDirection;
		public bool SetRedirect;
		[Output(connectionType = ConnectionType.Override)] public FloatSource PlayerIndex;
		[Output(connectionType = ConnectionType.Override)] public FloatSource AttackTeam;
		[Output(connectionType = ConnectionType.Override)] public FloatSource DefendTeam;
		[Output(connectionType = ConnectionType.Override)] public FloatSource ProjectileLevel;
		[Output(connectionType = ConnectionType.Override)] public FloatSource Direction;
		[Output(connectionType = ConnectionType.Override)] public FloatSource RedirectX;
		[Output(connectionType = ConnectionType.Override)] public FloatSource RedirectY;
		public bool ExactSpawn;
		[Output(connectionType = ConnectionType.Multiple)] public List<SASpawnAgent2.AddedSpawnData> AddedSpawns;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.SpawnAgent2Id;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SASpawnAgent2 data, MovesetGraph graph, string assetPath, Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SASpawnAgent2));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			Bank = data.Bank;
			Id = data.Id;
			Bone = data.Bone;
			LocalOffset = data.LocalOffset;
			WorldOffset = data.WorldOffset;
			CustomSpawnMovement = data.CustomSpawnMovement;
			Movements = data.Movements;
			
			foreach (SpawnMovement Movements_item in data.Movements)
			{
				SpawnMovementNode node_Movements = graph.AddNode<SpawnMovementNode>();
				GetPort("Movements").Connect(node_Movements.GetPort("NodeInput"));
				AssetDatabase.AddObjectToAsset(node_Movements, assetPath);
				variableCount += node_Movements.SetData(Movements_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				++variableCount;
			}
			
			SpawnedAgentDataId = data.SpawnedAgentDataId;
			SpawnedAgentDataSetValue = data.SpawnedAgentDataSetValue;
			
			switch (SpawnedAgentDataSetValue.TID)
			{
				case FloatSource.TypeId.AgentId:
					FSAgentNode AgentId_node_SpawnedAgentDataSetValue = graph.AddNode<FSAgentNode>();
					GetPort("SpawnedAgentDataSetValue").Connect(AgentId_node_SpawnedAgentDataSetValue.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AgentId_node_SpawnedAgentDataSetValue, assetPath);
					variableCount += AgentId_node_SpawnedAgentDataSetValue.SetData((FSAgent)SpawnedAgentDataSetValue, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.BonesId:
					FSBonesNode BonesId_node_SpawnedAgentDataSetValue = graph.AddNode<FSBonesNode>();
					GetPort("SpawnedAgentDataSetValue").Connect(BonesId_node_SpawnedAgentDataSetValue.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BonesId_node_SpawnedAgentDataSetValue, assetPath);
					variableCount += BonesId_node_SpawnedAgentDataSetValue.SetData((FSBones)SpawnedAgentDataSetValue, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AttackId:
					FSAttackNode AttackId_node_SpawnedAgentDataSetValue = graph.AddNode<FSAttackNode>();
					GetPort("SpawnedAgentDataSetValue").Connect(AttackId_node_SpawnedAgentDataSetValue.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AttackId_node_SpawnedAgentDataSetValue, assetPath);
					variableCount += AttackId_node_SpawnedAgentDataSetValue.SetData((FSAttack)SpawnedAgentDataSetValue, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FrameId:
					FSFrameNode FrameId_node_SpawnedAgentDataSetValue = graph.AddNode<FSFrameNode>();
					GetPort("SpawnedAgentDataSetValue").Connect(FrameId_node_SpawnedAgentDataSetValue.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FrameId_node_SpawnedAgentDataSetValue, assetPath);
					variableCount += FrameId_node_SpawnedAgentDataSetValue.SetData((FSFrame)SpawnedAgentDataSetValue, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.InputId:
					FSInputNode InputId_node_SpawnedAgentDataSetValue = graph.AddNode<FSInputNode>();
					GetPort("SpawnedAgentDataSetValue").Connect(InputId_node_SpawnedAgentDataSetValue.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputId_node_SpawnedAgentDataSetValue, assetPath);
					variableCount += InputId_node_SpawnedAgentDataSetValue.SetData((FSInput)SpawnedAgentDataSetValue, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FuncId:
					FSFuncNode FuncId_node_SpawnedAgentDataSetValue = graph.AddNode<FSFuncNode>();
					GetPort("SpawnedAgentDataSetValue").Connect(FuncId_node_SpawnedAgentDataSetValue.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FuncId_node_SpawnedAgentDataSetValue, assetPath);
					variableCount += FuncId_node_SpawnedAgentDataSetValue.SetData((FSFunc)SpawnedAgentDataSetValue, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.MovementId:
					FSMovementNode MovementId_node_SpawnedAgentDataSetValue = graph.AddNode<FSMovementNode>();
					GetPort("SpawnedAgentDataSetValue").Connect(MovementId_node_SpawnedAgentDataSetValue.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(MovementId_node_SpawnedAgentDataSetValue, assetPath);
					variableCount += MovementId_node_SpawnedAgentDataSetValue.SetData((FSMovement)SpawnedAgentDataSetValue, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CombatId:
					FSCombatNode CombatId_node_SpawnedAgentDataSetValue = graph.AddNode<FSCombatNode>();
					GetPort("SpawnedAgentDataSetValue").Connect(CombatId_node_SpawnedAgentDataSetValue.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CombatId_node_SpawnedAgentDataSetValue, assetPath);
					variableCount += CombatId_node_SpawnedAgentDataSetValue.SetData((FSCombat)SpawnedAgentDataSetValue, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.GrabsId:
					FSGrabsNode GrabsId_node_SpawnedAgentDataSetValue = graph.AddNode<FSGrabsNode>();
					GetPort("SpawnedAgentDataSetValue").Connect(GrabsId_node_SpawnedAgentDataSetValue.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(GrabsId_node_SpawnedAgentDataSetValue, assetPath);
					variableCount += GrabsId_node_SpawnedAgentDataSetValue.SetData((FSGrabs)SpawnedAgentDataSetValue, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.DataId:
					FSDataNode DataId_node_SpawnedAgentDataSetValue = graph.AddNode<FSDataNode>();
					GetPort("SpawnedAgentDataSetValue").Connect(DataId_node_SpawnedAgentDataSetValue.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DataId_node_SpawnedAgentDataSetValue, assetPath);
					variableCount += DataId_node_SpawnedAgentDataSetValue.SetData((FSData)SpawnedAgentDataSetValue, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ScratchId:
					FSScratchNode ScratchId_node_SpawnedAgentDataSetValue = graph.AddNode<FSScratchNode>();
					GetPort("SpawnedAgentDataSetValue").Connect(ScratchId_node_SpawnedAgentDataSetValue.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ScratchId_node_SpawnedAgentDataSetValue, assetPath);
					variableCount += ScratchId_node_SpawnedAgentDataSetValue.SetData((FSScratch)SpawnedAgentDataSetValue, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AnimId:
					FSAnimNode AnimId_node_SpawnedAgentDataSetValue = graph.AddNode<FSAnimNode>();
					GetPort("SpawnedAgentDataSetValue").Connect(AnimId_node_SpawnedAgentDataSetValue.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AnimId_node_SpawnedAgentDataSetValue, assetPath);
					variableCount += AnimId_node_SpawnedAgentDataSetValue.SetData((FSAnim)SpawnedAgentDataSetValue, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SpeedId:
					FSSpeedNode SpeedId_node_SpawnedAgentDataSetValue = graph.AddNode<FSSpeedNode>();
					GetPort("SpawnedAgentDataSetValue").Connect(SpeedId_node_SpawnedAgentDataSetValue.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpeedId_node_SpawnedAgentDataSetValue, assetPath);
					variableCount += SpeedId_node_SpawnedAgentDataSetValue.SetData((FSSpeed)SpawnedAgentDataSetValue, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.PhysicsId:
					FSPhysicsNode PhysicsId_node_SpawnedAgentDataSetValue = graph.AddNode<FSPhysicsNode>();
					GetPort("SpawnedAgentDataSetValue").Connect(PhysicsId_node_SpawnedAgentDataSetValue.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(PhysicsId_node_SpawnedAgentDataSetValue, assetPath);
					variableCount += PhysicsId_node_SpawnedAgentDataSetValue.SetData((FSPhysics)SpawnedAgentDataSetValue, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CollisionId:
					FSCollisionNode CollisionId_node_SpawnedAgentDataSetValue = graph.AddNode<FSCollisionNode>();
					GetPort("SpawnedAgentDataSetValue").Connect(CollisionId_node_SpawnedAgentDataSetValue.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CollisionId_node_SpawnedAgentDataSetValue, assetPath);
					variableCount += CollisionId_node_SpawnedAgentDataSetValue.SetData((FSCollision)SpawnedAgentDataSetValue, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.TimerId:
					FSTimerNode TimerId_node_SpawnedAgentDataSetValue = graph.AddNode<FSTimerNode>();
					GetPort("SpawnedAgentDataSetValue").Connect(TimerId_node_SpawnedAgentDataSetValue.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(TimerId_node_SpawnedAgentDataSetValue, assetPath);
					variableCount += TimerId_node_SpawnedAgentDataSetValue.SetData((FSTimer)SpawnedAgentDataSetValue, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.LagId:
					FSLagNode LagId_node_SpawnedAgentDataSetValue = graph.AddNode<FSLagNode>();
					GetPort("SpawnedAgentDataSetValue").Connect(LagId_node_SpawnedAgentDataSetValue.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LagId_node_SpawnedAgentDataSetValue, assetPath);
					variableCount += LagId_node_SpawnedAgentDataSetValue.SetData((FSLag)SpawnedAgentDataSetValue, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.EffectsId:
					FSEffectsNode EffectsId_node_SpawnedAgentDataSetValue = graph.AddNode<FSEffectsNode>();
					GetPort("SpawnedAgentDataSetValue").Connect(EffectsId_node_SpawnedAgentDataSetValue.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EffectsId_node_SpawnedAgentDataSetValue, assetPath);
					variableCount += EffectsId_node_SpawnedAgentDataSetValue.SetData((FSEffects)SpawnedAgentDataSetValue, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ColorsId:
					FSColorsNode ColorsId_node_SpawnedAgentDataSetValue = graph.AddNode<FSColorsNode>();
					GetPort("SpawnedAgentDataSetValue").Connect(ColorsId_node_SpawnedAgentDataSetValue.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ColorsId_node_SpawnedAgentDataSetValue, assetPath);
					variableCount += ColorsId_node_SpawnedAgentDataSetValue.SetData((FSColors)SpawnedAgentDataSetValue, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.OnHitId:
					FSOnHitNode OnHitId_node_SpawnedAgentDataSetValue = graph.AddNode<FSOnHitNode>();
					GetPort("SpawnedAgentDataSetValue").Connect(OnHitId_node_SpawnedAgentDataSetValue.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnHitId_node_SpawnedAgentDataSetValue, assetPath);
					variableCount += OnHitId_node_SpawnedAgentDataSetValue.SetData((FSOnHit)SpawnedAgentDataSetValue, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RandomId:
					FSRandomNode RandomId_node_SpawnedAgentDataSetValue = graph.AddNode<FSRandomNode>();
					GetPort("SpawnedAgentDataSetValue").Connect(RandomId_node_SpawnedAgentDataSetValue.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RandomId_node_SpawnedAgentDataSetValue, assetPath);
					variableCount += RandomId_node_SpawnedAgentDataSetValue.SetData((FSRandom)SpawnedAgentDataSetValue, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CameraId:
					FSCameraInfoNode CameraId_node_SpawnedAgentDataSetValue = graph.AddNode<FSCameraInfoNode>();
					GetPort("SpawnedAgentDataSetValue").Connect(CameraId_node_SpawnedAgentDataSetValue.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CameraId_node_SpawnedAgentDataSetValue, assetPath);
					variableCount += CameraId_node_SpawnedAgentDataSetValue.SetData((FSCameraInfo)SpawnedAgentDataSetValue, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SportsId:
					FSSportsNode SportsId_node_SpawnedAgentDataSetValue = graph.AddNode<FSSportsNode>();
					GetPort("SpawnedAgentDataSetValue").Connect(SportsId_node_SpawnedAgentDataSetValue.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SportsId_node_SpawnedAgentDataSetValue, assetPath);
					variableCount += SportsId_node_SpawnedAgentDataSetValue.SetData((FSSports)SpawnedAgentDataSetValue, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.Vector2Mag:
					FSVector2MagNode Vector2Mag_node_SpawnedAgentDataSetValue = graph.AddNode<FSVector2MagNode>();
					GetPort("SpawnedAgentDataSetValue").Connect(Vector2Mag_node_SpawnedAgentDataSetValue.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(Vector2Mag_node_SpawnedAgentDataSetValue, assetPath);
					variableCount += Vector2Mag_node_SpawnedAgentDataSetValue.SetData((FSVector2Mag)SpawnedAgentDataSetValue, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CPUHelpId:
					FSCpuHelpNode CPUHelpId_node_SpawnedAgentDataSetValue = graph.AddNode<FSCpuHelpNode>();
					GetPort("SpawnedAgentDataSetValue").Connect(CPUHelpId_node_SpawnedAgentDataSetValue.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CPUHelpId_node_SpawnedAgentDataSetValue, assetPath);
					variableCount += CPUHelpId_node_SpawnedAgentDataSetValue.SetData((FSCpuHelp)SpawnedAgentDataSetValue, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ItemId:
					FSItemNode ItemId_node_SpawnedAgentDataSetValue = graph.AddNode<FSItemNode>();
					GetPort("SpawnedAgentDataSetValue").Connect(ItemId_node_SpawnedAgentDataSetValue.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ItemId_node_SpawnedAgentDataSetValue, assetPath);
					variableCount += ItemId_node_SpawnedAgentDataSetValue.SetData((FSItem)SpawnedAgentDataSetValue, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ModeId:
					FSModeNode ModeId_node_SpawnedAgentDataSetValue = graph.AddNode<FSModeNode>();
					GetPort("SpawnedAgentDataSetValue").Connect(ModeId_node_SpawnedAgentDataSetValue.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ModeId_node_SpawnedAgentDataSetValue, assetPath);
					variableCount += ModeId_node_SpawnedAgentDataSetValue.SetData((FSMode)SpawnedAgentDataSetValue, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.JumpsId:
					FSJumpsNode JumpsId_node_SpawnedAgentDataSetValue = graph.AddNode<FSJumpsNode>();
					GetPort("SpawnedAgentDataSetValue").Connect(JumpsId_node_SpawnedAgentDataSetValue.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(JumpsId_node_SpawnedAgentDataSetValue, assetPath);
					variableCount += JumpsId_node_SpawnedAgentDataSetValue.SetData((FSJumps)SpawnedAgentDataSetValue, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RootAnimId:
					FSRootAnimNode RootAnimId_node_SpawnedAgentDataSetValue = graph.AddNode<FSRootAnimNode>();
					GetPort("SpawnedAgentDataSetValue").Connect(RootAnimId_node_SpawnedAgentDataSetValue.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RootAnimId_node_SpawnedAgentDataSetValue, assetPath);
					variableCount += RootAnimId_node_SpawnedAgentDataSetValue.SetData((FSRootAnim)SpawnedAgentDataSetValue, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FloatId:
					FSValueNode FloatId_node_SpawnedAgentDataSetValue = graph.AddNode<FSValueNode>();
					GetPort("SpawnedAgentDataSetValue").Connect(FloatId_node_SpawnedAgentDataSetValue.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FloatId_node_SpawnedAgentDataSetValue, assetPath);
					variableCount += FloatId_node_SpawnedAgentDataSetValue.SetData((FSValue)SpawnedAgentDataSetValue, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
			}
			++variableCount;
			
			ResultOrderAdded = data.ResultOrderAdded;
			
			switch (ResultOrderAdded.TID)
			{
				case FloatSource.TypeId.AgentId:
					FSAgentNode AgentId_node_ResultOrderAdded = graph.AddNode<FSAgentNode>();
					GetPort("ResultOrderAdded").Connect(AgentId_node_ResultOrderAdded.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AgentId_node_ResultOrderAdded, assetPath);
					variableCount += AgentId_node_ResultOrderAdded.SetData((FSAgent)ResultOrderAdded, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.BonesId:
					FSBonesNode BonesId_node_ResultOrderAdded = graph.AddNode<FSBonesNode>();
					GetPort("ResultOrderAdded").Connect(BonesId_node_ResultOrderAdded.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BonesId_node_ResultOrderAdded, assetPath);
					variableCount += BonesId_node_ResultOrderAdded.SetData((FSBones)ResultOrderAdded, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AttackId:
					FSAttackNode AttackId_node_ResultOrderAdded = graph.AddNode<FSAttackNode>();
					GetPort("ResultOrderAdded").Connect(AttackId_node_ResultOrderAdded.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AttackId_node_ResultOrderAdded, assetPath);
					variableCount += AttackId_node_ResultOrderAdded.SetData((FSAttack)ResultOrderAdded, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FrameId:
					FSFrameNode FrameId_node_ResultOrderAdded = graph.AddNode<FSFrameNode>();
					GetPort("ResultOrderAdded").Connect(FrameId_node_ResultOrderAdded.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FrameId_node_ResultOrderAdded, assetPath);
					variableCount += FrameId_node_ResultOrderAdded.SetData((FSFrame)ResultOrderAdded, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.InputId:
					FSInputNode InputId_node_ResultOrderAdded = graph.AddNode<FSInputNode>();
					GetPort("ResultOrderAdded").Connect(InputId_node_ResultOrderAdded.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputId_node_ResultOrderAdded, assetPath);
					variableCount += InputId_node_ResultOrderAdded.SetData((FSInput)ResultOrderAdded, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FuncId:
					FSFuncNode FuncId_node_ResultOrderAdded = graph.AddNode<FSFuncNode>();
					GetPort("ResultOrderAdded").Connect(FuncId_node_ResultOrderAdded.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FuncId_node_ResultOrderAdded, assetPath);
					variableCount += FuncId_node_ResultOrderAdded.SetData((FSFunc)ResultOrderAdded, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.MovementId:
					FSMovementNode MovementId_node_ResultOrderAdded = graph.AddNode<FSMovementNode>();
					GetPort("ResultOrderAdded").Connect(MovementId_node_ResultOrderAdded.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(MovementId_node_ResultOrderAdded, assetPath);
					variableCount += MovementId_node_ResultOrderAdded.SetData((FSMovement)ResultOrderAdded, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CombatId:
					FSCombatNode CombatId_node_ResultOrderAdded = graph.AddNode<FSCombatNode>();
					GetPort("ResultOrderAdded").Connect(CombatId_node_ResultOrderAdded.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CombatId_node_ResultOrderAdded, assetPath);
					variableCount += CombatId_node_ResultOrderAdded.SetData((FSCombat)ResultOrderAdded, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.GrabsId:
					FSGrabsNode GrabsId_node_ResultOrderAdded = graph.AddNode<FSGrabsNode>();
					GetPort("ResultOrderAdded").Connect(GrabsId_node_ResultOrderAdded.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(GrabsId_node_ResultOrderAdded, assetPath);
					variableCount += GrabsId_node_ResultOrderAdded.SetData((FSGrabs)ResultOrderAdded, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.DataId:
					FSDataNode DataId_node_ResultOrderAdded = graph.AddNode<FSDataNode>();
					GetPort("ResultOrderAdded").Connect(DataId_node_ResultOrderAdded.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DataId_node_ResultOrderAdded, assetPath);
					variableCount += DataId_node_ResultOrderAdded.SetData((FSData)ResultOrderAdded, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ScratchId:
					FSScratchNode ScratchId_node_ResultOrderAdded = graph.AddNode<FSScratchNode>();
					GetPort("ResultOrderAdded").Connect(ScratchId_node_ResultOrderAdded.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ScratchId_node_ResultOrderAdded, assetPath);
					variableCount += ScratchId_node_ResultOrderAdded.SetData((FSScratch)ResultOrderAdded, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AnimId:
					FSAnimNode AnimId_node_ResultOrderAdded = graph.AddNode<FSAnimNode>();
					GetPort("ResultOrderAdded").Connect(AnimId_node_ResultOrderAdded.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AnimId_node_ResultOrderAdded, assetPath);
					variableCount += AnimId_node_ResultOrderAdded.SetData((FSAnim)ResultOrderAdded, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SpeedId:
					FSSpeedNode SpeedId_node_ResultOrderAdded = graph.AddNode<FSSpeedNode>();
					GetPort("ResultOrderAdded").Connect(SpeedId_node_ResultOrderAdded.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpeedId_node_ResultOrderAdded, assetPath);
					variableCount += SpeedId_node_ResultOrderAdded.SetData((FSSpeed)ResultOrderAdded, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.PhysicsId:
					FSPhysicsNode PhysicsId_node_ResultOrderAdded = graph.AddNode<FSPhysicsNode>();
					GetPort("ResultOrderAdded").Connect(PhysicsId_node_ResultOrderAdded.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(PhysicsId_node_ResultOrderAdded, assetPath);
					variableCount += PhysicsId_node_ResultOrderAdded.SetData((FSPhysics)ResultOrderAdded, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CollisionId:
					FSCollisionNode CollisionId_node_ResultOrderAdded = graph.AddNode<FSCollisionNode>();
					GetPort("ResultOrderAdded").Connect(CollisionId_node_ResultOrderAdded.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CollisionId_node_ResultOrderAdded, assetPath);
					variableCount += CollisionId_node_ResultOrderAdded.SetData((FSCollision)ResultOrderAdded, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.TimerId:
					FSTimerNode TimerId_node_ResultOrderAdded = graph.AddNode<FSTimerNode>();
					GetPort("ResultOrderAdded").Connect(TimerId_node_ResultOrderAdded.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(TimerId_node_ResultOrderAdded, assetPath);
					variableCount += TimerId_node_ResultOrderAdded.SetData((FSTimer)ResultOrderAdded, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.LagId:
					FSLagNode LagId_node_ResultOrderAdded = graph.AddNode<FSLagNode>();
					GetPort("ResultOrderAdded").Connect(LagId_node_ResultOrderAdded.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LagId_node_ResultOrderAdded, assetPath);
					variableCount += LagId_node_ResultOrderAdded.SetData((FSLag)ResultOrderAdded, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.EffectsId:
					FSEffectsNode EffectsId_node_ResultOrderAdded = graph.AddNode<FSEffectsNode>();
					GetPort("ResultOrderAdded").Connect(EffectsId_node_ResultOrderAdded.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EffectsId_node_ResultOrderAdded, assetPath);
					variableCount += EffectsId_node_ResultOrderAdded.SetData((FSEffects)ResultOrderAdded, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ColorsId:
					FSColorsNode ColorsId_node_ResultOrderAdded = graph.AddNode<FSColorsNode>();
					GetPort("ResultOrderAdded").Connect(ColorsId_node_ResultOrderAdded.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ColorsId_node_ResultOrderAdded, assetPath);
					variableCount += ColorsId_node_ResultOrderAdded.SetData((FSColors)ResultOrderAdded, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.OnHitId:
					FSOnHitNode OnHitId_node_ResultOrderAdded = graph.AddNode<FSOnHitNode>();
					GetPort("ResultOrderAdded").Connect(OnHitId_node_ResultOrderAdded.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnHitId_node_ResultOrderAdded, assetPath);
					variableCount += OnHitId_node_ResultOrderAdded.SetData((FSOnHit)ResultOrderAdded, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RandomId:
					FSRandomNode RandomId_node_ResultOrderAdded = graph.AddNode<FSRandomNode>();
					GetPort("ResultOrderAdded").Connect(RandomId_node_ResultOrderAdded.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RandomId_node_ResultOrderAdded, assetPath);
					variableCount += RandomId_node_ResultOrderAdded.SetData((FSRandom)ResultOrderAdded, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CameraId:
					FSCameraInfoNode CameraId_node_ResultOrderAdded = graph.AddNode<FSCameraInfoNode>();
					GetPort("ResultOrderAdded").Connect(CameraId_node_ResultOrderAdded.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CameraId_node_ResultOrderAdded, assetPath);
					variableCount += CameraId_node_ResultOrderAdded.SetData((FSCameraInfo)ResultOrderAdded, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SportsId:
					FSSportsNode SportsId_node_ResultOrderAdded = graph.AddNode<FSSportsNode>();
					GetPort("ResultOrderAdded").Connect(SportsId_node_ResultOrderAdded.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SportsId_node_ResultOrderAdded, assetPath);
					variableCount += SportsId_node_ResultOrderAdded.SetData((FSSports)ResultOrderAdded, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.Vector2Mag:
					FSVector2MagNode Vector2Mag_node_ResultOrderAdded = graph.AddNode<FSVector2MagNode>();
					GetPort("ResultOrderAdded").Connect(Vector2Mag_node_ResultOrderAdded.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(Vector2Mag_node_ResultOrderAdded, assetPath);
					variableCount += Vector2Mag_node_ResultOrderAdded.SetData((FSVector2Mag)ResultOrderAdded, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CPUHelpId:
					FSCpuHelpNode CPUHelpId_node_ResultOrderAdded = graph.AddNode<FSCpuHelpNode>();
					GetPort("ResultOrderAdded").Connect(CPUHelpId_node_ResultOrderAdded.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CPUHelpId_node_ResultOrderAdded, assetPath);
					variableCount += CPUHelpId_node_ResultOrderAdded.SetData((FSCpuHelp)ResultOrderAdded, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ItemId:
					FSItemNode ItemId_node_ResultOrderAdded = graph.AddNode<FSItemNode>();
					GetPort("ResultOrderAdded").Connect(ItemId_node_ResultOrderAdded.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ItemId_node_ResultOrderAdded, assetPath);
					variableCount += ItemId_node_ResultOrderAdded.SetData((FSItem)ResultOrderAdded, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ModeId:
					FSModeNode ModeId_node_ResultOrderAdded = graph.AddNode<FSModeNode>();
					GetPort("ResultOrderAdded").Connect(ModeId_node_ResultOrderAdded.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ModeId_node_ResultOrderAdded, assetPath);
					variableCount += ModeId_node_ResultOrderAdded.SetData((FSMode)ResultOrderAdded, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.JumpsId:
					FSJumpsNode JumpsId_node_ResultOrderAdded = graph.AddNode<FSJumpsNode>();
					GetPort("ResultOrderAdded").Connect(JumpsId_node_ResultOrderAdded.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(JumpsId_node_ResultOrderAdded, assetPath);
					variableCount += JumpsId_node_ResultOrderAdded.SetData((FSJumps)ResultOrderAdded, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RootAnimId:
					FSRootAnimNode RootAnimId_node_ResultOrderAdded = graph.AddNode<FSRootAnimNode>();
					GetPort("ResultOrderAdded").Connect(RootAnimId_node_ResultOrderAdded.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RootAnimId_node_ResultOrderAdded, assetPath);
					variableCount += RootAnimId_node_ResultOrderAdded.SetData((FSRootAnim)ResultOrderAdded, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FloatId:
					FSValueNode FloatId_node_ResultOrderAdded = graph.AddNode<FSValueNode>();
					GetPort("ResultOrderAdded").Connect(FloatId_node_ResultOrderAdded.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FloatId_node_ResultOrderAdded, assetPath);
					variableCount += FloatId_node_ResultOrderAdded.SetData((FSValue)ResultOrderAdded, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
			}
			++variableCount;
			
			SetPlayerIndex = data.SetPlayerIndex;
			SetAttackTeam = data.SetAttackTeam;
			SetDefendTeam = data.SetDefendTeam;
			SetProjectileLevel = data.SetProjectileLevel;
			SetDirection = data.SetDirection;
			SetRedirect = data.SetRedirect;
			PlayerIndex = data.PlayerIndex;
			
			switch (PlayerIndex.TID)
			{
				case FloatSource.TypeId.AgentId:
					FSAgentNode AgentId_node_PlayerIndex = graph.AddNode<FSAgentNode>();
					GetPort("PlayerIndex").Connect(AgentId_node_PlayerIndex.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AgentId_node_PlayerIndex, assetPath);
					variableCount += AgentId_node_PlayerIndex.SetData((FSAgent)PlayerIndex, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.BonesId:
					FSBonesNode BonesId_node_PlayerIndex = graph.AddNode<FSBonesNode>();
					GetPort("PlayerIndex").Connect(BonesId_node_PlayerIndex.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BonesId_node_PlayerIndex, assetPath);
					variableCount += BonesId_node_PlayerIndex.SetData((FSBones)PlayerIndex, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AttackId:
					FSAttackNode AttackId_node_PlayerIndex = graph.AddNode<FSAttackNode>();
					GetPort("PlayerIndex").Connect(AttackId_node_PlayerIndex.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AttackId_node_PlayerIndex, assetPath);
					variableCount += AttackId_node_PlayerIndex.SetData((FSAttack)PlayerIndex, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FrameId:
					FSFrameNode FrameId_node_PlayerIndex = graph.AddNode<FSFrameNode>();
					GetPort("PlayerIndex").Connect(FrameId_node_PlayerIndex.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FrameId_node_PlayerIndex, assetPath);
					variableCount += FrameId_node_PlayerIndex.SetData((FSFrame)PlayerIndex, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.InputId:
					FSInputNode InputId_node_PlayerIndex = graph.AddNode<FSInputNode>();
					GetPort("PlayerIndex").Connect(InputId_node_PlayerIndex.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputId_node_PlayerIndex, assetPath);
					variableCount += InputId_node_PlayerIndex.SetData((FSInput)PlayerIndex, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FuncId:
					FSFuncNode FuncId_node_PlayerIndex = graph.AddNode<FSFuncNode>();
					GetPort("PlayerIndex").Connect(FuncId_node_PlayerIndex.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FuncId_node_PlayerIndex, assetPath);
					variableCount += FuncId_node_PlayerIndex.SetData((FSFunc)PlayerIndex, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.MovementId:
					FSMovementNode MovementId_node_PlayerIndex = graph.AddNode<FSMovementNode>();
					GetPort("PlayerIndex").Connect(MovementId_node_PlayerIndex.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(MovementId_node_PlayerIndex, assetPath);
					variableCount += MovementId_node_PlayerIndex.SetData((FSMovement)PlayerIndex, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CombatId:
					FSCombatNode CombatId_node_PlayerIndex = graph.AddNode<FSCombatNode>();
					GetPort("PlayerIndex").Connect(CombatId_node_PlayerIndex.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CombatId_node_PlayerIndex, assetPath);
					variableCount += CombatId_node_PlayerIndex.SetData((FSCombat)PlayerIndex, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.GrabsId:
					FSGrabsNode GrabsId_node_PlayerIndex = graph.AddNode<FSGrabsNode>();
					GetPort("PlayerIndex").Connect(GrabsId_node_PlayerIndex.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(GrabsId_node_PlayerIndex, assetPath);
					variableCount += GrabsId_node_PlayerIndex.SetData((FSGrabs)PlayerIndex, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.DataId:
					FSDataNode DataId_node_PlayerIndex = graph.AddNode<FSDataNode>();
					GetPort("PlayerIndex").Connect(DataId_node_PlayerIndex.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DataId_node_PlayerIndex, assetPath);
					variableCount += DataId_node_PlayerIndex.SetData((FSData)PlayerIndex, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ScratchId:
					FSScratchNode ScratchId_node_PlayerIndex = graph.AddNode<FSScratchNode>();
					GetPort("PlayerIndex").Connect(ScratchId_node_PlayerIndex.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ScratchId_node_PlayerIndex, assetPath);
					variableCount += ScratchId_node_PlayerIndex.SetData((FSScratch)PlayerIndex, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AnimId:
					FSAnimNode AnimId_node_PlayerIndex = graph.AddNode<FSAnimNode>();
					GetPort("PlayerIndex").Connect(AnimId_node_PlayerIndex.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AnimId_node_PlayerIndex, assetPath);
					variableCount += AnimId_node_PlayerIndex.SetData((FSAnim)PlayerIndex, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SpeedId:
					FSSpeedNode SpeedId_node_PlayerIndex = graph.AddNode<FSSpeedNode>();
					GetPort("PlayerIndex").Connect(SpeedId_node_PlayerIndex.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpeedId_node_PlayerIndex, assetPath);
					variableCount += SpeedId_node_PlayerIndex.SetData((FSSpeed)PlayerIndex, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.PhysicsId:
					FSPhysicsNode PhysicsId_node_PlayerIndex = graph.AddNode<FSPhysicsNode>();
					GetPort("PlayerIndex").Connect(PhysicsId_node_PlayerIndex.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(PhysicsId_node_PlayerIndex, assetPath);
					variableCount += PhysicsId_node_PlayerIndex.SetData((FSPhysics)PlayerIndex, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CollisionId:
					FSCollisionNode CollisionId_node_PlayerIndex = graph.AddNode<FSCollisionNode>();
					GetPort("PlayerIndex").Connect(CollisionId_node_PlayerIndex.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CollisionId_node_PlayerIndex, assetPath);
					variableCount += CollisionId_node_PlayerIndex.SetData((FSCollision)PlayerIndex, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.TimerId:
					FSTimerNode TimerId_node_PlayerIndex = graph.AddNode<FSTimerNode>();
					GetPort("PlayerIndex").Connect(TimerId_node_PlayerIndex.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(TimerId_node_PlayerIndex, assetPath);
					variableCount += TimerId_node_PlayerIndex.SetData((FSTimer)PlayerIndex, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.LagId:
					FSLagNode LagId_node_PlayerIndex = graph.AddNode<FSLagNode>();
					GetPort("PlayerIndex").Connect(LagId_node_PlayerIndex.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LagId_node_PlayerIndex, assetPath);
					variableCount += LagId_node_PlayerIndex.SetData((FSLag)PlayerIndex, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.EffectsId:
					FSEffectsNode EffectsId_node_PlayerIndex = graph.AddNode<FSEffectsNode>();
					GetPort("PlayerIndex").Connect(EffectsId_node_PlayerIndex.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EffectsId_node_PlayerIndex, assetPath);
					variableCount += EffectsId_node_PlayerIndex.SetData((FSEffects)PlayerIndex, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ColorsId:
					FSColorsNode ColorsId_node_PlayerIndex = graph.AddNode<FSColorsNode>();
					GetPort("PlayerIndex").Connect(ColorsId_node_PlayerIndex.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ColorsId_node_PlayerIndex, assetPath);
					variableCount += ColorsId_node_PlayerIndex.SetData((FSColors)PlayerIndex, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.OnHitId:
					FSOnHitNode OnHitId_node_PlayerIndex = graph.AddNode<FSOnHitNode>();
					GetPort("PlayerIndex").Connect(OnHitId_node_PlayerIndex.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnHitId_node_PlayerIndex, assetPath);
					variableCount += OnHitId_node_PlayerIndex.SetData((FSOnHit)PlayerIndex, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RandomId:
					FSRandomNode RandomId_node_PlayerIndex = graph.AddNode<FSRandomNode>();
					GetPort("PlayerIndex").Connect(RandomId_node_PlayerIndex.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RandomId_node_PlayerIndex, assetPath);
					variableCount += RandomId_node_PlayerIndex.SetData((FSRandom)PlayerIndex, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CameraId:
					FSCameraInfoNode CameraId_node_PlayerIndex = graph.AddNode<FSCameraInfoNode>();
					GetPort("PlayerIndex").Connect(CameraId_node_PlayerIndex.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CameraId_node_PlayerIndex, assetPath);
					variableCount += CameraId_node_PlayerIndex.SetData((FSCameraInfo)PlayerIndex, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SportsId:
					FSSportsNode SportsId_node_PlayerIndex = graph.AddNode<FSSportsNode>();
					GetPort("PlayerIndex").Connect(SportsId_node_PlayerIndex.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SportsId_node_PlayerIndex, assetPath);
					variableCount += SportsId_node_PlayerIndex.SetData((FSSports)PlayerIndex, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.Vector2Mag:
					FSVector2MagNode Vector2Mag_node_PlayerIndex = graph.AddNode<FSVector2MagNode>();
					GetPort("PlayerIndex").Connect(Vector2Mag_node_PlayerIndex.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(Vector2Mag_node_PlayerIndex, assetPath);
					variableCount += Vector2Mag_node_PlayerIndex.SetData((FSVector2Mag)PlayerIndex, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CPUHelpId:
					FSCpuHelpNode CPUHelpId_node_PlayerIndex = graph.AddNode<FSCpuHelpNode>();
					GetPort("PlayerIndex").Connect(CPUHelpId_node_PlayerIndex.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CPUHelpId_node_PlayerIndex, assetPath);
					variableCount += CPUHelpId_node_PlayerIndex.SetData((FSCpuHelp)PlayerIndex, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ItemId:
					FSItemNode ItemId_node_PlayerIndex = graph.AddNode<FSItemNode>();
					GetPort("PlayerIndex").Connect(ItemId_node_PlayerIndex.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ItemId_node_PlayerIndex, assetPath);
					variableCount += ItemId_node_PlayerIndex.SetData((FSItem)PlayerIndex, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ModeId:
					FSModeNode ModeId_node_PlayerIndex = graph.AddNode<FSModeNode>();
					GetPort("PlayerIndex").Connect(ModeId_node_PlayerIndex.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ModeId_node_PlayerIndex, assetPath);
					variableCount += ModeId_node_PlayerIndex.SetData((FSMode)PlayerIndex, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.JumpsId:
					FSJumpsNode JumpsId_node_PlayerIndex = graph.AddNode<FSJumpsNode>();
					GetPort("PlayerIndex").Connect(JumpsId_node_PlayerIndex.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(JumpsId_node_PlayerIndex, assetPath);
					variableCount += JumpsId_node_PlayerIndex.SetData((FSJumps)PlayerIndex, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RootAnimId:
					FSRootAnimNode RootAnimId_node_PlayerIndex = graph.AddNode<FSRootAnimNode>();
					GetPort("PlayerIndex").Connect(RootAnimId_node_PlayerIndex.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RootAnimId_node_PlayerIndex, assetPath);
					variableCount += RootAnimId_node_PlayerIndex.SetData((FSRootAnim)PlayerIndex, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FloatId:
					FSValueNode FloatId_node_PlayerIndex = graph.AddNode<FSValueNode>();
					GetPort("PlayerIndex").Connect(FloatId_node_PlayerIndex.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FloatId_node_PlayerIndex, assetPath);
					variableCount += FloatId_node_PlayerIndex.SetData((FSValue)PlayerIndex, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
			}
			++variableCount;
			
			AttackTeam = data.AttackTeam;
			
			switch (AttackTeam.TID)
			{
				case FloatSource.TypeId.AgentId:
					FSAgentNode AgentId_node_AttackTeam = graph.AddNode<FSAgentNode>();
					GetPort("AttackTeam").Connect(AgentId_node_AttackTeam.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AgentId_node_AttackTeam, assetPath);
					variableCount += AgentId_node_AttackTeam.SetData((FSAgent)AttackTeam, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.BonesId:
					FSBonesNode BonesId_node_AttackTeam = graph.AddNode<FSBonesNode>();
					GetPort("AttackTeam").Connect(BonesId_node_AttackTeam.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BonesId_node_AttackTeam, assetPath);
					variableCount += BonesId_node_AttackTeam.SetData((FSBones)AttackTeam, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AttackId:
					FSAttackNode AttackId_node_AttackTeam = graph.AddNode<FSAttackNode>();
					GetPort("AttackTeam").Connect(AttackId_node_AttackTeam.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AttackId_node_AttackTeam, assetPath);
					variableCount += AttackId_node_AttackTeam.SetData((FSAttack)AttackTeam, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FrameId:
					FSFrameNode FrameId_node_AttackTeam = graph.AddNode<FSFrameNode>();
					GetPort("AttackTeam").Connect(FrameId_node_AttackTeam.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FrameId_node_AttackTeam, assetPath);
					variableCount += FrameId_node_AttackTeam.SetData((FSFrame)AttackTeam, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.InputId:
					FSInputNode InputId_node_AttackTeam = graph.AddNode<FSInputNode>();
					GetPort("AttackTeam").Connect(InputId_node_AttackTeam.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputId_node_AttackTeam, assetPath);
					variableCount += InputId_node_AttackTeam.SetData((FSInput)AttackTeam, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FuncId:
					FSFuncNode FuncId_node_AttackTeam = graph.AddNode<FSFuncNode>();
					GetPort("AttackTeam").Connect(FuncId_node_AttackTeam.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FuncId_node_AttackTeam, assetPath);
					variableCount += FuncId_node_AttackTeam.SetData((FSFunc)AttackTeam, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.MovementId:
					FSMovementNode MovementId_node_AttackTeam = graph.AddNode<FSMovementNode>();
					GetPort("AttackTeam").Connect(MovementId_node_AttackTeam.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(MovementId_node_AttackTeam, assetPath);
					variableCount += MovementId_node_AttackTeam.SetData((FSMovement)AttackTeam, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CombatId:
					FSCombatNode CombatId_node_AttackTeam = graph.AddNode<FSCombatNode>();
					GetPort("AttackTeam").Connect(CombatId_node_AttackTeam.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CombatId_node_AttackTeam, assetPath);
					variableCount += CombatId_node_AttackTeam.SetData((FSCombat)AttackTeam, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.GrabsId:
					FSGrabsNode GrabsId_node_AttackTeam = graph.AddNode<FSGrabsNode>();
					GetPort("AttackTeam").Connect(GrabsId_node_AttackTeam.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(GrabsId_node_AttackTeam, assetPath);
					variableCount += GrabsId_node_AttackTeam.SetData((FSGrabs)AttackTeam, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.DataId:
					FSDataNode DataId_node_AttackTeam = graph.AddNode<FSDataNode>();
					GetPort("AttackTeam").Connect(DataId_node_AttackTeam.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DataId_node_AttackTeam, assetPath);
					variableCount += DataId_node_AttackTeam.SetData((FSData)AttackTeam, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ScratchId:
					FSScratchNode ScratchId_node_AttackTeam = graph.AddNode<FSScratchNode>();
					GetPort("AttackTeam").Connect(ScratchId_node_AttackTeam.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ScratchId_node_AttackTeam, assetPath);
					variableCount += ScratchId_node_AttackTeam.SetData((FSScratch)AttackTeam, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AnimId:
					FSAnimNode AnimId_node_AttackTeam = graph.AddNode<FSAnimNode>();
					GetPort("AttackTeam").Connect(AnimId_node_AttackTeam.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AnimId_node_AttackTeam, assetPath);
					variableCount += AnimId_node_AttackTeam.SetData((FSAnim)AttackTeam, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SpeedId:
					FSSpeedNode SpeedId_node_AttackTeam = graph.AddNode<FSSpeedNode>();
					GetPort("AttackTeam").Connect(SpeedId_node_AttackTeam.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpeedId_node_AttackTeam, assetPath);
					variableCount += SpeedId_node_AttackTeam.SetData((FSSpeed)AttackTeam, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.PhysicsId:
					FSPhysicsNode PhysicsId_node_AttackTeam = graph.AddNode<FSPhysicsNode>();
					GetPort("AttackTeam").Connect(PhysicsId_node_AttackTeam.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(PhysicsId_node_AttackTeam, assetPath);
					variableCount += PhysicsId_node_AttackTeam.SetData((FSPhysics)AttackTeam, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CollisionId:
					FSCollisionNode CollisionId_node_AttackTeam = graph.AddNode<FSCollisionNode>();
					GetPort("AttackTeam").Connect(CollisionId_node_AttackTeam.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CollisionId_node_AttackTeam, assetPath);
					variableCount += CollisionId_node_AttackTeam.SetData((FSCollision)AttackTeam, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.TimerId:
					FSTimerNode TimerId_node_AttackTeam = graph.AddNode<FSTimerNode>();
					GetPort("AttackTeam").Connect(TimerId_node_AttackTeam.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(TimerId_node_AttackTeam, assetPath);
					variableCount += TimerId_node_AttackTeam.SetData((FSTimer)AttackTeam, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.LagId:
					FSLagNode LagId_node_AttackTeam = graph.AddNode<FSLagNode>();
					GetPort("AttackTeam").Connect(LagId_node_AttackTeam.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LagId_node_AttackTeam, assetPath);
					variableCount += LagId_node_AttackTeam.SetData((FSLag)AttackTeam, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.EffectsId:
					FSEffectsNode EffectsId_node_AttackTeam = graph.AddNode<FSEffectsNode>();
					GetPort("AttackTeam").Connect(EffectsId_node_AttackTeam.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EffectsId_node_AttackTeam, assetPath);
					variableCount += EffectsId_node_AttackTeam.SetData((FSEffects)AttackTeam, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ColorsId:
					FSColorsNode ColorsId_node_AttackTeam = graph.AddNode<FSColorsNode>();
					GetPort("AttackTeam").Connect(ColorsId_node_AttackTeam.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ColorsId_node_AttackTeam, assetPath);
					variableCount += ColorsId_node_AttackTeam.SetData((FSColors)AttackTeam, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.OnHitId:
					FSOnHitNode OnHitId_node_AttackTeam = graph.AddNode<FSOnHitNode>();
					GetPort("AttackTeam").Connect(OnHitId_node_AttackTeam.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnHitId_node_AttackTeam, assetPath);
					variableCount += OnHitId_node_AttackTeam.SetData((FSOnHit)AttackTeam, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RandomId:
					FSRandomNode RandomId_node_AttackTeam = graph.AddNode<FSRandomNode>();
					GetPort("AttackTeam").Connect(RandomId_node_AttackTeam.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RandomId_node_AttackTeam, assetPath);
					variableCount += RandomId_node_AttackTeam.SetData((FSRandom)AttackTeam, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CameraId:
					FSCameraInfoNode CameraId_node_AttackTeam = graph.AddNode<FSCameraInfoNode>();
					GetPort("AttackTeam").Connect(CameraId_node_AttackTeam.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CameraId_node_AttackTeam, assetPath);
					variableCount += CameraId_node_AttackTeam.SetData((FSCameraInfo)AttackTeam, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SportsId:
					FSSportsNode SportsId_node_AttackTeam = graph.AddNode<FSSportsNode>();
					GetPort("AttackTeam").Connect(SportsId_node_AttackTeam.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SportsId_node_AttackTeam, assetPath);
					variableCount += SportsId_node_AttackTeam.SetData((FSSports)AttackTeam, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.Vector2Mag:
					FSVector2MagNode Vector2Mag_node_AttackTeam = graph.AddNode<FSVector2MagNode>();
					GetPort("AttackTeam").Connect(Vector2Mag_node_AttackTeam.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(Vector2Mag_node_AttackTeam, assetPath);
					variableCount += Vector2Mag_node_AttackTeam.SetData((FSVector2Mag)AttackTeam, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CPUHelpId:
					FSCpuHelpNode CPUHelpId_node_AttackTeam = graph.AddNode<FSCpuHelpNode>();
					GetPort("AttackTeam").Connect(CPUHelpId_node_AttackTeam.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CPUHelpId_node_AttackTeam, assetPath);
					variableCount += CPUHelpId_node_AttackTeam.SetData((FSCpuHelp)AttackTeam, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ItemId:
					FSItemNode ItemId_node_AttackTeam = graph.AddNode<FSItemNode>();
					GetPort("AttackTeam").Connect(ItemId_node_AttackTeam.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ItemId_node_AttackTeam, assetPath);
					variableCount += ItemId_node_AttackTeam.SetData((FSItem)AttackTeam, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ModeId:
					FSModeNode ModeId_node_AttackTeam = graph.AddNode<FSModeNode>();
					GetPort("AttackTeam").Connect(ModeId_node_AttackTeam.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ModeId_node_AttackTeam, assetPath);
					variableCount += ModeId_node_AttackTeam.SetData((FSMode)AttackTeam, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.JumpsId:
					FSJumpsNode JumpsId_node_AttackTeam = graph.AddNode<FSJumpsNode>();
					GetPort("AttackTeam").Connect(JumpsId_node_AttackTeam.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(JumpsId_node_AttackTeam, assetPath);
					variableCount += JumpsId_node_AttackTeam.SetData((FSJumps)AttackTeam, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RootAnimId:
					FSRootAnimNode RootAnimId_node_AttackTeam = graph.AddNode<FSRootAnimNode>();
					GetPort("AttackTeam").Connect(RootAnimId_node_AttackTeam.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RootAnimId_node_AttackTeam, assetPath);
					variableCount += RootAnimId_node_AttackTeam.SetData((FSRootAnim)AttackTeam, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FloatId:
					FSValueNode FloatId_node_AttackTeam = graph.AddNode<FSValueNode>();
					GetPort("AttackTeam").Connect(FloatId_node_AttackTeam.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FloatId_node_AttackTeam, assetPath);
					variableCount += FloatId_node_AttackTeam.SetData((FSValue)AttackTeam, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
			}
			++variableCount;
			
			DefendTeam = data.DefendTeam;
			
			switch (DefendTeam.TID)
			{
				case FloatSource.TypeId.AgentId:
					FSAgentNode AgentId_node_DefendTeam = graph.AddNode<FSAgentNode>();
					GetPort("DefendTeam").Connect(AgentId_node_DefendTeam.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AgentId_node_DefendTeam, assetPath);
					variableCount += AgentId_node_DefendTeam.SetData((FSAgent)DefendTeam, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.BonesId:
					FSBonesNode BonesId_node_DefendTeam = graph.AddNode<FSBonesNode>();
					GetPort("DefendTeam").Connect(BonesId_node_DefendTeam.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BonesId_node_DefendTeam, assetPath);
					variableCount += BonesId_node_DefendTeam.SetData((FSBones)DefendTeam, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AttackId:
					FSAttackNode AttackId_node_DefendTeam = graph.AddNode<FSAttackNode>();
					GetPort("DefendTeam").Connect(AttackId_node_DefendTeam.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AttackId_node_DefendTeam, assetPath);
					variableCount += AttackId_node_DefendTeam.SetData((FSAttack)DefendTeam, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FrameId:
					FSFrameNode FrameId_node_DefendTeam = graph.AddNode<FSFrameNode>();
					GetPort("DefendTeam").Connect(FrameId_node_DefendTeam.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FrameId_node_DefendTeam, assetPath);
					variableCount += FrameId_node_DefendTeam.SetData((FSFrame)DefendTeam, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.InputId:
					FSInputNode InputId_node_DefendTeam = graph.AddNode<FSInputNode>();
					GetPort("DefendTeam").Connect(InputId_node_DefendTeam.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputId_node_DefendTeam, assetPath);
					variableCount += InputId_node_DefendTeam.SetData((FSInput)DefendTeam, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FuncId:
					FSFuncNode FuncId_node_DefendTeam = graph.AddNode<FSFuncNode>();
					GetPort("DefendTeam").Connect(FuncId_node_DefendTeam.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FuncId_node_DefendTeam, assetPath);
					variableCount += FuncId_node_DefendTeam.SetData((FSFunc)DefendTeam, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.MovementId:
					FSMovementNode MovementId_node_DefendTeam = graph.AddNode<FSMovementNode>();
					GetPort("DefendTeam").Connect(MovementId_node_DefendTeam.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(MovementId_node_DefendTeam, assetPath);
					variableCount += MovementId_node_DefendTeam.SetData((FSMovement)DefendTeam, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CombatId:
					FSCombatNode CombatId_node_DefendTeam = graph.AddNode<FSCombatNode>();
					GetPort("DefendTeam").Connect(CombatId_node_DefendTeam.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CombatId_node_DefendTeam, assetPath);
					variableCount += CombatId_node_DefendTeam.SetData((FSCombat)DefendTeam, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.GrabsId:
					FSGrabsNode GrabsId_node_DefendTeam = graph.AddNode<FSGrabsNode>();
					GetPort("DefendTeam").Connect(GrabsId_node_DefendTeam.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(GrabsId_node_DefendTeam, assetPath);
					variableCount += GrabsId_node_DefendTeam.SetData((FSGrabs)DefendTeam, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.DataId:
					FSDataNode DataId_node_DefendTeam = graph.AddNode<FSDataNode>();
					GetPort("DefendTeam").Connect(DataId_node_DefendTeam.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DataId_node_DefendTeam, assetPath);
					variableCount += DataId_node_DefendTeam.SetData((FSData)DefendTeam, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ScratchId:
					FSScratchNode ScratchId_node_DefendTeam = graph.AddNode<FSScratchNode>();
					GetPort("DefendTeam").Connect(ScratchId_node_DefendTeam.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ScratchId_node_DefendTeam, assetPath);
					variableCount += ScratchId_node_DefendTeam.SetData((FSScratch)DefendTeam, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AnimId:
					FSAnimNode AnimId_node_DefendTeam = graph.AddNode<FSAnimNode>();
					GetPort("DefendTeam").Connect(AnimId_node_DefendTeam.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AnimId_node_DefendTeam, assetPath);
					variableCount += AnimId_node_DefendTeam.SetData((FSAnim)DefendTeam, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SpeedId:
					FSSpeedNode SpeedId_node_DefendTeam = graph.AddNode<FSSpeedNode>();
					GetPort("DefendTeam").Connect(SpeedId_node_DefendTeam.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpeedId_node_DefendTeam, assetPath);
					variableCount += SpeedId_node_DefendTeam.SetData((FSSpeed)DefendTeam, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.PhysicsId:
					FSPhysicsNode PhysicsId_node_DefendTeam = graph.AddNode<FSPhysicsNode>();
					GetPort("DefendTeam").Connect(PhysicsId_node_DefendTeam.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(PhysicsId_node_DefendTeam, assetPath);
					variableCount += PhysicsId_node_DefendTeam.SetData((FSPhysics)DefendTeam, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CollisionId:
					FSCollisionNode CollisionId_node_DefendTeam = graph.AddNode<FSCollisionNode>();
					GetPort("DefendTeam").Connect(CollisionId_node_DefendTeam.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CollisionId_node_DefendTeam, assetPath);
					variableCount += CollisionId_node_DefendTeam.SetData((FSCollision)DefendTeam, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.TimerId:
					FSTimerNode TimerId_node_DefendTeam = graph.AddNode<FSTimerNode>();
					GetPort("DefendTeam").Connect(TimerId_node_DefendTeam.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(TimerId_node_DefendTeam, assetPath);
					variableCount += TimerId_node_DefendTeam.SetData((FSTimer)DefendTeam, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.LagId:
					FSLagNode LagId_node_DefendTeam = graph.AddNode<FSLagNode>();
					GetPort("DefendTeam").Connect(LagId_node_DefendTeam.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LagId_node_DefendTeam, assetPath);
					variableCount += LagId_node_DefendTeam.SetData((FSLag)DefendTeam, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.EffectsId:
					FSEffectsNode EffectsId_node_DefendTeam = graph.AddNode<FSEffectsNode>();
					GetPort("DefendTeam").Connect(EffectsId_node_DefendTeam.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EffectsId_node_DefendTeam, assetPath);
					variableCount += EffectsId_node_DefendTeam.SetData((FSEffects)DefendTeam, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ColorsId:
					FSColorsNode ColorsId_node_DefendTeam = graph.AddNode<FSColorsNode>();
					GetPort("DefendTeam").Connect(ColorsId_node_DefendTeam.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ColorsId_node_DefendTeam, assetPath);
					variableCount += ColorsId_node_DefendTeam.SetData((FSColors)DefendTeam, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.OnHitId:
					FSOnHitNode OnHitId_node_DefendTeam = graph.AddNode<FSOnHitNode>();
					GetPort("DefendTeam").Connect(OnHitId_node_DefendTeam.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnHitId_node_DefendTeam, assetPath);
					variableCount += OnHitId_node_DefendTeam.SetData((FSOnHit)DefendTeam, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RandomId:
					FSRandomNode RandomId_node_DefendTeam = graph.AddNode<FSRandomNode>();
					GetPort("DefendTeam").Connect(RandomId_node_DefendTeam.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RandomId_node_DefendTeam, assetPath);
					variableCount += RandomId_node_DefendTeam.SetData((FSRandom)DefendTeam, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CameraId:
					FSCameraInfoNode CameraId_node_DefendTeam = graph.AddNode<FSCameraInfoNode>();
					GetPort("DefendTeam").Connect(CameraId_node_DefendTeam.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CameraId_node_DefendTeam, assetPath);
					variableCount += CameraId_node_DefendTeam.SetData((FSCameraInfo)DefendTeam, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SportsId:
					FSSportsNode SportsId_node_DefendTeam = graph.AddNode<FSSportsNode>();
					GetPort("DefendTeam").Connect(SportsId_node_DefendTeam.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SportsId_node_DefendTeam, assetPath);
					variableCount += SportsId_node_DefendTeam.SetData((FSSports)DefendTeam, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.Vector2Mag:
					FSVector2MagNode Vector2Mag_node_DefendTeam = graph.AddNode<FSVector2MagNode>();
					GetPort("DefendTeam").Connect(Vector2Mag_node_DefendTeam.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(Vector2Mag_node_DefendTeam, assetPath);
					variableCount += Vector2Mag_node_DefendTeam.SetData((FSVector2Mag)DefendTeam, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CPUHelpId:
					FSCpuHelpNode CPUHelpId_node_DefendTeam = graph.AddNode<FSCpuHelpNode>();
					GetPort("DefendTeam").Connect(CPUHelpId_node_DefendTeam.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CPUHelpId_node_DefendTeam, assetPath);
					variableCount += CPUHelpId_node_DefendTeam.SetData((FSCpuHelp)DefendTeam, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ItemId:
					FSItemNode ItemId_node_DefendTeam = graph.AddNode<FSItemNode>();
					GetPort("DefendTeam").Connect(ItemId_node_DefendTeam.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ItemId_node_DefendTeam, assetPath);
					variableCount += ItemId_node_DefendTeam.SetData((FSItem)DefendTeam, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ModeId:
					FSModeNode ModeId_node_DefendTeam = graph.AddNode<FSModeNode>();
					GetPort("DefendTeam").Connect(ModeId_node_DefendTeam.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ModeId_node_DefendTeam, assetPath);
					variableCount += ModeId_node_DefendTeam.SetData((FSMode)DefendTeam, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.JumpsId:
					FSJumpsNode JumpsId_node_DefendTeam = graph.AddNode<FSJumpsNode>();
					GetPort("DefendTeam").Connect(JumpsId_node_DefendTeam.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(JumpsId_node_DefendTeam, assetPath);
					variableCount += JumpsId_node_DefendTeam.SetData((FSJumps)DefendTeam, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RootAnimId:
					FSRootAnimNode RootAnimId_node_DefendTeam = graph.AddNode<FSRootAnimNode>();
					GetPort("DefendTeam").Connect(RootAnimId_node_DefendTeam.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RootAnimId_node_DefendTeam, assetPath);
					variableCount += RootAnimId_node_DefendTeam.SetData((FSRootAnim)DefendTeam, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FloatId:
					FSValueNode FloatId_node_DefendTeam = graph.AddNode<FSValueNode>();
					GetPort("DefendTeam").Connect(FloatId_node_DefendTeam.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FloatId_node_DefendTeam, assetPath);
					variableCount += FloatId_node_DefendTeam.SetData((FSValue)DefendTeam, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
			}
			++variableCount;
			
			ProjectileLevel = data.ProjectileLevel;
			
			switch (ProjectileLevel.TID)
			{
				case FloatSource.TypeId.AgentId:
					FSAgentNode AgentId_node_ProjectileLevel = graph.AddNode<FSAgentNode>();
					GetPort("ProjectileLevel").Connect(AgentId_node_ProjectileLevel.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AgentId_node_ProjectileLevel, assetPath);
					variableCount += AgentId_node_ProjectileLevel.SetData((FSAgent)ProjectileLevel, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.BonesId:
					FSBonesNode BonesId_node_ProjectileLevel = graph.AddNode<FSBonesNode>();
					GetPort("ProjectileLevel").Connect(BonesId_node_ProjectileLevel.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BonesId_node_ProjectileLevel, assetPath);
					variableCount += BonesId_node_ProjectileLevel.SetData((FSBones)ProjectileLevel, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AttackId:
					FSAttackNode AttackId_node_ProjectileLevel = graph.AddNode<FSAttackNode>();
					GetPort("ProjectileLevel").Connect(AttackId_node_ProjectileLevel.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AttackId_node_ProjectileLevel, assetPath);
					variableCount += AttackId_node_ProjectileLevel.SetData((FSAttack)ProjectileLevel, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FrameId:
					FSFrameNode FrameId_node_ProjectileLevel = graph.AddNode<FSFrameNode>();
					GetPort("ProjectileLevel").Connect(FrameId_node_ProjectileLevel.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FrameId_node_ProjectileLevel, assetPath);
					variableCount += FrameId_node_ProjectileLevel.SetData((FSFrame)ProjectileLevel, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.InputId:
					FSInputNode InputId_node_ProjectileLevel = graph.AddNode<FSInputNode>();
					GetPort("ProjectileLevel").Connect(InputId_node_ProjectileLevel.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputId_node_ProjectileLevel, assetPath);
					variableCount += InputId_node_ProjectileLevel.SetData((FSInput)ProjectileLevel, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FuncId:
					FSFuncNode FuncId_node_ProjectileLevel = graph.AddNode<FSFuncNode>();
					GetPort("ProjectileLevel").Connect(FuncId_node_ProjectileLevel.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FuncId_node_ProjectileLevel, assetPath);
					variableCount += FuncId_node_ProjectileLevel.SetData((FSFunc)ProjectileLevel, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.MovementId:
					FSMovementNode MovementId_node_ProjectileLevel = graph.AddNode<FSMovementNode>();
					GetPort("ProjectileLevel").Connect(MovementId_node_ProjectileLevel.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(MovementId_node_ProjectileLevel, assetPath);
					variableCount += MovementId_node_ProjectileLevel.SetData((FSMovement)ProjectileLevel, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CombatId:
					FSCombatNode CombatId_node_ProjectileLevel = graph.AddNode<FSCombatNode>();
					GetPort("ProjectileLevel").Connect(CombatId_node_ProjectileLevel.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CombatId_node_ProjectileLevel, assetPath);
					variableCount += CombatId_node_ProjectileLevel.SetData((FSCombat)ProjectileLevel, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.GrabsId:
					FSGrabsNode GrabsId_node_ProjectileLevel = graph.AddNode<FSGrabsNode>();
					GetPort("ProjectileLevel").Connect(GrabsId_node_ProjectileLevel.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(GrabsId_node_ProjectileLevel, assetPath);
					variableCount += GrabsId_node_ProjectileLevel.SetData((FSGrabs)ProjectileLevel, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.DataId:
					FSDataNode DataId_node_ProjectileLevel = graph.AddNode<FSDataNode>();
					GetPort("ProjectileLevel").Connect(DataId_node_ProjectileLevel.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DataId_node_ProjectileLevel, assetPath);
					variableCount += DataId_node_ProjectileLevel.SetData((FSData)ProjectileLevel, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ScratchId:
					FSScratchNode ScratchId_node_ProjectileLevel = graph.AddNode<FSScratchNode>();
					GetPort("ProjectileLevel").Connect(ScratchId_node_ProjectileLevel.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ScratchId_node_ProjectileLevel, assetPath);
					variableCount += ScratchId_node_ProjectileLevel.SetData((FSScratch)ProjectileLevel, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AnimId:
					FSAnimNode AnimId_node_ProjectileLevel = graph.AddNode<FSAnimNode>();
					GetPort("ProjectileLevel").Connect(AnimId_node_ProjectileLevel.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AnimId_node_ProjectileLevel, assetPath);
					variableCount += AnimId_node_ProjectileLevel.SetData((FSAnim)ProjectileLevel, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SpeedId:
					FSSpeedNode SpeedId_node_ProjectileLevel = graph.AddNode<FSSpeedNode>();
					GetPort("ProjectileLevel").Connect(SpeedId_node_ProjectileLevel.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpeedId_node_ProjectileLevel, assetPath);
					variableCount += SpeedId_node_ProjectileLevel.SetData((FSSpeed)ProjectileLevel, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.PhysicsId:
					FSPhysicsNode PhysicsId_node_ProjectileLevel = graph.AddNode<FSPhysicsNode>();
					GetPort("ProjectileLevel").Connect(PhysicsId_node_ProjectileLevel.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(PhysicsId_node_ProjectileLevel, assetPath);
					variableCount += PhysicsId_node_ProjectileLevel.SetData((FSPhysics)ProjectileLevel, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CollisionId:
					FSCollisionNode CollisionId_node_ProjectileLevel = graph.AddNode<FSCollisionNode>();
					GetPort("ProjectileLevel").Connect(CollisionId_node_ProjectileLevel.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CollisionId_node_ProjectileLevel, assetPath);
					variableCount += CollisionId_node_ProjectileLevel.SetData((FSCollision)ProjectileLevel, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.TimerId:
					FSTimerNode TimerId_node_ProjectileLevel = graph.AddNode<FSTimerNode>();
					GetPort("ProjectileLevel").Connect(TimerId_node_ProjectileLevel.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(TimerId_node_ProjectileLevel, assetPath);
					variableCount += TimerId_node_ProjectileLevel.SetData((FSTimer)ProjectileLevel, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.LagId:
					FSLagNode LagId_node_ProjectileLevel = graph.AddNode<FSLagNode>();
					GetPort("ProjectileLevel").Connect(LagId_node_ProjectileLevel.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LagId_node_ProjectileLevel, assetPath);
					variableCount += LagId_node_ProjectileLevel.SetData((FSLag)ProjectileLevel, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.EffectsId:
					FSEffectsNode EffectsId_node_ProjectileLevel = graph.AddNode<FSEffectsNode>();
					GetPort("ProjectileLevel").Connect(EffectsId_node_ProjectileLevel.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EffectsId_node_ProjectileLevel, assetPath);
					variableCount += EffectsId_node_ProjectileLevel.SetData((FSEffects)ProjectileLevel, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ColorsId:
					FSColorsNode ColorsId_node_ProjectileLevel = graph.AddNode<FSColorsNode>();
					GetPort("ProjectileLevel").Connect(ColorsId_node_ProjectileLevel.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ColorsId_node_ProjectileLevel, assetPath);
					variableCount += ColorsId_node_ProjectileLevel.SetData((FSColors)ProjectileLevel, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.OnHitId:
					FSOnHitNode OnHitId_node_ProjectileLevel = graph.AddNode<FSOnHitNode>();
					GetPort("ProjectileLevel").Connect(OnHitId_node_ProjectileLevel.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnHitId_node_ProjectileLevel, assetPath);
					variableCount += OnHitId_node_ProjectileLevel.SetData((FSOnHit)ProjectileLevel, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RandomId:
					FSRandomNode RandomId_node_ProjectileLevel = graph.AddNode<FSRandomNode>();
					GetPort("ProjectileLevel").Connect(RandomId_node_ProjectileLevel.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RandomId_node_ProjectileLevel, assetPath);
					variableCount += RandomId_node_ProjectileLevel.SetData((FSRandom)ProjectileLevel, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CameraId:
					FSCameraInfoNode CameraId_node_ProjectileLevel = graph.AddNode<FSCameraInfoNode>();
					GetPort("ProjectileLevel").Connect(CameraId_node_ProjectileLevel.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CameraId_node_ProjectileLevel, assetPath);
					variableCount += CameraId_node_ProjectileLevel.SetData((FSCameraInfo)ProjectileLevel, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SportsId:
					FSSportsNode SportsId_node_ProjectileLevel = graph.AddNode<FSSportsNode>();
					GetPort("ProjectileLevel").Connect(SportsId_node_ProjectileLevel.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SportsId_node_ProjectileLevel, assetPath);
					variableCount += SportsId_node_ProjectileLevel.SetData((FSSports)ProjectileLevel, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.Vector2Mag:
					FSVector2MagNode Vector2Mag_node_ProjectileLevel = graph.AddNode<FSVector2MagNode>();
					GetPort("ProjectileLevel").Connect(Vector2Mag_node_ProjectileLevel.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(Vector2Mag_node_ProjectileLevel, assetPath);
					variableCount += Vector2Mag_node_ProjectileLevel.SetData((FSVector2Mag)ProjectileLevel, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CPUHelpId:
					FSCpuHelpNode CPUHelpId_node_ProjectileLevel = graph.AddNode<FSCpuHelpNode>();
					GetPort("ProjectileLevel").Connect(CPUHelpId_node_ProjectileLevel.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CPUHelpId_node_ProjectileLevel, assetPath);
					variableCount += CPUHelpId_node_ProjectileLevel.SetData((FSCpuHelp)ProjectileLevel, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ItemId:
					FSItemNode ItemId_node_ProjectileLevel = graph.AddNode<FSItemNode>();
					GetPort("ProjectileLevel").Connect(ItemId_node_ProjectileLevel.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ItemId_node_ProjectileLevel, assetPath);
					variableCount += ItemId_node_ProjectileLevel.SetData((FSItem)ProjectileLevel, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ModeId:
					FSModeNode ModeId_node_ProjectileLevel = graph.AddNode<FSModeNode>();
					GetPort("ProjectileLevel").Connect(ModeId_node_ProjectileLevel.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ModeId_node_ProjectileLevel, assetPath);
					variableCount += ModeId_node_ProjectileLevel.SetData((FSMode)ProjectileLevel, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.JumpsId:
					FSJumpsNode JumpsId_node_ProjectileLevel = graph.AddNode<FSJumpsNode>();
					GetPort("ProjectileLevel").Connect(JumpsId_node_ProjectileLevel.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(JumpsId_node_ProjectileLevel, assetPath);
					variableCount += JumpsId_node_ProjectileLevel.SetData((FSJumps)ProjectileLevel, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RootAnimId:
					FSRootAnimNode RootAnimId_node_ProjectileLevel = graph.AddNode<FSRootAnimNode>();
					GetPort("ProjectileLevel").Connect(RootAnimId_node_ProjectileLevel.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RootAnimId_node_ProjectileLevel, assetPath);
					variableCount += RootAnimId_node_ProjectileLevel.SetData((FSRootAnim)ProjectileLevel, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FloatId:
					FSValueNode FloatId_node_ProjectileLevel = graph.AddNode<FSValueNode>();
					GetPort("ProjectileLevel").Connect(FloatId_node_ProjectileLevel.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FloatId_node_ProjectileLevel, assetPath);
					variableCount += FloatId_node_ProjectileLevel.SetData((FSValue)ProjectileLevel, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
			}
			++variableCount;
			
			Direction = data.Direction;
			
			switch (Direction.TID)
			{
				case FloatSource.TypeId.AgentId:
					FSAgentNode AgentId_node_Direction = graph.AddNode<FSAgentNode>();
					GetPort("Direction").Connect(AgentId_node_Direction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AgentId_node_Direction, assetPath);
					variableCount += AgentId_node_Direction.SetData((FSAgent)Direction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.BonesId:
					FSBonesNode BonesId_node_Direction = graph.AddNode<FSBonesNode>();
					GetPort("Direction").Connect(BonesId_node_Direction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BonesId_node_Direction, assetPath);
					variableCount += BonesId_node_Direction.SetData((FSBones)Direction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AttackId:
					FSAttackNode AttackId_node_Direction = graph.AddNode<FSAttackNode>();
					GetPort("Direction").Connect(AttackId_node_Direction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AttackId_node_Direction, assetPath);
					variableCount += AttackId_node_Direction.SetData((FSAttack)Direction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FrameId:
					FSFrameNode FrameId_node_Direction = graph.AddNode<FSFrameNode>();
					GetPort("Direction").Connect(FrameId_node_Direction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FrameId_node_Direction, assetPath);
					variableCount += FrameId_node_Direction.SetData((FSFrame)Direction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.InputId:
					FSInputNode InputId_node_Direction = graph.AddNode<FSInputNode>();
					GetPort("Direction").Connect(InputId_node_Direction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputId_node_Direction, assetPath);
					variableCount += InputId_node_Direction.SetData((FSInput)Direction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FuncId:
					FSFuncNode FuncId_node_Direction = graph.AddNode<FSFuncNode>();
					GetPort("Direction").Connect(FuncId_node_Direction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FuncId_node_Direction, assetPath);
					variableCount += FuncId_node_Direction.SetData((FSFunc)Direction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.MovementId:
					FSMovementNode MovementId_node_Direction = graph.AddNode<FSMovementNode>();
					GetPort("Direction").Connect(MovementId_node_Direction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(MovementId_node_Direction, assetPath);
					variableCount += MovementId_node_Direction.SetData((FSMovement)Direction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CombatId:
					FSCombatNode CombatId_node_Direction = graph.AddNode<FSCombatNode>();
					GetPort("Direction").Connect(CombatId_node_Direction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CombatId_node_Direction, assetPath);
					variableCount += CombatId_node_Direction.SetData((FSCombat)Direction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.GrabsId:
					FSGrabsNode GrabsId_node_Direction = graph.AddNode<FSGrabsNode>();
					GetPort("Direction").Connect(GrabsId_node_Direction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(GrabsId_node_Direction, assetPath);
					variableCount += GrabsId_node_Direction.SetData((FSGrabs)Direction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.DataId:
					FSDataNode DataId_node_Direction = graph.AddNode<FSDataNode>();
					GetPort("Direction").Connect(DataId_node_Direction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DataId_node_Direction, assetPath);
					variableCount += DataId_node_Direction.SetData((FSData)Direction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ScratchId:
					FSScratchNode ScratchId_node_Direction = graph.AddNode<FSScratchNode>();
					GetPort("Direction").Connect(ScratchId_node_Direction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ScratchId_node_Direction, assetPath);
					variableCount += ScratchId_node_Direction.SetData((FSScratch)Direction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AnimId:
					FSAnimNode AnimId_node_Direction = graph.AddNode<FSAnimNode>();
					GetPort("Direction").Connect(AnimId_node_Direction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AnimId_node_Direction, assetPath);
					variableCount += AnimId_node_Direction.SetData((FSAnim)Direction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SpeedId:
					FSSpeedNode SpeedId_node_Direction = graph.AddNode<FSSpeedNode>();
					GetPort("Direction").Connect(SpeedId_node_Direction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpeedId_node_Direction, assetPath);
					variableCount += SpeedId_node_Direction.SetData((FSSpeed)Direction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.PhysicsId:
					FSPhysicsNode PhysicsId_node_Direction = graph.AddNode<FSPhysicsNode>();
					GetPort("Direction").Connect(PhysicsId_node_Direction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(PhysicsId_node_Direction, assetPath);
					variableCount += PhysicsId_node_Direction.SetData((FSPhysics)Direction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CollisionId:
					FSCollisionNode CollisionId_node_Direction = graph.AddNode<FSCollisionNode>();
					GetPort("Direction").Connect(CollisionId_node_Direction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CollisionId_node_Direction, assetPath);
					variableCount += CollisionId_node_Direction.SetData((FSCollision)Direction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.TimerId:
					FSTimerNode TimerId_node_Direction = graph.AddNode<FSTimerNode>();
					GetPort("Direction").Connect(TimerId_node_Direction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(TimerId_node_Direction, assetPath);
					variableCount += TimerId_node_Direction.SetData((FSTimer)Direction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.LagId:
					FSLagNode LagId_node_Direction = graph.AddNode<FSLagNode>();
					GetPort("Direction").Connect(LagId_node_Direction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LagId_node_Direction, assetPath);
					variableCount += LagId_node_Direction.SetData((FSLag)Direction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.EffectsId:
					FSEffectsNode EffectsId_node_Direction = graph.AddNode<FSEffectsNode>();
					GetPort("Direction").Connect(EffectsId_node_Direction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EffectsId_node_Direction, assetPath);
					variableCount += EffectsId_node_Direction.SetData((FSEffects)Direction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ColorsId:
					FSColorsNode ColorsId_node_Direction = graph.AddNode<FSColorsNode>();
					GetPort("Direction").Connect(ColorsId_node_Direction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ColorsId_node_Direction, assetPath);
					variableCount += ColorsId_node_Direction.SetData((FSColors)Direction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.OnHitId:
					FSOnHitNode OnHitId_node_Direction = graph.AddNode<FSOnHitNode>();
					GetPort("Direction").Connect(OnHitId_node_Direction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnHitId_node_Direction, assetPath);
					variableCount += OnHitId_node_Direction.SetData((FSOnHit)Direction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RandomId:
					FSRandomNode RandomId_node_Direction = graph.AddNode<FSRandomNode>();
					GetPort("Direction").Connect(RandomId_node_Direction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RandomId_node_Direction, assetPath);
					variableCount += RandomId_node_Direction.SetData((FSRandom)Direction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CameraId:
					FSCameraInfoNode CameraId_node_Direction = graph.AddNode<FSCameraInfoNode>();
					GetPort("Direction").Connect(CameraId_node_Direction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CameraId_node_Direction, assetPath);
					variableCount += CameraId_node_Direction.SetData((FSCameraInfo)Direction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SportsId:
					FSSportsNode SportsId_node_Direction = graph.AddNode<FSSportsNode>();
					GetPort("Direction").Connect(SportsId_node_Direction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SportsId_node_Direction, assetPath);
					variableCount += SportsId_node_Direction.SetData((FSSports)Direction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.Vector2Mag:
					FSVector2MagNode Vector2Mag_node_Direction = graph.AddNode<FSVector2MagNode>();
					GetPort("Direction").Connect(Vector2Mag_node_Direction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(Vector2Mag_node_Direction, assetPath);
					variableCount += Vector2Mag_node_Direction.SetData((FSVector2Mag)Direction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CPUHelpId:
					FSCpuHelpNode CPUHelpId_node_Direction = graph.AddNode<FSCpuHelpNode>();
					GetPort("Direction").Connect(CPUHelpId_node_Direction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CPUHelpId_node_Direction, assetPath);
					variableCount += CPUHelpId_node_Direction.SetData((FSCpuHelp)Direction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ItemId:
					FSItemNode ItemId_node_Direction = graph.AddNode<FSItemNode>();
					GetPort("Direction").Connect(ItemId_node_Direction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ItemId_node_Direction, assetPath);
					variableCount += ItemId_node_Direction.SetData((FSItem)Direction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ModeId:
					FSModeNode ModeId_node_Direction = graph.AddNode<FSModeNode>();
					GetPort("Direction").Connect(ModeId_node_Direction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ModeId_node_Direction, assetPath);
					variableCount += ModeId_node_Direction.SetData((FSMode)Direction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.JumpsId:
					FSJumpsNode JumpsId_node_Direction = graph.AddNode<FSJumpsNode>();
					GetPort("Direction").Connect(JumpsId_node_Direction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(JumpsId_node_Direction, assetPath);
					variableCount += JumpsId_node_Direction.SetData((FSJumps)Direction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RootAnimId:
					FSRootAnimNode RootAnimId_node_Direction = graph.AddNode<FSRootAnimNode>();
					GetPort("Direction").Connect(RootAnimId_node_Direction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RootAnimId_node_Direction, assetPath);
					variableCount += RootAnimId_node_Direction.SetData((FSRootAnim)Direction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FloatId:
					FSValueNode FloatId_node_Direction = graph.AddNode<FSValueNode>();
					GetPort("Direction").Connect(FloatId_node_Direction.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FloatId_node_Direction, assetPath);
					variableCount += FloatId_node_Direction.SetData((FSValue)Direction, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
			}
			++variableCount;
			
			RedirectX = data.RedirectX;
			
			switch (RedirectX.TID)
			{
				case FloatSource.TypeId.AgentId:
					FSAgentNode AgentId_node_RedirectX = graph.AddNode<FSAgentNode>();
					GetPort("RedirectX").Connect(AgentId_node_RedirectX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AgentId_node_RedirectX, assetPath);
					variableCount += AgentId_node_RedirectX.SetData((FSAgent)RedirectX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.BonesId:
					FSBonesNode BonesId_node_RedirectX = graph.AddNode<FSBonesNode>();
					GetPort("RedirectX").Connect(BonesId_node_RedirectX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BonesId_node_RedirectX, assetPath);
					variableCount += BonesId_node_RedirectX.SetData((FSBones)RedirectX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AttackId:
					FSAttackNode AttackId_node_RedirectX = graph.AddNode<FSAttackNode>();
					GetPort("RedirectX").Connect(AttackId_node_RedirectX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AttackId_node_RedirectX, assetPath);
					variableCount += AttackId_node_RedirectX.SetData((FSAttack)RedirectX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FrameId:
					FSFrameNode FrameId_node_RedirectX = graph.AddNode<FSFrameNode>();
					GetPort("RedirectX").Connect(FrameId_node_RedirectX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FrameId_node_RedirectX, assetPath);
					variableCount += FrameId_node_RedirectX.SetData((FSFrame)RedirectX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.InputId:
					FSInputNode InputId_node_RedirectX = graph.AddNode<FSInputNode>();
					GetPort("RedirectX").Connect(InputId_node_RedirectX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputId_node_RedirectX, assetPath);
					variableCount += InputId_node_RedirectX.SetData((FSInput)RedirectX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FuncId:
					FSFuncNode FuncId_node_RedirectX = graph.AddNode<FSFuncNode>();
					GetPort("RedirectX").Connect(FuncId_node_RedirectX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FuncId_node_RedirectX, assetPath);
					variableCount += FuncId_node_RedirectX.SetData((FSFunc)RedirectX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.MovementId:
					FSMovementNode MovementId_node_RedirectX = graph.AddNode<FSMovementNode>();
					GetPort("RedirectX").Connect(MovementId_node_RedirectX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(MovementId_node_RedirectX, assetPath);
					variableCount += MovementId_node_RedirectX.SetData((FSMovement)RedirectX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CombatId:
					FSCombatNode CombatId_node_RedirectX = graph.AddNode<FSCombatNode>();
					GetPort("RedirectX").Connect(CombatId_node_RedirectX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CombatId_node_RedirectX, assetPath);
					variableCount += CombatId_node_RedirectX.SetData((FSCombat)RedirectX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.GrabsId:
					FSGrabsNode GrabsId_node_RedirectX = graph.AddNode<FSGrabsNode>();
					GetPort("RedirectX").Connect(GrabsId_node_RedirectX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(GrabsId_node_RedirectX, assetPath);
					variableCount += GrabsId_node_RedirectX.SetData((FSGrabs)RedirectX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.DataId:
					FSDataNode DataId_node_RedirectX = graph.AddNode<FSDataNode>();
					GetPort("RedirectX").Connect(DataId_node_RedirectX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DataId_node_RedirectX, assetPath);
					variableCount += DataId_node_RedirectX.SetData((FSData)RedirectX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ScratchId:
					FSScratchNode ScratchId_node_RedirectX = graph.AddNode<FSScratchNode>();
					GetPort("RedirectX").Connect(ScratchId_node_RedirectX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ScratchId_node_RedirectX, assetPath);
					variableCount += ScratchId_node_RedirectX.SetData((FSScratch)RedirectX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AnimId:
					FSAnimNode AnimId_node_RedirectX = graph.AddNode<FSAnimNode>();
					GetPort("RedirectX").Connect(AnimId_node_RedirectX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AnimId_node_RedirectX, assetPath);
					variableCount += AnimId_node_RedirectX.SetData((FSAnim)RedirectX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SpeedId:
					FSSpeedNode SpeedId_node_RedirectX = graph.AddNode<FSSpeedNode>();
					GetPort("RedirectX").Connect(SpeedId_node_RedirectX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpeedId_node_RedirectX, assetPath);
					variableCount += SpeedId_node_RedirectX.SetData((FSSpeed)RedirectX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.PhysicsId:
					FSPhysicsNode PhysicsId_node_RedirectX = graph.AddNode<FSPhysicsNode>();
					GetPort("RedirectX").Connect(PhysicsId_node_RedirectX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(PhysicsId_node_RedirectX, assetPath);
					variableCount += PhysicsId_node_RedirectX.SetData((FSPhysics)RedirectX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CollisionId:
					FSCollisionNode CollisionId_node_RedirectX = graph.AddNode<FSCollisionNode>();
					GetPort("RedirectX").Connect(CollisionId_node_RedirectX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CollisionId_node_RedirectX, assetPath);
					variableCount += CollisionId_node_RedirectX.SetData((FSCollision)RedirectX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.TimerId:
					FSTimerNode TimerId_node_RedirectX = graph.AddNode<FSTimerNode>();
					GetPort("RedirectX").Connect(TimerId_node_RedirectX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(TimerId_node_RedirectX, assetPath);
					variableCount += TimerId_node_RedirectX.SetData((FSTimer)RedirectX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.LagId:
					FSLagNode LagId_node_RedirectX = graph.AddNode<FSLagNode>();
					GetPort("RedirectX").Connect(LagId_node_RedirectX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LagId_node_RedirectX, assetPath);
					variableCount += LagId_node_RedirectX.SetData((FSLag)RedirectX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.EffectsId:
					FSEffectsNode EffectsId_node_RedirectX = graph.AddNode<FSEffectsNode>();
					GetPort("RedirectX").Connect(EffectsId_node_RedirectX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EffectsId_node_RedirectX, assetPath);
					variableCount += EffectsId_node_RedirectX.SetData((FSEffects)RedirectX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ColorsId:
					FSColorsNode ColorsId_node_RedirectX = graph.AddNode<FSColorsNode>();
					GetPort("RedirectX").Connect(ColorsId_node_RedirectX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ColorsId_node_RedirectX, assetPath);
					variableCount += ColorsId_node_RedirectX.SetData((FSColors)RedirectX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.OnHitId:
					FSOnHitNode OnHitId_node_RedirectX = graph.AddNode<FSOnHitNode>();
					GetPort("RedirectX").Connect(OnHitId_node_RedirectX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnHitId_node_RedirectX, assetPath);
					variableCount += OnHitId_node_RedirectX.SetData((FSOnHit)RedirectX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RandomId:
					FSRandomNode RandomId_node_RedirectX = graph.AddNode<FSRandomNode>();
					GetPort("RedirectX").Connect(RandomId_node_RedirectX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RandomId_node_RedirectX, assetPath);
					variableCount += RandomId_node_RedirectX.SetData((FSRandom)RedirectX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CameraId:
					FSCameraInfoNode CameraId_node_RedirectX = graph.AddNode<FSCameraInfoNode>();
					GetPort("RedirectX").Connect(CameraId_node_RedirectX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CameraId_node_RedirectX, assetPath);
					variableCount += CameraId_node_RedirectX.SetData((FSCameraInfo)RedirectX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SportsId:
					FSSportsNode SportsId_node_RedirectX = graph.AddNode<FSSportsNode>();
					GetPort("RedirectX").Connect(SportsId_node_RedirectX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SportsId_node_RedirectX, assetPath);
					variableCount += SportsId_node_RedirectX.SetData((FSSports)RedirectX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.Vector2Mag:
					FSVector2MagNode Vector2Mag_node_RedirectX = graph.AddNode<FSVector2MagNode>();
					GetPort("RedirectX").Connect(Vector2Mag_node_RedirectX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(Vector2Mag_node_RedirectX, assetPath);
					variableCount += Vector2Mag_node_RedirectX.SetData((FSVector2Mag)RedirectX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CPUHelpId:
					FSCpuHelpNode CPUHelpId_node_RedirectX = graph.AddNode<FSCpuHelpNode>();
					GetPort("RedirectX").Connect(CPUHelpId_node_RedirectX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CPUHelpId_node_RedirectX, assetPath);
					variableCount += CPUHelpId_node_RedirectX.SetData((FSCpuHelp)RedirectX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ItemId:
					FSItemNode ItemId_node_RedirectX = graph.AddNode<FSItemNode>();
					GetPort("RedirectX").Connect(ItemId_node_RedirectX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ItemId_node_RedirectX, assetPath);
					variableCount += ItemId_node_RedirectX.SetData((FSItem)RedirectX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ModeId:
					FSModeNode ModeId_node_RedirectX = graph.AddNode<FSModeNode>();
					GetPort("RedirectX").Connect(ModeId_node_RedirectX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ModeId_node_RedirectX, assetPath);
					variableCount += ModeId_node_RedirectX.SetData((FSMode)RedirectX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.JumpsId:
					FSJumpsNode JumpsId_node_RedirectX = graph.AddNode<FSJumpsNode>();
					GetPort("RedirectX").Connect(JumpsId_node_RedirectX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(JumpsId_node_RedirectX, assetPath);
					variableCount += JumpsId_node_RedirectX.SetData((FSJumps)RedirectX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RootAnimId:
					FSRootAnimNode RootAnimId_node_RedirectX = graph.AddNode<FSRootAnimNode>();
					GetPort("RedirectX").Connect(RootAnimId_node_RedirectX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RootAnimId_node_RedirectX, assetPath);
					variableCount += RootAnimId_node_RedirectX.SetData((FSRootAnim)RedirectX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FloatId:
					FSValueNode FloatId_node_RedirectX = graph.AddNode<FSValueNode>();
					GetPort("RedirectX").Connect(FloatId_node_RedirectX.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FloatId_node_RedirectX, assetPath);
					variableCount += FloatId_node_RedirectX.SetData((FSValue)RedirectX, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
			}
			++variableCount;
			
			RedirectY = data.RedirectY;
			
			switch (RedirectY.TID)
			{
				case FloatSource.TypeId.AgentId:
					FSAgentNode AgentId_node_RedirectY = graph.AddNode<FSAgentNode>();
					GetPort("RedirectY").Connect(AgentId_node_RedirectY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AgentId_node_RedirectY, assetPath);
					variableCount += AgentId_node_RedirectY.SetData((FSAgent)RedirectY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.BonesId:
					FSBonesNode BonesId_node_RedirectY = graph.AddNode<FSBonesNode>();
					GetPort("RedirectY").Connect(BonesId_node_RedirectY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BonesId_node_RedirectY, assetPath);
					variableCount += BonesId_node_RedirectY.SetData((FSBones)RedirectY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AttackId:
					FSAttackNode AttackId_node_RedirectY = graph.AddNode<FSAttackNode>();
					GetPort("RedirectY").Connect(AttackId_node_RedirectY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AttackId_node_RedirectY, assetPath);
					variableCount += AttackId_node_RedirectY.SetData((FSAttack)RedirectY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FrameId:
					FSFrameNode FrameId_node_RedirectY = graph.AddNode<FSFrameNode>();
					GetPort("RedirectY").Connect(FrameId_node_RedirectY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FrameId_node_RedirectY, assetPath);
					variableCount += FrameId_node_RedirectY.SetData((FSFrame)RedirectY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.InputId:
					FSInputNode InputId_node_RedirectY = graph.AddNode<FSInputNode>();
					GetPort("RedirectY").Connect(InputId_node_RedirectY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputId_node_RedirectY, assetPath);
					variableCount += InputId_node_RedirectY.SetData((FSInput)RedirectY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FuncId:
					FSFuncNode FuncId_node_RedirectY = graph.AddNode<FSFuncNode>();
					GetPort("RedirectY").Connect(FuncId_node_RedirectY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FuncId_node_RedirectY, assetPath);
					variableCount += FuncId_node_RedirectY.SetData((FSFunc)RedirectY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.MovementId:
					FSMovementNode MovementId_node_RedirectY = graph.AddNode<FSMovementNode>();
					GetPort("RedirectY").Connect(MovementId_node_RedirectY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(MovementId_node_RedirectY, assetPath);
					variableCount += MovementId_node_RedirectY.SetData((FSMovement)RedirectY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CombatId:
					FSCombatNode CombatId_node_RedirectY = graph.AddNode<FSCombatNode>();
					GetPort("RedirectY").Connect(CombatId_node_RedirectY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CombatId_node_RedirectY, assetPath);
					variableCount += CombatId_node_RedirectY.SetData((FSCombat)RedirectY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.GrabsId:
					FSGrabsNode GrabsId_node_RedirectY = graph.AddNode<FSGrabsNode>();
					GetPort("RedirectY").Connect(GrabsId_node_RedirectY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(GrabsId_node_RedirectY, assetPath);
					variableCount += GrabsId_node_RedirectY.SetData((FSGrabs)RedirectY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.DataId:
					FSDataNode DataId_node_RedirectY = graph.AddNode<FSDataNode>();
					GetPort("RedirectY").Connect(DataId_node_RedirectY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DataId_node_RedirectY, assetPath);
					variableCount += DataId_node_RedirectY.SetData((FSData)RedirectY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ScratchId:
					FSScratchNode ScratchId_node_RedirectY = graph.AddNode<FSScratchNode>();
					GetPort("RedirectY").Connect(ScratchId_node_RedirectY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ScratchId_node_RedirectY, assetPath);
					variableCount += ScratchId_node_RedirectY.SetData((FSScratch)RedirectY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AnimId:
					FSAnimNode AnimId_node_RedirectY = graph.AddNode<FSAnimNode>();
					GetPort("RedirectY").Connect(AnimId_node_RedirectY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AnimId_node_RedirectY, assetPath);
					variableCount += AnimId_node_RedirectY.SetData((FSAnim)RedirectY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SpeedId:
					FSSpeedNode SpeedId_node_RedirectY = graph.AddNode<FSSpeedNode>();
					GetPort("RedirectY").Connect(SpeedId_node_RedirectY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpeedId_node_RedirectY, assetPath);
					variableCount += SpeedId_node_RedirectY.SetData((FSSpeed)RedirectY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.PhysicsId:
					FSPhysicsNode PhysicsId_node_RedirectY = graph.AddNode<FSPhysicsNode>();
					GetPort("RedirectY").Connect(PhysicsId_node_RedirectY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(PhysicsId_node_RedirectY, assetPath);
					variableCount += PhysicsId_node_RedirectY.SetData((FSPhysics)RedirectY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CollisionId:
					FSCollisionNode CollisionId_node_RedirectY = graph.AddNode<FSCollisionNode>();
					GetPort("RedirectY").Connect(CollisionId_node_RedirectY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CollisionId_node_RedirectY, assetPath);
					variableCount += CollisionId_node_RedirectY.SetData((FSCollision)RedirectY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.TimerId:
					FSTimerNode TimerId_node_RedirectY = graph.AddNode<FSTimerNode>();
					GetPort("RedirectY").Connect(TimerId_node_RedirectY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(TimerId_node_RedirectY, assetPath);
					variableCount += TimerId_node_RedirectY.SetData((FSTimer)RedirectY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.LagId:
					FSLagNode LagId_node_RedirectY = graph.AddNode<FSLagNode>();
					GetPort("RedirectY").Connect(LagId_node_RedirectY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LagId_node_RedirectY, assetPath);
					variableCount += LagId_node_RedirectY.SetData((FSLag)RedirectY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.EffectsId:
					FSEffectsNode EffectsId_node_RedirectY = graph.AddNode<FSEffectsNode>();
					GetPort("RedirectY").Connect(EffectsId_node_RedirectY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EffectsId_node_RedirectY, assetPath);
					variableCount += EffectsId_node_RedirectY.SetData((FSEffects)RedirectY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ColorsId:
					FSColorsNode ColorsId_node_RedirectY = graph.AddNode<FSColorsNode>();
					GetPort("RedirectY").Connect(ColorsId_node_RedirectY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ColorsId_node_RedirectY, assetPath);
					variableCount += ColorsId_node_RedirectY.SetData((FSColors)RedirectY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.OnHitId:
					FSOnHitNode OnHitId_node_RedirectY = graph.AddNode<FSOnHitNode>();
					GetPort("RedirectY").Connect(OnHitId_node_RedirectY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnHitId_node_RedirectY, assetPath);
					variableCount += OnHitId_node_RedirectY.SetData((FSOnHit)RedirectY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RandomId:
					FSRandomNode RandomId_node_RedirectY = graph.AddNode<FSRandomNode>();
					GetPort("RedirectY").Connect(RandomId_node_RedirectY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RandomId_node_RedirectY, assetPath);
					variableCount += RandomId_node_RedirectY.SetData((FSRandom)RedirectY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CameraId:
					FSCameraInfoNode CameraId_node_RedirectY = graph.AddNode<FSCameraInfoNode>();
					GetPort("RedirectY").Connect(CameraId_node_RedirectY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CameraId_node_RedirectY, assetPath);
					variableCount += CameraId_node_RedirectY.SetData((FSCameraInfo)RedirectY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SportsId:
					FSSportsNode SportsId_node_RedirectY = graph.AddNode<FSSportsNode>();
					GetPort("RedirectY").Connect(SportsId_node_RedirectY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SportsId_node_RedirectY, assetPath);
					variableCount += SportsId_node_RedirectY.SetData((FSSports)RedirectY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.Vector2Mag:
					FSVector2MagNode Vector2Mag_node_RedirectY = graph.AddNode<FSVector2MagNode>();
					GetPort("RedirectY").Connect(Vector2Mag_node_RedirectY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(Vector2Mag_node_RedirectY, assetPath);
					variableCount += Vector2Mag_node_RedirectY.SetData((FSVector2Mag)RedirectY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CPUHelpId:
					FSCpuHelpNode CPUHelpId_node_RedirectY = graph.AddNode<FSCpuHelpNode>();
					GetPort("RedirectY").Connect(CPUHelpId_node_RedirectY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CPUHelpId_node_RedirectY, assetPath);
					variableCount += CPUHelpId_node_RedirectY.SetData((FSCpuHelp)RedirectY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ItemId:
					FSItemNode ItemId_node_RedirectY = graph.AddNode<FSItemNode>();
					GetPort("RedirectY").Connect(ItemId_node_RedirectY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ItemId_node_RedirectY, assetPath);
					variableCount += ItemId_node_RedirectY.SetData((FSItem)RedirectY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ModeId:
					FSModeNode ModeId_node_RedirectY = graph.AddNode<FSModeNode>();
					GetPort("RedirectY").Connect(ModeId_node_RedirectY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ModeId_node_RedirectY, assetPath);
					variableCount += ModeId_node_RedirectY.SetData((FSMode)RedirectY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.JumpsId:
					FSJumpsNode JumpsId_node_RedirectY = graph.AddNode<FSJumpsNode>();
					GetPort("RedirectY").Connect(JumpsId_node_RedirectY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(JumpsId_node_RedirectY, assetPath);
					variableCount += JumpsId_node_RedirectY.SetData((FSJumps)RedirectY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RootAnimId:
					FSRootAnimNode RootAnimId_node_RedirectY = graph.AddNode<FSRootAnimNode>();
					GetPort("RedirectY").Connect(RootAnimId_node_RedirectY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RootAnimId_node_RedirectY, assetPath);
					variableCount += RootAnimId_node_RedirectY.SetData((FSRootAnim)RedirectY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FloatId:
					FSValueNode FloatId_node_RedirectY = graph.AddNode<FSValueNode>();
					GetPort("RedirectY").Connect(FloatId_node_RedirectY.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FloatId_node_RedirectY, assetPath);
					variableCount += FloatId_node_RedirectY.SetData((FSValue)RedirectY, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
			}
			++variableCount;
			
			ExactSpawn = data.ExactSpawn;
			AddedSpawns = data.AddedSpawns;
			
			foreach (SASpawnAgent2.AddedSpawnData AddedSpawns_item in AddedSpawns)
			{
				SASpawnAgent2_AddedSpawnDataNode node_AddedSpawns = graph.AddNode<SASpawnAgent2_AddedSpawnDataNode>();
				GetPort("AddedSpawns").Connect(node_AddedSpawns.GetPort("NodeInput"));
				AssetDatabase.AddObjectToAsset(node_AddedSpawns, assetPath);
				variableCount += node_AddedSpawns.SetData(AddedSpawns_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				++variableCount;
			}
			return variableCount;
		}
		
		public new SASpawnAgent2 GetData()
		{
			SASpawnAgent2 objToReturn = new SASpawnAgent2();
			objToReturn.TID = TypeId.SpawnAgent2Id;
			objToReturn.Version = Version;
			objToReturn.Bank = Bank;
			objToReturn.Id = Id;
			objToReturn.Bone = Bone;
			objToReturn.LocalOffset = LocalOffset;
			objToReturn.WorldOffset = WorldOffset;
			objToReturn.CustomSpawnMovement = CustomSpawnMovement;
			foreach(NodePort port in GetPort("Movements").GetConnections())
			{
				SpawnMovementNode SpawnMovement_Node = (SpawnMovementNode)port.node;
				objToReturn.Movements.Add(SpawnMovement_Node.GetData());
			}
			objToReturn.SpawnedAgentDataId = SpawnedAgentDataId;
			if (GetPort("SpawnedAgentDataSetValue").ConnectionCount > 0)
			{
				FloatSourceNode FloatSource_Node = (FloatSourceNode)GetPort("SpawnedAgentDataSetValue").GetConnection(0).node;
				switch (FloatSource_Node.TID)
				{
					case FloatSource.TypeId.AgentId:
						FSAgentNode AgentId_FloatSource_Node = (FSAgentNode)GetPort("SpawnedAgentDataSetValue").GetConnection(0).node;
						objToReturn.SpawnedAgentDataSetValue = AgentId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.BonesId:
						FSBonesNode BonesId_FloatSource_Node = (FSBonesNode)GetPort("SpawnedAgentDataSetValue").GetConnection(0).node;
						objToReturn.SpawnedAgentDataSetValue = BonesId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AttackId:
						FSAttackNode AttackId_FloatSource_Node = (FSAttackNode)GetPort("SpawnedAgentDataSetValue").GetConnection(0).node;
						objToReturn.SpawnedAgentDataSetValue = AttackId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FrameId:
						FSFrameNode FrameId_FloatSource_Node = (FSFrameNode)GetPort("SpawnedAgentDataSetValue").GetConnection(0).node;
						objToReturn.SpawnedAgentDataSetValue = FrameId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.InputId:
						FSInputNode InputId_FloatSource_Node = (FSInputNode)GetPort("SpawnedAgentDataSetValue").GetConnection(0).node;
						objToReturn.SpawnedAgentDataSetValue = InputId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FuncId:
						FSFuncNode FuncId_FloatSource_Node = (FSFuncNode)GetPort("SpawnedAgentDataSetValue").GetConnection(0).node;
						objToReturn.SpawnedAgentDataSetValue = FuncId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.MovementId:
						FSMovementNode MovementId_FloatSource_Node = (FSMovementNode)GetPort("SpawnedAgentDataSetValue").GetConnection(0).node;
						objToReturn.SpawnedAgentDataSetValue = MovementId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CombatId:
						FSCombatNode CombatId_FloatSource_Node = (FSCombatNode)GetPort("SpawnedAgentDataSetValue").GetConnection(0).node;
						objToReturn.SpawnedAgentDataSetValue = CombatId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.GrabsId:
						FSGrabsNode GrabsId_FloatSource_Node = (FSGrabsNode)GetPort("SpawnedAgentDataSetValue").GetConnection(0).node;
						objToReturn.SpawnedAgentDataSetValue = GrabsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.DataId:
						FSDataNode DataId_FloatSource_Node = (FSDataNode)GetPort("SpawnedAgentDataSetValue").GetConnection(0).node;
						objToReturn.SpawnedAgentDataSetValue = DataId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ScratchId:
						FSScratchNode ScratchId_FloatSource_Node = (FSScratchNode)GetPort("SpawnedAgentDataSetValue").GetConnection(0).node;
						objToReturn.SpawnedAgentDataSetValue = ScratchId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AnimId:
						FSAnimNode AnimId_FloatSource_Node = (FSAnimNode)GetPort("SpawnedAgentDataSetValue").GetConnection(0).node;
						objToReturn.SpawnedAgentDataSetValue = AnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SpeedId:
						FSSpeedNode SpeedId_FloatSource_Node = (FSSpeedNode)GetPort("SpawnedAgentDataSetValue").GetConnection(0).node;
						objToReturn.SpawnedAgentDataSetValue = SpeedId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.PhysicsId:
						FSPhysicsNode PhysicsId_FloatSource_Node = (FSPhysicsNode)GetPort("SpawnedAgentDataSetValue").GetConnection(0).node;
						objToReturn.SpawnedAgentDataSetValue = PhysicsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CollisionId:
						FSCollisionNode CollisionId_FloatSource_Node = (FSCollisionNode)GetPort("SpawnedAgentDataSetValue").GetConnection(0).node;
						objToReturn.SpawnedAgentDataSetValue = CollisionId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.TimerId:
						FSTimerNode TimerId_FloatSource_Node = (FSTimerNode)GetPort("SpawnedAgentDataSetValue").GetConnection(0).node;
						objToReturn.SpawnedAgentDataSetValue = TimerId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.LagId:
						FSLagNode LagId_FloatSource_Node = (FSLagNode)GetPort("SpawnedAgentDataSetValue").GetConnection(0).node;
						objToReturn.SpawnedAgentDataSetValue = LagId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.EffectsId:
						FSEffectsNode EffectsId_FloatSource_Node = (FSEffectsNode)GetPort("SpawnedAgentDataSetValue").GetConnection(0).node;
						objToReturn.SpawnedAgentDataSetValue = EffectsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ColorsId:
						FSColorsNode ColorsId_FloatSource_Node = (FSColorsNode)GetPort("SpawnedAgentDataSetValue").GetConnection(0).node;
						objToReturn.SpawnedAgentDataSetValue = ColorsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.OnHitId:
						FSOnHitNode OnHitId_FloatSource_Node = (FSOnHitNode)GetPort("SpawnedAgentDataSetValue").GetConnection(0).node;
						objToReturn.SpawnedAgentDataSetValue = OnHitId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RandomId:
						FSRandomNode RandomId_FloatSource_Node = (FSRandomNode)GetPort("SpawnedAgentDataSetValue").GetConnection(0).node;
						objToReturn.SpawnedAgentDataSetValue = RandomId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CameraId:
						FSCameraInfoNode CameraId_FloatSource_Node = (FSCameraInfoNode)GetPort("SpawnedAgentDataSetValue").GetConnection(0).node;
						objToReturn.SpawnedAgentDataSetValue = CameraId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SportsId:
						FSSportsNode SportsId_FloatSource_Node = (FSSportsNode)GetPort("SpawnedAgentDataSetValue").GetConnection(0).node;
						objToReturn.SpawnedAgentDataSetValue = SportsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.Vector2Mag:
						FSVector2MagNode Vector2Mag_FloatSource_Node = (FSVector2MagNode)GetPort("SpawnedAgentDataSetValue").GetConnection(0).node;
						objToReturn.SpawnedAgentDataSetValue = Vector2Mag_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CPUHelpId:
						FSCpuHelpNode CPUHelpId_FloatSource_Node = (FSCpuHelpNode)GetPort("SpawnedAgentDataSetValue").GetConnection(0).node;
						objToReturn.SpawnedAgentDataSetValue = CPUHelpId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ItemId:
						FSItemNode ItemId_FloatSource_Node = (FSItemNode)GetPort("SpawnedAgentDataSetValue").GetConnection(0).node;
						objToReturn.SpawnedAgentDataSetValue = ItemId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ModeId:
						FSModeNode ModeId_FloatSource_Node = (FSModeNode)GetPort("SpawnedAgentDataSetValue").GetConnection(0).node;
						objToReturn.SpawnedAgentDataSetValue = ModeId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.JumpsId:
						FSJumpsNode JumpsId_FloatSource_Node = (FSJumpsNode)GetPort("SpawnedAgentDataSetValue").GetConnection(0).node;
						objToReturn.SpawnedAgentDataSetValue = JumpsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RootAnimId:
						FSRootAnimNode RootAnimId_FloatSource_Node = (FSRootAnimNode)GetPort("SpawnedAgentDataSetValue").GetConnection(0).node;
						objToReturn.SpawnedAgentDataSetValue = RootAnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FloatId:
						FSValueNode FloatId_FloatSource_Node = (FSValueNode)GetPort("SpawnedAgentDataSetValue").GetConnection(0).node;
						objToReturn.SpawnedAgentDataSetValue = FloatId_FloatSource_Node.GetData();
					break;
				}
			}
			if (GetPort("ResultOrderAdded").ConnectionCount > 0)
			{
				FloatSourceNode FloatSource_Node = (FloatSourceNode)GetPort("ResultOrderAdded").GetConnection(0).node;
				switch (FloatSource_Node.TID)
				{
					case FloatSource.TypeId.AgentId:
						FSAgentNode AgentId_FloatSource_Node = (FSAgentNode)GetPort("ResultOrderAdded").GetConnection(0).node;
						objToReturn.ResultOrderAdded = AgentId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.BonesId:
						FSBonesNode BonesId_FloatSource_Node = (FSBonesNode)GetPort("ResultOrderAdded").GetConnection(0).node;
						objToReturn.ResultOrderAdded = BonesId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AttackId:
						FSAttackNode AttackId_FloatSource_Node = (FSAttackNode)GetPort("ResultOrderAdded").GetConnection(0).node;
						objToReturn.ResultOrderAdded = AttackId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FrameId:
						FSFrameNode FrameId_FloatSource_Node = (FSFrameNode)GetPort("ResultOrderAdded").GetConnection(0).node;
						objToReturn.ResultOrderAdded = FrameId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.InputId:
						FSInputNode InputId_FloatSource_Node = (FSInputNode)GetPort("ResultOrderAdded").GetConnection(0).node;
						objToReturn.ResultOrderAdded = InputId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FuncId:
						FSFuncNode FuncId_FloatSource_Node = (FSFuncNode)GetPort("ResultOrderAdded").GetConnection(0).node;
						objToReturn.ResultOrderAdded = FuncId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.MovementId:
						FSMovementNode MovementId_FloatSource_Node = (FSMovementNode)GetPort("ResultOrderAdded").GetConnection(0).node;
						objToReturn.ResultOrderAdded = MovementId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CombatId:
						FSCombatNode CombatId_FloatSource_Node = (FSCombatNode)GetPort("ResultOrderAdded").GetConnection(0).node;
						objToReturn.ResultOrderAdded = CombatId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.GrabsId:
						FSGrabsNode GrabsId_FloatSource_Node = (FSGrabsNode)GetPort("ResultOrderAdded").GetConnection(0).node;
						objToReturn.ResultOrderAdded = GrabsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.DataId:
						FSDataNode DataId_FloatSource_Node = (FSDataNode)GetPort("ResultOrderAdded").GetConnection(0).node;
						objToReturn.ResultOrderAdded = DataId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ScratchId:
						FSScratchNode ScratchId_FloatSource_Node = (FSScratchNode)GetPort("ResultOrderAdded").GetConnection(0).node;
						objToReturn.ResultOrderAdded = ScratchId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AnimId:
						FSAnimNode AnimId_FloatSource_Node = (FSAnimNode)GetPort("ResultOrderAdded").GetConnection(0).node;
						objToReturn.ResultOrderAdded = AnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SpeedId:
						FSSpeedNode SpeedId_FloatSource_Node = (FSSpeedNode)GetPort("ResultOrderAdded").GetConnection(0).node;
						objToReturn.ResultOrderAdded = SpeedId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.PhysicsId:
						FSPhysicsNode PhysicsId_FloatSource_Node = (FSPhysicsNode)GetPort("ResultOrderAdded").GetConnection(0).node;
						objToReturn.ResultOrderAdded = PhysicsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CollisionId:
						FSCollisionNode CollisionId_FloatSource_Node = (FSCollisionNode)GetPort("ResultOrderAdded").GetConnection(0).node;
						objToReturn.ResultOrderAdded = CollisionId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.TimerId:
						FSTimerNode TimerId_FloatSource_Node = (FSTimerNode)GetPort("ResultOrderAdded").GetConnection(0).node;
						objToReturn.ResultOrderAdded = TimerId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.LagId:
						FSLagNode LagId_FloatSource_Node = (FSLagNode)GetPort("ResultOrderAdded").GetConnection(0).node;
						objToReturn.ResultOrderAdded = LagId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.EffectsId:
						FSEffectsNode EffectsId_FloatSource_Node = (FSEffectsNode)GetPort("ResultOrderAdded").GetConnection(0).node;
						objToReturn.ResultOrderAdded = EffectsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ColorsId:
						FSColorsNode ColorsId_FloatSource_Node = (FSColorsNode)GetPort("ResultOrderAdded").GetConnection(0).node;
						objToReturn.ResultOrderAdded = ColorsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.OnHitId:
						FSOnHitNode OnHitId_FloatSource_Node = (FSOnHitNode)GetPort("ResultOrderAdded").GetConnection(0).node;
						objToReturn.ResultOrderAdded = OnHitId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RandomId:
						FSRandomNode RandomId_FloatSource_Node = (FSRandomNode)GetPort("ResultOrderAdded").GetConnection(0).node;
						objToReturn.ResultOrderAdded = RandomId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CameraId:
						FSCameraInfoNode CameraId_FloatSource_Node = (FSCameraInfoNode)GetPort("ResultOrderAdded").GetConnection(0).node;
						objToReturn.ResultOrderAdded = CameraId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SportsId:
						FSSportsNode SportsId_FloatSource_Node = (FSSportsNode)GetPort("ResultOrderAdded").GetConnection(0).node;
						objToReturn.ResultOrderAdded = SportsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.Vector2Mag:
						FSVector2MagNode Vector2Mag_FloatSource_Node = (FSVector2MagNode)GetPort("ResultOrderAdded").GetConnection(0).node;
						objToReturn.ResultOrderAdded = Vector2Mag_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CPUHelpId:
						FSCpuHelpNode CPUHelpId_FloatSource_Node = (FSCpuHelpNode)GetPort("ResultOrderAdded").GetConnection(0).node;
						objToReturn.ResultOrderAdded = CPUHelpId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ItemId:
						FSItemNode ItemId_FloatSource_Node = (FSItemNode)GetPort("ResultOrderAdded").GetConnection(0).node;
						objToReturn.ResultOrderAdded = ItemId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ModeId:
						FSModeNode ModeId_FloatSource_Node = (FSModeNode)GetPort("ResultOrderAdded").GetConnection(0).node;
						objToReturn.ResultOrderAdded = ModeId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.JumpsId:
						FSJumpsNode JumpsId_FloatSource_Node = (FSJumpsNode)GetPort("ResultOrderAdded").GetConnection(0).node;
						objToReturn.ResultOrderAdded = JumpsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RootAnimId:
						FSRootAnimNode RootAnimId_FloatSource_Node = (FSRootAnimNode)GetPort("ResultOrderAdded").GetConnection(0).node;
						objToReturn.ResultOrderAdded = RootAnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FloatId:
						FSValueNode FloatId_FloatSource_Node = (FSValueNode)GetPort("ResultOrderAdded").GetConnection(0).node;
						objToReturn.ResultOrderAdded = FloatId_FloatSource_Node.GetData();
					break;
				}
			}
			objToReturn.SetPlayerIndex = SetPlayerIndex;
			objToReturn.SetAttackTeam = SetAttackTeam;
			objToReturn.SetDefendTeam = SetDefendTeam;
			objToReturn.SetProjectileLevel = SetProjectileLevel;
			objToReturn.SetDirection = SetDirection;
			objToReturn.SetRedirect = SetRedirect;
			if (GetPort("PlayerIndex").ConnectionCount > 0)
			{
				FloatSourceNode FloatSource_Node = (FloatSourceNode)GetPort("PlayerIndex").GetConnection(0).node;
				switch (FloatSource_Node.TID)
				{
					case FloatSource.TypeId.AgentId:
						FSAgentNode AgentId_FloatSource_Node = (FSAgentNode)GetPort("PlayerIndex").GetConnection(0).node;
						objToReturn.PlayerIndex = AgentId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.BonesId:
						FSBonesNode BonesId_FloatSource_Node = (FSBonesNode)GetPort("PlayerIndex").GetConnection(0).node;
						objToReturn.PlayerIndex = BonesId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AttackId:
						FSAttackNode AttackId_FloatSource_Node = (FSAttackNode)GetPort("PlayerIndex").GetConnection(0).node;
						objToReturn.PlayerIndex = AttackId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FrameId:
						FSFrameNode FrameId_FloatSource_Node = (FSFrameNode)GetPort("PlayerIndex").GetConnection(0).node;
						objToReturn.PlayerIndex = FrameId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.InputId:
						FSInputNode InputId_FloatSource_Node = (FSInputNode)GetPort("PlayerIndex").GetConnection(0).node;
						objToReturn.PlayerIndex = InputId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FuncId:
						FSFuncNode FuncId_FloatSource_Node = (FSFuncNode)GetPort("PlayerIndex").GetConnection(0).node;
						objToReturn.PlayerIndex = FuncId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.MovementId:
						FSMovementNode MovementId_FloatSource_Node = (FSMovementNode)GetPort("PlayerIndex").GetConnection(0).node;
						objToReturn.PlayerIndex = MovementId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CombatId:
						FSCombatNode CombatId_FloatSource_Node = (FSCombatNode)GetPort("PlayerIndex").GetConnection(0).node;
						objToReturn.PlayerIndex = CombatId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.GrabsId:
						FSGrabsNode GrabsId_FloatSource_Node = (FSGrabsNode)GetPort("PlayerIndex").GetConnection(0).node;
						objToReturn.PlayerIndex = GrabsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.DataId:
						FSDataNode DataId_FloatSource_Node = (FSDataNode)GetPort("PlayerIndex").GetConnection(0).node;
						objToReturn.PlayerIndex = DataId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ScratchId:
						FSScratchNode ScratchId_FloatSource_Node = (FSScratchNode)GetPort("PlayerIndex").GetConnection(0).node;
						objToReturn.PlayerIndex = ScratchId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AnimId:
						FSAnimNode AnimId_FloatSource_Node = (FSAnimNode)GetPort("PlayerIndex").GetConnection(0).node;
						objToReturn.PlayerIndex = AnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SpeedId:
						FSSpeedNode SpeedId_FloatSource_Node = (FSSpeedNode)GetPort("PlayerIndex").GetConnection(0).node;
						objToReturn.PlayerIndex = SpeedId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.PhysicsId:
						FSPhysicsNode PhysicsId_FloatSource_Node = (FSPhysicsNode)GetPort("PlayerIndex").GetConnection(0).node;
						objToReturn.PlayerIndex = PhysicsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CollisionId:
						FSCollisionNode CollisionId_FloatSource_Node = (FSCollisionNode)GetPort("PlayerIndex").GetConnection(0).node;
						objToReturn.PlayerIndex = CollisionId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.TimerId:
						FSTimerNode TimerId_FloatSource_Node = (FSTimerNode)GetPort("PlayerIndex").GetConnection(0).node;
						objToReturn.PlayerIndex = TimerId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.LagId:
						FSLagNode LagId_FloatSource_Node = (FSLagNode)GetPort("PlayerIndex").GetConnection(0).node;
						objToReturn.PlayerIndex = LagId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.EffectsId:
						FSEffectsNode EffectsId_FloatSource_Node = (FSEffectsNode)GetPort("PlayerIndex").GetConnection(0).node;
						objToReturn.PlayerIndex = EffectsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ColorsId:
						FSColorsNode ColorsId_FloatSource_Node = (FSColorsNode)GetPort("PlayerIndex").GetConnection(0).node;
						objToReturn.PlayerIndex = ColorsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.OnHitId:
						FSOnHitNode OnHitId_FloatSource_Node = (FSOnHitNode)GetPort("PlayerIndex").GetConnection(0).node;
						objToReturn.PlayerIndex = OnHitId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RandomId:
						FSRandomNode RandomId_FloatSource_Node = (FSRandomNode)GetPort("PlayerIndex").GetConnection(0).node;
						objToReturn.PlayerIndex = RandomId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CameraId:
						FSCameraInfoNode CameraId_FloatSource_Node = (FSCameraInfoNode)GetPort("PlayerIndex").GetConnection(0).node;
						objToReturn.PlayerIndex = CameraId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SportsId:
						FSSportsNode SportsId_FloatSource_Node = (FSSportsNode)GetPort("PlayerIndex").GetConnection(0).node;
						objToReturn.PlayerIndex = SportsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.Vector2Mag:
						FSVector2MagNode Vector2Mag_FloatSource_Node = (FSVector2MagNode)GetPort("PlayerIndex").GetConnection(0).node;
						objToReturn.PlayerIndex = Vector2Mag_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CPUHelpId:
						FSCpuHelpNode CPUHelpId_FloatSource_Node = (FSCpuHelpNode)GetPort("PlayerIndex").GetConnection(0).node;
						objToReturn.PlayerIndex = CPUHelpId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ItemId:
						FSItemNode ItemId_FloatSource_Node = (FSItemNode)GetPort("PlayerIndex").GetConnection(0).node;
						objToReturn.PlayerIndex = ItemId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ModeId:
						FSModeNode ModeId_FloatSource_Node = (FSModeNode)GetPort("PlayerIndex").GetConnection(0).node;
						objToReturn.PlayerIndex = ModeId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.JumpsId:
						FSJumpsNode JumpsId_FloatSource_Node = (FSJumpsNode)GetPort("PlayerIndex").GetConnection(0).node;
						objToReturn.PlayerIndex = JumpsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RootAnimId:
						FSRootAnimNode RootAnimId_FloatSource_Node = (FSRootAnimNode)GetPort("PlayerIndex").GetConnection(0).node;
						objToReturn.PlayerIndex = RootAnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FloatId:
						FSValueNode FloatId_FloatSource_Node = (FSValueNode)GetPort("PlayerIndex").GetConnection(0).node;
						objToReturn.PlayerIndex = FloatId_FloatSource_Node.GetData();
					break;
				}
			}
			if (GetPort("AttackTeam").ConnectionCount > 0)
			{
				FloatSourceNode FloatSource_Node = (FloatSourceNode)GetPort("AttackTeam").GetConnection(0).node;
				switch (FloatSource_Node.TID)
				{
					case FloatSource.TypeId.AgentId:
						FSAgentNode AgentId_FloatSource_Node = (FSAgentNode)GetPort("AttackTeam").GetConnection(0).node;
						objToReturn.AttackTeam = AgentId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.BonesId:
						FSBonesNode BonesId_FloatSource_Node = (FSBonesNode)GetPort("AttackTeam").GetConnection(0).node;
						objToReturn.AttackTeam = BonesId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AttackId:
						FSAttackNode AttackId_FloatSource_Node = (FSAttackNode)GetPort("AttackTeam").GetConnection(0).node;
						objToReturn.AttackTeam = AttackId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FrameId:
						FSFrameNode FrameId_FloatSource_Node = (FSFrameNode)GetPort("AttackTeam").GetConnection(0).node;
						objToReturn.AttackTeam = FrameId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.InputId:
						FSInputNode InputId_FloatSource_Node = (FSInputNode)GetPort("AttackTeam").GetConnection(0).node;
						objToReturn.AttackTeam = InputId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FuncId:
						FSFuncNode FuncId_FloatSource_Node = (FSFuncNode)GetPort("AttackTeam").GetConnection(0).node;
						objToReturn.AttackTeam = FuncId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.MovementId:
						FSMovementNode MovementId_FloatSource_Node = (FSMovementNode)GetPort("AttackTeam").GetConnection(0).node;
						objToReturn.AttackTeam = MovementId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CombatId:
						FSCombatNode CombatId_FloatSource_Node = (FSCombatNode)GetPort("AttackTeam").GetConnection(0).node;
						objToReturn.AttackTeam = CombatId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.GrabsId:
						FSGrabsNode GrabsId_FloatSource_Node = (FSGrabsNode)GetPort("AttackTeam").GetConnection(0).node;
						objToReturn.AttackTeam = GrabsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.DataId:
						FSDataNode DataId_FloatSource_Node = (FSDataNode)GetPort("AttackTeam").GetConnection(0).node;
						objToReturn.AttackTeam = DataId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ScratchId:
						FSScratchNode ScratchId_FloatSource_Node = (FSScratchNode)GetPort("AttackTeam").GetConnection(0).node;
						objToReturn.AttackTeam = ScratchId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AnimId:
						FSAnimNode AnimId_FloatSource_Node = (FSAnimNode)GetPort("AttackTeam").GetConnection(0).node;
						objToReturn.AttackTeam = AnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SpeedId:
						FSSpeedNode SpeedId_FloatSource_Node = (FSSpeedNode)GetPort("AttackTeam").GetConnection(0).node;
						objToReturn.AttackTeam = SpeedId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.PhysicsId:
						FSPhysicsNode PhysicsId_FloatSource_Node = (FSPhysicsNode)GetPort("AttackTeam").GetConnection(0).node;
						objToReturn.AttackTeam = PhysicsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CollisionId:
						FSCollisionNode CollisionId_FloatSource_Node = (FSCollisionNode)GetPort("AttackTeam").GetConnection(0).node;
						objToReturn.AttackTeam = CollisionId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.TimerId:
						FSTimerNode TimerId_FloatSource_Node = (FSTimerNode)GetPort("AttackTeam").GetConnection(0).node;
						objToReturn.AttackTeam = TimerId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.LagId:
						FSLagNode LagId_FloatSource_Node = (FSLagNode)GetPort("AttackTeam").GetConnection(0).node;
						objToReturn.AttackTeam = LagId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.EffectsId:
						FSEffectsNode EffectsId_FloatSource_Node = (FSEffectsNode)GetPort("AttackTeam").GetConnection(0).node;
						objToReturn.AttackTeam = EffectsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ColorsId:
						FSColorsNode ColorsId_FloatSource_Node = (FSColorsNode)GetPort("AttackTeam").GetConnection(0).node;
						objToReturn.AttackTeam = ColorsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.OnHitId:
						FSOnHitNode OnHitId_FloatSource_Node = (FSOnHitNode)GetPort("AttackTeam").GetConnection(0).node;
						objToReturn.AttackTeam = OnHitId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RandomId:
						FSRandomNode RandomId_FloatSource_Node = (FSRandomNode)GetPort("AttackTeam").GetConnection(0).node;
						objToReturn.AttackTeam = RandomId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CameraId:
						FSCameraInfoNode CameraId_FloatSource_Node = (FSCameraInfoNode)GetPort("AttackTeam").GetConnection(0).node;
						objToReturn.AttackTeam = CameraId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SportsId:
						FSSportsNode SportsId_FloatSource_Node = (FSSportsNode)GetPort("AttackTeam").GetConnection(0).node;
						objToReturn.AttackTeam = SportsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.Vector2Mag:
						FSVector2MagNode Vector2Mag_FloatSource_Node = (FSVector2MagNode)GetPort("AttackTeam").GetConnection(0).node;
						objToReturn.AttackTeam = Vector2Mag_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CPUHelpId:
						FSCpuHelpNode CPUHelpId_FloatSource_Node = (FSCpuHelpNode)GetPort("AttackTeam").GetConnection(0).node;
						objToReturn.AttackTeam = CPUHelpId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ItemId:
						FSItemNode ItemId_FloatSource_Node = (FSItemNode)GetPort("AttackTeam").GetConnection(0).node;
						objToReturn.AttackTeam = ItemId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ModeId:
						FSModeNode ModeId_FloatSource_Node = (FSModeNode)GetPort("AttackTeam").GetConnection(0).node;
						objToReturn.AttackTeam = ModeId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.JumpsId:
						FSJumpsNode JumpsId_FloatSource_Node = (FSJumpsNode)GetPort("AttackTeam").GetConnection(0).node;
						objToReturn.AttackTeam = JumpsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RootAnimId:
						FSRootAnimNode RootAnimId_FloatSource_Node = (FSRootAnimNode)GetPort("AttackTeam").GetConnection(0).node;
						objToReturn.AttackTeam = RootAnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FloatId:
						FSValueNode FloatId_FloatSource_Node = (FSValueNode)GetPort("AttackTeam").GetConnection(0).node;
						objToReturn.AttackTeam = FloatId_FloatSource_Node.GetData();
					break;
				}
			}
			if (GetPort("DefendTeam").ConnectionCount > 0)
			{
				FloatSourceNode FloatSource_Node = (FloatSourceNode)GetPort("DefendTeam").GetConnection(0).node;
				switch (FloatSource_Node.TID)
				{
					case FloatSource.TypeId.AgentId:
						FSAgentNode AgentId_FloatSource_Node = (FSAgentNode)GetPort("DefendTeam").GetConnection(0).node;
						objToReturn.DefendTeam = AgentId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.BonesId:
						FSBonesNode BonesId_FloatSource_Node = (FSBonesNode)GetPort("DefendTeam").GetConnection(0).node;
						objToReturn.DefendTeam = BonesId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AttackId:
						FSAttackNode AttackId_FloatSource_Node = (FSAttackNode)GetPort("DefendTeam").GetConnection(0).node;
						objToReturn.DefendTeam = AttackId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FrameId:
						FSFrameNode FrameId_FloatSource_Node = (FSFrameNode)GetPort("DefendTeam").GetConnection(0).node;
						objToReturn.DefendTeam = FrameId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.InputId:
						FSInputNode InputId_FloatSource_Node = (FSInputNode)GetPort("DefendTeam").GetConnection(0).node;
						objToReturn.DefendTeam = InputId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FuncId:
						FSFuncNode FuncId_FloatSource_Node = (FSFuncNode)GetPort("DefendTeam").GetConnection(0).node;
						objToReturn.DefendTeam = FuncId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.MovementId:
						FSMovementNode MovementId_FloatSource_Node = (FSMovementNode)GetPort("DefendTeam").GetConnection(0).node;
						objToReturn.DefendTeam = MovementId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CombatId:
						FSCombatNode CombatId_FloatSource_Node = (FSCombatNode)GetPort("DefendTeam").GetConnection(0).node;
						objToReturn.DefendTeam = CombatId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.GrabsId:
						FSGrabsNode GrabsId_FloatSource_Node = (FSGrabsNode)GetPort("DefendTeam").GetConnection(0).node;
						objToReturn.DefendTeam = GrabsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.DataId:
						FSDataNode DataId_FloatSource_Node = (FSDataNode)GetPort("DefendTeam").GetConnection(0).node;
						objToReturn.DefendTeam = DataId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ScratchId:
						FSScratchNode ScratchId_FloatSource_Node = (FSScratchNode)GetPort("DefendTeam").GetConnection(0).node;
						objToReturn.DefendTeam = ScratchId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AnimId:
						FSAnimNode AnimId_FloatSource_Node = (FSAnimNode)GetPort("DefendTeam").GetConnection(0).node;
						objToReturn.DefendTeam = AnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SpeedId:
						FSSpeedNode SpeedId_FloatSource_Node = (FSSpeedNode)GetPort("DefendTeam").GetConnection(0).node;
						objToReturn.DefendTeam = SpeedId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.PhysicsId:
						FSPhysicsNode PhysicsId_FloatSource_Node = (FSPhysicsNode)GetPort("DefendTeam").GetConnection(0).node;
						objToReturn.DefendTeam = PhysicsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CollisionId:
						FSCollisionNode CollisionId_FloatSource_Node = (FSCollisionNode)GetPort("DefendTeam").GetConnection(0).node;
						objToReturn.DefendTeam = CollisionId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.TimerId:
						FSTimerNode TimerId_FloatSource_Node = (FSTimerNode)GetPort("DefendTeam").GetConnection(0).node;
						objToReturn.DefendTeam = TimerId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.LagId:
						FSLagNode LagId_FloatSource_Node = (FSLagNode)GetPort("DefendTeam").GetConnection(0).node;
						objToReturn.DefendTeam = LagId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.EffectsId:
						FSEffectsNode EffectsId_FloatSource_Node = (FSEffectsNode)GetPort("DefendTeam").GetConnection(0).node;
						objToReturn.DefendTeam = EffectsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ColorsId:
						FSColorsNode ColorsId_FloatSource_Node = (FSColorsNode)GetPort("DefendTeam").GetConnection(0).node;
						objToReturn.DefendTeam = ColorsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.OnHitId:
						FSOnHitNode OnHitId_FloatSource_Node = (FSOnHitNode)GetPort("DefendTeam").GetConnection(0).node;
						objToReturn.DefendTeam = OnHitId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RandomId:
						FSRandomNode RandomId_FloatSource_Node = (FSRandomNode)GetPort("DefendTeam").GetConnection(0).node;
						objToReturn.DefendTeam = RandomId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CameraId:
						FSCameraInfoNode CameraId_FloatSource_Node = (FSCameraInfoNode)GetPort("DefendTeam").GetConnection(0).node;
						objToReturn.DefendTeam = CameraId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SportsId:
						FSSportsNode SportsId_FloatSource_Node = (FSSportsNode)GetPort("DefendTeam").GetConnection(0).node;
						objToReturn.DefendTeam = SportsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.Vector2Mag:
						FSVector2MagNode Vector2Mag_FloatSource_Node = (FSVector2MagNode)GetPort("DefendTeam").GetConnection(0).node;
						objToReturn.DefendTeam = Vector2Mag_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CPUHelpId:
						FSCpuHelpNode CPUHelpId_FloatSource_Node = (FSCpuHelpNode)GetPort("DefendTeam").GetConnection(0).node;
						objToReturn.DefendTeam = CPUHelpId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ItemId:
						FSItemNode ItemId_FloatSource_Node = (FSItemNode)GetPort("DefendTeam").GetConnection(0).node;
						objToReturn.DefendTeam = ItemId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ModeId:
						FSModeNode ModeId_FloatSource_Node = (FSModeNode)GetPort("DefendTeam").GetConnection(0).node;
						objToReturn.DefendTeam = ModeId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.JumpsId:
						FSJumpsNode JumpsId_FloatSource_Node = (FSJumpsNode)GetPort("DefendTeam").GetConnection(0).node;
						objToReturn.DefendTeam = JumpsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RootAnimId:
						FSRootAnimNode RootAnimId_FloatSource_Node = (FSRootAnimNode)GetPort("DefendTeam").GetConnection(0).node;
						objToReturn.DefendTeam = RootAnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FloatId:
						FSValueNode FloatId_FloatSource_Node = (FSValueNode)GetPort("DefendTeam").GetConnection(0).node;
						objToReturn.DefendTeam = FloatId_FloatSource_Node.GetData();
					break;
				}
			}
			if (GetPort("ProjectileLevel").ConnectionCount > 0)
			{
				FloatSourceNode FloatSource_Node = (FloatSourceNode)GetPort("ProjectileLevel").GetConnection(0).node;
				switch (FloatSource_Node.TID)
				{
					case FloatSource.TypeId.AgentId:
						FSAgentNode AgentId_FloatSource_Node = (FSAgentNode)GetPort("ProjectileLevel").GetConnection(0).node;
						objToReturn.ProjectileLevel = AgentId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.BonesId:
						FSBonesNode BonesId_FloatSource_Node = (FSBonesNode)GetPort("ProjectileLevel").GetConnection(0).node;
						objToReturn.ProjectileLevel = BonesId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AttackId:
						FSAttackNode AttackId_FloatSource_Node = (FSAttackNode)GetPort("ProjectileLevel").GetConnection(0).node;
						objToReturn.ProjectileLevel = AttackId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FrameId:
						FSFrameNode FrameId_FloatSource_Node = (FSFrameNode)GetPort("ProjectileLevel").GetConnection(0).node;
						objToReturn.ProjectileLevel = FrameId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.InputId:
						FSInputNode InputId_FloatSource_Node = (FSInputNode)GetPort("ProjectileLevel").GetConnection(0).node;
						objToReturn.ProjectileLevel = InputId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FuncId:
						FSFuncNode FuncId_FloatSource_Node = (FSFuncNode)GetPort("ProjectileLevel").GetConnection(0).node;
						objToReturn.ProjectileLevel = FuncId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.MovementId:
						FSMovementNode MovementId_FloatSource_Node = (FSMovementNode)GetPort("ProjectileLevel").GetConnection(0).node;
						objToReturn.ProjectileLevel = MovementId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CombatId:
						FSCombatNode CombatId_FloatSource_Node = (FSCombatNode)GetPort("ProjectileLevel").GetConnection(0).node;
						objToReturn.ProjectileLevel = CombatId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.GrabsId:
						FSGrabsNode GrabsId_FloatSource_Node = (FSGrabsNode)GetPort("ProjectileLevel").GetConnection(0).node;
						objToReturn.ProjectileLevel = GrabsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.DataId:
						FSDataNode DataId_FloatSource_Node = (FSDataNode)GetPort("ProjectileLevel").GetConnection(0).node;
						objToReturn.ProjectileLevel = DataId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ScratchId:
						FSScratchNode ScratchId_FloatSource_Node = (FSScratchNode)GetPort("ProjectileLevel").GetConnection(0).node;
						objToReturn.ProjectileLevel = ScratchId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AnimId:
						FSAnimNode AnimId_FloatSource_Node = (FSAnimNode)GetPort("ProjectileLevel").GetConnection(0).node;
						objToReturn.ProjectileLevel = AnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SpeedId:
						FSSpeedNode SpeedId_FloatSource_Node = (FSSpeedNode)GetPort("ProjectileLevel").GetConnection(0).node;
						objToReturn.ProjectileLevel = SpeedId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.PhysicsId:
						FSPhysicsNode PhysicsId_FloatSource_Node = (FSPhysicsNode)GetPort("ProjectileLevel").GetConnection(0).node;
						objToReturn.ProjectileLevel = PhysicsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CollisionId:
						FSCollisionNode CollisionId_FloatSource_Node = (FSCollisionNode)GetPort("ProjectileLevel").GetConnection(0).node;
						objToReturn.ProjectileLevel = CollisionId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.TimerId:
						FSTimerNode TimerId_FloatSource_Node = (FSTimerNode)GetPort("ProjectileLevel").GetConnection(0).node;
						objToReturn.ProjectileLevel = TimerId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.LagId:
						FSLagNode LagId_FloatSource_Node = (FSLagNode)GetPort("ProjectileLevel").GetConnection(0).node;
						objToReturn.ProjectileLevel = LagId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.EffectsId:
						FSEffectsNode EffectsId_FloatSource_Node = (FSEffectsNode)GetPort("ProjectileLevel").GetConnection(0).node;
						objToReturn.ProjectileLevel = EffectsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ColorsId:
						FSColorsNode ColorsId_FloatSource_Node = (FSColorsNode)GetPort("ProjectileLevel").GetConnection(0).node;
						objToReturn.ProjectileLevel = ColorsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.OnHitId:
						FSOnHitNode OnHitId_FloatSource_Node = (FSOnHitNode)GetPort("ProjectileLevel").GetConnection(0).node;
						objToReturn.ProjectileLevel = OnHitId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RandomId:
						FSRandomNode RandomId_FloatSource_Node = (FSRandomNode)GetPort("ProjectileLevel").GetConnection(0).node;
						objToReturn.ProjectileLevel = RandomId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CameraId:
						FSCameraInfoNode CameraId_FloatSource_Node = (FSCameraInfoNode)GetPort("ProjectileLevel").GetConnection(0).node;
						objToReturn.ProjectileLevel = CameraId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SportsId:
						FSSportsNode SportsId_FloatSource_Node = (FSSportsNode)GetPort("ProjectileLevel").GetConnection(0).node;
						objToReturn.ProjectileLevel = SportsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.Vector2Mag:
						FSVector2MagNode Vector2Mag_FloatSource_Node = (FSVector2MagNode)GetPort("ProjectileLevel").GetConnection(0).node;
						objToReturn.ProjectileLevel = Vector2Mag_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CPUHelpId:
						FSCpuHelpNode CPUHelpId_FloatSource_Node = (FSCpuHelpNode)GetPort("ProjectileLevel").GetConnection(0).node;
						objToReturn.ProjectileLevel = CPUHelpId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ItemId:
						FSItemNode ItemId_FloatSource_Node = (FSItemNode)GetPort("ProjectileLevel").GetConnection(0).node;
						objToReturn.ProjectileLevel = ItemId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ModeId:
						FSModeNode ModeId_FloatSource_Node = (FSModeNode)GetPort("ProjectileLevel").GetConnection(0).node;
						objToReturn.ProjectileLevel = ModeId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.JumpsId:
						FSJumpsNode JumpsId_FloatSource_Node = (FSJumpsNode)GetPort("ProjectileLevel").GetConnection(0).node;
						objToReturn.ProjectileLevel = JumpsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RootAnimId:
						FSRootAnimNode RootAnimId_FloatSource_Node = (FSRootAnimNode)GetPort("ProjectileLevel").GetConnection(0).node;
						objToReturn.ProjectileLevel = RootAnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FloatId:
						FSValueNode FloatId_FloatSource_Node = (FSValueNode)GetPort("ProjectileLevel").GetConnection(0).node;
						objToReturn.ProjectileLevel = FloatId_FloatSource_Node.GetData();
					break;
				}
			}
			if (GetPort("Direction").ConnectionCount > 0)
			{
				FloatSourceNode FloatSource_Node = (FloatSourceNode)GetPort("Direction").GetConnection(0).node;
				switch (FloatSource_Node.TID)
				{
					case FloatSource.TypeId.AgentId:
						FSAgentNode AgentId_FloatSource_Node = (FSAgentNode)GetPort("Direction").GetConnection(0).node;
						objToReturn.Direction = AgentId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.BonesId:
						FSBonesNode BonesId_FloatSource_Node = (FSBonesNode)GetPort("Direction").GetConnection(0).node;
						objToReturn.Direction = BonesId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AttackId:
						FSAttackNode AttackId_FloatSource_Node = (FSAttackNode)GetPort("Direction").GetConnection(0).node;
						objToReturn.Direction = AttackId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FrameId:
						FSFrameNode FrameId_FloatSource_Node = (FSFrameNode)GetPort("Direction").GetConnection(0).node;
						objToReturn.Direction = FrameId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.InputId:
						FSInputNode InputId_FloatSource_Node = (FSInputNode)GetPort("Direction").GetConnection(0).node;
						objToReturn.Direction = InputId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FuncId:
						FSFuncNode FuncId_FloatSource_Node = (FSFuncNode)GetPort("Direction").GetConnection(0).node;
						objToReturn.Direction = FuncId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.MovementId:
						FSMovementNode MovementId_FloatSource_Node = (FSMovementNode)GetPort("Direction").GetConnection(0).node;
						objToReturn.Direction = MovementId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CombatId:
						FSCombatNode CombatId_FloatSource_Node = (FSCombatNode)GetPort("Direction").GetConnection(0).node;
						objToReturn.Direction = CombatId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.GrabsId:
						FSGrabsNode GrabsId_FloatSource_Node = (FSGrabsNode)GetPort("Direction").GetConnection(0).node;
						objToReturn.Direction = GrabsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.DataId:
						FSDataNode DataId_FloatSource_Node = (FSDataNode)GetPort("Direction").GetConnection(0).node;
						objToReturn.Direction = DataId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ScratchId:
						FSScratchNode ScratchId_FloatSource_Node = (FSScratchNode)GetPort("Direction").GetConnection(0).node;
						objToReturn.Direction = ScratchId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AnimId:
						FSAnimNode AnimId_FloatSource_Node = (FSAnimNode)GetPort("Direction").GetConnection(0).node;
						objToReturn.Direction = AnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SpeedId:
						FSSpeedNode SpeedId_FloatSource_Node = (FSSpeedNode)GetPort("Direction").GetConnection(0).node;
						objToReturn.Direction = SpeedId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.PhysicsId:
						FSPhysicsNode PhysicsId_FloatSource_Node = (FSPhysicsNode)GetPort("Direction").GetConnection(0).node;
						objToReturn.Direction = PhysicsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CollisionId:
						FSCollisionNode CollisionId_FloatSource_Node = (FSCollisionNode)GetPort("Direction").GetConnection(0).node;
						objToReturn.Direction = CollisionId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.TimerId:
						FSTimerNode TimerId_FloatSource_Node = (FSTimerNode)GetPort("Direction").GetConnection(0).node;
						objToReturn.Direction = TimerId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.LagId:
						FSLagNode LagId_FloatSource_Node = (FSLagNode)GetPort("Direction").GetConnection(0).node;
						objToReturn.Direction = LagId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.EffectsId:
						FSEffectsNode EffectsId_FloatSource_Node = (FSEffectsNode)GetPort("Direction").GetConnection(0).node;
						objToReturn.Direction = EffectsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ColorsId:
						FSColorsNode ColorsId_FloatSource_Node = (FSColorsNode)GetPort("Direction").GetConnection(0).node;
						objToReturn.Direction = ColorsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.OnHitId:
						FSOnHitNode OnHitId_FloatSource_Node = (FSOnHitNode)GetPort("Direction").GetConnection(0).node;
						objToReturn.Direction = OnHitId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RandomId:
						FSRandomNode RandomId_FloatSource_Node = (FSRandomNode)GetPort("Direction").GetConnection(0).node;
						objToReturn.Direction = RandomId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CameraId:
						FSCameraInfoNode CameraId_FloatSource_Node = (FSCameraInfoNode)GetPort("Direction").GetConnection(0).node;
						objToReturn.Direction = CameraId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SportsId:
						FSSportsNode SportsId_FloatSource_Node = (FSSportsNode)GetPort("Direction").GetConnection(0).node;
						objToReturn.Direction = SportsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.Vector2Mag:
						FSVector2MagNode Vector2Mag_FloatSource_Node = (FSVector2MagNode)GetPort("Direction").GetConnection(0).node;
						objToReturn.Direction = Vector2Mag_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CPUHelpId:
						FSCpuHelpNode CPUHelpId_FloatSource_Node = (FSCpuHelpNode)GetPort("Direction").GetConnection(0).node;
						objToReturn.Direction = CPUHelpId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ItemId:
						FSItemNode ItemId_FloatSource_Node = (FSItemNode)GetPort("Direction").GetConnection(0).node;
						objToReturn.Direction = ItemId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ModeId:
						FSModeNode ModeId_FloatSource_Node = (FSModeNode)GetPort("Direction").GetConnection(0).node;
						objToReturn.Direction = ModeId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.JumpsId:
						FSJumpsNode JumpsId_FloatSource_Node = (FSJumpsNode)GetPort("Direction").GetConnection(0).node;
						objToReturn.Direction = JumpsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RootAnimId:
						FSRootAnimNode RootAnimId_FloatSource_Node = (FSRootAnimNode)GetPort("Direction").GetConnection(0).node;
						objToReturn.Direction = RootAnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FloatId:
						FSValueNode FloatId_FloatSource_Node = (FSValueNode)GetPort("Direction").GetConnection(0).node;
						objToReturn.Direction = FloatId_FloatSource_Node.GetData();
					break;
				}
			}
			if (GetPort("RedirectX").ConnectionCount > 0)
			{
				FloatSourceNode FloatSource_Node = (FloatSourceNode)GetPort("RedirectX").GetConnection(0).node;
				switch (FloatSource_Node.TID)
				{
					case FloatSource.TypeId.AgentId:
						FSAgentNode AgentId_FloatSource_Node = (FSAgentNode)GetPort("RedirectX").GetConnection(0).node;
						objToReturn.RedirectX = AgentId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.BonesId:
						FSBonesNode BonesId_FloatSource_Node = (FSBonesNode)GetPort("RedirectX").GetConnection(0).node;
						objToReturn.RedirectX = BonesId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AttackId:
						FSAttackNode AttackId_FloatSource_Node = (FSAttackNode)GetPort("RedirectX").GetConnection(0).node;
						objToReturn.RedirectX = AttackId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FrameId:
						FSFrameNode FrameId_FloatSource_Node = (FSFrameNode)GetPort("RedirectX").GetConnection(0).node;
						objToReturn.RedirectX = FrameId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.InputId:
						FSInputNode InputId_FloatSource_Node = (FSInputNode)GetPort("RedirectX").GetConnection(0).node;
						objToReturn.RedirectX = InputId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FuncId:
						FSFuncNode FuncId_FloatSource_Node = (FSFuncNode)GetPort("RedirectX").GetConnection(0).node;
						objToReturn.RedirectX = FuncId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.MovementId:
						FSMovementNode MovementId_FloatSource_Node = (FSMovementNode)GetPort("RedirectX").GetConnection(0).node;
						objToReturn.RedirectX = MovementId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CombatId:
						FSCombatNode CombatId_FloatSource_Node = (FSCombatNode)GetPort("RedirectX").GetConnection(0).node;
						objToReturn.RedirectX = CombatId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.GrabsId:
						FSGrabsNode GrabsId_FloatSource_Node = (FSGrabsNode)GetPort("RedirectX").GetConnection(0).node;
						objToReturn.RedirectX = GrabsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.DataId:
						FSDataNode DataId_FloatSource_Node = (FSDataNode)GetPort("RedirectX").GetConnection(0).node;
						objToReturn.RedirectX = DataId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ScratchId:
						FSScratchNode ScratchId_FloatSource_Node = (FSScratchNode)GetPort("RedirectX").GetConnection(0).node;
						objToReturn.RedirectX = ScratchId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AnimId:
						FSAnimNode AnimId_FloatSource_Node = (FSAnimNode)GetPort("RedirectX").GetConnection(0).node;
						objToReturn.RedirectX = AnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SpeedId:
						FSSpeedNode SpeedId_FloatSource_Node = (FSSpeedNode)GetPort("RedirectX").GetConnection(0).node;
						objToReturn.RedirectX = SpeedId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.PhysicsId:
						FSPhysicsNode PhysicsId_FloatSource_Node = (FSPhysicsNode)GetPort("RedirectX").GetConnection(0).node;
						objToReturn.RedirectX = PhysicsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CollisionId:
						FSCollisionNode CollisionId_FloatSource_Node = (FSCollisionNode)GetPort("RedirectX").GetConnection(0).node;
						objToReturn.RedirectX = CollisionId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.TimerId:
						FSTimerNode TimerId_FloatSource_Node = (FSTimerNode)GetPort("RedirectX").GetConnection(0).node;
						objToReturn.RedirectX = TimerId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.LagId:
						FSLagNode LagId_FloatSource_Node = (FSLagNode)GetPort("RedirectX").GetConnection(0).node;
						objToReturn.RedirectX = LagId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.EffectsId:
						FSEffectsNode EffectsId_FloatSource_Node = (FSEffectsNode)GetPort("RedirectX").GetConnection(0).node;
						objToReturn.RedirectX = EffectsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ColorsId:
						FSColorsNode ColorsId_FloatSource_Node = (FSColorsNode)GetPort("RedirectX").GetConnection(0).node;
						objToReturn.RedirectX = ColorsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.OnHitId:
						FSOnHitNode OnHitId_FloatSource_Node = (FSOnHitNode)GetPort("RedirectX").GetConnection(0).node;
						objToReturn.RedirectX = OnHitId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RandomId:
						FSRandomNode RandomId_FloatSource_Node = (FSRandomNode)GetPort("RedirectX").GetConnection(0).node;
						objToReturn.RedirectX = RandomId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CameraId:
						FSCameraInfoNode CameraId_FloatSource_Node = (FSCameraInfoNode)GetPort("RedirectX").GetConnection(0).node;
						objToReturn.RedirectX = CameraId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SportsId:
						FSSportsNode SportsId_FloatSource_Node = (FSSportsNode)GetPort("RedirectX").GetConnection(0).node;
						objToReturn.RedirectX = SportsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.Vector2Mag:
						FSVector2MagNode Vector2Mag_FloatSource_Node = (FSVector2MagNode)GetPort("RedirectX").GetConnection(0).node;
						objToReturn.RedirectX = Vector2Mag_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CPUHelpId:
						FSCpuHelpNode CPUHelpId_FloatSource_Node = (FSCpuHelpNode)GetPort("RedirectX").GetConnection(0).node;
						objToReturn.RedirectX = CPUHelpId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ItemId:
						FSItemNode ItemId_FloatSource_Node = (FSItemNode)GetPort("RedirectX").GetConnection(0).node;
						objToReturn.RedirectX = ItemId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ModeId:
						FSModeNode ModeId_FloatSource_Node = (FSModeNode)GetPort("RedirectX").GetConnection(0).node;
						objToReturn.RedirectX = ModeId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.JumpsId:
						FSJumpsNode JumpsId_FloatSource_Node = (FSJumpsNode)GetPort("RedirectX").GetConnection(0).node;
						objToReturn.RedirectX = JumpsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RootAnimId:
						FSRootAnimNode RootAnimId_FloatSource_Node = (FSRootAnimNode)GetPort("RedirectX").GetConnection(0).node;
						objToReturn.RedirectX = RootAnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FloatId:
						FSValueNode FloatId_FloatSource_Node = (FSValueNode)GetPort("RedirectX").GetConnection(0).node;
						objToReturn.RedirectX = FloatId_FloatSource_Node.GetData();
					break;
				}
			}
			if (GetPort("RedirectY").ConnectionCount > 0)
			{
				FloatSourceNode FloatSource_Node = (FloatSourceNode)GetPort("RedirectY").GetConnection(0).node;
				switch (FloatSource_Node.TID)
				{
					case FloatSource.TypeId.AgentId:
						FSAgentNode AgentId_FloatSource_Node = (FSAgentNode)GetPort("RedirectY").GetConnection(0).node;
						objToReturn.RedirectY = AgentId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.BonesId:
						FSBonesNode BonesId_FloatSource_Node = (FSBonesNode)GetPort("RedirectY").GetConnection(0).node;
						objToReturn.RedirectY = BonesId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AttackId:
						FSAttackNode AttackId_FloatSource_Node = (FSAttackNode)GetPort("RedirectY").GetConnection(0).node;
						objToReturn.RedirectY = AttackId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FrameId:
						FSFrameNode FrameId_FloatSource_Node = (FSFrameNode)GetPort("RedirectY").GetConnection(0).node;
						objToReturn.RedirectY = FrameId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.InputId:
						FSInputNode InputId_FloatSource_Node = (FSInputNode)GetPort("RedirectY").GetConnection(0).node;
						objToReturn.RedirectY = InputId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FuncId:
						FSFuncNode FuncId_FloatSource_Node = (FSFuncNode)GetPort("RedirectY").GetConnection(0).node;
						objToReturn.RedirectY = FuncId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.MovementId:
						FSMovementNode MovementId_FloatSource_Node = (FSMovementNode)GetPort("RedirectY").GetConnection(0).node;
						objToReturn.RedirectY = MovementId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CombatId:
						FSCombatNode CombatId_FloatSource_Node = (FSCombatNode)GetPort("RedirectY").GetConnection(0).node;
						objToReturn.RedirectY = CombatId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.GrabsId:
						FSGrabsNode GrabsId_FloatSource_Node = (FSGrabsNode)GetPort("RedirectY").GetConnection(0).node;
						objToReturn.RedirectY = GrabsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.DataId:
						FSDataNode DataId_FloatSource_Node = (FSDataNode)GetPort("RedirectY").GetConnection(0).node;
						objToReturn.RedirectY = DataId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ScratchId:
						FSScratchNode ScratchId_FloatSource_Node = (FSScratchNode)GetPort("RedirectY").GetConnection(0).node;
						objToReturn.RedirectY = ScratchId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AnimId:
						FSAnimNode AnimId_FloatSource_Node = (FSAnimNode)GetPort("RedirectY").GetConnection(0).node;
						objToReturn.RedirectY = AnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SpeedId:
						FSSpeedNode SpeedId_FloatSource_Node = (FSSpeedNode)GetPort("RedirectY").GetConnection(0).node;
						objToReturn.RedirectY = SpeedId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.PhysicsId:
						FSPhysicsNode PhysicsId_FloatSource_Node = (FSPhysicsNode)GetPort("RedirectY").GetConnection(0).node;
						objToReturn.RedirectY = PhysicsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CollisionId:
						FSCollisionNode CollisionId_FloatSource_Node = (FSCollisionNode)GetPort("RedirectY").GetConnection(0).node;
						objToReturn.RedirectY = CollisionId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.TimerId:
						FSTimerNode TimerId_FloatSource_Node = (FSTimerNode)GetPort("RedirectY").GetConnection(0).node;
						objToReturn.RedirectY = TimerId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.LagId:
						FSLagNode LagId_FloatSource_Node = (FSLagNode)GetPort("RedirectY").GetConnection(0).node;
						objToReturn.RedirectY = LagId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.EffectsId:
						FSEffectsNode EffectsId_FloatSource_Node = (FSEffectsNode)GetPort("RedirectY").GetConnection(0).node;
						objToReturn.RedirectY = EffectsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ColorsId:
						FSColorsNode ColorsId_FloatSource_Node = (FSColorsNode)GetPort("RedirectY").GetConnection(0).node;
						objToReturn.RedirectY = ColorsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.OnHitId:
						FSOnHitNode OnHitId_FloatSource_Node = (FSOnHitNode)GetPort("RedirectY").GetConnection(0).node;
						objToReturn.RedirectY = OnHitId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RandomId:
						FSRandomNode RandomId_FloatSource_Node = (FSRandomNode)GetPort("RedirectY").GetConnection(0).node;
						objToReturn.RedirectY = RandomId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CameraId:
						FSCameraInfoNode CameraId_FloatSource_Node = (FSCameraInfoNode)GetPort("RedirectY").GetConnection(0).node;
						objToReturn.RedirectY = CameraId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SportsId:
						FSSportsNode SportsId_FloatSource_Node = (FSSportsNode)GetPort("RedirectY").GetConnection(0).node;
						objToReturn.RedirectY = SportsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.Vector2Mag:
						FSVector2MagNode Vector2Mag_FloatSource_Node = (FSVector2MagNode)GetPort("RedirectY").GetConnection(0).node;
						objToReturn.RedirectY = Vector2Mag_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CPUHelpId:
						FSCpuHelpNode CPUHelpId_FloatSource_Node = (FSCpuHelpNode)GetPort("RedirectY").GetConnection(0).node;
						objToReturn.RedirectY = CPUHelpId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ItemId:
						FSItemNode ItemId_FloatSource_Node = (FSItemNode)GetPort("RedirectY").GetConnection(0).node;
						objToReturn.RedirectY = ItemId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ModeId:
						FSModeNode ModeId_FloatSource_Node = (FSModeNode)GetPort("RedirectY").GetConnection(0).node;
						objToReturn.RedirectY = ModeId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.JumpsId:
						FSJumpsNode JumpsId_FloatSource_Node = (FSJumpsNode)GetPort("RedirectY").GetConnection(0).node;
						objToReturn.RedirectY = JumpsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RootAnimId:
						FSRootAnimNode RootAnimId_FloatSource_Node = (FSRootAnimNode)GetPort("RedirectY").GetConnection(0).node;
						objToReturn.RedirectY = RootAnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FloatId:
						FSValueNode FloatId_FloatSource_Node = (FSValueNode)GetPort("RedirectY").GetConnection(0).node;
						objToReturn.RedirectY = FloatId_FloatSource_Node.GetData();
					break;
				}
			}
			objToReturn.ExactSpawn = ExactSpawn;
			foreach(NodePort port in GetPort("AddedSpawns").GetConnections())
			{
				SASpawnAgent2_AddedSpawnDataNode SASpawnAgent2_AddedSpawnData_Node = (SASpawnAgent2_AddedSpawnDataNode)port.node;
				objToReturn.AddedSpawns.Add(SASpawnAgent2_AddedSpawnData_Node.GetData());
			}
			return objToReturn;
		}
	}
}

