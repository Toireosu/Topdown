using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {
    [HideInInspector]
    public float lifeTime = 100; 
    public Vector3 direction;
    public float speed;

    private void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    void Update () {
        transform.position += direction * Time.deltaTime * speed;
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        Destroy(gameObject);
    }
}
