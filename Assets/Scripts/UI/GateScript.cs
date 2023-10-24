using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateScript : MonoBehaviour
{
    public GameObject uiF;
    public Transform player;
    public float minDis;
    private Animator anim;
    public bool isOpening;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position,player.position);
        if(distance<minDis){
            uiF.SetActive(true);
            if(Input.GetKeyDown(KeyCode.F)){
                if(isOpening==false){
                    anim.SetBool("isOpen",true);
                    isOpening=true;
                }else{
                    anim.SetBool("isOpen",false);
                    isOpening=false;
                }
               
                
                
            }
        }else{
            uiF.SetActive(false);
        }
    }
}
