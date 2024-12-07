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
using static MovesetParser.StateActions.StateAction;

namespace NASB_Moveset_Editor.StateActions
{
	public class SAManageAirJumpNode : StateActionNode
	{
		[Input(connectionType = ConnectionType.Override)] public StateAction NodeInput;
		[Output(connectionType = ConnectionType.Override)] public Manage Manage;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.SAManageAirJump;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SAManageAirJump data, MovesetGraph graph, string assetPath, UnityEngine.Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SAManageAirJump));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			Manage = data.Manage;
			
			ManageNode node_Manage = graph.AddNode<ManageNode>();
			GetPort("Manage").Connect(node_Manage.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_Manage, assetPath);
			variableCount += node_Manage.SetData(Manage, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			
			return variableCount;
		}
		
		public new SAManageAirJump GetData()
		{
			SAManageAirJump objToReturn = new SAManageAirJump();
			objToReturn.TID = TypeId.SAManageAirJump;
			if (GetPort("Manage").ConnectionCount > 0)
			{
				ManageNode Manage_Node = (ManageNode)GetPort("Manage").GetConnection(0).node;
				objToReturn.Manage = Manage_Node.GetData();
			}
			return objToReturn;
		}
	}
}

