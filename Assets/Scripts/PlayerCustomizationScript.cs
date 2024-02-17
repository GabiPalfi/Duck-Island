using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCustomizationScript : MonoBehaviour
{
    public Material[] material;
    public int index;
    // public static int bodyIndex = 0;
    // public static int legsIndex = 7;
    // public static int eyesIndex = 9;
    // public static int botIndex = 7;
    Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        ActualizeazaMaterialele();
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
       //ActualizeazaMaterialele();
        if(index==1){
            rend.sharedMaterial = material[GameManager.bodyIndex];
        }
        if(index==2){
            rend.sharedMaterial = material[GameManager.legsIndex];
        }
        if(index==3){
            rend.sharedMaterial = material[GameManager.eyesIndex];
        }
        if(index==4){
            rend.sharedMaterial = material[GameManager.botIndex];
        }
        if(index==5){
            rend.sharedMaterial = material[GameManager.papionIndex];
        }
         if(index==6){
            rend.sharedMaterial = material[GameManager.cravataIndex];
        }
        if(index==7){
            rend.sharedMaterial = material[GameManager.pamblicaIndex];
        }
         if(index==8){
            rend.sharedMaterial = material[GameManager.teacaIndex];
        }
        //Debug.Log(index);
    }
    public void ActualizeazaMaterialele(){
        if(index==1){
            rend.sharedMaterial = material[GameManager.bodyIndex];
        }
        if(index==2){
            rend.sharedMaterial = material[GameManager.legsIndex];
        }
        if(index==3){
            rend.sharedMaterial = material[GameManager.eyesIndex];
        }
        if(index==4){
            rend.sharedMaterial = material[GameManager.botIndex];
        }
    }
    public void RandomColors(){
        GameManager.bodyIndex = Random.Range(0, 10);
        GameManager.legsIndex = Random.Range(0, 10);
        GameManager.eyesIndex = Random.Range(0, 10);
        GameManager.botIndex = Random.Range(0, 10);
        ActualizeazaMaterialele();
    }
}
