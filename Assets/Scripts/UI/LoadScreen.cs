using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadScreen : MonoBehaviour
{
    public  Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void StartLevel(){
        
        anim.SetBool("LoadLevel",false);
    }
    public void EndLevel(){
        //Debug.Log("FAC CEVA");
        
        anim.SetBool("LoadLevel",true);
    }
}
