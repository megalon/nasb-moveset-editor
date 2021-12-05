// * 
// * 
// * This file was generated using NASB_Parser_to_xNode by megalon2d
// * https://github.com/megalon/NASB_Parser_to_xNode
// * 
// * 
using NASB_Parser.FloatSources;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEditor;
using XNode;
using XNodeEditor;
using NASB_Parser;
using NASB_Parser.Jumps;
using NASB_Parser.CheckThings;
using NASB_Parser.StateActions;
using NASB_Parser.ObjectSources;
using NASB_Moveset_Editor.FloatSources;
using NASB_Moveset_Editor.Jumps;
using NASB_Moveset_Editor.CheckThings;
using NASB_Moveset_Editor.StateActions;
using NASB_Moveset_Editor.ObjectSources;
using static NASB_Parser.StateActions.StateAction;

namespace NASB_Moveset_Editor.StateActions
{
	public class SASetFloatTargetNode : StateActionNode
	{
		[Output(connectionType = ConnectionType.Multiple)] public List<SASetFloatTarget.SetFloat> Sets;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.SetFloatId;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SASetFloatTarget data, MovesetGraph graph, string assetPath, Vector2 nodeDepthXY)
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
				variableCount += node_Sets.SetData(Sets_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				++variableCount;
			}
			return variableCount;
		}
		
		public new SASetFloatTarget GetData()
		{
			SASetFloatTarget objToReturn = new SASetFloatTarget();
			objToReturn.TID = TypeId.SetFloatId;
			objToReturn.Version = Version;
			foreach(NodePort port in GetPort("Sets").GetConnections())
			{
				SASetFloatTarget_SetFloatNode SASetFloatTarget_SetFloat_Node = (SASetFloatTarget_SetFloatNode)port.node;
				objToReturn.Sets.Add(SASetFloatTarget_SetFloat_Node.GetData());
			}
			return objToReturn;
		}
	}
}

