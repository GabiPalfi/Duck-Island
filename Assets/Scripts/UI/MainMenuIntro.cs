using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuIntro : MonoBehaviour
{
    private Animator anim;
    public bool isOpened=true;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey)
        {
            if(isOpened){
                anim.SetBool("isOpen",true);
                FindObjectOfType<AudioManager>().Play("ColectResorce");
                isOpened=false;
            }
           
        }
    }
}
