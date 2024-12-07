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
using static MovesetParser.StateActions.SAMapAnimation;

namespace NASB_Moveset_Editor.StateActions
{
	public class SAMapAnimationNode : StateActionNode
	{
		[Input(connectionType = ConnectionType.Override)] public StateAction NodeInput;
		public MapPoint[] MapPoints;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.SAMapAnimation;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SAMapAnimation data, MovesetGraph graph, string assetPath, UnityEngine.Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SAMapAnimation));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			MapPoints = data.MapPoints;
			return variableCount;
		}
		
		public new SAMapAnimation GetData()
		{
			SAMapAnimation objToReturn = new SAMapAnimation();
			objToReturn.TID = TypeId.SAMapAnimation;
			objToReturn.MapPoints = MapPoints;
			return objToReturn;
		}
	}
}

