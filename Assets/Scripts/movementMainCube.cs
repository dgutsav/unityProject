using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementMainCube : MonoBehaviour
{
    public MainCube cube;
    public Rigidbody rb;
    public float jump_force;
    public float side_force;
    public float normal_force;
    public GameMaster game_manager;
    void Start(){
        cube.enableJump1 = false;
        cube.enableJump2 = false;
    }
    void FixedUpdate()
    {
        if(game_manager.hasEnded){
            return;
        }
        if(Input.GetKeyDown(KeyCode.Space)){
            Debug.Log("Space Pressed");
            if(cube.enableJump1){
                Debug.Log("Jump 1");
                cube.enableJump1 = false;
                rb.AddForce(0,jump_force*Time.deltaTime,0);
            }
            else if(cube.enableJump2){
                Debug.Log("Jump 2");
                cube.enableJump2 = false;
                rb.AddForce(0,jump_force*Time.deltaTime,0);
            }
        }
        if(Input.GetKey(KeyCode.A)){
            Debug.Log("A Pressed");
            rb.AddForce(-side_force*Time.deltaTime,0,0);
        }
        if(Input.GetKey(KeyCode.D)){
            Debug.Log("D Pressed");
            rb.AddForce(side_force*Time.deltaTime,0,0);
        }
        rb.AddForce(0,0,normal_force*Time.deltaTime*game_manager.force_multiplier);
        //Debug.Log(transform.position.z);
    }
}
