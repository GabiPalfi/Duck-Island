using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseMenuScript : MonoBehaviour
{   
    public bool isPauseMenuOpen;
    public GameObject pauseMenu;
    private Animator anim;
    public PlayerMovement2 player;
    public LoadScreen ui;

    // Start is called before the first frame update
    void Start()
    {
       anim = GetComponent<Animator>();
       pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) && InventoryScript.isInventoryOpenStatic==false){
            pauseMenu.SetActive(true);
            Open();
        }
        if(isPauseMenuOpen){
            if(InventoryScript.isInventoryOpenStatic){
                Close();
            }
        }
    }
    public void Open(){
        if(isPauseMenuOpen){
            Close();  
               
        }else{
            player.canShoot1 = false;
            player.canMove = false;
            anim.SetBool("isOpen",true);
            FindObjectOfType<AudioManager>().Play("Inventory");
            isPauseMenuOpen = true;
           
            //Debug.Log("Am descis");
        }
    }
    IEnumerator Wait(){
        yield return new WaitForSeconds(0.5f);
        pauseMenu.SetActive(false);
        // inventoryMain.SetActive(true);
        // questMain.SetActive(false);
    }
    public void Close(){
        anim.SetBool("isOpen",false);
        FindObjectOfType<AudioManager>().Play("Inventory");
        isPauseMenuOpen = false;
        StartCoroutine(Wait());
        if(InventoryScript.isInventoryOpenStatic==false){
            player.canShoot1 = true;
        }
        player.canMove = true;
        //Debug.Log("Am inchis");
    }
    public void MainMenu(){
        ui.EndLevel();
        StartCoroutine(ChangeLevel());
        
    }
    IEnumerator ChangeLevel(){
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("MainMenu");
    }
}
