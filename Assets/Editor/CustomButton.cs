using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
//not using
[CustomEditor(typeof(SpecialButton))]
public class CustomButton : Editor
{
    public override void OnInspectorGUI()
    {
        SpecialButton specialButton = (SpecialButton)target;
       
       specialButton.acceptsPointerInput = 
            EditorGUILayout.Toggle("Accepts pointer input", specialButton.acceptsPointerInput);
        EditorUtility.SetDirty(target);
        // DrawDefaultInspector();
       base.OnInspectorGUI();
    }

}
