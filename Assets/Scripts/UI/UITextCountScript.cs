using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UITextCountScript : MonoBehaviour
{
    public TextMeshProUGUI Text;
    public InventoryScript inventory;
    public int slot;
    public int rand;
    public int value;
    public GameObject icon;

    // Start is called before the first frame update
    void Start()
    {
        Text = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if(inventory.isInventoryOpen){
             if(rand==1){
                Text.text = inventory.row1[slot].ToString();
                value = inventory.row1[slot];
                
            }else{
                if(rand==2){
                    Text.text = inventory.row2[slot].ToString();
                    value = inventory.row2[slot];
                }else{
                    if(rand==3){
                        Text.text = inventory.row3[slot].ToString();
                        value = inventory.row3[slot];
                    }else{
                        if(rand==4){
                            Text.text = inventory.row4[slot].ToString();
                            value = inventory.row4[slot];
                        }else{
                            if(rand==7){
                                Text.text = inventory.row7[slot].ToString();
                                value = inventory.row7[slot];
                            }else{
                                if(rand==6){
                                    Text.text = inventory.row6[slot].ToString();
                                    value = inventory.row6[slot];
                            }
                            }

                        }
                    }
                }
            }
        
        }
        if(value>=1){
           Text.enabled = true;
           icon.SetActive(true);
        }else{
           Text.enabled = false;
           icon.SetActive(false);
        }
           
        
    }
}
