using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuscaScript : MonoBehaviour
{
    public GameObject pressButton;
    // public bool isPlayerInRange;
    public Transform player;
    public float minimDis;
    public GameObject particle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position,player.position);
        if(GameManager.isBoss1Defeted){
            if(distance<=minimDis){
                pressButton.SetActive(true);
                if(Input.GetKeyDown(KeyCode.F)){
                    Instantiate(particle,transform.position,Quaternion.identity);
                    GameManager.isTwinSaved=true;
                    FindObjectOfType<AudioManager>().Play("ColectResorce");
                    Destroy(gameObject,0.1f);
                }
            }else{
                pressButton.SetActive(false);
            }
        }
        
    }
}
