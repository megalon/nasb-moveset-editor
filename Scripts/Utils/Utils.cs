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
        public static Dictionary<NASB_Parser.FloatSources.FSFunc.FuncWay, FSFuncText> funcTextDict;

        public static void SetupUtils()
        {
            if (funcTextDict != null) return;
            funcTextDict = new Dictionary<NASB_Parser.FloatSources.FSFunc.FuncWay, FSFuncText>();
            funcTextDict.Add(NASB_Parser.FloatSources.FSFunc.FuncWay.Abs, new FSFuncText("Input"));
            funcTextDict.Add(NASB_Parser.FloatSources.FSFunc.FuncWay.Add, new FSFuncText("A", "B"));
            funcTextDict.Add(NASB_Parser.FloatSources.FSFunc.FuncWay.Sub, new FSFuncText("A", "B"));
            funcTextDict.Add(NASB_Parser.FloatSources.FSFunc.FuncWay.Div, new FSFuncText("A", "B"));
            funcTextDict.Add(NASB_Parser.FloatSources.FSFunc.FuncWay.Mult, new FSFuncText("A", "B"));
            funcTextDict.Add(NASB_Parser.FloatSources.FSFunc.FuncWay.Sin, new FSFuncText("Input Deg"));
            funcTextDict.Add(NASB_Parser.FloatSources.FSFunc.FuncWay.Cos, new FSFuncText("Input Deg"));
            funcTextDict.Add(NASB_Parser.FloatSources.FSFunc.FuncWay.Mod, new FSFuncText("A", "B"));
            funcTextDict.Add(NASB_Parser.FloatSources.FSFunc.FuncWay.Clamp, new FSFuncText("Input", "Min", "Max"));
            funcTextDict.Add(NASB_Parser.FloatSources.FSFunc.FuncWay.Floor, new FSFuncText("Input"));
            funcTextDict.Add(NASB_Parser.FloatSources.FSFunc.FuncWay.Ceil, new FSFuncText("Input"));
            funcTextDict.Add(NASB_Parser.FloatSources.FSFunc.FuncWay.MoveTo, new FSFuncText("Current", "Target", "Max Delta", "Mathf.MoveTowards(Current, Target, Max_Delta * Frames)"));
            funcTextDict.Add(NASB_Parser.FloatSources.FSFunc.FuncWay.MoveToAng, new FSFuncText("Current", "Target", "Max Delta", "Mathf.MoveTowardsAngle(Current, Target, Max_Delta * Frames)"));
            funcTextDict.Add(NASB_Parser.FloatSources.FSFunc.FuncWay.MoveToF, new FSFuncText("Current", "Target", "Max Delta", "Mathf.MoveTowards(Current, Target, Max_Delta * (Frames * Time_Per_Frame))"));
            funcTextDict.Add(NASB_Parser.FloatSources.FSFunc.FuncWay.MoveToAngF, new FSFuncText("Current", "Target", "Max Delta", "Mathf.MoveTowardsAngle(Current, Target, Max_Delta * (Frames * Time_Per_Frame))"));
            funcTextDict.Add(NASB_Parser.FloatSources.FSFunc.FuncWay.Sign, new FSFuncText("Input"));
            funcTextDict.Add(NASB_Parser.FloatSources.FSFunc.FuncWay.Lerp, new FSFuncText("A", "B", "T"));
            funcTextDict.Add(NASB_Parser.FloatSources.FSFunc.FuncWay.InvLerp, new FSFuncText("A", "B", "T"));
            funcTextDict.Add(NASB_Parser.FloatSources.FSFunc.FuncWay.Repeat, new FSFuncText("Input", "Length"));
            funcTextDict.Add(NASB_Parser.FloatSources.FSFunc.FuncWay.Pow, new FSFuncText("Input", "Power"));
            funcTextDict.Add(NASB_Parser.FloatSources.FSFunc.FuncWay.Sqrt, new FSFuncText("Input"));
            funcTextDict.Add(NASB_Parser.FloatSources.FSFunc.FuncWay.Log, new FSFuncText("Input"));
            funcTextDict.Add(NASB_Parser.FloatSources.FSFunc.FuncWay.Log10, new FSFuncText("Input"));
            funcTextDict.Add(NASB_Parser.FloatSources.FSFunc.FuncWay.Atan, new FSFuncText("Input"));
            funcTextDict.Add(NASB_Parser.FloatSources.FSFunc.FuncWay.Atan2, new FSFuncText("Y", "X"));
            funcTextDict.Add(NASB_Parser.FloatSources.FSFunc.FuncWay.RoundToInt, new FSFuncText("Input"));
            funcTextDict.Add(NASB_Parser.FloatSources.FSFunc.FuncWay.Max, new FSFuncText("A", "B"));
            funcTextDict.Add(NASB_Parser.FloatSources.FSFunc.FuncWay.Min, new FSFuncText("A", "B"));
            funcTextDict.Add(NASB_Parser.FloatSources.FSFunc.FuncWay.Pi, new FSFuncText());
        }

        public static string GetGraphsDirPath()
        {
            // var mainDir = Path.GetDirectoryName(Path.GetDirectoryName(GetAssetPathFromDB("GraphHandler")));
            return Path.Combine("Assets", "Editor", Consts.GRAPH_FOLDER_NAME);
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

    public static class Logger
    {
        private enum LogLevel
        {
            Info,
            Warning,
            Error
        }

        public static void LogInfo(string message) => Log(message, LogLevel.Info);
        public static void LogWarning(string message) => Log(message, LogLevel.Warning);
        public static void LogError(string message) => Log(message, LogLevel.Error);
        private static void Log(string message, LogLevel logLevel)
        {
            message = $"[{Consts.PROJECT_NAME}] " + message;
            switch (logLevel)
            {
                case LogLevel.Warning:
                    Debug.LogWarning(message);
                    break;
                case LogLevel.Error:
                    Debug.LogError(message);
                    break;
                default:
                    Debug.Log(message);
                    break;
            }
        }
    }

    public static class Consts
    {
        public const float NodeXOffset = 250f;
        public const float NodeYOffset = 130f;
        public const float NodeVarHeight = 20f;
        public const int MaxDisplayNameLength = 12;

        public const string VERSION = "0.1.7";
        public const string PROJECT_NAME = "NASB Moveset Editor";
        public const string GRAPH_FOLDER_NAME = "Moveset Graphs";

        public const string KEY_NAMESPACE = "NASB_MOVESET_EDITOR__";
        public const string KEY_SELECTED_ASSET_NAME = KEY_NAMESPACE + "SELECTED_ASSET_NAME";
        public const string KEY_NEW_GRAPH_TEXTASSET_NAME = KEY_NAMESPACE + "NEW_GRAPH_TEXTASSET_NAME";
        public const string KEY_NEW_GRAPH_STATE = KEY_NAMESPACE + "NEW_GRAPH_STATE";
        public const string KEY_IMPORT_PATH = KEY_NAMESPACE + "IMPORT_PATH";
        public const string KEY_EXPORT_PATH = KEY_NAMESPACE + "EXPORT_PATH";
    }

    public class FSFuncText
    {
        public Dictionary<string, GUIContent> ContainerContents;

        public FSFuncText() : this("", "", "", "") { }
        public FSFuncText(string AText) : this(AText, "", "", "") { }
        public FSFuncText(string AText, string BText) : this(AText, BText, "", "") { }
        public FSFuncText(string AText, string BText, string CText) : this(AText, BText, CText, "") { }

        public FSFuncText(string AText, string BText, string CText, string Formula)
        {
            ContainerContents = new Dictionary<string, GUIContent>();
            ContainerContents.Add("ContainerA", new GUIContent(AText));
            ContainerContents.Add("ContainerB", new GUIContent(BText));
            ContainerContents.Add("ContainerC", new GUIContent(CText));
            ContainerContents.Add("Formula", new GUIContent("Formula (Hover to view)", Formula));
        }
    }
}
