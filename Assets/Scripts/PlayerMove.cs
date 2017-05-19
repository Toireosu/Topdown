using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    [SerializeField]
    float speed;

	void Update () {
        if (Input.GetAxisRaw("Horizontal") > 0) // Right
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0);
        }
        if (Input.GetAxisRaw("Horizontal") < 0) // Left
        {
            transform.position += new Vector3(-speed * Time.deltaTime, 0);
        }
        if (Input.GetAxisRaw("Vertical") > 0) // Up
        {
            transform.position += new Vector3(0, speed * Time.deltaTime);
        }
        if (Input.GetAxisRaw("Vertical") < 0) // Down
        {
            transform.position += new Vector3(0, -speed * Time.deltaTime);
        }
    }
}
