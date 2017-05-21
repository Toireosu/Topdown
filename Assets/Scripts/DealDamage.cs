using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DealDamage : MonoBehaviour
{
    public int dmg;
    public string targetTag;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == targetTag)
        {
            other.gameObject.GetComponent<Health>().TakeDamage(dmg);
        }

    }
}
