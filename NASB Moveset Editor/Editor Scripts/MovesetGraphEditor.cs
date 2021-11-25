using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using XNodeEditor;

namespace NASB_Moveset_Editor
{
	[CustomNodeGraphEditor(typeof(MovesetGraph))]
	public class MovesetGraphEditor : NodeGraphEditor
	{
		private string graphName;
		private GUIStyle titleStyle;
		private Rect titleRect;
		private int windowPadding = 20;

		public override string GetNodeMenuName(System.Type type)
		{
			if (type.Namespace != null && type.Namespace.StartsWith("NASB_Moveset_Editor"))
			{
				string nodeMenuName = base.GetNodeMenuName(type).Replace("NASB_Moveset_Editor/", "");

				// Organize State Action nodes
				if (nodeMenuName.Contains("State Actions/"))
                {
					string nodeName = nodeMenuName.Substring("State Actions/".Length);
					if (nodeName.StartsWith("SA"))
                    {
						string nameWithoutSA = nodeName.Substring("SA".Length).Trim();
						int alphaComp = string.Compare(nameWithoutSA, "N");
						if (alphaComp < 1)
							nodeName = "SA      A-M/" + nodeName;
						else
							nodeName = "SA      N-Z/" + nodeName;
					}
					nodeMenuName = "State Actions/" + nodeName;
				}
				return nodeMenuName;
			}
			else return null;
		}

        public override void OnCreate()
        {
            base.OnCreate();

			titleStyle = new GUIStyle();
			titleStyle.fontSize = 25;
			titleStyle.normal.textColor = new Color32(128, 128, 128, 255);

			string graphPath = AssetDatabase.GetAssetPath(base.serializedObject.targetObject);
			graphPath = graphPath.Substring(graphPath.IndexOf("NASB Moveset Editor/Graphs/") + "NASB Moveset Editor/Graphs/".Length);
			graphName = graphPath.Substring(0, graphPath.Length - ".asset".Length).Replace("/", " - ");
			window.titleContent = new GUIContent(Consts.PROJECT_NAME);
		}

        public override void OnGUI()
        {
            base.OnGUI();

			titleRect = new Rect(windowPadding, windowPadding, window.position.width - windowPadding, window.position.height - windowPadding);

			GUILayout.BeginArea(titleRect);
            EditorGUILayout.LabelField(graphName, titleStyle);
			GUILayout.EndArea();
        }
    }
}