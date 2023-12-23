using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ArmorEnemySCript : MonoBehaviour
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
    public float whiteDuration = 0.07f;
    public bool hasAwaken;
    public Material[] material;
    Renderer rend;
    public Animator anim;
    public bool isRunning;
    public bool isAttacking;
    public bool isRanged;
    public GameObject arrow;
    public Transform arrowPos;
    public float timeBtwAttacks;
    public bool giveHealthCooldown;
    // Start is called before the first frame update
    void Start()
    {
        health=maxHealth;
        //rend = GetComponent<Renderer>();
        //rend.sharedMaterial = material[0];
        anim = GetComponent<Animator>();
        giveHealthCooldown = true;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position,player.position);

        if(distance<minimPos){
            if(hasAwaken==false){
                //Debug.Log("PON");
                anim.SetBool("IsAwaken", true);
                StartCoroutine(WaitAwake());
                
            }
            
            if(hasAwaken){
                //Debug.Log("A");
                //Debug.Log("PON");
                if(isRunning == false){
                    anim.SetBool("RUN", true);
                    isRunning = true;
                }
                
                enemy.SetDestination(player.position);
                
                if(distance <= minDis){
                    //Debug.Log("AM AJUNS");
                    anim.SetBool("RUN", false);
                    if(isAttacking == false){
                        //anim.SetBool("isAttacking",true);
                        if(isRanged){
                            AttackRange();
                            anim.SetBool("isAttacking",true);
                        }else{
                            anim.SetBool("isAttacking2",true);
                        }
                        isAttacking = true;
                        StartCoroutine(WaitToAttack());
                    }
                   
                    isRunning = false;
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
            if(GameManager.healthTalisman>0){
                if(PlayerMovement2.staticHealth<5){
                    if(giveHealthCooldown){
                        FindObjectOfType<PlayerMovement2>().PlayerGainHealth();
                        giveHealthCooldown = false;
                    }
                   
                }
            }
            //Debug.Log("DAMI VIATA");
        }
    }
    void OnTriggerEnter(Collider other) {
        if(other.tag == "LetterBasic"){
            FindObjectOfType<AudioManager>().Play("BasicEnemyInpact");
            FindObjectOfType<AudioManager>().Play("ArmorEnemyHit");
            health-=gameManager.basicLetterDamage;
            StartCoroutine(cameraShake.Shake(gameManager.duration,gameManager.magnitude));
            Instantiate(destroyParticle,transform.position,Quaternion.identity);
            isWhite = true;
            StartCoroutine(ChangeMat());
        }
        if(other.tag == "RockLetter"){
            FindObjectOfType<AudioManager>().Play("BasicEnemyInpact");
            FindObjectOfType<AudioManager>().Play("ArmorEnemyHit");
            health-=gameManager.rockLetterDamage;
            StartCoroutine(cameraShake.Shake(gameManager.duration,gameManager.magnitude));
            Instantiate(destroyParticle,transform.position,Quaternion.identity);
            isWhite = true;
            StartCoroutine(ChangeMat());
        }
         if(other.tag == "FireWorkLetter"){
            FindObjectOfType<AudioManager>().Play("BasicEnemyInpact");
            FindObjectOfType<AudioManager>().Play("ArmorEnemyHit");
            health-=gameManager.fireworkLetterDamage;
            StartCoroutine(cameraShake.Shake(gameManager.duration,gameManager.magnitude));
            Instantiate(destroyParticle,transform.position,Quaternion.identity);
            isWhite = true;
            StartCoroutine(ChangeMat());
        }
    }
    public void AttackRange(){
        Instantiate(arrow,arrowPos.transform.position,Quaternion.identity);
        FindObjectOfType<AudioManager>().Play("BasicArrow");
    }
    IEnumerator ChangeMat(){
        yield return new WaitForSeconds(whiteDuration);
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
        anim.SetBool("IsAwaken", false);
    }
    IEnumerator WaitToAttack(){
        yield return new WaitForSeconds(0.5f);
        if(isRanged){
            anim.SetBool("isAttacking",false);
        }else{
            anim.SetBool("isAttacking2",false);
        }
       
        yield return new WaitForSeconds(timeBtwAttacks);
        isAttacking = false;

    }
}
