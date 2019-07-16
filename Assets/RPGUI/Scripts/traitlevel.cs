using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class traitlevel : MonoBehaviour
{
    Slider slider;
    TextMeshProUGUI target;

    void Start()
    {
        slider = transform.parent.gameObject.GetComponent<Slider>();
        target = gameObject.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        target.text = slider.value.ToString();
    }
}
