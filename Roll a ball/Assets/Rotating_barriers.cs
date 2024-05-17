using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotating_barriers : MonoBehaviour
{
    void Update()
    {
        transform.Rotate (new Vector3 (45, 20, 45) * (Time.deltaTime) * 7);
        
    }
}
