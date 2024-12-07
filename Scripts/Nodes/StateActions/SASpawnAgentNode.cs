// * 
// * 
// * This file was generated using NASB_Parser_to_xNode by megalon2d
// * https://github.com/megalon/NASB_Parser_to_xNode
// * 
// * 
using MovesetParser.BulkSerialize;
using MovesetParser.FloatSources;
using MovesetParser.Misc;
using UnityEngine;
using UnityEditor;
using XNode;
using XNodeEditor;
using MovesetParser;
using MovesetParser.CheckThings;
using MovesetParser.Jumps;
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
	public class SASpawnAgentNode : StateActionNode
	{
		[Input(connectionType = ConnectionType.Override)] public StateAction NodeInput;
		public string Bank;
		public string Id;
		public string Bone;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer LocalOffsetX;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer LocalOffsetY;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer LocalOffsetZ;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer WorldOffsetX;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer WorldOffsetY;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer WorldOffsetZ;
		public bool CustomSpawnMovement;
		public SpawnMovement[] CustomSpawnMovements;
		[Output(connectionType = ConnectionType.Override)] public SAGUAMessageObject GuaMessageObject;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer ResultOrderAdded;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.SASpawnAgent;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SASpawnAgent data, MovesetGraph graph, string assetPath, UnityEngine.Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SASpawnAgent));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			Bank = data.Bank;
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
			
			CustomSpawnMovement = data.CustomSpawnMovement;
			CustomSpawnMovements = data.CustomSpawnMovements;
			GuaMessageObject = data.GuaMessageObject;
			
			SAGUAMessageObjectNode node_GuaMessageObject = graph.AddNode<SAGUAMessageObjectNode>();
			GetPort("GuaMessageObject").Connect(node_GuaMessageObject.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_GuaMessageObject, assetPath);
			variableCount += node_GuaMessageObject.SetData(GuaMessageObject, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			ResultOrderAdded = data.ResultOrderAdded;
			
			FloatSourceContainerNode node_ResultOrderAdded = graph.AddNode<FloatSourceContainerNode>();
			GetPort("ResultOrderAdded").Connect(node_ResultOrderAdded.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_ResultOrderAdded, assetPath);
			variableCount += node_ResultOrderAdded.SetData(ResultOrderAdded, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			
			return variableCount;
		}
		
		public new SASpawnAgent GetData()
		{
			SASpawnAgent objToReturn = new SASpawnAgent();
			objToReturn.TID = TypeId.SASpawnAgent;
			objToReturn.Bank = Bank;
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
			objToReturn.CustomSpawnMovement = CustomSpawnMovement;
			objToReturn.CustomSpawnMovements = CustomSpawnMovements;
			if (GetPort("GuaMessageObject").ConnectionCount > 0)
			{
				SAGUAMessageObjectNode SAGUAMessageObject_Node = (SAGUAMessageObjectNode)GetPort("GuaMessageObject").GetConnection(0).node;
				objToReturn.GuaMessageObject = SAGUAMessageObject_Node.GetData();
			}
			if (GetPort("ResultOrderAdded").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("ResultOrderAdded").GetConnection(0).node;
				objToReturn.ResultOrderAdded = FloatSourceContainer_Node.GetData();
			}
			return objToReturn;
		}
	}
}

