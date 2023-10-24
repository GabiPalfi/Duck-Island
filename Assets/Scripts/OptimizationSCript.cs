using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptimizationSCript : MonoBehaviour
{
    public GameObject player;
    public float dis;
    public GameObject child;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position,player.transform.position);
        if(distance>dis){
            child.SetActive(false);
        }else{
            child.SetActive(true);
        }
    }
}
