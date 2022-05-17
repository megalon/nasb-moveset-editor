// * 
// * 
// * This file was generated using NASB_Parser_to_xNode by megalon2d
// * https://github.com/megalon/NASB_Parser_to_xNode
// * 
// * 
using NASB_Parser.FloatSources;
using System;
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
	public class SAPersistLocalFXNode : StateActionNode
	{
		[Input(connectionType = ConnectionType.Override)] public StateAction NodeInput;
		public string Id;
		[Output(connectionType = ConnectionType.Override)] public FloatSource Persist;
		public bool MaxOut;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.PersistLocalFXId;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SAPersistLocalFX data, MovesetGraph graph, string assetPath, Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SAPersistLocalFX));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			Id = data.Id;
			Persist = data.Persist;
			
			switch (Persist.TID)
			{
				case FloatSource.TypeId.AgentId:
					FSAgentNode AgentId_node_Persist = graph.AddNode<FSAgentNode>();
					GetPort("Persist").Connect(AgentId_node_Persist.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AgentId_node_Persist, assetPath);
					variableCount += AgentId_node_Persist.SetData((FSAgent)Persist, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.BonesId:
					FSBonesNode BonesId_node_Persist = graph.AddNode<FSBonesNode>();
					GetPort("Persist").Connect(BonesId_node_Persist.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BonesId_node_Persist, assetPath);
					variableCount += BonesId_node_Persist.SetData((FSBones)Persist, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AttackId:
					FSAttackNode AttackId_node_Persist = graph.AddNode<FSAttackNode>();
					GetPort("Persist").Connect(AttackId_node_Persist.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AttackId_node_Persist, assetPath);
					variableCount += AttackId_node_Persist.SetData((FSAttack)Persist, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FrameId:
					FSFrameNode FrameId_node_Persist = graph.AddNode<FSFrameNode>();
					GetPort("Persist").Connect(FrameId_node_Persist.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FrameId_node_Persist, assetPath);
					variableCount += FrameId_node_Persist.SetData((FSFrame)Persist, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.InputId:
					FSInputNode InputId_node_Persist = graph.AddNode<FSInputNode>();
					GetPort("Persist").Connect(InputId_node_Persist.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputId_node_Persist, assetPath);
					variableCount += InputId_node_Persist.SetData((FSInput)Persist, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FuncId:
					FSFuncNode FuncId_node_Persist = graph.AddNode<FSFuncNode>();
					GetPort("Persist").Connect(FuncId_node_Persist.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FuncId_node_Persist, assetPath);
					variableCount += FuncId_node_Persist.SetData((FSFunc)Persist, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.MovementId:
					FSMovementNode MovementId_node_Persist = graph.AddNode<FSMovementNode>();
					GetPort("Persist").Connect(MovementId_node_Persist.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(MovementId_node_Persist, assetPath);
					variableCount += MovementId_node_Persist.SetData((FSMovement)Persist, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CombatId:
					FSCombatNode CombatId_node_Persist = graph.AddNode<FSCombatNode>();
					GetPort("Persist").Connect(CombatId_node_Persist.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CombatId_node_Persist, assetPath);
					variableCount += CombatId_node_Persist.SetData((FSCombat)Persist, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.GrabsId:
					FSGrabsNode GrabsId_node_Persist = graph.AddNode<FSGrabsNode>();
					GetPort("Persist").Connect(GrabsId_node_Persist.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(GrabsId_node_Persist, assetPath);
					variableCount += GrabsId_node_Persist.SetData((FSGrabs)Persist, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.DataId:
					FSDataNode DataId_node_Persist = graph.AddNode<FSDataNode>();
					GetPort("Persist").Connect(DataId_node_Persist.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DataId_node_Persist, assetPath);
					variableCount += DataId_node_Persist.SetData((FSData)Persist, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ScratchId:
					FSScratchNode ScratchId_node_Persist = graph.AddNode<FSScratchNode>();
					GetPort("Persist").Connect(ScratchId_node_Persist.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ScratchId_node_Persist, assetPath);
					variableCount += ScratchId_node_Persist.SetData((FSScratch)Persist, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AnimId:
					FSAnimNode AnimId_node_Persist = graph.AddNode<FSAnimNode>();
					GetPort("Persist").Connect(AnimId_node_Persist.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AnimId_node_Persist, assetPath);
					variableCount += AnimId_node_Persist.SetData((FSAnim)Persist, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SpeedId:
					FSSpeedNode SpeedId_node_Persist = graph.AddNode<FSSpeedNode>();
					GetPort("Persist").Connect(SpeedId_node_Persist.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpeedId_node_Persist, assetPath);
					variableCount += SpeedId_node_Persist.SetData((FSSpeed)Persist, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.PhysicsId:
					FSPhysicsNode PhysicsId_node_Persist = graph.AddNode<FSPhysicsNode>();
					GetPort("Persist").Connect(PhysicsId_node_Persist.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(PhysicsId_node_Persist, assetPath);
					variableCount += PhysicsId_node_Persist.SetData((FSPhysics)Persist, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CollisionId:
					FSCollisionNode CollisionId_node_Persist = graph.AddNode<FSCollisionNode>();
					GetPort("Persist").Connect(CollisionId_node_Persist.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CollisionId_node_Persist, assetPath);
					variableCount += CollisionId_node_Persist.SetData((FSCollision)Persist, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.TimerId:
					FSTimerNode TimerId_node_Persist = graph.AddNode<FSTimerNode>();
					GetPort("Persist").Connect(TimerId_node_Persist.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(TimerId_node_Persist, assetPath);
					variableCount += TimerId_node_Persist.SetData((FSTimer)Persist, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.LagId:
					FSLagNode LagId_node_Persist = graph.AddNode<FSLagNode>();
					GetPort("Persist").Connect(LagId_node_Persist.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LagId_node_Persist, assetPath);
					variableCount += LagId_node_Persist.SetData((FSLag)Persist, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.EffectsId:
					FSEffectsNode EffectsId_node_Persist = graph.AddNode<FSEffectsNode>();
					GetPort("Persist").Connect(EffectsId_node_Persist.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EffectsId_node_Persist, assetPath);
					variableCount += EffectsId_node_Persist.SetData((FSEffects)Persist, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ColorsId:
					FSColorsNode ColorsId_node_Persist = graph.AddNode<FSColorsNode>();
					GetPort("Persist").Connect(ColorsId_node_Persist.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ColorsId_node_Persist, assetPath);
					variableCount += ColorsId_node_Persist.SetData((FSColors)Persist, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.OnHitId:
					FSOnHitNode OnHitId_node_Persist = graph.AddNode<FSOnHitNode>();
					GetPort("Persist").Connect(OnHitId_node_Persist.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnHitId_node_Persist, assetPath);
					variableCount += OnHitId_node_Persist.SetData((FSOnHit)Persist, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RandomId:
					FSRandomNode RandomId_node_Persist = graph.AddNode<FSRandomNode>();
					GetPort("Persist").Connect(RandomId_node_Persist.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RandomId_node_Persist, assetPath);
					variableCount += RandomId_node_Persist.SetData((FSRandom)Persist, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CameraId:
					FSCameraInfoNode CameraId_node_Persist = graph.AddNode<FSCameraInfoNode>();
					GetPort("Persist").Connect(CameraId_node_Persist.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CameraId_node_Persist, assetPath);
					variableCount += CameraId_node_Persist.SetData((FSCameraInfo)Persist, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SportsId:
					FSSportsNode SportsId_node_Persist = graph.AddNode<FSSportsNode>();
					GetPort("Persist").Connect(SportsId_node_Persist.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SportsId_node_Persist, assetPath);
					variableCount += SportsId_node_Persist.SetData((FSSports)Persist, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.Vector2Mag:
					FSVector2MagNode Vector2Mag_node_Persist = graph.AddNode<FSVector2MagNode>();
					GetPort("Persist").Connect(Vector2Mag_node_Persist.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(Vector2Mag_node_Persist, assetPath);
					variableCount += Vector2Mag_node_Persist.SetData((FSVector2Mag)Persist, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CPUHelpId:
					FSCpuHelpNode CPUHelpId_node_Persist = graph.AddNode<FSCpuHelpNode>();
					GetPort("Persist").Connect(CPUHelpId_node_Persist.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CPUHelpId_node_Persist, assetPath);
					variableCount += CPUHelpId_node_Persist.SetData((FSCpuHelp)Persist, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ItemId:
					FSItemNode ItemId_node_Persist = graph.AddNode<FSItemNode>();
					GetPort("Persist").Connect(ItemId_node_Persist.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ItemId_node_Persist, assetPath);
					variableCount += ItemId_node_Persist.SetData((FSItem)Persist, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ModeId:
					FSModeNode ModeId_node_Persist = graph.AddNode<FSModeNode>();
					GetPort("Persist").Connect(ModeId_node_Persist.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ModeId_node_Persist, assetPath);
					variableCount += ModeId_node_Persist.SetData((FSMode)Persist, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.JumpsId:
					FSJumpsNode JumpsId_node_Persist = graph.AddNode<FSJumpsNode>();
					GetPort("Persist").Connect(JumpsId_node_Persist.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(JumpsId_node_Persist, assetPath);
					variableCount += JumpsId_node_Persist.SetData((FSJumps)Persist, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RootAnimId:
					FSRootAnimNode RootAnimId_node_Persist = graph.AddNode<FSRootAnimNode>();
					GetPort("Persist").Connect(RootAnimId_node_Persist.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RootAnimId_node_Persist, assetPath);
					variableCount += RootAnimId_node_Persist.SetData((FSRootAnim)Persist, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FloatId:
					FSValueNode FloatId_node_Persist = graph.AddNode<FSValueNode>();
					GetPort("Persist").Connect(FloatId_node_Persist.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FloatId_node_Persist, assetPath);
					variableCount += FloatId_node_Persist.SetData((FSValue)Persist, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
			}
			++variableCount;
			
			MaxOut = data.MaxOut;
			return variableCount;
		}
		
		public new SAPersistLocalFX GetData()
		{
			SAPersistLocalFX objToReturn = new SAPersistLocalFX();
			objToReturn.TID = TypeId.PersistLocalFXId;
			objToReturn.Version = Version;
			objToReturn.Id = Id;
			if (GetPort("Persist").ConnectionCount > 0)
			{
				FloatSourceNode FloatSource_Node = (FloatSourceNode)GetPort("Persist").GetConnection(0).node;
				switch (FloatSource_Node.TID)
				{
					case FloatSource.TypeId.AgentId:
						FSAgentNode AgentId_FloatSource_Node = (FSAgentNode)GetPort("Persist").GetConnection(0).node;
						objToReturn.Persist = AgentId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.BonesId:
						FSBonesNode BonesId_FloatSource_Node = (FSBonesNode)GetPort("Persist").GetConnection(0).node;
						objToReturn.Persist = BonesId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AttackId:
						FSAttackNode AttackId_FloatSource_Node = (FSAttackNode)GetPort("Persist").GetConnection(0).node;
						objToReturn.Persist = AttackId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FrameId:
						FSFrameNode FrameId_FloatSource_Node = (FSFrameNode)GetPort("Persist").GetConnection(0).node;
						objToReturn.Persist = FrameId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.InputId:
						FSInputNode InputId_FloatSource_Node = (FSInputNode)GetPort("Persist").GetConnection(0).node;
						objToReturn.Persist = InputId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FuncId:
						FSFuncNode FuncId_FloatSource_Node = (FSFuncNode)GetPort("Persist").GetConnection(0).node;
						objToReturn.Persist = FuncId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.MovementId:
						FSMovementNode MovementId_FloatSource_Node = (FSMovementNode)GetPort("Persist").GetConnection(0).node;
						objToReturn.Persist = MovementId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CombatId:
						FSCombatNode CombatId_FloatSource_Node = (FSCombatNode)GetPort("Persist").GetConnection(0).node;
						objToReturn.Persist = CombatId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.GrabsId:
						FSGrabsNode GrabsId_FloatSource_Node = (FSGrabsNode)GetPort("Persist").GetConnection(0).node;
						objToReturn.Persist = GrabsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.DataId:
						FSDataNode DataId_FloatSource_Node = (FSDataNode)GetPort("Persist").GetConnection(0).node;
						objToReturn.Persist = DataId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ScratchId:
						FSScratchNode ScratchId_FloatSource_Node = (FSScratchNode)GetPort("Persist").GetConnection(0).node;
						objToReturn.Persist = ScratchId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AnimId:
						FSAnimNode AnimId_FloatSource_Node = (FSAnimNode)GetPort("Persist").GetConnection(0).node;
						objToReturn.Persist = AnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SpeedId:
						FSSpeedNode SpeedId_FloatSource_Node = (FSSpeedNode)GetPort("Persist").GetConnection(0).node;
						objToReturn.Persist = SpeedId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.PhysicsId:
						FSPhysicsNode PhysicsId_FloatSource_Node = (FSPhysicsNode)GetPort("Persist").GetConnection(0).node;
						objToReturn.Persist = PhysicsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CollisionId:
						FSCollisionNode CollisionId_FloatSource_Node = (FSCollisionNode)GetPort("Persist").GetConnection(0).node;
						objToReturn.Persist = CollisionId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.TimerId:
						FSTimerNode TimerId_FloatSource_Node = (FSTimerNode)GetPort("Persist").GetConnection(0).node;
						objToReturn.Persist = TimerId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.LagId:
						FSLagNode LagId_FloatSource_Node = (FSLagNode)GetPort("Persist").GetConnection(0).node;
						objToReturn.Persist = LagId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.EffectsId:
						FSEffectsNode EffectsId_FloatSource_Node = (FSEffectsNode)GetPort("Persist").GetConnection(0).node;
						objToReturn.Persist = EffectsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ColorsId:
						FSColorsNode ColorsId_FloatSource_Node = (FSColorsNode)GetPort("Persist").GetConnection(0).node;
						objToReturn.Persist = ColorsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.OnHitId:
						FSOnHitNode OnHitId_FloatSource_Node = (FSOnHitNode)GetPort("Persist").GetConnection(0).node;
						objToReturn.Persist = OnHitId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RandomId:
						FSRandomNode RandomId_FloatSource_Node = (FSRandomNode)GetPort("Persist").GetConnection(0).node;
						objToReturn.Persist = RandomId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CameraId:
						FSCameraInfoNode CameraId_FloatSource_Node = (FSCameraInfoNode)GetPort("Persist").GetConnection(0).node;
						objToReturn.Persist = CameraId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SportsId:
						FSSportsNode SportsId_FloatSource_Node = (FSSportsNode)GetPort("Persist").GetConnection(0).node;
						objToReturn.Persist = SportsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.Vector2Mag:
						FSVector2MagNode Vector2Mag_FloatSource_Node = (FSVector2MagNode)GetPort("Persist").GetConnection(0).node;
						objToReturn.Persist = Vector2Mag_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CPUHelpId:
						FSCpuHelpNode CPUHelpId_FloatSource_Node = (FSCpuHelpNode)GetPort("Persist").GetConnection(0).node;
						objToReturn.Persist = CPUHelpId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ItemId:
						FSItemNode ItemId_FloatSource_Node = (FSItemNode)GetPort("Persist").GetConnection(0).node;
						objToReturn.Persist = ItemId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ModeId:
						FSModeNode ModeId_FloatSource_Node = (FSModeNode)GetPort("Persist").GetConnection(0).node;
						objToReturn.Persist = ModeId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.JumpsId:
						FSJumpsNode JumpsId_FloatSource_Node = (FSJumpsNode)GetPort("Persist").GetConnection(0).node;
						objToReturn.Persist = JumpsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RootAnimId:
						FSRootAnimNode RootAnimId_FloatSource_Node = (FSRootAnimNode)GetPort("Persist").GetConnection(0).node;
						objToReturn.Persist = RootAnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FloatId:
						FSValueNode FloatId_FloatSource_Node = (FSValueNode)GetPort("Persist").GetConnection(0).node;
						objToReturn.Persist = FloatId_FloatSource_Node.GetData();
					break;
				}
			}
			objToReturn.MaxOut = MaxOut;
			return objToReturn;
		}
	}
}

