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
using static MovesetParser.StateActions.StateAction;

namespace NASB_Moveset_Editor.StateActions
{
	public class SASpawnFXNode : StateActionNode
	{
		[Input(connectionType = ConnectionType.Override)] public StateAction NodeInput;
		public string Id;
		public string Bone;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer LocalOffsetX;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer LocalOffsetY;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer LocalOffsetZ;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer WorldOffsetX;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer WorldOffsetY;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer WorldOffsetZ;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer DirX;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer DirY;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer DirZ;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer Scale;
		public bool Dynamic;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer DynamicX;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer DynamicY;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer DynamicZ;
		public bool Track;
		public bool BoneDirection;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.SASpawnFX;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SASpawnFX data, MovesetGraph graph, string assetPath, UnityEngine.Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SASpawnFX));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			Id = data.Id;
			Bone = data.Bone;
			LocalOffsetX = data.LocalOffsetX;
			
			FloatSourceContainerNode node_LocalOffsetX = graph.AddNode<FloatSourceContainerNode>();
			GetPort("LocalOffsetX").Connect(node_LocalOffsetX.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_LocalOffsetX, assetPath);
			variableCount += node_LocalOffsetX.SetData(LocalOffsetX, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			LocalOffsetY = data.LocalOffsetY;
			
			FloatSourceContainerNode node_LocalOffsetY = graph.AddNode<FloatSourceContainerNode>();
			GetPort("LocalOffsetY").Connect(node_LocalOffsetY.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_LocalOffsetY, assetPath);
			variableCount += node_LocalOffsetY.SetData(LocalOffsetY, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			LocalOffsetZ = data.LocalOffsetZ;
			
			FloatSourceContainerNode node_LocalOffsetZ = graph.AddNode<FloatSourceContainerNode>();
			GetPort("LocalOffsetZ").Connect(node_LocalOffsetZ.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_LocalOffsetZ, assetPath);
			variableCount += node_LocalOffsetZ.SetData(LocalOffsetZ, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			WorldOffsetX = data.WorldOffsetX;
			
			FloatSourceContainerNode node_WorldOffsetX = graph.AddNode<FloatSourceContainerNode>();
			GetPort("WorldOffsetX").Connect(node_WorldOffsetX.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_WorldOffsetX, assetPath);
			variableCount += node_WorldOffsetX.SetData(WorldOffsetX, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			WorldOffsetY = data.WorldOffsetY;
			
			FloatSourceContainerNode node_WorldOffsetY = graph.AddNode<FloatSourceContainerNode>();
			GetPort("WorldOffsetY").Connect(node_WorldOffsetY.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_WorldOffsetY, assetPath);
			variableCount += node_WorldOffsetY.SetData(WorldOffsetY, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			WorldOffsetZ = data.WorldOffsetZ;
			
			FloatSourceContainerNode node_WorldOffsetZ = graph.AddNode<FloatSourceContainerNode>();
			GetPort("WorldOffsetZ").Connect(node_WorldOffsetZ.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_WorldOffsetZ, assetPath);
			variableCount += node_WorldOffsetZ.SetData(WorldOffsetZ, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			DirX = data.DirX;
			
			FloatSourceContainerNode node_DirX = graph.AddNode<FloatSourceContainerNode>();
			GetPort("DirX").Connect(node_DirX.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_DirX, assetPath);
			variableCount += node_DirX.SetData(DirX, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			DirY = data.DirY;
			
			FloatSourceContainerNode node_DirY = graph.AddNode<FloatSourceContainerNode>();
			GetPort("DirY").Connect(node_DirY.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_DirY, assetPath);
			variableCount += node_DirY.SetData(DirY, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			DirZ = data.DirZ;
			
			FloatSourceContainerNode node_DirZ = graph.AddNode<FloatSourceContainerNode>();
			GetPort("DirZ").Connect(node_DirZ.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_DirZ, assetPath);
			variableCount += node_DirZ.SetData(DirZ, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			Scale = data.Scale;
			
			FloatSourceContainerNode node_Scale = graph.AddNode<FloatSourceContainerNode>();
			GetPort("Scale").Connect(node_Scale.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_Scale, assetPath);
			variableCount += node_Scale.SetData(Scale, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			Dynamic = data.Dynamic;
			DynamicX = data.DynamicX;
			
			FloatSourceContainerNode node_DynamicX = graph.AddNode<FloatSourceContainerNode>();
			GetPort("DynamicX").Connect(node_DynamicX.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_DynamicX, assetPath);
			variableCount += node_DynamicX.SetData(DynamicX, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			DynamicY = data.DynamicY;
			
			FloatSourceContainerNode node_DynamicY = graph.AddNode<FloatSourceContainerNode>();
			GetPort("DynamicY").Connect(node_DynamicY.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_DynamicY, assetPath);
			variableCount += node_DynamicY.SetData(DynamicY, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			DynamicZ = data.DynamicZ;
			
			FloatSourceContainerNode node_DynamicZ = graph.AddNode<FloatSourceContainerNode>();
			GetPort("DynamicZ").Connect(node_DynamicZ.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_DynamicZ, assetPath);
			variableCount += node_DynamicZ.SetData(DynamicZ, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			Track = data.Track;
			BoneDirection = data.BoneDirection;
			return variableCount;
		}
		
		public new SASpawnFX GetData()
		{
			SASpawnFX objToReturn = new SASpawnFX();
			objToReturn.TID = TypeId.SASpawnFX;
			objToReturn.Id = Id;
			objToReturn.Bone = Bone;
			if (GetPort("LocalOffsetX").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("LocalOffsetX").GetConnection(0).node;
				objToReturn.LocalOffsetX = FloatSourceContainer_Node.GetData();
			}
			if (GetPort("LocalOffsetY").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("LocalOffsetY").GetConnection(0).node;
				objToReturn.LocalOffsetY = FloatSourceContainer_Node.GetData();
			}
			if (GetPort("LocalOffsetZ").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("LocalOffsetZ").GetConnection(0).node;
				objToReturn.LocalOffsetZ = FloatSourceContainer_Node.GetData();
			}
			if (GetPort("WorldOffsetX").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("WorldOffsetX").GetConnection(0).node;
				objToReturn.WorldOffsetX = FloatSourceContainer_Node.GetData();
			}
			if (GetPort("WorldOffsetY").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("WorldOffsetY").GetConnection(0).node;
				objToReturn.WorldOffsetY = FloatSourceContainer_Node.GetData();
			}
			if (GetPort("WorldOffsetZ").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("WorldOffsetZ").GetConnection(0).node;
				objToReturn.WorldOffsetZ = FloatSourceContainer_Node.GetData();
			}
			if (GetPort("DirX").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("DirX").GetConnection(0).node;
				objToReturn.DirX = FloatSourceContainer_Node.GetData();
			}
			if (GetPort("DirY").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("DirY").GetConnection(0).node;
				objToReturn.DirY = FloatSourceContainer_Node.GetData();
			}
			if (GetPort("DirZ").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("DirZ").GetConnection(0).node;
				objToReturn.DirZ = FloatSourceContainer_Node.GetData();
			}
			if (GetPort("Scale").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("Scale").GetConnection(0).node;
				objToReturn.Scale = FloatSourceContainer_Node.GetData();
			}
			objToReturn.Dynamic = Dynamic;
			if (GetPort("DynamicX").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("DynamicX").GetConnection(0).node;
				objToReturn.DynamicX = FloatSourceContainer_Node.GetData();
			}
			if (GetPort("DynamicY").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("DynamicY").GetConnection(0).node;
				objToReturn.DynamicY = FloatSourceContainer_Node.GetData();
			}
			if (GetPort("DynamicZ").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("DynamicZ").GetConnection(0).node;
				objToReturn.DynamicZ = FloatSourceContainer_Node.GetData();
			}
			objToReturn.Track = Track;
			objToReturn.BoneDirection = BoneDirection;
			return objToReturn;
		}
	}
}

