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
	public class SACameraShakeNode : StateActionNode
	{
		[Input(connectionType = ConnectionType.Override)] public StateAction NodeInput;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer Shake;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer Intensity;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.SACameraShake;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SACameraShake data, MovesetGraph graph, string assetPath, UnityEngine.Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SACameraShake));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			Shake = data.Shake;
			
			FloatSourceContainerNode node_Shake = graph.AddNode<FloatSourceContainerNode>();
			GetPort("Shake").Connect(node_Shake.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_Shake, assetPath);
			variableCount += node_Shake.SetData(Shake, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			Intensity = data.Intensity;
			
			FloatSourceContainerNode node_Intensity = graph.AddNode<FloatSourceContainerNode>();
			GetPort("Intensity").Connect(node_Intensity.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_Intensity, assetPath);
			variableCount += node_Intensity.SetData(Intensity, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			
			return variableCount;
		}
		
		public new SACameraShake GetData()
		{
			SACameraShake objToReturn = new SACameraShake();
			objToReturn.TID = TypeId.SACameraShake;
			if (GetPort("Shake").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("Shake").GetConnection(0).node;
				objToReturn.Shake = FloatSourceContainer_Node.GetData();
			}
			if (GetPort("Intensity").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("Intensity").GetConnection(0).node;
				objToReturn.Intensity = FloatSourceContainer_Node.GetData();
			}
			return objToReturn;
		}
	}
}

