using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatNpc : MonoBehaviour
{
    public Transform player;
    public PlayerMovement2 playerScript;
    public float minimDis;
    public GameObject pressButton;
    public GameObject ui;
    public HouseUIanim uiAnim;
    public HouseUIanim shopAnim;
    public GameObject shopUI;
    public DialogueSCript2 dialogue;
    public static int dialogueIndex2;
    public static int questIndex;
    public QuestScript uiScript;
    public GameObject takeButton;
    public GameObject buttons;
    public GameObject dialogueButton;
    public InventoryScript inventory;
    

    [Header("Quest 1")]
    public int resourseNecesary;
    public int resourceIndex;
    public bool hasChangedindex = false;

    [Header("Quest 2")]
    public int resourseNecesary2;
    public int resourceIndex2;
    public bool hasChangedindex2 = false;

     [Header("Quest 3")]
    public int resourseNecesary3;
    public int resourceIndex3;
    public bool hasChangedindex3 = false;
    public GameObject twin;
    //public GameObject uiQuest1;
    // Start is called before the first frame update
    void Start()
    {
        dialogue.index = GameManager.dialogueIndexCat;
        if(GameManager.isTwinSaved){
            twin.SetActive(true);
        }else{
            twin.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        ShowUI();
        MonitorQuest();
        MonitorButtons();
        TakeButton();
        DialogueButtonCheck();
        GameManager.dialogueIndexCat = dialogueIndex2;
        GameManager.questIndexCat = questIndex;

    }
    public void CloseUI(){
        uiAnim.anim.SetBool("isOpen",false);
        StartCoroutine(WaitForAnim());
        playerScript.canMove = true;
        playerScript.canShoot1 = true;
        //dialogue.index = 0;
        dialogue.index = dialogueIndex2;
        //GameManager.ContinueGame();
        
    }
    void DialogueButtonCheck(){
        if(GameManager.docQuest3){
            dialogueButton.SetActive(true);
        }else{
            dialogueButton.SetActive(false);
        }
    }
    public void AcceptQuest(){
        uiAnim.anim.SetBool("isOpen",false);
        StartCoroutine(WaitForAnim());
        playerScript.canMove = true;
        playerScript.canShoot1= true;
        dialogueIndex2 = dialogue.index;
        questIndex++;
        GameManager.questStarted = true;
        if(questIndex == 1){
            GameManager.catQuest1IsActive = true; 
            
        }else{
            if(questIndex==2){
                GameManager.catQuest2IsActive = true;
                GameManager.catQuest1IsActive = false;
                uiScript.index=1;
            }else{
                if(questIndex==3){
                    GameManager.catQuest3IsActive = true;
                    GameManager.catQuest2IsActive = false;
                    uiScript.index=2;
                    inventory.row3[0]-=resourseNecesary2;
                    inventory.row3[1]-=resourseNecesary2;
                    inventory.row3[2]-=resourseNecesary2;
                    inventory.row3[3]-=resourseNecesary2;
                }
                
            }
        }
       
        
    }
    public void TakeButton(){
        if(dialogue.index==16){
            takeButton.SetActive(true);
        }else{
            takeButton.SetActive(false);
        }
    }
    IEnumerator WaitForAnim(){
        yield return new WaitForSeconds(0.3f);
        ui.SetActive(false);
    }
    public void DialogueSystem(){
        ui.SetActive(true);
        uiAnim.anim.SetBool("isOpen",true);
        
        buttons.SetActive(false);
    }
    public void Leave(){
        buttons.SetActive(false);
        playerScript.canMove = true;
        playerScript.canShoot1 = true;
    }
    public void LeaveShop(){
        shopAnim.anim.SetBool("isOpen",false);
        buttons.SetActive(false);
        playerScript.canMove = true;
        playerScript.canShoot1 = true;
        shopUI.SetActive(false);
        
    }
    public void Shop(){
        buttons.SetActive(false);
        shopUI.SetActive(true);
        shopAnim.anim.SetBool("isOpen",true);
    }

    public void ShowUI(){
        float distance = Vector3.Distance(transform.position,player.position);
        if(distance<=minimDis){
            if(Input.GetKeyDown(KeyCode.F)){
                //DialogueSystem();
                //GameManager.PauseGame();
                buttons.SetActive(true);
                playerScript.canMove = false;
                playerScript.canShoot1 = false;
                
            }
            pressButton.SetActive(true);
        }else{
            pressButton.SetActive(false);
        }
        if(Input.GetKeyDown(KeyCode.P)){
            CloseUI();
        }
    }
    public void MonitorQuest(){
        if(GameManager.catQuest1IsActive){
            if(GameManager.gooldSpent >= resourseNecesary){
                GameManager.catQuest1 = true;
                //Debug.Log("QuestComplete");
                if(hasChangedindex==false){
                    dialogue.index = 6;
                    dialogueIndex2 = 6;
                    dialogue.dialogeLimit = 9;
                    hasChangedindex = true;
                } 
            }else{
                StartCoroutine(Wait1Second());
            }
        }
        if(GameManager.catQuest2IsActive){
            if(GameManager.tomatoCount >= resourseNecesary2 && GameManager.pumpkinCount >= resourseNecesary2 && GameManager.carrotCount >= resourseNecesary2 && GameManager.cornCount >= resourseNecesary2){
                GameManager.catQuest2 = true;
                //Debug.Log("QuestComplete");
                if(hasChangedindex2==false){
                    dialogue.index = 10;
                    dialogueIndex2 = 10;
                    dialogue.dialogeLimit = 13;
                    hasChangedindex2 = true;
                } 
            }else{
                StartCoroutine(Wait1Second2());
            }
            //Debug.Log("QUEST 2");
        }
        if(GameManager.catQuest3IsActive){
            if(GameManager.isTwinSaved){
                GameManager.catQuest3 = true;
                //Debug.Log("QuestComplete");
                if(hasChangedindex3==false){
                    dialogue.index = 14;
                    dialogueIndex2 = 14;
                    dialogue.dialogeLimit = 16;
                    hasChangedindex3 = true;
                } 
            }else{
                StartCoroutine(Wait1Second3());
            }
            //Debug.Log("QUEST 3");
        }
        if(dialogue.index==17){
            GameManager.catQuest3IsActive=false;
        }
    }
    public void MonitorButtons(){
        if(dialogue.index==5 || dialogue.index==9 || dialogue.index==13){
            //dialogue.HideNext();
            dialogue.ShowAcceptDeclineButton();
        }else{
            //dialogue.ShowNextButton();
            dialogue.HideAcceptDeclineButton();
        }

        if(dialogue.index<dialogue.dialogeLimit){
            dialogue.ShowNextButton();
        }else{
            dialogue.HideNext();
        }

        if(dialogue.index==20 || dialogue.index==17){
            dialogue.ShowLeaveButton();
        }else{
            dialogue.HideLeaveButton();
        }
    }
    IEnumerator Wait1Second(){
        yield return new WaitForSeconds(1f);
        dialogue.index = 20;
        if(hasChangedindex==true){
            dialogue.index = 6;
            dialogue.dialogeLimit = 9;
            
        } 
        
    }
    IEnumerator Wait1Second2(){
        yield return new WaitForSeconds(1f);
        dialogue.index = 20;
        if(hasChangedindex2==true){
            dialogue.index = 10;
            dialogue.dialogeLimit = 13;
            
        } 
        
    }
    IEnumerator Wait1Second3(){
        yield return new WaitForSeconds(1f);
        dialogue.index = 20;
        if(hasChangedindex3==true){
            dialogue.index = 14;
            dialogue.dialogeLimit = 16;
            
        } 
        
    }
    // IEnumerator ChangeIndex(){
    //     yield return new WaitForSeconds(1f);
    //     dialogue.index++;
        
    // }
    public void TakeToken(){
        GameManager.tokenCount++;
        CloseUI();
        dialogue.index=17;
        dialogueIndex2=17;
    }
    public void Reset(){
        dialogue.index=0;
    }
}
