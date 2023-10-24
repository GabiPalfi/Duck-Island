using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class LetterCountUI : MonoBehaviour
{
    public TextMeshProUGUI Text;
    public PlayerMovement2 player;
    public InventoryScript inventory;
    // Start is called before the first frame update
    void Start()
    {
        Text = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.isNormalLetterSelected){
            Text.text = player.lettersCount.ToString();
        }
        if(GameManager.isRockLetterSelected){
            Text.text = inventory.row7[0].ToString();
        }
        if(GameManager.isFireworkLetterSelected){
            Text.text = inventory.row7[1].ToString();
        }
        
    }
}
