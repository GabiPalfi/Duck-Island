using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Rendering;

public class DialogueScript3 : MonoBehaviour
{
    public int index;
    public string[] lines = new string[10];
    public TextMeshProUGUI Text;
    public GameObject button;
    public GameObject nextButton;
    public int buttonIndex;
    public int dialogeLimit;
    //public GameObject yesButton;
    public GameObject leaveButton;
    // Start is called before the first frame update
    void Start()
    {
        Text = GetComponent<TextMeshProUGUI>();
        index = CrowNpc.dialogueIndex;
    }

    // Update is called once per frame
    void Update()
    {
        Text.text = lines[index];
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)){
            if(index<dialogeLimit){
                NewLine();
            }
           
        }
        if(Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)){
            //OldLine();
        }
        // if(index == buttonIndex){
        //     button.SetActive(true);
        //     nextButton.SetActive(false);
        // }else{
        //     button.SetActive(false);
        //     nextButton.SetActive(true);
        // }
    }
    public void NewLine(){
        index++;
        FindObjectOfType<AudioManager>().Play("ColectResorce");
        //Debug.Log("Am APASAT");

    }
    public void OldLine(){
        index--;
    }
    public void ShowNextButton(){
        nextButton.SetActive(true);
    }
    public void ShowAcceptDeclineButton(){
        button.SetActive(true);
        
    }
    public void ShowYesButton(){

    }
    public void HideNext(){
        nextButton.SetActive(false);
    }
    public void HideAcceptDeclineButton(){
        button.SetActive(false);
    }
    public void HideYesButton(){

    }
    public void ShowLeaveButton(){
        leaveButton.SetActive(true);
    }
    public void HideLeaveButton(){
        leaveButton.SetActive(false);
    }
}
