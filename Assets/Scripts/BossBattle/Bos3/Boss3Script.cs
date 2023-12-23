using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss3Script : MonoBehaviour
{
    public Transform player;
    public float health;
    public float maxHealth;
    public float minimPos;
    public CameraShake cameraShake;
    public Animator anim;
    public bool isWhite;
    public float distance;
    public bool canShoot;
    public float cooldownTime;
    public float timeBtwAttacks;
    public GameObject bullet;
    public GameObject bullet2;
    public GameObject bullet3;
    public GameObject bullet4;
    public GameObject bullet5;
    public Transform bulletPos;
    public GameObject bulletParticle;
    public GameManager gameManager;
    public GameObject hitParticle;
    public bool stage2;
    public int stage2Counter;
    public GameObject deathParticle;
    public int shootType;
    public GameObject stage2Enemys;
    public bool stage2AlreadySpawn;
    public static float healthBar;
    public GameObject slider;
    public GameObject music;
    public GameObject cage;
    public InventoryScript inventory;

    // Start is called before the first frame update
    void Start()
    {
        health=maxHealth;
        anim = GetComponent<Animator>();
        stage2Counter = 0;
        shootType = 0;
        stage2AlreadySpawn=false;
    }

    // Update is called once per frame
    void Update()
    {
        Attack();
        HealthCheck();
        SecondStage();
    }
    public void Attack(){
        distance = Vector3.Distance(transform.position,player.position);
        if(distance<minimPos){
            anim.SetBool("isAwake",true);
            if(canShoot){
                anim.SetBool("Shoot",true);
                canShoot=false;
                StartCoroutine(AttackCooldown());
            }
        }
    }
    public void HealthCheck(){
        healthBar=health;
        if(health <=0){
            StartCoroutine(cameraShake.Shake(gameManager.duration,gameManager.magnitude));
            Instantiate(deathParticle,transform.position,Quaternion.identity);
            slider.SetActive(false);
            music.SetActive(false);
            cage.SetActive(false);
            // amulet.SetActive(true);
            inventory.row6[2]=1;
            GameManager.boss3CompleteLetter=1;
            GameManager.isBoss3Defeted = true;
            // //StartCoroutine(BeforeDeath());
            Destroy(gameObject);
        }
    }
    void SecondStage(){
        if(health<=maxHealth/2){
            stage2 = true;
            //stage2Counter = 0;
        }
    }
    IEnumerator AttackCooldown(){
        yield return new WaitForSeconds(cooldownTime);
        anim.SetBool("Shoot",false);
        StartCoroutine(ResetCooldown());
        if(stage2){
            if(stage2Counter==2){
                anim.SetBool("Faze2",true);
                //timeBtwAttacks+=2f;
                stage2Counter=0;
            }else{
                stage2Counter++;
                //Debug.Log("Hey");
            }
            
        }
    }
    IEnumerator ResetCooldown(){
        yield return new WaitForSeconds(timeBtwAttacks);
        anim.SetBool("Faze2",false);
        canShoot = true;
    }
    public void Shoot(){
        FindObjectOfType<AudioManager>().Play("GunShoot");
        if(shootType==2){
            if(stage2){
                Instantiate(bullet,bulletPos.transform.position,Quaternion.identity);
                Instantiate(bullet2,bulletPos.transform.position,Quaternion.identity);
                Instantiate(bullet3,bulletPos.transform.position,Quaternion.identity);
                Instantiate(bullet4,bulletPos.transform.position,Quaternion.identity);
                Instantiate(bullet5,bulletPos.transform.position,Quaternion.identity);
            }else{
                Instantiate(bullet,bulletPos.transform.position,Quaternion.identity);
                Instantiate(bullet2,bulletPos.transform.position,Quaternion.identity);
                Instantiate(bullet3,bulletPos.transform.position,Quaternion.identity);
            }
           
            shootType=0;
        }else{
            if(stage2){
                Instantiate(bullet,bulletPos.transform.position,Quaternion.identity);
                Instantiate(bullet2,bulletPos.transform.position,Quaternion.identity);
                Instantiate(bullet3,bulletPos.transform.position,Quaternion.identity);
            }else{
                Instantiate(bullet,bulletPos.transform.position,Quaternion.identity);
            }
            shootType++;
        }
       
        Instantiate(bulletParticle,bulletPos.transform.position,Quaternion.identity);
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
    IEnumerator ChangeMat(){
        yield return new WaitForSeconds(0.05f);
        isWhite=false;
    }
    public void Stage2Spwan(){
        if(stage2AlreadySpawn==false){
            stage2Enemys.SetActive(true);
            stage2AlreadySpawn=true;
        }
    }
}
