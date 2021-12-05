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
using static NASB_Parser.Jumps.Jump;

namespace NASB_Moveset_Editor.Jumps
{
	public class HeightJumpNode : JumpNode
	{
		[Output(connectionType = ConnectionType.Override)] public FloatSource Height;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.HeightId;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(HeightJump data, MovesetGraph graph, string assetPath, Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(HeightJump));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			Height = data.Height;
			
			switch (Height.TID)
			{
				case FloatSource.TypeId.AgentId:
					FSAgentNode AgentId_node_Height = graph.AddNode<FSAgentNode>();
					GetPort("Height").Connect(AgentId_node_Height.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AgentId_node_Height, assetPath);
					variableCount += AgentId_node_Height.SetData((FSAgent)Height, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.BonesId:
					FSBonesNode BonesId_node_Height = graph.AddNode<FSBonesNode>();
					GetPort("Height").Connect(BonesId_node_Height.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BonesId_node_Height, assetPath);
					variableCount += BonesId_node_Height.SetData((FSBones)Height, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AttackId:
					FSAttackNode AttackId_node_Height = graph.AddNode<FSAttackNode>();
					GetPort("Height").Connect(AttackId_node_Height.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AttackId_node_Height, assetPath);
					variableCount += AttackId_node_Height.SetData((FSAttack)Height, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FrameId:
					FSFrameNode FrameId_node_Height = graph.AddNode<FSFrameNode>();
					GetPort("Height").Connect(FrameId_node_Height.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FrameId_node_Height, assetPath);
					variableCount += FrameId_node_Height.SetData((FSFrame)Height, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.InputId:
					FSInputNode InputId_node_Height = graph.AddNode<FSInputNode>();
					GetPort("Height").Connect(InputId_node_Height.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputId_node_Height, assetPath);
					variableCount += InputId_node_Height.SetData((FSInput)Height, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FuncId:
					FSFuncNode FuncId_node_Height = graph.AddNode<FSFuncNode>();
					GetPort("Height").Connect(FuncId_node_Height.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FuncId_node_Height, assetPath);
					variableCount += FuncId_node_Height.SetData((FSFunc)Height, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.MovementId:
					FSMovementNode MovementId_node_Height = graph.AddNode<FSMovementNode>();
					GetPort("Height").Connect(MovementId_node_Height.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(MovementId_node_Height, assetPath);
					variableCount += MovementId_node_Height.SetData((FSMovement)Height, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CombatId:
					FSCombatNode CombatId_node_Height = graph.AddNode<FSCombatNode>();
					GetPort("Height").Connect(CombatId_node_Height.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CombatId_node_Height, assetPath);
					variableCount += CombatId_node_Height.SetData((FSCombat)Height, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.GrabsId:
					FSGrabsNode GrabsId_node_Height = graph.AddNode<FSGrabsNode>();
					GetPort("Height").Connect(GrabsId_node_Height.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(GrabsId_node_Height, assetPath);
					variableCount += GrabsId_node_Height.SetData((FSGrabs)Height, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.DataId:
					FSDataNode DataId_node_Height = graph.AddNode<FSDataNode>();
					GetPort("Height").Connect(DataId_node_Height.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DataId_node_Height, assetPath);
					variableCount += DataId_node_Height.SetData((FSData)Height, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ScratchId:
					FSScratchNode ScratchId_node_Height = graph.AddNode<FSScratchNode>();
					GetPort("Height").Connect(ScratchId_node_Height.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ScratchId_node_Height, assetPath);
					variableCount += ScratchId_node_Height.SetData((FSScratch)Height, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AnimId:
					FSAnimNode AnimId_node_Height = graph.AddNode<FSAnimNode>();
					GetPort("Height").Connect(AnimId_node_Height.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AnimId_node_Height, assetPath);
					variableCount += AnimId_node_Height.SetData((FSAnim)Height, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SpeedId:
					FSSpeedNode SpeedId_node_Height = graph.AddNode<FSSpeedNode>();
					GetPort("Height").Connect(SpeedId_node_Height.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpeedId_node_Height, assetPath);
					variableCount += SpeedId_node_Height.SetData((FSSpeed)Height, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.PhysicsId:
					FSPhysicsNode PhysicsId_node_Height = graph.AddNode<FSPhysicsNode>();
					GetPort("Height").Connect(PhysicsId_node_Height.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(PhysicsId_node_Height, assetPath);
					variableCount += PhysicsId_node_Height.SetData((FSPhysics)Height, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CollisionId:
					FSCollisionNode CollisionId_node_Height = graph.AddNode<FSCollisionNode>();
					GetPort("Height").Connect(CollisionId_node_Height.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CollisionId_node_Height, assetPath);
					variableCount += CollisionId_node_Height.SetData((FSCollision)Height, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.TimerId:
					FSTimerNode TimerId_node_Height = graph.AddNode<FSTimerNode>();
					GetPort("Height").Connect(TimerId_node_Height.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(TimerId_node_Height, assetPath);
					variableCount += TimerId_node_Height.SetData((FSTimer)Height, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.LagId:
					FSLagNode LagId_node_Height = graph.AddNode<FSLagNode>();
					GetPort("Height").Connect(LagId_node_Height.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LagId_node_Height, assetPath);
					variableCount += LagId_node_Height.SetData((FSLag)Height, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.EffectsId:
					FSEffectsNode EffectsId_node_Height = graph.AddNode<FSEffectsNode>();
					GetPort("Height").Connect(EffectsId_node_Height.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EffectsId_node_Height, assetPath);
					variableCount += EffectsId_node_Height.SetData((FSEffects)Height, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ColorsId:
					FSColorsNode ColorsId_node_Height = graph.AddNode<FSColorsNode>();
					GetPort("Height").Connect(ColorsId_node_Height.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ColorsId_node_Height, assetPath);
					variableCount += ColorsId_node_Height.SetData((FSColors)Height, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.OnHitId:
					FSOnHitNode OnHitId_node_Height = graph.AddNode<FSOnHitNode>();
					GetPort("Height").Connect(OnHitId_node_Height.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnHitId_node_Height, assetPath);
					variableCount += OnHitId_node_Height.SetData((FSOnHit)Height, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RandomId:
					FSRandomNode RandomId_node_Height = graph.AddNode<FSRandomNode>();
					GetPort("Height").Connect(RandomId_node_Height.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RandomId_node_Height, assetPath);
					variableCount += RandomId_node_Height.SetData((FSRandom)Height, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CameraId:
					FSCameraInfoNode CameraId_node_Height = graph.AddNode<FSCameraInfoNode>();
					GetPort("Height").Connect(CameraId_node_Height.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CameraId_node_Height, assetPath);
					variableCount += CameraId_node_Height.SetData((FSCameraInfo)Height, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SportsId:
					FSSportsNode SportsId_node_Height = graph.AddNode<FSSportsNode>();
					GetPort("Height").Connect(SportsId_node_Height.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SportsId_node_Height, assetPath);
					variableCount += SportsId_node_Height.SetData((FSSports)Height, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.Vector2Mag:
					FSVector2MagNode Vector2Mag_node_Height = graph.AddNode<FSVector2MagNode>();
					GetPort("Height").Connect(Vector2Mag_node_Height.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(Vector2Mag_node_Height, assetPath);
					variableCount += Vector2Mag_node_Height.SetData((FSVector2Mag)Height, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CPUHelpId:
					FSCpuHelpNode CPUHelpId_node_Height = graph.AddNode<FSCpuHelpNode>();
					GetPort("Height").Connect(CPUHelpId_node_Height.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CPUHelpId_node_Height, assetPath);
					variableCount += CPUHelpId_node_Height.SetData((FSCpuHelp)Height, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ItemId:
					FSItemNode ItemId_node_Height = graph.AddNode<FSItemNode>();
					GetPort("Height").Connect(ItemId_node_Height.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ItemId_node_Height, assetPath);
					variableCount += ItemId_node_Height.SetData((FSItem)Height, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ModeId:
					FSModeNode ModeId_node_Height = graph.AddNode<FSModeNode>();
					GetPort("Height").Connect(ModeId_node_Height.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ModeId_node_Height, assetPath);
					variableCount += ModeId_node_Height.SetData((FSMode)Height, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.JumpsId:
					FSJumpsNode JumpsId_node_Height = graph.AddNode<FSJumpsNode>();
					GetPort("Height").Connect(JumpsId_node_Height.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(JumpsId_node_Height, assetPath);
					variableCount += JumpsId_node_Height.SetData((FSJumps)Height, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RootAnimId:
					FSRootAnimNode RootAnimId_node_Height = graph.AddNode<FSRootAnimNode>();
					GetPort("Height").Connect(RootAnimId_node_Height.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RootAnimId_node_Height, assetPath);
					variableCount += RootAnimId_node_Height.SetData((FSRootAnim)Height, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FloatId:
					FSValueNode FloatId_node_Height = graph.AddNode<FSValueNode>();
					GetPort("Height").Connect(FloatId_node_Height.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FloatId_node_Height, assetPath);
					variableCount += FloatId_node_Height.SetData((FSValue)Height, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
			}
			
			return variableCount;
		}
		
		public new HeightJump GetData()
		{
			HeightJump objToReturn = new HeightJump();
			objToReturn.TID = TypeId.HeightId;
			objToReturn.Version = Version;
			if (GetPort("Height").ConnectionCount > 0)
			{
				FloatSourceNode FloatSource_Node = (FloatSourceNode)GetPort("Height").GetConnection(0).node;
				switch (FloatSource_Node.TID)
				{
					case FloatSource.TypeId.AgentId:
						FSAgentNode AgentId_FloatSource_Node = (FSAgentNode)GetPort("Height").GetConnection(0).node;
						objToReturn.Height = AgentId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.BonesId:
						FSBonesNode BonesId_FloatSource_Node = (FSBonesNode)GetPort("Height").GetConnection(0).node;
						objToReturn.Height = BonesId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AttackId:
						FSAttackNode AttackId_FloatSource_Node = (FSAttackNode)GetPort("Height").GetConnection(0).node;
						objToReturn.Height = AttackId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FrameId:
						FSFrameNode FrameId_FloatSource_Node = (FSFrameNode)GetPort("Height").GetConnection(0).node;
						objToReturn.Height = FrameId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.InputId:
						FSInputNode InputId_FloatSource_Node = (FSInputNode)GetPort("Height").GetConnection(0).node;
						objToReturn.Height = InputId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FuncId:
						FSFuncNode FuncId_FloatSource_Node = (FSFuncNode)GetPort("Height").GetConnection(0).node;
						objToReturn.Height = FuncId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.MovementId:
						FSMovementNode MovementId_FloatSource_Node = (FSMovementNode)GetPort("Height").GetConnection(0).node;
						objToReturn.Height = MovementId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CombatId:
						FSCombatNode CombatId_FloatSource_Node = (FSCombatNode)GetPort("Height").GetConnection(0).node;
						objToReturn.Height = CombatId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.GrabsId:
						FSGrabsNode GrabsId_FloatSource_Node = (FSGrabsNode)GetPort("Height").GetConnection(0).node;
						objToReturn.Height = GrabsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.DataId:
						FSDataNode DataId_FloatSource_Node = (FSDataNode)GetPort("Height").GetConnection(0).node;
						objToReturn.Height = DataId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ScratchId:
						FSScratchNode ScratchId_FloatSource_Node = (FSScratchNode)GetPort("Height").GetConnection(0).node;
						objToReturn.Height = ScratchId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AnimId:
						FSAnimNode AnimId_FloatSource_Node = (FSAnimNode)GetPort("Height").GetConnection(0).node;
						objToReturn.Height = AnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SpeedId:
						FSSpeedNode SpeedId_FloatSource_Node = (FSSpeedNode)GetPort("Height").GetConnection(0).node;
						objToReturn.Height = SpeedId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.PhysicsId:
						FSPhysicsNode PhysicsId_FloatSource_Node = (FSPhysicsNode)GetPort("Height").GetConnection(0).node;
						objToReturn.Height = PhysicsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CollisionId:
						FSCollisionNode CollisionId_FloatSource_Node = (FSCollisionNode)GetPort("Height").GetConnection(0).node;
						objToReturn.Height = CollisionId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.TimerId:
						FSTimerNode TimerId_FloatSource_Node = (FSTimerNode)GetPort("Height").GetConnection(0).node;
						objToReturn.Height = TimerId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.LagId:
						FSLagNode LagId_FloatSource_Node = (FSLagNode)GetPort("Height").GetConnection(0).node;
						objToReturn.Height = LagId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.EffectsId:
						FSEffectsNode EffectsId_FloatSource_Node = (FSEffectsNode)GetPort("Height").GetConnection(0).node;
						objToReturn.Height = EffectsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ColorsId:
						FSColorsNode ColorsId_FloatSource_Node = (FSColorsNode)GetPort("Height").GetConnection(0).node;
						objToReturn.Height = ColorsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.OnHitId:
						FSOnHitNode OnHitId_FloatSource_Node = (FSOnHitNode)GetPort("Height").GetConnection(0).node;
						objToReturn.Height = OnHitId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RandomId:
						FSRandomNode RandomId_FloatSource_Node = (FSRandomNode)GetPort("Height").GetConnection(0).node;
						objToReturn.Height = RandomId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CameraId:
						FSCameraInfoNode CameraId_FloatSource_Node = (FSCameraInfoNode)GetPort("Height").GetConnection(0).node;
						objToReturn.Height = CameraId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SportsId:
						FSSportsNode SportsId_FloatSource_Node = (FSSportsNode)GetPort("Height").GetConnection(0).node;
						objToReturn.Height = SportsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.Vector2Mag:
						FSVector2MagNode Vector2Mag_FloatSource_Node = (FSVector2MagNode)GetPort("Height").GetConnection(0).node;
						objToReturn.Height = Vector2Mag_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CPUHelpId:
						FSCpuHelpNode CPUHelpId_FloatSource_Node = (FSCpuHelpNode)GetPort("Height").GetConnection(0).node;
						objToReturn.Height = CPUHelpId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ItemId:
						FSItemNode ItemId_FloatSource_Node = (FSItemNode)GetPort("Height").GetConnection(0).node;
						objToReturn.Height = ItemId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ModeId:
						FSModeNode ModeId_FloatSource_Node = (FSModeNode)GetPort("Height").GetConnection(0).node;
						objToReturn.Height = ModeId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.JumpsId:
						FSJumpsNode JumpsId_FloatSource_Node = (FSJumpsNode)GetPort("Height").GetConnection(0).node;
						objToReturn.Height = JumpsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RootAnimId:
						FSRootAnimNode RootAnimId_FloatSource_Node = (FSRootAnimNode)GetPort("Height").GetConnection(0).node;
						objToReturn.Height = RootAnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FloatId:
						FSValueNode FloatId_FloatSource_Node = (FSValueNode)GetPort("Height").GetConnection(0).node;
						objToReturn.Height = FloatId_FloatSource_Node.GetData();
					break;
				}
			}
			return objToReturn;
		}
	}
}

