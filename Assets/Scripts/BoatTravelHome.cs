using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BoatTravelHome : MonoBehaviour
{
    public Transform player;
    public float minimDis;
    public GameObject pressButton;
    public GameObject ui;
    public PlayerMovement2 playerScript;
    public HouseUIanim uiAnim;
    public GameObject travelButton;
    public LoadScreen uiScreen;
    
    // Start is called before the first frame update
    void Start()
    {
        
       
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position,player.position);
        if(distance<=minimDis){
            if(Input.GetKeyDown(KeyCode.F)){
                FindObjectOfType<AudioManager>().Play("ColectResorce");
                ui.SetActive(true);
                uiAnim.anim.SetBool("isOpen",true);
                playerScript.canMove = false;
                playerScript.canShoot1 = false;
            }
            pressButton.SetActive(true);
        }else{
            pressButton.SetActive(false);
        }

        if(GameManager.isBoss1Defeted && GameManager.isBoss2Defeted && GameManager.isBoss3Defeted && GameManager.isLastBossDefeted){
            travelButton.SetActive(true);
        }else{
            travelButton.SetActive(false);
        }
        
    }
    public void Close(){
        uiAnim.anim.SetBool("isOpen",false);
        FindObjectOfType<AudioManager>().Play("ColectResorce");
        StartCoroutine(HideUi());
    }
    IEnumerator HideUi(){
        yield return new WaitForSeconds(0.5f);
        ui.SetActive(false);
        playerScript.canMove = true;
        playerScript.canShoot1 = true;

    }
    public void TravelHome(){
        uiScreen.EndLevel();
        StartCoroutine(ChangeScene());
    }
    IEnumerator ChangeScene(){
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Credits");   
    }
}
