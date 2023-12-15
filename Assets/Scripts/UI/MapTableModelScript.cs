using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapTableModelScript : MonoBehaviour
{
    public GameObject uiF;
    //public GameObject ui;
    public Transform player;
    public float minDis;
    public GameObject button;
    public PlayerMovement2 playerScript;
    public GameObject ui;
    public HouseUIanim animScript;
    public bool isUiOpen;
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
                ui.SetActive(true);
                playerScript.canMove =false;
                animScript.anim.SetBool("isOpen",true);
                isUiOpen=true;  
            }
        }else{
            uiF.SetActive(false);
            
        }
    }
    public void CloseUI(){
        ui.SetActive(false);
        animScript.anim.SetBool("isOpen",false);
        //isUiOpen=false;
        playerScript.canMove = true;
        // StartCoroutine(WaitASec());
        FindObjectOfType<AudioManager>().Play("ColectResorce");
        playerScript.canShoot1=true;
        
        
        
    }
    // IEnumerator WaitASec(){
       
    //     yield return new WaitForSeconds(0.5f);
    //     // ui.SetActive(false);
    // }
}
