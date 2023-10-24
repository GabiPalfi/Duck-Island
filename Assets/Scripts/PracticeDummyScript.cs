using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeDummyScript : MonoBehaviour
{
    public GameObject destroyParticle;
    public GameManager gameManager;
    public CameraShake cameraShake;
    public GameObject whiteDummy;
    public GameObject normalDummy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other) {
        if(other.tag == "LetterBasic" ||other.tag == "RockLetter"||other.tag == "FireWorkLetter"){
            //health-=gameManager.basicLetterDamage;
            StartCoroutine(cameraShake.Shake(gameManager.duration,gameManager.magnitude));
            Instantiate(destroyParticle,transform.position,Quaternion.identity);
            
            //isWhite = true;
            StartCoroutine(ChangeMat());
        }
    }
    IEnumerator ChangeMat(){
        whiteDummy.SetActive(true);
        normalDummy.SetActive(false);
        yield return new WaitForSeconds(0.08f);
        whiteDummy.SetActive(false);
        normalDummy.SetActive(true);
    }
}
