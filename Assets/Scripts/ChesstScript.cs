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
    public GameObject rockUI;
    public GameObject stickkUI;
    public GameObject grassUI;
    public GameObject ironUI;
    public GameObject seedUI;
    public GameObject goldUI;
    public GameObject image;

    
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
                        ShowUI();
                    }else{
                        inventory.row1[0]+=bonusStone;
                        //inventory.row1[1]+=bonusShroom;
                        inventory.row1[2]+=bonusGrass;
                        inventory.row1[3]+=bonusStick;
                        inventory.row1[4]+=bonusIron;
                        inventory.row1[12]+=bonusSeeds;
                        GameManager.goldCount+=bonusGold;
                        ShowUI();


                    }
                }
            }else{
                pressButton.SetActive(false);
            }
        }
        
            
    }
    public void ShowUI(){
        if(bonusStone>0){
            rockUI.SetActive(true);
            image.SetActive(true);
        }
        if(bonusGrass>0){
            grassUI.SetActive(true);
            image.SetActive(true);
        }
        if(bonusStick>0){
            stickkUI.SetActive(true);
            image.SetActive(true);
        }
        if(bonusIron>0){
            ironUI.SetActive(true);
            image.SetActive(true);
        }
        if(bonusSeeds>0){
            seedUI.SetActive(true);
            image.SetActive(true);
        }
        if(bonusGold>0){
            goldUI.SetActive(true);
            image.SetActive(true);
        }
        StartCoroutine(HideUI());

    }
    IEnumerator HideUI(){
        yield return new WaitForSeconds(1.5f);
        rockUI.SetActive(false);
        grassUI.SetActive(false);
        stickkUI.SetActive(false);
        seedUI.SetActive(false);
        ironUI.SetActive(false);
        goldUI.SetActive(false);
        image.SetActive(false);
    }
}
