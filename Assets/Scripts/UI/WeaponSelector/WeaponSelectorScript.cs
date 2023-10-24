using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSelectorScript : MonoBehaviour
{
    public GameObject ui; 
    public PlayerMovement2 player;
    public InventoryScript inventory;
    //public GameObject[] arrows;
    public int index;
    private Animator anim;
    public GameObject arrow1;
    public GameObject arrow2;
    public GameObject arrow3;
    public GameObject arrow4;
    public GameObject arrow5;
    public bool isOpen;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(1)){
            //ui.SetActive(true);
            player.isWeaponWheelClose=false;
            anim.SetBool("isOpen",false);
            if(isOpen==false){
                FindObjectOfType<AudioManager>().Play("WeaponSelect");
                isOpen = true;
            }
            
        }else{
            //ui.SetActive(false);
            player.isWeaponWheelClose=true;
            anim.SetBool("isOpen",true);
            isOpen = false;
        }
        if(Input.GetKeyDown(KeyCode.Alpha1)){
            // Debug.Log("salut");
            SelectRockLetter();
        }
        if(Input.GetKeyDown(KeyCode.Alpha2)){
            // Debug.Log("salut");
            SelectFireworkLetter();
        }
        if(Input.GetKeyDown(KeyCode.Alpha3)){
            // Debug.Log("salut");
            SelectNormalLetter();
        }
    }
    public void SelectRockLetter(){
        if(inventory.row7[0]>0){
            FindObjectOfType<AudioManager>().Play("ColectResorce");
            GameManager.isRockLetterSelected = true;
            GameManager.isNormalLetterSelected = false;
            GameManager.isFireworkLetterSelected = false;
            arrow1.SetActive(true);
            arrow2.SetActive(false);
            arrow3.SetActive(false);
            arrow4.SetActive(false);
            arrow5.SetActive(false);
        }
    }
    public void SelectFireworkLetter(){
        if(inventory.row7[1]>0){
            FindObjectOfType<AudioManager>().Play("ColectResorce");
            GameManager.isFireworkLetterSelected = true;
            GameManager.isNormalLetterSelected = false;
            GameManager.isRockLetterSelected = false;
            arrow2.SetActive(true);
            arrow1.SetActive(false);
            arrow3.SetActive(false);
            arrow4.SetActive(false);
            arrow5.SetActive(false);
        }
    }
    public void SelectNormalLetter(){
        FindObjectOfType<AudioManager>().Play("ColectResorce");
        GameManager.isNormalLetterSelected = true;
        GameManager.isFireworkLetterSelected = false;
        GameManager.isRockLetterSelected = false;
        arrow3.SetActive(true);
        arrow2.SetActive(false);
        arrow1.SetActive(false);
        arrow4.SetActive(false);
        arrow5.SetActive(false);
    }
}
