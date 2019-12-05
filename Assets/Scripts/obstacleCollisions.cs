using UnityEngine;

public class ObstacleCollisions : MonoBehaviour
{
    public Rigidbody rb;
    public float collisionForce = 1f;
    void OnCollisionEnter(Collision collision){
        if(collision.collider.name == "Object"){
            Debug.Log("Object collided");
            rb.AddForce(collisionForce,collisionForce,collisionForce);
        }
    }    
}
