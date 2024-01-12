using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalCredits : MonoBehaviour
{
    public LoadScreen ui;
    public GameManager gameManager;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MainMenu(){
        ui.EndLevel();
        StartCoroutine(ChangeLevel());
        FindObjectOfType<AudioManager>().Play("ColectResorce");
        gameManager.DeleteSave();
    }
    IEnumerator ChangeLevel(){
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("MainMenu");
        FindObjectOfType<AudioManager>().Play("ColectResorce");
    }
}
