// * 
// * 
// * This file was generated using NASB_Parser_to_xNode by megalon2d
// * https://github.com/megalon/NASB_Parser_to_xNode
// * 
// * 
using MovesetParser.BulkSerialize;
using MovesetParser.Misc;
using UnityEngine;
using UnityEditor;
using XNode;
using XNodeEditor;
using MovesetParser;
using MovesetParser.CheckThings;
using MovesetParser.FloatSources;
using MovesetParser.Jumps;
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
	public class SAPlayAnimNode : StateActionNode
	{
		[Input(connectionType = ConnectionType.Override)] public StateAction NodeInput;
		public string Anim;
		public bool FromStart;
		[Output(connectionType = ConnectionType.Override)] public AnimConfig Config;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.SAPlayAnim;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SAPlayAnim data, MovesetGraph graph, string assetPath, UnityEngine.Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SAPlayAnim));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			Anim = data.Anim;
			FromStart = data.FromStart;
			Config = data.Config;
			
			AnimConfigNode node_Config = graph.AddNode<AnimConfigNode>();
			GetPort("Config").Connect(node_Config.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_Config, assetPath);
			variableCount += node_Config.SetData(Config, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			
			return variableCount;
		}
		
		public new SAPlayAnim GetData()
		{
			SAPlayAnim objToReturn = new SAPlayAnim();
			objToReturn.TID = TypeId.SAPlayAnim;
			objToReturn.Anim = Anim;
			objToReturn.FromStart = FromStart;
			if (GetPort("Config").ConnectionCount > 0)
			{
				AnimConfigNode AnimConfig_Node = (AnimConfigNode)GetPort("Config").GetConnection(0).node;
				objToReturn.Config = AnimConfig_Node.GetData();
			}
			return objToReturn;
		}
	}
}

