using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetLayerOrder : MonoBehaviour
{

    SpriteRenderer sr;
    public int order;

    // Update is called once per frame

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        sr.sortingOrder = ((int)(transform.position.y * 10) - order) * -1;
        //print(sr.sortingOrder);
    }
}
