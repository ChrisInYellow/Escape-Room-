using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Desk))]
public class DeskEditor : Editor {

	public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        Desk desk = (Desk)target;
        if (GUILayout.Button("Open"))
        {
            desk.Open();
        }
    }
}
