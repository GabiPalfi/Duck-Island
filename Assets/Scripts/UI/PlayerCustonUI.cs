using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCustonUI : MonoBehaviour
{
    public int index;
    public GameObject arrow1;
    public GameObject arrow2;
    public GameObject arrow3;
    public GameObject arrow4;
    public GameObject arrow12;
    public GameObject arrow22;
    public GameObject arrow32;
    public GameObject arrow42;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RandomColor(){
        FindObjectOfType<AudioManager>().Play("ColectResorce");
        GameManager.bodyIndex = Random.Range(0, 10);
        GameManager.legsIndex = Random.Range(0, 10);
        GameManager.eyesIndex = Random.Range(0, 10);
        GameManager.botIndex = Random.Range(0, 10);
    }
    public void HideAccesory(){
        FindObjectOfType<AudioManager>().Play("ColectResorce");
        GameManager.accesoryIndex =0;
    }
    public void RandomAccesorry(){
        FindObjectOfType<AudioManager>().Play("ColectResorce");
        GameManager.papionIndex = Random.Range(0, 10);
        GameManager.cravataIndex = Random.Range(0, 10);
        GameManager.pamblicaIndex = Random.Range(0, 10);
        GameManager.teacaIndex = Random.Range(0, 10);
    }
    public void OpenBody(){
        index=1;
        FindObjectOfType<AudioManager>().Play("ColectResorce");
        arrow1.SetActive(true);
        arrow2.SetActive(false);
        arrow3.SetActive(false);
        arrow4.SetActive(false);

    }
    public void OpenLegs(){
        index=2;
        FindObjectOfType<AudioManager>().Play("ColectResorce");
        arrow1.SetActive(false);
        arrow2.SetActive(true);
        arrow3.SetActive(false);
        arrow4.SetActive(false);
    }
    public void OpenEye(){
        index=3;
        FindObjectOfType<AudioManager>().Play("ColectResorce");
        arrow1.SetActive(false);
        arrow2.SetActive(false);
        arrow3.SetActive(true);
        arrow4.SetActive(false);
    }
    public void OpenCioc(){
        index=4;
        FindObjectOfType<AudioManager>().Play("ColectResorce");
        arrow1.SetActive(false);
        arrow2.SetActive(false);
        arrow3.SetActive(false);
        arrow4.SetActive(true);
    }
    public void OpenPapion(){
        index=5;
        GameManager.accesoryIndex = 1;
        FindObjectOfType<AudioManager>().Play("ColectResorce");
        arrow12.SetActive(true);
        arrow22.SetActive(false);
        arrow32.SetActive(false);
        arrow42.SetActive(false);

    }
    public void OpenCravata(){
        index=6;
        GameManager.accesoryIndex = 2;
        FindObjectOfType<AudioManager>().Play("ColectResorce");
        arrow12.SetActive(false);
        arrow22.SetActive(true);
        arrow32.SetActive(false);
        arrow42.SetActive(false);
    }
    public void OpenPamblica(){
        index=7;
        GameManager.accesoryIndex = 3;
        FindObjectOfType<AudioManager>().Play("ColectResorce");
        arrow12.SetActive(false);
        arrow22.SetActive(false);
        arrow32.SetActive(true);
        arrow42.SetActive(false);
    }
    public void OpenTeaca(){
        index=8;
        GameManager.accesoryIndex = 4;
        FindObjectOfType<AudioManager>().Play("ColectResorce");
        arrow12.SetActive(false);
        arrow22.SetActive(false);
        arrow32.SetActive(false);
        arrow42.SetActive(true);
    }
    public void Black(){
        if(index==1){
            GameManager.bodyIndex = 9;
        }
        if(index==2){
            GameManager.legsIndex = 9;
        }
        if(index==3){
            GameManager.eyesIndex = 9;
        }
        if(index==4){
            GameManager.botIndex = 9;
        }
        if(index==5){
            GameManager.papionIndex = 9;
        }
        if(index==6){
            GameManager.cravataIndex = 9;
        }
        if(index==7){
            GameManager.pamblicaIndex = 9;
        }
        if(index==8){
            GameManager.teacaIndex = 9;
        }
        FindObjectOfType<AudioManager>().Play("ColectResorce");
    }
    public void White(){
        if(index==1){
            GameManager.bodyIndex = 0;
        }
        if(index==2){
            GameManager.legsIndex = 0;
        }
        if(index==3){
            GameManager.eyesIndex = 0;
        }
        if(index==4){
            GameManager.botIndex = 0;
        }
        if(index==5){
            GameManager.papionIndex = 0;
        }
        if(index==6){
            GameManager.cravataIndex = 0;
        }
        if(index==7){
            GameManager.pamblicaIndex = 0;
        }
        if(index==8){
            GameManager.teacaIndex = 0;
        }
        FindObjectOfType<AudioManager>().Play("ColectResorce");
    }
    public void Red(){
        if(index==1){
            GameManager.bodyIndex = 1;
        }
        if(index==2){
            GameManager.legsIndex = 1;
        }
        if(index==3){
            GameManager.eyesIndex = 1;
        }
        if(index==4){
            GameManager.botIndex = 1;
        }
        if(index==5){
            GameManager.papionIndex = 1;
        }
        if(index==6){
            GameManager.cravataIndex = 1;
        }
        if(index==7){
            GameManager.pamblicaIndex = 1;
        }
        if(index==8){
            GameManager.teacaIndex = 1;
        }
        FindObjectOfType<AudioManager>().Play("ColectResorce");
    }
    public void Blue(){
        if(index==1){
            GameManager.bodyIndex = 4;
        }
        if(index==2){
            GameManager.legsIndex = 4;
        }
        if(index==3){
            GameManager.eyesIndex = 4;
        }
        if(index==4){
            GameManager.botIndex = 4;
        }
        if(index==5){
            GameManager.papionIndex = 4;
        }
        if(index==6){
            GameManager.cravataIndex = 4;
        }
        if(index==7){
            GameManager.pamblicaIndex = 4;
        }
        if(index==8){
            GameManager.teacaIndex = 4;
        }
        FindObjectOfType<AudioManager>().Play("ColectResorce");
    }
    public void Green(){
        if(index==1){
            GameManager.bodyIndex = 3;
        }
        if(index==2){
            GameManager.legsIndex = 3;
        }
        if(index==3){
            GameManager.eyesIndex = 3;
        }
        if(index==4){
            GameManager.botIndex = 3;
        }
        if(index==5){
            GameManager.papionIndex = 3;
        }
        if(index==6){
            GameManager.cravataIndex = 3;
        }
        if(index==7){
            GameManager.pamblicaIndex = 3;
        }
        if(index==8){
            GameManager.teacaIndex = 3;
        }
        FindObjectOfType<AudioManager>().Play("ColectResorce");
    }
    public void Yellow(){
        if(index==1){
            GameManager.bodyIndex = 2;
        }
        if(index==2){
            GameManager.legsIndex = 2;
        }
        if(index==3){
            GameManager.eyesIndex = 2;
        }
        if(index==4){
            GameManager.botIndex = 2;
        }
        if(index==5){
            GameManager.papionIndex = 2;
        }
        if(index==6){
            GameManager.cravataIndex = 2;
        }
        if(index==7){
            GameManager.pamblicaIndex = 2;
        }
        if(index==8){
            GameManager.teacaIndex = 2;
        }
        FindObjectOfType<AudioManager>().Play("ColectResorce");
    }
    public void Orange(){
        if(index==1){
            GameManager.bodyIndex = 7;
        }
        if(index==2){
            GameManager.legsIndex = 7;
        }
        if(index==3){
            GameManager.eyesIndex = 7;
        }
        if(index==4){
            GameManager.botIndex = 7;
        }
        if(index==5){
            GameManager.papionIndex = 7;
        }
        if(index==6){
            GameManager.cravataIndex = 7;
        }
        if(index==7){
            GameManager.pamblicaIndex = 7;
        }
        if(index==8){
            GameManager.teacaIndex = 7;
        }
        FindObjectOfType<AudioManager>().Play("ColectResorce");
    }
    public void Purple(){
        if(index==1){
            GameManager.bodyIndex = 5;
        }
        if(index==2){
            GameManager.legsIndex = 5;
        }
        if(index==3){
            GameManager.eyesIndex = 5;
        }
        if(index==4){
            GameManager.botIndex = 5;
        }
        if(index==5){
            GameManager.papionIndex = 5;
        }
        if(index==6){
            GameManager.cravataIndex = 5;
        }
        if(index==7){
            GameManager.pamblicaIndex = 5;
        }
        if(index==8){
            GameManager.teacaIndex = 5;
        }
        FindObjectOfType<AudioManager>().Play("ColectResorce");
    }
    public void Pink(){
        if(index==1){
            GameManager.bodyIndex = 6;
        }
        if(index==2){
            GameManager.legsIndex = 6;
        }
        if(index==3){
            GameManager.eyesIndex = 6;
        }
        if(index==4){
            GameManager.botIndex = 6;
        }
        if(index==5){
            GameManager.papionIndex = 6;
        }
        if(index==6){
            GameManager.cravataIndex = 6;
        }
        if(index==7){
            GameManager.pamblicaIndex = 6;
        }
        if(index==8){
            GameManager.teacaIndex = 6;
        }
        FindObjectOfType<AudioManager>().Play("ColectResorce");
    }
    public void Brown(){
        if(index==1){
            GameManager.bodyIndex = 8;
        }
        if(index==2){
            GameManager.legsIndex = 8;
        }
        if(index==3){
            GameManager.eyesIndex = 8;
        }
        if(index==4){
            GameManager.botIndex = 8;
        }
        if(index==5){
            GameManager.papionIndex = 8;
        }
        if(index==6){
            GameManager.cravataIndex = 8;
        }
        if(index==7){
            GameManager.pamblicaIndex = 8;
        }
        if(index==8){
            GameManager.teacaIndex = 8;
        }
        FindObjectOfType<AudioManager>().Play("ColectResorce");
    }
}
