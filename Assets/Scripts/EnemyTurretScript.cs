using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTurretScript : MonoBehaviour
{
    public GameObject arrow;
    
    public Transform Pos1;
    public Transform Pos2;
    public Transform Pos3;
    public Transform Pos4;
    public Transform player;
    public float minDis;
    public bool canShoot;
    public float cooldown;
    public float longCooldown;
    public float health;
    public GameObject destroyParticle;
    public GameObject deathParticle;
    public GameManager gameManager;
    public CameraShake cameraShake;
    public bool isWhite;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position,player.position);
         if(distance<minDis){
            if(canShoot){
                StartCoroutine(CooldownSmall());
                canShoot=false;
                StartCoroutine(Cooldown());
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
    IEnumerator Cooldown(){
        yield return new WaitForSeconds(longCooldown);
        canShoot=true;
    }
    IEnumerator CooldownSmall(){
        Instantiate(arrow,Pos1.position,Quaternion.identity);
        FindObjectOfType<AudioManager>().Play("BasicArrow");
        yield return new WaitForSeconds(cooldown);
        Instantiate(arrow,Pos2.position,Quaternion.identity);
        FindObjectOfType<AudioManager>().Play("BasicArrow");
        yield return new WaitForSeconds(cooldown);
        Instantiate(arrow,Pos3.position,Quaternion.identity);
        FindObjectOfType<AudioManager>().Play("BasicArrow");
        yield return new WaitForSeconds(cooldown);
        Instantiate(arrow,Pos4.position,Quaternion.identity);
        FindObjectOfType<AudioManager>().Play("BasicArrow");
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
    IEnumerator ChangeMat(){
        yield return new WaitForSeconds(0.07f);
        isWhite=false;
    }
    IEnumerator BeforeDeath(){
        FindObjectOfType<AudioManager>().Play("BasicEnemyDie");
        yield return new WaitForSeconds(0.03f);
        Destroy(gameObject);
    }
    public void JustShoot(){
        //canShoot=true;
        StartCoroutine(CooldownSmall());
    }
}
