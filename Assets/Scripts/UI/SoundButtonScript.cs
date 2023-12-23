using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundButtonScript : MonoBehaviour
{
    public Button spriteRenderer;
    public Sprite soundOff;
    public Sprite soundOn;   
    // Start is called before the first frame update
    void Start()
    {
        
        if(GameManager.isSoundPaused){
            AudioListener.pause = true;
            spriteRenderer.image.sprite = soundOff; 
        }else{
            AudioListener.pause = false;
            spriteRenderer.image.sprite = soundOn;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ButtonClicked(){
        if(GameManager.isSoundPaused){
            SoundOn();
        }else{
            SoundOff();
        }
    }
    public void SoundOff(){
        AudioListener.pause = true;
        FindObjectOfType<AudioManager>().Play("ColectResorce");
        GameManager.isSoundPaused = true;
        spriteRenderer.image.sprite = soundOff; 
        //Debug.Log("Sunet Off");
        
    }
    public void SoundOn(){
        AudioListener.pause = false;
        FindObjectOfType<AudioManager>().Play("ColectResorce");
        GameManager.isSoundPaused = false;
        spriteRenderer.image.sprite = soundOn; 
        //Debug.Log("Sunet On");
    }
}
