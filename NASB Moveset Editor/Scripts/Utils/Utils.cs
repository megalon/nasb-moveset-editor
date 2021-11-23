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
            var mainDir = Path.GetDirectoryName(Path.GetDirectoryName(GetAssetPathFromDB("GraphHandler")));
            return Path.Combine(mainDir, "Graphs");
        }

        public static string GetNodesDirPath()
        {
            var mainDir = Path.GetDirectoryName(GetAssetPathFromDB("BaseMovesetNode"));
            return mainDir;
        }

        private static string GetAssetPathFromDB(string scriptName)
        {
            var scriptsFromDB = AssetDatabase.FindAssets($"t:Script {scriptName}");
            var scriptPath = AssetDatabase.GUIDToAssetPath(scriptsFromDB[0]);
            foreach (string scriptGUID in scriptsFromDB)
            {
                string path = AssetDatabase.GUIDToAssetPath(scriptGUID);
                if (Path.GetFileNameWithoutExtension(path).Equals(scriptName))
                {
                    scriptPath = path;
                }
            }
            return scriptPath;
        }
    }

    public static class Consts
    {
        public static float NodeXOffset = 250f;
        public static float NodeYOffset = 130f;
        public static float NodeVarHeight = 20f;
        public static int MaxDisplayNameLength = 12;
    }
}
