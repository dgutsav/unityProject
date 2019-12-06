using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameEnd : MonoBehaviour
{
    public Text scoreText;
    public Transform obj;
    public objectMovement objectMove;
    private bool hasEnded;
    public void completedLevel(){
        Debug.Log("Completed");
    }
    void Update()
    {
        if(hasEnded){
            return;
        }
        if(obj.position.z>9.5 || obj.position.z<-9.5){
            scoreText.text = "GAME OVER";
            EndGame();
        }
        if(obj.position.x>650){
            scoreText.text = "FINAL SCORE "+scoreText.text;
            CompleteGame();
        }
    }
    public void EndGame(){
        hasEnded = true;
        objectMove.enable = false;
    }
    public void CompleteGame(){
        hasEnded = true;
        objectMove.enable = false;    
    }
}
