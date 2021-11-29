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
	public class SAMapAnimation_MapPointNode : StateActionNode
	{
		public bool RootAnim;
		public string AnimId;
		[Output] public FloatSource AtFrames;
		[Output] public FloatSource Frames;
		[Output] public FloatSource StartAnimFrame;
		[Output] public FloatSource EndAnimFrame;
		
		protected override void Init()
		{
			base.Init();
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SAMapAnimation.MapPoint data, MovesetGraph graph, string assetPath, Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SAMapAnimation.MapPoint));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			RootAnim = data.RootAnim;
			AnimId = data.AnimId;
			AtFrames = data.AtFrames;
			
			switch (AtFrames.TID)
			{
				case FloatSource.TypeId.AgentId:
					FSAgentNode AgentId_node_AtFrames = graph.AddNode<FSAgentNode>();
					GetPort("AtFrames").Connect(AgentId_node_AtFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AgentId_node_AtFrames, assetPath);
					variableCount += AgentId_node_AtFrames.SetData((FSAgent)AtFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.BonesId:
					FSBonesNode BonesId_node_AtFrames = graph.AddNode<FSBonesNode>();
					GetPort("AtFrames").Connect(BonesId_node_AtFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BonesId_node_AtFrames, assetPath);
					variableCount += BonesId_node_AtFrames.SetData((FSBones)AtFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AttackId:
					FSAttackNode AttackId_node_AtFrames = graph.AddNode<FSAttackNode>();
					GetPort("AtFrames").Connect(AttackId_node_AtFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AttackId_node_AtFrames, assetPath);
					variableCount += AttackId_node_AtFrames.SetData((FSAttack)AtFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FrameId:
					FSFrameNode FrameId_node_AtFrames = graph.AddNode<FSFrameNode>();
					GetPort("AtFrames").Connect(FrameId_node_AtFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FrameId_node_AtFrames, assetPath);
					variableCount += FrameId_node_AtFrames.SetData((FSFrame)AtFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.InputId:
					FSInputNode InputId_node_AtFrames = graph.AddNode<FSInputNode>();
					GetPort("AtFrames").Connect(InputId_node_AtFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputId_node_AtFrames, assetPath);
					variableCount += InputId_node_AtFrames.SetData((FSInput)AtFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FuncId:
					FSFuncNode FuncId_node_AtFrames = graph.AddNode<FSFuncNode>();
					GetPort("AtFrames").Connect(FuncId_node_AtFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FuncId_node_AtFrames, assetPath);
					variableCount += FuncId_node_AtFrames.SetData((FSFunc)AtFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.MovementId:
					FSMovementNode MovementId_node_AtFrames = graph.AddNode<FSMovementNode>();
					GetPort("AtFrames").Connect(MovementId_node_AtFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(MovementId_node_AtFrames, assetPath);
					variableCount += MovementId_node_AtFrames.SetData((FSMovement)AtFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CombatId:
					FSCombatNode CombatId_node_AtFrames = graph.AddNode<FSCombatNode>();
					GetPort("AtFrames").Connect(CombatId_node_AtFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CombatId_node_AtFrames, assetPath);
					variableCount += CombatId_node_AtFrames.SetData((FSCombat)AtFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.GrabsId:
					FSGrabsNode GrabsId_node_AtFrames = graph.AddNode<FSGrabsNode>();
					GetPort("AtFrames").Connect(GrabsId_node_AtFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(GrabsId_node_AtFrames, assetPath);
					variableCount += GrabsId_node_AtFrames.SetData((FSGrabs)AtFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.DataId:
					FSDataNode DataId_node_AtFrames = graph.AddNode<FSDataNode>();
					GetPort("AtFrames").Connect(DataId_node_AtFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DataId_node_AtFrames, assetPath);
					variableCount += DataId_node_AtFrames.SetData((FSData)AtFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ScratchId:
					FSScratchNode ScratchId_node_AtFrames = graph.AddNode<FSScratchNode>();
					GetPort("AtFrames").Connect(ScratchId_node_AtFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ScratchId_node_AtFrames, assetPath);
					variableCount += ScratchId_node_AtFrames.SetData((FSScratch)AtFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AnimId:
					FSAnimNode AnimId_node_AtFrames = graph.AddNode<FSAnimNode>();
					GetPort("AtFrames").Connect(AnimId_node_AtFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AnimId_node_AtFrames, assetPath);
					variableCount += AnimId_node_AtFrames.SetData((FSAnim)AtFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SpeedId:
					FSSpeedNode SpeedId_node_AtFrames = graph.AddNode<FSSpeedNode>();
					GetPort("AtFrames").Connect(SpeedId_node_AtFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpeedId_node_AtFrames, assetPath);
					variableCount += SpeedId_node_AtFrames.SetData((FSSpeed)AtFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.PhysicsId:
					FSPhysicsNode PhysicsId_node_AtFrames = graph.AddNode<FSPhysicsNode>();
					GetPort("AtFrames").Connect(PhysicsId_node_AtFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(PhysicsId_node_AtFrames, assetPath);
					variableCount += PhysicsId_node_AtFrames.SetData((FSPhysics)AtFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CollisionId:
					FSCollisionNode CollisionId_node_AtFrames = graph.AddNode<FSCollisionNode>();
					GetPort("AtFrames").Connect(CollisionId_node_AtFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CollisionId_node_AtFrames, assetPath);
					variableCount += CollisionId_node_AtFrames.SetData((FSCollision)AtFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.TimerId:
					FSTimerNode TimerId_node_AtFrames = graph.AddNode<FSTimerNode>();
					GetPort("AtFrames").Connect(TimerId_node_AtFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(TimerId_node_AtFrames, assetPath);
					variableCount += TimerId_node_AtFrames.SetData((FSTimer)AtFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.LagId:
					FSLagNode LagId_node_AtFrames = graph.AddNode<FSLagNode>();
					GetPort("AtFrames").Connect(LagId_node_AtFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LagId_node_AtFrames, assetPath);
					variableCount += LagId_node_AtFrames.SetData((FSLag)AtFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.EffectsId:
					FSEffectsNode EffectsId_node_AtFrames = graph.AddNode<FSEffectsNode>();
					GetPort("AtFrames").Connect(EffectsId_node_AtFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EffectsId_node_AtFrames, assetPath);
					variableCount += EffectsId_node_AtFrames.SetData((FSEffects)AtFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ColorsId:
					FSColorsNode ColorsId_node_AtFrames = graph.AddNode<FSColorsNode>();
					GetPort("AtFrames").Connect(ColorsId_node_AtFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ColorsId_node_AtFrames, assetPath);
					variableCount += ColorsId_node_AtFrames.SetData((FSColors)AtFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.OnHitId:
					FSOnHitNode OnHitId_node_AtFrames = graph.AddNode<FSOnHitNode>();
					GetPort("AtFrames").Connect(OnHitId_node_AtFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnHitId_node_AtFrames, assetPath);
					variableCount += OnHitId_node_AtFrames.SetData((FSOnHit)AtFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RandomId:
					FSRandomNode RandomId_node_AtFrames = graph.AddNode<FSRandomNode>();
					GetPort("AtFrames").Connect(RandomId_node_AtFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RandomId_node_AtFrames, assetPath);
					variableCount += RandomId_node_AtFrames.SetData((FSRandom)AtFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CameraId:
					FSCameraInfoNode CameraId_node_AtFrames = graph.AddNode<FSCameraInfoNode>();
					GetPort("AtFrames").Connect(CameraId_node_AtFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CameraId_node_AtFrames, assetPath);
					variableCount += CameraId_node_AtFrames.SetData((FSCameraInfo)AtFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SportsId:
					FSSportsNode SportsId_node_AtFrames = graph.AddNode<FSSportsNode>();
					GetPort("AtFrames").Connect(SportsId_node_AtFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SportsId_node_AtFrames, assetPath);
					variableCount += SportsId_node_AtFrames.SetData((FSSports)AtFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.Vector2Mag:
					FSVector2MagNode Vector2Mag_node_AtFrames = graph.AddNode<FSVector2MagNode>();
					GetPort("AtFrames").Connect(Vector2Mag_node_AtFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(Vector2Mag_node_AtFrames, assetPath);
					variableCount += Vector2Mag_node_AtFrames.SetData((FSVector2Mag)AtFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CPUHelpId:
					FSCpuHelpNode CPUHelpId_node_AtFrames = graph.AddNode<FSCpuHelpNode>();
					GetPort("AtFrames").Connect(CPUHelpId_node_AtFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CPUHelpId_node_AtFrames, assetPath);
					variableCount += CPUHelpId_node_AtFrames.SetData((FSCpuHelp)AtFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ItemId:
					FSItemNode ItemId_node_AtFrames = graph.AddNode<FSItemNode>();
					GetPort("AtFrames").Connect(ItemId_node_AtFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ItemId_node_AtFrames, assetPath);
					variableCount += ItemId_node_AtFrames.SetData((FSItem)AtFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ModeId:
					FSModeNode ModeId_node_AtFrames = graph.AddNode<FSModeNode>();
					GetPort("AtFrames").Connect(ModeId_node_AtFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ModeId_node_AtFrames, assetPath);
					variableCount += ModeId_node_AtFrames.SetData((FSMode)AtFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.JumpsId:
					FSJumpsNode JumpsId_node_AtFrames = graph.AddNode<FSJumpsNode>();
					GetPort("AtFrames").Connect(JumpsId_node_AtFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(JumpsId_node_AtFrames, assetPath);
					variableCount += JumpsId_node_AtFrames.SetData((FSJumps)AtFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RootAnimId:
					FSRootAnimNode RootAnimId_node_AtFrames = graph.AddNode<FSRootAnimNode>();
					GetPort("AtFrames").Connect(RootAnimId_node_AtFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RootAnimId_node_AtFrames, assetPath);
					variableCount += RootAnimId_node_AtFrames.SetData((FSRootAnim)AtFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FloatId:
					FSValueNode FloatId_node_AtFrames = graph.AddNode<FSValueNode>();
					GetPort("AtFrames").Connect(FloatId_node_AtFrames.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FloatId_node_AtFrames, assetPath);
					variableCount += FloatId_node_AtFrames.SetData((FSValue)AtFrames, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
			}
			++variableCount;
			
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
			++variableCount;
			
			StartAnimFrame = data.StartAnimFrame;
			
			switch (StartAnimFrame.TID)
			{
				case FloatSource.TypeId.AgentId:
					FSAgentNode AgentId_node_StartAnimFrame = graph.AddNode<FSAgentNode>();
					GetPort("StartAnimFrame").Connect(AgentId_node_StartAnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AgentId_node_StartAnimFrame, assetPath);
					variableCount += AgentId_node_StartAnimFrame.SetData((FSAgent)StartAnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.BonesId:
					FSBonesNode BonesId_node_StartAnimFrame = graph.AddNode<FSBonesNode>();
					GetPort("StartAnimFrame").Connect(BonesId_node_StartAnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BonesId_node_StartAnimFrame, assetPath);
					variableCount += BonesId_node_StartAnimFrame.SetData((FSBones)StartAnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AttackId:
					FSAttackNode AttackId_node_StartAnimFrame = graph.AddNode<FSAttackNode>();
					GetPort("StartAnimFrame").Connect(AttackId_node_StartAnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AttackId_node_StartAnimFrame, assetPath);
					variableCount += AttackId_node_StartAnimFrame.SetData((FSAttack)StartAnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FrameId:
					FSFrameNode FrameId_node_StartAnimFrame = graph.AddNode<FSFrameNode>();
					GetPort("StartAnimFrame").Connect(FrameId_node_StartAnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FrameId_node_StartAnimFrame, assetPath);
					variableCount += FrameId_node_StartAnimFrame.SetData((FSFrame)StartAnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.InputId:
					FSInputNode InputId_node_StartAnimFrame = graph.AddNode<FSInputNode>();
					GetPort("StartAnimFrame").Connect(InputId_node_StartAnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputId_node_StartAnimFrame, assetPath);
					variableCount += InputId_node_StartAnimFrame.SetData((FSInput)StartAnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FuncId:
					FSFuncNode FuncId_node_StartAnimFrame = graph.AddNode<FSFuncNode>();
					GetPort("StartAnimFrame").Connect(FuncId_node_StartAnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FuncId_node_StartAnimFrame, assetPath);
					variableCount += FuncId_node_StartAnimFrame.SetData((FSFunc)StartAnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.MovementId:
					FSMovementNode MovementId_node_StartAnimFrame = graph.AddNode<FSMovementNode>();
					GetPort("StartAnimFrame").Connect(MovementId_node_StartAnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(MovementId_node_StartAnimFrame, assetPath);
					variableCount += MovementId_node_StartAnimFrame.SetData((FSMovement)StartAnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CombatId:
					FSCombatNode CombatId_node_StartAnimFrame = graph.AddNode<FSCombatNode>();
					GetPort("StartAnimFrame").Connect(CombatId_node_StartAnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CombatId_node_StartAnimFrame, assetPath);
					variableCount += CombatId_node_StartAnimFrame.SetData((FSCombat)StartAnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.GrabsId:
					FSGrabsNode GrabsId_node_StartAnimFrame = graph.AddNode<FSGrabsNode>();
					GetPort("StartAnimFrame").Connect(GrabsId_node_StartAnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(GrabsId_node_StartAnimFrame, assetPath);
					variableCount += GrabsId_node_StartAnimFrame.SetData((FSGrabs)StartAnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.DataId:
					FSDataNode DataId_node_StartAnimFrame = graph.AddNode<FSDataNode>();
					GetPort("StartAnimFrame").Connect(DataId_node_StartAnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DataId_node_StartAnimFrame, assetPath);
					variableCount += DataId_node_StartAnimFrame.SetData((FSData)StartAnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ScratchId:
					FSScratchNode ScratchId_node_StartAnimFrame = graph.AddNode<FSScratchNode>();
					GetPort("StartAnimFrame").Connect(ScratchId_node_StartAnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ScratchId_node_StartAnimFrame, assetPath);
					variableCount += ScratchId_node_StartAnimFrame.SetData((FSScratch)StartAnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AnimId:
					FSAnimNode AnimId_node_StartAnimFrame = graph.AddNode<FSAnimNode>();
					GetPort("StartAnimFrame").Connect(AnimId_node_StartAnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AnimId_node_StartAnimFrame, assetPath);
					variableCount += AnimId_node_StartAnimFrame.SetData((FSAnim)StartAnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SpeedId:
					FSSpeedNode SpeedId_node_StartAnimFrame = graph.AddNode<FSSpeedNode>();
					GetPort("StartAnimFrame").Connect(SpeedId_node_StartAnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpeedId_node_StartAnimFrame, assetPath);
					variableCount += SpeedId_node_StartAnimFrame.SetData((FSSpeed)StartAnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.PhysicsId:
					FSPhysicsNode PhysicsId_node_StartAnimFrame = graph.AddNode<FSPhysicsNode>();
					GetPort("StartAnimFrame").Connect(PhysicsId_node_StartAnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(PhysicsId_node_StartAnimFrame, assetPath);
					variableCount += PhysicsId_node_StartAnimFrame.SetData((FSPhysics)StartAnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CollisionId:
					FSCollisionNode CollisionId_node_StartAnimFrame = graph.AddNode<FSCollisionNode>();
					GetPort("StartAnimFrame").Connect(CollisionId_node_StartAnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CollisionId_node_StartAnimFrame, assetPath);
					variableCount += CollisionId_node_StartAnimFrame.SetData((FSCollision)StartAnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.TimerId:
					FSTimerNode TimerId_node_StartAnimFrame = graph.AddNode<FSTimerNode>();
					GetPort("StartAnimFrame").Connect(TimerId_node_StartAnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(TimerId_node_StartAnimFrame, assetPath);
					variableCount += TimerId_node_StartAnimFrame.SetData((FSTimer)StartAnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.LagId:
					FSLagNode LagId_node_StartAnimFrame = graph.AddNode<FSLagNode>();
					GetPort("StartAnimFrame").Connect(LagId_node_StartAnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LagId_node_StartAnimFrame, assetPath);
					variableCount += LagId_node_StartAnimFrame.SetData((FSLag)StartAnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.EffectsId:
					FSEffectsNode EffectsId_node_StartAnimFrame = graph.AddNode<FSEffectsNode>();
					GetPort("StartAnimFrame").Connect(EffectsId_node_StartAnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EffectsId_node_StartAnimFrame, assetPath);
					variableCount += EffectsId_node_StartAnimFrame.SetData((FSEffects)StartAnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ColorsId:
					FSColorsNode ColorsId_node_StartAnimFrame = graph.AddNode<FSColorsNode>();
					GetPort("StartAnimFrame").Connect(ColorsId_node_StartAnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ColorsId_node_StartAnimFrame, assetPath);
					variableCount += ColorsId_node_StartAnimFrame.SetData((FSColors)StartAnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.OnHitId:
					FSOnHitNode OnHitId_node_StartAnimFrame = graph.AddNode<FSOnHitNode>();
					GetPort("StartAnimFrame").Connect(OnHitId_node_StartAnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnHitId_node_StartAnimFrame, assetPath);
					variableCount += OnHitId_node_StartAnimFrame.SetData((FSOnHit)StartAnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RandomId:
					FSRandomNode RandomId_node_StartAnimFrame = graph.AddNode<FSRandomNode>();
					GetPort("StartAnimFrame").Connect(RandomId_node_StartAnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RandomId_node_StartAnimFrame, assetPath);
					variableCount += RandomId_node_StartAnimFrame.SetData((FSRandom)StartAnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CameraId:
					FSCameraInfoNode CameraId_node_StartAnimFrame = graph.AddNode<FSCameraInfoNode>();
					GetPort("StartAnimFrame").Connect(CameraId_node_StartAnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CameraId_node_StartAnimFrame, assetPath);
					variableCount += CameraId_node_StartAnimFrame.SetData((FSCameraInfo)StartAnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SportsId:
					FSSportsNode SportsId_node_StartAnimFrame = graph.AddNode<FSSportsNode>();
					GetPort("StartAnimFrame").Connect(SportsId_node_StartAnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SportsId_node_StartAnimFrame, assetPath);
					variableCount += SportsId_node_StartAnimFrame.SetData((FSSports)StartAnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.Vector2Mag:
					FSVector2MagNode Vector2Mag_node_StartAnimFrame = graph.AddNode<FSVector2MagNode>();
					GetPort("StartAnimFrame").Connect(Vector2Mag_node_StartAnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(Vector2Mag_node_StartAnimFrame, assetPath);
					variableCount += Vector2Mag_node_StartAnimFrame.SetData((FSVector2Mag)StartAnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CPUHelpId:
					FSCpuHelpNode CPUHelpId_node_StartAnimFrame = graph.AddNode<FSCpuHelpNode>();
					GetPort("StartAnimFrame").Connect(CPUHelpId_node_StartAnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CPUHelpId_node_StartAnimFrame, assetPath);
					variableCount += CPUHelpId_node_StartAnimFrame.SetData((FSCpuHelp)StartAnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ItemId:
					FSItemNode ItemId_node_StartAnimFrame = graph.AddNode<FSItemNode>();
					GetPort("StartAnimFrame").Connect(ItemId_node_StartAnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ItemId_node_StartAnimFrame, assetPath);
					variableCount += ItemId_node_StartAnimFrame.SetData((FSItem)StartAnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ModeId:
					FSModeNode ModeId_node_StartAnimFrame = graph.AddNode<FSModeNode>();
					GetPort("StartAnimFrame").Connect(ModeId_node_StartAnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ModeId_node_StartAnimFrame, assetPath);
					variableCount += ModeId_node_StartAnimFrame.SetData((FSMode)StartAnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.JumpsId:
					FSJumpsNode JumpsId_node_StartAnimFrame = graph.AddNode<FSJumpsNode>();
					GetPort("StartAnimFrame").Connect(JumpsId_node_StartAnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(JumpsId_node_StartAnimFrame, assetPath);
					variableCount += JumpsId_node_StartAnimFrame.SetData((FSJumps)StartAnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RootAnimId:
					FSRootAnimNode RootAnimId_node_StartAnimFrame = graph.AddNode<FSRootAnimNode>();
					GetPort("StartAnimFrame").Connect(RootAnimId_node_StartAnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RootAnimId_node_StartAnimFrame, assetPath);
					variableCount += RootAnimId_node_StartAnimFrame.SetData((FSRootAnim)StartAnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FloatId:
					FSValueNode FloatId_node_StartAnimFrame = graph.AddNode<FSValueNode>();
					GetPort("StartAnimFrame").Connect(FloatId_node_StartAnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FloatId_node_StartAnimFrame, assetPath);
					variableCount += FloatId_node_StartAnimFrame.SetData((FSValue)StartAnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
			}
			++variableCount;
			
			EndAnimFrame = data.EndAnimFrame;
			
			switch (EndAnimFrame.TID)
			{
				case FloatSource.TypeId.AgentId:
					FSAgentNode AgentId_node_EndAnimFrame = graph.AddNode<FSAgentNode>();
					GetPort("EndAnimFrame").Connect(AgentId_node_EndAnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AgentId_node_EndAnimFrame, assetPath);
					variableCount += AgentId_node_EndAnimFrame.SetData((FSAgent)EndAnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.BonesId:
					FSBonesNode BonesId_node_EndAnimFrame = graph.AddNode<FSBonesNode>();
					GetPort("EndAnimFrame").Connect(BonesId_node_EndAnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BonesId_node_EndAnimFrame, assetPath);
					variableCount += BonesId_node_EndAnimFrame.SetData((FSBones)EndAnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AttackId:
					FSAttackNode AttackId_node_EndAnimFrame = graph.AddNode<FSAttackNode>();
					GetPort("EndAnimFrame").Connect(AttackId_node_EndAnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AttackId_node_EndAnimFrame, assetPath);
					variableCount += AttackId_node_EndAnimFrame.SetData((FSAttack)EndAnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FrameId:
					FSFrameNode FrameId_node_EndAnimFrame = graph.AddNode<FSFrameNode>();
					GetPort("EndAnimFrame").Connect(FrameId_node_EndAnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FrameId_node_EndAnimFrame, assetPath);
					variableCount += FrameId_node_EndAnimFrame.SetData((FSFrame)EndAnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.InputId:
					FSInputNode InputId_node_EndAnimFrame = graph.AddNode<FSInputNode>();
					GetPort("EndAnimFrame").Connect(InputId_node_EndAnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputId_node_EndAnimFrame, assetPath);
					variableCount += InputId_node_EndAnimFrame.SetData((FSInput)EndAnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FuncId:
					FSFuncNode FuncId_node_EndAnimFrame = graph.AddNode<FSFuncNode>();
					GetPort("EndAnimFrame").Connect(FuncId_node_EndAnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FuncId_node_EndAnimFrame, assetPath);
					variableCount += FuncId_node_EndAnimFrame.SetData((FSFunc)EndAnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.MovementId:
					FSMovementNode MovementId_node_EndAnimFrame = graph.AddNode<FSMovementNode>();
					GetPort("EndAnimFrame").Connect(MovementId_node_EndAnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(MovementId_node_EndAnimFrame, assetPath);
					variableCount += MovementId_node_EndAnimFrame.SetData((FSMovement)EndAnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CombatId:
					FSCombatNode CombatId_node_EndAnimFrame = graph.AddNode<FSCombatNode>();
					GetPort("EndAnimFrame").Connect(CombatId_node_EndAnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CombatId_node_EndAnimFrame, assetPath);
					variableCount += CombatId_node_EndAnimFrame.SetData((FSCombat)EndAnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.GrabsId:
					FSGrabsNode GrabsId_node_EndAnimFrame = graph.AddNode<FSGrabsNode>();
					GetPort("EndAnimFrame").Connect(GrabsId_node_EndAnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(GrabsId_node_EndAnimFrame, assetPath);
					variableCount += GrabsId_node_EndAnimFrame.SetData((FSGrabs)EndAnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.DataId:
					FSDataNode DataId_node_EndAnimFrame = graph.AddNode<FSDataNode>();
					GetPort("EndAnimFrame").Connect(DataId_node_EndAnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DataId_node_EndAnimFrame, assetPath);
					variableCount += DataId_node_EndAnimFrame.SetData((FSData)EndAnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ScratchId:
					FSScratchNode ScratchId_node_EndAnimFrame = graph.AddNode<FSScratchNode>();
					GetPort("EndAnimFrame").Connect(ScratchId_node_EndAnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ScratchId_node_EndAnimFrame, assetPath);
					variableCount += ScratchId_node_EndAnimFrame.SetData((FSScratch)EndAnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AnimId:
					FSAnimNode AnimId_node_EndAnimFrame = graph.AddNode<FSAnimNode>();
					GetPort("EndAnimFrame").Connect(AnimId_node_EndAnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AnimId_node_EndAnimFrame, assetPath);
					variableCount += AnimId_node_EndAnimFrame.SetData((FSAnim)EndAnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SpeedId:
					FSSpeedNode SpeedId_node_EndAnimFrame = graph.AddNode<FSSpeedNode>();
					GetPort("EndAnimFrame").Connect(SpeedId_node_EndAnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpeedId_node_EndAnimFrame, assetPath);
					variableCount += SpeedId_node_EndAnimFrame.SetData((FSSpeed)EndAnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.PhysicsId:
					FSPhysicsNode PhysicsId_node_EndAnimFrame = graph.AddNode<FSPhysicsNode>();
					GetPort("EndAnimFrame").Connect(PhysicsId_node_EndAnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(PhysicsId_node_EndAnimFrame, assetPath);
					variableCount += PhysicsId_node_EndAnimFrame.SetData((FSPhysics)EndAnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CollisionId:
					FSCollisionNode CollisionId_node_EndAnimFrame = graph.AddNode<FSCollisionNode>();
					GetPort("EndAnimFrame").Connect(CollisionId_node_EndAnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CollisionId_node_EndAnimFrame, assetPath);
					variableCount += CollisionId_node_EndAnimFrame.SetData((FSCollision)EndAnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.TimerId:
					FSTimerNode TimerId_node_EndAnimFrame = graph.AddNode<FSTimerNode>();
					GetPort("EndAnimFrame").Connect(TimerId_node_EndAnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(TimerId_node_EndAnimFrame, assetPath);
					variableCount += TimerId_node_EndAnimFrame.SetData((FSTimer)EndAnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.LagId:
					FSLagNode LagId_node_EndAnimFrame = graph.AddNode<FSLagNode>();
					GetPort("EndAnimFrame").Connect(LagId_node_EndAnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LagId_node_EndAnimFrame, assetPath);
					variableCount += LagId_node_EndAnimFrame.SetData((FSLag)EndAnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.EffectsId:
					FSEffectsNode EffectsId_node_EndAnimFrame = graph.AddNode<FSEffectsNode>();
					GetPort("EndAnimFrame").Connect(EffectsId_node_EndAnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EffectsId_node_EndAnimFrame, assetPath);
					variableCount += EffectsId_node_EndAnimFrame.SetData((FSEffects)EndAnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ColorsId:
					FSColorsNode ColorsId_node_EndAnimFrame = graph.AddNode<FSColorsNode>();
					GetPort("EndAnimFrame").Connect(ColorsId_node_EndAnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ColorsId_node_EndAnimFrame, assetPath);
					variableCount += ColorsId_node_EndAnimFrame.SetData((FSColors)EndAnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.OnHitId:
					FSOnHitNode OnHitId_node_EndAnimFrame = graph.AddNode<FSOnHitNode>();
					GetPort("EndAnimFrame").Connect(OnHitId_node_EndAnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnHitId_node_EndAnimFrame, assetPath);
					variableCount += OnHitId_node_EndAnimFrame.SetData((FSOnHit)EndAnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RandomId:
					FSRandomNode RandomId_node_EndAnimFrame = graph.AddNode<FSRandomNode>();
					GetPort("EndAnimFrame").Connect(RandomId_node_EndAnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RandomId_node_EndAnimFrame, assetPath);
					variableCount += RandomId_node_EndAnimFrame.SetData((FSRandom)EndAnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CameraId:
					FSCameraInfoNode CameraId_node_EndAnimFrame = graph.AddNode<FSCameraInfoNode>();
					GetPort("EndAnimFrame").Connect(CameraId_node_EndAnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CameraId_node_EndAnimFrame, assetPath);
					variableCount += CameraId_node_EndAnimFrame.SetData((FSCameraInfo)EndAnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SportsId:
					FSSportsNode SportsId_node_EndAnimFrame = graph.AddNode<FSSportsNode>();
					GetPort("EndAnimFrame").Connect(SportsId_node_EndAnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SportsId_node_EndAnimFrame, assetPath);
					variableCount += SportsId_node_EndAnimFrame.SetData((FSSports)EndAnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.Vector2Mag:
					FSVector2MagNode Vector2Mag_node_EndAnimFrame = graph.AddNode<FSVector2MagNode>();
					GetPort("EndAnimFrame").Connect(Vector2Mag_node_EndAnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(Vector2Mag_node_EndAnimFrame, assetPath);
					variableCount += Vector2Mag_node_EndAnimFrame.SetData((FSVector2Mag)EndAnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CPUHelpId:
					FSCpuHelpNode CPUHelpId_node_EndAnimFrame = graph.AddNode<FSCpuHelpNode>();
					GetPort("EndAnimFrame").Connect(CPUHelpId_node_EndAnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CPUHelpId_node_EndAnimFrame, assetPath);
					variableCount += CPUHelpId_node_EndAnimFrame.SetData((FSCpuHelp)EndAnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ItemId:
					FSItemNode ItemId_node_EndAnimFrame = graph.AddNode<FSItemNode>();
					GetPort("EndAnimFrame").Connect(ItemId_node_EndAnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ItemId_node_EndAnimFrame, assetPath);
					variableCount += ItemId_node_EndAnimFrame.SetData((FSItem)EndAnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ModeId:
					FSModeNode ModeId_node_EndAnimFrame = graph.AddNode<FSModeNode>();
					GetPort("EndAnimFrame").Connect(ModeId_node_EndAnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ModeId_node_EndAnimFrame, assetPath);
					variableCount += ModeId_node_EndAnimFrame.SetData((FSMode)EndAnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.JumpsId:
					FSJumpsNode JumpsId_node_EndAnimFrame = graph.AddNode<FSJumpsNode>();
					GetPort("EndAnimFrame").Connect(JumpsId_node_EndAnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(JumpsId_node_EndAnimFrame, assetPath);
					variableCount += JumpsId_node_EndAnimFrame.SetData((FSJumps)EndAnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RootAnimId:
					FSRootAnimNode RootAnimId_node_EndAnimFrame = graph.AddNode<FSRootAnimNode>();
					GetPort("EndAnimFrame").Connect(RootAnimId_node_EndAnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RootAnimId_node_EndAnimFrame, assetPath);
					variableCount += RootAnimId_node_EndAnimFrame.SetData((FSRootAnim)EndAnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FloatId:
					FSValueNode FloatId_node_EndAnimFrame = graph.AddNode<FSValueNode>();
					GetPort("EndAnimFrame").Connect(FloatId_node_EndAnimFrame.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FloatId_node_EndAnimFrame, assetPath);
					variableCount += FloatId_node_EndAnimFrame.SetData((FSValue)EndAnimFrame, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
			}
			
			return variableCount;
		}
		
		public SAMapAnimation.MapPoint GetData()
		{
			SAMapAnimation.MapPoint objToReturn = new SAMapAnimation.MapPoint();
			objToReturn.RootAnim = RootAnim;
			objToReturn.AnimId = AnimId;
			if (GetPort("AtFrames").ConnectionCount > 0)
			{
				FloatSourceNode FloatSource_Node = (FloatSourceNode)GetPort("AtFrames").GetConnection(0).node;
				switch (FloatSource_Node.TID)
				{
					case FloatSource.TypeId.AgentId:
						FSAgentNode AgentId_FloatSource_Node = (FSAgentNode)GetPort("AtFrames").GetConnection(0).node;
						objToReturn.AtFrames = AgentId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.BonesId:
						FSBonesNode BonesId_FloatSource_Node = (FSBonesNode)GetPort("AtFrames").GetConnection(0).node;
						objToReturn.AtFrames = BonesId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AttackId:
						FSAttackNode AttackId_FloatSource_Node = (FSAttackNode)GetPort("AtFrames").GetConnection(0).node;
						objToReturn.AtFrames = AttackId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FrameId:
						FSFrameNode FrameId_FloatSource_Node = (FSFrameNode)GetPort("AtFrames").GetConnection(0).node;
						objToReturn.AtFrames = FrameId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.InputId:
						FSInputNode InputId_FloatSource_Node = (FSInputNode)GetPort("AtFrames").GetConnection(0).node;
						objToReturn.AtFrames = InputId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FuncId:
						FSFuncNode FuncId_FloatSource_Node = (FSFuncNode)GetPort("AtFrames").GetConnection(0).node;
						objToReturn.AtFrames = FuncId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.MovementId:
						FSMovementNode MovementId_FloatSource_Node = (FSMovementNode)GetPort("AtFrames").GetConnection(0).node;
						objToReturn.AtFrames = MovementId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CombatId:
						FSCombatNode CombatId_FloatSource_Node = (FSCombatNode)GetPort("AtFrames").GetConnection(0).node;
						objToReturn.AtFrames = CombatId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.GrabsId:
						FSGrabsNode GrabsId_FloatSource_Node = (FSGrabsNode)GetPort("AtFrames").GetConnection(0).node;
						objToReturn.AtFrames = GrabsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.DataId:
						FSDataNode DataId_FloatSource_Node = (FSDataNode)GetPort("AtFrames").GetConnection(0).node;
						objToReturn.AtFrames = DataId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ScratchId:
						FSScratchNode ScratchId_FloatSource_Node = (FSScratchNode)GetPort("AtFrames").GetConnection(0).node;
						objToReturn.AtFrames = ScratchId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AnimId:
						FSAnimNode AnimId_FloatSource_Node = (FSAnimNode)GetPort("AtFrames").GetConnection(0).node;
						objToReturn.AtFrames = AnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SpeedId:
						FSSpeedNode SpeedId_FloatSource_Node = (FSSpeedNode)GetPort("AtFrames").GetConnection(0).node;
						objToReturn.AtFrames = SpeedId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.PhysicsId:
						FSPhysicsNode PhysicsId_FloatSource_Node = (FSPhysicsNode)GetPort("AtFrames").GetConnection(0).node;
						objToReturn.AtFrames = PhysicsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CollisionId:
						FSCollisionNode CollisionId_FloatSource_Node = (FSCollisionNode)GetPort("AtFrames").GetConnection(0).node;
						objToReturn.AtFrames = CollisionId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.TimerId:
						FSTimerNode TimerId_FloatSource_Node = (FSTimerNode)GetPort("AtFrames").GetConnection(0).node;
						objToReturn.AtFrames = TimerId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.LagId:
						FSLagNode LagId_FloatSource_Node = (FSLagNode)GetPort("AtFrames").GetConnection(0).node;
						objToReturn.AtFrames = LagId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.EffectsId:
						FSEffectsNode EffectsId_FloatSource_Node = (FSEffectsNode)GetPort("AtFrames").GetConnection(0).node;
						objToReturn.AtFrames = EffectsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ColorsId:
						FSColorsNode ColorsId_FloatSource_Node = (FSColorsNode)GetPort("AtFrames").GetConnection(0).node;
						objToReturn.AtFrames = ColorsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.OnHitId:
						FSOnHitNode OnHitId_FloatSource_Node = (FSOnHitNode)GetPort("AtFrames").GetConnection(0).node;
						objToReturn.AtFrames = OnHitId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RandomId:
						FSRandomNode RandomId_FloatSource_Node = (FSRandomNode)GetPort("AtFrames").GetConnection(0).node;
						objToReturn.AtFrames = RandomId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CameraId:
						FSCameraInfoNode CameraId_FloatSource_Node = (FSCameraInfoNode)GetPort("AtFrames").GetConnection(0).node;
						objToReturn.AtFrames = CameraId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SportsId:
						FSSportsNode SportsId_FloatSource_Node = (FSSportsNode)GetPort("AtFrames").GetConnection(0).node;
						objToReturn.AtFrames = SportsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.Vector2Mag:
						FSVector2MagNode Vector2Mag_FloatSource_Node = (FSVector2MagNode)GetPort("AtFrames").GetConnection(0).node;
						objToReturn.AtFrames = Vector2Mag_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CPUHelpId:
						FSCpuHelpNode CPUHelpId_FloatSource_Node = (FSCpuHelpNode)GetPort("AtFrames").GetConnection(0).node;
						objToReturn.AtFrames = CPUHelpId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ItemId:
						FSItemNode ItemId_FloatSource_Node = (FSItemNode)GetPort("AtFrames").GetConnection(0).node;
						objToReturn.AtFrames = ItemId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ModeId:
						FSModeNode ModeId_FloatSource_Node = (FSModeNode)GetPort("AtFrames").GetConnection(0).node;
						objToReturn.AtFrames = ModeId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.JumpsId:
						FSJumpsNode JumpsId_FloatSource_Node = (FSJumpsNode)GetPort("AtFrames").GetConnection(0).node;
						objToReturn.AtFrames = JumpsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RootAnimId:
						FSRootAnimNode RootAnimId_FloatSource_Node = (FSRootAnimNode)GetPort("AtFrames").GetConnection(0).node;
						objToReturn.AtFrames = RootAnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FloatId:
						FSValueNode FloatId_FloatSource_Node = (FSValueNode)GetPort("AtFrames").GetConnection(0).node;
						objToReturn.AtFrames = FloatId_FloatSource_Node.GetData();
					break;
				}
			}
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
			if (GetPort("StartAnimFrame").ConnectionCount > 0)
			{
				FloatSourceNode FloatSource_Node = (FloatSourceNode)GetPort("StartAnimFrame").GetConnection(0).node;
				switch (FloatSource_Node.TID)
				{
					case FloatSource.TypeId.AgentId:
						FSAgentNode AgentId_FloatSource_Node = (FSAgentNode)GetPort("StartAnimFrame").GetConnection(0).node;
						objToReturn.StartAnimFrame = AgentId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.BonesId:
						FSBonesNode BonesId_FloatSource_Node = (FSBonesNode)GetPort("StartAnimFrame").GetConnection(0).node;
						objToReturn.StartAnimFrame = BonesId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AttackId:
						FSAttackNode AttackId_FloatSource_Node = (FSAttackNode)GetPort("StartAnimFrame").GetConnection(0).node;
						objToReturn.StartAnimFrame = AttackId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FrameId:
						FSFrameNode FrameId_FloatSource_Node = (FSFrameNode)GetPort("StartAnimFrame").GetConnection(0).node;
						objToReturn.StartAnimFrame = FrameId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.InputId:
						FSInputNode InputId_FloatSource_Node = (FSInputNode)GetPort("StartAnimFrame").GetConnection(0).node;
						objToReturn.StartAnimFrame = InputId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FuncId:
						FSFuncNode FuncId_FloatSource_Node = (FSFuncNode)GetPort("StartAnimFrame").GetConnection(0).node;
						objToReturn.StartAnimFrame = FuncId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.MovementId:
						FSMovementNode MovementId_FloatSource_Node = (FSMovementNode)GetPort("StartAnimFrame").GetConnection(0).node;
						objToReturn.StartAnimFrame = MovementId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CombatId:
						FSCombatNode CombatId_FloatSource_Node = (FSCombatNode)GetPort("StartAnimFrame").GetConnection(0).node;
						objToReturn.StartAnimFrame = CombatId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.GrabsId:
						FSGrabsNode GrabsId_FloatSource_Node = (FSGrabsNode)GetPort("StartAnimFrame").GetConnection(0).node;
						objToReturn.StartAnimFrame = GrabsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.DataId:
						FSDataNode DataId_FloatSource_Node = (FSDataNode)GetPort("StartAnimFrame").GetConnection(0).node;
						objToReturn.StartAnimFrame = DataId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ScratchId:
						FSScratchNode ScratchId_FloatSource_Node = (FSScratchNode)GetPort("StartAnimFrame").GetConnection(0).node;
						objToReturn.StartAnimFrame = ScratchId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AnimId:
						FSAnimNode AnimId_FloatSource_Node = (FSAnimNode)GetPort("StartAnimFrame").GetConnection(0).node;
						objToReturn.StartAnimFrame = AnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SpeedId:
						FSSpeedNode SpeedId_FloatSource_Node = (FSSpeedNode)GetPort("StartAnimFrame").GetConnection(0).node;
						objToReturn.StartAnimFrame = SpeedId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.PhysicsId:
						FSPhysicsNode PhysicsId_FloatSource_Node = (FSPhysicsNode)GetPort("StartAnimFrame").GetConnection(0).node;
						objToReturn.StartAnimFrame = PhysicsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CollisionId:
						FSCollisionNode CollisionId_FloatSource_Node = (FSCollisionNode)GetPort("StartAnimFrame").GetConnection(0).node;
						objToReturn.StartAnimFrame = CollisionId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.TimerId:
						FSTimerNode TimerId_FloatSource_Node = (FSTimerNode)GetPort("StartAnimFrame").GetConnection(0).node;
						objToReturn.StartAnimFrame = TimerId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.LagId:
						FSLagNode LagId_FloatSource_Node = (FSLagNode)GetPort("StartAnimFrame").GetConnection(0).node;
						objToReturn.StartAnimFrame = LagId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.EffectsId:
						FSEffectsNode EffectsId_FloatSource_Node = (FSEffectsNode)GetPort("StartAnimFrame").GetConnection(0).node;
						objToReturn.StartAnimFrame = EffectsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ColorsId:
						FSColorsNode ColorsId_FloatSource_Node = (FSColorsNode)GetPort("StartAnimFrame").GetConnection(0).node;
						objToReturn.StartAnimFrame = ColorsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.OnHitId:
						FSOnHitNode OnHitId_FloatSource_Node = (FSOnHitNode)GetPort("StartAnimFrame").GetConnection(0).node;
						objToReturn.StartAnimFrame = OnHitId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RandomId:
						FSRandomNode RandomId_FloatSource_Node = (FSRandomNode)GetPort("StartAnimFrame").GetConnection(0).node;
						objToReturn.StartAnimFrame = RandomId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CameraId:
						FSCameraInfoNode CameraId_FloatSource_Node = (FSCameraInfoNode)GetPort("StartAnimFrame").GetConnection(0).node;
						objToReturn.StartAnimFrame = CameraId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SportsId:
						FSSportsNode SportsId_FloatSource_Node = (FSSportsNode)GetPort("StartAnimFrame").GetConnection(0).node;
						objToReturn.StartAnimFrame = SportsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.Vector2Mag:
						FSVector2MagNode Vector2Mag_FloatSource_Node = (FSVector2MagNode)GetPort("StartAnimFrame").GetConnection(0).node;
						objToReturn.StartAnimFrame = Vector2Mag_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CPUHelpId:
						FSCpuHelpNode CPUHelpId_FloatSource_Node = (FSCpuHelpNode)GetPort("StartAnimFrame").GetConnection(0).node;
						objToReturn.StartAnimFrame = CPUHelpId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ItemId:
						FSItemNode ItemId_FloatSource_Node = (FSItemNode)GetPort("StartAnimFrame").GetConnection(0).node;
						objToReturn.StartAnimFrame = ItemId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ModeId:
						FSModeNode ModeId_FloatSource_Node = (FSModeNode)GetPort("StartAnimFrame").GetConnection(0).node;
						objToReturn.StartAnimFrame = ModeId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.JumpsId:
						FSJumpsNode JumpsId_FloatSource_Node = (FSJumpsNode)GetPort("StartAnimFrame").GetConnection(0).node;
						objToReturn.StartAnimFrame = JumpsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RootAnimId:
						FSRootAnimNode RootAnimId_FloatSource_Node = (FSRootAnimNode)GetPort("StartAnimFrame").GetConnection(0).node;
						objToReturn.StartAnimFrame = RootAnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FloatId:
						FSValueNode FloatId_FloatSource_Node = (FSValueNode)GetPort("StartAnimFrame").GetConnection(0).node;
						objToReturn.StartAnimFrame = FloatId_FloatSource_Node.GetData();
					break;
				}
			}
			if (GetPort("EndAnimFrame").ConnectionCount > 0)
			{
				FloatSourceNode FloatSource_Node = (FloatSourceNode)GetPort("EndAnimFrame").GetConnection(0).node;
				switch (FloatSource_Node.TID)
				{
					case FloatSource.TypeId.AgentId:
						FSAgentNode AgentId_FloatSource_Node = (FSAgentNode)GetPort("EndAnimFrame").GetConnection(0).node;
						objToReturn.EndAnimFrame = AgentId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.BonesId:
						FSBonesNode BonesId_FloatSource_Node = (FSBonesNode)GetPort("EndAnimFrame").GetConnection(0).node;
						objToReturn.EndAnimFrame = BonesId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AttackId:
						FSAttackNode AttackId_FloatSource_Node = (FSAttackNode)GetPort("EndAnimFrame").GetConnection(0).node;
						objToReturn.EndAnimFrame = AttackId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FrameId:
						FSFrameNode FrameId_FloatSource_Node = (FSFrameNode)GetPort("EndAnimFrame").GetConnection(0).node;
						objToReturn.EndAnimFrame = FrameId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.InputId:
						FSInputNode InputId_FloatSource_Node = (FSInputNode)GetPort("EndAnimFrame").GetConnection(0).node;
						objToReturn.EndAnimFrame = InputId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FuncId:
						FSFuncNode FuncId_FloatSource_Node = (FSFuncNode)GetPort("EndAnimFrame").GetConnection(0).node;
						objToReturn.EndAnimFrame = FuncId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.MovementId:
						FSMovementNode MovementId_FloatSource_Node = (FSMovementNode)GetPort("EndAnimFrame").GetConnection(0).node;
						objToReturn.EndAnimFrame = MovementId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CombatId:
						FSCombatNode CombatId_FloatSource_Node = (FSCombatNode)GetPort("EndAnimFrame").GetConnection(0).node;
						objToReturn.EndAnimFrame = CombatId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.GrabsId:
						FSGrabsNode GrabsId_FloatSource_Node = (FSGrabsNode)GetPort("EndAnimFrame").GetConnection(0).node;
						objToReturn.EndAnimFrame = GrabsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.DataId:
						FSDataNode DataId_FloatSource_Node = (FSDataNode)GetPort("EndAnimFrame").GetConnection(0).node;
						objToReturn.EndAnimFrame = DataId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ScratchId:
						FSScratchNode ScratchId_FloatSource_Node = (FSScratchNode)GetPort("EndAnimFrame").GetConnection(0).node;
						objToReturn.EndAnimFrame = ScratchId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AnimId:
						FSAnimNode AnimId_FloatSource_Node = (FSAnimNode)GetPort("EndAnimFrame").GetConnection(0).node;
						objToReturn.EndAnimFrame = AnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SpeedId:
						FSSpeedNode SpeedId_FloatSource_Node = (FSSpeedNode)GetPort("EndAnimFrame").GetConnection(0).node;
						objToReturn.EndAnimFrame = SpeedId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.PhysicsId:
						FSPhysicsNode PhysicsId_FloatSource_Node = (FSPhysicsNode)GetPort("EndAnimFrame").GetConnection(0).node;
						objToReturn.EndAnimFrame = PhysicsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CollisionId:
						FSCollisionNode CollisionId_FloatSource_Node = (FSCollisionNode)GetPort("EndAnimFrame").GetConnection(0).node;
						objToReturn.EndAnimFrame = CollisionId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.TimerId:
						FSTimerNode TimerId_FloatSource_Node = (FSTimerNode)GetPort("EndAnimFrame").GetConnection(0).node;
						objToReturn.EndAnimFrame = TimerId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.LagId:
						FSLagNode LagId_FloatSource_Node = (FSLagNode)GetPort("EndAnimFrame").GetConnection(0).node;
						objToReturn.EndAnimFrame = LagId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.EffectsId:
						FSEffectsNode EffectsId_FloatSource_Node = (FSEffectsNode)GetPort("EndAnimFrame").GetConnection(0).node;
						objToReturn.EndAnimFrame = EffectsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ColorsId:
						FSColorsNode ColorsId_FloatSource_Node = (FSColorsNode)GetPort("EndAnimFrame").GetConnection(0).node;
						objToReturn.EndAnimFrame = ColorsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.OnHitId:
						FSOnHitNode OnHitId_FloatSource_Node = (FSOnHitNode)GetPort("EndAnimFrame").GetConnection(0).node;
						objToReturn.EndAnimFrame = OnHitId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RandomId:
						FSRandomNode RandomId_FloatSource_Node = (FSRandomNode)GetPort("EndAnimFrame").GetConnection(0).node;
						objToReturn.EndAnimFrame = RandomId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CameraId:
						FSCameraInfoNode CameraId_FloatSource_Node = (FSCameraInfoNode)GetPort("EndAnimFrame").GetConnection(0).node;
						objToReturn.EndAnimFrame = CameraId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SportsId:
						FSSportsNode SportsId_FloatSource_Node = (FSSportsNode)GetPort("EndAnimFrame").GetConnection(0).node;
						objToReturn.EndAnimFrame = SportsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.Vector2Mag:
						FSVector2MagNode Vector2Mag_FloatSource_Node = (FSVector2MagNode)GetPort("EndAnimFrame").GetConnection(0).node;
						objToReturn.EndAnimFrame = Vector2Mag_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CPUHelpId:
						FSCpuHelpNode CPUHelpId_FloatSource_Node = (FSCpuHelpNode)GetPort("EndAnimFrame").GetConnection(0).node;
						objToReturn.EndAnimFrame = CPUHelpId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ItemId:
						FSItemNode ItemId_FloatSource_Node = (FSItemNode)GetPort("EndAnimFrame").GetConnection(0).node;
						objToReturn.EndAnimFrame = ItemId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ModeId:
						FSModeNode ModeId_FloatSource_Node = (FSModeNode)GetPort("EndAnimFrame").GetConnection(0).node;
						objToReturn.EndAnimFrame = ModeId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.JumpsId:
						FSJumpsNode JumpsId_FloatSource_Node = (FSJumpsNode)GetPort("EndAnimFrame").GetConnection(0).node;
						objToReturn.EndAnimFrame = JumpsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RootAnimId:
						FSRootAnimNode RootAnimId_FloatSource_Node = (FSRootAnimNode)GetPort("EndAnimFrame").GetConnection(0).node;
						objToReturn.EndAnimFrame = RootAnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FloatId:
						FSValueNode FloatId_FloatSource_Node = (FSValueNode)GetPort("EndAnimFrame").GetConnection(0).node;
						objToReturn.EndAnimFrame = FloatId_FloatSource_Node.GetData();
					break;
				}
			}
			return objToReturn;
		}
	}
}

