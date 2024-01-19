using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastRoomControl : MonoBehaviour
{
    public GameObject gate;
    public GameObject music;
    
    // Start is called before the first frame update
   
    void OnTriggerEnter(Collider other){
        if(other.tag=="Player"){
            if(GameManager.isLastBossDefeted==false){
                gate.SetActive(true);
                music.SetActive(true);
                
            } 
        }
    }
}
