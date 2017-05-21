using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : MonoBehaviour
{
    GrenadeThrow gtThrow;
    Vector2 grenadeDirection;
    [HideInInspector]
    public Rigidbody2D rb;

    public float lifeTime;
    public float speed;
    public GameObject explosion;

    private void Start()
    {
        SetUpGrenade(lifeTime, speed);
        StartCoroutine(ExplodeGrenadeEnum(false, lifeTime, explosion));
    }

    public void SetUpGrenade(float lifeTime, float speed)
    {
        rb = GetComponent<Rigidbody2D>();
        gtThrow = GameObject.FindGameObjectWithTag("Player").GetComponent<GrenadeThrow>();
        //Grenade Direction
        grenadeDirection = Camera.main.ScreenToWorldPoint(gtThrow.mousePosOnThrow) - transform.position;
        //Add force in direction
        rb.AddForce(grenadeDirection * speed * Time.deltaTime);
        //Explode after time
    }

    public void ExplodeGrenade(GameObject explosion)
    {
        Instantiate(explosion, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    public IEnumerator ExplodeGrenadeEnum(bool status, float delayTime, GameObject explosion)
    {
        yield return new WaitForSeconds(delayTime);
        ExplodeGrenade(explosion);
    }

}
