using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class StatsGenerator : MonoBehaviour
{

        [SerializeField] Pageobj obj;
    [SerializeField] Infoso dane;

    [SerializeField] GameObject skillprefab;

    GameObject[] updatelist;
    // Start is called before the first frame update
    void Start()
    {
         updatelist = new GameObject[obj.Stats.Count];
        for(int i=0; i<obj.Stats.Count;i++)
        {
                updatelist[i] = transform.GetChild(i).gameObject;
        }
    }

    // Update is called once per frame
    void Update()
    {
            for (int i = 0; i < obj.Stats.Count; i++)
        {
            updatelist[i].transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = dane.Statsinfos[i].ToString();
        }
    }

    public void Generate()
    {
            for (int i = 0; i < transform.childCount; i++)
            {
                DestroyImmediate(transform.GetChild(i).gameObject);
            }
        
        for (int i = 0;( i < obj.Stats.Count)&&(transform.childCount<obj.Stats.Count); i++)
    {
        GameObject temp;
        temp = Instantiate(skillprefab);
        temp.transform.parent= transform;
        temp.transform.GetComponent<TMPro.TextMeshProUGUI>().text = obj.Stats[i];
        temp.transform.localScale = new Vector3(1,1,1);
    }
        
    }
}
