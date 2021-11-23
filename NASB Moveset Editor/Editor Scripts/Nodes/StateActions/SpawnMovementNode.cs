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
using static NASB_Parser.StateActions.SpawnMovement;

namespace NASB_Moveset_Editor.StateActions
{
	public class SpawnMovementNode : BaseMovesetNode
	{
		public string ToBone;
		public NASB_Parser.Vector3 LocalOffset;
		public NASB_Parser.Vector3 WorldOffset;
		[Output] public MovementConfig Config;
		
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
		
		public new SpawnMovement GetData()
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

