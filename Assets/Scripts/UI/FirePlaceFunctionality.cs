using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePlaceFunctionality : MonoBehaviour
{
    public GameObject uiF;
    public Transform player;
    public float minDis;
    public GameObject fire;
    public InventoryScript inventory;
    public int lifespan;
    public int maxLifespan;
    public int woodPrice;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position,player.position);
        if(distance<minDis){
            if(GameManager.fireHasBeenBought){
                uiF.SetActive(true);
                //FindObjectOfType<AudioManager>().Play("UIbasicSound");
                if(Input.GetKeyDown(KeyCode.F)){
                    if(inventory.row1[3]>=woodPrice){
                        inventory.row1[3] -= woodPrice;
                        maxLifespan +=lifespan;
                        fire.SetActive(true);
                        StartCoroutine(FireDuration());
                    }
                }
            }
        }else{
            uiF.SetActive(false);
        }
    }
    IEnumerator FireDuration(){
        
        yield return new WaitForSeconds(maxLifespan);
        fire.SetActive(false);
    }
}
