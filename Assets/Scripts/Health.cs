using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float maxHp;
    public float currHp;
    SpriteRenderer spriteR;
    float time;

    // Use this for initialization
    private void Start()
    {
        spriteR = GetComponent<SpriteRenderer>();
        currHp = maxHp;
    }

    // Update is called once per frame
    public void TakeDamage(int dmg)
    {
        currHp -= dmg;
        time = 0;
        spriteR.color = Color.red;

        if (gameObject.tag == "Player")
        {

        }
        else if (currHp <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void Heal(int hp)
    {
        currHp += hp;
    }

    public void Update()
    {
        time += Time.deltaTime;
        if (time > 0.1f)
        {
            spriteR.color = Color.white;
        }
    }
}
