using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashIconScript : MonoBehaviour
{
    private Animator anim;
    public int iconIndex;
    public PlayerMovement2 player;
    public bool hasAnimated;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

        if(player.dashTokens <= iconIndex){
            if(hasAnimated==false){
                anim.SetBool("isClose",false);
                hasAnimated=true;
            }
        }
        if(player.dashTokens==iconIndex){
            if(hasAnimated==true){
                anim.SetBool("isClose",true);
                hasAnimated=false;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(player.dashTokens <= iconIndex){
            if(hasAnimated==false){
                anim.SetBool("isClose",false);
                hasAnimated=true;
            }
        }
        if(player.dashTokens==iconIndex){
            if(hasAnimated==true){
                anim.SetBool("isClose",true);
                hasAnimated=false;
            }
        }
        // if(Input.GetKeyDown(KeyCode.P)){
        //     anim.SetBool("isClose",true);
        // }
    }
}
