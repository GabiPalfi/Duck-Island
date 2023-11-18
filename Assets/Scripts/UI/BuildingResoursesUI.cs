using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class BuildingResoursesUI : MonoBehaviour
{
    public TextMeshProUGUI Text;
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
            Text.text = GameManager.stoneCount.ToString();
        }
        if(index==2){
            Text.text = GameManager.mushroomCount.ToString();
        }
        if(index==3){
            Text.text = GameManager.grassCount.ToString();
        }
        if(index==4){
            Text.text = GameManager.stickCount.ToString();
        }
        if(index==5){
            Text.text = GameManager.ironCount.ToString();
        }
        if(index==6){
            Text.text = GameManager.ropeCount.ToString();
        }
        if(index==7){
            Text.text = GameManager.plankCount.ToString();
        }
        if(index==8){
            Text.text = GameManager.polishRockCount.ToString();
        }
        if(index==9){
            Text.text = GameManager.seedCount.ToString();
        }

    }
}
