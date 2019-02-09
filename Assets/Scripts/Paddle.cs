using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

    public float paddleSpeed = 1;
    public float xPosLimit = 10;

    // Update is called once per frame
    void Update()
    {
        float xPos = transform.position.x + (Input.GetAxis("Horizontal") * paddleSpeed);
        transform.position = new Vector3(Mathf.Clamp(xPos, -xPosLimit, xPosLimit), transform.position.y, transform.position.z);
    }
}
