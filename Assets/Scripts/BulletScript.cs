using System.Collections;
using System.Collections.Generic;
//using UnityEditor;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float lifTime;
    public float speed;
    public Rigidbody rb;
    private Camera mainCamera;
    public GameObject destroyParticle;
    public GameObject fireWorkParticle;
    public CameraShake cameraShake;
    public float duration;
    public float magnitude;
    public CameraShake cameraScript;
    public GameManager gameManager;
    public CapsuleCollider colider;
    public bool isFireWork;
    public bool isRock;
    


    // Start is called before the first frame update
    void Start()
    {
        
        mainCamera = FindObjectOfType<Camera>();
        StartCoroutine(Fly());
        if(isFireWork){
            colider = GetComponent<CapsuleCollider>();
        }
        
       
        Ray cameraRay = mainCamera.ScreenPointToRay(Input.mousePosition);
        Plane groundPlane = new Plane(Vector3.up,Vector3.zero);
        float rayLength;

        if(groundPlane.Raycast(cameraRay,out rayLength)){
            Vector3 pointToLook = cameraRay.GetPoint(rayLength);
            Debug.DrawLine(cameraRay.origin, pointToLook, Color.blue);
            transform.LookAt(new Vector3(pointToLook.x,transform.position.y,pointToLook.z));
        }
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = transform.forward * speed;
    }
    private IEnumerator Fly(){
        yield return new WaitForSeconds(lifTime);
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other) {
        if(other.tag=="SimpleEnemy"){
            StartCoroutine(cameraShake.Shake(gameManager.duration,gameManager.magnitude));

            FindObjectOfType<AudioManager>().Play("BasicInpact");

            if(isFireWork){
                Destroy(gameObject,0.2f);
                Instantiate(fireWorkParticle,transform.position,Quaternion.identity);
            }else{
                Destroy(gameObject);
                Instantiate(destroyParticle,transform.position,Quaternion.identity);
            }
        }
        if(other.tag=="Cliffs" || other.tag=="Rock"){
            if(isFireWork || isRock){
                //FindObjectOfType<AudioManager>().Play("BasicInpact");
                //StartCoroutine(cameraShake.Shake(gameManager.duration,gameManager.magnitude));
                //Instantiate(destroyParticle,transform.position,Quaternion.identity);
                //Destroy(gameObject);
            }else{
                FindObjectOfType<AudioManager>().Play("BasicInpact");
                StartCoroutine(cameraShake.Shake(gameManager.duration,gameManager.magnitude));
                Instantiate(destroyParticle,transform.position,Quaternion.identity);
                Destroy(gameObject);
            }
        }
        if(other.tag=="SimpleEnemy"){
            if(PlayerMovement2.dashMaxTokensStatic>PlayerMovement2.dashTokensStatic){
                PlayerMovement2.dashTokensStatic++;
                
            } 
            if(isFireWork){
                //Debug.Log("Hai");
                colider.radius = 13;
            }
            
        }
    }
}
