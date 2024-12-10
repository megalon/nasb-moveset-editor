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
	public class SALaunchGrabbedCustomNode : StateActionNode
	{
		[Input(connectionType = ConnectionType.Override)] public StateAction NodeInput;
		public string AtkProp;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer X;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer Y;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.SALaunchGrabbedCustom;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SALaunchGrabbedCustom data, MovesetGraph graph, string assetPath, UnityEngine.Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SALaunchGrabbedCustom));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			AtkProp = data.AtkProp;
			X = data.X;
			
			FloatSourceContainerNode node_X = graph.AddNode<FloatSourceContainerNode>();
			GetPort("X").Connect(node_X.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_X, assetPath);
			variableCount += node_X.SetData(X, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			Y = data.Y;
			
			FloatSourceContainerNode node_Y = graph.AddNode<FloatSourceContainerNode>();
			GetPort("Y").Connect(node_Y.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_Y, assetPath);
			variableCount += node_Y.SetData(Y, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			
			return variableCount;
		}
		
		public new SALaunchGrabbedCustom GetData()
		{
			SALaunchGrabbedCustom objToReturn = new SALaunchGrabbedCustom();
			objToReturn.TID = TypeId.SALaunchGrabbedCustom;
			objToReturn.AtkProp = AtkProp;
			if (GetPort("X").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("X").GetConnection(0).node;
				objToReturn.X = FloatSourceContainer_Node.GetData();
			}
			if (GetPort("Y").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("Y").GetConnection(0).node;
				objToReturn.Y = FloatSourceContainer_Node.GetData();
			}
			return objToReturn;
		}
	}
}

