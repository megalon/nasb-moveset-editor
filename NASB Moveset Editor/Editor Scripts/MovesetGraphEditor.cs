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
		private string graphParentName;
		private string graphSubName;
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
			window.titleContent = new GUIContent(Consts.PROJECT_NAME);

			titleStyle = new GUIStyle();
			titleStyle.fontSize = 25;
			titleStyle.normal.textColor = new Color32(128, 128, 128, 255);

			titleRect = new Rect(windowPadding, windowPadding, window.position.width - windowPadding, window.position.height - windowPadding);
		}

        public override void OnOpen()
        {
            base.OnOpen();

			SetupInsetGraphName();
		}

		public override void OnWindowFocus()
		{
			base.OnWindowFocus();

			SetupInsetGraphName();
		}

		public override void OnGUI()
        {
            base.OnGUI();

			GUILayout.BeginArea(titleRect);
			EditorGUILayout.LabelField(graphParentName, titleStyle);
			EditorGUILayout.Space(windowPadding * 0.66f);
			EditorGUILayout.LabelField(graphSubName, titleStyle);
			GUILayout.EndArea();
        }

		private void SetupInsetGraphName()
        {
			string graphPath = AssetDatabase.GetAssetPath(base.serializedObject.targetObject);

			try
            {
				graphPath = graphPath.Substring(graphPath.IndexOf("NASB Moveset Editor/Graphs/") + "NASB Moveset Editor/Graphs/".Length);
				graphPath = graphPath.Substring(0, graphPath.Length - ".asset".Length);
				graphParentName = graphPath.Substring(0, graphPath.IndexOf("/"));
				graphSubName = graphPath.Substring(graphParentName.Length + 1);
			} catch
            {
				graphParentName = graphPath;
			}
		}
    }
}