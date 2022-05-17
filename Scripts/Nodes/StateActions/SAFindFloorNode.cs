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
	public class SAFindFloorNode : StateActionNode
	{
		[Input(connectionType = ConnectionType.Override)] public StateAction NodeInput;
		public float SeekRange;
		[Output(connectionType = ConnectionType.Override)] public FloatSource Range;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.FindFloorId;
			Version = 1;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SAFindFloor data, MovesetGraph graph, string assetPath, Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SAFindFloor));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			SeekRange = data.SeekRange;
			Range = data.Range;
			
			switch (Range.TID)
			{
				case FloatSource.TypeId.AgentId:
					FSAgentNode AgentId_node_Range = graph.AddNode<FSAgentNode>();
					GetPort("Range").Connect(AgentId_node_Range.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AgentId_node_Range, assetPath);
					variableCount += AgentId_node_Range.SetData((FSAgent)Range, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.BonesId:
					FSBonesNode BonesId_node_Range = graph.AddNode<FSBonesNode>();
					GetPort("Range").Connect(BonesId_node_Range.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BonesId_node_Range, assetPath);
					variableCount += BonesId_node_Range.SetData((FSBones)Range, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AttackId:
					FSAttackNode AttackId_node_Range = graph.AddNode<FSAttackNode>();
					GetPort("Range").Connect(AttackId_node_Range.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AttackId_node_Range, assetPath);
					variableCount += AttackId_node_Range.SetData((FSAttack)Range, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FrameId:
					FSFrameNode FrameId_node_Range = graph.AddNode<FSFrameNode>();
					GetPort("Range").Connect(FrameId_node_Range.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FrameId_node_Range, assetPath);
					variableCount += FrameId_node_Range.SetData((FSFrame)Range, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.InputId:
					FSInputNode InputId_node_Range = graph.AddNode<FSInputNode>();
					GetPort("Range").Connect(InputId_node_Range.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputId_node_Range, assetPath);
					variableCount += InputId_node_Range.SetData((FSInput)Range, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FuncId:
					FSFuncNode FuncId_node_Range = graph.AddNode<FSFuncNode>();
					GetPort("Range").Connect(FuncId_node_Range.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FuncId_node_Range, assetPath);
					variableCount += FuncId_node_Range.SetData((FSFunc)Range, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.MovementId:
					FSMovementNode MovementId_node_Range = graph.AddNode<FSMovementNode>();
					GetPort("Range").Connect(MovementId_node_Range.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(MovementId_node_Range, assetPath);
					variableCount += MovementId_node_Range.SetData((FSMovement)Range, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CombatId:
					FSCombatNode CombatId_node_Range = graph.AddNode<FSCombatNode>();
					GetPort("Range").Connect(CombatId_node_Range.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CombatId_node_Range, assetPath);
					variableCount += CombatId_node_Range.SetData((FSCombat)Range, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.GrabsId:
					FSGrabsNode GrabsId_node_Range = graph.AddNode<FSGrabsNode>();
					GetPort("Range").Connect(GrabsId_node_Range.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(GrabsId_node_Range, assetPath);
					variableCount += GrabsId_node_Range.SetData((FSGrabs)Range, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.DataId:
					FSDataNode DataId_node_Range = graph.AddNode<FSDataNode>();
					GetPort("Range").Connect(DataId_node_Range.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DataId_node_Range, assetPath);
					variableCount += DataId_node_Range.SetData((FSData)Range, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ScratchId:
					FSScratchNode ScratchId_node_Range = graph.AddNode<FSScratchNode>();
					GetPort("Range").Connect(ScratchId_node_Range.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ScratchId_node_Range, assetPath);
					variableCount += ScratchId_node_Range.SetData((FSScratch)Range, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AnimId:
					FSAnimNode AnimId_node_Range = graph.AddNode<FSAnimNode>();
					GetPort("Range").Connect(AnimId_node_Range.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AnimId_node_Range, assetPath);
					variableCount += AnimId_node_Range.SetData((FSAnim)Range, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SpeedId:
					FSSpeedNode SpeedId_node_Range = graph.AddNode<FSSpeedNode>();
					GetPort("Range").Connect(SpeedId_node_Range.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpeedId_node_Range, assetPath);
					variableCount += SpeedId_node_Range.SetData((FSSpeed)Range, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.PhysicsId:
					FSPhysicsNode PhysicsId_node_Range = graph.AddNode<FSPhysicsNode>();
					GetPort("Range").Connect(PhysicsId_node_Range.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(PhysicsId_node_Range, assetPath);
					variableCount += PhysicsId_node_Range.SetData((FSPhysics)Range, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CollisionId:
					FSCollisionNode CollisionId_node_Range = graph.AddNode<FSCollisionNode>();
					GetPort("Range").Connect(CollisionId_node_Range.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CollisionId_node_Range, assetPath);
					variableCount += CollisionId_node_Range.SetData((FSCollision)Range, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.TimerId:
					FSTimerNode TimerId_node_Range = graph.AddNode<FSTimerNode>();
					GetPort("Range").Connect(TimerId_node_Range.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(TimerId_node_Range, assetPath);
					variableCount += TimerId_node_Range.SetData((FSTimer)Range, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.LagId:
					FSLagNode LagId_node_Range = graph.AddNode<FSLagNode>();
					GetPort("Range").Connect(LagId_node_Range.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LagId_node_Range, assetPath);
					variableCount += LagId_node_Range.SetData((FSLag)Range, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.EffectsId:
					FSEffectsNode EffectsId_node_Range = graph.AddNode<FSEffectsNode>();
					GetPort("Range").Connect(EffectsId_node_Range.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EffectsId_node_Range, assetPath);
					variableCount += EffectsId_node_Range.SetData((FSEffects)Range, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ColorsId:
					FSColorsNode ColorsId_node_Range = graph.AddNode<FSColorsNode>();
					GetPort("Range").Connect(ColorsId_node_Range.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ColorsId_node_Range, assetPath);
					variableCount += ColorsId_node_Range.SetData((FSColors)Range, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.OnHitId:
					FSOnHitNode OnHitId_node_Range = graph.AddNode<FSOnHitNode>();
					GetPort("Range").Connect(OnHitId_node_Range.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnHitId_node_Range, assetPath);
					variableCount += OnHitId_node_Range.SetData((FSOnHit)Range, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RandomId:
					FSRandomNode RandomId_node_Range = graph.AddNode<FSRandomNode>();
					GetPort("Range").Connect(RandomId_node_Range.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RandomId_node_Range, assetPath);
					variableCount += RandomId_node_Range.SetData((FSRandom)Range, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CameraId:
					FSCameraInfoNode CameraId_node_Range = graph.AddNode<FSCameraInfoNode>();
					GetPort("Range").Connect(CameraId_node_Range.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CameraId_node_Range, assetPath);
					variableCount += CameraId_node_Range.SetData((FSCameraInfo)Range, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SportsId:
					FSSportsNode SportsId_node_Range = graph.AddNode<FSSportsNode>();
					GetPort("Range").Connect(SportsId_node_Range.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SportsId_node_Range, assetPath);
					variableCount += SportsId_node_Range.SetData((FSSports)Range, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.Vector2Mag:
					FSVector2MagNode Vector2Mag_node_Range = graph.AddNode<FSVector2MagNode>();
					GetPort("Range").Connect(Vector2Mag_node_Range.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(Vector2Mag_node_Range, assetPath);
					variableCount += Vector2Mag_node_Range.SetData((FSVector2Mag)Range, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CPUHelpId:
					FSCpuHelpNode CPUHelpId_node_Range = graph.AddNode<FSCpuHelpNode>();
					GetPort("Range").Connect(CPUHelpId_node_Range.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CPUHelpId_node_Range, assetPath);
					variableCount += CPUHelpId_node_Range.SetData((FSCpuHelp)Range, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ItemId:
					FSItemNode ItemId_node_Range = graph.AddNode<FSItemNode>();
					GetPort("Range").Connect(ItemId_node_Range.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ItemId_node_Range, assetPath);
					variableCount += ItemId_node_Range.SetData((FSItem)Range, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ModeId:
					FSModeNode ModeId_node_Range = graph.AddNode<FSModeNode>();
					GetPort("Range").Connect(ModeId_node_Range.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ModeId_node_Range, assetPath);
					variableCount += ModeId_node_Range.SetData((FSMode)Range, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.JumpsId:
					FSJumpsNode JumpsId_node_Range = graph.AddNode<FSJumpsNode>();
					GetPort("Range").Connect(JumpsId_node_Range.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(JumpsId_node_Range, assetPath);
					variableCount += JumpsId_node_Range.SetData((FSJumps)Range, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RootAnimId:
					FSRootAnimNode RootAnimId_node_Range = graph.AddNode<FSRootAnimNode>();
					GetPort("Range").Connect(RootAnimId_node_Range.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RootAnimId_node_Range, assetPath);
					variableCount += RootAnimId_node_Range.SetData((FSRootAnim)Range, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FloatId:
					FSValueNode FloatId_node_Range = graph.AddNode<FSValueNode>();
					GetPort("Range").Connect(FloatId_node_Range.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FloatId_node_Range, assetPath);
					variableCount += FloatId_node_Range.SetData((FSValue)Range, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
			}
			
			return variableCount;
		}
		
		public new SAFindFloor GetData()
		{
			SAFindFloor objToReturn = new SAFindFloor();
			objToReturn.TID = TypeId.FindFloorId;
			objToReturn.Version = Version;
			objToReturn.SeekRange = SeekRange;
			if (GetPort("Range").ConnectionCount > 0)
			{
				FloatSourceNode FloatSource_Node = (FloatSourceNode)GetPort("Range").GetConnection(0).node;
				switch (FloatSource_Node.TID)
				{
					case FloatSource.TypeId.AgentId:
						FSAgentNode AgentId_FloatSource_Node = (FSAgentNode)GetPort("Range").GetConnection(0).node;
						objToReturn.Range = AgentId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.BonesId:
						FSBonesNode BonesId_FloatSource_Node = (FSBonesNode)GetPort("Range").GetConnection(0).node;
						objToReturn.Range = BonesId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AttackId:
						FSAttackNode AttackId_FloatSource_Node = (FSAttackNode)GetPort("Range").GetConnection(0).node;
						objToReturn.Range = AttackId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FrameId:
						FSFrameNode FrameId_FloatSource_Node = (FSFrameNode)GetPort("Range").GetConnection(0).node;
						objToReturn.Range = FrameId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.InputId:
						FSInputNode InputId_FloatSource_Node = (FSInputNode)GetPort("Range").GetConnection(0).node;
						objToReturn.Range = InputId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FuncId:
						FSFuncNode FuncId_FloatSource_Node = (FSFuncNode)GetPort("Range").GetConnection(0).node;
						objToReturn.Range = FuncId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.MovementId:
						FSMovementNode MovementId_FloatSource_Node = (FSMovementNode)GetPort("Range").GetConnection(0).node;
						objToReturn.Range = MovementId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CombatId:
						FSCombatNode CombatId_FloatSource_Node = (FSCombatNode)GetPort("Range").GetConnection(0).node;
						objToReturn.Range = CombatId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.GrabsId:
						FSGrabsNode GrabsId_FloatSource_Node = (FSGrabsNode)GetPort("Range").GetConnection(0).node;
						objToReturn.Range = GrabsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.DataId:
						FSDataNode DataId_FloatSource_Node = (FSDataNode)GetPort("Range").GetConnection(0).node;
						objToReturn.Range = DataId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ScratchId:
						FSScratchNode ScratchId_FloatSource_Node = (FSScratchNode)GetPort("Range").GetConnection(0).node;
						objToReturn.Range = ScratchId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AnimId:
						FSAnimNode AnimId_FloatSource_Node = (FSAnimNode)GetPort("Range").GetConnection(0).node;
						objToReturn.Range = AnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SpeedId:
						FSSpeedNode SpeedId_FloatSource_Node = (FSSpeedNode)GetPort("Range").GetConnection(0).node;
						objToReturn.Range = SpeedId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.PhysicsId:
						FSPhysicsNode PhysicsId_FloatSource_Node = (FSPhysicsNode)GetPort("Range").GetConnection(0).node;
						objToReturn.Range = PhysicsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CollisionId:
						FSCollisionNode CollisionId_FloatSource_Node = (FSCollisionNode)GetPort("Range").GetConnection(0).node;
						objToReturn.Range = CollisionId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.TimerId:
						FSTimerNode TimerId_FloatSource_Node = (FSTimerNode)GetPort("Range").GetConnection(0).node;
						objToReturn.Range = TimerId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.LagId:
						FSLagNode LagId_FloatSource_Node = (FSLagNode)GetPort("Range").GetConnection(0).node;
						objToReturn.Range = LagId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.EffectsId:
						FSEffectsNode EffectsId_FloatSource_Node = (FSEffectsNode)GetPort("Range").GetConnection(0).node;
						objToReturn.Range = EffectsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ColorsId:
						FSColorsNode ColorsId_FloatSource_Node = (FSColorsNode)GetPort("Range").GetConnection(0).node;
						objToReturn.Range = ColorsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.OnHitId:
						FSOnHitNode OnHitId_FloatSource_Node = (FSOnHitNode)GetPort("Range").GetConnection(0).node;
						objToReturn.Range = OnHitId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RandomId:
						FSRandomNode RandomId_FloatSource_Node = (FSRandomNode)GetPort("Range").GetConnection(0).node;
						objToReturn.Range = RandomId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CameraId:
						FSCameraInfoNode CameraId_FloatSource_Node = (FSCameraInfoNode)GetPort("Range").GetConnection(0).node;
						objToReturn.Range = CameraId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SportsId:
						FSSportsNode SportsId_FloatSource_Node = (FSSportsNode)GetPort("Range").GetConnection(0).node;
						objToReturn.Range = SportsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.Vector2Mag:
						FSVector2MagNode Vector2Mag_FloatSource_Node = (FSVector2MagNode)GetPort("Range").GetConnection(0).node;
						objToReturn.Range = Vector2Mag_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CPUHelpId:
						FSCpuHelpNode CPUHelpId_FloatSource_Node = (FSCpuHelpNode)GetPort("Range").GetConnection(0).node;
						objToReturn.Range = CPUHelpId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ItemId:
						FSItemNode ItemId_FloatSource_Node = (FSItemNode)GetPort("Range").GetConnection(0).node;
						objToReturn.Range = ItemId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ModeId:
						FSModeNode ModeId_FloatSource_Node = (FSModeNode)GetPort("Range").GetConnection(0).node;
						objToReturn.Range = ModeId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.JumpsId:
						FSJumpsNode JumpsId_FloatSource_Node = (FSJumpsNode)GetPort("Range").GetConnection(0).node;
						objToReturn.Range = JumpsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RootAnimId:
						FSRootAnimNode RootAnimId_FloatSource_Node = (FSRootAnimNode)GetPort("Range").GetConnection(0).node;
						objToReturn.Range = RootAnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FloatId:
						FSValueNode FloatId_FloatSource_Node = (FSValueNode)GetPort("Range").GetConnection(0).node;
						objToReturn.Range = FloatId_FloatSource_Node.GetData();
					break;
				}
			}
			return objToReturn;
		}
	}
}

