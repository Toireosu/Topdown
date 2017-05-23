using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    [SerializeField]
    float speed;

    Rigidbody2D rb2d;
    Animator anim;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        SetPos2DENNAFUNGERAR();
    }

    void SetPos1()
    {
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

    void SetPos2DENNAFUNGERAR()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        Vector2 movement = new Vector2(x, y);

        if (x != 0 || y != 0)
        {
            anim.SetBool("Walking", true);
        }
        else
        {
            anim.SetBool("Walking", false);
        }

        rb2d.velocity = movement.normalized * speed;
    }

    void SetPos3()
    {
        if (Input.GetAxisRaw("Horizontal") > 0) // Right
        {
            transform.position += new Vector3(1, 0) * speed * Time.deltaTime;
        }
        if (Input.GetAxisRaw("Horizontal") < 0) // Left
        {
            transform.position += new Vector3(-1, 0) * speed * Time.deltaTime;
        }
        if (Input.GetAxisRaw("Vertical") > 0) // Up
        {
            transform.position += new Vector3(0, 1) * speed * Time.deltaTime;
        }
        if (Input.GetAxisRaw("Vertical") < 0) // Down
        {
            transform.position += new Vector3(0, -1) * speed * Time.deltaTime;
        }
    }
}
