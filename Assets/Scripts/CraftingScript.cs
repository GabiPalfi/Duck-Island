using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftingScript : MonoBehaviour
{
    public InventoryScript inventory;
    public int maxBandages;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CraftRope(){
        if(inventory.row1[2]>=2){
            inventory.row1[5]++;
            inventory.row1[2]-=2;
            FindObjectOfType<AudioManager>().Play("ColectResorce");
        }
    }
    public void CraftRockLetter(){
        if(inventory.row1[5]>=1&&inventory.row1[0]>=1){
            inventory.row7[0]+=3;
            inventory.row1[5]--;
            inventory.row1[0]--;
            FindObjectOfType<AudioManager>().Play("ColectResorce");
        }
    }
    public void CraftFireWorkLetter(){
        if(inventory.row1[5]>=1 && inventory.row1[6]>=1){
            inventory.row7[1]+=3;
            inventory.row1[5]--;
            inventory.row1[6]--;
            FindObjectOfType<AudioManager>().Play("ColectResorce");
        }
    }
    public void CraftPlank(){
        if(inventory.row1[3]>=2){
            inventory.row1[8]++;
            inventory.row1[3]-=2;
            FindObjectOfType<AudioManager>().Play("ColectResorce");
        }
    }
    public void CraftBandage(){
        if(inventory.row1[1]>=2 && inventory.row1[9]<maxBandages){
            inventory.row1[9]++;
            inventory.row1[1]-=2;
            FindObjectOfType<AudioManager>().Play("ColectResorce");
        }
    }
    public void CraftPolishRock(){
        if(inventory.row1[0]>=2){
            inventory.row1[10]++;
            inventory.row1[0]-=2;
            FindObjectOfType<AudioManager>().Play("ColectResorce");
        }
    }
    public void Sound(){
        FindObjectOfType<AudioManager>().Play("ColectResorce");
    }
}
