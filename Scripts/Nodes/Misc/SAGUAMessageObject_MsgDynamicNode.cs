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
using MovesetParser;
using MovesetParser.CheckThings;
using MovesetParser.FloatSources;
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

namespace NASB_Moveset_Editor.Misc
{
	public class SAGUAMessageObject_MsgDynamicNode : BaseMovesetNode
	{
		[Input(connectionType = ConnectionType.Override)] public SAGUAMessageObject.MsgDynamic NodeInput;
		public string Id;
		[Output(connectionType = ConnectionType.Override)] public ObjectSourceContainer ObjectSourceContainer;
		
		protected override void Init()
		{
			base.Init();
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SAGUAMessageObject.MsgDynamic data, MovesetGraph graph, string assetPath, UnityEngine.Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SAGUAMessageObject.MsgDynamic));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			Id = data.Id;
			ObjectSourceContainer = data.ObjectSourceContainer;
			
			ObjectSourceContainerNode node_ObjectSourceContainer = graph.AddNode<ObjectSourceContainerNode>();
			GetPort("ObjectSourceContainer").Connect(node_ObjectSourceContainer.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_ObjectSourceContainer, assetPath);
			variableCount += node_ObjectSourceContainer.SetData(ObjectSourceContainer, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			
			return variableCount;
		}
		
		public SAGUAMessageObject.MsgDynamic GetData()
		{
			SAGUAMessageObject.MsgDynamic objToReturn = new SAGUAMessageObject.MsgDynamic();
			objToReturn.Id = Id;
			if (GetPort("ObjectSourceContainer").ConnectionCount > 0)
			{
				ObjectSourceContainerNode ObjectSourceContainer_Node = (ObjectSourceContainerNode)GetPort("ObjectSourceContainer").GetConnection(0).node;
				objToReturn.ObjectSourceContainer = ObjectSourceContainer_Node.GetData();
			}
			return objToReturn;
		}
	}
}

