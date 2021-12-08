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
	public class SAManipHurtbox_HBMNode : StateActionNode
	{
		[Input(connectionType = ConnectionType.Override)] public SAManipHurtbox.HBM NodeInput;
		public SAManipHurtbox.Manip Manip;
		public int Hurtbox;
		public HurtType Type;
		[Output(connectionType = ConnectionType.Override)] public FloatSource Source;
		
		protected override void Init()
		{
			base.Init();
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SAManipHurtbox.HBM data, MovesetGraph graph, string assetPath, Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SAManipHurtbox.HBM));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			Manip = data.Manip;
			Hurtbox = data.Hurtbox;
			Type = data.Type;
			Source = data.Source;
			
			switch (Source.TID)
			{
				case FloatSource.TypeId.AgentId:
					FSAgentNode AgentId_node_Source = graph.AddNode<FSAgentNode>();
					GetPort("Source").Connect(AgentId_node_Source.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AgentId_node_Source, assetPath);
					variableCount += AgentId_node_Source.SetData((FSAgent)Source, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.BonesId:
					FSBonesNode BonesId_node_Source = graph.AddNode<FSBonesNode>();
					GetPort("Source").Connect(BonesId_node_Source.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BonesId_node_Source, assetPath);
					variableCount += BonesId_node_Source.SetData((FSBones)Source, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AttackId:
					FSAttackNode AttackId_node_Source = graph.AddNode<FSAttackNode>();
					GetPort("Source").Connect(AttackId_node_Source.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AttackId_node_Source, assetPath);
					variableCount += AttackId_node_Source.SetData((FSAttack)Source, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FrameId:
					FSFrameNode FrameId_node_Source = graph.AddNode<FSFrameNode>();
					GetPort("Source").Connect(FrameId_node_Source.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FrameId_node_Source, assetPath);
					variableCount += FrameId_node_Source.SetData((FSFrame)Source, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.InputId:
					FSInputNode InputId_node_Source = graph.AddNode<FSInputNode>();
					GetPort("Source").Connect(InputId_node_Source.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputId_node_Source, assetPath);
					variableCount += InputId_node_Source.SetData((FSInput)Source, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FuncId:
					FSFuncNode FuncId_node_Source = graph.AddNode<FSFuncNode>();
					GetPort("Source").Connect(FuncId_node_Source.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FuncId_node_Source, assetPath);
					variableCount += FuncId_node_Source.SetData((FSFunc)Source, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.MovementId:
					FSMovementNode MovementId_node_Source = graph.AddNode<FSMovementNode>();
					GetPort("Source").Connect(MovementId_node_Source.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(MovementId_node_Source, assetPath);
					variableCount += MovementId_node_Source.SetData((FSMovement)Source, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CombatId:
					FSCombatNode CombatId_node_Source = graph.AddNode<FSCombatNode>();
					GetPort("Source").Connect(CombatId_node_Source.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CombatId_node_Source, assetPath);
					variableCount += CombatId_node_Source.SetData((FSCombat)Source, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.GrabsId:
					FSGrabsNode GrabsId_node_Source = graph.AddNode<FSGrabsNode>();
					GetPort("Source").Connect(GrabsId_node_Source.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(GrabsId_node_Source, assetPath);
					variableCount += GrabsId_node_Source.SetData((FSGrabs)Source, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.DataId:
					FSDataNode DataId_node_Source = graph.AddNode<FSDataNode>();
					GetPort("Source").Connect(DataId_node_Source.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DataId_node_Source, assetPath);
					variableCount += DataId_node_Source.SetData((FSData)Source, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ScratchId:
					FSScratchNode ScratchId_node_Source = graph.AddNode<FSScratchNode>();
					GetPort("Source").Connect(ScratchId_node_Source.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ScratchId_node_Source, assetPath);
					variableCount += ScratchId_node_Source.SetData((FSScratch)Source, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AnimId:
					FSAnimNode AnimId_node_Source = graph.AddNode<FSAnimNode>();
					GetPort("Source").Connect(AnimId_node_Source.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AnimId_node_Source, assetPath);
					variableCount += AnimId_node_Source.SetData((FSAnim)Source, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SpeedId:
					FSSpeedNode SpeedId_node_Source = graph.AddNode<FSSpeedNode>();
					GetPort("Source").Connect(SpeedId_node_Source.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpeedId_node_Source, assetPath);
					variableCount += SpeedId_node_Source.SetData((FSSpeed)Source, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.PhysicsId:
					FSPhysicsNode PhysicsId_node_Source = graph.AddNode<FSPhysicsNode>();
					GetPort("Source").Connect(PhysicsId_node_Source.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(PhysicsId_node_Source, assetPath);
					variableCount += PhysicsId_node_Source.SetData((FSPhysics)Source, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CollisionId:
					FSCollisionNode CollisionId_node_Source = graph.AddNode<FSCollisionNode>();
					GetPort("Source").Connect(CollisionId_node_Source.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CollisionId_node_Source, assetPath);
					variableCount += CollisionId_node_Source.SetData((FSCollision)Source, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.TimerId:
					FSTimerNode TimerId_node_Source = graph.AddNode<FSTimerNode>();
					GetPort("Source").Connect(TimerId_node_Source.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(TimerId_node_Source, assetPath);
					variableCount += TimerId_node_Source.SetData((FSTimer)Source, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.LagId:
					FSLagNode LagId_node_Source = graph.AddNode<FSLagNode>();
					GetPort("Source").Connect(LagId_node_Source.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LagId_node_Source, assetPath);
					variableCount += LagId_node_Source.SetData((FSLag)Source, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.EffectsId:
					FSEffectsNode EffectsId_node_Source = graph.AddNode<FSEffectsNode>();
					GetPort("Source").Connect(EffectsId_node_Source.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EffectsId_node_Source, assetPath);
					variableCount += EffectsId_node_Source.SetData((FSEffects)Source, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ColorsId:
					FSColorsNode ColorsId_node_Source = graph.AddNode<FSColorsNode>();
					GetPort("Source").Connect(ColorsId_node_Source.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ColorsId_node_Source, assetPath);
					variableCount += ColorsId_node_Source.SetData((FSColors)Source, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.OnHitId:
					FSOnHitNode OnHitId_node_Source = graph.AddNode<FSOnHitNode>();
					GetPort("Source").Connect(OnHitId_node_Source.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnHitId_node_Source, assetPath);
					variableCount += OnHitId_node_Source.SetData((FSOnHit)Source, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RandomId:
					FSRandomNode RandomId_node_Source = graph.AddNode<FSRandomNode>();
					GetPort("Source").Connect(RandomId_node_Source.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RandomId_node_Source, assetPath);
					variableCount += RandomId_node_Source.SetData((FSRandom)Source, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CameraId:
					FSCameraInfoNode CameraId_node_Source = graph.AddNode<FSCameraInfoNode>();
					GetPort("Source").Connect(CameraId_node_Source.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CameraId_node_Source, assetPath);
					variableCount += CameraId_node_Source.SetData((FSCameraInfo)Source, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SportsId:
					FSSportsNode SportsId_node_Source = graph.AddNode<FSSportsNode>();
					GetPort("Source").Connect(SportsId_node_Source.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SportsId_node_Source, assetPath);
					variableCount += SportsId_node_Source.SetData((FSSports)Source, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.Vector2Mag:
					FSVector2MagNode Vector2Mag_node_Source = graph.AddNode<FSVector2MagNode>();
					GetPort("Source").Connect(Vector2Mag_node_Source.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(Vector2Mag_node_Source, assetPath);
					variableCount += Vector2Mag_node_Source.SetData((FSVector2Mag)Source, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CPUHelpId:
					FSCpuHelpNode CPUHelpId_node_Source = graph.AddNode<FSCpuHelpNode>();
					GetPort("Source").Connect(CPUHelpId_node_Source.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CPUHelpId_node_Source, assetPath);
					variableCount += CPUHelpId_node_Source.SetData((FSCpuHelp)Source, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ItemId:
					FSItemNode ItemId_node_Source = graph.AddNode<FSItemNode>();
					GetPort("Source").Connect(ItemId_node_Source.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ItemId_node_Source, assetPath);
					variableCount += ItemId_node_Source.SetData((FSItem)Source, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ModeId:
					FSModeNode ModeId_node_Source = graph.AddNode<FSModeNode>();
					GetPort("Source").Connect(ModeId_node_Source.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ModeId_node_Source, assetPath);
					variableCount += ModeId_node_Source.SetData((FSMode)Source, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.JumpsId:
					FSJumpsNode JumpsId_node_Source = graph.AddNode<FSJumpsNode>();
					GetPort("Source").Connect(JumpsId_node_Source.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(JumpsId_node_Source, assetPath);
					variableCount += JumpsId_node_Source.SetData((FSJumps)Source, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RootAnimId:
					FSRootAnimNode RootAnimId_node_Source = graph.AddNode<FSRootAnimNode>();
					GetPort("Source").Connect(RootAnimId_node_Source.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RootAnimId_node_Source, assetPath);
					variableCount += RootAnimId_node_Source.SetData((FSRootAnim)Source, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FloatId:
					FSValueNode FloatId_node_Source = graph.AddNode<FSValueNode>();
					GetPort("Source").Connect(FloatId_node_Source.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FloatId_node_Source, assetPath);
					variableCount += FloatId_node_Source.SetData((FSValue)Source, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
			}
			
			return variableCount;
		}
		
		public SAManipHurtbox.HBM GetData()
		{
			SAManipHurtbox.HBM objToReturn = new SAManipHurtbox.HBM();
			objToReturn.Manip = Manip;
			objToReturn.Hurtbox = Hurtbox;
			objToReturn.Type = Type;
			if (GetPort("Source").ConnectionCount > 0)
			{
				FloatSourceNode FloatSource_Node = (FloatSourceNode)GetPort("Source").GetConnection(0).node;
				switch (FloatSource_Node.TID)
				{
					case FloatSource.TypeId.AgentId:
						FSAgentNode AgentId_FloatSource_Node = (FSAgentNode)GetPort("Source").GetConnection(0).node;
						objToReturn.Source = AgentId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.BonesId:
						FSBonesNode BonesId_FloatSource_Node = (FSBonesNode)GetPort("Source").GetConnection(0).node;
						objToReturn.Source = BonesId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AttackId:
						FSAttackNode AttackId_FloatSource_Node = (FSAttackNode)GetPort("Source").GetConnection(0).node;
						objToReturn.Source = AttackId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FrameId:
						FSFrameNode FrameId_FloatSource_Node = (FSFrameNode)GetPort("Source").GetConnection(0).node;
						objToReturn.Source = FrameId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.InputId:
						FSInputNode InputId_FloatSource_Node = (FSInputNode)GetPort("Source").GetConnection(0).node;
						objToReturn.Source = InputId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FuncId:
						FSFuncNode FuncId_FloatSource_Node = (FSFuncNode)GetPort("Source").GetConnection(0).node;
						objToReturn.Source = FuncId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.MovementId:
						FSMovementNode MovementId_FloatSource_Node = (FSMovementNode)GetPort("Source").GetConnection(0).node;
						objToReturn.Source = MovementId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CombatId:
						FSCombatNode CombatId_FloatSource_Node = (FSCombatNode)GetPort("Source").GetConnection(0).node;
						objToReturn.Source = CombatId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.GrabsId:
						FSGrabsNode GrabsId_FloatSource_Node = (FSGrabsNode)GetPort("Source").GetConnection(0).node;
						objToReturn.Source = GrabsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.DataId:
						FSDataNode DataId_FloatSource_Node = (FSDataNode)GetPort("Source").GetConnection(0).node;
						objToReturn.Source = DataId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ScratchId:
						FSScratchNode ScratchId_FloatSource_Node = (FSScratchNode)GetPort("Source").GetConnection(0).node;
						objToReturn.Source = ScratchId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AnimId:
						FSAnimNode AnimId_FloatSource_Node = (FSAnimNode)GetPort("Source").GetConnection(0).node;
						objToReturn.Source = AnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SpeedId:
						FSSpeedNode SpeedId_FloatSource_Node = (FSSpeedNode)GetPort("Source").GetConnection(0).node;
						objToReturn.Source = SpeedId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.PhysicsId:
						FSPhysicsNode PhysicsId_FloatSource_Node = (FSPhysicsNode)GetPort("Source").GetConnection(0).node;
						objToReturn.Source = PhysicsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CollisionId:
						FSCollisionNode CollisionId_FloatSource_Node = (FSCollisionNode)GetPort("Source").GetConnection(0).node;
						objToReturn.Source = CollisionId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.TimerId:
						FSTimerNode TimerId_FloatSource_Node = (FSTimerNode)GetPort("Source").GetConnection(0).node;
						objToReturn.Source = TimerId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.LagId:
						FSLagNode LagId_FloatSource_Node = (FSLagNode)GetPort("Source").GetConnection(0).node;
						objToReturn.Source = LagId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.EffectsId:
						FSEffectsNode EffectsId_FloatSource_Node = (FSEffectsNode)GetPort("Source").GetConnection(0).node;
						objToReturn.Source = EffectsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ColorsId:
						FSColorsNode ColorsId_FloatSource_Node = (FSColorsNode)GetPort("Source").GetConnection(0).node;
						objToReturn.Source = ColorsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.OnHitId:
						FSOnHitNode OnHitId_FloatSource_Node = (FSOnHitNode)GetPort("Source").GetConnection(0).node;
						objToReturn.Source = OnHitId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RandomId:
						FSRandomNode RandomId_FloatSource_Node = (FSRandomNode)GetPort("Source").GetConnection(0).node;
						objToReturn.Source = RandomId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CameraId:
						FSCameraInfoNode CameraId_FloatSource_Node = (FSCameraInfoNode)GetPort("Source").GetConnection(0).node;
						objToReturn.Source = CameraId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SportsId:
						FSSportsNode SportsId_FloatSource_Node = (FSSportsNode)GetPort("Source").GetConnection(0).node;
						objToReturn.Source = SportsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.Vector2Mag:
						FSVector2MagNode Vector2Mag_FloatSource_Node = (FSVector2MagNode)GetPort("Source").GetConnection(0).node;
						objToReturn.Source = Vector2Mag_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CPUHelpId:
						FSCpuHelpNode CPUHelpId_FloatSource_Node = (FSCpuHelpNode)GetPort("Source").GetConnection(0).node;
						objToReturn.Source = CPUHelpId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ItemId:
						FSItemNode ItemId_FloatSource_Node = (FSItemNode)GetPort("Source").GetConnection(0).node;
						objToReturn.Source = ItemId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ModeId:
						FSModeNode ModeId_FloatSource_Node = (FSModeNode)GetPort("Source").GetConnection(0).node;
						objToReturn.Source = ModeId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.JumpsId:
						FSJumpsNode JumpsId_FloatSource_Node = (FSJumpsNode)GetPort("Source").GetConnection(0).node;
						objToReturn.Source = JumpsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RootAnimId:
						FSRootAnimNode RootAnimId_FloatSource_Node = (FSRootAnimNode)GetPort("Source").GetConnection(0).node;
						objToReturn.Source = RootAnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FloatId:
						FSValueNode FloatId_FloatSource_Node = (FSValueNode)GetPort("Source").GetConnection(0).node;
						objToReturn.Source = FloatId_FloatSource_Node.GetData();
					break;
				}
			}
			return objToReturn;
		}
	}
}

