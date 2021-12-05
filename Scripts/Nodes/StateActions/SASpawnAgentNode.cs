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
	public class SASpawnAgentNode : StateActionNode
	{
		public string Bank;
		public string Id;
		public string Bone;
		public NASB_Parser.Vector3 LocalOffset;
		public NASB_Parser.Vector3 WorldOffset;
		[Output(connectionType = ConnectionType.Override)] public SAGUAMessageObject MessageObject;
		public bool CustomSpawnMovement;
		[Output(connectionType = ConnectionType.Multiple)] public List<SpawnMovement> Movements;
		[Output(connectionType = ConnectionType.Override)] public FloatSource ResultOrderAdded;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.SpawnAgentId;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SASpawnAgent data, MovesetGraph graph, string assetPath, Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SASpawnAgent));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			Bank = data.Bank;
			Id = data.Id;
			Bone = data.Bone;
			LocalOffset = data.LocalOffset;
			WorldOffset = data.WorldOffset;
			MessageObject = data.MessageObject;
			
			SAGUAMessageObjectNode node_MessageObject = graph.AddNode<SAGUAMessageObjectNode>();
			GetPort("MessageObject").Connect(node_MessageObject.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_MessageObject, assetPath);
			variableCount += node_MessageObject.SetData(MessageObject, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
			++variableCount;
			
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
			
			return variableCount;
		}
		
		public new SASpawnAgent GetData()
		{
			SASpawnAgent objToReturn = new SASpawnAgent();
			objToReturn.TID = TypeId.SpawnAgentId;
			objToReturn.Version = Version;
			objToReturn.Bank = Bank;
			objToReturn.Id = Id;
			objToReturn.Bone = Bone;
			objToReturn.LocalOffset = LocalOffset;
			objToReturn.WorldOffset = WorldOffset;
			if (GetPort("MessageObject").ConnectionCount > 0)
			{
				SAGUAMessageObjectNode SAGUAMessageObject_Node = (SAGUAMessageObjectNode)GetPort("MessageObject").GetConnection(0).node;
				objToReturn.MessageObject = SAGUAMessageObject_Node.GetData();
			}
			objToReturn.CustomSpawnMovement = CustomSpawnMovement;
			foreach(NodePort port in GetPort("Movements").GetConnections())
			{
				SpawnMovementNode SpawnMovement_Node = (SpawnMovementNode)port.node;
				objToReturn.Movements.Add(SpawnMovement_Node.GetData());
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
			return objToReturn;
		}
	}
}

