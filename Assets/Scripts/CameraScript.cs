using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform target;
    public float mouseChange = 0.7f;
    bool camerachange;

    public float smoothTime = 0.3F;
    private Vector3 velocity = Vector3.zero;

    void Update()
    {
        Vector3 targetPosition = target.TransformPoint(new Vector3(0, 0, -10));
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }

    // Update is called once per frame
    //void Update()
    //{
    //    ToggleCamera();
    //    Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

    //    if (camerachange)
    //    {
    //        transform.position = target.position + new Vector3(0, 0, -10) + mousePosition.normalized / mouseChange;
    //    }
    //    if (!camerachange)
    //    {
    //        transform.position = target.position + new Vector3(0, 0, -10);
    //    }

    //}

    //void ToggleCamera()
    //{
    //    if (Input.GetKeyDown(KeyCode.K))
    //    {
    //        camerachange = !camerachange;
    //    }
    //    print(camerachange);
    //}
}
