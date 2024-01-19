using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DieScreenUi : MonoBehaviour
{
    public GameObject ui;
    public PlayerMovement2 playerScript;
    //public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.playerHasDied){
            ShowUI();
            GameManager.playerHasDied = false;
        }
        //Debug.Log(GameManager.playerHasDied);
    }
    public void ShowUI(){
        ui.SetActive(true);
        playerScript.canMove=false;
        playerScript.canShoot1=false;

    }
    public void RestartGame(){
        Scene scene = SceneManager.GetActiveScene();
        if(scene.name=="Last Level"){
            GameManager.lastLevelDeathCount++;
        }
        FindObjectOfType<GameManager>().StartGame();
    }
    public void ResetScene(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
