using System.Collections;
using System.Collections.Generic;
//using UnityEditor.EditorTools;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonPrefabScript : MonoBehaviour
{
    public bool isSlotOpen;
    public GameObject slots;
    public Button yourButton;
    public Sprite newSprite;
    public Sprite oldSprite;
    public int index;
    public InventoryMainScript inventory;
    //private Animator anim;
    // Start is called before the first frame update
    //public bool isSelected;
    //private bool isHovering = false;
    void Start()
    {
        //anim = GetComponent<Animator>();
        slots.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(InventoryMainScript.indexActive != index){
            ChangeTextNew();
            slots.SetActive(false);
            isSlotOpen = false;
        }
        if(isSlotOpen == false){
            ChangeTextNew();
        }
    }
   public void ButtonClicked(){
        InventoryMainScript.indexActive = index;
        if(isSlotOpen){
            slots.SetActive(false);
            isSlotOpen = false;
        }else{
            slots.SetActive(true);
            isSlotOpen = true;
            ChangeTextNew();
        }
        ChangeText();
        
   }
   public void ChangeText(){
        Image buttonImage = yourButton.GetComponent<Image>();
        buttonImage.sprite = newSprite;
   }
   public void ChangeTextNew(){
        Image buttonImage = yourButton.GetComponent<Image>();
        buttonImage.sprite = oldSprite;
   }
   
}
