using UnityEngine;

public class objectMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    public float input_force = 1000f;
    public float side_force = 500f;
    public float jump_force = 1000f;
    public bool enable = true;
    void FixedUpdate()

    {
        if (!enable)
        {
            return;
        }
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("A pressed");
            rb.AddForce(0, 0, side_force * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(0, 0, -side_force * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(input_force * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(0, jump_force * Time.deltaTime, 0); 
        }

    }
}
