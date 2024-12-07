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
	public class SAStandardInputNode : StateActionNode
	{
		[Input(connectionType = ConnectionType.Override)] public StateAction NodeInput;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer Frames;
		public bool ForceCheck;
		[Output(connectionType = ConnectionType.Override)] public StandardInputTriggerConfig Config;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.SAStandardInput;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SAStandardInput data, MovesetGraph graph, string assetPath, UnityEngine.Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SAStandardInput));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			Frames = data.Frames;
			
			FloatSourceContainerNode node_Frames = graph.AddNode<FloatSourceContainerNode>();
			GetPort("Frames").Connect(node_Frames.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_Frames, assetPath);
			variableCount += node_Frames.SetData(Frames, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			ForceCheck = data.ForceCheck;
			Config = data.Config;
			
			StandardInputTriggerConfigNode node_Config = graph.AddNode<StandardInputTriggerConfigNode>();
			GetPort("Config").Connect(node_Config.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_Config, assetPath);
			variableCount += node_Config.SetData(Config, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			
			return variableCount;
		}
		
		public new SAStandardInput GetData()
		{
			SAStandardInput objToReturn = new SAStandardInput();
			objToReturn.TID = TypeId.SAStandardInput;
			if (GetPort("Frames").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("Frames").GetConnection(0).node;
				objToReturn.Frames = FloatSourceContainer_Node.GetData();
			}
			objToReturn.ForceCheck = ForceCheck;
			if (GetPort("Config").ConnectionCount > 0)
			{
				StandardInputTriggerConfigNode StandardInputTriggerConfig_Node = (StandardInputTriggerConfigNode)GetPort("Config").GetConnection(0).node;
				objToReturn.Config = StandardInputTriggerConfig_Node.GetData();
			}
			return objToReturn;
		}
	}
}

