using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TraitGenerator : MonoBehaviour
{
   
    [SerializeField] Pageobj obj;
    [SerializeField] Infoso dane;

    [SerializeField] GameObject skillprefab;

    GameObject[] updatelist;

    
    // Start is called before the first frame update
    void Start()
    {
        updatelist = new GameObject[obj.Traits.Count];
        Generate();
    }

    // Update is called once per frame
    void Update()
    {
            for (int i = 0; i < obj.Traits.Count; i++)
        {
            updatelist[i].transform.GetChild(0).GetComponent<Slider>().value = dane.Skillinfos[i];
        }
    }

    public void Generate()
    {for (int i = 0; i < obj.Traits.Count; i++)
    {
        GameObject temp;
        temp = Instantiate(skillprefab);
        updatelist[i] = temp;
        temp.transform.parent= transform;
        temp.transform.GetChild(0).GetComponent<Slider>().value = dane.Skillinfos[i];
        temp.transform.GetChild(1).GetComponent<Image>().sprite = obj.Traits[i].image;
        temp.transform.GetChild(2).GetComponent<TMPro.TextMeshProUGUI>().text = obj.Traits[i].Name;
        temp.transform.localScale = new Vector3(1,1,1);
    }
        
    }
}
