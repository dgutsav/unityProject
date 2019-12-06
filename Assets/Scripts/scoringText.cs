using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoringText : MonoBehaviour
{
    public Text scoreText;
    public GameMaster master;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "SCORE: "+ master.score.ToString();
    }
}
