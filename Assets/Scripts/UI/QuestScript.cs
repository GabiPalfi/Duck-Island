using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuestScript : MonoBehaviour
{
    public TextMeshProUGUI Text;
    public bool isFish;
    public bool isCat;
    public string[] quests = new string[3];
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
        
        //Text.text = quests[index];
    }
}
