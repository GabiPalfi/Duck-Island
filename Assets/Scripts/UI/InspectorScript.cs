using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InspectorScript : MonoBehaviour
{
    public int index;
    public GameObject rockUI;
    public bool isRockActive;

    public GameObject shroomUI;
    public bool isShroomActive;

    public GameObject grasUI;
    public bool isGrassActive;

    public GameObject woodUI;
    public bool isWoodActive;

    public GameObject ironUI;
    public bool isIronActive;

    public GameObject ropeUI;
    public bool isRopeActive;

    public GameObject plankUI;
    public bool isPlankActive;

    public GameObject coinUI;
    public bool isCoinActive;

    public GameObject fireworkUI;
    public bool isFireworkActive;

    public GameObject bandageUI;
    public bool isBandageActive;

    public GameObject polishRockUI;
    public bool isPolishRockActive;

    public GameObject greenShroomUI;
    public bool isGreenShroomActive;

    public GameObject seedUI;
    public bool isSeedActive;

     public GameObject rockLetterUI;
    public bool isRockLetterActive;

     public GameObject fireworkLetterUI;
    public bool isFireworkLetterActive;

     public GameObject carrotUI;
    public bool isCarrotActive;

     public GameObject tomatoeUI;
    public bool isTomatoeActive;

    public GameObject pumpkinUI;
    public bool isPumkinActive;

    public GameObject cornUI;
    public bool isCornActive;

    public GameObject dashUI;
    public bool isDashActive;

    public GameObject slashUI;
    public bool isSlashActive;

    public GameObject letterUI;
    public bool isLetterActive;

    public GameObject lifestealUI;
    public bool isLifestealActive;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(InventoryScript.isInventoryOpenStatic==false){
            CloseRock();
            CloseShroom();
            CloseGrass();
            CloseWodd();
            CloseIron();
            CloseRope();
            ClosePlank();
            CloseCoin();
            CloseFirework();
            CloseBnadage();
            ClosePolishRock();
            CloseGreenShroom();
            CloseSeed();
            CloseRockLetter();
            CloseFireWorkLetter();
            CloseCarrot();
            CloseTomatoe();
            ClosePumkin();
            CloseCorn();
            CloseDash();
            CloseSlash();
            CloseLetter();
            CloseLifesteal();

        }
    }
    public void CloseAll(){
        if(index==1){
            //CloseRock();
            CloseShroom();
            CloseGrass();
            CloseWodd();
            CloseIron();
            CloseRope();
            ClosePlank();
            CloseCoin();
            CloseFirework();
            CloseBnadage();
            ClosePolishRock();
            CloseGreenShroom();
            CloseSeed();
            CloseRockLetter();
            CloseFireWorkLetter();
            CloseCarrot();
            CloseTomatoe();
            ClosePumkin();
            CloseCorn();
            CloseDash();
            CloseSlash();
            CloseLetter();
            CloseLifesteal();
        }
        if(index==2){
            CloseRock();
            //CloseShroom();
            CloseGrass();
            CloseWodd();
            CloseIron();
            CloseRope();
            ClosePlank();
            CloseCoin();
            CloseFirework();
            CloseBnadage();
            ClosePolishRock();
            CloseGreenShroom();
            CloseSeed();
            CloseRockLetter();
            CloseFireWorkLetter();
            CloseCarrot();
            CloseTomatoe();
            ClosePumkin();
            CloseCorn();
            CloseDash();
            CloseSlash();
            CloseLetter();
            CloseLifesteal();
        }
        if(index==3){
            CloseRock();
            CloseShroom();
            //CloseGrass();
            CloseWodd();
            CloseIron();
            CloseRope();
            ClosePlank();
            CloseCoin();
            CloseFirework();
            CloseBnadage();
            ClosePolishRock();
            CloseGreenShroom();
            CloseSeed();
            CloseRockLetter();
            CloseFireWorkLetter();
            CloseCarrot();
            CloseTomatoe();
            ClosePumkin();
            CloseCorn();
             CloseDash();
            CloseSlash();
            CloseLetter();
            CloseLifesteal();
        }
        if(index==4){
            CloseRock();
            CloseShroom();
            CloseGrass();
            //CloseWodd();
            CloseIron();
            CloseRope();
            ClosePlank();
            CloseCoin();
            CloseFirework();
            CloseBnadage();
            ClosePolishRock();
            CloseGreenShroom();
            CloseSeed();
            CloseRockLetter();
            CloseFireWorkLetter();
            CloseCarrot();
            CloseTomatoe();
            ClosePumkin();
            CloseCorn();
             CloseDash();
            CloseSlash();
            CloseLetter();
            CloseLifesteal();
        }
         if(index==5){
            CloseRock();
            CloseShroom();
            CloseGrass();
            CloseWodd();
            //CloseIron();
            CloseRope();
            ClosePlank();
            CloseCoin();
            CloseFirework();
            CloseBnadage();
            ClosePolishRock();
            CloseGreenShroom();
            CloseSeed();
            CloseRockLetter();
            CloseFireWorkLetter();
            CloseCarrot();
            CloseTomatoe();
            ClosePumkin();
            CloseCorn();
            CloseDash();
            CloseSlash();
            CloseLetter();
            CloseLifesteal();
        }
         if(index==6){
            CloseRock();
            CloseShroom();
            CloseGrass();
            CloseWodd();
            CloseIron();
            //CloseRope();
            ClosePlank();
            CloseCoin();
            CloseFirework();
            CloseBnadage();
            ClosePolishRock();
            CloseGreenShroom();
            CloseSeed();
            CloseRockLetter();
            CloseFireWorkLetter();
            CloseCarrot();
            CloseTomatoe();
            ClosePumkin();
            CloseCorn();
             CloseDash();
            CloseSlash();
            CloseLetter();
            CloseLifesteal();
        }
         if(index==7){
            CloseRock();
            CloseShroom();
            CloseGrass();
            CloseWodd();
            CloseIron();
            CloseRope();
            //ClosePlank();
            CloseCoin();
            CloseFirework();
            CloseBnadage();
            ClosePolishRock();
            CloseGreenShroom();
            CloseSeed();
            CloseRockLetter();
            CloseFireWorkLetter();
            CloseCarrot();
            CloseTomatoe();
            ClosePumkin();
            CloseCorn();
             CloseDash();
            CloseSlash();
            CloseLetter();
            CloseLifesteal();
        }
         if(index==8){
            CloseRock();
            CloseShroom();
            CloseGrass();
            CloseWodd();
            CloseIron();
            CloseRope();
            ClosePlank();
            //CloseCoin();
            CloseFirework();
            CloseBnadage();
            ClosePolishRock();
            CloseGreenShroom();
            CloseSeed();
            CloseRockLetter();
            CloseFireWorkLetter();
            CloseCarrot();
            CloseTomatoe();
            ClosePumkin();
            CloseCorn();
             CloseDash();
            CloseSlash();
            CloseLetter();
            CloseLifesteal();
        }
         if(index==9){
            CloseRock();
            CloseShroom();
            CloseGrass();
            CloseWodd();
            CloseIron();
            CloseRope();
            ClosePlank();
            CloseCoin();
            //CloseFirework();
            CloseBnadage();
            ClosePolishRock();
            CloseGreenShroom();
            CloseSeed();
            CloseRockLetter();
            CloseFireWorkLetter();
            CloseCarrot();
            CloseTomatoe();
            ClosePumkin();
            CloseCorn();
             CloseDash();
            CloseSlash();
            CloseLetter();
            CloseLifesteal();
        }
         if(index==10){
            CloseRock();
            CloseShroom();
            CloseGrass();
            CloseWodd();
            CloseIron();
            CloseRope();
            ClosePlank();
            CloseCoin();
            CloseFirework();
            //CloseBnadage();
            ClosePolishRock();
            CloseGreenShroom();
            CloseSeed();
            CloseRockLetter();
            CloseFireWorkLetter();
            CloseCarrot();
            CloseTomatoe();
            ClosePumkin();
            CloseCorn();
             CloseDash();
            CloseSlash();
            CloseLetter();
            CloseLifesteal();
        }
        if(index==11){
            CloseRock();
            CloseShroom();
            CloseGrass();
            CloseWodd();
            CloseIron();
            CloseRope();
            ClosePlank();
            CloseCoin();
            CloseFirework();
            CloseBnadage();
            //ClosePolishRock();
            CloseGreenShroom();
            CloseSeed();
            CloseRockLetter();
            CloseFireWorkLetter();
            CloseCarrot();
            CloseTomatoe();
            ClosePumkin();
            CloseCorn();
             CloseDash();
            CloseSlash();
            CloseLetter();
            CloseLifesteal();
        }
        if(index==12){
            CloseRock();
            CloseShroom();
            CloseGrass();
            CloseWodd();
            CloseIron();
            CloseRope();
            ClosePlank();
            CloseCoin();
            CloseFirework();
            CloseBnadage();
            ClosePolishRock();
            //CloseGreenShroom();
            CloseSeed();
            CloseRockLetter();
            CloseFireWorkLetter();
            CloseCarrot();
            CloseTomatoe();
            ClosePumkin();
            CloseCorn();
             CloseDash();
            CloseSlash();
            CloseLetter();
            CloseLifesteal();
        }
        if(index==13){
            CloseRock();
            CloseShroom();
            CloseGrass();
            CloseWodd();
            CloseIron();
            CloseRope();
            ClosePlank();
            CloseCoin();
            CloseFirework();
            CloseBnadage();
            ClosePolishRock();
            CloseGreenShroom();
            //CloseSeed();
            CloseRockLetter();
            CloseFireWorkLetter();
            CloseCarrot();
            CloseTomatoe();
            ClosePumkin();
            CloseCorn();
             CloseDash();
            CloseSlash();
            CloseLetter();
            CloseLifesteal();
        }
         if(index==14){
            CloseRock();
            CloseShroom();
            CloseGrass();
            CloseWodd();
            CloseIron();
            CloseRope();
            ClosePlank();
            CloseCoin();
            CloseFirework();
            CloseBnadage();
            ClosePolishRock();
            CloseGreenShroom();
            CloseSeed();
            //CloseRockLetter();
            CloseFireWorkLetter();
            CloseCarrot();
            CloseTomatoe();
            ClosePumkin();
            CloseCorn();
             CloseDash();
            CloseSlash();
            CloseLetter();
            CloseLifesteal();
        }
         if(index==15){
            CloseRock();
            CloseShroom();
            CloseGrass();
            CloseWodd();
            CloseIron();
            CloseRope();
            ClosePlank();
            CloseCoin();
            CloseFirework();
            CloseBnadage();
            ClosePolishRock();
            CloseGreenShroom();
            CloseSeed();
            CloseRockLetter();
            //CloseFireWorkLetter();
            CloseCarrot();
            CloseTomatoe();
            ClosePumkin();
            CloseCorn();
             CloseDash();
            CloseSlash();
            CloseLetter();
            CloseLifesteal();
        }
         if(index==16){
            CloseRock();
            CloseShroom();
            CloseGrass();
            CloseWodd();
            CloseIron();
            CloseRope();
            ClosePlank();
            CloseCoin();
            CloseFirework();
            CloseBnadage();
            ClosePolishRock();
            CloseGreenShroom();
            CloseSeed();
            CloseRockLetter();
            CloseFireWorkLetter();
            //CloseCarrot();
            CloseTomatoe();
            ClosePumkin();
            CloseCorn();
             CloseDash();
            CloseSlash();
            CloseLetter();
            CloseLifesteal();
        }
         if(index==17){
            CloseRock();
            CloseShroom();
            CloseGrass();
            CloseWodd();
            CloseIron();
            CloseRope();
            ClosePlank();
            CloseCoin();
            CloseFirework();
            CloseBnadage();
            ClosePolishRock();
            CloseGreenShroom();
            CloseSeed();
            CloseRockLetter();
            CloseFireWorkLetter();
            CloseCarrot();
            //CloseTomatoe();
            ClosePumkin();
            CloseCorn();
             CloseDash();
            CloseSlash();
            CloseLetter();
            CloseLifesteal();
        }
        if(index==18){
            CloseRock();
            CloseShroom();
            CloseGrass();
            CloseWodd();
            CloseIron();
            CloseRope();
            ClosePlank();
            CloseCoin();
            CloseFirework();
            CloseBnadage();
            ClosePolishRock();
            CloseGreenShroom();
            CloseSeed();
            CloseRockLetter();
            CloseFireWorkLetter();
            CloseCarrot();
            CloseTomatoe();
            //ClosePumkin();
            CloseCorn();
             CloseDash();
            CloseSlash();
            CloseLetter();
            CloseLifesteal();
        }   
        if(index==19){
            CloseRock();
            CloseShroom();
            CloseGrass();
            CloseWodd();
            CloseIron();
            CloseRope();
            ClosePlank();
            CloseCoin();
            CloseFirework();
            CloseBnadage();
            ClosePolishRock();
            CloseGreenShroom();
            CloseSeed();
            CloseRockLetter();
            CloseFireWorkLetter();
            CloseCarrot();
            CloseTomatoe();
            ClosePumkin();
            //CloseCorn();
             CloseDash();
            CloseSlash();
            CloseLetter();
            CloseLifesteal();
        }
        if(index==20){
            CloseRock();
            CloseShroom();
            CloseGrass();
            CloseWodd();
            CloseIron();
            CloseRope();
            ClosePlank();
            CloseCoin();
            CloseFirework();
            CloseBnadage();
            ClosePolishRock();
            CloseGreenShroom();
            CloseSeed();
            CloseRockLetter();
            CloseFireWorkLetter();
            CloseCarrot();
            CloseTomatoe();
            ClosePumkin();
            CloseCorn();
            //CloseDash();
            CloseSlash();
            CloseLetter();
            CloseLifesteal();
        }
        if(index==21){
            CloseRock();
            CloseShroom();
            CloseGrass();
            CloseWodd();
            CloseIron();
            CloseRope();
            ClosePlank();
            CloseCoin();
            CloseFirework();
            CloseBnadage();
            ClosePolishRock();
            CloseGreenShroom();
            CloseSeed();
            CloseRockLetter();
            CloseFireWorkLetter();
            CloseCarrot();
            CloseTomatoe();
            ClosePumkin();
            CloseCorn();
            CloseDash();
            CloseLetter();
            //CloseSlash();
            CloseLifesteal();
        }
        if(index==22){
            CloseRock();
            CloseShroom();
            CloseGrass();
            CloseWodd();
            CloseIron();
            CloseRope();
            ClosePlank();
            CloseCoin();
            CloseFirework();
            CloseBnadage();
            ClosePolishRock();
            CloseGreenShroom();
            CloseSeed();
            CloseRockLetter();
            CloseFireWorkLetter();
            CloseCarrot();
            CloseTomatoe();
            ClosePumkin();
            CloseCorn();
            CloseDash();
            //CloseLetter();
            CloseSlash();
            CloseLifesteal();
        }
        if(index==23){
            CloseRock();
            CloseShroom();
            CloseGrass();
            CloseWodd();
            CloseIron();
            CloseRope();
            ClosePlank();
            CloseCoin();
            CloseFirework();
            CloseBnadage();
            ClosePolishRock();
            CloseGreenShroom();
            CloseSeed();
            CloseRockLetter();
            CloseFireWorkLetter();
            CloseCarrot();
            CloseTomatoe();
            ClosePumkin();
            CloseCorn();
            CloseDash();
            CloseLetter();
            CloseSlash();
            //CloseLifesteal();
        }


    }
    public void ShowRock(){
        if(GameManager.stoneCount>0){
            if(isRockActive){
                rockUI.SetActive(false);
                isRockActive=false;
            }else{
                rockUI.SetActive(true);
                isRockActive=true;
            }
            index=1;
            CloseAll();
            FindObjectOfType<AudioManager>().Play("Inventory");
        }
    }
    public void CloseRock(){
        rockUI.SetActive(false);
        isRockActive=false;
    }
    public void ShowShroom(){
        if(GameManager.mushroomCount>0){
            if(isShroomActive){
                shroomUI.SetActive(false);
                isShroomActive=false;
            }else{
                shroomUI.SetActive(true);
                isShroomActive=true;
            }
            index=2;
            CloseAll();
            FindObjectOfType<AudioManager>().Play("Inventory");
        }
    }
    public void CloseShroom(){
        shroomUI.SetActive(false);
        isShroomActive=false;
    }
    public void ShowGrass(){
        if(GameManager.grassCount>0){
            if(isGrassActive){
                grasUI.SetActive(false);
                isGrassActive=false;
            }else{
                grasUI.SetActive(true);
                isGrassActive=true;
            }
            index=3;
            CloseAll();
            FindObjectOfType<AudioManager>().Play("Inventory");
        }
    }
    public void CloseGrass(){
        grasUI.SetActive(false);
        isGrassActive=false;
    }

    public void ShowWood(){
        if(GameManager.stickCount>0){
            if(isWoodActive){
                woodUI.SetActive(false);
                isWoodActive=false;
            }else{
                woodUI.SetActive(true);
                isWoodActive=true;
            }
            index=4;
            CloseAll();
            FindObjectOfType<AudioManager>().Play("Inventory");
        }
    }
    public void CloseWodd(){
        woodUI.SetActive(false);
        isWoodActive=false;
    }

    public void ShowIron(){
        if(GameManager.ironCount>0){
            if(isIronActive){
                ironUI.SetActive(false);
                isIronActive=false;
            }else{
                ironUI.SetActive(true);
                isIronActive=true;
            }
            index=5;
            CloseAll();
            FindObjectOfType<AudioManager>().Play("Inventory");
        }
    }
    public void CloseIron(){
        ironUI.SetActive(false);
        isIronActive=false;
    }

    public void ShowRope(){
        if(GameManager.ropeCount>0){
            if(isRopeActive){
                ropeUI.SetActive(false);
                isRopeActive=false;
            }else{
                ropeUI.SetActive(true);
                isRopeActive=true;
            }
            index=6;
            CloseAll();
            FindObjectOfType<AudioManager>().Play("Inventory");
        }
    }
    public void CloseRope(){
        ropeUI.SetActive(false);
        isRopeActive=false;
    }
    public void ShowPlank(){
        if(GameManager.plankCount>0){
            if(isPlankActive){
                plankUI.SetActive(false);
                isPlankActive=false;
            }else{
                plankUI.SetActive(true);
                isPlankActive=true;
            }
            index=7;
            CloseAll();
            FindObjectOfType<AudioManager>().Play("Inventory");
        }
    }
    public void ClosePlank(){
        plankUI.SetActive(false);
        isPlankActive=false;
    }

    public void ShowGold(){
        if(GameManager.goldCount>0){
            if(isCoinActive){
                coinUI.SetActive(false);
                isCoinActive=false;
            }else{
                coinUI.SetActive(true);
                isCoinActive=true;
            }
            index=8;
            CloseAll();
            FindObjectOfType<AudioManager>().Play("Inventory");
        }
    }
    public void CloseCoin(){
        coinUI.SetActive(false);
        isCoinActive=false;
    }

    public void ShowFirework(){
        if(GameManager.fireworkCount>0){
            if(isFireworkActive){
                fireworkUI.SetActive(false);
                isFireworkActive=false;
            }else{
                fireworkUI.SetActive(true);
                isFireworkActive=true;
            }
            index=9;
            CloseAll();
            FindObjectOfType<AudioManager>().Play("Inventory");
        }
    }
    public void CloseFirework(){
        fireworkUI.SetActive(false);
        isFireworkActive=false;
    }
    public void ShowBandage(){
        if(GameManager.bandageCount>0){
            if(isBandageActive){
                bandageUI.SetActive(false);
                isBandageActive=false;
            }else{
                bandageUI.SetActive(true);
                isBandageActive=true;
            }
            index=10;
            CloseAll();
            FindObjectOfType<AudioManager>().Play("Inventory");
        }
    }
    public void CloseBnadage(){
        bandageUI.SetActive(false);
        isBandageActive=false;
    }
    public void ShowRockPolish(){
        if(GameManager.polishRockCount>0){
            if(isPolishRockActive){
                polishRockUI.SetActive(false);
                isPolishRockActive=false;
            }else{
                polishRockUI.SetActive(true);
                isPolishRockActive=true;
            }
            index=11;
            CloseAll();
            FindObjectOfType<AudioManager>().Play("Inventory");
        }
    }
    public void ClosePolishRock(){
        polishRockUI.SetActive(false);
        isPolishRockActive=false;
    }
    public void ShowGreenShroom(){
        if(GameManager.greenShroomCount>0){
            if(isGreenShroomActive){
                greenShroomUI.SetActive(false);
                isGreenShroomActive=false;
            }else{
                greenShroomUI.SetActive(true);
                isGreenShroomActive=true;
            }
            index=12;
            CloseAll();
            FindObjectOfType<AudioManager>().Play("Inventory");
        }
    }
    public void CloseGreenShroom(){
        greenShroomUI.SetActive(false);
        isGreenShroomActive=false;
    }
    public void ShowSeed(){
        if(GameManager.seedCount>0){
            if(isSeedActive){
                seedUI.SetActive(false);
                isSeedActive=false;
            }else{
                seedUI.SetActive(true);
                isSeedActive=true;
            }
            index=13;
            CloseAll();
            FindObjectOfType<AudioManager>().Play("Inventory");
        }
    }
    public void CloseSeed(){
        seedUI.SetActive(false);
        isSeedActive=false;
    }
    public void ShowRockLetter(){
        if(GameManager.rockLetterCount>0){
            if(isRockLetterActive){
                rockLetterUI.SetActive(false);
                isRockLetterActive=false;
            }else{
                rockLetterUI.SetActive(true);
                isRockLetterActive=true;
            }
            index=14;
            CloseAll();
            FindObjectOfType<AudioManager>().Play("Inventory");
        }
    }
    public void CloseRockLetter(){
        rockLetterUI.SetActive(false);
        isRockLetterActive=false;
    }

    public void ShowFireworkLetter(){
        if(GameManager.fireworkLetterCount>0){
            if(isFireworkLetterActive){
                fireworkLetterUI.SetActive(false);
                isFireworkLetterActive=false;
            }else{
                fireworkLetterUI.SetActive(true);
                isFireworkLetterActive=true;
            }
            index=15;
            CloseAll();
            FindObjectOfType<AudioManager>().Play("Inventory");
        }
    }
    public void CloseFireWorkLetter(){
        fireworkLetterUI.SetActive(false);
        isFireworkLetterActive=false;
    }
    public void ShowCarrot(){
        if(GameManager.carrotCount>0){
            if(isCarrotActive){
                carrotUI.SetActive(false);
                isCarrotActive=false;
            }else{
                carrotUI.SetActive(true);
                isCarrotActive=true;
            }
            index=16;
            CloseAll();
            FindObjectOfType<AudioManager>().Play("Inventory");
        }
    }
    public void CloseCarrot(){
        carrotUI.SetActive(false);
        isCarrotActive=false;
    }
    public void ShowTomatoe(){
        if(GameManager.tomatoCount>0){
            if(isTomatoeActive){
                tomatoeUI.SetActive(false);
                isTomatoeActive=false;
            }else{
                tomatoeUI.SetActive(true);
                isTomatoeActive=true;
            }
            index=17;
            CloseAll();
            FindObjectOfType<AudioManager>().Play("Inventory");
        }
    }
    public void CloseTomatoe(){
        tomatoeUI.SetActive(false);
        isTomatoeActive=false;
    }
     public void ShowCorn(){
        if(GameManager.cornCount>0){
            if(isCornActive){
                cornUI.SetActive(false);
                isCornActive=false;
            }else{
                cornUI.SetActive(true);
                isCornActive=true;
            }
            index=19;
            CloseAll();
            FindObjectOfType<AudioManager>().Play("Inventory");
        }
    }
    public void CloseCorn(){
        cornUI.SetActive(false);
        isCornActive=false;
    }
    public void ShowPumpkin(){
        if(GameManager.pumpkinCount>0){
            if(isPumkinActive){
                pumpkinUI.SetActive(false);
                isPumkinActive=false;
            }else{
                pumpkinUI.SetActive(true);
                isPumkinActive=true;
            }
            index=18;
            CloseAll();
            FindObjectOfType<AudioManager>().Play("Inventory");
        }
    }
    public void ClosePumkin(){
        pumpkinUI.SetActive(false);
        isPumkinActive=false;
    }

    public void ShowDash(){
        if(GameManager.eyeTalisman>0){
            if(isDashActive){
                dashUI.SetActive(false);
                isDashActive=false;
            }else{
                dashUI.SetActive(true);
                isDashActive=true;
            }
            index=20;
            CloseAll();
            FindObjectOfType<AudioManager>().Play("Inventory");
        }
    }
    public void CloseDash(){
        dashUI.SetActive(false);
        isDashActive=false;
    }

    public void ShowSlash(){
        if(GameManager.slashTalisman>0){
            if(isSlashActive){
                slashUI.SetActive(false);
                isSlashActive=false;
            }else{
                slashUI.SetActive(true);
                isSlashActive=true;
            }
            index=21;
            CloseAll();
            FindObjectOfType<AudioManager>().Play("Inventory");
        }
    }
    public void CloseSlash(){
        slashUI.SetActive(false);
        isSlashActive=false;
    }
    public void ShowLetter(){
       if(isLetterActive){
            letterUI.SetActive(false);
            isLetterActive=false;
        }else{
            letterUI.SetActive(true);
            isLetterActive=true;
        }
        index=22;
        CloseAll();
        FindObjectOfType<AudioManager>().Play("Inventory");
    }
    public void CloseLetter(){
        letterUI.SetActive(false);
        isLetterActive=false;
    }

    public void ShowLifesteal(){
       if(isLifestealActive){
            lifestealUI.SetActive(false);
            isLifestealActive=false;
        }else{
            lifestealUI.SetActive(true);
            isLifestealActive=true;
        }
        index=23;
        CloseAll();
        FindObjectOfType<AudioManager>().Play("Inventory");
    }
    public void CloseLifesteal(){
        lifestealUI.SetActive(false);
        isLifestealActive=false;
    }
    
}
