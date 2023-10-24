using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FarmSlider : MonoBehaviour
{
    public Slider slider;
    public FarmUiScript farm;
    
    // Start is called before the first frame update
    void Start()
    {
        slider.maxValue = farm.maxTime;
        slider.value = farm.currentTime;
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = GameManager.currentTime1;
    }
}
