using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
[CustomEditor (typeof(Mapgen))]
public class MapGeneratorEditor : Editor {

    public override void OnInspectorGUI()
    {
        Mapgen MapGen = (Mapgen)target;

        if(DrawDefaultInspector());
        if (MapGen.autoUpdate)
        {
            MapGen.GenerateMap();
        }
        if (GUILayout.Button("Generate"))
        {
            MapGen.GenerateMap();
        }
    }
}
