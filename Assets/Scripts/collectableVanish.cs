using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectableVanish : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision){
        if(collision.collider.name == "Cube"){
            rb.AddForce(0,100000,0);
        }
    }
}
