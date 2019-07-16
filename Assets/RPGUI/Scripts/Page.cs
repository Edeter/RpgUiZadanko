using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Page : MonoBehaviour
{
    [Header("Charcter")]
   
   public TextMeshProUGUI Name;
   public Image Avatar;

   public GameObject level;

   [Header("Info")]

   public GameObject tgen;
   public GameObject sgen;

   public GameObject statsgen;

[Header("UI constants")]
    public Pageobj global;

[Header("UI Data")]
public Infoso dane;
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        level.GetComponent<Slider>().value = dane.exp;
        level.GetComponentInChildren<TextMeshProUGUI>().text = dane.level.ToString();
        level.GetComponent<Slider>().maxValue = dane.maxexp;
    }
    public void setvaleus()
    {
        Name.text = dane.heroname;
        Avatar.sprite = dane.herosprite;
    }

    public void hide(bool what)
    {
        gameObject.SetActive(what);
    }

    public void UpdateValeus()
    {setvaleus();
         tgen.GetComponent<Traitsgenerator>().Generate();
        sgen.GetComponent<Skillsgenerator>().Generate();
        statsgen.GetComponent<StatsGenerator>().Generate();
    }

}
