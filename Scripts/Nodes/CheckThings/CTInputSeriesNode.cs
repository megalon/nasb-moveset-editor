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
using static MovesetParser.CheckThings.CheckThing;
using static MovesetParser.CheckThings.CTInputSeries;

namespace NASB_Moveset_Editor.CheckThings
{
	public class CTInputSeriesNode : CheckThingNode
	{
		[Input(connectionType = ConnectionType.Override)] public CheckThing NodeInput;
		public int CheckFrames;
		public LookForInput[] InputSeries;
		public LookForInput[] StopLooking;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.CTInputSeries;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(CTInputSeries data, MovesetGraph graph, string assetPath, UnityEngine.Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(CTInputSeries));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			CheckFrames = data.CheckFrames;
			InputSeries = data.InputSeries;
			StopLooking = data.StopLooking;
			return variableCount;
		}
		
		public new CTInputSeries GetData()
		{
			CTInputSeries objToReturn = new CTInputSeries();
			objToReturn.TID = TypeId.CTInputSeries;
			objToReturn.CheckFrames = CheckFrames;
			objToReturn.InputSeries = InputSeries;
			objToReturn.StopLooking = StopLooking;
			return objToReturn;
		}
	}
}

