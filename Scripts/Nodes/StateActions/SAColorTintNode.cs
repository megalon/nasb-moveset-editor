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
	public class SAColorTintNode : StateActionNode
	{
		[Input(connectionType = ConnectionType.Override)] public StateAction NodeInput;
		public string Id;
		public bool Activate;
		public bool Permanent;
		[Output(connectionType = ConnectionType.Override)] public FloatSource RunForTime;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.ColorTintId;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SAColorTint data, MovesetGraph graph, string assetPath, Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SAColorTint));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			Id = data.Id;
			Activate = data.Activate;
			Permanent = data.Permanent;
			RunForTime = data.RunForTime;
			
			switch (RunForTime.TID)
			{
				case FloatSource.TypeId.AgentId:
					FSAgentNode AgentId_node_RunForTime = graph.AddNode<FSAgentNode>();
					GetPort("RunForTime").Connect(AgentId_node_RunForTime.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AgentId_node_RunForTime, assetPath);
					variableCount += AgentId_node_RunForTime.SetData((FSAgent)RunForTime, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.BonesId:
					FSBonesNode BonesId_node_RunForTime = graph.AddNode<FSBonesNode>();
					GetPort("RunForTime").Connect(BonesId_node_RunForTime.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BonesId_node_RunForTime, assetPath);
					variableCount += BonesId_node_RunForTime.SetData((FSBones)RunForTime, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AttackId:
					FSAttackNode AttackId_node_RunForTime = graph.AddNode<FSAttackNode>();
					GetPort("RunForTime").Connect(AttackId_node_RunForTime.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AttackId_node_RunForTime, assetPath);
					variableCount += AttackId_node_RunForTime.SetData((FSAttack)RunForTime, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FrameId:
					FSFrameNode FrameId_node_RunForTime = graph.AddNode<FSFrameNode>();
					GetPort("RunForTime").Connect(FrameId_node_RunForTime.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FrameId_node_RunForTime, assetPath);
					variableCount += FrameId_node_RunForTime.SetData((FSFrame)RunForTime, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.InputId:
					FSInputNode InputId_node_RunForTime = graph.AddNode<FSInputNode>();
					GetPort("RunForTime").Connect(InputId_node_RunForTime.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputId_node_RunForTime, assetPath);
					variableCount += InputId_node_RunForTime.SetData((FSInput)RunForTime, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FuncId:
					FSFuncNode FuncId_node_RunForTime = graph.AddNode<FSFuncNode>();
					GetPort("RunForTime").Connect(FuncId_node_RunForTime.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FuncId_node_RunForTime, assetPath);
					variableCount += FuncId_node_RunForTime.SetData((FSFunc)RunForTime, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.MovementId:
					FSMovementNode MovementId_node_RunForTime = graph.AddNode<FSMovementNode>();
					GetPort("RunForTime").Connect(MovementId_node_RunForTime.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(MovementId_node_RunForTime, assetPath);
					variableCount += MovementId_node_RunForTime.SetData((FSMovement)RunForTime, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CombatId:
					FSCombatNode CombatId_node_RunForTime = graph.AddNode<FSCombatNode>();
					GetPort("RunForTime").Connect(CombatId_node_RunForTime.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CombatId_node_RunForTime, assetPath);
					variableCount += CombatId_node_RunForTime.SetData((FSCombat)RunForTime, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.GrabsId:
					FSGrabsNode GrabsId_node_RunForTime = graph.AddNode<FSGrabsNode>();
					GetPort("RunForTime").Connect(GrabsId_node_RunForTime.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(GrabsId_node_RunForTime, assetPath);
					variableCount += GrabsId_node_RunForTime.SetData((FSGrabs)RunForTime, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.DataId:
					FSDataNode DataId_node_RunForTime = graph.AddNode<FSDataNode>();
					GetPort("RunForTime").Connect(DataId_node_RunForTime.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DataId_node_RunForTime, assetPath);
					variableCount += DataId_node_RunForTime.SetData((FSData)RunForTime, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ScratchId:
					FSScratchNode ScratchId_node_RunForTime = graph.AddNode<FSScratchNode>();
					GetPort("RunForTime").Connect(ScratchId_node_RunForTime.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ScratchId_node_RunForTime, assetPath);
					variableCount += ScratchId_node_RunForTime.SetData((FSScratch)RunForTime, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AnimId:
					FSAnimNode AnimId_node_RunForTime = graph.AddNode<FSAnimNode>();
					GetPort("RunForTime").Connect(AnimId_node_RunForTime.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AnimId_node_RunForTime, assetPath);
					variableCount += AnimId_node_RunForTime.SetData((FSAnim)RunForTime, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SpeedId:
					FSSpeedNode SpeedId_node_RunForTime = graph.AddNode<FSSpeedNode>();
					GetPort("RunForTime").Connect(SpeedId_node_RunForTime.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpeedId_node_RunForTime, assetPath);
					variableCount += SpeedId_node_RunForTime.SetData((FSSpeed)RunForTime, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.PhysicsId:
					FSPhysicsNode PhysicsId_node_RunForTime = graph.AddNode<FSPhysicsNode>();
					GetPort("RunForTime").Connect(PhysicsId_node_RunForTime.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(PhysicsId_node_RunForTime, assetPath);
					variableCount += PhysicsId_node_RunForTime.SetData((FSPhysics)RunForTime, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CollisionId:
					FSCollisionNode CollisionId_node_RunForTime = graph.AddNode<FSCollisionNode>();
					GetPort("RunForTime").Connect(CollisionId_node_RunForTime.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CollisionId_node_RunForTime, assetPath);
					variableCount += CollisionId_node_RunForTime.SetData((FSCollision)RunForTime, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.TimerId:
					FSTimerNode TimerId_node_RunForTime = graph.AddNode<FSTimerNode>();
					GetPort("RunForTime").Connect(TimerId_node_RunForTime.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(TimerId_node_RunForTime, assetPath);
					variableCount += TimerId_node_RunForTime.SetData((FSTimer)RunForTime, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.LagId:
					FSLagNode LagId_node_RunForTime = graph.AddNode<FSLagNode>();
					GetPort("RunForTime").Connect(LagId_node_RunForTime.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LagId_node_RunForTime, assetPath);
					variableCount += LagId_node_RunForTime.SetData((FSLag)RunForTime, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.EffectsId:
					FSEffectsNode EffectsId_node_RunForTime = graph.AddNode<FSEffectsNode>();
					GetPort("RunForTime").Connect(EffectsId_node_RunForTime.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EffectsId_node_RunForTime, assetPath);
					variableCount += EffectsId_node_RunForTime.SetData((FSEffects)RunForTime, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ColorsId:
					FSColorsNode ColorsId_node_RunForTime = graph.AddNode<FSColorsNode>();
					GetPort("RunForTime").Connect(ColorsId_node_RunForTime.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ColorsId_node_RunForTime, assetPath);
					variableCount += ColorsId_node_RunForTime.SetData((FSColors)RunForTime, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.OnHitId:
					FSOnHitNode OnHitId_node_RunForTime = graph.AddNode<FSOnHitNode>();
					GetPort("RunForTime").Connect(OnHitId_node_RunForTime.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnHitId_node_RunForTime, assetPath);
					variableCount += OnHitId_node_RunForTime.SetData((FSOnHit)RunForTime, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RandomId:
					FSRandomNode RandomId_node_RunForTime = graph.AddNode<FSRandomNode>();
					GetPort("RunForTime").Connect(RandomId_node_RunForTime.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RandomId_node_RunForTime, assetPath);
					variableCount += RandomId_node_RunForTime.SetData((FSRandom)RunForTime, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CameraId:
					FSCameraInfoNode CameraId_node_RunForTime = graph.AddNode<FSCameraInfoNode>();
					GetPort("RunForTime").Connect(CameraId_node_RunForTime.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CameraId_node_RunForTime, assetPath);
					variableCount += CameraId_node_RunForTime.SetData((FSCameraInfo)RunForTime, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SportsId:
					FSSportsNode SportsId_node_RunForTime = graph.AddNode<FSSportsNode>();
					GetPort("RunForTime").Connect(SportsId_node_RunForTime.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SportsId_node_RunForTime, assetPath);
					variableCount += SportsId_node_RunForTime.SetData((FSSports)RunForTime, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.Vector2Mag:
					FSVector2MagNode Vector2Mag_node_RunForTime = graph.AddNode<FSVector2MagNode>();
					GetPort("RunForTime").Connect(Vector2Mag_node_RunForTime.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(Vector2Mag_node_RunForTime, assetPath);
					variableCount += Vector2Mag_node_RunForTime.SetData((FSVector2Mag)RunForTime, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CPUHelpId:
					FSCpuHelpNode CPUHelpId_node_RunForTime = graph.AddNode<FSCpuHelpNode>();
					GetPort("RunForTime").Connect(CPUHelpId_node_RunForTime.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CPUHelpId_node_RunForTime, assetPath);
					variableCount += CPUHelpId_node_RunForTime.SetData((FSCpuHelp)RunForTime, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ItemId:
					FSItemNode ItemId_node_RunForTime = graph.AddNode<FSItemNode>();
					GetPort("RunForTime").Connect(ItemId_node_RunForTime.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ItemId_node_RunForTime, assetPath);
					variableCount += ItemId_node_RunForTime.SetData((FSItem)RunForTime, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ModeId:
					FSModeNode ModeId_node_RunForTime = graph.AddNode<FSModeNode>();
					GetPort("RunForTime").Connect(ModeId_node_RunForTime.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ModeId_node_RunForTime, assetPath);
					variableCount += ModeId_node_RunForTime.SetData((FSMode)RunForTime, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.JumpsId:
					FSJumpsNode JumpsId_node_RunForTime = graph.AddNode<FSJumpsNode>();
					GetPort("RunForTime").Connect(JumpsId_node_RunForTime.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(JumpsId_node_RunForTime, assetPath);
					variableCount += JumpsId_node_RunForTime.SetData((FSJumps)RunForTime, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RootAnimId:
					FSRootAnimNode RootAnimId_node_RunForTime = graph.AddNode<FSRootAnimNode>();
					GetPort("RunForTime").Connect(RootAnimId_node_RunForTime.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RootAnimId_node_RunForTime, assetPath);
					variableCount += RootAnimId_node_RunForTime.SetData((FSRootAnim)RunForTime, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FloatId:
					FSValueNode FloatId_node_RunForTime = graph.AddNode<FSValueNode>();
					GetPort("RunForTime").Connect(FloatId_node_RunForTime.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FloatId_node_RunForTime, assetPath);
					variableCount += FloatId_node_RunForTime.SetData((FSValue)RunForTime, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
			}
			
			return variableCount;
		}
		
		public new SAColorTint GetData()
		{
			SAColorTint objToReturn = new SAColorTint();
			objToReturn.TID = TypeId.ColorTintId;
			objToReturn.Version = Version;
			objToReturn.Id = Id;
			objToReturn.Activate = Activate;
			objToReturn.Permanent = Permanent;
			if (GetPort("RunForTime").ConnectionCount > 0)
			{
				FloatSourceNode FloatSource_Node = (FloatSourceNode)GetPort("RunForTime").GetConnection(0).node;
				switch (FloatSource_Node.TID)
				{
					case FloatSource.TypeId.AgentId:
						FSAgentNode AgentId_FloatSource_Node = (FSAgentNode)GetPort("RunForTime").GetConnection(0).node;
						objToReturn.RunForTime = AgentId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.BonesId:
						FSBonesNode BonesId_FloatSource_Node = (FSBonesNode)GetPort("RunForTime").GetConnection(0).node;
						objToReturn.RunForTime = BonesId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AttackId:
						FSAttackNode AttackId_FloatSource_Node = (FSAttackNode)GetPort("RunForTime").GetConnection(0).node;
						objToReturn.RunForTime = AttackId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FrameId:
						FSFrameNode FrameId_FloatSource_Node = (FSFrameNode)GetPort("RunForTime").GetConnection(0).node;
						objToReturn.RunForTime = FrameId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.InputId:
						FSInputNode InputId_FloatSource_Node = (FSInputNode)GetPort("RunForTime").GetConnection(0).node;
						objToReturn.RunForTime = InputId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FuncId:
						FSFuncNode FuncId_FloatSource_Node = (FSFuncNode)GetPort("RunForTime").GetConnection(0).node;
						objToReturn.RunForTime = FuncId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.MovementId:
						FSMovementNode MovementId_FloatSource_Node = (FSMovementNode)GetPort("RunForTime").GetConnection(0).node;
						objToReturn.RunForTime = MovementId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CombatId:
						FSCombatNode CombatId_FloatSource_Node = (FSCombatNode)GetPort("RunForTime").GetConnection(0).node;
						objToReturn.RunForTime = CombatId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.GrabsId:
						FSGrabsNode GrabsId_FloatSource_Node = (FSGrabsNode)GetPort("RunForTime").GetConnection(0).node;
						objToReturn.RunForTime = GrabsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.DataId:
						FSDataNode DataId_FloatSource_Node = (FSDataNode)GetPort("RunForTime").GetConnection(0).node;
						objToReturn.RunForTime = DataId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ScratchId:
						FSScratchNode ScratchId_FloatSource_Node = (FSScratchNode)GetPort("RunForTime").GetConnection(0).node;
						objToReturn.RunForTime = ScratchId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AnimId:
						FSAnimNode AnimId_FloatSource_Node = (FSAnimNode)GetPort("RunForTime").GetConnection(0).node;
						objToReturn.RunForTime = AnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SpeedId:
						FSSpeedNode SpeedId_FloatSource_Node = (FSSpeedNode)GetPort("RunForTime").GetConnection(0).node;
						objToReturn.RunForTime = SpeedId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.PhysicsId:
						FSPhysicsNode PhysicsId_FloatSource_Node = (FSPhysicsNode)GetPort("RunForTime").GetConnection(0).node;
						objToReturn.RunForTime = PhysicsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CollisionId:
						FSCollisionNode CollisionId_FloatSource_Node = (FSCollisionNode)GetPort("RunForTime").GetConnection(0).node;
						objToReturn.RunForTime = CollisionId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.TimerId:
						FSTimerNode TimerId_FloatSource_Node = (FSTimerNode)GetPort("RunForTime").GetConnection(0).node;
						objToReturn.RunForTime = TimerId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.LagId:
						FSLagNode LagId_FloatSource_Node = (FSLagNode)GetPort("RunForTime").GetConnection(0).node;
						objToReturn.RunForTime = LagId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.EffectsId:
						FSEffectsNode EffectsId_FloatSource_Node = (FSEffectsNode)GetPort("RunForTime").GetConnection(0).node;
						objToReturn.RunForTime = EffectsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ColorsId:
						FSColorsNode ColorsId_FloatSource_Node = (FSColorsNode)GetPort("RunForTime").GetConnection(0).node;
						objToReturn.RunForTime = ColorsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.OnHitId:
						FSOnHitNode OnHitId_FloatSource_Node = (FSOnHitNode)GetPort("RunForTime").GetConnection(0).node;
						objToReturn.RunForTime = OnHitId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RandomId:
						FSRandomNode RandomId_FloatSource_Node = (FSRandomNode)GetPort("RunForTime").GetConnection(0).node;
						objToReturn.RunForTime = RandomId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CameraId:
						FSCameraInfoNode CameraId_FloatSource_Node = (FSCameraInfoNode)GetPort("RunForTime").GetConnection(0).node;
						objToReturn.RunForTime = CameraId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SportsId:
						FSSportsNode SportsId_FloatSource_Node = (FSSportsNode)GetPort("RunForTime").GetConnection(0).node;
						objToReturn.RunForTime = SportsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.Vector2Mag:
						FSVector2MagNode Vector2Mag_FloatSource_Node = (FSVector2MagNode)GetPort("RunForTime").GetConnection(0).node;
						objToReturn.RunForTime = Vector2Mag_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CPUHelpId:
						FSCpuHelpNode CPUHelpId_FloatSource_Node = (FSCpuHelpNode)GetPort("RunForTime").GetConnection(0).node;
						objToReturn.RunForTime = CPUHelpId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ItemId:
						FSItemNode ItemId_FloatSource_Node = (FSItemNode)GetPort("RunForTime").GetConnection(0).node;
						objToReturn.RunForTime = ItemId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ModeId:
						FSModeNode ModeId_FloatSource_Node = (FSModeNode)GetPort("RunForTime").GetConnection(0).node;
						objToReturn.RunForTime = ModeId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.JumpsId:
						FSJumpsNode JumpsId_FloatSource_Node = (FSJumpsNode)GetPort("RunForTime").GetConnection(0).node;
						objToReturn.RunForTime = JumpsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RootAnimId:
						FSRootAnimNode RootAnimId_FloatSource_Node = (FSRootAnimNode)GetPort("RunForTime").GetConnection(0).node;
						objToReturn.RunForTime = RootAnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FloatId:
						FSValueNode FloatId_FloatSource_Node = (FSValueNode)GetPort("RunForTime").GetConnection(0).node;
						objToReturn.RunForTime = FloatId_FloatSource_Node.GetData();
					break;
				}
			}
			return objToReturn;
		}
	}
}

