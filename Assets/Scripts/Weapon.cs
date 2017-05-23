using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject bullet;
    public float Dmg;
    [Range(0.0f, 10.0f)]
    public float lifeTime;

    public Transform pos1;
    public Transform pos2;

    Transform barrelPos;

    public Vector3 offset;

    public void Fire(PlayerAim.Direction direction)
    {
        Shoot(direction);
    }

    public virtual void Shoot(PlayerAim.Direction direction)
    {
        Vector3 dir = -transform.right;
        barrelPos = pos1;
        if (direction == PlayerAim.Direction.RIGHT)
        {
            dir = transform.right;
            barrelPos = pos2;
        }
        GameObject g = Instantiate(bullet, barrelPos.position, transform.rotation);
        Mover mover = g.GetComponent<Mover>();
        mover.direction = dir;
        mover.lifeTime = lifeTime;
    }
}
