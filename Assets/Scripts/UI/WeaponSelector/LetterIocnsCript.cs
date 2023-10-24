using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LetterIocnsCript : MonoBehaviour
{
    public Sprite normalLetter;
    public Sprite rockLetter;
    public Sprite fireworkLetter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.isNormalLetterSelected){
            gameObject.GetComponent<Image>().sprite = normalLetter;
        }
        if(GameManager.isRockLetterSelected){
            gameObject.GetComponent<Image>().sprite = rockLetter;
        }
        if(GameManager.isFireworkLetterSelected){
            gameObject.GetComponent<Image>().sprite = fireworkLetter;
        }
    }
}
