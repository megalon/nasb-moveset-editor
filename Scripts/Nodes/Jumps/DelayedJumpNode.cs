// * 
// * 
// * This file was generated using NASB_Parser_to_xNode by megalon2d
// * https://github.com/megalon/NASB_Parser_to_xNode
// * 
// * 
using NASB_Parser.FloatSources;
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
	public class DelayedJumpNode : JumpNode
	{
		[Input(connectionType = ConnectionType.Override)] public Jump NodeInput;
		[Output(connectionType = ConnectionType.Override)] public FloatSource Height;
		[Output(connectionType = ConnectionType.Override)] public FloatSource AutoHoldFrames;
		[Output(connectionType = ConnectionType.Override)] public FloatSource YVelMaxOnRelease;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.DelayedId;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(DelayedJump data, MovesetGraph graph, string assetPath, Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(DelayedJump));
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
			++variableCount;
			
			AutoHoldFrames = data.AutoHoldFrames;
			
			switch (AutoHoldFrames.TID)
			{
				case FloatSource.TypeId.AgentId:
					FSAgentNode AgentId_node_AutoHoldFrames = graph.AddNode<FSAgentNode>();
					GetPort("AutoHoldFrames").Connect(AgentId_node_AutoHoldFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AgentId_node_AutoHoldFrames, assetPath);
					variableCount += AgentId_node_AutoHoldFrames.SetData((FSAgent)AutoHoldFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.BonesId:
					FSBonesNode BonesId_node_AutoHoldFrames = graph.AddNode<FSBonesNode>();
					GetPort("AutoHoldFrames").Connect(BonesId_node_AutoHoldFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BonesId_node_AutoHoldFrames, assetPath);
					variableCount += BonesId_node_AutoHoldFrames.SetData((FSBones)AutoHoldFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AttackId:
					FSAttackNode AttackId_node_AutoHoldFrames = graph.AddNode<FSAttackNode>();
					GetPort("AutoHoldFrames").Connect(AttackId_node_AutoHoldFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AttackId_node_AutoHoldFrames, assetPath);
					variableCount += AttackId_node_AutoHoldFrames.SetData((FSAttack)AutoHoldFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FrameId:
					FSFrameNode FrameId_node_AutoHoldFrames = graph.AddNode<FSFrameNode>();
					GetPort("AutoHoldFrames").Connect(FrameId_node_AutoHoldFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FrameId_node_AutoHoldFrames, assetPath);
					variableCount += FrameId_node_AutoHoldFrames.SetData((FSFrame)AutoHoldFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.InputId:
					FSInputNode InputId_node_AutoHoldFrames = graph.AddNode<FSInputNode>();
					GetPort("AutoHoldFrames").Connect(InputId_node_AutoHoldFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputId_node_AutoHoldFrames, assetPath);
					variableCount += InputId_node_AutoHoldFrames.SetData((FSInput)AutoHoldFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FuncId:
					FSFuncNode FuncId_node_AutoHoldFrames = graph.AddNode<FSFuncNode>();
					GetPort("AutoHoldFrames").Connect(FuncId_node_AutoHoldFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FuncId_node_AutoHoldFrames, assetPath);
					variableCount += FuncId_node_AutoHoldFrames.SetData((FSFunc)AutoHoldFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.MovementId:
					FSMovementNode MovementId_node_AutoHoldFrames = graph.AddNode<FSMovementNode>();
					GetPort("AutoHoldFrames").Connect(MovementId_node_AutoHoldFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(MovementId_node_AutoHoldFrames, assetPath);
					variableCount += MovementId_node_AutoHoldFrames.SetData((FSMovement)AutoHoldFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CombatId:
					FSCombatNode CombatId_node_AutoHoldFrames = graph.AddNode<FSCombatNode>();
					GetPort("AutoHoldFrames").Connect(CombatId_node_AutoHoldFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CombatId_node_AutoHoldFrames, assetPath);
					variableCount += CombatId_node_AutoHoldFrames.SetData((FSCombat)AutoHoldFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.GrabsId:
					FSGrabsNode GrabsId_node_AutoHoldFrames = graph.AddNode<FSGrabsNode>();
					GetPort("AutoHoldFrames").Connect(GrabsId_node_AutoHoldFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(GrabsId_node_AutoHoldFrames, assetPath);
					variableCount += GrabsId_node_AutoHoldFrames.SetData((FSGrabs)AutoHoldFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.DataId:
					FSDataNode DataId_node_AutoHoldFrames = graph.AddNode<FSDataNode>();
					GetPort("AutoHoldFrames").Connect(DataId_node_AutoHoldFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DataId_node_AutoHoldFrames, assetPath);
					variableCount += DataId_node_AutoHoldFrames.SetData((FSData)AutoHoldFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ScratchId:
					FSScratchNode ScratchId_node_AutoHoldFrames = graph.AddNode<FSScratchNode>();
					GetPort("AutoHoldFrames").Connect(ScratchId_node_AutoHoldFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ScratchId_node_AutoHoldFrames, assetPath);
					variableCount += ScratchId_node_AutoHoldFrames.SetData((FSScratch)AutoHoldFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AnimId:
					FSAnimNode AnimId_node_AutoHoldFrames = graph.AddNode<FSAnimNode>();
					GetPort("AutoHoldFrames").Connect(AnimId_node_AutoHoldFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AnimId_node_AutoHoldFrames, assetPath);
					variableCount += AnimId_node_AutoHoldFrames.SetData((FSAnim)AutoHoldFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SpeedId:
					FSSpeedNode SpeedId_node_AutoHoldFrames = graph.AddNode<FSSpeedNode>();
					GetPort("AutoHoldFrames").Connect(SpeedId_node_AutoHoldFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpeedId_node_AutoHoldFrames, assetPath);
					variableCount += SpeedId_node_AutoHoldFrames.SetData((FSSpeed)AutoHoldFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.PhysicsId:
					FSPhysicsNode PhysicsId_node_AutoHoldFrames = graph.AddNode<FSPhysicsNode>();
					GetPort("AutoHoldFrames").Connect(PhysicsId_node_AutoHoldFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(PhysicsId_node_AutoHoldFrames, assetPath);
					variableCount += PhysicsId_node_AutoHoldFrames.SetData((FSPhysics)AutoHoldFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CollisionId:
					FSCollisionNode CollisionId_node_AutoHoldFrames = graph.AddNode<FSCollisionNode>();
					GetPort("AutoHoldFrames").Connect(CollisionId_node_AutoHoldFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CollisionId_node_AutoHoldFrames, assetPath);
					variableCount += CollisionId_node_AutoHoldFrames.SetData((FSCollision)AutoHoldFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.TimerId:
					FSTimerNode TimerId_node_AutoHoldFrames = graph.AddNode<FSTimerNode>();
					GetPort("AutoHoldFrames").Connect(TimerId_node_AutoHoldFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(TimerId_node_AutoHoldFrames, assetPath);
					variableCount += TimerId_node_AutoHoldFrames.SetData((FSTimer)AutoHoldFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.LagId:
					FSLagNode LagId_node_AutoHoldFrames = graph.AddNode<FSLagNode>();
					GetPort("AutoHoldFrames").Connect(LagId_node_AutoHoldFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LagId_node_AutoHoldFrames, assetPath);
					variableCount += LagId_node_AutoHoldFrames.SetData((FSLag)AutoHoldFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.EffectsId:
					FSEffectsNode EffectsId_node_AutoHoldFrames = graph.AddNode<FSEffectsNode>();
					GetPort("AutoHoldFrames").Connect(EffectsId_node_AutoHoldFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EffectsId_node_AutoHoldFrames, assetPath);
					variableCount += EffectsId_node_AutoHoldFrames.SetData((FSEffects)AutoHoldFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ColorsId:
					FSColorsNode ColorsId_node_AutoHoldFrames = graph.AddNode<FSColorsNode>();
					GetPort("AutoHoldFrames").Connect(ColorsId_node_AutoHoldFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ColorsId_node_AutoHoldFrames, assetPath);
					variableCount += ColorsId_node_AutoHoldFrames.SetData((FSColors)AutoHoldFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.OnHitId:
					FSOnHitNode OnHitId_node_AutoHoldFrames = graph.AddNode<FSOnHitNode>();
					GetPort("AutoHoldFrames").Connect(OnHitId_node_AutoHoldFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnHitId_node_AutoHoldFrames, assetPath);
					variableCount += OnHitId_node_AutoHoldFrames.SetData((FSOnHit)AutoHoldFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RandomId:
					FSRandomNode RandomId_node_AutoHoldFrames = graph.AddNode<FSRandomNode>();
					GetPort("AutoHoldFrames").Connect(RandomId_node_AutoHoldFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RandomId_node_AutoHoldFrames, assetPath);
					variableCount += RandomId_node_AutoHoldFrames.SetData((FSRandom)AutoHoldFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CameraId:
					FSCameraInfoNode CameraId_node_AutoHoldFrames = graph.AddNode<FSCameraInfoNode>();
					GetPort("AutoHoldFrames").Connect(CameraId_node_AutoHoldFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CameraId_node_AutoHoldFrames, assetPath);
					variableCount += CameraId_node_AutoHoldFrames.SetData((FSCameraInfo)AutoHoldFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SportsId:
					FSSportsNode SportsId_node_AutoHoldFrames = graph.AddNode<FSSportsNode>();
					GetPort("AutoHoldFrames").Connect(SportsId_node_AutoHoldFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SportsId_node_AutoHoldFrames, assetPath);
					variableCount += SportsId_node_AutoHoldFrames.SetData((FSSports)AutoHoldFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.Vector2Mag:
					FSVector2MagNode Vector2Mag_node_AutoHoldFrames = graph.AddNode<FSVector2MagNode>();
					GetPort("AutoHoldFrames").Connect(Vector2Mag_node_AutoHoldFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(Vector2Mag_node_AutoHoldFrames, assetPath);
					variableCount += Vector2Mag_node_AutoHoldFrames.SetData((FSVector2Mag)AutoHoldFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CPUHelpId:
					FSCpuHelpNode CPUHelpId_node_AutoHoldFrames = graph.AddNode<FSCpuHelpNode>();
					GetPort("AutoHoldFrames").Connect(CPUHelpId_node_AutoHoldFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CPUHelpId_node_AutoHoldFrames, assetPath);
					variableCount += CPUHelpId_node_AutoHoldFrames.SetData((FSCpuHelp)AutoHoldFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ItemId:
					FSItemNode ItemId_node_AutoHoldFrames = graph.AddNode<FSItemNode>();
					GetPort("AutoHoldFrames").Connect(ItemId_node_AutoHoldFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ItemId_node_AutoHoldFrames, assetPath);
					variableCount += ItemId_node_AutoHoldFrames.SetData((FSItem)AutoHoldFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ModeId:
					FSModeNode ModeId_node_AutoHoldFrames = graph.AddNode<FSModeNode>();
					GetPort("AutoHoldFrames").Connect(ModeId_node_AutoHoldFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ModeId_node_AutoHoldFrames, assetPath);
					variableCount += ModeId_node_AutoHoldFrames.SetData((FSMode)AutoHoldFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.JumpsId:
					FSJumpsNode JumpsId_node_AutoHoldFrames = graph.AddNode<FSJumpsNode>();
					GetPort("AutoHoldFrames").Connect(JumpsId_node_AutoHoldFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(JumpsId_node_AutoHoldFrames, assetPath);
					variableCount += JumpsId_node_AutoHoldFrames.SetData((FSJumps)AutoHoldFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RootAnimId:
					FSRootAnimNode RootAnimId_node_AutoHoldFrames = graph.AddNode<FSRootAnimNode>();
					GetPort("AutoHoldFrames").Connect(RootAnimId_node_AutoHoldFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RootAnimId_node_AutoHoldFrames, assetPath);
					variableCount += RootAnimId_node_AutoHoldFrames.SetData((FSRootAnim)AutoHoldFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FloatId:
					FSValueNode FloatId_node_AutoHoldFrames = graph.AddNode<FSValueNode>();
					GetPort("AutoHoldFrames").Connect(FloatId_node_AutoHoldFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FloatId_node_AutoHoldFrames, assetPath);
					variableCount += FloatId_node_AutoHoldFrames.SetData((FSValue)AutoHoldFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
			}
			++variableCount;
			
			YVelMaxOnRelease = data.YVelMaxOnRelease;
			
			switch (YVelMaxOnRelease.TID)
			{
				case FloatSource.TypeId.AgentId:
					FSAgentNode AgentId_node_YVelMaxOnRelease = graph.AddNode<FSAgentNode>();
					GetPort("YVelMaxOnRelease").Connect(AgentId_node_YVelMaxOnRelease.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AgentId_node_YVelMaxOnRelease, assetPath);
					variableCount += AgentId_node_YVelMaxOnRelease.SetData((FSAgent)YVelMaxOnRelease, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.BonesId:
					FSBonesNode BonesId_node_YVelMaxOnRelease = graph.AddNode<FSBonesNode>();
					GetPort("YVelMaxOnRelease").Connect(BonesId_node_YVelMaxOnRelease.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BonesId_node_YVelMaxOnRelease, assetPath);
					variableCount += BonesId_node_YVelMaxOnRelease.SetData((FSBones)YVelMaxOnRelease, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AttackId:
					FSAttackNode AttackId_node_YVelMaxOnRelease = graph.AddNode<FSAttackNode>();
					GetPort("YVelMaxOnRelease").Connect(AttackId_node_YVelMaxOnRelease.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AttackId_node_YVelMaxOnRelease, assetPath);
					variableCount += AttackId_node_YVelMaxOnRelease.SetData((FSAttack)YVelMaxOnRelease, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FrameId:
					FSFrameNode FrameId_node_YVelMaxOnRelease = graph.AddNode<FSFrameNode>();
					GetPort("YVelMaxOnRelease").Connect(FrameId_node_YVelMaxOnRelease.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FrameId_node_YVelMaxOnRelease, assetPath);
					variableCount += FrameId_node_YVelMaxOnRelease.SetData((FSFrame)YVelMaxOnRelease, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.InputId:
					FSInputNode InputId_node_YVelMaxOnRelease = graph.AddNode<FSInputNode>();
					GetPort("YVelMaxOnRelease").Connect(InputId_node_YVelMaxOnRelease.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputId_node_YVelMaxOnRelease, assetPath);
					variableCount += InputId_node_YVelMaxOnRelease.SetData((FSInput)YVelMaxOnRelease, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FuncId:
					FSFuncNode FuncId_node_YVelMaxOnRelease = graph.AddNode<FSFuncNode>();
					GetPort("YVelMaxOnRelease").Connect(FuncId_node_YVelMaxOnRelease.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FuncId_node_YVelMaxOnRelease, assetPath);
					variableCount += FuncId_node_YVelMaxOnRelease.SetData((FSFunc)YVelMaxOnRelease, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.MovementId:
					FSMovementNode MovementId_node_YVelMaxOnRelease = graph.AddNode<FSMovementNode>();
					GetPort("YVelMaxOnRelease").Connect(MovementId_node_YVelMaxOnRelease.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(MovementId_node_YVelMaxOnRelease, assetPath);
					variableCount += MovementId_node_YVelMaxOnRelease.SetData((FSMovement)YVelMaxOnRelease, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CombatId:
					FSCombatNode CombatId_node_YVelMaxOnRelease = graph.AddNode<FSCombatNode>();
					GetPort("YVelMaxOnRelease").Connect(CombatId_node_YVelMaxOnRelease.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CombatId_node_YVelMaxOnRelease, assetPath);
					variableCount += CombatId_node_YVelMaxOnRelease.SetData((FSCombat)YVelMaxOnRelease, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.GrabsId:
					FSGrabsNode GrabsId_node_YVelMaxOnRelease = graph.AddNode<FSGrabsNode>();
					GetPort("YVelMaxOnRelease").Connect(GrabsId_node_YVelMaxOnRelease.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(GrabsId_node_YVelMaxOnRelease, assetPath);
					variableCount += GrabsId_node_YVelMaxOnRelease.SetData((FSGrabs)YVelMaxOnRelease, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.DataId:
					FSDataNode DataId_node_YVelMaxOnRelease = graph.AddNode<FSDataNode>();
					GetPort("YVelMaxOnRelease").Connect(DataId_node_YVelMaxOnRelease.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DataId_node_YVelMaxOnRelease, assetPath);
					variableCount += DataId_node_YVelMaxOnRelease.SetData((FSData)YVelMaxOnRelease, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ScratchId:
					FSScratchNode ScratchId_node_YVelMaxOnRelease = graph.AddNode<FSScratchNode>();
					GetPort("YVelMaxOnRelease").Connect(ScratchId_node_YVelMaxOnRelease.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ScratchId_node_YVelMaxOnRelease, assetPath);
					variableCount += ScratchId_node_YVelMaxOnRelease.SetData((FSScratch)YVelMaxOnRelease, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AnimId:
					FSAnimNode AnimId_node_YVelMaxOnRelease = graph.AddNode<FSAnimNode>();
					GetPort("YVelMaxOnRelease").Connect(AnimId_node_YVelMaxOnRelease.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AnimId_node_YVelMaxOnRelease, assetPath);
					variableCount += AnimId_node_YVelMaxOnRelease.SetData((FSAnim)YVelMaxOnRelease, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SpeedId:
					FSSpeedNode SpeedId_node_YVelMaxOnRelease = graph.AddNode<FSSpeedNode>();
					GetPort("YVelMaxOnRelease").Connect(SpeedId_node_YVelMaxOnRelease.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpeedId_node_YVelMaxOnRelease, assetPath);
					variableCount += SpeedId_node_YVelMaxOnRelease.SetData((FSSpeed)YVelMaxOnRelease, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.PhysicsId:
					FSPhysicsNode PhysicsId_node_YVelMaxOnRelease = graph.AddNode<FSPhysicsNode>();
					GetPort("YVelMaxOnRelease").Connect(PhysicsId_node_YVelMaxOnRelease.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(PhysicsId_node_YVelMaxOnRelease, assetPath);
					variableCount += PhysicsId_node_YVelMaxOnRelease.SetData((FSPhysics)YVelMaxOnRelease, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CollisionId:
					FSCollisionNode CollisionId_node_YVelMaxOnRelease = graph.AddNode<FSCollisionNode>();
					GetPort("YVelMaxOnRelease").Connect(CollisionId_node_YVelMaxOnRelease.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CollisionId_node_YVelMaxOnRelease, assetPath);
					variableCount += CollisionId_node_YVelMaxOnRelease.SetData((FSCollision)YVelMaxOnRelease, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.TimerId:
					FSTimerNode TimerId_node_YVelMaxOnRelease = graph.AddNode<FSTimerNode>();
					GetPort("YVelMaxOnRelease").Connect(TimerId_node_YVelMaxOnRelease.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(TimerId_node_YVelMaxOnRelease, assetPath);
					variableCount += TimerId_node_YVelMaxOnRelease.SetData((FSTimer)YVelMaxOnRelease, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.LagId:
					FSLagNode LagId_node_YVelMaxOnRelease = graph.AddNode<FSLagNode>();
					GetPort("YVelMaxOnRelease").Connect(LagId_node_YVelMaxOnRelease.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LagId_node_YVelMaxOnRelease, assetPath);
					variableCount += LagId_node_YVelMaxOnRelease.SetData((FSLag)YVelMaxOnRelease, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.EffectsId:
					FSEffectsNode EffectsId_node_YVelMaxOnRelease = graph.AddNode<FSEffectsNode>();
					GetPort("YVelMaxOnRelease").Connect(EffectsId_node_YVelMaxOnRelease.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EffectsId_node_YVelMaxOnRelease, assetPath);
					variableCount += EffectsId_node_YVelMaxOnRelease.SetData((FSEffects)YVelMaxOnRelease, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ColorsId:
					FSColorsNode ColorsId_node_YVelMaxOnRelease = graph.AddNode<FSColorsNode>();
					GetPort("YVelMaxOnRelease").Connect(ColorsId_node_YVelMaxOnRelease.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ColorsId_node_YVelMaxOnRelease, assetPath);
					variableCount += ColorsId_node_YVelMaxOnRelease.SetData((FSColors)YVelMaxOnRelease, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.OnHitId:
					FSOnHitNode OnHitId_node_YVelMaxOnRelease = graph.AddNode<FSOnHitNode>();
					GetPort("YVelMaxOnRelease").Connect(OnHitId_node_YVelMaxOnRelease.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnHitId_node_YVelMaxOnRelease, assetPath);
					variableCount += OnHitId_node_YVelMaxOnRelease.SetData((FSOnHit)YVelMaxOnRelease, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RandomId:
					FSRandomNode RandomId_node_YVelMaxOnRelease = graph.AddNode<FSRandomNode>();
					GetPort("YVelMaxOnRelease").Connect(RandomId_node_YVelMaxOnRelease.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RandomId_node_YVelMaxOnRelease, assetPath);
					variableCount += RandomId_node_YVelMaxOnRelease.SetData((FSRandom)YVelMaxOnRelease, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CameraId:
					FSCameraInfoNode CameraId_node_YVelMaxOnRelease = graph.AddNode<FSCameraInfoNode>();
					GetPort("YVelMaxOnRelease").Connect(CameraId_node_YVelMaxOnRelease.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CameraId_node_YVelMaxOnRelease, assetPath);
					variableCount += CameraId_node_YVelMaxOnRelease.SetData((FSCameraInfo)YVelMaxOnRelease, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SportsId:
					FSSportsNode SportsId_node_YVelMaxOnRelease = graph.AddNode<FSSportsNode>();
					GetPort("YVelMaxOnRelease").Connect(SportsId_node_YVelMaxOnRelease.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SportsId_node_YVelMaxOnRelease, assetPath);
					variableCount += SportsId_node_YVelMaxOnRelease.SetData((FSSports)YVelMaxOnRelease, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.Vector2Mag:
					FSVector2MagNode Vector2Mag_node_YVelMaxOnRelease = graph.AddNode<FSVector2MagNode>();
					GetPort("YVelMaxOnRelease").Connect(Vector2Mag_node_YVelMaxOnRelease.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(Vector2Mag_node_YVelMaxOnRelease, assetPath);
					variableCount += Vector2Mag_node_YVelMaxOnRelease.SetData((FSVector2Mag)YVelMaxOnRelease, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CPUHelpId:
					FSCpuHelpNode CPUHelpId_node_YVelMaxOnRelease = graph.AddNode<FSCpuHelpNode>();
					GetPort("YVelMaxOnRelease").Connect(CPUHelpId_node_YVelMaxOnRelease.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CPUHelpId_node_YVelMaxOnRelease, assetPath);
					variableCount += CPUHelpId_node_YVelMaxOnRelease.SetData((FSCpuHelp)YVelMaxOnRelease, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ItemId:
					FSItemNode ItemId_node_YVelMaxOnRelease = graph.AddNode<FSItemNode>();
					GetPort("YVelMaxOnRelease").Connect(ItemId_node_YVelMaxOnRelease.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ItemId_node_YVelMaxOnRelease, assetPath);
					variableCount += ItemId_node_YVelMaxOnRelease.SetData((FSItem)YVelMaxOnRelease, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ModeId:
					FSModeNode ModeId_node_YVelMaxOnRelease = graph.AddNode<FSModeNode>();
					GetPort("YVelMaxOnRelease").Connect(ModeId_node_YVelMaxOnRelease.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ModeId_node_YVelMaxOnRelease, assetPath);
					variableCount += ModeId_node_YVelMaxOnRelease.SetData((FSMode)YVelMaxOnRelease, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.JumpsId:
					FSJumpsNode JumpsId_node_YVelMaxOnRelease = graph.AddNode<FSJumpsNode>();
					GetPort("YVelMaxOnRelease").Connect(JumpsId_node_YVelMaxOnRelease.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(JumpsId_node_YVelMaxOnRelease, assetPath);
					variableCount += JumpsId_node_YVelMaxOnRelease.SetData((FSJumps)YVelMaxOnRelease, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RootAnimId:
					FSRootAnimNode RootAnimId_node_YVelMaxOnRelease = graph.AddNode<FSRootAnimNode>();
					GetPort("YVelMaxOnRelease").Connect(RootAnimId_node_YVelMaxOnRelease.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RootAnimId_node_YVelMaxOnRelease, assetPath);
					variableCount += RootAnimId_node_YVelMaxOnRelease.SetData((FSRootAnim)YVelMaxOnRelease, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FloatId:
					FSValueNode FloatId_node_YVelMaxOnRelease = graph.AddNode<FSValueNode>();
					GetPort("YVelMaxOnRelease").Connect(FloatId_node_YVelMaxOnRelease.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FloatId_node_YVelMaxOnRelease, assetPath);
					variableCount += FloatId_node_YVelMaxOnRelease.SetData((FSValue)YVelMaxOnRelease, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
			}
			
			return variableCount;
		}
		
		public new DelayedJump GetData()
		{
			DelayedJump objToReturn = new DelayedJump();
			objToReturn.TID = TypeId.DelayedId;
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
			if (GetPort("AutoHoldFrames").ConnectionCount > 0)
			{
				FloatSourceNode FloatSource_Node = (FloatSourceNode)GetPort("AutoHoldFrames").GetConnection(0).node;
				switch (FloatSource_Node.TID)
				{
					case FloatSource.TypeId.AgentId:
						FSAgentNode AgentId_FloatSource_Node = (FSAgentNode)GetPort("AutoHoldFrames").GetConnection(0).node;
						objToReturn.AutoHoldFrames = AgentId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.BonesId:
						FSBonesNode BonesId_FloatSource_Node = (FSBonesNode)GetPort("AutoHoldFrames").GetConnection(0).node;
						objToReturn.AutoHoldFrames = BonesId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AttackId:
						FSAttackNode AttackId_FloatSource_Node = (FSAttackNode)GetPort("AutoHoldFrames").GetConnection(0).node;
						objToReturn.AutoHoldFrames = AttackId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FrameId:
						FSFrameNode FrameId_FloatSource_Node = (FSFrameNode)GetPort("AutoHoldFrames").GetConnection(0).node;
						objToReturn.AutoHoldFrames = FrameId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.InputId:
						FSInputNode InputId_FloatSource_Node = (FSInputNode)GetPort("AutoHoldFrames").GetConnection(0).node;
						objToReturn.AutoHoldFrames = InputId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FuncId:
						FSFuncNode FuncId_FloatSource_Node = (FSFuncNode)GetPort("AutoHoldFrames").GetConnection(0).node;
						objToReturn.AutoHoldFrames = FuncId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.MovementId:
						FSMovementNode MovementId_FloatSource_Node = (FSMovementNode)GetPort("AutoHoldFrames").GetConnection(0).node;
						objToReturn.AutoHoldFrames = MovementId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CombatId:
						FSCombatNode CombatId_FloatSource_Node = (FSCombatNode)GetPort("AutoHoldFrames").GetConnection(0).node;
						objToReturn.AutoHoldFrames = CombatId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.GrabsId:
						FSGrabsNode GrabsId_FloatSource_Node = (FSGrabsNode)GetPort("AutoHoldFrames").GetConnection(0).node;
						objToReturn.AutoHoldFrames = GrabsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.DataId:
						FSDataNode DataId_FloatSource_Node = (FSDataNode)GetPort("AutoHoldFrames").GetConnection(0).node;
						objToReturn.AutoHoldFrames = DataId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ScratchId:
						FSScratchNode ScratchId_FloatSource_Node = (FSScratchNode)GetPort("AutoHoldFrames").GetConnection(0).node;
						objToReturn.AutoHoldFrames = ScratchId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AnimId:
						FSAnimNode AnimId_FloatSource_Node = (FSAnimNode)GetPort("AutoHoldFrames").GetConnection(0).node;
						objToReturn.AutoHoldFrames = AnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SpeedId:
						FSSpeedNode SpeedId_FloatSource_Node = (FSSpeedNode)GetPort("AutoHoldFrames").GetConnection(0).node;
						objToReturn.AutoHoldFrames = SpeedId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.PhysicsId:
						FSPhysicsNode PhysicsId_FloatSource_Node = (FSPhysicsNode)GetPort("AutoHoldFrames").GetConnection(0).node;
						objToReturn.AutoHoldFrames = PhysicsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CollisionId:
						FSCollisionNode CollisionId_FloatSource_Node = (FSCollisionNode)GetPort("AutoHoldFrames").GetConnection(0).node;
						objToReturn.AutoHoldFrames = CollisionId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.TimerId:
						FSTimerNode TimerId_FloatSource_Node = (FSTimerNode)GetPort("AutoHoldFrames").GetConnection(0).node;
						objToReturn.AutoHoldFrames = TimerId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.LagId:
						FSLagNode LagId_FloatSource_Node = (FSLagNode)GetPort("AutoHoldFrames").GetConnection(0).node;
						objToReturn.AutoHoldFrames = LagId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.EffectsId:
						FSEffectsNode EffectsId_FloatSource_Node = (FSEffectsNode)GetPort("AutoHoldFrames").GetConnection(0).node;
						objToReturn.AutoHoldFrames = EffectsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ColorsId:
						FSColorsNode ColorsId_FloatSource_Node = (FSColorsNode)GetPort("AutoHoldFrames").GetConnection(0).node;
						objToReturn.AutoHoldFrames = ColorsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.OnHitId:
						FSOnHitNode OnHitId_FloatSource_Node = (FSOnHitNode)GetPort("AutoHoldFrames").GetConnection(0).node;
						objToReturn.AutoHoldFrames = OnHitId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RandomId:
						FSRandomNode RandomId_FloatSource_Node = (FSRandomNode)GetPort("AutoHoldFrames").GetConnection(0).node;
						objToReturn.AutoHoldFrames = RandomId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CameraId:
						FSCameraInfoNode CameraId_FloatSource_Node = (FSCameraInfoNode)GetPort("AutoHoldFrames").GetConnection(0).node;
						objToReturn.AutoHoldFrames = CameraId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SportsId:
						FSSportsNode SportsId_FloatSource_Node = (FSSportsNode)GetPort("AutoHoldFrames").GetConnection(0).node;
						objToReturn.AutoHoldFrames = SportsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.Vector2Mag:
						FSVector2MagNode Vector2Mag_FloatSource_Node = (FSVector2MagNode)GetPort("AutoHoldFrames").GetConnection(0).node;
						objToReturn.AutoHoldFrames = Vector2Mag_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CPUHelpId:
						FSCpuHelpNode CPUHelpId_FloatSource_Node = (FSCpuHelpNode)GetPort("AutoHoldFrames").GetConnection(0).node;
						objToReturn.AutoHoldFrames = CPUHelpId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ItemId:
						FSItemNode ItemId_FloatSource_Node = (FSItemNode)GetPort("AutoHoldFrames").GetConnection(0).node;
						objToReturn.AutoHoldFrames = ItemId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ModeId:
						FSModeNode ModeId_FloatSource_Node = (FSModeNode)GetPort("AutoHoldFrames").GetConnection(0).node;
						objToReturn.AutoHoldFrames = ModeId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.JumpsId:
						FSJumpsNode JumpsId_FloatSource_Node = (FSJumpsNode)GetPort("AutoHoldFrames").GetConnection(0).node;
						objToReturn.AutoHoldFrames = JumpsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RootAnimId:
						FSRootAnimNode RootAnimId_FloatSource_Node = (FSRootAnimNode)GetPort("AutoHoldFrames").GetConnection(0).node;
						objToReturn.AutoHoldFrames = RootAnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FloatId:
						FSValueNode FloatId_FloatSource_Node = (FSValueNode)GetPort("AutoHoldFrames").GetConnection(0).node;
						objToReturn.AutoHoldFrames = FloatId_FloatSource_Node.GetData();
					break;
				}
			}
			if (GetPort("YVelMaxOnRelease").ConnectionCount > 0)
			{
				FloatSourceNode FloatSource_Node = (FloatSourceNode)GetPort("YVelMaxOnRelease").GetConnection(0).node;
				switch (FloatSource_Node.TID)
				{
					case FloatSource.TypeId.AgentId:
						FSAgentNode AgentId_FloatSource_Node = (FSAgentNode)GetPort("YVelMaxOnRelease").GetConnection(0).node;
						objToReturn.YVelMaxOnRelease = AgentId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.BonesId:
						FSBonesNode BonesId_FloatSource_Node = (FSBonesNode)GetPort("YVelMaxOnRelease").GetConnection(0).node;
						objToReturn.YVelMaxOnRelease = BonesId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AttackId:
						FSAttackNode AttackId_FloatSource_Node = (FSAttackNode)GetPort("YVelMaxOnRelease").GetConnection(0).node;
						objToReturn.YVelMaxOnRelease = AttackId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FrameId:
						FSFrameNode FrameId_FloatSource_Node = (FSFrameNode)GetPort("YVelMaxOnRelease").GetConnection(0).node;
						objToReturn.YVelMaxOnRelease = FrameId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.InputId:
						FSInputNode InputId_FloatSource_Node = (FSInputNode)GetPort("YVelMaxOnRelease").GetConnection(0).node;
						objToReturn.YVelMaxOnRelease = InputId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FuncId:
						FSFuncNode FuncId_FloatSource_Node = (FSFuncNode)GetPort("YVelMaxOnRelease").GetConnection(0).node;
						objToReturn.YVelMaxOnRelease = FuncId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.MovementId:
						FSMovementNode MovementId_FloatSource_Node = (FSMovementNode)GetPort("YVelMaxOnRelease").GetConnection(0).node;
						objToReturn.YVelMaxOnRelease = MovementId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CombatId:
						FSCombatNode CombatId_FloatSource_Node = (FSCombatNode)GetPort("YVelMaxOnRelease").GetConnection(0).node;
						objToReturn.YVelMaxOnRelease = CombatId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.GrabsId:
						FSGrabsNode GrabsId_FloatSource_Node = (FSGrabsNode)GetPort("YVelMaxOnRelease").GetConnection(0).node;
						objToReturn.YVelMaxOnRelease = GrabsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.DataId:
						FSDataNode DataId_FloatSource_Node = (FSDataNode)GetPort("YVelMaxOnRelease").GetConnection(0).node;
						objToReturn.YVelMaxOnRelease = DataId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ScratchId:
						FSScratchNode ScratchId_FloatSource_Node = (FSScratchNode)GetPort("YVelMaxOnRelease").GetConnection(0).node;
						objToReturn.YVelMaxOnRelease = ScratchId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AnimId:
						FSAnimNode AnimId_FloatSource_Node = (FSAnimNode)GetPort("YVelMaxOnRelease").GetConnection(0).node;
						objToReturn.YVelMaxOnRelease = AnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SpeedId:
						FSSpeedNode SpeedId_FloatSource_Node = (FSSpeedNode)GetPort("YVelMaxOnRelease").GetConnection(0).node;
						objToReturn.YVelMaxOnRelease = SpeedId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.PhysicsId:
						FSPhysicsNode PhysicsId_FloatSource_Node = (FSPhysicsNode)GetPort("YVelMaxOnRelease").GetConnection(0).node;
						objToReturn.YVelMaxOnRelease = PhysicsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CollisionId:
						FSCollisionNode CollisionId_FloatSource_Node = (FSCollisionNode)GetPort("YVelMaxOnRelease").GetConnection(0).node;
						objToReturn.YVelMaxOnRelease = CollisionId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.TimerId:
						FSTimerNode TimerId_FloatSource_Node = (FSTimerNode)GetPort("YVelMaxOnRelease").GetConnection(0).node;
						objToReturn.YVelMaxOnRelease = TimerId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.LagId:
						FSLagNode LagId_FloatSource_Node = (FSLagNode)GetPort("YVelMaxOnRelease").GetConnection(0).node;
						objToReturn.YVelMaxOnRelease = LagId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.EffectsId:
						FSEffectsNode EffectsId_FloatSource_Node = (FSEffectsNode)GetPort("YVelMaxOnRelease").GetConnection(0).node;
						objToReturn.YVelMaxOnRelease = EffectsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ColorsId:
						FSColorsNode ColorsId_FloatSource_Node = (FSColorsNode)GetPort("YVelMaxOnRelease").GetConnection(0).node;
						objToReturn.YVelMaxOnRelease = ColorsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.OnHitId:
						FSOnHitNode OnHitId_FloatSource_Node = (FSOnHitNode)GetPort("YVelMaxOnRelease").GetConnection(0).node;
						objToReturn.YVelMaxOnRelease = OnHitId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RandomId:
						FSRandomNode RandomId_FloatSource_Node = (FSRandomNode)GetPort("YVelMaxOnRelease").GetConnection(0).node;
						objToReturn.YVelMaxOnRelease = RandomId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CameraId:
						FSCameraInfoNode CameraId_FloatSource_Node = (FSCameraInfoNode)GetPort("YVelMaxOnRelease").GetConnection(0).node;
						objToReturn.YVelMaxOnRelease = CameraId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SportsId:
						FSSportsNode SportsId_FloatSource_Node = (FSSportsNode)GetPort("YVelMaxOnRelease").GetConnection(0).node;
						objToReturn.YVelMaxOnRelease = SportsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.Vector2Mag:
						FSVector2MagNode Vector2Mag_FloatSource_Node = (FSVector2MagNode)GetPort("YVelMaxOnRelease").GetConnection(0).node;
						objToReturn.YVelMaxOnRelease = Vector2Mag_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CPUHelpId:
						FSCpuHelpNode CPUHelpId_FloatSource_Node = (FSCpuHelpNode)GetPort("YVelMaxOnRelease").GetConnection(0).node;
						objToReturn.YVelMaxOnRelease = CPUHelpId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ItemId:
						FSItemNode ItemId_FloatSource_Node = (FSItemNode)GetPort("YVelMaxOnRelease").GetConnection(0).node;
						objToReturn.YVelMaxOnRelease = ItemId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ModeId:
						FSModeNode ModeId_FloatSource_Node = (FSModeNode)GetPort("YVelMaxOnRelease").GetConnection(0).node;
						objToReturn.YVelMaxOnRelease = ModeId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.JumpsId:
						FSJumpsNode JumpsId_FloatSource_Node = (FSJumpsNode)GetPort("YVelMaxOnRelease").GetConnection(0).node;
						objToReturn.YVelMaxOnRelease = JumpsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RootAnimId:
						FSRootAnimNode RootAnimId_FloatSource_Node = (FSRootAnimNode)GetPort("YVelMaxOnRelease").GetConnection(0).node;
						objToReturn.YVelMaxOnRelease = RootAnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FloatId:
						FSValueNode FloatId_FloatSource_Node = (FSValueNode)GetPort("YVelMaxOnRelease").GetConnection(0).node;
						objToReturn.YVelMaxOnRelease = FloatId_FloatSource_Node.GetData();
					break;
				}
			}
			return objToReturn;
		}
	}
}

