using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followMainCube : MonoBehaviour
{
    public Transform cube;
    public Vector3 distance;
    void LateUpdate()
    {
        transform.position = cube.position + distance;
    }
}
