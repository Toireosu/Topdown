using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_eye : MonoBehaviour
{
    public Transform target;
    public float speed = 1;
    float time;
    public float timer = 0.2f;

    bool backing = false;
    [SerializeField][Range(0.0f, 20.0f)] float range = 5;
    [SerializeField][Range(0.0f, 20.0f)] float rotateSpeed = 3;

    private void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        Vector3 direction = target.position - transform.position;



        
        // Movement 
        if (direction.magnitude > range)
        {
            transform.position += direction.normalized * Time.deltaTime * speed;
        }
        else if (direction.magnitude < range - 1)
        {
            transform.position -= direction.normalized * Time.deltaTime * 2 * speed;
        }

        transform.position -= transform.up * Time.deltaTime * rotateSpeed;

        // Rotate towards player
        // Rotation calculation
        float adjacent = target.position.x - transform.position.x;
        float opposite = target.position.y - transform.position.y;
        float angle = Mathf.Atan2(opposite, adjacent);
        angle = Mathf.Rad2Deg * angle;
        transform.rotation = Quaternion.Euler(0, 0, angle);

    }
}
