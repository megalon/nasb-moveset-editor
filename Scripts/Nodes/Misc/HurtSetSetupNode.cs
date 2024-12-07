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
using static MovesetParser.Misc.HurtSetSetup;

namespace NASB_Moveset_Editor.Misc
{
	public class HurtSetSetupNode : BaseMovesetNode
	{
		[Input(connectionType = ConnectionType.Override)] public HurtSetSetup NodeInput;
		public HurtBone[] HurtBones;
		
		protected override void Init()
		{
			base.Init();
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(HurtSetSetup data, MovesetGraph graph, string assetPath, UnityEngine.Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(HurtSetSetup));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			HurtBones = data.HurtBones;
			return variableCount;
		}
		
		public HurtSetSetup GetData()
		{
			HurtSetSetup objToReturn = new HurtSetSetup();
			objToReturn.HurtBones = HurtBones;
			return objToReturn;
		}
	}
}
