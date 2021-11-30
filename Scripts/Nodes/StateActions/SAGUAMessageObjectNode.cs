// * 
// * 
// * This file was generated using NASB_Parser_to_xNode by megalon2d
// * https://github.com/megalon/NASB_Parser_to_xNode
// * 
// * 
using System;
using System.Collections.Generic;
using System.Text;
using NASB_Parser.ObjectSources;
using UnityEngine;
using UnityEditor;
using XNode;
using XNodeEditor;
using NASB_Parser;
using NASB_Parser.FloatSources;
using NASB_Parser.Jumps;
using NASB_Parser.CheckThings;
using NASB_Parser.StateActions;
using NASB_Moveset_Editor.FloatSources;
using NASB_Moveset_Editor.Jumps;
using NASB_Moveset_Editor.CheckThings;
using NASB_Moveset_Editor.StateActions;
using NASB_Moveset_Editor.ObjectSources;
using static NASB_Parser.StateActions.SAGUAMessageObject;

namespace NASB_Moveset_Editor.StateActions
{
	public class SAGUAMessageObjectNode : StateActionNode
	{
		public string PlainMessage;
		[Output] public List<SAGUAMessageObject.MessageDynamic> Dynamics;
		
		protected override void Init()
		{
			base.Init();
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SAGUAMessageObject data, MovesetGraph graph, string assetPath, Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SAGUAMessageObject));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			PlainMessage = data.PlainMessage;
			Dynamics = data.Dynamics;
			
			foreach (SAGUAMessageObject.MessageDynamic Dynamics_item in Dynamics)
			{
				SAGUAMessageObject_MessageDynamicNode node_Dynamics = graph.AddNode<SAGUAMessageObject_MessageDynamicNode>();
				GetPort("Dynamics").Connect(node_Dynamics.GetPort("NodeInput"));
				AssetDatabase.AddObjectToAsset(node_Dynamics, assetPath);
				variableCount += node_Dynamics.SetData(Dynamics_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				++variableCount;
			}
			return variableCount;
		}
		
		public SAGUAMessageObject GetData()
		{
			SAGUAMessageObject objToReturn = new SAGUAMessageObject();
			objToReturn.PlainMessage = PlainMessage;
			foreach(NodePort port in GetPort("Dynamics").GetConnections())
			{
				SAGUAMessageObject_MessageDynamicNode SAGUAMessageObject_MessageDynamic_Node = (SAGUAMessageObject_MessageDynamicNode)port.node;
				objToReturn.Dynamics.Add(SAGUAMessageObject_MessageDynamic_Node.GetData());
			}
			return objToReturn;
		}
	}
}

