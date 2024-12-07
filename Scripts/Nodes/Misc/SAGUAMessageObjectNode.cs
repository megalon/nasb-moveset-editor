// * 
// * 
// * This file was generated using NASB_Parser_to_xNode by megalon2d
// * https://github.com/megalon/NASB_Parser_to_xNode
// * 
// * 
using MovesetParser.BulkSerialize;
using MovesetParser.ObjectSources;
using System.Collections.Generic;
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
using MovesetParser.Unity;
using NASB_Moveset_Editor.CheckThings;
using NASB_Moveset_Editor.FloatSources;
using NASB_Moveset_Editor.Jumps;
using NASB_Moveset_Editor.Misc;
using NASB_Moveset_Editor.StateActions;
using NASB_Moveset_Editor.ObjectSources;
using NASB_Moveset_Editor.Unity;
using static MovesetParser.Misc.SAGUAMessageObject;

namespace NASB_Moveset_Editor.Misc
{
	public class SAGUAMessageObjectNode : BaseMovesetNode
	{
		[Input(connectionType = ConnectionType.Override)] public SAGUAMessageObject NodeInput;
		public string PlainMessage;
		[Output(connectionType = ConnectionType.Multiple)] public List<SAGUAMessageObject.MsgDynamic> Messages;
		
		protected override void Init()
		{
			base.Init();
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SAGUAMessageObject data, MovesetGraph graph, string assetPath, UnityEngine.Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SAGUAMessageObject));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			PlainMessage = data.PlainMessage;
			Messages = data.Messages;
			
			foreach (SAGUAMessageObject.MsgDynamic Messages_item in Messages)
			{
				SAGUAMessageObject_MsgDynamicNode node_Messages = graph.AddNode<SAGUAMessageObject_MsgDynamicNode>();
				GetPort("Messages").Connect(node_Messages.GetPort("NodeInput"));
				AssetDatabase.AddObjectToAsset(node_Messages, assetPath);
				variableCount += node_Messages.SetData(Messages_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				++variableCount;
			}
			return variableCount;
		}
		
		public SAGUAMessageObject GetData()
		{
			SAGUAMessageObject objToReturn = new SAGUAMessageObject();
			objToReturn.PlainMessage = PlainMessage;
			foreach(NodePort port in GetPort("Messages").GetConnections())
			{
				SAGUAMessageObject_MsgDynamicNode SAGUAMessageObject_MsgDynamic_Node = (SAGUAMessageObject_MsgDynamicNode)port.node;
				objToReturn.Messages.Add(SAGUAMessageObject_MsgDynamic_Node.GetData());
			}
			return objToReturn;
		}
	}
}

