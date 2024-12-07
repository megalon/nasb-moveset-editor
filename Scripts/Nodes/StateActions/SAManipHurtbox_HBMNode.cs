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
	public class SAManipHurtBox_HBMNode : StateActionNode
	{
		[Input(connectionType = ConnectionType.Override)] public SAManipHurtBox.HBM NodeInput;
		public SAManipHurtBox.Manip Manip;
		public int HurtBox;
		[Output(connectionType = ConnectionType.Override)] public FloatSourceContainer Value;
		public HurtType HurtType;
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
		
		public int SetData(SAManipHurtBox.HBM data, MovesetGraph graph, string assetPath, UnityEngine.Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SAManipHurtBox.HBM));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			Manip = data.Manip;
			HurtBox = data.HurtBox;
			Value = data.Value;
			
			FloatSourceContainerNode node_Value = graph.AddNode<FloatSourceContainerNode>();
			GetPort("Value").Connect(node_Value.GetPort("NodeInput"));
			AssetDatabase.AddObjectToAsset(node_Value, assetPath);
			variableCount += node_Value.SetData(Value, graph, assetPath, nodeDepthXY + new UnityEngine.Vector2(1, variableCount));
			++variableCount;
			
			HurtType = data.HurtType;
			Bone = data.Bone;
			Bone2 = data.Bone2;
			return variableCount;
		}
		
		public SAManipHurtBox.HBM GetData()
		{
			SAManipHurtBox.HBM objToReturn = new SAManipHurtBox.HBM();
			objToReturn.Manip = Manip;
			objToReturn.HurtBox = HurtBox;
			if (GetPort("Value").ConnectionCount > 0)
			{
				FloatSourceContainerNode FloatSourceContainer_Node = (FloatSourceContainerNode)GetPort("Value").GetConnection(0).node;
				objToReturn.Value = FloatSourceContainer_Node.GetData();
			}
			objToReturn.HurtType = HurtType;
			objToReturn.Bone = Bone;
			objToReturn.Bone2 = Bone2;
			return objToReturn;
		}
	}
}

