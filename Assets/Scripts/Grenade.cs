using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : MonoBehaviour
{

    GrenadeThrow gtThrow;
    Vector2 grenadeDirection;
    float speed = 10;

    private void Start()
    {
        gtThrow = GameObject.FindGameObjectWithTag("Player1").GetComponent<GrenadeThrow>();
        grenadeDirection = Camera.main.ScreenToWorldPoint(gtThrow.mousePosOnThrow) - transform.position;
        Destroy(gameObject, 10);
    }

    private void Update()
    {
        GrenadePos();
    }

    void GrenadePos()
    {
        speed *= 0.99f;
        
        transform.position += (Vector3)grenadeDirection.normalized * speed * Time.deltaTime;
        print((Vector3)grenadeDirection.normalized);
        //print(grenadeDirection);
    }
}
