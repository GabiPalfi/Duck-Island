using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelIslandSkip : MonoBehaviour
{
    public int index;
    public GameObject uiF;
    public Transform player;
    public float minimDis;
    public LoadScreen ui;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position,player.position);
        if(distance<=minimDis){
            uiF.SetActive(true);
            if(Input.GetKeyDown(KeyCode.F)){
                FindObjectOfType<AudioManager>().Play("ColectResorce");
                ui.EndLevel();
                StartCoroutine(ChangeLevel());
            }
        }else{
            uiF.SetActive(false);
        }
    }
    IEnumerator ChangeLevel(){
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(index);
    }
}
