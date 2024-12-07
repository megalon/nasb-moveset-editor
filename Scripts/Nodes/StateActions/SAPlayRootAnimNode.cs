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
	public class SAPlayRootAnimNode : StateActionNode
	{
		[Input(connectionType = ConnectionType.Override)] public StateAction NodeInput;
		public string Anim;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer Rate;
		public bool SetRateOnly;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer Frame;
		public bool SetFrame;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.SAPlayRootAnim;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SAPlayRootAnim data, MovesetGraph graph, string assetPath, UnityEngine.Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SAPlayRootAnim));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			Anim = data.Anim;
			Rate = data.Rate;
			
			FloatSourceContainerNode node_Rate = graph.AddNode<FloatSourceContainerNode>();
			GetPort("Rate").Connect(node_Rate.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_Rate, assetPath);
			variableCount += node_Rate.SetData(Rate, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			SetRateOnly = data.SetRateOnly;
			Frame = data.Frame;
			
			FloatSourceContainerNode node_Frame = graph.AddNode<FloatSourceContainerNode>();
			GetPort("Frame").Connect(node_Frame.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_Frame, assetPath);
			variableCount += node_Frame.SetData(Frame, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			SetFrame = data.SetFrame;
			return variableCount;
		}
		
		public new SAPlayRootAnim GetData()
		{
			SAPlayRootAnim objToReturn = new SAPlayRootAnim();
			objToReturn.TID = TypeId.SAPlayRootAnim;
			objToReturn.Anim = Anim;
			if (GetPort("Rate").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("Rate").GetConnection(0).node;
				objToReturn.Rate = FloatSourceContainer_Node.GetData();
			}
			objToReturn.SetRateOnly = SetRateOnly;
			if (GetPort("Frame").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("Frame").GetConnection(0).node;
				objToReturn.Frame = FloatSourceContainer_Node.GetData();
			}
			objToReturn.SetFrame = SetFrame;
			return objToReturn;
		}
	}
}

