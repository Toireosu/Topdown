using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_eye : MonoBehaviour
{
    Transform target;
    public float speed = 1;
    float time;
    public float timer = 0.2f;

    // Use this for initialization
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        Vector3 direction = target.position - transform.position;

        if (direction.magnitude > 5)
        {
            transform.position += direction.normalized * Time.deltaTime * speed;

        }
        else if(direction.magnitude < 5)
        {
            transform.position -= direction.normalized * Time.deltaTime * speed;

        }


    }
}
