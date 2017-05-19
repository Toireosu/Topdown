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

    // Use this for initialization
    void Start()
    {
<<<<<<< HEAD:Assets/Scripts/Necromancer.cs
        target = GameObject.FindGameObjectWithTag("Player1").transform;
=======
        target = GameObject.FindGameObjectWithTag("Player").transform;
        anim = GetComponent<Animator>();

>>>>>>> 8ae414ce2744864f24dd3f6f6d46bfaeb816558e:Assets/Scripts/Necromancer.cs
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        Vector3 direction = target.position - transform.position;
        transform.position -= direction.normalized * speed * Time.deltaTime;

        if (!attack)
        {
            attack = true;

        }

        if (time > attackTimer)
        {
            attack = false;
            Instantiate(summoningCircle, target.position, target.rotation);
            time = 0;
        }

        anim.SetBool("Summon", attack);

    }
}
