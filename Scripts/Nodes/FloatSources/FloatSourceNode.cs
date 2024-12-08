// * 
// * 
// * This file was generated using NASB_Parser_to_xNode by megalon2d
// * https://github.com/megalon/NASB_Parser_to_xNode
// * 
// * 
using MovesetParser.BulkSerialize;
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
using static MovesetParser.FloatSources.FloatSource;

namespace NASB_Moveset_Editor.FloatSources
{
	public class FloatSourceNode : BaseMovesetNode
	{
		[Input(connectionType = ConnectionType.Override)] public FloatSource NodeInput;
		[HideInInspector] public MovesetParser.FloatSources.FloatSource.TypeId TID;
		public float Value;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.FloatSource;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(FloatSource data, MovesetGraph graph, string assetPath, UnityEngine.Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(FloatSource));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			TID = data.TID;
			Value = data.Value;
			return variableCount;
		}
		
		public FloatSource GetData()
		{
			FloatSource objToReturn = new FloatSource();
			objToReturn.TID = TypeId.FloatSource;
			objToReturn.TID = TID;
			objToReturn.Value = Value;
			return objToReturn;
		}
	}
}

