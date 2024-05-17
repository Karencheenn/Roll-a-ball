using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartManager : MonoBehaviour
{
    public float restartThreshold = 0f;

    // Update is called once per frame
    void Update()
    {
       if (transform.position.y < restartThreshold)
       {
        SceneManager.LoadScene("Project");
       } 
    }
}
