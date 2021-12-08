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
using NASB_Parser;
using NASB_Parser.FloatSources;
using NASB_Parser.Jumps;
using NASB_Parser.CheckThings;
using NASB_Parser.StateActions;
using NASB_Parser.ObjectSources;
using NASB_Moveset_Editor.FloatSources;
using NASB_Moveset_Editor.Jumps;
using NASB_Moveset_Editor.CheckThings;
using NASB_Moveset_Editor.StateActions;
using NASB_Moveset_Editor.ObjectSources;

namespace NASB_Moveset_Editor.StateActions
{
	public class SAGUAMessageObject_MessageDynamicNode : StateActionNode
	{
		public string Id;
		[Output(connectionType = ConnectionType.Override)] public ObjectSource ObjectSource;
		
		protected override void Init()
		{
			base.Init();
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SAGUAMessageObject.MessageDynamic data, MovesetGraph graph, string assetPath, Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SAGUAMessageObject.MessageDynamic));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			Id = data.Id;
			ObjectSource = data.ObjectSource;
			
			switch (ObjectSource.TID)
			{
				case ObjectSource.TypeId.FloatId:
					OSFloatNode FloatId_node_ObjectSource = graph.AddNode<OSFloatNode>();
					GetPort("ObjectSource").Connect(FloatId_node_ObjectSource.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(FloatId_node_ObjectSource, assetPath);
					variableCount += FloatId_node_ObjectSource.SetData((OSFloat)ObjectSource, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case ObjectSource.TypeId.Vector2Id:
					OSVector2Node Vector2Id_node_ObjectSource = graph.AddNode<OSVector2Node>();
					GetPort("ObjectSource").Connect(Vector2Id_node_ObjectSource.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(Vector2Id_node_ObjectSource, assetPath);
					variableCount += Vector2Id_node_ObjectSource.SetData((OSVector2)ObjectSource, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
			}
			
			return variableCount;
		}
		
		public SAGUAMessageObject.MessageDynamic GetData()
		{
			SAGUAMessageObject.MessageDynamic objToReturn = new SAGUAMessageObject.MessageDynamic();
			objToReturn.Id = Id;
			if (GetPort("ObjectSource").ConnectionCount > 0)
			{
				ObjectSourceNode ObjectSource_Node = (ObjectSourceNode)GetPort("ObjectSource").GetConnection(0).node;
				switch (ObjectSource_Node.TID)
				{
					case ObjectSource.TypeId.FloatId:
						OSFloatNode FloatId_ObjectSource_Node = (OSFloatNode)GetPort("ObjectSource").GetConnection(0).node;
						objToReturn.ObjectSource = FloatId_ObjectSource_Node.GetData();
					break;
					case ObjectSource.TypeId.Vector2Id:
						OSVector2Node Vector2Id_ObjectSource_Node = (OSVector2Node)GetPort("ObjectSource").GetConnection(0).node;
						objToReturn.ObjectSource = Vector2Id_ObjectSource_Node.GetData();
					break;
					case ObjectSource.TypeId.BaseIdentifier:
						ObjectSourceNode BaseIdentifier_ObjectSource_Node = (ObjectSourceNode)GetPort("ObjectSource").GetConnection(0).node;
						objToReturn.ObjectSource = BaseIdentifier_ObjectSource_Node.GetData();
					break;
				}
			}
			return objToReturn;
		}
	}
}

