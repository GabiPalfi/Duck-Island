using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLevel2 : MonoBehaviour
{
     public int child;
    public static bool loadAgain=true;
    //public int index;
    // Start is called before the first frame update
    void Start()
    {
        // if(GameManager.level2EnemyDied){
        //     gameObject.SetActive(false);
        // }else{
        //     gameObject.SetActive(true);
        // }
        if(loadAgain){
            gameObject.SetActive(true);
        }else{
            gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        child = transform.childCount;
        // Debug.Log(child);
        if(child==0){
            //GameManager.level2EnemyDied = true;
            loadAgain = false;
        }
    }
}
