using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuestScript : MonoBehaviour
{
    public TextMeshProUGUI Text;
    public bool isFish;
    public bool isCat;
    public bool isBase;
    public bool isCrow;
    public string[] quests = new string[20];
    public int index;
    // Start is called before the first frame update
    void Start()
    {
        Text = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isCat){
            if(GameManager.catQuest1IsActive){
                Text.text = quests[0];
            }
            if(GameManager.catQuest2IsActive){
                Text.text = quests[1];
            }
            if(GameManager.catQuest3IsActive){
                Text.text = quests[2];
            }
        }
        if(isFish){
            if(GameManager.docQuest1IsActive){
                Text.text = quests[0];
            }
            if(GameManager.docQuest2IsActive){
                Text.text = quests[1];
            }
            if(GameManager.docQuest3IsActive){
                Text.text = quests[2];
            }
        }

        if(isCrow){
            if(GameManager.crowQuest1IsActive){
                Text.text = quests[0];
            }
            if(GameManager.crowQuest2IsActive){
                Text.text = quests[1];
            }
            if(GameManager.crowQuest3IsActive){
                Text.text = quests[2];
            }
        }

        if(isBase){
            // if(GameManager.buildIndex==0){
            //     Text.text = quests[10];
            // }
            if(GameManager.buildIndex==1){
                Text.text = quests[0];
            }
            if(GameManager.buildIndex==2){
                Text.text = quests[1];
            }
            if(GameManager.buildIndex==3){
                Text.text = quests[2];
            }
            if(GameManager.buildIndex==4){
                Text.text = quests[3];
            }
            if(GameManager.buildIndex==5){
                Text.text = quests[4];
            }
            if(GameManager.buildIndex==6){
                Text.text = quests[5];
            }
            if(GameManager.buildIndex==7){
                Text.text = quests[6];
            }
            if(GameManager.buildIndex==8){
                Text.text = quests[7];
            }
            if(GameManager.buildIndex==9){
                Text.text = quests[8];
            }
            if(GameManager.buildIndex==10){
                Text.text = quests[9];
            }
        }
        
        //Text.text = quests[index];
    }
}
