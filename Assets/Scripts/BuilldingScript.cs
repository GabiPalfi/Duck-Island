using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuilldingScript : MonoBehaviour
{
    [Header("Referinte")]
    public InventoryScript inventory;
    public Animator anim;
    public GameManager gameManager;

    [Header("House")]
    public HouseScript house;
    public GameObject houseModel;
    public GameObject houseSign;
    public GameObject houseUI;

    [Header("CraftBench")]
    public CraftBenchScript craftBench;
    public GameObject craftBenchObj;
    public GameObject craftBenchSign;
    public GameObject craftBenchUI;


    [Header("FirePlace")]
    public FirePlaceScript firePlace;
    public GameObject firePlaceModel;
    public GameObject firePlaceSign;
    public GameObject firePlaceUI;

    [Header("MapPlace")]
    public MapTableScript mapPlace;
    public GameObject mapPlaceModel;
    public GameObject mapPlaceSign;
    public GameObject mapPlaceUI;

    [Header("Farm")]
    public FarmPlaceSign farmPlace;
    public GameObject farmModel;
    public GameObject farmSign;
    public GameObject farmUI;

    [Header("Tiles")]
    public TilesSignScript tilePlace;
    public GameObject tileModel;
    public GameObject tileSign;
    public GameObject tileUI;

    [Header("Fence")]
    public FenceSignScript fencePlace;
    public GameObject fenceModel;
    public GameObject fenceSign;
    public GameObject fenceUI;

    [Header("Gate")]
    public PoartaSiginScript gatePlace;
    public GameObject gateModel;
    public GameObject gateSign;
    public GameObject gateUI;

    [Header("FlowerPot")]
    public FlowerPotSignScript flowerPotPlace;
    public GameObject flowerPotModel;
    public GameObject flowerPotSign;
    public GameObject flowerPotUI;

    [Header("Windmill")]
    public WindmillSignScript windmillPlace;
    public GameObject windmillModel;
    public GameObject windmillSign;
    public GameObject windmillUI;


    [Header("Particle")]
    public GameObject particle;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        //GameManager.buildIndex=0;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(GameManager.buildIndex);
    }
    public void BuildHutt(){
        //Debug.Log("Am loaduit");
        if(GameManager.houseHasBeenBought == false){
            if(inventory.row1[0]>=house.stonePrice && inventory.row1[2]>=house.grassPrice && inventory.row1[3]>=house.woodPrice){
                houseModel.SetActive(true);
                houseSign.SetActive(false);
                houseUI.SetActive(false);
                craftBenchSign.SetActive(true);
                Instantiate(particle,houseModel.transform.position,Quaternion.identity);
                inventory.row1[0]-=house.stonePrice;
                inventory.row1[2]-=house.grassPrice;
                inventory.row1[3]-=house.woodPrice;
                GameManager.houseHasBeenBought = true;
                FindObjectOfType<AudioManager>().Play("ColectResorce");
                GameManager.buildIndex=1;

            }
        }else{
            Debug.Log("Am loaduit");
            houseModel.SetActive(true);
            houseSign.SetActive(false);
            houseUI.SetActive(false);
            craftBenchSign.SetActive(true);
            //GameManager.buildIndex=1;
        }
    }
    public void BuildCraftingBench(){
        if(GameManager.craftingBenchHasBeenBought==false){
            if(inventory.row1[0]>=craftBench.stonePrice && inventory.row1[2]>=craftBench.grassPrice && inventory.row1[3]>=craftBench.woodPrice && inventory.row1[4]>=craftBench.ironPrice){
                craftBenchObj.SetActive(true);
                craftBenchSign.SetActive(false);
                craftBenchUI.SetActive(false);
                firePlaceSign.SetActive(true);
                Instantiate(particle,craftBenchObj.transform.position,Quaternion.identity);
                inventory.row1[0]-=craftBench.stonePrice;
                inventory.row1[2]-=craftBench.grassPrice;
                inventory.row1[3]-=craftBench.woodPrice;
                inventory.row1[4]-=craftBench.ironPrice;
                GameManager.craftingBenchHasBeenBought = true;
                FindObjectOfType<AudioManager>().Play("ColectResorce");
                GameManager.buildIndex=2;

            }
        }else{
            craftBenchObj.SetActive(true);
            craftBenchSign.SetActive(false);
            craftBenchUI.SetActive(false);
            if(GameManager.fireHasBeenBought==false){
                firePlaceSign.SetActive(true);
                
            }
            //GameManager.buildIndex=2;
           
        }
    }
    public void BuildFirePlace(){
        // Debug.Log("AM V");
        if(GameManager.fireHasBeenBought==false){
            if(inventory.row1[0]>=firePlace.stonePrice && inventory.row1[2]>=firePlace.grassPrice && inventory.row1[3]>=firePlace.woodPrice){
                firePlaceModel.SetActive(true);
                firePlaceSign.SetActive(false);
                firePlaceUI.SetActive(false);
                Instantiate(particle,firePlaceModel.transform.position,Quaternion.identity);
                mapPlaceSign.SetActive(true);
                //craftBenchSign.SetActive(true);
                inventory.row1[0]-=firePlace.stonePrice;
                inventory.row1[2]-=firePlace.grassPrice;
                inventory.row1[3]-=firePlace.woodPrice;
                GameManager.fireHasBeenBought = true;
                GameManager.mapTableUnlock = true;
                FindObjectOfType<AudioManager>().Play("ColectResorce");
                GameManager.buildIndex=3;
            }
        }else{
            firePlaceModel.SetActive(true);
            firePlaceSign.SetActive(false);
            firePlaceUI.SetActive(false);
            mapPlaceSign.SetActive(true);
            //GameManager.buildIndex=3;
        }
    }
    public void BuildMapTable(){
        // Debug.Log("AM V");
        if(GameManager.mapTableHasBeenBought==false){
            if(inventory.row1[10]>=mapPlace.stonePolish && inventory.row1[5]>=mapPlace.rope && inventory.row1[8]>=mapPlace.woodPlanks){
                mapPlaceModel.SetActive(true);
                mapPlaceSign.SetActive(false);
                mapPlaceUI.SetActive(false);
                Instantiate(particle,mapPlaceModel.transform.position,Quaternion.identity);
                //craftBenchSign.SetActive(true);
                farmSign.SetActive(true);
                inventory.row1[10]-=mapPlace.stonePolish;
                inventory.row1[5]-=mapPlace.rope;
                inventory.row1[8]-=mapPlace.woodPlanks;
                GameManager.mapTableHasBeenBought = true;
                GameManager.mapTableUnlock = false;
                FindObjectOfType<AudioManager>().Play("ColectResorce");
                GameManager.buildIndex=4;
            }
        }else{
            mapPlaceModel.SetActive(true);
            mapPlaceSign.SetActive(false);
            mapPlaceUI.SetActive(false);
            farmSign.SetActive(true);
            //GameManager.buildIndex=4;
        }
    }
    public void BuildFarm(){
        // Debug.Log("AM V");
        if(GameManager.farmHasBeenBought==false){
            if(inventory.row1[10]>=farmPlace.stonePolish && inventory.row1[5]>=farmPlace.rope && inventory.row1[8]>=farmPlace.woodPlanks && inventory.row1[12]>=farmPlace.seedCount){
                farmModel.SetActive(true);
                farmSign.SetActive(false);
                farmUI.SetActive(false);
                Instantiate(particle,farmModel.transform.position,Quaternion.identity);
                tileSign.SetActive(true);
                inventory.row1[10]-=farmPlace.stonePolish;
                inventory.row1[5]-=farmPlace.rope;
                inventory.row1[8]-=farmPlace.woodPlanks;
                inventory.row1[12]-=farmPlace.seedCount;
                GameManager.farmHasBeenBought = true;
                //GameManager.mapTableUnlock = false;
                FindObjectOfType<AudioManager>().Play("ColectResorce");
                GameManager.buildIndex=5;
            }
        }else{
            farmModel.SetActive(true);
            farmSign.SetActive(false);
            farmUI.SetActive(false);
            tileSign.SetActive(true);
            //GameManager.buildIndex=5;
        }
    }
    public void BuildTile(){
        // Debug.Log("AM V");
        if(GameManager.tileHasBeenBought==false){
            if(inventory.row1[10]>=tilePlace.stonePolish){
                tileModel.SetActive(true);
                tileSign.SetActive(false);
                tileUI.SetActive(false);
                Instantiate(particle,tileSign.transform.position,Quaternion.identity);
                //craftBenchSign.SetActive(true);
                inventory.row1[10]-=tilePlace.stonePolish;
                GameManager.tileHasBeenBought = true;
                fenceSign.SetActive(true);
                //GameManager.mapTableUnlock = false;
                FindObjectOfType<AudioManager>().Play("ColectResorce");
                GameManager.buildIndex=6;
            }
        }else{
            tileModel.SetActive(true);
            tileSign.SetActive(false);
            tileUI.SetActive(false);
            fenceSign.SetActive(true);
            //GameManager.buildIndex=6;
        }
    }
    public void BuildFence(){
        // Debug.Log("AM V");
        if(GameManager.fenceHasBeenBought==false){
            if(inventory.row1[5]>=fencePlace.rope && inventory.row1[8]>=fencePlace.woodPlanks){
                fenceModel.SetActive(true);
                fenceSign.SetActive(false);
                fenceUI.SetActive(false);
                Instantiate(particle,fenceSign.transform.position,Quaternion.identity);
                //craftBenchSign.SetActive(true);
                inventory.row1[5]-=fencePlace.rope;
                inventory.row1[8]-=fencePlace.woodPlanks;
                GameManager.fenceHasBeenBought = true;
                gateSign.SetActive(true);
                //GameManager.mapTableUnlock = false;
                FindObjectOfType<AudioManager>().Play("ColectResorce");
                GameManager.buildIndex=7;
            }
        }else{
            fenceModel.SetActive(true);
            fenceSign.SetActive(false);
            fenceUI.SetActive(false);
            gateSign.SetActive(true);
            //GameManager.buildIndex=7;
        }
    }
    public void BuildGate(){
        // Debug.Log("AM V");
        if(GameManager.gateHasBeenBought==false){
            if(inventory.row1[5]>=gatePlace.rope && inventory.row1[8]>=gatePlace.woodPlanks){
                gateModel.SetActive(true);
                gateSign.SetActive(false);
                gateUI.SetActive(false);
                Instantiate(particle,gateSign.transform.position,Quaternion.identity);
                //craftBenchSign.SetActive(true);
                inventory.row1[5]-=gatePlace.rope;
                inventory.row1[8]-=gatePlace.woodPlanks;
                GameManager.gateHasBeenBought = true;
                flowerPotSign.SetActive(true);
                //GameManager.mapTableUnlock = false;
                FindObjectOfType<AudioManager>().Play("ColectResorce");
                GameManager.buildIndex=8;
            }
        }else{
            gateModel.SetActive(true);
            gateSign.SetActive(false);
            gateUI.SetActive(false);
            flowerPotSign.SetActive(true);
            //GameManager.buildIndex=8;
        }
    }
    public void BuildFlowerPot(){
        // Debug.Log("AM V");
        if(GameManager.flowerPotHasBeenBought==false){
            if(inventory.row1[10]>=flowerPotPlace.stonePolish && inventory.row1[5]>=flowerPotPlace.rope && inventory.row1[5]>=flowerPotPlace.woodPlanks && inventory.row1[12]>=farmPlace.seedCount){
                flowerPotModel.SetActive(true);
                flowerPotSign.SetActive(false);
                flowerPotUI.SetActive(false);
                Instantiate(particle,flowerPotSign.transform.position,Quaternion.identity);
                //craftBenchSign.SetActive(true);
                inventory.row1[10]-=flowerPotPlace.stonePolish;
                inventory.row1[5]-=flowerPotPlace.rope;
                inventory.row1[8]-=flowerPotPlace.woodPlanks;
                inventory.row1[12]-=flowerPotPlace.seedCount;
                GameManager.flowerPotHasBeenBought = true;
                windmillSign.SetActive(true);
                //GameManager.mapTableUnlock = false;
                FindObjectOfType<AudioManager>().Play("ColectResorce");
                GameManager.buildIndex=9;
            }
        }else{
            flowerPotModel.SetActive(true);
            flowerPotSign.SetActive(false);
            flowerPotUI.SetActive(false);
            windmillSign.SetActive(true);
            //GameManager.buildIndex=9;
        }
    }
    public void BuildWindmill(){
        // Debug.Log("AM V");
        if(GameManager.windmillHasBeenBought==false){
            if(inventory.row1[10]>=windmillPlace.stonePolish && inventory.row1[5]>=windmillPlace.rope && inventory.row1[8]>=windmillPlace.woodPlanks && inventory.row1[4]>=windmillPlace.ironPrice){
                windmillModel.SetActive(true);
                windmillSign.SetActive(false);
                windmillUI.SetActive(false);
                Instantiate(particle,windmillSign.transform.position,Quaternion.identity);
                //craftBenchSign.SetActive(true);
                inventory.row1[10]-=windmillPlace.stonePolish;
                inventory.row1[5]-=windmillPlace.rope;
                inventory.row1[8]-=windmillPlace.woodPlanks;
                inventory.row1[4]-=windmillPlace.ironPrice;
                GameManager.windmillHasBeenBought = true;
                //GameManager.mapTableUnlock = false;
                FindObjectOfType<AudioManager>().Play("ColectResorce");
                GameManager.buildIndex=10;
            }
        }else{
            windmillModel.SetActive(true);
            windmillSign.SetActive(false);
            windmillUI.SetActive(false);
            //GameManager.buildIndex=10;
        }
    }
}
