using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTrigger : MonoBehaviour
{
    public GameEnd gameEnd;
    // Start is called before the first frame update
    void OnTriggerEnter(){
        gameEnd.completedLevel();
    }
}