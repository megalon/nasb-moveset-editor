using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

namespace NASB_Moveset_Editor
{
    public class Utils : MonoBehaviour
    {
        public static string GetGraphsDirPath()
        {
            var scriptFromDB = AssetDatabase.FindAssets("t:Script GraphHandler");
            var mainDir = Path.GetDirectoryName(Path.GetDirectoryName(AssetDatabase.GUIDToAssetPath(scriptFromDB[0])));
            return Path.Combine(mainDir, "Graphs");
        }
    }

    // Empty class for blank outputs
    [Serializable]
    public class Empty { }

    public static class Consts
    {
        public static float NodeXOffset = 250f;
        // public static float NodeYOffset = 20f;
        // public static float NodeHeight = 60f;
        public static float NodeYOffset = 120f;
        public static float NodeVarHeight = 20f;
    }
}
