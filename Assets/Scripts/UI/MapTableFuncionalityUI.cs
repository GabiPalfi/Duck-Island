using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MapTableFuncionalityUI : MonoBehaviour
{
    public LoadScreen anim;
    public GameObject skullIslandLocked;
    public GameObject skullIslandUnlock;
    public GameObject skullIslandTravel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.island1Unlocked){
            skullIslandLocked.SetActive(false);
            skullIslandUnlock.SetActive(false);
            skullIslandTravel.SetActive(true);
        }else{
            skullIslandLocked.SetActive(true);
            skullIslandUnlock.SetActive(true);
            skullIslandTravel.SetActive(false);
        }
    }
    public void UnlockSkullIsland(){
        if(GameManager.tokenCount>=1){
            GameManager.tokenCount--;
            GameManager.island1Unlocked=true;
            skullIslandLocked.SetActive(false);
            skullIslandUnlock.SetActive(false);
            skullIslandTravel.SetActive(true);
        }
    }
    public void GoToSkullIsland(){
        anim.EndLevel();
        StartCoroutine(ChangeScene());
       
    }
    IEnumerator ChangeScene(){
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Level 3");
    }
}
