using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;
using XNode;
using XNodeEditor;

namespace NASB_Moveset_Editor
{
	[CustomNodeGraphEditor(typeof(MovesetGraph), Consts.KEY_NAMESPACE + "MOVESET_GRAPH_SETTINGS")]
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
				if (Consts.NodesToIgnore.Contains(type.Name)) return null;

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

		public override NodeEditorPreferences.Settings GetDefaultPreferences()
		{
			return new NodeEditorPreferences.Settings()
			{
				noodlePath = NoodlePath.Angled,
				noodleThickness = 5,
				portTooltips = true,
				tintColor = new Color32(85, 85, 85, 255)
			};
		}

		private void SetupInsetGraphName()
		{
			string graphPath = AssetDatabase.GetAssetPath(base.serializedObject.targetObject);

			try
			{
				graphPath = graphPath.Substring(graphPath.IndexOf($"{Consts.GRAPH_FOLDER_NAME}") + Consts.GRAPH_FOLDER_NAME.Length + 1);
				graphPath = graphPath.Substring(0, graphPath.Length - ".asset".Length);
				graphParentName = graphPath.Substring(0, graphPath.IndexOf("/"));
				graphSubName = graphPath.Substring(graphParentName.Length + 1);
			} catch
			{
				graphParentName = graphPath;
			}
		}

        public override void AddContextMenuItems(GenericMenu menu, Type compatibleType = null, NodePort.IO direction = NodePort.IO.Input)
        {
			Vector2 pos = NodeEditorWindow.current.WindowToGridPosition(Event.current.mousePosition);

			if (compatibleType != null)
			{
				Type[] nodeTypes;

				// If this is a list, get the type of the item in the list, then find nodes that have inputs for that type
				if (typeof(IEnumerable).IsAssignableFrom(compatibleType) && compatibleType != typeof(string))
				{
					Type subType = Type.GetType(compatibleType.GenericTypeArguments[0].AssemblyQualifiedName);
					nodeTypes = NodeEditorUtilities.GetCompatibleNodesTypes(NodeEditorReflection.nodeTypes, subType, direction).OrderBy(GetNodeMenuOrder).ToArray();
				}
				else if (NodeEditorPreferences.GetSettings().createFilter)
				{
					nodeTypes = NodeEditorUtilities.GetCompatibleNodesTypes(NodeEditorReflection.nodeTypes, compatibleType, direction).OrderBy(GetNodeMenuOrder).ToArray();
				}
				else
				{
					nodeTypes = NodeEditorReflection.nodeTypes.OrderBy(GetNodeMenuOrder).ToArray();
				}

				for (int i = 0; i < nodeTypes.Length; i++)
				{
					Type type = nodeTypes[i];

					//Get node context menu path
					string path = GetNodeMenuName(type);
					if (string.IsNullOrEmpty(path)) continue;

					// Check if user is allowed to add more of given node type
					XNode.Node.DisallowMultipleNodesAttribute disallowAttrib;
					bool disallowed = false;
					if (NodeEditorUtilities.GetAttrib(type, out disallowAttrib))
					{
						int typeCount = target.nodes.Count(x => x.GetType() == type);
						if (typeCount >= disallowAttrib.max) disallowed = true;
					}

					// Add node entry to context menu
					if (disallowed) menu.AddItem(new GUIContent(path), false, null);
					else menu.AddItem(new GUIContent(path), false, () => {
						XNode.Node node = CreateNode(type, pos);
						NodeEditorWindow.current.AutoConnect(node);
					});
				}
			}
			base.AddContextMenuItems(menu, compatibleType, direction);
			menu.AddSeparator("");
			menu.AddItem(new GUIContent("Organize Graph"), false, () => GraphHandler.CheckOrganizeGraph());
        }
    }
}