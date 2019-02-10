using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    private float ballInitialVelocity = 500f;

    private Rigidbody rb;
    private bool launched;

    // Start is called before the first frame update
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1") && !launched)
        {
            transform.parent = null;
            launched = true;
            rb.isKinematic = false;
            rb.AddForce(new Vector3(ballInitialVelocity, ballInitialVelocity, 0));
        }
    }

    public void OnCollisionEnter(Collision other)
    {
        if (other.transform.CompareTag("brick"))
        {
            other.transform.GetComponent<Brick>().DestroyBrick();
        }
    }
}
