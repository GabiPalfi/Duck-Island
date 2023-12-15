using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuButton : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
         anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MouseOver(){
        anim.SetBool("isSelected", true);
        FindObjectOfType<AudioManager>().Play("Shoot");
    }
    public void MouseExit(){
        anim.SetBool("isSelected", false);
    }
}
