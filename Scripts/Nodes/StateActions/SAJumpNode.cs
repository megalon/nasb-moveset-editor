// * 
// * 
// * This file was generated using NASB_Parser_to_xNode by megalon2d
// * https://github.com/megalon/NASB_Parser_to_xNode
// * 
// * 
using MovesetParser.BulkSerialize;
using MovesetParser.Jumps;
using UnityEngine;
using UnityEditor;
using XNode;
using XNodeEditor;
using MovesetParser;
using MovesetParser.CheckThings;
using MovesetParser.FloatSources;
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
	public class SAJumpNode : StateActionNode
	{
		[Input(connectionType = ConnectionType.Override)] public StateAction NodeInput;
		public string JumpId;
		[Output(connectionType = ConnectionType.Override)] public Jump Jump;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.SAJump;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SAJump data, MovesetGraph graph, string assetPath, UnityEngine.Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SAJump));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			JumpId = data.JumpId;
			Jump = data.Jump;
			
			switch (Jump.TID)
			{
				case Jump.TypeId.Jump:
					JumpNode Jump_node_Jump = graph.AddNode<JumpNode>();
					GetPort("Jump").Connect(Jump_node_Jump.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(Jump_node_Jump, assetPath);
					variableCount += Jump_node_Jump.SetData((Jump)Jump, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case Jump.TypeId.HeightJump:
					HeightJumpNode HeightJump_node_Jump = graph.AddNode<HeightJumpNode>();
					GetPort("Jump").Connect(HeightJump_node_Jump.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(HeightJump_node_Jump, assetPath);
					variableCount += HeightJump_node_Jump.SetData((HeightJump)Jump, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case Jump.TypeId.HoldJump:
					HoldJumpNode HoldJump_node_Jump = graph.AddNode<HoldJumpNode>();
					GetPort("Jump").Connect(HoldJump_node_Jump.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(HoldJump_node_Jump, assetPath);
					variableCount += HoldJump_node_Jump.SetData((HoldJump)Jump, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case Jump.TypeId.AirDashJump:
					AirDashJumpNode AirDashJump_node_Jump = graph.AddNode<AirDashJumpNode>();
					GetPort("Jump").Connect(AirDashJump_node_Jump.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(AirDashJump_node_Jump, assetPath);
					variableCount += AirDashJump_node_Jump.SetData((AirDashJump)Jump, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case Jump.TypeId.KnockbackJump:
					KnockbackJumpNode KnockbackJump_node_Jump = graph.AddNode<KnockbackJumpNode>();
					GetPort("Jump").Connect(KnockbackJump_node_Jump.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(KnockbackJump_node_Jump, assetPath);
					variableCount += KnockbackJump_node_Jump.SetData((KnockbackJump)Jump, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case Jump.TypeId.DelayedJump:
					DelayedJumpNode DelayedJump_node_Jump = graph.AddNode<DelayedJumpNode>();
					GetPort("Jump").Connect(DelayedJump_node_Jump.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(DelayedJump_node_Jump, assetPath);
					variableCount += DelayedJump_node_Jump.SetData((DelayedJump)Jump, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
				case Jump.TypeId.ClampMomentumJump:
					ClampMomentumJumpNode ClampMomentumJump_node_Jump = graph.AddNode<ClampMomentumJumpNode>();
					GetPort("Jump").Connect(ClampMomentumJump_node_Jump.GetPort("NodeInput"));
					AssetDatabase.AddObjectToAsset(ClampMomentumJump_node_Jump, assetPath);
					variableCount += ClampMomentumJump_node_Jump.SetData((ClampMomentumJump)Jump, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
				break;
			}
			
			return variableCount;
		}
		
		public new SAJump GetData()
		{
			SAJump objToReturn = new SAJump();
			objToReturn.TID = TypeId.SAJump;
			objToReturn.JumpId = JumpId;
			if (GetPort("Jump").ConnectionCount > 0)
			{
				JumpNode Jump_Node = (JumpNode)GetPort("Jump").GetConnection(0).node;
				switch (Jump_Node.TID)
				{
					case Jump.TypeId.Jump:
						JumpNode Jump_Jump_Node = (JumpNode)GetPort("Jump").GetConnection(0).node;
						objToReturn.Jump = Jump_Jump_Node.GetData();
					break;
					case Jump.TypeId.HeightJump:
						HeightJumpNode HeightJump_Jump_Node = (HeightJumpNode)GetPort("Jump").GetConnection(0).node;
						objToReturn.Jump = HeightJump_Jump_Node.GetData();
					break;
					case Jump.TypeId.HoldJump:
						HoldJumpNode HoldJump_Jump_Node = (HoldJumpNode)GetPort("Jump").GetConnection(0).node;
						objToReturn.Jump = HoldJump_Jump_Node.GetData();
					break;
					case Jump.TypeId.AirDashJump:
						AirDashJumpNode AirDashJump_Jump_Node = (AirDashJumpNode)GetPort("Jump").GetConnection(0).node;
						objToReturn.Jump = AirDashJump_Jump_Node.GetData();
					break;
					case Jump.TypeId.KnockbackJump:
						KnockbackJumpNode KnockbackJump_Jump_Node = (KnockbackJumpNode)GetPort("Jump").GetConnection(0).node;
						objToReturn.Jump = KnockbackJump_Jump_Node.GetData();
					break;
					case Jump.TypeId.DelayedJump:
						DelayedJumpNode DelayedJump_Jump_Node = (DelayedJumpNode)GetPort("Jump").GetConnection(0).node;
						objToReturn.Jump = DelayedJump_Jump_Node.GetData();
					break;
					case Jump.TypeId.ClampMomentumJump:
						ClampMomentumJumpNode ClampMomentumJump_Jump_Node = (ClampMomentumJumpNode)GetPort("Jump").GetConnection(0).node;
						objToReturn.Jump = ClampMomentumJump_Jump_Node.GetData();
					break;
				}
			}
			return objToReturn;
		}
	}
}

