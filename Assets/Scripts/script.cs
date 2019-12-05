using UnityEngine;

public class script : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    public float force = 500f;
   void FixedUpdate()

    {
        //Debug.Log(transform.position.x);
        rb.AddForce(force*Time.deltaTime,0,0);
        
    }
}
