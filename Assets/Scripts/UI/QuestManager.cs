using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    public GameObject uiFish;
    public GameObject uiCat;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.docQuest1IsActive || GameManager.docQuest2IsActive|| GameManager.docQuest3IsActive ){
            uiFish.SetActive(true);
        }else{
            uiFish.SetActive(false);
        }
        if(GameManager.catQuest1IsActive || GameManager.catQuest2IsActive|| GameManager.catQuest3IsActive ){
            uiCat.SetActive(true);
        }else{
            uiCat.SetActive(false);
        }
        
    }
}
