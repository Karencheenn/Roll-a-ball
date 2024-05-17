using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floating : MonoBehaviour
{

    public float speed = 5.0f;

    public float height = 0.5f;

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        float newY = Mathf.Abs(Mathf.Sin(Time.time * speed));
        transform.position = new Vector3(pos.x, newY, pos.z) * height;
    }
}
