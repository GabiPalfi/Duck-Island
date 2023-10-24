using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthIconScript : MonoBehaviour
{
    private Animator anim;
    public int iconIndex;
    public PlayerMovement2 player;
    public bool hasAnimated;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

        if(player.currentHealth < iconIndex){
            if(hasAnimated==false){
                anim.SetBool("LoseHearth",true);
                anim.SetBool("GainHearth",false);
                hasAnimated=true;
            }
        }
        if(player.currentHealth==iconIndex){
            if(hasAnimated==true){
                anim.SetBool("LoseHearth",false);
                anim.SetBool("GainHearth",true);
                hasAnimated=false;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(player.currentHealth < iconIndex){
            if(hasAnimated==false){
                anim.SetBool("LoseHearth",true);
                anim.SetBool("GainHearth",false);
                hasAnimated=true;
            }
        }
        if(player.currentHealth==iconIndex){
            if(hasAnimated==true){
                anim.SetBool("LoseHearth",false);
                anim.SetBool("GainHearth",true);
                hasAnimated=false;
            }
        }
    }
    public void LoseHealth(){
       
       

    }
    public void GainHealth(){
        
    }
}
