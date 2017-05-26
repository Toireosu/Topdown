using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public float lifetime;

    // Use this for initialization
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = transform.up * speed;
        Destroy(gameObject, lifetime);
        

    }

    // Update is called once per frame
    void Update()
    {

    }
}
