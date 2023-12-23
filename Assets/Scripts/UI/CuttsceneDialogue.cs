using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CuttsceneDialogue : MonoBehaviour
{
    public int index;
    public string[] lines = new string[10];
    public TextMeshProUGUI Text;
    public int dialogeLimit;
    public GameObject button;
    public GameObject nextButton;
    
    // Start is called before the first frame update
    void Start()
    {
        Text = GetComponent<TextMeshProUGUI>();
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
        if(Input.GetKeyDown(KeyCode.A)){
            if(index>0){
                OldLine();
            }
        }
        if(index==dialogeLimit){
            button.SetActive(true);
        }
        if(index<dialogeLimit){
            nextButton.SetActive(true);
        }else{
            nextButton.SetActive(false);
        }
    }
    public void NewLine(){
        index++;
        FindObjectOfType<AudioManager>().Play("ColectResorce");
    }
    public void OldLine(){
        index--;
        FindObjectOfType<AudioManager>().Play("ColectResorce");
    }
}
