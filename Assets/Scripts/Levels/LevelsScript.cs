using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelsScript : MonoBehaviour
{
    public LoadScreen ui;
    public GameObject uiF;
    public Transform player;
    public float minimDis;
    public int index;
    public int sceneIndex;
    // public static int currentLevel;
    // public static int lastLevel;
    // public static int exitIndexStatic;
    // public int exitIndex;
    public int nextLevel;
    // public bool isGoing;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Scene scene = SceneManager.GetActiveScene();
        float distance = Vector3.Distance(transform.position,player.position);
        if(distance<=minimDis){
            uiF.SetActive(true);
            if(Input.GetKeyDown(KeyCode.F)){
                ui.EndLevel();
                FindObjectOfType<AudioManager>().Play("ColectResorce");
                StartCoroutine(WaitAbit());
                if(scene.name=="MainBase"){
                    GameManager.gameStarted=true;
                    GameManager.isLevel1Finish=true;
                    //FindObjectOfType<SaveLoadPos>().Save();
                }
                if(index==10){
                    
                    GameManager.level1Index=1;
                    
                }
                if(index==11){
                    
                    GameManager.level1Index=0;
                    
                }
                if(index==12){
                    
                    GameManager.level1Index=2;
                    
                }

                
                
                
            }
        }else{
            uiF.SetActive(false);
        }
    }
    IEnumerator WaitAbit(){
        yield return new WaitForSeconds(0.5f);
        //FindObjectOfType<SaveLoadPos>().Save();
        SceneManager.LoadScene(sceneIndex);
    }
    
}
