using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss3TurnWhite : MonoBehaviour
{
    public Material[] material;
    Renderer rend;
    public Boss3Script script;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.sharedMaterial = material[0];
    }

    // Update is called once per frame
    void Update()
    {
        if(script.isWhite == true){
            rend.sharedMaterial= material[1];
        }else{
            rend.sharedMaterial= material[0];
        }
    }
}
