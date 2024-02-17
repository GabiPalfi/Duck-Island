using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WardrobFunctionality : MonoBehaviour
{
    public GameObject uiF;
    public Transform player;
    public float minDis;
    public GameObject ui;
    public HouseUIanim animScript;
    public bool isUiOpen;
    public PlayerMovement2 playerScript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position,player.position);
        if(distance<minDis){
            uiF.SetActive(true);
            if(Input.GetKeyDown(KeyCode.F)){
                FindObjectOfType<AudioManager>().Play("UIbasicSound");
                ui.SetActive(true); 
                if(isUiOpen ==false){
                    animScript.anim.SetBool("isOpen",true);
                    isUiOpen=true;
                    playerScript.canMove=false;
                    playerScript.canShoot1=false;
                }else{
                    animScript.anim.SetBool("isOpen",false);
                    isUiOpen=false;
                    playerScript.canMove=true;
                    playerScript.canShoot1=true;
                }   
            }    
    
        }else{
            uiF.SetActive(false);
        }
    }
    public void Close(){
        animScript.anim.SetBool("isOpen",false);
        isUiOpen=false;
        playerScript.canMove=true;
        playerScript.canShoot1=true;
        FindObjectOfType<AudioManager>().Play("ColectResorce");
    }
    public void Sound(){
        FindObjectOfType<AudioManager>().Play("ColectResorce");
    }
}
