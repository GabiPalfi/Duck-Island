using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalismanInventoryScript : MonoBehaviour
{
    public InventoryScript inventory;
    public int slot;
    public int rand;
    public int value;
    public GameObject icon;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(inventory.isInventoryOpen){
            value = inventory.row2[slot];
        
        }
        if(value>=1){
           icon.SetActive(true);
        }else{
           icon.SetActive(false);
        }
    }
}
