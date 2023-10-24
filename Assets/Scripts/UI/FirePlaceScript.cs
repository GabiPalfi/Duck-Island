using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePlaceScript : MonoBehaviour
{
    public GameObject uiF;
    public GameObject ui;
    public Transform player;
    public float minDis;
    public PlayerMovement2 playerScript;
    public bool isUIopen;
    public int stonePrice;
    public int grassPrice;
    public int woodPrice;
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
            uiF.SetActive(true);
            
            if(Input.GetKeyDown(KeyCode.F)){
                isUIopen = true;
                FindObjectOfType<AudioManager>().Play("UIbasicSound");
                ui.SetActive(true);
                animScript.anim.SetBool("isOpen",true);
                
                
            }
        }else{
            uiF.SetActive(false);
            isUIopen = false;
            animScript.anim.SetBool("isOpen",false);
            //ui.SetActive(false); 
        }
        // if(isUIopen){
        //     playerScript.canShoot=false;
        // }else{
        //     playerScript.canShoot=true;
        // }

    }
}
