// * 
// * 
// * This file was generated using NASB_Parser_to_xNode by megalon2d
// * https://github.com/megalon/NASB_Parser_to_xNode
// * 
// * 
using NASB_Parser.Jumps;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEditor;
using XNode;
using XNodeEditor;
using NASB_Parser;
using NASB_Parser.FloatSources;
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
	public class SAJumpNode : StateActionNode
	{
		[Input(connectionType = ConnectionType.Override)] public StateAction NodeInput;
		public string JumpId;
		[Output(connectionType = ConnectionType.Override)] public Jump Jump;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.JumpId;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SAJump data, MovesetGraph graph, string assetPath, Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SAJump));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			JumpId = data.JumpId;
			Jump = data.Jump;
			
			switch (Jump.TID)
			{
				case Jump.TypeId.HeightId:
					HeightJumpNode HeightId_node_Jump = graph.AddNode<HeightJumpNode>();
					GetPort("Jump").Connect(HeightId_node_Jump.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(HeightId_node_Jump, assetPath);
					variableCount += HeightId_node_Jump.SetData((HeightJump)Jump, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case Jump.TypeId.HoldId:
					HoldJumpNode HoldId_node_Jump = graph.AddNode<HoldJumpNode>();
					GetPort("Jump").Connect(HoldId_node_Jump.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(HoldId_node_Jump, assetPath);
					variableCount += HoldId_node_Jump.SetData((HoldJump)Jump, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case Jump.TypeId.AirdashId:
					AirDashJumpNode AirdashId_node_Jump = graph.AddNode<AirDashJumpNode>();
					GetPort("Jump").Connect(AirdashId_node_Jump.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AirdashId_node_Jump, assetPath);
					variableCount += AirdashId_node_Jump.SetData((AirDashJump)Jump, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
				case Jump.TypeId.KnockbackId:
					KnockbackJumpNode KnockbackId_node_Jump = graph.AddNode<KnockbackJumpNode>();
					GetPort("Jump").Connect(KnockbackId_node_Jump.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(KnockbackId_node_Jump, assetPath);
					variableCount += KnockbackId_node_Jump.SetData((KnockbackJump)Jump, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
				break;
			}
			
			return variableCount;
		}
		
		public new SAJump GetData()
		{
			SAJump objToReturn = new SAJump();
			objToReturn.TID = TypeId.JumpId;
			objToReturn.Version = Version;
			objToReturn.JumpId = JumpId;
			if (GetPort("Jump").ConnectionCount > 0)
			{
				JumpNode Jump_Node = (JumpNode)GetPort("Jump").GetConnection(0).node;
				switch (Jump_Node.TID)
				{
					case Jump.TypeId.HeightId:
						HeightJumpNode HeightId_Jump_Node = (HeightJumpNode)GetPort("Jump").GetConnection(0).node;
						objToReturn.Jump = HeightId_Jump_Node.GetData();
					break;
					case Jump.TypeId.HoldId:
						HoldJumpNode HoldId_Jump_Node = (HoldJumpNode)GetPort("Jump").GetConnection(0).node;
						objToReturn.Jump = HoldId_Jump_Node.GetData();
					break;
					case Jump.TypeId.AirdashId:
						AirDashJumpNode AirdashId_Jump_Node = (AirDashJumpNode)GetPort("Jump").GetConnection(0).node;
						objToReturn.Jump = AirdashId_Jump_Node.GetData();
					break;
					case Jump.TypeId.KnockbackId:
						KnockbackJumpNode KnockbackId_Jump_Node = (KnockbackJumpNode)GetPort("Jump").GetConnection(0).node;
						objToReturn.Jump = KnockbackId_Jump_Node.GetData();
					break;
					case Jump.TypeId.BaseIdentifier:
						JumpNode BaseIdentifier_Jump_Node = (JumpNode)GetPort("Jump").GetConnection(0).node;
						objToReturn.Jump = BaseIdentifier_Jump_Node.GetData();
					break;
				}
			}
			return objToReturn;
		}
	}
}

