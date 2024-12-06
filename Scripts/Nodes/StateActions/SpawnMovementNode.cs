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
using static MovesetParser.StateActions.SpawnMovement;

namespace NASB_Moveset_Editor.StateActions
{
	public class SpawnMovementNode : StateActionNode
	{
		[Input(connectionType = ConnectionType.Override)] public SpawnMovement NodeInput;
		public string ToBone;
		public MovesetParser.Vector3 LocalOffset;
		public MovesetParser.Vector3 WorldOffset;
		[Output(connectionType = ConnectionType.Override)] public MovementConfig Config;
		
		protected override void Init()
		{
			base.Init();
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SpawnMovement data, MovesetGraph graph, string assetPath, Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SpawnMovement));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			ToBone = data.ToBone;
			LocalOffset = data.LocalOffset;
			WorldOffset = data.WorldOffset;
			Config = data.Config;
			
			MovementConfigNode node_Config = graph.AddNode<MovementConfigNode>();
			GetPort("Config").Connect(node_Config.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_Config, assetPath);
			variableCount += node_Config.SetData(Config, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
			
			return variableCount;
		}
		
		public SpawnMovement GetData()
		{
			SpawnMovement objToReturn = new SpawnMovement();
			objToReturn.ToBone = ToBone;
			objToReturn.LocalOffset = LocalOffset;
			objToReturn.WorldOffset = WorldOffset;
			if (GetPort("Config").ConnectionCount > 0)
			{
				MovementConfigNode MovementConfig_Node = (MovementConfigNode)GetPort("Config").GetConnection(0).node;
				objToReturn.Config = MovementConfig_Node.GetData();
			}
			return objToReturn;
		}
	}
}

