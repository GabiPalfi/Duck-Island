using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialScript : MonoBehaviour
{
    public HouseUIanim animScript; 
    public GameObject ui;
    public BoxCollider col;
    public PlayerMovement2 player;
    
    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.isTutorialOver){
            col.enabled = false;
            ui.SetActive(false);
        }
    }
    public void OnTriggerEnter(Collider other) {
        if(other.tag=="Player"){
            //ui.SetActive(true);
            animScript.anim.SetBool("isOpen",true);
            col.enabled = false;
            player.canMove=false;
            player.canShoot1=false;
        }
    }
    public void Close(){
        animScript.anim.SetBool("isOpen",false);
        player.canMove=true;
        player.canShoot1=true;
        GameManager.isTutorialOver = true;
        FindObjectOfType<AudioManager>().Play("ColectResorce");
        StartCoroutine(CloseAll());

    }
    IEnumerator CloseAll(){
        yield return new WaitForSeconds(0.5f);
        ui.SetActive(false);
    }
}
