using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_eye : MonoBehaviour
{
    public Transform target;
    public float speed = 1;
    [SerializeField] [Range(0.0f, 60.0f)] float rotateSpeed = 5; 
    [SerializeField] [Range(0.0f, 20.0f)] float range = 5;

    bool rotateReverse = false;
    public float timeKnockedOut = 2;

    Rigidbody2D rb2d;

    float bounce = 0;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        bounce -= Time.deltaTime;
        Vector3 direction = target.position - transform.position;
        if (bounce <= 0)
        {
            rb2d.velocity = new Vector2();


            // Movement towards/away from target
            if (direction.magnitude > range)
            {
                transform.position += direction.normalized * Time.deltaTime * speed;
            }
            else if(direction.magnitude < range - 1)
            {
                transform.position -= direction.normalized * Time.deltaTime * 2 * speed;
            }

            if (rotateReverse)
            {
                transform.position += transform.up * Time.deltaTime * rotateSpeed;
            } 
            else
            {
                // Movement around target
                transform.position += -transform.up * Time.deltaTime * rotateSpeed;
            }


        }
        //Rotate towards target
        // Angle calculation
        float adjacent = target.position.x - transform.position.x;
        float opposite = target.position.y - transform.position.y;
        float angle = Mathf.Atan2(opposite, adjacent);
        angle = Mathf.Rad2Deg * angle;

        transform.rotation = Quaternion.Euler(0, 0, angle);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (bounce <= 0)
        {
            rb2d.velocity = -(collision.transform.position - transform.position).normalized * 4;
            bounce = timeKnockedOut;
            rotateReverse = !rotateReverse;
        }
    }
}
