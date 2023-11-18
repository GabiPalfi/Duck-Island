using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ChestUi : MonoBehaviour
{
    public TextMeshProUGUI Text;
    public ChesstScript script;
    public int index;
    // Start is called before the first frame update
    void Start()
    {
        Text = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if(index==1){
            Text.text=script.bonusStone.ToString();
        }
        if(index==2){
            Text.text=script.bonusGrass.ToString();
        }
         if(index==3){
            Text.text=script.bonusStick.ToString();
        }
         if(index==4){
            Text.text=script.bonusIron.ToString();
        }
        if(index==5){
            Text.text=script.bonusSeeds.ToString();
        }
         if(index==6){
            Text.text=script.bonusGold.ToString();
        }
    }
}
