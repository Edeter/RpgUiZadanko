using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Traitsgenerator : MonoBehaviour
{
       [SerializeField] Pageobj obj;
       
 [SerializeField] Infoso dane;
    [SerializeField] GameObject traitprefab;

    GameObject[] updatelist;
    // Start is called before the first frame update
    void Start()
    {updatelist = new GameObject[obj.Traits.Count];
        for(int i=0; i<obj.Traits.Count;i++)
        {
                updatelist[i] = transform.GetChild(i).gameObject;
        }
       // Generate();
    }

    // Update is called once per frame
    void Update()
    {
            for (int i = 0; i < obj.Traits.Count; i++)
        {
               updatelist[i].transform.GetChild(0).GetComponent<Slider>().value = dane.Traitsinfos[i];
        }
        
    }

    public void Generate()
    {
        for (int i = 0; i < transform.childCount; i++)
            {
                DestroyImmediate(transform.GetChild(i).gameObject);
            }
        for (int i = 0;( i < obj.Traits.Count)&&(transform.childCount<obj.Traits.Count); i++)
    {
        GameObject temp;
        temp = Instantiate(traitprefab);
        temp.transform.parent= transform;
        temp.transform.GetChild(0).GetComponent<Slider>().value = dane.Traitsinfos[i];
        temp.transform.GetChild(1).GetComponent<Image>().sprite = obj.Traits[i].image;
        temp.transform.GetChild(2).GetComponent<TMPro.TextMeshProUGUI>().text = obj.Traits[i].Name;
        temp.transform.localScale = new Vector3(1,1,1);
    }
        
    }
}
