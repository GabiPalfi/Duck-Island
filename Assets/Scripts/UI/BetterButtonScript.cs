using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BetterButtonScript : MonoBehaviour
{
    public Sprite redButton;
    public Sprite normalButton;
    public Image imageToUpdate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void IsActive(){
        imageToUpdate.sprite = redButton;
    }
    public void IsNotActive(){
        imageToUpdate.sprite = normalButton;
    }
}
