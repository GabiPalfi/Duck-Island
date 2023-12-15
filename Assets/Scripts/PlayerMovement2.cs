using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;


public class PlayerMovement2 : MonoBehaviour
{
    [Header("Referinte")]
    public CharacterController controler;
    private Camera mainCamera;
    public CameraShake cameraShake;
    public GameManager gameManager;
    public InventoryScript inventory;
    public GameObject Cam;
    public GameObject sprintSlider;

    [Header("Game Objects")]
    public GameObject bullet;
    public GameObject rockLetter;
    public GameObject fireworkLetter;
    public Transform bulletPos;

    [Header("Player Variables")]
    public float speed;
    public float _gravity = -9.8f;
    [SerializeField] private float gravityMultiplyer = 3.0f;
    public float _velocity;
   
    [Header("Animation")]
    private Animator anim;
    public bool canAnimate;

    [Header("Shooting")]
    public int lettersCount;
    public int maxLetterCount;
    public float reloadTime;
    public bool canShoot1;
    public float cooldown;
    public bool startReloading;
    public bool isWeaponWheelClose;
    public bool canAttack;
    public bool weaponSlashAquire;


    [Header("Health")]

    public static int staticHealth=5;
    public int currentHealth;
    public int maxHealth;
    public bool canTakeDamage;
    public static bool isAlive;
    


    [Header("Movement")]
    private Vector3 _direction;
    public bool canMove;
    public float dashTime;
    public float dashSpeed;
    public bool canDash;
    public static bool canDashStatic;
    public bool dashDebuger=true;
    public static int dashTokensStatic;
    public static int dashMaxTokensStatic=3;
    public int dashTokens;
    public float sprintSpeed;
    public float basicSpeed;
    public static float sprintSliderValue;
    public bool canSprint;
    private float keyPressStartTime = 0f;
    private bool keyPressing = false;
    
    
   

    [Header("Particle")]
    public GameObject dashParticle;

    [Header("Sounds")]
    // [SerializeField] private AudioSource walkSound;
    public bool canWalkSound;


    // Start is called before the first frame update
    void Awake(){
       SetPos();

    }
    void Start()
    {
        mainCamera = FindObjectOfType<Camera>();
        anim = GetComponent<Animator>();
        lettersCount = maxLetterCount;
        canTakeDamage = true;
        dashTokensStatic=0;
        canDashStatic = dashDebuger;
        currentHealth=staticHealth;
        GameManager.isNormalLetterSelected = true;
        isAlive=true;
        SetPos();
        StartCoroutine(FixPos());
        StartCoroutine(FixPos2());
        speed=basicSpeed;
        sprintSliderValue = 20;
        //canSprint=true;
        
        
        
    }
    

    // Update is called once per frame
    void Update()
    {
        ApplyRotation();
        Movement();
        Shoot();
        Health();
        Dash();
        Attack();
    }

    void ApplyRotation(){
          //camera follow cursor
        Ray cameraRay = mainCamera.ScreenPointToRay(Input.mousePosition);
        Plane groundPlane = new Plane(Vector3.up,Vector3.zero);
        float rayLength;

        if(groundPlane.Raycast(cameraRay,out rayLength)){
            Vector3 pointToLook = cameraRay.GetPoint(rayLength);
            Debug.DrawLine(cameraRay.origin, pointToLook, Color.blue);
            transform.LookAt(new Vector3(pointToLook.x,transform.position.y ,pointToLook.z));
        }
    }

    void Movement(){
        //movement
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        _direction = new Vector3(horizontal,_velocity,vertical).normalized;

        if(_direction.magnitude >= 0.1f){
            if(canMove){
                controler.Move(_direction*speed*Time.deltaTime);
                //FindObjectOfType<AudioManager>().Play("PlayerWalk");
            }
            // float targetAngle = Mathf.Atan2(direction.x, direction.z)*Mathf.Rad2Deg;
            // transform.rotation = Quaternion.Euler(0f, targetAngle, 0f);
            
        }
        if(canAnimate){
            if(horizontal==0 && vertical==0){
                anim.SetBool("IsRunning", false);
            }else{
                anim.SetBool("IsRunning", true);
            }
        }
        if(controler.isGrounded){
            _velocity = -1f;
        }else{
            _velocity += _gravity*gravityMultiplyer * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)){
            if(canWalkSound){
                FindObjectOfType<AudioManager>().Play("PlayerWalk");
                canWalkSound=false;
                StartCoroutine(WalkSound());
            }
            //Debug.Log("SAMA FGUT IN ARICPA");
            // if(!walkSound.isPlaying){
            //     walkSound.Play();
            // }else{
            //     walkSound.Stop();
            // }
            
        }
        if(Input.GetKey(KeyCode.LeftShift)){
            if(canSprint){
                sprintSlider.SetActive(true);
                speed = sprintSpeed;
                sprintSliderValue-=7.5f * Time.deltaTime;  
                if (!keyPressing){
                    keyPressStartTime = Time.time;
                    keyPressing = true;
                }
            }
            
        }else{
            speed = basicSpeed; 
            if (keyPressing){
                keyPressing = false;
                float keyPressDuration = Time.time - keyPressStartTime;
                //Debug.Log("Time Between Key Presses: " + keyPressDuration);
                
            }
            if(sprintSliderValue<20 && sprintSliderValue>0){
                StartCoroutine(RechargeSprint());
            }
        }

        if(sprintSliderValue<0){
            canSprint=false;
            speed = basicSpeed;
            StartCoroutine(Sprint()); 
        }
        
    }
    IEnumerator RechargeSprint(){
        while(sprintSliderValue<=20){
            sprintSliderValue+=0.01f;
            yield return new WaitForSeconds(0.1f);
        }
    }
    IEnumerator Sprint(){
        yield return new WaitForSeconds(2f);
        while(sprintSliderValue<=10){
            sprintSliderValue+=0.01f;
            yield return new WaitForSeconds(0.1f);
        }
        if(sprintSliderValue>=10){
            canSprint=true;
            // yield return new WaitForSeconds(0.5f);
            // sprintSlider.SetActive(false);
        }
        
    }
    IEnumerator WalkSound(){
        yield return new WaitForSeconds(0.3f);
        canWalkSound=true;
    }
    public void Health(){
        staticHealth=currentHealth;
        // if(Input.GetKeyDown(KeyCode.L)){
        //     PlayerLoseHealth();
        // }
        if(Input.GetKeyDown(KeyCode.K)){
            if(inventory.row1[9]>0 && currentHealth<maxHealth){
                PlayerGainHealth();
                inventory.row1[9]--;
            }
           
        }
        
    }

    void Shoot(){
        if(isWeaponWheelClose){
            if(canShoot1){
                if(GameManager.isNormalLetterSelected){
                    if(lettersCount>0){
                        if(Input.GetKeyDown(KeyCode.E) || Input.GetMouseButtonDown(0)){
                            // Debug.Log("E");
                            FindObjectOfType<AudioManager>().Play("Shoot");
                            Instantiate(bullet,bulletPos.position,Quaternion.identity);
                            lettersCount--;
                            canShoot1 = false;
                            StartCoroutine(ShootColdown());
                        }
                    } 
                }
                if(GameManager.isRockLetterSelected){
                    if(inventory.row7[0]>0){
                        if(Input.GetKeyDown(KeyCode.E) || Input.GetMouseButtonDown(0)){
                            // Debug.Log("E");
                            FindObjectOfType<AudioManager>().Play("Shoot");
                            Instantiate(rockLetter,bulletPos.position,Quaternion.identity);
                            inventory.row7[0]--;
                            canShoot1 = false;
                            StartCoroutine(ShootColdown());
                        }
                    } 
                }
                if(GameManager.isFireworkLetterSelected){
                    if(inventory.row7[1]>0){
                        if(Input.GetKeyDown(KeyCode.E) || Input.GetMouseButtonDown(0)){
                            // Debug.Log("E");
                            FindObjectOfType<AudioManager>().Play("Shoot");
                            Instantiate(fireworkLetter,bulletPos.position,Quaternion.identity);
                            inventory.row7[1]--;
                            canShoot1 = false;
                            StartCoroutine(ShootColdown());
                        }
                    } 
                }
            }
        }
       
        if(lettersCount<maxLetterCount && startReloading){
            StartCoroutine(Reload());
            startReloading=false;
        }
        
    }
    public void Attack(){
        if(GameManager.slashTalisman>0){
            weaponSlashAquire=true;
        }else{
            weaponSlashAquire=false;
        }
        if(weaponSlashAquire){
            if(canAttack){
                if(Input.GetKeyDown(KeyCode.Q)){
                    
                    anim.SetBool("isSlashing",true);
                    canAttack=false;
                    StartCoroutine(Slash());
                }
            }
        }
    }
    IEnumerator Slash(){
        yield return new WaitForSeconds(0.15f);
        FindObjectOfType<AudioManager>().Play("KatanaSlash");
        anim.SetBool("isSlashing",false);
        yield return new WaitForSeconds(0.5f);
        canAttack=true;
    }
    void Dash(){
        dashTokens=dashTokensStatic;
        //canDashStatic = dashDebuger;
        if(dashTokens==dashMaxTokensStatic){
            canDash=true;
        }
        if(Input.GetKeyDown(KeyCode.Space)){
            if(canDashStatic){
                 if(canDash){
                    FindObjectOfType<AudioManager>().Play("Dash");
                    StartCoroutine(Dashing());
                    Instantiate(dashParticle,transform.position,Quaternion.identity);
                    canDash=false;
                    dashTokensStatic=0;
                }
            }
           
           
        }
    }
    IEnumerator Dashing(){
        float startTime = Time.time;
        while(Time.time < startTime + dashTime){
            controler.Move(_direction*dashSpeed*Time.deltaTime);
            yield return null;
        }
        // canDash=false;
        // dashTokensStatic=0;
    }
    private void OnTriggerEnter(Collider other){
        if(other.tag=="BasicAttack"){
            if(canTakeDamage){
                PlayerLoseHealth();
                canTakeDamage=false;
                StartCoroutine(DontTakeDamage());
            }
            
        }
    }
    IEnumerator ShootColdown(){
        yield return new WaitForSeconds(cooldown);
        canShoot1=true;
    }
    IEnumerator Reload(){
        yield return new WaitForSeconds(reloadTime);
        lettersCount++;
        startReloading = true;
    }
    IEnumerator DontTakeDamage(){
        yield return new WaitForSeconds(1f);
        canTakeDamage = true;
    }
    public void PlayerLoseHealth(){
        StartCoroutine(cameraShake.Shake(gameManager.duration,gameManager.magnitude));
        currentHealth--;
        FindObjectOfType<AudioManager>().Play("HealthDown");
        
        if(currentHealth<=0){
            currentHealth = maxHealth;
            gameManager.StartGame();
        }


    }
    public void PlayerGainHealth(){
        StartCoroutine(cameraShake.Shake(gameManager.duration,gameManager.magnitude));
        currentHealth++;
        FindObjectOfType<AudioManager>().Play("ColectResorce");
    }

    void SetPos(){
        Scene scene = SceneManager.GetActiveScene();
       
        if(GameManager.level1Index==1 && scene.name=="Level 1"){
            Cam.transform.position = new Vector3(57f,10f,20f);
            transform.position = new Vector3(57f,2f,30f);
            StartCoroutine(FixPos());
        }
        if(GameManager.level1Index==2 && scene.name=="Level 1"){
            Cam.transform.position = new Vector3(-11f,10f,74f);
            transform.position = new Vector3(-11f,2f,85f);
            StartCoroutine(FixPos());
        }
        if(GameManager.gameStarted ==false && scene.name=="MainBase"){
            Cam.transform.position = new Vector3(10.993f,9.897725f,-97.87727f);
            transform.position = new Vector3(11.39f,2.276636f,-87.64f);
            StartCoroutine(FixPos());
        }
        
        
    }
    IEnumerator FixPos(){
        Scene scene = SceneManager.GetActiveScene();
       
        if(GameManager.level1Index==1 && scene.name=="Level 1"){
            Cam.transform.position = new Vector3(57f,10f,20f);
            transform.position = new Vector3(57f,2f,30f);
            yield return new WaitForSeconds(0.5f);
            Cam.transform.position = new Vector3(57f,10f,20f);
            transform.position = new Vector3(57f,2f,30f);
            yield return new WaitForSeconds(0.5f);
            Cam.transform.position = new Vector3(57f,10f,20f);
            transform.position = new Vector3(57f,2f,30f);
           
        }
        if(GameManager.level1Index==2 && scene.name=="Level 1"){
            Cam.transform.position = new Vector3(-11f,10f,74f);
            transform.position = new Vector3(-11f,2f,85f);
            yield return new WaitForSeconds(0.5f);
            Cam.transform.position = new Vector3(-11f,10f,74f);
            transform.position = new Vector3(-11f,2f,85f);
            yield return new WaitForSeconds(0.5f);
            Cam.transform.position = new Vector3(-11f,10f,74f);
            transform.position = new Vector3(-11f,2f,85f);
        }

        if(GameManager.gameStarted == false && scene.name=="MainBase"){
            Cam.transform.position = new Vector3(10.993f,9.897725f,-97.87727f);
            transform.position = new Vector3(11.39f,2.276636f,-87.64f);
            yield return new WaitForSeconds(0.5f);
            Cam.transform.position = new Vector3(10.993f,9.897725f,-97.87727f);
            transform.position = new Vector3(11.39f,2.276636f,-87.64f);
            
        }
    }
     IEnumerator FixPos2(){
        Scene scene = SceneManager.GetActiveScene();
       
        if(GameManager.level1Index==1 && scene.name=="Level 1"){
            Cam.transform.position = new Vector3(57f,10f,20f);
            transform.position = new Vector3(57f,2f,30f);
            yield return new WaitForSeconds(0.25f);
            Cam.transform.position = new Vector3(57f,10f,20f);
            transform.position = new Vector3(57f,2f,30f);
            yield return new WaitForSeconds(0.75f);
            Cam.transform.position = new Vector3(57f,10f,20f);
            transform.position = new Vector3(57f,2f,30f);
        }
        if(GameManager.level1Index==2 && scene.name=="Level 1"){
            Cam.transform.position = new Vector3(-11f,10f,74f);
            transform.position = new Vector3(-11f,2f,85f);
            yield return new WaitForSeconds(0.25f);
            Cam.transform.position = new Vector3(-11f,10f,74f);
            transform.position = new Vector3(-11f,2f,85f);
            yield return new WaitForSeconds(0.75f);
            Cam.transform.position = new Vector3(-11f,10f,74f);
            transform.position = new Vector3(-11f,2f,85f);
        }
        if(GameManager.gameStarted == false && scene.name=="MainBase"){
            Cam.transform.position = new Vector3(10.993f,9.897725f,-97.87727f);
            transform.position = new Vector3(11.39f,2.276636f,-87.64f);
            yield return new WaitForSeconds(0.5f);
            Cam.transform.position = new Vector3(10.993f,9.897725f,-97.87727f);
            transform.position = new Vector3(11.39f,2.276636f,-87.64f);
            
        }
    }
}
