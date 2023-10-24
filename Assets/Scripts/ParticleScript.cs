using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class ParticleScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Deleting());
    }
    IEnumerator Deleting(){
        yield return new WaitForSeconds(0.1f);
        Destroy(gameObject);
    }
}
