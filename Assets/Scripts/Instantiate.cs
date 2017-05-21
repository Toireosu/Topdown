using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instantiate : MonoBehaviour
{

    public Slider healthSlider;

    private void Start()
    {
        Instantiate(healthSlider);
    }

}
