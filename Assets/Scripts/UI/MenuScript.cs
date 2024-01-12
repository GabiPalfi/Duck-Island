using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuScript : MonoBehaviour
{
    public GameObject startButton;
    public GameObject continueButton;
    public GameManager gameManager;
    public GameObject saveIcon;
    //public LoadScreen ui;
    // Start is called before the first frame update
    void Start()
    {
        //gameManager.LoadData();
        if(GameManager.saveFileExists){
            //startButton.SetActive(false);
            continueButton.SetActive(true);
        }else{
            //startButton.SetActive(true);
            continueButton.SetActive(false);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartGame(){
        gameManager.DeleteSave();
        FindObjectOfType<AudioManager>().Play("ColectResorce");
        //ui.EndLevel();
        StartCoroutine(WaitAbitStartGame());
    }
    IEnumerator WaitAbitStartGame(){
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Cuttscene");
    }
    public void CloseGame(){
        Application.Quit();
    }
    public void Sound(){
        FindObjectOfType<AudioManager>().Play("ColectResorce");
    }
    public void ContinueGame(){
        FindObjectOfType<AudioManager>().Play("ColectResorce");
        gameManager.LoadData();
        //ui.EndLevel();
        StartCoroutine(WaitAbitContinueGame());
    }
    IEnumerator WaitAbitContinueGame(){
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("MainBase");
    }
    public void DeleteSave(){
        gameManager.DeleteSave();
        saveIcon.SetActive(false);
        //gameManager.LoadData();
        gameManager.SaveData();
    }
    public void Cuttscene(){
        FindObjectOfType<AudioManager>().Play("ColectResorce");
        StartCoroutine(WaitAbitContinueGame());
    }
    public void ChoseDificultyEasy(){
        GameManager.difficulty = 1;
        StartGame();
    }
    public void ChoseDificultyNormal(){
        GameManager.difficulty = 0;
        StartGame();
    }
    public void ChoseDificultyHard(){
        GameManager.difficulty = -1;
        StartGame();
    }
}
