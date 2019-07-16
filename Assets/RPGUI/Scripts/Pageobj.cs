
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[CreateAssetMenu(fileName="page",menuName="page")]
public class Pageobj : ScriptableObject
{
[Header("Basics")]
public string heroname;
public Sprite herosprite;

[Header("New skill")]
public string newname;
public Sprite newsprite;

[Header("New trait")]
public string newtraitname;
public Sprite newtraitsprite;

[Header("New stat")]

public string Statname;


  [SerializeField] public List<Skill> Skills = new List<Skill>();

  [SerializeField] public List<Skill> Traits = new List<Skill>();

  [SerializeField] public List<string> Stats = new List<string>();
}
