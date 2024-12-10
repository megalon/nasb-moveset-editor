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

namespace NASB_Moveset_Editor.StateActions
{
	public class SASpawnAgent2_AddedSpawnedDataNode : StateActionNode
	{
		[Input(connectionType = ConnectionType.Override)] public SASpawnAgent2.AddedSpawnedData NodeInput;
		public string spawnedAgentDataId;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer spawnedAgentDataSetValue;
		
		protected override void Init()
		{
			base.Init();
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SASpawnAgent2.AddedSpawnedData data, MovesetGraph graph, string assetPath, UnityEngine.Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SASpawnAgent2.AddedSpawnedData));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			spawnedAgentDataId = data.spawnedAgentDataId;
			spawnedAgentDataSetValue = data.spawnedAgentDataSetValue;
			
			FloatSourceContainerNode node_spawnedAgentDataSetValue = graph.AddNode<FloatSourceContainerNode>();
			GetPort("spawnedAgentDataSetValue").Connect(node_spawnedAgentDataSetValue.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_spawnedAgentDataSetValue, assetPath);
			variableCount += node_spawnedAgentDataSetValue.SetData(spawnedAgentDataSetValue, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			
			return variableCount;
		}
		
		public SASpawnAgent2.AddedSpawnedData GetData()
		{
			SASpawnAgent2.AddedSpawnedData objToReturn = new SASpawnAgent2.AddedSpawnedData();
			objToReturn.spawnedAgentDataId = spawnedAgentDataId;
			if (GetPort("spawnedAgentDataSetValue").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("spawnedAgentDataSetValue").GetConnection(0).node;
				objToReturn.spawnedAgentDataSetValue = FloatSourceContainer_Node.GetData();
			}
			return objToReturn;
		}
	}
}

