using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class SimpleEnemySCript : MonoBehaviour
{
    public NavMeshAgent enemy;
    public Transform player;
    public float minimPos;
    public float health;
    public int maxHealth;
    public GameManager gameManager;
    public CameraShake cameraShake;
    public GameObject destroyParticle;
    public GameObject deathParticle;
    public float minDis;
    public bool isWhite;
    public bool hasAwaken;
    public Material[] material;
    Renderer rend;
    public Animator anim;
    

    // Start is called before the first frame update
    void Start()
    {
        health=maxHealth;
        //rend = GetComponent<Renderer>();
        //rend.sharedMaterial = material[0];
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position,player.position);

        if(distance<minimPos){
            if(hasAwaken==false){
                anim.SetBool("isAwake", true);
                StartCoroutine(WaitAwake());
                
            }
            
            if(hasAwaken){
                //Debug.Log("A");
                enemy.SetDestination(player.position);
                anim.SetBool("isRunning", true);
                if(distance <= minDis){
                    //Debug.Log("AM AJUNS");
                    anim.SetBool("isRunning", false);
                }else{
                    anim.SetBool("isRunning", true);
                }
            }
            
        }
        
             
        
        if(health <=0){
            StartCoroutine(cameraShake.Shake(gameManager.duration,gameManager.magnitude));
            Instantiate(deathParticle,transform.position,Quaternion.identity);
            StartCoroutine(BeforeDeath());
            bool giveGold = true;
            if(giveGold){
                GameManager.goldCount+=Random.Range(1,2);
                giveGold=false;
            }
            
        }
    }
    void OnTriggerEnter(Collider other) {
        if(other.tag == "LetterBasic"){
            FindObjectOfType<AudioManager>().Play("BasicEnemyInpact");
            health-=gameManager.basicLetterDamage;
            StartCoroutine(cameraShake.Shake(gameManager.duration,gameManager.magnitude));
            Instantiate(destroyParticle,transform.position,Quaternion.identity);
            isWhite = true;
            StartCoroutine(ChangeMat());
        }
        if(other.tag == "RockLetter"){
            FindObjectOfType<AudioManager>().Play("BasicEnemyInpact");
            health-=gameManager.rockLetterDamage;
            StartCoroutine(cameraShake.Shake(gameManager.duration,gameManager.magnitude));
            Instantiate(destroyParticle,transform.position,Quaternion.identity);
            isWhite = true;
            StartCoroutine(ChangeMat());
        }
         if(other.tag == "FireWorkLetter"){
            FindObjectOfType<AudioManager>().Play("BasicEnemyInpact");
            health-=gameManager.fireworkLetterDamage;
            StartCoroutine(cameraShake.Shake(gameManager.duration,gameManager.magnitude));
            Instantiate(destroyParticle,transform.position,Quaternion.identity);
            isWhite = true;
            StartCoroutine(ChangeMat());
        }
    }
    IEnumerator ChangeMat(){
        yield return new WaitForSeconds(0.07f);
        isWhite=false;
    }
    IEnumerator BeforeDeath(){
        FindObjectOfType<AudioManager>().Play("BasicEnemyDie");
        yield return new WaitForSeconds(0.03f);
        Destroy(gameObject);
    }
    IEnumerator WaitAwake(){
        yield return new WaitForSeconds(1f);
        hasAwaken=true;
        anim.SetBool("isAwake", false);
    }
}
