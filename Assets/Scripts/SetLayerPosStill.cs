using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetLayerPosStill : MonoBehaviour
{

    SpriteRenderer sr;
    public int order;

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.sortingOrder = ((int)(transform.position.y * 10) - order) * -1;
    }

}
