using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadLevel : MonoBehaviour
{
    public LoadScreen ui;
    public GameObject player;
    public Transform[] startPos = new Transform[3];
    public int exitIndex;

    public BuilldingScript script;

    private void Awake() {
        //Scene scene = SceneManager.GetActiveScene();
        // if(scene.name=="MainBase"&&GameManager.gameStarted){
        //     // FindObjectOfType<SaveLoadPos>().Save();
        //     //FindObjectOfType<SaveLoadPos>().LoadLevel1Pos();
           
        // }
       
        //Debug.Log(exitIndex);
        if(GameManager.houseHasBeenBought){
            //Debug.Log("Load Haouse");
            script.BuildHutt();
        }
        if(GameManager.fireHasBeenBought){
            script.BuildFirePlace();
        }
        if(GameManager.craftingBenchHasBeenBought){
            script.BuildCraftingBench();
        }
        if(GameManager.mapTableHasBeenBought){
            script.BuildMapTable();
        }
        if(GameManager.farmHasBeenBought){
            script.BuildFarm();
        }
        if(GameManager.tileHasBeenBought){
            script.BuildTile();
        }
        if(GameManager.fenceHasBeenBought){
            script.BuildFence();
        }
        if(GameManager.gateHasBeenBought){
            script.BuildGate();
        }
        if(GameManager.flowerPotHasBeenBought){
            script.BuildFlowerPot();
        }
         if(GameManager.windmillHasBeenBought){
            script.BuildWindmill();
        }

       
    }
    void Start()
    {
        //startPos[0] = new 
        
        // Scene scene = SceneManager.GetActiveScene();
        // Debug.Log(GameManager.level2Index);
        // Debug.Log("HEIII");
        // //exitIndex = LevelsScript.exitIndexStatic;
        // if(GameManager.level1Index==1 && scene.name=="MainBase"){
        //     player.transform.position = startPos[1].transform.position;
        // }

        // if(scene.name=="Level 1"){
        //     if(GameManager.level2Index==1){
        //         player.transform.position = startPos[1].transform.position;
        //     }
        //     if(GameManager.level2Index==2){
        //         player.transform.position = startPos[2].transform.position;
        //     }
        // }
        ui.StartLevel();    
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.H)){
            //FindObjectOfType<SaveLoadPos>().Save();
        }
    }
}
