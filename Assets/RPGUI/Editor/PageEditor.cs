using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
[CustomEditor(typeof(Pageobj))]
public class PageEditor : Editor
{

    
    
    public override void OnInspectorGUI()
    {
        
        Pageobj obj = (Pageobj)target;
       // serializedObject.Update();
        base.OnInspectorGUI();
       // EditorGUILayout.PropertyField(serializedObject.FindProperty("tak"),true);
       // EditorGUILayout.PropertyField(serializedObject.FindProperty("element 0"),true);
        //serializedObject.ApplyModifiedProperties();
        GUILayout.Space(10);
        if(GUILayout.Button("add Skill"))
        {
                obj.Skills.Add(new Skill(obj.newname,obj.newsprite,obj.Skills.Count));
                
        }
        GUILayout.Space(10);
        if(GUILayout.Button("add Trait"))
        {
                obj.Traits.Add(new Skill(obj.newtraitname,obj.newtraitsprite,obj.Skills.Count));
        }
        GUILayout.Space(10);
        if(GUILayout.Button("add Stat"))
        {
                obj.Stats.Add(obj.Statname);
        }
        
        
    }
}
