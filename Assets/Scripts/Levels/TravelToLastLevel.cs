using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TravelToLastLevel : MonoBehaviour
{
    public LoadScreen ui;
    public GameObject uiTax;
    public GameObject uiF;
    public Transform player;
    public float minimDis;
    //public int index;
    // Start is called before the first frame update
    void Start()
    {
        // GameManager.isBoss1Defeted=true;
        // GameManager.isBoss2Defeted=true;;
        // GameManager.isBoss3Defeted=true;
        // Debug.Log(GameManager.isBoss1Defeted);
        // Debug.Log(GameManager.isBoss2Defeted);
        // Debug.Log(GameManager.isBoss3Defeted);
    }

    // Update is called once per frame
    void Update()
    {
        // Scene scene = SceneManager.GetActiveScene();
        float distance = Vector3.Distance(transform.position,player.position);
        if(distance<=minimDis){
            uiF.SetActive(true);
            uiTax.SetActive(true);
            if(Input.GetKeyDown(KeyCode.F)){
                if(GameManager.isBoss1Defeted && GameManager.isBoss2Defeted && GameManager.isBoss3Defeted && GameManager.hasGivenTokenCrow == true){
                    ui.EndLevel();
                    FindObjectOfType<AudioManager>().Play("ColectResorce");
                    SceneManager.LoadScene("Level 13");
                    //Debug.Log("PULAAAA");
                }
            }
            
        }else{
            uiF.SetActive(false);
            uiTax.SetActive(false);
        }
    }
}
