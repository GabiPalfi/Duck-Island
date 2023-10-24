using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSlash : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other) {
        if(other.tag == "SimpleEnemy"){
            //StartCoroutine(cameraShake.Shake(gameManager.duration,gameManager.magnitude));
             if(PlayerMovement2.dashMaxTokensStatic>PlayerMovement2.dashTokensStatic){
                PlayerMovement2.dashTokensStatic++;
            } 
        }
    }
}
