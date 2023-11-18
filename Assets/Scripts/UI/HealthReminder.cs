using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthReminder : MonoBehaviour
{
    public GameObject ui;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.bandageCount>0&&PlayerMovement2.staticHealth<5){
            ui.SetActive(true);
        }else{
            ui.SetActive(false);
        }
    }
}
