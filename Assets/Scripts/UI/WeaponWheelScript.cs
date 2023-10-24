using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponWheelScript : MonoBehaviour
{
    public GameObject ui;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetMouseButton(1)){
            ui.SetActive(true);
       }else{
            ui.SetActive(false);
       }
     //   MoveObject();
    }
//     void MoveObject(){
//           Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
//           transform.position = new Vector2(cursorPos.x,cursorPos.y);
//     }
}
