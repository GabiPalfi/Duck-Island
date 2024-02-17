using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrowNpc : MonoBehaviour
{
    public Transform player;
    public PlayerMovement2 playerScript;
    public float minimDis;
    public GameObject pressButton;
    public GameObject ui;
    public HouseUIanim uiAnim;
    public DialogueScript3 dialogue;
    public static int dialogueIndex;
    public static int questIndex;
    public QuestScript uiScript;
    public GameObject takeButton;
    public InventoryScript inventory;
    public bool isUiActive;
    public GameObject explosion;
    //public  DialogueSCript2 catDialogue;
    //public CatNpc catScript;
    

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
    //public GameObject uiQuest1;
    // Start is called before the first frame update
    void Start()
    {
        dialogue.index = GameManager.dialogueIndexCrow;
        questIndex = GameManager.questIndexCrow;
    }

    // Update is called once per frame
    void Update()
    {
        ShowUI();
        MonitorQuest();
        MonitorButtons();
        TakeButton();
        GameManager.dialogueIndexCrow = dialogueIndex;
        GameManager.questIndexCrow = questIndex;
        //CollectQuests();

        // if(Input.GetKeyDown(KeyCode.O)){
        //     GameManager.isBoss1Defeted = true;
        //     GameManager.isBoss2Defeted = true;
        //     GameManager.isBoss3Defeted = true;
        //     GameManager.isTwinSaved = true;
        // }
    }
    public void CloseUI(){
        uiAnim.anim.SetBool("isOpen",false);
        StartCoroutine(WaitForAnim());
        playerScript.canMove = true;
        playerScript.canShoot1 = true;
        //dialogue.index = 0;
        dialogue.index = dialogueIndex;
        isUiActive=false;
    }
    public void AcceptQuest(){
        uiAnim.anim.SetBool("isOpen",false);
        StartCoroutine(WaitForAnim());
        playerScript.canMove = true;
        playerScript.canShoot1 = true;
        dialogueIndex = dialogue.index;
        questIndex++;
        FindObjectOfType<AudioManager>().Play("ColectResorce");
        GameManager.questStarted = true;
        GameManager.hasTalkedCrow = true;
        if(questIndex == 1){
            GameManager.crowQuest1IsActive = true; 
            StartCoroutine(DestryCrow());
        }else{
            if(questIndex==2){
                inventory.row1[0]-=resourseNecesary;
                GameManager.crowQuest2IsActive = true;
                GameManager.crowQuest1IsActive = false;
                uiScript.index=1;
                
            }else{
                if(questIndex==3){
                    inventory.row1[3]-=resourseNecesary2;
                    GameManager.crowQuest3IsActive = true;
                    GameManager.crowQuest2IsActive = false;
                    uiScript.index=2;
                    GameManager.tokenCount++;
                    Debug.Log("HEYYY");
                }
                
            }
        }
       
        
    }
    // void CollectQuests(){
    //     if(isUiActive&&dialogue.index==7){
    //         inventory.row1[0]-=resourseNecesary;
    //         Debug.Log("PlataAchitata");
    //     }
    //     if(isUiActive&&dialogue.index==10){
    //         inventory.row1[3]-=resourseNecesary2;
    //     }
    //     if(isUiActive&&dialogue.index==14){
    //         inventory.row3[2]-=resourseNecesary3;
    //     }
    // }
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
    public void ShowUI(){
        float distance = Vector3.Distance(transform.position,player.position);
        if(distance<=minimDis){
            if(Input.GetKeyDown(KeyCode.F)){
                ui.SetActive(true);
                isUiActive=true;
                //Debug.Log("HEII");
                uiAnim.anim.SetBool("isOpen",true);
                playerScript.canMove = false;
                playerScript.canShoot1 = false;
            }
            pressButton.SetActive(true);
        }else{
            pressButton.SetActive(false);
        }
        // if(Input.GetKeyDown(KeyCode.P)){
        //     CloseUI();
        // }
    }
    public void MonitorQuest(){
        if(GameManager.crowQuest1IsActive){
            if(GameManager.isBoss1Defeted){
                GameManager.crowQuest1 = true;
                //Debug.Log("QUestCompleted");
                //Debug.Log("QuestComplete");
                if(hasChangedindex==false){
                    dialogue.index = 6;
                    dialogueIndex = 6;
                    dialogue.dialogeLimit = 9;
                    hasChangedindex = true;
                    
                } 
            }else{
                StartCoroutine(Wait1Second());
            }
        }
        if(GameManager.crowQuest2IsActive){
            if(GameManager.isBoss2Defeted){
                GameManager.crowQuest2 = true;
                //Debug.Log("QuestComplete");
                if(hasChangedindex2==false){
                    dialogue.index = 10;
                    dialogueIndex = 10;
                    dialogue.dialogeLimit = 13;
                    hasChangedindex2 = true;
                } 
            }else{
                StartCoroutine(Wait1Second2());
            }
            //Debug.Log("QUEST 2");
        }
        if(GameManager.crowQuest3IsActive){
            if(GameManager.isBoss3Defeted){
                GameManager.crowQuest3 = true;
                
                //Debug.Log("QuestComplete");
                if(hasChangedindex3==false){
                    dialogue.index = 14;
                    dialogueIndex = 14;
                    dialogue.dialogeLimit = 16;
                    hasChangedindex3 = true;
                } 
            }else{
                StartCoroutine(Wait1Second3());
            }
            //Debug.Log("QUEST 3");
        }
        if(dialogue.index==17){
            GameManager.crowQuest3IsActive=false;
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

        if(dialogue.index==20 || dialogue.index==17 || dialogue.index==21){
            dialogue.ShowLeaveButton();
        }else{
            dialogue.HideLeaveButton();
        }
    }
    IEnumerator Wait1Second(){
        yield return new WaitForSeconds(1f);
        dialogue.index = 21;
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
    
        CloseUI();
        StartCoroutine(DestryCrow());
        GameManager.crowQuest3IsActive=false;
        GameManager.hasGivenTokenCrow = true;
        
    }
    IEnumerator DestryCrow(){
        yield return new WaitForSeconds(0.5f);
        Instantiate(explosion,transform.position,Quaternion.identity);
        FindObjectOfType<AudioManager>().Play("BasicEnemyDie");
        //yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }
}
