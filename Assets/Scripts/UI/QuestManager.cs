using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    public GameObject uiFish;
    public GameObject uiCat;
    public GameObject uiCrow;

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
        if(GameManager.crowQuest1IsActive || GameManager.crowQuest2IsActive|| GameManager.crowQuest3IsActive ){
            uiCrow.SetActive(true);
        }else{
            uiCrow.SetActive(false);
        }
        
    }
}
