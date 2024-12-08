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
	public class SAManipHitBoxNode : StateActionNode
	{
		[Input(connectionType = ConnectionType.Override)] public StateAction NodeInput;
		[Output(connectionType = ConnectionType.Multiple)] public SAManipHitBox.HBM[] Manips;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.SAManipHitBox;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SAManipHitBox data, MovesetGraph graph, string assetPath, UnityEngine.Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SAManipHitBox));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			Manips = data.Manips;
			
			foreach (SAManipHitBox.HBM Manips_item in Manips)
			{
				SAManipHitBox_HBMNode node_Manips = graph.AddNode<SAManipHitBox_HBMNode>();
				GetPort("Manips").Connect(node_Manips.GetPort("NodeInput"));
				AssetDatabase.AddObjectToAsset(node_Manips, assetPath);
				variableCount += node_Manips.SetData(Manips_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				++variableCount;
			}
			return variableCount;
		}
		
		public new SAManipHitBox GetData()
		{
			SAManipHitBox objToReturn = new SAManipHitBox();
			objToReturn.TID = TypeId.SAManipHitBox;
			objToReturn.Manips = new SAManipHitBox.HBM[GetPort("Manips").ConnectionCount];
			int i = 0;
			foreach(NodePort port in GetPort("Manips").GetConnections())
			{
				SAManipHitBox_HBMNode SAManipHitBox_HBM_Node = (SAManipHitBox_HBMNode)port.node;
				objToReturn.Manips[i] = SAManipHitBox_HBM_Node.GetData();
				++i;
			}
			return objToReturn;
		}
	}
}

