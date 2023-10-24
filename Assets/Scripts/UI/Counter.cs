using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Counter : MonoBehaviour
{
    public int maxTime;
    
    // Start is called before the first frame update
    void Start()
    {
        Scene scene = SceneManager.GetActiveScene();
        if(GameManager.hasBeenPlanted1 && scene.name!="Main Base"){
            maxTime=GameManager.maxTime1;
            StartCoroutine(Farm1());
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Farm1(){
        for(int i=GameManager.currentTime1;i<=maxTime;i++){
            yield return new WaitForSeconds(1f);
            //Debug.Log(i);
            GameManager.currentTime1++;
        }
    }
}
