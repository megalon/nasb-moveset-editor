// * 
// * 
// * This file was generated using MovesetParser_to_xNode by megalon2d
// * https://github.com/megalon/MovesetParser_to_xNode
// * 
// * 
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEditor;
using XNode;
using XNodeEditor;
using MovesetParser;
using MovesetParser.FloatSources;
using MovesetParser.Jumps;
using MovesetParser.CheckThings;
using MovesetParser.StateActions;
using MovesetParser.ObjectSources;
using NASB_Moveset_Editor.FloatSources;
using NASB_Moveset_Editor.Jumps;
using NASB_Moveset_Editor.CheckThings;
using NASB_Moveset_Editor.StateActions;
using NASB_Moveset_Editor.ObjectSources;
using static MovesetParser.FloatSources.FloatSource;

namespace NASB_Moveset_Editor.FloatSources
{
	public class FSTimerNode : FloatSourceNode
	{
		[Input(connectionType = ConnectionType.Override)] public FloatSource NodeInput;
		public string Id;
		
		protected override void Init()
		{
			base.Init();
			TID = TypeId.TimerId;
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(FSTimer data, MovesetGraph graph, string assetPath, Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(FSTimer));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			Id = data.Id;
			return variableCount;
		}
		
		public new FSTimer GetData()
		{
			FSTimer objToReturn = new FSTimer();
			objToReturn.TID = TypeId.TimerId;
			objToReturn.Version = Version;
			objToReturn.Id = Id;
			return objToReturn;
		}
	}
}

