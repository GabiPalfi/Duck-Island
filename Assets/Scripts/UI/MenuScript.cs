using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuScript : MonoBehaviour
{
    public GameObject startButton;
    public GameObject continueButton;
    //public LoadScreen ui;
    // Start is called before the first frame update
    void Start()
    {
        if(GameManager.isLevel1Finish){
            startButton.SetActive(false);
            continueButton.SetActive(true);
        }else{
            startButton.SetActive(true);
            continueButton.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartGame(){
        
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
        //ui.EndLevel();
        StartCoroutine(WaitAbitContinueGame());
    }
    IEnumerator WaitAbitContinueGame(){
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("MainBase");
    }
}
