using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Skill 
{

    public string Name;
    public Sprite image;
    public int Index;
    public Skill(string name, Sprite sprite,int i)
    {
        Name = name;
        image = sprite;
        Index = i;
    }
    // Other properties, methods, events...


}
[System.Serializable]
public class Trait
{
    
    public string Name;
    public Sprite image;
    public Trait(string name, Sprite sprite)
    {
        Name = name;
        image = sprite;
    }
    // Other properties, methods, events...


}
