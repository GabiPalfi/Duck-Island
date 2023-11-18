using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HatUiIcon : MonoBehaviour
{
    public GameObject icon;
    public int index;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(index==1){
            if(GameManager.cookHat>0){
                icon.SetActive(true);
            }else{
                icon.SetActive(false);
            }
        }
         if(index==2){
            if(GameManager.collageHat>0){
                icon.SetActive(true);
            }else{
                icon.SetActive(false);
            }
        }
         if(index==3){
            if(GameManager.japanHat>0){
                icon.SetActive(true);
            }else{
                icon.SetActive(false);
            }
        }
         if(index==4){
            if(GameManager.cristamsHat>0){
                icon.SetActive(true);
            }else{
                icon.SetActive(false);
            }
        }
         if(index==5){
            if(GameManager.astronautHat>0){
                icon.SetActive(true);
            }else{
                icon.SetActive(false);
            }
        }
         if(index==6){
            if(GameManager.partyHat>0){
                icon.SetActive(true);
            }else{
                icon.SetActive(false);
            }
        }
         if(index==7){
            if(GameManager.fancyHat>0){
                icon.SetActive(true);
            }else{
                icon.SetActive(false);
            }
        }
         if(index==8){
            if(GameManager.soliderHat>0){
                icon.SetActive(true);
            }else{
                icon.SetActive(false);
            }
        }
         if(index==9){
            if(GameManager.vikingHat>0){
                icon.SetActive(true);
            }else{
                icon.SetActive(false);
            }
        }
         if(index==10){
            if(GameManager.mailmanHat>0){
                icon.SetActive(true);
            }else{
                icon.SetActive(false);
            }
        }
    }
}
