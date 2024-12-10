// * 
// * 
// * This file was generated using NASB_Parser_to_xNode by megalon2d
// * https://github.com/megalon/NASB_Parser_to_xNode
// * 
// * 
using UnityEngine;
using UnityEditor;
using XNode;
using XNodeEditor;
using MovesetParser;
using MovesetParser.CheckThings;
using MovesetParser.FloatSources;
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

namespace NASB_Moveset_Editor.StateActions
{
	public class SAManipHitBox_HBMNode : StateActionNode
	{
		[Input(connectionType = ConnectionType.Override)] public SAManipHitBox.HBM NodeInput;
		public SAManipHitBox.Manip Manip;
		public int HitBox;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer Value;
		public string Bone;
		public string Bone2;
		
		protected override void Init()
		{
			base.Init();
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SAManipHitBox.HBM data, MovesetGraph graph, string assetPath, UnityEngine.Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SAManipHitBox.HBM));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			Manip = data.Manip;
			HitBox = data.HitBox;
			Value = data.Value;
			
			FloatSourceContainerNode node_Value = graph.AddNode<FloatSourceContainerNode>();
			GetPort("Value").Connect(node_Value.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_Value, assetPath);
			variableCount += node_Value.SetData(Value, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			Bone = data.Bone;
			Bone2 = data.Bone2;
			return variableCount;
		}
		
		public SAManipHitBox.HBM GetData()
		{
			SAManipHitBox.HBM objToReturn = new SAManipHitBox.HBM();
			objToReturn.Manip = Manip;
			objToReturn.HitBox = HitBox;
			if (GetPort("Value").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("Value").GetConnection(0).node;
				objToReturn.Value = FloatSourceContainer_Node.GetData();
			}
			objToReturn.Bone = Bone;
			objToReturn.Bone2 = Bone2;
			return objToReturn;
		}
	}
}

