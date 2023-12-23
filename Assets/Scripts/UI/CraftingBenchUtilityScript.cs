using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftingBenchUtilityScript : MonoBehaviour
{
    public GameObject uiF;
    public GameObject ui;
    public Transform player;
    public float minDis;
    public InventoryScript inventory;
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
            if(GameManager.craftingBenchHasBeenBought){
                uiF.SetActive(true);
                if(Input.GetKeyDown(KeyCode.F)){
                    FindObjectOfType<AudioManager>().Play("UIbasicSound");
                    ui.SetActive(true); 
                    if(isUiOpen ==false){
                        animScript.anim.SetBool("IsOpen",true);
                        isUiOpen=true;
                        playerScript.canMove=false;
                    }else{
                        animScript.anim.SetBool("IsOpen",false);
                        isUiOpen=false;
                        playerScript.canMove=true;
                    }
                    inventory.OpenInventory();
                   
                }
                if(isUiOpen==true){
                    if(Input.GetKeyDown(KeyCode.Tab) || Input.GetKeyDown(KeyCode.Escape)){
                        animScript.anim.SetBool("IsOpen",false);
                        isUiOpen=false;
                        playerScript.canMove=true;
                    }
                }
            }
            
        }else{
            //animScript.anim.SetBool("isOpen",false);
            //gameSaveUI.SetActive(false);
            //animScript.anim.SetBool("IsOpen",false);
            //ui.SetActive(false);
            //inventory.isInventoryOpen = false;
            //inventory.OpenInventory();
            uiF.SetActive(false);
            //isUiOpen=false;
            
        }
    }
}
