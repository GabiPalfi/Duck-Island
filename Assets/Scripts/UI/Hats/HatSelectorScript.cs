using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HatSelectorScript : MonoBehaviour
{
    public static int index;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CookHat(){
        index=1;
        FindObjectOfType<AudioManager>().Play("ColectResorce");
    }
    public void CollageHatHat(){
        index=2;
        FindObjectOfType<AudioManager>().Play("ColectResorce");
    }
    public void JapanHat(){
        index=3;
        FindObjectOfType<AudioManager>().Play("ColectResorce");
    }
    public void CristmasHat(){
        index=4;
        FindObjectOfType<AudioManager>().Play("ColectResorce");
    }
    public void AstronautHat(){
        index=5;
        FindObjectOfType<AudioManager>().Play("ColectResorce");
    }
    public void PartyHat(){
        index=6;
        FindObjectOfType<AudioManager>().Play("ColectResorce");
    }
    public void FancyHat(){
        index=7;
        FindObjectOfType<AudioManager>().Play("ColectResorce");
    }
    public void SoliderHat(){
        index=8;
        FindObjectOfType<AudioManager>().Play("ColectResorce");
    }
    public void VikingHat(){
        index=9;
        FindObjectOfType<AudioManager>().Play("ColectResorce");
    }
    public void MailmanHat(){
        index=10;
        FindObjectOfType<AudioManager>().Play("ColectResorce");
    }
}
