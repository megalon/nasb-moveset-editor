// * 
// * 
// * This file was generated using MovesetParser_to_xNode by megalon2d
// * https://github.com/megalon/MovesetParser_to_xNode
// * 
// * 
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

namespace NASB_Moveset_Editor.StateActions
{
	public class SAStandardInput_StandardConfigNode : StateActionNode
	{
		[Input(connectionType = ConnectionType.Override)] public SAStandardInput.StandardConfig NodeInput;
		public byte DontCheck0;
		public byte DontCheck1;
		public byte DontCheck2;
		public byte DontCheck3;
		
		protected override void Init()
		{
			base.Init();
		}
		
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public int SetData(SAStandardInput.StandardConfig data, MovesetGraph graph, string assetPath, Vector2 nodeDepthXY)
		{
			name = NodeEditorUtilities.NodeDefaultName(typeof(SAStandardInput.StandardConfig));
			position.x = nodeDepthXY.x * Consts.NodeXOffset;
			position.y = nodeDepthXY.y * Consts.NodeYOffset;
			int variableCount = 0;
			
			DontCheck0 = data.DontCheck0;
			DontCheck1 = data.DontCheck1;
			DontCheck2 = data.DontCheck2;
			DontCheck3 = data.DontCheck3;
			return variableCount;
		}
		
		public SAStandardInput.StandardConfig GetData()
		{
			SAStandardInput.StandardConfig objToReturn = new SAStandardInput.StandardConfig();
			objToReturn.DontCheck0 = DontCheck0;
			objToReturn.DontCheck1 = DontCheck1;
			objToReturn.DontCheck2 = DontCheck2;
			objToReturn.DontCheck3 = DontCheck3;
			return objToReturn;
		}
	}
}

