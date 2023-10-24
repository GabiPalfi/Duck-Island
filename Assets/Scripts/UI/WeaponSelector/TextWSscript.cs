using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextWSscript : MonoBehaviour
{
    public TextMeshProUGUI Text;
    public int index;
    public GameObject icon;
    // Start is called before the first frame update
    void Start()
    {
        Text = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if(index==1){
            Text.text = GameManager.rockLetterCount.ToString();
            if(GameManager.rockLetterCount>0){
                Text.enabled = true;
                icon.SetActive(true);
            }else{
                Text.enabled = false;
                icon.SetActive(false);
            }
        }
        if(index==2){
            Text.text = GameManager.fireworkLetterCount.ToString();
            if(GameManager.fireworkLetterCount>0){
                Text.enabled = true;
                icon.SetActive(true);
            }else{
                Text.enabled = false;
                icon.SetActive(false);
            }
        }
    }
}
