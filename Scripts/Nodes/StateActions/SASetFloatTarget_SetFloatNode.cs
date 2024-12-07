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
	public class SASetFloatTarget_SetFloatNode : StateActionNode
	{
		[Input(connectionType = ConnectionType.Override)] public SASetFloatTarget.SetFloat NodeInput;
		public SASetFloatTarget.SetFloat.ManipWay Way;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer Target;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer Source;
		
		protected override void Init()
		{
			base.Init();
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SASetFloatTarget.SetFloat data, MovesetGraph graph, string assetPath, UnityEngine.Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SASetFloatTarget.SetFloat));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			Way = data.Way;
			Target = data.Target;
			
			FloatSourceContainerNode node_Target = graph.AddNode<FloatSourceContainerNode>();
			GetPort("Target").Connect(node_Target.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_Target, assetPath);
			variableCount += node_Target.SetData(Target, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			Source = data.Source;
			
			FloatSourceContainerNode node_Source = graph.AddNode<FloatSourceContainerNode>();
			GetPort("Source").Connect(node_Source.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_Source, assetPath);
			variableCount += node_Source.SetData(Source, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			
			return variableCount;
		}
		
		public SASetFloatTarget.SetFloat GetData()
		{
			SASetFloatTarget.SetFloat objToReturn = new SASetFloatTarget.SetFloat();
			objToReturn.Way = Way;
			if (GetPort("Target").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("Target").GetConnection(0).node;
				objToReturn.Target = FloatSourceContainer_Node.GetData();
			}
			if (GetPort("Source").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("Source").GetConnection(0).node;
				objToReturn.Source = FloatSourceContainer_Node.GetData();
			}
			return objToReturn;
		}
	}
}

