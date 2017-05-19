using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform target;
    public float mouseChange = 0.7f;


    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        transform.position = target.position + new Vector3(0, 0, -10) + mousePosition.normalized / mouseChange;

    }
}
