// * 
// * 
// * This file was generated using NASB_Parser_to_xNode by megalon2d
// * https://github.com/megalon/NASB_Parser_to_xNode
// * 
// * 
using MovesetParser.BulkSerialize;
using MovesetParser.FloatSources;
using UnityEngine;
using UnityEditor;
using XNode;
using XNodeEditor;
using MovesetParser;
using MovesetParser.CheckThings;
using MovesetParser.Jumps;
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
	public class SAPersistLocalFXNode : StateActionNode
	{
		[Input(connectionType = ConnectionType.Override)] public StateAction NodeInput;
		public string Id;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer Persist;
		public bool MaxOut;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.SAPersistLocalFX;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SAPersistLocalFX data, MovesetGraph graph, string assetPath, UnityEngine.Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SAPersistLocalFX));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			Id = data.Id;
			Persist = data.Persist;
			
			FloatSourceContainerNode node_Persist = graph.AddNode<FloatSourceContainerNode>();
			GetPort("Persist").Connect(node_Persist.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_Persist, assetPath);
			variableCount += node_Persist.SetData(Persist, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			MaxOut = data.MaxOut;
			return variableCount;
		}
		
		public new SAPersistLocalFX GetData()
		{
			SAPersistLocalFX objToReturn = new SAPersistLocalFX();
			objToReturn.TID = TypeId.SAPersistLocalFX;
			objToReturn.Id = Id;
			if (GetPort("Persist").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("Persist").GetConnection(0).node;
				objToReturn.Persist = FloatSourceContainer_Node.GetData();
			}
			objToReturn.MaxOut = MaxOut;
			return objToReturn;
		}
	}
}

