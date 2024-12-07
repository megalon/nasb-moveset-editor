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
	public class FSLagNode : FloatSourceNode
	{
		[Input(connectionType = ConnectionType.Override)] public FloatSource NodeInput;
		[Output(connectionType = ConnectionType.Override)] public LagType LagType;
		[Output(connectionType = ConnectionType.Override)] public ManipLag ManipLag;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.FSLag;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(FSLag data, MovesetGraph graph, string assetPath, UnityEngine.Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(FSLag));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			LagType = data.LagType;
			
			LagTypeNode node_LagType = graph.AddNode<LagTypeNode>();
			GetPort("LagType").Connect(node_LagType.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_LagType, assetPath);
			variableCount += node_LagType.SetData(LagType, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			ManipLag = data.ManipLag;
			
			ManipLagNode node_ManipLag = graph.AddNode<ManipLagNode>();
			GetPort("ManipLag").Connect(node_ManipLag.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_ManipLag, assetPath);
			variableCount += node_ManipLag.SetData(ManipLag, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			
			return variableCount;
		}
		
		public new FSLag GetData()
		{
			FSLag objToReturn = new FSLag();
			objToReturn.TID = TypeId.FSLag;
			if (GetPort("LagType").ConnectionCount > 0)
			{
				LagTypeNode LagType_Node = (LagTypeNode)GetPort("LagType").GetConnection(0).node;
				objToReturn.LagType = LagType_Node.GetData();
			}
			if (GetPort("ManipLag").ConnectionCount > 0)
			{
				ManipLagNode ManipLag_Node = (ManipLagNode)GetPort("ManipLag").GetConnection(0).node;
				objToReturn.ManipLag = ManipLag_Node.GetData();
			}
			return objToReturn;
		}
	}
}

