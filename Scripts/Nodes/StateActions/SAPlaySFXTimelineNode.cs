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
	public class SAPlaySFXTimelineNode : StateActionNode
	{
		[Input(connectionType = ConnectionType.Override)] public StateAction NodeInput;
		public MovesetParser.StateActions.SAPlaySFXTimeline.ManipType Manip;
		public string Timeline;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer Value;
		public bool Loop;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.SAPlaySFXTimeline;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SAPlaySFXTimeline data, MovesetGraph graph, string assetPath, UnityEngine.Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SAPlaySFXTimeline));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			Manip = data.Manip;
			Timeline = data.Timeline;
			Value = data.Value;
			
			FloatSourceContainerNode node_Value = graph.AddNode<FloatSourceContainerNode>();
			GetPort("Value").Connect(node_Value.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_Value, assetPath);
			variableCount += node_Value.SetData(Value, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			Loop = data.Loop;
			return variableCount;
		}
		
		public new SAPlaySFXTimeline GetData()
		{
			SAPlaySFXTimeline objToReturn = new SAPlaySFXTimeline();
			objToReturn.TID = TypeId.SAPlaySFXTimeline;
			objToReturn.Manip = Manip;
			objToReturn.Timeline = Timeline;
			if (GetPort("Value").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("Value").GetConnection(0).node;
				objToReturn.Value = FloatSourceContainer_Node.GetData();
			}
			objToReturn.Loop = Loop;
			return objToReturn;
		}
	}
}

