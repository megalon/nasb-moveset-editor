// * 
// * 
// * This file was generated using NASB_Parser_to_xNode by megalon2d
// * https://github.com/megalon/NASB_Parser_to_xNode
// * 
// * 
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEditor;
using XNode;
using XNodeEditor;
using NASB_Parser;
using NASB_Parser.FloatSources;
using NASB_Parser.Jumps;
using NASB_Parser.CheckThings;
using NASB_Parser.StateActions;
using NASB_Parser.ObjectSources;
using NASB_Moveset_Editor.FloatSources;
using NASB_Moveset_Editor.Jumps;
using NASB_Moveset_Editor.CheckThings;
using NASB_Moveset_Editor.StateActions;
using NASB_Moveset_Editor.ObjectSources;
using static NASB_Parser.ObjectSources.ObjectSource;

namespace NASB_Moveset_Editor.ObjectSources
{
	public class ObjectSourceNode : BaseMovesetNode
	{
		[Input(connectionType = ConnectionType.Override)] public ObjectSource NodeInput;
		[HideInInspector] public NASB_Parser.ObjectSources.ObjectSource.TypeId TID;
		[HideInInspector] public int Version;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.BaseIdentifier;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(ObjectSource data, MovesetGraph graph, string assetPath, Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(ObjectSource));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			TID = data.TID;
			Version = data.Version;
			return variableCount;
		}
		
		public ObjectSource GetData()
		{
			ObjectSource objToReturn = new ObjectSource();
			objToReturn.TID = TypeId.BaseIdentifier;
			objToReturn.Version = Version;
			objToReturn.TID = TID;
			objToReturn.Version = Version;
			return objToReturn;
		}
	}
}

