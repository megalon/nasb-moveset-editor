// * 
// * 
// * This file was generated using NASB_Parser_to_xNode by megalon2d
// * https://github.com/megalon/NASB_Parser_to_xNode
// * 
// * 
using NASB_Parser.FloatSources;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEditor;
using XNode;
using XNodeEditor;
using NASB_Parser;
using static NASB_Parser.StateActions.SAManipHurtbox;
using NASB_Parser.Jumps;
using NASB_Parser.CheckThings;
using NASB_Parser.StateActions;
using NASB_Parser.ObjectSources;
using NASB_Moveset_Editor.FloatSources;
using NASB_Moveset_Editor.Jumps;
using NASB_Moveset_Editor.CheckThings;
using NASB_Moveset_Editor.StateActions;
using NASB_Moveset_Editor.ObjectSources;
using static NASB_Parser.StateActions.StateAction;

namespace NASB_Moveset_Editor.StateActions
{
	public class SAManipHurtboxNode : StateActionNode
	{
		[Input(connectionType = ConnectionType.Override)] public StateAction NodeInput;
		[Output(connectionType = ConnectionType.Multiple)] public List<SAManipHurtbox.HBM> Manips;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.ManipHurtboxId;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SAManipHurtbox data, MovesetGraph graph, string assetPath, Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SAManipHurtbox));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			Manips = data.Manips;
			
			foreach (SAManipHurtbox.HBM Manips_item in Manips)
			{
				SAManipHurtbox_HBMNode node_Manips = graph.AddNode<SAManipHurtbox_HBMNode>();
				GetPort("Manips").Connect(node_Manips.GetPort("NodeInput"));
				AssetDatabase.AddObjectToAsset(node_Manips, assetPath);
				variableCount += node_Manips.SetData(Manips_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				++variableCount;
			}
			return variableCount;
		}
		
		public new SAManipHurtbox GetData()
		{
			SAManipHurtbox objToReturn = new SAManipHurtbox();
			objToReturn.TID = TypeId.ManipHurtboxId;
			objToReturn.Version = Version;
			foreach(NodePort port in GetPort("Manips").GetConnections())
			{
				SAManipHurtbox_HBMNode SAManipHurtbox_HBM_Node = (SAManipHurtbox_HBMNode)port.node;
				objToReturn.Manips.Add(SAManipHurtbox_HBM_Node.GetData());
			}
			return objToReturn;
		}
	}
}

