// * 
// * 
// * This file was generated using NASB_Parser_to_xNode by megalon2d
// * https://github.com/megalon/NASB_Parser_to_xNode
// * 
// * 
using MovesetParser.BulkSerialize;
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
using static MovesetParser.ObjectSources.ObjectSourceContainer;

namespace NASB_Moveset_Editor.ObjectSources
{
	public class ObjectSourceContainerNode : ObjectSourceNode
	{
		[Input(connectionType = ConnectionType.Override)] public ObjectSource NodeInput;
		[Output(connectionType = ConnectionType.Override)] public ObjectSource ObjectSource;
		
		protected override void Init()
		{
			base.Init();
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(ObjectSourceContainer data, MovesetGraph graph, string assetPath, UnityEngine.Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(ObjectSourceContainer));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			ObjectSource = data.ObjectSource;
			
			switch (ObjectSource.TID)
			{
				case ObjectSource.TypeId.ObjectSource:
					ObjectSourceNode ObjectSource_node_ObjectSource = graph.AddNode<ObjectSourceNode>();
					GetPort("ObjectSource").Connect(ObjectSource_node_ObjectSource.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ObjectSource_node_ObjectSource, assetPath);
					variableCount += ObjectSource_node_ObjectSource.SetData((ObjectSource)ObjectSource, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case ObjectSource.TypeId.OSFloat:
					OSFloatNode OSFloat_node_ObjectSource = graph.AddNode<OSFloatNode>();
					GetPort("ObjectSource").Connect(OSFloat_node_ObjectSource.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OSFloat_node_ObjectSource, assetPath);
					variableCount += OSFloat_node_ObjectSource.SetData((OSFloat)ObjectSource, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case ObjectSource.TypeId.OSVector2:
					OSVector2Node OSVector2_node_ObjectSource = graph.AddNode<OSVector2Node>();
					GetPort("ObjectSource").Connect(OSVector2_node_ObjectSource.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(OSVector2_node_ObjectSource, assetPath);
					variableCount += OSVector2_node_ObjectSource.SetData((OSVector2)ObjectSource, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
			}
			
			return variableCount;
		}
		
		public ObjectSourceContainer GetData()
		{
			ObjectSourceContainer objToReturn = new ObjectSourceContainer();
			if (GetPort("ObjectSource").ConnectionCount > 0)
			{
				ObjectSourceNode ObjectSource_Node = (ObjectSourceNode)GetPort("ObjectSource").GetConnection(0).node;
				switch (ObjectSource_Node.TID)
				{
					case ObjectSource.TypeId.ObjectSource:
						ObjectSourceNode ObjectSource_ObjectSource_Node = (ObjectSourceNode)GetPort("ObjectSource").GetConnection(0).node;
						objToReturn.ObjectSource = ObjectSource_ObjectSource_Node.GetData();
					break;
					case ObjectSource.TypeId.OSFloat:
						OSFloatNode OSFloat_ObjectSource_Node = (OSFloatNode)GetPort("ObjectSource").GetConnection(0).node;
						objToReturn.ObjectSource = OSFloat_ObjectSource_Node.GetData();
					break;
					case ObjectSource.TypeId.OSVector2:
						OSVector2Node OSVector2_ObjectSource_Node = (OSVector2Node)GetPort("ObjectSource").GetConnection(0).node;
						objToReturn.ObjectSource = OSVector2_ObjectSource_Node.GetData();
					break;
				}
			}
			return objToReturn;
		}
	}
}

