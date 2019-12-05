using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public Text scoreText;
    public Transform obj;
    private int score = 0;
    void Awake(){
        scoreText.text = " 0 ";
    }

    void Update(){
        scoreText.text = obj.position.x.ToString();
    }
    void OnCollisionEnter(Collision collision){
        /* if(collision.collider.tag == "Obstacle1"){            
            score++;
            scoreText.text = score + "";
        }*/
        score++;
        scoreText.text = score + "";
    }
}
