using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tabchange : MonoBehaviour
{


    private void OnEnable() {
        
    }

    private void Start() {
        change(2);
    }
    public void change(int num)
    {
        for(int i=0;i<transform.childCount;i++)
        {
            transform.GetChild(i).gameObject.SetActive(num==i);
        }
    }
}
