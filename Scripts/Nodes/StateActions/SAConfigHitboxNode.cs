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
	public class SAConfigHitboxNode : StateActionNode
	{
		[Input(connectionType = ConnectionType.Override)] public StateAction NodeInput;
		public int Hitbox;
		public string Prop;
		public string Bone;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer Radius;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer LocalOffsetX;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer LocalOffsetY;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer LocalOffsetZ;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer WorldOffsetX;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer WorldOffsetY;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer WorldOffsetZ;
		public string FxId;
		public string SfxId;
		public bool Inactive;
		public bool SecondTrack;
		public string Bone2nd;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer LocalOffset2ndX;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer LocalOffset2ndY;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer LocalOffset2ndZ;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer WorldOffset2ndX;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer WorldOffset2ndY;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer WorldOffset2ndZ;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.SAConfigHitbox;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SAConfigHitbox data, MovesetGraph graph, string assetPath, UnityEngine.Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SAConfigHitbox));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			Hitbox = data.Hitbox;
			Prop = data.Prop;
			Bone = data.Bone;
			Radius = data.Radius;
			
			FloatSourceContainerNode node_Radius = graph.AddNode<FloatSourceContainerNode>();
			GetPort("Radius").Connect(node_Radius.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_Radius, assetPath);
			variableCount += node_Radius.SetData(Radius, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
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
			
			FxId = data.FxId;
			SfxId = data.SfxId;
			Inactive = data.Inactive;
			SecondTrack = data.SecondTrack;
			Bone2nd = data.Bone2nd;
			LocalOffset2ndX = data.LocalOffset2ndX;
			
			FloatSourceContainerNode node_LocalOffset2ndX = graph.AddNode<FloatSourceContainerNode>();
			GetPort("LocalOffset2ndX").Connect(node_LocalOffset2ndX.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_LocalOffset2ndX, assetPath);
			variableCount += node_LocalOffset2ndX.SetData(LocalOffset2ndX, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			LocalOffset2ndY = data.LocalOffset2ndY;
			
			FloatSourceContainerNode node_LocalOffset2ndY = graph.AddNode<FloatSourceContainerNode>();
			GetPort("LocalOffset2ndY").Connect(node_LocalOffset2ndY.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_LocalOffset2ndY, assetPath);
			variableCount += node_LocalOffset2ndY.SetData(LocalOffset2ndY, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			LocalOffset2ndZ = data.LocalOffset2ndZ;
			
			FloatSourceContainerNode node_LocalOffset2ndZ = graph.AddNode<FloatSourceContainerNode>();
			GetPort("LocalOffset2ndZ").Connect(node_LocalOffset2ndZ.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_LocalOffset2ndZ, assetPath);
			variableCount += node_LocalOffset2ndZ.SetData(LocalOffset2ndZ, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			WorldOffset2ndX = data.WorldOffset2ndX;
			
			FloatSourceContainerNode node_WorldOffset2ndX = graph.AddNode<FloatSourceContainerNode>();
			GetPort("WorldOffset2ndX").Connect(node_WorldOffset2ndX.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_WorldOffset2ndX, assetPath);
			variableCount += node_WorldOffset2ndX.SetData(WorldOffset2ndX, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			WorldOffset2ndY = data.WorldOffset2ndY;
			
			FloatSourceContainerNode node_WorldOffset2ndY = graph.AddNode<FloatSourceContainerNode>();
			GetPort("WorldOffset2ndY").Connect(node_WorldOffset2ndY.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_WorldOffset2ndY, assetPath);
			variableCount += node_WorldOffset2ndY.SetData(WorldOffset2ndY, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			WorldOffset2ndZ = data.WorldOffset2ndZ;
			
			FloatSourceContainerNode node_WorldOffset2ndZ = graph.AddNode<FloatSourceContainerNode>();
			GetPort("WorldOffset2ndZ").Connect(node_WorldOffset2ndZ.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_WorldOffset2ndZ, assetPath);
			variableCount += node_WorldOffset2ndZ.SetData(WorldOffset2ndZ, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			
			return variableCount;
		}
		
		public new SAConfigHitbox GetData()
		{
			SAConfigHitbox objToReturn = new SAConfigHitbox();
			objToReturn.TID = TypeId.SAConfigHitbox;
			objToReturn.Hitbox = Hitbox;
			objToReturn.Prop = Prop;
			objToReturn.Bone = Bone;
			if (GetPort("Radius").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("Radius").GetConnection(0).node;
				objToReturn.Radius = FloatSourceContainer_Node.GetData();
			}
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
			objToReturn.FxId = FxId;
			objToReturn.SfxId = SfxId;
			objToReturn.Inactive = Inactive;
			objToReturn.SecondTrack = SecondTrack;
			objToReturn.Bone2nd = Bone2nd;
			if (GetPort("LocalOffset2ndX").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("LocalOffset2ndX").GetConnection(0).node;
				objToReturn.LocalOffset2ndX = FloatSourceContainer_Node.GetData();
			}
			if (GetPort("LocalOffset2ndY").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("LocalOffset2ndY").GetConnection(0).node;
				objToReturn.LocalOffset2ndY = FloatSourceContainer_Node.GetData();
			}
			if (GetPort("LocalOffset2ndZ").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("LocalOffset2ndZ").GetConnection(0).node;
				objToReturn.LocalOffset2ndZ = FloatSourceContainer_Node.GetData();
			}
			if (GetPort("WorldOffset2ndX").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("WorldOffset2ndX").GetConnection(0).node;
				objToReturn.WorldOffset2ndX = FloatSourceContainer_Node.GetData();
			}
			if (GetPort("WorldOffset2ndY").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("WorldOffset2ndY").GetConnection(0).node;
				objToReturn.WorldOffset2ndY = FloatSourceContainer_Node.GetData();
			}
			if (GetPort("WorldOffset2ndZ").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("WorldOffset2ndZ").GetConnection(0).node;
				objToReturn.WorldOffset2ndZ = FloatSourceContainer_Node.GetData();
			}
			return objToReturn;
		}
	}
}

