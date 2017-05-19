using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : Weapon {

    public float pellets = 0;
    [Range(0f, 100f)] public float spread = 80f;

    public override void Shoot(PlayerAim.Direction direction)
    {
        for (int i = 0; i < pellets; i++)
        {
            float randomRotation = Random.Range(-spread, spread);
            GameObject g = Instantiate(bullet, transform.position + offset, transform.rotation * Quaternion.Euler(0, 0, -randomRotation));
            Mover mover = g.GetComponent<Mover>();
            Vector3 dir = -g.transform.right;
            if (direction == PlayerAim.Direction.RIGHT)
            {
                dir = g.transform.right;
            }
            mover.direction = dir;
            mover.lifeTime = lifeTime;
        }
    }
}
