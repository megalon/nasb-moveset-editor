// * 
// * 
// * This file was generated using MovesetParser_to_xNode by megalon2d
// * https://github.com/megalon/MovesetParser_to_xNode
// * 
// * 
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEditor;
using XNode;
using XNodeEditor;
using MovesetParser;
using MovesetParser.FloatSources;
using MovesetParser.Jumps;
using MovesetParser.CheckThings;
using MovesetParser.StateActions;
using MovesetParser.ObjectSources;
using NASB_Moveset_Editor.FloatSources;
using NASB_Moveset_Editor.Jumps;
using NASB_Moveset_Editor.CheckThings;
using NASB_Moveset_Editor.StateActions;
using NASB_Moveset_Editor.ObjectSources;
using static MovesetParser.StateActions.StateAction;

namespace NASB_Moveset_Editor.StateActions
{
	public class SASetupHurtboxesNode : StateActionNode
	{
		[Input(connectionType = ConnectionType.Override)] public StateAction NodeInput;
		[Output(connectionType = ConnectionType.Override)] public HurtSetSetup HurtSetSetup;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.SetupHurtsetId;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SASetupHurtboxes data, MovesetGraph graph, string assetPath, Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SASetupHurtboxes));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			HurtSetSetup = data.HurtSetSetup;
			
			HurtSetSetupNode node_HurtSetSetup = graph.AddNode<HurtSetSetupNode>();
			GetPort("HurtSetSetup").Connect(node_HurtSetSetup.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_HurtSetSetup, assetPath);
			variableCount += node_HurtSetSetup.SetData(HurtSetSetup, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
			
			return variableCount;
		}
		
		public new SASetupHurtboxes GetData()
		{
			SASetupHurtboxes objToReturn = new SASetupHurtboxes();
			objToReturn.TID = TypeId.SetupHurtsetId;
			objToReturn.Version = Version;
			if (GetPort("HurtSetSetup").ConnectionCount > 0)
			{
				HurtSetSetupNode HurtSetSetup_Node = (HurtSetSetupNode)GetPort("HurtSetSetup").GetConnection(0).node;
				objToReturn.HurtSetSetup = HurtSetSetup_Node.GetData();
			}
			return objToReturn;
		}
	}
}

