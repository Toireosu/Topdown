using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    [SerializeField]
    float speed;

    Rigidbody2D rb2d;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update () {
        if (Input.GetAxisRaw("Horizontal") > 0) // Right
        {
            rb2d.velocity = new Vector3(speed * Time.deltaTime, rb2d.velocity.y);
        }
        if (Input.GetAxisRaw("Horizontal") < 0) // Left
        {
            rb2d.velocity = new Vector3(-speed * Time.deltaTime, rb2d.velocity.y);
        }
        if (Input.GetAxisRaw("Vertical") > 0) // Up
        {
            rb2d.velocity = new Vector3(rb2d.velocity.x, speed * Time.deltaTime);
        }
        if (Input.GetAxisRaw("Vertical") < 0) // Down
        {
            rb2d.velocity = new Vector3(rb2d.velocity.x, -speed * Time.deltaTime);
        }
        if (Input.GetAxisRaw("Horizontal") == 0)
        {
            rb2d.velocity = new Vector3(0, rb2d.velocity.y);
        }
        if (Input.GetAxisRaw("Vertical") == 0)
        {
            rb2d.velocity = new Vector3(rb2d.velocity.x, 0);
        }
    }
}
