using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaziGrenade : Grenade
{
    
    //This script is for NaziGrenade (sieg heil) abilities only

    public float spinAmount;

    void Update()
    {
        //Moves the grenade towards direction
        GrenadeMovement();
    }

    void GrenadeMovement()
    {
        if (rb.velocity.magnitude < 1.5)
        {
            rb.velocity = new Vector2(0, 0);
        }

        transform.Rotate(Vector3.forward * spinAmount * rb.velocity.magnitude * Time.deltaTime);
    }
}
