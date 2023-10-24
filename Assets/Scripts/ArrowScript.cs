using System.Collections;
using System.Collections.Generic;
using System.Reflection.Emit;
using Unity.VisualScripting;
using UnityEngine;

public class ArrowScript : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    public Transform player;
    public Vector3 playerPos;
    private Vector3 direction;
    public bool hasRotated;
    public float lifetime;
    private Vector3 initialDirection;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        playerPos = player.transform.position;
        //playerPos = player.transform.position;
        //Vector3 v3Force = speed*transform.forward;
        rb = GetComponent<Rigidbody>(); 
        StartCoroutine(Life());
        initialDirection = (player.position - transform.position).normalized;
        
    }

    // Update is called once per frame
    void Update()
    {

        // Vector3 direction = (playerPos - transform.position).normalized;
        // rb.velocity = direction * speed;
        // if(hasRotated==false){
        //     hasRotated = true;
        //     Quaternion targetRotation = Quaternion.LookRotation(direction);
        //     transform.rotation = targetRotation;
        // }

        // Vector3 directionToPlayer = (player.position - transform.position).normalized;
        // rb.velocity = directionToPlayer * speed;
        // if (rb.velocity != Vector3.zero)
        // {
        //     transform.rotation = Quaternion.LookRotation(rb.velocity);
        // }
        rb.velocity = initialDirection * speed;
        if (rb.velocity != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(rb.velocity);
        }

    }
    IEnumerator Life(){
        yield return new WaitForSeconds(lifetime);
        Destroy(gameObject);
    }
}
