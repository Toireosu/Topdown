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

    public override void Shoot(Vector3 dir)
    {
        for (int i = 0; i < pellets; i++)
        {

            float randomRotation = Random.Range(-spread, spread);
            GameObject g = Instantiate(bullet, barrelPos.position, transform.rotation * Quaternion.Euler(0, 0, -randomRotation));
            Mover mover = g.GetComponent<Mover>();
            Vector3 dir2 = g.transform.right;
            if (dir == -transform.right)
            {
                dir2 = -g.transform.right;
            }
            mover.direction = dir2;
            mover.lifeTime = lifeTime;
        }
    }
}
