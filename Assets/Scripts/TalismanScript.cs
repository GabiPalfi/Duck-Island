using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalismanScript : MonoBehaviour
{
    public int index;
    // Start is called before the first frame update
    void Start()
    {
        if(index==1){
            if(GameManager.eyeTalisman>0){
                gameObject.SetActive(false);
            }else{
                gameObject.SetActive(true);
            }
        }
        if(index==2){
            if(GameManager.slashTalisman>0){
                gameObject.SetActive(false);
            }else{
                gameObject.SetActive(true);
            }
        }
        if(index==3){
            if(GameManager.healthTalisman>0){
                gameObject.SetActive(false);
            }else{
                gameObject.SetActive(true);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
