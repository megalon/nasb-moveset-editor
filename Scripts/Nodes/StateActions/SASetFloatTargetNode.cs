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
	public class SASetFloatTargetNode : StateActionNode
	{
		[Input(connectionType = ConnectionType.Override)] public StateAction NodeInput;
		[Output(connectionType = ConnectionType.Multiple)] public SASetFloatTarget.SetFloat[] Sets;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.SASetFloatTarget;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SASetFloatTarget data, MovesetGraph graph, string assetPath, UnityEngine.Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SASetFloatTarget));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			Sets = data.Sets;
			
			foreach (SASetFloatTarget.SetFloat Sets_item in Sets)
			{
				SASetFloatTarget_SetFloatNode node_Sets = graph.AddNode<SASetFloatTarget_SetFloatNode>();
				GetPort("Sets").Connect(node_Sets.GetPort("NodeInput"));
				AssetDatabase.AddObjectToAsset(node_Sets, assetPath);
				variableCount += node_Sets.SetData(Sets_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				++variableCount;
			}
			return variableCount;
		}
		
		public new SASetFloatTarget GetData()
		{
			SASetFloatTarget objToReturn = new SASetFloatTarget();
			objToReturn.TID = TypeId.SASetFloatTarget;
			objToReturn.Sets = new SASetFloatTarget.SetFloat[GetPort("Sets").ConnectionCount];
			int i = 0;
			foreach(NodePort port in GetPort("Sets").GetConnections())
			{
				SASetFloatTarget_SetFloatNode SASetFloatTarget_SetFloat_Node = (SASetFloatTarget_SetFloatNode)port.node;
				objToReturn.Sets[i] = SASetFloatTarget_SetFloat_Node.GetData();
				++i;
			}
			return objToReturn;
		}
	}
}

