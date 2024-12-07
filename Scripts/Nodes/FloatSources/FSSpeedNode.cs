// * 
// * 
// * This file was generated using NASB_Parser_to_xNode by megalon2d
// * https://github.com/megalon/NASB_Parser_to_xNode
// * 
// * 
using MovesetParser.BulkSerialize;
using MovesetParser.Misc;
using UnityEngine;
using UnityEditor;
using XNode;
using XNodeEditor;
using MovesetParser;
using MovesetParser.CheckThings;
using MovesetParser.FloatSources;
using MovesetParser.Jumps;
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
using static MovesetParser.FloatSources.FloatSource;

namespace NASB_Moveset_Editor.FloatSources
{
	public class FSSpeedNode : FloatSourceNode
	{
		[Input(connectionType = ConnectionType.Override)] public FloatSource NodeInput;
		[Output(connectionType = ConnectionType.Override)] public SpeedType SpeedType;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.FSSpeed;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(FSSpeed data, MovesetGraph graph, string assetPath, UnityEngine.Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(FSSpeed));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			SpeedType = data.SpeedType;
			
			SpeedTypeNode node_SpeedType = graph.AddNode<SpeedTypeNode>();
			GetPort("SpeedType").Connect(node_SpeedType.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_SpeedType, assetPath);
			variableCount += node_SpeedType.SetData(SpeedType, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			
			return variableCount;
		}
		
		public new FSSpeed GetData()
		{
			FSSpeed objToReturn = new FSSpeed();
			objToReturn.TID = TypeId.FSSpeed;
			if (GetPort("SpeedType").ConnectionCount > 0)
			{
				SpeedTypeNode SpeedType_Node = (SpeedTypeNode)GetPort("SpeedType").GetConnection(0).node;
				objToReturn.SpeedType = SpeedType_Node.GetData();
			}
			return objToReturn;
		}
	}
}

