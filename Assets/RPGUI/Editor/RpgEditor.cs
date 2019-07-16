using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
[CustomEditor(typeof(Page))]
public class RpgEditor : Editor
{
   
   public override void OnInspectorGUI()
   {
       Page page = (Page)target;
        base.OnInspectorGUI();

        if (GUILayout.Button("Update card"))
        {
            page.UpdateValeus();
        }
   }
}
