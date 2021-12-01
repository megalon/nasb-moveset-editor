using System;
using UnityEngine;
using XNode;
using System.Collections.Generic;


namespace NASB_Moveset_Editor
{
    [Serializable]
    public class MovesetGraph : NodeGraph {
        // public string happens = "testing";

        private void OnEnable()
        {
            Utils.SetupUtils();
        }
    }
}