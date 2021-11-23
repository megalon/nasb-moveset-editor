// * 
// * 
// * This file was generated using NASB_Parser_to_xNode by megalon2d
// * https://github.com/megalon/NASB_Parser_to_xNode
// * 
// * 
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

namespace NASB_Moveset_Editor.StateActions
{
	public class SASpawnAgent2_AddedSpawnDataNode : BaseMovesetNode
	{
		public string SpawnedAgentDataId;
		[Output] public FloatSource SpawnedAgentDataSetValue;
		
		protected override void Init()
		{
			base.Init();
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SASpawnAgent2.AddedSpawnData data, MovesetGraph graph, string assetPath, Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SASpawnAgent2.AddedSpawnData));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
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
			
			return variableCount;
		}
		
		public new SASpawnAgent2.AddedSpawnData GetData()
		{
			SASpawnAgent2.AddedSpawnData objToReturn = new SASpawnAgent2.AddedSpawnData();
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
			return objToReturn;
		}
	}
}

