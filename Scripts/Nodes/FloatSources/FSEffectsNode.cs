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
	public class FSEffectsNode : FloatSourceNode
	{
		public string LocalFxId;
		public MovesetParser.FloatSources.FSEffects.EffectsAttribute Attribute;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.FSEffects;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(FSEffects data, MovesetGraph graph, string assetPath, UnityEngine.Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(FSEffects));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			LocalFxId = data.LocalFxId;
			Attribute = data.Attribute;
			return variableCount;
		}
		
		public new FSEffects GetData()
		{
			FSEffects objToReturn = new FSEffects();
			objToReturn.TID = TypeId.FSEffects;
			objToReturn.LocalFxId = LocalFxId;
			objToReturn.Attribute = Attribute;
			return objToReturn;
		}
	}
}

