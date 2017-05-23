using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleAI : MonoBehaviour {

    public Transform target;
    public float speed;
	
	void Update () {
        Vector3 direction = (target.position - transform.position).normalized;
        transform.position += direction * Time.deltaTime * speed;
	}
}
