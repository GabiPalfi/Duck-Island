using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bos2RoomControl : MonoBehaviour
{
    public GameObject border;
    public GameObject healthSlider;
    public GameObject boosBattle;
    public GameObject music;
    public GameObject amulet;
    // Start is called before the first frame update
    void Start()
    {
        if(GameManager.isBoss2Defeted){
            boosBattle.SetActive(false);
        }else{
            boosBattle.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other){
        if(other.tag=="Player"){
            if(GameManager.isBoss2Defeted==false){
                border.SetActive(true);
                healthSlider.SetActive(true);
                music.SetActive(true);
                
            }else{
                border.SetActive(false);
                healthSlider.SetActive(false);
                music.SetActive(false);
                
            }
           
        }
    }
}
