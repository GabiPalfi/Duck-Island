using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChesstScript : MonoBehaviour
{
    public InventoryScript inventory;
    //public static ChesstScript Instance;
    public GameObject pressButton;
    public bool isPlayerInRange;
    public Transform player;
    public float minimDis;
    private bool showF=true;
    private static bool hasBeenOpen;
    //public int inventorySlot;
    //public int inventoryRand;
    public int index;
    public bool isRandom;
    private Animator anim;
    public GameObject particle;
    public int bonusStone;
    public int bonusShroom;
    public int bonusGrass;
    public int bonusStick;
    public int bonusGold;
    public int bonusIron;
    public int minGold;
    public int maxGold;
    public int bonusSeeds;
    
    // Start is called before the first frame update
    void Start()
    {
        inventory = FindAnyObjectByType<InventoryScript>();
        anim = GetComponent<Animator>();
        if(GameManager.levelChests[index]==1){
            anim.SetBool("isOpen",true);
            pressButton.SetActive(false);
        }
        
    }
    //  private void Awake()
    // {
    //    if(GameManager.levelChests[index]!=1){
    //         hasBeenOpen=false;
    //    }else{
    //         hasBeenOpen=true;
    //    }
    // }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.levelChests[index]!=1){
            float distance = Vector3.Distance(transform.position,player.position);
            if(distance<=minimDis){

            if(showF){
                pressButton.SetActive(true);
            }
           
            
                if(Input.GetKeyDown(KeyCode.F)){
                    anim.SetBool("isOpen",true);
                    FindObjectOfType<AudioManager>().Play("ColectResorce");
                    Instantiate(particle,transform.position,Quaternion.identity);
                    //Destroy(pressButton,0.1f);
                    showF=false;
                    pressButton.SetActive(false);
                    hasBeenOpen=true;
                    GameManager.levelChests[index]=1;
                    if(isRandom){
                        //inventory.row1[7]+=Random.Range(1,5);
                        GameManager.goldCount+=Random.Range(minGold,maxGold);
                    }else{
                        inventory.row1[0]+=bonusStone;
                        inventory.row1[1]+=bonusShroom;
                        inventory.row1[2]+=bonusGrass;
                        inventory.row1[3]+=bonusStick;
                        inventory.row1[4]+=bonusIron;
                        inventory.row1[12]+=bonusSeeds;
                        GameManager.goldCount+=bonusGold;


                    }
                }
            }else{
                pressButton.SetActive(false);
            }
        }
        
            
    }
}
