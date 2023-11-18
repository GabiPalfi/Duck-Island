using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boss1HealthSlider : MonoBehaviour
{
    public Slider slider;
    public int index;
    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        if(index==1){
            slider.value = BossBattleScript1.healthBar;
        }
        if(index==2){
            slider.value = Bos2Script.healthBar;
        }

        
    }
}
