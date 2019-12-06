using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    public float score_multiplier;
    public int score;
    public float force_multiplier;
    public bool hasEnded = false;
    void Start()
    {
        Debug.Log("Game Manager Start");    
        score_multiplier = 1f;
        score = 0;
        force_multiplier = 1f;
    }

    void Update()
    {
        
    }
    public void EndGame(){
        Debug.Log("Game Over");
        hasEnded = true;
    }
    public void Increment(){
        Debug.Log("Collected");
        score++;
        force_multiplier+=0.1f;
    }
}
