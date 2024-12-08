// * 
// * 
// * This file was generated using NASB_Parser_to_xNode by megalon2d
// * https://github.com/megalon/NASB_Parser_to_xNode
// * 
// * 
using MovesetParser.BulkSerialize;
using UnityEngine;
using UnityEditor;
using XNode;
using XNodeEditor;
using MovesetParser;
using MovesetParser.CheckThings;
using MovesetParser.FloatSources;
using MovesetParser.Jumps;
using MovesetParser.Misc;
using MovesetParser.StateActions;
using MovesetParser.ObjectSources;
using MovesetParser.Unity;
using NASB_Moveset_Editor.CheckThings;
using NASB_Moveset_Editor.FloatSources;
using NASB_Moveset_Editor.Jumps;
using NASB_Moveset_Editor.Misc;
using NASB_Moveset_Editor.StateActions;
using NASB_Moveset_Editor.ObjectSources;
using NASB_Moveset_Editor.Unity;
using static MovesetParser.FloatSources.FloatSourceContainer;

namespace NASB_Moveset_Editor.FloatSources
{
	public class FloatSourceContainerNode : FloatSourceNode
	{
		[Input(connectionType = ConnectionType.Override)] public FloatSource NodeInput;
		[Output(connectionType = ConnectionType.Override)] public FloatSource FloatSource;
		
		protected override void Init()
		{
			base.Init();
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(FloatSourceContainer data, MovesetGraph graph, string assetPath, UnityEngine.Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(FloatSourceContainer));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;

			if (data == null) return variableCount;
			
			FloatSource = data.FloatSource;
			
			switch (FloatSource.TID)
			{
				case FloatSource.TypeId.FloatSource:
					FloatSourceNode FloatSource_node_FloatSource = graph.AddNode<FloatSourceNode>();
					GetPort("FloatSource").Connect(FloatSource_node_FloatSource.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FloatSource_node_FloatSource, assetPath);
					variableCount += FloatSource_node_FloatSource.SetData((FloatSource)FloatSource, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FSAgent:
					FSAgentNode FSAgent_node_FloatSource = graph.AddNode<FSAgentNode>();
					GetPort("FloatSource").Connect(FSAgent_node_FloatSource.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FSAgent_node_FloatSource, assetPath);
					variableCount += FSAgent_node_FloatSource.SetData((FSAgent)FloatSource, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FSBones:
					FSBonesNode FSBones_node_FloatSource = graph.AddNode<FSBonesNode>();
					GetPort("FloatSource").Connect(FSBones_node_FloatSource.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FSBones_node_FloatSource, assetPath);
					variableCount += FSBones_node_FloatSource.SetData((FSBones)FloatSource, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FSAttack:
					FSAttackNode FSAttack_node_FloatSource = graph.AddNode<FSAttackNode>();
					GetPort("FloatSource").Connect(FSAttack_node_FloatSource.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FSAttack_node_FloatSource, assetPath);
					variableCount += FSAttack_node_FloatSource.SetData((FSAttack)FloatSource, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FSFrame:
					FSFrameNode FSFrame_node_FloatSource = graph.AddNode<FSFrameNode>();
					GetPort("FloatSource").Connect(FSFrame_node_FloatSource.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FSFrame_node_FloatSource, assetPath);
					variableCount += FSFrame_node_FloatSource.SetData((FSFrame)FloatSource, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FSInput:
					FSInputNode FSInput_node_FloatSource = graph.AddNode<FSInputNode>();
					GetPort("FloatSource").Connect(FSInput_node_FloatSource.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FSInput_node_FloatSource, assetPath);
					variableCount += FSInput_node_FloatSource.SetData((FSInput)FloatSource, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FSFunc:
					FSFuncNode FSFunc_node_FloatSource = graph.AddNode<FSFuncNode>();
					GetPort("FloatSource").Connect(FSFunc_node_FloatSource.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FSFunc_node_FloatSource, assetPath);
					variableCount += FSFunc_node_FloatSource.SetData((FSFunc)FloatSource, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FSMovement:
					FSMovementNode FSMovement_node_FloatSource = graph.AddNode<FSMovementNode>();
					GetPort("FloatSource").Connect(FSMovement_node_FloatSource.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FSMovement_node_FloatSource, assetPath);
					variableCount += FSMovement_node_FloatSource.SetData((FSMovement)FloatSource, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FSCombat:
					FSCombatNode FSCombat_node_FloatSource = graph.AddNode<FSCombatNode>();
					GetPort("FloatSource").Connect(FSCombat_node_FloatSource.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FSCombat_node_FloatSource, assetPath);
					variableCount += FSCombat_node_FloatSource.SetData((FSCombat)FloatSource, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FSGrabs:
					FSGrabsNode FSGrabs_node_FloatSource = graph.AddNode<FSGrabsNode>();
					GetPort("FloatSource").Connect(FSGrabs_node_FloatSource.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FSGrabs_node_FloatSource, assetPath);
					variableCount += FSGrabs_node_FloatSource.SetData((FSGrabs)FloatSource, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FSData:
					FSDataNode FSData_node_FloatSource = graph.AddNode<FSDataNode>();
					GetPort("FloatSource").Connect(FSData_node_FloatSource.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FSData_node_FloatSource, assetPath);
					variableCount += FSData_node_FloatSource.SetData((FSData)FloatSource, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FSScratch:
					FSScratchNode FSScratch_node_FloatSource = graph.AddNode<FSScratchNode>();
					GetPort("FloatSource").Connect(FSScratch_node_FloatSource.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FSScratch_node_FloatSource, assetPath);
					variableCount += FSScratch_node_FloatSource.SetData((FSScratch)FloatSource, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FSAnim:
					FSAnimNode FSAnim_node_FloatSource = graph.AddNode<FSAnimNode>();
					GetPort("FloatSource").Connect(FSAnim_node_FloatSource.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FSAnim_node_FloatSource, assetPath);
					variableCount += FSAnim_node_FloatSource.SetData((FSAnim)FloatSource, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FSSpeed:
					FSSpeedNode FSSpeed_node_FloatSource = graph.AddNode<FSSpeedNode>();
					GetPort("FloatSource").Connect(FSSpeed_node_FloatSource.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FSSpeed_node_FloatSource, assetPath);
					variableCount += FSSpeed_node_FloatSource.SetData((FSSpeed)FloatSource, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FSPhysics:
					FSPhysicsNode FSPhysics_node_FloatSource = graph.AddNode<FSPhysicsNode>();
					GetPort("FloatSource").Connect(FSPhysics_node_FloatSource.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FSPhysics_node_FloatSource, assetPath);
					variableCount += FSPhysics_node_FloatSource.SetData((FSPhysics)FloatSource, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FSCollision:
					FSCollisionNode FSCollision_node_FloatSource = graph.AddNode<FSCollisionNode>();
					GetPort("FloatSource").Connect(FSCollision_node_FloatSource.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FSCollision_node_FloatSource, assetPath);
					variableCount += FSCollision_node_FloatSource.SetData((FSCollision)FloatSource, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FSTimer:
					FSTimerNode FSTimer_node_FloatSource = graph.AddNode<FSTimerNode>();
					GetPort("FloatSource").Connect(FSTimer_node_FloatSource.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FSTimer_node_FloatSource, assetPath);
					variableCount += FSTimer_node_FloatSource.SetData((FSTimer)FloatSource, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FSLag:
					FSLagNode FSLag_node_FloatSource = graph.AddNode<FSLagNode>();
					GetPort("FloatSource").Connect(FSLag_node_FloatSource.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FSLag_node_FloatSource, assetPath);
					variableCount += FSLag_node_FloatSource.SetData((FSLag)FloatSource, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FSEffects:
					FSEffectsNode FSEffects_node_FloatSource = graph.AddNode<FSEffectsNode>();
					GetPort("FloatSource").Connect(FSEffects_node_FloatSource.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FSEffects_node_FloatSource, assetPath);
					variableCount += FSEffects_node_FloatSource.SetData((FSEffects)FloatSource, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FSColors:
					FSColorsNode FSColors_node_FloatSource = graph.AddNode<FSColorsNode>();
					GetPort("FloatSource").Connect(FSColors_node_FloatSource.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FSColors_node_FloatSource, assetPath);
					variableCount += FSColors_node_FloatSource.SetData((FSColors)FloatSource, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FSOnHit:
					FSOnHitNode FSOnHit_node_FloatSource = graph.AddNode<FSOnHitNode>();
					GetPort("FloatSource").Connect(FSOnHit_node_FloatSource.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FSOnHit_node_FloatSource, assetPath);
					variableCount += FSOnHit_node_FloatSource.SetData((FSOnHit)FloatSource, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FSRandom:
					FSRandomNode FSRandom_node_FloatSource = graph.AddNode<FSRandomNode>();
					GetPort("FloatSource").Connect(FSRandom_node_FloatSource.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FSRandom_node_FloatSource, assetPath);
					variableCount += FSRandom_node_FloatSource.SetData((FSRandom)FloatSource, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FSCameraInfo:
					FSCameraInfoNode FSCameraInfo_node_FloatSource = graph.AddNode<FSCameraInfoNode>();
					GetPort("FloatSource").Connect(FSCameraInfo_node_FloatSource.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FSCameraInfo_node_FloatSource, assetPath);
					variableCount += FSCameraInfo_node_FloatSource.SetData((FSCameraInfo)FloatSource, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FSSports:
					FSSportsNode FSSports_node_FloatSource = graph.AddNode<FSSportsNode>();
					GetPort("FloatSource").Connect(FSSports_node_FloatSource.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FSSports_node_FloatSource, assetPath);
					variableCount += FSSports_node_FloatSource.SetData((FSSports)FloatSource, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FSVector2Mag:
					FSVector2MagNode FSVector2Mag_node_FloatSource = graph.AddNode<FSVector2MagNode>();
					GetPort("FloatSource").Connect(FSVector2Mag_node_FloatSource.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FSVector2Mag_node_FloatSource, assetPath);
					variableCount += FSVector2Mag_node_FloatSource.SetData((FSVector2Mag)FloatSource, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FSCPUHelp:
					FSCPUHelpNode FSCPUHelp_node_FloatSource = graph.AddNode<FSCPUHelpNode>();
					GetPort("FloatSource").Connect(FSCPUHelp_node_FloatSource.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FSCPUHelp_node_FloatSource, assetPath);
					variableCount += FSCPUHelp_node_FloatSource.SetData((FSCPUHelp)FloatSource, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FSItem:
					FSItemNode FSItem_node_FloatSource = graph.AddNode<FSItemNode>();
					GetPort("FloatSource").Connect(FSItem_node_FloatSource.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FSItem_node_FloatSource, assetPath);
					variableCount += FSItem_node_FloatSource.SetData((FSItem)FloatSource, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FSMode:
					FSModeNode FSMode_node_FloatSource = graph.AddNode<FSModeNode>();
					GetPort("FloatSource").Connect(FSMode_node_FloatSource.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FSMode_node_FloatSource, assetPath);
					variableCount += FSMode_node_FloatSource.SetData((FSMode)FloatSource, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FSJumps:
					FSJumpsNode FSJumps_node_FloatSource = graph.AddNode<FSJumpsNode>();
					GetPort("FloatSource").Connect(FSJumps_node_FloatSource.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FSJumps_node_FloatSource, assetPath);
					variableCount += FSJumps_node_FloatSource.SetData((FSJumps)FloatSource, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FSRootAnim:
					FSRootAnimNode FSRootAnim_node_FloatSource = graph.AddNode<FSRootAnimNode>();
					GetPort("FloatSource").Connect(FSRootAnim_node_FloatSource.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FSRootAnim_node_FloatSource, assetPath);
					variableCount += FSRootAnim_node_FloatSource.SetData((FSRootAnim)FloatSource, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case FloatSource.TypeId.FSLastAtk:
					FSLastAtkNode FSLastAtk_node_FloatSource = graph.AddNode<FSLastAtkNode>();
					GetPort("FloatSource").Connect(FSLastAtk_node_FloatSource.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FSLastAtk_node_FloatSource, assetPath);
					variableCount += FSLastAtk_node_FloatSource.SetData((FSLastAtk)FloatSource, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
			}
			
			return variableCount;
		}
		
		public FloatSourceContainer GetData()
		{
			FloatSourceContainer objToReturn = new FloatSourceContainer();
			if (GetPort("FloatSource").ConnectionCount > 0)
			{
				FloatSourceNode FloatSource_Node = (FloatSourceNode)GetPort("FloatSource").GetConnection(0).node;
				switch (FloatSource_Node.TID)
				{
					case FloatSource.TypeId.FloatSource:
						FloatSourceNode FloatSource_FloatSource_Node = (FloatSourceNode)GetPort("FloatSource").GetConnection(0).node;
						objToReturn.FloatSource = FloatSource_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FSAgent:
						FSAgentNode FSAgent_FloatSource_Node = (FSAgentNode)GetPort("FloatSource").GetConnection(0).node;
						objToReturn.FloatSource = FSAgent_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FSBones:
						FSBonesNode FSBones_FloatSource_Node = (FSBonesNode)GetPort("FloatSource").GetConnection(0).node;
						objToReturn.FloatSource = FSBones_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FSAttack:
						FSAttackNode FSAttack_FloatSource_Node = (FSAttackNode)GetPort("FloatSource").GetConnection(0).node;
						objToReturn.FloatSource = FSAttack_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FSFrame:
						FSFrameNode FSFrame_FloatSource_Node = (FSFrameNode)GetPort("FloatSource").GetConnection(0).node;
						objToReturn.FloatSource = FSFrame_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FSInput:
						FSInputNode FSInput_FloatSource_Node = (FSInputNode)GetPort("FloatSource").GetConnection(0).node;
						objToReturn.FloatSource = FSInput_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FSFunc:
						FSFuncNode FSFunc_FloatSource_Node = (FSFuncNode)GetPort("FloatSource").GetConnection(0).node;
						objToReturn.FloatSource = FSFunc_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FSMovement:
						FSMovementNode FSMovement_FloatSource_Node = (FSMovementNode)GetPort("FloatSource").GetConnection(0).node;
						objToReturn.FloatSource = FSMovement_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FSCombat:
						FSCombatNode FSCombat_FloatSource_Node = (FSCombatNode)GetPort("FloatSource").GetConnection(0).node;
						objToReturn.FloatSource = FSCombat_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FSGrabs:
						FSGrabsNode FSGrabs_FloatSource_Node = (FSGrabsNode)GetPort("FloatSource").GetConnection(0).node;
						objToReturn.FloatSource = FSGrabs_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FSData:
						FSDataNode FSData_FloatSource_Node = (FSDataNode)GetPort("FloatSource").GetConnection(0).node;
						objToReturn.FloatSource = FSData_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FSScratch:
						FSScratchNode FSScratch_FloatSource_Node = (FSScratchNode)GetPort("FloatSource").GetConnection(0).node;
						objToReturn.FloatSource = FSScratch_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FSAnim:
						FSAnimNode FSAnim_FloatSource_Node = (FSAnimNode)GetPort("FloatSource").GetConnection(0).node;
						objToReturn.FloatSource = FSAnim_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FSSpeed:
						FSSpeedNode FSSpeed_FloatSource_Node = (FSSpeedNode)GetPort("FloatSource").GetConnection(0).node;
						objToReturn.FloatSource = FSSpeed_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FSPhysics:
						FSPhysicsNode FSPhysics_FloatSource_Node = (FSPhysicsNode)GetPort("FloatSource").GetConnection(0).node;
						objToReturn.FloatSource = FSPhysics_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FSCollision:
						FSCollisionNode FSCollision_FloatSource_Node = (FSCollisionNode)GetPort("FloatSource").GetConnection(0).node;
						objToReturn.FloatSource = FSCollision_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FSTimer:
						FSTimerNode FSTimer_FloatSource_Node = (FSTimerNode)GetPort("FloatSource").GetConnection(0).node;
						objToReturn.FloatSource = FSTimer_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FSLag:
						FSLagNode FSLag_FloatSource_Node = (FSLagNode)GetPort("FloatSource").GetConnection(0).node;
						objToReturn.FloatSource = FSLag_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FSEffects:
						FSEffectsNode FSEffects_FloatSource_Node = (FSEffectsNode)GetPort("FloatSource").GetConnection(0).node;
						objToReturn.FloatSource = FSEffects_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FSColors:
						FSColorsNode FSColors_FloatSource_Node = (FSColorsNode)GetPort("FloatSource").GetConnection(0).node;
						objToReturn.FloatSource = FSColors_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FSOnHit:
						FSOnHitNode FSOnHit_FloatSource_Node = (FSOnHitNode)GetPort("FloatSource").GetConnection(0).node;
						objToReturn.FloatSource = FSOnHit_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FSRandom:
						FSRandomNode FSRandom_FloatSource_Node = (FSRandomNode)GetPort("FloatSource").GetConnection(0).node;
						objToReturn.FloatSource = FSRandom_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FSCameraInfo:
						FSCameraInfoNode FSCameraInfo_FloatSource_Node = (FSCameraInfoNode)GetPort("FloatSource").GetConnection(0).node;
						objToReturn.FloatSource = FSCameraInfo_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FSSports:
						FSSportsNode FSSports_FloatSource_Node = (FSSportsNode)GetPort("FloatSource").GetConnection(0).node;
						objToReturn.FloatSource = FSSports_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FSVector2Mag:
						FSVector2MagNode FSVector2Mag_FloatSource_Node = (FSVector2MagNode)GetPort("FloatSource").GetConnection(0).node;
						objToReturn.FloatSource = FSVector2Mag_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FSCPUHelp:
						FSCPUHelpNode FSCPUHelp_FloatSource_Node = (FSCPUHelpNode)GetPort("FloatSource").GetConnection(0).node;
						objToReturn.FloatSource = FSCPUHelp_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FSItem:
						FSItemNode FSItem_FloatSource_Node = (FSItemNode)GetPort("FloatSource").GetConnection(0).node;
						objToReturn.FloatSource = FSItem_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FSMode:
						FSModeNode FSMode_FloatSource_Node = (FSModeNode)GetPort("FloatSource").GetConnection(0).node;
						objToReturn.FloatSource = FSMode_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FSJumps:
						FSJumpsNode FSJumps_FloatSource_Node = (FSJumpsNode)GetPort("FloatSource").GetConnection(0).node;
						objToReturn.FloatSource = FSJumps_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FSRootAnim:
						FSRootAnimNode FSRootAnim_FloatSource_Node = (FSRootAnimNode)GetPort("FloatSource").GetConnection(0).node;
						objToReturn.FloatSource = FSRootAnim_FloatSource_Node.GetData();
					break;
					case FloatSource.TypeId.FSLastAtk:
						FSLastAtkNode FSLastAtk_FloatSource_Node = (FSLastAtkNode)GetPort("FloatSource").GetConnection(0).node;
						objToReturn.FloatSource = FSLastAtk_FloatSource_Node.GetData();
					break;
				}
			}
			return objToReturn;
		}
	}
}

