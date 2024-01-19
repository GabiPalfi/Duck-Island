using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrowNpcCheck : MonoBehaviour
{
    public GameObject crow;
    public int index;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(GameManager.hasTalkedCrow);
        if(index==1){
            if(GameManager.hasTalkedCrow){
                crow.SetActive(false);
            }
        }
        if(index==2){
            if(GameManager.hasGivenTokenCrow){
                crow.SetActive(false);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        // if(index==1){
        //     if(GameManager.hasTalkedCrow){
        //         crow.SetActive(false);
        //     }
        // }
        // if(index==2){
        //     if(GameManager.hasGivenTokenCrow){
        //         crow.SetActive(false);
        //     }
        // }
    }
}
