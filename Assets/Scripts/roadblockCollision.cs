using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roadblockCollision : MonoBehaviour
{
    //public GameMaster manager;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("roadbloack collision start");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision){
        if(collision.collider.tag == "Roadblocks"){
            FindObjectOfType<GameMaster>().EndGame();
        }
    }
}
