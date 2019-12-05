using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform cube;
    public Vector3 behind;
    // Update is called once per frame
    void Update(){
        transform.position = cube.position + behind;
    }
}
