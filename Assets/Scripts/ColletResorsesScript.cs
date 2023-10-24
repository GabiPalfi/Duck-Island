using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColletResorsesScript : MonoBehaviour
{
    public InventoryScript inventory;
    public GameObject pressButton;
    public bool isPlayerInRange;
    public Transform player;
    public float minimDis;
    public int inventorySlot;
    public int inventoryRand;
    public GameObject particle;

    // Start is called before the first frame update
    void Start()
    {
        inventory = FindAnyObjectByType<InventoryScript>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position,player.position);
        if(distance<=minimDis){
            pressButton.SetActive(true);
            if(Input.GetKeyDown(KeyCode.F)){
                FindObjectOfType<AudioManager>().Play("ColectResorce");
                Instantiate(particle,transform.position,Quaternion.identity);
                if(inventoryRand==1){
                    inventory.row1[inventorySlot]++;
                }else{
                    if(inventoryRand==2){
                        inventory.row2[inventorySlot]++;
                        Debug.Log("HAI NOROC");
                    }else{
                        if(inventoryRand==3){
                            inventory.row2[inventorySlot]++;
                        }else{
                            if(inventoryRand==4){
                                inventory.row2[inventorySlot]++;
                            }
                        }
                    }
                }
                Destroy(gameObject);

            }
        }else{
            pressButton.SetActive(false);
        }
    }
    
}
