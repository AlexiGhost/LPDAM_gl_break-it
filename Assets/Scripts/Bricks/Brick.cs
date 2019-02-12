using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    public GameObject particles;

    public void DestroyBrick()
    {
        Instantiate(particles, transform.position, Quaternion.identity);
        Level.instance.DestroyBrick();
        Destroy(gameObject, 0.1f);
    }
}
