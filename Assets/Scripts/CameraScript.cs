using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject player;
    public float speed;
    private Vector3 offset;
    private Vector3 newpos;
    public float duration;
    public float magnitude;
    public CameraShake cameraShake;

    // Start is called before the first frame update
    void Start()
    {
        offset = player.transform.position - transform.position;
    }
    void Shake(){
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position-offset;
        
    }
    
}
