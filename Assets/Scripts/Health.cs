using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float maxHp;
    float health;


    // Use this for initialization
    void Update()
    {
        health = maxHp;
    }

    // Update is called once per frame
    public void TakeDamage(int dmg)
    {
        health -= dmg;
    }

    public void Heal(int hp)
    {
        health += hp;

    }
}
