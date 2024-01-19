using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrowScript2 : MonoBehaviour
{
    public Transform player;
    public PlayerMovement2 playerScript;
    public float minimDis;
    public GameObject ui;
    public HouseUIanim uiAnim;
    public GameObject pressButton;
    public GameObject nextButton;
    public GameObject acceptDeclineButtons;
    public CrowDialogueScript dialogue;
    public int lastIndex;
    public bool hasTalked;
    private Animator anim;
    public CameraShake cameraShake;
    public GameManager gameManager;
    public LoadScreen uiScreen;
    public bool hasAccepted;
    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        dialogue.index=0;
    }

    // Update is called once per frame
    void Update()
    {
        CheckUi();
        MonitorButtons();
    }
    public void CheckUi(){
        float distance = Vector3.Distance(transform.position,player.position);
        if(hasTalked==false){
            if(distance<=minimDis){
                if(Input.GetKeyDown(KeyCode.F)){
                    ui.SetActive(true);
                    uiAnim.anim.SetBool("isOpen",true);
                    playerScript.canMove = false;
                    playerScript.canShoot1 = false;
                }
                pressButton.SetActive(true);
            }else{
                pressButton.SetActive(false);
            }
        }
        if(hasTalked){
            pressButton.SetActive(false);
        }
    }

    public void MonitorButtons(){
        if(dialogue.index<lastIndex){
            nextButton.SetActive(true);
        }else{
            nextButton.SetActive(false);
        }
        if(dialogue.index==lastIndex){
            acceptDeclineButtons.SetActive(true);
        }else{
            acceptDeclineButtons.SetActive(false);
        }
    }
    public void CloseUI(){
        uiAnim.anim.SetBool("isOpen",false);
        StartCoroutine(WaitForAnim());
        //playerScript.canMove = true;
        //playerScript.canShoot1 = true;
    }
    IEnumerator WaitForAnim(){
        yield return new WaitForSeconds(0.3f);
        ui.SetActive(false);
    }
    public void AcceptOffer(){
        FindObjectOfType<AudioManager>().Play("ColectResorce");
        CloseUI();
        hasTalked=true;
        anim.SetBool("Decline",true);
        hasAccepted=true;
    }
    public void DeclineOffer(){
        FindObjectOfType<AudioManager>().Play("ColectResorce");
        CloseUI();
        hasTalked=true;
        anim.SetBool("Decline",true);
        hasAccepted=false;
    }
    public void SoundFire(){
        FindObjectOfType<AudioManager>().Play("Fire");
    }
    public void SoundHoror(){
        FindObjectOfType<AudioManager>().Play("Horor");
    }
    public void SoundHoror2(){
        FindObjectOfType<AudioManager>().Play("Horor2");
    }
    public void SoundChurch(){
        FindObjectOfType<AudioManager>().Play("Church");
    }
    public void FinalBoss(){
        Debug.Log("final");
        uiScreen.EndLevel();
        StartCoroutine(NextLevel());
        
    }
    public void CameraShake(){
        StartCoroutine(cameraShake.Shake(gameManager.duration,gameManager.magnitude));
    }
    IEnumerator NextLevel(){
        yield return new WaitForSeconds(0.5f);
        if(hasAccepted){
            SceneManager.LoadScene("Credits");    
        }else{
            SceneManager.LoadScene("Last Level");
        }
         
    }
}
