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
	public class SASetFloatTarget_SetFloatNode : StateActionNode
	{
		[Output(connectionType = ConnectionType.Override)] public FloatSource Target;
		[Output(connectionType = ConnectionType.Override)] public FloatSource Source;
		public SASetFloatTarget.SetFloat.ManipWay Way;
		
		protected override void Init()
		{
			base.Init();
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SASetFloatTarget.SetFloat data, MovesetGraph graph, string assetPath, Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SASetFloatTarget.SetFloat));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			Target = data.Target;
			
			switch (Target.TID)
			{
				case FloatSource.TypeId.AgentId:
					FSAgentNode AgentId_node_Target = graph.AddNode<FSAgentNode>();
					GetPort("Target").Connect(AgentId_node_Target.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AgentId_node_Target, assetPath);
					variableCount += AgentId_node_Target.SetData((FSAgent)Target, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.BonesId:
					FSBonesNode BonesId_node_Target = graph.AddNode<FSBonesNode>();
					GetPort("Target").Connect(BonesId_node_Target.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(BonesId_node_Target, assetPath);
					variableCount += BonesId_node_Target.SetData((FSBones)Target, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AttackId:
					FSAttackNode AttackId_node_Target = graph.AddNode<FSAttackNode>();
					GetPort("Target").Connect(AttackId_node_Target.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AttackId_node_Target, assetPath);
					variableCount += AttackId_node_Target.SetData((FSAttack)Target, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FrameId:
					FSFrameNode FrameId_node_Target = graph.AddNode<FSFrameNode>();
					GetPort("Target").Connect(FrameId_node_Target.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FrameId_node_Target, assetPath);
					variableCount += FrameId_node_Target.SetData((FSFrame)Target, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.InputId:
					FSInputNode InputId_node_Target = graph.AddNode<FSInputNode>();
					GetPort("Target").Connect(InputId_node_Target.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(InputId_node_Target, assetPath);
					variableCount += InputId_node_Target.SetData((FSInput)Target, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FuncId:
					FSFuncNode FuncId_node_Target = graph.AddNode<FSFuncNode>();
					GetPort("Target").Connect(FuncId_node_Target.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FuncId_node_Target, assetPath);
					variableCount += FuncId_node_Target.SetData((FSFunc)Target, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.MovementId:
					FSMovementNode MovementId_node_Target = graph.AddNode<FSMovementNode>();
					GetPort("Target").Connect(MovementId_node_Target.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(MovementId_node_Target, assetPath);
					variableCount += MovementId_node_Target.SetData((FSMovement)Target, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CombatId:
					FSCombatNode CombatId_node_Target = graph.AddNode<FSCombatNode>();
					GetPort("Target").Connect(CombatId_node_Target.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CombatId_node_Target, assetPath);
					variableCount += CombatId_node_Target.SetData((FSCombat)Target, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.GrabsId:
					FSGrabsNode GrabsId_node_Target = graph.AddNode<FSGrabsNode>();
					GetPort("Target").Connect(GrabsId_node_Target.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(GrabsId_node_Target, assetPath);
					variableCount += GrabsId_node_Target.SetData((FSGrabs)Target, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.DataId:
					FSDataNode DataId_node_Target = graph.AddNode<FSDataNode>();
					GetPort("Target").Connect(DataId_node_Target.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DataId_node_Target, assetPath);
					variableCount += DataId_node_Target.SetData((FSData)Target, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ScratchId:
					FSScratchNode ScratchId_node_Target = graph.AddNode<FSScratchNode>();
					GetPort("Target").Connect(ScratchId_node_Target.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ScratchId_node_Target, assetPath);
					variableCount += ScratchId_node_Target.SetData((FSScratch)Target, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.AnimId:
					FSAnimNode AnimId_node_Target = graph.AddNode<FSAnimNode>();
					GetPort("Target").Connect(AnimId_node_Target.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AnimId_node_Target, assetPath);
					variableCount += AnimId_node_Target.SetData((FSAnim)Target, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SpeedId:
					FSSpeedNode SpeedId_node_Target = graph.AddNode<FSSpeedNode>();
					GetPort("Target").Connect(SpeedId_node_Target.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SpeedId_node_Target, assetPath);
					variableCount += SpeedId_node_Target.SetData((FSSpeed)Target, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.PhysicsId:
					FSPhysicsNode PhysicsId_node_Target = graph.AddNode<FSPhysicsNode>();
					GetPort("Target").Connect(PhysicsId_node_Target.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(PhysicsId_node_Target, assetPath);
					variableCount += PhysicsId_node_Target.SetData((FSPhysics)Target, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CollisionId:
					FSCollisionNode CollisionId_node_Target = graph.AddNode<FSCollisionNode>();
					GetPort("Target").Connect(CollisionId_node_Target.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CollisionId_node_Target, assetPath);
					variableCount += CollisionId_node_Target.SetData((FSCollision)Target, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.TimerId:
					FSTimerNode TimerId_node_Target = graph.AddNode<FSTimerNode>();
					GetPort("Target").Connect(TimerId_node_Target.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(TimerId_node_Target, assetPath);
					variableCount += TimerId_node_Target.SetData((FSTimer)Target, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.LagId:
					FSLagNode LagId_node_Target = graph.AddNode<FSLagNode>();
					GetPort("Target").Connect(LagId_node_Target.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(LagId_node_Target, assetPath);
					variableCount += LagId_node_Target.SetData((FSLag)Target, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.EffectsId:
					FSEffectsNode EffectsId_node_Target = graph.AddNode<FSEffectsNode>();
					GetPort("Target").Connect(EffectsId_node_Target.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(EffectsId_node_Target, assetPath);
					variableCount += EffectsId_node_Target.SetData((FSEffects)Target, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ColorsId:
					FSColorsNode ColorsId_node_Target = graph.AddNode<FSColorsNode>();
					GetPort("Target").Connect(ColorsId_node_Target.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ColorsId_node_Target, assetPath);
					variableCount += ColorsId_node_Target.SetData((FSColors)Target, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.OnHitId:
					FSOnHitNode OnHitId_node_Target = graph.AddNode<FSOnHitNode>();
					GetPort("Target").Connect(OnHitId_node_Target.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OnHitId_node_Target, assetPath);
					variableCount += OnHitId_node_Target.SetData((FSOnHit)Target, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RandomId:
					FSRandomNode RandomId_node_Target = graph.AddNode<FSRandomNode>();
					GetPort("Target").Connect(RandomId_node_Target.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RandomId_node_Target, assetPath);
					variableCount += RandomId_node_Target.SetData((FSRandom)Target, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CameraId:
					FSCameraInfoNode CameraId_node_Target = graph.AddNode<FSCameraInfoNode>();
					GetPort("Target").Connect(CameraId_node_Target.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CameraId_node_Target, assetPath);
					variableCount += CameraId_node_Target.SetData((FSCameraInfo)Target, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.SportsId:
					FSSportsNode SportsId_node_Target = graph.AddNode<FSSportsNode>();
					GetPort("Target").Connect(SportsId_node_Target.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(SportsId_node_Target, assetPath);
					variableCount += SportsId_node_Target.SetData((FSSports)Target, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.Vector2Mag:
					FSVector2MagNode Vector2Mag_node_Target = graph.AddNode<FSVector2MagNode>();
					GetPort("Target").Connect(Vector2Mag_node_Target.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(Vector2Mag_node_Target, assetPath);
					variableCount += Vector2Mag_node_Target.SetData((FSVector2Mag)Target, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.CPUHelpId:
					FSCpuHelpNode CPUHelpId_node_Target = graph.AddNode<FSCpuHelpNode>();
					GetPort("Target").Connect(CPUHelpId_node_Target.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(CPUHelpId_node_Target, assetPath);
					variableCount += CPUHelpId_node_Target.SetData((FSCpuHelp)Target, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ItemId:
					FSItemNode ItemId_node_Target = graph.AddNode<FSItemNode>();
					GetPort("Target").Connect(ItemId_node_Target.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ItemId_node_Target, assetPath);
					variableCount += ItemId_node_Target.SetData((FSItem)Target, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.ModeId:
					FSModeNode ModeId_node_Target = graph.AddNode<FSModeNode>();
					GetPort("Target").Connect(ModeId_node_Target.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ModeId_node_Target, assetPath);
					variableCount += ModeId_node_Target.SetData((FSMode)Target, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.JumpsId:
					FSJumpsNode JumpsId_node_Target = graph.AddNode<FSJumpsNode>();
					GetPort("Target").Connect(JumpsId_node_Target.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(JumpsId_node_Target, assetPath);
					variableCount += JumpsId_node_Target.SetData((FSJumps)Target, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.RootAnimId:
					FSRootAnimNode RootAnimId_node_Target = graph.AddNode<FSRootAnimNode>();
					GetPort("Target").Connect(RootAnimId_node_Target.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(RootAnimId_node_Target, assetPath);
					variableCount += RootAnimId_node_Target.SetData((FSRootAnim)Target, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FloatId:
					FSValueNode FloatId_node_Target = graph.AddNode<FSValueNode>();
					GetPort("Target").Connect(FloatId_node_Target.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FloatId_node_Target, assetPath);
					variableCount += FloatId_node_Target.SetData((FSValue)Target, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
			}
			++variableCount;
			
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
			++variableCount;
			
			Way = data.Way;
			return variableCount;
		}
		
		public SASetFloatTarget.SetFloat GetData()
		{
			SASetFloatTarget.SetFloat objToReturn = new SASetFloatTarget.SetFloat();
			if (GetPort("Target").ConnectionCount > 0)
			{
				FloatSourceNode FloatSource_Node = (FloatSourceNode)GetPort("Target").GetConnection(0).node;
				switch (FloatSource_Node.TID)
				{
					case FloatSource.TypeId.AgentId:
						FSAgentNode AgentId_FloatSource_Node = (FSAgentNode)GetPort("Target").GetConnection(0).node;
						objToReturn.Target = AgentId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.BonesId:
						FSBonesNode BonesId_FloatSource_Node = (FSBonesNode)GetPort("Target").GetConnection(0).node;
						objToReturn.Target = BonesId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AttackId:
						FSAttackNode AttackId_FloatSource_Node = (FSAttackNode)GetPort("Target").GetConnection(0).node;
						objToReturn.Target = AttackId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FrameId:
						FSFrameNode FrameId_FloatSource_Node = (FSFrameNode)GetPort("Target").GetConnection(0).node;
						objToReturn.Target = FrameId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.InputId:
						FSInputNode InputId_FloatSource_Node = (FSInputNode)GetPort("Target").GetConnection(0).node;
						objToReturn.Target = InputId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FuncId:
						FSFuncNode FuncId_FloatSource_Node = (FSFuncNode)GetPort("Target").GetConnection(0).node;
						objToReturn.Target = FuncId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.MovementId:
						FSMovementNode MovementId_FloatSource_Node = (FSMovementNode)GetPort("Target").GetConnection(0).node;
						objToReturn.Target = MovementId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CombatId:
						FSCombatNode CombatId_FloatSource_Node = (FSCombatNode)GetPort("Target").GetConnection(0).node;
						objToReturn.Target = CombatId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.GrabsId:
						FSGrabsNode GrabsId_FloatSource_Node = (FSGrabsNode)GetPort("Target").GetConnection(0).node;
						objToReturn.Target = GrabsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.DataId:
						FSDataNode DataId_FloatSource_Node = (FSDataNode)GetPort("Target").GetConnection(0).node;
						objToReturn.Target = DataId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ScratchId:
						FSScratchNode ScratchId_FloatSource_Node = (FSScratchNode)GetPort("Target").GetConnection(0).node;
						objToReturn.Target = ScratchId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.AnimId:
						FSAnimNode AnimId_FloatSource_Node = (FSAnimNode)GetPort("Target").GetConnection(0).node;
						objToReturn.Target = AnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SpeedId:
						FSSpeedNode SpeedId_FloatSource_Node = (FSSpeedNode)GetPort("Target").GetConnection(0).node;
						objToReturn.Target = SpeedId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.PhysicsId:
						FSPhysicsNode PhysicsId_FloatSource_Node = (FSPhysicsNode)GetPort("Target").GetConnection(0).node;
						objToReturn.Target = PhysicsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CollisionId:
						FSCollisionNode CollisionId_FloatSource_Node = (FSCollisionNode)GetPort("Target").GetConnection(0).node;
						objToReturn.Target = CollisionId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.TimerId:
						FSTimerNode TimerId_FloatSource_Node = (FSTimerNode)GetPort("Target").GetConnection(0).node;
						objToReturn.Target = TimerId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.LagId:
						FSLagNode LagId_FloatSource_Node = (FSLagNode)GetPort("Target").GetConnection(0).node;
						objToReturn.Target = LagId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.EffectsId:
						FSEffectsNode EffectsId_FloatSource_Node = (FSEffectsNode)GetPort("Target").GetConnection(0).node;
						objToReturn.Target = EffectsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ColorsId:
						FSColorsNode ColorsId_FloatSource_Node = (FSColorsNode)GetPort("Target").GetConnection(0).node;
						objToReturn.Target = ColorsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.OnHitId:
						FSOnHitNode OnHitId_FloatSource_Node = (FSOnHitNode)GetPort("Target").GetConnection(0).node;
						objToReturn.Target = OnHitId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RandomId:
						FSRandomNode RandomId_FloatSource_Node = (FSRandomNode)GetPort("Target").GetConnection(0).node;
						objToReturn.Target = RandomId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CameraId:
						FSCameraInfoNode CameraId_FloatSource_Node = (FSCameraInfoNode)GetPort("Target").GetConnection(0).node;
						objToReturn.Target = CameraId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.SportsId:
						FSSportsNode SportsId_FloatSource_Node = (FSSportsNode)GetPort("Target").GetConnection(0).node;
						objToReturn.Target = SportsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.Vector2Mag:
						FSVector2MagNode Vector2Mag_FloatSource_Node = (FSVector2MagNode)GetPort("Target").GetConnection(0).node;
						objToReturn.Target = Vector2Mag_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.CPUHelpId:
						FSCpuHelpNode CPUHelpId_FloatSource_Node = (FSCpuHelpNode)GetPort("Target").GetConnection(0).node;
						objToReturn.Target = CPUHelpId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ItemId:
						FSItemNode ItemId_FloatSource_Node = (FSItemNode)GetPort("Target").GetConnection(0).node;
						objToReturn.Target = ItemId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.ModeId:
						FSModeNode ModeId_FloatSource_Node = (FSModeNode)GetPort("Target").GetConnection(0).node;
						objToReturn.Target = ModeId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.JumpsId:
						FSJumpsNode JumpsId_FloatSource_Node = (FSJumpsNode)GetPort("Target").GetConnection(0).node;
						objToReturn.Target = JumpsId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.RootAnimId:
						FSRootAnimNode RootAnimId_FloatSource_Node = (FSRootAnimNode)GetPort("Target").GetConnection(0).node;
						objToReturn.Target = RootAnimId_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FloatId:
						FSValueNode FloatId_FloatSource_Node = (FSValueNode)GetPort("Target").GetConnection(0).node;
						objToReturn.Target = FloatId_FloatSource_Node.GetData();
					break;
				}
			}
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
			objToReturn.Way = Way;
			return objToReturn;
		}
	}
}

