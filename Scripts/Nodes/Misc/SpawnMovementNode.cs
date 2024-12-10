// * 
// * 
// * This file was generated using NASB_Parser_to_xNode by megalon2d
// * https://github.com/megalon/NASB_Parser_to_xNode
// * 
// * 
using MovesetParser.BulkSerialize;
using MovesetParser.FloatSources;
using UnityEngine;
using UnityEditor;
using XNode;
using XNodeEditor;
using MovesetParser;
using MovesetParser.CheckThings;
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
using static MovesetParser.Misc.SpawnMovement;

namespace NASB_Moveset_Editor.Misc
{
	public class SpawnMovementNode : BaseMovesetNode
	{
		[Input(connectionType = ConnectionType.Override)] public SpawnMovement NodeInput;
		public string toBone;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer localOffsetX;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer localOffsetY;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer localOffsetZ;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer worldOffsetX;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer worldOffsetY;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer worldOffsetZ;
		[Output(connectionType = ConnectionType.Override)] public MovementConfig cfg;
		
		protected override void Init()
		{
			base.Init();
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SpawnMovement data, MovesetGraph graph, string assetPath, UnityEngine.Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SpawnMovement));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			toBone = data.toBone;
			localOffsetX = data.localOffsetX;
			
			FloatSourceContainerNode node_localOffsetX = graph.AddNode<FloatSourceContainerNode>();
			GetPort("localOffsetX").Connect(node_localOffsetX.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_localOffsetX, assetPath);
			variableCount += node_localOffsetX.SetData(localOffsetX, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			localOffsetY = data.localOffsetY;
			
			FloatSourceContainerNode node_localOffsetY = graph.AddNode<FloatSourceContainerNode>();
			GetPort("localOffsetY").Connect(node_localOffsetY.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_localOffsetY, assetPath);
			variableCount += node_localOffsetY.SetData(localOffsetY, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			localOffsetZ = data.localOffsetZ;
			
			FloatSourceContainerNode node_localOffsetZ = graph.AddNode<FloatSourceContainerNode>();
			GetPort("localOffsetZ").Connect(node_localOffsetZ.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_localOffsetZ, assetPath);
			variableCount += node_localOffsetZ.SetData(localOffsetZ, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			worldOffsetX = data.worldOffsetX;
			
			FloatSourceContainerNode node_worldOffsetX = graph.AddNode<FloatSourceContainerNode>();
			GetPort("worldOffsetX").Connect(node_worldOffsetX.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_worldOffsetX, assetPath);
			variableCount += node_worldOffsetX.SetData(worldOffsetX, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			worldOffsetY = data.worldOffsetY;
			
			FloatSourceContainerNode node_worldOffsetY = graph.AddNode<FloatSourceContainerNode>();
			GetPort("worldOffsetY").Connect(node_worldOffsetY.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_worldOffsetY, assetPath);
			variableCount += node_worldOffsetY.SetData(worldOffsetY, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			worldOffsetZ = data.worldOffsetZ;
			
			FloatSourceContainerNode node_worldOffsetZ = graph.AddNode<FloatSourceContainerNode>();
			GetPort("worldOffsetZ").Connect(node_worldOffsetZ.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_worldOffsetZ, assetPath);
			variableCount += node_worldOffsetZ.SetData(worldOffsetZ, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			cfg = data.cfg;
			
			MovementConfigNode node_cfg = graph.AddNode<MovementConfigNode>();
			GetPort("cfg").Connect(node_cfg.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_cfg, assetPath);
			variableCount += node_cfg.SetData(cfg, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			
			return variableCount;
		}
		
		public SpawnMovement GetData()
		{
			SpawnMovement objToReturn = new SpawnMovement();
			objToReturn.toBone = toBone;
			if (GetPort("localOffsetX").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("localOffsetX").GetConnection(0).node;
				objToReturn.localOffsetX = FloatSourceContainer_Node.GetData();
			}
			if (GetPort("localOffsetY").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("localOffsetY").GetConnection(0).node;
				objToReturn.localOffsetY = FloatSourceContainer_Node.GetData();
			}
			if (GetPort("localOffsetZ").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("localOffsetZ").GetConnection(0).node;
				objToReturn.localOffsetZ = FloatSourceContainer_Node.GetData();
			}
			if (GetPort("worldOffsetX").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("worldOffsetX").GetConnection(0).node;
				objToReturn.worldOffsetX = FloatSourceContainer_Node.GetData();
			}
			if (GetPort("worldOffsetY").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("worldOffsetY").GetConnection(0).node;
				objToReturn.worldOffsetY = FloatSourceContainer_Node.GetData();
			}
			if (GetPort("worldOffsetZ").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("worldOffsetZ").GetConnection(0).node;
				objToReturn.worldOffsetZ = FloatSourceContainer_Node.GetData();
			}
			if (GetPort("cfg").ConnectionCount > 0)
			{
				MovementConfigNode MovementConfig_Node = (MovementConfigNode)GetPort("cfg").GetConnection(0).node;
				objToReturn.cfg = MovementConfig_Node.GetData();
			}
			return objToReturn;
		}
	}
}

