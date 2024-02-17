using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookUI : MonoBehaviour
{
    public Transform player;
    public float minDis;
    public GameObject uiF;
    public GameObject ui;
    public bool isUIopen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position,player.position);
        if(distance<minDis){
            uiF.SetActive(true);
            if(Input.GetKeyDown(KeyCode.F)){
                if(isUIopen){
                    ui.SetActive(false);
                    FindObjectOfType<AudioManager>().Play("ColectResorce");
                }else{
                    ui.SetActive(true);
                    FindObjectOfType<AudioManager>().Play("ColectResorce");
                }
            }
        }else{
            uiF.SetActive(false);
            ui.SetActive(false);
            
        }
    }
}
