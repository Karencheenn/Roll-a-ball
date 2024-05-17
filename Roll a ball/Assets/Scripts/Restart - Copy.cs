using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    private float fail = 0f;

    void Update()
    {
       if (transform.position.y < fail)
       {
        SceneManager.LoadScene("Mini Game");
       } 
    }
}
