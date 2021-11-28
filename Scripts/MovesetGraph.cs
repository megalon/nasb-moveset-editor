using System;
using UnityEngine;
using XNode;
using System.Collections.Generic;


namespace NASB_Moveset_Editor
{
    [Serializable, CreateAssetMenu(fileName = "New Moveset Graph", menuName = "NASB Moveset Editor")]
    public class MovesetGraph : NodeGraph {
        // public string happens = "testing";

        private void OnEnable()
        {
            Utils.SetupUtils();
        }
    }
}