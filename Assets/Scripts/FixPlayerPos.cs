using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FixPlayerPos : MonoBehaviour
{
    public GameObject player;
    public GameObject camera;
    // Start is called before the first frame update
    void Start()
    {
        Scene scene = SceneManager.GetActiveScene();

        if(GameManager.level1Index==1 && scene.name=="Level 1"){
            player.transform.position = new Vector3(57f,2f,30f);
            camera.transform.position = new Vector3(57f,10f,20f);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
