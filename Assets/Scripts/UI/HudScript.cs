using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HudScript : MonoBehaviour
{
    public GameObject dash;
    public int dashDebug;
    // Start is called before the first frame update
    void Start()
    {
        GameManager.eyeTalisman = dashDebug;
        if(GameManager.eyeTalisman==1){
            dash.SetActive(true);
            PlayerMovement2.canDashStatic=true;
        }else{
            dash.SetActive(false);
            PlayerMovement2.canDashStatic=false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //GameManager.eyeTalisman = dashDebug;
        if(GameManager.eyeTalisman==1){
            dash.SetActive(true);
            PlayerMovement2.canDashStatic=true;
        }else{
            dash.SetActive(false);
            PlayerMovement2.canDashStatic=false;
        }
    }
}
