using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InventoryScript : MonoBehaviour
{
    [Header("Referinte")]
    private Animator anim;
    public PlayerMovement2 player;
    public GameObject inventory;
    public BetterButtonScript inventoryMain;
    public BetterButtonScript questMain;
    
    [Header("VariabileBool")]
    public bool isInventoryOpen;
    public static bool isInventoryOpenStatic;
    
    [Header("Row1")]
    public int[] row1 = new int[6];

    [Header("Row2")]
    public int[] row2 = new int[5];
    
    [Header("Row3")]
    public int[] row3 = new int[4];

    [Header("Row4")]
    public int[] row4 = new int[3];
    
    [Header("Row5")]
    public int[] row5 = new int[4];

    [Header("Row6")]
    public int[] row6 = new int[4];

    [Header("Row7")]
    public int[] row7 = new int[4];
    public int[][] inventorySlots;
    

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        //inventory.SetActive(false);
        player.canShoot1 = true;
      

    }
    void Awake(){
        //row1
        row1[0] = GameManager.stoneCount;
        row1[1] = GameManager.mushroomCount;
        row1[2] = GameManager.grassCount;
        row1[3] = GameManager.stickCount;
        row1[4] = GameManager.ironCount;
        row1[5] = GameManager.ropeCount;
        row1[6] = GameManager.fireworkCount;
        row1[7] = GameManager.goldCount;
        row1[8] = GameManager.plankCount;
        row1[9] = GameManager.bandageCount;
        row1[10] = GameManager.polishRockCount;
        row1[11] = GameManager.greenShroomCount;
        row1[12] = GameManager.seedCount;
        
        row3[0] = GameManager.carrotCount;
        row3[1] = GameManager.tomatoCount;
        row3[2] = GameManager.pumpkinCount;
        row3[3] = GameManager.cornCount;
    
        row2[0] = GameManager.eyeTalisman;
        row2[1] = GameManager.slashTalisman;
        
        row7[0] = GameManager.rockLetterCount;
        row7[1] = GameManager.fireworkLetterCount;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab)){
            inventory.SetActive(true);
            OpenInventory();
           
        }
        if(Input.GetKeyDown(KeyCode.Escape) && isInventoryOpen){
            anim.SetBool("IsInventoryOpen",false);
            FindObjectOfType<AudioManager>().Play("Inventory");
            isInventoryOpen = false;
            StartCoroutine(Wait());
            player.canShoot1 = true;
            //Debug.Log("Am inchis");
        }
        // if(isInventoryOpen){
        //     player.canShoot1 = false;
        // }else{
        //     player.canShoot1=true;
        // }
        GameManager.stoneCount = row1[0];
        GameManager.mushroomCount = row1[1];
        GameManager.grassCount = row1[2];
        GameManager.stickCount = row1[3];
        GameManager.ironCount = row1[4];
        GameManager.ropeCount = row1[5];
        GameManager.fireworkCount = row1[6];
        GameManager.plankCount = row1[8];
        GameManager.bandageCount = row1[9];
        GameManager.polishRockCount = row1[10];
        GameManager.greenShroomCount = row1[11];
        GameManager.seedCount = row1[12];
        row1[7] = GameManager.goldCount;

        GameManager.eyeTalisman = row2[0];
        GameManager.slashTalisman = row2[1];

        GameManager.rockLetterCount = row7[0];
        GameManager.fireworkLetterCount = row7[1];
        GameManager.carrotCount = row3[0];
        GameManager.tomatoCount = row3[1];
        GameManager.pumpkinCount = row3[2];
        GameManager.cornCount = row3[3];


        isInventoryOpenStatic=isInventoryOpen;
    }
    public void OpenInventory(){
         if(isInventoryOpen){
                anim.SetBool("IsInventoryOpen",false);
                FindObjectOfType<AudioManager>().Play("Inventory");
                isInventoryOpen = false;
                StartCoroutine(Wait());
                //Debug.Log("Am inchis");
                player.canShoot1 = true;
               
            }else{
                player.canShoot1 = false;
                anim.SetBool("IsInventoryOpen",true);
                FindObjectOfType<AudioManager>().Play("Inventory");
                isInventoryOpen = true;
                //Debug.Log("Am descis");
            }
    }
    IEnumerator Wait(){
        yield return new WaitForSeconds(1f);
        // inventoryMain.SetActive(true);
        // questMain.SetActive(false);
    }
    public void OpenInventorySlot(){
        inventoryMain.IsActive();
        questMain.IsNotActive();
    }
    public void OpenQuest(){
        inventoryMain.IsNotActive();
        questMain.IsActive();
    }
    public void Sound(){
        FindObjectOfType<AudioManager>().Play("ColectResorce");
    }
}
