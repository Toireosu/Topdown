using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {
    public GameObject bullet;
    public float Dmg;
    [Range(0.0f, 10.0f)] public float lifeTime;

    public Vector3 offset;

	public void Fire(PlayerAim.Direction direction)
    {
        Shoot(direction);
    }

    public virtual void Shoot(PlayerAim.Direction direction)
    {
        Vector3 dir = -transform.right;
        if (direction == PlayerAim.Direction.RIGHT)
        {
            dir = transform.right;
        }
        GameObject g = Instantiate(bullet, transform.position + offset, transform.rotation);
        Mover mover = g.GetComponent<Mover>();
        mover.direction = dir;
        mover.lifeTime = lifeTime;
    }
}
