using System;
using UnityEngine;
using XNode;
using System.Collections.Generic;

namespace NASB_Moveset_Editor
{
    [Serializable]
    public class MovesetGraph : NodeGraph {
        public string version;
        private SemanticVersion graphVersion;

        private void OnEnable()
        {
            Utils.SetupUtils();

            var editorVersion = StringToVersion(Consts.VERSION);

            if (graphVersion != null)
            {
                if (graphVersion < editorVersion)
                {
                    Logger.LogWarning($"Graph {name} was built on older editor version {graphVersion.ToString()}!");
                }
            } else
            {
                Logger.LogWarning($"Graph {name} has no version!");
            }
        }

        private SemanticVersion StringToVersion(string input)
        {
            string major = input.Substring(0, input.IndexOf('.'));
            string minor = input.Substring(input.IndexOf('.') + 1);
            minor = minor.Substring(0, minor.IndexOf('.'));
            string patch = input.Substring(input.LastIndexOf('.') + 1);
            return new SemanticVersion(int.Parse(major), int.Parse(minor), int.Parse(patch));
        }
    }
}