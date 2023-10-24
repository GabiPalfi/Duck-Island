using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopScript : MonoBehaviour
{
    public InventoryScript inventory;
    public int rockPrice;
    public int grassPrice;
    public int shroomPrice;
    public int stickPrice;
    public int fireworkPrice;
    public int tomatoPrice;
    public int carrotPrice;
    public int pumpkinPrice;
    public int cornPrice;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BuyRock(){
        if(GameManager.goldCount>=rockPrice){
            FindObjectOfType<AudioManager>().Play("ColectResorce");
            inventory.row1[0]++;
            GameManager.goldCount-=rockPrice;
            if(GameManager.catQuest1IsActive){
                GameManager.gooldSpent+=rockPrice;
                //Debug.Log("CUMPAR");
            }
        }
    }
    public void BuyGrass(){
        if(GameManager.goldCount>=grassPrice){
            FindObjectOfType<AudioManager>().Play("ColectResorce");
            inventory.row1[2]++;
            GameManager.goldCount-=grassPrice;
            if(GameManager.catQuest1IsActive){
                GameManager.gooldSpent+=grassPrice;
            }
        }
    }
    public void BuyStick(){
        if(GameManager.goldCount>=stickPrice){
            FindObjectOfType<AudioManager>().Play("ColectResorce");
            inventory.row1[3]++;
            GameManager.goldCount-=stickPrice;
            if(GameManager.catQuest1IsActive){
                GameManager.gooldSpent+=stickPrice;
            }
        }
    }
    public void BuyShroom(){
        if(GameManager.goldCount>=shroomPrice){
            FindObjectOfType<AudioManager>().Play("ColectResorce");
            inventory.row1[1]++;
            GameManager.goldCount-=shroomPrice;
            if(GameManager.catQuest1IsActive){
                GameManager.gooldSpent+=shroomPrice;
            }
        }
    }
    public void BuyFirework(){
        if(GameManager.goldCount>=fireworkPrice){
            FindObjectOfType<AudioManager>().Play("ColectResorce");
            inventory.row1[6]++;
            GameManager.goldCount-=fireworkPrice;
             if(GameManager.catQuest1IsActive){
                GameManager.gooldSpent+=fireworkPrice;
            }
        }
    }
    public void SellTomato(){
        if(inventory.row3[1]>0){
            FindObjectOfType<AudioManager>().Play("ColectResorce");
            GameManager.goldCount+=tomatoPrice;
            inventory.row3[1]--;
        }
    }
    public void SellCarrot(){
        if(inventory.row3[0]>0){
            FindObjectOfType<AudioManager>().Play("ColectResorce");
            GameManager.goldCount+=carrotPrice;
            inventory.row3[0]--;
        }
    }
    public void SellPumpkin(){
        if(inventory.row3[2]>0){
            FindObjectOfType<AudioManager>().Play("ColectResorce");
            GameManager.goldCount+=pumpkinPrice;
            inventory.row3[2]--;
        }
    }
    public void SellCorn(){
        if(inventory.row3[3]>0){
            FindObjectOfType<AudioManager>().Play("ColectResorce");
            inventory.row3[3]--;
            GameManager.goldCount+=cornPrice;
        }
    }
}
