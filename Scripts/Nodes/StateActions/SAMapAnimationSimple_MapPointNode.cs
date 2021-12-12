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
	public class SAMapAnimationSimple_MapPointNode : StateActionNode
	{
		[Input(connectionType = ConnectionType.Override)] public SAMapAnimationSimple.MapPoint NodeInput;
		[Output(connectionType = ConnectionType.Override)] public FloatSource OffsetFrame;
		[Output(connectionType = ConnectionType.Override)] public FloatSource AnimFrame;
		
		protected override void Init()
		{
			base.Init();
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SAMapAnimationSimple.MapPoint data, MovesetGraph graph, string assetPath, Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SAMapAnimationSimple.MapPoint));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			OffsetFrame = data.OffsetFrame;
			
			switch (OffsetFrame.TID)
			{
				case FloatSource.TypeId.AgentId:
					FSAgentNode AgentId_node_OffsetFrame = graph.AddNode<FSAgentNode>();
					GetPort("OffsetFrame").Connect(AgentId_node_OffsetFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AgentId_node_OffsetFrame, assetPath);
					variableCount += AgentId_node_OffsetFrame.SetData((FSAgent)OffsetFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.BonesId:
					FSBonesNode BonesId_node_OffsetFrame = graph.AddNode<FSBonesNode>();
					GetPort("OffsetFrame").Connect(BonesId_node_OffsetFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BonesId_node_OffsetFrame, assetPath);
					variableCount += BonesId_node_OffsetFrame.SetData((FSBones)OffsetFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AttackId:
					FSAttackNode AttackId_node_OffsetFrame = graph.AddNode<FSAttackNode>();
					GetPort("OffsetFrame").Connect(AttackId_node_OffsetFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AttackId_node_OffsetFrame, assetPath);
					variableCount += AttackId_node_OffsetFrame.SetData((FSAttack)OffsetFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FrameId:
					FSFrameNode FrameId_node_OffsetFrame = graph.AddNode<FSFrameNode>();
					GetPort("OffsetFrame").Connect(FrameId_node_OffsetFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FrameId_node_OffsetFrame, assetPath);
					variableCount += FrameId_node_OffsetFrame.SetData((FSFrame)OffsetFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.InputId:
					FSInputNode InputId_node_OffsetFrame = graph.AddNode<FSInputNode>();
					GetPort("OffsetFrame").Connect(InputId_node_OffsetFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputId_node_OffsetFrame, assetPath);
					variableCount += InputId_node_OffsetFrame.SetData((FSInput)OffsetFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FuncId:
					FSFuncNode FuncId_node_OffsetFrame = graph.AddNode<FSFuncNode>();
					GetPort("OffsetFrame").Connect(FuncId_node_OffsetFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FuncId_node_OffsetFrame, assetPath);
					variableCount += FuncId_node_OffsetFrame.SetData((FSFunc)OffsetFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.MovementId:
					FSMovementNode MovementId_node_OffsetFrame = graph.AddNode<FSMovementNode>();
					GetPort("OffsetFrame").Connect(MovementId_node_OffsetFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(MovementId_node_OffsetFrame, assetPath);
					variableCount += MovementId_node_OffsetFrame.SetData((FSMovement)OffsetFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CombatId:
					FSCombatNode CombatId_node_OffsetFrame = graph.AddNode<FSCombatNode>();
					GetPort("OffsetFrame").Connect(CombatId_node_OffsetFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CombatId_node_OffsetFrame, assetPath);
					variableCount += CombatId_node_OffsetFrame.SetData((FSCombat)OffsetFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.GrabsId:
					FSGrabsNode GrabsId_node_OffsetFrame = graph.AddNode<FSGrabsNode>();
					GetPort("OffsetFrame").Connect(GrabsId_node_OffsetFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(GrabsId_node_OffsetFrame, assetPath);
					variableCount += GrabsId_node_OffsetFrame.SetData((FSGrabs)OffsetFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.DataId:
					FSDataNode DataId_node_OffsetFrame = graph.AddNode<FSDataNode>();
					GetPort("OffsetFrame").Connect(DataId_node_OffsetFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DataId_node_OffsetFrame, assetPath);
					variableCount += DataId_node_OffsetFrame.SetData((FSData)OffsetFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ScratchId:
					FSScratchNode ScratchId_node_OffsetFrame = graph.AddNode<FSScratchNode>();
					GetPort("OffsetFrame").Connect(ScratchId_node_OffsetFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ScratchId_node_OffsetFrame, assetPath);
					variableCount += ScratchId_node_OffsetFrame.SetData((FSScratch)OffsetFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AnimId:
					FSAnimNode AnimId_node_OffsetFrame = graph.AddNode<FSAnimNode>();
					GetPort("OffsetFrame").Connect(AnimId_node_OffsetFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AnimId_node_OffsetFrame, assetPath);
					variableCount += AnimId_node_OffsetFrame.SetData((FSAnim)OffsetFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SpeedId:
					FSSpeedNode SpeedId_node_OffsetFrame = graph.AddNode<FSSpeedNode>();
					GetPort("OffsetFrame").Connect(SpeedId_node_OffsetFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpeedId_node_OffsetFrame, assetPath);
					variableCount += SpeedId_node_OffsetFrame.SetData((FSSpeed)OffsetFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.PhysicsId:
					FSPhysicsNode PhysicsId_node_OffsetFrame = graph.AddNode<FSPhysicsNode>();
					GetPort("OffsetFrame").Connect(PhysicsId_node_OffsetFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(PhysicsId_node_OffsetFrame, assetPath);
					variableCount += PhysicsId_node_OffsetFrame.SetData((FSPhysics)OffsetFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CollisionId:
					FSCollisionNode CollisionId_node_OffsetFrame = graph.AddNode<FSCollisionNode>();
					GetPort("OffsetFrame").Connect(CollisionId_node_OffsetFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CollisionId_node_OffsetFrame, assetPath);
					variableCount += CollisionId_node_OffsetFrame.SetData((FSCollision)OffsetFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.TimerId:
					FSTimerNode TimerId_node_OffsetFrame = graph.AddNode<FSTimerNode>();
					GetPort("OffsetFrame").Connect(TimerId_node_OffsetFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(TimerId_node_OffsetFrame, assetPath);
					variableCount += TimerId_node_OffsetFrame.SetData((FSTimer)OffsetFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.LagId:
					FSLagNode LagId_node_OffsetFrame = graph.AddNode<FSLagNode>();
					GetPort("OffsetFrame").Connect(LagId_node_OffsetFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LagId_node_OffsetFrame, assetPath);
					variableCount += LagId_node_OffsetFrame.SetData((FSLag)OffsetFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.EffectsId:
					FSEffectsNode EffectsId_node_OffsetFrame = graph.AddNode<FSEffectsNode>();
					GetPort("OffsetFrame").Connect(EffectsId_node_OffsetFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EffectsId_node_OffsetFrame, assetPath);
					variableCount += EffectsId_node_OffsetFrame.SetData((FSEffects)OffsetFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ColorsId:
					FSColorsNode ColorsId_node_OffsetFrame = graph.AddNode<FSColorsNode>();
					GetPort("OffsetFrame").Connect(ColorsId_node_OffsetFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ColorsId_node_OffsetFrame, assetPath);
					variableCount += ColorsId_node_OffsetFrame.SetData((FSColors)OffsetFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.OnHitId:
					FSOnHitNode OnHitId_node_OffsetFrame = graph.AddNode<FSOnHitNode>();
					GetPort("OffsetFrame").Connect(OnHitId_node_OffsetFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnHitId_node_OffsetFrame, assetPath);
					variableCount += OnHitId_node_OffsetFrame.SetData((FSOnHit)OffsetFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RandomId:
					FSRandomNode RandomId_node_OffsetFrame = graph.AddNode<FSRandomNode>();
					GetPort("OffsetFrame").Connect(RandomId_node_OffsetFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RandomId_node_OffsetFrame, assetPath);
					variableCount += RandomId_node_OffsetFrame.SetData((FSRandom)OffsetFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CameraId:
					FSCameraInfoNode CameraId_node_OffsetFrame = graph.AddNode<FSCameraInfoNode>();
					GetPort("OffsetFrame").Connect(CameraId_node_OffsetFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CameraId_node_OffsetFrame, assetPath);
					variableCount += CameraId_node_OffsetFrame.SetData((FSCameraInfo)OffsetFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SportsId:
					FSSportsNode SportsId_node_OffsetFrame = graph.AddNode<FSSportsNode>();
					GetPort("OffsetFrame").Connect(SportsId_node_OffsetFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SportsId_node_OffsetFrame, assetPath);
					variableCount += SportsId_node_OffsetFrame.SetData((FSSports)OffsetFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.Vector2Mag:
					FSVector2MagNode Vector2Mag_node_OffsetFrame = graph.AddNode<FSVector2MagNode>();
					GetPort("OffsetFrame").Connect(Vector2Mag_node_OffsetFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(Vector2Mag_node_OffsetFrame, assetPath);
					variableCount += Vector2Mag_node_OffsetFrame.SetData((FSVector2Mag)OffsetFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CPUHelpId:
					FSCpuHelpNode CPUHelpId_node_OffsetFrame = graph.AddNode<FSCpuHelpNode>();
					GetPort("OffsetFrame").Connect(CPUHelpId_node_OffsetFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CPUHelpId_node_OffsetFrame, assetPath);
					variableCount += CPUHelpId_node_OffsetFrame.SetData((FSCpuHelp)OffsetFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ItemId:
					FSItemNode ItemId_node_OffsetFrame = graph.AddNode<FSItemNode>();
					GetPort("OffsetFrame").Connect(ItemId_node_OffsetFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ItemId_node_OffsetFrame, assetPath);
					variableCount += ItemId_node_OffsetFrame.SetData((FSItem)OffsetFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ModeId:
					FSModeNode ModeId_node_OffsetFrame = graph.AddNode<FSModeNode>();
					GetPort("OffsetFrame").Connect(ModeId_node_OffsetFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ModeId_node_OffsetFrame, assetPath);
					variableCount += ModeId_node_OffsetFrame.SetData((FSMode)OffsetFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.JumpsId:
					FSJumpsNode JumpsId_node_OffsetFrame = graph.AddNode<FSJumpsNode>();
					GetPort("OffsetFrame").Connect(JumpsId_node_OffsetFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(JumpsId_node_OffsetFrame, assetPath);
					variableCount += JumpsId_node_OffsetFrame.SetData((FSJumps)OffsetFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RootAnimId:
					FSRootAnimNode RootAnimId_node_OffsetFrame = graph.AddNode<FSRootAnimNode>();
					GetPort("OffsetFrame").Connect(RootAnimId_node_OffsetFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RootAnimId_node_OffsetFrame, assetPath);
					variableCount += RootAnimId_node_OffsetFrame.SetData((FSRootAnim)OffsetFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FloatId:
					FSValueNode FloatId_node_OffsetFrame = graph.AddNode<FSValueNode>();
					GetPort("OffsetFrame").Connect(FloatId_node_OffsetFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FloatId_node_OffsetFrame, assetPath);
					variableCount += FloatId_node_OffsetFrame.SetData((FSValue)OffsetFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
			}
			++variableCount;
			
			AnimFrame = data.AnimFrame;
			
			switch (AnimFrame.TID)
			{
				case FloatSource.TypeId.AgentId:
					FSAgentNode AgentId_node_AnimFrame = graph.AddNode<FSAgentNode>();
					GetPort("AnimFrame").Connect(AgentId_node_AnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AgentId_node_AnimFrame, assetPath);
					variableCount += AgentId_node_AnimFrame.SetData((FSAgent)AnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.BonesId:
					FSBonesNode BonesId_node_AnimFrame = graph.AddNode<FSBonesNode>();
					GetPort("AnimFrame").Connect(BonesId_node_AnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BonesId_node_AnimFrame, assetPath);
					variableCount += BonesId_node_AnimFrame.SetData((FSBones)AnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AttackId:
					FSAttackNode AttackId_node_AnimFrame = graph.AddNode<FSAttackNode>();
					GetPort("AnimFrame").Connect(AttackId_node_AnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AttackId_node_AnimFrame, assetPath);
					variableCount += AttackId_node_AnimFrame.SetData((FSAttack)AnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FrameId:
					FSFrameNode FrameId_node_AnimFrame = graph.AddNode<FSFrameNode>();
					GetPort("AnimFrame").Connect(FrameId_node_AnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FrameId_node_AnimFrame, assetPath);
					variableCount += FrameId_node_AnimFrame.SetData((FSFrame)AnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.InputId:
					FSInputNode InputId_node_AnimFrame = graph.AddNode<FSInputNode>();
					GetPort("AnimFrame").Connect(InputId_node_AnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputId_node_AnimFrame, assetPath);
					variableCount += InputId_node_AnimFrame.SetData((FSInput)AnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FuncId:
					FSFuncNode FuncId_node_AnimFrame = graph.AddNode<FSFuncNode>();
					GetPort("AnimFrame").Connect(FuncId_node_AnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FuncId_node_AnimFrame, assetPath);
					variableCount += FuncId_node_AnimFrame.SetData((FSFunc)AnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.MovementId:
					FSMovementNode MovementId_node_AnimFrame = graph.AddNode<FSMovementNode>();
					GetPort("AnimFrame").Connect(MovementId_node_AnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(MovementId_node_AnimFrame, assetPath);
					variableCount += MovementId_node_AnimFrame.SetData((FSMovement)AnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CombatId:
					FSCombatNode CombatId_node_AnimFrame = graph.AddNode<FSCombatNode>();
					GetPort("AnimFrame").Connect(CombatId_node_AnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CombatId_node_AnimFrame, assetPath);
					variableCount += CombatId_node_AnimFrame.SetData((FSCombat)AnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.GrabsId:
					FSGrabsNode GrabsId_node_AnimFrame = graph.AddNode<FSGrabsNode>();
					GetPort("AnimFrame").Connect(GrabsId_node_AnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(GrabsId_node_AnimFrame, assetPath);
					variableCount += GrabsId_node_AnimFrame.SetData((FSGrabs)AnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.DataId:
					FSDataNode DataId_node_AnimFrame = graph.AddNode<FSDataNode>();
					GetPort("AnimFrame").Connect(DataId_node_AnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DataId_node_AnimFrame, assetPath);
					variableCount += DataId_node_AnimFrame.SetData((FSData)AnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ScratchId:
					FSScratchNode ScratchId_node_AnimFrame = graph.AddNode<FSScratchNode>();
					GetPort("AnimFrame").Connect(ScratchId_node_AnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ScratchId_node_AnimFrame, assetPath);
					variableCount += ScratchId_node_AnimFrame.SetData((FSScratch)AnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AnimId:
					FSAnimNode AnimId_node_AnimFrame = graph.AddNode<FSAnimNode>();
					GetPort("AnimFrame").Connect(AnimId_node_AnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AnimId_node_AnimFrame, assetPath);
					variableCount += AnimId_node_AnimFrame.SetData((FSAnim)AnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SpeedId:
					FSSpeedNode SpeedId_node_AnimFrame = graph.AddNode<FSSpeedNode>();
					GetPort("AnimFrame").Connect(SpeedId_node_AnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpeedId_node_AnimFrame, assetPath);
					variableCount += SpeedId_node_AnimFrame.SetData((FSSpeed)AnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.PhysicsId:
					FSPhysicsNode PhysicsId_node_AnimFrame = graph.AddNode<FSPhysicsNode>();
					GetPort("AnimFrame").Connect(PhysicsId_node_AnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(PhysicsId_node_AnimFrame, assetPath);
					variableCount += PhysicsId_node_AnimFrame.SetData((FSPhysics)AnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CollisionId:
					FSCollisionNode CollisionId_node_AnimFrame = graph.AddNode<FSCollisionNode>();
					GetPort("AnimFrame").Connect(CollisionId_node_AnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CollisionId_node_AnimFrame, assetPath);
					variableCount += CollisionId_node_AnimFrame.SetData((FSCollision)AnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.TimerId:
					FSTimerNode TimerId_node_AnimFrame = graph.AddNode<FSTimerNode>();
					GetPort("AnimFrame").Connect(TimerId_node_AnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(TimerId_node_AnimFrame, assetPath);
					variableCount += TimerId_node_AnimFrame.SetData((FSTimer)AnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.LagId:
					FSLagNode LagId_node_AnimFrame = graph.AddNode<FSLagNode>();
					GetPort("AnimFrame").Connect(LagId_node_AnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LagId_node_AnimFrame, assetPath);
					variableCount += LagId_node_AnimFrame.SetData((FSLag)AnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.EffectsId:
					FSEffectsNode EffectsId_node_AnimFrame = graph.AddNode<FSEffectsNode>();
					GetPort("AnimFrame").Connect(EffectsId_node_AnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EffectsId_node_AnimFrame, assetPath);
					variableCount += EffectsId_node_AnimFrame.SetData((FSEffects)AnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ColorsId:
					FSColorsNode ColorsId_node_AnimFrame = graph.AddNode<FSColorsNode>();
					GetPort("AnimFrame").Connect(ColorsId_node_AnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ColorsId_node_AnimFrame, assetPath);
					variableCount += ColorsId_node_AnimFrame.SetData((FSColors)AnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.OnHitId:
					FSOnHitNode OnHitId_node_AnimFrame = graph.AddNode<FSOnHitNode>();
					GetPort("AnimFrame").Connect(OnHitId_node_AnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnHitId_node_AnimFrame, assetPath);
					variableCount += OnHitId_node_AnimFrame.SetData((FSOnHit)AnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RandomId:
					FSRandomNode RandomId_node_AnimFrame = graph.AddNode<FSRandomNode>();
					GetPort("AnimFrame").Connect(RandomId_node_AnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RandomId_node_AnimFrame, assetPath);
					variableCount += RandomId_node_AnimFrame.SetData((FSRandom)AnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CameraId:
					FSCameraInfoNode CameraId_node_AnimFrame = graph.AddNode<FSCameraInfoNode>();
					GetPort("AnimFrame").Connect(CameraId_node_AnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CameraId_node_AnimFrame, assetPath);
					variableCount += CameraId_node_AnimFrame.SetData((FSCameraInfo)AnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SportsId:
					FSSportsNode SportsId_node_AnimFrame = graph.AddNode<FSSportsNode>();
					GetPort("AnimFrame").Connect(SportsId_node_AnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SportsId_node_AnimFrame, assetPath);
					variableCount += SportsId_node_AnimFrame.SetData((FSSports)AnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.Vector2Mag:
					FSVector2MagNode Vector2Mag_node_AnimFrame = graph.AddNode<FSVector2MagNode>();
					GetPort("AnimFrame").Connect(Vector2Mag_node_AnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(Vector2Mag_node_AnimFrame, assetPath);
					variableCount += Vector2Mag_node_AnimFrame.SetData((FSVector2Mag)AnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CPUHelpId:
					FSCpuHelpNode CPUHelpId_node_AnimFrame = graph.AddNode<FSCpuHelpNode>();
					GetPort("AnimFrame").Connect(CPUHelpId_node_AnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CPUHelpId_node_AnimFrame, assetPath);
					variableCount += CPUHelpId_node_AnimFrame.SetData((FSCpuHelp)AnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ItemId:
					FSItemNode ItemId_node_AnimFrame = graph.AddNode<FSItemNode>();
					GetPort("AnimFrame").Connect(ItemId_node_AnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ItemId_node_AnimFrame, assetPath);
					variableCount += ItemId_node_AnimFrame.SetData((FSItem)AnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ModeId:
					FSModeNode ModeId_node_AnimFrame = graph.AddNode<FSModeNode>();
					GetPort("AnimFrame").Connect(ModeId_node_AnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ModeId_node_AnimFrame, assetPath);
					variableCount += ModeId_node_AnimFrame.SetData((FSMode)AnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.JumpsId:
					FSJumpsNode JumpsId_node_AnimFrame = graph.AddNode<FSJumpsNode>();
					GetPort("AnimFrame").Connect(JumpsId_node_AnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(JumpsId_node_AnimFrame, assetPath);
					variableCount += JumpsId_node_AnimFrame.SetData((FSJumps)AnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RootAnimId:
					FSRootAnimNode RootAnimId_node_AnimFrame = graph.AddNode<FSRootAnimNode>();
					GetPort("AnimFrame").Connect(RootAnimId_node_AnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RootAnimId_node_AnimFrame, assetPath);
					variableCount += RootAnimId_node_AnimFrame.SetData((FSRootAnim)AnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FloatId:
					FSValueNode FloatId_node_AnimFrame = graph.AddNode<FSValueNode>();
					GetPort("AnimFrame").Connect(FloatId_node_AnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FloatId_node_AnimFrame, assetPath);
					variableCount += FloatId_node_AnimFrame.SetData((FSValue)AnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
			}
			
			return variableCount;
		}
		
		public SAMapAnimationSimple.MapPoint GetData()
		{
			SAMapAnimationSimple.MapPoint objToReturn = new SAMapAnimationSimple.MapPoint();
			if (GetPort("OffsetFrame").ConnectionCount > 0)
			{
				FloatSourceNode FloatSource_Node = (FloatSourceNode)GetPort("OffsetFrame").GetConnection(0).node;
				switch (FloatSource_Node.TID)
				{
					case FloatSource.TypeId.AgentId:
						FSAgentNode AgentId_FloatSource_Node = (FSAgentNode)GetPort("OffsetFrame").GetConnection(0).node;
						objToReturn.OffsetFrame = AgentId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.BonesId:
						FSBonesNode BonesId_FloatSource_Node = (FSBonesNode)GetPort("OffsetFrame").GetConnection(0).node;
						objToReturn.OffsetFrame = BonesId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AttackId:
						FSAttackNode AttackId_FloatSource_Node = (FSAttackNode)GetPort("OffsetFrame").GetConnection(0).node;
						objToReturn.OffsetFrame = AttackId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FrameId:
						FSFrameNode FrameId_FloatSource_Node = (FSFrameNode)GetPort("OffsetFrame").GetConnection(0).node;
						objToReturn.OffsetFrame = FrameId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.InputId:
						FSInputNode InputId_FloatSource_Node = (FSInputNode)GetPort("OffsetFrame").GetConnection(0).node;
						objToReturn.OffsetFrame = InputId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FuncId:
						FSFuncNode FuncId_FloatSource_Node = (FSFuncNode)GetPort("OffsetFrame").GetConnection(0).node;
						objToReturn.OffsetFrame = FuncId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.MovementId:
						FSMovementNode MovementId_FloatSource_Node = (FSMovementNode)GetPort("OffsetFrame").GetConnection(0).node;
						objToReturn.OffsetFrame = MovementId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CombatId:
						FSCombatNode CombatId_FloatSource_Node = (FSCombatNode)GetPort("OffsetFrame").GetConnection(0).node;
						objToReturn.OffsetFrame = CombatId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.GrabsId:
						FSGrabsNode GrabsId_FloatSource_Node = (FSGrabsNode)GetPort("OffsetFrame").GetConnection(0).node;
						objToReturn.OffsetFrame = GrabsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.DataId:
						FSDataNode DataId_FloatSource_Node = (FSDataNode)GetPort("OffsetFrame").GetConnection(0).node;
						objToReturn.OffsetFrame = DataId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ScratchId:
						FSScratchNode ScratchId_FloatSource_Node = (FSScratchNode)GetPort("OffsetFrame").GetConnection(0).node;
						objToReturn.OffsetFrame = ScratchId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AnimId:
						FSAnimNode AnimId_FloatSource_Node = (FSAnimNode)GetPort("OffsetFrame").GetConnection(0).node;
						objToReturn.OffsetFrame = AnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SpeedId:
						FSSpeedNode SpeedId_FloatSource_Node = (FSSpeedNode)GetPort("OffsetFrame").GetConnection(0).node;
						objToReturn.OffsetFrame = SpeedId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.PhysicsId:
						FSPhysicsNode PhysicsId_FloatSource_Node = (FSPhysicsNode)GetPort("OffsetFrame").GetConnection(0).node;
						objToReturn.OffsetFrame = PhysicsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CollisionId:
						FSCollisionNode CollisionId_FloatSource_Node = (FSCollisionNode)GetPort("OffsetFrame").GetConnection(0).node;
						objToReturn.OffsetFrame = CollisionId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.TimerId:
						FSTimerNode TimerId_FloatSource_Node = (FSTimerNode)GetPort("OffsetFrame").GetConnection(0).node;
						objToReturn.OffsetFrame = TimerId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.LagId:
						FSLagNode LagId_FloatSource_Node = (FSLagNode)GetPort("OffsetFrame").GetConnection(0).node;
						objToReturn.OffsetFrame = LagId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.EffectsId:
						FSEffectsNode EffectsId_FloatSource_Node = (FSEffectsNode)GetPort("OffsetFrame").GetConnection(0).node;
						objToReturn.OffsetFrame = EffectsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ColorsId:
						FSColorsNode ColorsId_FloatSource_Node = (FSColorsNode)GetPort("OffsetFrame").GetConnection(0).node;
						objToReturn.OffsetFrame = ColorsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.OnHitId:
						FSOnHitNode OnHitId_FloatSource_Node = (FSOnHitNode)GetPort("OffsetFrame").GetConnection(0).node;
						objToReturn.OffsetFrame = OnHitId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RandomId:
						FSRandomNode RandomId_FloatSource_Node = (FSRandomNode)GetPort("OffsetFrame").GetConnection(0).node;
						objToReturn.OffsetFrame = RandomId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CameraId:
						FSCameraInfoNode CameraId_FloatSource_Node = (FSCameraInfoNode)GetPort("OffsetFrame").GetConnection(0).node;
						objToReturn.OffsetFrame = CameraId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SportsId:
						FSSportsNode SportsId_FloatSource_Node = (FSSportsNode)GetPort("OffsetFrame").GetConnection(0).node;
						objToReturn.OffsetFrame = SportsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.Vector2Mag:
						FSVector2MagNode Vector2Mag_FloatSource_Node = (FSVector2MagNode)GetPort("OffsetFrame").GetConnection(0).node;
						objToReturn.OffsetFrame = Vector2Mag_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CPUHelpId:
						FSCpuHelpNode CPUHelpId_FloatSource_Node = (FSCpuHelpNode)GetPort("OffsetFrame").GetConnection(0).node;
						objToReturn.OffsetFrame = CPUHelpId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ItemId:
						FSItemNode ItemId_FloatSource_Node = (FSItemNode)GetPort("OffsetFrame").GetConnection(0).node;
						objToReturn.OffsetFrame = ItemId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ModeId:
						FSModeNode ModeId_FloatSource_Node = (FSModeNode)GetPort("OffsetFrame").GetConnection(0).node;
						objToReturn.OffsetFrame = ModeId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.JumpsId:
						FSJumpsNode JumpsId_FloatSource_Node = (FSJumpsNode)GetPort("OffsetFrame").GetConnection(0).node;
						objToReturn.OffsetFrame = JumpsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RootAnimId:
						FSRootAnimNode RootAnimId_FloatSource_Node = (FSRootAnimNode)GetPort("OffsetFrame").GetConnection(0).node;
						objToReturn.OffsetFrame = RootAnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FloatId:
						FSValueNode FloatId_FloatSource_Node = (FSValueNode)GetPort("OffsetFrame").GetConnection(0).node;
						objToReturn.OffsetFrame = FloatId_FloatSource_Node.GetData();
					break;
				}
			}
			if (GetPort("AnimFrame").ConnectionCount > 0)
			{
				FloatSourceNode FloatSource_Node = (FloatSourceNode)GetPort("AnimFrame").GetConnection(0).node;
				switch (FloatSource_Node.TID)
				{
					case FloatSource.TypeId.AgentId:
						FSAgentNode AgentId_FloatSource_Node = (FSAgentNode)GetPort("AnimFrame").GetConnection(0).node;
						objToReturn.AnimFrame = AgentId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.BonesId:
						FSBonesNode BonesId_FloatSource_Node = (FSBonesNode)GetPort("AnimFrame").GetConnection(0).node;
						objToReturn.AnimFrame = BonesId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AttackId:
						FSAttackNode AttackId_FloatSource_Node = (FSAttackNode)GetPort("AnimFrame").GetConnection(0).node;
						objToReturn.AnimFrame = AttackId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FrameId:
						FSFrameNode FrameId_FloatSource_Node = (FSFrameNode)GetPort("AnimFrame").GetConnection(0).node;
						objToReturn.AnimFrame = FrameId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.InputId:
						FSInputNode InputId_FloatSource_Node = (FSInputNode)GetPort("AnimFrame").GetConnection(0).node;
						objToReturn.AnimFrame = InputId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FuncId:
						FSFuncNode FuncId_FloatSource_Node = (FSFuncNode)GetPort("AnimFrame").GetConnection(0).node;
						objToReturn.AnimFrame = FuncId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.MovementId:
						FSMovementNode MovementId_FloatSource_Node = (FSMovementNode)GetPort("AnimFrame").GetConnection(0).node;
						objToReturn.AnimFrame = MovementId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CombatId:
						FSCombatNode CombatId_FloatSource_Node = (FSCombatNode)GetPort("AnimFrame").GetConnection(0).node;
						objToReturn.AnimFrame = CombatId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.GrabsId:
						FSGrabsNode GrabsId_FloatSource_Node = (FSGrabsNode)GetPort("AnimFrame").GetConnection(0).node;
						objToReturn.AnimFrame = GrabsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.DataId:
						FSDataNode DataId_FloatSource_Node = (FSDataNode)GetPort("AnimFrame").GetConnection(0).node;
						objToReturn.AnimFrame = DataId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ScratchId:
						FSScratchNode ScratchId_FloatSource_Node = (FSScratchNode)GetPort("AnimFrame").GetConnection(0).node;
						objToReturn.AnimFrame = ScratchId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AnimId:
						FSAnimNode AnimId_FloatSource_Node = (FSAnimNode)GetPort("AnimFrame").GetConnection(0).node;
						objToReturn.AnimFrame = AnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SpeedId:
						FSSpeedNode SpeedId_FloatSource_Node = (FSSpeedNode)GetPort("AnimFrame").GetConnection(0).node;
						objToReturn.AnimFrame = SpeedId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.PhysicsId:
						FSPhysicsNode PhysicsId_FloatSource_Node = (FSPhysicsNode)GetPort("AnimFrame").GetConnection(0).node;
						objToReturn.AnimFrame = PhysicsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CollisionId:
						FSCollisionNode CollisionId_FloatSource_Node = (FSCollisionNode)GetPort("AnimFrame").GetConnection(0).node;
						objToReturn.AnimFrame = CollisionId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.TimerId:
						FSTimerNode TimerId_FloatSource_Node = (FSTimerNode)GetPort("AnimFrame").GetConnection(0).node;
						objToReturn.AnimFrame = TimerId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.LagId:
						FSLagNode LagId_FloatSource_Node = (FSLagNode)GetPort("AnimFrame").GetConnection(0).node;
						objToReturn.AnimFrame = LagId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.EffectsId:
						FSEffectsNode EffectsId_FloatSource_Node = (FSEffectsNode)GetPort("AnimFrame").GetConnection(0).node;
						objToReturn.AnimFrame = EffectsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ColorsId:
						FSColorsNode ColorsId_FloatSource_Node = (FSColorsNode)GetPort("AnimFrame").GetConnection(0).node;
						objToReturn.AnimFrame = ColorsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.OnHitId:
						FSOnHitNode OnHitId_FloatSource_Node = (FSOnHitNode)GetPort("AnimFrame").GetConnection(0).node;
						objToReturn.AnimFrame = OnHitId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RandomId:
						FSRandomNode RandomId_FloatSource_Node = (FSRandomNode)GetPort("AnimFrame").GetConnection(0).node;
						objToReturn.AnimFrame = RandomId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CameraId:
						FSCameraInfoNode CameraId_FloatSource_Node = (FSCameraInfoNode)GetPort("AnimFrame").GetConnection(0).node;
						objToReturn.AnimFrame = CameraId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SportsId:
						FSSportsNode SportsId_FloatSource_Node = (FSSportsNode)GetPort("AnimFrame").GetConnection(0).node;
						objToReturn.AnimFrame = SportsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.Vector2Mag:
						FSVector2MagNode Vector2Mag_FloatSource_Node = (FSVector2MagNode)GetPort("AnimFrame").GetConnection(0).node;
						objToReturn.AnimFrame = Vector2Mag_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CPUHelpId:
						FSCpuHelpNode CPUHelpId_FloatSource_Node = (FSCpuHelpNode)GetPort("AnimFrame").GetConnection(0).node;
						objToReturn.AnimFrame = CPUHelpId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ItemId:
						FSItemNode ItemId_FloatSource_Node = (FSItemNode)GetPort("AnimFrame").GetConnection(0).node;
						objToReturn.AnimFrame = ItemId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ModeId:
						FSModeNode ModeId_FloatSource_Node = (FSModeNode)GetPort("AnimFrame").GetConnection(0).node;
						objToReturn.AnimFrame = ModeId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.JumpsId:
						FSJumpsNode JumpsId_FloatSource_Node = (FSJumpsNode)GetPort("AnimFrame").GetConnection(0).node;
						objToReturn.AnimFrame = JumpsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RootAnimId:
						FSRootAnimNode RootAnimId_FloatSource_Node = (FSRootAnimNode)GetPort("AnimFrame").GetConnection(0).node;
						objToReturn.AnimFrame = RootAnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FloatId:
						FSValueNode FloatId_FloatSource_Node = (FSValueNode)GetPort("AnimFrame").GetConnection(0).node;
						objToReturn.AnimFrame = FloatId_FloatSource_Node.GetData();
					break;
				}
			}
			return objToReturn;
		}
	}
}

