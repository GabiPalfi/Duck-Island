using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MapTableFuncionalityUI : MonoBehaviour
{
    public LoadScreen anim;

    public GameObject skullIslandLocked;
    public GameObject skullIslandUnlockButton;
    public GameObject skullIslandTravel;

    public GameObject japanIslandLocked;
    public GameObject japanIslandUnlockButton;
    public GameObject japanIslandTravel;

    public GameObject corporationIslandLocked;
    public GameObject corporationIslandUnlockButton;
    public GameObject corporationIslandTravel;


    public int index;
    // Start is called before the first frame update
    void Start()
    {
        //GameManager.tokenCount=3;
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.island1Unlocked){
            skullIslandLocked.SetActive(false);
            skullIslandUnlockButton.SetActive(false);
            skullIslandTravel.SetActive(true);
            japanIslandUnlockButton.SetActive(true);
            
        }else{
            skullIslandLocked.SetActive(true);
            skullIslandUnlockButton.SetActive(true);
            skullIslandTravel.SetActive(false);
            // japanIslandUnlockButton.SetActive(true);
        }

        if(GameManager.island2Unlocked){
            japanIslandLocked.SetActive(false);
            japanIslandUnlockButton.SetActive(false);
            japanIslandTravel.SetActive(true);
            corporationIslandUnlockButton.SetActive(true);
            
        }else{
            japanIslandLocked.SetActive(true);
            //japanIslandUnlockButton.SetActive(true);
            japanIslandTravel.SetActive(false);
            //japanIslandUnlockButton.SetActive(true);
        }

        if(GameManager.island3Unlocked){
            corporationIslandLocked.SetActive(false);
            corporationIslandUnlockButton.SetActive(false);
            corporationIslandTravel.SetActive(true);
            //corporationIslandUnlockButton.SetActive(true);
            
        }else{
            corporationIslandLocked.SetActive(true);
            //japanIslandUnlockButton.SetActive(true);
            corporationIslandTravel.SetActive(false);
            //japanIslandUnlockButton.SetActive(true);
        }

    }
    public void UnlockSkullIsland(){
        if(GameManager.tokenCount>=1){
            GameManager.tokenCount--;
            GameManager.island1Unlocked=true;
            skullIslandLocked.SetActive(false);
            skullIslandUnlockButton.SetActive(false);
            skullIslandTravel.SetActive(true);
            FindObjectOfType<AudioManager>().Play("ColectResorce");
        }
    }
    public void UnlockJapanIsland(){
        if(GameManager.tokenCount>=1 && GameManager.island1Unlocked){
            GameManager.tokenCount--;
            GameManager.island2Unlocked=true;
            japanIslandLocked.SetActive(false);
            japanIslandUnlockButton.SetActive(false);
            japanIslandTravel.SetActive(true);
            FindObjectOfType<AudioManager>().Play("ColectResorce");
        }
    }
    public void UnlockCorporationIsland(){
        if(GameManager.tokenCount>=1 && GameManager.island1Unlocked && GameManager.island2Unlocked){
            GameManager.tokenCount--;
            GameManager.island3Unlocked=true;
            // japanIslandLocked.SetActive(false);
            // japanIslandUnlockButton.SetActive(false);
            // japanIslandTravel.SetActive(true);
            FindObjectOfType<AudioManager>().Play("ColectResorce");
        }
    }

    public void GoToSkullIsland(){
        index=1;
        anim.EndLevel();
        FindObjectOfType<AudioManager>().Play("ColectResorce");
        StartCoroutine(ChangeScene());
       
    }
    public void GoToJapanIsland(){
        index=2;
        anim.EndLevel();
        FindObjectOfType<AudioManager>().Play("ColectResorce");
        StartCoroutine(ChangeScene());
       
    }
    public void GoToCorporationIsland(){
        index=3;
        anim.EndLevel();
        FindObjectOfType<AudioManager>().Play("ColectResorce");
        StartCoroutine(ChangeScene());
       
    }
    
    IEnumerator ChangeScene(){
        yield return new WaitForSeconds(0.5f);
        if(index==1){
            SceneManager.LoadScene("Level 3");
        }
        if(index==2){
            SceneManager.LoadScene("Level 7");
        }
        if(index==3){
            SceneManager.LoadScene("Level 9");
        }
        
    }
}
