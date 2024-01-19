using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LastBossScript : MonoBehaviour
{
    public Transform player;
    public float health;
    public float maxHealth;
    public float minimPos;
    public CameraShake cameraShake;
    public Animator anim;
    public bool isWhite;
    public HouseUIanim spikeAttack1Anim;
    public GameObject spikeAttack1;
    public GameManager gameManager;
    public HouseUIanim spikeLogAnim;
    public GameObject spikeLog;
    public float distance;
    public bool canAttack;
    public float cooldownTime;
    public float cooldownTime2;
    public float timeBtwAttacks;
    public bool hasSetPos1;
    private Vector3 pos1;
    public bool hasSetPos2;
    private Vector3 pos2;
    public GameObject hitParticle;
    public GameObject dieParticle;

    public bool stage2;
    public bool attck1;
    public bool attck2;

    public GameObject stoneEnemy;
    public bool hasSpawnedStoneEnemy;
    public bool hasDied;
    public GameObject music;
    public Transform particlePos;
    public LoadScreen uiScreen;
    public InventoryScript inventory;
    // Start is called before the first frame update
    void Start()
    {
        health=maxHealth;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Attack();
        HealthCheck();
        // Debug.Log(GameManager.lastLevelDeathCount);
        MonitorTryes();
    }
    public void Attack(){
        distance = Vector3.Distance(transform.position,player.position);
        if(distance<minimPos){
            anim.SetBool("isAwake",true);
            //Debug.Log("Hey");
            if(canAttack){
                anim.SetBool("Attack1",true);
                attck1=true;
                canAttack=false;
                StartCoroutine(AttackCooldown());
            }
        }
    }
    IEnumerator AttackCooldown(){
        yield return new WaitForSeconds(cooldownTime);
        anim.SetBool("Attack1",false);
        attck1=false;
        //yield return new WaitForSeconds(timeBtwAttacks);
        anim.SetBool("Attack2",true);
        attck2=true;
        StartCoroutine(AttackCooldown2());
    }
    IEnumerator AttackCooldown2(){
        yield return new WaitForSeconds(cooldownTime2);
        //anim.SetBool("Attack1",false);
        anim.SetBool("Attack2",false);
        attck2=false;
        yield return new WaitForSeconds(timeBtwAttacks);
        canAttack=true;
        //StartCoroutine(AttackCooldown2());
    }

    public void HealthCheck(){
        if(health<=maxHealth/2){
            stage2=true;
            if(hasSpawnedStoneEnemy==false){
                stoneEnemy.SetActive(true);
                hasSpawnedStoneEnemy=true;
            }
        }
        if(health<=0){
            if(hasDied==false){
                anim.SetTrigger("HasDied");
                hasDied=true;
            }
            anim.SetBool("Attack1",false);
            anim.SetBool("Attack2",false);
        }
    }
    public void SpikeAttackFirst(){
        //spikeAttack1.SetActive(false);
        if(stage2 && attck1){
            LogAttack();
        }
        hasSetPos1=false;
        //Debug.Log("HEYYY");
        if(hasSetPos1==false){
            pos1 = new Vector3(player.position.x,-3,player.position.z);
            spikeAttack1.transform.position = pos1;
            StartCoroutine(SpikeCooldown());
        }
        //hasSetPos=false; 
    }
    IEnumerator SpikeCooldown(){
        yield return new WaitForSeconds(0.2f);
        spikeAttack1Anim.anim.SetBool("Attack",true);
        hasSetPos1=true;
        yield return new WaitForSeconds(1f);
        //anim.SetBool("Attack1",false);
        spikeAttack1Anim.anim.SetBool("Attack",false);
        //StartCoroutine(AttackCooldown2());
    }
    public void LogAttack(){
        hasSetPos2=false;
        if(hasSetPos2==false){
            pos2 = new Vector3(93f,1.5f,player.position.z);
            //Debug.Log(pos2);
            spikeLog.transform.position = pos2;
            StartCoroutine(LogCooldown());
        }
        if(stage2 && attck2){
            SpikeAttackFirst();
        }
    }
    IEnumerator LogCooldown(){
        yield return new WaitForSeconds(0.2f);
        spikeLogAnim.anim.SetBool("Attack",true);
        hasSetPos2=true;
        yield return new WaitForSeconds(2f);
        spikeLogAnim.anim.SetBool("Attack",false);
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
    public void Sound(){
        FindObjectOfType<AudioManager>().Play("Spike");
    }
    public void Death(){
        stoneEnemy.SetActive(false);
        canAttack=false;
        FindObjectOfType<AudioManager>().Play("BasicEnemyDie");
        music.SetActive(false);
        Destroy(music);
        inventory.row6[3]=1;
        GameManager.boss4CompleteLetter=1;
        GameManager.isLastBossDefeted=true;
       
    }
    public void DeathSound(){
        FindObjectOfType<AudioManager>().Play("BasicEnemyDie");
        Instantiate(dieParticle,particlePos.position,Quaternion.identity);
        StartCoroutine(cameraShake.Shake(gameManager.duration,gameManager.magnitude));
        StartCoroutine(ChangeScene());
    }
    IEnumerator ChangeScene(){
        yield return new WaitForSeconds(3f);
        uiScreen.EndLevel();
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("MainBase");   
    }
    public void MonitorTryes(){
        if(GameManager.lastLevelDeathCount==10){
            StartCoroutine(ChangeScene2());
        }
    }
    IEnumerator ChangeScene2(){
        uiScreen.EndLevel();
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Credits");   
    }
}
