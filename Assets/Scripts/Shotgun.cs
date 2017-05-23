using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : Weapon
{

    public float pellets = 0;
    //public Transform pos3;
    //public Transform pos4;
    //Transform barrelPos2;
    [Range(0f, 100f)]
    public float spread = 80f;

    public override void Shoot(PlayerAim.Direction direction)
    {
        for (int i = 0; i < pellets; i++)
        {
            barrelPos = pos2;

            if (direction == PlayerAim.Direction.RIGHT)
            {
                barrelPos = pos1;
            }

            float randomRotation = Random.Range(-spread, spread);
            GameObject g = Instantiate(bullet, barrelPos.position, transform.rotation * Quaternion.Euler(0, 0, -randomRotation));
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
