﻿using System;
using UnityEngine;
using XNode;
using System.Collections.Generic;
using UnityEditor;

namespace NASB_Moveset_Editor
{
    [Serializable]
    public class MovesetGraph : NodeGraph
    {
        [HideInInspector][SerializeField]
        private string editorVersion;

        private void OnEnable()
        {
            Utils.SetupUtils();

            SemanticVersion editorVersion = new SemanticVersion(Consts.VERSION);
            SemanticVersion graphVersion = null;

            string assetPath = AssetDatabase.GetAssetPath(this);

            if (this.editorVersion != null && !this.editorVersion.Equals(string.Empty))
            {
                graphVersion = new SemanticVersion(this.editorVersion);
            }

            if (graphVersion == null)
            {
                // If this is an existing graph with no version number
                if (nodes.Count > 0)
                {
                    Logger.LogWarning($"Graph {name} was made with an old version of the Moveset Editor. It may not export correctly!\n{assetPath}");
                } else
                {
                    // Graph has no nodes, assume this is a new graph, so set the version
                    this.editorVersion = Consts.VERSION;
                }
            } else
            {
                if (graphVersion < editorVersion)
                {
                    Logger.LogWarning($"Graph was built on older editor version {graphVersion.ToString()}!\n{assetPath}");
                } else if (graphVersion > editorVersion)
                {
                    Logger.LogError($"Graph {name} was built on a NEWER editor version {graphVersion.ToString()}! Please upgrade your editor!\n{assetPath}");
                } else
                {
                    // Graph was made with current version of editor
                }
            }
        }
    }
}