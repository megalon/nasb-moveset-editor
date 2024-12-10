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

namespace NASB_Moveset_Editor.Misc
{
	public class HurtSetSetup_HurtBoneNode : BaseMovesetNode
	{
		[Input(connectionType = ConnectionType.Override)] public HurtSetSetup.HurtBone NodeInput;
		public HurtType type;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer armor;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer knockbackarmor;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer radius;
		public bool ignoregrab;
		public string bone_a;
		public string bone_b;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer localOffsetAX;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer localOffsetAY;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer localOffsetAZ;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer worldOffsetAX;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer worldOffsetAY;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer worldOffsetAZ;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer localOffsetBX;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer localOffsetBY;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer localOffsetBZ;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer worldOffsetBX;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer worldOffsetBY;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer worldOffsetBZ;
		
		protected override void Init()
		{
			base.Init();
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(HurtSetSetup.HurtBone data, MovesetGraph graph, string assetPath, UnityEngine.Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(HurtSetSetup.HurtBone));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			type = data.type;
			armor = data.armor;
			
			FloatSourceContainerNode node_armor = graph.AddNode<FloatSourceContainerNode>();
			GetPort("armor").Connect(node_armor.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_armor, assetPath);
			variableCount += node_armor.SetData(armor, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			knockbackarmor = data.knockbackarmor;
			
			FloatSourceContainerNode node_knockbackarmor = graph.AddNode<FloatSourceContainerNode>();
			GetPort("knockbackarmor").Connect(node_knockbackarmor.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_knockbackarmor, assetPath);
			variableCount += node_knockbackarmor.SetData(knockbackarmor, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			radius = data.radius;
			
			FloatSourceContainerNode node_radius = graph.AddNode<FloatSourceContainerNode>();
			GetPort("radius").Connect(node_radius.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_radius, assetPath);
			variableCount += node_radius.SetData(radius, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			ignoregrab = data.ignoregrab;
			bone_a = data.bone_a;
			bone_b = data.bone_b;
			localOffsetAX = data.localOffsetAX;
			
			FloatSourceContainerNode node_localOffsetAX = graph.AddNode<FloatSourceContainerNode>();
			GetPort("localOffsetAX").Connect(node_localOffsetAX.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_localOffsetAX, assetPath);
			variableCount += node_localOffsetAX.SetData(localOffsetAX, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			localOffsetAY = data.localOffsetAY;
			
			FloatSourceContainerNode node_localOffsetAY = graph.AddNode<FloatSourceContainerNode>();
			GetPort("localOffsetAY").Connect(node_localOffsetAY.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_localOffsetAY, assetPath);
			variableCount += node_localOffsetAY.SetData(localOffsetAY, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			localOffsetAZ = data.localOffsetAZ;
			
			FloatSourceContainerNode node_localOffsetAZ = graph.AddNode<FloatSourceContainerNode>();
			GetPort("localOffsetAZ").Connect(node_localOffsetAZ.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_localOffsetAZ, assetPath);
			variableCount += node_localOffsetAZ.SetData(localOffsetAZ, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			worldOffsetAX = data.worldOffsetAX;
			
			FloatSourceContainerNode node_worldOffsetAX = graph.AddNode<FloatSourceContainerNode>();
			GetPort("worldOffsetAX").Connect(node_worldOffsetAX.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_worldOffsetAX, assetPath);
			variableCount += node_worldOffsetAX.SetData(worldOffsetAX, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			worldOffsetAY = data.worldOffsetAY;
			
			FloatSourceContainerNode node_worldOffsetAY = graph.AddNode<FloatSourceContainerNode>();
			GetPort("worldOffsetAY").Connect(node_worldOffsetAY.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_worldOffsetAY, assetPath);
			variableCount += node_worldOffsetAY.SetData(worldOffsetAY, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			worldOffsetAZ = data.worldOffsetAZ;
			
			FloatSourceContainerNode node_worldOffsetAZ = graph.AddNode<FloatSourceContainerNode>();
			GetPort("worldOffsetAZ").Connect(node_worldOffsetAZ.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_worldOffsetAZ, assetPath);
			variableCount += node_worldOffsetAZ.SetData(worldOffsetAZ, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			localOffsetBX = data.localOffsetBX;
			
			FloatSourceContainerNode node_localOffsetBX = graph.AddNode<FloatSourceContainerNode>();
			GetPort("localOffsetBX").Connect(node_localOffsetBX.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_localOffsetBX, assetPath);
			variableCount += node_localOffsetBX.SetData(localOffsetBX, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			localOffsetBY = data.localOffsetBY;
			
			FloatSourceContainerNode node_localOffsetBY = graph.AddNode<FloatSourceContainerNode>();
			GetPort("localOffsetBY").Connect(node_localOffsetBY.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_localOffsetBY, assetPath);
			variableCount += node_localOffsetBY.SetData(localOffsetBY, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			localOffsetBZ = data.localOffsetBZ;
			
			FloatSourceContainerNode node_localOffsetBZ = graph.AddNode<FloatSourceContainerNode>();
			GetPort("localOffsetBZ").Connect(node_localOffsetBZ.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_localOffsetBZ, assetPath);
			variableCount += node_localOffsetBZ.SetData(localOffsetBZ, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			worldOffsetBX = data.worldOffsetBX;
			
			FloatSourceContainerNode node_worldOffsetBX = graph.AddNode<FloatSourceContainerNode>();
			GetPort("worldOffsetBX").Connect(node_worldOffsetBX.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_worldOffsetBX, assetPath);
			variableCount += node_worldOffsetBX.SetData(worldOffsetBX, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			worldOffsetBY = data.worldOffsetBY;
			
			FloatSourceContainerNode node_worldOffsetBY = graph.AddNode<FloatSourceContainerNode>();
			GetPort("worldOffsetBY").Connect(node_worldOffsetBY.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_worldOffsetBY, assetPath);
			variableCount += node_worldOffsetBY.SetData(worldOffsetBY, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			worldOffsetBZ = data.worldOffsetBZ;
			
			FloatSourceContainerNode node_worldOffsetBZ = graph.AddNode<FloatSourceContainerNode>();
			GetPort("worldOffsetBZ").Connect(node_worldOffsetBZ.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_worldOffsetBZ, assetPath);
			variableCount += node_worldOffsetBZ.SetData(worldOffsetBZ, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			
			return variableCount;
		}
		
		public HurtSetSetup.HurtBone GetData()
		{
			HurtSetSetup.HurtBone objToReturn = new HurtSetSetup.HurtBone();
			objToReturn.type = type;
			if (GetPort("armor").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("armor").GetConnection(0).node;
				objToReturn.armor = FloatSourceContainer_Node.GetData();
			}
			if (GetPort("knockbackarmor").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("knockbackarmor").GetConnection(0).node;
				objToReturn.knockbackarmor = FloatSourceContainer_Node.GetData();
			}
			if (GetPort("radius").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("radius").GetConnection(0).node;
				objToReturn.radius = FloatSourceContainer_Node.GetData();
			}
			objToReturn.ignoregrab = ignoregrab;
			objToReturn.bone_a = bone_a;
			objToReturn.bone_b = bone_b;
			if (GetPort("localOffsetAX").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("localOffsetAX").GetConnection(0).node;
				objToReturn.localOffsetAX = FloatSourceContainer_Node.GetData();
			}
			if (GetPort("localOffsetAY").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("localOffsetAY").GetConnection(0).node;
				objToReturn.localOffsetAY = FloatSourceContainer_Node.GetData();
			}
			if (GetPort("localOffsetAZ").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("localOffsetAZ").GetConnection(0).node;
				objToReturn.localOffsetAZ = FloatSourceContainer_Node.GetData();
			}
			if (GetPort("worldOffsetAX").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("worldOffsetAX").GetConnection(0).node;
				objToReturn.worldOffsetAX = FloatSourceContainer_Node.GetData();
			}
			if (GetPort("worldOffsetAY").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("worldOffsetAY").GetConnection(0).node;
				objToReturn.worldOffsetAY = FloatSourceContainer_Node.GetData();
			}
			if (GetPort("worldOffsetAZ").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("worldOffsetAZ").GetConnection(0).node;
				objToReturn.worldOffsetAZ = FloatSourceContainer_Node.GetData();
			}
			if (GetPort("localOffsetBX").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("localOffsetBX").GetConnection(0).node;
				objToReturn.localOffsetBX = FloatSourceContainer_Node.GetData();
			}
			if (GetPort("localOffsetBY").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("localOffsetBY").GetConnection(0).node;
				objToReturn.localOffsetBY = FloatSourceContainer_Node.GetData();
			}
			if (GetPort("localOffsetBZ").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("localOffsetBZ").GetConnection(0).node;
				objToReturn.localOffsetBZ = FloatSourceContainer_Node.GetData();
			}
			if (GetPort("worldOffsetBX").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("worldOffsetBX").GetConnection(0).node;
				objToReturn.worldOffsetBX = FloatSourceContainer_Node.GetData();
			}
			if (GetPort("worldOffsetBY").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("worldOffsetBY").GetConnection(0).node;
				objToReturn.worldOffsetBY = FloatSourceContainer_Node.GetData();
			}
			if (GetPort("worldOffsetBZ").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("worldOffsetBZ").GetConnection(0).node;
				objToReturn.worldOffsetBZ = FloatSourceContainer_Node.GetData();
			}
			return objToReturn;
		}
	}
}

