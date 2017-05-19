using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Summon : MonoBehaviour
{
    public GameObject lightning;
    public GameObject skeleton;
    float time;
    public float timer;
    public float spawndelay;
    bool oneAttack = false;
    GameObject i;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (timer < time && oneAttack == false)
        {
            i = Instantiate(lightning, transform.position, transform.rotation);
            oneAttack = true;

        }

        if (timer < time - spawndelay)
        {
            Instantiate(skeleton, transform.position, transform.rotation);
            Destroy(i);
            Destroy(gameObject);
        }

    }
}
