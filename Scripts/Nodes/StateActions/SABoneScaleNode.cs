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
	public class SABoneScaleNode : StateActionNode
	{
		[Input(connectionType = ConnectionType.Override)] public StateAction NodeInput;
		public string Bone;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer Scale;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.SABoneScale;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SABoneScale data, MovesetGraph graph, string assetPath, UnityEngine.Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SABoneScale));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			Bone = data.Bone;
			Scale = data.Scale;
			
			FloatSourceContainerNode node_Scale = graph.AddNode<FloatSourceContainerNode>();
			GetPort("Scale").Connect(node_Scale.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_Scale, assetPath);
			variableCount += node_Scale.SetData(Scale, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			
			return variableCount;
		}
		
		public new SABoneScale GetData()
		{
			SABoneScale objToReturn = new SABoneScale();
			objToReturn.TID = TypeId.SABoneScale;
			objToReturn.Bone = Bone;
			if (GetPort("Scale").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("Scale").GetConnection(0).node;
				objToReturn.Scale = FloatSourceContainer_Node.GetData();
			}
			return objToReturn;
		}
	}
}

