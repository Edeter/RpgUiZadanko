using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
[CustomEditor(typeof(Infoso))]
public class InfosEditor : Editor
{
    Infoso temp;
    // Start is called before the first frame update
    private void OnEnable() {
        temp = (Infoso)target;
    }
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        temp.fill();
    }
}
