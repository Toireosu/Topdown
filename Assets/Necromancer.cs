using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Necromancer : MonoBehaviour
{
    public GameObject summoningCircle;
    Transform target;
    public float speed = 1;
    float time;
    public float attackTimer = 0.2f;

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
        transform.position -= direction.normalized * speed * Time.deltaTime;

        if (time > attackTimer)
        {
            Instantiate(summoningCircle, target.position, target.rotation);
            time = 0;
        }

    }
}
