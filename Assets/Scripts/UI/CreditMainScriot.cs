using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditMainScriot : MonoBehaviour
{
    public GameObject ui;
    public bool isOpen;
    public HouseUIanim animScript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Space)){
            if(isOpen){
                CloseUi();
            }
        }
    }
    public void CloseUi(){
        ui.SetActive(false);
        isOpen=false;
        FindObjectOfType<AudioManager>().Play("ColectResorce");
    }
    public void StartUI(){
        ui.SetActive(true);
        isOpen=true;
        animScript.anim.SetBool("Start",true);
        StartCoroutine(Wait());
        //animScript.anim.SetBool("Start",false);
    }
    IEnumerator Wait(){
        yield return new WaitForSeconds(50f);
        // inventoryMain.SetActive(true);
        // questMain.SetActive(false);
        animScript.anim.SetBool("Start",false);
        Debug.Log("Heiii");
    }
}
