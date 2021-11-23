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
using static NASB_Parser.StateActions.SAManipHitbox;
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
	public class SAManipHitboxNode : StateActionNode
	{
		[Output] public List<SAManipHitbox.HBM> Manips;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.ManipHitboxId;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SAManipHitbox data, MovesetGraph graph, string assetPath, Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SAManipHitbox));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			Manips = data.Manips;
			
			foreach (SAManipHitbox.HBM Manips_item in Manips)
			{
				SAManipHitbox_HBMNode node_Manips = graph.AddNode<SAManipHitbox_HBMNode>();
				GetPort("Manips").Connect(node_Manips.GetPort("NodeInput"));
				AssetDatabase.AddObjectToAsset(node_Manips, assetPath);
				variableCount += node_Manips.SetData(Manips_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				++variableCount;
			}
			return variableCount;
		}
		
		public new SAManipHitbox GetData()
		{
			SAManipHitbox objToReturn = new SAManipHitbox();
			objToReturn.TID = TypeId.ManipHitboxId;
			objToReturn.Version = Version;
			foreach(NodePort port in GetPort("Manips").GetConnections())
			{
				SAManipHitbox_HBMNode SAManipHitbox_HBM_Node = (SAManipHitbox_HBMNode)port.node;
				objToReturn.Manips.Add(SAManipHitbox_HBM_Node.GetData());
			}
			return objToReturn;
		}
	}
}

