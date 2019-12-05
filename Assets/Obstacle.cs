using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Obstacle : MonoBehaviour
{
    public Rigidbody rb;
    public float collisionForce = 5f;
    
    void OnCollisionEnter(Collision collision){
        if(collision.collider.name == "Object"){
            Debug.Log("Object collided");
            rb.AddForce(collisionForce,collisionForce,collisionForce);
        }
    }    
}
