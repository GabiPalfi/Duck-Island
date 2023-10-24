using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseFunctionalityScript : MonoBehaviour
{
    public GameObject uiF;
    public Transform player;
    public float minDis;
    public GameObject gameSaveUI;
    public HouseUIanim animScript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position,player.position);
        if(distance<minDis){
            if(GameManager.houseHasBeenBought){
                uiF.SetActive(true);
                //FindObjectOfType<AudioManager>().Play("UIbasicSound");
                if(Input.GetKeyDown(KeyCode.F)){
                    gameSaveUI.SetActive(true);
                    animScript.anim.SetBool("isOpen",true);
                }
            }
            
        }else{
            animScript.anim.SetBool("isOpen",false);
            gameSaveUI.SetActive(false);
            uiF.SetActive(false);
            
        }
    }
}
