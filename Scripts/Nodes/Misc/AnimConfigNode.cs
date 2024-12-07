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
using static MovesetParser.Misc.AnimConfig;

namespace NASB_Moveset_Editor.Misc
{
	public class AnimConfigNode : BaseMovesetNode
	{
		[Input(connectionType = ConnectionType.Override)] public AnimConfig NodeInput;
		public float Rate;
		public float Weight;
		[Output(connectionType = ConnectionType.Override)] public WrapMode WrapMode;
		public bool ClingToFrames;
		
		protected override void Init()
		{
			base.Init();
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(AnimConfig data, MovesetGraph graph, string assetPath, UnityEngine.Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(AnimConfig));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			Rate = data.Rate;
			Weight = data.Weight;
			WrapMode = data.WrapMode;
			
			WrapModeNode node_WrapMode = graph.AddNode<WrapModeNode>();
			GetPort("WrapMode").Connect(node_WrapMode.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_WrapMode, assetPath);
			variableCount += node_WrapMode.SetData(WrapMode, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			ClingToFrames = data.ClingToFrames;
			return variableCount;
		}
		
		public AnimConfig GetData()
		{
			AnimConfig objToReturn = new AnimConfig();
			objToReturn.Rate = Rate;
			objToReturn.Weight = Weight;
			if (GetPort("WrapMode").ConnectionCount > 0)
			{
				WrapModeNode WrapMode_Node = (WrapModeNode)GetPort("WrapMode").GetConnection(0).node;
				objToReturn.WrapMode = WrapMode_Node.GetData();
			}
			objToReturn.ClingToFrames = ClingToFrames;
			return objToReturn;
		}
	}
}

