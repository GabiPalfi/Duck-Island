using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmUiScript : MonoBehaviour
{
    public GameObject uiF;
    public Transform player;
    public float minDis;
    //public GameObject fire;
    public int seedCount;
    public InventoryScript inventory;
    public GameObject ui;
    public HouseUIanim animScript;
    public GameObject faze1;
    public GameObject faze2;
    public int currentTime;
    public int maxTime;
    public GameObject colectParticle;

    // Start is called before the first frame update
    void Start()
    {
        
        if(GameManager.hasBeenPlanted1){
            currentTime = GameManager.currentTime1;
            //maxTime= maxTime-currentTime;
            faze1.SetActive(true);
           StartCoroutine(WaitForGrow());
        }
        if(GameManager.collectFarm1){
            faze1.SetActive(false);
            faze2.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position,player.position);
        if(distance<minDis){
            if(GameManager.farmHasBeenBought){
                uiF.SetActive(true);
                if(Input.GetKeyDown(KeyCode.F)){
                    //Debug.Log("Plant");
                    if(GameManager.hasBeenPlanted1==false){
                        if(inventory.row1[12]>=seedCount){
                            inventory.row1[12]-=seedCount;
                            PlantSeeds();
                            GameManager.hasBeenPlanted1=true;
                        }
                    }
                    if(GameManager.collectFarm1==true){
                        CollectFarm();
                    }
                    ui.SetActive(true);
                    animScript.anim.SetBool("isOpen",true);
                }
            }
        }else{
            uiF.SetActive(false);
            StartCoroutine(CloseAnim());
            //ui.SetActive(false);
        }
        UpdateGameManager();
    }
    public void UpdateGameManager(){
        GameManager.currentTime1=currentTime;
        GameManager.maxTime1=maxTime;
    }

    IEnumerator CloseAnim(){
        animScript.anim.SetBool("isOpen",false);
        yield return new WaitForSeconds(0.3f);
        //ui.SetActive(false);
    }
    public void PlantSeeds(){
        
        FindObjectOfType<AudioManager>().Play("ColectResorce");
        faze1.SetActive(true);
        currentTime=0;
        StartCoroutine(WaitForGrow());
    }
    public void CollectFarm(){
        FindObjectOfType<AudioManager>().Play("ColectResorce");
        faze1.SetActive(false);
        faze2.SetActive(false);
        currentTime = 0;
        Instantiate(colectParticle,transform.position,Quaternion.identity);
        GameManager.collectFarm1=false;
        GameManager.hasBeenPlanted1=false;
        inventory.row3[0]+=Random.Range(0,4);
        inventory.row3[1]+=Random.Range(0,4);
        inventory.row3[2]+=Random.Range(0,4);
        inventory.row3[3]+=Random.Range(0,4);
        inventory.row1[12]++;
        //Debug.Log("HEI");
    }
    IEnumerator WaitForGrow(){
        for(int i=GameManager.currentTime1;i<=maxTime;i++){
            yield return new WaitForSeconds(1f);
            //Debug.Log(currentTime);
            currentTime++;
        }
        faze1.SetActive(false);
        faze2.SetActive(true);
        GameManager.collectFarm1=true;
        
    }
}
