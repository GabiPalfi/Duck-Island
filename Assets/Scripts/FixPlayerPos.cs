using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FixPlayerPos : MonoBehaviour
{
    public GameObject player;
    public GameObject camera;
    public Vector3 playerPos;
    public Vector3 posCheck;
    // Start is called before the first frame update
    void Start()
    {
       
        Scene scene = SceneManager.GetActiveScene();
        //playerPos=new Vector3(15f,2.3f,-20f);
        if(GameManager.gameStarted==false){
            player.transform.position = new Vector3(11.1f,2.4f,-88f);
            camera.transform.position = new Vector3(11.1f,2.4f,-88f);
            StartCoroutine(FixPos());
            //StartCoroutine(ChangePos());
        }
        
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    IEnumerator FixPos(){
        yield return new WaitForSeconds(1.5f);
        player.transform.position = new Vector3(11.1f,2.4f,-88f);
        camera.transform.position = new Vector3(11.1f,2.4f,-88f);
        if(player.transform.position.z <-20f){
            player.transform.position = new Vector3(11.1f,2.4f,-88f);
            camera.transform.position = new Vector3(11.1f,2.4f,-88f);
            //StartCoroutine(FixPos());
        }
    }
    IEnumerator ChangePos(){
        yield return new WaitForSeconds(3f);
        if(player.transform.position.z <-20f){
            player.transform.position = new Vector3(11.1f,2.4f,-88f);
            camera.transform.position = new Vector3(11.1f,2.4f,-88f);
            //StartCoroutine(FixPos());
        }
    }
}
