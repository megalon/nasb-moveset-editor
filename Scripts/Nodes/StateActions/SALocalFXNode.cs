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
	public class SALocalFXNode : StateActionNode
	{
		[Input(connectionType = ConnectionType.Override)] public StateAction NodeInput;
		public string Id;
		[Output(connectionType = ConnectionType.Override)] public LocalFXAction LocalFXAction;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.SALocalFX;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SALocalFX data, MovesetGraph graph, string assetPath, UnityEngine.Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SALocalFX));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			Id = data.Id;
			LocalFXAction = data.LocalFXAction;
			
			LocalFXActionNode node_LocalFXAction = graph.AddNode<LocalFXActionNode>();
			GetPort("LocalFXAction").Connect(node_LocalFXAction.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_LocalFXAction, assetPath);
			variableCount += node_LocalFXAction.SetData(LocalFXAction, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			
			return variableCount;
		}
		
		public new SALocalFX GetData()
		{
			SALocalFX objToReturn = new SALocalFX();
			objToReturn.TID = TypeId.SALocalFX;
			objToReturn.Id = Id;
			if (GetPort("LocalFXAction").ConnectionCount > 0)
			{
				LocalFXActionNode LocalFXAction_Node = (LocalFXActionNode)GetPort("LocalFXAction").GetConnection(0).node;
				objToReturn.LocalFXAction = LocalFXAction_Node.GetData();
			}
			return objToReturn;
		}
	}
}

