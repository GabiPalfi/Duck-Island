using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HatScript : MonoBehaviour
{
    public GameObject cookHat;
    public GameObject collageHat;
    public GameObject japanHat;
    public GameObject cristamsHat;
    public GameObject astronautHat;
    public GameObject partyHat;
    public GameObject fancyHat;
    public GameObject soliderHat;
    public GameObject vikingHat;
    public GameObject mailmanHat; 
    public static int index;
    // Start is called before the first frame update
    void Start()
    {
        GameManager.cookHat=1;
        GameManager.collageHat=1;
        GameManager.japanHat=1;
        GameManager.cristamsHat=1;
        GameManager.astronautHat=1;
        GameManager.partyHat=1;
        GameManager.fancyHat=1;
        GameManager.soliderHat=1;
        GameManager.vikingHat=1;
        GameManager.mailmanHat=1;
        index = GameManager.hatIndex;



        if(index==1){
            CookHat();
        }
        if(index==2){
            CollageHat();
        }
        if(index==3){
            JapanHat();
        }
        if(index==4){
            CristamasHat();
        }
        if(index==5){
            AstronautHat();
        }
        if(index==6){
            PartyHat();
        }
        if(index==7){
            FancyHat();
        }
        if(index==8){
            SoliderHat();
        }
        if(index==9){
            VikingHat();
        }
        if(index==10){
            MailmanHat();
        }

    }

    // Update is called once per frame
    void Update()
    {
        GameManager.hatIndex = index;
        if(HatSelectorScript.index==1){
            CookHat();
            //GameManager.cookHat=1;
            //Debug.Log("Hey");
        }
        if(HatSelectorScript.index==2){
            CollageHat();
           
            //Debug.Log("Hey");
        }
        if(HatSelectorScript.index==3){
            JapanHat();
            
            //Debug.Log("Hey");
        }
        if(HatSelectorScript.index==4){
            CristamasHat();
            
            //Debug.Log("Hey");
        }
        if(HatSelectorScript.index==5){
            AstronautHat();
           
            //Debug.Log("Hey");
        }
        if(HatSelectorScript.index==6){
            PartyHat();
           
            //Debug.Log("Hey");
        }
        if(HatSelectorScript.index==7){
            FancyHat();
            //Debug.Log("Hey");
        }
        if(HatSelectorScript.index==8){
            SoliderHat();
            //Debug.Log("Hey");
        }
        if(HatSelectorScript.index==9){
            VikingHat();
            //Debug.Log("Hey");
        }
        if(HatSelectorScript.index==10){
            MailmanHat();
            //Debug.Log("Hey");
        }
    }

    public void CookHat(){
        if(GameManager.cookHat>0){
            index=1;
            cookHat.SetActive(true);
            //FindObjectOfType<AudioManager>().Play("ColectResorce");
            HideOtherHat();
        }
    }
    public void CollageHat(){
        if(GameManager.collageHat>0){
            index=2;
            collageHat.SetActive(true);
            //FindObjectOfType<AudioManager>().Play("ColectResorce");
            HideOtherHat();
        }
    }
    public void JapanHat(){
        if(GameManager.japanHat>0){
            index=3;
            japanHat.SetActive(true);
            //FindObjectOfType<AudioManager>().Play("ColectResorce");
            HideOtherHat();
        }
    }
    public void CristamasHat(){
        if(GameManager.cristamsHat>0){
            index=4;
            cristamsHat.SetActive(true);
            //FindObjectOfType<AudioManager>().Play("ColectResorce");
            HideOtherHat();
        }
    }
    public void AstronautHat(){
        if(GameManager.astronautHat>0){
            index=5;
            astronautHat.SetActive(true);
            //FindObjectOfType<AudioManager>().Play("ColectResorce");
            HideOtherHat();
        }
    }
    public void PartyHat(){
        if(GameManager.partyHat>0){
            index=6;
            partyHat.SetActive(true);
            //FindObjectOfType<AudioManager>().Play("ColectResorce");
            HideOtherHat();
        }
    }
    public void FancyHat(){
        if(GameManager.fancyHat>0){
            index=7;
            fancyHat.SetActive(true);
            //FindObjectOfType<AudioManager>().Play("ColectResorce");
            HideOtherHat();
        }
    }
    public void SoliderHat(){
        if(GameManager.soliderHat>0){
            index=8;
            soliderHat.SetActive(true);
            //FindObjectOfType<AudioManager>().Play("ColectResorce");
            HideOtherHat();
        }
    }
    public void VikingHat(){
        if(GameManager.vikingHat>0){
            index=9;
            vikingHat.SetActive(true);
            //FindObjectOfType<AudioManager>().Play("ColectResorce");
            HideOtherHat();
        }
    }
    public void MailmanHat(){
        if(GameManager.mailmanHat>0){
            index=10;
            mailmanHat.SetActive(true);
            //FindObjectOfType<AudioManager>().Play("ColectResorce");
            HideOtherHat();
        }
    }
    public void HideOtherHat(){
        if(index==1){
            //cookHat.SetActive(false); 
            collageHat.SetActive(false);
            japanHat.SetActive(false);
            cristamsHat.SetActive(false);
            astronautHat.SetActive(false);
            partyHat.SetActive(false);
            fancyHat.SetActive(false);
            soliderHat.SetActive(false);
            vikingHat.SetActive(false);
            mailmanHat.SetActive(false); 
        }
        if(index==2){ 
            cookHat.SetActive(false); 
            //collageHat.SetActive(false);
            japanHat.SetActive(false);
            cristamsHat.SetActive(false);
            astronautHat.SetActive(false);
            partyHat.SetActive(false);
            fancyHat.SetActive(false);
            soliderHat.SetActive(false);
            vikingHat.SetActive(false);
            mailmanHat.SetActive(false); 
        }
        if(index==3){ 
            cookHat.SetActive(false); 
            collageHat.SetActive(false);
            //japanHat.SetActive(false);
            cristamsHat.SetActive(false);
            astronautHat.SetActive(false);
            partyHat.SetActive(false);
            fancyHat.SetActive(false);
            soliderHat.SetActive(false);
            vikingHat.SetActive(false);
            mailmanHat.SetActive(false); 
        }
        if(index==4){ 
            cookHat.SetActive(false); 
            collageHat.SetActive(false);
            japanHat.SetActive(false);
            ///cristamsHat.SetActive(false);
            astronautHat.SetActive(false);
            partyHat.SetActive(false);
            fancyHat.SetActive(false);
            soliderHat.SetActive(false);
            vikingHat.SetActive(false);
            mailmanHat.SetActive(false); 
        }
        if(index==5){
            cookHat.SetActive(false);  
            collageHat.SetActive(false);
            japanHat.SetActive(false);
            cristamsHat.SetActive(false);
            //astronautHat.SetActive(false);
            partyHat.SetActive(false);
            fancyHat.SetActive(false);
            soliderHat.SetActive(false);
            vikingHat.SetActive(false);
            mailmanHat.SetActive(false); 
        }
        if(index==6){ 
            cookHat.SetActive(false); 
            collageHat.SetActive(false);
            japanHat.SetActive(false);
            cristamsHat.SetActive(false);
            astronautHat.SetActive(false);
            //partyHat.SetActive(false);
            fancyHat.SetActive(false);
            soliderHat.SetActive(false);
            vikingHat.SetActive(false);
            mailmanHat.SetActive(false); 
        }
        if(index==7){ 
            cookHat.SetActive(false); 
            collageHat.SetActive(false);
            japanHat.SetActive(false);
            cristamsHat.SetActive(false);
            astronautHat.SetActive(false);
            partyHat.SetActive(false);
            //fancyHat.SetActive(false);
            soliderHat.SetActive(false);
            vikingHat.SetActive(false);
            mailmanHat.SetActive(false); 
        }
        if(index==8){ 
            cookHat.SetActive(false); 
            collageHat.SetActive(false);
            japanHat.SetActive(false);
            cristamsHat.SetActive(false);
            astronautHat.SetActive(false);
            partyHat.SetActive(false);
            fancyHat.SetActive(false);
            //soliderHat.SetActive(false);
            vikingHat.SetActive(false);
            mailmanHat.SetActive(false); 
        }
        if(index==9){ 
            cookHat.SetActive(false); 
            collageHat.SetActive(false);
            japanHat.SetActive(false);
            cristamsHat.SetActive(false);
            astronautHat.SetActive(false);
            partyHat.SetActive(false);
            fancyHat.SetActive(false);
            soliderHat.SetActive(false);
            //vikingHat.SetActive(false);
            mailmanHat.SetActive(false); 
        }
        if(index==10){ 
            cookHat.SetActive(false); 
            collageHat.SetActive(false);
            japanHat.SetActive(false);
            cristamsHat.SetActive(false);
            astronautHat.SetActive(false);
            partyHat.SetActive(false);
            fancyHat.SetActive(false);
            soliderHat.SetActive(false);
            vikingHat.SetActive(false);
            //mailmanHat.SetActive(false); 
        }
    }

}
