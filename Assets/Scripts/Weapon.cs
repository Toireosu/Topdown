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

    [HideInInspector]
    public Transform barrelPos;

    public GameObject muzzleFlash;

    public void Fire(PlayerAim.Direction direction)
    {
        Vector3 dir = -transform.right;
        barrelPos = pos1;
        if (direction == PlayerAim.Direction.RIGHT)
        {
            dir = transform.right;
            barrelPos = pos2;
        }
        // Create the muzzle flash
        GameObject f = Instantiate(muzzleFlash, barrelPos.position, transform.rotation);
        f.transform.SetParent(barrelPos);
        Mover moverf = f.GetComponent<Mover>();
        moverf.lifeTime = 0.1f;
        if (direction == PlayerAim.Direction.RIGHT) { f.GetComponent<SpriteRenderer>().flipX = true; }
        Shoot(dir);
    }

    public virtual void Shoot(Vector3 dir)
    {
        // Create the bullet
        GameObject g = Instantiate(bullet, barrelPos.position, transform.rotation);
        Mover mover = g.GetComponent<Mover>();
        mover.direction = dir;
        mover.lifeTime = lifeTime;
    }
}
