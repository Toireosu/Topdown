using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float maxHp;
    [HideInInspector]
    public float currHp;


    // Use this for initialization
    private void Start()
    {
        currHp = maxHp;
    }

    // Update is called once per frame
    public void TakeDamage(int dmg)
    {
        currHp -= dmg;
    }

    public void Heal(int hp)
    {
        currHp += hp;
    }
}
