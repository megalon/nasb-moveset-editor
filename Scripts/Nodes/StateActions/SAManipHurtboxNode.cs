// * 
// * 
// * This file was generated using NASB_Parser_to_xNode by megalon2d
// * https://github.com/megalon/NASB_Parser_to_xNode
// * 
// * 
using MovesetParser.BulkSerialize;
using MovesetParser.FloatSources;
using MovesetParser.Misc;
using UnityEngine;
using UnityEditor;
using XNode;
using XNodeEditor;
using MovesetParser;
using MovesetParser.CheckThings;
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
using static MovesetParser.StateActions.StateAction;

namespace NASB_Moveset_Editor.StateActions
{
	public class SAManipHurtBoxNode : StateActionNode
	{
		[Input(connectionType = ConnectionType.Override)] public StateAction NodeInput;
		[Output(connectionType = ConnectionType.Multiple)] public SAManipHurtBox.HBM[] Manips;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.SAManipHurtBox;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SAManipHurtBox data, MovesetGraph graph, string assetPath, UnityEngine.Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SAManipHurtBox));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			Manips = data.Manips;
			
			foreach (SAManipHurtBox.HBM Manips_item in Manips)
			{
				SAManipHurtBox_HBMNode node_Manips = graph.AddNode<SAManipHurtBox_HBMNode>();
				GetPort("Manips").Connect(node_Manips.GetPort("NodeInput"));
				AssetDatabase.AddObjectToAsset(node_Manips, assetPath);
				variableCount += node_Manips.SetData(Manips_item, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				++variableCount;
			}
			return variableCount;
		}
		
		public new SAManipHurtBox GetData()
		{
			SAManipHurtBox objToReturn = new SAManipHurtBox();
			objToReturn.TID = TypeId.SAManipHurtBox;
			objToReturn.Manips = new SAManipHurtBox.HBM[GetPort("Manips").ConnectionCount];
			int i = 0;
			foreach(NodePort port in GetPort("Manips").GetConnections())
			{
				SAManipHurtBox_HBMNode SAManipHurtBox_HBM_Node = (SAManipHurtBox_HBMNode)port.node;
				objToReturn.Manips[i] = SAManipHurtBox_HBM_Node.GetData();
				++i;
			}
			return objToReturn;
		}
	}
}

