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
	public class SAPlayAnimNode : StateActionNode
	{
		[Input(connectionType = ConnectionType.Override)] public StateAction NodeInput;
		public bool FromStart;
		public string Anim;
		[Output(connectionType = ConnectionType.Override)] public AnimConfig Cfg;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.PlayAnimId;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SAPlayAnim data, MovesetGraph graph, string assetPath, Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SAPlayAnim));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			FromStart = data.FromStart;
			Anim = data.Anim;
			Cfg = data.Cfg;
			
			AnimConfigNode node_Cfg = graph.AddNode<AnimConfigNode>();
			GetPort("Cfg").Connect(node_Cfg.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_Cfg, assetPath);
			variableCount += node_Cfg.SetData(Cfg, graph, assetPath, nodeDepthXY + new Vector2(1, variableCount));
			
			return variableCount;
		}
		
		public new SAPlayAnim GetData()
		{
			SAPlayAnim objToReturn = new SAPlayAnim();
			objToReturn.TID = TypeId.PlayAnimId;
			objToReturn.Version = Version;
			objToReturn.FromStart = FromStart;
			objToReturn.Anim = Anim;
			if (GetPort("Cfg").ConnectionCount > 0)
			{
				AnimConfigNode AnimConfig_Node = (AnimConfigNode)GetPort("Cfg").GetConnection(0).node;
				objToReturn.Cfg = AnimConfig_Node.GetData();
			}
			return objToReturn;
		}
	}
}

