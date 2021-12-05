// * 
// * 
// * This file was generated using NASB_Parser_to_xNode by megalon2d
// * https://github.com/megalon/NASB_Parser_to_xNode
// * 
// * 
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEditor;
using XNode;
using XNodeEditor;
using NASB_Parser;
using NASB_Parser.FloatSources;
using NASB_Parser.Jumps;
using NASB_Parser.CheckThings;
using NASB_Parser.StateActions;
using NASB_Parser.ObjectSources;
using NASB_Moveset_Editor.FloatSources;
using NASB_Moveset_Editor.Jumps;
using NASB_Moveset_Editor.CheckThings;
using NASB_Moveset_Editor.StateActions;
using NASB_Moveset_Editor.ObjectSources;
using static NASB_Parser.StateActions.HurtSetSetup;

namespace NASB_Moveset_Editor.StateActions
{
	public class HurtSetSetupNode : StateActionNode
	{
		[Output(connectionType = ConnectionType.Multiple)] public List<HurtBone> HurtBones;
		
		protected override void Init()
		{
			base.Init();
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(HurtSetSetup data, MovesetGraph graph, string assetPath, Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(HurtSetSetup));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			HurtBones = data.HurtBones;
			
			foreach (HurtBone HurtBones_item in data.HurtBones)
			{
				HurtBoneNode node_HurtBones = graph.AddNode<HurtBoneNode>();
				GetPort("HurtBones").Connect(node_HurtBones.GetPort("NodeInput"));
				AssetDatabase.AddObjectToAsset(node_HurtBones, assetPath);
				variableCount += node_HurtBones.SetData(HurtBones_item, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				++variableCount;
			}
			
			return variableCount;
		}
		
		public HurtSetSetup GetData()
		{
			HurtSetSetup objToReturn = new HurtSetSetup();
			foreach(NodePort port in GetPort("HurtBones").GetConnections())
			{
				HurtBoneNode HurtBone_Node = (HurtBoneNode)port.node;
				objToReturn.HurtBones.Add(HurtBone_Node.GetData());
			}
			return objToReturn;
		}
	}
}

