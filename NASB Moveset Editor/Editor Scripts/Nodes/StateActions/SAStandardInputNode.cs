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
using static NASB_Parser.StateActions.StateAction;

namespace NASB_Moveset_Editor.StateActions
{
	public class SAStandardInputNode : StateActionNode
	{
		public float Frames;
		public bool ForceCheck;
		[Output] public SAStandardInput.StandardConfig Config;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.StandardInputId;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SAStandardInput data, MovesetGraph graph, string assetPath, Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SAStandardInput));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			Frames = data.Frames;
			ForceCheck = data.ForceCheck;
			Config = data.Config;
			
			SAStandardInput_StandardConfigNode node_Config = graph.AddNode<SAStandardInput_StandardConfigNode>();
			GetPort("Config").Connect(node_Config.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_Config, assetPath);
			variableCount += node_Config.SetData(Config, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
			++variableCount;
			return variableCount;
		}
		
		public new SAStandardInput GetData()
		{
			SAStandardInput objToReturn = new SAStandardInput();
			objToReturn.TID = TypeId.StandardInputId;
			objToReturn.Version = Version;
			objToReturn.Frames = Frames;
			objToReturn.ForceCheck = ForceCheck;
			if (GetPort("Config").ConnectionCount > 0)
			{
				SAStandardInput_StandardConfigNode SAStandardInput_StandardConfig_Node = (SAStandardInput_StandardConfigNode)GetPort("Config").GetConnection(0).node;
				objToReturn.Config = SAStandardInput_StandardConfig_Node.GetData();
			}
			return objToReturn;
		}
	}
}

