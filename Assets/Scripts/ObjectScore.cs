using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectScore : MonoBehaviour
{
    public Text scoreText;
    public int score = 0; 
    
    void OnCollisionEnter(Collision collision){
        if(collision.collider.tag == "Obstacle1"){
            score++;
            scoreText.text = "SCORE: "+score.ToString();
        }
    }
    
}
