using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccesoryScript : MonoBehaviour
{
    public GameObject papion;
    public GameObject cravata;
    public GameObject pablica;
    public GameObject teaca;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.accesoryIndex==0){
            papion.SetActive(false);
            cravata.SetActive(false);
            pablica.SetActive(false);
            teaca.SetActive(false);
        }
        if(GameManager.accesoryIndex==1){
            papion.SetActive(true);
            cravata.SetActive(false);
            pablica.SetActive(false);
            teaca.SetActive(false);
        }
        if(GameManager.accesoryIndex==2){
            papion.SetActive(false);
            cravata.SetActive(true);
            pablica.SetActive(false);
            teaca.SetActive(false);
        }
        if(GameManager.accesoryIndex==3){
            papion.SetActive(false);
            cravata.SetActive(false);
            pablica.SetActive(true);
            teaca.SetActive(false);
        }
        if(GameManager.accesoryIndex==4){
            papion.SetActive(false);
            cravata.SetActive(false);
            pablica.SetActive(false);
            teaca.SetActive(true);
        }
    }
}
