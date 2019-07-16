using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="data",menuName="data")]
public class Infoso : ScriptableObject
{
  public Pageobj page;

  public int level;
  public int exp;
  public int maxexp;


private void OnEnable() {
 fill();   
}

[SerializeField] public List<int> Skillinfos = new List<int>();
[SerializeField] public List<int> Traitsinfos = new List<int>();

[SerializeField] public List<int> Statsinfos = new List<int>();
public void fill() {
    
    if (Skillinfos.Count>page.Skills.Count)
    {
        Skillinfos.RemoveRange(page.Skills.Count,Skillinfos.Count-page.Skills.Count);
    }

    for (int i = 0; i < page.Skills.Count; i++)
    {   
        if (Skillinfos.Count<page.Skills.Count)
        {
            Skillinfos.Add(0);
        }
        
    }

    if (Traitsinfos.Count>page.Traits.Count)
    {
        Traitsinfos.RemoveRange(page.Traits.Count,Traitsinfos.Count-page.Traits.Count);
    }

    for (int i = 0; i < page.Traits.Count; i++)
    {   
        if (Traitsinfos.Count<page.Traits.Count)
        {
            Traitsinfos.Add(0);
        }
        
    }

    if (Statsinfos.Count>page.Stats.Count)
    {
        Statsinfos.RemoveRange(page.Stats.Count,Skillinfos.Count-page.Stats.Count);
    }

    for (int i = 0; i < page.Stats.Count; i++)
    {   
        if (Statsinfos.Count<page.Stats.Count)
        {
            Statsinfos.Add(0);
        }
        
    }
}



}

