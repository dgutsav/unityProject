using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followObject : MonoBehaviour
{
    public Transform cube;
    public Vector3 behind;
    // Update is called once per frame
    void Update(){
        transform.position = cube.position + behind;
    }
}
