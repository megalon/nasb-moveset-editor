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
	public class SAManipDecorChainNode : StateActionNode
	{
		[Input(connectionType = ConnectionType.Override)] public StateAction NodeInput;
		public int ManipIndex;
		public MovesetParser.StateActions.SAManipDecorChain.Manip ManipType;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer MaxDistEnds;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.SAManipDecorChain;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SAManipDecorChain data, MovesetGraph graph, string assetPath, UnityEngine.Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SAManipDecorChain));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			ManipIndex = data.ManipIndex;
			ManipType = data.ManipType;
			MaxDistEnds = data.MaxDistEnds;
			
			FloatSourceContainerNode node_MaxDistEnds = graph.AddNode<FloatSourceContainerNode>();
			GetPort("MaxDistEnds").Connect(node_MaxDistEnds.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_MaxDistEnds, assetPath);
			variableCount += node_MaxDistEnds.SetData(MaxDistEnds, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			
			return variableCount;
		}
		
		public new SAManipDecorChain GetData()
		{
			SAManipDecorChain objToReturn = new SAManipDecorChain();
			objToReturn.TID = TypeId.SAManipDecorChain;
			objToReturn.ManipIndex = ManipIndex;
			objToReturn.ManipType = ManipType;
			if (GetPort("MaxDistEnds").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("MaxDistEnds").GetConnection(0).node;
				objToReturn.MaxDistEnds = FloatSourceContainer_Node.GetData();
			}
			return objToReturn;
		}
	}
}

