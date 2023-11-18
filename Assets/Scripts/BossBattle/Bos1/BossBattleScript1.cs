using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BossBattleScript1 : MonoBehaviour
{
    public NavMeshAgent bossBattle1;
    public Transform player;
    public float health;
    public float minimPos;
    public float minDis;
    public int maxHealth;
    public CameraShake cameraShake;
    public Animator anim;
    public bool isRunning;
    public bool isAttacking;
    public bool canMove;
    public float coolDownTime;
    public float distance;
    public bool isWhite;
    public GameObject hitParticle;
    public GameObject deathParticle;
    public GameManager gameManager;
    public Transform axeEffectPos;
    public static float healthBar;
    public GameObject slider;
    public GameObject border;
    public bool secondStage;
    public float restTime;
    public GameObject projectile;
    public Transform projectilePos;
    public GameObject hitbox;
    public bool canDisableHitbox;
    public GameObject axeHitParticle;
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        anim = GetComponent<Animator>();   
    }

    // Update is called once per frame
    void Update()
    {
        HealthCheck();
        MoveAndAttack();
        SecondStage();
        Hitbox();
    }
    void MoveAndAttack(){
        distance = Vector3.Distance(transform.position,player.position);
        if(distance<minimPos){
            
            if(canMove){
                bossBattle1.SetDestination(player.position);
            }
            

            if(isRunning == false && isAttacking==false){
                anim.SetBool("isRuning", true);
                isRunning = true;
            }

            if(distance <= minDis){
                anim.SetBool("isRuning", false);
                if(isAttacking==false){
                    isAttacking=true;
                    StartCoroutine(Attack());
                }
                isRunning = false;
            }
        }
    }
    IEnumerator Attack(){
        //FindObjectOfType<AudioManager>().Play("BossSwing");
        anim.SetBool("Attack1", true);
        anim.SetBool("Attack2", false);
        anim.SetBool("Attack3", false);
        
        yield return new WaitForSeconds(1f);
        //FindObjectOfType<AudioManager>().Play("BossSwing");
        anim.SetBool("Attack2", true);
        anim.SetBool("Attack1", false);
        anim.SetBool("Attack3", false);
        yield return new WaitForSeconds(1f);
        //FindObjectOfType<AudioManager>().Play("BossSwing");
        anim.SetBool("Attack2", false);
        anim.SetBool("Attack1", false);
        anim.SetBool("Attack3", true);
        yield return new WaitForSeconds(restTime);
        anim.SetBool("Attack2", false);
        anim.SetBool("Attack1", false);
        anim.SetBool("Attack3", false);
        canMove=false;
        if(secondStage){
            SecondStageAttack();
        }
        yield return new WaitForSeconds(coolDownTime);
        
        isAttacking=false;
        canMove=true;
        
    }
    void Hitbox(){
        if(canDisableHitbox==false){
            StartCoroutine(HitboxDisable());
            canDisableHitbox=true;
        }
       
    }
    IEnumerator HitboxDisable(){
        hitbox.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        hitbox.SetActive(true);
        canDisableHitbox=false;
    }
    void HealthCheck(){
        healthBar = health;
        if(health <=0){
            StartCoroutine(cameraShake.Shake(gameManager.duration,gameManager.magnitude));
            Instantiate(deathParticle,transform.position,Quaternion.identity);
            slider.SetActive(false);
            border.SetActive(false);
            GameManager.isBoss1Defeted = true;
            //StartCoroutine(BeforeDeath());
            Destroy(gameObject);
        }
    }
    void SecondStage(){
        if(health<=maxHealth/2){
            secondStage = true;
        }
    }
    void SecondStageAttack(){
        //Debug.Log("hihiha");
        anim.SetBool("AttackStage2",true);
        StartCoroutine(Stage2());
    }
    IEnumerator Stage2(){
        yield return new WaitForSeconds(3f);
        anim.SetBool("AttackStage2",false);
    }
    public void ShootRock(){
        StartCoroutine(ShootRockCoroutine());
        Instantiate(projectile,projectilePos.transform.position,Quaternion.identity);
    }
    IEnumerator ShootRockCoroutine(){
        FindObjectOfType<AudioManager>().Play("RockSound");
        Instantiate(projectile,projectilePos.transform.position,Quaternion.identity);
        yield return new WaitForSeconds(0.2f);
        FindObjectOfType<AudioManager>().Play("RockSound");
        Instantiate(projectile,projectilePos.transform.position,Quaternion.identity);
        yield return new WaitForSeconds(0.2f);
        FindObjectOfType<AudioManager>().Play("RockSound");
        Instantiate(projectile,projectilePos.transform.position,Quaternion.identity);
    }
    void ChameraShake(){
        StartCoroutine(cameraShake.Shake(gameManager.durationSoft,gameManager.magnitudeSoft));
    }
    void ChameraShakeHard(){
        StartCoroutine(cameraShake.Shake(gameManager.duration,gameManager.magnitude));
    }
    void AxeParticle(){
        Instantiate(axeHitParticle,axeEffectPos.position,Quaternion.identity);
    }
    IEnumerator ChangeMat(){
        yield return new WaitForSeconds(0.01f);
        isWhite=false;
    }

    void OnTriggerEnter(Collider other){
        if(other.tag == "LetterBasic"){
            FindObjectOfType<AudioManager>().Play("BasicEnemyInpact");
            FindObjectOfType<AudioManager>().Play("BasicArrow");
            health-=gameManager.basicLetterDamage;
            StartCoroutine(cameraShake.Shake(gameManager.duration,gameManager.magnitude));
            Instantiate(hitParticle,transform.position,Quaternion.identity);
            isWhite = true;
            StartCoroutine(ChangeMat());
        }
        if(other.tag == "RockLetter"){
            FindObjectOfType<AudioManager>().Play("BasicEnemyInpact");
            FindObjectOfType<AudioManager>().Play("BasicArrow");
            health-=gameManager.rockLetterDamage;
            StartCoroutine(cameraShake.Shake(gameManager.duration,gameManager.magnitude));
            Instantiate(hitParticle,transform.position,Quaternion.identity);
            isWhite = true;
            StartCoroutine(ChangeMat());
        }
         if(other.tag == "FireWorkLetter"){
            FindObjectOfType<AudioManager>().Play("BasicEnemyInpact");
            FindObjectOfType<AudioManager>().Play("BasicArrow");
            health-=gameManager.fireworkLetterDamage;
            StartCoroutine(cameraShake.Shake(gameManager.duration,gameManager.magnitude));
            Instantiate(hitParticle,transform.position,Quaternion.identity);
            isWhite = true;
            StartCoroutine(ChangeMat());
        }
    }
    public void Sound1(){
        FindObjectOfType<AudioManager>().Play("BossSwing");
       
        FindObjectOfType<AudioManager>().Play("AxeSwing2");
    }
    public void Sound2(){
        FindObjectOfType<AudioManager>().Play("BossHitGround");
    }
    public void Sound3(){
        FindObjectOfType<AudioManager>().Play("HeavyStep");
    }
}
