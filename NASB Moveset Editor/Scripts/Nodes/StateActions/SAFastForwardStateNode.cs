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
	public class SAFastForwardStateNode : StateActionNode
	{
		[Output] public FloatSource Frames;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.FastForwardId;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SAFastForwardState data, MovesetGraph graph, string assetPath, Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SAFastForwardState));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			Frames = data.Frames;
			
			switch (Frames.TID)
			{
				case FloatSource.TypeId.AgentId:
					FSAgentNode AgentId_node_Frames = graph.AddNode<FSAgentNode>();
					GetPort("Frames").Connect(AgentId_node_Frames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AgentId_node_Frames, assetPath);
					variableCount += AgentId_node_Frames.SetData((FSAgent)Frames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.BonesId:
					FSBonesNode BonesId_node_Frames = graph.AddNode<FSBonesNode>();
					GetPort("Frames").Connect(BonesId_node_Frames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BonesId_node_Frames, assetPath);
					variableCount += BonesId_node_Frames.SetData((FSBones)Frames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AttackId:
					FSAttackNode AttackId_node_Frames = graph.AddNode<FSAttackNode>();
					GetPort("Frames").Connect(AttackId_node_Frames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AttackId_node_Frames, assetPath);
					variableCount += AttackId_node_Frames.SetData((FSAttack)Frames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FrameId:
					FSFrameNode FrameId_node_Frames = graph.AddNode<FSFrameNode>();
					GetPort("Frames").Connect(FrameId_node_Frames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FrameId_node_Frames, assetPath);
					variableCount += FrameId_node_Frames.SetData((FSFrame)Frames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.InputId:
					FSInputNode InputId_node_Frames = graph.AddNode<FSInputNode>();
					GetPort("Frames").Connect(InputId_node_Frames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputId_node_Frames, assetPath);
					variableCount += InputId_node_Frames.SetData((FSInput)Frames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FuncId:
					FSFuncNode FuncId_node_Frames = graph.AddNode<FSFuncNode>();
					GetPort("Frames").Connect(FuncId_node_Frames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FuncId_node_Frames, assetPath);
					variableCount += FuncId_node_Frames.SetData((FSFunc)Frames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.MovementId:
					FSMovementNode MovementId_node_Frames = graph.AddNode<FSMovementNode>();
					GetPort("Frames").Connect(MovementId_node_Frames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(MovementId_node_Frames, assetPath);
					variableCount += MovementId_node_Frames.SetData((FSMovement)Frames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CombatId:
					FSCombatNode CombatId_node_Frames = graph.AddNode<FSCombatNode>();
					GetPort("Frames").Connect(CombatId_node_Frames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CombatId_node_Frames, assetPath);
					variableCount += CombatId_node_Frames.SetData((FSCombat)Frames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.GrabsId:
					FSGrabsNode GrabsId_node_Frames = graph.AddNode<FSGrabsNode>();
					GetPort("Frames").Connect(GrabsId_node_Frames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(GrabsId_node_Frames, assetPath);
					variableCount += GrabsId_node_Frames.SetData((FSGrabs)Frames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.DataId:
					FSDataNode DataId_node_Frames = graph.AddNode<FSDataNode>();
					GetPort("Frames").Connect(DataId_node_Frames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DataId_node_Frames, assetPath);
					variableCount += DataId_node_Frames.SetData((FSData)Frames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ScratchId:
					FSScratchNode ScratchId_node_Frames = graph.AddNode<FSScratchNode>();
					GetPort("Frames").Connect(ScratchId_node_Frames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ScratchId_node_Frames, assetPath);
					variableCount += ScratchId_node_Frames.SetData((FSScratch)Frames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AnimId:
					FSAnimNode AnimId_node_Frames = graph.AddNode<FSAnimNode>();
					GetPort("Frames").Connect(AnimId_node_Frames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AnimId_node_Frames, assetPath);
					variableCount += AnimId_node_Frames.SetData((FSAnim)Frames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SpeedId:
					FSSpeedNode SpeedId_node_Frames = graph.AddNode<FSSpeedNode>();
					GetPort("Frames").Connect(SpeedId_node_Frames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpeedId_node_Frames, assetPath);
					variableCount += SpeedId_node_Frames.SetData((FSSpeed)Frames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.PhysicsId:
					FSPhysicsNode PhysicsId_node_Frames = graph.AddNode<FSPhysicsNode>();
					GetPort("Frames").Connect(PhysicsId_node_Frames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(PhysicsId_node_Frames, assetPath);
					variableCount += PhysicsId_node_Frames.SetData((FSPhysics)Frames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CollisionId:
					FSCollisionNode CollisionId_node_Frames = graph.AddNode<FSCollisionNode>();
					GetPort("Frames").Connect(CollisionId_node_Frames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CollisionId_node_Frames, assetPath);
					variableCount += CollisionId_node_Frames.SetData((FSCollision)Frames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.TimerId:
					FSTimerNode TimerId_node_Frames = graph.AddNode<FSTimerNode>();
					GetPort("Frames").Connect(TimerId_node_Frames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(TimerId_node_Frames, assetPath);
					variableCount += TimerId_node_Frames.SetData((FSTimer)Frames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.LagId:
					FSLagNode LagId_node_Frames = graph.AddNode<FSLagNode>();
					GetPort("Frames").Connect(LagId_node_Frames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LagId_node_Frames, assetPath);
					variableCount += LagId_node_Frames.SetData((FSLag)Frames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.EffectsId:
					FSEffectsNode EffectsId_node_Frames = graph.AddNode<FSEffectsNode>();
					GetPort("Frames").Connect(EffectsId_node_Frames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EffectsId_node_Frames, assetPath);
					variableCount += EffectsId_node_Frames.SetData((FSEffects)Frames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ColorsId:
					FSColorsNode ColorsId_node_Frames = graph.AddNode<FSColorsNode>();
					GetPort("Frames").Connect(ColorsId_node_Frames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ColorsId_node_Frames, assetPath);
					variableCount += ColorsId_node_Frames.SetData((FSColors)Frames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.OnHitId:
					FSOnHitNode OnHitId_node_Frames = graph.AddNode<FSOnHitNode>();
					GetPort("Frames").Connect(OnHitId_node_Frames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnHitId_node_Frames, assetPath);
					variableCount += OnHitId_node_Frames.SetData((FSOnHit)Frames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RandomId:
					FSRandomNode RandomId_node_Frames = graph.AddNode<FSRandomNode>();
					GetPort("Frames").Connect(RandomId_node_Frames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RandomId_node_Frames, assetPath);
					variableCount += RandomId_node_Frames.SetData((FSRandom)Frames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CameraId:
					FSCameraInfoNode CameraId_node_Frames = graph.AddNode<FSCameraInfoNode>();
					GetPort("Frames").Connect(CameraId_node_Frames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CameraId_node_Frames, assetPath);
					variableCount += CameraId_node_Frames.SetData((FSCameraInfo)Frames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SportsId:
					FSSportsNode SportsId_node_Frames = graph.AddNode<FSSportsNode>();
					GetPort("Frames").Connect(SportsId_node_Frames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SportsId_node_Frames, assetPath);
					variableCount += SportsId_node_Frames.SetData((FSSports)Frames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.Vector2Mag:
					FSVector2MagNode Vector2Mag_node_Frames = graph.AddNode<FSVector2MagNode>();
					GetPort("Frames").Connect(Vector2Mag_node_Frames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(Vector2Mag_node_Frames, assetPath);
					variableCount += Vector2Mag_node_Frames.SetData((FSVector2Mag)Frames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CPUHelpId:
					FSCpuHelpNode CPUHelpId_node_Frames = graph.AddNode<FSCpuHelpNode>();
					GetPort("Frames").Connect(CPUHelpId_node_Frames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CPUHelpId_node_Frames, assetPath);
					variableCount += CPUHelpId_node_Frames.SetData((FSCpuHelp)Frames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ItemId:
					FSItemNode ItemId_node_Frames = graph.AddNode<FSItemNode>();
					GetPort("Frames").Connect(ItemId_node_Frames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ItemId_node_Frames, assetPath);
					variableCount += ItemId_node_Frames.SetData((FSItem)Frames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ModeId:
					FSModeNode ModeId_node_Frames = graph.AddNode<FSModeNode>();
					GetPort("Frames").Connect(ModeId_node_Frames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ModeId_node_Frames, assetPath);
					variableCount += ModeId_node_Frames.SetData((FSMode)Frames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.JumpsId:
					FSJumpsNode JumpsId_node_Frames = graph.AddNode<FSJumpsNode>();
					GetPort("Frames").Connect(JumpsId_node_Frames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(JumpsId_node_Frames, assetPath);
					variableCount += JumpsId_node_Frames.SetData((FSJumps)Frames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RootAnimId:
					FSRootAnimNode RootAnimId_node_Frames = graph.AddNode<FSRootAnimNode>();
					GetPort("Frames").Connect(RootAnimId_node_Frames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RootAnimId_node_Frames, assetPath);
					variableCount += RootAnimId_node_Frames.SetData((FSRootAnim)Frames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FloatId:
					FSValueNode FloatId_node_Frames = graph.AddNode<FSValueNode>();
					GetPort("Frames").Connect(FloatId_node_Frames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FloatId_node_Frames, assetPath);
					variableCount += FloatId_node_Frames.SetData((FSValue)Frames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
			}
			
			return variableCount;
		}
		
		public new SAFastForwardState GetData()
		{
			SAFastForwardState objToReturn = new SAFastForwardState();
			objToReturn.TID = TypeId.FastForwardId;
			objToReturn.Version = Version;
			if (GetPort("Frames").ConnectionCount > 0)
			{
				FloatSourceNode FloatSource_Node = (FloatSourceNode)GetPort("Frames").GetConnection(0).node;
				switch (FloatSource_Node.TID)
				{
					case FloatSource.TypeId.AgentId:
						FSAgentNode AgentId_FloatSource_Node = (FSAgentNode)GetPort("Frames").GetConnection(0).node;
						objToReturn.Frames = AgentId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.BonesId:
						FSBonesNode BonesId_FloatSource_Node = (FSBonesNode)GetPort("Frames").GetConnection(0).node;
						objToReturn.Frames = BonesId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AttackId:
						FSAttackNode AttackId_FloatSource_Node = (FSAttackNode)GetPort("Frames").GetConnection(0).node;
						objToReturn.Frames = AttackId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FrameId:
						FSFrameNode FrameId_FloatSource_Node = (FSFrameNode)GetPort("Frames").GetConnection(0).node;
						objToReturn.Frames = FrameId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.InputId:
						FSInputNode InputId_FloatSource_Node = (FSInputNode)GetPort("Frames").GetConnection(0).node;
						objToReturn.Frames = InputId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FuncId:
						FSFuncNode FuncId_FloatSource_Node = (FSFuncNode)GetPort("Frames").GetConnection(0).node;
						objToReturn.Frames = FuncId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.MovementId:
						FSMovementNode MovementId_FloatSource_Node = (FSMovementNode)GetPort("Frames").GetConnection(0).node;
						objToReturn.Frames = MovementId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CombatId:
						FSCombatNode CombatId_FloatSource_Node = (FSCombatNode)GetPort("Frames").GetConnection(0).node;
						objToReturn.Frames = CombatId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.GrabsId:
						FSGrabsNode GrabsId_FloatSource_Node = (FSGrabsNode)GetPort("Frames").GetConnection(0).node;
						objToReturn.Frames = GrabsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.DataId:
						FSDataNode DataId_FloatSource_Node = (FSDataNode)GetPort("Frames").GetConnection(0).node;
						objToReturn.Frames = DataId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ScratchId:
						FSScratchNode ScratchId_FloatSource_Node = (FSScratchNode)GetPort("Frames").GetConnection(0).node;
						objToReturn.Frames = ScratchId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AnimId:
						FSAnimNode AnimId_FloatSource_Node = (FSAnimNode)GetPort("Frames").GetConnection(0).node;
						objToReturn.Frames = AnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SpeedId:
						FSSpeedNode SpeedId_FloatSource_Node = (FSSpeedNode)GetPort("Frames").GetConnection(0).node;
						objToReturn.Frames = SpeedId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.PhysicsId:
						FSPhysicsNode PhysicsId_FloatSource_Node = (FSPhysicsNode)GetPort("Frames").GetConnection(0).node;
						objToReturn.Frames = PhysicsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CollisionId:
						FSCollisionNode CollisionId_FloatSource_Node = (FSCollisionNode)GetPort("Frames").GetConnection(0).node;
						objToReturn.Frames = CollisionId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.TimerId:
						FSTimerNode TimerId_FloatSource_Node = (FSTimerNode)GetPort("Frames").GetConnection(0).node;
						objToReturn.Frames = TimerId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.LagId:
						FSLagNode LagId_FloatSource_Node = (FSLagNode)GetPort("Frames").GetConnection(0).node;
						objToReturn.Frames = LagId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.EffectsId:
						FSEffectsNode EffectsId_FloatSource_Node = (FSEffectsNode)GetPort("Frames").GetConnection(0).node;
						objToReturn.Frames = EffectsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ColorsId:
						FSColorsNode ColorsId_FloatSource_Node = (FSColorsNode)GetPort("Frames").GetConnection(0).node;
						objToReturn.Frames = ColorsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.OnHitId:
						FSOnHitNode OnHitId_FloatSource_Node = (FSOnHitNode)GetPort("Frames").GetConnection(0).node;
						objToReturn.Frames = OnHitId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RandomId:
						FSRandomNode RandomId_FloatSource_Node = (FSRandomNode)GetPort("Frames").GetConnection(0).node;
						objToReturn.Frames = RandomId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CameraId:
						FSCameraInfoNode CameraId_FloatSource_Node = (FSCameraInfoNode)GetPort("Frames").GetConnection(0).node;
						objToReturn.Frames = CameraId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SportsId:
						FSSportsNode SportsId_FloatSource_Node = (FSSportsNode)GetPort("Frames").GetConnection(0).node;
						objToReturn.Frames = SportsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.Vector2Mag:
						FSVector2MagNode Vector2Mag_FloatSource_Node = (FSVector2MagNode)GetPort("Frames").GetConnection(0).node;
						objToReturn.Frames = Vector2Mag_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CPUHelpId:
						FSCpuHelpNode CPUHelpId_FloatSource_Node = (FSCpuHelpNode)GetPort("Frames").GetConnection(0).node;
						objToReturn.Frames = CPUHelpId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ItemId:
						FSItemNode ItemId_FloatSource_Node = (FSItemNode)GetPort("Frames").GetConnection(0).node;
						objToReturn.Frames = ItemId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ModeId:
						FSModeNode ModeId_FloatSource_Node = (FSModeNode)GetPort("Frames").GetConnection(0).node;
						objToReturn.Frames = ModeId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.JumpsId:
						FSJumpsNode JumpsId_FloatSource_Node = (FSJumpsNode)GetPort("Frames").GetConnection(0).node;
						objToReturn.Frames = JumpsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RootAnimId:
						FSRootAnimNode RootAnimId_FloatSource_Node = (FSRootAnimNode)GetPort("Frames").GetConnection(0).node;
						objToReturn.Frames = RootAnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FloatId:
						FSValueNode FloatId_FloatSource_Node = (FSValueNode)GetPort("Frames").GetConnection(0).node;
						objToReturn.Frames = FloatId_FloatSource_Node.GetData();
					break;
				}
			}
			return objToReturn;
		}
	}
}

