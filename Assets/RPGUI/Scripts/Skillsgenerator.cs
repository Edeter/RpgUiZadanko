using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Skillsgenerator : MonoBehaviour
{

    [SerializeField] Pageobj obj;
    [SerializeField] Infoso dane;

    [SerializeField] GameObject skillprefab;

    GameObject[] updatelist;

    
    // Start is called before the first frame update
    void Start()
    {
        updatelist = new GameObject[obj.Skills.Count];
        for(int i=0; i<obj.Skills.Count;i++)
        {
                updatelist[i] = transform.GetChild(i).gameObject;
        }
        //Generate();
    }

    // Update is called once per frame
    void Update()
    {
            for (int i = 0; i < obj.Skills.Count; i++)
        {
            updatelist[i].transform.GetChild(0).GetComponent<Slider>().value = dane.Skillinfos[i];
        }
    }

    public void Generate()
    {
        if (transform.childCount>obj.Skills.Count)
        {
            for (int i = obj.Skills.Count; i < transform.childCount; i++)
            {
                DestroyImmediate(transform.GetChild(i).gameObject);
            }
        }
        for (int i = 0;( i < obj.Skills.Count)&&(transform.childCount<obj.Skills.Count); i++)
    {
        GameObject temp;
        temp = Instantiate(skillprefab);
        temp.transform.parent= transform;
        temp.transform.GetChild(0).GetComponent<Slider>().value = dane.Skillinfos[i];
        temp.transform.GetChild(1).GetComponent<Image>().sprite = obj.Skills[i].image;
        temp.transform.GetChild(2).GetComponent<TMPro.TextMeshProUGUI>().text = obj.Skills[i].Name;
        temp.transform.localScale = new Vector3(1,1,1);
    }
        
    }
}
