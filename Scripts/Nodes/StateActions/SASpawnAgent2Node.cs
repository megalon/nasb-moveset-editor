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
using static MovesetParser.StateActions.SASpawnAgent2;

namespace NASB_Moveset_Editor.StateActions
{
	public class SASpawnAgent2Node : StateActionNode
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
		public string SpawnedAgentDataId;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer SpawnedAgentDataSetValue;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer ResultOrderAdded;
		public bool SetPlayerIndex;
		public bool SetAttackTeam;
		public bool SetDefendTeam;
		public bool SetProjectileLevel;
		public bool SetDirection;
		public bool SetRedirect;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer PlayerIndex;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer AttackTeam;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer DefendTeam;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer ProjectileLevel;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer Direction;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer RedirectX;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer RedirectY;
		public bool ExactSpawn;
		public AddedSpawnedData[] AddedSpawnedDatas;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.SASpawnAgent2;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SASpawnAgent2 data, MovesetGraph graph, string assetPath, UnityEngine.Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SASpawnAgent2));
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
			SpawnedAgentDataId = data.SpawnedAgentDataId;
			SpawnedAgentDataSetValue = data.SpawnedAgentDataSetValue;
			
			FloatSourceContainerNode node_SpawnedAgentDataSetValue = graph.AddNode<FloatSourceContainerNode>();
			GetPort("SpawnedAgentDataSetValue").Connect(node_SpawnedAgentDataSetValue.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_SpawnedAgentDataSetValue, assetPath);
			variableCount += node_SpawnedAgentDataSetValue.SetData(SpawnedAgentDataSetValue, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			ResultOrderAdded = data.ResultOrderAdded;
			
			FloatSourceContainerNode node_ResultOrderAdded = graph.AddNode<FloatSourceContainerNode>();
			GetPort("ResultOrderAdded").Connect(node_ResultOrderAdded.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_ResultOrderAdded, assetPath);
			variableCount += node_ResultOrderAdded.SetData(ResultOrderAdded, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			SetPlayerIndex = data.SetPlayerIndex;
			SetAttackTeam = data.SetAttackTeam;
			SetDefendTeam = data.SetDefendTeam;
			SetProjectileLevel = data.SetProjectileLevel;
			SetDirection = data.SetDirection;
			SetRedirect = data.SetRedirect;
			PlayerIndex = data.PlayerIndex;
			
			FloatSourceContainerNode node_PlayerIndex = graph.AddNode<FloatSourceContainerNode>();
			GetPort("PlayerIndex").Connect(node_PlayerIndex.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_PlayerIndex, assetPath);
			variableCount += node_PlayerIndex.SetData(PlayerIndex, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			AttackTeam = data.AttackTeam;
			
			FloatSourceContainerNode node_AttackTeam = graph.AddNode<FloatSourceContainerNode>();
			GetPort("AttackTeam").Connect(node_AttackTeam.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_AttackTeam, assetPath);
			variableCount += node_AttackTeam.SetData(AttackTeam, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			DefendTeam = data.DefendTeam;
			
			FloatSourceContainerNode node_DefendTeam = graph.AddNode<FloatSourceContainerNode>();
			GetPort("DefendTeam").Connect(node_DefendTeam.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_DefendTeam, assetPath);
			variableCount += node_DefendTeam.SetData(DefendTeam, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			ProjectileLevel = data.ProjectileLevel;
			
			FloatSourceContainerNode node_ProjectileLevel = graph.AddNode<FloatSourceContainerNode>();
			GetPort("ProjectileLevel").Connect(node_ProjectileLevel.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_ProjectileLevel, assetPath);
			variableCount += node_ProjectileLevel.SetData(ProjectileLevel, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			Direction = data.Direction;
			
			FloatSourceContainerNode node_Direction = graph.AddNode<FloatSourceContainerNode>();
			GetPort("Direction").Connect(node_Direction.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_Direction, assetPath);
			variableCount += node_Direction.SetData(Direction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			RedirectX = data.RedirectX;
			
			FloatSourceContainerNode node_RedirectX = graph.AddNode<FloatSourceContainerNode>();
			GetPort("RedirectX").Connect(node_RedirectX.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_RedirectX, assetPath);
			variableCount += node_RedirectX.SetData(RedirectX, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			RedirectY = data.RedirectY;
			
			FloatSourceContainerNode node_RedirectY = graph.AddNode<FloatSourceContainerNode>();
			GetPort("RedirectY").Connect(node_RedirectY.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_RedirectY, assetPath);
			variableCount += node_RedirectY.SetData(RedirectY, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			ExactSpawn = data.ExactSpawn;
			AddedSpawnedDatas = data.AddedSpawnedDatas;
			return variableCount;
		}
		
		public new SASpawnAgent2 GetData()
		{
			SASpawnAgent2 objToReturn = new SASpawnAgent2();
			objToReturn.TID = TypeId.SASpawnAgent2;
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
			objToReturn.SpawnedAgentDataId = SpawnedAgentDataId;
			if (GetPort("SpawnedAgentDataSetValue").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("SpawnedAgentDataSetValue").GetConnection(0).node;
				objToReturn.SpawnedAgentDataSetValue = FloatSourceContainer_Node.GetData();
			}
			if (GetPort("ResultOrderAdded").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("ResultOrderAdded").GetConnection(0).node;
				objToReturn.ResultOrderAdded = FloatSourceContainer_Node.GetData();
			}
			objToReturn.SetPlayerIndex = SetPlayerIndex;
			objToReturn.SetAttackTeam = SetAttackTeam;
			objToReturn.SetDefendTeam = SetDefendTeam;
			objToReturn.SetProjectileLevel = SetProjectileLevel;
			objToReturn.SetDirection = SetDirection;
			objToReturn.SetRedirect = SetRedirect;
			if (GetPort("PlayerIndex").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("PlayerIndex").GetConnection(0).node;
				objToReturn.PlayerIndex = FloatSourceContainer_Node.GetData();
			}
			if (GetPort("AttackTeam").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("AttackTeam").GetConnection(0).node;
				objToReturn.AttackTeam = FloatSourceContainer_Node.GetData();
			}
			if (GetPort("DefendTeam").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("DefendTeam").GetConnection(0).node;
				objToReturn.DefendTeam = FloatSourceContainer_Node.GetData();
			}
			if (GetPort("ProjectileLevel").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("ProjectileLevel").GetConnection(0).node;
				objToReturn.ProjectileLevel = FloatSourceContainer_Node.GetData();
			}
			if (GetPort("Direction").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("Direction").GetConnection(0).node;
				objToReturn.Direction = FloatSourceContainer_Node.GetData();
			}
			if (GetPort("RedirectX").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("RedirectX").GetConnection(0).node;
				objToReturn.RedirectX = FloatSourceContainer_Node.GetData();
			}
			if (GetPort("RedirectY").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("RedirectY").GetConnection(0).node;
				objToReturn.RedirectY = FloatSourceContainer_Node.GetData();
			}
			objToReturn.ExactSpawn = ExactSpawn;
			objToReturn.AddedSpawnedDatas = AddedSpawnedDatas;
			return objToReturn;
		}
	}
}

