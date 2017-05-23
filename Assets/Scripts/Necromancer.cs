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
    Animator anim;
    bool attack = false;
    bool isAllowedToMove = false;
    public float animTime;

    // Use this for initialization
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        Vector3 direction = target.position - transform.position;

        if (time > attackTimer)
        {

            Instantiate(summoningCircle, target.position - new Vector3(0, 0.9f, 0), target.rotation);
            time = 0;
            attack = false;


        }

        else if (time < attackTimer - animTime)
        {
            transform.position -= direction.normalized * speed * Time.deltaTime;

        }

        else if (time > attackTimer - animTime)
        {
            attack = true;
        }


        anim.SetBool("Summon", attack);

    }
}
