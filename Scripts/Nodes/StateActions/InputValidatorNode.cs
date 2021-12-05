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
using static NASB_Parser.StateActions.InputValidator;

namespace NASB_Moveset_Editor.StateActions
{
	public class InputValidatorNode : StateActionNode
	{
		public NASB_Parser.StateActions.InputValidator.ValidatorInputType InputType;
		public bool RawX;
		public NASB_Parser.StateActions.InputValidator.CtrlSeg Segment;
		public NASB_Parser.StateActions.InputValidator.ValidatorFloatCompare FloatCompare;
		public NASB_Parser.StateActions.InputValidator.ValidatorButtonCompare ButtonCompare;
		public NASB_Parser.StateActions.InputValidator.CtrlSegCompare SegCompare;
		public NASB_Parser.StateActions.InputValidator.ValidatorMultiCompare MultiCompare;
		[Output(connectionType = ConnectionType.Override)] public FloatSource FloatContainer;
		[Output(connectionType = ConnectionType.Multiple)] public List<InputValidator> Validators;
		
		protected override void Init()
		{
			base.Init();
			// InputValidator should default to Inside, since zero is unused
			SegCompare = CtrlSegCompare.Inside;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(InputValidator data, MovesetGraph graph, string assetPath, Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(InputValidator));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			InputType = data.InputType;
			RawX = data.RawX;
			Segment = data.Segment;
			FloatCompare = data.FloatCompare;
			ButtonCompare = data.ButtonCompare;
			SegCompare = data.SegCompare;
			MultiCompare = data.MultiCompare;
			FloatContainer = data.FloatContainer;
			
			switch (FloatContainer.TID)
			{
				case FloatSource.TypeId.AgentId:
					FSAgentNode AgentId_node_FloatContainer = graph.AddNode<FSAgentNode>();
					GetPort("FloatContainer").Connect(AgentId_node_FloatContainer.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AgentId_node_FloatContainer, assetPath);
					variableCount += AgentId_node_FloatContainer.SetData((FSAgent)FloatContainer, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.BonesId:
					FSBonesNode BonesId_node_FloatContainer = graph.AddNode<FSBonesNode>();
					GetPort("FloatContainer").Connect(BonesId_node_FloatContainer.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BonesId_node_FloatContainer, assetPath);
					variableCount += BonesId_node_FloatContainer.SetData((FSBones)FloatContainer, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AttackId:
					FSAttackNode AttackId_node_FloatContainer = graph.AddNode<FSAttackNode>();
					GetPort("FloatContainer").Connect(AttackId_node_FloatContainer.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AttackId_node_FloatContainer, assetPath);
					variableCount += AttackId_node_FloatContainer.SetData((FSAttack)FloatContainer, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FrameId:
					FSFrameNode FrameId_node_FloatContainer = graph.AddNode<FSFrameNode>();
					GetPort("FloatContainer").Connect(FrameId_node_FloatContainer.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FrameId_node_FloatContainer, assetPath);
					variableCount += FrameId_node_FloatContainer.SetData((FSFrame)FloatContainer, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.InputId:
					FSInputNode InputId_node_FloatContainer = graph.AddNode<FSInputNode>();
					GetPort("FloatContainer").Connect(InputId_node_FloatContainer.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputId_node_FloatContainer, assetPath);
					variableCount += InputId_node_FloatContainer.SetData((FSInput)FloatContainer, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FuncId:
					FSFuncNode FuncId_node_FloatContainer = graph.AddNode<FSFuncNode>();
					GetPort("FloatContainer").Connect(FuncId_node_FloatContainer.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FuncId_node_FloatContainer, assetPath);
					variableCount += FuncId_node_FloatContainer.SetData((FSFunc)FloatContainer, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.MovementId:
					FSMovementNode MovementId_node_FloatContainer = graph.AddNode<FSMovementNode>();
					GetPort("FloatContainer").Connect(MovementId_node_FloatContainer.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(MovementId_node_FloatContainer, assetPath);
					variableCount += MovementId_node_FloatContainer.SetData((FSMovement)FloatContainer, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CombatId:
					FSCombatNode CombatId_node_FloatContainer = graph.AddNode<FSCombatNode>();
					GetPort("FloatContainer").Connect(CombatId_node_FloatContainer.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CombatId_node_FloatContainer, assetPath);
					variableCount += CombatId_node_FloatContainer.SetData((FSCombat)FloatContainer, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.GrabsId:
					FSGrabsNode GrabsId_node_FloatContainer = graph.AddNode<FSGrabsNode>();
					GetPort("FloatContainer").Connect(GrabsId_node_FloatContainer.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(GrabsId_node_FloatContainer, assetPath);
					variableCount += GrabsId_node_FloatContainer.SetData((FSGrabs)FloatContainer, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.DataId:
					FSDataNode DataId_node_FloatContainer = graph.AddNode<FSDataNode>();
					GetPort("FloatContainer").Connect(DataId_node_FloatContainer.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DataId_node_FloatContainer, assetPath);
					variableCount += DataId_node_FloatContainer.SetData((FSData)FloatContainer, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ScratchId:
					FSScratchNode ScratchId_node_FloatContainer = graph.AddNode<FSScratchNode>();
					GetPort("FloatContainer").Connect(ScratchId_node_FloatContainer.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ScratchId_node_FloatContainer, assetPath);
					variableCount += ScratchId_node_FloatContainer.SetData((FSScratch)FloatContainer, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AnimId:
					FSAnimNode AnimId_node_FloatContainer = graph.AddNode<FSAnimNode>();
					GetPort("FloatContainer").Connect(AnimId_node_FloatContainer.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AnimId_node_FloatContainer, assetPath);
					variableCount += AnimId_node_FloatContainer.SetData((FSAnim)FloatContainer, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SpeedId:
					FSSpeedNode SpeedId_node_FloatContainer = graph.AddNode<FSSpeedNode>();
					GetPort("FloatContainer").Connect(SpeedId_node_FloatContainer.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpeedId_node_FloatContainer, assetPath);
					variableCount += SpeedId_node_FloatContainer.SetData((FSSpeed)FloatContainer, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.PhysicsId:
					FSPhysicsNode PhysicsId_node_FloatContainer = graph.AddNode<FSPhysicsNode>();
					GetPort("FloatContainer").Connect(PhysicsId_node_FloatContainer.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(PhysicsId_node_FloatContainer, assetPath);
					variableCount += PhysicsId_node_FloatContainer.SetData((FSPhysics)FloatContainer, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CollisionId:
					FSCollisionNode CollisionId_node_FloatContainer = graph.AddNode<FSCollisionNode>();
					GetPort("FloatContainer").Connect(CollisionId_node_FloatContainer.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CollisionId_node_FloatContainer, assetPath);
					variableCount += CollisionId_node_FloatContainer.SetData((FSCollision)FloatContainer, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.TimerId:
					FSTimerNode TimerId_node_FloatContainer = graph.AddNode<FSTimerNode>();
					GetPort("FloatContainer").Connect(TimerId_node_FloatContainer.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(TimerId_node_FloatContainer, assetPath);
					variableCount += TimerId_node_FloatContainer.SetData((FSTimer)FloatContainer, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.LagId:
					FSLagNode LagId_node_FloatContainer = graph.AddNode<FSLagNode>();
					GetPort("FloatContainer").Connect(LagId_node_FloatContainer.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LagId_node_FloatContainer, assetPath);
					variableCount += LagId_node_FloatContainer.SetData((FSLag)FloatContainer, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.EffectsId:
					FSEffectsNode EffectsId_node_FloatContainer = graph.AddNode<FSEffectsNode>();
					GetPort("FloatContainer").Connect(EffectsId_node_FloatContainer.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EffectsId_node_FloatContainer, assetPath);
					variableCount += EffectsId_node_FloatContainer.SetData((FSEffects)FloatContainer, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ColorsId:
					FSColorsNode ColorsId_node_FloatContainer = graph.AddNode<FSColorsNode>();
					GetPort("FloatContainer").Connect(ColorsId_node_FloatContainer.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ColorsId_node_FloatContainer, assetPath);
					variableCount += ColorsId_node_FloatContainer.SetData((FSColors)FloatContainer, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.OnHitId:
					FSOnHitNode OnHitId_node_FloatContainer = graph.AddNode<FSOnHitNode>();
					GetPort("FloatContainer").Connect(OnHitId_node_FloatContainer.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnHitId_node_FloatContainer, assetPath);
					variableCount += OnHitId_node_FloatContainer.SetData((FSOnHit)FloatContainer, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RandomId:
					FSRandomNode RandomId_node_FloatContainer = graph.AddNode<FSRandomNode>();
					GetPort("FloatContainer").Connect(RandomId_node_FloatContainer.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RandomId_node_FloatContainer, assetPath);
					variableCount += RandomId_node_FloatContainer.SetData((FSRandom)FloatContainer, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CameraId:
					FSCameraInfoNode CameraId_node_FloatContainer = graph.AddNode<FSCameraInfoNode>();
					GetPort("FloatContainer").Connect(CameraId_node_FloatContainer.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CameraId_node_FloatContainer, assetPath);
					variableCount += CameraId_node_FloatContainer.SetData((FSCameraInfo)FloatContainer, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SportsId:
					FSSportsNode SportsId_node_FloatContainer = graph.AddNode<FSSportsNode>();
					GetPort("FloatContainer").Connect(SportsId_node_FloatContainer.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SportsId_node_FloatContainer, assetPath);
					variableCount += SportsId_node_FloatContainer.SetData((FSSports)FloatContainer, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.Vector2Mag:
					FSVector2MagNode Vector2Mag_node_FloatContainer = graph.AddNode<FSVector2MagNode>();
					GetPort("FloatContainer").Connect(Vector2Mag_node_FloatContainer.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(Vector2Mag_node_FloatContainer, assetPath);
					variableCount += Vector2Mag_node_FloatContainer.SetData((FSVector2Mag)FloatContainer, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CPUHelpId:
					FSCpuHelpNode CPUHelpId_node_FloatContainer = graph.AddNode<FSCpuHelpNode>();
					GetPort("FloatContainer").Connect(CPUHelpId_node_FloatContainer.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CPUHelpId_node_FloatContainer, assetPath);
					variableCount += CPUHelpId_node_FloatContainer.SetData((FSCpuHelp)FloatContainer, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ItemId:
					FSItemNode ItemId_node_FloatContainer = graph.AddNode<FSItemNode>();
					GetPort("FloatContainer").Connect(ItemId_node_FloatContainer.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ItemId_node_FloatContainer, assetPath);
					variableCount += ItemId_node_FloatContainer.SetData((FSItem)FloatContainer, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ModeId:
					FSModeNode ModeId_node_FloatContainer = graph.AddNode<FSModeNode>();
					GetPort("FloatContainer").Connect(ModeId_node_FloatContainer.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ModeId_node_FloatContainer, assetPath);
					variableCount += ModeId_node_FloatContainer.SetData((FSMode)FloatContainer, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.JumpsId:
					FSJumpsNode JumpsId_node_FloatContainer = graph.AddNode<FSJumpsNode>();
					GetPort("FloatContainer").Connect(JumpsId_node_FloatContainer.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(JumpsId_node_FloatContainer, assetPath);
					variableCount += JumpsId_node_FloatContainer.SetData((FSJumps)FloatContainer, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RootAnimId:
					FSRootAnimNode RootAnimId_node_FloatContainer = graph.AddNode<FSRootAnimNode>();
					GetPort("FloatContainer").Connect(RootAnimId_node_FloatContainer.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RootAnimId_node_FloatContainer, assetPath);
					variableCount += RootAnimId_node_FloatContainer.SetData((FSRootAnim)FloatContainer, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FloatId:
					FSValueNode FloatId_node_FloatContainer = graph.AddNode<FSValueNode>();
					GetPort("FloatContainer").Connect(FloatId_node_FloatContainer.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FloatId_node_FloatContainer, assetPath);
					variableCount += FloatId_node_FloatContainer.SetData((FSValue)FloatContainer, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
			}
			++variableCount;
			
			Validators = data.Validators;
			
			foreach (InputValidator Validators_item in data.Validators)
			{
				InputValidatorNode node_Validators = graph.AddNode<InputValidatorNode>();
				GetPort("Validators").Connect(node_Validators.GetPort("NodeInput"));
				AssetDatabase.AddObjectToAsset(node_Validators, assetPath);
				variableCount += node_Validators.SetData(Validators_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				++variableCount;
			}
			
			return variableCount;
		}
		
		public InputValidator GetData()
		{
			InputValidator objToReturn = new InputValidator();
			objToReturn.InputType = InputType;
			objToReturn.RawX = RawX;
			objToReturn.Segment = Segment;
			objToReturn.FloatCompare = FloatCompare;
			objToReturn.ButtonCompare = ButtonCompare;
			objToReturn.SegCompare = SegCompare;
			objToReturn.MultiCompare = MultiCompare;
			if (GetPort("FloatContainer").ConnectionCount > 0)
			{
				FloatSourceNode FloatSource_Node = (FloatSourceNode)GetPort("FloatContainer").GetConnection(0).node;
				switch (FloatSource_Node.TID)
				{
					case FloatSource.TypeId.AgentId:
						FSAgentNode AgentId_FloatSource_Node = (FSAgentNode)GetPort("FloatContainer").GetConnection(0).node;
						objToReturn.FloatContainer = AgentId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.BonesId:
						FSBonesNode BonesId_FloatSource_Node = (FSBonesNode)GetPort("FloatContainer").GetConnection(0).node;
						objToReturn.FloatContainer = BonesId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AttackId:
						FSAttackNode AttackId_FloatSource_Node = (FSAttackNode)GetPort("FloatContainer").GetConnection(0).node;
						objToReturn.FloatContainer = AttackId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FrameId:
						FSFrameNode FrameId_FloatSource_Node = (FSFrameNode)GetPort("FloatContainer").GetConnection(0).node;
						objToReturn.FloatContainer = FrameId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.InputId:
						FSInputNode InputId_FloatSource_Node = (FSInputNode)GetPort("FloatContainer").GetConnection(0).node;
						objToReturn.FloatContainer = InputId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FuncId:
						FSFuncNode FuncId_FloatSource_Node = (FSFuncNode)GetPort("FloatContainer").GetConnection(0).node;
						objToReturn.FloatContainer = FuncId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.MovementId:
						FSMovementNode MovementId_FloatSource_Node = (FSMovementNode)GetPort("FloatContainer").GetConnection(0).node;
						objToReturn.FloatContainer = MovementId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CombatId:
						FSCombatNode CombatId_FloatSource_Node = (FSCombatNode)GetPort("FloatContainer").GetConnection(0).node;
						objToReturn.FloatContainer = CombatId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.GrabsId:
						FSGrabsNode GrabsId_FloatSource_Node = (FSGrabsNode)GetPort("FloatContainer").GetConnection(0).node;
						objToReturn.FloatContainer = GrabsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.DataId:
						FSDataNode DataId_FloatSource_Node = (FSDataNode)GetPort("FloatContainer").GetConnection(0).node;
						objToReturn.FloatContainer = DataId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ScratchId:
						FSScratchNode ScratchId_FloatSource_Node = (FSScratchNode)GetPort("FloatContainer").GetConnection(0).node;
						objToReturn.FloatContainer = ScratchId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AnimId:
						FSAnimNode AnimId_FloatSource_Node = (FSAnimNode)GetPort("FloatContainer").GetConnection(0).node;
						objToReturn.FloatContainer = AnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SpeedId:
						FSSpeedNode SpeedId_FloatSource_Node = (FSSpeedNode)GetPort("FloatContainer").GetConnection(0).node;
						objToReturn.FloatContainer = SpeedId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.PhysicsId:
						FSPhysicsNode PhysicsId_FloatSource_Node = (FSPhysicsNode)GetPort("FloatContainer").GetConnection(0).node;
						objToReturn.FloatContainer = PhysicsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CollisionId:
						FSCollisionNode CollisionId_FloatSource_Node = (FSCollisionNode)GetPort("FloatContainer").GetConnection(0).node;
						objToReturn.FloatContainer = CollisionId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.TimerId:
						FSTimerNode TimerId_FloatSource_Node = (FSTimerNode)GetPort("FloatContainer").GetConnection(0).node;
						objToReturn.FloatContainer = TimerId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.LagId:
						FSLagNode LagId_FloatSource_Node = (FSLagNode)GetPort("FloatContainer").GetConnection(0).node;
						objToReturn.FloatContainer = LagId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.EffectsId:
						FSEffectsNode EffectsId_FloatSource_Node = (FSEffectsNode)GetPort("FloatContainer").GetConnection(0).node;
						objToReturn.FloatContainer = EffectsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ColorsId:
						FSColorsNode ColorsId_FloatSource_Node = (FSColorsNode)GetPort("FloatContainer").GetConnection(0).node;
						objToReturn.FloatContainer = ColorsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.OnHitId:
						FSOnHitNode OnHitId_FloatSource_Node = (FSOnHitNode)GetPort("FloatContainer").GetConnection(0).node;
						objToReturn.FloatContainer = OnHitId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RandomId:
						FSRandomNode RandomId_FloatSource_Node = (FSRandomNode)GetPort("FloatContainer").GetConnection(0).node;
						objToReturn.FloatContainer = RandomId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CameraId:
						FSCameraInfoNode CameraId_FloatSource_Node = (FSCameraInfoNode)GetPort("FloatContainer").GetConnection(0).node;
						objToReturn.FloatContainer = CameraId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SportsId:
						FSSportsNode SportsId_FloatSource_Node = (FSSportsNode)GetPort("FloatContainer").GetConnection(0).node;
						objToReturn.FloatContainer = SportsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.Vector2Mag:
						FSVector2MagNode Vector2Mag_FloatSource_Node = (FSVector2MagNode)GetPort("FloatContainer").GetConnection(0).node;
						objToReturn.FloatContainer = Vector2Mag_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CPUHelpId:
						FSCpuHelpNode CPUHelpId_FloatSource_Node = (FSCpuHelpNode)GetPort("FloatContainer").GetConnection(0).node;
						objToReturn.FloatContainer = CPUHelpId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ItemId:
						FSItemNode ItemId_FloatSource_Node = (FSItemNode)GetPort("FloatContainer").GetConnection(0).node;
						objToReturn.FloatContainer = ItemId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ModeId:
						FSModeNode ModeId_FloatSource_Node = (FSModeNode)GetPort("FloatContainer").GetConnection(0).node;
						objToReturn.FloatContainer = ModeId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.JumpsId:
						FSJumpsNode JumpsId_FloatSource_Node = (FSJumpsNode)GetPort("FloatContainer").GetConnection(0).node;
						objToReturn.FloatContainer = JumpsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RootAnimId:
						FSRootAnimNode RootAnimId_FloatSource_Node = (FSRootAnimNode)GetPort("FloatContainer").GetConnection(0).node;
						objToReturn.FloatContainer = RootAnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FloatId:
						FSValueNode FloatId_FloatSource_Node = (FSValueNode)GetPort("FloatContainer").GetConnection(0).node;
						objToReturn.FloatContainer = FloatId_FloatSource_Node.GetData();
					break;
				}
			}
			foreach(NodePort port in GetPort("Validators").GetConnections())
			{
				InputValidatorNode InputValidator_Node = (InputValidatorNode)port.node;
				objToReturn.Validators.Add(InputValidator_Node.GetData());
			}
			return objToReturn;
		}
	}
}

