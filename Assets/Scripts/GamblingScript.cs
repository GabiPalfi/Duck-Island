using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamblingScript : MonoBehaviour
{
    public GameObject uiF;
    public GameObject ui;
    public Transform player;
    public float minDis;
    public bool isUIopen;
    public GameObject closeButton;
    public GameObject startButton;
    public PlayerMovement2 playerScript;
    public GameObject tax;
    public GameObject choseButtons;
    public int bidCount;
    public int playerIndex;
    public int enemyIndex;
    public GameObject rockButton;
    public GameObject grassButton;
    public GameObject stickButton;

    public GameObject choseRock;
    public GameObject choseGrass;
    public GameObject choseStick;

    public GameObject enemyChoseRock;
    public GameObject enemyChoseGrass;
    public GameObject enemyChoseStick;

    public GameObject wonText;
    public GameObject loseText;
    public GameObject tieText;

    public GameObject replayButton;
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
                //animScript.anim.SetBool("isOpen",true);
                playerScript.canMove=false;
                playerScript.canShoot1=false;
                
                
            }
        }else{
            uiF.SetActive(false);
            isUIopen = false;
            //animScript.anim.SetBool("isOpen",false);
            //ui.SetActive(false); 
        }
    }
    public void Close(){
        FindObjectOfType<AudioManager>().Play("ColectResorce");
        ui.SetActive(false);
        playerScript.canMove=true;
        playerScript.canShoot1=true;
    }
    public void StartGame(){
        if(GameManager.goldCount>=bidCount){
            FindObjectOfType<AudioManager>().Play("ColectResorce");
            tax.SetActive(false);
            startButton.SetActive(false);
            GameManager.goldCount-=bidCount;
            GameStarted();
        }
    }
    public void GameStarted(){
        choseButtons.SetActive(true);
        closeButton.SetActive(false);

    }
    public void ChoseRock(){
        FindObjectOfType<AudioManager>().Play("ColectResorce");
        playerIndex=1;
        // grassButton.SetActive(true);
        // stickButton.SetActive(true);
        choseButtons.SetActive(false);
        ShowWhatIChose();
    }
    public void ChoseGrass(){
        FindObjectOfType<AudioManager>().Play("ColectResorce");
        playerIndex=2;
        // rockButton.SetActive(false);
        // stickButton.SetActive(false);
        choseButtons.SetActive(false);
        ShowWhatIChose();
    }
    public void ChoseStick(){
        FindObjectOfType<AudioManager>().Play("ColectResorce");
        playerIndex=3;
        // rockButton.SetActive(false);
        // grassButton.SetActive(false);
        choseButtons.SetActive(false);
        ShowWhatIChose();
    }
    public void ShowWhatIChose(){
        if(playerIndex==1){
            choseRock.SetActive(true);
            choseGrass.SetActive(false);
            choseStick.SetActive(false);
        }
        if(playerIndex==2){
            choseGrass.SetActive(true);
            choseRock.SetActive(false);
            choseStick.SetActive(false);
        }
        if(playerIndex==3){
            choseStick.SetActive(true);
            choseGrass.SetActive(false);
            choseRock.SetActive(false);
        }
        ChoseEnemy();
    }
    public void ChoseEnemy(){
        enemyIndex = Random.Range(1, 4);
        Debug.Log(enemyIndex);
        if(enemyIndex==1){
            enemyChoseRock.SetActive(true);
            enemyChoseGrass.SetActive(false);
            enemyChoseStick.SetActive(false);
        }
        if(enemyIndex==2){
            enemyChoseGrass.SetActive(true);
            enemyChoseRock.SetActive(false);
            enemyChoseStick.SetActive(false);
        }
        if(enemyIndex==3){
            enemyChoseStick.SetActive(true);
            enemyChoseGrass.SetActive(false);
            enemyChoseRock.SetActive(false);
        }
        CheckWhoWon();
    }
    public void CheckWhoWon(){
        if((playerIndex==1 && enemyIndex==1) || (playerIndex==2 && enemyIndex==2) || (playerIndex==3 && enemyIndex==3)){
            tieText.SetActive(true);
            loseText.SetActive(false);
            wonText.SetActive(false);
            replayButton.SetActive(true);
            GameManager.goldCount+=bidCount;
        }
        if((playerIndex==1 && enemyIndex==3) || (playerIndex==2 && enemyIndex==1) || (playerIndex==3 && enemyIndex==2)){
            tieText.SetActive(false);
            loseText.SetActive(false);
            wonText.SetActive(true);
            replayButton.SetActive(true);
            GameManager.goldCount+=bidCount*2;
        }
        if((playerIndex==1 && enemyIndex==2) || (playerIndex==2 && enemyIndex==3) || (playerIndex==3 && enemyIndex==1)){
            tieText.SetActive(false);
            loseText.SetActive(true);
            wonText.SetActive(false);
            replayButton.SetActive(true);
            //GameManager.goldCount-=bidCount;
        }
        closeButton.SetActive(true);
    }
    public void Replay(){
        FindObjectOfType<AudioManager>().Play("ColectResorce");
        choseRock.SetActive(false);
        choseGrass.SetActive(false);
        choseStick.SetActive(false);
        tieText.SetActive(false);
        loseText.SetActive(false);
        wonText.SetActive(false);
        enemyChoseGrass.SetActive(false);
        enemyChoseRock.SetActive(false);
        enemyChoseStick.SetActive(false);
        replayButton.SetActive(false);

        startButton.SetActive(true);
        tax.SetActive(true);
    }
    public void SettBid10(){
        bidCount=10;
        StartGame();
    }
    public void SettBid25(){
        bidCount=25;
        StartGame();
    }
    public void SettBid50(){
        bidCount=50;
        StartGame();
    }
}
