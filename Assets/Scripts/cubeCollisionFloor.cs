using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeCollisionFloor : MonoBehaviour
{
    public MainCube cube;
    void Start()
    {
        Debug.Log("collision script");
    }
    void OnCollisionEnter(Collision collision){
        if(collision.collider.name=="Floor"){
            //Debug.Log("jump set to true");
            cube.enableJump1 = true;
            cube.enableJump2 = true;
        }
        else if(collision.collider.tag == "Roadblocks"){
            FindObjectOfType<GameMaster>().EndGame();
        }
        else if(collision.collider.tag == "Collectables"){
            FindObjectOfType<GameMaster>().Increment();
        }
    }
}
